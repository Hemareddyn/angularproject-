import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from './components/login/login.component';
import { SignupComponent } from './components/signup/signup.component';
import {ForgotpasswordComponent} from './components/forgotpassword/forgotpassword.component';
import { UserpostComponent} from './components/userpost/userpost.component';
import { SidenavbarComponent} from './components/sidenavbar/sidenavbar.component';
import {TagsComponent} from './components/tags/tags.component';
import {UsersComponent} from './components/users/users.component';



const routes: Routes = [
  {path:'' , redirectTo: 'login' ,pathMatch: 'full'},
  {path: 'login', component : LoginComponent},
  {path: 'signup', component : SignupComponent},
  {path: 'forgotpassword', component : ForgotpasswordComponent},
  {path: 'questions', component : UserpostComponent},
  {path: 'sidenavbar', component : SidenavbarComponent},
  {path: 'tags' ,component : TagsComponent},
  {path: 'users' ,component :UsersComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
