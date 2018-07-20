import { Component, OnInit } from '@angular/core';
import { HoadonService } from '../hoadon.service';

@Component({
  selector: 'app-quanlyhoadon',
  templateUrl: './quanlyhoadon.component.html',
  styleUrls: ['./quanlyhoadon.component.css']
})
export class QuanlyhoadonComponent implements OnInit {

  constructor(private hoadonService: HoadonService) { }

  private listQuanLyHoaDon;
  ngOnInit() {
    this.hoadonService.GetAllHoaDon().subscribe(data => {
      this.listQuanLyHoaDon = data;
    });
  }

}
