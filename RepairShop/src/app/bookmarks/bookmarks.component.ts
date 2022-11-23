import { Component, OnInit } from '@angular/core';
import { RepairOrder } from '../repair-order';
import { RepairOrderService } from '../repair-order.service';
import { ShortRepairList } from '../short-repair-list';

@Component({
  selector: 'app-bookmarks',
  templateUrl: './bookmarks.component.html',
  styleUrls: ['./bookmarks.component.css']
})
export class BookmarksComponent implements OnInit {

  TheList: ShortRepairList[] = [];

  constructor(private OrderSrv: RepairOrderService) {
    OrderSrv.bookmarks(
      (result: ShortRepairList[]) => {
        this.TheList = result;
      }
    );
  }

  ngOnInit(): void {
  }

}
