CREATE TABLE Cars(
	CarId INT NOT NULL PRIMARY KEY,
	BrandId INT NOT NULL,
	ColorId INT NOT NULL,
	ModelYear INT NOT NULL,
	DailyPrice DECIMAL NOT NULL,
	Descriptions NVARCHAR (50) NOT NULL,
	FOREIGN KEY (ColorId) REFERENCES Colors(ColorId),
	FOREIGN KEY (BrandId) REFERENCES Brands(BrandId)
)

CREATE TABLE Colors(
	ColorId INT NOT NULL PRIMARY KEY,
	ColorName NVARCHAR (50)
)

CREATE TABLE Brands(
	BrandId INT NOT NULL PRIMARY KEY,
	BrandName NVARCHAR (50) NOT NULL
)

INSERT INTO Cars(BrandId,ColorId,ModelYear,DailyPrice,Descriptions)
VALUES
	('1','1','2019','1700','Price for 3 days!'),
	('3','1','2017','750','Price for 3 days!'),
	('2','2','2018','800','Price for 3 days!'),
	('1','3','2018','1500','Price for 3 days!'),
	('2','2','2019','195','Price for a day!'),
	('3','5','2018','185','Price for a day!'),
	('4','3','2014','135','Price for a day!'),
	('5','1','2020','200','Price for a day!'),
	('4','4','2019','600','Price for 3 days!');


INSERT INTO Colors(ColorName)
VALUES
	('Siyah'),
	('Beyaz'),
	('Lacivert'),
	('Sarı'),
	('Kırmızı');


INSERT INTO Brands(BrandName)
VALUES
	('Audi'),
	('Opel'),
	('Volkswagen'),
	('Renault'),
	('Ford');