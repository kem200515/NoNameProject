import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { AppComponent } from './app.component';
import { LoginComponent } from './login/login.component';
import { AdminComponent } from './admin/admin.component';
import { HomeComponent } from './home/home.component';
import { AuthGuard } from './auth.guard';
import { UserService } from './user.service';
import { AuthService } from './auth.service';
import { HoadonComponent } from './hoadon/hoadon.component';
import { NhaphangComponent } from './nhaphang/nhaphang.component';
import { QuanlysanphamComponent } from './quanlysanpham/quanlysanpham.component';
import { HoadonService } from './hoadon.service';
import { SanphamService } from './sanpham.service';
import {FormsModule} from '@angular/forms';

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    AdminComponent,
    HomeComponent,
    HoadonComponent,
    NhaphangComponent,
    QuanlysanphamComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      {
        path: 'home',
        component: HomeComponent
      },
      {
        path: 'admin',
        component: AdminComponent,
        canActivate: [AuthGuard]
      },
      {
        path: 'login',
        component: LoginComponent
      },
      {
        path: '',
        component: LoginComponent
      },
      {
        path: 'hoadon',
        component: HoadonComponent
      }

    ])
  ],
  providers: [AuthService, UserService, AuthGuard, HoadonService, SanphamService],
  bootstrap: [AppComponent]
})
export class AppModule { }
