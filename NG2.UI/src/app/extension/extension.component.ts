import { Component, OnInit } from '@angular/core';
import { ExtensionService } from './extension.service';
import { Extension }           from './../shared/models';

@Component({
  templateUrl: './extension.component.template.html' 
})
export class ExtensionsComponent implements OnInit {
  extensions: Extension[];
  errorMessage: string;
  updateMessage: string;

  constructor(
    private service: ExtensionService
  ) {  }

  ngOnInit() {
      this.service.getExtensions()
        .subscribe(
         exts => this.extensions = <Extension[]>exts,
         error =>  this.errorMessage = <any>error);
  }
  get diagnostic() { return JSON.stringify(this.extensions); }

  updateExtension (ext: Extension) {
    if (!ext) { return; }
    this.service.updateExtension(ext)
                     .subscribe(
                       updateMsg  => this.updateMessage = updateMsg.toString(),
                       error =>  this.errorMessage = <any>error);
  }
 }