import { Component, OnInit } from '@angular/core';
import { RepairOrder } from '../repair-order';
import { RepairOrderService } from '../repair-order.service';

@Component({
  selector: 'app-bookmarks',
  templateUrl: './bookmarks.component.html',
  styleUrls: ['./bookmarks.component.css']
})
export class BookmarksComponent implements OnInit {

  TheList: RepairOrder[] = [];

  constructor(private OrderSrv: RepairOrderService) {
    OrderSrv.bookmarks(
      (result: RepairOrder[]) => {
        this.TheList = result;
      }
    );
  }

  ngOnInit(): void {
  }

}
