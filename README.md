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

En esta actividad se creó una aplicación de consola en C# con el objetivo de comprender la estructura fundamental de una clase y el proceso de instanciación de objetos. Se definió la clase LibroCalificacion, la cual contiene un único método público llamado MostrarMensaje(), cuya función es desplegar en pantalla un mensaje de bienvenida mediante Console.WriteLine.

Posteriormente, dentro del método Main (punto de entrada obligatorio de toda aplicación de consola en C#), se instanció un objeto de la clase mediante el operador new, asignándolo a la variable MyLibro. Una vez creado el objeto, se invocó el método MostrarMensaje() utilizando la notación de punto (MyLibro.MostrarMensaje();), lo que permitió comprobar que un método definido en una clase solo puede ejecutarse a través de una instancia (objeto) de dicha clase. Esta actividad permitió aplicar la convención de nomenclatura PascalCase en el nombre de la clase y reforzar el concepto de que Main se ejecuta automáticamente al correr el programa.

<img width="1471" height="335" alt="image" src="https://github.com/user-attachments/assets/85266dd5-b6ec-4642-b5b0-98ffc7ec5dba" />


## Actividad 2 - Agregarle Parámetros al Método

En esta actividad se modificó la clase para incorporar el paso de argumentos entre objetos. Se creó la clase MiLibroCalificaciones con un método MostrarMensaje(string nombreCurso) que ahora recibe un parámetro de tipo string. Dentro del método, se utilizó Console.WriteLine junto con el marcador de posición {0} y el carácter de salto de línea \n para mostrar un mensaje personalizado que incluye el nombre del curso ingresado.

En el Main, se solicitó al usuario que ingresara el nombre de un curso mediante Console.ReadLine(), almacenando el valor en la variable nombreDelCurso. Este valor se pasó como argumento al llamar al método MostrarMensaje(nombreDelCurso), demostrando cómo el valor de una variable local en Main se transfiere al parámetro correspondiente del método al momento de la invocación.

<img width="1472" height="453" alt="image" src="https://github.com/user-attachments/assets/9293ebfc-f05c-4f49-b241-dbc3fa4952a8" />

## Actividad 3: Variables de Instancia y Propiedades

Esta actividad tuvo como propósito aplicar el concepto de encapsulamiento mediante variables de instancia y propiedades. Se declaró en la clase LibroCalificaciones un campo privado private string nombreCurso;, el cual, al estar fuera del cuerpo de cualquier método, conserva su valor durante toda la vida del objeto (variable de instancia).

Para permitir el acceso controlado a este campo privado sin exponerlo directamente, se implementó la propiedad pública NombreCurso, compuesta por:

un descriptor get, que retorna el valor almacenado en nombreCurso; y
un descriptor set, que asigna a nombreCurso el valor recibido mediante la palabra implícita value.

Además, se creó un constructor public LibroCalificaciones(string nombre) que inicializa la variable de instancia al momento de crear el objeto. El método MostrarMensaje() se modificó para que ya no reciba parámetros, sino que obtenga el nombre del curso a través de la propiedad NombreCurso, siguiendo la buena práctica de que los métodos de una clase manipulen sus variables de instancia a través de propiedades y no de forma directa. Esto demuestra el principio de ocultamiento de información (information hiding), donde el modificador private restringe el acceso a la variable solo a los miembros de la propia clase.

<img width="1467" height="462" alt="image" src="https://github.com/user-attachments/assets/2f21b971-9b08-4bfb-9e74-e925db35236d" />


¿Por qué esto es importante? Porque ahora el objeto mantiene su propio estado. Si creas dos objetos LibroCalificaciones, cada uno recuerda su propio curso. Es como si cada libro tuviera memoria propia.
