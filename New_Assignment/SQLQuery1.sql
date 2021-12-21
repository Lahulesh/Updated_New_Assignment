create table City
(
CityId int identity primary key,
CityName varchar(100),
)

create table Vendor
(
VendorId int identity primary key,
VendorName varchar(100)UNIQUE,
VendorEmail varchar(100),
VendorContact bigint,
CityId int foreign key references City(CityId)
)
create table Asset
(
AssetID int identity primary key,
AssetName varchar(100) UNIQUE,
VendorName varchar(100),
PurchaseDate date,
Cost bigint
)

select * from City;
select * from Vendor;
select * from Asset;

INSERT INTO City VALUES ('Mumbai');
INSERT INTO City VALUES ('Delhi');
INSERT INTO City VALUES ('Pune');
INSERT INTO City VALUES ('Kolkata');


INSERT INTO Vendor VALUES ('Aniket','aniket@gmail.com',7894584857,4);
