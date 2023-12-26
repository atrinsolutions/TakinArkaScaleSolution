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
            this.zero = new System.Windows.Forms.Button();
            this.tare = new System.Windows.Forms.Button();
            this.clearTare = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnNet = new System.Windows.Forms.Button();
            this.btnStable = new System.Windows.Forms.Button();
            this.lbWeight = new System.Windows.Forms.Label();
            this.lbTare = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblConnection = new System.Windows.Forms.Label();
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
            // zero
            // 
            this.zero.BackColor = System.Drawing.Color.Transparent;
            this.zero.FlatAppearance.BorderSize = 0;
            this.zero.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.zero.ForeColor = System.Drawing.Color.Black;
            this.zero.Location = new System.Drawing.Point(454, 23);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(76, 15);
            this.zero.TabIndex = 1;
            this.zero.UseVisualStyleBackColor = false;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // tare
            // 
            this.tare.BackColor = System.Drawing.Color.Transparent;
            this.tare.FlatAppearance.BorderSize = 0;
            this.tare.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tare.Location = new System.Drawing.Point(454, 73);
            this.tare.Name = "tare";
            this.tare.Size = new System.Drawing.Size(76, 16);
            this.tare.TabIndex = 2;
            this.tare.UseVisualStyleBackColor = false;
            this.tare.Click += new System.EventHandler(this.tare_Click);
            // 
            // clearTare
            // 
            this.clearTare.BackColor = System.Drawing.Color.Transparent;
            this.clearTare.FlatAppearance.BorderSize = 0;
            this.clearTare.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clearTare.Location = new System.Drawing.Point(454, 48);
            this.clearTare.Name = "clearTare";
            this.clearTare.Size = new System.Drawing.Size(76, 15);
            this.clearTare.TabIndex = 3;
            this.clearTare.UseVisualStyleBackColor = false;
            this.clearTare.Click += new System.EventHandler(this.clearTare_Click);
            // 
            // btnZero
            // 
            this.btnZero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnZero.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnZero.Location = new System.Drawing.Point(404, 68);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(42, 23);
            this.btnZero.TabIndex = 4;
            this.btnZero.Text = "صفر";
            this.btnZero.UseVisualStyleBackColor = false;
            // 
            // btnNet
            // 
            this.btnNet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnNet.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNet.Location = new System.Drawing.Point(404, 44);
            this.btnNet.Name = "btnNet";
            this.btnNet.Size = new System.Drawing.Size(42, 23);
            this.btnNet.TabIndex = 5;
            this.btnNet.Text = "خالص";
            this.btnNet.UseVisualStyleBackColor = false;
            // 
            // btnStable
            // 
            this.btnStable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnStable.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStable.Location = new System.Drawing.Point(404, 20);
            this.btnStable.Name = "btnStable";
            this.btnStable.Size = new System.Drawing.Size(42, 23);
            this.btnStable.TabIndex = 6;
            this.btnStable.Text = "ثبات";
            this.btnStable.UseVisualStyleBackColor = false;
            // 
            // lbWeight
            // 
            this.lbWeight.AutoSize = true;
            this.lbWeight.BackColor = System.Drawing.SystemColors.Window;
            this.lbWeight.Font = new System.Drawing.Font("SimSun", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbWeight.Location = new System.Drawing.Point(216, 40);
            this.lbWeight.Name = "lbWeight";
            this.lbWeight.Size = new System.Drawing.Size(145, 48);
            this.lbWeight.TabIndex = 7;
            this.lbWeight.Text = "0.000";
            // 
            // lbTare
            // 
            this.lbTare.AutoSize = true;
            this.lbTare.BackColor = System.Drawing.Color.Transparent;
            this.lbTare.Font = new System.Drawing.Font("SimSun", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTare.Location = new System.Drawing.Point(26, 40);
            this.lbTare.Name = "lbTare";
            this.lbTare.Size = new System.Drawing.Size(145, 48);
            this.lbTare.TabIndex = 8;
            this.lbTare.Text = "0.000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(382, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Image = global::TakinArkaScale.Properties.Resources.exit;
            this.button1.Location = new System.Drawing.Point(477, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 18);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblConnection
            // 
            this.lblConnection.AutoSize = true;
            this.lblConnection.BackColor = System.Drawing.Color.IndianRed;
            this.lblConnection.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblConnection.Location = new System.Drawing.Point(48, 4);
            this.lblConnection.Name = "lblConnection";
            this.lblConnection.Size = new System.Drawing.Size(15, 11);
            this.lblConnection.TabIndex = 11;
            this.lblConnection.Text = "     ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(539, 94);
            this.Controls.Add(this.lblConnection);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbTare);
            this.Controls.Add(this.lbWeight);
            this.Controls.Add(this.btnStable);
            this.Controls.Add(this.btnNet);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.clearTare);
            this.Controls.Add(this.tare);
            this.Controls.Add(this.zero);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private Button zero;
        private Button tare;
        private Button clearTare;
        private Button btnZero;
        private Button btnNet;
        private Button btnStable;
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
    }
}