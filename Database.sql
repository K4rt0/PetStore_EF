CREATE DATABASE PetStore
GO
USE PetStore
GO
DROP TABLE IF EXISTS accounts
GO
DROP TABLE IF EXISTS Role
GO
CREATE TABLE Role (
	id int identity(1,1) PRIMARY KEY,
	DisplayName NVARCHAR(MAX) NOT NULL
)
GO
INSERT INTO Role(DisplayName) VALUES ('Admin')
GO
INSERT INTO Role(DisplayName) VALUES ('Staff')
GO
CREATE TABLE accounts (
	id int identity(1,1) PRIMARY KEY,
	DisplayName NVARCHAR(MAX) NOT NULL,
	Username NVARCHAR(50) NOT NULL,
	Password NVARCHAR(MAX) NOT NULL,
	Role int NOT NULL FOREIGN KEY REFERENCES Role(id)
)
GO
INSERT INTO accounts(DisplayName, Username, Password, Role) VALUES ('Admin', 'admin', '$2y$10$TOUcHPByiXyczgv8vb/HIuvLJAx5P4x/oNNA8LdsgK94E2Q0PpL5K', 1)
GO
INSERT INTO accounts(DisplayName, Username, Password, Role) VALUES ('Staff', 'staff', '$2y$10$2BLfmJlHeVHYhSoni6R0b.vzRGLUX7TKLrePJNVx7gPQd9ZdpgRKe', 2)
GO
GO
GO
GO
GO
GO
GO
GO
GO
GO
GO
GO
GO
GO
GO
GO
GO
GO
GO
GO
GO
GO
GO
GO