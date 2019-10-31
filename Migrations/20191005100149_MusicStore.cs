using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicStore.Migrations
{
    public partial class MusicStore : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artists",
                columns: table => new
                {
                    ArtistId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artists", x => x.ArtistId);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    GenreId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.GenreId);
                });

            migrationBuilder.CreateTable(
                name: "Albums",
                columns: table => new
                {
                    AlbumId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GenreId = table.Column<int>(nullable: false),
                    ArtistId = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    AlbumArtUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albums", x => x.AlbumId);
                    table.ForeignKey(
                        name: "FK_Albums_Artists_ArtistId",
                        column: x => x.ArtistId,
                        principalTable: "Artists",
                        principalColumn: "ArtistId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Albums_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "GenreId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[,]
                {
                    { 1, "Aaron Copland & London Symphony Orchestra" },
                    { 98, "Nicolaus Esterhazy Sinfonia" },
                    { 99, "Nirvana" },
                    { 100, "O Terço" },
                    { 101, "Olodum" },
                    { 102, "Orchestra of The Age of Enlightenment" },
                    { 103, "Os Paralamas Do Sucesso" },
                    { 97, "Nash Ensemble" },
                    { 104, "Ozzy Osbourne" },
                    { 106, "Paul D'Ianno" },
                    { 107, "Pearl Jam" },
                    { 108, "Pink Floyd" },
                    { 109, "Queen" },
                    { 110, "R.E.M." },
                    { 111, "Raul Seixas" },
                    { 105, "Page & Plant" },
                    { 96, "Motörhead" },
                    { 95, "Mötley Crüe" },
                    { 94, "Milton Nascimento" },
                    { 78, "Legião Urbana" },
                    { 79, "Lenny Kravitz" },
                    { 81, "London Symphony Orchestra & Sir Charles Mackerras" },
                    { 82, "Luciana Souza/Romero Lubambo" },
                    { 83, "Lulu Santos" },
                    { 84, "Marcos Valle" },
                    { 85, "Marillion" },
                    { 86, "Marisa Monte" },
                    { 87, "Martin Roscoe" },
                    { 88, "Maurizio Pollini" },
                    { 89, "Mela Tenenbaum, Pro Musica Prague & Richard Kapp" },
                    { 90, "Men At Work" },
                    { 91, "Metallica" },
                    { 92, "Michael Tilson Thomas & San Francisco Symphony" },
                    { 93, "Miles Davis" },
                    { 112, "Red Hot Chili Peppers" },
                    { 113, "Roger Norrington, London Classical Players" },
                    { 114, "Royal Philharmonic Orchestra & Sir Thomas Beecham" },
                    { 115, "Rush" },
                    { 135, "The Posies" },
                    { 136, "The Rolling Stones" },
                    { 137, "The Who" },
                    { 138, "Tim Maia" },
                    { 139, "Ton Koopman" },
                    { 140, "U2" },
                    { 141, "UB40" },
                    { 142, "Van Halen" },
                    { 143, "Various Aenres" },
                    { 144, "Velvet Revolver" },
                    { 145, "Vinícius De Moraes" },
                    { 146, "Wilhelm Kempff" },
                    { 147, "Yehudi Menuhin" },
                    { 148, "Yo-Yo Ma" },
                    { 149, "Zeca Pagodinho" },
                    { 134, "The Police" },
                    { 77, "Led Zeppelin" },
                    { 133, "The King's Singers" },
                    { 131, "The Cult" },
                    { 116, "Santana" },
                    { 117, "Scholars Baroque Ensemble" },
                    { 118, "Scorpions" },
                    { 119, "Sergei Prokofiev & Yuri Temirkanov" },
                    { 120, "Sir Georg Solti & Wiener Philharmoniker" },
                    { 121, "Skank" },
                    { 122, "Soundgarden" },
                    { 123, "Spyro Gyra" },
                    { 124, "Stevie Ray Vaughan & Double Trouble" },
                    { 125, "Stone Temple Pilots" },
                    { 126, "System Of A Down" },
                    { 127, "Temple of the Dog" },
                    { 128, "Terry Bozzio, Tony Levin & Steve Stevens" },
                    { 129, "The 12 Cellists of The Berlin Philharmonic" },
                    { 130, "The Black Crowes" },
                    { 132, "The Doors" },
                    { 76, "Kiss" },
                    { 80, "Les Arts Florissants & William Christie" },
                    { 74, "Julian Bream" },
                    { 21, "Black Sabbath" },
                    { 22, "Boston Symphony Orchestra & Seiji Ozawa" },
                    { 23, "Britten Sinfonia, Ivor Bolton & Lesley Garrett" },
                    { 24, "Bruce Dickinson" },
                    { 25, "Buddy Guy" },
                    { 26, "Caetano Veloso" },
                    { 27, "Cake" },
                    { 28, "Calexico" },
                    { 29, "Cássia Eller" },
                    { 30, "Chic" },
                    { 31, "Chicago Symphony Orchestra & Fritz Reiner" },
                    { 32, "Chico Buarque" },
                    { 33, "Chico Science & Nação Zumbi" },
                    { 75, "Kent Nagano and Orchestre de l'Opéra de Lyon" },
                    { 35, "Chris Cornell" },
                    { 20, "Black Label Society" },
                    { 36, "Christopher O'Riley" },
                    { 19, "Billy Cobham" },
                    { 17, "Berliner Philharmoniker & Hans Rosbaud" },
                    { 2, "Aaron Goldberg" },
                    { 3, "AC/DC" },
                    { 4, "Accept" },
                    { 5, "Adrian Leaper & Doreen de Feis" },
                    { 6, "Aerosmith" },
                    { 7, "Aisha Duo" },
                    { 8, "Alanis Morissette" },
                    { 9, "Alberto Turco & Nova Schola Gregoriana" },
                    { 10, "Alice In Chains" },
                    { 11, "Amy Winehouse" },
                    { 12, "Anita Ward" },
                    { 13, "Antônio Carlos Jobim" },
                    { 14, "Apocalyptica" },
                    { 15, "Audioslave" },
                    { 16, "Barry Wordsworth & BBC Concert Orchestra" },
                    { 18, "Berliner Philharmoniker & Herbert Von Karajan" },
                    { 37, "Cidade Negra" },
                    { 34, "Choir Of Westminster Abbey & Simon Preston" },
                    { 39, "Creedence Clearwater Revival" },
                    { 59, "Gilberto Gil" },
                    { 60, "Godsmack" },
                    { 38, "Cláudio Zoli" },
                    { 62, "Göteborgs Symfoniker & Neeme Järvi" },
                    { 63, "Guns N' Roses" },
                    { 64, "Gustav Mahler" },
                    { 65, "Incognito" },
                    { 66, "Iron Maiden" },
                    { 67, "James Levine" },
                    { 68, "Jamiroquai" },
                    { 69, "Jimi Hendrix" },
                    { 70, "Joe Satriani" },
                    { 71, "Jorge Ben" },
                    { 72, "Jota Quest" },
                    { 73, "Judas Priest" },
                    { 58, "Gerald Moore" },
                    { 57, "Funk Como Le Gusta" },
                    { 61, "Gonzaguinha" },
                    { 55, "Frank Zappa & Captain Beefheart" },
                    { 40, "David Coverdale" },
                    { 41, "Deep Purple" },
                    { 42, "Dennis Chambers" },
                    { 56, "Fretwork" },
                    { 43, "Djavan" },
                    { 44, "Donna Summer" },
                    { 46, "Ed Motta" },
                    { 45, "Dread Zeppelin" },
                    { 48, "Elis Regina" },
                    { 49, "English Concert & Trevor Pinnock" },
                    { 50, "Eric Clapton" },
                    { 51, "Eugene Ormandy" },
                    { 52, "Faith No More" },
                    { 53, "Falamansa" },
                    { 54, "Foo Fighters" },
                    { 47, "Edo de Waart & San Francisco Symphony" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "Description", "Name" },
                values: new object[,]
                {
                    { 6, null, "Blues" },
                    { 8, null, "Reggae" },
                    { 7, null, "Latin" },
                    { 5, null, "Disco" },
                    { 9, null, "Pop" },
                    { 3, null, "Metal" },
                    { 2, null, "Jazz" },
                    { 1, null, "Rock" },
                    { 4, null, "Alternative" },
                    { 10, null, "Classical" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Albums_ArtistId",
                table: "Albums",
                column: "ArtistId");

            migrationBuilder.CreateIndex(
                name: "IX_Albums_GenreId",
                table: "Albums",
                column: "GenreId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Albums");

            migrationBuilder.DropTable(
                name: "Artists");

            migrationBuilder.DropTable(
                name: "Genres");
        }
    }
}
