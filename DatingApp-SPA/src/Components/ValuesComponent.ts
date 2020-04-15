import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'angular-ui',
  templateUrl: './values-component.component.html',
  styleUrls: ['./values-component.component.css']
})
export class ValuesComponent implements OnInit {
values:any;
  constructor(private http:HttpClient) {

   }

  ngOnInit(): void {
    this.getValues();
  }
getValues()
{
  this.http.get('http://localhost:5000/api/values').subscribe(response=>{
this.values=response;
  },error=>{console.log(error)});
}
}
