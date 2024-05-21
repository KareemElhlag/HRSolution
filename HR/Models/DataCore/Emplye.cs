namespace HR.Models.DataCore
{
    public class Emplye
    {
        public int Id { get; set; }
        public string F_Name { get; set; }
        public string Sec_Name { get; set; }
        public string Thr_Name { get; set; }
        public string L_Name { get; set; }
        public string UserName { get; set; }
        public required DepartmentInformations departmentName { get; set; }
        public DateTime JoinDate { get; set; }
        public bool MaritalStatus { get; set; }
        public bool GenderStatus { get; set; }
        public int RoleAccess { get; set; }
        public string img_Path { get; set; }
        public int ExWorkYears { get; set; }
        public int EmplyeCode { get; set; }
        public string BloodGroub { get; set; }
        public string Nationalty { get; set; }
        public string Regle { get; set; }







    }
}
