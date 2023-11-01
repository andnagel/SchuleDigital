USE master;
GO

-- Check and create database
IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'SchuleDB')
   CREATE DATABASE [SchuleDB];
GO

USE [SchuleDB];
GO

-- Check and create tables
-- Student
IF NOT EXISTS (SELECT 1 FROM sys.tables WHERE name = 'dbo.Schueler' and type = 'U')
   CREATE TABLE [dbo].[Schueler] (
    [SchuelerID]   INT           IDENTITY (1, 1) NOT NULL,
    [Vorname]      NVARCHAR (30) NOT NULL,
    [Nachname]     NVARCHAR (30) NOT NULL,
    [Geburtsdatum] DATE          NOT NULL,
    [Geschlecht]   NVARCHAR (10) NOT NULL,
    [Adresse]      TEXT          NOT NULL,
    [TelefonNr]    NVARCHAR (30) NULL,
    [Bild]         IMAGE         NULL,
    PRIMARY KEY CLUSTERED ([SchuelerID] ASC)
);
GO

-- Teacher
IF NOT EXISTS (SELECT 1 FROM sys.tables WHERE name = 'dbo.Lehrer' and type = 'U')
   CREATE TABLE [dbo].[Lehrer] (
    [PersID]       INT           IDENTITY (1, 1) NOT NULL,
    [Vorname]      NVARCHAR (30) NOT NULL,
    [Nachname]     NVARCHAR (30) NOT NULL,
    [Geburtsdatum] DATE          NOT NULL,
    [Geschlecht]   NVARCHAR (10) NOT NULL,
    [Adresse]      TEXT          NOT NULL,
    [TelefonNr]    NVARCHAR (30) NULL,
    [Bild]         IMAGE         NULL,
    PRIMARY KEY CLUSTERED ([PersID] ASC)
);
GO

-- Subject
IF NOT EXISTS (SELECT 1 FROM sys.tables WHERE name = 'dbo.Faecher' and type = 'U')
   CREATE TABLE [dbo].[Faecher] (
    [FachID]       INT           IDENTITY (1, 1) NOT NULL,
    [Bezeichnung]  NVARCHAR (30) NOT NULL,
    [Stufe]        NVARCHAR (10) NOT NULL,
    [Beschreibung] TEXT          NULL,
    [LehrerPersID] INT           NULL,
    PRIMARY KEY CLUSTERED ([FachID] ASC)
);
GO

-- Grade
IF NOT EXISTS (SELECT 1 FROM sys.tables WHERE name = 'dbo.Noten' and type = 'U')
   CREATE TABLE [dbo].[Noten] (
    [SchuelerID] INT           NOT NULL,
    [FachID]     INT           NOT NULL,
    [Wert]       NVARCHAR (30) NOT NULL,
    [Datum]      DATE          NOT NULL,
    CONSTRAINT [PK_Noten] PRIMARY KEY CLUSTERED ([SchuelerID] ASC, [FachID] ASC, [Datum] ASC),
    CONSTRAINT [FK_Noten_ToSchueler] FOREIGN KEY ([SchuelerID]) REFERENCES [dbo].[Schueler] ([SchuelerID]) ON DELETE CASCADE,
    CONSTRAINT [FK_Noten_ToFaecher] FOREIGN KEY ([FachID]) REFERENCES [dbo].[Faecher] ([FachID])
);
GO