import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class HoadonService {

  constructor(private http: HttpClient) { }

  InserListHoaDon(listHoaDon) {
    return this.http.post('http://118.68.215.45:12345/ChiTietHoaDon/InsertChiTietHoaDon', listHoaDon);
  }
}
