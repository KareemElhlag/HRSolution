namespace HR.Models.DataCore
{
    public class CampInformation
    {
        public int id { get; set; }
        public string LogoPath { get; set; }
        public string name { get; set; }
        public string description { get; set; }

        public DateTime CreateYears { get; set; }
        public int Commercial_register { get; set; }
        public int Tax_number { get; }

    }
}
