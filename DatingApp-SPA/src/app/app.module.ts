import {NgModule} from '@angular/core';

import {BrowserModule} from "@angular/platform-browser"
import {FormsModule} from "@angular/forms"
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import {AppComponent} from "../app/app.component"

import {NavComponent} from "../app/nav/nav.component"
import {HomeComponent} from "../app/home/home.component"
import {RegisterComponent} from "../app/register/register.component"
import { HttpClientModule } from '@angular/common/http';
import { AuthService } from './_services/auth.service';
import { ErrorInterceptorProvider } from './_services/error.interceptor';
import {BsDropdownModule} from 'ngx-bootstrap/dropdown';
@NgModule(
    {
    declarations:[AppComponent,NavComponent,HomeComponent,RegisterComponent],
    bootstrap:[AppComponent],
    imports:[BrowserModule,FormsModule,HttpClientModule,BsDropdownModule.forRoot(),BrowserAnimationsModule],
    providers:[
        AuthService,
        ErrorInterceptorProvider
    ]
    }
)
export class AppModule
{

}