namespace Tyuiu.MikhailichenkoAI.Sprint7.Project.V3
{
    partial class FormMain_MAI
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartAreaAnalytics_MAI = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legendAnalytics_MAI = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataGridViewCellStyle gridAlternatingStyle_MAI = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle gridHeaderStyle_MAI = new System.Windows.Forms.DataGridViewCellStyle();

            this.menuStripMain_MAI = new System.Windows.Forms.MenuStrip();
            this.menuItemFile_MAI = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemOpenCsv_MAI = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSaveCsv_MAI = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSaveAsCsv_MAI = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSeparatorFile_MAI = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemExit_MAI = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemRecords_MAI = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAddRecord_MAI = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemEditRecord_MAI = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDeleteRecord_MAI = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAnalytics_MAI = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemRefreshChart_MAI = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemResetFilters_MAI = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemHelp_MAI = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemGuide_MAI = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAbout_MAI = new System.Windows.Forms.ToolStripMenuItem();

            this.toolStripMain_MAI = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonOpen_MAI = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSave_MAI = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparatorOne_MAI = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonAdd_MAI = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEdit_MAI = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDelete_MAI = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparatorTwo_MAI = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonReset_MAI = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparatorThree_MAI = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonGuide_MAI = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAbout_MAI = new System.Windows.Forms.ToolStripButton();

            this.panelFilterBar_MAI = new System.Windows.Forms.Panel();
            this.groupBoxControls_MAI = new System.Windows.Forms.GroupBox();
            this.labelSearch_MAI = new System.Windows.Forms.Label();
            this.textBoxSearch_MAI = new System.Windows.Forms.TextBox();
            this.labelFilterPosition_MAI = new System.Windows.Forms.Label();
            this.comboBoxFilterPosition_MAI = new System.Windows.Forms.ComboBox();
            this.labelFilterControl_MAI = new System.Windows.Forms.Label();
            this.comboBoxFilterControl_MAI = new System.Windows.Forms.ComboBox();
            this.labelFilterDepartment_MAI = new System.Windows.Forms.Label();
            this.comboBoxFilterDepartment_MAI = new System.Windows.Forms.ComboBox();
            this.labelSortField_MAI = new System.Windows.Forms.Label();
            this.comboBoxSortField_MAI = new System.Windows.Forms.ComboBox();
            this.checkBoxSortAsc_MAI = new System.Windows.Forms.CheckBox();
            this.buttonResetFilters_MAI = new System.Windows.Forms.Button();

            this.splitContainerMain_MAI = new System.Windows.Forms.SplitContainer();
            this.groupBoxDataGrid_MAI = new System.Windows.Forms.GroupBox();
            this.dataGridViewUniversity_MAI = new System.Windows.Forms.DataGridView();
            this.splitContainerAnalytics_MAI = new System.Windows.Forms.SplitContainer();
            this.groupBoxStatistics_MAI = new System.Windows.Forms.GroupBox();
            this.labelStatCount_MAI = new System.Windows.Forms.Label();
            this.textBoxStatCount_MAI = new System.Windows.Forms.TextBox();
            this.labelStatSum_MAI = new System.Windows.Forms.Label();
            this.textBoxStatSum_MAI = new System.Windows.Forms.TextBox();
            this.labelStatAvg_MAI = new System.Windows.Forms.Label();
            this.textBoxStatAvg_MAI = new System.Windows.Forms.TextBox();
            this.labelStatMin_MAI = new System.Windows.Forms.Label();
            this.textBoxStatMin_MAI = new System.Windows.Forms.TextBox();
            this.labelStatMax_MAI = new System.Windows.Forms.Label();
            this.textBoxStatMax_MAI = new System.Windows.Forms.TextBox();
            this.groupBoxChart_MAI = new System.Windows.Forms.GroupBox();
            this.panelChartHeader_MAI = new System.Windows.Forms.Panel();
            this.labelChartMode_MAI = new System.Windows.Forms.Label();
            this.comboBoxChartMode_MAI = new System.Windows.Forms.ComboBox();
            this.chartAnalytics_MAI = new System.Windows.Forms.DataVisualization.Charting.Chart();

            this.statusStripMain_MAI = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelFile_MAI = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelCount_MAI = new System.Windows.Forms.ToolStripStatusLabel();

            this.openFileDialogCsv_MAI = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogCsv_MAI = new System.Windows.Forms.SaveFileDialog();
            this.toolTipMain_MAI = new System.Windows.Forms.ToolTip(this.components);

            this.menuStripMain_MAI.SuspendLayout();
            this.toolStripMain_MAI.SuspendLayout();
            this.panelFilterBar_MAI.SuspendLayout();
            this.groupBoxControls_MAI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain_MAI)).BeginInit();
            this.splitContainerMain_MAI.Panel1.SuspendLayout();
            this.splitContainerMain_MAI.Panel2.SuspendLayout();
            this.splitContainerMain_MAI.SuspendLayout();
            this.groupBoxDataGrid_MAI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUniversity_MAI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAnalytics_MAI)).BeginInit();
            this.splitContainerAnalytics_MAI.Panel1.SuspendLayout();
            this.splitContainerAnalytics_MAI.Panel2.SuspendLayout();
            this.splitContainerAnalytics_MAI.SuspendLayout();
            this.groupBoxStatistics_MAI.SuspendLayout();
            this.groupBoxChart_MAI.SuspendLayout();
            this.panelChartHeader_MAI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartAnalytics_MAI)).BeginInit();
            this.statusStripMain_MAI.SuspendLayout();
            this.SuspendLayout();

            this.menuStripMain_MAI.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.menuItemFile_MAI,
                this.menuItemRecords_MAI,
                this.menuItemAnalytics_MAI,
                this.menuItemHelp_MAI
            });
            this.menuStripMain_MAI.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain_MAI.Name = "menuStripMain_MAI";
            this.menuStripMain_MAI.Size = new System.Drawing.Size(1184, 24);
            this.menuStripMain_MAI.TabIndex = 0;

            this.menuItemFile_MAI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.menuItemOpenCsv_MAI,
                this.menuItemSaveCsv_MAI,
                this.menuItemSaveAsCsv_MAI,
                this.menuSeparatorFile_MAI,
                this.menuItemExit_MAI
            });
            this.menuItemFile_MAI.Name = "menuItemFile_MAI";
            this.menuItemFile_MAI.Text = "Файл";

            this.menuItemOpenCsv_MAI.Name = "menuItemOpenCsv_MAI";
            this.menuItemOpenCsv_MAI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menuItemOpenCsv_MAI.Text = "Открыть CSV...";
            this.menuItemOpenCsv_MAI.Click += new System.EventHandler(this.menuItemOpenCsv_MAI_Click);

            this.menuItemSaveCsv_MAI.Name = "menuItemSaveCsv_MAI";
            this.menuItemSaveCsv_MAI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuItemSaveCsv_MAI.Text = "Сохранить";
            this.menuItemSaveCsv_MAI.Click += new System.EventHandler(this.menuItemSaveCsv_MAI_Click);

            this.menuItemSaveAsCsv_MAI.Name = "menuItemSaveAsCsv_MAI";
            this.menuItemSaveAsCsv_MAI.Text = "Сохранить как...";
            this.menuItemSaveAsCsv_MAI.Click += new System.EventHandler(this.menuItemSaveAsCsv_MAI_Click);

            this.menuSeparatorFile_MAI.Name = "menuSeparatorFile_MAI";

            this.menuItemExit_MAI.Name = "menuItemExit_MAI";
            this.menuItemExit_MAI.Text = "Выход";
            this.menuItemExit_MAI.Click += new System.EventHandler(this.menuItemExit_MAI_Click);

            this.menuItemRecords_MAI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.menuItemAddRecord_MAI,
                this.menuItemEditRecord_MAI,
                this.menuItemDeleteRecord_MAI
            });
            this.menuItemRecords_MAI.Name = "menuItemRecords_MAI";
            this.menuItemRecords_MAI.Text = "Записи";

            this.menuItemAddRecord_MAI.Name = "menuItemAddRecord_MAI";
            this.menuItemAddRecord_MAI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuItemAddRecord_MAI.Text = "Добавить запись...";
            this.menuItemAddRecord_MAI.Click += new System.EventHandler(this.menuItemAddRecord_MAI_Click);

            this.menuItemEditRecord_MAI.Name = "menuItemEditRecord_MAI";
            this.menuItemEditRecord_MAI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.menuItemEditRecord_MAI.Text = "Редактировать выбранную...";
            this.menuItemEditRecord_MAI.Click += new System.EventHandler(this.menuItemEditRecord_MAI_Click);

            this.menuItemDeleteRecord_MAI.Name = "menuItemDeleteRecord_MAI";
            this.menuItemDeleteRecord_MAI.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.menuItemDeleteRecord_MAI.Text = "Удалить выбранную";
            this.menuItemDeleteRecord_MAI.Click += new System.EventHandler(this.menuItemDeleteRecord_MAI_Click);

            this.menuItemAnalytics_MAI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.menuItemRefreshChart_MAI,
                this.menuItemResetFilters_MAI
            });
            this.menuItemAnalytics_MAI.Name = "menuItemAnalytics_MAI";
            this.menuItemAnalytics_MAI.Text = "Аналитика";

            this.menuItemRefreshChart_MAI.Name = "menuItemRefreshChart_MAI";
            this.menuItemRefreshChart_MAI.Text = "Обновить диаграмму";
            this.menuItemRefreshChart_MAI.Click += new System.EventHandler(this.menuItemRefreshChart_MAI_Click);

            this.menuItemResetFilters_MAI.Name = "menuItemResetFilters_MAI";
            this.menuItemResetFilters_MAI.Text = "Сбросить фильтры и поиск";
            this.menuItemResetFilters_MAI.Click += new System.EventHandler(this.menuItemResetFilters_MAI_Click);

            this.menuItemHelp_MAI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.menuItemGuide_MAI,
                this.menuItemAbout_MAI
            });
            this.menuItemHelp_MAI.Name = "menuItemHelp_MAI";
            this.menuItemHelp_MAI.Text = "Справка";

            this.menuItemGuide_MAI.Name = "menuItemGuide_MAI";
            this.menuItemGuide_MAI.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.menuItemGuide_MAI.Text = "Руководство пользователя";
            this.menuItemGuide_MAI.Click += new System.EventHandler(this.menuItemGuide_MAI_Click);

            this.menuItemAbout_MAI.Name = "menuItemAbout_MAI";
            this.menuItemAbout_MAI.Text = "О программе";
            this.menuItemAbout_MAI.Click += new System.EventHandler(this.menuItemAbout_MAI_Click);

            this.toolStripMain_MAI.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripMain_MAI.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.toolStripButtonOpen_MAI,
                this.toolStripButtonSave_MAI,
                this.toolStripSeparatorOne_MAI,
                this.toolStripButtonAdd_MAI,
                this.toolStripButtonEdit_MAI,
                this.toolStripButtonDelete_MAI,
                this.toolStripSeparatorTwo_MAI,
                this.toolStripButtonReset_MAI,
                this.toolStripSeparatorThree_MAI,
                this.toolStripButtonGuide_MAI,
                this.toolStripButtonAbout_MAI
            });
            this.toolStripMain_MAI.Location = new System.Drawing.Point(0, 24);
            this.toolStripMain_MAI.Name = "toolStripMain_MAI";
            this.toolStripMain_MAI.Padding = new System.Windows.Forms.Padding(6, 2, 6, 2);
            this.toolStripMain_MAI.Size = new System.Drawing.Size(1184, 30);
            this.toolStripMain_MAI.TabIndex = 1;

            this.toolStripButtonOpen_MAI.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonOpen_MAI.Name = "toolStripButtonOpen_MAI";
            this.toolStripButtonOpen_MAI.Text = "📂 Открыть CSV";
            this.toolStripButtonOpen_MAI.ToolTipText = "Загрузить таблицу данных из файла CSV (Ctrl+O)";
            this.toolStripButtonOpen_MAI.Click += new System.EventHandler(this.toolStripButtonOpen_MAI_Click);

            this.toolStripButtonSave_MAI.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonSave_MAI.Name = "toolStripButtonSave_MAI";
            this.toolStripButtonSave_MAI.Text = "💾 Сохранить";
            this.toolStripButtonSave_MAI.ToolTipText = "Сохранить все записи в файл CSV (Ctrl+S)";
            this.toolStripButtonSave_MAI.Click += new System.EventHandler(this.toolStripButtonSave_MAI_Click);

            this.toolStripSeparatorOne_MAI.Name = "toolStripSeparatorOne_MAI";

            this.toolStripButtonAdd_MAI.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonAdd_MAI.Name = "toolStripButtonAdd_MAI";
            this.toolStripButtonAdd_MAI.Text = "➕ Добавить";
            this.toolStripButtonAdd_MAI.ToolTipText = "Добавить новую запись в базу университета (Ctrl+N)";
            this.toolStripButtonAdd_MAI.Click += new System.EventHandler(this.toolStripButtonAdd_MAI_Click);

            this.toolStripButtonEdit_MAI.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonEdit_MAI.Name = "toolStripButtonEdit_MAI";
            this.toolStripButtonEdit_MAI.Text = "✏ Редактировать";
            this.toolStripButtonEdit_MAI.ToolTipText = "Изменить выбранную запись (Ctrl+E)";
            this.toolStripButtonEdit_MAI.Click += new System.EventHandler(this.toolStripButtonEdit_MAI_Click);

            this.toolStripButtonDelete_MAI.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonDelete_MAI.Name = "toolStripButtonDelete_MAI";
            this.toolStripButtonDelete_MAI.Text = "🗑 Удалить";
            this.toolStripButtonDelete_MAI.ToolTipText = "Удалить выбранную запись (Del)";
            this.toolStripButtonDelete_MAI.Click += new System.EventHandler(this.toolStripButtonDelete_MAI_Click);

            this.toolStripSeparatorTwo_MAI.Name = "toolStripSeparatorTwo_MAI";

            this.toolStripButtonReset_MAI.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonReset_MAI.Name = "toolStripButtonReset_MAI";
            this.toolStripButtonReset_MAI.Text = "🔄 Сбросить фильтры";
            this.toolStripButtonReset_MAI.ToolTipText = "Очистить строку поиска и все фильтры";
            this.toolStripButtonReset_MAI.Click += new System.EventHandler(this.toolStripButtonReset_MAI_Click);

            this.toolStripSeparatorThree_MAI.Name = "toolStripSeparatorThree_MAI";

            this.toolStripButtonGuide_MAI.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonGuide_MAI.Name = "toolStripButtonGuide_MAI";
            this.toolStripButtonGuide_MAI.Text = "📘 Руководство";
            this.toolStripButtonGuide_MAI.ToolTipText = "Открыть краткое руководство пользователя (F1)";
            this.toolStripButtonGuide_MAI.Click += new System.EventHandler(this.toolStripButtonGuide_MAI_Click);

            this.toolStripButtonAbout_MAI.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonAbout_MAI.Name = "toolStripButtonAbout_MAI";
            this.toolStripButtonAbout_MAI.Text = "ℹ О программе";
            this.toolStripButtonAbout_MAI.ToolTipText = "Показать сведения о программе и разработчике";
            this.toolStripButtonAbout_MAI.Click += new System.EventHandler(this.toolStripButtonAbout_MAI_Click);

            this.panelFilterBar_MAI.Controls.Add(this.groupBoxControls_MAI);
            this.panelFilterBar_MAI.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilterBar_MAI.Location = new System.Drawing.Point(0, 54);
            this.panelFilterBar_MAI.Name = "panelFilterBar_MAI";
            this.panelFilterBar_MAI.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.panelFilterBar_MAI.Size = new System.Drawing.Size(1184, 86);
            this.panelFilterBar_MAI.TabIndex = 2;

            this.groupBoxControls_MAI.Controls.Add(this.buttonResetFilters_MAI);
            this.groupBoxControls_MAI.Controls.Add(this.checkBoxSortAsc_MAI);
            this.groupBoxControls_MAI.Controls.Add(this.comboBoxSortField_MAI);
            this.groupBoxControls_MAI.Controls.Add(this.labelSortField_MAI);
            this.groupBoxControls_MAI.Controls.Add(this.comboBoxFilterDepartment_MAI);
            this.groupBoxControls_MAI.Controls.Add(this.labelFilterDepartment_MAI);
            this.groupBoxControls_MAI.Controls.Add(this.comboBoxFilterControl_MAI);
            this.groupBoxControls_MAI.Controls.Add(this.labelFilterControl_MAI);
            this.groupBoxControls_MAI.Controls.Add(this.comboBoxFilterPosition_MAI);
            this.groupBoxControls_MAI.Controls.Add(this.labelFilterPosition_MAI);
            this.groupBoxControls_MAI.Controls.Add(this.textBoxSearch_MAI);
            this.groupBoxControls_MAI.Controls.Add(this.labelSearch_MAI);
            this.groupBoxControls_MAI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxControls_MAI.Location = new System.Drawing.Point(8, 4);
            this.groupBoxControls_MAI.Name = "groupBoxControls_MAI";
            this.groupBoxControls_MAI.Size = new System.Drawing.Size(1168, 78);
            this.groupBoxControls_MAI.TabIndex = 0;
            this.groupBoxControls_MAI.TabStop = false;
            this.groupBoxControls_MAI.Text = "Поиск, фильтрация и сортировка";

            this.labelSearch_MAI.AutoSize = true;
            this.labelSearch_MAI.Location = new System.Drawing.Point(12, 22);
            this.labelSearch_MAI.Name = "labelSearch_MAI";
            this.labelSearch_MAI.Text = "Поиск:";

            this.textBoxSearch_MAI.Location = new System.Drawing.Point(12, 40);
            this.textBoxSearch_MAI.Name = "textBoxSearch_MAI";
            this.textBoxSearch_MAI.PlaceholderText = "ФИО, предмет, аудитория...";
            this.textBoxSearch_MAI.Size = new System.Drawing.Size(190, 23);
            this.textBoxSearch_MAI.TabIndex = 1;
            this.toolTipMain_MAI.SetToolTip(this.textBoxSearch_MAI, "Введите текст или число для поиска по всем столбцам");
            this.textBoxSearch_MAI.TextChanged += new System.EventHandler(this.textBoxSearch_MAI_TextChanged);

            this.labelFilterPosition_MAI.AutoSize = true;
            this.labelFilterPosition_MAI.Location = new System.Drawing.Point(214, 22);
            this.labelFilterPosition_MAI.Name = "labelFilterPosition_MAI";
            this.labelFilterPosition_MAI.Text = "Должность:";

            this.comboBoxFilterPosition_MAI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFilterPosition_MAI.Location = new System.Drawing.Point(214, 40);
            this.comboBoxFilterPosition_MAI.Name = "comboBoxFilterPosition_MAI";
            this.comboBoxFilterPosition_MAI.Size = new System.Drawing.Size(155, 23);
            this.comboBoxFilterPosition_MAI.TabIndex = 2;
            this.toolTipMain_MAI.SetToolTip(this.comboBoxFilterPosition_MAI, "Фильтрация по должности преподавателя");
            this.comboBoxFilterPosition_MAI.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilterPosition_MAI_SelectedIndexChanged);

            this.labelFilterControl_MAI.AutoSize = true;
            this.labelFilterControl_MAI.Location = new System.Drawing.Point(381, 22);
            this.labelFilterControl_MAI.Name = "labelFilterControl_MAI";
            this.labelFilterControl_MAI.Text = "Тип контроля:";

            this.comboBoxFilterControl_MAI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFilterControl_MAI.Location = new System.Drawing.Point(381, 40);
            this.comboBoxFilterControl_MAI.Name = "comboBoxFilterControl_MAI";
            this.comboBoxFilterControl_MAI.Size = new System.Drawing.Size(140, 23);
            this.comboBoxFilterControl_MAI.TabIndex = 3;
            this.toolTipMain_MAI.SetToolTip(this.comboBoxFilterControl_MAI, "Фильтрация по типу контроля предмета");
            this.comboBoxFilterControl_MAI.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilterControl_MAI_SelectedIndexChanged);

            this.labelFilterDepartment_MAI.AutoSize = true;
            this.labelFilterDepartment_MAI.Location = new System.Drawing.Point(533, 22);
            this.labelFilterDepartment_MAI.Name = "labelFilterDepartment_MAI";
            this.labelFilterDepartment_MAI.Text = "Кафедра:";

            this.comboBoxFilterDepartment_MAI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFilterDepartment_MAI.Location = new System.Drawing.Point(533, 40);
            this.comboBoxFilterDepartment_MAI.Name = "comboBoxFilterDepartment_MAI";
            this.comboBoxFilterDepartment_MAI.Size = new System.Drawing.Size(185, 23);
            this.comboBoxFilterDepartment_MAI.TabIndex = 4;
            this.toolTipMain_MAI.SetToolTip(this.comboBoxFilterDepartment_MAI, "Фильтрация по названию кафедры");
            this.comboBoxFilterDepartment_MAI.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilterDepartment_MAI_SelectedIndexChanged);

            this.labelSortField_MAI.AutoSize = true;
            this.labelSortField_MAI.Location = new System.Drawing.Point(730, 22);
            this.labelSortField_MAI.Name = "labelSortField_MAI";
            this.labelSortField_MAI.Text = "Сортировка:";

            this.comboBoxSortField_MAI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSortField_MAI.Items.AddRange(new object[] {
                "Номер преподавателя",
                "ФИО преподавателя",
                "Должность",
                "Название предмета",
                "Количество часов",
                "Кафедра",
                "Аудитория"
            });
            this.comboBoxSortField_MAI.Location = new System.Drawing.Point(730, 40);
            this.comboBoxSortField_MAI.Name = "comboBoxSortField_MAI";
            this.comboBoxSortField_MAI.Size = new System.Drawing.Size(165, 23);
            this.comboBoxSortField_MAI.TabIndex = 5;
            this.toolTipMain_MAI.SetToolTip(this.comboBoxSortField_MAI, "Выберите столбец для сортировки записей");
            this.comboBoxSortField_MAI.SelectedIndexChanged += new System.EventHandler(this.comboBoxSortField_MAI_SelectedIndexChanged);

            this.checkBoxSortAsc_MAI.AutoSize = true;
            this.checkBoxSortAsc_MAI.Checked = true;
            this.checkBoxSortAsc_MAI.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSortAsc_MAI.Location = new System.Drawing.Point(905, 42);
            this.checkBoxSortAsc_MAI.Name = "checkBoxSortAsc_MAI";
            this.checkBoxSortAsc_MAI.Size = new System.Drawing.Size(115, 19);
            this.checkBoxSortAsc_MAI.TabIndex = 6;
            this.checkBoxSortAsc_MAI.Text = "По возрастанию";
            this.toolTipMain_MAI.SetToolTip(this.checkBoxSortAsc_MAI, "Переключить направление сортировки (по возрастанию / убыванию)");
            this.checkBoxSortAsc_MAI.CheckedChanged += new System.EventHandler(this.checkBoxSortAsc_MAI_CheckedChanged);

            this.buttonResetFilters_MAI.Location = new System.Drawing.Point(1035, 36);
            this.buttonResetFilters_MAI.Name = "buttonResetFilters_MAI";
            this.buttonResetFilters_MAI.Size = new System.Drawing.Size(92, 29);
            this.buttonResetFilters_MAI.TabIndex = 7;
            this.buttonResetFilters_MAI.Text = "Сбросить";
            this.toolTipMain_MAI.SetToolTip(this.buttonResetFilters_MAI, "Сбросить все параметры поиска и фильтрации");
            this.buttonResetFilters_MAI.UseVisualStyleBackColor = true;
            this.buttonResetFilters_MAI.Click += new System.EventHandler(this.buttonResetFilters_MAI_Click);

            this.splitContainerMain_MAI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain_MAI.Location = new System.Drawing.Point(0, 140);
            this.splitContainerMain_MAI.Name = "splitContainerMain_MAI";
            this.splitContainerMain_MAI.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.splitContainerMain_MAI.Panel1.Controls.Add(this.groupBoxDataGrid_MAI);
            this.splitContainerMain_MAI.Panel1.Padding = new System.Windows.Forms.Padding(8, 2, 8, 2);
            this.splitContainerMain_MAI.Panel2.Controls.Add(this.splitContainerAnalytics_MAI);
            this.splitContainerMain_MAI.Panel2.Padding = new System.Windows.Forms.Padding(8, 2, 8, 4);
            this.splitContainerMain_MAI.Size = new System.Drawing.Size(1184, 579);
            this.splitContainerMain_MAI.SplitterDistance = 300;
            this.splitContainerMain_MAI.TabIndex = 3;

            this.groupBoxDataGrid_MAI.Controls.Add(this.dataGridViewUniversity_MAI);
            this.groupBoxDataGrid_MAI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDataGrid_MAI.Name = "groupBoxDataGrid_MAI";
            this.groupBoxDataGrid_MAI.TabIndex = 0;
            this.groupBoxDataGrid_MAI.TabStop = false;
            this.groupBoxDataGrid_MAI.Text = "Таблица данных университета (двойной щелчок — редактирование)";

            gridAlternatingStyle_MAI.BackColor = System.Drawing.Color.FromArgb(242, 246, 252);
            this.dataGridViewUniversity_MAI.AlternatingRowsDefaultCellStyle = gridAlternatingStyle_MAI;
            this.dataGridViewUniversity_MAI.AllowUserToAddRows = false;
            this.dataGridViewUniversity_MAI.AllowUserToDeleteRows = false;
            this.dataGridViewUniversity_MAI.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewUniversity_MAI.BackgroundColor = System.Drawing.Color.White;
            gridHeaderStyle_MAI.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dataGridViewUniversity_MAI.ColumnHeadersDefaultCellStyle = gridHeaderStyle_MAI;
            this.dataGridViewUniversity_MAI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUniversity_MAI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewUniversity_MAI.MultiSelect = false;
            this.dataGridViewUniversity_MAI.Name = "dataGridViewUniversity_MAI";
            this.dataGridViewUniversity_MAI.ReadOnly = true;
            this.dataGridViewUniversity_MAI.RowHeadersVisible = false;
            this.dataGridViewUniversity_MAI.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUniversity_MAI.TabIndex = 0;
            this.dataGridViewUniversity_MAI.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUniversity_MAI_CellDoubleClick);

            this.splitContainerAnalytics_MAI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerAnalytics_MAI.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerAnalytics_MAI.Name = "splitContainerAnalytics_MAI";
            this.splitContainerAnalytics_MAI.Panel1.Controls.Add(this.groupBoxStatistics_MAI);
            this.splitContainerAnalytics_MAI.Panel2.Controls.Add(this.groupBoxChart_MAI);
            this.splitContainerAnalytics_MAI.Size = new System.Drawing.Size(1168, 269);
            this.splitContainerAnalytics_MAI.SplitterDistance = 275;
            this.splitContainerAnalytics_MAI.TabIndex = 0;

            this.groupBoxStatistics_MAI.Controls.Add(this.textBoxStatMax_MAI);
            this.groupBoxStatistics_MAI.Controls.Add(this.labelStatMax_MAI);
            this.groupBoxStatistics_MAI.Controls.Add(this.textBoxStatMin_MAI);
            this.groupBoxStatistics_MAI.Controls.Add(this.labelStatMin_MAI);
            this.groupBoxStatistics_MAI.Controls.Add(this.textBoxStatAvg_MAI);
            this.groupBoxStatistics_MAI.Controls.Add(this.labelStatAvg_MAI);
            this.groupBoxStatistics_MAI.Controls.Add(this.textBoxStatSum_MAI);
            this.groupBoxStatistics_MAI.Controls.Add(this.labelStatSum_MAI);
            this.groupBoxStatistics_MAI.Controls.Add(this.textBoxStatCount_MAI);
            this.groupBoxStatistics_MAI.Controls.Add(this.labelStatCount_MAI);
            this.groupBoxStatistics_MAI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxStatistics_MAI.Name = "groupBoxStatistics_MAI";
            this.groupBoxStatistics_MAI.TabIndex = 0;
            this.groupBoxStatistics_MAI.TabStop = false;
            this.groupBoxStatistics_MAI.Text = "Статистика по часам";

            this.labelStatCount_MAI.AutoSize = true;
            this.labelStatCount_MAI.Location = new System.Drawing.Point(14, 30);
            this.labelStatCount_MAI.Name = "labelStatCount_MAI";
            this.labelStatCount_MAI.Text = "Количество записей:";

            this.textBoxStatCount_MAI.Location = new System.Drawing.Point(155, 27);
            this.textBoxStatCount_MAI.Name = "textBoxStatCount_MAI";
            this.textBoxStatCount_MAI.ReadOnly = true;
            this.textBoxStatCount_MAI.Size = new System.Drawing.Size(100, 23);
            this.textBoxStatCount_MAI.TabIndex = 0;
            this.textBoxStatCount_MAI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

            this.labelStatSum_MAI.AutoSize = true;
            this.labelStatSum_MAI.Location = new System.Drawing.Point(14, 68);
            this.labelStatSum_MAI.Name = "labelStatSum_MAI";
            this.labelStatSum_MAI.Text = "Сумма часов:";

            this.textBoxStatSum_MAI.Location = new System.Drawing.Point(155, 65);
            this.textBoxStatSum_MAI.Name = "textBoxStatSum_MAI";
            this.textBoxStatSum_MAI.ReadOnly = true;
            this.textBoxStatSum_MAI.Size = new System.Drawing.Size(100, 23);
            this.textBoxStatSum_MAI.TabIndex = 1;
            this.textBoxStatSum_MAI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

            this.labelStatAvg_MAI.AutoSize = true;
            this.labelStatAvg_MAI.Location = new System.Drawing.Point(14, 106);
            this.labelStatAvg_MAI.Name = "labelStatAvg_MAI";
            this.labelStatAvg_MAI.Text = "Среднее часов:";

            this.textBoxStatAvg_MAI.Location = new System.Drawing.Point(155, 103);
            this.textBoxStatAvg_MAI.Name = "textBoxStatAvg_MAI";
            this.textBoxStatAvg_MAI.ReadOnly = true;
            this.textBoxStatAvg_MAI.Size = new System.Drawing.Size(100, 23);
            this.textBoxStatAvg_MAI.TabIndex = 2;
            this.textBoxStatAvg_MAI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

            this.labelStatMin_MAI.AutoSize = true;
            this.labelStatMin_MAI.Location = new System.Drawing.Point(14, 144);
            this.labelStatMin_MAI.Name = "labelStatMin_MAI";
            this.labelStatMin_MAI.Text = "Минимум часов:";

            this.textBoxStatMin_MAI.Location = new System.Drawing.Point(155, 141);
            this.textBoxStatMin_MAI.Name = "textBoxStatMin_MAI";
            this.textBoxStatMin_MAI.ReadOnly = true;
            this.textBoxStatMin_MAI.Size = new System.Drawing.Size(100, 23);
            this.textBoxStatMin_MAI.TabIndex = 3;
            this.textBoxStatMin_MAI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

            this.labelStatMax_MAI.AutoSize = true;
            this.labelStatMax_MAI.Location = new System.Drawing.Point(14, 182);
            this.labelStatMax_MAI.Name = "labelStatMax_MAI";
            this.labelStatMax_MAI.Text = "Максимум часов:";

            this.textBoxStatMax_MAI.Location = new System.Drawing.Point(155, 179);
            this.textBoxStatMax_MAI.Name = "textBoxStatMax_MAI";
            this.textBoxStatMax_MAI.ReadOnly = true;
            this.textBoxStatMax_MAI.Size = new System.Drawing.Size(100, 23);
            this.textBoxStatMax_MAI.TabIndex = 4;
            this.textBoxStatMax_MAI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

            this.groupBoxChart_MAI.Controls.Add(this.chartAnalytics_MAI);
            this.groupBoxChart_MAI.Controls.Add(this.panelChartHeader_MAI);
            this.groupBoxChart_MAI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxChart_MAI.Name = "groupBoxChart_MAI";
            this.groupBoxChart_MAI.TabIndex = 0;
            this.groupBoxChart_MAI.TabStop = false;
            this.groupBoxChart_MAI.Text = "Визуализация данных";

            this.panelChartHeader_MAI.Controls.Add(this.comboBoxChartMode_MAI);
            this.panelChartHeader_MAI.Controls.Add(this.labelChartMode_MAI);
            this.panelChartHeader_MAI.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelChartHeader_MAI.Name = "panelChartHeader_MAI";
            this.panelChartHeader_MAI.Size = new System.Drawing.Size(883, 34);
            this.panelChartHeader_MAI.TabIndex = 0;

            this.labelChartMode_MAI.AutoSize = true;
            this.labelChartMode_MAI.Location = new System.Drawing.Point(10, 9);
            this.labelChartMode_MAI.Name = "labelChartMode_MAI";
            this.labelChartMode_MAI.Text = "Режим диаграммы:";

            this.comboBoxChartMode_MAI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChartMode_MAI.Items.AddRange(new object[] {
                "Часы по кафедрам (гистограмма)",
                "Часы по должностям (гистограмма)",
                "Предметы по типу контроля (круговая)"
            });
            this.comboBoxChartMode_MAI.Location = new System.Drawing.Point(130, 5);
            this.comboBoxChartMode_MAI.Name = "comboBoxChartMode_MAI";
            this.comboBoxChartMode_MAI.Size = new System.Drawing.Size(270, 23);
            this.comboBoxChartMode_MAI.TabIndex = 1;
            this.toolTipMain_MAI.SetToolTip(this.comboBoxChartMode_MAI, "Выберите тип отображаемой диаграммы");
            this.comboBoxChartMode_MAI.SelectedIndexChanged += new System.EventHandler(this.comboBoxChartMode_MAI_SelectedIndexChanged);

            chartAreaAnalytics_MAI.Name = "ChartAreaAnalytics_MAI";
            this.chartAnalytics_MAI.ChartAreas.Add(chartAreaAnalytics_MAI);
            legendAnalytics_MAI.Name = "LegendAnalytics_MAI";
            this.chartAnalytics_MAI.Legends.Add(legendAnalytics_MAI);
            this.chartAnalytics_MAI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartAnalytics_MAI.Name = "chartAnalytics_MAI";
            this.chartAnalytics_MAI.TabIndex = 1;

            this.statusStripMain_MAI.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.toolStripStatusLabelFile_MAI,
                this.toolStripStatusLabelCount_MAI
            });
            this.statusStripMain_MAI.Location = new System.Drawing.Point(0, 719);
            this.statusStripMain_MAI.Name = "statusStripMain_MAI";
            this.statusStripMain_MAI.Size = new System.Drawing.Size(1184, 22);
            this.statusStripMain_MAI.TabIndex = 4;

            this.toolStripStatusLabelFile_MAI.Name = "toolStripStatusLabelFile_MAI";
            this.toolStripStatusLabelFile_MAI.Spring = true;
            this.toolStripStatusLabelFile_MAI.Text = "Файл: не выбран";
            this.toolStripStatusLabelFile_MAI.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.toolStripStatusLabelCount_MAI.Name = "toolStripStatusLabelCount_MAI";
            this.toolStripStatusLabelCount_MAI.Text = "Записей: 0";

            this.openFileDialogCsv_MAI.Filter = "CSV файлы (*.csv)|*.csv|Все файлы (*.*)|*.*";
            this.openFileDialogCsv_MAI.Title = "Открыть файл данных университета (CSV)";

            this.saveFileDialogCsv_MAI.DefaultExt = "csv";
            this.saveFileDialogCsv_MAI.Filter = "CSV файлы (*.csv)|*.csv|Все файлы (*.*)|*.*";
            this.saveFileDialogCsv_MAI.Title = "Сохранить данные университета (CSV)";

            this.toolTipMain_MAI.IsBalloon = true;
            this.toolTipMain_MAI.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipMain_MAI.ToolTipTitle = "Подсказка";

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 741);
            this.Controls.Add(this.splitContainerMain_MAI);
            this.Controls.Add(this.panelFilterBar_MAI);
            this.Controls.Add(this.toolStripMain_MAI);
            this.Controls.Add(this.menuStripMain_MAI);
            this.Controls.Add(this.statusStripMain_MAI);
            this.MainMenuStrip = this.menuStripMain_MAI;
            this.MinimumSize = new System.Drawing.Size(1080, 660);
            this.Name = "FormMain_MAI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Университет — Учёт учебной нагрузки | Спринт 7 | Вариант 3 | Михайличенко А. И.";
            this.Load += new System.EventHandler(this.FormMain_MAI_Load);

            this.menuStripMain_MAI.ResumeLayout(false);
            this.menuStripMain_MAI.PerformLayout();
            this.toolStripMain_MAI.ResumeLayout(false);
            this.toolStripMain_MAI.PerformLayout();
            this.panelFilterBar_MAI.ResumeLayout(false);
            this.groupBoxControls_MAI.ResumeLayout(false);
            this.groupBoxControls_MAI.PerformLayout();
            this.splitContainerMain_MAI.Panel1.ResumeLayout(false);
            this.splitContainerMain_MAI.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain_MAI)).EndInit();
            this.splitContainerMain_MAI.ResumeLayout(false);
            this.groupBoxDataGrid_MAI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUniversity_MAI)).EndInit();
            this.splitContainerAnalytics_MAI.Panel1.ResumeLayout(false);
            this.splitContainerAnalytics_MAI.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAnalytics_MAI)).EndInit();
            this.splitContainerAnalytics_MAI.ResumeLayout(false);
            this.groupBoxStatistics_MAI.ResumeLayout(false);
            this.groupBoxStatistics_MAI.PerformLayout();
            this.groupBoxChart_MAI.ResumeLayout(false);
            this.panelChartHeader_MAI.ResumeLayout(false);
            this.panelChartHeader_MAI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartAnalytics_MAI)).EndInit();
            this.statusStripMain_MAI.ResumeLayout(false);
            this.statusStripMain_MAI.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.MenuStrip menuStripMain_MAI;
        private System.Windows.Forms.ToolStripMenuItem menuItemFile_MAI;
        private System.Windows.Forms.ToolStripMenuItem menuItemOpenCsv_MAI;
        private System.Windows.Forms.ToolStripMenuItem menuItemSaveCsv_MAI;
        private System.Windows.Forms.ToolStripMenuItem menuItemSaveAsCsv_MAI;
        private System.Windows.Forms.ToolStripSeparator menuSeparatorFile_MAI;
        private System.Windows.Forms.ToolStripMenuItem menuItemExit_MAI;
        private System.Windows.Forms.ToolStripMenuItem menuItemRecords_MAI;
        private System.Windows.Forms.ToolStripMenuItem menuItemAddRecord_MAI;
        private System.Windows.Forms.ToolStripMenuItem menuItemEditRecord_MAI;
        private System.Windows.Forms.ToolStripMenuItem menuItemDeleteRecord_MAI;
        private System.Windows.Forms.ToolStripMenuItem menuItemAnalytics_MAI;
        private System.Windows.Forms.ToolStripMenuItem menuItemRefreshChart_MAI;
        private System.Windows.Forms.ToolStripMenuItem menuItemResetFilters_MAI;
        private System.Windows.Forms.ToolStripMenuItem menuItemHelp_MAI;
        private System.Windows.Forms.ToolStripMenuItem menuItemGuide_MAI;
        private System.Windows.Forms.ToolStripMenuItem menuItemAbout_MAI;

        private System.Windows.Forms.ToolStrip toolStripMain_MAI;
        private System.Windows.Forms.ToolStripButton toolStripButtonOpen_MAI;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave_MAI;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorOne_MAI;
        private System.Windows.Forms.ToolStripButton toolStripButtonAdd_MAI;
        private System.Windows.Forms.ToolStripButton toolStripButtonEdit_MAI;
        private System.Windows.Forms.ToolStripButton toolStripButtonDelete_MAI;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorTwo_MAI;
        private System.Windows.Forms.ToolStripButton toolStripButtonReset_MAI;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorThree_MAI;
        private System.Windows.Forms.ToolStripButton toolStripButtonGuide_MAI;
        private System.Windows.Forms.ToolStripButton toolStripButtonAbout_MAI;

        private System.Windows.Forms.Panel panelFilterBar_MAI;
        private System.Windows.Forms.GroupBox groupBoxControls_MAI;
        private System.Windows.Forms.Label labelSearch_MAI;
        private System.Windows.Forms.TextBox textBoxSearch_MAI;
        private System.Windows.Forms.Label labelFilterPosition_MAI;
        private System.Windows.Forms.ComboBox comboBoxFilterPosition_MAI;
        private System.Windows.Forms.Label labelFilterControl_MAI;
        private System.Windows.Forms.ComboBox comboBoxFilterControl_MAI;
        private System.Windows.Forms.Label labelFilterDepartment_MAI;
        private System.Windows.Forms.ComboBox comboBoxFilterDepartment_MAI;
        private System.Windows.Forms.Label labelSortField_MAI;
        private System.Windows.Forms.ComboBox comboBoxSortField_MAI;
        private System.Windows.Forms.CheckBox checkBoxSortAsc_MAI;
        private System.Windows.Forms.Button buttonResetFilters_MAI;

        private System.Windows.Forms.SplitContainer splitContainerMain_MAI;
        private System.Windows.Forms.GroupBox groupBoxDataGrid_MAI;
        private System.Windows.Forms.DataGridView dataGridViewUniversity_MAI;
        private System.Windows.Forms.SplitContainer splitContainerAnalytics_MAI;
        private System.Windows.Forms.GroupBox groupBoxStatistics_MAI;
        private System.Windows.Forms.Label labelStatCount_MAI;
        private System.Windows.Forms.TextBox textBoxStatCount_MAI;
        private System.Windows.Forms.Label labelStatSum_MAI;
        private System.Windows.Forms.TextBox textBoxStatSum_MAI;
        private System.Windows.Forms.Label labelStatAvg_MAI;
        private System.Windows.Forms.TextBox textBoxStatAvg_MAI;
        private System.Windows.Forms.Label labelStatMin_MAI;
        private System.Windows.Forms.TextBox textBoxStatMin_MAI;
        private System.Windows.Forms.Label labelStatMax_MAI;
        private System.Windows.Forms.TextBox textBoxStatMax_MAI;
        private System.Windows.Forms.GroupBox groupBoxChart_MAI;
        private System.Windows.Forms.Panel panelChartHeader_MAI;
        private System.Windows.Forms.Label labelChartMode_MAI;
        private System.Windows.Forms.ComboBox comboBoxChartMode_MAI;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAnalytics_MAI;

        private System.Windows.Forms.StatusStrip statusStripMain_MAI;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelFile_MAI;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelCount_MAI;

        private System.Windows.Forms.OpenFileDialog openFileDialogCsv_MAI;
        private System.Windows.Forms.SaveFileDialog saveFileDialogCsv_MAI;
        private System.Windows.Forms.ToolTip toolTipMain_MAI;
    }
}
