﻿namespace CodeAutogenerationTool.MForm
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.菜单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtn_Connect = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_Disconnect = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_Exit = new System.Windows.Forms.ToolStripButton();
            this.TabPage = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_Close = new System.Windows.Forms.Button();
            this.txt_DataBaseName = new System.Windows.Forms.TextBox();
            this.lbl_Tips = new System.Windows.Forms.LinkLabel();
            this.btn_SelectPath = new System.Windows.Forms.Button();
            this.lbl_Path = new System.Windows.Forms.Label();
            this.txt_Path = new System.Windows.Forms.TextBox();
            this.lbl_NameSpace = new System.Windows.Forms.Label();
            this.txt_NameSpace = new System.Windows.Forms.TextBox();
            this.lbl_DataBaseName = new System.Windows.Forms.Label();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.lbl_Pwd = new System.Windows.Forms.Label();
            this.txt_Pwd = new System.Windows.Forms.TextBox();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.lbl_DataBaseType = new System.Windows.Forms.Label();
            this.cbb_DataBaseType = new System.Windows.Forms.ComboBox();
            this.lbl_Ip = new System.Windows.Forms.Label();
            this.txt_Ip = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbl_Mode = new System.Windows.Forms.Label();
            this.cbb_Mode = new System.Windows.Forms.ComboBox();
            this.lbl_TableName = new System.Windows.Forms.Label();
            this.dgv_TableDetails = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FieldName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FieldDescribe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FieldType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FieldLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsPrimaryKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsNull = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FieldDefaultValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Read = new System.Windows.Forms.Button();
            this.btn_Generate = new System.Windows.Forms.Button();
            this.cbb_Tables = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txt_Msg = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MainMenuStrip.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.TabPage.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TableDetails)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.菜单ToolStripMenuItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.MainMenuStrip.Size = new System.Drawing.Size(762, 25);
            this.MainMenuStrip.TabIndex = 0;
            // 
            // 菜单ToolStripMenuItem
            // 
            this.菜单ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_Help,
            this.MenuItem_Exit});
            this.菜单ToolStripMenuItem.Name = "菜单ToolStripMenuItem";
            this.菜单ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.菜单ToolStripMenuItem.Text = "菜单";
            // 
            // MenuItem_Help
            // 
            this.MenuItem_Help.Image = ((System.Drawing.Image)(resources.GetObject("MenuItem_Help.Image")));
            this.MenuItem_Help.Name = "MenuItem_Help";
            this.MenuItem_Help.Size = new System.Drawing.Size(117, 22);
            this.MenuItem_Help.Text = "帮助(&H)";
            this.MenuItem_Help.Click += new System.EventHandler(this.MenuItem_Help_Click);
            // 
            // MenuItem_Exit
            // 
            this.MenuItem_Exit.Image = ((System.Drawing.Image)(resources.GetObject("MenuItem_Exit.Image")));
            this.MenuItem_Exit.Name = "MenuItem_Exit";
            this.MenuItem_Exit.Size = new System.Drawing.Size(117, 22);
            this.MenuItem_Exit.Text = "退出(&X)";
            this.MenuItem_Exit.Click += new System.EventHandler(this.MenuItem_Exit_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtn_Connect,
            this.tsbtn_Disconnect,
            this.tsbtn_Exit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(762, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtn_Connect
            // 
            this.tsbtn_Connect.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_Connect.Image")));
            this.tsbtn_Connect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_Connect.Name = "tsbtn_Connect";
            this.tsbtn_Connect.Size = new System.Drawing.Size(56, 24);
            this.tsbtn_Connect.Text = "连接";
            this.tsbtn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // tsbtn_Disconnect
            // 
            this.tsbtn_Disconnect.Enabled = false;
            this.tsbtn_Disconnect.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_Disconnect.Image")));
            this.tsbtn_Disconnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_Disconnect.Name = "tsbtn_Disconnect";
            this.tsbtn_Disconnect.Size = new System.Drawing.Size(80, 24);
            this.tsbtn_Disconnect.Text = "断开连接";
            this.tsbtn_Disconnect.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // tsbtn_Exit
            // 
            this.tsbtn_Exit.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_Exit.Image")));
            this.tsbtn_Exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_Exit.Name = "tsbtn_Exit";
            this.tsbtn_Exit.Size = new System.Drawing.Size(56, 24);
            this.tsbtn_Exit.Text = "退出";
            this.tsbtn_Exit.Click += new System.EventHandler(this.MenuItem_Exit_Click);
            // 
            // TabPage
            // 
            this.TabPage.Controls.Add(this.tabPage1);
            this.TabPage.Controls.Add(this.tabPage2);
            this.TabPage.Controls.Add(this.tabPage3);
            this.TabPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabPage.Location = new System.Drawing.Point(0, 52);
            this.TabPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TabPage.Name = "TabPage";
            this.TabPage.SelectedIndex = 0;
            this.TabPage.Size = new System.Drawing.Size(762, 477);
            this.TabPage.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_Close);
            this.tabPage1.Controls.Add(this.txt_DataBaseName);
            this.tabPage1.Controls.Add(this.lbl_Tips);
            this.tabPage1.Controls.Add(this.btn_SelectPath);
            this.tabPage1.Controls.Add(this.lbl_Path);
            this.tabPage1.Controls.Add(this.txt_Path);
            this.tabPage1.Controls.Add(this.lbl_NameSpace);
            this.tabPage1.Controls.Add(this.txt_NameSpace);
            this.tabPage1.Controls.Add(this.lbl_DataBaseName);
            this.tabPage1.Controls.Add(this.btn_Connect);
            this.tabPage1.Controls.Add(this.lbl_Pwd);
            this.tabPage1.Controls.Add(this.txt_Pwd);
            this.tabPage1.Controls.Add(this.lbl_UserName);
            this.tabPage1.Controls.Add(this.txt_UserName);
            this.tabPage1.Controls.Add(this.lbl_DataBaseType);
            this.tabPage1.Controls.Add(this.cbb_DataBaseType);
            this.tabPage1.Controls.Add(this.lbl_Ip);
            this.tabPage1.Controls.Add(this.txt_Ip);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(754, 451);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "数据库连接";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Close.Enabled = false;
            this.btn_Close.Location = new System.Drawing.Point(414, 345);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(76, 30);
            this.btn_Close.TabIndex = 19;
            this.btn_Close.Text = "断开";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // txt_DataBaseName
            // 
            this.txt_DataBaseName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_DataBaseName.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_DataBaseName.Location = new System.Drawing.Point(328, 210);
            this.txt_DataBaseName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_DataBaseName.Name = "txt_DataBaseName";
            this.txt_DataBaseName.Size = new System.Drawing.Size(174, 27);
            this.txt_DataBaseName.TabIndex = 4;
            // 
            // lbl_Tips
            // 
            this.lbl_Tips.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Tips.AutoSize = true;
            this.lbl_Tips.Location = new System.Drawing.Point(516, 90);
            this.lbl_Tips.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Tips.Name = "lbl_Tips";
            this.lbl_Tips.Size = new System.Drawing.Size(113, 12);
            this.lbl_Tips.TabIndex = 17;
            this.lbl_Tips.TabStop = true;
            this.lbl_Tips.Text = "连接远程服务器注意";
            this.lbl_Tips.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_Tips_LinkClicked);
            // 
            // btn_SelectPath
            // 
            this.btn_SelectPath.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_SelectPath.Location = new System.Drawing.Point(518, 298);
            this.btn_SelectPath.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_SelectPath.Name = "btn_SelectPath";
            this.btn_SelectPath.Size = new System.Drawing.Size(76, 22);
            this.btn_SelectPath.TabIndex = 16;
            this.btn_SelectPath.Text = "选择";
            this.btn_SelectPath.UseVisualStyleBackColor = true;
            this.btn_SelectPath.Click += new System.EventHandler(this.btn_SelectPath_Click);
            // 
            // lbl_Path
            // 
            this.lbl_Path.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Path.AutoSize = true;
            this.lbl_Path.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Path.Location = new System.Drawing.Point(263, 304);
            this.lbl_Path.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Path.Name = "lbl_Path";
            this.lbl_Path.Size = new System.Drawing.Size(59, 17);
            this.lbl_Path.TabIndex = 15;
            this.lbl_Path.Text = "生成路径:";
            // 
            // txt_Path
            // 
            this.txt_Path.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Path.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_Path.Location = new System.Drawing.Point(328, 298);
            this.txt_Path.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Path.Name = "txt_Path";
            this.txt_Path.Size = new System.Drawing.Size(174, 27);
            this.txt_Path.TabIndex = 6;
            // 
            // lbl_NameSpace
            // 
            this.lbl_NameSpace.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_NameSpace.AutoSize = true;
            this.lbl_NameSpace.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_NameSpace.Location = new System.Drawing.Point(263, 258);
            this.lbl_NameSpace.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_NameSpace.Name = "lbl_NameSpace";
            this.lbl_NameSpace.Size = new System.Drawing.Size(59, 17);
            this.lbl_NameSpace.TabIndex = 13;
            this.lbl_NameSpace.Text = "命名空间:";
            // 
            // txt_NameSpace
            // 
            this.txt_NameSpace.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_NameSpace.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_NameSpace.Location = new System.Drawing.Point(328, 253);
            this.txt_NameSpace.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_NameSpace.Name = "txt_NameSpace";
            this.txt_NameSpace.Size = new System.Drawing.Size(174, 27);
            this.txt_NameSpace.TabIndex = 5;
            // 
            // lbl_DataBaseName
            // 
            this.lbl_DataBaseName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_DataBaseName.AutoSize = true;
            this.lbl_DataBaseName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_DataBaseName.Location = new System.Drawing.Point(253, 215);
            this.lbl_DataBaseName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_DataBaseName.Name = "lbl_DataBaseName";
            this.lbl_DataBaseName.Size = new System.Drawing.Size(71, 17);
            this.lbl_DataBaseName.TabIndex = 10;
            this.lbl_DataBaseName.Text = "数据库名称:";
            // 
            // btn_Connect
            // 
            this.btn_Connect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Connect.Location = new System.Drawing.Point(278, 345);
            this.btn_Connect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(76, 30);
            this.btn_Connect.TabIndex = 8;
            this.btn_Connect.Text = "连接";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // lbl_Pwd
            // 
            this.lbl_Pwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Pwd.AutoSize = true;
            this.lbl_Pwd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Pwd.Location = new System.Drawing.Point(274, 174);
            this.lbl_Pwd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Pwd.Name = "lbl_Pwd";
            this.lbl_Pwd.Size = new System.Drawing.Size(51, 17);
            this.lbl_Pwd.TabIndex = 7;
            this.lbl_Pwd.Text = "密    码:";
            // 
            // txt_Pwd
            // 
            this.txt_Pwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Pwd.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_Pwd.Location = new System.Drawing.Point(328, 169);
            this.txt_Pwd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Pwd.Name = "txt_Pwd";
            this.txt_Pwd.PasswordChar = '*';
            this.txt_Pwd.Size = new System.Drawing.Size(174, 27);
            this.txt_Pwd.TabIndex = 3;
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_UserName.Location = new System.Drawing.Point(274, 132);
            this.lbl_UserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(47, 17);
            this.lbl_UserName.TabIndex = 5;
            this.lbl_UserName.Text = "用户名:";
            // 
            // txt_UserName
            // 
            this.txt_UserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_UserName.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_UserName.Location = new System.Drawing.Point(328, 126);
            this.txt_UserName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(174, 27);
            this.txt_UserName.TabIndex = 2;
            // 
            // lbl_DataBaseType
            // 
            this.lbl_DataBaseType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_DataBaseType.AutoSize = true;
            this.lbl_DataBaseType.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_DataBaseType.Location = new System.Drawing.Point(252, 46);
            this.lbl_DataBaseType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_DataBaseType.Name = "lbl_DataBaseType";
            this.lbl_DataBaseType.Size = new System.Drawing.Size(71, 17);
            this.lbl_DataBaseType.TabIndex = 3;
            this.lbl_DataBaseType.Text = "数据库类型:";
            // 
            // cbb_DataBaseType
            // 
            this.cbb_DataBaseType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbb_DataBaseType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_DataBaseType.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbb_DataBaseType.FormattingEnabled = true;
            this.cbb_DataBaseType.Location = new System.Drawing.Point(328, 40);
            this.cbb_DataBaseType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbb_DataBaseType.Name = "cbb_DataBaseType";
            this.cbb_DataBaseType.Size = new System.Drawing.Size(174, 28);
            this.cbb_DataBaseType.TabIndex = 0;
            // 
            // lbl_Ip
            // 
            this.lbl_Ip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Ip.AutoSize = true;
            this.lbl_Ip.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Ip.Location = new System.Drawing.Point(274, 89);
            this.lbl_Ip.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Ip.Name = "lbl_Ip";
            this.lbl_Ip.Size = new System.Drawing.Size(47, 17);
            this.lbl_Ip.TabIndex = 1;
            this.lbl_Ip.Text = "IP地址:";
            // 
            // txt_Ip
            // 
            this.txt_Ip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Ip.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_Ip.Location = new System.Drawing.Point(328, 83);
            this.txt_Ip.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Ip.Name = "txt_Ip";
            this.txt_Ip.Size = new System.Drawing.Size(174, 27);
            this.txt_Ip.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lbl_Mode);
            this.tabPage2.Controls.Add(this.cbb_Mode);
            this.tabPage2.Controls.Add(this.lbl_TableName);
            this.tabPage2.Controls.Add(this.dgv_TableDetails);
            this.tabPage2.Controls.Add(this.btn_Read);
            this.tabPage2.Controls.Add(this.btn_Generate);
            this.tabPage2.Controls.Add(this.cbb_Tables);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(754, 451);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "代码生成";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbl_Mode
            // 
            this.lbl_Mode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Mode.AutoSize = true;
            this.lbl_Mode.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Mode.Location = new System.Drawing.Point(425, 21);
            this.lbl_Mode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Mode.Name = "lbl_Mode";
            this.lbl_Mode.Size = new System.Drawing.Size(35, 17);
            this.lbl_Mode.TabIndex = 14;
            this.lbl_Mode.Text = "表名:";
            // 
            // cbb_Mode
            // 
            this.cbb_Mode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbb_Mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Mode.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbb_Mode.FormattingEnabled = true;
            this.cbb_Mode.Location = new System.Drawing.Point(463, 15);
            this.cbb_Mode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbb_Mode.Name = "cbb_Mode";
            this.cbb_Mode.Size = new System.Drawing.Size(146, 28);
            this.cbb_Mode.TabIndex = 13;
            // 
            // lbl_TableName
            // 
            this.lbl_TableName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_TableName.AutoSize = true;
            this.lbl_TableName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_TableName.Location = new System.Drawing.Point(62, 21);
            this.lbl_TableName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_TableName.Name = "lbl_TableName";
            this.lbl_TableName.Size = new System.Drawing.Size(35, 17);
            this.lbl_TableName.TabIndex = 12;
            this.lbl_TableName.Text = "表名:";
            // 
            // dgv_TableDetails
            // 
            this.dgv_TableDetails.AllowUserToAddRows = false;
            this.dgv_TableDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TableDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.FieldName,
            this.FieldDescribe,
            this.FieldType,
            this.FieldLength,
            this.IsPrimaryKey,
            this.IsNull,
            this.FieldDefaultValue});
            this.dgv_TableDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_TableDetails.Location = new System.Drawing.Point(2, 49);
            this.dgv_TableDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_TableDetails.Name = "dgv_TableDetails";
            this.dgv_TableDetails.ReadOnly = true;
            this.dgv_TableDetails.RowTemplate.Height = 27;
            this.dgv_TableDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_TableDetails.Size = new System.Drawing.Size(750, 400);
            this.dgv_TableDetails.TabIndex = 11;
            // 
            // Number
            // 
            this.Number.DataPropertyName = "序号";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Number.DefaultCellStyle = dataGridViewCellStyle1;
            this.Number.HeaderText = "序号";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            // 
            // FieldName
            // 
            this.FieldName.DataPropertyName = "字段名称";
            this.FieldName.FillWeight = 82.47158F;
            this.FieldName.HeaderText = "字段名称";
            this.FieldName.Name = "FieldName";
            this.FieldName.ReadOnly = true;
            this.FieldName.Width = 150;
            // 
            // FieldDescribe
            // 
            this.FieldDescribe.DataPropertyName = "字段说明";
            this.FieldDescribe.FillWeight = 84.77386F;
            this.FieldDescribe.HeaderText = "字段说明";
            this.FieldDescribe.Name = "FieldDescribe";
            this.FieldDescribe.ReadOnly = true;
            this.FieldDescribe.Width = 154;
            // 
            // FieldType
            // 
            this.FieldType.DataPropertyName = "字段类型";
            this.FieldType.FillWeight = 66.55966F;
            this.FieldType.HeaderText = "字段类型";
            this.FieldType.MinimumWidth = 80;
            this.FieldType.Name = "FieldType";
            this.FieldType.ReadOnly = true;
            this.FieldType.Width = 121;
            // 
            // FieldLength
            // 
            this.FieldLength.DataPropertyName = "字段长度";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.FieldLength.DefaultCellStyle = dataGridViewCellStyle2;
            this.FieldLength.FillWeight = 59.03904F;
            this.FieldLength.HeaderText = "字段长度";
            this.FieldLength.MinimumWidth = 80;
            this.FieldLength.Name = "FieldLength";
            this.FieldLength.ReadOnly = true;
            this.FieldLength.Width = 108;
            // 
            // IsPrimaryKey
            // 
            this.IsPrimaryKey.DataPropertyName = "是否主键";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.IsPrimaryKey.DefaultCellStyle = dataGridViewCellStyle3;
            this.IsPrimaryKey.FillWeight = 52.45149F;
            this.IsPrimaryKey.HeaderText = "是否主键";
            this.IsPrimaryKey.MinimumWidth = 80;
            this.IsPrimaryKey.Name = "IsPrimaryKey";
            this.IsPrimaryKey.ReadOnly = true;
            this.IsPrimaryKey.Width = 108;
            // 
            // IsNull
            // 
            this.IsNull.DataPropertyName = "能否为空";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.IsNull.DefaultCellStyle = dataGridViewCellStyle4;
            this.IsNull.FillWeight = 51.17035F;
            this.IsNull.HeaderText = "能否为空";
            this.IsNull.MinimumWidth = 80;
            this.IsNull.Name = "IsNull";
            this.IsNull.ReadOnly = true;
            this.IsNull.Width = 108;
            // 
            // FieldDefaultValue
            // 
            this.FieldDefaultValue.DataPropertyName = "默认值";
            this.FieldDefaultValue.FillWeight = 46.68127F;
            this.FieldDefaultValue.HeaderText = "默认值";
            this.FieldDefaultValue.Name = "FieldDefaultValue";
            this.FieldDefaultValue.ReadOnly = true;
            this.FieldDefaultValue.Width = 108;
            // 
            // btn_Read
            // 
            this.btn_Read.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Read.Location = new System.Drawing.Point(344, 13);
            this.btn_Read.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Read.Name = "btn_Read";
            this.btn_Read.Size = new System.Drawing.Size(76, 30);
            this.btn_Read.TabIndex = 10;
            this.btn_Read.Text = "读取";
            this.btn_Read.UseVisualStyleBackColor = true;
            this.btn_Read.Click += new System.EventHandler(this.btn_Read_Click);
            // 
            // btn_Generate
            // 
            this.btn_Generate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Generate.Location = new System.Drawing.Point(612, 13);
            this.btn_Generate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Generate.Name = "btn_Generate";
            this.btn_Generate.Size = new System.Drawing.Size(76, 30);
            this.btn_Generate.TabIndex = 9;
            this.btn_Generate.Tag = "";
            this.btn_Generate.Text = "生成";
            this.btn_Generate.UseVisualStyleBackColor = true;
            this.btn_Generate.Click += new System.EventHandler(this.btn_Generate_Click);
            // 
            // cbb_Tables
            // 
            this.cbb_Tables.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbb_Tables.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbb_Tables.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbb_Tables.FormattingEnabled = true;
            this.cbb_Tables.Location = new System.Drawing.Point(99, 15);
            this.cbb_Tables.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbb_Tables.Name = "cbb_Tables";
            this.cbb_Tables.Size = new System.Drawing.Size(242, 28);
            this.cbb_Tables.TabIndex = 3;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txt_Msg);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Size = new System.Drawing.Size(754, 459);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "日志";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txt_Msg
            // 
            this.txt_Msg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Msg.Location = new System.Drawing.Point(2, 2);
            this.txt_Msg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Msg.Multiline = true;
            this.txt_Msg.Name = "txt_Msg";
            this.txt_Msg.Size = new System.Drawing.Size(750, 455);
            this.txt_Msg.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // MainForm
            // 
            this.AcceptButton = this.btn_Connect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 529);
            this.Controls.Add(this.TabPage);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.MainMenuStrip);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "代码生成工具";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.TabPage.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TableDetails)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem 菜单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Exit;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TabControl TabPage;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStripButton tsbtn_Connect;
        private System.Windows.Forms.Label lbl_DataBaseType;
        private System.Windows.Forms.ComboBox cbb_DataBaseType;
        private System.Windows.Forms.Label lbl_Ip;
        private System.Windows.Forms.TextBox txt_Ip;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Help;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txt_Msg;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.Label lbl_Pwd;
        private System.Windows.Forms.TextBox txt_Pwd;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.Label lbl_DataBaseName;
        private System.Windows.Forms.Label lbl_NameSpace;
        private System.Windows.Forms.TextBox txt_NameSpace;
        private System.Windows.Forms.Label lbl_Path;
        private System.Windows.Forms.TextBox txt_Path;
        private System.Windows.Forms.Button btn_SelectPath;
        private System.Windows.Forms.LinkLabel lbl_Tips;
        private System.Windows.Forms.TextBox txt_DataBaseName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox cbb_Tables;
        private System.Windows.Forms.Button btn_Read;
        private System.Windows.Forms.Button btn_Generate;
        private System.Windows.Forms.DataGridView dgv_TableDetails;
        private System.Windows.Forms.Label lbl_TableName;
        private System.Windows.Forms.ComboBox cbb_Mode;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label lbl_Mode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn FieldName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FieldDescribe;
        private System.Windows.Forms.DataGridViewTextBoxColumn FieldType;
        private System.Windows.Forms.DataGridViewTextBoxColumn FieldLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsPrimaryKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsNull;
        private System.Windows.Forms.DataGridViewTextBoxColumn FieldDefaultValue;
        private System.Windows.Forms.ToolStripButton tsbtn_Disconnect;
        private System.Windows.Forms.ToolStripButton tsbtn_Exit;
    }
}