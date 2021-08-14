USE [Test]
GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 11/08/2021 04:01:29 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleados](
	[IdEmpleado] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](60) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[Puesto] [varchar](60) NOT NULL,
	[Salario] [int] NOT NULL,
 CONSTRAINT [PK_Empleados] PRIMARY KEY CLUSTERED 
(
	[IdEmpleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[spCrudEmp]    Script Date: 11/08/2021 04:01:30 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spCrudEmp]
	@IdEmpleado int = null,
	@Nombre varchar(60) = null,
	@Email varchar(50)= null,
	@Puesto varchar(60) = null,
	@Salario int,
	@opc varchar(100) = null
AS
BEGIN	

	if @opc = 'Insert'
	begin 
		insert into Empleados values(@Nombre, @Email, @Puesto, @Salario)
	end

	if @opc = 'Update'
	begin 
		Update Empleados set Nombre=@Nombre, Email=@Email, Puesto=@Puesto, Salario=@Salario
		WHERE IdEmpleado=@IdEmpleado
	end

	if @opc = 'Delete'
	begin 
		Delete from Empleados WHERE IdEmpleado=@IdEmpleado
	end		
	
	if @opc = 'SelectId'
	begin 
		Select * from Empleados WHERE IdEmpleado=@IdEmpleado
	end

	if @opc = 'Select'
	begin
		Select * from Empleados
	end
END
GO
