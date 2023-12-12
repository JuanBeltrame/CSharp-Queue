using Queue_Practice_03;

static Order[] RecieveOrderFromBranch01()
{
    // Creating new orders array
    Order[] orders = new Order[]
    {
        new Order(1,5),
        new Order(2,4),
        new Order(6,10)
    };

    return orders;
}

static Order[] RecieveOrderFromBranch02()
{
    // Creating a new orders array and initializing it with some objects of type Order
    Order[] orders = new Order[]
    {
        new Order(3,5),
        new Order(4,4),
        new Order(5,10)
    };

    // return the array of orders that we created
    return orders;
}

Queue<Order> ordersQueue = new Queue<Order>();

foreach(Order o in RecieveOrderFromBranch01())
{
    // add each order to the queue
    ordersQueue.Enqueue(o);
}

foreach (Order o in RecieveOrderFromBranch02())
{
    // add each order to the queue
    ordersQueue.Enqueue(o);
}

// as longs as the queue is not empty
while(ordersQueue.Count > 0)
{
    // remove the order At the front of the queue
    // and store it in a variable called currentOrder
    Order currentOrder = ordersQueue.Dequeue();
    // Process the order
    currentOrder.ProcessOrder();
    Thread.Sleep(900);
}