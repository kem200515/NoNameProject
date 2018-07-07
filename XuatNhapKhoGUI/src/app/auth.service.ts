import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';


@Injectable({
  providedIn: 'root'
})
export class AuthService {
  private loggedInStatus = JSON.parse(localStorage.getItem('userId')) || false;
  private userId = '';
  constructor(private http: HttpClient) { }

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
    return this.http.post('http://localhost:54198/User/Login', userModel
    );
  }
}
