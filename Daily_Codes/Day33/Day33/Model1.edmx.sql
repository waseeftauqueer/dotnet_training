
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/16/2025 10:15:38
-- Generated from EDMX file: C:\dotnet_training\Daily_Codes\Day33\Day33\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [MyOnlinePizza];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Pizzas'
CREATE TABLE [dbo].[Pizzas] (
    [PizzaId] int IDENTITY(1,1) NOT NULL,
    [PizzaName] nchar(20)  NOT NULL,
    [Price] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [Type] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [PizzaId] in table 'Pizzas'
ALTER TABLE [dbo].[Pizzas]
ADD CONSTRAINT [PK_Pizzas]
    PRIMARY KEY CLUSTERED ([PizzaId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------