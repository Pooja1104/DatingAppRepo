import {NgModule} from '@angular/core';

import {BrowserModule} from "@angular/platform-browser"
import {FormsModule} from "@angular/forms"
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HttpClientModule } from '@angular/common/http';
import { AuthService } from './_services/auth.service';
import { ErrorInterceptorProvider } from './_services/error.interceptor';
import {BsDropdownModule} from 'ngx-bootstrap/dropdown';
import { RouterModule } from '@angular/router';
import { appRoutes } from './routes';

import {AppComponent} from "../app/app.component"
import {NavComponent} from "../app/nav/nav.component"
import {HomeComponent} from "../app/home/home.component"
import {RegisterComponent} from "../app/register/register.component"
import {ListsComponent} from "../app/lists/lists.component"
import {MemberListComponent} from "../app/member-list/member-list.component"
import {MessagesComponent} from '../app/messages/messages.component'



@NgModule(
    {
    declarations:[
        AppComponent,
        NavComponent,
        HomeComponent,
        RegisterComponent,
        ListsComponent,
        MemberListComponent,
        MessagesComponent
        ],
    bootstrap:[AppComponent],
    imports:[
        BrowserModule,
        FormsModule,
        HttpClientModule,
        BsDropdownModule.forRoot(),
        BrowserAnimationsModule,
        RouterModule.forRoot(appRoutes)
        ],
        providers:[
        AuthService,
        ErrorInterceptorProvider
    ]
    }
)
export class AppModule
{

}