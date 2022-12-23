namespace ToDo
{
    partial class FormMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.docker = new Bunifu.UI.WinForms.BunifuFormDock();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.gridToDo = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.colChk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colTask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinishDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuSnackbar1 = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            this.addTextTask = new Bunifu.UI.WinForms.BunifuTextBox();
            this.addTaskBtn = new Bunifu.UI.WinForms.BunifuImageButton();
            this.updateBtn = new Bunifu.UI.WinForms.BunifuImageButton();
            this.removeBtn = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuSeparator2 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnImp = new System.Windows.Forms.Button();
            this.btnTomrw = new System.Windows.Forms.Button();
            this.btnToday = new System.Windows.Forms.Button();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.bunifuToolTip1 = new Bunifu.UI.WinForms.BunifuToolTip(this.components);
            this.btnInfo = new Bunifu.UI.WinForms.BunifuImageButton();
            this.newDateBtn = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnAll = new System.Windows.Forms.Button();
            this.labelRights = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridToDo)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // docker
            // 
            this.docker.AllowFormDragging = true;
            this.docker.AllowFormDropShadow = true;
            this.docker.AllowFormResizing = true;
            this.docker.AllowHidingBottomRegion = true;
            this.docker.AllowOpacityChangesWhileDragging = false;
            this.docker.BorderOptions.BottomBorder.BorderColor = System.Drawing.Color.Silver;
            this.docker.BorderOptions.BottomBorder.BorderThickness = 1;
            this.docker.BorderOptions.BottomBorder.ShowBorder = true;
            this.docker.BorderOptions.LeftBorder.BorderColor = System.Drawing.Color.Silver;
            this.docker.BorderOptions.LeftBorder.BorderThickness = 1;
            this.docker.BorderOptions.LeftBorder.ShowBorder = true;
            this.docker.BorderOptions.RightBorder.BorderColor = System.Drawing.Color.Silver;
            this.docker.BorderOptions.RightBorder.BorderThickness = 1;
            this.docker.BorderOptions.RightBorder.ShowBorder = true;
            this.docker.BorderOptions.TopBorder.BorderColor = System.Drawing.Color.Silver;
            this.docker.BorderOptions.TopBorder.BorderThickness = 1;
            this.docker.BorderOptions.TopBorder.ShowBorder = true;
            this.docker.ContainerControl = this;
            this.docker.DockingIndicatorsColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(215)))), ((int)(((byte)(233)))));
            this.docker.DockingIndicatorsOpacity = 0.5D;
            this.docker.DockingOptions.DockAll = true;
            this.docker.DockingOptions.DockBottomLeft = true;
            this.docker.DockingOptions.DockBottomRight = true;
            this.docker.DockingOptions.DockFullScreen = true;
            this.docker.DockingOptions.DockLeft = true;
            this.docker.DockingOptions.DockRight = true;
            this.docker.DockingOptions.DockTopLeft = true;
            this.docker.DockingOptions.DockTopRight = true;
            this.docker.FormDraggingOpacity = 0.9D;
            this.docker.ParentForm = this;
            this.docker.ShowCursorChanges = true;
            this.docker.ShowDockingIndicators = true;
            this.docker.TitleBarOptions.AllowFormDragging = true;
            this.docker.TitleBarOptions.BunifuFormDock = this.docker;
            this.docker.TitleBarOptions.DoubleClickToExpandWindow = true;
            this.docker.TitleBarOptions.TitleBarControl = null;
            this.docker.TitleBarOptions.UseBackColorOnDockingIndicators = false;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(49)))), ((int)(((byte)(212)))));
            this.bunifuLabel1.Location = new System.Drawing.Point(117, 26);
            this.bunifuLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(262, 77);
            this.bunifuLabel1.TabIndex = 0;
            this.bunifuLabel1.Text = "ToDo List";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuToolTip1.SetToolTip(this.bunifuLabel1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuLabel1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuLabel1, "");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(243)))), ((int)(((byte)(129)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.bunifuLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1402, 126);
            this.panel1.TabIndex = 4;
            this.bunifuToolTip1.SetToolTip(this.panel1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel1, "");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.pictureBox1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.pictureBox1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.pictureBox1, "");
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(0, 0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(200, 100);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.bunifuToolTip1.SetToolTip(this.tabPage1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.tabPage1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.tabPage1, "");
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(0, 0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(200, 100);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "tabPage2";
            this.bunifuToolTip1.SetToolTip(this.tabPage2, "");
            this.bunifuToolTip1.SetToolTipIcon(this.tabPage2, null);
            this.bunifuToolTip1.SetToolTipTitle(this.tabPage2, "");
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(0, 0);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(200, 100);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "tabPage3";
            this.bunifuToolTip1.SetToolTip(this.tabPage3, "");
            this.bunifuToolTip1.SetToolTipIcon(this.tabPage3, null);
            this.bunifuToolTip1.SetToolTipTitle(this.tabPage3, "");
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(0, 0);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(200, 100);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "tabPage4";
            this.bunifuToolTip1.SetToolTip(this.tabPage4, "");
            this.bunifuToolTip1.SetToolTipIcon(this.tabPage4, null);
            this.bunifuToolTip1.SetToolTipTitle(this.tabPage4, "");
            // 
            // gridToDo
            // 
            this.gridToDo.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.gridToDo.AllowCustomTheming = false;
            this.gridToDo.AllowUserToAddRows = false;
            this.gridToDo.AllowUserToDeleteRows = false;
            this.gridToDo.AllowUserToResizeColumns = false;
            this.gridToDo.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(236)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            this.gridToDo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.gridToDo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridToDo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(49)))), ((int)(((byte)(212)))));
            this.gridToDo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridToDo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridToDo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(143)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridToDo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.gridToDo.ColumnHeadersHeight = 40;
            this.gridToDo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colChk,
            this.colTask,
            this.colStartDate,
            this.colFinishDate,
            this.colStatus});
            this.gridToDo.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(236)))), ((int)(((byte)(219)))));
            this.gridToDo.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gridToDo.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gridToDo.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(209)))), ((int)(((byte)(169)))));
            this.gridToDo.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.gridToDo.CurrentTheme.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.gridToDo.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(232)))), ((int)(((byte)(212)))));
            this.gridToDo.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.gridToDo.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.gridToDo.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridToDo.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(143)))), ((int)(((byte)(90)))));
            this.gridToDo.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gridToDo.CurrentTheme.Name = null;
            this.gridToDo.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(239)))), ((int)(((byte)(226)))));
            this.gridToDo.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gridToDo.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gridToDo.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(209)))), ((int)(((byte)(169)))));
            this.gridToDo.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(239)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(209)))), ((int)(((byte)(169)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridToDo.DefaultCellStyle = dataGridViewCellStyle15;
            this.gridToDo.EnableHeadersVisualStyles = false;
            this.gridToDo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(232)))), ((int)(((byte)(212)))));
            this.gridToDo.HeaderBackColor = System.Drawing.Color.MediumSeaGreen;
            this.gridToDo.HeaderBgColor = System.Drawing.Color.Empty;
            this.gridToDo.HeaderForeColor = System.Drawing.Color.White;
            this.gridToDo.Location = new System.Drawing.Point(328, 228);
            this.gridToDo.Name = "gridToDo";
            this.gridToDo.RowHeadersVisible = false;
            this.gridToDo.RowTemplate.Height = 40;
            this.gridToDo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridToDo.Size = new System.Drawing.Size(1050, 534);
            this.gridToDo.TabIndex = 16;
            this.gridToDo.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.MediumSeaGreen;
            this.bunifuToolTip1.SetToolTip(this.gridToDo, "");
            this.bunifuToolTip1.SetToolTipIcon(this.gridToDo, null);
            this.bunifuToolTip1.SetToolTipTitle(this.gridToDo, "");
            this.gridToDo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridToDo_CellContentClick);
            // 
            // colChk
            // 
            this.colChk.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colChk.FillWeight = 30F;
            this.colChk.HeaderText = "    ✓";
            this.colChk.Name = "colChk";
            this.colChk.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colChk.ToolTipText = "Выполнено";
            // 
            // colTask
            // 
            this.colTask.FillWeight = 200F;
            this.colTask.HeaderText = "Задача";
            this.colTask.Name = "colTask";
            this.colTask.ReadOnly = true;
            this.colTask.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colTask.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colTask.ToolTipText = "Чтобы взаимодействовать используйте меню выше";
            // 
            // colStartDate
            // 
            dataGridViewCellStyle13.Format = "M";
            dataGridViewCellStyle13.NullValue = null;
            this.colStartDate.DefaultCellStyle = dataGridViewCellStyle13;
            this.colStartDate.HeaderText = "Дата начала";
            this.colStartDate.Name = "colStartDate";
            this.colStartDate.ReadOnly = true;
            this.colStartDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colStartDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colStartDate.ToolTipText = "День, когда было добавлено задание";
            // 
            // colFinishDate
            // 
            dataGridViewCellStyle14.Format = "M";
            dataGridViewCellStyle14.NullValue = null;
            this.colFinishDate.DefaultCellStyle = dataGridViewCellStyle14;
            this.colFinishDate.HeaderText = "Дата окончания";
            this.colFinishDate.Name = "colFinishDate";
            this.colFinishDate.ReadOnly = true;
            this.colFinishDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colFinishDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colFinishDate.ToolTipText = "День, когда истечет срок выполнения задания";
            // 
            // colStatus
            // 
            this.colStatus.FillWeight = 80F;
            this.colStatus.HeaderText = "Статус";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colStatus.ToolTipText = "Показывает, в каком состоянии находится задание";
            // 
            // bunifuSnackbar1
            // 
            this.bunifuSnackbar1.AllowDragging = false;
            this.bunifuSnackbar1.AllowMultipleViews = true;
            this.bunifuSnackbar1.ClickToClose = true;
            this.bunifuSnackbar1.DoubleClickToClose = true;
            this.bunifuSnackbar1.DurationAfterIdle = 3000;
            this.bunifuSnackbar1.ErrorOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.ErrorOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.ErrorOptions.ActionBorderRadius = 1;
            this.bunifuSnackbar1.ErrorOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bunifuSnackbar1.ErrorOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.ErrorOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.ErrorOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.ErrorOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(199)))));
            this.bunifuSnackbar1.ErrorOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuSnackbar1.ErrorOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.ErrorOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon")));
            this.bunifuSnackbar1.ErrorOptions.IconLeftMargin = 12;
            this.bunifuSnackbar1.FadeCloseIcon = false;
            this.bunifuSnackbar1.Host = Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner;
            this.bunifuSnackbar1.InformationOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.InformationOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.InformationOptions.ActionBorderRadius = 1;
            this.bunifuSnackbar1.InformationOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bunifuSnackbar1.InformationOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.InformationOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.InformationOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.InformationOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.InformationOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuSnackbar1.InformationOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.InformationOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon1")));
            this.bunifuSnackbar1.InformationOptions.IconLeftMargin = 12;
            this.bunifuSnackbar1.Margin = 10;
            this.bunifuSnackbar1.MaximumSize = new System.Drawing.Size(0, 0);
            this.bunifuSnackbar1.MaximumViews = 7;
            this.bunifuSnackbar1.MessageRightMargin = 15;
            this.bunifuSnackbar1.MinimumSize = new System.Drawing.Size(0, 0);
            this.bunifuSnackbar1.ShowBorders = false;
            this.bunifuSnackbar1.ShowCloseIcon = false;
            this.bunifuSnackbar1.ShowIcon = true;
            this.bunifuSnackbar1.ShowShadows = true;
            this.bunifuSnackbar1.SuccessOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.SuccessOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.SuccessOptions.ActionBorderRadius = 1;
            this.bunifuSnackbar1.SuccessOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bunifuSnackbar1.SuccessOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.SuccessOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.SuccessOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.SuccessOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(255)))), ((int)(((byte)(237)))));
            this.bunifuSnackbar1.SuccessOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuSnackbar1.SuccessOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.SuccessOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon2")));
            this.bunifuSnackbar1.SuccessOptions.IconLeftMargin = 12;
            this.bunifuSnackbar1.ViewsMargin = 3;
            this.bunifuSnackbar1.WarningOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.WarningOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.WarningOptions.ActionBorderRadius = 1;
            this.bunifuSnackbar1.WarningOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bunifuSnackbar1.WarningOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.WarningOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.WarningOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.WarningOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(143)))));
            this.bunifuSnackbar1.WarningOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuSnackbar1.WarningOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.WarningOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon3")));
            this.bunifuSnackbar1.WarningOptions.IconLeftMargin = 12;
            this.bunifuSnackbar1.ZoomCloseIcon = true;
            // 
            // addTextTask
            // 
            this.addTextTask.AcceptsReturn = false;
            this.addTextTask.AcceptsTab = false;
            this.addTextTask.AnimationSpeed = 200;
            this.addTextTask.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.addTextTask.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.addTextTask.BackColor = System.Drawing.Color.Transparent;
            this.addTextTask.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addTextTask.BackgroundImage")));
            this.addTextTask.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.addTextTask.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.addTextTask.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.addTextTask.BorderColorIdle = System.Drawing.Color.Silver;
            this.addTextTask.BorderRadius = 1;
            this.addTextTask.BorderThickness = 1;
            this.addTextTask.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.addTextTask.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addTextTask.DefaultFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addTextTask.DefaultText = "";
            this.addTextTask.FillColor = System.Drawing.Color.White;
            this.addTextTask.HideSelection = true;
            this.addTextTask.IconLeft = null;
            this.addTextTask.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.addTextTask.IconPadding = 10;
            this.addTextTask.IconRight = null;
            this.addTextTask.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.addTextTask.Lines = new string[0];
            this.addTextTask.Location = new System.Drawing.Point(392, 147);
            this.addTextTask.MaxLength = 32767;
            this.addTextTask.MinimumSize = new System.Drawing.Size(1, 1);
            this.addTextTask.Modified = false;
            this.addTextTask.Multiline = false;
            this.addTextTask.Name = "addTextTask";
            stateProperties9.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.addTextTask.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.addTextTask.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Empty;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.addTextTask.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.Silver;
            stateProperties12.FillColor = System.Drawing.Color.White;
            stateProperties12.ForeColor = System.Drawing.Color.Empty;
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.addTextTask.OnIdleState = stateProperties12;
            this.addTextTask.Padding = new System.Windows.Forms.Padding(3);
            this.addTextTask.PasswordChar = '\0';
            this.addTextTask.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.addTextTask.PlaceholderText = "Добавить задачу";
            this.addTextTask.ReadOnly = false;
            this.addTextTask.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.addTextTask.SelectedText = "";
            this.addTextTask.SelectionLength = 0;
            this.addTextTask.SelectionStart = 0;
            this.addTextTask.ShortcutsEnabled = true;
            this.addTextTask.Size = new System.Drawing.Size(791, 44);
            this.addTextTask.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.addTextTask.TabIndex = 21;
            this.addTextTask.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.addTextTask.TextMarginBottom = 0;
            this.addTextTask.TextMarginLeft = 3;
            this.addTextTask.TextMarginTop = 0;
            this.addTextTask.TextPlaceholder = "Добавить задачу";
            this.bunifuToolTip1.SetToolTip(this.addTextTask, "");
            this.bunifuToolTip1.SetToolTipIcon(this.addTextTask, null);
            this.bunifuToolTip1.SetToolTipTitle(this.addTextTask, "");
            this.addTextTask.UseSystemPasswordChar = false;
            this.addTextTask.WordWrap = true;
            this.addTextTask.KeyUp += new System.Windows.Forms.KeyEventHandler(this.addTextTask_KeyUp);
            // 
            // addTaskBtn
            // 
            this.addTaskBtn.ActiveImage = null;
            this.addTaskBtn.AllowAnimations = true;
            this.addTaskBtn.AllowBuffering = false;
            this.addTaskBtn.AllowToggling = false;
            this.addTaskBtn.AllowZooming = true;
            this.addTaskBtn.AllowZoomingOnFocus = false;
            this.addTaskBtn.BackColor = System.Drawing.Color.Transparent;
            this.addTaskBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.addTaskBtn.ErrorImage = ((System.Drawing.Image)(resources.GetObject("addTaskBtn.ErrorImage")));
            this.addTaskBtn.FadeWhenInactive = false;
            this.addTaskBtn.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.addTaskBtn.Image = ((System.Drawing.Image)(resources.GetObject("addTaskBtn.Image")));
            this.addTaskBtn.ImageActive = null;
            this.addTaskBtn.ImageLocation = null;
            this.addTaskBtn.ImageMargin = 0;
            this.addTaskBtn.ImageSize = new System.Drawing.Size(49, 49);
            this.addTaskBtn.ImageZoomSize = new System.Drawing.Size(50, 50);
            this.addTaskBtn.InitialImage = ((System.Drawing.Image)(resources.GetObject("addTaskBtn.InitialImage")));
            this.addTaskBtn.Location = new System.Drawing.Point(329, 144);
            this.addTaskBtn.Name = "addTaskBtn";
            this.addTaskBtn.Rotation = 0;
            this.addTaskBtn.ShowActiveImage = true;
            this.addTaskBtn.ShowCursorChanges = true;
            this.addTaskBtn.ShowImageBorders = false;
            this.addTaskBtn.ShowSizeMarkers = false;
            this.addTaskBtn.Size = new System.Drawing.Size(50, 50);
            this.addTaskBtn.TabIndex = 23;
            this.bunifuToolTip1.SetToolTip(this.addTaskBtn, "Добавить новую задачу");
            this.bunifuToolTip1.SetToolTipIcon(this.addTaskBtn, ((System.Drawing.Image)(resources.GetObject("addTaskBtn.ToolTipIcon"))));
            this.addTaskBtn.ToolTipText = "Новая задача";
            this.bunifuToolTip1.SetToolTipTitle(this.addTaskBtn, "");
            this.addTaskBtn.WaitOnLoad = false;
            this.addTaskBtn.Zoom = 0;
            this.addTaskBtn.ZoomSpeed = 10;
            this.addTaskBtn.Click += new System.EventHandler(this.addTaskBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.ActiveImage = null;
            this.updateBtn.AllowAnimations = true;
            this.updateBtn.AllowBuffering = false;
            this.updateBtn.AllowToggling = false;
            this.updateBtn.AllowZooming = true;
            this.updateBtn.AllowZoomingOnFocus = false;
            this.updateBtn.BackColor = System.Drawing.Color.Transparent;
            this.updateBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.updateBtn.ErrorImage = ((System.Drawing.Image)(resources.GetObject("updateBtn.ErrorImage")));
            this.updateBtn.FadeWhenInactive = false;
            this.updateBtn.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.updateBtn.Image = ((System.Drawing.Image)(resources.GetObject("updateBtn.Image")));
            this.updateBtn.ImageActive = null;
            this.updateBtn.ImageLocation = null;
            this.updateBtn.ImageMargin = 0;
            this.updateBtn.ImageSize = new System.Drawing.Size(49, 49);
            this.updateBtn.ImageZoomSize = new System.Drawing.Size(50, 50);
            this.updateBtn.InitialImage = ((System.Drawing.Image)(resources.GetObject("updateBtn.InitialImage")));
            this.updateBtn.Location = new System.Drawing.Point(1196, 144);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Rotation = 0;
            this.updateBtn.ShowActiveImage = true;
            this.updateBtn.ShowCursorChanges = true;
            this.updateBtn.ShowImageBorders = true;
            this.updateBtn.ShowSizeMarkers = false;
            this.updateBtn.Size = new System.Drawing.Size(50, 50);
            this.updateBtn.TabIndex = 24;
            this.bunifuToolTip1.SetToolTip(this.updateBtn, "Редактировать");
            this.bunifuToolTip1.SetToolTipIcon(this.updateBtn, ((System.Drawing.Image)(resources.GetObject("updateBtn.ToolTipIcon"))));
            this.updateBtn.ToolTipText = "\r\n";
            this.bunifuToolTip1.SetToolTipTitle(this.updateBtn, "");
            this.updateBtn.WaitOnLoad = false;
            this.updateBtn.Zoom = 0;
            this.updateBtn.ZoomSpeed = 10;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.ActiveImage = null;
            this.removeBtn.AllowAnimations = true;
            this.removeBtn.AllowBuffering = false;
            this.removeBtn.AllowToggling = false;
            this.removeBtn.AllowZooming = true;
            this.removeBtn.AllowZoomingOnFocus = false;
            this.removeBtn.BackColor = System.Drawing.Color.Transparent;
            this.removeBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.removeBtn.ErrorImage = ((System.Drawing.Image)(resources.GetObject("removeBtn.ErrorImage")));
            this.removeBtn.FadeWhenInactive = false;
            this.removeBtn.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.removeBtn.Image = ((System.Drawing.Image)(resources.GetObject("removeBtn.Image")));
            this.removeBtn.ImageActive = null;
            this.removeBtn.ImageLocation = null;
            this.removeBtn.ImageMargin = 0;
            this.removeBtn.ImageSize = new System.Drawing.Size(49, 49);
            this.removeBtn.ImageZoomSize = new System.Drawing.Size(50, 50);
            this.removeBtn.InitialImage = ((System.Drawing.Image)(resources.GetObject("removeBtn.InitialImage")));
            this.removeBtn.Location = new System.Drawing.Point(1259, 144);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Rotation = 0;
            this.removeBtn.ShowActiveImage = true;
            this.removeBtn.ShowCursorChanges = true;
            this.removeBtn.ShowImageBorders = true;
            this.removeBtn.ShowSizeMarkers = false;
            this.removeBtn.Size = new System.Drawing.Size(50, 50);
            this.removeBtn.TabIndex = 25;
            this.bunifuToolTip1.SetToolTip(this.removeBtn, "Удалить");
            this.bunifuToolTip1.SetToolTipIcon(this.removeBtn, ((System.Drawing.Image)(resources.GetObject("removeBtn.ToolTipIcon"))));
            this.removeBtn.ToolTipText = " \r\n";
            this.bunifuToolTip1.SetToolTipTitle(this.removeBtn, "");
            this.removeBtn.WaitOnLoad = false;
            this.removeBtn.Zoom = 0;
            this.removeBtn.ZoomSpeed = 10;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator2.BackgroundImage")));
            this.bunifuSeparator2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator2.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(243)))), ((int)(((byte)(129)))));
            this.bunifuSeparator2.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.DoubleEdgeFaded;
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(328, 200);
            this.bunifuSeparator2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator2.Size = new System.Drawing.Size(1047, 19);
            this.bunifuSeparator2.TabIndex = 31;
            this.bunifuToolTip1.SetToolTip(this.bunifuSeparator2, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuSeparator2, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuSeparator2, "");
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.btnAll);
            this.panelMenu.Controls.Add(this.btnImp);
            this.panelMenu.Controls.Add(this.btnTomrw);
            this.panelMenu.Controls.Add(this.btnToday);
            this.panelMenu.Location = new System.Drawing.Point(0, 147);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(294, 340);
            this.panelMenu.TabIndex = 32;
            this.bunifuToolTip1.SetToolTip(this.panelMenu, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panelMenu, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panelMenu, "");
            // 
            // btnImp
            // 
            this.btnImp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnImp.FlatAppearance.BorderSize = 0;
            this.btnImp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImp.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnImp.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnImp.Image = ((System.Drawing.Image)(resources.GetObject("btnImp.Image")));
            this.btnImp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImp.Location = new System.Drawing.Point(0, 162);
            this.btnImp.Name = "btnImp";
            this.btnImp.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnImp.Size = new System.Drawing.Size(294, 81);
            this.btnImp.TabIndex = 2;
            this.btnImp.Text = "  Важные";
            this.btnImp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bunifuToolTip1.SetToolTip(this.btnImp, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btnImp, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnImp, "");
            this.btnImp.UseVisualStyleBackColor = true;
            this.btnImp.Click += new System.EventHandler(this.btnImp_Click);
            // 
            // btnTomrw
            // 
            this.btnTomrw.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTomrw.FlatAppearance.BorderSize = 0;
            this.btnTomrw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTomrw.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTomrw.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTomrw.Image = ((System.Drawing.Image)(resources.GetObject("btnTomrw.Image")));
            this.btnTomrw.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTomrw.Location = new System.Drawing.Point(0, 81);
            this.btnTomrw.Name = "btnTomrw";
            this.btnTomrw.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnTomrw.Size = new System.Drawing.Size(294, 81);
            this.btnTomrw.TabIndex = 1;
            this.btnTomrw.Text = "  Завтра";
            this.btnTomrw.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTomrw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bunifuToolTip1.SetToolTip(this.btnTomrw, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btnTomrw, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnTomrw, "");
            this.btnTomrw.UseVisualStyleBackColor = true;
            this.btnTomrw.Click += new System.EventHandler(this.btnTomrw_Click);
            // 
            // btnToday
            // 
            this.btnToday.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnToday.FlatAppearance.BorderSize = 0;
            this.btnToday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToday.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnToday.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnToday.Image = ((System.Drawing.Image)(resources.GetObject("btnToday.Image")));
            this.btnToday.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnToday.Location = new System.Drawing.Point(0, 0);
            this.btnToday.Name = "btnToday";
            this.btnToday.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnToday.Size = new System.Drawing.Size(294, 81);
            this.btnToday.TabIndex = 0;
            this.btnToday.Text = "  Сегодня";
            this.btnToday.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnToday.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bunifuToolTip1.SetToolTip(this.btnToday, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btnToday, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnToday, "");
            this.btnToday.UseVisualStyleBackColor = true;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator1.BackgroundImage")));
            this.bunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(243)))), ((int)(((byte)(129)))));
            this.bunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.DoubleEdgeFaded;
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(304, 137);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Vertical;
            this.bunifuSeparator1.Size = new System.Drawing.Size(10, 633);
            this.bunifuSeparator1.TabIndex = 33;
            this.bunifuToolTip1.SetToolTip(this.bunifuSeparator1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuSeparator1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuSeparator1, "");
            // 
            // bunifuToolTip1
            // 
            this.bunifuToolTip1.Active = true;
            this.bunifuToolTip1.AlignTextWithTitle = false;
            this.bunifuToolTip1.AllowAutoClose = false;
            this.bunifuToolTip1.AllowFading = true;
            this.bunifuToolTip1.AutoCloseDuration = 5000;
            this.bunifuToolTip1.BackColor = System.Drawing.Color.White;
            this.bunifuToolTip1.BorderColor = System.Drawing.Color.Gainsboro;
            this.bunifuToolTip1.ClickToShowDisplayControl = false;
            this.bunifuToolTip1.ConvertNewlinesToBreakTags = true;
            this.bunifuToolTip1.DisplayControl = null;
            this.bunifuToolTip1.EntryAnimationSpeed = 350;
            this.bunifuToolTip1.ExitAnimationSpeed = 200;
            this.bunifuToolTip1.GenerateAutoCloseDuration = false;
            this.bunifuToolTip1.IconMargin = 6;
            this.bunifuToolTip1.InitialDelay = 0;
            this.bunifuToolTip1.Name = "bunifuToolTip1";
            this.bunifuToolTip1.Opacity = 1D;
            this.bunifuToolTip1.OverrideToolTipTitles = false;
            this.bunifuToolTip1.Padding = new System.Windows.Forms.Padding(10);
            this.bunifuToolTip1.ReshowDelay = 100;
            this.bunifuToolTip1.ShowAlways = true;
            this.bunifuToolTip1.ShowBorders = false;
            this.bunifuToolTip1.ShowIcons = true;
            this.bunifuToolTip1.ShowShadows = true;
            this.bunifuToolTip1.Tag = null;
            this.bunifuToolTip1.TextFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuToolTip1.TextForeColor = System.Drawing.Color.Black;
            this.bunifuToolTip1.TextMargin = 2;
            this.bunifuToolTip1.TitleFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuToolTip1.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(49)))), ((int)(((byte)(212)))));
            this.bunifuToolTip1.ToolTipPosition = new System.Drawing.Point(0, 0);
            this.bunifuToolTip1.ToolTipTitle = null;
            // 
            // btnInfo
            // 
            this.btnInfo.ActiveImage = null;
            this.btnInfo.AllowAnimations = true;
            this.btnInfo.AllowBuffering = false;
            this.btnInfo.AllowToggling = false;
            this.btnInfo.AllowZooming = true;
            this.btnInfo.AllowZoomingOnFocus = false;
            this.btnInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnInfo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnInfo.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnInfo.ErrorImage")));
            this.btnInfo.FadeWhenInactive = false;
            this.btnInfo.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnInfo.Image")));
            this.btnInfo.ImageActive = null;
            this.btnInfo.ImageLocation = null;
            this.btnInfo.ImageMargin = 0;
            this.btnInfo.ImageSize = new System.Drawing.Size(47, 47);
            this.btnInfo.ImageZoomSize = new System.Drawing.Size(48, 48);
            this.btnInfo.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnInfo.InitialImage")));
            this.btnInfo.Location = new System.Drawing.Point(22, 714);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Rotation = 0;
            this.btnInfo.ShowActiveImage = true;
            this.btnInfo.ShowCursorChanges = true;
            this.btnInfo.ShowImageBorders = true;
            this.btnInfo.ShowSizeMarkers = false;
            this.btnInfo.Size = new System.Drawing.Size(48, 48);
            this.btnInfo.TabIndex = 35;
            this.bunifuToolTip1.SetToolTip(this.btnInfo, "Лучшее приложение для составления списков, \r\nкоторое пригодится вам и на работе, " +
        "и на отдыхе.\r\nПриложение поможет вам обрести концентрацию, \r\nорганизованность и " +
        "покой.");
            this.bunifuToolTip1.SetToolTipIcon(this.btnInfo, ((System.Drawing.Image)(resources.GetObject("btnInfo.ToolTipIcon"))));
            this.btnInfo.ToolTipText = "";
            this.bunifuToolTip1.SetToolTipTitle(this.btnInfo, "ToDo List");
            this.btnInfo.WaitOnLoad = false;
            this.btnInfo.Zoom = 0;
            this.btnInfo.ZoomSpeed = 10;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // newDateBtn
            // 
            this.newDateBtn.ActiveImage = null;
            this.newDateBtn.AllowAnimations = true;
            this.newDateBtn.AllowBuffering = false;
            this.newDateBtn.AllowToggling = false;
            this.newDateBtn.AllowZooming = true;
            this.newDateBtn.AllowZoomingOnFocus = false;
            this.newDateBtn.BackColor = System.Drawing.Color.Transparent;
            this.newDateBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.newDateBtn.ErrorImage = ((System.Drawing.Image)(resources.GetObject("newDateBtn.ErrorImage")));
            this.newDateBtn.FadeWhenInactive = false;
            this.newDateBtn.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.newDateBtn.Image = ((System.Drawing.Image)(resources.GetObject("newDateBtn.Image")));
            this.newDateBtn.ImageActive = null;
            this.newDateBtn.ImageLocation = null;
            this.newDateBtn.ImageMargin = 0;
            this.newDateBtn.ImageSize = new System.Drawing.Size(49, 49);
            this.newDateBtn.ImageZoomSize = new System.Drawing.Size(50, 50);
            this.newDateBtn.InitialImage = ((System.Drawing.Image)(resources.GetObject("newDateBtn.InitialImage")));
            this.newDateBtn.Location = new System.Drawing.Point(1322, 144);
            this.newDateBtn.Name = "newDateBtn";
            this.newDateBtn.Rotation = 0;
            this.newDateBtn.ShowActiveImage = true;
            this.newDateBtn.ShowCursorChanges = true;
            this.newDateBtn.ShowImageBorders = true;
            this.newDateBtn.ShowSizeMarkers = false;
            this.newDateBtn.Size = new System.Drawing.Size(50, 50);
            this.newDateBtn.TabIndex = 36;
            this.bunifuToolTip1.SetToolTip(this.newDateBtn, "Обновить дату");
            this.bunifuToolTip1.SetToolTipIcon(this.newDateBtn, ((System.Drawing.Image)(resources.GetObject("newDateBtn.ToolTipIcon"))));
            this.newDateBtn.ToolTipText = "Обновить дату";
            this.bunifuToolTip1.SetToolTipTitle(this.newDateBtn, "");
            this.newDateBtn.WaitOnLoad = false;
            this.newDateBtn.Zoom = 0;
            this.newDateBtn.ZoomSpeed = 10;
            this.newDateBtn.Click += new System.EventHandler(this.newDateBtn_Click);
            // 
            // btnAll
            // 
            this.btnAll.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAll.FlatAppearance.BorderSize = 0;
            this.btnAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAll.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAll.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAll.Image = ((System.Drawing.Image)(resources.GetObject("btnAll.Image")));
            this.btnAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAll.Location = new System.Drawing.Point(0, 243);
            this.btnAll.Name = "btnAll";
            this.btnAll.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnAll.Size = new System.Drawing.Size(294, 81);
            this.btnAll.TabIndex = 3;
            this.btnAll.Text = "  Все задачи";
            this.btnAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bunifuToolTip1.SetToolTip(this.btnAll, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btnAll, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnAll, "");
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // labelRights
            // 
            this.labelRights.AutoSize = true;
            this.labelRights.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRights.ForeColor = System.Drawing.Color.White;
            this.labelRights.Location = new System.Drawing.Point(89, 750);
            this.labelRights.Name = "labelRights";
            this.labelRights.Size = new System.Drawing.Size(205, 12);
            this.labelRights.TabIndex = 37;
            this.labelRights.Text = "ООО «ToDo List» Все права не защищены © 2022";
            this.bunifuToolTip1.SetToolTip(this.labelRights, "");
            this.bunifuToolTip1.SetToolTipIcon(this.labelRights, null);
            this.bunifuToolTip1.SetToolTipTitle(this.labelRights, "");
            this.labelRights.Visible = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(49)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(1402, 774);
            this.Controls.Add(this.labelRights);
            this.Controls.Add(this.newDateBtn);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.addTaskBtn);
            this.Controls.Add(this.addTextTask);
            this.Controls.Add(this.gridToDo);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ToDo List";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridToDo)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuFormDock docker;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuDataGridView gridToDo;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private Bunifu.UI.WinForms.BunifuSnackbar bunifuSnackbar1;
        private Bunifu.UI.WinForms.BunifuImageButton addTaskBtn;
        private Bunifu.UI.WinForms.BunifuTextBox addTextTask;
        private Bunifu.UI.WinForms.BunifuImageButton updateBtn;
        private Bunifu.UI.WinForms.BunifuImageButton removeBtn;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colChk;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTask;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinishDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.Button btnImp;
        private System.Windows.Forms.Button btnTomrw;
        private Bunifu.UI.WinForms.BunifuImageButton btnInfo;
        private Bunifu.UI.WinForms.BunifuToolTip bunifuToolTip1;
        private Bunifu.UI.WinForms.BunifuImageButton newDateBtn;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Label labelRights;
    }
}

