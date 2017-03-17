import { Component, OnInit } from '@angular/core';
import { EmployeeService } from './employee.service';
import { Employee }           from './../shared/models';

@Component({
  templateUrl: './employee.component.template.html' 
})
export class EmployeeComponent implements OnInit {
  employees: Employee[];
  errorMessage: string;
  updateMessage: string;

  constructor(
    private service: EmployeeService
  ) {  }

  ngOnInit() {
      this.service.getEmployees()
        .subscribe(
         emps => this.employees = <Employee[]>emps,
         error =>  this.errorMessage = <any>error);
  }
  get diagnostic() { return JSON.stringify(this.employees); }

  updateExtension (emp: Employee) {
    if (!emp) { return; }
    this.service.updateEmployee(emp)
                     .subscribe(
                       updateMsg  => this.updateMessage = updateMsg.toString(),
                       error =>  this.errorMessage = <any>error);
  }
 }