public class QuickSort
{
    public List<int> Execute(List<int> A) {
        if (A.Count < 2) {
            return A;
        }

        int pivo = A[0];
        List<int> menores = new List<int>();
        List<int> maiores = new List<int>();
        foreach(int i in A) {
            if (i < pivo) {
                menores.Add(i);
            }
            else {
                maiores.Add(i);
            }
        }

        return new List<int>(Execute(menores).Concat(new List<int>(pivo)).Concat(maiores));
    }
}