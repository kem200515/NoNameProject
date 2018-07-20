import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';


@Injectable({
  providedIn: 'root'
})
export class AuthService {
  private loggedInStatus = JSON.parse(localStorage.getItem('userId')) || false;
  private baseAPI = 'http://xuatnhapkho.hopto.org:12345/';
  // private baseAPI = 'http://localhost:54198/';
  private userId = '';
  constructor(private http: HttpClient) { }

  getBaseAPI() {
    return this.baseAPI;
  }
  setLoggedIn(value: boolean) {
    this.loggedInStatus = value;
    localStorage.setItem('userId', 'true');
  }

  get isLoggedIn() {
    return JSON.parse(localStorage.getItem('userId') || this.loggedInStatus);
  }
  setUserId(userId: string) {
    this.userId = userId;
  }
  getUserId() {
    return this.userId;
  }
  Login(username, password) {
    const userModel = {
      Username: username,
      Password: password
    };
    return this.http.post(this.baseAPI + 'User/Login', userModel
    );
  }
}
