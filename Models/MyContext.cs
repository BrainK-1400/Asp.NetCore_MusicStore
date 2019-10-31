using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MusicStore.ViewModels;
/// <summary>
/// MyContext
/// TO-DO
/// 用DI addscope来进行修改。
/// </summary>
namespace MusicStore.Models
{
    public class MyContext:DbContext
    {
        
        public DbSet<Album> Albums { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Artist> Artists { get; set; }

        public DbSet<Cart> Carts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }


        public MyContext(DbContextOptions<MyContext> options):base(options)
        {

        }
        
        //Seed数据
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Genre>().HasData(
                new Genre { Name = "Rock", GenreId = 1 },
                new Genre { Name = "Jazz", GenreId = 2 },
                new Genre { Name = "Metal", GenreId = 3 },
                new Genre { Name = "Alternative", GenreId = 4 },
                new Genre { Name = "Disco", GenreId = 5 },
                new Genre { Name = "Blues", GenreId = 6 },
                new Genre { Name = "Latin", GenreId = 7 },
                new Genre { Name = "Reggae", GenreId = 8 },
                new Genre { Name = "Pop", GenreId = 9 },
                new Genre { Name = "Classical", GenreId = 10 }
                );
            int i = 1;
            modelBuilder.Entity<Artist>().HasData(
                new Artist { Name = "Aaron Copland & London Symphony Orchestra", ArtistId = i++ },
                new Artist { Name = "Aaron Goldberg", ArtistId = i++ },
                new Artist { Name = "AC/DC", ArtistId = i++ },
                new Artist { Name = "Accept", ArtistId = i++ },
                new Artist { Name = "Adrian Leaper & Doreen de Feis", ArtistId = i++ },
                new Artist { Name = "Aerosmith", ArtistId = i++ },
                new Artist { Name = "Aisha Duo", ArtistId = i++ },
                new Artist { Name = "Alanis Morissette", ArtistId = i++ },
                new Artist { Name = "Alberto Turco & Nova Schola Gregoriana", ArtistId = i++ },
                new Artist { Name = "Alice In Chains", ArtistId = i++ },
                new Artist { Name = "Amy Winehouse", ArtistId = i++ },
                new Artist { Name = "Anita Ward", ArtistId = i++ },
                new Artist { Name = "Antônio Carlos Jobim", ArtistId = i++ },
                new Artist { Name = "Apocalyptica", ArtistId = i++ },
                new Artist { Name = "Audioslave", ArtistId = i++ },
                new Artist { Name = "Barry Wordsworth & BBC Concert Orchestra", ArtistId = i++ },
                new Artist { Name = "Berliner Philharmoniker & Hans Rosbaud", ArtistId = i++ },
                new Artist { Name = "Berliner Philharmoniker & Herbert Von Karajan", ArtistId = i++ },
                new Artist { Name = "Billy Cobham", ArtistId = i++ },
                new Artist { Name = "Black Label Society", ArtistId = i++ },
                new Artist { Name = "Black Sabbath", ArtistId = i++ },
                new Artist { Name = "Boston Symphony Orchestra & Seiji Ozawa", ArtistId = i++ },
                new Artist { Name = "Britten Sinfonia, Ivor Bolton & Lesley Garrett", ArtistId = i++ },
                new Artist { Name = "Bruce Dickinson", ArtistId = i++ },
                new Artist { Name = "Buddy Guy", ArtistId = i++ },
                new Artist { Name = "Caetano Veloso", ArtistId = i++ },
                new Artist { Name = "Cake", ArtistId = i++ },
                new Artist { Name = "Calexico", ArtistId = i++ },
                new Artist { Name = "Cássia Eller", ArtistId = i++ },
                new Artist { Name = "Chic", ArtistId = i++ },
                new Artist { Name = "Chicago Symphony Orchestra & Fritz Reiner", ArtistId = i++ },
                new Artist { Name = "Chico Buarque", ArtistId = i++ },
                new Artist { Name = "Chico Science & Nação Zumbi", ArtistId = i++ },
                new Artist { Name = "Choir Of Westminster Abbey & Simon Preston", ArtistId = i++ },
                new Artist { Name = "Chris Cornell", ArtistId = i++ },
                new Artist { Name = "Christopher O'Riley", ArtistId = i++ },
                new Artist { Name = "Cidade Negra", ArtistId = i++ },
                new Artist { Name = "Cláudio Zoli", ArtistId = i++ },
                new Artist { Name = "Creedence Clearwater Revival", ArtistId = i++ },
                new Artist { Name = "David Coverdale", ArtistId = i++ },
                new Artist { Name = "Deep Purple", ArtistId = i++ },
                new Artist { Name = "Dennis Chambers", ArtistId = i++ },
                new Artist { Name = "Djavan", ArtistId = i++ },
                new Artist { Name = "Donna Summer", ArtistId = i++ },
                new Artist { Name = "Dread Zeppelin", ArtistId = i++ },
                new Artist { Name = "Ed Motta", ArtistId = i++ },
                new Artist { Name = "Edo de Waart & San Francisco Symphony", ArtistId = i++ },
                new Artist { Name = "Elis Regina", ArtistId = i++ },
                new Artist { Name = "English Concert & Trevor Pinnock", ArtistId = i++ },
                new Artist { Name = "Eric Clapton", ArtistId = i++ },
                new Artist { Name = "Eugene Ormandy", ArtistId = i++ },
                new Artist { Name = "Faith No More", ArtistId = i++ },
                new Artist { Name = "Falamansa", ArtistId = i++ },
                new Artist { Name = "Foo Fighters", ArtistId = i++ },
                new Artist { Name = "Frank Zappa & Captain Beefheart", ArtistId = i++ },
                new Artist { Name = "Fretwork", ArtistId = i++ },
                new Artist { Name = "Funk Como Le Gusta", ArtistId = i++ },
                new Artist { Name = "Gerald Moore", ArtistId = i++ },
                new Artist { Name = "Gilberto Gil", ArtistId = i++ },
                new Artist { Name = "Godsmack", ArtistId = i++ },
                new Artist { Name = "Gonzaguinha", ArtistId = i++ },
                new Artist { Name = "Göteborgs Symfoniker & Neeme Järvi", ArtistId = i++ },
                new Artist { Name = "Guns N' Roses", ArtistId = i++ },
                new Artist { Name = "Gustav Mahler", ArtistId = i++ },
                new Artist { Name = "Incognito", ArtistId = i++ },
                new Artist { Name = "Iron Maiden", ArtistId = i++ },
                new Artist { Name = "James Levine", ArtistId = i++ },
                new Artist { Name = "Jamiroquai", ArtistId = i++ },
                new Artist { Name = "Jimi Hendrix", ArtistId = i++ },
                new Artist { Name = "Joe Satriani", ArtistId = i++ },
                new Artist { Name = "Jorge Ben", ArtistId = i++ },
                new Artist { Name = "Jota Quest", ArtistId = i++ },
                new Artist { Name = "Judas Priest", ArtistId = i++ },
                new Artist { Name = "Julian Bream", ArtistId = i++ },
                new Artist { Name = "Kent Nagano and Orchestre de l'Opéra de Lyon", ArtistId = i++ },
                new Artist { Name = "Kiss", ArtistId = i++ },
                new Artist { Name = "Led Zeppelin", ArtistId = i++ },
                new Artist { Name = "Legião Urbana", ArtistId = i++ },
                new Artist { Name = "Lenny Kravitz", ArtistId = i++ },
                new Artist { Name = "Les Arts Florissants & William Christie", ArtistId = i++ },
                new Artist { Name = "London Symphony Orchestra & Sir Charles Mackerras", ArtistId = i++ },
                new Artist { Name = "Luciana Souza/Romero Lubambo", ArtistId = i++ },
                new Artist { Name = "Lulu Santos", ArtistId = i++ },
                new Artist { Name = "Marcos Valle", ArtistId = i++ },
                new Artist { Name = "Marillion", ArtistId = i++ },
                new Artist { Name = "Marisa Monte", ArtistId = i++ },
                new Artist { Name = "Martin Roscoe", ArtistId = i++ },
                new Artist { Name = "Maurizio Pollini", ArtistId = i++ },
                new Artist { Name = "Mela Tenenbaum, Pro Musica Prague & Richard Kapp", ArtistId = i++ },
                new Artist { Name = "Men At Work", ArtistId = i++ },
                new Artist { Name = "Metallica", ArtistId = i++ },
                new Artist { Name = "Michael Tilson Thomas & San Francisco Symphony", ArtistId = i++ },
                new Artist { Name = "Miles Davis", ArtistId = i++ },
                new Artist { Name = "Milton Nascimento", ArtistId = i++ },
                new Artist { Name = "Mötley Crüe", ArtistId = i++ },
                new Artist { Name = "Motörhead", ArtistId = i++ },
                new Artist { Name = "Nash Ensemble", ArtistId = i++ },
                new Artist { Name = "Nicolaus Esterhazy Sinfonia", ArtistId = i++ },
                new Artist { Name = "Nirvana", ArtistId = i++ },
                new Artist { Name = "O Terço", ArtistId = i++ },
                new Artist { Name = "Olodum", ArtistId = i++ },
                new Artist { Name = "Orchestra of The Age of Enlightenment", ArtistId = i++ },
                new Artist { Name = "Os Paralamas Do Sucesso", ArtistId = i++ },
                new Artist { Name = "Ozzy Osbourne", ArtistId = i++ },
                new Artist { Name = "Page & Plant", ArtistId = i++ },
                new Artist { Name = "Paul D'Ianno", ArtistId = i++ },
                new Artist { Name = "Pearl Jam", ArtistId = i++ },
                new Artist { Name = "Pink Floyd", ArtistId = i++ },
                new Artist { Name = "Queen", ArtistId = i++ },
                new Artist { Name = "R.E.M.", ArtistId = i++ },
                new Artist { Name = "Raul Seixas", ArtistId = i++ },
                new Artist { Name = "Red Hot Chili Peppers", ArtistId = i++ },
                new Artist { Name = "Roger Norrington, London Classical Players", ArtistId = i++ },
                new Artist { Name = "Royal Philharmonic Orchestra & Sir Thomas Beecham", ArtistId = i++ },
                new Artist { Name = "Rush", ArtistId = i++ },
                new Artist { Name = "Santana", ArtistId = i++ },
                new Artist { Name = "Scholars Baroque Ensemble", ArtistId = i++ },
                new Artist { Name = "Scorpions", ArtistId = i++ },
                new Artist { Name = "Sergei Prokofiev & Yuri Temirkanov", ArtistId = i++ },
                new Artist { Name = "Sir Georg Solti & Wiener Philharmoniker", ArtistId = i++ },
                new Artist { Name = "Skank", ArtistId = i++ },
                new Artist { Name = "Soundgarden", ArtistId = i++ },
                new Artist { Name = "Spyro Gyra", ArtistId = i++ },
                new Artist { Name = "Stevie Ray Vaughan & Double Trouble", ArtistId = i++ },
                new Artist { Name = "Stone Temple Pilots", ArtistId = i++ },
                new Artist { Name = "System Of A Down", ArtistId = i++ },
                new Artist { Name = "Temple of the Dog", ArtistId = i++ },
                new Artist { Name = "Terry Bozzio, Tony Levin & Steve Stevens", ArtistId = i++ },
                new Artist { Name = "The 12 Cellists of The Berlin Philharmonic", ArtistId = i++ },
                new Artist { Name = "The Black Crowes", ArtistId = i++ },
                new Artist { Name = "The Cult", ArtistId = i++ },
                new Artist { Name = "The Doors", ArtistId = i++ },
                new Artist { Name = "The King's Singers", ArtistId = i++ },
                new Artist { Name = "The Police", ArtistId = i++ },
                new Artist { Name = "The Posies", ArtistId = i++ },
                new Artist { Name = "The Rolling Stones", ArtistId = i++ },
                new Artist { Name = "The Who", ArtistId = i++ },
                new Artist { Name = "Tim Maia", ArtistId = i++ },
                new Artist { Name = "Ton Koopman", ArtistId = i++ },
                new Artist { Name = "U2", ArtistId = i++ },
                new Artist { Name = "UB40", ArtistId = i++ },
                new Artist { Name = "Van Halen", ArtistId = i++ },
                new Artist { Name = "Various Aenres", ArtistId = i++ },
                new Artist { Name = "Velvet Revolver", ArtistId = i++ },
                new Artist { Name = "Vinícius De Moraes", ArtistId = i++ },
                new Artist { Name = "Wilhelm Kempff", ArtistId = i++ },
                new Artist { Name = "Yehudi Menuhin", ArtistId = i++ },
                new Artist { Name = "Yo-Yo Ma", ArtistId = i++ },
                new Artist { Name = "Zeca Pagodinho", ArtistId = i++ }
                );


        }


        //Seed数据
        public DbSet<MusicStore.ViewModels.ShoppingCartViewModel> ShoppingCartViewModel { get; set; }



    }
}
