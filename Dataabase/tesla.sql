create database tesla;

use tesla;

create table CustomerTable
(Cust_ID varchar(15)not null primary key , 
Cust_FName varchar(20) not null,
Cust_LName varchar(20) not null,
Cust_Email varchar(50) not null,
Cust_Add varchar(100)not null,
Cust_Country varchar(30)not null,
Cust_Phone int not null,
Cust_Password varchar(50) not null);



select*from CustomerTable;

create table OrderTable
(Order_ID varchar(15)not null primary key ,
Cust_ID varchar(15) references CustomerTable(Cust_ID),
Order_Date datetime,
Vehicle varchar(40) not null,
Color varchar(20) not null,
Wheels varchar(20)not null,
Interior varchar(20)not null,
Auto_Pilot varchar(4)not null,
Total float not null);


create table Order_approve_Table(orde_num varchar(15) foreign key references OrderTable(Order_ID) unique,
Status varchar(20) not null,
Reason varchar(50),
Status_Date datetime not null,
Emp_ID varchar(15) foreign key references EmployeeTable(Emp_ID)not null );

drop table Order_approve_Table;


create table EmployeeTable(Emp_ID varchar(15) primary key,
Emp_f_name varchar(20) not null,
Emp_L_name varchar(20) not null,
Date_of_Birth date not null,
Emp_Address varchar(100) not null,
Emp_Email varchar(50) not null,
Emp_Pass varchar(50) not null,
Emp_telnumber int not null,
Gender varchar(10) not null);

select* from EmployeeTable;
select* from Order_approve_Table;
select* from OrderTable;

create table Manager(Mana_ID varchar(15) primary key,
Mana_name varchar(20) not null,
Mana_Email varchar(50) not null,
Mana_Pass varchar(50) not null,
Mana_telnumber int not null);

insert into Manager values('MID 0001','Nimal','nimal@gmail.com','abc@123','0769940872');

select* from Manager;