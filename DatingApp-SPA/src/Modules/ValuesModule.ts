import {NgModule} from '@angular/core';

import {BrowserModule} from "@angular/platform-browser"
import {FormsModule} from "@angular/forms"
import {HttpClientModule} from "@angular/common/http"

import {ValuesComponent} from "../Components/ValuesComponent"
@NgModule(
    {
        declarations:[ValuesComponent],
bootstrap:[ValuesComponent],
imports:[BrowserModule,FormsModule,HttpClientModule]
    }
)
export class ValuesModule
{

}