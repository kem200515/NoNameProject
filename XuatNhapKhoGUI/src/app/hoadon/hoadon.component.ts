import { Component, OnInit } from '@angular/core';
import { SanphamService } from '../sanpham.service';
import { HoadonService } from '../hoadon.service';

@Component({
  selector: 'app-hoadon',
  templateUrl: './hoadon.component.html',
  styleUrls: ['./hoadon.component.css']
})
export class HoadonComponent implements OnInit {

  constructor(private sanPhamService: SanphamService, private hoaDonService: HoadonService) { }
  public listSanPham;
  hoadon = {
    TenHang: '',
    ChieuDai: '',
    Kho: '',
    SoTam: '',
    Som2: '',
    DonGia: '',
    ThanhTien: ''
  };
  listHoaDon = [];
  ngOnInit() {
    this.sanPhamService.GetAll().subscribe(data => {
      this.listSanPham = data;
    });
    console.log(this.listSanPham);
  }
  public ThemHoaDon(hoadon) {
    const a = Object.assign({}, hoadon);
    this.listHoaDon.push(a);
    console.log(this.listHoaDon);
  }
  public ThanhToan() {
    this.hoaDonService.InserListHoaDon(this.listHoaDon).subscribe(data => {
      console.log(data);
    });
  }
  public SelectedSanPham(selectElem) {
    this.hoadon.TenHang = selectElem;
    console.log(selectElem.TenHang);
  }
}
