/*                                *
 *   Procedimientos de búsqueda   *
 *                                */
use Administrador
go

-- Usuario
create procedure [Busqueda_Usuario](
	@valor varchar(100)
)
as
begin
	select * from Usuario where (ID like '%'+@valor+'%' or Nombre like '%'+@valor+'%') or Apellido like '%'+@valor+'%'
end

	go

-- Cliente
create procedure [Busqueda_Cliente](
	@valor varchar(100),
	@clave int
)
as
begin
	if @clave = 0
		select * from Cliente where Nombre like '%'+@valor+'%' or ID like '%'+@valor+'%'
	else
		if @clave = 1
			select * from Cliente where Email like '%'+@valor+'%'
		else
			if @clave = 2
				select * from Cliente where Domicilio like '%'+@valor+'%'
			else
				if @clave = 3
					select * from Cliente where Telefono like '%'+@valor+'%'
end

	go

-- Proveedor
create procedure [Busqueda_Proveedor](
	@valor varchar(100),
	@clave int
)
as
begin
	if @clave = 0
		select * from Proveedor where Nombre like '%'+@valor+'%' or ID like '%'+@valor+'%'
	else
		if @clave = 1
			select * from Proveedor where Email like '%'+@valor+'%'
		else
			if @clave = 2
				select * from Proveedor where Domicilio like '%'+@valor+'%'
			else
				if @clave = 3
					select * from Proveedor where Telefono like '%'+@valor+'%'
end

	go

-- Compras
create procedure [Busqueda_Compras](
	@valor varchar(100),
	@clave int
)
as
begin
	if @clave = 0
		select * from Compra where ID like '%'+@valor+'%'
	else
		if @clave = 1
			select * from Compra where ProveedorID like '%'+@valor+'%'
		else
			if @clave = 2
				select * from Compra where FechaCompra like '%'+@valor+'%'
			else
				if @clave = 3
					select * from Compra where Monto like '%'+@valor+'%'
end

	go

-- Ventas
create procedure [Busqueda_Ventas](
	@valor varchar(100),
	@clave int
)
as
begin
	if @clave = 0
		select * from Venta where ID like '%'+@valor+'%'
	else
		if @clave = 1
			select * from Venta where ClienteID like '%'+@valor+'%'
		else
			if @clave = 2
				select * from Venta where FechaVenta like '%'+@valor+'%'
			else
				if @clave = 3
					select * from Venta where Total like '%'+@valor+'%'
end

	go

-- Productos
create procedure [Busqueda_Productos](
	@valor varchar(100),
	@clave int
)
as
begin
	if @clave = 0
		select * from Producto where (Nombre like '%'+@valor+'%' or ID like '%'+@valor+'%') and Estado = 1
	else
		if @clave = 1
			select * from Producto  where (CategoriaID like '%'+@valor+'%') and Estado = 1
		else
			if @clave = 2
				select * from Producto where (PrecioVenta like '%'+@valor+'%') and Estado = 1
			else
				if @clave = 3
					select * from Producto where (Stock like '%'+@valor+'%') and Estado = 1
end

	go

-- Categorías
create procedure [Busqueda_Categoria](
	@valor varchar(100),
	@estado int
)
as
begin
	if @estado = 1
		select * from Categoria where (Nombre like '%'+@valor+'%' or ID like '%'+@valor+'%') and Estado = 1
	else
		select * from Categoria where Nombre like '%'+@valor+'%' or ID like '%'+@valor+'%'
end

	go

-- Productos deshabilitados
create procedure [Busqueda_Productos_Deshabilitados](
	@valor varchar(100),
	@estado int
)
as
begin
		select * from Producto where (Nombre like '%'+@valor+'%' or ID like '%'+@valor+'%') and Estado = 0
end