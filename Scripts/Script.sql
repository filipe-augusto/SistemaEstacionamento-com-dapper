CREATE DATABASE Parking
USE 
Parking
CREATE TABLE [Client] (
    [Id] INT NOT NULL IDENTITY(1, 1),
    [Name] NVARCHAR(255) NOT NULL,
    [Document] VARCHAR(50) NULL,
    [Phone] VARCHAR(50) NOT NULL,
    [Special] BIT NOT NULL
    CONSTRAINT [PK_User] PRIMARY KEY([Id]),
    CONSTRAINT [UQ_Client_Document] UNIQUE([Document]),
    CONSTRAINT [UQ_Client_Phone] UNIQUE([Phone])
)
CREATE NONCLUSTERED INDEX [IX_Client_Document] ON [Client]([Document])
CREATE NONCLUSTERED INDEX [IX_Client_Name] ON [Client]([Name])
CREATE TABLE [Car] (
    [Id] INT NOT NULL IDENTITY(1, 1),
    [Modelo] NVARCHAR(60) NOT NULL,
    [Color] VARCHAR(50) NOT NULL,
    [LicensePlate] VARCHAR(255) NOT NULL,
    CONSTRAINT [PK_Car] PRIMARY KEY([Id])
)
CREATE TABLE [ClientCar] (
    [CarId] INT NOT NULL,
    [ClientId] INT NOT NULL,
    CONSTRAINT [PK_UserRole] PRIMARY KEY([CarId], [ClientId])
)

SELECT * FROM Car

CREATE TABLE [Scheduling] (
    [Id] INT NOT NULL IDENTITY(1, 1),
    [StartDate] DATETIME NOT NULL,
    [EndDate]   DATETIME NOT NULL,
    [Special]   BIT NOT NULL,
    [Finished]  BIT NOT NULL,
    [IdCar]     INT NOT NULL,
    [IdClient]  INT NOT NULL,
    [Value]     DECIMAL NOT NULL,
    [AmountMinutes] INT NOT NULL,

    CONSTRAINT [PK_Scheduling] PRIMARY KEY([Id]),
    CONSTRAINT [FK_Scheduling_Car] FOREIGN KEY([IdCar]) REFERENCES [Car]([Id]),
    CONSTRAINT [FK_Scheduling_Client] FOREIGN KEY([IdClient]) REFERENCES [Client]([Id]),
)

CREATE TABLE [MonthlyClient] (
    [Id] INT NOT NULL IDENTITY(1, 1),
    [StartDate] DATETIME NOT NULL,
    [EndDate]   DATETIME NOT NULL,
    [ValueFixed]     DECIMAL NOT NULL,
    [Special]   BIT NOT NULL,
    [Active]  BIT NOT NULL,
    [IdCar]     INT NOT NULL,
    [IdClient]  INT NOT NULL,

    CONSTRAINT [PK_MonthlyClient] PRIMARY KEY([Id]),
    CONSTRAINT [FK_MonthlyClient_Car] FOREIGN KEY([IdCar]) REFERENCES [Car]([Id]),
    CONSTRAINT [FK_MonthlyClient_Client] FOREIGN KEY([IdClient]) REFERENCES [Client]([Id]),
)
    -- dotnet add package .Microsoft.Data.DataClient
    -- dotnet add package Dapper
    -- dotnet add package Dapper.Contrib