Create database Gestion_De_Empleados;
go 

use Gestion_De_Empleados;
go

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

create table Vacaciones (

IdVacaciones int identity (1,1) primary key,
IdEmpleado int,
FechaInicio date,
FechaFin date,
Estado varchar (50) default 'Pendiente',
foreign key (IdEmpleado) references Empleados(IdEmpleado),

);


create table LicenciasMedicas (

IdLicencia int identity  (1,1) primary key,
IdEmpleado int ,
FechaInicio date,
FechaFin date ,
Tipolicencia varchar (50),
Estado varchar(50) default 'Pendiente',
foreign key (IdEmpleado) references Empleados(IdEmpleado)

);

create table DiasPersonales (

IdDiaPersonales int identity (1,1) primary key,
IdEmpleado int,
Fecha date,
Estado varchar (50) default 'pendiente',
foreign key (IdEmpleado) references Empleados(IdEmpleado),

);

create table Admins (
IdAdmin int identity (1,1) primary key,
NombreUsuario varchar (50) not null,
Contraseña varchar (50) not null,
);

insert into Admins (NombreUsuario, Contraseña) 
values ('Miriam' , '2025');