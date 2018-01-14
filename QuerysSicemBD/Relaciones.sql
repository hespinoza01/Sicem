use sicem
	go

alter table RH_Empleado
add foreign key (DepartamentoID) references RH_Departamentos(ID)
	go

alter table Producto
add foreign key (CategoriaID) references Categoria(ID)
	go

alter table HistorialPrecioProducto
add foreign key (ProductoID) references Producto(ID)
	go

alter table HistorialCostoProducto
add foreign key (ProductoID) references Producto(ID)
	go

alter table Inventario
add foreign key (ProductoID) references Producto(ID)
	go

alter table Inventario
add foreign key (BodegaID) references Bodega(ID)
	go

alter table Compra 
add foreign key	(ProveedorID) references Proveedor(ID)
	go

alter table Detalle_Compra
add foreign key (CompraID) references Compra(Id)
	go

alter table Detalle_Compra
add foreign key (ProductoID) references Producto(ID)
	go

alter table Venta
add foreign key (ClienteID) references Cliente(ID)
	go

alter table Detalle_Venta
add foreign key (VentaID) references Venta(ID)
	go 

alter table Detalle_Venta
add foreign key (ProductoID) references Producto(ID)
	go

alter table ClienteTarjetaCredito
add foreign key (ClienteID) references Cliente(ID)
 	go

alter table ClienteTarjetaCredito
add foreign key (TarjetaCreditoID) references TarjetaCredito(ID)
	go

alter table OfertaEspecialProducto
add foreign key (OfertaEspecialID) references OfertaEspecial(ID)
	go

alter table OfertaEspecialProducto
add foreign key (ProductoID) references Producto(ID)