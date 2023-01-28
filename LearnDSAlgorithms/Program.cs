namespace LearnDSAlgorithms{
    public class Program{
        static void Main(){
            SumOfNumbers sumOfNumbers = new SumOfNumbers();
            Console.WriteLine($"Sum Using Formula: {sumOfNumbers.SumN(5)}");
            Console.WriteLine($"Sum Using Iteration: {sumOfNumbers.SumNIteration(5)}");
            Console.WriteLine($"Sum Using Recursion: {sumOfNumbers.SumNRecursion(5)}");
        }
    }
}
