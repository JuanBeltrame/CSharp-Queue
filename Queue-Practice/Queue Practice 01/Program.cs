﻿using Queue_Practice_01;
using System.Drawing;
// Las Colecciones en C# son objetos, por lo tanto ademas, son tipos de referencia

// Forma 1: Declaracion y asignacion en una Linea sin valores iniciales
Queue<int> cola01 = new Queue<int>();

// Forma 2: Declaración y asignación en una línea sin valores iniciales con capacidad inicial especificada
Queue<int> cola02 = new Queue<int>(10);

// Forma 3: Declaración e inicialización en una sola línea con elementos
// Esta forma no se puede, o bien, desconozco como hacerlo

// Forma 4: Declaracion y asignacion en varias Lineas
Queue<int> cola04;
cola04 = new Queue<int>();

//---------------------------
// Forma 1: Declarar Objetos // Declaracion y asignacion en una Linea sin valores iniciales
Queue<Auto> autoCola01 = new Queue<Auto>();

// Forma 2: Declarar Objetos // Declaración y asignación en una línea sin valores iniciales con capacidad inicial especificada
Queue<Auto> autoCola02 = new Queue<Auto>(10);

// Forma 3: Declarar Objetos // Declaración e inicialización en una sola línea con elementos
Queue<Auto> autoPila03 = new Queue<Auto>(new Auto[]
{
   new Auto(1, 12343, Color.AliceBlue, 1000),
   new Auto(1, 12343, Color.AliceBlue, 1000),
   new Auto(1, 12343, Color.AliceBlue, 1000)
});

// Forma 4: Declarar Objetos // Declaracion y asignacion en varias Lineas
Queue<Auto> autoCola04;
autoCola04 = new Queue<Auto>();

