Console.WriteLine("Masukkan nama pelanggan");
string NamaPelnaggan = Console.ReadLine()!;

Console.WriteLine("Masukkan Jumlah Halaman");
int JumlahHalaman = int.Parse(Console.ReadLine()!);

Console.WriteLine("Masukkan Harga Per Halaman");
int HargaPerHalaman = int.Parse(Console.ReadLine()!);

int BiayaAdministrasi = 2000;

int subtotal = JumlahHalaman * HargaPerHalaman;
int totalbiaya = subtotal + BiayaAdministrasi;

Console.WriteLine($"Nama Pelanggan = {NamaPelanggan}");
Console.WriteLine($"Jumlah Halaman = {JumlahHalaman}");
Console.WriteLine($"Harga Perhalaman = {HargaPerHalaman}");
Console.WriteLine($"Subtotal = {subtotal}");
Console.WriteLine($"Biaya Admin = {BiayaAdministrasi}");
Console.WriteLine($"TotalBiaya = {totalbiaya}");