namespace SearchAlgorithms;
public class Program{
    public static void Main(){
        Search search = new Search();
        int[] A = {15,21,47,84,96};
        int found = search.BinaryRecursive(A, 21, 0, A.Length-1);
        Console.WriteLine("Result: " + found);
    }
}