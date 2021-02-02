use [Space];
create table Satellite(
[Name] nvarchar(10) primary key,
Radius int not null,
Distance int not null);
create table Planet(
id int identity(1,1) primary key,
[Name] nvarchar(10) not null,
Radius int not null,
Temperature real,
IsLife nvarchar(1) default 'N' check(IsLife='Y' or IsLife='N'),
IsAtmosphere nvarchar(1) default 'N' check(IsAtmosphere='Y' or IsAtmosphere='N'),
Satellites nvarchar(10));
create table MoreInformation(
[Description] nvarchar(50) primary key,
PlanetName nvarchar(10) foreign key references Planet([Name]));