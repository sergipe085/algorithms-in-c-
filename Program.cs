// See https://aka.ms/new-console-template for more information
public class Program {
    static void Main(string[] args) {
        LinearSortAlgorithm();
        NBitBinaryAdditionAlgorithm();
        MergeSortAlgorithm();
    }

    private static void LinearSortAlgorithm() {
        int[] numbers = new int[] {
            5, 3, 8, 1
        };

        LinearSort linearSort = new LinearSort();
        linearSort.Execute(ref numbers);

        PrintNumberArray(numbers);
    }

    private static void NBitBinaryAdditionAlgorithm() {
        int[] A = new int[] { 1, 1, 0, 1 };
        int[] B = new int[] { 1, 0, 1, 1 };

        BinaryAddition binaryAddition = new BinaryAddition();

        int[]? result = binaryAddition.Execute(A, B);

        if (result != null) {
            PrintNumberArray(result);
        }
    }

    private static void MergeSortAlgorithm() {
        int[] numbers = new int[] { 43, 3, 64, 82, 21, 46, 87, 3, 9, 4, 76 };
        MergeSort mergeSort = new MergeSort();
        mergeSort.Execute(ref numbers, 0, numbers.Length - 1);

        PrintNumberArray(numbers);
    }

    public static void PrintNumberArray(int[] numbers) {
        foreach(int n1 in numbers) {
            Console.Write(n1 + ",");
        }
        Console.WriteLine("");
    }
}
