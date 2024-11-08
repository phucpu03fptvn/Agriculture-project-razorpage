CREATE DATABASE [AgricultureManagement]

USE [AgricultureManagement]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 10/30/2024 7:42:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AgricultureCategories]    Script Date: 10/30/2024 7:42:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AgricultureCategories](
	[CategoryId] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
 CONSTRAINT [PK_AgricultureCategories] PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AgricultureProducts]    Script Date: 10/30/2024 7:42:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AgricultureProducts](
	[ProductId] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](max) NULL,
	[Price] [decimal](18, 2) NOT NULL,
	[StockQuantity] [int] NOT NULL,
	[Description] [nvarchar](max) NULL,
	[CategoryId] [int] NULL,
	[CreatedAt] [datetime2](7) NOT NULL,
	[UpdatedAt] [datetime2](7) NOT NULL,
	[Thumbnail] [nvarchar](max) NULL,
 CONSTRAINT [PK_AgricultureProducts] PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 10/30/2024 7:42:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[RoleId] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [nvarchar](max) NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 10/30/2024 7:42:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[Password] [nvarchar](max) NULL,
	[RoleId] [int] NOT NULL,
	[CreateAt] [datetime2](7) NOT NULL,
	[UpdateAt] [datetime2](7) NOT NULL,
	[Address] [nvarchar](max) NOT NULL,
	[DateOfBirth] [datetime2](7) NOT NULL,
	[PhoneNumber] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20241022084738_InitialCreate', N'6.0.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20241022182417_AddUserDetails', N'6.0.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20241028130615_ImageUpdate', N'6.0.8')
GO
SET IDENTITY_INSERT [dbo].[AgricultureCategories] ON 

INSERT [dbo].[AgricultureCategories] ([CategoryId], [CategoryName], [Description]) VALUES (1, N'Coffee', N'Various types of coffee products.')
INSERT [dbo].[AgricultureCategories] ([CategoryId], [CategoryName], [Description]) VALUES (2, N'Tea', N'Different varieties of tea.')
INSERT [dbo].[AgricultureCategories] ([CategoryId], [CategoryName], [Description]) VALUES (3, N'Herbs', N'Fresh herbs and spices.')
INSERT [dbo].[AgricultureCategories] ([CategoryId], [CategoryName], [Description]) VALUES (4, N'Seeds', N'Seeds for planting various crops.')
INSERT [dbo].[AgricultureCategories] ([CategoryId], [CategoryName], [Description]) VALUES (5, N'Vegetables', N'Fresh organic vegetables.')
INSERT [dbo].[AgricultureCategories] ([CategoryId], [CategoryName], [Description]) VALUES (6, N'Spices', N'A variety of spices for cooking.')
INSERT [dbo].[AgricultureCategories] ([CategoryId], [CategoryName], [Description]) VALUES (7, N'Honey', N'Natural honey from local beekeepers.')
INSERT [dbo].[AgricultureCategories] ([CategoryId], [CategoryName], [Description]) VALUES (8, N'Fruits', N'Fresh seasonal fruits.')
INSERT [dbo].[AgricultureCategories] ([CategoryId], [CategoryName], [Description]) VALUES (9, N'Garlic', N'Fresh garlic bulbs.')
INSERT [dbo].[AgricultureCategories] ([CategoryId], [CategoryName], [Description]) VALUES (10, N'Cucumbers', N'Crisp cucumbers for salads.')
SET IDENTITY_INSERT [dbo].[AgricultureCategories] OFF
GO
SET IDENTITY_INSERT [dbo].[AgricultureProducts] ON 

INSERT [dbo].[AgricultureProducts] ([ProductId], [ProductName], [Price], [StockQuantity], [Description], [CategoryId], [CreatedAt], [UpdatedAt], [Thumbnail]) VALUES (1, N'Arabica Coffee', CAST(150000.00 AS Decimal(18, 2)), 100, N'High quality arabica coffee beans.', 1, CAST(N'2024-10-22T17:04:23.5333333' AS DateTime2), CAST(N'2024-10-22T17:04:23.5333333' AS DateTime2), N'https://worldwidechocolate.com/wp-content/uploads/2023/09/Prova-Gourmet-Colombia-Arabica-Coffee-Extract-Label.png')
INSERT [dbo].[AgricultureProducts] ([ProductId], [ProductName], [Price], [StockQuantity], [Description], [CategoryId], [CreatedAt], [UpdatedAt], [Thumbnail]) VALUES (3, N'Green Tea', CAST(80000.00 AS Decimal(18, 2)), 150, N'Organic green tea leaves.', 2, CAST(N'2024-10-29T15:22:21.4033230' AS DateTime2), CAST(N'2024-10-29T15:22:21.4033235' AS DateTime2), N'https://i.pinimg.com/736x/2f/46/dd/2f46dddf2fef4e4a8f9759b7503b796e.jpg')
INSERT [dbo].[AgricultureProducts] ([ProductId], [ProductName], [Price], [StockQuantity], [Description], [CategoryId], [CreatedAt], [UpdatedAt], [Thumbnail]) VALUES (4, N'Black Tea', CAST(70000.00 AS Decimal(18, 2)), 120, N'Rich and aromatic black tea.', 2, CAST(N'2024-10-22T17:04:23.5333333' AS DateTime2), CAST(N'2024-10-22T17:04:23.5333333' AS DateTime2), N'http://keysofhealth.com/wp-content/uploads/2017/12/Black-tea-1024x727.jpg')
INSERT [dbo].[AgricultureProducts] ([ProductId], [ProductName], [Price], [StockQuantity], [Description], [CategoryId], [CreatedAt], [UpdatedAt], [Thumbnail]) VALUES (5, N'Basil', CAST(50000.00 AS Decimal(18, 2)), 200, N'Fresh basil leaves.', 3, CAST(N'2024-10-29T15:31:00.8397949' AS DateTime2), CAST(N'2024-10-29T15:31:00.8397954' AS DateTime2), N'https://www.tasteofhome.com/wp-content/uploads/2020/05/GettyImages-152891221.jpg')
INSERT [dbo].[AgricultureProducts] ([ProductId], [ProductName], [Price], [StockQuantity], [Description], [CategoryId], [CreatedAt], [UpdatedAt], [Thumbnail]) VALUES (6, N'Mint', CAST(70000.00 AS Decimal(18, 2)), 180, N'Fresh mint leaves.', 3, CAST(N'2024-10-30T12:06:31.3279998' AS DateTime2), CAST(N'2024-10-30T12:06:31.3280008' AS DateTime2), N'https://www.thespruce.com/thmb/okicoeSuE7_m0okpcVNDyKZvQIg=/4726x3151/filters:fill(auto,1)/types-of-mint-5120608-hero-7a3d6d0f70034bcc967080a6d7118967.jpg')
INSERT [dbo].[AgricultureProducts] ([ProductId], [ProductName], [Price], [StockQuantity], [Description], [CategoryId], [CreatedAt], [UpdatedAt], [Thumbnail]) VALUES (7, N'Sunflower Seeds', CAST(402000.00 AS Decimal(18, 2)), 250, N'Healthy sunflower seeds.', 4, CAST(N'2024-10-30T12:02:22.8480300' AS DateTime2), CAST(N'2024-10-30T12:02:22.8480304' AS DateTime2), N'https://www.thespruce.com/thmb/r8x-tSX2hwvkX1bclwSJbj0Mo34=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/save-sunflower-seeds-385625-hero-f5907ea55d434d6ca54cca445cf55a27.jpg')
INSERT [dbo].[AgricultureProducts] ([ProductId], [ProductName], [Price], [StockQuantity], [Description], [CategoryId], [CreatedAt], [UpdatedAt], [Thumbnail]) VALUES (8, N'Pumpkin Seeds', CAST(45000.00 AS Decimal(18, 2)), 220, N'Nutritious pumpkin seeds.', 4, CAST(N'2024-10-22T17:04:23.5333333' AS DateTime2), CAST(N'2024-10-22T17:04:23.5333333' AS DateTime2), N'https://c8.alamy.com/comp/A70145/food-medicinal-plant-pumpkin-pumkinseed-kernels-kuerbisskerne-A70145.jpg')
INSERT [dbo].[AgricultureProducts] ([ProductId], [ProductName], [Price], [StockQuantity], [Description], [CategoryId], [CreatedAt], [UpdatedAt], [Thumbnail]) VALUES (9, N'Cà chua bi', CAST(40000.00 AS Decimal(18, 2)), 300, N'Fresh organic tomatoes.', 5, CAST(N'2024-10-30T12:06:51.7470525' AS DateTime2), CAST(N'2024-10-30T12:06:51.7470529' AS DateTime2), N'https://img.lovepik.com/free-png/20211108/lovepik-cherry-tomatoes-png-image_400539785_wh1200.png')
INSERT [dbo].[AgricultureProducts] ([ProductId], [ProductName], [Price], [StockQuantity], [Description], [CategoryId], [CreatedAt], [UpdatedAt], [Thumbnail]) VALUES (10, N'Dưa leo', CAST(25000.00 AS Decimal(18, 2)), 280, N'Crisp cucumbers.', 5, CAST(N'2024-10-22T16:51:05.3779779' AS DateTime2), CAST(N'2024-10-22T16:51:05.3779783' AS DateTime2), N'https://www.freshpoint.com/wp-content/uploads/2020/02/freshpoint-english-cucumber-scaled.jpg')
INSERT [dbo].[AgricultureProducts] ([ProductId], [ProductName], [Price], [StockQuantity], [Description], [CategoryId], [CreatedAt], [UpdatedAt], [Thumbnail]) VALUES (15, N'Arabica Coffee', CAST(50.00 AS Decimal(18, 2)), 100, N'High-quality Arabica coffee beans', 1, CAST(N'2024-10-28T20:43:51.1600000' AS DateTime2), CAST(N'2024-10-28T20:43:51.1600000' AS DateTime2), N'https://worldwidechocolate.com/wp-content/uploads/2023/09/Prova-Gourmet-Colombia-Arabica-Coffee-Extract-Label.png')
INSERT [dbo].[AgricultureProducts] ([ProductId], [ProductName], [Price], [StockQuantity], [Description], [CategoryId], [CreatedAt], [UpdatedAt], [Thumbnail]) VALUES (17, N'Green Tea', CAST(30.00 AS Decimal(18, 2)), 200, N'Fresh and aromatic green tea leaves', 2, CAST(N'2024-10-28T20:43:51.1600000' AS DateTime2), CAST(N'2024-10-28T20:43:51.1600000' AS DateTime2), N'https://i.pinimg.com/736x/2f/46/dd/2f46dddf2fef4e4a8f9759b7503b796e.jpg')
INSERT [dbo].[AgricultureProducts] ([ProductId], [ProductName], [Price], [StockQuantity], [Description], [CategoryId], [CreatedAt], [UpdatedAt], [Thumbnail]) VALUES (18, N'Watermelon', CAST(1234.00 AS Decimal(18, 2)), 10, N'Watermelon for fresh summer!', 5, CAST(N'2024-10-29T15:00:29.1424867' AS DateTime2), CAST(N'2024-10-29T15:00:29.1424870' AS DateTime2), N'file:///D:/Ass01Solution_SE1705_NguyenHoangPhuc_SE173197/Ass01Solution_SE1705_NguyenHoangPhuc_SE173197/Assets/watermelon.jpg')
INSERT [dbo].[AgricultureProducts] ([ProductId], [ProductName], [Price], [StockQuantity], [Description], [CategoryId], [CreatedAt], [UpdatedAt], [Thumbnail]) VALUES (19, N'Cà chua bi hạng 1', CAST(130000.00 AS Decimal(18, 2)), 200, N'Cà chua bi được nhập khẩu từ Ý', 5, CAST(N'2024-10-30T12:08:18.9395328' AS DateTime2), CAST(N'2024-10-30T12:08:18.9395338' AS DateTime2), N'file:///D:/Ass01Solution_SE1705_NguyenHoangPhuc_SE173197/Ass01Solution_SE1705_NguyenHoangPhuc_SE173197/Assets/tomato.jpg')
SET IDENTITY_INSERT [dbo].[AgricultureProducts] OFF
GO
SET IDENTITY_INSERT [dbo].[Roles] ON 

INSERT [dbo].[Roles] ([RoleId], [RoleName]) VALUES (1, N'ADMIN')
INSERT [dbo].[Roles] ([RoleId], [RoleName]) VALUES (2, N'USER')
INSERT [dbo].[Roles] ([RoleId], [RoleName]) VALUES (3, N'STAFF')
SET IDENTITY_INSERT [dbo].[Roles] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([UserId], [Name], [Email], [Password], [RoleId], [CreateAt], [UpdateAt], [Address], [DateOfBirth], [PhoneNumber]) VALUES (1, N'Nguyen Hoang Phuc', N'admin@example.com', N'admin_password', 1, CAST(N'2024-10-22T19:20:03.7480000' AS DateTime2), CAST(N'2024-10-22T19:20:03.7480000' AS DateTime2), N'Phú Yên', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), N'0366658711')
INSERT [dbo].[Users] ([UserId], [Name], [Email], [Password], [RoleId], [CreateAt], [UpdateAt], [Address], [DateOfBirth], [PhoneNumber]) VALUES (2, N'Regular User', N'user@example.com', N'user_password', 2, CAST(N'2024-10-22T19:20:39.8676003' AS DateTime2), CAST(N'2024-10-22T19:20:39.8676007' AS DateTime2), N'TP.HCM', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), N'09212345678')
INSERT [dbo].[Users] ([UserId], [Name], [Email], [Password], [RoleId], [CreateAt], [UpdateAt], [Address], [DateOfBirth], [PhoneNumber]) VALUES (3, N'Staff User', N'staff@example.com', N'staff@@123', 3, CAST(N'2024-10-30T11:23:03.3132796' AS DateTime2), CAST(N'2024-10-30T11:23:03.3132799' AS DateTime2), N'Phú Yên', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), N'0123456789')
INSERT [dbo].[Users] ([UserId], [Name], [Email], [Password], [RoleId], [CreateAt], [UpdateAt], [Address], [DateOfBirth], [PhoneNumber]) VALUES (5, N'Phuc Pu', N'phucpu03@gmail.com', N'123456789', 1, CAST(N'2024-10-30T12:10:03.3296383' AS DateTime2), CAST(N'2024-10-30T12:10:03.3296383' AS DateTime2), N'Phu Yen', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), N'0123456789')
INSERT [dbo].[Users] ([UserId], [Name], [Email], [Password], [RoleId], [CreateAt], [UpdateAt], [Address], [DateOfBirth], [PhoneNumber]) VALUES (6, N'Phat 2', N'phat1923@gmail.com', N'fighting123', 3, CAST(N'2024-10-30T11:21:30.2249213' AS DateTime2), CAST(N'2024-10-30T11:21:30.2249217' AS DateTime2), N'Kontum', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), N'0981234567')
INSERT [dbo].[Users] ([UserId], [Name], [Email], [Password], [RoleId], [CreateAt], [UpdateAt], [Address], [DateOfBirth], [PhoneNumber]) VALUES (8, N'Vo Nguyen Nhu Ngoc', N'nhungoc@gmail.com', N'123456789', 3, CAST(N'2024-10-30T11:28:52.9298865' AS DateTime2), CAST(N'2024-10-30T11:28:52.9298868' AS DateTime2), N'Phú Yên', CAST(N'2003-08-14T00:00:00.0000000' AS DateTime2), N'0967456234')
INSERT [dbo].[Users] ([UserId], [Name], [Email], [Password], [RoleId], [CreateAt], [UpdateAt], [Address], [DateOfBirth], [PhoneNumber]) VALUES (10, N'Vo Thuy Hang', N'thuyhang002@gmail.com', N'thuyhang_password', 2, CAST(N'2024-10-30T12:11:20.2999850' AS DateTime2), CAST(N'2024-10-30T12:11:20.2999852' AS DateTime2), N'Phú Yên', CAST(N'2003-11-27T00:00:00.0000000' AS DateTime2), N'0356788991')
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
ALTER TABLE [dbo].[Users] ADD  DEFAULT (N'') FOR [Address]
GO
ALTER TABLE [dbo].[Users] ADD  DEFAULT ('0001-01-01T00:00:00.0000000') FOR [DateOfBirth]
GO
ALTER TABLE [dbo].[Users] ADD  DEFAULT (N'') FOR [PhoneNumber]
GO
ALTER TABLE [dbo].[AgricultureProducts]  WITH CHECK ADD  CONSTRAINT [FK_AgricultureProducts_AgricultureCategories_CategoryId] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[AgricultureCategories] ([CategoryId])
GO
ALTER TABLE [dbo].[AgricultureProducts] CHECK CONSTRAINT [FK_AgricultureProducts_AgricultureCategories_CategoryId]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Roles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[Roles] ([RoleId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Roles_RoleId]
GO
