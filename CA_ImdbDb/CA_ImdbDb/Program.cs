﻿using System;

namespace CA_ImdbDb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MovieRepository movieRepository = new MovieRepository();
            int sayac = 0;
            




            while (sayac<1)
            {
                Console.WriteLine("****Imdb'ye Hoşgeldiniz****");
                Console.WriteLine("İşlemler: ");
                Console.WriteLine("1-Film listeleme");
                Console.WriteLine("2-Seçilen yıla göre listeleme");
                Console.WriteLine("3-Seçilen puana göre listeleme");
                Console.WriteLine("4-Seçilen açıklamaya göre listeleme");
                Console.WriteLine("5-Seçilen türe göre listeleme");
                Console.WriteLine("6-Rastgele film seçimi");
                Console.WriteLine("7-Puan aralığında rastgele film getirme");
                Console.WriteLine("8-Çıkış");
                Console.WriteLine("*********************************");

                try
                {
                    Console.WriteLine("Lütfen seçim yapınız.");
                    int selected=int.Parse(Console.ReadLine());
                    var value = (SelectedItem)selected;

                    switch (value)
                    {
                        case SelectedItem.List:
                            movieRepository.List();
                            break;
                        case SelectedItem.GetBySelectedYear:
                            Console.WriteLine(movieRepository.GetBySelectedYear());
                            break;
                        case SelectedItem.GetByRating:
                            Console.WriteLine(movieRepository.GetByRating());                            
                            break;
                        case SelectedItem.GetByDescription:
                            Console.WriteLine(movieRepository.GetByDescription());                            
                            break;
                        case SelectedItem.GetByGenre:
                            Console.WriteLine("Bir kategori adı girmek için [1]\nİki kategori adı girmek için [2]");
                            int selection = int.Parse(Console.ReadLine());
                            if (selection == 1)
                            {
                                Console.WriteLine(movieRepository.GetByGenre());
                            }
                            else if (selection == 2)
                            {
                                Console.WriteLine(movieRepository.GetByGenreM());
                            }
                            break;
                        case SelectedItem.RandomMovie:
                            Console.WriteLine(movieRepository.RandomMovie());
                            break;
                        case SelectedItem.RandomGetByRating:
                            Console.WriteLine(movieRepository.RandomGetByRating());
                            break;
                        default:
                            sayac++;
                            break;
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }














        }
    }
}
