-- Script para crear la base de datos biblioteca
-- Ejecutar en MySQL Server con usuario root

-- Crear la base de datos
CREATE DATABASE IF NOT EXISTS biblioteca;
USE biblioteca;

-- Tabla de categorías
CREATE TABLE IF NOT EXISTS categorias (
    IDCategoria INT PRIMARY KEY AUTO_INCREMENT,
    Nombre VARCHAR(100) NOT NULL
);

-- Tabla de autores
CREATE TABLE IF NOT EXISTS autores (
    IDAutor INT PRIMARY KEY AUTO_INCREMENT,
    Nombre VARCHAR(100) NOT NULL,
    Apellido VARCHAR(100),
    Nacionalidad VARCHAR(100)
);

-- Tabla de editoriales
CREATE TABLE IF NOT EXISTS editoriales (
    IDEditorial INT PRIMARY KEY AUTO_INCREMENT,
    Nombre VARCHAR(100) NOT NULL,
    Direccion VARCHAR(200),
    Telefono VARCHAR(20)
);

-- Tabla de libros
CREATE TABLE IF NOT EXISTS libros (
    IDLibro INT PRIMARY KEY AUTO_INCREMENT,
    Titulo VARCHAR(200) NOT NULL,
    Fecha DATE,
    Paginas INT,
    categoria INT,
    autor INT,
    editorial INT,
    FOREIGN KEY (categoria) REFERENCES categorias(IDCategoria),
    FOREIGN KEY (autor) REFERENCES autores(IDAutor),
    FOREIGN KEY (editorial) REFERENCES editoriales(IDEditorial)
);

-- Insertar datos de ejemplo para categorías
INSERT INTO categorias (Nombre) VALUES 
('Acción'),
('Novela'),
('Infantil'),
('Ciencia Ficción'),
('Romance'),
('Terror'),
('Aventura');

-- Insertar datos de ejemplo para autores
INSERT INTO autores (Nombre, Apellido, Nacionalidad) VALUES 
('Gabriel', 'García Márquez', 'Colombiana'),
('Stephen', 'King', 'Americana'),
('J.K.', 'Rowling', 'Británica'),
('Mario', 'Vargas Llosa', 'Peruana'),
('Isabel', 'Allende', 'Chilena'),
('Jorge Luis', 'Borges', 'Argentina');

-- Insertar datos de ejemplo para editoriales
INSERT INTO editoriales (Nombre, Direccion, Telefono) VALUES 
('Adrex', 'Calle Principal 123', '555-0001'),
('Planeta', 'Avenida Central 456', '555-0002'),
('Alfaguara', 'Boulevard Norte 789', '555-0003'),
('Penguin Random House', 'Zona Sur 321', '555-0004'),
('Editorial Sudamericana', 'Centro Histórico 654', '555-0005');

-- Insertar datos de ejemplo para libros
INSERT INTO libros (Titulo, Fecha, Paginas, categoria, autor, editorial) VALUES 
('El Bosque Mágico', '2005-06-24', 59, 3, 3, 1),
('Cien Años de Soledad', '1967-05-30', 471, 2, 1, 2),
('It (Eso)', '1986-09-15', 1138, 6, 2, 3),
('Harry Potter y la Piedra Filosofal', '1997-06-26', 223, 3, 3, 4),
('La Casa de los Espíritus', '1982-10-01', 433, 2, 5, 5);

-- Verificar que las tablas se crearon correctamente
SHOW TABLES;

-- Mostrar algunos datos de ejemplo
SELECT 'CATEGORÍAS:' as Tabla;
SELECT * FROM categorias LIMIT 5;

SELECT 'AUTORES:' as Tabla;  
SELECT * FROM autores LIMIT 5;

SELECT 'EDITORIALES:' as Tabla;
SELECT * FROM editoriales LIMIT 5;

SELECT 'LIBROS:' as Tabla;
SELECT l.IDLibro, l.Titulo, l.Fecha, l.Paginas, 
       c.Nombre as Categoria, 
       CONCAT(a.Nombre, ' ', a.Apellido) as Autor,
       e.Nombre as Editorial
FROM libros l
JOIN categorias c ON l.categoria = c.IDCategoria
JOIN autores a ON l.autor = a.IDAutor  
JOIN editoriales e ON l.editorial = e.IDEditorial
LIMIT 5;