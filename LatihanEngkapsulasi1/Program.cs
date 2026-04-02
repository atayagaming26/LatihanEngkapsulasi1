RekeningBank newRekening = new RekeningBank("272727");

string pilihan;
double jumlah;

while (true)
{
    Console.Clear();

    Console.WriteLine("Selamat datang di ATM Sangford");
    Console.WriteLine("1. Display Info Rekening");
    Console.WriteLine("2. Setor Uang");
    Console.WriteLine("3. Tarik Uang");
    Console.WriteLine("4. Keluar");
    Console.WriteLine("Pilihan Anda");
    pilihan = Console.ReadLine();

    if (pilihan == "1")
    {
        newRekening.DisplayInfo();
    }
    else if (pilihan == "2")
    {
        Console.Write("\nMasukkan Jumlah Uang: Rp");
        jumlah = double.Parse(Console.ReadLine());

        newRekening.SetorUang(jumlah);
    }
    else if (pilihan == "3")
    {
        Console.Write("\nMasukkan Jumlah Uang: Rp");
        jumlah = double.Parse(Console.ReadLine());

        newRekening.SetorUang(jumlah);
    }
    else if (pilihan == "4")
    {
        Console.WriteLine("Terima Kasih telah menggunakan ATM kami");
        break;
    }
    else
    {
        Console.WriteLine("Pilihan tidak valid");
    }
    Console.ReadLine();
}



public class RekeningBank
{
    private double _saldo;
    private string _noRekening;

    public double Saldo
    {
        get { return _saldo; }
        set
        {
            if (value >= 0) _saldo = value;
            else Console.WriteLine("Saldo tidak boleh negatif!");
        }
    }
    public string noRekening
    {
        get { return _noRekening; }
    }


    public RekeningBank(string norekening)
    {
        _saldo = 100000;
        _noRekening = norekening;

    }

    public void TarikUang(double jumlah)
    {
        if (jumlah > 0)
        {
            if (Saldo >= jumlah)
            {
                Saldo -= jumlah;
                Console.WriteLine("Berhasil tarik uang!");
            }
            else
            {
                Console.WriteLine("Saldo tidak cukup!");
            }
        }
        else
        {
            Console.WriteLine("Jumlah uang tidak valid!");
        }







    }

    public void SetorUang(double jumlah)
    {
        if (jumlah > 0)
        {
            Saldo += jumlah;
            Console.WriteLine("Berhasil setor uang!");
        }
        else
        {
            Console.WriteLine("Jumlah uang tidak valid!");
        }
    }





    public void DisplayInfo()
    {
        Console.WriteLine("\nDisplay info rekening");
        Console.WriteLine($"No Rekening: {noRekening}");
        Console.WriteLine($"Saldo: {Saldo}");

    }




}