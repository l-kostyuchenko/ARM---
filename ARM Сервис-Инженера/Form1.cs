using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net.Mail;
using System.Net;
using System.Net.Mime;

using System.Diagnostics;

using System.IO;
using System.Xml;

using System.IO.Compression;
using ARM_Сервис_Инженера.WebReference;
using System.Threading;


namespace ARM_Сервис_Инженера
{
    public partial class Form1 : Form
    {
        
        dynamic DB1C;
        
        string WS_login = "";
        string WS_pass = "";
        ARM_Сервис_Инженера.WebReference.StrRequest[] ArrRequest;

        string num = "";
        string NVer = "";
        bool u = false;

        public Form1()
        {
            InitializeComponent();

            WS_login = DB_login.Text;
            WS_pass = DB_pwd.Text;
        }

        private void CreateCOM_Click(object sender, EventArgs e)
        {
            //ComConnection();                        
        }

        //void ComConnection()
        //{
        //    ////            
        //}

        List<string> UpdateUserBase(string ThisVer, string conf, string Platform, object sender)             
        {
            List<string> PathUpd = new List<string>();
            string confName = "";
          
            //определим название конфигурации
            if (conf.ToLower().Contains("бухгалтерия предприятия"))
                confName = "Accounting";
            if (conf.ToLower().Contains("бухгалтерия предприятия базовая"))
                confName = "AccountingBase";
            if (conf.ToLower().Contains("зарплата и управление персоналом"))
                confName = "HRM";
            if (conf.ToLower().Contains("комплексная автоматизация"))
                confName = "ARAutomation";
            if (conf.ToLower().Contains("управление производственным предприятием"))
                confName = "Enterprise";

            //определим редакцию
            string redact = ThisVer.Replace(".","").Substring(0,2);

            //определим платформу
            string plat = Platform.Replace(".", "").Substring(0, 2);

            try
            {
                DownloadTemplate(confName, redact, plat, sender);
                List<TablUpd> UpdVersions = new List<TablUpd>();
                UpdVersions = XML_Parse(ThisVer, sender);

                PathUpd = new List<string>();
                foreach (TablUpd NewVer in UpdVersions)
                {
                    PathUpd.Add(DownloadCFU(confName, NewVer.Version, sender));
                }

                NVer = UpdVersions[UpdVersions.Count - 1].Version;

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                //return;
                BackgroundWorker worker = sender as BackgroundWorker;
                worker.ReportProgress(100, ex.Message);
            }
            finally
            {
                backgroundWorker2.CancelAsync();
                backgroundWorker2.Dispose();
            }

            return PathUpd;
                
        }

        //Письмо на почту
        void SendMessage(string msgText, object sender)
        {
            string email = Email.Text;
            string password = Password.Text.Trim();

            //Авторизация на SMTP сервере
            SmtpClient Smtp = new SmtpClient("smtp.mail.ru", 25);
            Smtp.Credentials = new NetworkCredential(email, password);
            Smtp.EnableSsl = true;           
              
            MailMessage Msg = new MailMessage();
            Msg.From = new MailAddress(email);
           
            Msg.To.Add(new MailAddress(email));
            Msg.Subject = "Обновление завершено";
            Msg.Body = msgText;


            BackgroundWorker worker = sender as BackgroundWorker;
            string MsgString;
            try
            {
                Smtp.Send(Msg);
               
                MsgString = "Сообщение отправлено!" + Environment.NewLine;
                worker.ReportProgress(100, MsgString);
            }
            catch
            {
                
                MsgString = "Неправильные данные e-mail" + Environment.NewLine;
                worker.ReportProgress(100, MsgString);
            }
        }

        private void SendMsg_Click(object sender, EventArgs e)
        {
            SendMessage("", sender);
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        string BatFile(string User, string Pwd, string Address, List<string> PathUpd, object sender)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            string MsgString;
            string Result = "";
            //string encode = "chcp 1251";
            string Start1C;

            //проверка версии системы и версии платформы.
            if (Directory.Exists(@"C:\Program Files (x86)"))
            {
                Start1C = @"C:\Program Files (x86)\1cv8\common\1cestart.exe";
                if (!Directory.Exists(@"C:\Program Files (x86)\1cv8"))
                {
                    Start1C = @"C:\Program Files (x86)\1cv82\common\1cestart.exe";
                }
            }
            else
            {
                Start1C = @"C:\Program Files\1cv8\common\1cestart.exe";
                if (!Directory.Exists(@"C:\Program Files\1cv8"))
                {
                    Start1C = @"C:\Program Files\1cv82\common\1cestart.exe";
                }
            }

            if (!Directory.Exists(Dir.Text + @"\Log"))
            { Directory.CreateDirectory(Dir.Text + @"\Log"); }
            string LogFile = Dir.Text + @"\Log\LogFile.txt";
            const char quote = '\u0022';
            string date = DateTime.Now.ToString().Replace(".", "-").Substring(0, 10);
            

            string ArchivePath = Dir.Text + @"\Архив1С";
            if (!Directory.Exists(ArchivePath))
            { Directory.CreateDirectory(ArchivePath); }
            string baseName = Path.GetFileName(Address).Replace(" ", "_");

            string ArchiveFile = ArchivePath + @"\" + date + " " + baseName + ".dt";

            //=====================================================


            //=====================================================

            string UserPwd;
            if (User == "")
            { UserPwd = ""; }
            else
            { UserPwd = " /N " + quote + User + quote + " /P " + Pwd; }

            if (File.Exists(LogFile)) File.Delete(LogFile);

            string Archive = "CONFIG /Out " + quote + LogFile + quote + " /DisableStartupMessages /F "
                + quote + Address + quote + UserPwd + " /DumpIB " + quote + ArchiveFile + quote;

            Process NewProcess = new Process();
            NewProcess.StartInfo.FileName = Start1C;
            NewProcess.StartInfo.Arguments = Archive;
            NewProcess.Start();

            bool lf = true;
            while (!File.Exists(LogFile) || lf)
            {
                try
                {
                    int a = File.ReadAllText(LogFile).Length;
                    if (a>0) lf = false;
                }
                catch { }
            }

            string log = File.ReadAllText(LogFile, Encoding.GetEncoding(1251));
            Result += log;

         
            MsgString = log;
            worker.ReportProgress(60, MsgString);


            if (!log.Contains("Выгрузка информационной базы успешно завершена"))
            {
                return Result;
            }

            //=====================================================
            int TekNum = 1;
            foreach (string Cfu in PathUpd)
            {
                TekNum++;
                if (File.Exists(LogFile)) File.Delete(LogFile);

                string Update = "CONFIG /Out " + quote + LogFile + quote + " /DisableStartupMessages /F "
                    + quote + Address + quote + UserPwd + " /UpdateCfg " + quote + Cfu + quote + " /UpdateDBCfg";

                NewProcess = new Process();
                NewProcess.StartInfo.FileName = Start1C;
                NewProcess.StartInfo.Arguments = Update;
                NewProcess.Start();

                lf = true;
                while (!File.Exists(LogFile) || lf)
                {
                    try
                    {
                        int a = File.ReadAllText(LogFile).Length;
                        if (a > 0) lf = false;
                    }
                    catch { }
                }

                log = File.ReadAllText(LogFile, Encoding.GetEncoding(1251));
                Result += log;
  
                if (log.Contains("Обновление конфигурации успешно завершено"))
                {
                    MsgString = "Обновление конфигурации успешно завершено" + Environment.NewLine;
                    worker.ReportProgress(60 + TekNum / PathUpd.Count * 20, MsgString);
                }
                else
                {
                    MsgString = "При обновлении конфигурации произошла ошибка:" + Environment.NewLine + log;
                    worker.ReportProgress(100, MsgString);
                    return Result; //(?)
                }
            }

            //=====================================================

            if (File.Exists(LogFile)) File.Delete(LogFile);

            string Test = "CONFIG /Out " + quote + LogFile + quote + " /DisableStartupMessages /F "
                + quote + Address + quote + UserPwd + " /IBCheckAndRepair -ReIndex -LogIntegrity -RecalcTotals";
            
            NewProcess = new Process();
            NewProcess.StartInfo.FileName = Start1C;
            NewProcess.StartInfo.Arguments = Test;
            NewProcess.Start();

            lf = true;
            while (!File.Exists(LogFile) || lf)
            {
                try
                {
                    int a = File.ReadAllText(LogFile).Length;
                    if (a > 0) lf = false;
                }
                catch { }
            }

            log = File.ReadAllText(LogFile, Encoding.GetEncoding(1251));
            Result += log;
        
            MsgString = log + Environment.NewLine;
            worker.ReportProgress(90, MsgString);

            if (!log.Contains("Тестирование закончено"))
            {
                return Result;
            }

            //=====================================================
            Result += "Обновление завершено";           

            u = true;
            return Result;
        }

        private void XML_Click(object sender, EventArgs e)
        {
            XML_Parse("2.0.63.4", sender);
        }

        List<TablUpd> XML_Parse(string OldVer, object sender)
        {
         
            string file_xml = Dir.Text + @"\v8cscdsc.xml";

            string xmlString = File.ReadAllText(file_xml, Encoding.UTF8);
            StringReader SR = new StringReader(xmlString);
            XmlReader reader = XmlReader.Create(SR);

      
            string Version = "";
            string FileU = "";
            string Size = "";
            string Target = "";
            List<TablUpd> TU = new List<TablUpd>();

            while (reader.Read())
            {
                if (reader.Name == "v8u:version" && reader.NodeType == XmlNodeType.Element)
                {
                    reader.Read();
                    Version = reader.Value;
                    continue;
                }
                if (reader.Name == "v8u:file" && reader.NodeType == XmlNodeType.Element)
                {
                    reader.Read();
                    FileU = reader.Value;
                    continue;
                }
                if (reader.Name == "v8u:size" && reader.NodeType == XmlNodeType.Element)
                {
                    reader.Read();
                    Size = reader.Value;
                    continue;
                }
                if (reader.Name == "v8u:target" && reader.NodeType == XmlNodeType.Element)
                {
                    reader.Read();
                    Target = reader.Value;
               

                    TablUpd NewTU = new TablUpd(Version, FileU, Size, Target);
                    TU.Add(NewTU);
                }
            }
             
            var LastVerLinq = (from TUElement in TU
                              orderby IndexN(TUElement.Version, 3) descending
                              orderby IndexN(TUElement.Version, 2) descending
                              orderby IndexN(TUElement.Version, 1) descending
                              orderby IndexN(TUElement.Version, 0) descending
                              select TUElement);
                 

            string LastVer = "";
            
            foreach (var V in LastVerLinq)
            {
                LastVer = V.Version;
                break;
            }
                       
            string ThisVer = OldVer;
                  
            List<TablUpd> VersionTU = new List<TablUpd>();

            while (ThisVer != LastVer)
            {
                var OrderLinq = from TUElement in TU
                                where TUElement.Target == ThisVer
                                orderby IndexN(TUElement.Version, 3) descending
                                orderby IndexN(TUElement.Version, 2) descending
                                orderby IndexN(TUElement.Version, 1) descending
                                orderby IndexN(TUElement.Version, 0) descending
                                select TUElement;

                foreach (var V in OrderLinq)
                {
                    ThisVer = V.Version;
                    VersionTU.Add(V);
                    break;
                }
            }

            BackgroundWorker worker = sender as BackgroundWorker;
            string MsgString;
   
            MsgString = "Загружаемые версии:" + Environment.NewLine;
            worker.ReportProgress(30, MsgString);

            foreach (var El in VersionTU)
            {
                MsgString = El.Version + Environment.NewLine;
                worker.ReportProgress(30, MsgString);
            }

          
            return VersionTU;

        }

        long IndexN(string Str, int N)
        {
            string[] Array = Str.Split('.');
            return Convert.ToInt64(Array[N]);
        }

        private void DownloadXML_Click(object sender, EventArgs e)
        {
            //DownloadTemplate();           
        }

        void DownloadTemplate(string confName, string redaction, string platform, object sender)
        {
            string address = @"http://downloads.1c.ru/ipp/ITSREPV/V8Update/Configs/" + confName + "/" + redaction + "/" + platform + @"/v8upd11.zip";

            string pathName = Dir.Text;
            if (!Directory.Exists(pathName))
            { Directory.CreateDirectory(pathName); }
            string fileName = pathName + @"\v8upd11.zip";

            WebClient myWebClient = new WebClient();
            WebProxy wp = new WebProxy("downloads.1c.ru");            
            myWebClient.Proxy = wp;
            Uri myStringWebResource = new Uri(address);

            myWebClient.DownloadFile(myStringWebResource, fileName);
            string fd = Directory.GetParent(fileName).ToString();
            string file_xml = fd + "\\v8cscdsc.xml";
            if (File.Exists(file_xml))
            {
                File.Delete(file_xml);
            }
            ZipFile.ExtractToDirectory(fileName, fd);

            File.Delete(fileName);

            BackgroundWorker worker = sender as BackgroundWorker;
            string MsgString = "Загружен файл v8cscdsc.xml" + Environment.NewLine;
            worker.ReportProgress(20, MsgString);

        }

        private void CFU_Click(object sender, EventArgs e)
        {
            DownloadCFU("Accounting", "2.0.64.34", sender);
        }

        string DownloadCFU(string confName, string Ver, object sender)
        {            
            string Ver_ = Ver.Replace('.', '_');      
            string address = @"/tmplts/1c/" + confName + @"/" + Ver_ + @"/1cv8.zip";
            string pathName = Dir.Text + @"\Обновление1С";

            if (!Directory.Exists(pathName))
            { Directory.CreateDirectory(pathName); }

            string fileName = pathName + @"\" + Ver + ".zip";

            //Создадим каталог для файла обновления
            string fd = Dir.Text + @"\Шаблоны1С\" + confName + @"\" + Ver_;
            if (!Directory.Exists(fd))
            { Directory.CreateDirectory(fd); }

            //проверить, скачивался ли данный релиз ранее (есть ли файл cfu)
            BackgroundWorker worker = sender as BackgroundWorker;
            string MsgString;

            string cfu_file = fd + "\\1cv8.cfu";
            if (File.Exists(cfu_file))
            {
            
                MsgString = "Обнаружено обновление " + Ver + Environment.NewLine;
                worker.ReportProgress(50, MsgString);
                return cfu_file;
            }
            
            //скачиваем

            string AddressServerUpd = "downloads.v8.1c.ru";
            string CodeUser = UP_login.Text;
            string PwdServ = UP_pwd.Text;
       
            dynamic Conn;
            Conn = DB1C.NewObject("HTTPСоединение", AddressServerUpd, 80, CodeUser, PwdServ);
            Conn.Получить(address, fileName);
       
          
            ZipFile.ExtractToDirectory(fileName, fd);
           
            MsgString = "Скачано обновление " + Ver + Environment.NewLine;
            worker.ReportProgress(50, MsgString);
            return cfu_file;
        }

        bool CreateEmptyBase(string UpdBase)
        {
            //string UpdBase = @"C:\UpdBase";

            string Start1C;

            //проверка версии системы и версии платформы.
            if (Directory.Exists(@"C:\Program Files (x86)"))
            {
                Start1C = @"C:\Program Files (x86)\1cv8\common\1cestart.exe";
                if (!Directory.Exists(@"C:\Program Files (x86)\1cv8"))
                {
                    Start1C = @"C:\Program Files (x86)\1cv82\common\1cestart.exe";
                }
            }
            else
            {
                Start1C = @"C:\Program Files\1cv8\common\1cestart.exe";
                if (!Directory.Exists(@"C:\Program Files\1cv8"))
                {
                    Start1C = @"C:\Program Files\1cv82\common\1cestart.exe";
                }
            }

            if (!Directory.Exists(Dir.Text + @"\Log"))
            { Directory.CreateDirectory(Dir.Text + @"\Log"); }
            string LogFile = Dir.Text + @"\Log\LogFile.txt";
            const char quote = '\u0022';

            //try
            //{
            //    if (Directory.Exists(UpdBase)) { Directory.Delete(UpdBase, true); }
            //}
            //catch { }

            //if (File.Exists(LogFile)) File.Delete(LogFile);

           
            string Archive = "";
            if (!Directory.Exists(UpdBase))
            {
                Archive = "CREATEINFOBASE File=" + quote + UpdBase + quote + "/Out " + quote + LogFile + quote;
                Process NewProcess = new Process();
                NewProcess.StartInfo.FileName = Start1C;
                NewProcess.StartInfo.Arguments = Archive;
                NewProcess.Start();
            }
            else 
            {
                return true;
            }

            bool lf = true;
            while (!File.Exists(LogFile) || lf)
            {
                try
                {
                    int a = File.ReadAllText(LogFile).Length;
                    if (a > 0) lf = false;
                }
                catch { }
            }

            string log = File.ReadAllText(LogFile, Encoding.GetEncoding(1251));
            

            if (log.Contains("успешно завершено"))
            { return true; }
            else
            { return false; }
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 100; i++)
            {
                comboBox1.Items.Add(i.ToString());
            }

            Msg1.Text = "";

            Dir.Text = @"D:\!АйТи";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            num = comboBox1.SelectedItem.ToString();
            if (num.Length == 1) { num = "00000000" + num; }
            if (num.Length == 2) { num = "0000000" + num; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy != true)
            {
                // Start the asynchronous operation.
                Msg1.Text = "Данные загружаются...";
                backgroundWorker1.RunWorkerAsync();
            }            
        }       

        private void button3_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            textBox2.Clear();
            backgroundWorker2.RunWorkerAsync();     
            
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {  
            using (Service service = new Service())
            {
                service.SoapVersion = System.Web.Services.Protocols.SoapProtocolVersion.Soap12;
                service.Credentials = new System.Net.NetworkCredential(WS_login, WS_pass);
                ArrRequest = service.GetRequest(num);

                if (ArrRequest == null)
                {
                    MessageBox.Show("Данные не обнаружены");
                    return;
                }                
            }

            BackgroundWorker worker = sender as BackgroundWorker;
            worker.ReportProgress(0);
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            textBox2.Clear();
            dataGridView1.RowCount = 0;
          
            foreach (var Str in ArrRequest)
            {
                int NewStr = dataGridView1.Rows.Add();
                dataGridView1.Rows[NewStr].Cells["Konfig"].Value = Str.Konfig;
                dataGridView1.Rows[NewStr].Cells["Reliz"].Value = Str.Reliz;
                dataGridView1.Rows[NewStr].Cells["Platform"].Value = Str.Platform;
                dataGridView1.Rows[NewStr].Cells["Address"].Value = Str.Address;
                dataGridView1.Rows[NewStr].Cells["User"].Value = Str.User;
                dataGridView1.Rows[NewStr].Cells["Pass"].Value = Str.Pass;
                dataGridView1.Rows[NewStr].Cells["Code"].Value = Str.Code;
                dataGridView1.Rows[NewStr].Cells["Up"].Value = true;
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Msg1.Text = "Данные получены";
        }

        private void Add_Click(object sender, EventArgs e)
        {
           int NewStr = dataGridView1.Rows.Add();
           dataGridView1.Rows[NewStr].Cells["Up"].Value = false;
           dataGridView1.Rows[NewStr].Cells["User"].Value = "";
           dataGridView1.Rows[NewStr].Cells["Pass"].Value = "";
           dataGridView1.Rows[NewStr].Cells["Address"].Value = "";
           dataGridView1.Rows[NewStr].Cells["Reliz"].Value = "";
           dataGridView1.Rows[NewStr].Cells["Konfig"].Value = "";
           dataGridView1.Rows[NewStr].Cells["Platform"].Value = "";
           dataGridView1.Rows[NewStr].Cells["Code"].Value = "";
        }

        private void Del_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
            {
                dataGridView1.Rows.RemoveAt(cell.RowIndex);
            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            string MsgString;

            //создаем пустую базу

            string UpdBase = Dir.Text + @"\UpdBase";
            //string UpdBase = @"C:\UpdBase";
            if (!CreateEmptyBase(UpdBase))
            {
               
                MsgString = "Не удалось скачать обновления (ошибка подключения)" + Environment.NewLine;
                worker.ReportProgress(100, MsgString);
                return; // "Не удалось скачать обновления (ошибка подключения)";
            }

            //создаем СОМ-соединение

            V83.COMConnector com1s = new V83.COMConnector();
            com1s.PoolCapacity = 10;
            com1s.PoolTimeout = 60;
            com1s.MaxConnections = 2;

            string path_connect_file = "File='" + UpdBase + "';";
         

            try
            {
                DB1C = com1s.Connect(path_connect_file);
              
                MsgString = "Подключение выполнено успешно" + Environment.NewLine;
                worker.ReportProgress(1, MsgString);                
            }
            catch
            {
                MessageBox.Show("Не удалось подключиться");
               
                MsgString = "Не удалось скачать обновления (ошибка подключения)" + Environment.NewLine;
                worker.ReportProgress(100, MsgString);
                return;// "Не удалось скачать обновления"; 
            }
            
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if ((bool)row.Cells["Up"].Value == true)
                {
                    worker.ReportProgress(1, "");

                    //обнуляем переменные
                    num = "";
                    NVer = "";
                    u = false;

                    int Str = row.Index;

                    if ((row.Cells["Address"].Value.ToString() == "") | (row.Cells["Reliz"].Value.ToString() == "") | (row.Cells["Konfig"].Value.ToString() == "") | (row.Cells["Platform"].Value.ToString() == ""))
                    {
                        MsgString = "Проверьте, заполнены ли все поля" + Environment.NewLine;
                        worker.ReportProgress(100, MsgString);
                        break;
                    }                  

                    string Login_user;
                    if (row.Cells["User"].Value == null)
                    { Login_user = ""; }
                    else
                    { Login_user = row.Cells["User"].Value.ToString(); }
                    
                    string Pas_user = row.Cells["Pass"].Value.ToString();
                    string file_db_user = row.Cells["Address"].Value.ToString();
                    string ThisVer = row.Cells["Reliz"].Value.ToString();
                    string confName = row.Cells["Konfig"].Value.ToString();
                    string platform = row.Cells["Platform"].Value.ToString();
                    string Code = row.Cells["Code"].Value.ToString();


                    MsgString = "===== Начато обновление базы " + file_db_user + " =====" + Environment.NewLine;
                    worker.ReportProgress(10, MsgString);

                    List<string> PathUpd = UpdateUserBase(ThisVer, confName, platform, sender); //получаем пути обновлений
                    //обновляем
                    if (PathUpd.Count > 0)
                    {
                        string Result = BatFile(Login_user, Pas_user, file_db_user, PathUpd, sender);

                        if (u && (Code != "")) //выполнено без ошибок И значение получено из БД
                        {
                            //передаем обратно версию обновления
                            using (Service service = new Service())
                            {
                                service.SoapVersion = System.Web.Services.Protocols.SoapProtocolVersion.Soap12;
                                service.Credentials = new System.Net.NetworkCredential(WS_login, WS_pass);
                                
                                var NumRequest = service.ReturnReliz(Code, NVer);
                            }
                            
                        }
                        SendMessage(Result, sender);

                        MsgString = "===== Обновление завершено =====" + Environment.NewLine;
                        worker.ReportProgress(100, MsgString);
                       
                    }
                    else
                    {
                       
                        MsgString = "Обновление не выполнено" + Environment.NewLine;
                        worker.ReportProgress(100, MsgString);

                    }
                }
            }

            //удаляем СОМ

            if (Directory.Exists(UpdBase))
                try
                {
                    Directory.Delete(UpdBase, true);
                }
                catch { }

            backgroundWorker2.Dispose();
        }

        private void backgroundWorker2_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            textBox2.Text += e.UserState.ToString();
        }

        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            textBox2.Text += "Обновление всех баз завершено";
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (dataGridView1.RowCount > 0) button3.Enabled = true;
        }
        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (dataGridView1.RowCount == 0) button3.Enabled = false;
        }

        private void ChDir_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            Dir.Text = folderBrowserDialog1.SelectedPath;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }


        
    }
}



