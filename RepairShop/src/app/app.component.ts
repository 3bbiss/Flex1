import { Component } from '@angular/core';
import { Instrument } from './instrument';
import { InstrumentService } from './instrument.service';
import { RepairOrder } from './repair-order';
import { RepairOrderService } from './repair-order.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'RepairShop';

  constructor(private InstSrv: InstrumentService, private OrderSrv: RepairOrderService){}

  save(){
    /* this.OrderSrv.add(
      (result: RepairOrder) => {
        alert(`Saved! The new id is ${result.id}`);
      },

      this.newOrder
    ); */
  }

}
