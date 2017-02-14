namespace SampleApp.Core.Entities
{
    public class Country : BaseEntity
    {
        public string Name { get; set; }

        public string Abbrv { get; set; }

        public string Code { get; set; }

        public string Iso { get; set; }
    }
}