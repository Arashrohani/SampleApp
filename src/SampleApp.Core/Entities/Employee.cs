namespace SampleApp.Core.Entities
{
    public class Employee : BaseEntity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EmployeeNumber { get; set; }

        public Address HomeAddress { get; set; }

        public Address MailingAddress { get; set; }

        public Department Department { get; set; }
    }
}