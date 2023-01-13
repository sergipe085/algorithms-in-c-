// See https://aka.ms/new-console-template for more information
public class Program {
    static void Main(string[] args) {
        LinearSortAlgorithm();
        NBitBinaryAdditionAlgorithm();
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

    private static void PrintNumberArray(int[] numbers) {
        foreach(int n1 in numbers) {
            Console.Write(n1);
        }
        Console.WriteLine("");
    }
}
