namespace SortingAlgorithms;
public class Program{
    static void Main(){
        Sort sort = new Sort();
        int[] A = {3,5,8,9,6,2};
        Console.Write($"Original Array: ");
        sort.Display(A);
        sort.QuickSort(A, 0, A.Length -1);
        Console.Write("Sorted Array: ");
        sort.Display(A);
    }
}