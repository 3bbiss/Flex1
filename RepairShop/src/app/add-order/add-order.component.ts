import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { Instrument } from '../instrument';
import { InstrumentService } from '../instrument.service';
import { RepairOrder } from '../repair-order';

@Component({
  selector: 'app-add-order',
  templateUrl: './add-order.component.html',
  styleUrls: ['./add-order.component.css']
})
export class AddOrderComponent implements OnInit {

  constructor(private InstSrv: InstrumentService) {
    InstSrv.getAll(
      (result: Instrument[]) => {
        this.TheInstruments = result;
      }
    );
   }

   newOrder: RepairOrder = {
    id: 0, customer: '', instrument_id: 0,
    status: 0, price: 0, notes: '', bookmark: false
  };

   TheInstruments: Instrument[] = [];

  ngOnInit(): void {
  }

  
  @Output() save: EventEmitter<RepairOrder> = new EventEmitter<RepairOrder>();

  saveIt(){
    this.save.emit(this.newOrder);
  }

}
