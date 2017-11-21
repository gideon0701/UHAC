CREATE TABLE Records(
	[id] int NOT NULL FOREIGN KEY REFERENCES employees(id),
	[Availment/Claim] varchar(100) NOT NULL PRIMARY KEY,
	[Health Card] varchar(50) NOT NULL,
	[Hospital] varchar(100) NOT NULL,
	[Covered Bill] int NOT NULL,
	[Date] varchar(50) NOT NULL,
	
)