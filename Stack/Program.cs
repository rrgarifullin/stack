namespace Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Stack stack = new Stack("a", "b", "c");
                Console.WriteLine($"Размер стека: {stack.Size}");
                Console.WriteLine($"Верхний элемент стека: {stack.Top}");

                stack.Add("d");
                Console.WriteLine($"Размер стека: {stack.Size}");
                Console.WriteLine($"Верхний элемент стека: {stack.Top}");

                var deleted = stack.Pop();
                Console.WriteLine($"Удален элемент {deleted}");
                Console.WriteLine($"Размер стека: {stack.Size}");
                Console.WriteLine($"Верхний элемент стека: {stack.Top}");

                Stack stack2 = new Stack("1", "2", "3");
                stack.Merge(stack2);

                var mergedStack = Stack.Concat(new Stack("1", "2", "3"), new Stack("4", "5", "6"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
