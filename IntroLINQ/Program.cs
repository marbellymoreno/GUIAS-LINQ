using IntroLinq;
using IntroLINQ;

#region Introducción 
// Definimos un arreglo de palabras y mostramos las que tienen más de 5 letras
string[] palabras;
palabras = new string[] { "gato", "perro", "lagarto", "tortuga", "cocdrilo", "serpiente", "123456789" };
Console.WriteLine("Mas de 5 letras");

List<string> resultado = new List<string>();

// Usamos un bucle para encontrar palabras con más de 5 letras
foreach (string str in palabras)
{
    if (str.Length > 5)
    {
        resultado.Add(str);
    }
}

// Mostramos el resultado
foreach (var r in resultado)
    Console.WriteLine(r);
#endregion

#region Utilizando Linq
// Usamos LINQ para encontrar palabras con más de 8 letras
Console.WriteLine("-----------------------------------------------------");
IEnumerable<string> list = from r in palabras where r.Length > 8 select r;
foreach (var listado in list)
    Console.WriteLine(listado);
Console.WriteLine("-----------------------------------------------------");
#endregion

#region Lista de Modelos
// Creamos listas para casas y habitantes
List<Casa> ListaCasas = new List<Casa>();
List<Habitante> ListaHabitantes = new List<Habitante>();
#endregion

#region Lista de Casas
// Añadimos casas a la lista
ListaCasas.Add(new Casa
{
    Id = 1,
    Direccion = "3 av Norte ArcanCity",
    Ciudad = "Gothan City",
    numeroHabitaciones = 20,
});
ListaCasas.Add(new Casa
{
    Id = 2,
    Direccion = "6 av Sur SmollVille",
    Ciudad = "Metropolis",
    numeroHabitaciones = 5,
});
ListaCasas.Add(new Casa
{
    Id = 3,
    Direccion = "Forest Hills, Queens, NY 11375",
    Ciudad = "New York"
});
#endregion

#region Lista de Habitantes
// Añadimos habitantes a la lista
ListaHabitantes.Add(new Habitante
{
    IdHabitante = 1,
    Nombre = "Bruno Diaz",
    Edad = 36,
    IdCasa = 1
});
ListaHabitantes.Add(new Habitante
{
    IdHabitante = 2,
    Nombre = "Clark Kent",
    Edad = 40,
    IdCasa = 2
});
ListaHabitantes.Add(new Habitante
{
    IdHabitante = 3,
    Nombre = "Peter Parker",
    Edad = 25,
    IdCasa = 3
});
ListaHabitantes.Add(new Habitante
{
    IdHabitante = 3,
    Nombre = "Tia Mey",
    Edad = 85,
    IdCasa = 3
});
ListaHabitantes.Add(new Habitante
{
    IdHabitante = 2,
    Nombre = "Luise Lain",
    Edad = 40,
    IdCasa = 2
});
ListaHabitantes.Add(new Habitante
{
    IdHabitante = 1,
    Nombre = "Selina Kyle",
    Edad = 30,
    IdCasa = 1
});
ListaHabitantes.Add(new Habitante
{
    IdHabitante = 1,
    Nombre = "Alfred",
    Edad = 65,
    IdCasa = 1
});
ListaHabitantes.Add(new Habitante
{
    IdHabitante = 1,
    Nombre = "Nathan Drake",
    Edad = 37,
    IdCasa = 1
});
#endregion

#region Sentencias LinQ

// Seleccionamos los habitantes con edad mayor a 40 usando LINQ
IEnumerable<Habitante> ListaEdad = from ObjetoProvicional
                                   in ListaHabitantes
                                   where ObjetoProvicional.Edad > 40
                                   select ObjetoProvicional;

// Mostramos los resultados
foreach (Habitante objetoProcicional2 in ListaEdad)
{
    Console.WriteLine(objetoProcicional2.datosHabitante());
}

// Hacemos un Join para encontrar habitantes en Gothan City
IEnumerable<Habitante> listaCasaGothan = from objetoTemporalHabitante in ListaHabitantes
                                         join objetoTemporalCasa in ListaCasas
                                         on objetoTemporalHabitante.IdHabitante equals objetoTemporalCasa.Id
                                         where objetoTemporalCasa.Ciudad == "Gothan City"
                                         select objetoTemporalHabitante;
Console.WriteLine("----------------------------------------------------------------------------------------------");
foreach (Habitante h in listaCasaGothan)
{
    Console.WriteLine(h.datosHabitante());
}

#endregion

#region First y FirstOrDefault
// Seleccionamos la primera casa
Console.WriteLine("----------------------------------------------------------------------------------------------");
var primeraCasa = ListaCasas.First();
Console.WriteLine(primeraCasa.dameDatosCasa());

// Seleccionamos el primer habitante mayor de 25 años
Habitante personaEdad = (from variableTemporalHabitante in ListaHabitantes where variableTemporalHabitante.Edad > 25 select variableTemporalHabitante).First();
Console.WriteLine(personaEdad.datosHabitante());

// Lo mismo pero con una expresión lambda
Console.WriteLine("---------------------------Lo mismo pero con lambdas---------------------------------------------------------");
var Habitante1 = ListaHabitantes.First(objectTemp => objectTemp.Edad > 25);
Console.WriteLine(Habitante1.datosHabitante());

// Usamos FirstOrDefault para evitar una excepción si no se encuentra el elemento
Casa CasaConFirsthOrDedault = ListaCasas.FirstOrDefault(vCasa => vCasa.Id > 200);
if (CasaConFirsthOrDedault == null)
{
    Console.WriteLine("No existe !No hay!");
    return;
}
Console.WriteLine("existe !Si existe!");

#endregion

#region Last
// Seleccionamos la última casa con Id mayor que 1
Casa ultimaCasa = ListaCasas.Last(temp => temp.Id > 1);
Console.WriteLine(ultimaCasa.dameDatosCasa());

// Seleccionamos el último habitante mayor de 60 años
Console.WriteLine("_____________________________________________________");
var h1 = (from objHabitante in ListaHabitantes where objHabitante.Edad > 60 select objHabitante)
    .LastOrDefault();
if (h1 == null)
{
    Console.WriteLine("Algo fallo");
    return;
}
Console.WriteLine(h1.datosHabitante());

#endregion

#region ElementAt
// Seleccionamos la tercera casa
var terceraCasa = ListaCasas.ElementAt(2);
Console.WriteLine($"La tercera casa es {terceraCasa.dameDatosCasa()}");

// Intentamos seleccionar una casa en la posición 3 (que no existe)
var casaError = ListaCasas.ElementAtOrDefault(3);
if (casaError != null) { Console.WriteLine($"La tercera casa es {casaError.dameDatosCasa()}"); }

// Seleccionamos el segundo habitante
var segundoHabitante = (from objetoTem in ListaHabitantes select objetoTem).ElementAtOrDefault(2);
Console.WriteLine($"El segundo habitante es: {segundoHabitante.datosHabitante()}");

#endregion

#region Single
// Usamos Single para seleccionar un único habitante en un rango de edad específico
try
{
    var habitantes = ListaHabitantes.Single(variableTem => variableTem.Edad > 40 && variableTem.Edad < 70);
    var habitante2 = (from obtem in ListaHabitantes where obtem.Edad > 70 select obtem).SingleOrDefault();

    Console.WriteLine($"Habitante con menos de 70 años: {habitantes.datosHabitante()}");
    if (habitante2 != null) Console.WriteLine($"Habitante con más de 70 años: {habitante2.datosHabitante()}");
}
catch (Exception)
{
    Console.WriteLine("Ocurrió un error");
}

#endregion

#region OfType
// Filtramos una lista de empleados por tipo usando OfType
var listaEmpleados = new List<Empleado>() {
    new Medico(){ nombre= "Jorge Casa" },
    new Enfermero(){ nombre = "Raul Blanco"}
};

var medico = listaEmpleados.OfType<Medico>();
Console.WriteLine(medico.Single().nombre);
#endregion

#region OrderBy
// Ordenamos la lista de habitantes por edad en orden ascendente
var edadA = ListaHabitantes.OrderBy(x => x.Edad);
var edadAC = from vt in ListaHabitantes orderby vt.Edad select vt;
foreach (var edad in edadAC)
{
    Console.WriteLine(edad.datosHabitante());
}
#endregion

#region OrderByDescending
// Ordenamos la lista de habitantes por edad en orden descendente
var listaEdad = ListaHabitantes.OrderByDescending(x => x.Edad);
foreach (Habitante h in listaEdad)
{
    Console.WriteLine(h.datosHabitante());
}
Console.WriteLine("-------------------------------------------");
var ListaEdad2 = from h in ListaHabitantes orderby h.Edad descending select h;
foreach (Habitante h in ListaEdad2)
{
    Console.WriteLine(h.datosHabitante());
}

#endregion

#region ThenBy
// Ordenamos por edad y luego por nombre en orden ascendente
var habitantes3 = ListaHabitantes.OrderBy(x => x.Edad).ThenBy(x => x.Nombre);
var edadATA = from h in ListaHabitantes orderby h.Edad, h.Nombre descending select h;

foreach (var h in edadATA)
{
    Console.WriteLine(h.datosHabitante());
}

Console.WriteLine("------------------");

#endregion

#region ThenByDescending
// Ordenamos por edad en orden ascendente y nombre en orden descendente
var habitantes4 = ListaHabitantes.OrderBy(x => x.Edad).ThenByDescending(x => x.Nombre);
var listaE = from x in ListaHabitantes orderby x.Edad, x.Nombre descending select x;

foreach (var h in listaE)
{
    Console.WriteLine(h.datosHabitante());
}
#endregion
