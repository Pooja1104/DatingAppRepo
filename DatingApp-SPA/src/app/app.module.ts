import {NgModule} from '@angular/core';

import {BrowserModule} from "@angular/platform-browser"
import {FormsModule} from "@angular/forms"

import {AppComponent} from "../app/app.component"
import {ValueComponent} from "../app/value/value.component"
import {NavComponent} from "../app/nav/nav.component"
import {HomeComponent} from "../app/home/home.component"
import {RegisterComponent} from "../app/register/register.component"
import { HttpClientModule } from '@angular/common/http';
import { AuthService } from './_services/auth.service';
@NgModule(
    {
    declarations:[AppComponent,ValueComponent,NavComponent,HomeComponent,RegisterComponent],
    bootstrap:[AppComponent],
    imports:[BrowserModule,FormsModule,HttpClientModule],
    providers:[
        AuthService
    ]
    }
)
export class AppModule
{

}