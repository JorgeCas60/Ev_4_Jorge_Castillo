using Ev_4_Jorge_Castillo.Modelo;

Console.WriteLine("Evaluación 4 - PAA");

using (EFContext db = new EFContext())
{
    /* 1) Obtener Editoriales cuyos Run estén entre 200000000 y 900000000,
          ordenados por Run de forma descendente */
    var editorialesOrdenadas = db.Editoriales
        .Where(x => x.Run >= 200000000 && x.Run <= 900000000)
        .OrderByDescending(x => x.Run)
        .ToList();

    Console.WriteLine("\nLista de Editoriales: ");
    foreach (var editoriales in editorialesOrdenadas)
    {
        Console.WriteLine($"ID: {editoriales.Id} | Nombre: {editoriales.Nombre} | Run: {editoriales.Run} | Fecha Creación: {editoriales.FechaCreacion.ToString("dd-MM-yyyy")}");
    }

    /* 2) Obtener el promedio del NroSerie de lo libros */
    double promedioNroSerie = db.Libros.Average(x => x.NroSerie);
    Console.WriteLine($"\nEl promedio del NroSerie del libro es: {promedioNroSerie}");

    /* 3) Obtener una sola Editorial a través de su FechaCreacion (1949-07-09 00:00:00) */
    var primero = db.Editoriales.FirstOrDefault(x => x.FechaCreacion == DateTime.Parse("1949-07-09 00:00:00"));
    Console.WriteLine($"\nEl registro es: ");
    Console.WriteLine($"ID: {primero.Id} | Nombre: {primero.Nombre} | Run: {primero.Run} | Fecha Creación: {primero.FechaCreacion.ToString("dd-MM-yyyy")}");

    /* 4) Insertar una nueva Editorial sin un ID existente aun, que posea
          las siguientes características:
          Nombre: "Ediciones Overol", Run: 245986543, FechaCreacion: El 10 de marzo del 2015
          No se poseen datos si esta Activo o no. 

    Editorial nuevaEditorial = new Editorial()
    {
        Id = 0,
        Nombre = "Ediciones Overol",
        FechaCreacion = Convert.ToDateTime("2015-03-10"),
        Estado = null,
        Run = 245986543
    };

    db.Editoriales.Add(nuevaEditorial);
    db.SaveChanges();
    */

    /* 5) Actualizar el nombre del Libro "El enfoque gestalt y testigos de terapia" a "SONIA TE ENVIO LOS CUADERNOS DE CAFE: APUNTES DE TERAPIA GESTALTICA" y su NroSerie de 200672 a 211512 
          a través de la búsqueda de su Id (101) 

    var libroEditar = db.Libros.FirstOrDefault(x => x.Id == 101);
    libroEditar.Nombre = "SONIA TE ENVIO LOS CUADERNOS DE CAFE: APUNTES DE TERAPIA GESTALTICA";
    libroEditar.NroSerie = 200672;

    db.Libros.Update(libroEditar);
    db.SaveChanges();
    */

    /* 6) Eliminar el Libro "MikelTube 3. Zombie Battle Royale"
         a través de la búsqueda de su Id (116) 

    var libroEliminar = db.Libros.FirstOrDefault(x => x.Id == 116);

    db.Libros.Remove(libroEliminar);
    db.SaveChanges();
    */
}
