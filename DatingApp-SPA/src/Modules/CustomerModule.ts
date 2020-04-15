import {NgModule} from '@angular/core';

import {BrowserModule} from "@angular/platform-browser"
import {FormsModule} from "@angular/forms"

import {CustomerComponent} from "../Components/CustomerComponent"

@NgModule(
    {
        declarations:[CustomerComponent],
bootstrap:[CustomerComponent],
imports:[BrowserModule,FormsModule]
    }
)
export class CustomerModule
{

}