import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { AuthService } from './auth.service';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor(private http: HttpClient, private authService: AuthService) { }

  getUserById(userId: string) {
    return this.http.get(this.authService.getBaseAPI() + 'User/GetUserById');
  }
}


