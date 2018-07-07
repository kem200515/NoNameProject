import { Component, OnInit } from '@angular/core';


@Component({
  selector: 'app-admin',
  templateUrl: './admin.component.html',
  styleUrls: ['./admin.component.css']
})
export class AdminComponent implements OnInit {

  public type = 1;
  constructor() { }

  ngOnInit() {

  }

  ChangeType(a) {
    this.type = a;
  }
}
