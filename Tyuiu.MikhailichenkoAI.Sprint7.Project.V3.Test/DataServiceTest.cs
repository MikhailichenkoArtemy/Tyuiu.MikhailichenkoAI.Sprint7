using System.Collections.Generic;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MikhailichenkoAI.Sprint7.Project.V3.Lib;

namespace Tyuiu.MikhailichenkoAI.Sprint7.Project.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        private List<UniversityRecord> CreateSampleRecords()
        {
            return new List<UniversityRecord>
            {
                new UniversityRecord
                {
                    TeacherId = 101,
                    TeacherFullName = "Смирнов Алексей Викторович",
                    TeacherAddress = "ул. Республики, д. 45",
                    TeacherPosition = "Профессор",
                    SubjectCode = "CS-101",
                    SubjectName = "Программирование на C#",
                    Hours = 144,
                    ControlType = "Экзамен",
                    SubjectSection = "Программная инженерия",
                    DepartmentCode = "КАФ-01",
                    DepartmentName = "Прикладная информатика",
                    HeadTeacherId = 101,
                    Classroom = "305А"
                },
                new UniversityRecord
                {
                    TeacherId = 102,
                    TeacherFullName = "Кузнецова Елена Сергеевна",
                    TeacherAddress = "ул. Мельникайте, д. 72",
                    TeacherPosition = "Доцент",
                    SubjectCode = "CS-102",
                    SubjectName = "Базы данных",
                    Hours = 108,
                    ControlType = "Зачёт",
                    SubjectSection = "Информационные системы",
                    DepartmentCode = "КАФ-01",
                    DepartmentName = "Прикладная информатика",
                    HeadTeacherId = 101,
                    Classroom = "308Б"
                },
                new UniversityRecord
                {
                    TeacherId = 104,
                    TeacherFullName = "Волкова Ольга Андреевна",
                    TeacherAddress = "ул. Широтная, д. 112",
                    TeacherPosition = "Профессор",
                    SubjectCode = "MATH-201",
                    SubjectName = "Математический анализ",
                    Hours = 180,
                    ControlType = "Экзамен",
                    SubjectSection = "Математические основы",
                    DepartmentCode = "КАФ-02",
                    DepartmentName = "Высшая математика",
                    HeadTeacherId = 104,
                    Classroom = "201"
                }
            };
        }

        [TestMethod]
        public void ValidSaveAndLoadCsv()
        {
            DataService ds = new DataService();
            string path = Path.Combine(Path.GetTempPath(), "TestUniversityData_MAI.csv");
            List<UniversityRecord> sample = CreateSampleRecords();

            ds.SaveToCsv(path, sample);
            List<UniversityRecord> loaded = ds.LoadFromCsv(path);

            Assert.AreEqual(sample.Count, loaded.Count);
            Assert.AreEqual(sample[0].TeacherFullName, loaded[0].TeacherFullName);
            Assert.AreEqual(sample[2].Hours, loaded[2].Hours);

            if (File.Exists(path))
            {
                File.Delete(path); 
            }
        }

        [TestMethod]
        public void ValidSearchRecords()
        {
            DataService ds = new DataService();
            List<UniversityRecord> sample = CreateSampleRecords();

            List<UniversityRecord> found = ds.SearchRecords(sample, "Базы данных");

            Assert.AreEqual(1, found.Count);
            Assert.AreEqual(102, found[0].TeacherId);
        }

        [TestMethod]
        public void ValidFilterRecords()
        {
            DataService ds = new DataService();
            List<UniversityRecord> sample = CreateSampleRecords();

            List<UniversityRecord> filtered = ds.FilterRecords(sample, "Профессор", "Экзамен", "Все");

            Assert.AreEqual(2, filtered.Count);
        }

        [TestMethod]
        public void ValidSortRecords()
        {
            DataService ds = new DataService();
            List<UniversityRecord> sample = CreateSampleRecords();

            List<UniversityRecord> sortedDesc = ds.SortRecords(sample, "Количество часов", false);

            Assert.AreEqual(180, sortedDesc[0].Hours);
            Assert.AreEqual(108, sortedDesc[2].Hours);
        }

        [TestMethod]
        public void ValidStatistics()
        {
            DataService ds = new DataService();
            List<UniversityRecord> sample = CreateSampleRecords();

            Assert.AreEqual(3, ds.GetCount(sample));
            Assert.AreEqual(432, ds.GetTotalHours(sample));
            Assert.AreEqual(144.0, ds.GetAverageHours(sample));
            Assert.AreEqual(108, ds.GetMinHours(sample));
            Assert.AreEqual(180, ds.GetMaxHours(sample));
        }

        [TestMethod]
        public void ValidChartAggregations()
        {
            DataService ds = new DataService();
            List<UniversityRecord> sample = CreateSampleRecords();

            Dictionary<string, int> byDept = ds.GetHoursByDepartment(sample);
            Dictionary<string, int> byPos = ds.GetHoursByPosition(sample);
            Dictionary<string, int> byCtrl = ds.GetCountByControlType(sample);

            Assert.AreEqual(252, byDept["Прикладная информатика"]);
            Assert.AreEqual(180, byDept["Высшая математика"]);
            Assert.AreEqual(324, byPos["Профессор"]);
            Assert.AreEqual(2, byCtrl["Экзамен"]);
        }
    }
}
