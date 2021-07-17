using Microsoft.EntityFrameworkCore.Migrations;

namespace SwiezeBackend.Migrations
{
    public partial class SeedContactClientUnitType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "UnitTypes",
                type: "character varying(60)",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(30)",
                oldMaxLength: 30);

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactId", "City", "FlatNumber", "HouseNumber", "Mail", "Phone", "PostalCode", "Street", "Voivodeship" },
                values: new object[,]
                {
                    { 1, "Lake Mohamedbury", "97Z", "8537", "Halie48@hotmail.com", "804892815", "64-780", "Bailee Expressway", "Pennsylvania" },
                    { 74, "West Melyssafort", "609D", "87663", "Sarina.Schmeler@yahoo.com", "183115557", "14-097", "Mante Mall", "Nebraska" },
                    { 73, "Rooseveltfurt", "159", "4997", "Aniyah.Gislason80@gmail.com", "201420304", "92-817", "Abshire Ville", "Indiana" },
                    { 72, "West Zeldastad", "10S", "71851", "Marjorie_Wiza@hotmail.com", "749891651", "57-853", "Cheyenne Union", "Maryland" },
                    { 71, "Ronaldoville", "27", "007", "Dawn_Rowe@yahoo.com", "965755514", "43-894", "Tyrese Forest", "Maine" },
                    { 70, "South Quinnside", "957Z", "3264", "Walton_Kovacek@gmail.com", "884861923", "34-883", "Nitzsche Stravenue", "New York" },
                    { 69, "North Stevefort", "4X", "1387", "Aliya_Gusikowski@hotmail.com", "941263712", "19-431", "Meagan Isle", "Mississippi" },
                    { 68, "East Aurore", "726B", "107", "Curtis_DuBuque@hotmail.com", "448473617", "46-988", "Frami Orchard", "North Carolina" },
                    { 67, "Gutmanntown", "34R", "97678", "Jean_Tremblay@yahoo.com", "580266713", "20-166", "Stark Skyway", "Idaho" },
                    { 66, "Herzogland", "60U", "775", "Chauncey_Cruickshank37@hotmail.com", "969205492", "01-020", "Hand Parks", "Alaska" },
                    { 65, "West Clare", "06H", "0185", "Priscilla.Torp@hotmail.com", "730726332", "66-347", "Muller Union", "Delaware" },
                    { 64, "East Marvin", "536", "827", "Verdie29@hotmail.com", "565858004", "11-417", "Quigley Fields", "Texas" },
                    { 63, "East Jeanetteside", "958", "317", "Enrique_Orn45@yahoo.com", "823704775", "36-669", "Gaylord Port", "Minnesota" },
                    { 62, "Whitneyburgh", "27Z", "7379", "Candelario.Schinner@yahoo.com", "473103008", "74-179", "Koss Highway", "North Dakota" },
                    { 61, "Port Ernie", "32N", "455", "Electa_Keeling@hotmail.com", "635722159", "46-957", "Jovan Keys", "Kentucky" },
                    { 60, "East Johnathonland", "33", "22621", "Kallie83@hotmail.com", "694453909", "86-922", "Delmer Parkways", "North Dakota" },
                    { 59, "North Donnellchester", "8D", "15379", "Shana_Kuhlman4@gmail.com", "315053399", "05-206", "Dooley Stream", "Mississippi" },
                    { 58, "North Carterstad", "29", "2134", "Xzavier.Bartoletti@hotmail.com", "391507402", "94-334", "Reina Mountain", "Massachusetts" },
                    { 57, "East Katlynnmouth", "0", "734", "Micah.Runolfsdottir@gmail.com", "555821719", "02-749", "Jast Skyway", "South Carolina" },
                    { 56, "Herzogfort", "898H", "03475", "Gregory_Rau63@gmail.com", "519936256", "20-547", "Audra Expressway", "South Dakota" },
                    { 54, "Lake Pasquale", "20", "1510", "Assunta56@yahoo.com", "647696545", "16-195", "Sanford Corner", "South Carolina" },
                    { 53, "Lake Verla", "67M", "91727", "Vicente.Pfannerstill21@gmail.com", "721774833", "85-412", "Jaren Brooks", "New Mexico" },
                    { 75, "New Janelleton", "877", "200", "Myles48@yahoo.com", "322789896", "65-944", "Zane Knolls", "Minnesota" },
                    { 76, "Dibbertberg", "45", "567", "Karina.Halvorson1@gmail.com", "659531584", "51-873", "Amos Dale", "Iowa" },
                    { 77, "Ronnyland", "9E", "75672", "Hipolito.Osinski@yahoo.com", "444736667", "59-018", "Kevon Roads", "Wyoming" },
                    { 78, "Williamsonshire", "898", "3887", "Keagan67@hotmail.com", "254586466", "53-162", "Ruben Street", "Missouri" },
                    { 100, "Stehrberg", "2", "261", "Jerod.Carter@hotmail.com", "172264637", "15-989", "Kailee Circles", "North Carolina" },
                    { 99, "Stoltenbergshire", "4", "9211", "Michale.Flatley93@hotmail.com", "165475553", "85-962", "Nolan Cliffs", "Virginia" },
                    { 98, "Wisokychester", "57", "12370", "Dalton7@gmail.com", "211884941", "78-490", "Parker Lakes", "North Dakota" },
                    { 97, "Framibury", "467", "8037", "Liana.Walter@hotmail.com", "308105086", "17-910", "Lakin Port", "Louisiana" },
                    { 96, "Bayerchester", "870", "88966", "Lorenza37@yahoo.com", "223330540", "84-768", "Broderick Shore", "Florida" },
                    { 95, "West Sibyl", "99N", "78265", "Graham_Lang27@hotmail.com", "437263101", "34-856", "Paris Mission", "Connecticut" },
                    { 94, "Ricoton", "6", "3746", "Marco_Jaskolski@hotmail.com", "365598563", "78-722", "Viola Road", "Wisconsin" },
                    { 93, "Towneborough", "3", "00888", "Mavis.Hilpert39@yahoo.com", "215628241", "07-724", "Garett Pike", "Vermont" },
                    { 92, "Goyetteville", "79G", "08234", "Marta_Collins@hotmail.com", "747786529", "26-930", "Pfannerstill Haven", "Minnesota" },
                    { 91, "Icieport", "3", "92451", "Agustin.Kohler@yahoo.com", "630869486", "79-671", "Kailyn Keys", "Arizona" },
                    { 52, "South Rosendoville", "5O", "88056", "Beryl.Mueller@hotmail.com", "493358213", "16-025", "Xzavier Mews", "New York" },
                    { 90, "Port Aldaton", "527P", "388", "Greta.Lesch11@gmail.com", "576569214", "34-416", "Spencer Stravenue", "Washington" },
                    { 88, "New Shad", "28", "90628", "Oral.Schuppe@gmail.com", "181477652", "42-152", "Abby Junction", "Connecticut" },
                    { 87, "North Laurenberg", "54R", "5485", "Jaylin41@hotmail.com", "764504521", "08-093", "Jaden Lodge", "Hawaii" },
                    { 86, "South Carriebury", "514", "45240", "Earnest_Cruickshank@yahoo.com", "529163636", "32-470", "Feil Light", "South Dakota" },
                    { 85, "East Dorthaside", "8", "648", "Clair.Murray@hotmail.com", "762179396", "35-158", "Steuber Courts", "Montana" },
                    { 84, "New Kian", "3", "15375", "Wilford.Lebsack66@yahoo.com", "722829118", "53-621", "Katharina Pine", "Iowa" },
                    { 83, "North Jared", "69", "92017", "Myah_Baumbach@yahoo.com", "251244114", "88-053", "Jeremy Loaf", "Vermont" },
                    { 82, "Gislasonmouth", "69", "29260", "Emmie_Wisoky@gmail.com", "998702168", "46-775", "Bobby Underpass", "New Mexico" },
                    { 81, "Haleyport", "633L", "272", "Donnell.Terry@gmail.com", "116375990", "99-823", "Ahmad Ports", "California" },
                    { 80, "New Mabelleport", "299", "17892", "Ressie29@yahoo.com", "230165413", "28-824", "Okuneva Orchard", "Idaho" },
                    { 79, "North Brent", "148", "20756", "Alfreda_Armstrong@gmail.com", "671303219", "15-462", "Noemy Shoal", "Arkansas" },
                    { 89, "Klockotown", "7", "1444", "Maribel79@hotmail.com", "321860512", "79-282", "Gerhard Way", "Delaware" },
                    { 51, "Skilesport", "326R", "3520", "Brittany24@yahoo.com", "935746757", "83-481", "Stanton Creek", "South Dakota" },
                    { 55, "North River", "58", "54941", "Vivienne4@yahoo.com", "334117160", "27-193", "Cary Spur", "Maine" },
                    { 49, "North Adolphus", "22O", "12885", "Nicole62@yahoo.com", "935116146", "56-208", "Russel Walk", "Oklahoma" },
                    { 23, "West Berenicechester", "973", "134", "Bette51@yahoo.com", "712804335", "73-261", "Bailey Underpass", "Maine" },
                    { 22, "North Heberhaven", "3", "911", "Dereck.Grimes@hotmail.com", "850821978", "08-304", "Rosalee Row", "Maryland" },
                    { 50, "East Timmy", "0", "90350", "Eda.Feest72@hotmail.com", "219130968", "83-720", "Jacobi Mills", "Connecticut" },
                    { 20, "Schadenfort", "1", "13838", "Sheila49@hotmail.com", "967728830", "57-645", "Everett Motorway", "Utah" },
                    { 19, "Eldaside", "520", "75109", "Henri95@gmail.com", "164513456", "81-509", "Jovany Radial", "Tennessee" },
                    { 18, "Masonview", "36C", "716", "Kirk.Parker40@hotmail.com", "608897949", "19-025", "Paucek Inlet", "Utah" },
                    { 17, "Idellaland", "8", "51291", "Myron26@hotmail.com", "643601002", "66-225", "Kareem Roads", "Kansas" },
                    { 16, "West Josephinechester", "863", "96137", "Geovany.Walsh19@gmail.com", "284202846", "32-321", "Waelchi Field", "New York" },
                    { 15, "Lake Efren", "4M", "89534", "Emmet26@gmail.com", "749543843", "40-919", "Rosina Orchard", "South Dakota" },
                    { 14, "North Adolphusmouth", "9U", "4252", "Karlee70@hotmail.com", "597689949", "64-586", "Myrtle Dale", "Louisiana" },
                    { 24, "Port Christymouth", "387P", "1226", "Chelsie0@yahoo.com", "970928858", "83-340", "Nikolaus Common", "Colorado" },
                    { 13, "Kassulketown", "2", "616", "Terence_Romaguera@gmail.com", "756744512", "54-694", "Charlotte Prairie", "Illinois" },
                    { 11, "South Cyril", "22O", "6157", "Gregg44@yahoo.com", "201184793", "39-757", "Clare Way", "Massachusetts" },
                    { 10, "Port Emie", "199Q", "83300", "Esteban.Cruickshank29@gmail.com", "581868454", "95-935", "Bailey Mount", "North Dakota" },
                    { 9, "Yasmineshire", "593", "7714", "Quinten_Considine@hotmail.com", "476800644", "66-333", "Karlee Hill", "Montana" },
                    { 8, "Pfannerstillshire", "3U", "605", "Gail_OReilly@yahoo.com", "884450304", "06-130", "Lessie Freeway", "Oregon" },
                    { 7, "West Patiencefurt", "1", "2375", "Alia_Connelly@gmail.com", "739039160", "13-042", "Gaetano Trace", "Colorado" },
                    { 6, "Port Daren", "67F", "830", "Krystel4@hotmail.com", "505670197", "97-639", "Alyce Cape", "California" },
                    { 5, "West Queenville", "644H", "4926", "Scot29@yahoo.com", "115369061", "52-678", "Corene Tunnel", "Rhode Island" },
                    { 4, "Glovermouth", "0", "74682", "Brando0@yahoo.com", "496711471", "89-438", "Goyette Plains", "Wisconsin" },
                    { 3, "New Keaton", "2R", "52912", "Frida_Armstrong@hotmail.com", "288544533", "95-582", "Ernser Courts", "Washington" },
                    { 2, "New Garrisonbury", "67", "2625", "Kaia25@hotmail.com", "238569164", "48-927", "Margarett Streets", "Tennessee" },
                    { 12, "New Shyannborough", "293W", "752", "Abelardo45@gmail.com", "937258777", "42-521", "Johnston Turnpike", "Florida" },
                    { 25, "North Bret", "3", "60892", "Lera_Bashirian@yahoo.com", "471404432", "14-595", "Kolby Isle", "Georgia" },
                    { 21, "Bradtketown", "26Q", "09498", "Destiney.Bednar18@gmail.com", "726508555", "13-908", "Goodwin Cove", "Wisconsin" },
                    { 27, "Aufderharstad", "59", "8391", "Jessy.Homenick41@yahoo.com", "560046478", "36-031", "Emmie Ford", "Rhode Island" },
                    { 48, "Marcellaside", "0C", "9274", "Landen.Langworth61@gmail.com", "146012079", "31-178", "Jayne Forest", "Hawaii" },
                    { 47, "East Hilbert", "162", "1365", "Freddie_Prohaska@yahoo.com", "636977602", "17-226", "Colt Mill", "Maryland" },
                    { 46, "Port Kurtchester", "691J", "966", "Melody3@gmail.com", "812371666", "22-976", "Jerod Junction", "Alabama" },
                    { 45, "Rogahnburgh", "48", "91610", "Oren_Lind@hotmail.com", "759598069", "77-371", "Julian Harbors", "Wisconsin" },
                    { 44, "Morissetteland", "4X", "28126", "Devante69@yahoo.com", "589325692", "27-510", "Iliana Terrace", "Florida" },
                    { 26, "Lilianstad", "57E", "231", "Stella_Botsford@hotmail.com", "917135186", "72-344", "Mable Key", "South Carolina" },
                    { 42, "Verdahaven", "622R", "138", "Norma11@gmail.com", "744927491", "25-314", "Adams Garden", "New Jersey" },
                    { 41, "Peytonton", "84N", "9448", "Jules_OKeefe5@yahoo.com", "481523246", "49-561", "Schneider Fields", "Nevada" },
                    { 40, "Murphyport", "1", "500", "Shemar93@gmail.com", "490741240", "32-303", "Krajcik Mission", "North Carolina" },
                    { 39, "Port Dominiquemouth", "3P", "85559", "Columbus_Wolff5@hotmail.com", "610578718", "90-401", "Blick Underpass", "Pennsylvania" },
                    { 43, "Lake Tracy", "54", "45593", "Bert_Sanford31@yahoo.com", "278828085", "81-524", "Weissnat Meadow", "Kentucky" },
                    { 37, "Port Lea", "81L", "5908", "Kamron_Krajcik@gmail.com", "460969879", "68-720", "Breanna Mission", "Indiana" },
                    { 38, "South Maureenside", "74D", "93766", "Juliana53@hotmail.com", "723505106", "05-539", "Tiffany Forks", "South Carolina" },
                    { 29, "North Genovevafort", "6X", "6258", "Amya_Stracke80@hotmail.com", "454542676", "20-353", "Huels Bypass", "Montana" },
                    { 30, "Wolfffort", "16", "2768", "Brian.Huel@gmail.com", "262647809", "75-548", "Hammes Crossroad", "Georgia" },
                    { 31, "Port Jamir", "0", "0437", "Elna.Stanton@hotmail.com", "785657489", "90-930", "Stracke Mews", "Indiana" },
                    { 28, "Rosenbaumhaven", "6", "529", "Caterina.Deckow75@gmail.com", "466185633", "01-599", "Gaston Island", "Montana" },
                    { 33, "Schambergershire", "8H", "51800", "Marcos_Bednar23@yahoo.com", "337307653", "46-023", "Brekke Via", "Nebraska" },
                    { 34, "Gutmannbury", "871S", "18941", "Sage47@hotmail.com", "169230667", "76-275", "Virginia Mission", "Louisiana" },
                    { 35, "Mitchellhaven", "5J", "108", "Caden_Rath@gmail.com", "268925757", "42-497", "Pacocha Divide", "Tennessee" },
                    { 36, "Port Elfriedabury", "0J", "90488", "Jammie_Tremblay@gmail.com", "370393625", "85-222", "Rau Groves", "West Virginia" },
                    { 32, "Lehnerburgh", "7W", "6473", "Marta50@hotmail.com", "734817748", "61-059", "Clement Expressway", "South Dakota" }
                });

            migrationBuilder.InsertData(
                table: "UnitTypes",
                columns: new[] { "UnitTypeId", "Name" },
                values: new object[,]
                {
                    { 9, "Metrics" },
                    { 1, "payment" },
                    { 2, "Phased" },
                    { 3, "Baby" },
                    { 4, "Handcrafted" },
                    { 5, "microchip" },
                    { 6, "Product" },
                    { 7, "Engineer" },
                    { 8, "Trail" },
                    { 10, "calculating" }
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "ClientId", "ContactId", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, 1, "Joanna", "Hand" },
                    { 73, 73, "Andres", "Waters" },
                    { 72, 72, "Natalie", "Sporer" },
                    { 71, 71, "Candice", "Grimes" },
                    { 70, 70, "Jan", "Powlowski" },
                    { 69, 69, "Wilson", "Harvey" },
                    { 68, 68, "Wilbert", "Vandervort" },
                    { 67, 67, "Anna", "Schowalter" },
                    { 66, 66, "Donna", "Klein" },
                    { 65, 65, "Al", "Rolfson" },
                    { 64, 64, "Pam", "Labadie" },
                    { 63, 63, "Juana", "Miller" },
                    { 62, 62, "Felicia", "Brakus" },
                    { 61, 61, "Lester", "Fisher" },
                    { 60, 60, "Sally", "Ortiz" },
                    { 59, 59, "Aaron", "White" },
                    { 58, 58, "Pete", "Jast" },
                    { 57, 57, "Kim", "Walsh" },
                    { 56, 56, "Lynda", "Langosh" },
                    { 55, 55, "Ora", "Hagenes" },
                    { 54, 54, "Abel", "Johns" },
                    { 53, 53, "Amanda", "Reichert" },
                    { 74, 74, "Willie", "Mante" },
                    { 52, 52, "Dana", "Huels" },
                    { 75, 75, "Paulette", "Ziemann" },
                    { 77, 77, "Loretta", "Langosh" },
                    { 98, 98, "Dexter", "Prosacco" },
                    { 97, 97, "Gordon", "Cole" },
                    { 96, 96, "Santos", "Franecki" },
                    { 95, 95, "Tom", "Bartell" },
                    { 94, 94, "Jordan", "Maggio" },
                    { 93, 93, "Robin", "Aufderhar" },
                    { 92, 92, "Kayla", "Raynor" },
                    { 91, 91, "Carolyn", "Kub" },
                    { 90, 90, "Francisco", "Pollich" },
                    { 89, 89, "Candice", "Lowe" },
                    { 88, 88, "Ismael", "Weber" },
                    { 87, 87, "Daisy", "Langworth" },
                    { 86, 86, "Kent", "Hilpert" },
                    { 85, 85, "Judith", "Glover" },
                    { 84, 84, "Vicky", "Stark" },
                    { 83, 83, "Bradley", "Moore" },
                    { 82, 82, "Raymond", "Zboncak" },
                    { 81, 81, "Jeff", "Thompson" },
                    { 80, 80, "Marcia", "Pfannerstill" },
                    { 79, 79, "Amber", "Sauer" },
                    { 78, 78, "Alfred", "Hermann" },
                    { 76, 76, "Caroline", "Farrell" },
                    { 51, 51, "Tracy", "Boyle" },
                    { 50, 50, "Geraldine", "Corkery" },
                    { 49, 49, "Brendan", "Lindgren" },
                    { 22, 22, "Dean", "King" },
                    { 21, 21, "Cornelius", "D'Amore" },
                    { 20, 20, "Blanca", "Prohaska" },
                    { 19, 19, "Rachael", "Boyle" },
                    { 18, 18, "Irma", "Kulas" },
                    { 17, 17, "Dwayne", "Wilderman" },
                    { 16, 16, "Mona", "Weissnat" },
                    { 15, 15, "Janie", "Langworth" },
                    { 14, 14, "Nathaniel", "Terry" },
                    { 13, 13, "Deanna", "Hilll" },
                    { 12, 12, "Roger", "O'Kon" },
                    { 11, 11, "Glenn", "Rice" },
                    { 10, 10, "Laurie", "Wintheiser" },
                    { 9, 9, "Al", "Watsica" },
                    { 8, 8, "Omar", "Ziemann" },
                    { 7, 7, "Glenda", "Osinski" },
                    { 6, 6, "Albert", "Cassin" },
                    { 5, 5, "Tracy", "Nader" },
                    { 4, 4, "Ken", "Buckridge" },
                    { 3, 3, "Kelly", "Berge" },
                    { 2, 2, "Leticia", "Kihn" },
                    { 23, 23, "Orville", "Harber" },
                    { 24, 24, "Michele", "Lemke" },
                    { 25, 25, "Jo", "McGlynn" },
                    { 26, 26, "Ignacio", "Gulgowski" },
                    { 48, 48, "Roman", "Frami" },
                    { 47, 47, "Sophia", "Monahan" },
                    { 46, 46, "Marlon", "Cronin" },
                    { 45, 45, "Raquel", "Collier" },
                    { 44, 44, "Rolando", "Gusikowski" },
                    { 43, 43, "Leland", "Collier" },
                    { 42, 42, "Janis", "Roberts" },
                    { 41, 41, "Rafael", "Koelpin" },
                    { 40, 40, "Hattie", "Herzog" },
                    { 39, 39, "Opal", "Ruecker" },
                    { 99, 99, "Maggie", "Pfeffer" },
                    { 38, 38, "Julio", "Mann" },
                    { 36, 36, "Harriet", "Wehner" },
                    { 35, 35, "Anita", "Prosacco" },
                    { 34, 34, "Warren", "Mertz" },
                    { 33, 33, "Joseph", "Morar" },
                    { 32, 32, "Derek", "Zboncak" },
                    { 31, 31, "Mindy", "Von" },
                    { 30, 30, "Tyrone", "Heidenreich" },
                    { 29, 29, "Tina", "Ruecker" },
                    { 28, 28, "Opal", "Rodriguez" },
                    { 27, 27, "Roy", "Gusikowski" },
                    { 37, 37, "Toby", "Ritchie" },
                    { 100, 100, "Kendra", "Mann" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "UnitTypes",
                keyColumn: "UnitTypeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UnitTypes",
                keyColumn: "UnitTypeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UnitTypes",
                keyColumn: "UnitTypeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "UnitTypes",
                keyColumn: "UnitTypeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "UnitTypes",
                keyColumn: "UnitTypeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "UnitTypes",
                keyColumn: "UnitTypeId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "UnitTypes",
                keyColumn: "UnitTypeId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "UnitTypes",
                keyColumn: "UnitTypeId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "UnitTypes",
                keyColumn: "UnitTypeId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "UnitTypes",
                keyColumn: "UnitTypeId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "UnitTypes",
                type: "character varying(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(60)",
                oldMaxLength: 60);
        }
    }
}
