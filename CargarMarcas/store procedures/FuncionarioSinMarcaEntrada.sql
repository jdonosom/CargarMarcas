CREATE PROCEDURE FuncionarioSinMarcaEntrada
(
	@Fecha	char(8),
	@Unidad int = 0
)
AS
BEGIN

	 SELECT U.Descripcion
		  , U.Email AS CorreoUnidad
		  , F.IdEmpleado
		  ,	F.Rut
		  , F.ApellidoPaterno + ' ' + ApellidoMaterno + ' ' + Nombres AS NombreCompleto
		  , F.Email AS CorreoFuncionario
		  , F.Foto
		  , PF.Descripcion AS Permiso
		  , PF.FechaInicio
		  , PF.FechaTermino 
		  , R.Hora
		  , R.Fecha
		  , H.Descripcion AS Horario
	  FROM Funcionario F

	LEFT JOIN Registro R ON R.Id = F.IdEmpleado AND R.Fecha = @FECHA AND R.TipoMarca = 1
	LEFT JOIN FuncionarioUnidad FU ON FU.IdEmpleado = F.IdEmpleado 
	LEFT JOIN Unidad U ON U.IdUnidad = FU.IdUnidad
	LEFT JOIN HorarioFuncionario HF ON HF.IdEmpleado = F.IdEmpleado
	LEFT JOIN Horario H ON HF.IdHorario = H.IdHorario
	LEFT JOIN PermisoFuncionario PF ON PF.IdEmpleado = F.IdEmpleado 
			 AND (@FECHA >= CONVERT(char(8),PF.FechaInicio,112) AND @FECHA <= CONVERT(CHAR(8), PF.FechaTermino, 112) )
	WHERE FU.IdUnidad = @Unidad 
	   OR @Unidad = 0

END