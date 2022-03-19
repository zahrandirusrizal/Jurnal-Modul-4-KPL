using System;

namespace mod4
{
    public class Penjumlahan
    {

        public static void JumlahTigaAngka<T, U, V>(T inputUser1, U inputUser2, V inputUser3)
        {
            dynamic temp1 = inputUser1;
            dynamic temp2 = inputUser2;
            dynamic temp3 = inputUser3;

            Console.WriteLine(temp1 + temp2 + temp3);
        }
    }
}
