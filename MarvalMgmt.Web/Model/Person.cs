namespace MarvalMgmt.Web.Model
{
    public class Person
    {
        public long Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string SurName { get; set; } = string.Empty;
        public int Age { get; set; }
        public string Sex { get; set; } = string.Empty;
        public string Mobile { get; set; } = string.Empty;
        public bool Active { get; set; }
    }
}