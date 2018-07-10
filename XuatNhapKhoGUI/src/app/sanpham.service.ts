import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class SanphamService {

  constructor(private http: HttpClient) { }
  GetAll() {
    return this.http.get('http://118.68.215.45:12345/SanPham/GetAll');
  }
}
