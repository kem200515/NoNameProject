import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { AuthService } from './auth.service';

@Injectable({
  providedIn: 'root'
})
export class SanphamService {

  constructor(private http: HttpClient, private authService: AuthService) { }
  GetAll() {
    return this.http.get(this.authService.getBaseAPI() + 'SanPham/GetAll');
  }
}
