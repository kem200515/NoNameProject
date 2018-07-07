import { TestBed, inject } from '@angular/core/testing';

import { SanphamService } from './sanpham.service';

describe('SanphamService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [SanphamService]
    });
  });

  it('should be created', inject([SanphamService], (service: SanphamService) => {
    expect(service).toBeTruthy();
  }));
});
