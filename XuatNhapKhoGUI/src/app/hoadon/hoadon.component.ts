import { Component, OnInit } from '@angular/core';
import { SanphamService } from '../sanpham.service';
import { HoadonService } from '../hoadon.service';
import { forEach } from '@angular/router/src/utils/collection';
import { variable } from '@angular/compiler/src/output/output_ast';

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
    ChieuDai: 0,
    Kho: 0,
    SoTam: 0,
    Som2: 0,
    DonGia: 0,
    ThanhTien: 0,
    SanPhamId: '',
  };
  sanpham;
  listHoaDon = [];
  thanhToanHoaDon = {
    NgayThucHienTimestamp: Date.now(),
    NgayThucHien: new Date(),
    listHoaDon: [],
    TongTien: 0
  };
  ngOnInit() {
    this.sanPhamService.GetAll().subscribe(data => {
      this.listSanPham = data;
    });
    console.log(this.listSanPham);
  }
  public ThemHoaDon(hoadon) {
    const clone = Object.assign({}, hoadon);
    this.listHoaDon.push(clone);
    this.thanhToanHoaDon.TongTien = 0;
    for (let i = 0; i < this.listHoaDon.length; i++) {
      this.thanhToanHoaDon.TongTien = this.listHoaDon[i].ThanhTien + this.thanhToanHoaDon.TongTien;
    }

    console.log(this.thanhToanHoaDon.TongTien);
  }
  public ThanhToan() {
    this.thanhToanHoaDon.listHoaDon = this.listHoaDon;
    console.log(this.thanhToanHoaDon);
    this.hoaDonService.InserListHoaDon(this.thanhToanHoaDon).subscribe(data => {
      console.log(data);
    });
  }
  public ChangeSanPham() {
    this.hoadon.TenHang = this.sanpham.TenHang;
    this.hoadon.SanPhamId = this.sanpham.Id;
    this.hoadon.Kho = this.sanpham.Kho;
    this.hoadon.DonGia = this.sanpham.DonGia;
    this.ChangeThongSo();
    console.log(this.sanpham);
  }
  public ChangeThongSo() {
    this.hoadon.Som2 = this.hoadon.ChieuDai * this.hoadon.Kho * this.hoadon.SoTam;
    this.hoadon.ThanhTien = this.hoadon.Som2 * this.hoadon.DonGia;

  }
}
