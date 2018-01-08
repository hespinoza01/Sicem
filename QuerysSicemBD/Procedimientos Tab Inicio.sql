use Administrador
go

alter procedure [contadores_tab_inicio]
as begin
	declare 
		@ventas int,
		@clientes int,
		@proveedores int,
		@producto int

	set @ventas = ( select count(ID) from Venta where month(FechaVenta) = month(getdate()) and year(FechaVenta) = year(getdate()) )
	set @clientes = ( select count(ID) from Cliente )
	set @proveedores = ( select count(ID) from Proveedor )
	set @producto = ( select count(ID) from Producto )

	select 
		@clientes as Cliente,
		@proveedores as Proveedor,
		@producto as Producto,
		@ventas as Venta
	--from Cliente c, Proveedor p, Producto pr--, Venta v
end
exec contadores_tab_inicio
	go

create procedure [ultimas_ventas]
as begin
	select top 5
		ID,
		FechaVenta as Fecha,
		Total
	from Venta
	order by ID desc
end

	go

create procedure productos_mas_vendidos
as begin
	select top 5 
			dv.ProductoID as [ID],
			p.Nombre as [Nombre],
			count(dv.Cantidad) as [Cantidad vendida]
		from [Detalle_Venta] dv
			inner join Venta v
				on v.ID = dv.VentaID
				inner join Producto p
					on p.ID = dv.ProductoID and dv.VentaID = v.ID
		where year(v.FechaVenta) = year(getdate()) and month(v.FechaVenta) = month(getdate())
		group by p.Nombre, dv.ProductoID
		order by [Cantidad vendida] desc
end

	go

create procedure top_clientes
as begin
	select top 5 
				c.ID as [ID],
				c.Nombre as [Nombre],
				round(sum(v.Total), 2) as [Recaudación]
			from [Venta] v
				inner join Cliente c
					on v.ClienteID = c.ID
			where year(v.FechaVenta) = year(getdate())
			group by c.ID, c.Nombre
			order by [Recaudación] desc
end
