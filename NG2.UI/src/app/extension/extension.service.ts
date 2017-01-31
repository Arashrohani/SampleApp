import { Injectable, OnInit }     from '@angular/core';
import { Http, Response } from '@angular/http';
import { Extension, IResult }           from './../shared/models';
import { Observable }     from 'rxjs/Observable';

@Injectable()
export class ExtensionService {
  private heroesUrl = 'http://localhost:1327/api/webclient';  // URL to web API
  

  constructor (
    private http: Http

    ) {}

  NgOnInit() {

  }

  getExtensions (): Observable<Extension[]> {
    return  this.http.get(this.heroesUrl)
                    .map(this.extractData)
                    .catch(this.handleError);
  }

  updateExtension (extension: Extension): Observable<Response>{
    return this.http.put(this.heroesUrl,extension)
                    .catch(this.handleError);
  }
  
  private extractData(res: Response) {
    let body = res.json();
    let test = <IResult>body.data;
    console.log("Body: ", body);
    
    return body.data.Model || { };
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