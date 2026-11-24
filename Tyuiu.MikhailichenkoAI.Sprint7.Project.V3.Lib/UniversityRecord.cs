namespace Tyuiu.MikhailichenkoAI.Sprint7.Project.V3.Lib
{
    public class UniversityRecord
    {
        public int TeacherId { get; set; }
        public string TeacherFullName { get; set; } = string.Empty;
        public string TeacherAddress { get; set; } = string.Empty;
        public string TeacherPosition { get; set; } = string.Empty;
        public string SubjectCode { get; set; } = string.Empty;
        public string SubjectName { get; set; } = string.Empty;
        public int Hours { get; set; }
        public string ControlType { get; set; } = string.Empty;
        public string SubjectSection { get; set; } = string.Empty;
        public string DepartmentCode { get; set; } = string.Empty;
        public string DepartmentName { get; set; } = string.Empty;
        public int HeadTeacherId { get; set; }
        public string Classroom { get; set; } = string.Empty;
    }
}
