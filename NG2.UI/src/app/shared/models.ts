export class Extension {
  constructor(
    public UserId: number,
    public GroupId: number,
    public Cacheable: string, 
    public Id: number,
    public Mailbox: number
    ) { }
}

export interface IResult {
  
     ResultId: number; 
     WasSuccessful: string;
     Message: string;

}