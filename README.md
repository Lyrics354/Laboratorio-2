# Laboratorio-2
## Actividades 1 al 3 
Reglas que use para poder programar cada consola:

1. Nomenclatura (Nombres de Clases)
Los nombres de clases SIEMPRE en PascalCase (mayúscula en cada palabra, sin espacios ni guiones bajos)

2. Estructura de Clases
Cada clase debe tener atributos privados (usa private para proteger datos). Declara propiedades públicas con get y set para acceder a esos datos de forma segura. Los métodos deben ser públicos si necesitan ser llamados desde fuera

3. Encapsulamiento
Las variables de instancia (campos) van con private
Las propiedades van con public
No expongas directamente los datos, usa propiedades como intermediarias

4. Métodos
Todo método debe tener una intención clara
Usa public void si no devuelve nada
Declara parámetros con tipos definidos (ej: string nombreCurso)

5. El Método Main()
Es el punto de entrada de tu programa (se ejecuta automáticamente)
Aquí creas los objetos, los inicializas y llamas a sus métodos
Formato obligatorio: public static void Main(string[] args)

6. Control de Errores y Validación
Valida la entrada de datos del usuario
Maneja conversiones de tipos (string a int, etc.)
Implementa try-catch si es necesario

7. Formato de Strings
Usa {0}, {1} etc. para insertar variables en texto, Ejemplo: Console.WriteLine("El curso es: {0}", nombreCurso);

## Actividad 1 - Crear la Clase LibroCalificaciones

Imagina que necesitas crear un sistema para un libro de calificaciones. En esta primera actividad vas a:

-Crear una clase simple llamada LibroCalificaciones

-Darle un método que solo muestre un mensaje de bienvenida cuando lo llames

-Crear un objeto (una instancia) de esa clase en tu Main()

-Llamar al método para que se ejecute


## Actividad 2 - Agregarle Parámetros al Método

Ahora vas a mejorar lo anterior. El problema con la Actividad 1 es que el mensaje siempre es igual. Así que aquí vas a:

-Modificar el método para que acepte un parámetro (por ejemplo, el nombre del curso)

-Pedir al usuario que ingrese el nombre del curso por teclado

-Pasar ese nombre al método para que lo muestre personalizado

Básicamente: en lugar de que el libro siempre diga "¡Bienvenido!", ahora dice "¡Bienvenido al curso de Matemáticas!" o el que el usuario haya ingresado. Es como darle al método "instrucciones personalizadas".

## Actividad 3: Variables de Instancia y Propiedades

Ahora vas a:

-Crear un campo privado llamado nombreCurso que guarde el nombre del curso dentro del objeto

-Crear una propiedad pública NombreCurso que tenga un get (para leer) y un set (para escribir)

-El usuario ingresa un nombre, lo guardas en la propiedad, y el objeto lo recuerda

-El método MostrarMensaje() ahora usa la propiedad en lugar de un parámetro

¿Por qué esto es importante? Porque ahora el objeto mantiene su propio estado. Si creas dos objetos LibroCalificaciones, cada uno recuerda su propio curso. Es como si cada libro tuviera memoria propia.
