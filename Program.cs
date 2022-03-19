using System;

namespace mod4
{
    class program
    {
        static void Main(string[] args)
        {
            //NIM 1302204080, Menggunakan tipe data long
            Penjumlahan.JumlahTigaAngka<long, long, long>(13, 02, 20);
            SimpleDataBase<int> BasisData = new SimpleDataBase<int>();
            BasisData.AddNewData(13);
            BasisData.AddNewData(02);
            BasisData.AddNewData(20);
            BasisData.PrintAllData();
        }
    }
}