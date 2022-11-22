export interface RepairOrder {
    id: number,
    customer: string,
    instrument_id: number,
    status: number,
    price: number,
    notes: string,
    bookmark: boolean
}
