namespace SearchAlgorithms;
public class Program{
    public static void Main(){
        Search search = new Search();
        int[] A = {84, 21, 47,  96, 15};
        int found = search.LinearSearch(A, A.Length, 21);
        Console.WriteLine("Result: " + found);
    }
}