namespace SearchAlgorithms;
public class Program{
    public static void Main(){
        Search search = new Search();
        int[] A = {15,21,47,84,96};
        int found = search.BinaryIterative(A, A.Length, 100);
        Console.WriteLine("Result: " + found);
    }
}