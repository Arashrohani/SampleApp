export class Employee {
  constructor(
    public FirstName: string,
    public LastName: string,
    public EmployeeNumber: string,
    public HomeAddress: Address,
    public MailingAddress: Address,
    public Department: Department
  ) {}
}


export class Extension {
  constructor(
    public UserId: number,
    public GroupId: number,
    public Cacheable: string,
    public Id: number,
    public Mailbox: number
  ) {}
}


export class Department {
  constructor(
    public Name: string,
    public Division: string
  ) {}
}

export class Address {
  constructor(
    public StreetNumber: string,
    public StreetName: string,
    public Address1: string,
    public Address2: string,
    public City: string,
    public State: string,
    public Zip: string
  ) {}
}

export interface IResult {

  ResultId: number;
  WasSuccessful: string;
  Message: string;

}
