CREATE PROCEDURE SP_Persona_AgregaPersona
@bActualiza BIT,
@nIdPersona VARCHAR(25),
@cNomPersona VARCHAR(50),
@cApePersona VARCHAR(50),
@dFechaNacPersona DATE,
@nIdGenero INT,
@cDocumento VARCHAR(25),
@cDireccionPersonal VARCHAR(50),
@nIdZone INT,
@cDireccionTrabajo VARCHAR(50),
@cCorreoPersona VARCHAR(25),
@nIdEstadoCivil INT,
@vFotoPersona VARBINARY(MAX)
AS
BEGIN
	IF @bActualiza = 0
	BEGIN
		INSERT INTO PersonaNatural(cNomPersona,
			cApePersona,
			dFechaNacPersona,
			nIdGenero,
			cDocumento,
			cDireccionPersonal,
			nIdZone,
			cDireccionTrabajo,
			cCorreoPersona,
			nIdEstadoCivil,
			vFotoPersona)
		VALUES
		(@cNomPersona,
		@cApePersona,
		@dFechaNacPersona,
		@nIdGenero,
		@cDocumento,
		@cDireccionPersonal,
		@nIdZone,
		@cDireccionTrabajo,
		@cCorreoPersona,
		@nIdEstadoCivil,
		@vFotoPersona)
	END
	ELSE
	BEGIN
		UPDATE PersonaNatural
		SET cNomPersona = @cNomPersona,
			cApePersona = @cApePersona,
			dFechaNacPersona = @dFechaNacPersona,
			nIdGenero = @nIdGenero,
			cDocumento = @cDocumento,
			cDireccionPersonal = @cDireccionPersonal,
			nIdZone = @nIdZone,
			cDireccionTrabajo = @cDireccionTrabajo,
			cCorreoPersona = @cCorreoPersona,
			nIdEstadoCivil = @nIdEstadoCivil,
			vFotoPersona = @vFotoPersona
		WHERE nIdPers = @nIdPersona
	END
END

