/*  DESKTOP-6NVT70E  -> servidor */

create database sicem
	go
use sicem
	go

/* Creación de las tablas */

create table Usuario(
	ID varchar(15) primary key not null,
	Contraseña varchar(50),
	Nombre varchar(50),
	Apellido varchar(50),
	FotoPerfil image,
	Estado int,
	FechaCreacion date,
	FechaModificacion date
)
	go
create table Cliente(
	ID varchar(25) primary key not null,
	NombreCliente varchar(75),
	NombreContacto varchar(50),
	TituloContacto varchar(35),
	Domicilio varchar(200),
	ciudad varchar(35),
	Telefono varchar(25),
	Email varchar(50),
	Estado int,
	FechaModificacion date
)
	go
create table Proveedor(
	ID int identity(1,1) primary key not null,
	Nombre varchar(75),
	NombreContacto varchar(50),
	TituloContacto varchar(35),
	Domicilio varchar(200),
	ciudad varchar(35),
	Telefono varchar(25),
	Email varchar(50),
	Estado int,
	FehaModificacion date
)
	go
create table RH_Empleado(
	ID int identity(1,1) primary key not null,
	Nombres varchar(80),
	Apellidos varchar(80),
	DepartamentoID int,
	TituloLaboral varchar(35),
	FechaDeNacimiento date,
	FechaDeContratacion date,
	EstadoCivil int,
	Genero int,
	Domicilio varchar(200),
	ciudad varchar(35),
	Telefono varchar(25),
	Cedula varchar(25),
	Email varchar(50),
	HorasVacaciones int,
	HorasLicenciaEnfermedad int,
	Observaciones text,
	ReportarA int,
	Foto image,
	Estado int,
	FechaModificacion date
)
	go
create table RH_Departamentos(
	ID int identity(1,1) primary key,
	Nombre varchar(35),
	NombreGrupo varchar(35),
	FechaModificacion date
)
	go
create table Producto(
	ID int identity(1,1) primary key not null,
	CategoriaID int,
	Nombre varchar(50),
	CantidadPorUnidad int,
	PrecioVenta decimal(18,2),
	Stock int,
	Descripcion varchar(250),
	Estado int,
	FechaModificacion date
)
	go
create table HistorialPrecioProducto(
	ProductoID int,
	FechaInicio date,
	FechaFinal date,
	Precio decimal(18,2),
	FechaModificacion date
)
	go
create table HistorialCostoProducto(
	ProductoID int,
	FechaInicio date,
	FechaFinal date,
	Precio decimal(18,2)
)
	go
create table HistorialEntradaProducto(
	ProductoID int,
	Cantidad int,
	Costo decimal(18,2),
	FechaEntrada date
)
	go
create table Bodega(
	ID int identity(1,1) primary key,
	Nombre varchar(35),
	Disponibilidad int,
	FechaModificacion date
)
	go
create table Inventario(
	ProductoID int,
	BodegaID int,
	Estante varchar(50),
	Cantidad int,
	FechaModificacion date
)
	go
create table Categoria(
	ID int identity(1,1) primary key not null,
	Nombre varchar(50),
	Descripcion varchar(250),
	Estado int,
	FechaCreacion date,
	FechaModificacion date
)
	go
create table Compra(
	ID varchar(15) primary key not null,
	ProveedorID int,
	FechaCompra date,
	TipoPago int,
	Monto decimal(18,2),
	FechaModificacion date
)
	go
create table Detalle_Compra(
	CompraID varchar(15) not null,
	ProductoID int not null,
	Cantidad int not null,
	CantidadDevuelta int,
	CostoUnitario decimal(18,2) not null,
	Total decimal(18,2),
	FechaModificacion date
)
	go
create table Venta(
	ID varchar(15) primary key not null,
	ClienteID varchar(25) not null,
	UsuarioID varchar(15),
	FechaVenta date not null,
	TipoPago int not null,
	TipoVenta int,
	SubTotal decimal(18,2),
	Impuesto decimal(18,2),
	Total decimal(18,2),
	FechaModificacion date
)
	go
create table Detalle_Venta(
	VentaID varchar(15) not null,
	ProductoID int not null,
	Cantidad int,
	PrecioUnitario decimal(18,2),
	Descuento decimal(18,2),
	Impuesto decimal(18,2),
	Total decimal(18,2),
	FechaModificacion date
)
	go
create table TarjetaCredito(
	ID int identity(1,1) primary key,
	TipoTarjeta varchar(25),
	NumeroTarjeta varchar(25),
	ExpiraMes int,
	ExpiraAño int,
	FechaModificacion date
)
	go
create table ClienteTarjetaCredito(
	ClienteID varchar(25),
	TarjetaCreditoID int,
	FechaModificacion date
)
	go
create table OfertaEspecial(
	ID int identity(1,1) primary key,
	Descripcion text,
	PorcentajeDescuento float,
	tipoOferta varchar(75),
	FechaInicio date,
	FechaFinal date,
	MinCantidad int,
	MaxCantidad int,
	FechaModificacion date
)
	go
create table OfertaEspecialProducto(
	OfertaEspecialID int,
	ProductoID int,
	FechaModificacion date
)
	go
alter table Producto
add foreign key (CategoriaID) references Categoria(ID)
	go
alter table Compra 
add foreign key	(ProveedorID) references Proveedor(ID)
	go
alter table Detalle_Compra
add foreign key (CompraID) references Compra(Id)
	go
alter table Detalle_Compra
add foreign key (ProductoID) references Producto(ID)
	go
alter table Venta
add foreign key (ClienteID) references Cliente(ID)
	go
alter table Detalle_Venta
add foreign key (VentaID) references Venta(ID)
	go 
alter table Detalle_Venta
add foreign key (ProductoID) references Producto(ID)