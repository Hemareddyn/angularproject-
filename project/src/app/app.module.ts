import {  NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule, ReactiveFormsModule } from '@angular/forms'; 
import { CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';


import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoginComponent } from './components/login/login.component';
import { SignupComponent } from './components/signup/signup.component';
import { NavbarComponent } from './components/navbar/navbar.component';
import { ForgotPasswordComponent } from './components/forgotpassword/forgotpassword.component';
import { UserpostComponent } from './components/userpost/userpost.component';
// import { SidenavbarComponent } from './components/sidenavbar/sidenavbar.component';

import { MatCardModule } from '@angular/material/card';
import { MatButtonModule } from '@angular/material/button';
import { MatInputModule } from '@angular/material/input';
import { MatIconModule } from '@angular/material/icon';
// import { SidenavbarComponent } from './components/sidenavbar/sidenavbar.component';
import { MatSidenavModule } from '@angular/material/sidenav';
import {MatListModule} from '@angular/material/list';
import { TagsComponent } from './components/tags/tags.component';
import { UsersComponent } from './components/users/users.component';
import { HomepageComponent } from './components/homepage/homepage.component';
import { HttpClientModule } from "@angular/common/http";
import { ApiService } from './shared/api.service';


@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    SignupComponent,
    NavbarComponent,
    ForgotPasswordComponent,
    UserpostComponent,
    // SidenavbarComponent,
    TagsComponent,
    UsersComponent,
    HomepageComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,

    MatButtonModule,
    MatCardModule,
    MatInputModule,
    MatIconModule,
    MatSidenavModule,
    MatListModule


    

  ],
  providers: [ApiService],
  schemas : [ CUSTOM_ELEMENTS_SCHEMA ],
  bootstrap: [AppComponent]
})
export class AppModule { }
