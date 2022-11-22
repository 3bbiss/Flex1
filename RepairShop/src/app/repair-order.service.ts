import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { RepairOrder } from './repair-order';
import { ShortRepairList } from './short-repair-list';

@Injectable({
  providedIn: 'root'
})
export class RepairOrderService {

	getOne(cb: any, id: any) {
		this.http.get<RepairOrder>(`https://localhost:5001/repairorder/${id}`).subscribe(cb);
	}

	add(cb: any, order: RepairOrder) {
		this.http.post<RepairOrder>('https://localhost:5001/repairorder', order).subscribe(cb);
	}

	delete(cb: any, id: any) {
		this.http.delete(`https://localhost:5001/repairorder/${id}`).subscribe(cb);
	}

	update(cb: any, order: RepairOrder) {
		this.http.put<RepairOrder>('https://localhost:5001/repairorder', order).subscribe(cb);
	}

	shortList(cb: any) {
		this.http.get<ShortRepairList[]>('https://localhost:5001/repairorder/short').subscribe(cb);
	}
	
	constructor(private http: HttpClient) { }
}
