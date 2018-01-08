use Administrador
go

-- Aumentar el stock a la hora de insertar un Detalle compra
create trigger [Aumentar_Stock_DC]
on [Detalle_Compra]
for insert
as
	update p
	set p.Stock = (p.Stock + i.Cantidad) 
	from Producto p
		inner join inserted i
			on p.ID = i.ProductoID

	go

-- Disminuir el stock a la hora de insertar un Detalle venta
create trigger [Disminuir_Stock_DV]
on [Detalle_Venta]
for insert
as
	update p
	set p.Stock = (p.Stock - i.Cantidad) 
	from Producto p
		inner join inserted i
			on p.ID = i.ProductoID

	go

-- Actualiza el stock despues de actualizar detalle compra
create trigger [Actualiza_Stock_A_DC]
on [Detalle_Compra]
for update
as
	declare
		@ActualizaStock as int
		set @ActualizaStock = (select 
							       d.Cantidad 
							   from Detalle_Compra d
							       inner join updated u
								       on d.CompraID = u.CompraID
							   where 
							       d.CompraID = u.CompraID and d.ProductoID = u.ProductoID)

	Update p
		set p.Stock = p.Stock + (u.Cantidad - @ActualizaStock)
	from Producto p
		inner join updated u
			on p.ID = u.ProductoID

-- Actualiza el stock despues de actualizar detalle venta
create trigger [Actualiza_Stock_A_DV]
on [Detalle_Venta]
for update
as
	declare
		@ActualizaStock as int
		set @ActualizaStock = (select 
							       d.Cantidad 
							   from Detalle_Venta d
							       inner join updated u
								       on d.VentaID = u.VentaID
							   where 
							       d.VentaID = u.VentaID and d.ProductoID = u.ProductoID)

	Update p
		set p.Stock = p.Stock - (u.Cantidad - @ActualizaStock)
	from Producto p
		inner join updated u
			on p.ID = u.ProductoID




/* provando el trigger de aumento_stock_dc*/
--insert into Categoria(Nombre, Descripcion, Estado)
--values ('Zapatos', 'Zapatos de distintos estilos, colores y marcas, para damas, niños y caballeros', 1)
--go
--insert into Producto(CategoriaID, Nombre, PrecioVenta, Stock, Descripcion, Estado)
--values (1, 'Deportivo NIKE', 575, 10, 'descripcion', 1)
--go
--insert into Proveedor(Nombre, Domicilio, Telefono, Email)
--values ('NIKE', 'Alguna direción', '0000-0000', 'nikecompany@gmail.com')
--go
--insert into Compra
--values ('compra', 1, getdate(), 1, 1290)

--select * from Producto
--insert Detalle_Compra
--values ('compra', 1, 3, 120, 120)