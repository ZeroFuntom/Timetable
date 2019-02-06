
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/06/2019 11:03:44
-- Generated from EDMX file: C:\Git\Timetable\Timetable.Domain\Model\TimetableModel.edmx.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Timetable];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Lessons]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Lessons];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Lessons'
CREATE TABLE [dbo].[Lessons] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [LessonName] nvarchar(max)  NOT NULL,
    [StartLesson] nvarchar(max)  NOT NULL,
    [EndLesson] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Lessons'
ALTER TABLE [dbo].[Lessons]
ADD CONSTRAINT [PK_Lessons]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------