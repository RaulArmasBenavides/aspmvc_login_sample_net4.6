 
-----------

CREATE PROCEDURE usp_Empleado_Valida
	@Nombre varchar(10),
	@Apellido varchar(20)
AS
	SELECT IdEmpleado,Apellidos,Nombre 
	From Empleados
	Where Nombre=@Nombre and Apellidos=@Apellido

RETURN 0

--------------