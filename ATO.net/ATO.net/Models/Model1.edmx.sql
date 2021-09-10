
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 09/07/2021 19:25:11
-- Generated from EDMX file: C:\Users\cheli\Documents\GitHub\ATO.NET\ATO.net\ATO.net\Models\Model1.edmx
-- --------------------------------------------------


SET QUOTED_IDENTIFIER OFF;
GO
USE [ATO.net.Models.Model1];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_EmployeePayslip]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PayslipSet] DROP CONSTRAINT [FK_EmployeePayslip];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[EmployeeSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EmployeeSet];
GO
IF OBJECT_ID(N'[dbo].[PayslipSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PayslipSet];
GO
IF OBJECT_ID(N'[dbo].[TaxthresholdSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TaxthresholdSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'EmployeeSet'
CREATE TABLE [dbo].[EmployeeSet] (
    [employeeId] int IDENTITY(1,1) NOT NULL,
    [firstName] nvarchar(max)  NOT NULL,
    [lastName] nvarchar(max)  NOT NULL,
    [annualSalary] double  precision,
    [superRate] int  NOT NULL,
    [paymentMonth] int  NOT NULL
);
GO

-- Creating table 'PayslipSet'
CREATE TABLE [dbo].[PayslipSet] (
    [payslipId] int IDENTITY(1,1) NOT NULL,
    [fromDate] nvarchar(max)  NOT NULL,
    [toDate] nvarchar(max)  NOT NULL,
    [incomeTax] double  precision,
    [netIncome] double  precision,
    [superAmount] double  precision,
    [grossIncome] double  precision,
    [Employee_employeeId] int  NOT NULL
);
GO

-- Creating table 'TaxthresholdSet'
CREATE TABLE [dbo].[Taxthreshold] (
    [taxthresholdId] int IDENTITY(1,1) NOT NULL,
    [taxMin] double  precision,
    [taxCent] double  precision,
    [taxLump] double  precision
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [employeeId] in table 'EmployeeSet'
ALTER TABLE [dbo].[EmployeeSet]
ADD CONSTRAINT [PK_EmployeeSet]
    PRIMARY KEY CLUSTERED ([employeeId] ASC);
GO

-- Creating primary key on [payslipId] in table 'PayslipSet'
ALTER TABLE [dbo].[PayslipSet]
ADD CONSTRAINT [PK_PayslipSet]
    PRIMARY KEY CLUSTERED ([payslipId] ASC);
GO

-- Creating primary key on [taxthresholdId] in table 'TaxthresholdSet'
ALTER TABLE [dbo].[Taxthreshold]
ADD CONSTRAINT [PK_Taxthreshold]
    PRIMARY KEY CLUSTERED ([taxthresholdId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Employee_employeeId] in table 'PayslipSet'
ALTER TABLE [dbo].[PayslipSet]
ADD CONSTRAINT [FK_EmployeePayslip]
    FOREIGN KEY ([Employee_employeeId])
    REFERENCES [dbo].[EmployeeSet]
        ([employeeId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EmployeePayslip'
CREATE INDEX [IX_FK_EmployeePayslip]
ON [dbo].[PayslipSet]
    ([Employee_employeeId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------