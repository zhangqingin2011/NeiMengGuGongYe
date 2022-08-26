using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading;
using SCADA.NewApp;

namespace SCADA
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.ThreadException += new ThreadExceptionEventHandler(MainUIThreadExceptionHandler);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(MainUIUnhandledExceptionHandler);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            System.Diagnostics.Process m_process = RunningInstance();
            if (m_process != null)
            {
                if (MessageBox.Show("已经有一个MES在运行，是否重启MES?", "警告", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    m_process.Kill();
                }
                else 
                {
                    HandleRunningInstance(m_process);
                    return;
                }
            }
            InitializeDB();
            Application.Run(new LineMainForm());
            //Application.Run(new TestToNewProcessForm());
            //Application.Run(new TestOrderForm());
            //Application.Run(new MainForm());
            //Application.Run(new NewApp.NVRForm());
            //Application.Run(new TestWMSForm());
            /*if (ChoiceForm.TheChoose == 1)
            {
                Application.Run(new MainForm());
            }
            else if(ChoiceForm.TheChoose == 2)
            {
                Application.Run(new LineMainForm());
            }*/
            Environment.Exit(0);
        }

        public static MMCSRepository Repo { get; private set; }
        /// <summary>
        /// 初始化数据库
        /// </summary>
        private static void InitializeDB()
        {
            try
            {
                MMCSDbInitializer.Initialize();
                Repo = new MMCSRepository();
                InitDBTable();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                //Repo.Insert(new Log { LogLevel = LogLevel.Error , Description = ex.Message.ToString() });
            }
            /*if (Repo.Count<Log>() == 0)
            {
                Repo.Insert(new Log { LogLevel = HNC.MMCS.Server.LogLevel.Information, Name = "Init", Description = nameof(InitializeDB) });
            }*/
        }

        private static void InitDBTable()
        {
            InitUser();
            InitPLCAlarm();
            InitKeyValueData();
            InitWorkOrderData();
            InitRackUnitData();
        }

        private static void InitRackUnitData()
        {
            for (int i = 1; i <= 35; i++)
            {
                var data = Repo.GetSingle<RackUnitData>(p => p.NO == i);
                if (data == null)
                {
                    var data1 = new RackUnitData
                    {
                        NO = i,
                        Tray = TRAYTYPE.空,
                        TrayVolume = 0,
                        Piece1 = PIECETYTPE.无,
                        Piece1Quality = PIECEQUALITY.待检测,
                        Piece2 = PIECETYTPE.无,
                        Piece2Quality = PIECEQUALITY.待检测,
                        Piece3 = PIECETYTPE.无,
                        Piece3Quality = PIECEQUALITY.待检测,
                        Piece4 = PIECETYTPE.无,
                        Piece4Quality = PIECEQUALITY.待检测,
                        Lock = false
                    };
                    Repo.Insert<RackUnitData>(data1);
                    RackForm.listRackData.Add(data1);
                }
                else
                {
                    RackForm.listRackData.Add(data);
                }
            }
            Console.WriteLine("初始化料库表成功 {0}", DateTime.Now);
        }

        private static void InitWorkOrderData()
        {
            DateTime nowtime = DateTime.Now;
            DateTime start = new DateTime(nowtime.Year, nowtime.Month, nowtime.Day, 0, 0, 0);
            var completelist = Repo.Get<WorkOrderData>(p => (p.OrderState == ORDERSTATE.结束 && p.CreationTime < start));
            if (completelist != null)
            {
                foreach (var data in completelist)
                {
                    Repo.RealDelete<WorkOrderData>(data);
                }
            }

            if (Repo.Get<WorkOrderData>().Count > 0)
            {
                var datalist = Repo.GetOrderByASC<WorkOrderData>();
                foreach (var data in datalist)
                {
                    OrderExcuteForm.workOrderTasks.Add(data);
                }
            }
            Console.WriteLine("初始化订单表成功 {0}", DateTime.Now);
        }

        private static void InitKeyValueData()
        {
            var data1 = Repo.GetSingle<KeyValueData>(p => p.Key == (int)INDEX.wMSPositionBind);
            if (data1 == null)
            {
                var data = new KeyValueData
                {
                    Key = (int)INDEX.wMSPositionBind,
                    Value = "0",
                    Name = INDEX.wMSPositionBind.ToString()
                };
                Repo.Insert<KeyValueData>(data);
                OrderExcuteForm.listKeyValueData.Add(data);
            }
            else
            {
                OrderExcuteForm.listKeyValueData.Add(data1);
            }

            var data2 = Repo.GetSingle<KeyValueData>(p => p.Key == (int)INDEX.aGVBind);
            if (data2 == null)
            {
                var data = new KeyValueData
                {
                    Key = (int)INDEX.aGVBind,
                    Value = "0",
                    Name = INDEX.aGVBind.ToString()
                };
                Repo.Insert<KeyValueData>(data);
                OrderExcuteForm.listKeyValueData.Add(data);
            }
            else
            {
                OrderExcuteForm.listKeyValueData.Add(data2);
            }

            var data3 = Repo.GetSingle<KeyValueData>(p => p.Key == (int)INDEX.process1Position1Bind);
            if (data3 == null)
            {
                var data = new KeyValueData
                {
                    Key = (int)INDEX.process1Position1Bind,
                    Value = "0",
                    Name = INDEX.process1Position1Bind.ToString()
                };
                Repo.Insert<KeyValueData>(data);
                OrderExcuteForm.listKeyValueData.Add(data);
            }
            else
            {
                OrderExcuteForm.listKeyValueData.Add(data3);
            }

            var data4 = Repo.GetSingle<KeyValueData>(p => p.Key == (int)INDEX.process1Position2Bind);
            if (data4 == null)
            {
                var data = new KeyValueData
                {
                    Key = (int)INDEX.process1Position2Bind,
                    Value = "0",
                    Name = INDEX.process1Position2Bind.ToString()
                };
                Repo.Insert<KeyValueData>(data);
                OrderExcuteForm.listKeyValueData.Add(data);
            }
            else
            {
                OrderExcuteForm.listKeyValueData.Add(data4);
            }

            var data5 = Repo.GetSingle<KeyValueData>(p => p.Key == (int)INDEX.process2Position1Bind);
            if (data5 == null)
            {
                var data = new KeyValueData
                {
                    Key = (int)INDEX.process2Position1Bind,
                    Value = "0",
                    Name = INDEX.process2Position1Bind.ToString()
                };
                Repo.Insert<KeyValueData>(data);
                OrderExcuteForm.listKeyValueData.Add(data);
            }
            else
            {
                OrderExcuteForm.listKeyValueData.Add(data5);
            }

            var data6 = Repo.GetSingle<KeyValueData>(p => p.Key == (int)INDEX.process2Position2Bind);
            if (data6 == null)
            {
                var data = new KeyValueData
                {
                    Key = (int)INDEX.process2Position2Bind,
                    Value = "0",
                    Name = INDEX.process2Position2Bind.ToString()
                };
                Repo.Insert<KeyValueData>(data);
                OrderExcuteForm.listKeyValueData.Add(data);
            }
            else
            {
                OrderExcuteForm.listKeyValueData.Add(data6);
            }

            var data7 = Repo.GetSingle<KeyValueData>(p => p.Key == (int)INDEX.checkPosition1Bind);
            if (data7 == null)
            {
                var data = new KeyValueData
                {
                    Key = (int)INDEX.checkPosition1Bind,
                    Value = "0",
                    Name = INDEX.checkPosition1Bind.ToString()
                };
                Repo.Insert<KeyValueData>(data);
                OrderExcuteForm.listKeyValueData.Add(data);
            }
            else
            {
                OrderExcuteForm.listKeyValueData.Add(data7);
            }

            var data8 = Repo.GetSingle<KeyValueData>(p => p.Key == (int)INDEX.checkPosition2Bind);
            if (data8 == null)
            {
                var data = new KeyValueData
                {
                    Key = (int)INDEX.checkPosition2Bind,
                    Value = "0",
                    Name = INDEX.checkPosition2Bind.ToString()
                };
                Repo.Insert<KeyValueData>(data);
                OrderExcuteForm.listKeyValueData.Add(data);
            }
            else
            {
                OrderExcuteForm.listKeyValueData.Add(data8);
            }
            Console.WriteLine("初始化数据索引表成功 {0}", DateTime.Now);
        }

        private static void InitPLCAlarm()
        {
            if (Repo.Get<PLCAlarm>().Count > 0)
            {
                Repo.EmptyData<PLCAlarm>();
            }
            WMSPLCALARM e0 = new WMSPLCALARM();

            CONTROLPLCALARM e1 = new CONTROLPLCALARM();

            Console.WriteLine("初始化PLC报警表成功 {0}", DateTime.Now);
        }


        private static void InitUser()
        {
            if (Repo.Get<Users>().Count == 0)
            {
                var data = new Users
                {
                    username = "admin",
                    Password = "123456",
                    lever = Lever.Admin
                };
                Repo.Insert<Users>(data);
                var data1 = new Users
                {
                    username = "管理员",
                    Password = "123456",
                    lever = Lever.Admin
                };
                Repo.Insert<Users>(data1);
            }
            Console.WriteLine("初始化用户表成功 {0}", DateTime.Now);
        }

        public static void MainUIThreadExceptionHandler(object sender, ThreadExceptionEventArgs e)
        {
            MessageBox.Show(e.Exception.ToString(), "线程异常:", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void MainUIUnhandledExceptionHandler(object sender, UnhandledExceptionEventArgs e)
        {
            MessageBox.Show(e.ExceptionObject.ToString(), "未处理的异常:", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        /// <summary>
        /// 获取正在运行的实例，没有运行的实例返回null;
        /// </summary>
        public static System.Diagnostics.Process RunningInstance()
        {
            System.Diagnostics.Process current = System.Diagnostics.Process.GetCurrentProcess();
            System.Diagnostics.Process[] processes = System.Diagnostics.Process.GetProcessesByName(current.ProcessName);
            foreach (System.Diagnostics.Process process in processes)
            {
                if (process.Id != current.Id)
                {
                    if (System.Reflection.Assembly.GetExecutingAssembly().Location.Replace("/", "//") == current.MainModule.FileName)
                    {
                        return process;
                    }
                }
            }
            return null;
        }
        private static void HandleRunningInstance(System.Diagnostics.Process instance)
        {
            ShowWindowAsync(instance.MainWindowHandle, 1);//显示  
            SetForegroundWindow(instance.MainWindowHandle);//当到最前端  
        }
        /// 该函数设置由不同线程产生的窗口的显示状态  
        /// </summary>  
        /// <param name="hWnd">窗口句柄</param>  
        /// <param name="cmdShow">指定窗口如何显示。查看允许值列表，请查阅ShowWlndow函数的说明部分</param>  
        /// <returns>如果函数原来可见，返回值为非零；如果函数原来被隐藏，返回值为零</returns>  
        [System.Runtime.InteropServices.DllImport("User32.dll")]
        private static extern bool ShowWindowAsync(IntPtr hWnd, int cmdShow);
        /// <summary>  
        ///  该函数将创建指定窗口的线程设置到前台，并且激活该窗口。键盘输入转向该窗口，并为用户改各种可视的记号。  
        ///  系统给创建前台窗口的线程分配的权限稍高于其他线程。   
        /// </summary>  
        /// <param name="hWnd">将被激活并被调入前台的窗口句柄</param>  
        /// <returns>如果窗口设入了前台，返回值为非零；如果窗口未被设入前台，返回值为零</returns>  
        [System.Runtime.InteropServices.DllImport("User32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);  
    }
}
