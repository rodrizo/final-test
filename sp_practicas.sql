USE ExamenDB
GO

/*
Creador: Rodney Rizo
Funcionalidad: SP para formulario de prácticas realizadas por estudiantes y profesores
*/
CREATE PROCEDURE sp_practicas (
	@action VARCHAR(10) = NULL,
	@idAlumno INT = NULL, 
	@idPractica INT = NULL, 
	@fecha DATETIME = NULL, 
	@nota INT = NULL,
	@idProfesor INT = NULL
)
AS
BEGIN
	SET NOCOUNT ON;

	IF (@action = 'C') --Create
	BEGIN
		INSERT INTO AlumnoPractica VALUES(@idAlumno, @idPractica, @fecha, @nota)
	END
	IF (@action = 'R') --Read
	BEGIN
		SELECT al.nombre [Nombre], STRING_AGG(p.titulo, ', ') [Prácticas] 
		FROM AlumnoPractica ap WITH(NOLOCK)
		INNER JOIN Practica p WITH(NOLOCK) ON ap.idPractica = p.idPractica
		INNER JOIN Alumno al WITH(NOLOCK) ON al.idAlumno = ap.idAlumno
		WHERE al.idAlumno = ISNULL(@idAlumno, al.idAlumno)
		GROUP BY al.idAlumno, al.nombre
	END
	IF (@action = 'RP') --Read professor
	BEGIN
		SELECT pr.nombre [Nombre], STRING_AGG(p.titulo, ', ') [Prácticas] 
		FROM ProfesorPractica ap WITH(NOLOCK)
		INNER JOIN Practica p WITH(NOLOCK) ON ap.idPractica = p.idPractica
		INNER JOIN Profesor pr WITH(NOLOCK) ON ap.idProfesor = pr.idProfesor
		WHERE pr.idProfesor = ISNULL(@idProfesor, pr.idProfesor)
		GROUP BY pr.idProfesor, pr.nombre
	END
END