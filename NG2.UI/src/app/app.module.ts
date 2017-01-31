import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { RouterModule } from '@angular/router';
import { AppRoutingModule }     from './app-routing.module';

import { AppComponent } from './app.component';

import { ExtensionsComponent } from './extension/extension.component';
import { ExtensionService } from './extension/extension.service';

import { IdentityComponent } from './identity/identity.component';
import {HomeComponent} from './home/home.component';

@NgModule({
  imports: [
    BrowserModule,
    FormsModule,
    HttpModule,
    AppRoutingModule
    
  ],
  declarations: [
    AppComponent,
    IdentityComponent,
    ExtensionsComponent,
    HomeComponent
  ],
  providers: [ExtensionService],
  bootstrap: [AppComponent]
})
export class AppModule { }
