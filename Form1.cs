using System;
using System.IO;
using System.IO.Ports;
using System.Net.Mail;
using System.Reflection.Emit;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace Bootloader_v1._0
{
    public partial class Form1 : Form
    {

        const byte UART_BOOTMODE_ACK = 41;
        const byte UART_BOOTMODE_NACK = 42;
        const byte UART_TAKE_BOOTMODE_COMMAND = 43;
        const byte UART_FLASH_SIZE_CHECK_COMMAND = 44;
        const byte UART_SEND_BYTE_COMMAND = 45;
        const byte SYSTEM_RESET_COMMAND = 46;

        enum programStatus_t
        {
            STANDBY_MODE=0,
            BOOT_MODE,
            FLASHING_MODE
        }

        programStatus_t programStatus;

        String receivedData;
        byte[] fileBytes;
        Int64 ackCounter = -2;

        private CancellationTokenSource cancellationTokenSource;
        private Task programTask;

        public Form1()
        {
            InitializeComponent();

            comboBaudrate.SelectedIndex = 3;
            lblProgramStatus1.Text = Convert.ToString(programStatus);
            lblProgramStatus2.Text = Convert.ToString(programStatus);

            foreach (string s in SerialPort.GetPortNames())
                comboComPort.Items.Add(s);
    
            if (comboComPort.Items.Count > 0)
                comboComPort.SelectedIndex = 0;

        }

        #region "Butons"

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.BaudRate = Convert.ToInt32(comboBaudrate.SelectedItem);
                serialPort1.Parity = Parity.None;
                serialPort1.PortName = comboComPort.SelectedItem.ToString();
                serialPort1.DataBits = 8;
                serialPort1.StopBits = StopBits.One;
                serialPort1.Open();

                serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);

                if (serialPort1.IsOpen)
                {
                    tabControl1.SelectedTab = bootloaderTab;
                    MessageBox.Show("Bağlantı sağlandı");                   
                }
                    
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();
                    MessageBox.Show("Bağlantı Kesildi");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnTakeBootMode_Click(object sender, EventArgs e)
        {
            ackCounter = -2;
            bootModeCheck_Timer.Start();

            byte[] sendMessage = new byte[3];

            sendMessage[0] = UART_TAKE_BOOTMODE_COMMAND;
            sendMessage[1] = 0x41;
            int checkSum = calculateCheckSum(sendMessage[0], sendMessage[1]);
            sendMessage[2] = (byte)checkSum;


            if (serialPort1.IsOpen)
            {
                serialPort1.Write(sendMessage,0,3);
            }

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            String filePath = OpenBinFileDialog();

            if(!String.IsNullOrEmpty(filePath) && !String.IsNullOrEmpty(filePath))
            {
                txtBoxFilePath.Text = filePath;
                getBinFile(filePath);
            }
            else
            {
                MessageBox.Show("Lütfen yüklemek istediğiniz dosya yolunu tekrar seçiniz.",caption:"Dosya Yolu Seçimi Bilgilendirme",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void btnProgram_Click(object sender, EventArgs e)
        {
            if(programStatus == programStatus_t.BOOT_MODE)
            {
                cancellationTokenSource = new CancellationTokenSource();
                var token = cancellationTokenSource.Token;

                try
                {

                    programTask = Task.Run(async () => await programTaskFunction(token), token);

                    await programTask;

                }
                catch (OperationCanceledException)
                {


                }
            }
            
        }

        private void btnResetSystem_Click(object sender, EventArgs e)
        {
            if (programStatus == programStatus_t.BOOT_MODE)
            {
                byte[] sendMessage = new byte[3];

                sendMessage[0] = SYSTEM_RESET_COMMAND;
                sendMessage[1] = 0x01;
                int checkSum = calculateCheckSum(sendMessage[0], sendMessage[1]);
                sendMessage[2] = (byte)checkSum;

                if (serialPort1.IsOpen)
                {
                    serialPort1.Write(sendMessage, 0, 3);
                }
            }          
        }

        #endregion

        #region "Özel Fonksiyonlar"

        public int calculateCheckSum(int firstByte, int secondByte)
        {
            int checkSum_Value = (firstByte + secondByte) / 2;
            return checkSum_Value;
        }

        public string OpenBinFileDialog()
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Bin dosyaları (*.bin)|*.bin";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                return openFileDialog.FileName;
            }

            return null;
        }

        public void getBinFile(string filePath)
        {
            try
            {
                fileBytes = File.ReadAllBytes(filePath);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Dosya okuma hatası: " + ex.Message);
            }
        }

        #endregion

        #region "Bootloader"

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    receivedData = serialPort1.ReadLine();

                    if (txtBoxReceivedData.InvokeRequired)
                    {
                        txtBoxReceivedData.Invoke(new Action(delegate ()
                        {
                            if(receivedData == ")")
                            {
                                txtBoxReceivedData.Text = "ACK";
                            }
                            else if(receivedData == "*")
                            {
                                txtBoxReceivedData.Text = "NACK";
                            }
                            else
                            {
                                txtBoxReceivedData.Text = receivedData;
                            }
                            

                        }));
                    }

                    if (receivedData == ")")
                    {
                        ackCounter++;
                    }
                }
                catch (IOException ex)
                {

                    MessageBox.Show($"{ex.Message}");
                }
            }

        }

        private async Task programTaskFunction(CancellationToken token)
        {

            programStatus = programStatus_t.FLASHING_MODE;

            lblProgramStatus1.Invoke(new Action(delegate ()
            {
                lblProgramStatus1.Text = Convert.ToString(programStatus);

            }));

            lblProgramStatus2.Invoke(new Action(delegate ()
            {
                lblProgramStatus2.Text = Convert.ToString(programStatus);

            }));

            while (true)
            {
                token.ThrowIfCancellationRequested();

                byte[] sendBuffer = new byte[3];
                int fileSize = fileBytes.Length;
                byte[] fileSizeByte = new byte[4];

                progressBar.Invoke(new Action(delegate ()
                {
                    progressBar.Step = 1;
                    progressBar.Maximum = fileSize;
                    progressBar.Minimum = 0;
                    progressBar.Value = 0;

                }));

                fileSizeByte[0] = (byte)(fileSize & 0xFF);
                fileSizeByte[1] = (byte)((fileSize >> 8) & 0xFF);
                fileSizeByte[2] = (byte)((fileSize >> 16) & 0xFF);
                fileSizeByte[3] = (byte)((fileSize >> 24) & 0xFF);

                for (int i = 0; i < 4; i++)
                {
                    sendBuffer[0] = UART_FLASH_SIZE_CHECK_COMMAND;
                    sendBuffer[1] = fileSizeByte[i];
                    sendBuffer[2] = Convert.ToByte(calculateCheckSum(sendBuffer[0], sendBuffer[1]));

                    serialPort1.Write(sendBuffer, 0, 3);

                    await Task.Delay(200);
                }

                while (receivedData != ")") ;
                receivedData = "";

                for (int i = 0; i < fileBytes.Length; i++)
                {
                    sendBuffer[0] = UART_SEND_BYTE_COMMAND;
                    sendBuffer[1] = fileBytes[i];
                    sendBuffer[2] = Convert.ToByte(calculateCheckSum(sendBuffer[0], sendBuffer[1]));

                    serialPort1.Write(sendBuffer, 0, 3);

                    progressBar.Invoke(new Action(delegate ()
                    {
                        progressBar.Value += 1;

                    }));

                    await Task.Delay(1);
                }

                if (ackCounter == fileSize)
                {
                    MessageBox.Show("Program Başarılı Şekilde Yüklenmiştir.", caption: "Program Yükleme Durumu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ackCounter = -2;
                    programStatus = programStatus_t.BOOT_MODE;

                    lblProgramStatus1.Invoke(new Action(delegate ()
                    {
                        lblProgramStatus1.Text = Convert.ToString(programStatus);

                    }));

                    lblProgramStatus2.Invoke(new Action(delegate ()
                    {
                        lblProgramStatus2.Text = Convert.ToString(programStatus);

                    }));
                }
                else
                {
                    MessageBox.Show("Program Yükleme Başarısız Olmuştur. Lütfen Tekrardan Deneyiniz.", caption: "Program Yükleme Durumu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ackCounter = -2;
                }

                if (programTask != null && !programTask.IsCompleted)
                {
                    cancellationTokenSource.Cancel();
                }

            }

        }

        #endregion

        #region "Form Timers"
        private void bootModeCheck_Timer_Tick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                if (receivedData == ")")
                {
                    programStatus = programStatus_t.BOOT_MODE;

                    lblProgramStatus1.Text = Convert.ToString(programStatus);
                    lblProgramStatus2.Text = Convert.ToString(programStatus);

                    btnProgram.Enabled = true;
                    btnResetSystem.Enabled = true;

                    bootModeCheck_Timer.Enabled = false;
                    bootModeCheck_Timer.Stop();
                    MessageBox.Show("mCU Boot Moduna Girmiştir.",caption:"Boot Mode Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }

            }
        }

        #endregion

        #region "Form Events"

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Close();

                    if (programTask != null && !programTask.IsCompleted)
                    {
                        cancellationTokenSource.Cancel();
                    }

                }
                catch (IOException)
                {
                    
                }

            }
        }

        #endregion

    }
}


