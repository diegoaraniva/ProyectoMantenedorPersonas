CREATE TABLE PersonaNatural(
	nIdPers INT PRIMARY KEY IDENTITY,
	cNomPersona VARCHAR(50),
	cApePersona VARCHAR(50),
	dFechaNacPersona DATE,
	nIdGenero INT,
	cDocumento VARCHAR(25),
	cDireccionPersonal VARCHAR(50),
	nIdZone INT,
	cDireccionTrabajo VARCHAR(50),
	cCorreoPersona VARCHAR(25),
	nIdEstadoCivil INT,
	vFotoPersona VARBINARY(MAX)
)

CREATE TABLE ZoneLookup(
	nIdZone INT,
	cNameZone VARCHAR(100),
	nRefValue INT
)

CREATE TABLE CategoryLookup(
	nIdCategory INT,
	cNameCategory VARCHAR(100),
	nRefValue INT
)