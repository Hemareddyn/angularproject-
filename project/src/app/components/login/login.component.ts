import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ApiService } from '../../shared/api.service';
import { UserModel } from '../../shared/model/user.model';
import { HttpClient } from '@angular/common/http';


@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

 
  public data = {
    username: '',
    email: '',
    
    
  };
  valid = {
   
    email: true,
    password: true,

  };

  public loginObj = new UserModel();
  constructor(
    private http: HttpClient,
    private router: Router,
    private api: ApiService
  ) {}

  ngOnInit(): void {}
 Login() {
    const formData = new FormData();
    formData.append('UserName', this.data.username);
    formData.append('Emailid', this.data.email);
    // formData.append('CreatePassword', this.data.password);
    // formData.append('Name', this.data.username);

    console.log(this.loginObj);
    this.api.Login(formData).subscribe((res) => {
      alert('success');
    });
  }
}
