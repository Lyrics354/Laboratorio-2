# Laboratorio #2: Clases en C#

📅 **Fecha:** 31/08/2026

## 📋 Contenido del Repositorio

Este repositorio contiene el desarrollo del **Laboratorio #2** de la asignatura *Herramientas de la Programación Aplicada III (.Net)*, enfocado en el **Modelado de Clases y Gestión de Atributos mediante Propiedades en C#**. Se abordan los conceptos fundamentales de la Programación Orientada a Objetos en C#: estructura de un programa por consola, declaración de clases, instanciación de objetos, métodos con y sin parámetros, variables de instancia, propiedades con descriptores `get`/`set`, y modificadores de acceso `public` y `private`.

## 🛠️ Tecnologías Utilizadas

- **Lenguaje / Framework:** C# (.NET 10.0)
- **IDE:** Visual Studio 2026
- **Tipo de proyecto:** Aplicación de Consola
- **Control de versiones:** Git / GitHub

## 💻 Capturas de Pantalla y Problemas

### Interfaz Principal

- **Actividad 1 – Estructura básica de una clase:**
En esta actividad se creó una aplicación de consola en C# con el objetivo de comprender la estructura fundamental de una clase y el proceso de instanciación de objetos. Se definió la clase LibroCalificacion, la cual contiene un único método público llamado MostrarMensaje(), cuya función es desplegar en pantalla un mensaje de bienvenida mediante Console.WriteLine.

Posteriormente, dentro del método Main (punto de entrada obligatorio de toda aplicación de consola en C#), se instanció un objeto de la clase mediante el operador new, asignándolo a la variable MyLibro. Una vez creado el objeto, se invocó el método MostrarMensaje() utilizando la notación de punto (MyLibro.MostrarMensaje();), lo que permitió comprobar que un método definido en una clase solo puede ejecutarse a través de una instancia (objeto) de dicha clase. Esta actividad permitió aplicar la convención de nomenclatura PascalCase en el nombre de la clase y reforzar el concepto de que Main se ejecuta automáticamente al correr el programa.

<img width="1471" height="335" alt="image" src="https://github.com/user-attachments/assets/85266dd5-b6ec-4642-b5b0-98ffc7ec5dba" />

- **Actividad 2 – Método con parámetro:**
En esta actividad se modificó la clase para incorporar el paso de argumentos entre objetos. Se creó la clase MiLibroCalificaciones con un método MostrarMensaje(string nombreCurso) que ahora recibe un parámetro de tipo string. Dentro del método, se utilizó Console.WriteLine junto con el marcador de posición {0} y el carácter de salto de línea \n para mostrar un mensaje personalizado que incluye el nombre del curso ingresado.

En el Main, se solicitó al usuario que ingresara el nombre de un curso mediante Console.ReadLine(), almacenando el valor en la variable nombreDelCurso. Este valor se pasó como argumento al llamar al método MostrarMensaje(nombreDelCurso), demostrando cómo el valor de una variable local en Main se transfiere al parámetro correspondiente del método al momento de la invocación.

<img width="1472" height="453" alt="image" src="https://github.com/user-attachments/assets/9293ebfc-f05c-4f49-b241-dbc3fa4952a8" />

- **Actividad 3 – Variables de instancia y propiedades:**
Esta actividad tuvo como propósito aplicar el concepto de encapsulamiento mediante variables de instancia y propiedades. Se declaró en la clase LibroCalificaciones un campo privado private string nombreCurso;, el cual, al estar fuera del cuerpo de cualquier método, conserva su valor durante toda la vida del objeto (variable de instancia).

Para permitir el acceso controlado a este campo privado sin exponerlo directamente, se implementó la propiedad pública NombreCurso, compuesta por:

-un descriptor get, que retorna el valor almacenado en nombreCurso; y
-un descriptor set, que asigna a nombreCurso el valor recibido mediante la palabra implícita value.

Además, se creó un constructor public LibroCalificaciones(string nombre) que inicializa la variable de instancia al momento de crear el objeto. El método MostrarMensaje() se modificó para que ya no reciba parámetros, sino que obtenga el nombre del curso a través de la propiedad NombreCurso, siguiendo la buena práctica de que los métodos de una clase manipulen sus variables de instancia a través de propiedades y no de forma directa. Esto demuestra el principio de ocultamiento de información (information hiding), donde el modificador private restringe el acceso a la variable solo a los miembros de la propia clase.

<img width="1467" height="462" alt="image" src="https://github.com/user-attachments/assets/2f21b971-9b08-4bfb-9e74-e925db35236d" />

## ▶️ Instrucciones de Ejecución / Uso

1. Clonar el repositorio:
```
https://github.com/Lyrics354/Laboratorio-2.git
```
2. Abrir la solución deseada (`.sln`) en **Visual Studio 2026**.
3. Verificar que el framework de destino sea **.NET 10.0**.
4. Compilar el proyecto (`Ctrl + Shift + B` o Compilar > Compilar solución).
5. Ejecutar la aplicación con **F5** o **Ctrl + F5** (sin depurar).
6. Seguir las instrucciones que se muestran en la consola (por ejemplo, ingresar el nombre del curso cuando se solicite).

## 👤 Autor y Contexto

- **Nombre:** Wilson Wu 2-756-299
- **Institución:** Universidad Tecnológica de Panamá (UTP) – Campus Víctor Levis Sasso
- **Grupo:** 1IL133
- **Instructor:** Ing. Irina Fong
- **Fecha de Realización:** 1/09/2026

## 🔗 Referencias

- Guía del Laboratorio #2: Clases en C#
- Documento guia para realizar repositorio github: [file:///C:/Users/wuwil/Downloads/Directrices%20del%20Resumen%20del%20Repositorio.pdf](https://virtual.utp.ac.pa/moodle/pluginfile.php/4964794/mod_resource/content/2/Directrices%20del%20Resumen%20del%20Repositorio.pdf)
- Documento guia para desarrollar este laboratorio: file:///C:/Users/wuwil/Downloads/%F0%9F%A7%AA%20Laboratorio%20%232%20Introducci%C3%B3n%20a%20Clases.pdf
