# Interfaces Inteligentes

- Hugo Hernández Martín (alu0101481227@ull.edu.es)

# Práctica 2: Introducción a C# y Scripts

En la presente práctica se han desarrollado diferentes ejercicios con el objetivo de introducirnos al uso del lenguaje de programación C# y la incorporación del mismo a los Scripts de Unity.

## Ejercicio 1: Cambio a color aleatorio cada 120 frames

El primer ejercicio consiste en realizar un programa que cambie el color de algún objeto, en este caso una esfera, un cubo y un cilindro. Para ello se ha hecho uso de la clase Random de Unity, del componente Renderer de los GameObject y de la clase Color de Unity. Además, es destacable que se ha dejado un atributo público en el Script que representa el número de frames que pasan para que se vuelva a cambiar el color a las figuras. Ésto se ha hecho con el fin de poder modificar el parámetro desde el inspector de Unity, como se observa a continuación:

![Gif Animado de la actividad 1](docs/p02-act1.gif)

[Código del Script del Ejercicio 1](Scripts/DynamicRandomColor.cs)

## Ejercicio 2: Creación de Escena e impresión de nombre por consola

En el segundo ejercicio se especifica que la escena creada ha de tener un plano, un cubo, una esfera y un cilindro. A todos los objetos se les asocia un material diferente (contenido en una carpeta Materials dentro de la carpeta Assets). Además, se añade a cada objeto un pequeño script que muestra su nombre (propiedad *name*).

![Gif Animado de la actividad 2](docs/p02-act2.gif)

[Código del Script del Ejercicio 2](Scripts/PrintName.cs)

## Ejercicio 3: Vector3 y sus métodos

En este ejercicio se han creado dos variables Vector3 públicas para que sean accesibles desde el inspector de Unity. Se han calculado diferentes operaciones (métodos de la clase Vector3) y se muestra el resultado en la consola y en el inspector.

![Gif Animado de la actividad 3](docs/p02-act3.gif)

[Código del Script del Ejercicio 3](Scripts/VectorProperties.cs)

## Ejercicio 4: Mostrar posición por consola


[Código del Script del Ejercicio 4]()

## Ejercicio 5: Cálculo de distancias entre diferentes objetos


[Código del Script del Ejercicio 5]()

## Ejercicio 6: Traslación de objetos a nuevas posiciones al pulsar una tecla


[Código del Script del Ejercicio 6]()

## Ejercicio 7: Cambiar color de objetos al pulsar teclas


[Código del Script del Ejercicio 7]()

## Ejercicio 8: Modificar escala y color según distancia entre diferentes objetos


[Código del Script del Ejercicio 8]()