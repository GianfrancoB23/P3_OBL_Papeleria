USE [PapeleriaOBL]
GO
SET IDENTITY_INSERT [dbo].[Articulos] ON 

INSERT [dbo].[Articulos] ([Id], [PrecioVP], [CodigoProveedor_codigo], [Descripcion_Descripcion], [NombreArticulo_Nombre], [Stock_cantidad]) VALUES (1, 500, 1234567891231, N'Pack Hojas de tamaño A4', N'Hoja A4', 5000)
INSERT [dbo].[Articulos] ([Id], [PrecioVP], [CodigoProveedor_codigo], [Descripcion_Descripcion], [NombreArticulo_Nombre], [Stock_cantidad]) VALUES (2, 50, 9876543210981, N'Tijeras escolares', N'Tijeras', 2000)
INSERT [dbo].[Articulos] ([Id], [PrecioVP], [CodigoProveedor_codigo], [Descripcion_Descripcion], [NombreArticulo_Nombre], [Stock_cantidad]) VALUES (3, 90, 4561237894561, N'Cuadernos de 100 hojas', N'Cuaderno', 3000)
INSERT [dbo].[Articulos] ([Id], [PrecioVP], [CodigoProveedor_codigo], [Descripcion_Descripcion], [NombreArticulo_Nombre], [Stock_cantidad]) VALUES (4, 30, 7891234567891, N'Lápices HB', N'Lápiz HB', 10000)
INSERT [dbo].[Articulos] ([Id], [PrecioVP], [CodigoProveedor_codigo], [Descripcion_Descripcion], [NombreArticulo_Nombre], [Stock_cantidad]) VALUES (5, 1000, 3216549871231, N'Mochilas escolares', N'Mochila', 500)
INSERT [dbo].[Articulos] ([Id], [PrecioVP], [CodigoProveedor_codigo], [Descripcion_Descripcion], [NombreArticulo_Nombre], [Stock_cantidad]) VALUES (6, 25, 6549873214561, N'Gomas de borrar', N'Goma de borrar', 8000)
INSERT [dbo].[Articulos] ([Id], [PrecioVP], [CodigoProveedor_codigo], [Descripcion_Descripcion], [NombreArticulo_Nombre], [Stock_cantidad]) VALUES (7, 200, 7894561237819, N'Calculadoras científicas', N'Calculadora', 1500)
INSERT [dbo].[Articulos] ([Id], [PrecioVP], [CodigoProveedor_codigo], [Descripcion_Descripcion], [NombreArticulo_Nombre], [Stock_cantidad]) VALUES (8, 23, 1237896543121, N'Cartulinas de colores', N'Cartulina', 6000)
INSERT [dbo].[Articulos] ([Id], [PrecioVP], [CodigoProveedor_codigo], [Descripcion_Descripcion], [NombreArticulo_Nombre], [Stock_cantidad]) VALUES (9, 15, 4567891231987, N'Pegamento en barra', N'Pegamento', 7000)
INSERT [dbo].[Articulos] ([Id], [PrecioVP], [CodigoProveedor_codigo], [Descripcion_Descripcion], [NombreArticulo_Nombre], [Stock_cantidad]) VALUES (10, 30, 1122334451566, N'Bolígrafos azules', N'Bolígrafo', 12000)
INSERT [dbo].[Articulos] ([Id], [PrecioVP], [CodigoProveedor_codigo], [Descripcion_Descripcion], [NombreArticulo_Nombre], [Stock_cantidad]) VALUES (11, 28, 2233445516677, N'Resaltadores', N'Resaltador', 8000)
INSERT [dbo].[Articulos] ([Id], [PrecioVP], [CodigoProveedor_codigo], [Descripcion_Descripcion], [NombreArticulo_Nombre], [Stock_cantidad]) VALUES (12, 60, 3344556617788, N'Libretas de notas', N'Libreta', 5000)
INSERT [dbo].[Articulos] ([Id], [PrecioVP], [CodigoProveedor_codigo], [Descripcion_Descripcion], [NombreArticulo_Nombre], [Stock_cantidad]) VALUES (13, 150, 4455667718899, N'Grampas para engrapadora', N'Grampas', 15000)
INSERT [dbo].[Articulos] ([Id], [PrecioVP], [CodigoProveedor_codigo], [Descripcion_Descripcion], [NombreArticulo_Nombre], [Stock_cantidad]) VALUES (14, 17, 5566778891900, N'Notas adhesivas', N'Post-it', 9000)
SET IDENTITY_INSERT [dbo].[Articulos] OFF
GO
SET IDENTITY_INSERT [dbo].[Clientes] ON 

INSERT [dbo].[Clientes] ([Id], [razonSocial], [direccion_Calle], [direccion_Ciudad], [direccion_Distancia], [direccion_Numero], [rut_Rut]) VALUES (1, N'Pepsico SA', N'Minas', N'Montevideo', 125, 4558, 123456789123)
INSERT [dbo].[Clientes] ([Id], [razonSocial], [direccion_Calle], [direccion_Ciudad], [direccion_Distancia], [direccion_Numero], [rut_Rut]) VALUES (2, N'Apple Inc.', N'Wall Street', N'New York', 200, 1, 234567891234)
INSERT [dbo].[Clientes] ([Id], [razonSocial], [direccion_Calle], [direccion_Ciudad], [direccion_Distancia], [direccion_Numero], [rut_Rut]) VALUES (3, N'Microsoft Corp.', N'Silicon Valley', N'San Francisco', 300, 2, 345678912345)
INSERT [dbo].[Clientes] ([Id], [razonSocial], [direccion_Calle], [direccion_Ciudad], [direccion_Distancia], [direccion_Numero], [rut_Rut]) VALUES (4, N'Google LLC', N'Mountain View', N'San Francisco', 150, 1600, 456789123456)
INSERT [dbo].[Clientes] ([Id], [razonSocial], [direccion_Calle], [direccion_Ciudad], [direccion_Distancia], [direccion_Numero], [rut_Rut]) VALUES (5, N'Amazon.com Inc.', N'Broadway', N'New York', 120, 2121, 567891234567)
INSERT [dbo].[Clientes] ([Id], [razonSocial], [direccion_Calle], [direccion_Ciudad], [direccion_Distancia], [direccion_Numero], [rut_Rut]) VALUES (6, N'Facebook Inc.', N'Palo Alto', N'San Francisco', 180, 1601, 678912345678)
INSERT [dbo].[Clientes] ([Id], [razonSocial], [direccion_Calle], [direccion_Ciudad], [direccion_Distancia], [direccion_Numero], [rut_Rut]) VALUES (7, N'Alibaba Group', N'Hangzhou Road', N'Hangzhou', 250, 8899, 789123456789)
INSERT [dbo].[Clientes] ([Id], [razonSocial], [direccion_Calle], [direccion_Ciudad], [direccion_Distancia], [direccion_Numero], [rut_Rut]) VALUES (8, N'Samsung Electronics', N'Samsung Town', N'Seoul', 350, 44, 891234567890)
INSERT [dbo].[Clientes] ([Id], [razonSocial], [direccion_Calle], [direccion_Ciudad], [direccion_Distancia], [direccion_Numero], [rut_Rut]) VALUES (9, N'Toyota Motor Corp.', N'Toyota City', N'Aichi', 400, 1, 912345678901)
INSERT [dbo].[Clientes] ([Id], [razonSocial], [direccion_Calle], [direccion_Ciudad], [direccion_Distancia], [direccion_Numero], [rut_Rut]) VALUES (10, N'Coca-Cola Co.', N'North Avenue', N'Atlanta', 270, 711, 123456789012)
INSERT [dbo].[Clientes] ([Id], [razonSocial], [direccion_Calle], [direccion_Ciudad], [direccion_Distancia], [direccion_Numero], [rut_Rut]) VALUES (11, N'Walmart Inc.', N'Bentonville', N'Arkansas', 320, 702, 234567890123)
INSERT [dbo].[Clientes] ([Id], [razonSocial], [direccion_Calle], [direccion_Ciudad], [direccion_Distancia], [direccion_Numero], [rut_Rut]) VALUES (12, N'Johnson & Johnson', N'New Brunswick', N'New Jersey', 240, 1, 345678901234)
INSERT [dbo].[Clientes] ([Id], [razonSocial], [direccion_Calle], [direccion_Ciudad], [direccion_Distancia], [direccion_Numero], [rut_Rut]) VALUES (13, N'Nestlé SA', N'Vevey', N'Vaud', 310, 55, 456789012345)
INSERT [dbo].[Clientes] ([Id], [razonSocial], [direccion_Calle], [direccion_Ciudad], [direccion_Distancia], [direccion_Numero], [rut_Rut]) VALUES (14, N'Procter & Gamble', N'Procter Street', N'Cincinnati', 290, 1, 567890123456)
INSERT [dbo].[Clientes] ([Id], [razonSocial], [direccion_Calle], [direccion_Ciudad], [direccion_Distancia], [direccion_Numero], [rut_Rut]) VALUES (15, N'IBM Corp.', N'IBM Road', N'Armonk', 220, 5, 678901234567)
SET IDENTITY_INSERT [dbo].[Clientes] OFF
GO
SET IDENTITY_INSERT [dbo].[Pedidos] ON 

INSERT [dbo].[Pedidos] ([Id], [fechaPedido], [clienteId], [recargo], [entregaPrometida], [precioFinal], [entregado], [anulado], [Discriminator], [iva_valor]) VALUES (1, CAST(N'2024-05-16T16:06:58.7378925' AS DateTime2), 2, 0.05, 370, 1921.5, 0, 0, N'Comunes', 0.22)
INSERT [dbo].[Pedidos] ([Id], [fechaPedido], [clienteId], [recargo], [entregaPrometida], [precioFinal], [entregado], [anulado], [Discriminator], [iva_valor]) VALUES (2, CAST(N'2024-03-10T16:07:56.0000000' AS DateTime2), 11, 0.15, 3, 645.38, 1, 0, N'Express', 0.22)
INSERT [dbo].[Pedidos] ([Id], [fechaPedido], [clienteId], [recargo], [entregaPrometida], [precioFinal], [entregado], [anulado], [Discriminator], [iva_valor]) VALUES (3, CAST(N'2022-05-02T16:18:18.0000000' AS DateTime2), 10, 0.05, 594, 768.6, 0, 0, N'Comunes', 0.22)
INSERT [dbo].[Pedidos] ([Id], [fechaPedido], [clienteId], [recargo], [entregaPrometida], [precioFinal], [entregado], [anulado], [Discriminator], [iva_valor]) VALUES (4, CAST(N'2024-01-01T16:18:58.0000000' AS DateTime2), 15, 0.15, 1, 667.828, 0, 1, N'Express', 0.22)
INSERT [dbo].[Pedidos] ([Id], [fechaPedido], [clienteId], [recargo], [entregaPrometida], [precioFinal], [entregado], [anulado], [Discriminator], [iva_valor]) VALUES (5, CAST(N'2023-05-16T16:19:27.0000000' AS DateTime2), 7, 0.05, 13, 257342.652, 1, 0, N'Comunes', 0.22)
INSERT [dbo].[Pedidos] ([Id], [fechaPedido], [clienteId], [recargo], [entregaPrometida], [precioFinal], [entregado], [anulado], [Discriminator], [iva_valor]) VALUES (6, CAST(N'2023-10-16T16:19:42.0000000' AS DateTime2), 3, 0.05, 5, 512400, 0, 0, N'Comunes', 0.22)
INSERT [dbo].[Pedidos] ([Id], [fechaPedido], [clienteId], [recargo], [entregaPrometida], [precioFinal], [entregado], [anulado], [Discriminator], [iva_valor]) VALUES (7, CAST(N'2023-03-11T16:20:12.0000000' AS DateTime2), 3, 0.05, 19, 7173.5999999999995, 0, 1, N'Comunes', 0.22)
INSERT [dbo].[Pedidos] ([Id], [fechaPedido], [clienteId], [recargo], [entregaPrometida], [precioFinal], [entregado], [anulado], [Discriminator], [iva_valor]) VALUES (8, CAST(N'2024-03-20T16:20:48.0000000' AS DateTime2), 6, 0.05, 750, 23058, 0, 0, N'Comunes', 0.22)
INSERT [dbo].[Pedidos] ([Id], [fechaPedido], [clienteId], [recargo], [entregaPrometida], [precioFinal], [entregado], [anulado], [Discriminator], [iva_valor]) VALUES (9, CAST(N'2024-01-16T16:21:24.0000000' AS DateTime2), 12, 0.05, 8, 262605, 1, 0, N'Comunes', 0.22)
INSERT [dbo].[Pedidos] ([Id], [fechaPedido], [clienteId], [recargo], [entregaPrometida], [precioFinal], [entregado], [anulado], [Discriminator], [iva_valor]) VALUES (10, CAST(N'2024-04-30T16:22:48.0000000' AS DateTime2), 13, 0.05, 75, 84690.900000000009, 0, 0, N'Comunes', 0.8)
SET IDENTITY_INSERT [dbo].[Pedidos] OFF
GO
SET IDENTITY_INSERT [dbo].[LineasPedidos] ON 

INSERT [dbo].[LineasPedidos] ([Id], [ArticuloId], [Cantidad], [PrecioUnitarioVigente], [pedidoId]) VALUES (1, 13, 10, 150, 1)
INSERT [dbo].[LineasPedidos] ([Id], [ArticuloId], [Cantidad], [PrecioUnitarioVigente], [pedidoId]) VALUES (2, 8, 20, 23, 2)
INSERT [dbo].[LineasPedidos] ([Id], [ArticuloId], [Cantidad], [PrecioUnitarioVigente], [pedidoId]) VALUES (3, 12, 10, 60, 3)
INSERT [dbo].[LineasPedidos] ([Id], [ArticuloId], [Cantidad], [PrecioUnitarioVigente], [pedidoId]) VALUES (4, 11, 17, 28, 4)
INSERT [dbo].[LineasPedidos] ([Id], [ArticuloId], [Cantidad], [PrecioUnitarioVigente], [pedidoId]) VALUES (5, 10, 15, 30, 5)
INSERT [dbo].[LineasPedidos] ([Id], [ArticuloId], [Cantidad], [PrecioUnitarioVigente], [pedidoId]) VALUES (6, 14, 26, 17, 5)
INSERT [dbo].[LineasPedidos] ([Id], [ArticuloId], [Cantidad], [PrecioUnitarioVigente], [pedidoId]) VALUES (7, 5, 200, 1000, 5)
INSERT [dbo].[LineasPedidos] ([Id], [ArticuloId], [Cantidad], [PrecioUnitarioVigente], [pedidoId]) VALUES (8, 7, 2000, 200, 6)
INSERT [dbo].[LineasPedidos] ([Id], [ArticuloId], [Cantidad], [PrecioUnitarioVigente], [pedidoId]) VALUES (9, 11, 200, 28, 7)
INSERT [dbo].[LineasPedidos] ([Id], [ArticuloId], [Cantidad], [PrecioUnitarioVigente], [pedidoId]) VALUES (10, 12, 300, 60, 8)
INSERT [dbo].[LineasPedidos] ([Id], [ArticuloId], [Cantidad], [PrecioUnitarioVigente], [pedidoId]) VALUES (11, 5, 200, 1000, 9)
INSERT [dbo].[LineasPedidos] ([Id], [ArticuloId], [Cantidad], [PrecioUnitarioVigente], [pedidoId]) VALUES (12, 2, 100, 50, 9)
INSERT [dbo].[LineasPedidos] ([Id], [ArticuloId], [Cantidad], [PrecioUnitarioVigente], [pedidoId]) VALUES (13, 1, 20, 500, 10)
INSERT [dbo].[LineasPedidos] ([Id], [ArticuloId], [Cantidad], [PrecioUnitarioVigente], [pedidoId]) VALUES (14, 3, 20, 90, 10)
INSERT [dbo].[LineasPedidos] ([Id], [ArticuloId], [Cantidad], [PrecioUnitarioVigente], [pedidoId]) VALUES (15, 2, 29, 50, 10)
INSERT [dbo].[LineasPedidos] ([Id], [ArticuloId], [Cantidad], [PrecioUnitarioVigente], [pedidoId]) VALUES (16, 4, 20, 30, 10)
INSERT [dbo].[LineasPedidos] ([Id], [ArticuloId], [Cantidad], [PrecioUnitarioVigente], [pedidoId]) VALUES (17, 5, 20, 1000, 10)
INSERT [dbo].[LineasPedidos] ([Id], [ArticuloId], [Cantidad], [PrecioUnitarioVigente], [pedidoId]) VALUES (18, 6, 20, 25, 10)
INSERT [dbo].[LineasPedidos] ([Id], [ArticuloId], [Cantidad], [PrecioUnitarioVigente], [pedidoId]) VALUES (19, 7, 20, 200, 10)
INSERT [dbo].[LineasPedidos] ([Id], [ArticuloId], [Cantidad], [PrecioUnitarioVigente], [pedidoId]) VALUES (20, 8, 20, 23, 10)
INSERT [dbo].[LineasPedidos] ([Id], [ArticuloId], [Cantidad], [PrecioUnitarioVigente], [pedidoId]) VALUES (21, 9, 20, 15, 10)
INSERT [dbo].[LineasPedidos] ([Id], [ArticuloId], [Cantidad], [PrecioUnitarioVigente], [pedidoId]) VALUES (22, 10, 20, 30, 10)
INSERT [dbo].[LineasPedidos] ([Id], [ArticuloId], [Cantidad], [PrecioUnitarioVigente], [pedidoId]) VALUES (23, 11, 20, 28, 10)
INSERT [dbo].[LineasPedidos] ([Id], [ArticuloId], [Cantidad], [PrecioUnitarioVigente], [pedidoId]) VALUES (24, 12, 20, 60, 10)
INSERT [dbo].[LineasPedidos] ([Id], [ArticuloId], [Cantidad], [PrecioUnitarioVigente], [pedidoId]) VALUES (25, 13, 20, 150, 10)
INSERT [dbo].[LineasPedidos] ([Id], [ArticuloId], [Cantidad], [PrecioUnitarioVigente], [pedidoId]) VALUES (26, 14, 20, 17, 10)
SET IDENTITY_INSERT [dbo].[LineasPedidos] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuarios] ON 

INSERT [dbo].[Usuarios] ([Id], [Contrasenia_Valor], [Email_Direccion], [NombreCompleto_Apellido], [NombreCompleto_Nombre]) VALUES (1, N'Prueba123!', N'prueba@prueba.com', N'Apellido', N'Nombre')
INSERT [dbo].[Usuarios] ([Id], [Contrasenia_Valor], [Email_Direccion], [NombreCompleto_Apellido], [NombreCompleto_Nombre]) VALUES (2, N'Prueba123!', N'gbonanni@email.com', N'Bonanni', N'Gianfranco')
INSERT [dbo].[Usuarios] ([Id], [Contrasenia_Valor], [Email_Direccion], [NombreCompleto_Apellido], [NombreCompleto_Nombre]) VALUES (4, N'Prueba123!', N'mantunez@email.com', N'Antunez', N'Martin')
INSERT [dbo].[Usuarios] ([Id], [Contrasenia_Valor], [Email_Direccion], [NombreCompleto_Apellido], [NombreCompleto_Nombre]) VALUES (5, N'Prueba123!', N'gmoreno@email.com', N'Moreno', N'Gabriel')
INSERT [dbo].[Usuarios] ([Id], [Contrasenia_Valor], [Email_Direccion], [NombreCompleto_Apellido], [NombreCompleto_Nombre]) VALUES (6, N'Prueba123!', N'clugano@email.com', N'Lugano', N'Christian')
INSERT [dbo].[Usuarios] ([Id], [Contrasenia_Valor], [Email_Direccion], [NombreCompleto_Apellido], [NombreCompleto_Nombre]) VALUES (7, N'Prueba123!', N'jfonseca@email.com', N'Fonseca', N'Juan')
INSERT [dbo].[Usuarios] ([Id], [Contrasenia_Valor], [Email_Direccion], [NombreCompleto_Apellido], [NombreCompleto_Nombre]) VALUES (8, N'Prueba123!', N'igallas@email.com', N'Ismael', N'Gallas')
INSERT [dbo].[Usuarios] ([Id], [Contrasenia_Valor], [Email_Direccion], [NombreCompleto_Apellido], [NombreCompleto_Nombre]) VALUES (9, N'Prueba123!', N'mcuello@email.com', N'Cuello', N'Melissa')
INSERT [dbo].[Usuarios] ([Id], [Contrasenia_Valor], [Email_Direccion], [NombreCompleto_Apellido], [NombreCompleto_Nombre]) VALUES (10, N'Prueba123!', N'jostraujov@email.com', N'Ostraujov', N'Jennifer')
INSERT [dbo].[Usuarios] ([Id], [Contrasenia_Valor], [Email_Direccion], [NombreCompleto_Apellido], [NombreCompleto_Nombre]) VALUES (11, N'Prueba123!', N'emarsiglia@email.com', N'Marsiglia', N'Esteban')
INSERT [dbo].[Usuarios] ([Id], [Contrasenia_Valor], [Email_Direccion], [NombreCompleto_Apellido], [NombreCompleto_Nombre]) VALUES (12, N'Prueba123!', N'gmoreno31@gani', N'Moreno', N'Gabriel')
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
GO
