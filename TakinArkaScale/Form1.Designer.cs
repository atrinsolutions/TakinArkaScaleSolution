namespace TakinArkaScale
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.appSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOMPORTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOM1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOM2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOM3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOM4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOM5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bAUDRATEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.tCPPORT1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tCPPORT2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbWeight = new System.Windows.Forms.Label();
            this.lbTare = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblConnection = new System.Windows.Forms.Label();
            this.zero = new System.Windows.Forms.Button();
            this.clearTare = new System.Windows.Forms.Button();
            this.tare = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.zeroLed = new System.Windows.Forms.Label();
            this.netLed = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.stbLed = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipText = "Scale Notifier";
            this.notifyIcon.BalloonTipTitle = "Takin Arka";
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Takin Scale Notifier";
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.appSettingToolStripMenuItem,
            this.exitApplicationToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(112, 48);
            // 
            // appSettingToolStripMenuItem
            // 
            this.appSettingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cOMPORTToolStripMenuItem,
            this.bAUDRATEToolStripMenuItem,
            this.tCPPORT1ToolStripMenuItem,
            this.tCPPORT2ToolStripMenuItem});
            this.appSettingToolStripMenuItem.Name = "appSettingToolStripMenuItem";
            this.appSettingToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.appSettingToolStripMenuItem.Text = "Setting";
            // 
            // cOMPORTToolStripMenuItem
            // 
            this.cOMPORTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cOM1ToolStripMenuItem,
            this.cOM2ToolStripMenuItem,
            this.cOM3ToolStripMenuItem,
            this.cOM4ToolStripMenuItem,
            this.cOM5ToolStripMenuItem});
            this.cOMPORTToolStripMenuItem.Name = "cOMPORTToolStripMenuItem";
            this.cOMPORTToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.cOMPORTToolStripMenuItem.Text = "COM PORT";
            // 
            // cOM1ToolStripMenuItem
            // 
            this.cOM1ToolStripMenuItem.Name = "cOM1ToolStripMenuItem";
            this.cOM1ToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.cOM1ToolStripMenuItem.Text = "COM1";
            // 
            // cOM2ToolStripMenuItem
            // 
            this.cOM2ToolStripMenuItem.Name = "cOM2ToolStripMenuItem";
            this.cOM2ToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.cOM2ToolStripMenuItem.Text = "COM2";
            // 
            // cOM3ToolStripMenuItem
            // 
            this.cOM3ToolStripMenuItem.Name = "cOM3ToolStripMenuItem";
            this.cOM3ToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.cOM3ToolStripMenuItem.Text = "COM3";
            // 
            // cOM4ToolStripMenuItem
            // 
            this.cOM4ToolStripMenuItem.Name = "cOM4ToolStripMenuItem";
            this.cOM4ToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.cOM4ToolStripMenuItem.Text = "COM4";
            // 
            // cOM5ToolStripMenuItem
            // 
            this.cOM5ToolStripMenuItem.Name = "cOM5ToolStripMenuItem";
            this.cOM5ToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.cOM5ToolStripMenuItem.Text = "COM5";
            // 
            // bAUDRATEToolStripMenuItem
            // 
            this.bAUDRATEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6});
            this.bAUDRATEToolStripMenuItem.Name = "bAUDRATEToolStripMenuItem";
            this.bAUDRATEToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.bAUDRATEToolStripMenuItem.Text = "BAUDRATE";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(110, 22);
            this.toolStripMenuItem2.Text = "9600";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(110, 22);
            this.toolStripMenuItem3.Text = "19200";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(110, 22);
            this.toolStripMenuItem4.Text = "38400";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(110, 22);
            this.toolStripMenuItem5.Text = "57600";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(110, 22);
            this.toolStripMenuItem6.Text = "115200";
            // 
            // tCPPORT1ToolStripMenuItem
            // 
            this.tCPPORT1ToolStripMenuItem.Name = "tCPPORT1ToolStripMenuItem";
            this.tCPPORT1ToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.tCPPORT1ToolStripMenuItem.Text = "TCP PORT1";
            // 
            // tCPPORT2ToolStripMenuItem
            // 
            this.tCPPORT2ToolStripMenuItem.Name = "tCPPORT2ToolStripMenuItem";
            this.tCPPORT2ToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.tCPPORT2ToolStripMenuItem.Text = "TCP PORT2";
            // 
            // exitApplicationToolStripMenuItem
            // 
            this.exitApplicationToolStripMenuItem.Name = "exitApplicationToolStripMenuItem";
            this.exitApplicationToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.exitApplicationToolStripMenuItem.Text = "Quit";
            // 
            // lbWeight
            // 
            this.lbWeight.AutoSize = true;
            this.lbWeight.BackColor = System.Drawing.Color.Transparent;
            this.lbWeight.Font = new System.Drawing.Font("Algerian", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbWeight.Location = new System.Drawing.Point(216, 42);
            this.lbWeight.Name = "lbWeight";
            this.lbWeight.Size = new System.Drawing.Size(186, 54);
            this.lbWeight.TabIndex = 7;
            this.lbWeight.Text = "22.780";
            // 
            // lbTare
            // 
            this.lbTare.AutoSize = true;
            this.lbTare.BackColor = System.Drawing.Color.Transparent;
            this.lbTare.Font = new System.Drawing.Font("Algerian", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTare.Location = new System.Drawing.Point(31, 42);
            this.lbTare.Name = "lbTare";
            this.lbTare.Size = new System.Drawing.Size(156, 54);
            this.lbTare.TabIndex = 8;
            this.lbTare.Text = "1.250";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(382, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Image = global::TakinArkaScale.Properties.Resources.exit;
            this.button1.Location = new System.Drawing.Point(346, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 18);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblConnection
            // 
            this.lblConnection.AutoSize = true;
            this.lblConnection.BackColor = System.Drawing.Color.IndianRed;
            this.lblConnection.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblConnection.Location = new System.Drawing.Point(54, 4);
            this.lblConnection.Name = "lblConnection";
            this.lblConnection.Size = new System.Drawing.Size(22, 13);
            this.lblConnection.TabIndex = 11;
            this.lblConnection.Text = "     ";
            // 
            // zero
            // 
            this.zero.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.zero.Location = new System.Drawing.Point(366, 99);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(41, 23);
            this.zero.TabIndex = 12;
            this.zero.Text = "صفر";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // clearTare
            // 
            this.clearTare.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clearTare.Location = new System.Drawing.Point(275, 99);
            this.clearTare.Name = "clearTare";
            this.clearTare.Size = new System.Drawing.Size(87, 23);
            this.clearTare.TabIndex = 13;
            this.clearTare.Text = "حذف پارسنگ";
            this.clearTare.UseVisualStyleBackColor = true;
            this.clearTare.Click += new System.EventHandler(this.clearTare_Click);
            // 
            // tare
            // 
            this.tare.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tare.Location = new System.Drawing.Point(210, 99);
            this.tare.Name = "tare";
            this.tare.Size = new System.Drawing.Size(62, 23);
            this.tare.TabIndex = 14;
            this.tare.Text = "پارسنگ";
            this.tare.UseVisualStyleBackColor = true;
            this.tare.Click += new System.EventHandler(this.tare_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(7, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 26);
            this.label2.TabIndex = 15;
            this.label2.Text = "صفر";
            // 
            // zeroLed
            // 
            this.zeroLed.AutoSize = true;
            this.zeroLed.BackColor = System.Drawing.Color.Silver;
            this.zeroLed.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.zeroLed.Location = new System.Drawing.Point(44, 107);
            this.zeroLed.Name = "zeroLed";
            this.zeroLed.Size = new System.Drawing.Size(15, 11);
            this.zeroLed.TabIndex = 16;
            this.zeroLed.Text = "     ";
            // 
            // netLed
            // 
            this.netLed.AutoSize = true;
            this.netLed.BackColor = System.Drawing.Color.Silver;
            this.netLed.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.netLed.Location = new System.Drawing.Point(171, 107);
            this.netLed.Name = "netLed";
            this.netLed.Size = new System.Drawing.Size(15, 11);
            this.netLed.TabIndex = 18;
            this.netLed.Text = "     ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(127, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "خالص";
            // 
            // stbLed
            // 
            this.stbLed.AutoSize = true;
            this.stbLed.BackColor = System.Drawing.Color.Silver;
            this.stbLed.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.stbLed.Location = new System.Drawing.Point(102, 107);
            this.stbLed.Name = "stbLed";
            this.stbLed.Size = new System.Drawing.Size(15, 11);
            this.stbLed.TabIndex = 20;
            this.stbLed.Text = "     ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(61, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 26);
            this.label6.TabIndex = 19;
            this.label6.Text = "ثبات";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::TakinArkaScale.Properties.Resources.FORM2;
            this.ClientSize = new System.Drawing.Size(416, 127);
            this.Controls.Add(this.stbLed);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.netLed);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.zeroLed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tare);
            this.Controls.Add(this.clearTare);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.lblConnection);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbTare);
            this.Controls.Add(this.lbWeight);
            this.Name = "Form1";
            this.Text = "Takin Indicator X10";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NotifyIcon notifyIcon;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem appSettingToolStripMenuItem;
        private Label lbWeight;
        private Label lbTare;
        private ToolStripMenuItem exitApplicationToolStripMenuItem;
        private ToolStripMenuItem cOMPORTToolStripMenuItem;
        private ToolStripMenuItem cOM1ToolStripMenuItem;
        private ToolStripMenuItem cOM2ToolStripMenuItem;
        private ToolStripMenuItem cOM3ToolStripMenuItem;
        private ToolStripMenuItem cOM4ToolStripMenuItem;
        private ToolStripMenuItem bAUDRATEToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem toolStripMenuItem6;
        private ToolStripMenuItem tCPPORT1ToolStripMenuItem;
        private ToolStripMenuItem tCPPORT2ToolStripMenuItem;
        private ToolStripMenuItem cOM5ToolStripMenuItem;
        private Label label1;
        private Button button1;
        private Label lblConnection;
        private Button zero;
        private Button clearTare;
        private Button tare;
        private Label label2;
        private Label zeroLed;
        private Label netLed;
        private Label label4;
        private Label stbLed;
        private Label label6;
    }
}