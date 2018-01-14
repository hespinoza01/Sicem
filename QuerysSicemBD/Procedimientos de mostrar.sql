/*                               *
 *   Procedimientos de mostrar   *
 *                               */

use sicem
go

-- Usuarios
create procedure [Mostrar_Usuarios]
as begin
	select * from Usuario
end

	go

create procedure [Detalle_Usuario](@ID varchar(15))
as begin
	select * from Usuario where ID = @ID
end

	go

-- Clientes
create procedure [Mostrar_Clientes]
as begin
	select * from Cliente
end

	go

create procedure [Detalle_Cliente](@ID varchar(25))
as begin
	select * from Cliente where ID = @ID
end

	go

-- Proveedores
create procedure [Mostrar_Proveedores]
as begin
	select * from Proveedor
end

	go

create procedure [Detalle_Proveedor](@ID int)
as begin
	select * from Proveedor where ID = @ID
end

	go

create procedure [Mostrar_Empleados]
as begin
	select * from RH_Empleado
end

	go

create procedure [Detalle_Empleado](@ID int)
as begin
	select * from RH_Empleado where ID = @ID
end

	go

create procedure [Mostrar_Departamentos]
as begin
	select * from RH_Departamentos
end

	go

create procedure [Detalle_Departamento](@ID int)
as begin
	select * from RH_Departamentos where ID = @ID
end

	go

-- Productos
create procedure [Mostrar_Productos]
as begin
	select * from Producto where Estado = 1
end

	go

create procedure [Mostrar_Todo_Productos]
as begin
	select * from Producto
end

	go

create procedure [Detalle_Producto](@ID int)
as begin
	select * from Producto where ID = @ID
end

	go

create procedure [Mostrar_HistorialPrecioProducto](@ID int)
as begin
	select * from HistorialPrecioProducto h where h.ProductoID = @ID 
end

	go

create procedure [Mostrar_HistorialCostoProducto](@ID int)
as begin
	select * from HistorialCostoProducto h where h.ProductoID = @ID 
end

	go

create procedure [Mostrar_Bodegas]
as begin
	select * from Bodega
end

	go

create procedure [Detalle_Bodega](@ID int)
as begin
	select * from Bodega where ID = @ID
end

	go

-- Categorias habilitadas
create procedure [Mostrar_Categorias]
as begin
	select * from Categoria
end

	go

create procedure [Detalle_Categoria](@ID int)
as begin
	select * from Categoria where ID = @ID
end

	go

-- Compras
create procedure [Mostrar_Compras]
as begin
	select * from Compra
end

	go

create procedure [CompraDetallada](@ID varchar(15))
as begin
	select
		c.ID,
		c.ProveedorID,
		p.Nombre,
		c.FechaCompra,
		c.TipoPago,
		c.Monto,
		c.FechaModificacion
	from Compra c 
		inner join Proveedor p 
			on p.ID = c.ProveedorID
	where c.ID = @ID
end

	go

create procedure [Mostrar_Detalle_Compra](@ID varchar(15))
as begin
	select 
		d.ProductoID as ID,
		p.Nombre as Producto,
		d.Cantidad as Cantidad,
		d.CostoUnitario as [Costo unitario],
		d.Total as Total
	from Detalle_Compra d
		inner join Producto p
			on p.ID = d.ProductoID
	where d.CompraID = @ID
end

	go

-- Ventas
create procedure [Mostrar_Ventas]
as begin
	select * from Venta
end

	go

create procedure [VentaDetallada](@ID varchar(15))
as begin
	select
		v.ID,
		v.ClienteID,
		c.NombreCliente,
		v.FechaVenta,
		v.TipoPago,
		v.TipoVenta,
		v.SubTotal,
		v.Impuesto,
		v.Total,
		v.FechaModificacion
	from Venta v
		inner join Cliente c 
			on c.ID = v.ClienteID
	where v.ID = @ID
end

	go

create procedure [Mostrar_Detalle_Venta](@ID varchar(15))
as begin
	select 
		d.VentaID as ID,
		p.Nombre as Producto,
		d.Cantidad as Cantidad,
		d.PrecioUnitario as [Precio unitario],
		d.Descuento as Descuento,
		d.Impuesto as Impuesto,
		d.Total as Total
	from Detalle_Venta d
		inner join Producto p
			on p.ID = d.ProductoID
	where d.VentaID = @ID
end

	go

create procedure [Detalle_TarjetaCredito]( @ID int )
as begin
	select * from TarjetaCredito where ID = @ID
end

	go

create procedure [Mostrar_ClienteTarjetaCredito]( @ClienteID varchar(25) )
as begin
	select
		c.TarjetaCreditoID as ID,
		t.NumeroTarjeta as Tarjeta
	from ClienteTarjetaCredito c
		inner join TarjetaCredito t
			on t.ID = c.TarjetaCreditoID
	where c.ClienteID = @ClienteID
end

	go

create procedure [Mostrar_Ofertas]
as begin
	select * from OfertaEspecial
end

	go

create procedure [Detalle_Oferta](@ID int)
as begin
	select * from OfertaEspecial where ID = @ID
end

	go

create procedure [Mostrar_OfertaProducto]( @ProductoID int )
as begin
	select
		o.OfertaEspecialID as ID,
		oe.tipoOferta as Oferta
	from OfertaEspecialProducto o 
		inner join OfertaEspecial oe
			on oe.ID = o.OfertaEspecialID
	where o.ProductoID = @ProductoID
end

	go

create procedure [Productos_Oferta](@idoferta int)
as begin
	select
		o.ProductoID,
		p.Nombre
	from OfertaEspecialProducto o
		inner join Producto p
			on p.ID = o.ProductoID
	where o.OfertaEspecialID = @idoferta
end