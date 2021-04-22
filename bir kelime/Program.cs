using System;
using System.IO;

namespace bir_kelime
{
    class Program
    {

        static void Main(string[] args)
        {
            Random rastgele = new Random();
            char[] karakter = new char[8];
            char[] karakterkopya = new char[8];
            char[] yazikopya = new char[9];
            int a = 0;
            

            

            int giris;
            Console.WriteLine("1-Kelimeleri random üret\n2-kelime gir");
            giris = Convert.ToInt32(Console.ReadLine());
            
            
            if (giris == 1)
            {
                for (int i = 0; i < 8; i++)
                {
                    for (; ; )
                    {
                        int kod = rastgele.Next(97, 123);
                        karakter[i] = Convert.ToChar(kod);
                        //random üretilen harfin x yada w olmasını engellemek
                        if (kod != 119 && kod != 120)
                            break;
                    }

                    Console.WriteLine(karakter[i]);
                }
            }
            else 
            {
                for (int i = 0; i < 8; i++)
                {
                    Console.WriteLine(i + 1 + ".harfi giriniz");
                    karakter[i] = Convert.ToChar(Console.ReadLine());

                }
                Console.WriteLine("Harfleriniz");
                Console.WriteLine(karakter);

            }


            
            

            string dosya_yolu9 = @"C:\Users\Mehmet\Desktop\bir kelime\kelimeler 9 haneli.txt";
            FileStream fs9 = new FileStream(dosya_yolu9, FileMode.Open, FileAccess.Read);
            StreamReader sr9 = new StreamReader(fs9);
            string yazi9 ;
            while ((yazi9 = sr9.ReadLine()) != null)
            {
                int sayac = 0;

                for (int i = 0; i < 9; i++)
                {
                    yazikopya[i] = yazi9[i];
                }

                for (int i = 0; i < 8; i++)
                {
                    karakterkopya[i] = karakter[i];
                }


                for (int i = 0; i < 8 ; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        if (karakterkopya[i] == yazikopya[j])
                        {

                            karakterkopya[i] = '.';
                            yazikopya[j] = ',';
                            sayac++;
                            break;

                        }
                    }
                }

                if(sayac==8)
                {
                    Console.WriteLine("\nkelime:"+yazi9);
                    yazi9 = sr9.ReadLine();
                    Console.WriteLine("9 haneli sayı bulundu 15 puan");
                    a = 1;
                    break;
                }
                

                
                
            }

            sr9.Close();
            fs9.Close();

            if(a==0)
            {
                string dosya_yolu8 = @"C:\Users\Mehmet\Desktop\bir kelime\kelimeler 8 haneli.txt";
                FileStream fs8 = new FileStream(dosya_yolu8, FileMode.Open, FileAccess.Read);
                StreamReader sr8 = new StreamReader(fs8);
                string yazi8;
                while ((yazi8 = sr8.ReadLine()) != null)
                {
                    int sayac = 0;

                    for (int i = 0; i < 8; i++)
                    {
                        yazikopya[i] = yazi8[i];
                    }

                    for (int i = 0; i < 8; i++)
                    {
                        karakterkopya[i] = karakter[i];
                    }


                    for (int i = 0; i < 8; i++)
                    {
                        for (int j = 0; j < 9; j++)
                        {
                            if (karakterkopya[i] == yazikopya[j])
                            {

                                karakterkopya[i] = '.';
                                yazikopya[j] = ',';
                                sayac++;
                                break;

                            }
                        }
                    }

                    if (sayac == 7 || sayac == 8)
                    {
                        Console.WriteLine("\nkelime:" + yazi8);
                        yazi8 = sr8.ReadLine();
                        Console.WriteLine("8 haneli sayı bulundu 11 puan");
                        a = 1;
                        break;
                    }




                }

                sr8.Close();
                fs8.Close();
            }


            if (a == 0)
            {
                string dosya_yolu7 = @"C:\Users\Mehmet\Desktop\bir kelime\kelimeler 7 haneli.txt";
                FileStream fs7 = new FileStream(dosya_yolu7, FileMode.Open, FileAccess.Read);
                StreamReader sr7 = new StreamReader(fs7);
                string yazi7;
                while ((yazi7 = sr7.ReadLine()) != null)
                {
                    int sayac = 0;

                    for (int i = 0; i < 7; i++)
                    {
                        yazikopya[i] = yazi7[i];
                    }

                    for (int i = 0; i < 8; i++)
                    {
                        karakterkopya[i] = karakter[i];
                    }


                    for (int i = 0; i < 8; i++)
                    {
                        for (int j = 0; j < 9; j++)
                        {
                            if (karakterkopya[i] == yazikopya[j])
                            {

                                karakterkopya[i] = '.';
                                yazikopya[j] = ',';
                                sayac++;
                                break;

                            }
                        }
                    }

                    if (sayac == 6 || sayac == 7)
                    {
                        Console.WriteLine("\nkelime:" + yazi7);
                        yazi7 = sr7.ReadLine();
                        Console.WriteLine("7 haneli sayı bulundu 9 puan");
                        a = 1;
                        break;
                    }




                }

                sr7.Close();
                fs7.Close();
            }


            if (a == 0)
            {
                string dosya_yolu6 = @"C:\Users\Mehmet\Desktop\bir kelime\kelimeler 6 haneli.txt";
                FileStream fs6 = new FileStream(dosya_yolu6, FileMode.Open, FileAccess.Read);
                StreamReader sr6 = new StreamReader(fs6);
                string yazi6;
                while ((yazi6 = sr6.ReadLine()) != null)
                {
                    int sayac = 0;

                    for (int i = 0; i < 6; i++)
                    {
                        yazikopya[i] = yazi6[i];
                    }

                    for (int i = 0; i < 8; i++)
                    {
                        karakterkopya[i] = karakter[i];
                    }


                    for (int i = 0; i < 8; i++)
                    {
                        for (int j = 0; j < 9; j++)
                        {
                            if (karakterkopya[i] == yazikopya[j])
                            {

                                karakterkopya[i] = '.';
                                yazikopya[j] = ',';
                                sayac++;
                                break;

                            }
                        }
                    }

                    if (sayac == 5 || sayac == 6)
                    {
                        Console.WriteLine("\nkelime:" + yazi6);
                        yazi6 = sr6.ReadLine();
                        Console.WriteLine("6 haneli sayı bulundu 7 puan");
                        a = 1;
                        break;
                    }




                }

                sr6.Close();
                fs6.Close();
            }

            if (a == 0)
            {
                string dosya_yolu5 = @"C:\Users\Mehmet\Desktop\bir kelime\kelimeler 5 haneli.txt";
                FileStream fs5 = new FileStream(dosya_yolu5, FileMode.Open, FileAccess.Read);
                StreamReader sr5 = new StreamReader(fs5);
                string yazi5;
                while ((yazi5 = sr5.ReadLine()) != null)
                {
                    int sayac = 0;

                    for (int i = 0; i < 5; i++)
                    {
                        yazikopya[i] = yazi5[i];
                    }

                    for (int i = 0; i < 8; i++)
                    {
                        karakterkopya[i] = karakter[i];
                    }


                    for (int i = 0; i < 8; i++)
                    {
                        for (int j = 0; j < 9; j++)
                        {
                            if (karakterkopya[i] == yazikopya[j])
                            {

                                karakterkopya[i] = '.';
                                yazikopya[j] = ',';
                                sayac++;
                                break;

                            }
                        }
                    }

                    if (sayac == 4 || sayac ==5)
                    {
                        Console.WriteLine("\nkelime:" + yazi5);
                        yazi5 = sr5.ReadLine();
                        Console.WriteLine("5 haneli sayı bulundu 5 puan");
                        a = 1;
                        break;
                    }




                }

                sr5.Close();
                fs5.Close();
            }


            if (a == 0)
            {
                string dosya_yolu4 = @"C:\Users\Mehmet\Desktop\bir kelime\kelimeler 4 haneli.txt";
                FileStream fs4 = new FileStream(dosya_yolu4, FileMode.Open, FileAccess.Read);
                StreamReader sr4 = new StreamReader(fs4);
                string yazi4;
                while ((yazi4 = sr4.ReadLine()) != null)
                {
                    int sayac = 0;

                    for (int i = 0; i < 4; i++)
                    {
                        yazikopya[i] = yazi4[i];
                    }

                    for (int i = 0; i < 8; i++)
                    {
                        karakterkopya[i] = karakter[i];
                    }


                    for (int i = 0; i < 8; i++)
                    {
                        for (int j = 0; j < 9; j++)
                        {
                            if (karakterkopya[i] == yazikopya[j])
                            {

                                karakterkopya[i] = '.';
                                yazikopya[j] = ',';
                                sayac++;
                                break;

                            }
                        }
                    }

                    if (sayac == 3 || sayac == 4)
                    {
                        Console.WriteLine("\nkelime:" + yazi4);
                        yazi4 = sr4.ReadLine();
                        Console.WriteLine("4 haneli sayı bulundu 4 puan");
                        a = 1;
                        break;
                    }




                }

                sr4.Close();
                fs4.Close();
            }


            if (a == 0)
            {
                string dosya_yolu3 = @"C:\Users\Mehmet\Desktop\bir kelime\kelimeler 3 haneli.txt";
                FileStream fs3 = new FileStream(dosya_yolu3, FileMode.Open, FileAccess.Read);
                StreamReader sr3 = new StreamReader(fs3);
                string yazi3;
                while ((yazi3 = sr3.ReadLine()) != null)
                {
                    int sayac = 0;

                    for (int i = 0; i < 3; i++)
                    {
                        yazikopya[i] = yazi3[i];
                    }

                    for (int i = 0; i < 8; i++)
                    {
                        karakterkopya[i] = karakter[i];
                    }


                    for (int i = 0; i < 8; i++)
                    {
                        for (int j = 0; j < 9; j++)
                        {
                            if (karakterkopya[i] == yazikopya[j])
                            {

                                karakterkopya[i] = '.';
                                yazikopya[j] = ',';
                                sayac++;
                                break;

                            }
                        }
                    }

                    if (sayac == 2 || sayac == 3)
                    {
                        Console.WriteLine("\nkelime:" + yazi3);
                        yazi3 = sr3.ReadLine();
                        Console.WriteLine("3 haneli sayı bulundu 3 puan");
                        a = 1;
                        break;
                    }




                }

                sr3.Close();
                fs3.Close();
            }



            Console.ReadLine();
        }

    }
}
