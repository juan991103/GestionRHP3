
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/22/2019 22:51:18
-- Generated from EDMX file: C:\Users\Enrique R\source\repos\juan991103\GestionRHP3\GestionRH\Models\MaitenanceModule.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [GestionRH];
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

-- Creating table 'Mantenimiento_EmpleadoSet'
CREATE TABLE [dbo].[Mantenimiento_EmpleadoSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Codigo_empleado]int NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [Apellido] nvarchar(max)  NOT NULL,
    [Telefono] nvarchar(max) NOT NULL,
    [Departamento] int NOT NULL,
    [Fecha_Ingreso] datetime  NOT NULL,
    [Salario] float  NOT NULL,
    [Estatus] bit NOT NULL,
    [Cargo] int NOT NULL
);
GO

-- Creating table 'Mantenimiento_DepartamentoSet'
CREATE TABLE [dbo].[Mantenimiento_DepartamentoSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Codigo_Departamento] int NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Mantenimiento_CargoSet'
CREATE TABLE [dbo].[Mantenimiento_CargoSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Codigo_Cargo] nvarchar(max)  NOT NULL,
    [Nombre_Cargo] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Process_nominasSet'
CREATE TABLE [dbo].[Process_nominasSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Age] datetime  NOT NULL,
    [mes] datetime  NOT NULL,
    [monto_total] float  NOT NULL
);
GO

-- Creating table 'Process_salida_empleadoSet'
CREATE TABLE [dbo].[Process_salida_empleadoSet] (
    [Empleado] nvarchar(max)  NOT NULL,
    [Tipo_de_salida] nvarchar(max)  NOT NULL,
    [Motivo] nvarchar(max)  NOT NULL,
    [Fecha] datetime  NOT NULL,
    [Id] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'Process_VacacionesSet'
CREATE TABLE [dbo].[Process_VacacionesSet] (
    [Empleado] nvarchar(max)  NOT NULL,
    [desde] datetime  NOT NULL,
    [hasta] datetime  NOT NULL,
    [correspondiente] datetime  NOT NULL,
    [comentario] nvarchar(max)  NOT NULL,
    [Id] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'Process_licenciasSet'
CREATE TABLE [dbo].[Process_licenciasSet] (
    [Empleado] nvarchar(max)  NOT NULL,
    [desde] nvarchar(max)  NOT NULL,
    [hasta] nvarchar(max)  NOT NULL,
    [comentario] nvarchar(max)  NOT NULL,
    [motivo] nvarchar(max)  NOT NULL,
    [Id] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'Process_PermisosSet'
CREATE TABLE [dbo].[Process_PermisosSet] (
    [Empleados] nvarchar(max)  NOT NULL,
    [desde] nvarchar(max)  NOT NULL,
    [hasta] nvarchar(max)  NOT NULL,
    [comentario] nvarchar(max)  NOT NULL,
    [Id] int IDENTITY(1,1) NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Mantenimiento_EmpleadoSet'
ALTER TABLE [dbo].[Mantenimiento_EmpleadoSet]
ADD CONSTRAINT [PK_Mantenimiento_EmpleadoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Mantenimiento_DepartamentoSet'
ALTER TABLE [dbo].[Mantenimiento_DepartamentoSet]
ADD CONSTRAINT [PK_Mantenimiento_DepartamentoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Mantenimiento_CargoSet'
ALTER TABLE [dbo].[Mantenimiento_CargoSet]
ADD CONSTRAINT [PK_Mantenimiento_CargoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Process_nominasSet'
ALTER TABLE [dbo].[Process_nominasSet]
ADD CONSTRAINT [PK_Process_nominasSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Process_salida_empleadoSet'
ALTER TABLE [dbo].[Process_salida_empleadoSet]
ADD CONSTRAINT [PK_Process_salida_empleadoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Process_VacacionesSet'
ALTER TABLE [dbo].[Process_VacacionesSet]
ADD CONSTRAINT [PK_Process_VacacionesSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Process_licenciasSet'
ALTER TABLE [dbo].[Process_licenciasSet]
ADD CONSTRAINT [PK_Process_licenciasSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Process_PermisosSet'
ALTER TABLE [dbo].[Process_PermisosSet]
ADD CONSTRAINT [PK_Process_PermisosSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------