CREATE TABLE Cars(
	CarID INT NOT NULL PRIMARY KEY,
	BrandID INT NOT NULL,
	ColorID INT NOT NULL,
	ModelYear INT NOT NULL,
	DailyPrice DECIMAL NOT NULL,
	Descriptions NVARCHAR (50) NOT NULL,
	FOREIGN KEY (ColorID) REFERENCES Colors(ColorID),
	FOREIGN KEY (BrandID) REFERENCES Brands(BrandID)
)

CREATE TABLE Colors(
	ColorID INT NOT NULL PRIMARY KEY,
	ColorName NVARCHAR (25)
)

CREATE TABLE Brands(
	BrandID INT NOT NULL PRIMARY KEY,
	BrandName NVARCHAR (25) NOT NULL
)

INSERT INTO Cars(BrandID,ColorID,ModelYear,DailyPrice,Descriptions)
VALUES
	('1','1','2019','1700','3 günlük kiralık!'),
	('3','1','2017','750','3 günlük kiralık!'),
	('2','2','2018','800','3 günlük kiralık!'),
	('1','3','2018','1500','3 günlük kiralık!'),
	('2','2','2019','195','Günlük kiralık!'),
	('3','2','2018','185','Günlük kiralık!');

INSERT INTO Colors(ColorName)
VALUES
	('Siyah'),
	('Beyaz'),
	('Lacivert');


INSERT INTO Brands(BrandName)
VALUES
	('Audi'),
	('Opel'),
	('Volkswagen');