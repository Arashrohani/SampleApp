namespace SampleApp.Core.Entities
{
    public class Address
    {
        public string StreetNumber { get; set; }
        public string StreetName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public Country Country { get; set; }
    }
}