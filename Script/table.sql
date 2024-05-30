
CREATE DATABASE PruebaIT;

CREATE TABLE [Pacientes](
	[Id] INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[Name] VARCHAR(250) NOT NULL,
	[Date] DATETIME NOT NULL,
	[Email] VARCHAR(250) NOT NULL,
	[Gender] Int ,
	[Address] VARCHAR(250) NOT NULL,
	[Phone] Int ,
	[DateA] DATETIME NOT NULL,
	[Remove] BIT NOT NULL DEFAULT 0,
);
