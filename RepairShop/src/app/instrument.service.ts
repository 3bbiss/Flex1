import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Instrument } from './instrument';

@Injectable({
  providedIn: 'root'
})
export class InstrumentService {

  constructor(private http: HttpClient) { }

  getAll(cb: any){
    this.http.get<Instrument>('https://localhost:5001/instrument').subscribe(cb);
  }

}
