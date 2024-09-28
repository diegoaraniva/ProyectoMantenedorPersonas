CREATE PROCEDURE SP_Persona_EliminaPersona
@nIdPersona INT
AS
BEGIN
	DELETE PersonaNatural WHERE nIdPers = @nIdPersona
END