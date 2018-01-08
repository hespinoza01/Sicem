/*                                     *
 *   Procedimientos de actualización   *
 *                                     */
 select * from Usuario
 use Administrador
 go

-- Usuario
alter procedure [Actualizar_Usuario](
	@ID varchar(15),
	@Contraseña varchar(50),
	@Nombre varchar(50),
	@Apellido varchar(50),
	@FotoPerfil image
)
as
begin
	Update Usuario
		Set
			Contraseña = @contraseña,
			Nombre = @Nombre,
			Apellido = @Apellido,
			FotoPerfil = @FotoPerfil
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
	@ID Int,
	@Nombre varchar(50),
	@Domicilio varchar (125),
	@Telefono varchar(25),
	@Email varchar (50)
)
as
begin
	Update Cliente 
		Set Nombre=@Nombre, 
			Domicilio=@Domicilio,
			Telefono=@Telefono,
			Email=@Email
	where ID=@ID
end

	go

-- Proveedor
create procedure [Actualizar_Proveedores](	
	@ID Int,
	@Nombre varchar(50),
	@Domicilio varchar (125),
	@Telefono varchar(25),
	@Email varchar (50)
)
as
begin
	Update Proveedor 
		Set Nombre=@Nombre, 
			Domicilio=@Domicilio,
			Telefono=@Telefono,
			Email=@Email
	where ID=@ID
end

	go

-- Producto
create procedure [Actualizar_Producto](
	@ID int,
	@CategoriaID int,
	@Nombre varchar(50),
	@PrecioVenta decimal(18,2),
	@Stock int,
	@Descripcion varchar(250),
	@Estado int
)
as
begin
	Update Producto
		set 
			CategoriaID = @CategoriaID,
			Nombre = @Nombre,
			PrecioVenta = @PrecioVenta,
			Stock = @Stock,
			Descripcion = @Descripcion,
			Estado = @Estado
	where ID = @ID
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
			Estado = @Estado
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
			Monto = @Monto
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
			Total = @Total
	where CompraID = @CompraID and ProductoID = @ProductoID
end

	go

-- Venta
create procedure [Actualizar_Venta](
	@ID varchar(15),
	@ClienteID int,
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
			Total = @Total
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
			Total = @Total
	where VentaID = @VentaID and ProductoID = @ProductoID
end
