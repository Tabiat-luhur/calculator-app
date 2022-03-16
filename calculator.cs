class Calculator
{
statistic void Main(string[] args)
{
	// Melengkapi Fungsi Main
	int a = 10;
	int b = 6;
	
	Console.WriteLine("Hasil Penambahan : {0} + {1} = {2}", a, b, Penambahan(a, b));
	Console.WriteLine("Hasil Pengurangan : {0} - {1} = {2}", a, b, Pengurangan(a, b));
}
// Fungsi Penambahan
statistic int Penambahan(int a, int b){
	return a + b;
}
// Fungsi Pengurangan
statistic int Pengurangan(int a, int b) {
	return a - b;
}
}