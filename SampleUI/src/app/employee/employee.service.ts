import { Injectable, OnInit }     from '@angular/core';
import { Http, Response } from '@angular/http';
import { Employee, IResult }           from './../shared/models';
import { Observable }     from 'rxjs/Observable';

@Injectable()
export class EmployeeService {
  private apiUrl = 'http://localhost:5000/api/employee';  // URL to web API
  

  constructor (
    private http: Http

    ) {}

  NgOnInit() {

  }

  getEmployees (): Observable<Employee[]> {
    return  this.http.get(this.apiUrl)
                    .map(this.extractData)
                    .catch(this.handleError);
  }

  updateEmployee (employee: Employee): Observable<Response>{
    return this.http.put(this.apiUrl,employee)
                    .catch(this.handleError);
  }
  
 private extractData(res: Response) {
    let body = res.json();
    let test = <Employee>body.data;

    return body.data || { };
  }
  

  private handleError (error: Response | any) {
    //TODO: inject a remote logging service
    console.error(error);
    let errMsg: string;
    if (error instanceof Response) {
      const body = error.json() || '';
      const err = body.error || JSON.stringify(body);
      errMsg = `${error.status} - ${error.statusText || ''} ${err}`;
    } else {
      errMsg = error.message ? error.message : error.toString();
    }
    console.error(errMsg);
    return Observable.throw(errMsg);
  }
}