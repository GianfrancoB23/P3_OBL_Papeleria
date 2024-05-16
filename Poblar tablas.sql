use PapeleriaOBL

insert into Usuarios (Contrasenia_Valor, Email_Direccion, NombreCompleto_Apellido, NombreCompleto_Nombre) values 
('Prueba123!', 'prueba@prueba.com', 'Apellido', 'Nombre'),
('Prueba123!', 'gbonanni@email.com', 'Bonanni', 'Gianfranco'),
('Prueba123!', 'gmoreira@email.com', 'Moreira', 'German'),
('Prueba123!', 'mantunez@email.com', 'Antunez', 'Martin'),
('Prueba123!', 'gmoreno@email.com', 'Moreno', 'Gabriel'),
('Prueba123!', 'clugano@email.com', 'Lugano', 'Christian'),
('Prueba123!', 'jfonseca@email.com', 'Fonseca', 'Juan'),
('Prueba123!', 'igallas@email.com', 'Ismael', 'Gallas'),
('Prueba123!', 'mcuello@email.com', 'Cuello', 'Melissa'),
('Prueba123!', 'jostraujov@email.com', 'Ostraujov', 'Jennifer'),
('Prueba123!', 'emarsiglia@email.com', 'Marsiglia', 'Esteban')

insert into Articulos(PrecioVP,CodigoProveedor_codigo, Descripcion_Descripcion, NombreArticulo_Nombre,Stock_cantidad) values
(500,1234567891231, 'Pack Hojas de tamaño A4', 'Hoja A4',5000),
(50, 9876543210981, 'Tijeras escolares', 'Tijeras', 2000),
(90, 4561237894561, 'Cuadernos de 100 hojas', 'Cuaderno', 3000),
(30, 7891234567891, 'Lápices HB', 'Lápiz HB', 10000),
(1000,3216549871231, 'Mochilas escolares', 'Mochila', 500),
(25,6549873214561, 'Gomas de borrar', 'Goma de borrar', 8000),
(200,7894561237819, 'Calculadoras científicas', 'Calculadora', 1500),
(23, 1237896543121, 'Cartulinas de colores', 'Cartulina', 6000),
(15, 4567891231987, 'Pegamento en barra', 'Pegamento', 7000),
(30, 1122334451566, 'Bolígrafos azules', 'Bolígrafo', 12000),
(28, 2233445516677, 'Resaltadores', 'Resaltador', 8000),
(60, 3344556617788, 'Libretas de notas', 'Libreta', 5000),
(150, 4455667718899, 'Grampas para engrapadora', 'Grampas', 15000),
(17, 5566778891900, 'Notas adhesivas', 'Post-it', 9000);

INSERT INTO Clientes (razonSocial, direccion_Calle, direccion_Ciudad, direccion_Distancia, direccion_Numero, rut_Rut) VALUES
('Pepsico SA', 'Minas', 'Montevideo', 125, 4558, '123456789123'),
('Apple Inc.', 'Wall Street', 'New York', 200, 1, '234567891234'),
('Microsoft Corp.', 'Silicon Valley', 'San Francisco', 300, 2, '345678912345'),
('Google LLC', 'Mountain View', 'San Francisco', 150, 1600, '456789123456'),
('Amazon.com Inc.', 'Broadway', 'New York', 120, 2121, '567891234567'),
('Facebook Inc.', 'Palo Alto', 'San Francisco', 180, 1601, '678912345678'),
('Alibaba Group', 'Hangzhou Road', 'Hangzhou', 250, 8899, '789123456789'),
('Samsung Electronics', 'Samsung Town', 'Seoul', 350, 44, '891234567890'),
('Toyota Motor Corp.', 'Toyota City', 'Aichi', 400, 1, '912345678901'),
('Coca-Cola Co.', 'North Avenue', 'Atlanta', 270, 711, '123456789012'),
('Walmart Inc.', 'Bentonville', 'Arkansas', 320, 702, '234567890123'),
('Johnson & Johnson', 'New Brunswick', 'New Jersey', 240, 1, '345678901234'),
('Nestlé SA', 'Vevey', 'Vaud', 310, 55, '456789012345'),
('Procter & Gamble', 'Procter Street', 'Cincinnati', 290, 1, '567890123456'),
('IBM Corp.', 'IBM Road', 'Armonk', 220, 5, '678901234567');

INSERT INTO Pedidos (fechaPedido, clienteId, recargo, entregaPrometida, precioFinal, Discriminator, iva_valor, entregado, anulado) values
('16/05/2024 11:45:12', 1, 0.05, 40, 877.485, 'Comunes', 0.22, false, false),
('14/05/2024 11:45:12', 2, 0.05, 25, 2882.25, 'Comunes', 0.22, false, false),
('12/05/2024 11:45:12', 3, 0.15, 3, 64.538, 'Express', 0.22, false, false),