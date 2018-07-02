import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class SanphamService {

  constructor(private http: HttpClient) { }
  GetAll() {
    return this.http.get('http://localhost:54198/SanPham/GetAll');
  }
}
