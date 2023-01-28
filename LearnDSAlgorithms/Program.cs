namespace LearnDSAlgorithms{
    public class Program{
        static void Main(){
            Factorial factorial = new Factorial();
            Console.WriteLine($"Factorial Iterative: {factorial.NFactorialIterative(5)}");
            Console.WriteLine($"Factorial Recursive: {factorial.NFactorialRecursion(5)}");
        }
    }
}
