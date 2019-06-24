﻿using CodeAutogenerationTool.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Linq;
using CodeAutogenerationTool.Helper;
using EasyFramework.Models;
using EasyFramework.Attr;

namespace CodeAutogenerationTool.MForm
{
    public partial class MainForm : Form
    {
        #region 全局属性定义

        List<ListItem> dataBaseTypeItems = new List<ListItem>()
        {
            new ListItem(){ Text = "Microsoft SQL Server", Value = "0" }
        };//数据库类型
        string configPath = "CodeAutogenerationTool.xml";//配置文件路径
        string connStr = "";//数据库连接字符串
        SqlConnection conn = null;//数据库连接
        delegate void connDelegate();//主线程委托

        #endregion

        public MainForm()
        {
            InitializeComponent();
        }

        //窗体加载事件
        private void MainForm_Load(object sender, EventArgs e)
        {
            //数据库类型添加
            foreach (var item in dataBaseTypeItems)
            {
                cbb_DataBaseType.Items.Add(item);
            }
            cbb_DataBaseType.SelectedIndex = 0;

            //加载保存过的数据
            LoadConfiguration();

            //代码生成项赋值
            cbb_Mode.Items.Add(new ListItem() { Text = "生成MVC中的MC", Value = "MC" });
            cbb_Mode.Items.Add(new ListItem() { Text = "生成三层中的DAL", Value = "DAL" });
            cbb_Mode.Items.Add(new ListItem() { Text = "生成Model", Value = "Model" });
            cbb_Mode.SelectedIndex = 0;
        }

        //选择生成路径按钮
        private void btn_SelectPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txt_Path.Text = folderBrowserDialog.SelectedPath;
            }
        }

        //连接至数据库
        private void btn_Connect_Click(object sender, EventArgs e)
        {
            //保存配置文件
            if(string.IsNullOrEmpty(txt_Ip.Text) || string.IsNullOrEmpty(txt_UserName.Text)|| string.IsNullOrEmpty(txt_Pwd.Text)|| string.IsNullOrEmpty(txt_DataBaseName.Text)|| string.IsNullOrEmpty(txt_NameSpace.Text)|| string.IsNullOrEmpty(txt_Path.Text))
            {
                MessageBox.Show("关键信息不能为空");
                return;
            }
            Thread thread = new Thread(ConnectionDataBase);
            string[] config = new string[] { cbb_DataBaseType.Text, txt_Ip.Text, txt_UserName.Text, txt_Pwd.Text, txt_DataBaseName.Text, txt_NameSpace.Text, txt_Path.Text };
            IsConfigExist(true, config);
            btn_Connect.Enabled = false;
            tsbtn_Connect.Enabled = false;
            tsbtn_Disconnect.Enabled = true;
            btn_Connect.Text = "连接中...";
            thread.Start();
        }

        //连接远程服务器注意提醒
        private void lbl_Tips_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("1.需要在数据库配置中打开TCP/IP协议, 端口如果不是1433则在填写ip地址中加入端口号例如:XXX.XXX.XXX.XXX,端口号\n2.数据库需要允许远程连接\n3.用户名访问数据库权限\n4.如连接失败请查看日志");
        }

        //断开数据库连接
        private void btn_Close_Click(object sender, EventArgs e)
        {
            cbb_DataBaseType.Enabled = true;
            txt_Ip.Enabled = true;
            txt_NameSpace.Enabled = true;
            txt_Path.Enabled = true;
            txt_Pwd.Enabled = true;
            txt_UserName.Enabled = true;
            btn_Connect.Enabled = true;
            conn.Close();
            btn_Connect.Text = "连接";
            btn_Close.Enabled = false;
            txt_DataBaseName.Enabled = true;
            btn_SelectPath.Enabled = true;
            cbb_Tables.DataSource = null;
            dgv_TableDetails.DataSource = null;
            tsbtn_Connect.Enabled = true;
            tsbtn_Disconnect.Enabled = false;
            txt_Msg.Text += DateTime.Now + " 断开连接\r\n";
        }

        //读取表的信息
        private void btn_Read_Click(object sender, EventArgs e)
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                if (string.IsNullOrEmpty(cbb_Tables.Text))
                {
                    MessageBox.Show("请先选择需要读取的数据表!");
                    return;
                }
                //查询表信息sql语句
                string sqlStr = string.Format(@"SELECT (case when a.colorder=1 then d.name else null end) 表名,  
 a.colorder 序号,a.name 字段名称,
(case when COLUMNPROPERTY( a.id,a.name,'IsIdentity')=1 then '√'else '' end) 标识, 
(case when (SELECT count(*) FROM sysobjects  
WHERE (name in (SELECT name FROM sysindexes  
WHERE (id = a.id) AND (indid in  
(SELECT indid FROM sysindexkeys  
 WHERE (id = a.id) AND (colid in  
(SELECT colid FROM syscolumns WHERE (id = a.id) AND (name = a.name)))))))  
AND (xtype = 'PK'))>0 then '√' else '' end) 是否主键,b.name 字段类型,a.length 占用字节数,  
COLUMNPROPERTY(a.id,a.name,'PRECISION') as 字段长度,  
isnull(COLUMNPROPERTY(a.id,a.name,'Scale'),0) as 小数位数,(case when a.isnullable=1 then '√'else '' end) 能否为空,  
isnull(e.text,'') 默认值,isnull(g.[value], ' ') AS [字段说明]
 FROM  syscolumns a 
left join systypes b on a.xtype=b.xusertype  
 inner join sysobjects d on a.id=d.id and d.xtype='U' and d.name<>'dtproperties' 
left join syscomments e on a.cdefault=e.id  
 left join sys.extended_properties g on a.id=g.major_id AND a.colid=g.minor_id
left join sys.extended_properties f on d.id=f.class and f.minor_id=0
 where b.name is not null
AND  d.name='{0}' --如果只查询指定表,加上此条件
 order by a.id,a.colorder;", cbb_Tables.Text);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlStr, conn);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                dataAdapter.Dispose();
                dgv_TableDetails.DataSource = dt;
            }
            else
            {
                MessageBox.Show("与数据库断开连接, 请尝试断开重新连接!");
            }
        }

        //生成代码
        private void btn_Generate_Click(object sender, EventArgs e)
        {
            if (dgv_TableDetails.Rows.Count < 1)
            {
                //读取字段为0
                MessageBox.Show("没有数据能够生成");
            }
            else if (conn == null || conn.State != ConnectionState.Open)
            {
                //数据库连接关闭或异常
                MessageBox.Show("与数据库的连接已经断开, 请尝试断开后重新连接");
            }
            else
            {
                MSSqlAutoGenerationHelper.path = txt_Path.Text.Trim();
                MSSqlAutoGenerationHelper.nameSpace = txt_NameSpace.Text.Trim();

                //代码生成
                #region 生成主要代码
                //表信息
                ModelAttribute modelAttribute = new ModelAttribute()
                {
                    TableName = cbb_Tables.Text
                };
                //该模型字段信息
                List<ModelProperty> modelProperties = new List<ModelProperty>();
                foreach (DataGridViewRow row in dgv_TableDetails.Rows)
                {
                    if (string.IsNullOrEmpty(modelAttribute.PrimaryKey) && !string.IsNullOrEmpty(row.Cells["IsPrimaryKey"].Value.ToString()))
                    {
                        modelAttribute.PrimaryKey = row.Cells["FieldName"].Value.ToString();//表主键
                    }
                    //字段信息
                    ModelProperty modelProperty = new ModelProperty()
                    {
                        ColName = row.Cells["FieldName"].Value.ToString(),
                        ColType = row.Cells["FieldType"].Value.ToString(),
                        Default = row.Cells["FieldDefaultValue"].Value.ToString(),
                        Explain = row.Cells["FieldDescribe"].Value.ToString(),
                        IsNull = string.IsNullOrEmpty(row.Cells["IsNull"].Value.ToString()),
                        MinLength = 0,
                        MaxLength = Convert.ToInt32(row.Cells["FieldLength"].Value.ToString()),
                    };
                    modelProperties.Add(modelProperty);
                }
                #endregion

                switch ((cbb_Mode.SelectedItem as ListItem).Value)
                {
                    case "MC":
                        //生成MVC模式中的Model和Controller
                        //生成的路径
                        string path = txt_Path.Text;
                        //判断Controllers文件夹是否存在
                        if (!Directory.Exists(path + "/Controllers"))
                        {
                            //不存在则创建 一般来说创建MVC项目时会有
                            Directory.CreateDirectory(path + "/Controllers");
                        }
                        //判断Models文件夹是否存在
                        if (!Directory.Exists(path + "/Models"))
                        {
                            // 不存在则创建
                            Directory.CreateDirectory(path + "/Models");
                        }

                        //调用生成方法生成MC
                        if (MSSqlAutoGenerationHelper.GenerateMC(modelProperties, modelAttribute))
                        {
                            txt_Msg.Text += "成功生成" + cbb_Mode.Text + ", 数据库表名:" + cbb_Tables.Text + ";\r\n";
                            MessageBox.Show("生成成功");
                        }
                        break;
                    case "DAL":
                        //生成普通三成架构中的DAL
                        MessageBox.Show("生成DAL");
                        break;
                    case "Model":
                        //只生成Model
                        //判断Models文件夹是否存在
                        if (!Directory.Exists(txt_Path.Text + "/Models"))
                        {
                            // 不存在则创建
                            Directory.CreateDirectory(txt_Path.Text + "/Models");
                        }
                        if (MSSqlAutoGenerationHelper.GenerateModel(modelProperties, modelAttribute))
                        {
                            txt_Msg.Text += "成功生成" + cbb_Mode.Text + ", 数据库表名:" + cbb_Tables.Text + ";\r\n";
                            MessageBox.Show("生成成功");
                        }
                        break;
                }

                //代码生成配置文件(数据库连接信息等)
                if (!Directory.Exists(txt_Path.Text + "/bin"))
                {
                    //创建bin文件夹
                    Directory.CreateDirectory(txt_Path.Text + "/bin");
                }
                GenerateConfigFile();
            }
        }

        //退出
        private void MenuItem_Exit_Click(object sender, EventArgs e)
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            Application.Exit();
        }

        //退出
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("是否退出?", "提醒", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        #region 菜单事件

        //帮助
        private void MenuItem_Help_Click(object sender, EventArgs e)
        {
            string msg = "1.选择数据库类型 \n2.输入数据库所在IP地址及登录用户名和密码(如是本机则一般为127.0.0.1), 连接\n3.连接失败请查看日志, 连接成功选择对应需要生成代码的数据库,确定";

            MessageBox.Show(msg);
        }

        #endregion

        #region 自定义方法

        /// <summary>
        /// 加载软件配置文件
        /// </summary>
        private void LoadConfiguration()
        {
            try
            {
                //验证配置文件是否存在
                IsConfigExist(false);
                XDocument xml = XDocument.Load(configPath);
                XElement root = xml.Root;//获取xml根元素
                IEnumerable<XElement> elements = root.Element("appSettings").Elements("add");
                foreach (var item in elements)
                {
                    switch (item.Attribute("key").Value)
                    {
                        case "Server.Type":
                            if (dataBaseTypeItems.Where(p => p.Text == item.Attribute("value").Value).Count() > 0)
                                cbb_DataBaseType.SelectedItem = dataBaseTypeItems.Single(p => p.Text == item.Attribute("value").Value);
                            break;
                        case "Server.Ip":
                            txt_Ip.Text = item.Attribute("value").Value;
                            break;
                        case "Server.UserName":
                            txt_UserName.Text = item.Attribute("value").Value;
                            break;
                        case "Server.Pwd":
                            txt_Pwd.Text = item.Attribute("value").Value;
                            break;
                        case "Server.NameSpace":
                            txt_NameSpace.Text = item.Attribute("value").Value;
                            break;
                        case "Server.Path":
                            txt_Path.Text = item.Attribute("value").Value;
                            break;
                        case "Server.DataBaseName":
                            txt_DataBaseName.Text = item.Attribute("value").Value;
                            break;
                    }
                }
            }
            catch (Exception e)
            {
                //验证配置文件是否存在
                IsConfigExist(true);
            }
        }

        /// <summary>
        /// 判断软件配置文件是否存在或保存配置文件
        /// </summary>
        /// <param name="isReset">为true则重置文件内容</param>
        /// <param name="config">可选参数, 为配置文件里的value值, 需要长度为6的数组</param>
        private void IsConfigExist(bool isReset, params string[] config)
        {
            try
            {
                if (config.Length < 7)
                {
                    config = new string[] { "", "", "", "", "", "", "" };
                }
                if (!File.Exists(configPath) || isReset)
                {
                    FileStream fileStream = new FileStream("CodeAutogenerationTool.xml", FileMode.Create);
                    string configStr = string.Format("<?xml version=\"1.0\" encoding=\"utf-8\" ?>\n<configuration>\n  <appSettings>\n    <add key=\"Server.Type\" value=\"{0}\" />\n    <add key=\"Server.Ip\" value=\"{1}\" />\n    <add key=\"Server.UserName\" value=\"{2}\" />\n    <add key=\"Server.Pwd\" value=\"{3}\" />\n    <add key=\"Server.DataBaseName\" value=\"{4}\" />\n    <add key=\"Server.NameSpace\" value=\"{5}\" />\n    <add key=\"Server.Path\" value=\"{6}\" />\n  </appSettings>\n</configuration>", config);
                    byte[] array = Encoding.Default.GetBytes(configStr);
                    fileStream.Write(array, 0, array.Length);
                    fileStream.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("生成配置文件出错, 请查看日志!");
                txt_Msg.Text += e.Message + "\r\n";
            }

        }

        /// <summary>
        /// 连接数据库
        /// </summary>
        private void ConnectionDataBase()
        {
            try
            {
                string dataBaseType = "";
                if (cbb_DataBaseType.InvokeRequired)
                {
                    connDelegate cd = new connDelegate(() =>
                    {
                        dataBaseType = (cbb_DataBaseType.SelectedItem as ListItem).Value;
                    });
                    Invoke(cd);
                }
                switch (dataBaseType)
                {
                    case "0":
                        //MS SQL的数据库连接字符串
                        connStr = string.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3};Connection Timeout=5", txt_Ip.Text, txt_DataBaseName.Text, txt_UserName.Text, txt_Pwd.Text);
                        break;
                }
                conn = new SqlConnection(connStr);
                conn.Open();//打开数据库连接
                if (btn_Connect.InvokeRequired)
                {
                    connDelegate cd = new connDelegate(ConnectionDelegate);
                    Invoke(cd);
                }
                else
                {
                    ConnectionDelegate();
                }
            }
            catch (Exception e)
            {
                //数据库连接失败 从不是创建控件的线程 委托访问
                if (btn_Connect.InvokeRequired)
                {
                    connDelegate cd = new connDelegate(() =>
                    {
                        btn_Connect.Enabled = true;
                        btn_Connect.Text = "重新连接";
                        txt_Msg.Text += e.Message + "\r\n";
                    });
                    Invoke(cd);
                }
                else
                {
                    btn_Connect.Enabled = true;
                    btn_Connect.Text = "重新连接";
                    txt_Msg.Text += e.Message + "\r\n";
                }
            }
        }

        //该线程无法操作非该线程创建的控件, 使用委托修改指定线程创建的控件
        private void ConnectionDelegate()
        {
            //连接数据库成功
            if (conn.State == ConnectionState.Open)
            {
                cbb_DataBaseType.Enabled = false;
                txt_Ip.Enabled = false;
                txt_UserName.Enabled = false;
                txt_Pwd.Enabled = false;
                txt_DataBaseName.Enabled = false;
                txt_NameSpace.Enabled = false;
                txt_Path.Enabled = false;
                btn_Connect.Enabled = false;
                btn_Connect.Text = "连接成功";
                btn_Close.Enabled = true;
                btn_SelectPath.Enabled = false;
                txt_Msg.Text += DateTime.Now + " 连接数据库成功\r\n";
                MSSqlAutoGenerationHelper.path = txt_Path.Text;//生成代码路径
                MSSqlAutoGenerationHelper.nameSpace = txt_NameSpace.Text;//生成代码的命名空间

                #region 数据库中表名读取
                string[] restrictions = new string[4];
                restrictions[3] = "BASE TABLE";
                DataTable dt = conn.GetSchema("Tables", restrictions);
                List<string> tables = new List<string>();
                foreach (DataRow row in dt.Rows)
                {
                    tables.Add(row["TABLE_NAME"].ToString());
                }
                tables.Sort();
                cbb_Tables.DataSource = tables;
                #endregion
            }
        }

        /// <summary>
        /// 生成EasyFramework配置文件
        /// </summary>
        private void GenerateConfigFile()
        {
            try
            {
                if (File.Exists(txt_Path.Text + "/bin/EasyFramework.config"))
                {
                    return;
                }
                else
                {
                    //创建配置文件
                    FileStream fileStream = new FileStream(txt_Path.Text + "/bin/EasyFramework.config", FileMode.Create);
                    string configStr = string.Format("<?xml version=\"1.0\" encoding=\"utf-8\" ?>\n<configuration>\n  <appSettings>\n    <add key=\"DataSource\" value=\"{0}\" />\n    <add key=\"InitialCatalog\" value=\"{1}\" />\n    <add key=\"UserID\" value=\"{2}\" />\n    <add key=\"Password\" value=\"{3}\" />\n  </appSettings>\n</configuration>", txt_Ip.Text, txt_DataBaseName.Text, txt_UserName.Text, txt_Pwd.Text);
                    //写入信息
                    byte[] array = Encoding.Default.GetBytes(configStr);
                    fileStream.Write(array, 0, array.Length);
                    fileStream.Close();
                }
            }
            catch (Exception e)
            {

                MessageBox.Show("生成配置文件出错, 请查看日志!");
                txt_Msg.Text += e.Message + "\r\n";
            }

        }

        #endregion
    }
}
