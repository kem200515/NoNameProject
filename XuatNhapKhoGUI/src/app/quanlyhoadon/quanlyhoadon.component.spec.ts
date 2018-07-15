import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { QuanlyhoadonComponent } from './quanlyhoadon.component';

describe('QuanlyhoadonComponent', () => {
  let component: QuanlyhoadonComponent;
  let fixture: ComponentFixture<QuanlyhoadonComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ QuanlyhoadonComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(QuanlyhoadonComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
