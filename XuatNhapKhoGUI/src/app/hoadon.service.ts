import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class HoadonService {

  constructor(private http: HttpClient) { }

  InserListHoaDon(listHoaDon) {
    return this.http.post('http://localhost:54198/User/Login', listHoaDon);
  }
}
