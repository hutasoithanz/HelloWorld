using HelloWorld.Logics;

/// Variabel adalah sebuah penampung nilai dalam programming. 
/// Variabel akan membooking tempat di memori sebagai penampung untuk nilai yang akan diberikan padanya.
/// Nilai ini dapat diisi sesuai tipe yang dipilih.
/// Bisa berupa angka (int, float, double), huruf (char, string) atau bahkan berupa object (Orang).
/// Dalam bahasa pemograman modern, bisa juga tipe ini tidak didefinisikan.
/// Misalnya dalam .NET tipe tanpa definisi adalah (var, obj).
/// 
/// Selain memiliki tipe, variabel juga memiliki sifat, 'static', 'final'/'readonly', 'const'.
/// 'static' variabel akan selalu ada di memori selama program berjalan.
/// 'final' atau 'readonly' akan memiliki value yang tidak dapat dirubah selama program berjalan.
/// 'const' memiliki sifat yang sama dengan 'final' atau 'readonly'.
/// Perbedaan 'const' dan 'readonly' ada di saat nilai diberikan. 'const' akan diberikan saat kompilasi
/// sementara 'readonly' akan memiliki nilai saat program dijalankan.
/// 
int angkaSatu = 0; // selalu berikan nilai untuk variabel ketika inisialisasi.
int angkaDua = 0;
/// Hello world adalah hal pertama yang dikenalkan dalam pemograman.
/// Ini menunjukkan pemogram menyapa dunia dengan program pertamanya.
Console.WriteLine("Hello, World!");
Console.WriteLine();
/// Conditional atau perbandingan bisa dilihat di sini.
Console.WriteLine("=================================================");
Console.WriteLine("==CONDITIONALS===================================");
Console.WriteLine("==CONDITIONAL IF=================================");
Console.Write("Masukkan angka pertama: ");
Int32.TryParse(Console.ReadLine(), out angkaSatu);
Console.Write("Masukkan angka ke dua: ");
Int32.TryParse(Console.ReadLine(), out angkaDua);
/// Berikut ini adalah pemanggilan sebuah nilai hasil pengerjaan fungsi yang dilakukan objek statis.
/// Arahkan kursor pada kata ContohConditionalIf lalu tekan F12 pada keyboard untuk mengetahui isi detil
/// dari fungsi tersebut.
Console.WriteLine(Conditional.ContohConditionalIf(angkaSatu, angkaDua));
Console.WriteLine("==CONDITIONAL SWITCH=============================");
Console.Write("Masukkan sebuah angka: ");
Int32.TryParse(Console.ReadLine(), out angkaDua);
Console.WriteLine(Conditional.ContohConditionalSwitch(angkaDua));
/// Iteration atau pengulangan bisa dilihat di sini.
Console.WriteLine("=================================================");
Console.WriteLine("==ITERATION======================================");
