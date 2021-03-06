USE [master]
GO
/****** Object:  Database [CarRentalDB]    Script Date: 2020-12-09 11:17:11 AM ******/
CREATE DATABASE [CarRentalDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CarRentalDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\CarRentalDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CarRentalDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\CarRentalDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [CarRentalDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CarRentalDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CarRentalDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CarRentalDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CarRentalDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CarRentalDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CarRentalDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [CarRentalDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CarRentalDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CarRentalDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CarRentalDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CarRentalDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CarRentalDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CarRentalDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CarRentalDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CarRentalDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CarRentalDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CarRentalDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CarRentalDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CarRentalDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CarRentalDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CarRentalDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CarRentalDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CarRentalDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CarRentalDB] SET RECOVERY FULL 
GO
ALTER DATABASE [CarRentalDB] SET  MULTI_USER 
GO
ALTER DATABASE [CarRentalDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CarRentalDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CarRentalDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CarRentalDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CarRentalDB] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'CarRentalDB', N'ON'
GO
ALTER DATABASE [CarRentalDB] SET QUERY_STORE = OFF
GO
USE [CarRentalDB]
GO
/****** Object:  Table [dbo].[Branches]    Script Date: 2020-12-09 11:17:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Branches](
	[Branch_ID] [nchar](10) NOT NULL,
	[street_name] [nchar](20) NULL,
	[street_number] [nchar](10) NULL,
	[city] [nchar](20) NULL,
	[province] [nchar](20) NULL,
	[zip] [nchar](10) NULL,
	[phone_number] [varchar](50) NULL,
 CONSTRAINT [PK_Branches] PRIMARY KEY CLUSTERED 
(
	[Branch_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Car_types]    Script Date: 2020-12-09 11:17:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Car_types](
	[CarType] [nchar](30) NOT NULL,
	[price_D] [decimal](10, 2) NOT NULL,
	[price_W] [decimal](10, 2) NOT NULL,
	[price_M] [decimal](10, 2) NOT NULL,
 CONSTRAINT [PK_Car_types] PRIMARY KEY CLUSTERED 
(
	[CarType] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cars]    Script Date: 2020-12-09 11:17:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cars](
	[VIN] [nchar](10) NOT NULL,
	[Color] [nchar](20) NOT NULL,
	[Model] [nchar](40) NOT NULL,
	[CarType] [nchar](30) NOT NULL,
	[Branch_ID] [nchar](10) NOT NULL,
	[Available] [varchar](5) NULL,
 CONSTRAINT [PK_Cars] PRIMARY KEY CLUSTERED 
(
	[VIN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 2020-12-09 11:17:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[CustomerID] [nchar](10) NOT NULL,
	[first_name] [nchar](20) NOT NULL,
	[last_name] [nchar](20) NOT NULL,
	[Driving_License] [nchar](10) NOT NULL,
	[membership] [nchar](10) NULL,
	[street_name] [nchar](20) NULL,
	[street_number] [nchar](10) NULL,
	[apt_number] [nchar](10) NULL,
	[city] [nchar](20) NULL,
	[province] [nchar](20) NULL,
	[zip] [nchar](10) NULL,
	[phone_number] [nchar](20) NOT NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 2020-12-09 11:17:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[EID] [nchar](10) NOT NULL,
	[First_Name] [nchar](10) NOT NULL,
	[Last_Name] [nchar](10) NOT NULL,
	[Position] [nchar](10) NOT NULL,
	[Branch_ID] [nchar](10) NOT NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[EID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rental_Trans]    Script Date: 2020-12-09 11:17:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rental_Trans](
	[Rental_ID] [nchar](10) NOT NULL,
	[pickup_date] [date] NULL,
	[return_date] [date] NULL,
	[price] [float] NULL,
	[Customer_ID] [nchar](10) NOT NULL,
	[Employee_ID] [nchar](10) NOT NULL,
	[pickup_Branch_ID] [nchar](10) NULL,
	[return_Branch_ID] [nchar](10) NULL,
	[VIN] [nchar](10) NULL,
 CONSTRAINT [PK_Rental_Trans] PRIMARY KEY CLUSTERED 
(
	[Rental_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Branches] ([Branch_ID], [street_name], [street_number], [city], [province], [zip], [phone_number]) VALUES (N'1         ', N'RAINBOW STREET      ', N'123       ', N'EDMONTON            ', N'ALBERTA             ', N'123123    ', N'780-780-1234')
INSERT [dbo].[Branches] ([Branch_ID], [street_name], [street_number], [city], [province], [zip], [phone_number]) VALUES (N'2         ', N'145 STREET NW       ', N'9016      ', N'EDMONTON            ', N'ALBERTA             ', N'T5R0V2    ', N'780-443-5624')
INSERT [dbo].[Branches] ([Branch_ID], [street_name], [street_number], [city], [province], [zip], [phone_number]) VALUES (N'3         ', N'16 AVENUE           ', N'4913      ', N'CALGARY             ', N'ALBERTA             ', N'T2A0P1    ', N'403-313-4736')
INSERT [dbo].[Branches] ([Branch_ID], [street_name], [street_number], [city], [province], [zip], [phone_number]) VALUES (N'4         ', N'GROUSEWOODS CRES    ', N'5779      ', N'VANCOUVER           ', N'BRITISH COLUMBIA    ', N'V7R4V9    ', N'604-985-3838')
INSERT [dbo].[Branches] ([Branch_ID], [street_name], [street_number], [city], [province], [zip], [phone_number]) VALUES (N'5         ', N'RAMSAY ROAD         ', N'4537      ', N'VANCOUVER           ', N'BRITISH COLUMBIA    ', N'          ', N'604-986-7523')
INSERT [dbo].[Branches] ([Branch_ID], [street_name], [street_number], [city], [province], [zip], [phone_number]) VALUES (N'6         ', N'DUFFERIN STREET     ', N'2925      ', N'TORONTO             ', N'ONTARIO             ', N'M6B2G8    ', N'647-342-2158')
INSERT [dbo].[Branches] ([Branch_ID], [street_name], [street_number], [city], [province], [zip], [phone_number]) VALUES (N'7         ', N'BAYVIEW AVENUE      ', N'1710      ', N'TORONTO             ', N'ONTARIO             ', N'M4G3C4    ', N'416-250-7121')
INSERT [dbo].[Branches] ([Branch_ID], [street_name], [street_number], [city], [province], [zip], [phone_number]) VALUES (N'8         ', N'NEWMARKET AVENUE    ', N'52        ', N'TORONTO             ', N'ONTARIO             ', N'M4C1V9    ', N'416-463-55555')
INSERT [dbo].[Branches] ([Branch_ID], [street_name], [street_number], [city], [province], [zip], [phone_number]) VALUES (N'9         ', N'65 STREET NW        ', N'10045     ', N'EDMONTON            ', N'ALBERTA             ', N'T5A4K6    ', N'780-111-1111')
GO
INSERT [dbo].[Car_types] ([CarType], [price_D], [price_W], [price_M]) VALUES (N'HYBRID/ELECTRIC CAR           ', CAST(69.20 AS Decimal(10, 2)), CAST(229.48 AS Decimal(10, 2)), CAST(1416.87 AS Decimal(10, 2)))
INSERT [dbo].[Car_types] ([CarType], [price_D], [price_W], [price_M]) VALUES (N'LUXURY  CAR                   ', CAST(195.52 AS Decimal(10, 2)), CAST(1266.40 AS Decimal(10, 2)), CAST(3891.87 AS Decimal(10, 2)))
INSERT [dbo].[Car_types] ([CarType], [price_D], [price_W], [price_M]) VALUES (N'STANDARD CAR                  ', CAST(60.41 AS Decimal(10, 2)), CAST(229.48 AS Decimal(10, 2)), CAST(1294.42 AS Decimal(10, 2)))
INSERT [dbo].[Car_types] ([CarType], [price_D], [price_W], [price_M]) VALUES (N'SUV                           ', CAST(65.98 AS Decimal(10, 2)), CAST(368.88 AS Decimal(10, 2)), CAST(2328.95 AS Decimal(10, 2)))
INSERT [dbo].[Car_types] ([CarType], [price_D], [price_W], [price_M]) VALUES (N'TRUCK                         ', CAST(75.63 AS Decimal(10, 2)), CAST(392.88 AS Decimal(10, 2)), CAST(2635.53 AS Decimal(10, 2)))
INSERT [dbo].[Car_types] ([CarType], [price_D], [price_W], [price_M]) VALUES (N'VAN                           ', CAST(91.54 AS Decimal(10, 2)), CAST(563.61 AS Decimal(10, 2)), CAST(2549.39 AS Decimal(10, 2)))
GO
INSERT [dbo].[Cars] ([VIN], [Color], [Model], [CarType], [Branch_ID], [Available]) VALUES (N'1         ', N'BLACK               ', N'CHEVROLET TAHOE                         ', N'SUV                           ', N'1         ', N'YES')
INSERT [dbo].[Cars] ([VIN], [Color], [Model], [CarType], [Branch_ID], [Available]) VALUES (N'10        ', N'SILVER              ', N'JEEP WRANGLER UNLIMITED                 ', N'SUV                           ', N'2         ', N'YES')
INSERT [dbo].[Cars] ([VIN], [Color], [Model], [CarType], [Branch_ID], [Available]) VALUES (N'11        ', N'BROWN               ', N'FORD FUSION HYBRID                      ', N'HYBRID/ELECTRIC CAR           ', N'1         ', N'YES')
INSERT [dbo].[Cars] ([VIN], [Color], [Model], [CarType], [Branch_ID], [Available]) VALUES (N'2         ', N'WHITE               ', N'NISSAN QASHQAI                          ', N'SUV                           ', N'3         ', N'YES')
INSERT [dbo].[Cars] ([VIN], [Color], [Model], [CarType], [Branch_ID], [Available]) VALUES (N'3         ', N'RED                 ', N'FORD EDGE                               ', N'SUV                           ', N'3         ', N'YES')
INSERT [dbo].[Cars] ([VIN], [Color], [Model], [CarType], [Branch_ID], [Available]) VALUES (N'4         ', N'BLACK               ', N'BMW X1                                  ', N'SUV                           ', N'4         ', N'YES')
INSERT [dbo].[Cars] ([VIN], [Color], [Model], [CarType], [Branch_ID], [Available]) VALUES (N'5         ', N'WHITE               ', N'BMW X3                                  ', N'SUV                           ', N'1         ', N'YES')
INSERT [dbo].[Cars] ([VIN], [Color], [Model], [CarType], [Branch_ID], [Available]) VALUES (N'6         ', N'WHITE               ', N'CHEVY COLORADO                          ', N'TRUCK                         ', N'2         ', N'YES')
INSERT [dbo].[Cars] ([VIN], [Color], [Model], [CarType], [Branch_ID], [Available]) VALUES (N'7         ', N'BLACK               ', N'FORD F150 SUPER CREW                    ', N'TRUCK                         ', N'2         ', N'YES')
INSERT [dbo].[Cars] ([VIN], [Color], [Model], [CarType], [Branch_ID], [Available]) VALUES (N'8         ', N'WHITE               ', N'CHEVROLET SUBURBAN                      ', N'TRUCK                         ', N'1         ', N'YES')
INSERT [dbo].[Cars] ([VIN], [Color], [Model], [CarType], [Branch_ID], [Available]) VALUES (N'9         ', N'BLACK               ', N'DODGE DURANGO                           ', N'TRUCK                         ', N'1         ', N'YES')
GO
INSERT [dbo].[Customers] ([CustomerID], [first_name], [last_name], [Driving_License], [membership], [street_name], [street_number], [apt_number], [city], [province], [zip], [phone_number]) VALUES (N'1         ', N'Cecilia             ', N'Chapman             ', N'111111111 ', N'01        ', N'Nulla St.           ', N'2880      ', N'711       ', N'Mankato             ', N'Mississippi         ', N'96522     ', N'2575637401          ')
INSERT [dbo].[Customers] ([CustomerID], [first_name], [last_name], [Driving_License], [membership], [street_name], [street_number], [apt_number], [city], [province], [zip], [phone_number]) VALUES (N'10        ', N'Hu                  ', N'Park                ', N'630015664 ', NULL, N'Netus Rd.           ', N'1429      ', NULL, N'Reedsport           ', N'NY                  ', NULL, N'8748864174          ')
INSERT [dbo].[Customers] ([CustomerID], [first_name], [last_name], [Driving_License], [membership], [street_name], [street_number], [apt_number], [city], [province], [zip], [phone_number]) VALUES (N'11        ', N'Aaron               ', N'Trujillo            ', N'750025671 ', N'          ', NULL, NULL, NULL, N'Kingsport           ', N'NH                  ', NULL, N'9836328597          ')
INSERT [dbo].[Customers] ([CustomerID], [first_name], [last_name], [Driving_License], [membership], [street_name], [street_number], [apt_number], [city], [province], [zip], [phone_number]) VALUES (N'12        ', N'Jane                ', N'Doe                 ', N'123456789 ', N'          ', N'                    ', N'          ', N'          ', N'Edmonton            ', N'                    ', N'          ', N'7801112222          ')
INSERT [dbo].[Customers] ([CustomerID], [first_name], [last_name], [Driving_License], [membership], [street_name], [street_number], [apt_number], [city], [province], [zip], [phone_number]) VALUES (N'2         ', N'Iris                ', N'Watson              ', N'581146119 ', NULL, N'Fusce Rd.           ', N'8562      ', NULL, N'Frederick           ', N'Nebraska            ', N'20620     ', N'3725872335          ')
INSERT [dbo].[Customers] ([CustomerID], [first_name], [last_name], [Driving_License], [membership], [street_name], [street_number], [apt_number], [city], [province], [zip], [phone_number]) VALUES (N'3         ', N'Celeste             ', N'Slater              ', N'621133141 ', NULL, N'Ullamcorper. Street ', N'606-3727  ', NULL, N'Roseville           ', N'NH                  ', NULL, N'7867138616
        ')
INSERT [dbo].[Customers] ([CustomerID], [first_name], [last_name], [Driving_License], [membership], [street_name], [street_number], [apt_number], [city], [province], [zip], [phone_number]) VALUES (N'4         ', N'Theodore            ', N'Lowe                ', N'551412610 ', N'02        ', N'Sit Rd.             ', N'859       ', N'Ap #867   ', N'Azusa               ', N'New York            ', N'39531     ', N'7931516230          ')
INSERT [dbo].[Customers] ([CustomerID], [first_name], [last_name], [Driving_License], [membership], [street_name], [street_number], [apt_number], [city], [province], [zip], [phone_number]) VALUES (N'5         ', N'Zephania            ', N'Sanders             ', N'981891658 ', N'03        ', N'Nascetur St.        ', N'3714      ', NULL, N'Hawthorne           ', N'Louisiana           ', N'10626     ', N'5395673573          ')
INSERT [dbo].[Customers] ([CustomerID], [first_name], [last_name], [Driving_License], [membership], [street_name], [street_number], [apt_number], [city], [province], [zip], [phone_number]) VALUES (N'6         ', N'Hiram               ', N'Mullins             ', N'925418114 ', N'04        ', N'Nunc Ave            ', N'754-6427  ', NULL, N'Kennewick           ', N'AL                  ', N'41329     ', N'7169775775          ')
INSERT [dbo].[Customers] ([CustomerID], [first_name], [last_name], [Driving_License], [membership], [street_name], [street_number], [apt_number], [city], [province], [zip], [phone_number]) VALUES (N'7         ', N'Dante               ', N'Bennett             ', N'147411544 ', N'05        ', N'Nulla Street        ', N'8762      ', N'481       ', N'Dearborn            ', N'OR                  ', N'62401     ', N'8409879449          ')
INSERT [dbo].[Customers] ([CustomerID], [first_name], [last_name], [Driving_License], [membership], [street_name], [street_number], [apt_number], [city], [province], [zip], [phone_number]) VALUES (N'8         ', N'Dahlia              ', N'Lee                 ', N'282852876 ', NULL, N'Tincidunt Street    ', N'1293      ', NULL, N'Atwater             ', N'Pennsylvania        ', NULL, N'8823995084          ')
INSERT [dbo].[Customers] ([CustomerID], [first_name], [last_name], [Driving_License], [membership], [street_name], [street_number], [apt_number], [city], [province], [zip], [phone_number]) VALUES (N'9         ', N'Howard              ', N'Hayden              ', N'355827441 ', N'06        ', N'Massa Av.           ', N'1011      ', NULL, NULL, NULL, NULL, N'2877559948          ')
GO
INSERT [dbo].[Rental_Trans] ([Rental_ID], [pickup_date], [return_date], [price], [Customer_ID], [Employee_ID], [pickup_Branch_ID], [return_Branch_ID], [VIN]) VALUES (N'01        ', CAST(N'2020-05-06' AS Date), CAST(N'2020-05-13' AS Date), 1, N'2         ', N'1         ', N'3         ', N'3         ', N'2         ')
INSERT [dbo].[Rental_Trans] ([Rental_ID], [pickup_date], [return_date], [price], [Customer_ID], [Employee_ID], [pickup_Branch_ID], [return_Branch_ID], [VIN]) VALUES (N'02        ', CAST(N'2020-01-25' AS Date), CAST(N'2020-01-26' AS Date), 1, N'11        ', N'09        ', N'2         ', N'2         ', N'7         ')
INSERT [dbo].[Rental_Trans] ([Rental_ID], [pickup_date], [return_date], [price], [Customer_ID], [Employee_ID], [pickup_Branch_ID], [return_Branch_ID], [VIN]) VALUES (N'03        ', CAST(N'2019-08-14' AS Date), CAST(N'2019-08-26' AS Date), 1, N'3         ', N'4         ', N'2         ', N'2         ', N'6         ')
INSERT [dbo].[Rental_Trans] ([Rental_ID], [pickup_date], [return_date], [price], [Customer_ID], [Employee_ID], [pickup_Branch_ID], [return_Branch_ID], [VIN]) VALUES (N'04        ', CAST(N'2019-02-05' AS Date), CAST(N'2019-02-10' AS Date), 1, N'8         ', N'2         ', N'1         ', N'1         ', N'8         ')
INSERT [dbo].[Rental_Trans] ([Rental_ID], [pickup_date], [return_date], [price], [Customer_ID], [Employee_ID], [pickup_Branch_ID], [return_Branch_ID], [VIN]) VALUES (N'05        ', CAST(N'2021-01-01' AS Date), CAST(N'2021-01-09' AS Date), 1, N'11        ', N'05        ', N'2         ', N'2         ', N'10        ')
INSERT [dbo].[Rental_Trans] ([Rental_ID], [pickup_date], [return_date], [price], [Customer_ID], [Employee_ID], [pickup_Branch_ID], [return_Branch_ID], [VIN]) VALUES (N'06        ', CAST(N'2021-06-10' AS Date), CAST(N'2021-06-11' AS Date), 1, N'5         ', N'2         ', N'3         ', N'3         ', N'3         ')
GO
ALTER TABLE [dbo].[Cars]  WITH CHECK ADD  CONSTRAINT [FK_Cars_Branches] FOREIGN KEY([Branch_ID])
REFERENCES [dbo].[Branches] ([Branch_ID])
GO
ALTER TABLE [dbo].[Cars] CHECK CONSTRAINT [FK_Cars_Branches]
GO
ALTER TABLE [dbo].[Cars]  WITH CHECK ADD  CONSTRAINT [FK_Cars_Car_types] FOREIGN KEY([CarType])
REFERENCES [dbo].[Car_types] ([CarType])
GO
ALTER TABLE [dbo].[Cars] CHECK CONSTRAINT [FK_Cars_Car_types]
GO
ALTER TABLE [dbo].[Rental_Trans]  WITH CHECK ADD  CONSTRAINT [FK_Customer_ID] FOREIGN KEY([Customer_ID])
REFERENCES [dbo].[Customers] ([CustomerID])
GO
ALTER TABLE [dbo].[Rental_Trans] CHECK CONSTRAINT [FK_Customer_ID]
GO
ALTER TABLE [dbo].[Rental_Trans]  WITH NOCHECK ADD  CONSTRAINT [FK_Employee_ID] FOREIGN KEY([Employee_ID])
REFERENCES [dbo].[Employee] ([EID])
GO
ALTER TABLE [dbo].[Rental_Trans] NOCHECK CONSTRAINT [FK_Employee_ID]
GO
ALTER TABLE [dbo].[Rental_Trans]  WITH CHECK ADD  CONSTRAINT [FK_pickup_Branch_ID] FOREIGN KEY([pickup_Branch_ID])
REFERENCES [dbo].[Branches] ([Branch_ID])
GO
ALTER TABLE [dbo].[Rental_Trans] CHECK CONSTRAINT [FK_pickup_Branch_ID]
GO
ALTER TABLE [dbo].[Rental_Trans]  WITH CHECK ADD  CONSTRAINT [FK_return_Branch_ID] FOREIGN KEY([return_Branch_ID])
REFERENCES [dbo].[Branches] ([Branch_ID])
GO
ALTER TABLE [dbo].[Rental_Trans] CHECK CONSTRAINT [FK_return_Branch_ID]
GO
ALTER TABLE [dbo].[Rental_Trans]  WITH CHECK ADD  CONSTRAINT [FK_VIN] FOREIGN KEY([VIN])
REFERENCES [dbo].[Cars] ([VIN])
GO
ALTER TABLE [dbo].[Rental_Trans] CHECK CONSTRAINT [FK_VIN]
GO
USE [master]
GO
ALTER DATABASE [CarRentalDB] SET  READ_WRITE 
GO
