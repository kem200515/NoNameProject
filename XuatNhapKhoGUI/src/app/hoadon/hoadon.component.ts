import { Component, OnInit } from '@angular/core';
import { SanphamService } from '../sanpham.service';

@Component({
  selector: 'app-hoadon',
  templateUrl: './hoadon.component.html',
  styleUrls: ['./hoadon.component.css']
})
export class HoadonComponent implements OnInit {

  constructor(private sanPhamService: SanphamService) { }
  public listSanPham;
  ngOnInit() {
    this.sanPhamService.GetAll().subscribe(data => {
      this.listSanPham = data;
    });
    console.log(this.listSanPham);
  }

}
