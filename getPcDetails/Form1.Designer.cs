namespace GetPcDetails
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.אודותToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rightToLeftBtn = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.clearTextBoxBtn = new System.Windows.Forms.Button();
            this.GetProcessorIdBtn = new System.Windows.Forms.Button();
            this.GetHDDSerialNoBtn = new System.Windows.Forms.Button();
            this.GetMACAddressBtn = new System.Windows.Forms.Button();
            this.GetBoardMakerBtn = new System.Windows.Forms.Button();
            this.GetBoardProductIdBtn = new System.Windows.Forms.Button();
            this.GetBIOSmakerBtn = new System.Windows.Forms.Button();
            this.GetBIOSserNoBtn = new System.Windows.Forms.Button();
            this.GetAccountNameBtn = new System.Windows.Forms.Button();
            this.GetPhysicalMemoryBtn = new System.Windows.Forms.Button();
            this.GetCPUManufacturerBtn = new System.Windows.Forms.Button();
            this.GetCpuSpeedInGHzBtn = new System.Windows.Forms.Button();
            this.GetOSInformationBtn = new System.Windows.Forms.Button();
            this.GetProcessorInformationBtn = new System.Windows.Forms.Button();
            this.MachineNameBtn = new System.Windows.Forms.Button();
            this.ipconfigBtn = new System.Windows.Forms.Button();
            this.pingGoogleBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rightToLeft = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.rightToLeftBtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.אודותToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // אודותToolStripMenuItem
            // 
            this.אודותToolStripMenuItem.Name = "אודותToolStripMenuItem";
            resources.ApplyResources(this.אודותToolStripMenuItem, "אודותToolStripMenuItem");
            this.אודותToolStripMenuItem.Click += new System.EventHandler(this.אודותToolStripMenuItem_Click);
            // 
            // listBox1
            // 
            resources.ApplyResources(this.listBox1, "listBox1");
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Name = "listBox1";
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            resources.ApplyResources(this.button4, "button4");
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            resources.ApplyResources(this.button5, "button5");
            this.button5.Name = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Name = "label3";
            // 
            // button6
            // 
            resources.ApplyResources(this.button6, "button6");
            this.button6.Name = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.rightToLeftBtn);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button6);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Controls.Add(this.button2);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rightToLeftBtn
            // 
            this.rightToLeftBtn.Controls.Add(this.label2);
            this.rightToLeftBtn.Controls.Add(this.label1);
            this.rightToLeftBtn.Controls.Add(this.pingGoogleBtn);
            this.rightToLeftBtn.Controls.Add(this.GetAccountNameBtn);
            this.rightToLeftBtn.Controls.Add(this.ipconfigBtn);
            this.rightToLeftBtn.Controls.Add(this.GetBIOSserNoBtn);
            this.rightToLeftBtn.Controls.Add(this.MachineNameBtn);
            this.rightToLeftBtn.Controls.Add(this.GetBIOSmakerBtn);
            this.rightToLeftBtn.Controls.Add(this.GetProcessorInformationBtn);
            this.rightToLeftBtn.Controls.Add(this.GetBoardProductIdBtn);
            this.rightToLeftBtn.Controls.Add(this.GetOSInformationBtn);
            this.rightToLeftBtn.Controls.Add(this.GetBoardMakerBtn);
            this.rightToLeftBtn.Controls.Add(this.GetCpuSpeedInGHzBtn);
            this.rightToLeftBtn.Controls.Add(this.GetMACAddressBtn);
            this.rightToLeftBtn.Controls.Add(this.GetCPUManufacturerBtn);
            this.rightToLeftBtn.Controls.Add(this.GetHDDSerialNoBtn);
            this.rightToLeftBtn.Controls.Add(this.GetPhysicalMemoryBtn);
            this.rightToLeftBtn.Controls.Add(this.GetProcessorIdBtn);
            this.rightToLeftBtn.Controls.Add(this.rightToLeft);
            this.rightToLeftBtn.Controls.Add(this.clearTextBoxBtn);
            this.rightToLeftBtn.Controls.Add(this.textBox1);
            resources.ApplyResources(this.rightToLeftBtn, "rightToLeftBtn");
            this.rightToLeftBtn.Name = "rightToLeftBtn";
            this.rightToLeftBtn.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // clearTextBoxBtn
            // 
            resources.ApplyResources(this.clearTextBoxBtn, "clearTextBoxBtn");
            this.clearTextBoxBtn.Name = "clearTextBoxBtn";
            this.clearTextBoxBtn.UseVisualStyleBackColor = true;
            this.clearTextBoxBtn.Click += new System.EventHandler(this.clearTextBoxBtn_Click);
            // 
            // GetProcessorIdBtn
            // 
            resources.ApplyResources(this.GetProcessorIdBtn, "GetProcessorIdBtn");
            this.GetProcessorIdBtn.Name = "GetProcessorIdBtn";
            this.GetProcessorIdBtn.UseVisualStyleBackColor = true;
            this.GetProcessorIdBtn.Click += new System.EventHandler(this.GetProcessorIdBtn_Click);
            // 
            // GetHDDSerialNoBtn
            // 
            resources.ApplyResources(this.GetHDDSerialNoBtn, "GetHDDSerialNoBtn");
            this.GetHDDSerialNoBtn.Name = "GetHDDSerialNoBtn";
            this.GetHDDSerialNoBtn.UseVisualStyleBackColor = true;
            this.GetHDDSerialNoBtn.Click += new System.EventHandler(this.GetHDDSerialNoBtn_Click);
            // 
            // GetMACAddressBtn
            // 
            resources.ApplyResources(this.GetMACAddressBtn, "GetMACAddressBtn");
            this.GetMACAddressBtn.Name = "GetMACAddressBtn";
            this.GetMACAddressBtn.UseVisualStyleBackColor = true;
            this.GetMACAddressBtn.Click += new System.EventHandler(this.GetMACAddressBtn_Click);
            // 
            // GetBoardMakerBtn
            // 
            resources.ApplyResources(this.GetBoardMakerBtn, "GetBoardMakerBtn");
            this.GetBoardMakerBtn.Name = "GetBoardMakerBtn";
            this.GetBoardMakerBtn.UseVisualStyleBackColor = true;
            this.GetBoardMakerBtn.Click += new System.EventHandler(this.GetBoardMakerBtn_Click);
            // 
            // GetBoardProductIdBtn
            // 
            resources.ApplyResources(this.GetBoardProductIdBtn, "GetBoardProductIdBtn");
            this.GetBoardProductIdBtn.Name = "GetBoardProductIdBtn";
            this.GetBoardProductIdBtn.UseVisualStyleBackColor = true;
            this.GetBoardProductIdBtn.Click += new System.EventHandler(this.GetBoardProductIdBtn_Click);
            // 
            // GetBIOSmakerBtn
            // 
            resources.ApplyResources(this.GetBIOSmakerBtn, "GetBIOSmakerBtn");
            this.GetBIOSmakerBtn.Name = "GetBIOSmakerBtn";
            this.GetBIOSmakerBtn.UseVisualStyleBackColor = true;
            this.GetBIOSmakerBtn.Click += new System.EventHandler(this.GetBIOSmakerBtn_Click);
            // 
            // GetBIOSserNoBtn
            // 
            resources.ApplyResources(this.GetBIOSserNoBtn, "GetBIOSserNoBtn");
            this.GetBIOSserNoBtn.Name = "GetBIOSserNoBtn";
            this.GetBIOSserNoBtn.UseVisualStyleBackColor = true;
            this.GetBIOSserNoBtn.Click += new System.EventHandler(this.GetBIOSserNoBtn_Click);
            // 
            // GetAccountNameBtn
            // 
            resources.ApplyResources(this.GetAccountNameBtn, "GetAccountNameBtn");
            this.GetAccountNameBtn.Name = "GetAccountNameBtn";
            this.GetAccountNameBtn.UseVisualStyleBackColor = true;
            this.GetAccountNameBtn.Click += new System.EventHandler(this.GetAccountNameBtn_Click);
            // 
            // GetPhysicalMemoryBtn
            // 
            resources.ApplyResources(this.GetPhysicalMemoryBtn, "GetPhysicalMemoryBtn");
            this.GetPhysicalMemoryBtn.Name = "GetPhysicalMemoryBtn";
            this.GetPhysicalMemoryBtn.UseVisualStyleBackColor = true;
            this.GetPhysicalMemoryBtn.Click += new System.EventHandler(this.GetPhysicalMemoryBtn_Click);
            // 
            // GetCPUManufacturerBtn
            // 
            resources.ApplyResources(this.GetCPUManufacturerBtn, "GetCPUManufacturerBtn");
            this.GetCPUManufacturerBtn.Name = "GetCPUManufacturerBtn";
            this.GetCPUManufacturerBtn.UseVisualStyleBackColor = true;
            this.GetCPUManufacturerBtn.Click += new System.EventHandler(this.GetCPUManufacturerBtn_Click);
            // 
            // GetCpuSpeedInGHzBtn
            // 
            resources.ApplyResources(this.GetCpuSpeedInGHzBtn, "GetCpuSpeedInGHzBtn");
            this.GetCpuSpeedInGHzBtn.Name = "GetCpuSpeedInGHzBtn";
            this.GetCpuSpeedInGHzBtn.UseVisualStyleBackColor = true;
            this.GetCpuSpeedInGHzBtn.Click += new System.EventHandler(this.GetCpuSpeedInGHzBtn_Click);
            // 
            // GetOSInformationBtn
            // 
            resources.ApplyResources(this.GetOSInformationBtn, "GetOSInformationBtn");
            this.GetOSInformationBtn.Name = "GetOSInformationBtn";
            this.GetOSInformationBtn.UseVisualStyleBackColor = true;
            this.GetOSInformationBtn.Click += new System.EventHandler(this.GetOSInformationBtn_Click);
            // 
            // GetProcessorInformationBtn
            // 
            resources.ApplyResources(this.GetProcessorInformationBtn, "GetProcessorInformationBtn");
            this.GetProcessorInformationBtn.Name = "GetProcessorInformationBtn";
            this.GetProcessorInformationBtn.UseVisualStyleBackColor = true;
            this.GetProcessorInformationBtn.Click += new System.EventHandler(this.GetProcessorInformationBtn_Click);
            // 
            // MachineNameBtn
            // 
            resources.ApplyResources(this.MachineNameBtn, "MachineNameBtn");
            this.MachineNameBtn.Name = "MachineNameBtn";
            this.MachineNameBtn.UseVisualStyleBackColor = true;
            this.MachineNameBtn.Click += new System.EventHandler(this.MachineNameBtn_Click);
            // 
            // ipconfigBtn
            // 
            resources.ApplyResources(this.ipconfigBtn, "ipconfigBtn");
            this.ipconfigBtn.Name = "ipconfigBtn";
            this.ipconfigBtn.UseVisualStyleBackColor = true;
            this.ipconfigBtn.Click += new System.EventHandler(this.ipconfigBtn_Click);
            // 
            // pingGoogleBtn
            // 
            resources.ApplyResources(this.pingGoogleBtn, "pingGoogleBtn");
            this.pingGoogleBtn.Name = "pingGoogleBtn";
            this.pingGoogleBtn.UseVisualStyleBackColor = true;
            this.pingGoogleBtn.Click += new System.EventHandler(this.pingGoogleBtn_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // rightToLeft
            // 
            resources.ApplyResources(this.rightToLeft, "rightToLeft");
            this.rightToLeft.Name = "rightToLeft";
            this.rightToLeft.UseVisualStyleBackColor = true;
            this.rightToLeft.Click += new System.EventHandler(this.rightToLeft_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.rightToLeftBtn.ResumeLayout(false);
            this.rightToLeftBtn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem אודותToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage rightToLeftBtn;
        private System.Windows.Forms.Button pingGoogleBtn;
        private System.Windows.Forms.Button GetAccountNameBtn;
        private System.Windows.Forms.Button ipconfigBtn;
        private System.Windows.Forms.Button GetBIOSserNoBtn;
        private System.Windows.Forms.Button MachineNameBtn;
        private System.Windows.Forms.Button GetBIOSmakerBtn;
        private System.Windows.Forms.Button GetProcessorInformationBtn;
        private System.Windows.Forms.Button GetBoardProductIdBtn;
        private System.Windows.Forms.Button GetOSInformationBtn;
        private System.Windows.Forms.Button GetBoardMakerBtn;
        private System.Windows.Forms.Button GetCpuSpeedInGHzBtn;
        private System.Windows.Forms.Button GetMACAddressBtn;
        private System.Windows.Forms.Button GetCPUManufacturerBtn;
        private System.Windows.Forms.Button GetHDDSerialNoBtn;
        private System.Windows.Forms.Button GetPhysicalMemoryBtn;
        private System.Windows.Forms.Button GetProcessorIdBtn;
        private System.Windows.Forms.Button clearTextBoxBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button rightToLeft;
    }
}

