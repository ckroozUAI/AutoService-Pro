-- ============================================================================
-- BASE DE DATOS: AUTOSERVICE
-- Sistema de Gestión Integral de Taller Mecánico y Reparaciones (AutoService Pro)
-- Convención física: UPPER_SNAKE_CASE en Tablas y Columnas | PK: IDENTITY(1,1)
-- ============================================================================

IF DB_ID('AUTOSERVICE') IS NOT NULL
BEGIN
    ALTER DATABASE AUTOSERVICE SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE AUTOSERVICE;
END
GO

CREATE DATABASE AUTOSERVICE;
GO

USE AUTOSERVICE;
GO

-- ============================================================================
-- 1. Tabla USUARIO (Operadores del sistema)
-- ============================================================================
CREATE TABLE USUARIO (
    ID INT IDENTITY(1,1) NOT NULL,
    USUARIO VARCHAR(50) NOT NULL,
    PASSWORD VARCHAR(255) NOT NULL,
    FECHA_REGISTRO DATETIME DEFAULT GETDATE(),
    CONSTRAINT PK_USUARIO PRIMARY KEY (ID),
    CONSTRAINT UQ_USUARIO_NOMBRE UNIQUE (USUARIO)
);
GO

-- ============================================================================
-- 2. Tabla CLIENTE (Titulares de vehículos)
-- ============================================================================
CREATE TABLE CLIENTE (
    ID INT IDENTITY(1,1) NOT NULL,
    NOMBRE VARCHAR(50) NOT NULL,
    APELLIDO VARCHAR(50) NOT NULL,
    DNI VARCHAR(15) NOT NULL,
    TELEFONO VARCHAR(30) NULL,
    EMAIL VARCHAR(100) NULL,
    FECHA_REGISTRO DATETIME DEFAULT GETDATE(),
    CONSTRAINT PK_CLIENTE PRIMARY KEY (ID),
    CONSTRAINT UQ_CLIENTE_DNI UNIQUE (DNI)
);
GO

-- ============================================================================
-- 3. Tabla VEHICULO (Rodados registrados)
-- ============================================================================
CREATE TABLE VEHICULO (
    ID INT IDENTITY(1,1) NOT NULL,
    ID_CLIENTE INT NOT NULL,
    PATENTE VARCHAR(10) NOT NULL,
    MARCA VARCHAR(50) NOT NULL,
    MODELO VARCHAR(50) NOT NULL,
    ANIO INT NOT NULL,
    COLOR VARCHAR(30) NULL,
    KILOMETRAJE INT NOT NULL DEFAULT 0,
    FECHA_REGISTRO DATETIME DEFAULT GETDATE(),
    CONSTRAINT PK_VEHICULO PRIMARY KEY (ID),
    CONSTRAINT UQ_VEHICULO_PATENTE UNIQUE (PATENTE),
    CONSTRAINT CK_VEHICULO_ANIO CHECK (ANIO BETWEEN 1950 AND 2100),
    CONSTRAINT FK_VEHICULO_CLIENTE FOREIGN KEY (ID_CLIENTE) REFERENCES CLIENTE(ID)
);
GO

CREATE INDEX IX_VEHICULO_CLIENTE ON VEHICULO(ID_CLIENTE);
GO

-- ============================================================================
-- 4. Tabla REPUESTO (Catálogo e inventario físico)
-- ============================================================================
CREATE TABLE REPUESTO (
    ID INT IDENTITY(1,1) NOT NULL,
    CODIGO VARCHAR(50) NOT NULL,
    DESCRIPCION VARCHAR(150) NOT NULL,
    PRECIO DECIMAL(18,2) NOT NULL DEFAULT 0,
    STOCK_FISICO INT NOT NULL DEFAULT 0,
    CONSTRAINT PK_REPUESTO PRIMARY KEY (ID),
    CONSTRAINT UQ_REPUESTO_CODIGO UNIQUE (CODIGO),
    CONSTRAINT CK_REPUESTO_PRECIO CHECK (PRECIO >= 0),
    CONSTRAINT CK_REPUESTO_STOCK CHECK (STOCK_FISICO >= 0)
);
GO

CREATE INDEX IX_REPUESTO_DESCRIPCION ON REPUESTO(DESCRIPCION);
GO

-- ============================================================================
-- 5. Tabla ORDEN_SERVICIO (Cabecera de trabajos del taller)
-- ============================================================================
CREATE TABLE ORDEN_SERVICIO (
    ID INT IDENTITY(1,1) NOT NULL,
    ID_VEHICULO INT NOT NULL,
    FECHA_INGRESO DATETIME NOT NULL DEFAULT GETDATE(),
    ID_TECNICO INT NOT NULL,
    FECHA_CIERRE DATETIME NULL,
    DIAGNOSTICO VARCHAR(500) NULL,
    ESTADO VARCHAR(50) NOT NULL,
    MANO_OBRA DECIMAL(18,2) NOT NULL DEFAULT 0,
    TOTAL DECIMAL(18,2) NOT NULL DEFAULT 0,
    TOTAL_REPUESTOS DECIMAL(18,2) NOT NULL DEFAULT 0,
    KILOMETRAJE INT NOT NULL DEFAULT 0,
    CONSTRAINT PK_ORDEN_SERVICIO PRIMARY KEY (ID),
    CONSTRAINT FK_ORDEN_VEHICULO FOREIGN KEY (ID_VEHICULO) REFERENCES VEHICULO(ID)
);
GO

-- ============================================================================
-- 6. Tabla DETALLE_ORDEN (Tabla intermedia N:M de repuestos consumidos)
-- ============================================================================
CREATE TABLE DETALLE_ORDEN (
    ID INT IDENTITY(1,1) NOT NULL,
    ID_ORDEN INT NOT NULL,
    ID_REPUESTO INT NOT NULL,
    CANTIDAD INT NOT NULL,
    PRECIO_UNITARIO DECIMAL(18,2) NOT NULL,
    CONSTRAINT PK_DETALLE_ORDEN PRIMARY KEY (ID),
    CONSTRAINT CK_DETALLE_CANTIDAD CHECK (CANTIDAD > 0),
    CONSTRAINT CK_DETALLE_PRECIO CHECK (PRECIO_UNITARIO >= 0),
    CONSTRAINT FK_DETALLE_ORDEN FOREIGN KEY (ID_ORDEN) REFERENCES ORDEN_SERVICIO(ID),
    CONSTRAINT FK_DETALLE_REPUESTO FOREIGN KEY (ID_REPUESTO) REFERENCES REPUESTO(ID)
);
GO

-- ============================================================================
-- DATOS DE PRUEBA (5 registros por tabla, excepto USUARIO)
-- ============================================================================

-- 1. CLIENTE (5 registros -> generarán IDs 1 a 5)
INSERT INTO CLIENTE (NOMBRE, APELLIDO, DNI, TELEFONO, EMAIL, FECHA_REGISTRO) VALUES
('Martín', 'Rodríguez', '30111222', '11-4521-8890', 'martin.rodriguez@email.com', GETDATE()),
('Sofía', 'Fernández', '27333444', '11-6234-1122', 'sofia.fernandez@email.com', GETDATE()),
('Lucas', 'Giménez', '32555666', '11-4890-2233', 'lucas.gimenez@email.com', GETDATE()),
('Valeria', 'Sosa', '29777888', '11-5341-7788', 'valeria.sosa@email.com', GETDATE()),
('Diego', 'Paz', '28999000', '11-4789-3300', 'diego.paz@email.com', GETDATE());
GO

-- 2. VEHICULO (5 registros -> generarán IDs 1 a 5, vinculados a CLIENTE 1..5)
INSERT INTO VEHICULO (ID_CLIENTE, PATENTE, MARCA, MODELO, ANIO, COLOR, KILOMETRAJE, FECHA_REGISTRO) VALUES
(1, 'AE452KL', 'Toyota', 'Corolla', 2020, 'Gris Plata', 50000, GETDATE()),
(2, 'AF890MN', 'Volkswagen', 'Amarok', 2022, 'Blanco', 42100, GETDATE()),
(3, 'AD123BC', 'Ford', 'Ranger', 2019, 'Negro', 115000, GETDATE()),
(4, 'AC741XY', 'Peugeot', '208', 2021, 'Azul', 31800, GETDATE()),
(5, 'AG369ZZ', 'Chevrolet', 'Cruze', 2023, 'Rojo', 18400, GETDATE());
GO

-- 3. REPUESTO (5 registros -> generarán IDs 1 a 5)
INSERT INTO REPUESTO (CODIGO, DESCRIPCION, PRECIO, STOCK_FISICO) VALUES
('REP-001', 'Filtro de aceite sintético', 15000.00, 10),
('REP-002', 'Aceite motor 5W-30 4L', 62000.00, 15),
('REP-003', 'Pastillas de freno delanteras', 48000.00, 12),
('REP-004', 'Filtro de aire motor', 19500.00, 20),
('REP-005', 'Kit distribución y bomba de agua', 175000.00, 6);
GO

-- 4. ORDEN_SERVICIO (5 registros -> generarán IDs 1 a 5, vinculados a VEHICULO 1..5)
INSERT INTO ORDEN_SERVICIO (ID_VEHICULO, FECHA_INGRESO, ID_TECNICO, FECHA_CIERRE, DIAGNOSTICO, ESTADO, MANO_OBRA, TOTAL_REPUESTOS, TOTAL, KILOMETRAJE) VALUES
(1, DATEADD(DAY, -5, GETDATE()), 1, DATEADD(DAY, -4, GETDATE()), 'Service preventivo: cambio de aceite y filtro', 'Finalizada', 25000.00, 15000.00, 40000.00, 50000),
(2, DATEADD(DAY, -3, GETDATE()), 1, NULL, 'Revisión de frenos delanteros y ruido en tren delantero', 'Presupuestada', 30000.00, 48000.00, 78000.00, 42100),
(3, DATEADD(DAY, -2, GETDATE()), 2, DATEADD(DAY, -1, GETDATE()), 'Cambio de filtro de aire y aceite de motor', 'Finalizada', 28000.00, 81500.00, 109500.00, 115000),
(4, DATEADD(DAY, -1, GETDATE()), 1, NULL, 'Presupuesto de mantenimiento general', 'Presupuestada', 22000.00, 19500.00, 41500.00, 31800),
(5, GETDATE(), 2, NULL, 'Control de distribución programado', 'Presupuestada', 65000.00, 175000.00, 240000.00, 18400);
GO

-- 5. DETALLE_ORDEN (5 registros -> vinculados a ORDEN_SERVICIO 1..5 y REPUESTO 1..5)
INSERT INTO DETALLE_ORDEN (ID_ORDEN, ID_REPUESTO, CANTIDAD, PRECIO_UNITARIO) VALUES
(1, 1, 1, 15000.00),
(2, 3, 1, 48000.00),
(3, 2, 1, 62000.00),
(4, 4, 1, 19500.00),
(5, 5, 1, 175000.00);
GO