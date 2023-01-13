public class LinearSort {
    public void Execute(ref int[] numbers) {
        for (int i = 1; i < numbers.Length; i++) {
            int j = i;

            while(j > 0 && numbers[j] < numbers[j - 1]) {
                int temp = numbers[j];
                numbers[j] = numbers[j - 1];
                numbers[j - 1] = temp;
                j--;
            }
        }
    }
}