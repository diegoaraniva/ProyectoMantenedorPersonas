CREATE PROCEDURE SP_Persona_RecuperaPersona
@cBusqueda VARCHAR(100),
@nFiltro INT
AS
BEGIN
	SELECT nIdPers,
		cApePersona,
		dFechaNacPersona,
		(SELECT TOP 1 cNameCategory FROM CategoryLookup WHERE nIdCategory = 1 AND nRefValue = PS.nIdGenero) AS nIdGenero,
		cDocumento,
		cDireccionPersonal,
		(SELECT TOP 1 cNameZone FROM ZoneLookup WHERE nIdZone = 1 AND nRefValue = PS.nIdZone) AS nIdZone,
		cDireccionTrabajo,
		cCorreoPersona,
		(SELECT TOP 1 cNameCategory FROM CategoryLookup WHERE nIdCategory = 2 AND nRefValue = PS.nIdEstadoCivil) AS nIdEstadoCivil,
		vFotoPersona
	FROM PersonaNatural PS
	WHERE PS.nIdEstadoCivil = @nFiltro 
		AND ((PS.cApePersona + ' ' + PS.cNomPersona) LIKE '%' + @cBusqueda + '%'
		OR PS.cDocumento = @cBusqueda
		OR PS.cCorreoPersona = @cBusqueda)
END