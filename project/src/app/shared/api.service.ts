import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import { pipe } from 'rxjs';
import {map} from 'rxjs/operators'
@Injectable({
  providedIn: 'root'
})
export class ApiService{

  readonly APIUrl = "https://localhost:44346//api/UserController/InsertUserDetailsIntoSignUpForm";

  constructor(private _http : HttpClient) { }

 
  Register(empObj : any){
    console.log("empobj.....",empObj);
    //return this._http.post<any>(this.loginAPIUrl+"signup",empObj)
    return this._http.post<any>(this.APIUrl,empObj)
  }
  Login(empObj:any){
    console.log("empobj.....",empObj);
    return this._http.get<any>(this.APIUrl+'/Login',empObj)
  }
  ForgotPassword(empObj:any){
    console.log("empobj.....",empObj);
    return this._http.get<any>(this.APIUrl+'/ForgotPassword',empObj)
  }


//   Booking(empObj : any){
//     console.log("empobj.....",empObj); 
//     return this._http.post<any>(this.APIUrl + '/TicketBooking',empObj)
//   }
  
}