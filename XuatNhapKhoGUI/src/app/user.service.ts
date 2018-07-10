import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor(private http: HttpClient) { }

  getUserById(userId: string) {
    return this.http.get('http://118.68.215.45:12345/User/GetUserById');
  }
}


