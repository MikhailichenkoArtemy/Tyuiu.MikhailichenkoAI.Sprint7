namespace Tyuiu.MikhailichenkoAI.Sprint7.Project.V3
{
    partial class FormEditRecord_MAI
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
            this.groupBoxTeacherInfo_MAI = new System.Windows.Forms.GroupBox();
            this.labelTeacherId_MAI = new System.Windows.Forms.Label();
            this.textBoxTeacherId_MAI = new System.Windows.Forms.TextBox();
            this.labelTeacherFullName_MAI = new System.Windows.Forms.Label();
            this.textBoxTeacherFullName_MAI = new System.Windows.Forms.TextBox();
            this.labelTeacherAddress_MAI = new System.Windows.Forms.Label();
            this.textBoxTeacherAddress_MAI = new System.Windows.Forms.TextBox();
            this.labelTeacherPosition_MAI = new System.Windows.Forms.Label();
            this.comboBoxTeacherPosition_MAI = new System.Windows.Forms.ComboBox();
            this.groupBoxSubjectInfo_MAI = new System.Windows.Forms.GroupBox();
            this.labelSubjectCode_MAI = new System.Windows.Forms.Label();
            this.textBoxSubjectCode_MAI = new System.Windows.Forms.TextBox();
            this.labelSubjectName_MAI = new System.Windows.Forms.Label();
            this.textBoxSubjectName_MAI = new System.Windows.Forms.TextBox();
            this.labelSubjectHours_MAI = new System.Windows.Forms.Label();
            this.textBoxSubjectHours_MAI = new System.Windows.Forms.TextBox();
            this.labelControlType_MAI = new System.Windows.Forms.Label();
            this.comboBoxControlType_MAI = new System.Windows.Forms.ComboBox();
            this.labelSubjectSection_MAI = new System.Windows.Forms.Label();
            this.textBoxSubjectSection_MAI = new System.Windows.Forms.TextBox();
            this.groupBoxDepartmentInfo_MAI = new System.Windows.Forms.GroupBox();
            this.labelDepartmentCode_MAI = new System.Windows.Forms.Label();
            this.textBoxDepartmentCode_MAI = new System.Windows.Forms.TextBox();
            this.labelDepartmentName_MAI = new System.Windows.Forms.Label();
            this.textBoxDepartmentName_MAI = new System.Windows.Forms.TextBox();
            this.labelHeadTeacherId_MAI = new System.Windows.Forms.Label();
            this.textBoxHeadTeacherId_MAI = new System.Windows.Forms.TextBox();
            this.labelClassroom_MAI = new System.Windows.Forms.Label();
            this.textBoxClassroom_MAI = new System.Windows.Forms.TextBox();
            this.buttonSaveRecord_MAI = new System.Windows.Forms.Button();
            this.buttonCancelRecord_MAI = new System.Windows.Forms.Button();
            this.toolTipEdit_MAI = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxTeacherInfo_MAI.SuspendLayout();
            this.groupBoxSubjectInfo_MAI.SuspendLayout();
            this.groupBoxDepartmentInfo_MAI.SuspendLayout();
            this.SuspendLayout();

            this.groupBoxTeacherInfo_MAI.Controls.Add(this.comboBoxTeacherPosition_MAI);
            this.groupBoxTeacherInfo_MAI.Controls.Add(this.labelTeacherPosition_MAI);
            this.groupBoxTeacherInfo_MAI.Controls.Add(this.textBoxTeacherAddress_MAI);
            this.groupBoxTeacherInfo_MAI.Controls.Add(this.labelTeacherAddress_MAI);
            this.groupBoxTeacherInfo_MAI.Controls.Add(this.textBoxTeacherFullName_MAI);
            this.groupBoxTeacherInfo_MAI.Controls.Add(this.labelTeacherFullName_MAI);
            this.groupBoxTeacherInfo_MAI.Controls.Add(this.textBoxTeacherId_MAI);
            this.groupBoxTeacherInfo_MAI.Controls.Add(this.labelTeacherId_MAI);
            this.groupBoxTeacherInfo_MAI.Location = new System.Drawing.Point(14, 12);
            this.groupBoxTeacherInfo_MAI.Name = "groupBoxTeacherInfo_MAI";
            this.groupBoxTeacherInfo_MAI.Size = new System.Drawing.Size(520, 145);
            this.groupBoxTeacherInfo_MAI.TabIndex = 0;
            this.groupBoxTeacherInfo_MAI.TabStop = false;
            this.groupBoxTeacherInfo_MAI.Text = "Преподаватель";

            this.labelTeacherId_MAI.AutoSize = true;
            this.labelTeacherId_MAI.Location = new System.Drawing.Point(14, 26);
            this.labelTeacherId_MAI.Name = "labelTeacherId_MAI";
            this.labelTeacherId_MAI.Size = new System.Drawing.Size(48, 15);
            this.labelTeacherId_MAI.TabIndex = 0;
            this.labelTeacherId_MAI.Text = "Номер:";

            this.textBoxTeacherId_MAI.Location = new System.Drawing.Point(120, 23);
            this.textBoxTeacherId_MAI.Name = "textBoxTeacherId_MAI";
            this.textBoxTeacherId_MAI.Size = new System.Drawing.Size(120, 23);
            this.textBoxTeacherId_MAI.TabIndex = 1;
            this.toolTipEdit_MAI.SetToolTip(this.textBoxTeacherId_MAI, "Табельный номер преподавателя (целое число)");
            this.textBoxTeacherId_MAI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumericOnly_MAI_KeyPress);

            this.labelTeacherPosition_MAI.AutoSize = true;
            this.labelTeacherPosition_MAI.Location = new System.Drawing.Point(255, 26);
            this.labelTeacherPosition_MAI.Name = "labelTeacherPosition_MAI";
            this.labelTeacherPosition_MAI.Size = new System.Drawing.Size(70, 15);
            this.labelTeacherPosition_MAI.TabIndex = 2;
            this.labelTeacherPosition_MAI.Text = "Должность:";

            this.comboBoxTeacherPosition_MAI.Items.AddRange(new object[] {
                "Профессор",
                "Доцент",
                "Старший преподаватель",
                "Ассистент"
            });
            this.comboBoxTeacherPosition_MAI.Location = new System.Drawing.Point(335, 23);
            this.comboBoxTeacherPosition_MAI.Name = "comboBoxTeacherPosition_MAI";
            this.comboBoxTeacherPosition_MAI.Size = new System.Drawing.Size(170, 23);
            this.comboBoxTeacherPosition_MAI.TabIndex = 3;

            this.labelTeacherFullName_MAI.AutoSize = true;
            this.labelTeacherFullName_MAI.Location = new System.Drawing.Point(14, 62);
            this.labelTeacherFullName_MAI.Name = "labelTeacherFullName_MAI";
            this.labelTeacherFullName_MAI.Size = new System.Drawing.Size(37, 15);
            this.labelTeacherFullName_MAI.TabIndex = 4;
            this.labelTeacherFullName_MAI.Text = "ФИО:";

            this.textBoxTeacherFullName_MAI.Location = new System.Drawing.Point(120, 59);
            this.textBoxTeacherFullName_MAI.Name = "textBoxTeacherFullName_MAI";
            this.textBoxTeacherFullName_MAI.Size = new System.Drawing.Size(385, 23);
            this.textBoxTeacherFullName_MAI.TabIndex = 5;

            this.labelTeacherAddress_MAI.AutoSize = true;
            this.labelTeacherAddress_MAI.Location = new System.Drawing.Point(14, 98);
            this.labelTeacherAddress_MAI.Name = "labelTeacherAddress_MAI";
            this.labelTeacherAddress_MAI.Size = new System.Drawing.Size(44, 15);
            this.labelTeacherAddress_MAI.TabIndex = 6;
            this.labelTeacherAddress_MAI.Text = "Адрес:";

            this.textBoxTeacherAddress_MAI.Location = new System.Drawing.Point(120, 95);
            this.textBoxTeacherAddress_MAI.Name = "textBoxTeacherAddress_MAI";
            this.textBoxTeacherAddress_MAI.Size = new System.Drawing.Size(385, 23);
            this.textBoxTeacherAddress_MAI.TabIndex = 7;

            this.groupBoxSubjectInfo_MAI.Controls.Add(this.textBoxSubjectSection_MAI);
            this.groupBoxSubjectInfo_MAI.Controls.Add(this.labelSubjectSection_MAI);
            this.groupBoxSubjectInfo_MAI.Controls.Add(this.comboBoxControlType_MAI);
            this.groupBoxSubjectInfo_MAI.Controls.Add(this.labelControlType_MAI);
            this.groupBoxSubjectInfo_MAI.Controls.Add(this.textBoxSubjectHours_MAI);
            this.groupBoxSubjectInfo_MAI.Controls.Add(this.labelSubjectHours_MAI);
            this.groupBoxSubjectInfo_MAI.Controls.Add(this.textBoxSubjectName_MAI);
            this.groupBoxSubjectInfo_MAI.Controls.Add(this.labelSubjectName_MAI);
            this.groupBoxSubjectInfo_MAI.Controls.Add(this.textBoxSubjectCode_MAI);
            this.groupBoxSubjectInfo_MAI.Controls.Add(this.labelSubjectCode_MAI);
            this.groupBoxSubjectInfo_MAI.Location = new System.Drawing.Point(14, 165);
            this.groupBoxSubjectInfo_MAI.Name = "groupBoxSubjectInfo_MAI";
            this.groupBoxSubjectInfo_MAI.Size = new System.Drawing.Size(520, 175);
            this.groupBoxSubjectInfo_MAI.TabIndex = 1;
            this.groupBoxSubjectInfo_MAI.TabStop = false;
            this.groupBoxSubjectInfo_MAI.Text = "Дисциплина (Предмет)";

            this.labelSubjectCode_MAI.AutoSize = true;
            this.labelSubjectCode_MAI.Location = new System.Drawing.Point(14, 26);
            this.labelSubjectCode_MAI.Name = "labelSubjectCode_MAI";
            this.labelSubjectCode_MAI.Size = new System.Drawing.Size(86, 15);
            this.labelSubjectCode_MAI.TabIndex = 0;
            this.labelSubjectCode_MAI.Text = "Код предмета:";

            this.textBoxSubjectCode_MAI.Location = new System.Drawing.Point(120, 23);
            this.textBoxSubjectCode_MAI.Name = "textBoxSubjectCode_MAI";
            this.textBoxSubjectCode_MAI.Size = new System.Drawing.Size(120, 23);
            this.textBoxSubjectCode_MAI.TabIndex = 1;

            this.labelSubjectHours_MAI.AutoSize = true;
            this.labelSubjectHours_MAI.Location = new System.Drawing.Point(255, 26);
            this.labelSubjectHours_MAI.Name = "labelSubjectHours_MAI";
            this.labelSubjectHours_MAI.Size = new System.Drawing.Size(42, 15);
            this.labelSubjectHours_MAI.TabIndex = 2;
            this.labelSubjectHours_MAI.Text = "Часы:";

            this.textBoxSubjectHours_MAI.Location = new System.Drawing.Point(335, 23);
            this.textBoxSubjectHours_MAI.Name = "textBoxSubjectHours_MAI";
            this.textBoxSubjectHours_MAI.Size = new System.Drawing.Size(170, 23);
            this.textBoxSubjectHours_MAI.TabIndex = 3;
            this.textBoxSubjectHours_MAI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumericOnly_MAI_KeyPress);

            this.labelSubjectName_MAI.AutoSize = true;
            this.labelSubjectName_MAI.Location = new System.Drawing.Point(14, 62);
            this.labelSubjectName_MAI.Name = "labelSubjectName_MAI";
            this.labelSubjectName_MAI.Size = new System.Drawing.Size(63, 15);
            this.labelSubjectName_MAI.TabIndex = 4;
            this.labelSubjectName_MAI.Text = "Название:";

            this.textBoxSubjectName_MAI.Location = new System.Drawing.Point(120, 59);
            this.textBoxSubjectName_MAI.Name = "textBoxSubjectName_MAI";
            this.textBoxSubjectName_MAI.Size = new System.Drawing.Size(385, 23);
            this.textBoxSubjectName_MAI.TabIndex = 5;

            this.labelControlType_MAI.AutoSize = true;
            this.labelControlType_MAI.Location = new System.Drawing.Point(14, 98);
            this.labelControlType_MAI.Name = "labelControlType_MAI";
            this.labelControlType_MAI.Size = new System.Drawing.Size(87, 15);
            this.labelControlType_MAI.TabIndex = 6;
            this.labelControlType_MAI.Text = "Тип контроля:";

            this.comboBoxControlType_MAI.Items.AddRange(new object[] {
                "Экзамен",
                "Зачёт",
                "Диф. зачёт",
                "Курсовая работа"
            });
            this.comboBoxControlType_MAI.Location = new System.Drawing.Point(120, 95);
            this.comboBoxControlType_MAI.Name = "comboBoxControlType_MAI";
            this.comboBoxControlType_MAI.Size = new System.Drawing.Size(180, 23);
            this.comboBoxControlType_MAI.TabIndex = 7;

            this.labelSubjectSection_MAI.AutoSize = true;
            this.labelSubjectSection_MAI.Location = new System.Drawing.Point(14, 134);
            this.labelSubjectSection_MAI.Name = "labelSubjectSection_MAI";
            this.labelSubjectSection_MAI.Size = new System.Drawing.Size(48, 15);
            this.labelSubjectSection_MAI.TabIndex = 8;
            this.labelSubjectSection_MAI.Text = "Раздел:";

            this.textBoxSubjectSection_MAI.Location = new System.Drawing.Point(120, 131);
            this.textBoxSubjectSection_MAI.Name = "textBoxSubjectSection_MAI";
            this.textBoxSubjectSection_MAI.Size = new System.Drawing.Size(385, 23);
            this.textBoxSubjectSection_MAI.TabIndex = 9;

            this.groupBoxDepartmentInfo_MAI.Controls.Add(this.textBoxClassroom_MAI);
            this.groupBoxDepartmentInfo_MAI.Controls.Add(this.labelClassroom_MAI);
            this.groupBoxDepartmentInfo_MAI.Controls.Add(this.textBoxHeadTeacherId_MAI);
            this.groupBoxDepartmentInfo_MAI.Controls.Add(this.labelHeadTeacherId_MAI);
            this.groupBoxDepartmentInfo_MAI.Controls.Add(this.textBoxDepartmentName_MAI);
            this.groupBoxDepartmentInfo_MAI.Controls.Add(this.labelDepartmentName_MAI);
            this.groupBoxDepartmentInfo_MAI.Controls.Add(this.textBoxDepartmentCode_MAI);
            this.groupBoxDepartmentInfo_MAI.Controls.Add(this.labelDepartmentCode_MAI);
            this.groupBoxDepartmentInfo_MAI.Location = new System.Drawing.Point(14, 348);
            this.groupBoxDepartmentInfo_MAI.Name = "groupBoxDepartmentInfo_MAI";
            this.groupBoxDepartmentInfo_MAI.Size = new System.Drawing.Size(520, 140);
            this.groupBoxDepartmentInfo_MAI.TabIndex = 2;
            this.groupBoxDepartmentInfo_MAI.TabStop = false;
            this.groupBoxDepartmentInfo_MAI.Text = "Кафедра и аудитория";

            this.labelDepartmentCode_MAI.AutoSize = true;
            this.labelDepartmentCode_MAI.Location = new System.Drawing.Point(14, 26);
            this.labelDepartmentCode_MAI.Name = "labelDepartmentCode_MAI";
            this.labelDepartmentCode_MAI.Size = new System.Drawing.Size(83, 15);
            this.labelDepartmentCode_MAI.TabIndex = 0;
            this.labelDepartmentCode_MAI.Text = "Код кафедры:";

            this.textBoxDepartmentCode_MAI.Location = new System.Drawing.Point(120, 23);
            this.textBoxDepartmentCode_MAI.Name = "textBoxDepartmentCode_MAI";
            this.textBoxDepartmentCode_MAI.Size = new System.Drawing.Size(120, 23);
            this.textBoxDepartmentCode_MAI.TabIndex = 1;

            this.labelHeadTeacherId_MAI.AutoSize = true;
            this.labelHeadTeacherId_MAI.Location = new System.Drawing.Point(255, 26);
            this.labelHeadTeacherId_MAI.Name = "labelHeadTeacherId_MAI";
            this.labelHeadTeacherId_MAI.Size = new System.Drawing.Size(118, 15);
            this.labelHeadTeacherId_MAI.TabIndex = 2;
            this.labelHeadTeacherId_MAI.Text = "№ зав. кафедрой:";

            this.textBoxHeadTeacherId_MAI.Location = new System.Drawing.Point(378, 23);
            this.textBoxHeadTeacherId_MAI.Name = "textBoxHeadTeacherId_MAI";
            this.textBoxHeadTeacherId_MAI.Size = new System.Drawing.Size(127, 23);
            this.textBoxHeadTeacherId_MAI.TabIndex = 3;
            this.textBoxHeadTeacherId_MAI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumericOnly_MAI_KeyPress);

            this.labelDepartmentName_MAI.AutoSize = true;
            this.labelDepartmentName_MAI.Location = new System.Drawing.Point(14, 62);
            this.labelDepartmentName_MAI.Name = "labelDepartmentName_MAI";
            this.labelDepartmentName_MAI.Size = new System.Drawing.Size(63, 15);
            this.labelDepartmentName_MAI.TabIndex = 4;
            this.labelDepartmentName_MAI.Text = "Кафедра:";

            this.textBoxDepartmentName_MAI.Location = new System.Drawing.Point(120, 59);
            this.textBoxDepartmentName_MAI.Name = "textBoxDepartmentName_MAI";
            this.textBoxDepartmentName_MAI.Size = new System.Drawing.Size(385, 23);
            this.textBoxDepartmentName_MAI.TabIndex = 5;

            this.labelClassroom_MAI.AutoSize = true;
            this.labelClassroom_MAI.Location = new System.Drawing.Point(14, 98);
            this.labelClassroom_MAI.Name = "labelClassroom_MAI";
            this.labelClassroom_MAI.Size = new System.Drawing.Size(68, 15);
            this.labelClassroom_MAI.TabIndex = 6;
            this.labelClassroom_MAI.Text = "Аудитория:";

            this.textBoxClassroom_MAI.Location = new System.Drawing.Point(120, 95);
            this.textBoxClassroom_MAI.Name = "textBoxClassroom_MAI";
            this.textBoxClassroom_MAI.Size = new System.Drawing.Size(120, 23);
            this.textBoxClassroom_MAI.TabIndex = 7;

            this.buttonSaveRecord_MAI.BackColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.buttonSaveRecord_MAI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveRecord_MAI.ForeColor = System.Drawing.Color.White;
            this.buttonSaveRecord_MAI.Location = new System.Drawing.Point(314, 500);
            this.buttonSaveRecord_MAI.Name = "buttonSaveRecord_MAI";
            this.buttonSaveRecord_MAI.Size = new System.Drawing.Size(105, 32);
            this.buttonSaveRecord_MAI.TabIndex = 3;
            this.buttonSaveRecord_MAI.Text = "Сохранить";
            this.buttonSaveRecord_MAI.UseVisualStyleBackColor = false;
            this.buttonSaveRecord_MAI.Click += new System.EventHandler(this.buttonSaveRecord_MAI_Click);

            this.buttonCancelRecord_MAI.Location = new System.Drawing.Point(429, 500);
            this.buttonCancelRecord_MAI.Name = "buttonCancelRecord_MAI";
            this.buttonCancelRecord_MAI.Size = new System.Drawing.Size(105, 32);
            this.buttonCancelRecord_MAI.TabIndex = 4;
            this.buttonCancelRecord_MAI.Text = "Отмена";
            this.buttonCancelRecord_MAI.UseVisualStyleBackColor = true;
            this.buttonCancelRecord_MAI.Click += new System.EventHandler(this.buttonCancelRecord_MAI_Click);

            this.AcceptButton = this.buttonSaveRecord_MAI;
            this.CancelButton = this.buttonCancelRecord_MAI;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 545);
            this.Controls.Add(this.buttonCancelRecord_MAI);
            this.Controls.Add(this.buttonSaveRecord_MAI);
            this.Controls.Add(this.groupBoxDepartmentInfo_MAI);
            this.Controls.Add(this.groupBoxSubjectInfo_MAI);
            this.Controls.Add(this.groupBoxTeacherInfo_MAI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEditRecord_MAI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Запись — Университет";
            this.groupBoxTeacherInfo_MAI.ResumeLayout(false);
            this.groupBoxTeacherInfo_MAI.PerformLayout();
            this.groupBoxSubjectInfo_MAI.ResumeLayout(false);
            this.groupBoxSubjectInfo_MAI.PerformLayout();
            this.groupBoxDepartmentInfo_MAI.ResumeLayout(false);
            this.groupBoxDepartmentInfo_MAI.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox groupBoxTeacherInfo_MAI;
        private System.Windows.Forms.Label labelTeacherId_MAI;
        private System.Windows.Forms.TextBox textBoxTeacherId_MAI;
        private System.Windows.Forms.Label labelTeacherFullName_MAI;
        private System.Windows.Forms.TextBox textBoxTeacherFullName_MAI;
        private System.Windows.Forms.Label labelTeacherAddress_MAI;
        private System.Windows.Forms.TextBox textBoxTeacherAddress_MAI;
        private System.Windows.Forms.Label labelTeacherPosition_MAI;
        private System.Windows.Forms.ComboBox comboBoxTeacherPosition_MAI;
        private System.Windows.Forms.GroupBox groupBoxSubjectInfo_MAI;
        private System.Windows.Forms.Label labelSubjectCode_MAI;
        private System.Windows.Forms.TextBox textBoxSubjectCode_MAI;
        private System.Windows.Forms.Label labelSubjectName_MAI;
        private System.Windows.Forms.TextBox textBoxSubjectName_MAI;
        private System.Windows.Forms.Label labelSubjectHours_MAI;
        private System.Windows.Forms.TextBox textBoxSubjectHours_MAI;
        private System.Windows.Forms.Label labelControlType_MAI;
        private System.Windows.Forms.ComboBox comboBoxControlType_MAI;
        private System.Windows.Forms.Label labelSubjectSection_MAI;
        private System.Windows.Forms.TextBox textBoxSubjectSection_MAI;
        private System.Windows.Forms.GroupBox groupBoxDepartmentInfo_MAI;
        private System.Windows.Forms.Label labelDepartmentCode_MAI;
        private System.Windows.Forms.TextBox textBoxDepartmentCode_MAI;
        private System.Windows.Forms.Label labelDepartmentName_MAI;
        private System.Windows.Forms.TextBox textBoxDepartmentName_MAI;
        private System.Windows.Forms.Label labelHeadTeacherId_MAI;
        private System.Windows.Forms.TextBox textBoxHeadTeacherId_MAI;
        private System.Windows.Forms.Label labelClassroom_MAI;
        private System.Windows.Forms.TextBox textBoxClassroom_MAI;
        private System.Windows.Forms.Button buttonSaveRecord_MAI;
        private System.Windows.Forms.Button buttonCancelRecord_MAI;
        private System.Windows.Forms.ToolTip toolTipEdit_MAI;
    }
}
