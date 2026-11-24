using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.MikhailichenkoAI.Sprint7.Project.V3.Lib;

namespace Tyuiu.MikhailichenkoAI.Sprint7.Project.V3
{
    public partial class FormMain_MAI : Form
    {
        private readonly DataService dataService = new DataService();
        private List<UniversityRecord> allRecords = new List<UniversityRecord>();
        private List<UniversityRecord> displayedRecords = new List<UniversityRecord>();
        private string currentFilePath = string.Empty;
        private bool isUpdatingFilters = false;

        public FormMain_MAI()
        {
            InitializeComponent();
        }

        private void FormMain_MAI_Load(object sender, EventArgs e)
        {
            ConfigureGridColumns();
            comboBoxSortField_MAI.SelectedIndex = 0;
            comboBoxChartMode_MAI.SelectedIndex = 0;

            string defaultFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "UniversityData.csv");
            if (File.Exists(defaultFile))
            {
                LoadCsvFile(defaultFile);
            }
            else
            {
                PopulateFilterDropdowns();
                ApplyDataPipeline();
            }
        }

        private void ConfigureGridColumns()
        {
            dataGridViewUniversity_MAI.Columns.Clear();
            dataGridViewUniversity_MAI.Columns.Add("colTeacherId_MAI", "№ преп.");
            dataGridViewUniversity_MAI.Columns.Add("colTeacherFullName_MAI", "ФИО преподавателя");
            dataGridViewUniversity_MAI.Columns.Add("colTeacherAddress_MAI", "Адрес");
            dataGridViewUniversity_MAI.Columns.Add("colTeacherPosition_MAI", "Должность");
            dataGridViewUniversity_MAI.Columns.Add("colSubjectCode_MAI", "Код предм.");
            dataGridViewUniversity_MAI.Columns.Add("colSubjectName_MAI", "Название предмета");
            dataGridViewUniversity_MAI.Columns.Add("colHours_MAI", "Часы");
            dataGridViewUniversity_MAI.Columns.Add("colControlType_MAI", "Тип контроля");
            dataGridViewUniversity_MAI.Columns.Add("colSubjectSection_MAI", "Раздел предмета");
            dataGridViewUniversity_MAI.Columns.Add("colDepartmentCode_MAI", "Код каф.");
            dataGridViewUniversity_MAI.Columns.Add("colDepartmentName_MAI", "Название кафедры");
            dataGridViewUniversity_MAI.Columns.Add("colHeadTeacherId_MAI", "№ зав. каф.");
            dataGridViewUniversity_MAI.Columns.Add("colClassroom_MAI", "Аудитория");
        }

        private void LoadCsvFile(string path)
        {
            try
            {
                allRecords = dataService.LoadFromCsv(path);
                currentFilePath = path;
                PopulateFilterDropdowns();
                ApplyDataPipeline();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось загрузить файл CSV: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateFilterDropdowns()
        {
            isUpdatingFilters = true;

            string selectedPos = comboBoxFilterPosition_MAI.SelectedItem?.ToString() ?? "Все";
            string selectedCtrl = comboBoxFilterControl_MAI.SelectedItem?.ToString() ?? "Все";
            string selectedDept = comboBoxFilterDepartment_MAI.SelectedItem?.ToString() ?? "Все";

            comboBoxFilterPosition_MAI.Items.Clear();
            comboBoxFilterPosition_MAI.Items.Add("Все");
            foreach (string pos in allRecords.Select(r => r.TeacherPosition).Where(s => !string.IsNullOrWhiteSpace(s)).Distinct().OrderBy(s => s))
            {
                comboBoxFilterPosition_MAI.Items.Add(pos);
            }

            comboBoxFilterControl_MAI.Items.Clear();
            comboBoxFilterControl_MAI.Items.Add("Все");
            foreach (string ctrl in allRecords.Select(r => r.ControlType).Where(s => !string.IsNullOrWhiteSpace(s)).Distinct().OrderBy(s => s))
            {
                comboBoxFilterControl_MAI.Items.Add(ctrl);
            }

            comboBoxFilterDepartment_MAI.Items.Clear();
            comboBoxFilterDepartment_MAI.Items.Add("Все");
            foreach (string dept in allRecords.Select(r => r.DepartmentName).Where(s => !string.IsNullOrWhiteSpace(s)).Distinct().OrderBy(s => s))
            {
                comboBoxFilterDepartment_MAI.Items.Add(dept);
            }

            comboBoxFilterPosition_MAI.SelectedItem = comboBoxFilterPosition_MAI.Items.Contains(selectedPos) ? selectedPos : "Все";
            comboBoxFilterControl_MAI.SelectedItem = comboBoxFilterControl_MAI.Items.Contains(selectedCtrl) ? selectedCtrl : "Все";
            comboBoxFilterDepartment_MAI.SelectedItem = comboBoxFilterDepartment_MAI.Items.Contains(selectedDept) ? selectedDept : "Все";

            isUpdatingFilters = false;
        }

        private void ApplyDataPipeline()
        {
            if (isUpdatingFilters)
            {
                return;
            }

            string query = textBoxSearch_MAI.Text;
            string position = comboBoxFilterPosition_MAI.SelectedItem?.ToString() ?? "Все";
            string controlType = comboBoxFilterControl_MAI.SelectedItem?.ToString() ?? "Все";
            string department = comboBoxFilterDepartment_MAI.SelectedItem?.ToString() ?? "Все";
            string sortField = comboBoxSortField_MAI.SelectedItem?.ToString() ?? "Номер преподавателя";
            bool ascending = checkBoxSortAsc_MAI.Checked;

            List<UniversityRecord> result = dataService.SearchRecords(allRecords, query);
            result = dataService.FilterRecords(result, position, controlType, department);
            result = dataService.SortRecords(result, sortField, ascending);

            displayedRecords = result;
            RefreshGrid();
            UpdateStatistics();
            UpdateChart();
            UpdateStatusBar();
        }

        private void RefreshGrid()
        {
            dataGridViewUniversity_MAI.Rows.Clear();

            foreach (UniversityRecord r in displayedRecords)
            {
                int rowIndex = dataGridViewUniversity_MAI.Rows.Add(
                    r.TeacherId,
                    r.TeacherFullName,
                    r.TeacherAddress,
                    r.TeacherPosition,
                    r.SubjectCode,
                    r.SubjectName,
                    r.Hours,
                    r.ControlType,
                    r.SubjectSection,
                    r.DepartmentCode,
                    r.DepartmentName,
                    r.HeadTeacherId,
                    r.Classroom
                );
                dataGridViewUniversity_MAI.Rows[rowIndex].Tag = r;
            }
        }

        private void UpdateStatistics()
        {
            textBoxStatCount_MAI.Text = dataService.GetCount(displayedRecords).ToString();
            textBoxStatSum_MAI.Text = dataService.GetTotalHours(displayedRecords).ToString();
            textBoxStatAvg_MAI.Text = dataService.GetAverageHours(displayedRecords).ToString("F2");
            textBoxStatMin_MAI.Text = dataService.GetMinHours(displayedRecords).ToString();
            textBoxStatMax_MAI.Text = dataService.GetMaxHours(displayedRecords).ToString();
        }

        private void UpdateChart()
        {
            chartAnalytics_MAI.Series.Clear();
            chartAnalytics_MAI.Titles.Clear();

            ChartArea area = chartAnalytics_MAI.ChartAreas[0];
            area.AxisX.CustomLabels.Clear();
            area.AxisX.Interval = 1;
            area.AxisX.LabelStyle.Interval = 1;
            area.AxisX.LabelStyle.IsEndLabelVisible = true;
            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.MajorGrid.LineColor = Color.LightGray;

            int mode = comboBoxChartMode_MAI.SelectedIndex;
            Dictionary<string, int> chartData;
            string titleText;
            SeriesChartType chartType = SeriesChartType.Column;

            if (mode == 1)
            {
                chartData = dataService.GetHoursByPosition(displayedRecords);
                titleText = "Распределение часов по должностям";
                area.AxisX.Title = "Должность";
                area.AxisY.Title = "Часы";
            }
            else if (mode == 2)
            {
                chartData = dataService.GetCountByControlType(displayedRecords);
                titleText = "Количество предметов по типу контроля";
                chartType = SeriesChartType.Pie;
                area.AxisX.Title = string.Empty;
                area.AxisY.Title = string.Empty;
            }
            else
            {
                chartData = dataService.GetHoursByDepartment(displayedRecords);
                titleText = "Распределение часов по кафедрам";
                area.AxisX.Title = "Кафедра";
                area.AxisY.Title = "Часы";
            }

            chartAnalytics_MAI.Titles.Add(titleText);
            chartAnalytics_MAI.Titles[0].Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            Series series = new Series("SeriesData_MAI")
            {
                ChartType = chartType,
                IsValueShownAsLabel = true,
                IsXValueIndexed = true
            };

            Color[] barPalette = new Color[]
            {
                Color.FromArgb(41, 128, 185),
                Color.FromArgb(39, 174, 96),
                Color.FromArgb(230, 126, 34),
                Color.FromArgb(142, 68, 173),
                Color.FromArgb(22, 160, 133),
                Color.FromArgb(192, 57, 43)
            };

            if (chartType == SeriesChartType.Column)
            {
                chartAnalytics_MAI.Legends[0].Enabled = false;
                series["PointWidth"] = "0.6";
                int index = 1;
                foreach (KeyValuePair<string, int> item in chartData)
                {
                    int ptIndex = series.Points.AddXY(index, item.Value);
                    DataPoint pt = series.Points[ptIndex];
                    pt.AxisLabel = item.Key;
                    pt.Color = barPalette[(index - 1) % barPalette.Length];
                    pt.ToolTip = $"{item.Key}: {item.Value} ч.";
                    index++;
                }
            }
            else
            {
                chartAnalytics_MAI.Legends[0].Enabled = true;
                series.IsXValueIndexed = false;
                foreach (KeyValuePair<string, int> item in chartData)
                {
                    int ptIndex = series.Points.AddXY(item.Key, item.Value);
                    DataPoint pt = series.Points[ptIndex];
                    pt.LegendText = $"{item.Key} ({item.Value})";
                    pt.Label = "#VAL (#PERCENT{P0})";
                    pt.ToolTip = $"{item.Key}: {item.Value}";
                }
            }

            chartAnalytics_MAI.Series.Add(series);
            area.RecalculateAxesScale();
        }

        private void UpdateStatusBar()
        {
            string fileDisplay = string.IsNullOrEmpty(currentFilePath) ? "Файл не выбран" : currentFilePath;
            toolStripStatusLabelFile_MAI.Text = "Файл: " + fileDisplay;
            toolStripStatusLabelCount_MAI.Text = $"Показано записей: {displayedRecords.Count} из {allRecords.Count}";
        }

        private UniversityRecord? GetSelectedRecord()
        {
            if (dataGridViewUniversity_MAI.SelectedRows.Count == 0)
            {
                return null;
            }
            return dataGridViewUniversity_MAI.SelectedRows[0].Tag as UniversityRecord;
        }

        private void OpenCsvAction()
        {
            if (openFileDialogCsv_MAI.ShowDialog() == DialogResult.OK)
            {
                LoadCsvFile(openFileDialogCsv_MAI.FileName);
            }
        }

        private void SaveCsvAction(bool saveAs)
        {
            string targetPath = currentFilePath;
            if (saveAs || string.IsNullOrEmpty(targetPath))
            {
                saveFileDialogCsv_MAI.FileName = string.IsNullOrEmpty(currentFilePath) ? "UniversityData.csv" : Path.GetFileName(currentFilePath);
                if (saveFileDialogCsv_MAI.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                targetPath = saveFileDialogCsv_MAI.FileName;
            }

            try
            {
                dataService.SaveToCsv(targetPath, allRecords);
                currentFilePath = targetPath;
                UpdateStatusBar();
                MessageBox.Show("Данные успешно сохранены в файл:\n" + targetPath, "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении файла: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddRecordAction()
        {
            using (FormEditRecord_MAI formEdit = new FormEditRecord_MAI())
            {
                if (formEdit.ShowDialog() == DialogResult.OK)
                {
                    allRecords.Add(formEdit.RecordData);
                    PopulateFilterDropdowns();
                    ApplyDataPipeline();
                }
            }
        }

        private void EditRecordAction()
        {
            UniversityRecord? selected = GetSelectedRecord();
            if (selected == null)
            {
                MessageBox.Show("Выберите строку в таблице для редактирования.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (FormEditRecord_MAI formEdit = new FormEditRecord_MAI(selected))
            {
                if (formEdit.ShowDialog() == DialogResult.OK)
                {
                    int idx = allRecords.IndexOf(selected);
                    if (idx >= 0)
                    {
                        allRecords[idx] = formEdit.RecordData;
                    }
                    PopulateFilterDropdowns();
                    ApplyDataPipeline();
                }
            }
        }

        private void DeleteRecordAction()
        {
            UniversityRecord? selected = GetSelectedRecord();
            if (selected == null)
            {
                MessageBox.Show("Выберите строку в таблице для удаления.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                $"Удалить запись «{selected.TeacherFullName} — {selected.SubjectName}»?",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                allRecords.Remove(selected);
                PopulateFilterDropdowns();
                ApplyDataPipeline();
            }
        }

        private void ResetFiltersAction()
        {
            isUpdatingFilters = true;
            textBoxSearch_MAI.Text = string.Empty;
            comboBoxFilterPosition_MAI.SelectedItem = "Все";
            comboBoxFilterControl_MAI.SelectedItem = "Все";
            comboBoxFilterDepartment_MAI.SelectedItem = "Все";
            comboBoxSortField_MAI.SelectedIndex = 0;
            checkBoxSortAsc_MAI.Checked = true;
            isUpdatingFilters = false;
            ApplyDataPipeline();
        }

        private void OpenGuideAction()
        {
            using (FormGuide_MAI formGuide = new FormGuide_MAI())
            {
                formGuide.ShowDialog();
            }
        }

        private void OpenAboutAction()
        {
            using (FormAbout_MAI formAbout = new FormAbout_MAI())
            {
                formAbout.ShowDialog();
            }
        }

        private void menuItemOpenCsv_MAI_Click(object sender, EventArgs e) => OpenCsvAction();
        private void menuItemSaveCsv_MAI_Click(object sender, EventArgs e) => SaveCsvAction(false);
        private void menuItemSaveAsCsv_MAI_Click(object sender, EventArgs e) => SaveCsvAction(true);
        private void menuItemExit_MAI_Click(object sender, EventArgs e) => this.Close();
        private void menuItemAddRecord_MAI_Click(object sender, EventArgs e) => AddRecordAction();
        private void menuItemEditRecord_MAI_Click(object sender, EventArgs e) => EditRecordAction();
        private void menuItemDeleteRecord_MAI_Click(object sender, EventArgs e) => DeleteRecordAction();
        private void menuItemResetFilters_MAI_Click(object sender, EventArgs e) => ResetFiltersAction();
        private void menuItemRefreshChart_MAI_Click(object sender, EventArgs e) => UpdateChart();
        private void menuItemGuide_MAI_Click(object sender, EventArgs e) => OpenGuideAction();
        private void menuItemAbout_MAI_Click(object sender, EventArgs e) => OpenAboutAction();

        private void toolStripButtonOpen_MAI_Click(object sender, EventArgs e) => OpenCsvAction();
        private void toolStripButtonSave_MAI_Click(object sender, EventArgs e) => SaveCsvAction(false);
        private void toolStripButtonAdd_MAI_Click(object sender, EventArgs e) => AddRecordAction();
        private void toolStripButtonEdit_MAI_Click(object sender, EventArgs e) => EditRecordAction();
        private void toolStripButtonDelete_MAI_Click(object sender, EventArgs e) => DeleteRecordAction();
        private void toolStripButtonReset_MAI_Click(object sender, EventArgs e) => ResetFiltersAction();
        private void toolStripButtonGuide_MAI_Click(object sender, EventArgs e) => OpenGuideAction();
        private void toolStripButtonAbout_MAI_Click(object sender, EventArgs e) => OpenAboutAction();

        private void textBoxSearch_MAI_TextChanged(object sender, EventArgs e) => ApplyDataPipeline();
        private void comboBoxFilterPosition_MAI_SelectedIndexChanged(object sender, EventArgs e) => ApplyDataPipeline();
        private void comboBoxFilterControl_MAI_SelectedIndexChanged(object sender, EventArgs e) => ApplyDataPipeline();
        private void comboBoxFilterDepartment_MAI_SelectedIndexChanged(object sender, EventArgs e) => ApplyDataPipeline();
        private void comboBoxSortField_MAI_SelectedIndexChanged(object sender, EventArgs e) => ApplyDataPipeline();
        private void checkBoxSortAsc_MAI_CheckedChanged(object sender, EventArgs e) => ApplyDataPipeline();
        private void buttonResetFilters_MAI_Click(object sender, EventArgs e) => ResetFiltersAction();
        private void comboBoxChartMode_MAI_SelectedIndexChanged(object sender, EventArgs e) => UpdateChart();

        private void dataGridViewUniversity_MAI_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                EditRecordAction();
            }
        }
    }
}
