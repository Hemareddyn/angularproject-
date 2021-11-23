import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from './components/login/login.component';
import { SignupComponent } from './components/signup/signup.component';
import {ForgotpasswordComponent} from './components/forgotpassword/forgotpassword.component';
import { UserpostComponent} from './components/userpost/userpost.component';
const routes: Routes = [
  {path:'' , redirectTo: 'login' ,pathMatch: 'full'},
  {path: 'login', component : LoginComponent},
  {path: 'signup', component : SignupComponent},
  {path: 'forgotpassword', component : ForgotpasswordComponent},
  {path: 'userpost', component : UserpostComponent}

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
