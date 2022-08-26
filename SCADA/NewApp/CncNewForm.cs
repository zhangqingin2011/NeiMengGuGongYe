using SCADA.SimensPLC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCADA.NewApp
{
    public partial class CncNewForm : Form
    {
        private CncUnit cncUnit4;
        private CncUnit cncUnit3;
        private CncUnit cncUnit2;
        private CncUnit cncUnit1;

        public CncNewForm()
        {
            InitializeComponent();
            InitUI();
            Task.Run(() => AutoDoWork());
        }

        public void InitUI()
        {
            this.cncUnit1 = new SCADA.NewApp.CncUnit();
            this.cncUnit2 = new SCADA.NewApp.CncUnit();
            this.cncUnit3 = new SCADA.NewApp.CncUnit();
            this.cncUnit4 = new SCADA.NewApp.CncUnit();
            this.tableLayoutPanel1.Controls.Add(this.cncUnit4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cncUnit3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cncUnit2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cncUnit1, 0, 0);
            // 
            // cncUnit1
            // 
            this.cncUnit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cncUnit1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cncUnit1.Location = new System.Drawing.Point(5, 5);
            this.cncUnit1.Margin = new System.Windows.Forms.Padding(5);
            this.cncUnit1.Name = "cncUnit1";
            this.cncUnit1.Size = new System.Drawing.Size(656, 384);
            this.cncUnit1.TabIndex = 0;
            // 
            // cncUnit2
            // 
            this.cncUnit2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cncUnit2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cncUnit2.Location = new System.Drawing.Point(671, 5);
            this.cncUnit2.Margin = new System.Windows.Forms.Padding(5);
            this.cncUnit2.Name = "cncUnit2";
            this.cncUnit2.Size = new System.Drawing.Size(657, 384);
            this.cncUnit2.TabIndex = 1;
            // 
            // cncUnit3
            // 
            this.cncUnit3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cncUnit3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cncUnit3.Location = new System.Drawing.Point(5, 399);
            this.cncUnit3.Margin = new System.Windows.Forms.Padding(5);
            this.cncUnit3.Name = "cncUnit3";
            this.cncUnit3.Size = new System.Drawing.Size(656, 384);
            this.cncUnit3.TabIndex = 2;
            // 
            // cncUnit4
            // 
            this.cncUnit4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cncUnit4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cncUnit4.Location = new System.Drawing.Point(671, 399);
            this.cncUnit4.Margin = new System.Windows.Forms.Padding(5);
            this.cncUnit4.Name = "cncUnit4";
            this.cncUnit4.Size = new System.Drawing.Size(657, 384);
            this.cncUnit4.TabIndex = 3;
            cncUnit1.Description.Text = "加工单元一车床";
            cncUnit1.Picture.Image = Image.FromFile("..\\picture\\chechuang3.png");
            cncUnit2.Description.Text = "加工单元一加工中心";
            cncUnit2.Picture.Image = Image.FromFile("..\\picture\\xichuang3.png");
            cncUnit3.Description.Text = "加工单元二车床";
            cncUnit3.Picture.Image = Image.FromFile("..\\picture\\chechuang3.png");
            cncUnit4.Description.Text = "加工单元二加工中心";
            cncUnit4.Picture.Image = Image.FromFile("..\\picture\\xichuang3.png");
        }

        private void AutoDoWork()
        {
            while (true)
            {
                Thread.Sleep(TimeSpan.FromSeconds(2));
                UpdateCNCDataShow();
            }
        }

        private void UpdateCNCDataShow()
        {
            if (LineMainForm.controlplc.GetOnlineState())
            {
                int[] values = new int[4];
                LineMainForm.controlplc.ReadMutiRegisters((int)ControlPLC.REGINDEX.加工单元一车床IO信号, values.Length, out values);
                GetUnitData(values[0], values[1], cncUnit1, cncUnit2);
                GetUnitData(values[2], values[3], cncUnit3, cncUnit4);
            }
            else
            {
                CleanCNCIO(cncUnit1);
                CleanCNCIO(cncUnit2);
                CleanCNCIO(cncUnit3);
                CleanCNCIO(cncUnit4);
            }
        }

        private void GetUnitData(int value1, int value2, CncUnit Unit1, CncUnit Unit2)
        {
            if (ControlPLC.GetBoolValue(value1, (int)ControlPLC.LATHEIO.车床已联机))
                Unit1.OnlineIO.InvokeEx(c => { c.Picture.Image = Image.FromFile("top_bar_green.png"); });
            else
                Unit1.OnlineIO.InvokeEx(c => { c.Picture.Image = Image.FromFile("top_bar_black.png"); });

            if (ControlPLC.GetBoolValue(value1, (int)ControlPLC.LATHEIO.车床加工中))
                Unit1.WorkIO.InvokeEx(c => { c.Picture.Image = Image.FromFile("top_bar_green.png"); });
            else
                Unit1.WorkIO.InvokeEx(c => { c.Picture.Image = Image.FromFile("top_bar_black.png"); });

            if (ControlPLC.GetBoolValue(value1, (int)ControlPLC.LATHEIO.车床报警))
                Unit1.AlarmIO.InvokeEx(c => { c.Picture.Image = Image.FromFile("top_bar_green.png"); });
            else
                Unit1.AlarmIO.InvokeEx(c => { c.Picture.Image = Image.FromFile("top_bar_black.png"); });

            if (ControlPLC.GetBoolValue(value1, (int)ControlPLC.LATHEIO.车床卡盘夹紧))
                Unit1.ChuckIO.InvokeEx(c => { c.Picture.Image = Image.FromFile("top_bar_green.png"); });
            else
                Unit1.ChuckIO.InvokeEx(c => { c.Picture.Image = Image.FromFile("top_bar_black.png"); });

            if (ControlPLC.GetBoolValue(value1, (int)ControlPLC.LATHEIO.车床自动门状态))
                Unit1.DoorIO.InvokeEx(c => { c.Picture.Image = Image.FromFile("top_bar_green.png"); });
            else
                Unit1.DoorIO.InvokeEx(c => { c.Picture.Image = Image.FromFile("top_bar_black.png"); });

            if (ControlPLC.GetBoolValue(value2, (int)ControlPLC.CENTERIO.加工中心已联机))
                Unit2.OnlineIO.InvokeEx(c => { c.Picture.Image = Image.FromFile("top_bar_green.png"); });
            else
                Unit2.OnlineIO.InvokeEx(c => { c.Picture.Image = Image.FromFile("top_bar_black.png"); });

            if (ControlPLC.GetBoolValue(value2, (int)ControlPLC.CENTERIO.加工中心加工中))
                Unit2.WorkIO.InvokeEx(c => { c.Picture.Image = Image.FromFile("top_bar_green.png"); });
            else
                Unit2.WorkIO.InvokeEx(c => { c.Picture.Image = Image.FromFile("top_bar_black.png"); });

            if (ControlPLC.GetBoolValue(value2, (int)ControlPLC.CENTERIO.加工中心报警))
                Unit2.AlarmIO.InvokeEx(c => { c.Picture.Image = Image.FromFile("top_bar_green.png"); });
            else
                Unit2.AlarmIO.InvokeEx(c => { c.Picture.Image = Image.FromFile("top_bar_black.png"); });

            if (ControlPLC.GetBoolValue(value2, (int)ControlPLC.CENTERIO.加工中心卡盘夹紧))
                Unit2.ChuckIO.InvokeEx(c => { c.Picture.Image = Image.FromFile("top_bar_green.png"); });
            else
                Unit2.ChuckIO.InvokeEx(c => { c.Picture.Image = Image.FromFile("top_bar_black.png"); });

            if (ControlPLC.GetBoolValue(value2, (int)ControlPLC.CENTERIO.加工中心自动门状态))
                Unit2.DoorIO.InvokeEx(c => { c.Picture.Image = Image.FromFile("top_bar_green.png"); });
            else
                Unit2.DoorIO.InvokeEx(c => { c.Picture.Image = Image.FromFile("top_bar_black.png"); });
        }

        private void CleanCNCIO(CncUnit cncUnit)
        {
            cncUnit.OnlineIO.InvokeEx(c => { c.Picture.Image = Image.FromFile("top_bar_black.png"); });
            cncUnit.DoorIO.InvokeEx(c => { c.Picture.Image = Image.FromFile("top_bar_black.png"); });
            cncUnit.ChuckIO.InvokeEx(c => { c.Picture.Image = Image.FromFile("top_bar_black.png"); });
            cncUnit.WorkIO.InvokeEx(c => { c.Picture.Image = Image.FromFile("top_bar_black.png"); });
            cncUnit.AlarmIO.InvokeEx(c => { c.Picture.Image = Image.FromFile("top_bar_black.png"); });
        }
    }
}
