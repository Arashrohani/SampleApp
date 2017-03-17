import { Component } from '@angular/core';

//import './rxjs-operators';
//import 'rxjs/Rx'; //This will add EVERYTHING 

import 'rxjs/add/operator/catch';
import 'rxjs/add/operator/map';

//import 'rxjs/add/operator/toPromise';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'app works!';
}
