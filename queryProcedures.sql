--Procedures para realizar diferentes operaciones en la BD
--insertar Cliente
create procedure insertaCliente
	@cedula int,
	@nombre varchar(30),
	@apellido1 varchar(30),
	@apellido2 varchar(30),
	@ciudad varchar (30),
	@pais int,
	@correoElectronico varchar(30)
	as
	begin
		insert into Cliente values(@cedula, @nombre, @apellido1, @apellido2, @ciudad, @pais,@correoElectronico)
	end
--Actualizar servicios asignados del cliente
create procedure actualizaEstadoServicioCliente
	@idServicio int,
	@cedula int,
	@estadoServicio varchar(30) 
	as
	begin
		set nocount on
		update IntermediaClienteyServicio
		set
			estadoServicio = @estadoServicio
			from IntermediaClienteyServicio
			where IntermediaClienteyServicio.idServicio = @idServicio and IntermediaClienteyServicio.cedula = @cedula
	end