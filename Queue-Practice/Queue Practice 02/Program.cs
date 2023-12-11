//-----------Programa Principal----------------

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


