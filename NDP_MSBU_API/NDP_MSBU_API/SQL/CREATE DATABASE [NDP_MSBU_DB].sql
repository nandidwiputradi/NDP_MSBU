USE [master]
GO

/****** Object:  Database [NDP_MSBU_DB]    Script Date: 5/25/2023 12:37:45 PM ******/
CREATE DATABASE [NDP_MSBU_DB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'NDP_MSBU_DB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\NDP_MSBU_DB.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'NDP_MSBU_DB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\NDP_MSBU_DB_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

ALTER DATABASE [NDP_MSBU_DB] SET COMPATIBILITY_LEVEL = 120
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [NDP_MSBU_DB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [NDP_MSBU_DB] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [NDP_MSBU_DB] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [NDP_MSBU_DB] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [NDP_MSBU_DB] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [NDP_MSBU_DB] SET ARITHABORT OFF 
GO

ALTER DATABASE [NDP_MSBU_DB] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [NDP_MSBU_DB] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [NDP_MSBU_DB] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [NDP_MSBU_DB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [NDP_MSBU_DB] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [NDP_MSBU_DB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [NDP_MSBU_DB] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [NDP_MSBU_DB] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [NDP_MSBU_DB] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [NDP_MSBU_DB] SET  DISABLE_BROKER 
GO

ALTER DATABASE [NDP_MSBU_DB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [NDP_MSBU_DB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [NDP_MSBU_DB] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [NDP_MSBU_DB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [NDP_MSBU_DB] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [NDP_MSBU_DB] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [NDP_MSBU_DB] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [NDP_MSBU_DB] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [NDP_MSBU_DB] SET  MULTI_USER 
GO

ALTER DATABASE [NDP_MSBU_DB] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [NDP_MSBU_DB] SET DB_CHAINING OFF 
GO

ALTER DATABASE [NDP_MSBU_DB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [NDP_MSBU_DB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO

ALTER DATABASE [NDP_MSBU_DB] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [NDP_MSBU_DB] SET  READ_WRITE 
GO


