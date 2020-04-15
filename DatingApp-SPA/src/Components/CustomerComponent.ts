import {Customer} from "../Model/Customer"
import {Component} from "@angular/core"

@Component(
    {
        selector:"angular-ui",
        templateUrl:"../UI/Customer.html"
    }
)

export class CustomerComponent
{
    custObj:Customer=new Customer();
}