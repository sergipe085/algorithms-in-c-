public class MergeSort {
    public void Merge(ref int[] numbers, int startIndex, int middleIndex, int endIndex) {
        List<int> numbersList = new List<int>(numbers);
        List<int> left = numbersList.GetRange(startIndex, middleIndex - startIndex + 1);
        List<int> right = numbersList.GetRange(middleIndex + 1, endIndex - middleIndex);

        int currentOutputIndex = startIndex;
        int leftIndex = 0;
        int rightIndex = 0;

        while (leftIndex < left.Count && rightIndex < right.Count) {
            if (left[leftIndex] < right[rightIndex]) {
                numbers[currentOutputIndex] = left[leftIndex];
                leftIndex++;
                currentOutputIndex++;
            }
            else {
                numbers[currentOutputIndex] = right[rightIndex];
                rightIndex++;
                currentOutputIndex++;
            }
        }

        while (leftIndex < left.Count) {
            numbers[currentOutputIndex] = left[leftIndex];
            leftIndex++;
            currentOutputIndex++;
        }

        while (rightIndex < right.Count) {
            numbers[currentOutputIndex] = right[rightIndex];
            rightIndex++;
            currentOutputIndex++;
        }
    }

    public void Execute(ref int[] numbers, int startIndex, int endIndex) {
        if (startIndex >= endIndex) {
            return;
        }

        int middleIndex = (startIndex + endIndex) / 2;

        Execute(ref numbers, startIndex, middleIndex);
        Execute(ref numbers, middleIndex + 1, endIndex);

        Merge(ref numbers, startIndex, middleIndex, endIndex);
    }
}