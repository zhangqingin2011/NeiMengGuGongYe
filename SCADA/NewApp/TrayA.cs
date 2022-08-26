using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCADA.NewApp
{
    public partial class TrayA : UserControl
    {
        public TrayA()
        {
            InitializeComponent();
        }

        public void SetData(PIECETYTPE piecetype, PIECEQUALITY pIECEQUALITY)
        {
            switch (piecetype)
            {
                case PIECETYTPE.无:
                    label1.InvokeEx(c => { c.Text = piecetype.ToString(); c.ForeColor = Color.Black; });
                    tableLayoutPanel1.InvokeEx(c => { c.BackColor = Color.White; });
                    break;
                case PIECETYTPE.毛坯A:
                    label1.InvokeEx(c => { c.Text = piecetype.ToString(); c.ForeColor = Color.Black; });
                    tableLayoutPanel1.BackColor = Color.Silver;
                    break;
                case PIECETYTPE.叶轮:
                    if (pIECEQUALITY == PIECEQUALITY.合格)
                    {
                        label1.InvokeEx(c => { c.Text = piecetype.ToString(); c.ForeColor = Color.Black; });
                        tableLayoutPanel1.InvokeEx(c => { c.BackColor = Color.GreenYellow; });
                    }
                    else
                    {
                        label1.InvokeEx(c => { c.Text = piecetype.ToString(); c.ForeColor = Color.BlueViolet; });
                        tableLayoutPanel1.InvokeEx(c => { c.BackColor = Color.LightCoral; });
                    }
                    break;
            }
        }
    }
}
