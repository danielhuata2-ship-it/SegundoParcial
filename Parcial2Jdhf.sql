CREATE DATABASE Parcial2Jdhf;
USE master
GO

CREATE LOGIN usrparcial2 WITH PASSWORD = '12345678',
	CHECK_POLICY = ON,
	CHECK_EXPIRATION = OFF,
	DEFAULT_DATABASE = Parcial2Jdhf
GO
USE Parcial2Jdhf
GO
CREATE USER usrparcial2 FOR LOGIN usrparcial2
GO
ALTER ROLE db_owner ADD MEMBER usrparcial2
GO

DROP TABLE IF EXISTS Programa
DROP TABLE IF EXISTS Canal

CREATE TABLE Canal(
	id INT IDENTITY(1,1) PRIMARY KEY,
	nombre VARCHAR(50) NOT NULL,
	frecuencia VARCHAR(20),
	estado SMALLINT NOT NULL DEFAULT(1)
)

CREATE TABLE Programa(
	id INT IDENTITY(1, 1) PRIMARY KEY,
	idCanal INT NOT NULL,
	titulo VARCHAR(100) NOT NULL,
	descripcion VARCHAR(250) NOT NULL,
	duracion INT NOT NULL,
	productor VARCHAR(100) NOT NULL,
	fechaEstreno DATE NOT NULL,
	estado SMALLINT NOT NULL DEFAULT(1),
	clasificacion VARCHAR (15) NOT NULL,
	CONSTRAINT fk_Programa_Canal FOREIGN KEY (idCanal) REFERENCES Canal(id)
)

GO
DROP PROC IF EXISTS paCanalListar;
GO
CREATE PROC paCanalListar @parametro VARCHAR(50)
AS
BEGIN
    SELECT c.id, c.nombre, c.frecuencia, c.estado
    FROM Canal c
    WHERE c.estado > -1 
      AND (c.nombre + c.frecuencia) LIKE '%' + REPLACE(@parametro, ' ', '%') + '%'
    ORDER BY c.estado DESC, c.nombre ASC;
END;
GO

EXEC paCanalListar '';

GO
DROP PROC IF EXISTS paProgramaListar;
GO
CREATE PROC paProgramaListar @parametro VARCHAR(50)
AS
BEGIN
    SELECT p.id, p.idCanal, p.titulo, p.descripcion, p.duracion, p.productor, p.fechaEstreno, p.estado, p.clasificacion
    FROM Programa p
    WHERE p.estado > -1 
      AND (p.titulo + p.descripcion + p.productor + p.clasificacion) LIKE '%' + REPLACE(@parametro, ' ', '%') + '%'
    ORDER BY p.estado DESC, p.titulo ASC;
END;
GO

EXEC paProgramaListar '';

INSERT INTO Canal (nombre, frecuencia) VALUES
('Animal Planet', '100.1 FM'),
('Tyc Sports', '101.2 FM'),
('Cartoon Network', '102.3 FM');

INSERT INTO Programa (idCanal, titulo, descripcion, duracion, productor, fechaEstreno, clasificacion) VALUES
(1, 'Planet Earth', 'Una serie documental sobre el mundo natural', 60, 'BBC Studios', '2006-03-05', '13+'),
(2, 'Futbol Argentino', 'Retransmisión en directo de los partidos de fútbol argentino.', 120, 'Tyc Sports Productions', '2020-08-15', '16+'),
(3, 'Adventure Time', 'Una serie animada sobre las aventuras de Finn y Jake.', 30, 'Cartoon Network Studios', '2010-04-05', '18+');

