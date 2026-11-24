using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Tyuiu.MikhailichenkoAI.Sprint7.Project.V3.Lib
{
    public class DataService
    {
        private const string CsvHeader = "Номер преподавателя;ФИО преподавателя;Адрес преподавателя;Должность;Код предмета;Название предмета;Количество часов;Тип контроля;Раздел предмета;Код кафедры;Название кафедры;Номер зав. кафедрой;Аудитория";

        public List<UniversityRecord> LoadFromCsv(string path)
        {
            List<UniversityRecord> records = new List<UniversityRecord>(); 
            if (!File.Exists(path))
            {
                return records;
            }

            string[] lines = File.ReadAllLines(path, Encoding.UTF8);
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i].Trim();
                if (string.IsNullOrWhiteSpace(line))
                {
                    continue;
                }

                string[] parts = line.Split(';');
                if (parts.Length < 13)
                {
                    continue;
                }

                if (i == 0 && !int.TryParse(parts[0].Trim(), out _))
                {
                    continue;
                }

                if (!int.TryParse(parts[0].Trim(), out int teacherId))
                {
                    continue;
                }

                int.TryParse(parts[6].Trim(), out int hours);
                int.TryParse(parts[11].Trim(), out int headTeacherId);

                records.Add(new UniversityRecord
                {
                    TeacherId = teacherId,
                    TeacherFullName = parts[1].Trim(),
                    TeacherAddress = parts[2].Trim(),
                    TeacherPosition = parts[3].Trim(),
                    SubjectCode = parts[4].Trim(),
                    SubjectName = parts[5].Trim(),
                    Hours = hours,
                    ControlType = parts[7].Trim(),
                    SubjectSection = parts[8].Trim(),
                    DepartmentCode = parts[9].Trim(),
                    DepartmentName = parts[10].Trim(),
                    HeadTeacherId = headTeacherId,
                    Classroom = parts[12].Trim()
                });
            }

            return records;
        }

        public void SaveToCsv(string path, List<UniversityRecord> records)
        {
            List<string> lines = new List<string> { CsvHeader };

            foreach (UniversityRecord r in records)
            {
                string line = string.Join(";",
                    r.TeacherId,
                    SanitizeField(r.TeacherFullName),
                    SanitizeField(r.TeacherAddress),
                    SanitizeField(r.TeacherPosition),
                    SanitizeField(r.SubjectCode),
                    SanitizeField(r.SubjectName),
                    r.Hours,
                    SanitizeField(r.ControlType),
                    SanitizeField(r.SubjectSection),
                    SanitizeField(r.DepartmentCode),
                    SanitizeField(r.DepartmentName),
                    r.HeadTeacherId,
                    SanitizeField(r.Classroom));
                lines.Add(line);
            }

            File.WriteAllLines(path, lines, new UTF8Encoding(true));
        }

        private string SanitizeField(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return string.Empty;
            }
            return value.Replace(";", ",").Replace("\r", " ").Replace("\n", " ").Trim();
        }

        public List<UniversityRecord> SearchRecords(List<UniversityRecord> records, string query)
        {
            if (string.IsNullOrWhiteSpace(query))
            {
                return new List<UniversityRecord>(records);
            }

            string q = query.Trim().ToLowerInvariant();
            return records.Where(r =>
                r.TeacherId.ToString().Contains(q) ||
                r.TeacherFullName.ToLowerInvariant().Contains(q) ||
                r.TeacherAddress.ToLowerInvariant().Contains(q) ||
                r.TeacherPosition.ToLowerInvariant().Contains(q) ||
                r.SubjectCode.ToLowerInvariant().Contains(q) ||
                r.SubjectName.ToLowerInvariant().Contains(q) ||
                r.Hours.ToString().Contains(q) ||
                r.ControlType.ToLowerInvariant().Contains(q) ||
                r.SubjectSection.ToLowerInvariant().Contains(q) ||
                r.DepartmentCode.ToLowerInvariant().Contains(q) ||
                r.DepartmentName.ToLowerInvariant().Contains(q) ||
                r.HeadTeacherId.ToString().Contains(q) ||
                r.Classroom.ToLowerInvariant().Contains(q)
            ).ToList();
        }

        public List<UniversityRecord> FilterRecords(List<UniversityRecord> records, string position, string controlType, string department)
        {
            IEnumerable<UniversityRecord> query = records;

            if (!string.IsNullOrWhiteSpace(position) && position != "Все")
            {
                query = query.Where(r => r.TeacherPosition.Equals(position, StringComparison.OrdinalIgnoreCase));
            }

            if (!string.IsNullOrWhiteSpace(controlType) && controlType != "Все")
            {
                query = query.Where(r => r.ControlType.Equals(controlType, StringComparison.OrdinalIgnoreCase));
            }

            if (!string.IsNullOrWhiteSpace(department) && department != "Все")
            {
                query = query.Where(r => r.DepartmentName.Equals(department, StringComparison.OrdinalIgnoreCase));
            }

            return query.ToList();
        }

        public List<UniversityRecord> SortRecords(List<UniversityRecord> records, string sortBy, bool ascending)
        {
            IEnumerable<UniversityRecord> sorted = sortBy switch
            {
                "Номер преподавателя" => ascending ? records.OrderBy(r => r.TeacherId) : records.OrderByDescending(r => r.TeacherId),
                "ФИО преподавателя" => ascending ? records.OrderBy(r => r.TeacherFullName) : records.OrderByDescending(r => r.TeacherFullName),
                "Должность" => ascending ? records.OrderBy(r => r.TeacherPosition) : records.OrderByDescending(r => r.TeacherPosition),
                "Название предмета" => ascending ? records.OrderBy(r => r.SubjectName) : records.OrderByDescending(r => r.SubjectName),
                "Количество часов" => ascending ? records.OrderBy(r => r.Hours) : records.OrderByDescending(r => r.Hours),
                "Кафедра" => ascending ? records.OrderBy(r => r.DepartmentName) : records.OrderByDescending(r => r.DepartmentName),
                "Аудитория" => ascending ? records.OrderBy(r => r.Classroom) : records.OrderByDescending(r => r.Classroom),
                _ => ascending ? records.OrderBy(r => r.TeacherId) : records.OrderByDescending(r => r.TeacherId)
            };

            return sorted.ToList();
        }

        public int GetCount(List<UniversityRecord> records)
        {
            return records.Count;
        }

        public int GetTotalHours(List<UniversityRecord> records)
        {
            if (records.Count == 0)
            {
                return 0;
            }
            return records.Sum(r => r.Hours);
        }

        public double GetAverageHours(List<UniversityRecord> records)
        {
            if (records.Count == 0)
            {
                return 0;
            }
            return Math.Round(records.Average(r => r.Hours), 2);
        }

        public int GetMinHours(List<UniversityRecord> records)
        {
            if (records.Count == 0)
            {
                return 0;
            }
            return records.Min(r => r.Hours);
        }

        public int GetMaxHours(List<UniversityRecord> records)
        {
            if (records.Count == 0)
            {
                return 0;
            }
            return records.Max(r => r.Hours);
        }

        public Dictionary<string, int> GetHoursByDepartment(List<UniversityRecord> records)
        {
            return records
                .GroupBy(r => string.IsNullOrWhiteSpace(r.DepartmentName) ? "Без кафедры" : r.DepartmentName)
                .ToDictionary(g => g.Key, g => g.Sum(r => r.Hours));
        }

        public Dictionary<string, int> GetHoursByPosition(List<UniversityRecord> records)
        {
            return records
                .GroupBy(r => string.IsNullOrWhiteSpace(r.TeacherPosition) ? "Не указана" : r.TeacherPosition)
                .ToDictionary(g => g.Key, g => g.Sum(r => r.Hours));
        }

        public Dictionary<string, int> GetCountByControlType(List<UniversityRecord> records)
        {
            return records
                .GroupBy(r => string.IsNullOrWhiteSpace(r.ControlType) ? "Не указан" : r.ControlType)
                .ToDictionary(g => g.Key, g => g.Count());
        }
    }
}
