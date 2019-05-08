create database TestProjectDataBase

use TestProjectDataBase

create table Employee(
	employeeID int not null IDENTITY(1,1) primary key , 
	employeeLastName varchar(25),
	employeeFisrtName varchar(25),
	employeePhone varchar(25),
	employeeZip varchar(5),
    hireDate date
);

select *
from Employee