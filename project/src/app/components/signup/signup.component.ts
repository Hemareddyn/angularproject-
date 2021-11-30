import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ApiService } from '../../shared/api.service';
import { UserModel } from '../../shared/model/user.model';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-signup',
  templateUrl: './signup.component.html',
  styleUrls: ['./signup.component.css'],
})
export class SignupComponent implements OnInit {
  public data = {
    username: '',
    email: '',
    password: '',
    confirmPassword: '',
  };
  valid = {
    username: true,
    email: true,
    password: true,
  };

  public registerObj = new UserModel();
  constructor(
    private http: HttpClient,
    private router: Router,
<<<<<<< HEAD
    private api: ApiService
=======
    private api: ApiService,
>>>>>>> 544b4bd65583c329c8335577737c56d877a4fc10
  ) {}

  ngOnInit(): void {}

  validate(type: string): void {
    const usernamePattern = /^[\w-.]*$/;
    const emailPattern = /\S+@\S+\.\S+/;

    if (type === 'username') {
      if (this.data.username.length < 5) {
        this.valid.username = false;
      } else {
        this.valid.username = usernamePattern.test(this.data.username);
      }
    } else if (type === 'email') {
      this.valid.email = emailPattern.test(this.data.email);
    } else if (type === ('confirmPassword' || 'password')) {
      if (this.data.password !== this.data.confirmPassword) {
        this.valid.password = false;
      } else {
        this.valid.password = true;
      }
    }
  }

  onKey(event: any, type: string) {
    if (type === 'username') {
      this.data.username = event.target.value;
    } else if (type === 'email') {
      this.data.email = event.target.value;
    } else if (type === 'password') {
      this.data.password = event.target.value;
    } else if (type === 'confirmPassword') {
      this.data.confirmPassword = event.target.value;
    }
    this.validate(type);
  }

  Register() {
    const formData = new FormData();
    formData.append('UserName', this.data.username);
    formData.append('Emailid', this.data.email);
    formData.append('CreatePassword', this.data.password);
    formData.append('Name', this.data.username);

    console.log(this.registerObj);
    this.api.Register(formData).subscribe((res) => {
      alert('success');
    });
  }
<<<<<<< HEAD
}
=======
}
>>>>>>> 544b4bd65583c329c8335577737c56d877a4fc10
