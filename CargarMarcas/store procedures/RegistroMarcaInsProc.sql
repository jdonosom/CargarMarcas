--
--	Registrar o actualizar las marcas de empleados
--

CREATE PROCEDURE RegistroMarcaInsProc
(
	@Id		int,
	@Fecha  char(8),
	@Time   char(4),
	@Tipo	int,
	@Serie  varchar(20)
)
AS
BEGIN

	If( SELECT 1 FROM Registro 
		 WHERE Id        = @Id 
		   AND @Fecha    = CONVERT(char(8),Fecha,112) 
		   AND TipoMarca = @Tipo 
		   AND Serie     = @Serie ) = 1
	BEGIN
		UPDATE Registro 
		   SET Hora = @Time
		 WHERE Id        = @Id
		   AND CONVERT(char(8),Fecha,112) = @Fecha
		   AND TipoMarca = @Tipo
		   AND Serie     = @Serie
	END
	ELSE
	BEGIN
		INSERT Registro(Id, Fecha, Hora, TipoMarca, Serie) 
		VALUES(@Id, @Fecha, @Time, @Tipo, @Serie)
	END
END

