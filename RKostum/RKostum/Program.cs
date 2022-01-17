using NewProgramFundamental;
using System;
using System.Collections.Generic;

namespace WorkingSpace
{
    public class Program
    {
        int pilih;
        private static List<string> KostumList = new List<string>();
        private static List<int> priceList = new List<int>();

        private static List<string> nameList = new List<string>();
        private static List<string> phoneList = new List<string>();
        private static List<string> idList = new List<string>();
        private static List<string> addressList = new List<string>();
        private static List<int> paymentList = new List<int>();
        private static List<int> LamaPinjamList = new List<int>();


        static void Main(string[] args)
        {

            Program pg = new Program();
            Customer c = new Customer();
            Menu m = new Menu();

            mainMenu();

        }
        public static void mainMenu()
        {
            Program p = new Program();
            Customer c = new Customer();
            List<string> pilihan = new List<string>() { "Menu Kostum", "Tambah Pesanan", "Tutup Program" };
            for (int i = 0; i < pilihan.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + pilihan[i]);
            }

            Console.Write("Masukan Pilihan\t: ");
            int pilih = Convert.ToInt32(Console.ReadLine());
            switch (pilih)
            {
                case 1:
                    crud();
                    //Menu.tampil();
                    //goto run;
                    break;
                case 2:
                    tampilkanList();
                    pilihanKostum();
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
            }
        }

        public static void crud()
        {
            int ganti, hapus;
            int pilih;

            List<string> menu1 = new List<string> { "Tambah", "Edit", "Hapus", "Keluar" };
        menu:
            for (int i = 0; i < menu1.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + menu1[i]);
            }

            Console.Write("Masukan pilhanmu\t: ");
            pilih = Convert.ToInt32((Console.ReadLine()));
            if (pilih == 1)
            {
                inputKostum();
            }
            else if (pilih == 2)
            {
                editKostum();
            }
            else if (pilih == 3)
            {
                hapusKostum();
            }
            else if (pilih == 4)
            {
                Console.Clear();
                mainMenu();
            }
            else
            {
                Console.WriteLine("Input Salah, Coba Lagi!!");
            }
        }
        public static void tampilkanList()
        {
            Console.Clear();
            Console.WriteLine("=============================================================================");
            Console.WriteLine("\tJenis Kostum\t");
            Console.WriteLine("=============================================================================");
            for (int i = 0; i < KostumList.Count; i++)
            {
                Console.WriteLine($"{i}. \t{KostumList[i]}");
            }
            Console.WriteLine("=============================================================================");
            Console.WriteLine("\tHarga Ruangan\t");
            Console.WriteLine("=============================================================================");
            for (int j = 0; j < priceList.Count; j++)
            {

                Console.WriteLine($"{j}. \t{priceList[j]}");
            }
            Console.WriteLine();
        }
        public static void inputKostum()
        {
            Console.Clear();
            Console.Write("Masukkan Kostum = ");
            string nKostum = Console.ReadLine();
            Console.Write("Masukkan harga = ");
            int nPrice = Convert.ToInt32(Console.ReadLine());
            Menu m = new Menu();
            m.Kostum = nKostum;
            m.price = nPrice;
            //isi lisst
            KostumList.Add(m.Kostum);
            priceList.Add(m.price);
            m.tampil();

            Program.inputAgain();
        }
        public static void inputAgain()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Input Lagi? [y/n]\t: ");
            string ulang = Console.ReadLine().ToLower();
            switch (ulang)
            {
                case "y":
                    //Console.SetCursorPosition(0, Console.CursorTop - 1);
                    Console.Clear();
                    inputKostum();
                    break;
                case "n":
                    Program.tampilkanList();
                    Program.crud();
                    break;
            }
        }
        public static void editKostum()
        {
            Console.Write("Masukan Nomor data yang akan diedit: ");
            int edit = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nMasukan nama Kostum baru\t: ");
            string editKostum = Console.ReadLine();
            Console.Write("\nMasukan harga Kostum baru\t: ");
            int editPrice = Convert.ToInt32(Console.ReadLine());
            KostumList[edit] = editKostum;
            priceList[edit] = editPrice;
            tampilkanList();
            crud();
        }
        public static void hapusKostum()
        {
            Console.Write("Masukan Nomor data yang akan dihapus: ");
            int hapus = Convert.ToInt32(Console.ReadLine());
            KostumList.RemoveAt(hapus);
            priceList.RemoveAt(hapus);
            tampilkanList();
            crud();
        }
        public static void pilihanKostum()
        {
            Program p = new Program();
            Console.Write("Masukan nomor Kostum yang dipilih\t: ");
            p.pilih = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Pilihan Kostum\t\t\t\t: {KostumList[p.pilih]}");
            Console.WriteLine($"Harga Kostum\t\t\t\t: {priceList[p.pilih]}");

            Customer c = new Customer();
            inputDataCustomer();
            p.dataCustomer();
        }

        public static void inputDataCustomer()
        {
            Program p = new Program();
            Customer c = new Customer();

            Console.WriteLine("DATA CUSTOMER");           
            Console.Write("Nama Konsumen\t\t\t\t: ");
            string nName = Console.ReadLine();
            Console.Write("No. Telp\t\t\t\t: ");
            string nPhone = Console.ReadLine();
            Console.Write("Alamat\t\t\t\t\t: ");
            string nAddress = Console.ReadLine();
            Console.Write("Masukan Lama Pinjam\t\t\t: ");
            int nLamaPinjam = Convert.ToInt32(Console.ReadLine());
            c.LamaPinjam = nLamaPinjam;
            LamaPinjamList.Add(c.LamaPinjam);
            Console.WriteLine();
            Console.WriteLine("Total\t\t\t\t\t: {0}", priceList[p.pilih] * LamaPinjamList[0]);
            Console.WriteLine();
            Console.Write("Masukan Uang\t\t\t\t: ");
            int nPayment = int.Parse(Console.ReadLine());
            

            c.Name = nName;
            c.NumberPhone = nPhone;
            c.Address = nAddress;
            c.Payment = nPayment;

            nameList.Add(c.Name);
            phoneList.Add(c.NumberPhone);
            addressList.Add(c.Address);
            paymentList.Add(c.Payment);
        }

        public void dataCustomer()
        {
            Customer c = new Customer();
            Console.Clear();
            Console.WriteLine("YOUR CUSTOMER DATA");
            Console.WriteLine("Nama Penyewa\t\t\t\t: {0}", nameList[0]);
            Console.WriteLine("No. Telp\t\t\t\t: {0}", phoneList[0]);          
            Console.WriteLine("Alamat\t\t\t\t\t: {0}", addressList[0]);
            Console.WriteLine($"Pilihan Kostum\t\t\t\t: {KostumList[pilih]}");
            Console.WriteLine($"Harga Kostum\t\t\t\t: {priceList[pilih]}");
            Console.WriteLine($"Lama Pinjam\t\t\t\t: {LamaPinjamList[pilih]}");

            Console.WriteLine("TAGIHAN");
            Console.WriteLine("Harga Kostum\t\t\t\t: {0}", priceList[pilih]);
            Console.WriteLine("Total\t\t\t\t\t: {0}", priceList[pilih]*LamaPinjamList[0]);
            Console.WriteLine("Uang Tunai\t\t\t\t: {0}", paymentList[0]);
            Console.WriteLine("Kembalian\t\t\t\t: {0}", (paymentList[0] - (priceList[pilih] * LamaPinjamList[0])));

            backToMenu();
        }

        public void backToMenu()
        {
            Console.WriteLine("\nKembali ke Menu? [y/n]");
            string jwb = Console.ReadLine();
            switch (jwb)
            {
                case "y":
                    Console.Clear();
                    mainMenu();
                    break;
                case "n":
                    Environment.Exit(0);
                    break;
            }
        }
    }







}