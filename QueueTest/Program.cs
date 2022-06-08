namespace QueueTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> myQueue = new Queue<string>();
            myQueue.Enqueue("pierwszy w kolejce");
            myQueue.Enqueue("drugi w kolejce");
            myQueue.Enqueue("trzeci w kolejce");
            myQueue.Enqueue("ostatni w kolejce");

            // Metoda Peek "podgląda" pierwszy element bez usuwania go z kolejki.
            Console.WriteLine($"Metoda Peek() zwróciła: \n{myQueue.Peek()}");

            // Metoda Dequeue pobiera następny element z POCZĄTKU kolejki.
            Console.WriteLine($"Pierwsze wywołanie Dequeue() zwróciło: \n{myQueue.Dequeue()}");
            Console.WriteLine($"Drugie wywołanie Dequeue() zwróciło: \n{myQueue.Dequeue()}");

            // Metoda Clear usuwa wszystkie elementy z kolejki.
            Console.WriteLine($"Count przed wywołaniem Clear(): \n{myQueue.Count()}");
            myQueue.Clear();
            Console.WriteLine($"Count po wywołaniu Clear(): \n{myQueue.Count()}");
        }
    }
}