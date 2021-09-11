create database TheCoffee
go
use TheCoffee
go
create table ProductType
(
	IDType varchar(10) primary key,
	TypeName nvarchar(50)
	
)
go
create table Product
(
	IDProduct varchar(20) primary key,
	ProductName nvarchar(100),
	IDType varchar(10) FOREIGN KEY REFERENCES ProductType(IDType),
	Price int not null,
	Size nvarchar(10)
)
go
create table Employee(
	UsernameEmp varchar(50) Primary key,
	NameEmp nvarchar(50) not null,
	Gender nvarchar(10) not null,
	Birthday datetime not null,
	Phone varchar(20) not null,
	Email varchar(50) not null,
	salary varchar(20) not null,
	[Address] nvarchar(Max) not null,
	Hinh varchar(50) not null,
	pass nvarchar(12) not null,
	administrator bit not null
)
go
Create Table [Order](
	IDOrder int Primary key,
	status bit default(0),
	emp varchar(50) foreign key REFERENCES Employee(UsernameEmp)

)
go
Create Table OrderDetails(
	IdOrderDetail int primary key identity,
	IDOrder int foreign key REFERENCES [Order](IDOrder),
	IDProduct varchar(20) foreign key REFERENCES Product(IDProduct),
	Quantity int not null,
	price int not null,
	TimeOrder datetime default CURRENT_TIMESTAMP,
	[status] bit default(0)
)
go
--Insert 1 Administrators

--Insert 4 Employees information
Insert into Employee values('vutung',N'Vũ Văn Tùng',N'Nam',convert(datetime,'01/01/1996'),'0124566789','tung@gmail.com',12000,N'Dĩ an','2.jpg','abcd',1)
Insert into Employee values('nguyenngan',N'Nguyễn Huỳnh Thanh',N'Nam',convert(datetime,'02/03/1994'),'0124221177','thanhtung@gmail.com',1200000,N'Tphcm','5.jpg','abcd',0)
Insert into Employee values('thanhtung',N'Nguyễn Huỳnh Thanh A',N'Nam',convert(datetime,'02/03/1994'),'0124221177','thanhtung@gmail.com',1200000,N'Tphcm','3.jpg','abcd',0)
Insert into Employee values('tuongvy',N'Tường Vy',N'Nữ',convert(datetime,'01/05/1995'),'0909123456','vy@gmail.com',1200000,N'12 Lê Hồng Phong','1.jpg','abcd',0)

go
--Inser 7 ProductTypes
Insert into ProductType values('T01',N'Cà phê')
Insert into ProductType values('T06',N'Nước trái cây')
go
--Insert 20 Products
Insert into Product values('CF01', N'Cà phê đá', 'T01', 20000,N'Nhỏ')
Insert into Product values('CF02', N'Cà phê đá','T01', 25000,N'Vừa')
Insert into Product values('CF03', N'Cà phê đá','T01', 30000,N'Lớn')
Insert into Product values('CF04', N'Cà phê sữa đá', 'T01', 25000,N'Nhỏ')
Insert into Product values('CF05', N'Cà phê sữa đá', 'T01', 30000,N'Vừa')
Insert into Product values('CF06', N'Cà phê sữa đá', 'T01', 35000,N'Lớn')
Insert into Product values('ES01', N'ESPRESSO MILK', 'T06', 30000,N'Nhỏ')
Insert into Product values('ES02', N'ESPRESSO MILK', 'T06', 40000,N'Vừa')
Insert into Product values('ES03', N'ESPRESSO MILK', 'T06', 50000,N'Lớn')
Insert into Product values('CA01', N'CAPPUCCINO', 'T06', 4200,N'Nhỏ')
Insert into Product values('CA02', N'CAPPUCCINO', 'T06', 52000,N'Vừa')
Insert into Product values('CA03', N'CAPPUCCINO', 'T06', 62000,N'Lớn')
Insert into Product values('TD01', N'Trà đào', 'T06', 40000,N'Nhỏ')
Insert into Product values('TD02', N'Trà đào', 'T06', 50000,N'Vừa')
Insert into Product values('TD03', N'Trà đào', 'T06', 60000,N'Lớn')
Insert into Product values('CE01', N'Cam ép', 'T06', 35000,N'Nhỏ')
Insert into Product values('CE02', N'Cam ép', 'T06', 40000,N'Lớn')
Insert into Product values('ST01', N'Sinh tố thập cẩm', 'T06', 50000,N'Nhỏ')
Insert into Product values('ST02', N'Sinh tố thập cẩm', 'T06', 60000,N'Lớn')



go
Insert into [Order] values(1,1,'nguyenngan')
Insert into [Order] values(2,1,'nguyenngan')
Insert into [Order] values(3,1,'nguyenngan')
Insert into [Order] values(4,1,'nguyenngan')
Insert into [Order] values(5,1,'nguyenngan')
Insert into [Order] values(6,1,'nguyenngan')
Insert into [Order] values(7,1,'nguyenngan')
Insert into [Order] values(8,1,'nguyenngan')
Insert into [Order] values(9,1,'nguyenngan')
Insert into [Order] values(10,0,'nguyenngan')
Insert into [Order] values(11,0,'nguyenngan')
Insert into [Order] values(12,0,'nguyenngan')
Insert into [Order] values(13,0,'nguyenngan')
Insert into [Order] values(14,1,'nguyenngan')
Insert into [Order] values(15,0,'nguyenngan')
go
Insert into OrderDetails values(1,'CF05',1,10000,'2018-11-11 13:23:44',0)
Insert into OrderDetails values(6,'CF01',2,10000,'2012-11-11 13:23:44',0)
Insert into OrderDetails values(2,'ST01',1,10000,'2011-11-11 13:23:44',0)
Insert into OrderDetails values(2,'ES01',2,10000,'2008-11-11 13:23:44',0)
Insert into OrderDetails values(3,'ES02',1,10000,'2008-11-11 13:23:44',0)
Insert into OrderDetails values(5,'CE01',2,10000,'2008-11-11 13:23:44',0)
Insert into OrderDetails values(4,'CA01',1,10000,'2008-11-11 13:23:44',0)
Insert into OrderDetails values(4,'TD02',3,10000,'2008-11-11 13:23:44',0)
Insert into OrderDetails values(3,'TD01',1,10000,'2008-11-11 13:23:44',0)
Insert into OrderDetails values(1,'CF02',4,10000,'2008-11-11 13:23:44',0)
go
