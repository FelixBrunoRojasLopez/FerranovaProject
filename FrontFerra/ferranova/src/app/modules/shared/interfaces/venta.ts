import { DetalleVenta } from "./detalle-venta";

export interface Venta {
    idVenta         : number;
    numeroDocumento : string;
    idMetodoPago    : number;
    tipoPago        : string;
    fechaRegistro   : Date;
    total           : number;
    detalleVenta    : DetalleVenta;


}
