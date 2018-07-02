import { TestBed, inject } from '@angular/core/testing';

import { HoadonService } from './hoadon.service';

describe('HoadonService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [HoadonService]
    });
  });

  it('should be created', inject([HoadonService], (service: HoadonService) => {
    expect(service).toBeTruthy();
  }));
});
