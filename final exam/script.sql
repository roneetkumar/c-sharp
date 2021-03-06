USE [master]
GO
/****** Object:  Database [SMTI_Teacher_Course_Final]    Script Date: 4/17/2020 10:55:47 AM ******/
CREATE DATABASE [SMTI_Teacher_Course_Final]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SMTI_Teacher_Course_Final', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\SMTI_Teacher_Course_Final.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SMTI_Teacher_Course_Final_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\SMTI_Teacher_Course_Final_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [SMTI_Teacher_Course_Final] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SMTI_Teacher_Course_Final].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SMTI_Teacher_Course_Final] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SMTI_Teacher_Course_Final] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SMTI_Teacher_Course_Final] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SMTI_Teacher_Course_Final] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SMTI_Teacher_Course_Final] SET ARITHABORT OFF 
GO
ALTER DATABASE [SMTI_Teacher_Course_Final] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SMTI_Teacher_Course_Final] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SMTI_Teacher_Course_Final] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SMTI_Teacher_Course_Final] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SMTI_Teacher_Course_Final] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SMTI_Teacher_Course_Final] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SMTI_Teacher_Course_Final] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SMTI_Teacher_Course_Final] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SMTI_Teacher_Course_Final] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SMTI_Teacher_Course_Final] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SMTI_Teacher_Course_Final] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SMTI_Teacher_Course_Final] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SMTI_Teacher_Course_Final] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SMTI_Teacher_Course_Final] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SMTI_Teacher_Course_Final] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SMTI_Teacher_Course_Final] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SMTI_Teacher_Course_Final] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SMTI_Teacher_Course_Final] SET RECOVERY FULL 
GO
ALTER DATABASE [SMTI_Teacher_Course_Final] SET  MULTI_USER 
GO
ALTER DATABASE [SMTI_Teacher_Course_Final] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SMTI_Teacher_Course_Final] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SMTI_Teacher_Course_Final] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SMTI_Teacher_Course_Final] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SMTI_Teacher_Course_Final] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'SMTI_Teacher_Course_Final', N'ON'
GO
ALTER DATABASE [SMTI_Teacher_Course_Final] SET QUERY_STORE = OFF
GO
USE [SMTI_Teacher_Course_Final]
GO
/****** Object:  Table [dbo].[CourseAssignment]    Script Date: 4/17/2020 10:55:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CourseAssignment](
	[CourseId] [nvarchar](50) NOT NULL,
	[TeacherId] [int] NOT NULL,
	[AssignmentDate] [date] NULL,
 CONSTRAINT [PK_CourseAssignment] PRIMARY KEY CLUSTERED 
(
	[CourseId] ASC,
	[TeacherId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Courses]    Script Date: 4/17/2020 10:55:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Courses](
	[CourseId] [nvarchar](50) NOT NULL,
	[CourseName] [nvarchar](100) NULL,
 CONSTRAINT [PK_Courses] PRIMARY KEY CLUSTERED 
(
	[CourseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teachers]    Script Date: 4/17/2020 10:55:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teachers](
	[TeacherId] [int] NOT NULL,
	[Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_Teachers] PRIMARY KEY CLUSTERED 
(
	[TeacherId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 4/17/2020 10:55:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserId] [int] NOT NULL,
	[Password] [nvarchar](50) NULL,
	[JobTitle] [nvarchar](50) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CourseAssignment] ([CourseId], [TeacherId], [AssignmentDate]) VALUES (N'1111', 0, CAST(N'2020-02-01' AS Date))
INSERT [dbo].[Courses] ([CourseId], [CourseName]) VALUES (N'1111', N'IT')
INSERT [dbo].[Teachers] ([TeacherId], [Name]) VALUES (0, N'Roneet')
ALTER TABLE [dbo].[CourseAssignment]  WITH CHECK ADD  CONSTRAINT [FK_CourseAssignment_Courses] FOREIGN KEY([CourseId])
REFERENCES [dbo].[Courses] ([CourseId])
GO
ALTER TABLE [dbo].[CourseAssignment] CHECK CONSTRAINT [FK_CourseAssignment_Courses]
GO
ALTER TABLE [dbo].[CourseAssignment]  WITH CHECK ADD  CONSTRAINT [FK_CourseAssignment_Teachers] FOREIGN KEY([TeacherId])
REFERENCES [dbo].[Teachers] ([TeacherId])
GO
ALTER TABLE [dbo].[CourseAssignment] CHECK CONSTRAINT [FK_CourseAssignment_Teachers]
GO
/****** Object:  StoredProcedure [dbo].[forLogin]    Script Date: 4/17/2020 10:55:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[forLogin]  
 @username varchar(100),  
 @password varchar(100)  
AS  
BEGIN  
 SELECT UserId, Password  
 FROM Users 
 WHERE UserId = @username  
 AND Password = @password  
END
GO
USE [master]
GO
ALTER DATABASE [SMTI_Teacher_Course_Final] SET  READ_WRITE 
GO
