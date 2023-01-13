public class BinaryAddition {
    public int[]? Execute(int[] A, int[] B) {
        if (A.Length != B.Length) return null;
        int n = A.Length;

        List<int> C = new List<int>();
        bool acumulated = false;

        for (int i = n - 1; i >= 0; i--) {
            int c = 0;

            int a = A[i];
            int b = B[i];

            int sum = acumulated ? a + b + 1 : a + b;
            acumulated = sum / 2 == 1;
            c = sum % 2;

            C.Add(c);
        }
        if (acumulated) {
            C.Add(1);
        }

        C.Reverse();

        return C.ToArray();
    }
}