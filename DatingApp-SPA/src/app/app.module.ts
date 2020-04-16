import {NgModule} from '@angular/core';

import {BrowserModule} from "@angular/platform-browser"
import {FormsModule} from "@angular/forms"

import {AppComponent} from "../app/app.component"
import {ValueComponent} from "../app/value/value.component"
import {NavComponent} from "../app/nav/nav.component"
import { HttpClientModule } from '@angular/common/http';
@NgModule(
    {
    declarations:[AppComponent,ValueComponent,NavComponent],
    bootstrap:[AppComponent],
    imports:[BrowserModule,FormsModule,HttpClientModule]
    }
)
export class AppModule
{

}