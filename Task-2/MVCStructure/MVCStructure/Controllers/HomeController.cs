﻿using Microsoft.AspNetCore.Mvc;
using MVCStructure.Models;

namespace MVCStructure.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Artist artist1 = new Artist
            {
                ArtistID = 1,
                Name = "Brand New",
                Genre = "Rock"

            };

            Artist artist2 = new Artist
            {
                ArtistID = 2,
                Name = "Kodak Black",
                Genre = "Rap"

            };

            Artist artist3 = new Artist
            {
                ArtistID = 3,
                Name = "Kendrick Lamar",
                Genre = "Rap"

            };

            Artist artist4 = new Artist
            {
                ArtistID = 4,
                Name = "Neck Deep",
                Genre = "Rock"

            };

            Artist artist5 = new Artist
            {
                ArtistID = 5,
                Name = "Kesha",
                Genre = "Pop"

            };

            Album album1 = new Album
            {
                AlbumID = 1,
                Name = "Science Fiction",
                RecordLabel = "PM Traitors",
                Artist = artist1,
                CopiesSold = 55000,
                ReleaseDate = new DateTime(2017, 8, 18),
                Streams = 4500000
            };

            Album album2 = new Album
            {
                AlbumID = 2,
                Name = "Project Baby Two",
                RecordLabel = "Atlantic",
                Artist = artist2,
                CopiesSold = 8000,
                ReleaseDate = new DateTime(2017, 8, 18),
                Streams = 70500000
            };

            Album album3 = new Album
            {
                AlbumID = 3,
                Name = "DAMN.",
                RecordLabel = "Aftermath",
                Artist = artist3,
                CopiesSold = 20000,
                ReleaseDate = new DateTime(2017, 4, 14),
                Streams = 31500000
            };

            Album album4 = new Album
            {
                AlbumID = 4,
                Name = "The Peace and the Panic",
                RecordLabel = "Hopeless",
                Artist = artist4,
                CopiesSold = 29000,
                ReleaseDate = new DateTime(2017, 8, 18),
                Streams = 4500000
            };

            Album album5 = new Album
            {
                AlbumID = 5,
                Name = "Rainbow",
                RecordLabel = "RCA",
                Artist = artist5,
                CopiesSold = 15000,
                ReleaseDate = new DateTime(2017, 8, 11),
                Streams = 24000000
            };

            List<Album> listOfAlbums = new List<Album>();
            listOfAlbums.Add(album1);
            listOfAlbums.Add(album2);
            listOfAlbums.Add(album3);
            listOfAlbums.Add(album4);
            listOfAlbums.Add(album5);

            ViewBag.Title = "Top 5 Albums of the Week";
            return View(listOfAlbums);
        }
    }
}
