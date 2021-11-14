using JCS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Linq;
using Microsoft.Win32;
using System.IO;
using System.Drawing.Text;
using DocumentFormat.OpenXml.CustomProperties;

namespace GetPcDetails
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void ButtonsOff()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
        }
        private void ButtonsOn()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            if (listBox1.Items.Count != 0)
            {
                button3.Enabled = true;
            }
        }
        private void textBoxAdd(string name, string funcResult)
        {
            textBox1.AppendText(name + Environment.NewLine + funcResult + Environment.NewLine);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.RightToLeft = RightToLeft.Yes;
            ButtonsOff();
            listBox1.Items.Add("פרטי משתמש:");
            listBox1.Items.Add("");
            listBox1.Items.Add("שם מחשב:  " + Environment.MachineName);
            listBox1.Items.Add("שם משתמש נוכחי:  " + Environment.UserName);
            listBox1.Items.Add("");
            listBox1.Items.Add("רשימת משתמשים: ");
            listBox1.Items.Add("");
            string[] listOfUsers = HardwareInfo.GetUsersList();
            foreach (string user in listOfUsers)
            {
                listBox1.Items.Add(user);

            }
            listBox1.Items.Add("");
            listBox1.Items.Add("פרטי מחשב:");
            listBox1.Items.Add("");
            listBox1.Items.Add("גירסת מערכת ההפעלה:  " + HardwareInfo.GetOSInformation());
            listBox1.Items.Add("זכרון ראם (זכרון פנימי -רץ):  " + HardwareInfo.GetPhysicalMemory());
            listBox1.Items.Add("דגם המעבד:  " + HardwareInfo.GetProcessorInformation());
            listBox1.Items.Add("מספר ליבות במעבד:  " + Environment.ProcessorCount);
            listBox1.Items.Add("מהירות מעבד:  " + HardwareInfo.GetCpuSpeedInGHz());
            listBox1.Items.Add("יצרן לוח אם:  " + HardwareInfo.GetBoardMaker());
            listBox1.Items.Add("דגם לוח אם:  " + HardwareInfo.GetBoardProductId());
            listBox1.Items.Add("");
            ButtonsOn();
        }



        private void אודותToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 a = new AboutBox1();
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ButtonsOff();
            listBox1.Items.Clear();
            listBox1.RightToLeft = RightToLeft.No;
            int programCounter = 0;
            string[] softwareList = HardwareInfo.GetSoftwareList();
            Array.Sort(softwareList);
            foreach (string software in softwareList)
            {
                listBox1.Items.Add(software);
                programCounter++;
            }
            listBox1.Items.Add("");
            listBox1.Items.Add("סך הכל " + programCounter + " תוכנות מותקנות במחשב");
            ButtonsOn();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            // set a default file name
            savefile.FileName = "list.txt";
            // set filters - this can be done in properties as well
            savefile.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                StreamWriter SavedFile = new StreamWriter(savefile.FileName);
                foreach (var item in listBox1.Items)
                {
                    SavedFile.WriteLine(item);
                }
                SavedFile.ToString();
                SavedFile.Close();
                MessageBox.Show("הקובץ נשמר בהצלחה במיקום שבחרתם!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            button3.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.RightToLeft = RightToLeft.No;
            listBox1.Items.Clear();
            ButtonsOff();
            DirectoryInfo dirinfo = new DirectoryInfo("C:\\Windows\\Fonts");
            FileInfo[] fonts = dirinfo.GetFiles();

            foreach (FileInfo font in fonts)
            {
                listBox1.Items.Add(font.Name);
            }
            ButtonsOn();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.RightToLeft = RightToLeft.Yes;
            ButtonsOff();

            try
            {
                if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
                {
                    IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
                    string ipAddress = Convert.ToString(ipHostInfo.AddressList.FirstOrDefault(address => address.AddressFamily == AddressFamily.InterNetwork));

                    listBox1.Items.Add("מחובר לרשת");
                    listBox1.Items.Add("כתובת IP פנימית: " + ipAddress);
                    listBox1.Items.Add("כתובת IP חיצונית: " + HardwareInfo.GetIPAddress());
                    for (int i = 0; i < 4; i++)
                    {
                        listBox1.Items.Add("");
                    }

                }
                else
                {
                    listBox1.Items.Add("לא מחובר לרשת");
                }
            }
            catch
            {
                MessageBox.Show("אירעה שגיאה בלתי צפויה!");
            }
            finally {
                listBox1.Items.Add("פרטי חיבור מתקדם:");
                listBox1.Items.Add("(מוצג בשורה אחת לצורך שמירה בקובץ)");
                listBox1.Items.Add(HardwareInfo.GetIpConfig());
            }
            ButtonsOn();

        }

        public void InitCustomLabelFont()
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            int fontLength = GetPcDetails.Properties.Resources.FbEleganti_Bold.Length;


            PrivateFontCollection modernFont = new PrivateFontCollection();

            modernFont.AddFontFile("FBELEGANTI-BOLD.OTF");
            modernFont.AddFontFile("FBELEGANTI-MEDIUM.OTF");
            modernFont.AddFontFile("FBELEGANTI-REGULAR.OTF");
            modernFont.AddFontFile("PFT_FRANK BOLD.TTF");
            modernFont.AddFontFile("PFT_FRANK.TTF");
        }

        private void GetProcessorIdBtn_Click(object sender, EventArgs e)
        {
            textBoxAdd("ID מעבד: ", HardwareInfo.GetProcessorId());
        }

        private void GetHDDSerialNoBtn_Click(object sender, EventArgs e)
        {
            textBoxAdd("HDD סיריאל: ", HardwareInfo.GetHDDSerialNo());
        }

        private void GetMACAddressBtn_Click(object sender, EventArgs e)
        {
            textBoxAdd("כתובת MAC: ", HardwareInfo.GetMACAddress());
        }

        private void GetBoardMakerBtn_Click(object sender, EventArgs e)
        {
            textBoxAdd("יצרן הלוח אם: ", HardwareInfo.GetBoardMaker());
        }

        private void GetBoardProductIdBtn_Click(object sender, EventArgs e)
        {
            textBoxAdd("דגם הלוח אם: ", HardwareInfo.GetBoardProductId());
        }

        private void GetBIOSmakerBtn_Click(object sender, EventArgs e)
        {
            textBoxAdd("יצרן BIOS: ", HardwareInfo.GetBIOSmaker());
        }

        private void GetBIOSserNoBtn_Click(object sender, EventArgs e)
        {
            textBoxAdd("BIOS סיריאל: ", HardwareInfo.GetBIOSserNo());
        }

        private void GetAccountNameBtn_Click(object sender, EventArgs e)
        {
            textBoxAdd("שם משתמש נוכחי: ", Environment.UserName);
        }

        private void GetPhysicalMemoryBtn_Click(object sender, EventArgs e)
        {
            textBoxAdd("כמות זכרון ראם : ", HardwareInfo.GetPhysicalMemory());
        }

        private void GetCPUManufacturerBtn_Click(object sender, EventArgs e)
        {
            textBoxAdd("יצרן המעבד : ", HardwareInfo.GetCPUManufacturer());
        }

        private void GetCpuSpeedInGHzBtn_Click(object sender, EventArgs e)
        {
            textBoxAdd("מהירות המעבד : ", HardwareInfo.GetCpuSpeedInGHz().ToString());
        }

        private void GetOSInformationBtn_Click(object sender, EventArgs e)
        {
            textBoxAdd("פרטי מערכת ההפעלה : ", HardwareInfo.GetOSInformation());
        }

        private void GetProcessorInformationBtn_Click(object sender, EventArgs e)
        {
            textBoxAdd("פרטי המעבד : ", HardwareInfo.GetProcessorInformation());
        }

        private void MachineNameBtn_Click(object sender, EventArgs e)
        {
            textBoxAdd("שם מחשב : ", Environment.MachineName);
        }

        private void ipconfigBtn_Click(object sender, EventArgs e)
        {
            textBox1.RightToLeft = RightToLeft.No;
            textBox1.AppendText(HardwareInfo.GetIpConfig() + Environment.NewLine);
        }

        private void pingGoogleBtn_Click(object sender, EventArgs e)
        {
            textBox1.RightToLeft = RightToLeft.No;
            textBox1.AppendText(HardwareInfo.PingGoogle() + Environment.NewLine);
        }

        private void clearTextBoxBtn_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void rightToLeft_Click(object sender, EventArgs e)
        {
            textBox1.RightToLeft = RightToLeft.Yes;
        }
    }

}
