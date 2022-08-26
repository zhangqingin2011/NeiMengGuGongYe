namespace SCADA.NewApp
{
    partial class LineMainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LineMainForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.labela2 = new System.Windows.Forms.Label();
            this.labela1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.totaltimeText = new System.Windows.Forms.ToolStripStatusLabel();
            this.totaldays = new System.Windows.Forms.ToolStripStatusLabel();
            this.dayText = new System.Windows.Forms.ToolStripStatusLabel();
            this.timesText = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelcurtime = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUnit4 = new System.Windows.Forms.Button();
            this.btnUnit3 = new System.Windows.Forms.Button();
            this.btnUnit2 = new System.Windows.Forms.Button();
            this.btnUnit1 = new System.Windows.Forms.Button();
            this.groupBoxPLC = new System.Windows.Forms.GroupBox();
            this.labelPLC2state = new System.Windows.Forms.Label();
            this.labelPLC2 = new System.Windows.Forms.Label();
            this.labelPLC1state = new System.Windows.Forms.Label();
            this.labelPLC1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labProductionLine = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPagemain = new System.Windows.Forms.TabControl();
            this.tabPageHome = new System.Windows.Forms.TabPage();
            this.tabPageDevice = new System.Windows.Forms.TabPage();
            this.tabPageOrder = new System.Windows.Forms.TabPage();
            this.tabPageBoard = new System.Windows.Forms.TabPage();
            this.tabPageSYSSet = new System.Windows.Forms.TabPage();
            this.timer_timekeeper = new System.Windows.Forms.Timer(this.components);
            this.PLCChecktimer = new System.Windows.Forms.Timer(this.components);
            this.timerNCload = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxPLC.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPagemain.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.SteelBlue;
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.labela2);
            this.splitContainer1.Panel1.Controls.Add(this.labela1);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxPLC);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox4);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabPagemain);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            resources.ApplyResources(this.button1, "button1");
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labela2
            // 
            resources.ApplyResources(this.labela2, "labela2");
            this.labela2.ForeColor = System.Drawing.Color.DarkOrange;
            this.labela2.Name = "labela2";
            // 
            // labela1
            // 
            resources.ApplyResources(this.labela1, "labela1");
            this.labela1.ForeColor = System.Drawing.Color.DarkOrange;
            this.labela1.Name = "labela1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.statusStrip);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // statusStrip
            // 
            resources.ApplyResources(this.statusStrip, "statusStrip");
            this.statusStrip.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.totaltimeText,
            this.totaldays,
            this.dayText,
            this.timesText});
            this.statusStrip.Name = "statusStrip";
            // 
            // totaltimeText
            // 
            this.totaltimeText.Name = "totaltimeText";
            resources.ApplyResources(this.totaltimeText, "totaltimeText");
            // 
            // totaldays
            // 
            this.totaldays.Name = "totaldays";
            resources.ApplyResources(this.totaldays, "totaldays");
            // 
            // dayText
            // 
            this.dayText.Name = "dayText";
            resources.ApplyResources(this.dayText, "dayText");
            // 
            // timesText
            // 
            this.timesText.Name = "timesText";
            resources.ApplyResources(this.timesText, "timesText");
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelcurtime);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // labelcurtime
            // 
            resources.ApplyResources(this.labelcurtime, "labelcurtime");
            this.labelcurtime.Name = "labelcurtime";
            this.labelcurtime.SizeChanged += new System.EventHandler(this.labelcurtime_SizeChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUnit4);
            this.groupBox1.Controls.Add(this.btnUnit3);
            this.groupBox1.Controls.Add(this.btnUnit2);
            this.groupBox1.Controls.Add(this.btnUnit1);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // btnUnit4
            // 
            resources.ApplyResources(this.btnUnit4, "btnUnit4");
            this.btnUnit4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnUnit4.FlatAppearance.BorderSize = 0;
            this.btnUnit4.ForeColor = System.Drawing.Color.White;
            this.btnUnit4.Name = "btnUnit4";
            this.btnUnit4.UseVisualStyleBackColor = false;
            this.btnUnit4.Click += new System.EventHandler(this.btnUnit4_Click);
            // 
            // btnUnit3
            // 
            resources.ApplyResources(this.btnUnit3, "btnUnit3");
            this.btnUnit3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnUnit3.FlatAppearance.BorderSize = 0;
            this.btnUnit3.ForeColor = System.Drawing.Color.White;
            this.btnUnit3.Name = "btnUnit3";
            this.btnUnit3.UseVisualStyleBackColor = false;
            this.btnUnit3.Click += new System.EventHandler(this.btnUnit3_Click);
            // 
            // btnUnit2
            // 
            resources.ApplyResources(this.btnUnit2, "btnUnit2");
            this.btnUnit2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnUnit2.FlatAppearance.BorderSize = 0;
            this.btnUnit2.ForeColor = System.Drawing.Color.White;
            this.btnUnit2.Name = "btnUnit2";
            this.btnUnit2.UseVisualStyleBackColor = false;
            this.btnUnit2.Click += new System.EventHandler(this.BtnUnit2_Click);
            // 
            // btnUnit1
            // 
            resources.ApplyResources(this.btnUnit1, "btnUnit1");
            this.btnUnit1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnUnit1.FlatAppearance.BorderSize = 0;
            this.btnUnit1.ForeColor = System.Drawing.Color.White;
            this.btnUnit1.Name = "btnUnit1";
            this.btnUnit1.UseVisualStyleBackColor = false;
            this.btnUnit1.Click += new System.EventHandler(this.BtnUnit1_Click);
            // 
            // groupBoxPLC
            // 
            this.groupBoxPLC.Controls.Add(this.labelPLC2state);
            this.groupBoxPLC.Controls.Add(this.labelPLC2);
            this.groupBoxPLC.Controls.Add(this.labelPLC1state);
            this.groupBoxPLC.Controls.Add(this.labelPLC1);
            resources.ApplyResources(this.groupBoxPLC, "groupBoxPLC");
            this.groupBoxPLC.ForeColor = System.Drawing.Color.White;
            this.groupBoxPLC.Name = "groupBoxPLC";
            this.groupBoxPLC.TabStop = false;
            // 
            // labelPLC2state
            // 
            resources.ApplyResources(this.labelPLC2state, "labelPLC2state");
            this.labelPLC2state.Name = "labelPLC2state";
            // 
            // labelPLC2
            // 
            resources.ApplyResources(this.labelPLC2, "labelPLC2");
            this.labelPLC2.Name = "labelPLC2";
            // 
            // labelPLC1state
            // 
            resources.ApplyResources(this.labelPLC1state, "labelPLC1state");
            this.labelPLC1state.Name = "labelPLC1state";
            // 
            // labelPLC1
            // 
            resources.ApplyResources(this.labelPLC1, "labelPLC1");
            this.labelPLC1.Name = "labelPLC1";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.labProductionLine);
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            this.groupBox4.SizeChanged += new System.EventHandler(this.GroupBox4_SizeChanged);
            // 
            // labProductionLine
            // 
            resources.ApplyResources(this.labProductionLine, "labProductionLine");
            this.labProductionLine.Name = "labProductionLine";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // tabPagemain
            // 
            this.tabPagemain.Controls.Add(this.tabPageHome);
            this.tabPagemain.Controls.Add(this.tabPageDevice);
            this.tabPagemain.Controls.Add(this.tabPageOrder);
            this.tabPagemain.Controls.Add(this.tabPageBoard);
            this.tabPagemain.Controls.Add(this.tabPageSYSSet);
            resources.ApplyResources(this.tabPagemain, "tabPagemain");
            this.tabPagemain.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabPagemain.Multiline = true;
            this.tabPagemain.Name = "tabPagemain";
            this.tabPagemain.SelectedIndex = 0;
            this.tabPagemain.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabPagemain_DrawItem);
            this.tabPagemain.SelectedIndexChanged += new System.EventHandler(this.tabPagemain_SelectedIndexChanged);
            // 
            // tabPageHome
            // 
            this.tabPageHome.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.tabPageHome, "tabPageHome");
            this.tabPageHome.Name = "tabPageHome";
            this.tabPageHome.Tag = "SCADA.NewApp.HomePageForm";
            // 
            // tabPageDevice
            // 
            this.tabPageDevice.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.tabPageDevice, "tabPageDevice");
            this.tabPageDevice.Name = "tabPageDevice";
            this.tabPageDevice.Tag = "SCADA.NewApp.DeviceForm";
            // 
            // tabPageOrder
            // 
            this.tabPageOrder.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.tabPageOrder, "tabPageOrder");
            this.tabPageOrder.Name = "tabPageOrder";
            this.tabPageOrder.Tag = "SCADA.NewApp.OrderExcuteForm";
            // 
            // tabPageBoard
            // 
            this.tabPageBoard.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.tabPageBoard, "tabPageBoard");
            this.tabPageBoard.Name = "tabPageBoard";
            this.tabPageBoard.Tag = "SCADA.NewApp.BoardForm";
            // 
            // tabPageSYSSet
            // 
            this.tabPageSYSSet.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.tabPageSYSSet, "tabPageSYSSet");
            this.tabPageSYSSet.Name = "tabPageSYSSet";
            this.tabPageSYSSet.Tag = "SCADA.NewApp.SYSSetForm";
            // 
            // timer_timekeeper
            // 
            this.timer_timekeeper.Enabled = true;
            this.timer_timekeeper.Interval = 1000;
            this.timer_timekeeper.Tick += new System.EventHandler(this.timer_timekeeper_Tick);
            // 
            // PLCChecktimer
            // 
            this.PLCChecktimer.Enabled = true;
            this.PLCChecktimer.Interval = 1000;
            this.PLCChecktimer.Tick += new System.EventHandler(this.PLCChecktimer_Tick);
            // 
            // timerNCload
            // 
            this.timerNCload.Enabled = true;
            this.timerNCload.Interval = 2000;
            this.timerNCload.Tick += new System.EventHandler(this.TimerNCload_Tick);
            // 
            // LineMainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.Controls.Add(this.splitContainer1);
            this.Name = "LineMainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LineMainForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBoxPLC.ResumeLayout(false);
            this.groupBoxPLC.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPagemain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabPagemain;
        private System.Windows.Forms.TabPage tabPageHome;
        private System.Windows.Forms.TabPage tabPageDevice;
        private System.Windows.Forms.TabPage tabPageOrder;
        private System.Windows.Forms.TabPage tabPageBoard;
        private System.Windows.Forms.TabPage tabPageSYSSet;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label labProductionLine;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxPLC;
        private System.Windows.Forms.Label labelPLC1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel totaltimeText;
        private System.Windows.Forms.ToolStripStatusLabel totaldays;
        private System.Windows.Forms.ToolStripStatusLabel dayText;
        private System.Windows.Forms.ToolStripStatusLabel timesText;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelcurtime;
        private System.Windows.Forms.Timer timer_timekeeper;
        private System.Windows.Forms.Timer PLCChecktimer;
        private System.Windows.Forms.Label labelPLC1state;
        private System.Windows.Forms.Label labelPLC2state;
        private System.Windows.Forms.Label labelPLC2;
        private System.Windows.Forms.Timer timerNCload;
        private System.Windows.Forms.Button btnUnit2;
        private System.Windows.Forms.Button btnUnit1;
        private System.Windows.Forms.Label labela2;
        private System.Windows.Forms.Label labela1;
        private System.Windows.Forms.Button btnUnit4;
        private System.Windows.Forms.Button btnUnit3;
        private System.Windows.Forms.Button button1;
    }
}