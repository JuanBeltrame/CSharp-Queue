using Queue_Practice_02;
using System.Drawing;
//-----------Programa Principal----------------

//---------------------------------------------
// Trabajando con Strings 
Queue<string> clientes = new Queue<string>();

clientes.Enqueue("Mauricio");
clientes.Enqueue("Lucas");
clientes.Enqueue("Laurato");

Console.WriteLine("--------------");
// Me devuelve el primer elemento que esta en la cola pero sin eliminarlo
Console.Write("Muetro el primero elemento de la cola: ");
Console.WriteLine(clientes.Peek());

Console.WriteLine("--------------");
foreach (string item in clientes)
{
    Console.WriteLine(item);
}

Console.WriteLine("--------------");
// Me devuelve el primer elemento que esta en la cola y lo elimina
Console.WriteLine(clientes.Dequeue());

Console.WriteLine("--------------");
foreach (string item in clientes)
{
    Console.WriteLine(item);
}


//---------------------------------------------
// Trabajando con Objetos
Queue<Auto> autosCola = new Queue<Auto>();


Auto auto01 = new Auto(2005, 123456, Color.Magenta, 20);
Auto auto02 = new Auto(2005, 123456, Color.Magenta, 20);
Auto auto03 = new Auto(2005, 123456, Color.Magenta, 20);

autosCola.Enqueue(auto01);
autosCola.Enqueue(auto02);
autosCola.Enqueue(auto03);

foreach(Auto item in autosCola)
{
    Console.WriteLine(item.GetCarInfo());
}

Console.WriteLine(autosCola.Peek().GetCarInfo());

//---------------------------------------------
// Another Example
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine(  );
Console.WriteLine("--------------");
Queue<int> queue = new Queue<int>();

queue.Enqueue(1);
// Printing the element at the front of the queue
Console.WriteLine("The value at the front of the queue is: {0}", queue.Peek());
queue.Enqueue(2);
Console.WriteLine("Top Value in the queue is : {0}", queue.Peek());
queue.Enqueue(3);
Console.WriteLine("Top Value in the queue is : {0}", queue.Peek());

Console.WriteLine();
while (queue.Count > 0)
{
    Console.WriteLine();
    // Dequeue() will return the element that was removed from the queue
    Console.WriteLine("The front value {0} was removed from the queue", queue.Dequeue());
    // Print the queue count
    Console.WriteLine("Current queue count is: {0}", queue.Count);
}