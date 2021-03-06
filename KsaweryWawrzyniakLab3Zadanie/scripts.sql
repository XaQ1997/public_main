USE [master]
GO
/****** Object:  Database [KsaweryWawrzyniakLab3Zadanie]    Script Date: 10.12.2019 00:21:27 ******/
CREATE DATABASE [KsaweryWawrzyniakLab3Zadanie]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'KsaweryWawrzyniakLab3Zadanie', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\KsaweryWawrzyniakLab3Zadanie.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'KsaweryWawrzyniakLab3Zadanie_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\KsaweryWawrzyniakLab3Zadanie_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [KsaweryWawrzyniakLab3Zadanie] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [KsaweryWawrzyniakLab3Zadanie].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [KsaweryWawrzyniakLab3Zadanie] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [KsaweryWawrzyniakLab3Zadanie] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [KsaweryWawrzyniakLab3Zadanie] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [KsaweryWawrzyniakLab3Zadanie] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [KsaweryWawrzyniakLab3Zadanie] SET ARITHABORT OFF 
GO
ALTER DATABASE [KsaweryWawrzyniakLab3Zadanie] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [KsaweryWawrzyniakLab3Zadanie] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [KsaweryWawrzyniakLab3Zadanie] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [KsaweryWawrzyniakLab3Zadanie] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [KsaweryWawrzyniakLab3Zadanie] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [KsaweryWawrzyniakLab3Zadanie] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [KsaweryWawrzyniakLab3Zadanie] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [KsaweryWawrzyniakLab3Zadanie] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [KsaweryWawrzyniakLab3Zadanie] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [KsaweryWawrzyniakLab3Zadanie] SET  DISABLE_BROKER 
GO
ALTER DATABASE [KsaweryWawrzyniakLab3Zadanie] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [KsaweryWawrzyniakLab3Zadanie] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [KsaweryWawrzyniakLab3Zadanie] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [KsaweryWawrzyniakLab3Zadanie] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [KsaweryWawrzyniakLab3Zadanie] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [KsaweryWawrzyniakLab3Zadanie] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [KsaweryWawrzyniakLab3Zadanie] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [KsaweryWawrzyniakLab3Zadanie] SET RECOVERY FULL 
GO
ALTER DATABASE [KsaweryWawrzyniakLab3Zadanie] SET  MULTI_USER 
GO
ALTER DATABASE [KsaweryWawrzyniakLab3Zadanie] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [KsaweryWawrzyniakLab3Zadanie] SET DB_CHAINING OFF 
GO
ALTER DATABASE [KsaweryWawrzyniakLab3Zadanie] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [KsaweryWawrzyniakLab3Zadanie] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [KsaweryWawrzyniakLab3Zadanie] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'KsaweryWawrzyniakLab3Zadanie', N'ON'
GO
ALTER DATABASE [KsaweryWawrzyniakLab3Zadanie] SET QUERY_STORE = OFF
GO
USE [KsaweryWawrzyniakLab3Zadanie]
GO
/****** Object:  Table [dbo].[ChessRecords]    Script Date: 10.12.2019 00:21:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChessRecords](
	[RecordId] [int] IDENTITY(0,1) NOT NULL,
	[WhitePlayerName] [nvarchar](1) NULL,
	[BlackPlayerName] [nvarchar](1) NULL,
	[WinnerColour] [nvarchar](6) NULL,
	[Date] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[RecordId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Player]    Script Date: 10.12.2019 00:21:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Player](
	[PlayerId] [int] IDENTITY(0,1) NOT NULL,
	[PlayerName] [nvarchar](1) NULL,
	[Password] [nvarchar](1) NULL,
PRIMARY KEY CLUSTERED 
(
	[PlayerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Player__F528443FE3A11236]    Script Date: 10.12.2019 00:21:27 ******/
ALTER TABLE [dbo].[Player] ADD UNIQUE NONCLUSTERED 
(
	[PlayerName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ChessRecords]  WITH CHECK ADD FOREIGN KEY([BlackPlayerName])
REFERENCES [dbo].[Player] ([PlayerName])
GO
ALTER TABLE [dbo].[ChessRecords]  WITH CHECK ADD FOREIGN KEY([WhitePlayerName])
REFERENCES [dbo].[Player] ([PlayerName])
GO
ALTER TABLE [dbo].[ChessRecords]  WITH CHECK ADD CHECK  (([WinnerColour]='BIAŁE' OR [WinnerColour]='CZARNE' OR [WinnerColour]='Remis'))
GO
USE [master]
GO
ALTER DATABASE [KsaweryWawrzyniakLab3Zadanie] SET  READ_WRITE 
GO
