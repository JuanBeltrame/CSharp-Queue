// Las Colecciones en C# son objetos, por lo tanto ademas, son tipos de referencia

// Forma 1: Declaracion y asignacion en una Linea sin valores iniciales
Queue<int> cola01 = new Queue<int>();

// Forma 2: Declaración y asignación en una línea sin valores iniciales con capacidad inicial especificada
Queue<int> cola02 = new Queue<int>(10);

// Forma 3: Declaración e inicialización en una sola línea con elementos
Queue<int> cola03 = new Queue<int> { 1, 2, 3, 4, 5 };

// Forma 4: Declaracion y asignacion en varias Lineas
Queue<int> cola04;
cola04 = new Queue<int>();