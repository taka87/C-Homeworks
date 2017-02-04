using System;

class TorrentPirate
{
    static void Main()
    {
        int d = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int w = int.Parse(Console.ReadLine());

        double hour = (double)d / 2 / 60 / 60;
        double priceForDownload = (double)hour * w;
        double numberDonwloadMovies = (double)d / 1500;
        double cinemaPrice = (double)numberDonwloadMovies * p;

        if (priceForDownload > cinemaPrice)
        {
            Console.WriteLine("Cinema -> {0:F2}lv", cinemaPrice); //{0:F2} -> dva simvola sled zapetayata
        }
        else
        {
            Console.WriteLine("mall -> {0:F2}lv", priceForDownload);
        }

        //“{place to go} -> {price to pay}lv”.
        //        //Download time = 
        //= (download data)/(fixed speed)/(seconds)/(minutes) =
        //= 30000 / 2 / 60 / 60 = 4.1667 hours in the mall
        //Price for download = (download time)*(wife spending) =
        //= 4.1667*50 = 208.34lv
        //Number of movies downloaded = 
        //= (download data)/(movie size) = 30000/1500 = 20 movies
        //Cinema price = 
        //= (number of movies)*(cinema price) = 20*5lv = 100lv
        //Result on the console: cinema -> 100lv
    }
}