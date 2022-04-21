using System;

namespace test
{
  public class karyawan
  {
    public string nama {get;set;}
    public double nik {get;set;}
    public double gaji {get;set;}

    public void Nama()
    {
      Console.Write("Nama : {0}",nama);
    }
    public void Nik()
    {
      Console.Write(" NIK {0}",nik);
    }
    public void Gaji()
    {
      Console.Write(" Gaji : {0}",gaji);
    }
  class program
  {
    static void Main(string[] args)
    {
      karyawan paijo = new karyawan();
      karyawan jono = new karyawan();

      paijo.nik = 190302123;
      paijo.nama = "Paijo";
      paijo.gaji = 3000000;

      jono.nik = 190302124;
      jono.nama = "Jono";
      jono.gaji = 2000000;

      Console.WriteLine("No Nik/Nama   Gaji Bulanan");
      Console.Write("1.");
      paijo.Nama();
      paijo.Nik();
      paijo.Gaji();
      Console.WriteLine();

      Console.Write("2.");
      jono.Nama();
      jono.Nik();
      jono.Gaji();
      Console.WriteLine();

      Console.WriteLine("Yey naik gaji");

      paijo.gaji += 300000;
      jono.gaji += 300000;

      Console.WriteLine("No Nik/Nama   Gaji Bulanan");
      Console.Write("1.");
      paijo.Nama();
      paijo.Nik();
      paijo.Gaji();
      Console.WriteLine();

      Console.Write("2.");
      jono.Nama();
      jono.Nik();
      jono.Gaji();
      Console.WriteLine();

      Console.ReadKey();
    }
  }
  }
}
