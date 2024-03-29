USE [CrudDB]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 4/03/2024 11:28:14 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[DateBirth] [date] NOT NULL,
	[Gender] [char](2) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[add_users]    Script Date: 4/03/2024 11:28:14 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[add_users]

@name varchar(100),
@dateBirth date,
@gender char(1)
as
insert into Users (Name,DateBirth,Gender) values(@name,@dateBirth,@gender)
GO
/****** Object:  StoredProcedure [dbo].[delete_users]    Script Date: 4/03/2024 11:28:14 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[delete_users]
@id int
as
delete  from Users
where Id = @id
GO
/****** Object:  StoredProcedure [dbo].[search_users]    Script Date: 4/03/2024 11:28:14 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[search_users]
@data varchar(20)
as
select * from Users 
where Name like '%' + @data + '%'--buscara el nombre al principio o al final
GO
/****** Object:  StoredProcedure [dbo].[show_users]    Script Date: 4/03/2024 11:28:14 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[show_users]
as
select * from Users
order by Id desc
GO
/****** Object:  StoredProcedure [dbo].[update_users]    Script Date: 4/03/2024 11:28:14 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[update_users]
@id int,
@name varchar(100),
@dateBirth date,
@gender char(1)
AS

update Users set Name = @Name,DateBirth = @dateBirth,Gender = @gender
where Id = @id
GO
