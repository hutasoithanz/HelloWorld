using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Logics
{
    /// <summary>
    /// Class adalah sebuah representasi objek di dunia nyata yang melakukan berbagai fungsi.
    /// Fungsi tersebut didefinisikan dalam satu kumpulan kode (statement).
    /// Alangkah baiknya jika tiap class melakukan fungsi objek dunia nyata yang dilakukannya.
    /// Contoh: class Matematika akan melakukan fungsi matematika, bukan perbandingan huruf/kata.
    /// Contoh buruk: class Gelas melakukan fungsi mengaduk semen.
    /// 
    /// Class conditional berisi berbagai jenis kondisi yang dapat digunakan dalam bahasa pemograman.
    /// Di dalam ini contohnya sebagai berikut:
    ///     - If Else; penggunaannya untuk nilai variabel yang tidak tetap atau bersifat ranged.
    ///     - Switch Case; penggunaannya untuk nilai variabel yang sudah diketahui jenis dan nilainya.
    /// </summary>
    public class Conditional
    {
        /// <summary>
        /// Ini adalah fungsi. Fungsi dalam class melakukan sesuatu tindakan dan bisa memberikan hasil.
        /// Tidak semua fungsi memberikan hasil. Ada fungsi yang hanya melakukan pengerjaan di belakang.
        /// 
        /// Fungsi dapat juga dipanggil berdasarkan inisialisasinya. Fungsi 'static' akan tetap ada selama
        /// program berjalan. Fungsi tanpa keyword 'static' akan ada jika object masih ada di memory.
        /// 
        /// Fungsi dapat memiliki variabel yang harus diberikan ketika pemanggilan fungsinya.
        /// Variabel ini disebut dengan parameter. Parameter bisa berupa input ataupun input/output.
        /// 
        /// Pada contoh fungsi ini, akan didemonstrasikan cara pemanggilan conditional if
        /// untuk perbandingan kedua parameter, mana yang lebih besar.
        /// </summary>
        /// <param name="angkaSatu">Parameter angkaSatu membutuhkan nilai angka integer untuk diisi.</param>
        /// <param name="angkaDua">Parameter angkaDua membutuhkan nilai angka integer untuk diisi.</param>
        /// <returns>Hasil perbandingan akan diberikan oleh fungsi ini kepada 
        /// program yang memanggilnya.</returns>
        public static string ContohConditionalIf(int angkaSatu, int angkaDua)
        {
            if (angkaSatu > angkaDua)
            {
                return "nilai " + angkaSatu + " lebih besar dari " + angkaDua + ".";
            }
            else if (angkaSatu < angkaDua)
            {
                return "nilai " + angkaSatu + " lebih kecil dari " + angkaDua + ".";

            }
            else
            {
                return "nilai " + angkaSatu + " sama dengan " + angkaDua + ".";
            }
        }

        public static string ContohConditionalSwitch(int angkaInput)
        {
            switch (angkaInput % 2)
            {
                case 1:
                    return "angka " + angkaInput + " adalah angka ganjil.";
                case 0:
                    return "angka " + angkaInput + " adalah angka genap.";
                default:
                    return "angka masukan tidak valid.";
            }
        }
    }
}
