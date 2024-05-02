USE [PapeleriaOBL]
GO

/****** Objeto: Table [dbo].[Clientes] Fecha del script: 02/05/2024 1:04:32 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Clientes] (
    [Id]                   INT            IDENTITY (1, 1) NOT NULL,
    [direccion_Calle]      NVARCHAR (MAX) NOT NULL,
    [direccion_Ciudad]     NVARCHAR (MAX) NOT NULL,
    [direccion_Distancia]  INT            NOT NULL,
    [direccion_Numero]     INT            NOT NULL,
    [razonSocial_RazonSoc] NVARCHAR (MAX) NOT NULL,
    [rut_Rut]              BIGINT         NOT NULL
);


INSERT INTO [dbo].[Clientes] ([direccion_Calle], [direccion_Ciudad], [direccion_Distancia], [direccion_Numero], [razonSocial_RazonSoc], [rut_Rut])
VALUES 
('Calle A', 'Ciudad A', 5, 123, 'Razón Social 1', 1234567890123),
('Calle B', 'Ciudad B', 10, 456, 'Razón Social 2', 2345678901234),
('Calle C', 'Ciudad C', 15, 789, 'Razón Social 3', 3456789012345),
('Calle D', 'Ciudad D', 20, 101112, 'Razón Social 4', 4567890123456),
('Calle E', 'Ciudad E', 25, 131415, 'Razón Social 5', 5678901234567),
('Calle F', 'Ciudad F', 30, 161718, 'Razón Social 6', 6789012345678),
('Calle G', 'Ciudad G', 35, 192021, 'Razón Social 7', 7890123456789),
('Calle H', 'Ciudad H', 40, 222324, 'Razón Social 8', 8901234567890),
('Calle I', 'Ciudad I', 45, 252627, 'Razón Social 9', 9012345678901),
('Calle J', 'Ciudad J', 50, 282930, 'Razón Social 10', 1234567890128);