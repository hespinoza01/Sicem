/*                                *
 *   Procedimientos de búsqueda   *
 *                                */
use sicem
go

-- Usuario
create procedure [Busqueda_Usuario](
	@valor varchar(100),
	@clave int
)
as
begin
	if @clave = 0
		select 	* from Usuario 	where ID like '%'+@valor+'%' or Nombre like '%'+@valor+'%'
	else if @clave = 1
			select * from Usuario where Apellido like '%'+@valor+'%'
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
		select * from Cliente where NombreCliente like '%'+@valor+'%' or ID like '%'+@valor+'%'
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

create procedure [Busqueda_Empleado](
	@valor varchar(100),
	@clave int
)
as
begin
	if @clave = 0
		select * from RH_Empleado where (Nombres like '%'+@valor+'%' or ID like '%'+@valor+'%') or Apellidos like '%'+@valor+'%'
	else
		if @clave = 1
			select * from RH_Empleado where Email like '%'+@valor+'%'
		else
			if @clave = 2
				select * from RH_Empleado where Domicilio like '%'+@valor+'%'
			else
				if @clave = 3
					select * from RH_Empleado where Telefono like '%'+@valor+'%'
end

	go

create procedure [Busqueda_Departamento](
	@valor varchar(100),
	@clave int
)
as
begin
	if @clave = 0
		select * from RH_Departamentos where Nombre like '%'+@valor+'%' or ID like '%'+@valor+'%'
	else
		if @clave = 1
			select * from RH_Departamentos where NombreGrupo like '%'+@valor+'%'
end

	go

create procedure [Busqueda_Bodega](
	@valor varchar(100),
	@clave int
)
as
begin
	if @clave = 0
		select * from Bodega where Nombre like '%'+@valor+'%' or ID like '%'+@valor+'%'
	else
		if @clave = 1
			select * from Bodega where Almacenaje like '%'+@valor+'%'
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

create procedure [Busqueda_Productos_Todo](
	@valor varchar(100),
	@clave int
)
as
begin
	if @clave = 0
		select * from Producto where (Nombre like '%'+@valor+'%' or ID like '%'+@valor+'%')
	else
		if @clave = 1
			select * from Producto  where (CategoriaID like '%'+@valor+'%')
		else
			if @clave = 2
				select * from Producto where (PrecioVenta like '%'+@valor+'%')
			else
				if @clave = 3
					select * from Producto where (Stock like '%'+@valor+'%')
end

	go

-- Categorías
create procedure [Busqueda_Categoria](
	@valor varchar(100)
)
as
begin
		select * from Categoria where Nombre like '%'+@valor+'%' or ID like '%'+@valor+'%'
end

	go

create procedure [Busqueda_Oferta](
	@valor varchar(100),
	@clave int
)
as
begin
	if @clave = 0
		select * from OfertaEspecial where ID like '%'+@valor+'%' or tipoOferta like '%'+@valor+'%'
	else
		if @clave = 1
			select * from OfertaEspecial  where (PorcentajeDescuento like '%'+@valor+'%')
		else
			if @clave = 2
				select * from OfertaEspecial where (FechaInicio like '%'+@valor+'%')
			else
				if @clave = 3
					select * from OfertaEspecial where (FechaFinal like '%'+@valor+'%')
end