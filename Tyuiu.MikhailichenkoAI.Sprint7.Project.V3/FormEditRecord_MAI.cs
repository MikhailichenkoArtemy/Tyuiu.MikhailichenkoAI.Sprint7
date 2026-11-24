using System;
using System.Windows.Forms;
using Tyuiu.MikhailichenkoAI.Sprint7.Project.V3.Lib;

namespace Tyuiu.MikhailichenkoAI.Sprint7.Project.V3
{
    public partial class FormEditRecord_MAI : Form
    {
        public UniversityRecord RecordData { get; private set; }

        public FormEditRecord_MAI(UniversityRecord? existingRecord = null)
        {
            InitializeComponent();

            if (existingRecord != null)
            {
                this.Text = "Редактирование записи — Университет";
                RecordData = existingRecord;
                textBoxTeacherId_MAI.Text = existingRecord.TeacherId.ToString();
                textBoxTeacherFullName_MAI.Text = existingRecord.TeacherFullName;
                textBoxTeacherAddress_MAI.Text = existingRecord.TeacherAddress;
                comboBoxTeacherPosition_MAI.Text = existingRecord.TeacherPosition;
                textBoxSubjectCode_MAI.Text = existingRecord.SubjectCode;
                textBoxSubjectName_MAI.Text = existingRecord.SubjectName;
                textBoxSubjectHours_MAI.Text = existingRecord.Hours.ToString();
                comboBoxControlType_MAI.Text = existingRecord.ControlType;
                textBoxSubjectSection_MAI.Text = existingRecord.SubjectSection;
                textBoxDepartmentCode_MAI.Text = existingRecord.DepartmentCode;
                textBoxDepartmentName_MAI.Text = existingRecord.DepartmentName;
                textBoxHeadTeacherId_MAI.Text = existingRecord.HeadTeacherId.ToString();
                textBoxClassroom_MAI.Text = existingRecord.Classroom;
            }
            else
            {
                this.Text = "Добавление записи — Университет";
                RecordData = new UniversityRecord();
                comboBoxTeacherPosition_MAI.SelectedIndex = 1;
                comboBoxControlType_MAI.SelectedIndex = 0;
            }
        }

        private void buttonSaveRecord_MAI_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxTeacherId_MAI.Text.Trim(), out int teacherId) || teacherId <= 0)
            {
                MessageBox.Show("Введите корректный положительный номер преподавателя.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxTeacherId_MAI.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxTeacherFullName_MAI.Text))
            {
                MessageBox.Show("Укажите ФИО преподавателя.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxTeacherFullName_MAI.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxSubjectName_MAI.Text))
            {
                MessageBox.Show("Укажите название предмета.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxSubjectName_MAI.Focus();
                return;
            }

            if (!int.TryParse(textBoxSubjectHours_MAI.Text.Trim(), out int hours) || hours <= 0)
            {
                MessageBox.Show("Введите корректное количество часов (целое число больше 0).", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxSubjectHours_MAI.Focus();
                return;
            }

            if (!int.TryParse(textBoxHeadTeacherId_MAI.Text.Trim(), out int headTeacherId) || headTeacherId <= 0)
            {
                MessageBox.Show("Введите корректный номер заведующего кафедрой.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxHeadTeacherId_MAI.Focus();
                return;
            }

            RecordData = new UniversityRecord
            {
                TeacherId = teacherId,
                TeacherFullName = textBoxTeacherFullName_MAI.Text.Trim(),
                TeacherAddress = textBoxTeacherAddress_MAI.Text.Trim(),
                TeacherPosition = comboBoxTeacherPosition_MAI.Text.Trim(),
                SubjectCode = textBoxSubjectCode_MAI.Text.Trim(),
                SubjectName = textBoxSubjectName_MAI.Text.Trim(),
                Hours = hours,
                ControlType = comboBoxControlType_MAI.Text.Trim(),
                SubjectSection = textBoxSubjectSection_MAI.Text.Trim(),
                DepartmentCode = textBoxDepartmentCode_MAI.Text.Trim(),
                DepartmentName = textBoxDepartmentName_MAI.Text.Trim(),
                HeadTeacherId = headTeacherId,
                Classroom = textBoxClassroom_MAI.Text.Trim()
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancelRecord_MAI_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void textBoxNumericOnly_MAI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
