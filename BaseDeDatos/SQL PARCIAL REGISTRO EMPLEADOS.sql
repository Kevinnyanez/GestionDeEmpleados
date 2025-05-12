
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
Gmail nvarchar (250) NOT NULL,
DNI nvarchar (20) NOT NULL,
FechaCumple date,
CumpleHoy bit,
DiasPersonalesAsignados int default 3 ,
DiasPersonalesRestantes int default 3,
VacacionesAsignadas int default 15,
VacacionesUsadas int default 0,
LicenciasAsignadas int default 5 ,
LicenciasUsadas int default 0,
Contraseña nvarchar(100) not null unique
);



create table Admins (
IdAdmin int identity (1,1) primary key,
NombreUsuario varchar (50) not null,
Contraseña varchar (50) not null
);

-- agregamos los datos del administrador
insert into Admins (NombreUsuario, Contraseña) 
values ('Matias' , '2025');


-- Inserts de empleados --
INSERT INTO Empleados (
    NombreCompleto, 
    NumeroCelular, 
    Gmail, 
    DNI, 
    FechaCumple, 
    CumpleHoy, 
    Contraseña
)
VALUES
('juan perez', '+5491145678901', 'juan.perez@gmail.com', '40123456', '1990-05-15', 0, '40123456'),
('maría gómez', '+5491156789012', 'maria.gomez@gmail.com', '39123456', '1985-08-22', 0, '39123456'),
('carlos rodríguez', '+5491167890123', 'carlos.rod@gmail.com', '38123456', '1993-02-10', 0, '38123456'),
('laura fernández', '+5491178901234', 'laura.fer@gmail.com', '37123456', '1988-11-30', 0, '37123456'),
('pedro lópez', '+5491189012345', 'pedro.lopez@gmail.com', '36123456', '1995-07-04', 0, '36123456'),
('ana martínez', '+5491190123456', 'ana.martinez@mail.com', '35123456', '1992-09-18', 0, '35123456'),
('diego sánchez', '+5491101234567', 'diego.sanchez@mail.com', '34123456', '1987-04-25', 0, '34123456'),
('sofía ramos', '+5491112345678', 'sofia.ramos@mail.com', '33123456', '1998-12-05', 0, '33123456'),
('jorge díaz', '+5491123456789', 'jorge.diaz@mail.com', '32123456', '1991-03-14', 0, '32123456'),
('marta ruiz', '+5491134567890', 'marta.ruiz@mail.com', '31123456', '1984-06-27', 0, '31123456'),
('luis hernández', '+5491145678901', 'luis.hernan@mail.com', '30123456', '1997-01-09', 0, '30123456'),
('elena castro', '+5491156789012', 'elena.castro@mail.com', '29123456', '1994-10-12', 0, '29123456'),
('miguel torres', '+5491167890123', 'miguel.torre@mail.com', '28123456', '1989-07-19', 0, '28123456'),
('isabel vargas', '+5491178901234', 'isabel.vargas@mail.com', '27123456', '1996-08-03', 0, '27123456'),
('oscar romero', '+5491189012345', 'oscar.romero@mail.com', '26123456', '1983-05-28', 0, '26123456'),
('carmen medina', '+5491190123456', 'carmen.medina@mail.com', '25123456', '1999-04-11', 0, '25123456'),
('ricardo ortiz', '+5491201234567', 'ricardo.ort@mail.com', '24123456', '1986-12-24', 0, '24123456'),
('patricia muñoz', '+5491212345678', 'patricia.mun@mail.com', '23123456', '1990-02-17', 0, '23123456'),
('fernando gil', '+5491223456789', 'fernando.gil@mail.com', '22123456', '1981-09-08', 0, '22123456'),
('teresa navarro', '+5491234567890', 'teresa.nava@mail.com', '21123456', '1993-06-13', 0, '21123456'),
('roberto campos', '+5491245678901', 'roberto.cam@mail.com', '20123456', '1984-03-26', 0, '20123456'),
('silvia reyes', '+5491256789012', 'silvia.reyes@mail.com', '19123456', '1997-10-07', 0, '19123456'),
('javier morales', '+5491267890123', 'javier.mor@mail.com', '18123456', '1988-01-14', 0, '18123456'),
('lucía ibáñez', '+5491278901234', 'lucia.ibanez@mail.com', '17123456', '1995-11-23', 0, '17123456'),
('manuel delgado', '+5491289012345', 'manuel.del@mail.com', '16123456', '1982-07-30', 0, '16123456'),
('eva pascual', '+5491290123456', 'eva.pascual@mail.com', '15123456', '1998-04-09', 0, '15123456'),
('alberto marín', '+5491301234567', 'alberto.mar@mail.com', '14123456', '1989-08-16', 0, '14123456'),
('rosa serrano', '+5491312345678', 'rosa.serrano@mail.com', '13123456', '1991-12-19', 0, '13123456'),
('víctor bravo', '+5491323456789', 'victor.bravo@mail.com', '12123456', '1985-05-02', 0, '12123456'),
('concepción león', '+5491334567890', 'con.leon@mail.com', '11123456', '1994-03-15', 0, '11123456'),
('sergio cabrera', '+5491345678901', 'sergio.cab@mail.com', '10123456', '1987-10-28', 0, '10123456'),
('irene peña', '+5491356789012', 'irene.pena@mail.com', '9123456', '1996-09-04', 0, '9123456'),
('alfonso vega', '+5491367890123', 'alfonso.vega@mail.com', '8123456', '1983-02-11', 0, '8123456'),
('nuria santos', '+5491378901234', 'nuria.santos@mail.com', '7123456', '1999-07-22', 0, '7123456'),
('ramón molina', '+5491389012345', 'ramon.molina@mail.com', '6123456', '1980-11-05', 0, '6123456'),
('pilar herrero', '+5491390123456', 'pilar.herrero@mail.com', '5123456', '1992-04-18', 0, '5123456'),
('joaquín montero', '+5491401234567', 'joaquin.mon@mail.com', '4123456', '1986-06-25', 0, '4123456'),
('consuelo palma', '+5491412345678', 'consuelo.pal@mail.com', '3123456', '1997-01-08', 0, '3123456'),
('gabriel pons', '+5491423456789', 'gabriel.pon@mail.com', '2123456', '1984-10-13', 0, '2123456'),
('clara segura', '+5491434567890', 'clara.segura@mail.com', '1123456', '1993-12-31', 0, '1123456');
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
	FOREIGN KEY (CategoriaID) REFERENCES Categorias (CategoriaID)
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
	FOREIGN KEY (CategoriaID) REFERENCES Categorias (CategoriaID),
	FOREIGN KEY (SubCatID) REFERENCES SubCategorias (SubCatID)
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



