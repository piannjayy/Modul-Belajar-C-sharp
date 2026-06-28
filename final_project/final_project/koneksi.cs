using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerpusSekawan // Pastikan namespace ini sesuai
{
    // Class untuk menyimpan Connection String
    class Koneksi
    {
        // KONEKSI SUDAH DENGAN SERVER ABANG: LAPTOP-UH3ULTU9 dan DB: perpustakaan_bufajar
        public static string conn = "Data Source = LAPTOP-UH3ULTU9; Initial Catalog = perpustakaan_bufajar; Integrated Security = True";
    }

    // Class untuk menyimpan data session nama pengguna
    public class Model
    {
        public static string name { get; set; }
    }
}