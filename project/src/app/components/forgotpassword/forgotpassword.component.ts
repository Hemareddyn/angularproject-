import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ApiService } from '../../shared/api.service';
import { UserModel } from '../../shared/model/user.model';
import { HttpClient } from '@angular/common/http';


@Component({
  selector: 'app-forgotpassword',
  templateUrl: './forgotpassword.component.html',
  styleUrls: ['./forgotpassword.component.css']
})
export class ForgotPasswordComponent implements OnInit {
  public data = {
    forgotPassword: '',
  };
  valid = {
    
    forgotpassword: true,
  };

  public forgotpasswordObj = new UserModel();
  constructor(
    private http: HttpClient,
    private router: Router,
    private api: ApiService
  ) {}
ngOnInit(): void {} 

   Register() {
    const formData = new FormData();
    // formData.append('UserName', this.data.username);
    // formData.append('Emailid', this.data.email);
    formData.append('forgotPassword', this.data.forgotPassword);
    // formData.append('Name', this.data.username);

    console.log(this.forgotpasswordObj);
    this.api.ForgotPassword(formData).subscribe((res) => {
      alert('success');
    });
  }
 

}
