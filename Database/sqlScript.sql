USE [PetStore]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 22.3.2022. 01:08:30 ******/
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
/****** Object:  Table [dbo].[OrderPetToy]    Script Date: 22.3.2022. 01:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderPetToy](
	[OrdersId] [uniqueidentifier] NOT NULL,
	[PetToysId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_OrderPetToy] PRIMARY KEY CLUSTERED 
(
	[OrdersId] ASC,
	[PetToysId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 22.3.2022. 01:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[Id] [uniqueidentifier] NOT NULL,
	[CustomerFirstname] [nvarchar](max) NULL,
	[CustomerLastname] [nvarchar](max) NULL,
	[CustomerAddress] [nvarchar](max) NULL,
	[CustomerCreditCard] [nvarchar](max) NULL,
	[OrderDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PetToys]    Script Date: 22.3.2022. 01:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PetToys](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[Material] [nvarchar](max) NULL,
	[Price] [float] NOT NULL,
 CONSTRAINT [PK_PetToys] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220317223409_Initial', N'5.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220317224809_Initial2', N'5.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220317225528_NewMigration2', N'5.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220318000445_Test', N'5.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220321160407_FixPropName', N'5.0.0')
GO
INSERT [dbo].[OrderPetToy] ([OrdersId], [PetToysId]) VALUES (N'741ecdc3-5370-440f-f5f9-08da0b5ab462', N'40f27434-59ce-4a2e-b3dc-08da0a96112c')
INSERT [dbo].[OrderPetToy] ([OrdersId], [PetToysId]) VALUES (N'aa25e382-154a-4eab-dc25-08da0b8a6679', N'60872aec-71a1-4fbf-b3dd-08da0a96112c')
INSERT [dbo].[OrderPetToy] ([OrdersId], [PetToysId]) VALUES (N'aa25e382-154a-4eab-dc25-08da0b8a6679', N'85c42daf-e217-48d7-182f-08da0ac9b215')
INSERT [dbo].[OrderPetToy] ([OrdersId], [PetToysId]) VALUES (N'8689513b-c717-49b5-4d1f-08da0b8c2367', N'85c42daf-e217-48d7-182f-08da0ac9b215')
INSERT [dbo].[OrderPetToy] ([OrdersId], [PetToysId]) VALUES (N'741ecdc3-5370-440f-f5f9-08da0b5ab462', N'12d953a4-82ca-45fd-838d-08da0b46208f')
INSERT [dbo].[OrderPetToy] ([OrdersId], [PetToysId]) VALUES (N'26dce1c9-d90a-4244-685a-08da0b5bfd3a', N'12d953a4-82ca-45fd-838d-08da0b46208f')
INSERT [dbo].[OrderPetToy] ([OrdersId], [PetToysId]) VALUES (N'aa25e382-154a-4eab-dc25-08da0b8a6679', N'12d953a4-82ca-45fd-838d-08da0b46208f')
GO
INSERT [dbo].[Orders] ([Id], [CustomerFirstname], [CustomerLastname], [CustomerAddress], [CustomerCreditCard], [OrderDate]) VALUES (N'741ecdc3-5370-440f-f5f9-08da0b5ab462', N'Marko', N'Markovic', N'Banja Luka', N'676481878', CAST(N'2022-03-20T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Orders] ([Id], [CustomerFirstname], [CustomerLastname], [CustomerAddress], [CustomerCreditCard], [OrderDate]) VALUES (N'26dce1c9-d90a-4244-685a-08da0b5bfd3a', N'Pero', N'Peric', N'Ljubljana', N'1255598', CAST(N'2022-02-10T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Orders] ([Id], [CustomerFirstname], [CustomerLastname], [CustomerAddress], [CustomerCreditCard], [OrderDate]) VALUES (N'aa25e382-154a-4eab-dc25-08da0b8a6679', N'Ivan', N'Ivanic', N'Zagreb', N'333555', CAST(N'2022-03-21T23:30:22.0371624' AS DateTime2))
INSERT [dbo].[Orders] ([Id], [CustomerFirstname], [CustomerLastname], [CustomerAddress], [CustomerCreditCard], [OrderDate]) VALUES (N'8689513b-c717-49b5-4d1f-08da0b8c2367', N'Darko', N'Darkovic', N'Trebinje', N'998976', CAST(N'2022-02-10T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[PetToys] ([Id], [Name], [Description], [Material], [Price]) VALUES (N'40f27434-59ce-4a2e-b3dc-08da0a96112c', N'Mouse', N'Tire toy for cats', N'Tire', 52.6)
INSERT [dbo].[PetToys] ([Id], [Name], [Description], [Material], [Price]) VALUES (N'60872aec-71a1-4fbf-b3dd-08da0a96112c', N'Bone', N'Toy for dogs', N'Plastic', 28.91)
INSERT [dbo].[PetToys] ([Id], [Name], [Description], [Material], [Price]) VALUES (N'85c42daf-e217-48d7-182f-08da0ac9b215', N'Bird', N'Toy for cats', N'Unknown', 98.11)
INSERT [dbo].[PetToys] ([Id], [Name], [Description], [Material], [Price]) VALUES (N'8b29890e-be61-4f17-838b-08da0b46208f', N'TestToy', N'This is very expensive toy!', N'Plastic', 981.11)
INSERT [dbo].[PetToys] ([Id], [Name], [Description], [Material], [Price]) VALUES (N'12d953a4-82ca-45fd-838d-08da0b46208f', N'Ball', N'Toy for dogs', N'Tire', 65.51)
GO
ALTER TABLE [dbo].[OrderPetToy]  WITH CHECK ADD  CONSTRAINT [FK_OrderPetToy_Orders_OrdersId] FOREIGN KEY([OrdersId])
REFERENCES [dbo].[Orders] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrderPetToy] CHECK CONSTRAINT [FK_OrderPetToy_Orders_OrdersId]
GO
ALTER TABLE [dbo].[OrderPetToy]  WITH CHECK ADD  CONSTRAINT [FK_OrderPetToy_PetToys_PetToysId] FOREIGN KEY([PetToysId])
REFERENCES [dbo].[PetToys] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrderPetToy] CHECK CONSTRAINT [FK_OrderPetToy_PetToys_PetToysId]
GO
