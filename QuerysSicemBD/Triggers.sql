use sicem
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

-- actualiza los id de inventario despues de haber eliminado uno
create trigger [Actualiza_ID_Inventario]
on Inventario
for delete
as
begin tran
	declare @id int
	set @id = (select ID from deleted)
	
	update Inventario
	set ID = ID-1
	where ID > @id
commit


-- Actulizar el almacen con respecto a las salidas del producto
create trigger [Disminuir_Almacen]
on [Detalle_Venta]
for insert
as
	declare 
		@salida int,
		@idProductoSalida int,
		@idAlmacen int,
		@stockAlmacen int

	set @salida = (select Cantidad from inserted)
	set @idProductoSalida = (select ProductoID from inserted)

	while @salida > 0
	begin
		set @idAlmacen = (select top 1 ID from Inventario where ProductoID = @idProductoSalida order by id)
		set @stockAlmacen = (select Cantidad from Inventario where ID = @idAlmacen)

		if @salida > @stockAlmacen
			begin
				delete from Inventario where ID = @idAlmacen
				set @salida = @salida - @stockAlmacen
			end
			else if (@salida - @stockAlmacen) = 0
				begin
					delete from Inventario where ID = @idAlmacen
					set @salida = 0
				end
				else
					begin
						update Inventario set Cantidad = Cantidad - @salida where ID = @idAlmacen
						set @salida = 0
					end
	end