
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using HtmlAgilityPack;
using System.IO;
using System.Text;
//using RobotsTxt;
using Strictly.RobsRobot;
using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace WindowsFormsApp2
{
    public partial class mainScreen : Form
    {
        public string strConn;
        private TreeNode[] svrNode = new TreeNode[500]; 
        private TreeNode[] sideNode = new TreeNode[50];

        public string connectionString;
        public string myUserAgent = "Mozilla / 5.0(Macintosh; Intel Mac OS X 10_12_6) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/61.0.3163.100 Safari/537.36";

        public mainScreen()
        {
            InitializeComponent();
        }
        private bool IsSiteConnected(string sURL)
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
            tsStatusLabel1.Text = "사이트에 접속중입니다.";
            string ret;
                try
                {
                    // Here we create the request and write the POST data to it.
                    var request = (HttpWebRequest)HttpWebRequest.Create(sURL);
                    request.Method = "GET";
                    HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                    if (HttpStatusCode.OK == response.StatusCode)
                    {
                        Stream dataStream = response.GetResponseStream();
                        StreamReader reader = new StreamReader(dataStream);
                        ret = reader.ReadToEnd();
                        response.Close();
                    }
                    return true;
                }
                catch (WebException e)
                {
                    using (WebResponse response = e.Response)
                    {
                        HttpWebResponse httpResponse = (HttpWebResponse)response;
                        if (httpResponse == null)
                        {
                        tsStatusLabel1.Text = " 사이트 연결이 되지 않습니다. "; // Error code: " + httpResponse.StatusCode;
                            wb.Browser.LoadURL("About:blank");
                            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
                            chkURL.Checked = true;
                            return false;
                        }

                    using (Stream data = response.GetResponseStream())
                        {
                            string text = new StreamReader(data).ReadToEnd();
                            tsStatusLabel1.Text = text;
                        }
                    }
                    tsStatusLabel1.Text = e.Message;
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
                return false;

                }
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
        }
        public bool IsInternetConnected2(string urlToConnect)
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead(urlToConnect))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public bool IsInternetConnected()
        {
            const string NCSI_TEST_URL = "http://www.msftncsi.com/ncsi.txt";
            const string NCSI_TEST_RESULT = "Microsoft NCSI";
            const string NCSI_DNS = "dns.msftncsi.com";
            const string NCSI_DNS_IP_ADDRESS = "131.107.255.255";
            
            try
            {
                // Check NCSI test link
                var webClient = new WebClient();
                string result = webClient.DownloadString(NCSI_TEST_URL);
                if (result != NCSI_TEST_RESULT)
                {
                    return false;
                }

                // Check NCSI DNS IP
                var dnsHost = Dns.GetHostEntry(NCSI_DNS);
                if (dnsHost.AddressList.Count() < 0 || dnsHost.AddressList[0].ToString() != NCSI_DNS_IP_ADDRESS)
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return false;
            }

            return true;
        }
        private void label8_Click(object sender, EventArgs e)
        {

        }
       
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void LoadInitValue()
        {
            dateFrom.Text = DateTime.Now.AddMonths(-1).ToString();
            dateTo.Text = DateTime.Now.ToString();
            txtREQID2.Enabled = true;
            txtNM_EMP_REG2.Enabled = true;
            

        }
        private void LoadInitFile()
        {
            // This sample assumes that you have a folder named "c:\temp" on your computer.
            string filePath = Application.ExecutablePath+".ini";

            // Delete the file if it exists.
            if (File.Exists(filePath))
            {
                // Open the stream and read it back.
                using (FileStream fs = File.Open(filePath, FileMode.Open, FileAccess.Read))
                {
                    byte[] b = new byte[1024];
                    UTF8Encoding temp = new UTF8Encoding(true);

                    try
                    {
                        while (fs.Read(b, 0, b.Length) > 0)
                        {
                            connectionString = temp.GetString(b);
                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("chkCrawler 실패:" + ex.Message, "chkCrawler Error");
       
                    }
                }
            }
            else
            {
                // Create the file.
                using (FileStream fs = File.Create(filePath))
                {
                    Byte[] info = new UTF8Encoding(true).GetBytes("SERVER=localhost;DATABASE=ems;UID=root;PASSWORD=!root!;SslMode=none");
                    // Add some information to the file.
                    fs.Write(info, 0, info.Length);
                    fs.Close();
                }
            }
            
        }
        private void LoadCrawlerReq(string strQuery)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                try
                {
                    connection.Open();

                    // 데이터 검색
                    MySqlCommand selectCommand = new MySqlCommand();
                    selectCommand.Connection = connection;
                    selectCommand.CommandText = strQuery;

                    DataSet ds = new DataSet();
                    MySqlDataAdapter da = new MySqlDataAdapter(selectCommand.CommandText, connection);
                    da.Fill(ds, "an_ext_crawler_request");
                    if (ds.Tables.Count > 0)
                    {
                        foreach (DataRow row in ds.Tables[0].Rows)
                        {
                            txtREQID.Text = row["ID_CRAWLER_REQ"].ToString();
                            txtREQID2.Text = txtREQID.Text;
                            txtCATEGORY_KEYWORD.Text = row["CATEGORY_KEYWORD"].ToString();
                            txtCATEGORY_KEYWORD2.Text = txtCATEGORY_KEYWORD.Text;
                            txtREQID3.Text = txtREQID.Text;
                            txtNM_EMP_REG.Text = row["NM_EMP_REG"].ToString();
                            txtSEARCH_KEYWORD.Text = row["SEARCH_KEYWORD"].ToString();
                            txtEMBED_KEYWORD.Text = row["EMBED_KEYWORD"].ToString();
                            txtNO_KEYWORD.Text = row["NO_KEYWORD"].ToString();
                             
                            switch (row["POSSIBLE_YN"].ToString())
                            {
                                case "0":
                                    rbBeforeChk.Checked =true;
                                    rbOKScrap.Checked = false;
                                    rbNOScrap.Checked = false;
                                    break;
                                case "Y":
                                    rbBeforeChk.Checked = false;
                                    rbOKScrap.Checked = true;
                                    rbNOScrap.Checked = false;
                                    break;

                                case "N":
                                    rbBeforeChk.Checked = false;
                                    rbNOScrap.Checked = true;
                                    rbOKScrap.Checked = false;
                                    break;
                                default:  break;
                            }

                               
                            txtBEGIN_DT.Text = row["BEGIN_DT"].ToString();
                            txtEND_DT.Text = row["END_DT"].ToString();
                            tsStatusLabel1.Text =  "DB에서 해당 URL의 신청내역을 찿았습니다.";
                        }
                    }
                    connection.Close();
                    chkDB.Checked = false;
                }
                catch (Exception ex)
                {
                    chkDB.Checked = true;
                    tsStatusLabel1.Text = "데이터 베이스 오픈 실패:" + ex.Message + "Database Error[MYSQL]";
                }
                finally
                {
                    connection.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
        }

        private void LoadCrawlerTree(string strQry)
        {
            treeView1.Nodes.Clear();
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {

                try
                {
                    connection.Open();                    

                    // 데이터 검색

                    MySqlCommand selectCommand = new MySqlCommand();

                    selectCommand.Connection = connection;

                    selectCommand.CommandText = strQry;

                    DataSet ds = new DataSet();

                    MySqlDataAdapter da = new MySqlDataAdapter(strQry, connection);

                    da.Fill(ds);
                    int i=0,j=0;

                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        string seq = row["ID_CRAWLER_SEQ"].ToString();
                        int comparison = seq.CompareTo("1");
                        if (comparison < 0) { }
                           // Console.WriteLine($"<{root}> is less than <{root2}>");
                        else if (comparison > 0) {
                            j++;
                            sideNode[j] = new TreeNode(" "+ row["ID_CRAWLER_REQ"].ToString() + " " + row["REQ_URL"].ToString());
                            svrNode[i].Nodes.Add(sideNode[j]);
                            
                        }
                        else {  // 1
                            svrNode[i] = new TreeNode(row["NM_EMP_REG"].ToString()+" #"+ row["CATEGORY_KEYWORD"].ToString()+"# ");
                            sideNode[j] = new TreeNode(" " + row["ID_CRAWLER_REQ"].ToString() + " " + row["REQ_URL"].ToString());

                            treeView1.Nodes.Add(svrNode[i]);
                            svrNode[i].Nodes.Add(sideNode[j]);
                          
                        }
                    }
                    treeView1.ExpandAll();
                    connection.Close();
                    chkDB.Checked = false;
                }
                catch (Exception ex)

                {
                    chkDB.Checked = true;
                    tsStatusLabel1.Text= "chkCrawler.exe.ini화일을 수정하시거나 데이터 베이스 연결를 점검해주세요. " + ex.Message+ "Database Error[MYSQL]";
                }

                finally

                {
                    connection.Close();
                }
            
                

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            tsStatusLabel1.Text = "상단 트리메뉴에서 확인할 맟춤형 URL를 선택해 주세요.";
            txtDomain.ReadOnly = true;
            //chk001.Checked = false;
            InitCheckNetworkState();

            //this.wb.Navigate("https://section.blog.naver.com/BlogHome.nhn?directoryNo=24&currentPage=1&groupId=0");
            LoadInitFile();
            LoadInitValue();
            LoadCrawlerTree("SELECT * FROM an_ext_crawler_request order by REQ_DT,ID_EMP_REG,ID_CRAWLER_REQ,ID_CRAWLER_SEQ");
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {

            
        }



        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnTestMysql_Click(object sender, EventArgs e)
        {
            LoadCrawlerReq("SELECT * FROM an_ext_crawler_request order by REQ_DT,ID_EMP_REG,ID_CRAWLER_REQ,ID_CRAWLER_SEQ");
        }
        private Boolean CheckRobotTxt(String txtURL)
        {
            Robot.ParseRobotsTxtFile(txtURL.AsDomain());

            // Once parsed we can check whether URLs are allowed to be accessed or
            // not depending on the rules in the Robots.txt file.
            if (Robot.URLIsAllowed(txtURL))
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }
        private void btnClearNode_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            txtURL.Text = "";
            txtDomain.Text = "";
            tsStatusLabel1.Text = "스크랩핑 확인 버튼을 클릭해주세요";

            InitCheckNetworkState();
            if (e.Node.Text.Length > 10)
            {
                string enodeKey;
                
                enodeKey=Regex.Replace(e.Node.Text, "(NO\\.? )", String.Empty);
                string[] words = enodeKey.Split('#');
                if(words.Length == 3)
                {
                    bool allDigits = words[1].All(char.IsDigit);
                    if (allDigits == true)
                    {
                        tsStatusLabel1.Text = "사이트 검색은 분석번호가 아니라 URL 이 있는 노드를 클릭해주세요";
                        return;
                    }
                }
                else
                {
                    words = enodeKey.Split(' ');
                    enodeKey = words[1].ToString();
                }

                LoadCrawlerReq("SELECT * FROM an_ext_crawler_request " + " where ID_CRAWLER_REQ='" + enodeKey + "'" + " order by REQ_DT,ID_EMP_REG,ID_CRAWLER_REQ,ID_CRAWLER_SEQ");
                txtREQID.Text = words[1].ToString();
                txtURL.Text = words[2].ToString();  //99201 81021 01200 01
                txtURL2.Text = txtURL.Text;
                txtDomain.Text = txtURL.Text.AsDomain();
                txtDomain2.Text = txtDomain.Text;

                if (chkNameServer.Checked == true )
                {
                    tsStatusLabel1.Text = "인터넷 연결이 되지 않습니다.";
                    return;
                }
                else
                {
                    if (chkDB.Checked == true)
                    {
                        tsStatusLabel1.Text = "마리아DB 연결이 되지 않습니다.";
                        return;
                    }

                }
            }
            else
            {
                return;
            }

        }

        #region Definitions/DLL Imports
        /// <summary>
        /// For PInvoke: Contains information about an entry in the Internet cache
        /// </summary>
        [StructLayout(LayoutKind.Explicit, Size = 80)]
        public struct INTERNET_CACHE_ENTRY_INFOA
        {
            [FieldOffset(0)]
            public uint dwStructSize;
            [FieldOffset(4)]
            public IntPtr lpszSourceUrlName;
            [FieldOffset(8)]
            public IntPtr lpszLocalFileName;
            [FieldOffset(12)]
            public uint CacheEntryType;
            [FieldOffset(16)]
            public uint dwUseCount;
            [FieldOffset(20)]
            public uint dwHitRate;
            [FieldOffset(24)]
            public uint dwSizeLow;
            [FieldOffset(28)]
            public uint dwSizeHigh;
            [FieldOffset(32)]
            public System.Runtime.InteropServices.ComTypes.FILETIME LastModifiedTime;
            [FieldOffset(40)]
            public System.Runtime.InteropServices.ComTypes.FILETIME ExpireTime;
            [FieldOffset(48)]
            public System.Runtime.InteropServices.ComTypes.FILETIME LastAccessTime;
            [FieldOffset(56)]
            public System.Runtime.InteropServices.ComTypes.FILETIME LastSyncTime;
            [FieldOffset(64)]
            public IntPtr lpHeaderInfo;
            [FieldOffset(68)]
            public uint dwHeaderInfoSize;
            [FieldOffset(72)]
            public IntPtr lpszFileExtension;
            [FieldOffset(76)]
            public uint dwReserved;
            [FieldOffset(76)]
            public uint dwExemptDelta;
        }

        // For PInvoke: Initiates the enumeration of the cache groups in the Internet cache
        [DllImport(@"wininet",
            SetLastError = true,
            CharSet = CharSet.Auto,
            EntryPoint = "FindFirstUrlCacheGroup",
            CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr FindFirstUrlCacheGroup(
            int dwFlags,
            int dwFilter,
            IntPtr lpSearchCondition,
        int dwSearchCondition,
        ref long lpGroupId,
        IntPtr lpReserved);

        // For PInvoke: Retrieves the next cache group in a cache group enumeration
        [DllImport(@"wininet",
        SetLastError = true,
            CharSet = CharSet.Auto,
        EntryPoint = "FindNextUrlCacheGroup",
            CallingConvention = CallingConvention.StdCall)]
        public static extern bool FindNextUrlCacheGroup(
            IntPtr hFind,
            ref long lpGroupId,
            IntPtr lpReserved);

        // For PInvoke: Releases the specified GROUPID and any associated state in the cache index file
        [DllImport(@"wininet",
            SetLastError = true,
            CharSet = CharSet.Auto,
            EntryPoint = "DeleteUrlCacheGroup",
            CallingConvention = CallingConvention.StdCall)]
        public static extern bool DeleteUrlCacheGroup(
            long GroupId,
            int dwFlags,
            IntPtr lpReserved);

        // For PInvoke: Begins the enumeration of the Internet cache
        [DllImport(@"wininet",
            SetLastError = true,
            CharSet = CharSet.Auto,
            EntryPoint = "FindFirstUrlCacheEntryA",
            CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr FindFirstUrlCacheEntry(
            [MarshalAs(UnmanagedType.LPTStr)] string lpszUrlSearchPattern,
            IntPtr lpFirstCacheEntryInfo,
            ref int lpdwFirstCacheEntryInfoBufferSize);

        // For PInvoke: Retrieves the next entry in the Internet cache
        [DllImport(@"wininet",
            SetLastError = true,
            CharSet = CharSet.Auto,
            EntryPoint = "FindNextUrlCacheEntryA",
            CallingConvention = CallingConvention.StdCall)]
        public static extern bool FindNextUrlCacheEntry(
            IntPtr hFind,
            IntPtr lpNextCacheEntryInfo,
            ref int lpdwNextCacheEntryInfoBufferSize);

        // For PInvoke: Removes the file that is associated with the source name from the cache, if the file exists
        [DllImport(@"wininet",
            SetLastError = true,
            CharSet = CharSet.Auto,
            EntryPoint = "DeleteUrlCacheEntryA",
            CallingConvention = CallingConvention.StdCall)]
        public static extern bool DeleteUrlCacheEntry(
            IntPtr lpszUrlName);
        #endregion

        #region Public Static Functions

        /// <summary>
        /// Clears the cache of the web browser
        /// </summary>
        public static void ClearCache()
        {
            // Indicates that all of the cache groups in the user's system should be enumerated
            const int CACHEGROUP_SEARCH_ALL = 0x0;
            // Indicates that all the cache entries that are associated with the cache group
            // should be deleted, unless the entry belongs to another cache group.
            const int CACHEGROUP_FLAG_FLUSHURL_ONDELETE = 0x2;
            // File not found.
            const int ERROR_FILE_NOT_FOUND = 0x2;
            // No more items have been found.
            const int ERROR_NO_MORE_ITEMS = 259;
            // Pointer to a GROUPID variable
            long groupId = 0;

            // Local variables
            int cacheEntryInfoBufferSizeInitial = 0;
            int cacheEntryInfoBufferSize = 0;
            IntPtr cacheEntryInfoBuffer = IntPtr.Zero;
            INTERNET_CACHE_ENTRY_INFOA internetCacheEntry;
            IntPtr enumHandle = IntPtr.Zero;
            bool returnValue = false;

            // Delete the groups first.
            // Groups may not always exist on the system.
            // For more information, visit the following Microsoft Web site:
            // http://msdn.microsoft.com/library/?url=/workshop/networking/wininet/overview/cache.asp            
            // By default, a URL does not belong to any group. Therefore, that cache may become
            // empty even when the CacheGroup APIs are not used because the existing URL does not belong to any group.            
            enumHandle = FindFirstUrlCacheGroup(0, CACHEGROUP_SEARCH_ALL, IntPtr.Zero, 0, ref groupId, IntPtr.Zero);
            // If there are no items in the Cache, you are finished.
            if (enumHandle != IntPtr.Zero && ERROR_NO_MORE_ITEMS == Marshal.GetLastWin32Error())
                return;

            // Loop through Cache Group, and then delete entries.
            while (true)
            {
                if (ERROR_NO_MORE_ITEMS == Marshal.GetLastWin32Error() || ERROR_FILE_NOT_FOUND == Marshal.GetLastWin32Error()) { break; }
                // Delete a particular Cache Group.
                returnValue = DeleteUrlCacheGroup(groupId, CACHEGROUP_FLAG_FLUSHURL_ONDELETE, IntPtr.Zero);
                if (!returnValue && ERROR_FILE_NOT_FOUND == Marshal.GetLastWin32Error())
                {
                    returnValue = FindNextUrlCacheGroup(enumHandle, ref groupId, IntPtr.Zero);
                }

                if (!returnValue && (ERROR_NO_MORE_ITEMS == Marshal.GetLastWin32Error() || ERROR_FILE_NOT_FOUND == Marshal.GetLastWin32Error()))
                    break;
            }

            // Start to delete URLs that do not belong to any group.
            enumHandle = FindFirstUrlCacheEntry(null, IntPtr.Zero, ref cacheEntryInfoBufferSizeInitial);
            if (enumHandle != IntPtr.Zero && ERROR_NO_MORE_ITEMS == Marshal.GetLastWin32Error())
                return;

            cacheEntryInfoBufferSize = cacheEntryInfoBufferSizeInitial;
            cacheEntryInfoBuffer = Marshal.AllocHGlobal(cacheEntryInfoBufferSize);
            enumHandle = FindFirstUrlCacheEntry(null, cacheEntryInfoBuffer, ref cacheEntryInfoBufferSizeInitial);

            while (true)
            {
                internetCacheEntry = (INTERNET_CACHE_ENTRY_INFOA)Marshal.PtrToStructure(cacheEntryInfoBuffer, typeof(INTERNET_CACHE_ENTRY_INFOA));
                if (ERROR_NO_MORE_ITEMS == Marshal.GetLastWin32Error()) { break; }

                cacheEntryInfoBufferSizeInitial = cacheEntryInfoBufferSize;
                returnValue = DeleteUrlCacheEntry(internetCacheEntry.lpszSourceUrlName);
                if (!returnValue)
                {
                    returnValue = FindNextUrlCacheEntry(enumHandle, cacheEntryInfoBuffer, ref cacheEntryInfoBufferSizeInitial);
                }
                if (!returnValue && ERROR_NO_MORE_ITEMS == Marshal.GetLastWin32Error())
                {
                    break;
                }
                if (!returnValue && cacheEntryInfoBufferSizeInitial > cacheEntryInfoBufferSize)
                {
                    cacheEntryInfoBufferSize = cacheEntryInfoBufferSizeInitial;
                    cacheEntryInfoBuffer = Marshal.ReAllocHGlobal(cacheEntryInfoBuffer, (IntPtr)cacheEntryInfoBufferSize);
                    returnValue = FindNextUrlCacheEntry(enumHandle, cacheEntryInfoBuffer, ref cacheEntryInfoBufferSizeInitial);
                }
            }
            Marshal.FreeHGlobal(cacheEntryInfoBuffer);
        }
        #endregion
        // Navigates to the given URL if it is valid.
        private void Navigate(String address)
        {
            if (String.IsNullOrEmpty(address)) return;
            if (address.Equals("about:blank"))
            {
                wb.Browser.LoadURL("about:blank");
                return;
            }
            if (!address.StartsWith("http://") &&
                !address.StartsWith("https://"))
            {
                address = "http://" + address;
            }
            try
            {
                //wb.Navigate(new Uri(address) + "?refreshToken=" + Guid.NewGuid().ToString());
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
                tsStatusLabel1.Text = address + "에 연결합니다.";
                wb.Browser.LoadURL(address);
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
                chkStep1.Checked = true;
                chkStep2.Checked = true;
                chkStepEtc.Checked = true;
                wb.Refresh();

            }
            catch (System.UriFormatException)
            {
                return;
            }
        }
        private void btnMakeURL_Click(object sender, EventArgs e)
        {

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
            /*!40101 SET NAMES utf8 */
            ;
            /*!50503 SET NAMES utf8mb4 */
            ;
            /*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */
            ;
            /*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */
            ;

            //--테이블 데이터 ems.an_ext_crawler_request: ~3 rows(대략적) 내보내기
           /*!40000 ALTER TABLE `an_ext_crawler_request` DISABLE KEYS */;
            //INSERT INTO `an_ext_crawler_request` (`ID_CRAWLER_REQ`, `ID_CRAWLER_SEQ`, `REQ_DT`, `REQ_URL`, `REQ_DONE_DT`, `CHANNEL`, `POSSIBLE_YN`, `PROCESS_STATE`, `DT_PROCESS`, `NO_CAUSE`, `ID_URL`, `PW_URL`, `NM_EMP_REG`, `ID_EMP_REG`, `DT_REG`, `ID_EMP_UPT`, `DT_UPT`) VALUES
           //     (99201810210120001, 1, '20181021', 'http://www.naver.com/1', NULL, '0', '0', '0', NULL, 'N', NULL, NULL, NULL, NULL, NULL, NULL, NULL),
	//(99201810210120002, 2, '20181021', 'http://www.naver.com/2', NULL, '0', '0', '0', NULL, 'N', NULL, NULL, NULL, NULL, NULL, NULL, NULL),
	//(99201810221012001, 1, '20181021', 'http://www.naver.com', NULL, '0', '0', '0', NULL, 'N', NULL, NULL, NULL, NULL, NULL, NULL, NULL);
            /*!40000 ALTER TABLE `an_ext_crawler_request` ENABLE KEYS */
            ;

            /*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */
            ;
            /*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */
            ;
            /*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */
            ;

        }

        private void wb_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
                                                                               //If the control is not docked
           
        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void chk204_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string strQry;
            string strBegin;
            string strEnd;
            strQry = "SELECT * FROM an_ext_crawler_request ";
            strBegin = dateFrom.Value.ToString("yyyyMMdd");
            strEnd = dateTo.Value.ToString("yyyyMMdd");
            strQry = strQry + "  where REQ_DT>='" + strBegin + "'";
            strQry = strQry + "  and REQ_DT<='" + strEnd + "'";
            if (txtNM_EMP_REG2.Text.Length > 2)
                strQry = strQry + "  and NM_EMP_REG='" + txtNM_EMP_REG2.Text.Trim() + "'";
            if (txtCATEGORY_KEYWORD2.Text.Length > 2)
               strQry= strQry + "  and CATEGORY_KEYWORD like '" + txtCATEGORY_KEYWORD2.Text.Trim()+"'";
            strQry = strQry + "  order by REQ_DT,ID_EMP_REG,ID_CRAWLER_REQ,ID_CRAWLER_SEQ";
            LoadCrawlerReq(strQry);
            LoadCrawlerTree(strQry);
        }

        private void btnClearNode_Click_1(object sender, EventArgs e)
        {

        }

        private void 프로그램정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You could change MariaDB host ip in a 'chkCrawler.exe.ini' file. ","HELP");
        }


        private void CreateMySqlCommand(string myExecuteQuery, string strMsg)
        {
            try
            {
                MySqlConnection myConnection = new MySqlConnection(connectionString);
                MySqlCommand myCommand = new MySqlCommand(myExecuteQuery, myConnection);

                myCommand.Connection.Open();
                myCommand.ExecuteNonQuery();
                myConnection.Close();
                MessageBox.Show(strMsg, "확인");
                tsStatusLabel1.Text = strMsg;
            }
            catch (MySqlException ex)
            {
                tsStatusLabel1.Text = ex.ToString();
            }
            finally
            {
            }
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            String strQry;
            strQry = "update an_ext_crawler_request set possible_yn='Y'  where id_crawler_req='" +txtREQID2.Text  +"';";
            
            CreateMySqlCommand(strQry,"스크랩핑이 가능하도록 승인으로 등록되었습니다.");
            rbBeforeChk.Checked = false;
            rbOKScrap.Checked = true;
            rbNOScrap.Checked = false;
        }

        private void btnDeny_Click(object sender, EventArgs e)
        {
            String strQry;
            strQry = "update an_ext_crawler_request set possible_yn='N'  where id_crawler_req='" + txtREQID2.Text + "';";
            CreateMySqlCommand(strQry, "스크랩핑이 불가하도록 승인불가로 등록되었습니다.");
            rbBeforeChk.Checked = false;
            rbOKScrap.Checked = false;
            rbNOScrap.Checked = true;
        }

        private void treeView1_AfterSelect_1(object sender, TreeViewEventArgs e)
        {
            treeView1_AfterSelect( sender,  e);
        }

        private void btnConfirm_Click_1(object sender, EventArgs e)
        {
            btnConfirm_Click(sender, e);
        }

        private void btnDeny_Click_1(object sender, EventArgs e)
        {
            btnDeny_Click(sender, e);

        }
        private int MakeParsing()
        {
            var web1 = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc1 = null;
            try
            {

                doc1 = web1.LoadFromBrowser(txtURL.Text, o =>
                {
                    var webBrowser = (WebBrowser)o;

                    // WAIT until the dynamic text is set

                    return !string.IsNullOrEmpty(webBrowser.Document.GetElementById("uiDynamicText").InnerText);

                });
                var t1 = doc1.DocumentNode.SelectSingleNode("//div[@id='uiDynamicText']").InnerText;

                var web2 = new HtmlWeb();
                var doc2 = web2.LoadFromBrowser(txtURL.Text, html =>
                {
                    // WAIT until the dynamic text is set
                    return !html.Contains("<div id=\"uiDynamicText\"></div>");
                });
                var t2 = doc2.DocumentNode.SelectSingleNode("//div[@id='uiDynamicText']").InnerText;
                // "http://html-agility-pack.net/from-browser";
                return 0;

            }
            catch (System.UriFormatException ex1)
            {
                tsStatusLabel1.Text = ex1.Message;
                return -98;
            }
            catch (System.NullReferenceException ex)
            {
                tsStatusLabel1.Text = ex.Message;
                return -99;
            }

        }
        private void InitCheckNetworkState()
        {
            chkStep1.Checked = false;
            chkStep2.Checked = false;
            chkStepEtc.Checked = false;
            chkHtmlParse.Checked = false;
            chkROBOTS.Checked = false;
            chkURL.Checked = false;
            if (IsInternetConnected() == true)
            {
                chkNameServer.Checked = false;
            }
            else
            {
                chkNameServer.Checked = true;
                tsStatusLabel1.Text = "Name Server 설정에 오류가 있습니다.";
                DialogResult dr = MessageBox.Show("인터넷 접속에 오류가 발생하는데 프로그램을 종료 하시겠습니까?", "인터넷연결확인", MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes:
                        Application.Exit();
                        break;
                    case DialogResult.No:
                        break;
                }
            }
        }
        private void bntCheck_Click_3(object sender, EventArgs e)
        {
            CheckAll(txtURL.Text);
        }
        private void CheckAll(string txtURL)
        {
            int ret;

            InitCheckNetworkState();


            ret = CheckStep1(txtURL);
            if (ret == 0)
            {
                chkStep1.Checked = true;
            }
            else
            {
                chkStep1.Checked = false;
                return;
            }
            ret = CheckStep2();
            if (ret == 0)
            {
                chkStep2.Checked = true;
            }
            else
            {
                chkStep2.Checked = false;
                return;
            }
            ret = CheckStep3();
            if (ret == 0)
            {
                chkStepEtc.Checked = true;
            }
            else
            {
                chkStepEtc.Checked = false;
                return;
            }


        }
        private int CheckStep1(string txtURL)
        {
            if (txtURL.Length == 0)
            {
                tsStatusLabel1.Text = "해당 URL를 선택해주세요.";
                return -1;
            }

            if (IsInternetConnected() == true)
            {
                chkNameServer.Checked = false;
            }
            else
            {
                chkNameServer.Checked = true;
                tsStatusLabel1.Text = "Name Server 설정에 오류가 있습니다.";
                return -2;
            }
            Boolean retStep1 = false;
            retStep1 = CheckRobotTxt(txtURL);

            if (retStep1 == false)
            {
                tsStatusLabel1.Text = "이 사이트는 해당URL에 대하여 스크래핑 금지 정책을 실시하고 있습니다."+"["+txtURL+"]";
                chkResultNO.Checked = true;
                chkResultOK.Checked = false;
                chkROBOTS.Checked = true;
            }
            else
            {
                tsStatusLabel1.Text = "이 사이트는 해당URL에 대하여 스크래핑 허용 정책을 실시하고 있습니다." + "[" + txtURL + "]";
                chkROBOTS.Checked = false;
                chkResultNO.Checked = false;
                chkResultOK.Checked = true;
            }

            //if (IsSiteConnected(txtURL.Text) == false)
            //{
            //    chkURL.Checked = false;
           // }
            //else
            //{
             //   chkURL.Checked = true;
            //    tsStatusLabel1.Text = "사이트가 연결되지 않습니다. 주소를 확인해주세요.";
            //    return -3;
            //}


            return 0;

        }
        private int CheckStep2()
        {
            return 0;
        }
        private int CheckStep3()
        {
            return 0;
        }

        private void btnConfirm_Click_2(object sender, EventArgs e)
        {
            btnConfirm_Click(sender, e);
        }

        private void btnDeny_Click_2(object sender, EventArgs e)
        {
            btnDeny_Click(sender, e);
        }

        private void cmdWebBrowsing_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
            if (IsSiteConnected(txtURL.Text) == true)
            {
                chkWebBrowser.Checked = false;
            }
            else
            {
                chkWebBrowser.Checked = true;
            }
            Navigate(txtURL.Text);
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
        }

        private void btnCheckScrap_Click(object sender, EventArgs e)
        {
            CheckAll(txtURL.Text);
        }

        private void cmdWebBrowsing_Click_1(object sender, EventArgs e)
        {
            cmdWebBrowsing_Click(sender, e);
        }
    }
}
