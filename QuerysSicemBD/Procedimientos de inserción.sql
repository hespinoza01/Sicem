/*                                *
 *   Procedimientos de inserción  *
 *                                */
use sicem

	go

	-- Usuario
create procedure [Insertar_Usuario](
	@ID varchar(15),
	@Contraseña varchar(50),
	@Nombre varchar(50),
	@Apellido varchar(50),
	@FotoPerfil image,
	@Estado int
)
as
begin
	insert into Usuario
	values(
		@ID, 
		@contraseña, 
		@Nombre, 
		@Apellido, 
		@FotoPerfil, 
		@Estado, 
		getdate(), 
		getdate()
		)	
end

 go

 -- Cliente
create procedure [Insertar_Cliente](
	@ID varchar(25),
	@NombreCliente varchar(75),
	@NombreContacto varchar(50),
	@TituloContacto varchar(35),
	@Domicilio varchar(200),
	@Ciudad varchar(35),
	@Telefono varchar(25),
	@Email varchar(50),
	@Estado int
)
as
begin
	insert into Cliente
	values (
		@ID,
		@NombreCliente,
		@NombreContacto,
		@TituloContacto, 
		@Domicilio,
		@Ciudad, 
		@Telefono, 
		@Email,
		@Estado,
		getdate()
	)
end

	go

	-- Proveedor
create procedure [Insertar_Proveedor](
	@Nombre varchar(75),
	@NombreContacto varchar(50),
	@TituloContacto varchar(35),
	@Domicilio varchar(200),
	@Ciudad varchar(35),
	@Telefono varchar(25),
	@Email varchar(50),
	@Estado int
)
as
begin
	insert into Proveedor(
		Nombre,
		NombreContacto,
		TituloContacto, 
		Domicilio,
		Ciudad, 
		Telefono, 
		Email,
		Estado,
		FechaModificacion)
	values (
		@Nombre,
		@NombreContacto,
		@TituloContacto, 
		@Domicilio,
		@Ciudad, 
		@Telefono, 
		@Email,
		@Estado,
		getdate())
end

	go
	--Empleado
create procedure [Insertar_Empleado](
	@Nombres varchar(80),
	@Apellidos varchar(80),
	@DepartamentoID int,
	@TituloLaboral varchar(35),
	@FechaDeNacimiento date,
	@FechaDeContratacion date,
	@EstadoCivil int,
	@Genero int,
	@Domicilio varchar(200),
	@Ciudad varchar(35),
	@Telefono varchar(25),
	@Cedula varchar(25),
	@Email varchar(50),
	@Observaciones text,
	@ReportarA int,
	@Foto image,
	@Estado int
) as
begin
	insert into RH_Empleado(
		Nombres,
		Apellidos,
		DepartamentoID,
		TituloLaboral,
		FechaDeNacimiento,
		FechaDeContratacion,
		EstadoCivil,
		Genero,
		Domicilio,
		Ciudad,
		Telefono,
		Cedula,
		Email,
		Observaciones,
		ReportarA,
		Foto,
		Estado,
		FechaModificacion
	)
	values(
		@Nombres,
		@Apellidos,
		@DepartamentoID,
		@TituloLaboral,
		@FechaDeNacimiento,
		@FechaDeContratacion,
		@EstadoCivil,
		@Genero,
		@Domicilio,
		@Ciudad,
		@Telefono,
		@Cedula,
		@Email,
		@Observaciones,
		@ReportarA,
		@Foto,
		@Estado,
		getdate()
	)
end

	go
	--Departamento laboral
create procedure [Insertar_Departamento](
	@Nombre varchar(35),
	@NombreGrupo varchar(35)
)as begin
	insert into RH_Departamentos(
		Nombre,
		NombreGrupo,
		FechaModificacion
	)
	values(
		@Nombre,
		@NombreGrupo,
		getdate()
	)
end

	go

	-- Producto
create procedure [Insertar_Producto](
	@CategoriaID int,
	@Nombre varchar(50),
	@CantidadPorUnidad int,
	@PrecioVenta decimal(18,2),
	@Stock int,
	@Descripcion varchar(250),
	@Estado int
)
as
begin
	insert into Producto(
		CategoriaID, 
		Nombre,
		CantidadPorUnidad, 
		PrecioVenta, 
		Stock, 
		Descripcion, 
		Estado,
		FechaModificacion)
	values(
		@CategoriaID, 
		@Nombre,
		@CantidadPorUnidad, 
		@PrecioVenta, 
		@Stock, 
		@Descripcion, 
		@Estado,
		getdate())
end

	go

create procedure [Insertar_Historial_Precio_Producto](
	@ProductoID int,
	@Precio decimal(18,2)
)as begin
	update HistorialPrecioProducto
		set FechaFinal = getdate()
		where FechaFinal = null

	insert into HistorialPrecioProducto(
		ProductoID,
		FechaInicio,
		Precio
	)
	values(
		@ProductoID,
		getdate(),
		@Precio
	)
end

	go

create procedure [Insertar_Historial_Costo_Producto](
	@ProductoID int,
	@Precio decimal(18,2)
)as begin
	update HistorialCostoProducto
		set FechaFinal = getdate()
		where FechaFinal = null

	insert into HistorialCostoProducto(
		ProductoID,
		FechaInicio,
		Precio
	)
	values(
		@ProductoID,
		getdate(),
		@Precio
	)
end

	go

create procedure [Insertar_Bodega](
	@Nombre varchar(35),
	@Almacenaje int,
	@Comentarios text,
	@Estado int
)as begin
	insert into Bodega(
		Nombre,
		Almacenaje,
		Comentarios,
		Estado,
		FechaModificacion
	)
	values(
		@Nombre,
		@Almacenaje,
		@Comentarios,
		@Estado,
		getdate()
	)
end

	go

create procedure [Insertar_Inventario](
	@ProductoID int,
	@BodegaID int,
	@Estante varchar(50),
	@Cantidad int
)as begin
	declare @id int
	set @id = (select count(*)+1 from Inventario)

	insert into Inventario
	values(
		@id,
		@ProductoID,
		@BodegaID,
		@Estante,
		@Cantidad
	)
end

	go

	-- Categoria
create procedure [Insertar_Categoria](
	@Nombre varchar(50),
	@Descripcion varchar(250),
	@Estado int
)
as
begin
	insert into Categoria(
		Nombre, 
		Descripcion, 
		Estado,
		FechaCreacion,
		FechaModificacion)
	values(
		@Nombre, 
		@Descripcion, 
		@Estado,
		getdate(),
		getdate())
end

	go

	-- Compra
create procedure [Insertar_Compra](
	@ID varchar(15),
	@ProveedorID int,
	@FechaCompra date,
	@TipoPago int,
	@Monto decimal(18,2)
)
as
begin
	insert into Compra(ID, ProveedorID, FechaCompra, TipoPago, Monto, FechaModificacion)
	values(@ID, @ProveedorID, @FechaCompra, @TipoPago, @Monto, getdate())
end 

	go

	-- Detalle Compra
create procedure [Insertar_Detalle_Compra](
	@CompraID varchar(15),
	@ProductoID int,
	@Cantidad int,
	@CostoUnitario decimal(18,2),
	@Total decimal(18,2)
)
as 
begin
	insert into Detalle_Compra(CompraID, ProductoID, Cantidad, CostoUnitario, Total, FechaModificacion)
	values(@CompraID, @ProductoID, @Cantidad, @CostoUnitario, @Total, getdate())
end

	go

	-- Venta
create procedure [Insertar_Venta](
	@ID varchar(15),
	@ClienteID varchar(25),
	@FechaVenta date,
	@TipoPago int,
	@TipoVenta int,
	@SubTotal decimal(18,2),
	@Impuesto decimal(18,2),
	@Total decimal(18,2)
)
as
begin
	insert into Venta
	values(@ID, @ClienteID, @FechaVenta, @TipoPago, @TipoVenta, @SubTotal, @Impuesto, @Total, getdate())
end

	go

	-- Detalle Venta
create procedure [Insertar_Detalle_Venta](
	@VentaID varchar(15),
	@ProductoID int,
	@Cantidad int,
	@PrecioUnitario decimal(18,2),
	@Descuento decimal(18,2),
	@Impuesto decimal(18,2),
	@Total decimal(18,2)
)
as
begin
	insert into Detalle_Venta
	values(@VentaID, @ProductoID, @Cantidad, @PrecioUnitario, @Descuento, @Impuesto, @Total, getdate())
end

	go

create procedure [Insertar_TarjetaCredito](
	@TipoTarjeta varchar(25),
	@NumeroTarjeta varchar(25),
	@ExpiraMes int,
	@ExpiraAño int
)as begin
	begin tran
	insert into TarjetaCredito(
		TipoTarjeta,
		NumeroTarjeta,
		ExpiraMes,
		ExpiraAño,
		FechaModificacion
	)
	values(
		@TipoTarjeta,
		@NumeroTarjeta,
		@ExpiraMes,
		@ExpiraAño,
		getdate()
	)
	commit
end

	go

create procedure [Insertar_ClienteTarjetaCredito](
	@ClienteID varchar(25),
	@TarjetaCreditoID int
)as begin
	begin tran
	insert into ClienteTarjetaCredito
	values(
		@ClienteID,
		@TarjetaCreditoID
	)
	commit
end

	go

create procedure [Insertar_OfertaEspecial](
	@Descripcion text,
	@PorcentajeDescuento float,
	@tipoOferta varchar(75),
	@FechaInicio date,
	@FechaFinal date,
	@MinCantidad int,
	@MaxCantidad int
)as begin
	insert into OfertaEspecial(
		Descripcion,
		PorcentajeDescuento,
		tipoOferta,
		FechaInicio,
		FechaFinal,
		MinCantidad,
		MaxCantidad,
		FechaModificacion
	)
	values(
		@Descripcion,
		@PorcentajeDescuento,
		@tipoOferta,
		@FechaInicio,
		@FechaFinal,
		@MinCantidad,
		@MaxCantidad,
		getdate()
	)
end

	go 

create procedure [Insertar_OfertaEspecialProducto](
	@OfertaEspecialID int,
	@ProductoID int
)as begin
	insert into OfertaEspecialProducto
	values(
		@OfertaEspecialID,
		@ProductoID
	)
end

	go

create procedure [Remover_OfertaEspecialProducto](
	@OfertaID int,
	@ProductoID int
)as begin
	delete 
	from OfertaEspecialProducto
	where
		OfertaEspecialID = @OfertaID
			and
		ProductoID = @ProductoID 
end