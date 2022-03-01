
# aspmvc_login_sample_net4.6
asp mvc model framework 4.6 using C# and sql server database model : Neptuno



using stored procedure : 
CREATE PROCEDURE usp_validar_empleado
	@Nombre varchar(10),
	@Apellido varchar(20)
AS
	SELECT IdEmpleado,Apellidos,Nombre 
	From Empleados
	Where Nombre=@Nombre and Apellidos=@Apellido

RETURN 0

 
