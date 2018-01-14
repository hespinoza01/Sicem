/*                                     *
 *   Procedimientos de actualización   *
 *                                     */
 use sicem
 go

-- Usuario
create procedure [Actualizar_Usuario](
	@ID varchar(15),
	@Contraseña varchar(50),
	@Nombre varchar(50),
	@Apellido varchar(50),
	@FotoPerfil image,
	@Estado int
)
as
begin
	Update Usuario
		Set
			Contraseña = @contraseña,
			Nombre = @Nombre,
			Apellido = @Apellido,
			FotoPerfil = @FotoPerfil,
			Estado = @Estado,
			FechaModificacion = getdate()
	where ID = @ID
end

	go

-- Validar usuario
create procedure [Validar_Usuario](
	@Usuario varchar(15),
	@Contraseña varchar (50)
)
as begin
	Select 
		ID 
	from Usuario  
	where ID =  @Usuario and Contraseña = @Contraseña
end

	go

-- Cliente
create procedure [Actualizar_Cliente](	
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
	Update Cliente 
		Set NombreCliente=@NombreCliente,
			NombreContacto=@NombreContacto,
			TituloContacto=@TituloContacto, 
			Domicilio=@Domicilio,
			Ciudad=@Ciudad,
			Telefono=@Telefono,
			Email=@Email,
			Estado=@Estado,
			FechaModificacion=getdate()
	where ID=@ID
end

	go

-- Proveedor
create procedure [Actualizar_Proveedores](
	@ID int,	
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
	Update Proveedor 
		Set Nombre=@Nombre,
			NombreContacto=@NombreContacto,
			TituloContacto=@TituloContacto, 
			Domicilio=@Domicilio,
			Ciudad=@Ciudad,
			Telefono=@Telefono,
			Email=@Email,
			Estado=@Estado,
			FechaModificacion=getdate()
	where ID=@ID
end

	go

create procedure [Actualizar_Empleado](
	@ID int,
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
)as begin
	update RH_Empleado
		set Nombres=@Nombres,
			Apellidos=@Apellidos,
			DepartamentoID=@DepartamentoID,
			TituloLaboral=@TituloLaboral,
			FechaDeNacimiento=@FechaDeNacimiento,
			FechaDeContratacion=@FechaDeContratacion,
			EstadoCivil=@EstadoCivil,
			Genero=@Genero,
			Domicilio=@Domicilio,
			Ciudad=@Ciudad,
			Telefono=@Telefono,
			Cedula=@Cedula,
			Email=@Email,
			Observaciones=@Observaciones,
			ReportarA=@ReportarA,
			Foto=@Foto,
			Estado=@Estado,
			FechaModificacion=getdate()
		where ID = @ID
end

	go

create procedure [Actualizar_Departamento](
	@ID int,
	@Nombre varchar(35),
	@NombreGrupo varchar(35)
)as begin
	update RH_Departamentos
		set Nombre=@Nombre,
			NombreGrupo=@NombreGrupo,
			FechaModificacion=getdate()
		where ID=@ID
end

	go

-- Producto
create procedure [Actualizar_Producto](
	@ID int,
	@CategoriaID int,
	@Nombre varchar(50),
	@CantidadPorUnidad int,
	@PrecioVenta decimal(18,2),
	@Stock int,
	@Descripcion varchar(250),
	@Estado int
)
as begin
	Update Producto
		set 
			CategoriaID = @CategoriaID,
			Nombre = @Nombre,
			CantidadPorUnidad = @CantidadPorUnidad,
			PrecioVenta = @PrecioVenta,
			Stock = @Stock,
			Descripcion = @Descripcion,
			Estado = @Estado,
			FechaModificacion = getdate()
	where ID = @ID
end
	
	go

create procedure [Actualizar_Bodega](
	@ID int,
	@Nombre varchar(35),
	@Almacenaje int
)as begin
	update Bodega
		set Nombre=@Nombre,
			Almacenaje=@Almacenaje,
			FechaModificacion=getdate()
		where ID=@ID
end

	go

-- Categoria
create procedure [Actualizar_Categoria](
	@ID int,
	@Nombre varchar(50),
	@Descripcion varchar(250),
	@Estado int
)
as
begin
	Update Categoria
		set 
			Nombre = @Nombre,
			Descripcion = @Descripcion,
			Estado = @Estado,
			FechaModificacion = getdate()
	where ID = @Id
end

	go

-- Compra
create procedure [Actualizar_Compra](
	@ID varchar(15),
	@ProveedorID int,
	@FechaCompra date,
	@TipoPago int,
	@Monto decimal(18,2)
)
as
begin
	Update Compra
		set 
			ProveedorID = @ProveedorID,
			FechaCompra = @FechaCompra,
			TipoPago = @TipoPago,
			Monto = @Monto,
			FechaModificacion = getdate()
	where ID = @ID
end 

	go

-- Detalle Compra
create procedure [Actualizar_Detalle_Compra](
	@CompraID varchar(15),
	@ProductoID int,
	@Cantidad int,
	@CostoUnitario decimal(18,2),
	@Total decimal(18,2)
)
as
begin
	Update Detalle_Compra 
		set 
			Cantidad = @Cantidad,
			CostoUnitario = @CostoUnitario,
			Total = @Total,
			FechaModificacion = getdate()
	where CompraID = @CompraID and ProductoID = @ProductoID
end

	go

-- Venta
create procedure [Actualizar_Venta](
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
	Update Venta
		set
			ClienteID = @ClienteID,
			FechaVenta = @FechaVenta,
			TipoPago = @TipoPago,
			TipoVenta = @TipoVenta,
			SubTotal = @SubTotal,
			Impuesto = @Impuesto,
			Total = @Total,
			FechaModificacion = getdate()
	where ID = @ID
end

	go

-- Detalle Venta
create procedure [Actualizar_Detalle_Venta](
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
	Update Detalle_Venta
		set
			Cantidad = @Cantidad,
			PrecioUnitario = @PrecioUnitario,
			Descuento = @Descuento,
			Impuesto = @Impuesto,
			Total = @Total,
			FechaModificacion = getdate()
	where VentaID = @VentaID and ProductoID = @ProductoID
end

	go

create procedure [Actualizar_TarjetaCredito](
	@ID int,
	@TipoTarjeta varchar(25),
	@NumeroTarjeta varchar(25),
	@ExpiraMes int,
	@ExpiraAño int
)as begin
	update TarjetaCredito
		set TipoTarjeta=@TipoTarjeta,
			NumeroTarjeta=@NumeroTarjeta,
			ExpiraMes=@ExpiraMes,
			ExpiraAño=@ExpiraAño,
			FechaModificacion = getdate()
end

	go

create procedure [Actualizar_OfertaEspecial](
	@ID int,
	@Descripcion text,
	@PorcentajeDescuento float,
	@tipoOferta varchar(75),
	@FechaInicio date,
	@FechaFinal date,
	@MinCantidad int,
	@MaxCantidad int
)as begin
	update OfertaEspecial
		set Descripcion=@Descripcion,
			PorcentajeDescuento=@PorcentajeDescuento,
			tipoOferta=@tipoOferta,
			FechaInicio=@FechaInicio,
			FechaFinal=@FechaFinal,
			MinCantidad=@MinCantidad,
			MaxCantidad=@MaxCantidad,
			FechaModificacion=getdate()
		where ID = @ID
end
