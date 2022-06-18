Create database LibraryDB
go 
use LibraryDB 
go 
create table Category 
(
id int primary key identity,
catname varchar(50),
status varchar(50)
)
go
create table Author 
(
id int primary key identity,
name varchar(50),
address varchar(50),
phone varchar(50)
)
go
create table Publisher 
(
id int identity primary key,
name varchar(50),
address varchar(50),
phone varchar(50) 
)
go
create table Member 
(
id int identity primary key,
name varchar(50),
address varchar(50),
phone varchar(50)
)
go
create table Book
(
id int identity primary key,
bname varchar(50),
c_id int references Category(id),
a_id int references Author(id),
p_id int references Publisher(id),
contents varchar(50),
pages int,
edition int 
)
go
create table Issuebook
(
id int identity primary key,
m_id int,
book varchar(50),
issuedate date,
returndate date
)
go
create table Returnbook
(
id int identity primary key,
m_id int,
book varchar(50),
returndate date,
elsp int,
fine int
)
go
--
select * from Issuebook
go
select * from Returnbook
--
delete  from Category