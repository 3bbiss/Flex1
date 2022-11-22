import { TestBed } from '@angular/core/testing';

import { ShortRepairListService } from './short-repair-list.service';

describe('ShortRepairListService', () => {
  let service: ShortRepairListService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ShortRepairListService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
