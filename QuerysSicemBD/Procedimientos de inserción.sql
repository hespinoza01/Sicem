/*                                *
 *   Procedimientos de inserción  *
 *                                */
use Administrador

	go

	-- Usuario
alter procedure [Insertar_Usuario](
	@ID varchar(15),
	@Contraseña varchar(50),
	@Nombre varchar(50),
	@Apellido varchar(50),
	@FotoPerfil image
)
as
begin
	insert into Usuario
	values(@ID, @contraseña, @Nombre, @Apellido, @FotoPerfil)	
end

 go

 -- Cliente
create procedure [Insertar_Cliente](
	@Nombre varchar(50),
	@Domicilio varchar(125),
	@Telefono varchar(25),
	@Email varchar(50)
)
as
begin
	insert into Cliente(Nombre, Domicilio, Telefono, Email)
	values (@Nombre, @Domicilio, @Telefono, @Email)
end

	go

	-- Proveedor
create procedure [Insertar_Proveedor](
	@Nombre varchar(50),
	@Domicilio varchar(125),
	@Telefono varchar(25),
	@Email varchar(50)
)
as
begin
	insert into Proveedor(Nombre, Domicilio, Telefono, Email)
	values (@Nombre, @Domicilio, @Telefono, @Email)
end

	go

	-- Producto
create procedure [Insertar_Producto](
	@CategoriaID int,
	@Nombre varchar(50),
	@PrecioVenta decimal(18,2),
	@Stock int,
	@Descripcion varchar(250),
	@Estado int
)
as
begin
	insert into Producto(CategoriaID, Nombre, PrecioVenta, Stock, Descripcion, Estado)
	values(@CategoriaID, @Nombre, @PrecioVenta, @Stock, @Descripcion, @Estado)
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
	insert into Categoria(Nombre, Descripcion, Estado)
	values(@Nombre, @Descripcion, @Estado)
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
	insert into Compra(ID, ProveedorID, FechaCompra, TipoPago, Monto)
	values(@ID, @ProveedorID, @FechaCompra, @TipoPago, @Monto)
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
	insert into Detalle_Compra(CompraID, ProductoID, Cantidad, CostoUnitario, Total)
	values(@CompraID, @ProductoID, @Cantidad, @CostoUnitario, @Total)
end

	go

	-- Venta
create procedure [Insertar_Venta](
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
	insert into Venta
	values(@ID, @ClienteID, @FechaVenta, @TipoPago, @TipoVenta, @SubTotal, @Impuesto, @Total)
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
	values(@VentaID, @ProductoID, @Cantidad, @PrecioUnitario, @Descuento, @Impuesto, @Total)
end
