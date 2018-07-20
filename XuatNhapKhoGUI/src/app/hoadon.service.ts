import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { AuthService } from './auth.service';

@Injectable({
  providedIn: 'root'
})
export class HoadonService {

  constructor(private http: HttpClient, private authService: AuthService) { }

  InserListHoaDon(listHoaDon) {
    return this.http.post(this.authService.getBaseAPI() + 'ChiTietHoaDon/InsertChiTietHoaDon', listHoaDon);
  }
  GetAllHoaDon() {
    return this.http.get(this.authService.getBaseAPI() + 'QuanLyHoaDon/GetAll');
  }
}
