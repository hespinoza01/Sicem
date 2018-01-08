/*                               *
 *   Procedimientos de mostrar   *
 *                               */

use Administrador
go

-- Usuarios
create procedure [Mostrar_Usuarios]
as begin
	select * from Usuario
end

	go

-- Clientes
create procedure [Mostrar_Clientes]
as begin
	select * from Cliente
end

	go

-- Proveedores
create procedure [Mostrar_Proveedores]
as begin
	select * from Proveedor
end

	go

-- Productos
create procedure [Mostrar_Productos]
as begin
	select * from Producto where Estado = 1
end

	go

-- Categorias habilitadas
create procedure [Mostrar_Categorias]
as begin
	select * from Categoria where Estado = 1
end

	go

-- Categorias habilitadas/deshabilitadas
create procedure [Mostrar_Todo_Categorias]
as begin
	select * from Categoria
end

	go

-- Compras
create procedure [Mostrar_Compras]
as begin
	select * from Compra
end

	go

create procedure [Mostrar_Detalle_Compra](@id varchar(15))
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
	where d.CompraID = @id
end

	go

-- Ventas
create procedure [Mostrar_Ventas]
as begin
	select * from Venta
end

	go

create procedure [Mostrar_Detalle_Venta](@id varchar(15))
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
	where d.VentaID = @id
end
