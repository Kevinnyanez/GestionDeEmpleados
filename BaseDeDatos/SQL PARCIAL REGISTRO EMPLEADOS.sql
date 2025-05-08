
-- -------------------- CREAMOS LA BASE DE DATOS Y LA SELECCIONAMOS -----------------------
Create database Gestion_De_Empleados;
GO

use Gestion_De_Empleados;
GO

-- -------------------- TABLAS DE ADMIN Y EMPLEADOS ---------------------------------
Create table Empleados (

IdEmpleado int identity(1,1) primary key,
NombreCompleto varchar(50) not null,
NumeroCelular varchar(18),
Gmail varchar (25),
DNI varchar (20),
FechaCumple date,
CumpleHoy bit,
DiasPersonalesAsignados int default 3 ,
DiasPersonalesRestantes int default 3,
VacacionesAsignadas int default 15,
VacacionesUsadas int default 0,
LicenciasAsignadas int default 5 ,
LicenciasUsadas int default 0
);



create table Admins (
IdAdmin int identity (1,1) primary key,
NombreUsuario varchar (50) not null,
Contraseña varchar (50) not null
);

-- agregamos los datos del administrador
insert into Admins (NombreUsuario, Contraseña) 
values ('Miriam' , '2025');

-- Agregamos La columna contraseña para poder entrar en el Login Empleados a partir de ella y un gmail
ALTER TABLE Empleados
ADD Contraseña VARCHAR(100) UNIQUE;

-- --------------------------------------TABLAS DE LOS PRODUCTOS, CATEGORIAS Y SUBCATEGORIAS-------------------------------------------------
-- CREAR TABLA DE tipo
CREATE TABLE Categorias(
	CategoriaID INT IDENTITY (1,1) PRIMARY KEY,
	NombreCat VARCHAR (50) NOT NULL 
	)
	
-- Inserto las categorias
	INSERT INTO Categorias(NombreCat)
	VALUES
		('Calzado'),
		('Vestimenta'),
		('Accesorios'),
		('Perfumes')


-- CREAR TABLA DE SUBCATEGORIA
CREATE TABLE SubCategorias(
	SubCatID INT IDENTITY (1,1) PRIMARY KEY,
	CategoriaID INT NOT NULL,
	SubCatNombre VARCHAR (50) NOT NULL,
	FOREIGN KEY (CategoriaID) REFERENCES CategoriaProd (CategoriaID)
	)
	-- Inserto las subcat
	INSERT INTO SubCategorias(CategoriaID, SubCatNombre)
	VALUES
		(1, 'Running'), (1, 'Basquet'), (1, 'Futbol'), (1, 'Tenis'),
		(2, 'Remeras'), (2, 'Pantalones'), (2, 'Buzos'),
		(3, 'Relojes'), (3, 'Medias'), (3, 'Tobilleras'),
		(4, 'Masculino'), (4, 'Femenino')


--CREAR TABLA DE PRODUCTOS
CREATE TABLE Productos(
	ProductoID INT IDENTITY (1,1) PRIMARY KEY,
	NombreProducto NVARCHAR (50) NOT NULL,
	Descripcion NVARCHAR (150),
	Precio FLOAT NOT NULL,
	Stock INT CHECK (Stock >= 0) NOT NULL,-- NO DEBERIA SER MENOR A "0" (verificar)
	CategoriaID INT NOT NULL,
	SubCatID INT NOT NULL,
	FOREIGN KEY (CategoriaID) REFERENCES CategoriaProd (CategoriaID),
	FOREIGN KEY (SubCatID) REFERENCES SubCategoria (SubCatID)
	)
	--agregamos productos
	INSERT INTO Productos (NombreProducto, Descripcion, Precio, Stock, CategoriaID, SubCatID)
	VALUES 
		('Zapatillas ADIDAS xx5', 'Zapatilla deportiva de running para calle', 78900.00, 300, 1, 1),
		('Zapatillas ADIDAS MS4', 'Zapatilla deportiva de running para calle', 91550.00, 300, 1,1),
		('Zapatillas ADIDAS MS5', 'Zapatilla deportiva de running para calle', 92800.00, 200, 1,1),
		('Zapatillas NIKE NS7', 'Zapatilla deportiva de running todo terreno', 107000.00, 240, 1,1),
		('Zapatillas NIKE NN11', 'Zapatilla deportiva de running todo terreno', 144000.00, 110, 1,1),

		('Zapatillas Nike Air Zoom BB', 'Zapatilla de básquet profesional', 102500.00, 150, 1, 2),
		('Zapatillas Adidas Pro Bounce', 'Zapatilla de básquet de alta tracción', 97800.00, 120, 1, 2),
		('Zapatillas Under Armour UA2', 'Zapatilla de básquet de alta tracción', 112000.00, 80, 1, 2),
		('Zapatillas Puma Pro', 'Zapatilla de básquet con diseño clásico', 89900.00, 100, 1, 2),
		('Zapatillas Jordan 2', 'Zapatilla de básquet de alta tracción', 119000.00, 60, 1, 2),
		('Zapatillas Reebok Question Mid', 'Modelo retro con buen soporte de tobillo', 87000.00, 90, 1, 2),

		('Botin Nike Mercurial', 'Botín para césped natural', 88500.00, 180, 1, 3),
		('Botin Adidas Predator', 'Botín para césped natural', 91500.00, 160, 1, 3),
		('Botin Puma FZ', 'Botín para césped natural', 84000.00, 140, 1, 3),
		('Botin Nike GT2', 'Clásico botín de cuero para todo tipo de canchas', 89900.00, 130, 1, 3),
		('Botin Adidas Mundial', 'Clásico botín de cuero para todo tipo de canchas', 92000.00, 100, 1, 3),
		('Botin Umbro Pro', 'Clásico botín de cuero para todo tipo de canchas', 77500.00, 110, 1, 3),

		('Zapatillas Wilson Rush Pro', 'Zapatilla ligera y con amortiguación', 83200.00, 100, 1, 4),
		('Zapatillas Nike Court Lite', 'Zapatilla ligera y con amortiguación', 75800.00, 90, 1, 4),
		('Zapatillas Adidas Barricade', 'Zapatilla ligera y con amortiguación', 81000.00, 85, 1, 4),
		('Zapatillas Asics Gel Resolution 8', 'Estabilidad y soporte lateral', 84500.00, 95, 1, 4),
		('Zapatillas New Balance FuelCell 996', 'Estabilidad y soporte lateral', 79000.00, 70, 1, 4),
		('Zapatillas Head Sprint Pro 3.5', 'Estabilidad y soporte lateral', 80500.00, 75, 1, 4),


		('Remeras Nike DryFit', 'Remera deportiva con tecnología de secado rápido', 32000.00, 200, 2, 5),
		('Remeras Adidas Essentials', 'Remera básica de algodón suave', 29500.00, 180, 2, 5),
		('Remeras Puma Training', 'Remera liviana para entrenamiento diario', 31000.00, 150, 2, 5),
		('Remeras Under Armour Tech', 'Remera técnica con tela transpirable', 33000.00, 160, 2, 5),

		('Pantalones Nike Club Fleece', 'Pantalón jogger de abrigo para invierno', 45000.00, 100, 2, 6),
		('Pantalones Adidas Tiro 21', 'Pantalón deportivo ajustado con cierre', 47000.00, 110, 2, 6),
		('Pantalones Puma Power', 'Diseño moderno con bolsillos funcionales', 43000.00, 90, 2, 6),
		('Pantalones Under Armour Rival', 'Pantalón cómodo de entrenamiento', 44000.00, 120, 2, 6),

		('Buzos Nike Sportswear', 'Buzo con capucha y ajuste clásico', 52000.00, 80, 2, 7),
		('Buzos Adidas Essentials', 'Buzo liviano con logo frontal', 51000.00, 75, 2, 7),
		('Buzos Puma Classics', 'Diseño urbano con ajuste holgado', 49500.00, 90, 2, 7),
		('Buzos Under Armour Fleece', 'Buzo térmico ideal para días fríos', 53500.00, 70, 2, 7),

		('Relojes Casio G-Shock', 'Reloj resistente a golpes y al agua', 76000.00, 60, 3, 8),
		('Relojes Swatch Originals', 'Estilo casual y moderno para uso diario', 52000.00, 80, 3, 8),
		('Relojes Fossil Grant', 'Reloj elegante con correa de cuero', 89000.00, 40, 3, 8),
		('Relojes Xiaomi Mi Watch', 'Smartwatch con monitoreo de salud', 67000.00, 100, 3, 8),

		('Medias Nike Everyday', 'Pack de 3 pares con suela acolchada', 15500.00, 200, 3, 9),
		('Medias Adidas Performance', 'Pack de medias deportivas tobilleras', 14900.00, 190, 3, 9),
		('Medias Puma Classic Crew', 'Medias altas de algodón', 16500.00, 150, 3, 9),
		('Medias Under Armour Heatgear', 'Tecnología anti-transpiración', 17200.00, 130, 3, 9),
	
		('Tobilleras Nike Pro', 'Compresión para mayor estabilidad articular', 21000.00, 60, 3, 10),
		('Tobilleras Adidas Support', 'Diseño ergonómico con refuerzo lateral', 19500.00, 70, 3, 10),
		('Tobilleras Reebok Fit', 'Soporte liviano para entrenamientos diarios', 18500.00, 65, 3, 10),
		('Tobilleras Mueller Adjustable', 'Tobillera ajustable con velcro', 23000.00, 50, 3, 10),

		('Masculino Hugo Boss Bottled', 'Fragancia clásica y elegante para hombre', 98000.00, 45, 4, 11),
		('Masculino Paco Rabanne Invictus', 'Aroma fresco e intenso', 102000.00, 50, 4, 11),
		('Masculino Dior Sauvage', 'Perfume potente de larga duración', 118000.00, 40, 4, 11),
		('Masculino Bleu de Chanel', 'Fragancia sofisticada y moderna', 125000.00, 35, 4, 11),

		('Femenino Carolina Herrera Good Girl', 'Fragancia dulce y seductora', 109000.00, 50, 4, 12),
		('Femenino Lancôme La Vie Est Belle', 'Perfume floral y elegante', 99000.00, 60, 4, 12),
		('Femenino Chanel Coco Mademoiselle', 'Toque oriental moderno y refinado', 125000.00, 40, 4, 12),
		('Femenino Dior Miss Dior', 'Aroma fresco con notas florales', 115000.00, 45, 4, 12);
		GO


-- ------------------- CREACIÓN DE VISTA PARA MOSTRAR LAS CATEGORIAS Y SUBCATEGORIAS ------------------------------
CREATE VIEW VistaProductos AS
SELECT 
    Productos.ProductoID,
    Productos.NombreProducto,
    Productos.Descripcion,
    Productos.Precio,
    Productos.Stock,
    Categorias.NombreCat AS NombreCategoria,
    SubCategorias.SubCatNombre AS NombreSubCategoria
FROM 
    Productos
JOIN 
    Categorias ON Productos.CategoriaID = Categorias.CategoriaID
JOIN 
    SubCategorias ON Productos.SubCatID = SubCategorias.SubCatID;



