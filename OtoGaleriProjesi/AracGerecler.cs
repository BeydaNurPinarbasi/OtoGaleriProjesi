﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoGaleriProjesi
{
    class AracGerecler
    {
        static public bool PlakaMi(string veri)
        {
            int sayi;
          
            if (veri.Length > 6 && veri.Length < 10
                && int.TryParse(veri.Substring(0, 2), out sayi)
                && HarfMi(veri.Substring(2, 1)))
            {
                
                if (veri.Length == 7 && int.TryParse(veri.Substring(3), out sayi))
                {
                    return true;
                }
                
                else if (veri.Length < 9 && HarfMi(veri.Substring(3, 1)) && int.TryParse(veri.Substring(4), out sayi))
                {
                    return true;
                }
              
                else if (HarfMi(veri.Substring(3, 2)) && int.TryParse(veri.Substring(5), out sayi))
                {
                    return true;
                }
            }
            return false;    
        }

        
        static public bool HarfMi(string veri)
        {
            veri = veri.ToUpper();

            for (int i = 0; i < veri.Length; i++)
            {
                int kod = (int)veri[i];
                if ((kod >= 65 && kod <= 90) != true) 
                {
                    return false;
                }
            }

            return true;
        }

        static public string YaziAl(string yazi)
        {
            int sayi;

           

            do
            {
                try
                {
                    Console.Write(yazi);
                    string giris = Console.ReadLine().ToUpper();

                    if (int.TryParse(giris, out sayi))
                    {
                        throw new Exception("Giriş tanımlanamadı. Tekrar deneyin.");
                    }
                    else if (giris == "X")
                    {
                        return giris;
                    }
                    else
                    {
                        return giris;
                    }

                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                }

            } while (true);

        }

        static public int SayiAl(string mesaj)
        {
            int sayi;

            

            do
            {
                try
                {
                    Console.Write(mesaj);
                    string giris = Console.ReadLine().ToUpper();

                    if (int.TryParse(giris, out sayi))
                    {
                        return sayi;
                    }
                    else if (giris == "X")
                    {
                        throw new Exception("Çıkış");
                    }
                    else
                    {
                        throw new Exception("Giriş tanımlanamadı. Tekrar deneyin.");
                    }
                }
                catch (Exception e)
                {
                    if (e.Message == "Çıkış")
                    {
                        throw new Exception("Çıkış");
                    }
                    else
                    {
                        Console.WriteLine(e.Message);
                    }
                }

            } while (true);

        }
        static public string PlakaAl(string mesaj)
        {
            string plaka;
            do
            {
                try
                {
                    Console.Write(mesaj);
                    plaka = Console.ReadLine().ToUpper();

                    if (plaka == "X")
                    {
                        return "X";
                    }

                    if (!PlakaMi(plaka))
                    {
                        throw new Exception("Bu şekilde plaka girişi yapamazsınız. Tekrar deneyin.");
                    }

                    return plaka;
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                }
            } while (true);
        }

        static public string AracTipiAl()
        {
            Console.WriteLine("Araç tipi: ");
            Console.WriteLine("SUV için 1");
            Console.WriteLine("Hatchback için 2");
            Console.WriteLine("Sedan için 3");

            while (true)
            {

                Console.Write("Araba Tipi: ");
                string secim = Console.ReadLine().ToUpper();
                if (secim == "X")
                {
                    throw new Exception("Çıkış");
                }

                switch (secim)
                {
                    case "1":
                        return "SUV";

                    case "2":
                        return "Hatchback";

                    case "3":
                        return "Sedan";

                    default:
                        Console.WriteLine("Giriş tanımlanamadı. Tekrar deneyin.");
                        break;
                }

            }
        }
    }
}

