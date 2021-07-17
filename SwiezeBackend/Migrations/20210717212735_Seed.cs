using Microsoft.EntityFrameworkCore.Migrations;

namespace SwiezeBackend.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Products_UnitTypeId",
                table: "Products");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "UnitTypes",
                type: "character varying(60)",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(30)",
                oldMaxLength: 30);

            migrationBuilder.AddColumn<int>(
                name: "VendorId",
                table: "Products",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactId", "City", "FlatNumber", "HouseNumber", "Mail", "Phone", "PostalCode", "Street", "Voivodeship" },
                values: new object[,]
                {
                    { 1, "Lake Mohamedbury", "97Z", "8537", "Halie48@hotmail.com", "804892815", "64-780", "Bailee Expressway", "Pennsylvania" },
                    { 129, "Kertzmannburgh", "464", "091", "Fae27@yahoo.com", "876944130", "89-389", "Florine Spurs", "Pennsylvania" },
                    { 130, "Mariettastad", "43", "54931", "Iliana78@yahoo.com", "416662752", "08-559", "Lind Well", "Colorado" },
                    { 131, "Dorabury", "079Y", "5141", "Daija.Grimes@hotmail.com", "600641840", "05-424", "Clemmie Lights", "Alabama" },
                    { 132, "Estevanside", "455", "29821", "Lexie45@yahoo.com", "305070657", "16-891", "Amber Square", "Virginia" },
                    { 133, "Carrollborough", "07", "9864", "Hassan80@gmail.com", "431335439", "04-077", "Jonathon Course", "Minnesota" },
                    { 134, "New Creola", "70Z", "400", "Heloise.Anderson@yahoo.com", "628439312", "88-409", "Antone Mission", "Michigan" },
                    { 135, "Loganview", "92M", "49239", "Camila_Harvey66@hotmail.com", "159973313", "31-855", "Langosh Ville", "New Hampshire" },
                    { 136, "Langport", "76E", "06634", "Edward_Batz78@hotmail.com", "233683006", "18-810", "Hessel Divide", "Kentucky" },
                    { 137, "North Eltashire", "3P", "37240", "Maymie.Kshlerin@hotmail.com", "814026249", "25-836", "Kuhic Lights", "Virginia" },
                    { 138, "East Artburgh", "73", "074", "Kayden18@yahoo.com", "748829175", "75-058", "Corbin Shoal", "Missouri" },
                    { 139, "Cleoramouth", "749U", "994", "Lulu_Kunze67@hotmail.com", "346489955", "83-418", "Bartell Curve", "Pennsylvania" },
                    { 140, "New Connie", "521V", "397", "Bulah_Kerluke44@hotmail.com", "463198838", "95-403", "Donavon Plaza", "New Hampshire" },
                    { 141, "South Tyreek", "22D", "63118", "Ron_Borer@hotmail.com", "158368573", "07-706", "Leanne Course", "Florida" },
                    { 142, "East Gilbertoville", "185S", "514", "Delmer_Considine33@yahoo.com", "714037462", "42-440", "Farrell Mountain", "Oklahoma" },
                    { 143, "Reillyland", "24W", "39945", "Maida_Robel@gmail.com", "960483969", "23-694", "Franecki Stream", "New York" },
                    { 144, "South Marielamouth", "3", "16778", "Kaitlyn81@hotmail.com", "738358040", "37-381", "Alexandrea Forest", "Nebraska" },
                    { 145, "North Adelinemouth", "49", "246", "Olin_Rowe@yahoo.com", "178695360", "00-390", "Alec Stream", "Minnesota" },
                    { 146, "Port Floyd", "65", "083", "Shaina_Kirlin42@gmail.com", "310281191", "41-241", "Kory Shoal", "Nevada" },
                    { 147, "East Tatyana", "8Q", "60335", "Erling.Ortiz@hotmail.com", "145937465", "30-845", "Goyette Bypass", "Connecticut" },
                    { 148, "Lake Derek", "2", "0352", "Raymond56@gmail.com", "185180180", "04-253", "Marguerite Prairie", "Minnesota" },
                    { 149, "Saigetown", "9", "521", "Margaretta53@gmail.com", "737366366", "12-273", "Bernier Roads", "South Carolina" },
                    { 128, "West Nico", "731", "495", "Ivory17@gmail.com", "146308571", "84-215", "Jacobs Via", "Massachusetts" },
                    { 150, "Kenyatown", "46", "44541", "Jennings37@gmail.com", "811893263", "36-785", "Gideon Vista", "Colorado" },
                    { 127, "Reichertchester", "559", "4803", "Crystal.Cruickshank@gmail.com", "952168008", "49-701", "Kirlin Vista", "Alaska" },
                    { 125, "North Quintonport", "454M", "850", "Edison.Berge@gmail.com", "659347699", "94-793", "Elenor Ways", "Ohio" },
                    { 103, "Vivamouth", "03", "5961", "Candido53@yahoo.com", "560198687", "67-112", "Barton Estates", "Alaska" },
                    { 104, "Glennieland", "912", "845", "Destini_Schaefer65@yahoo.com", "272739829", "89-026", "O'Connell Burgs", "Mississippi" },
                    { 106, "Amieborough", "934", "225", "David.Ortiz99@gmail.com", "644111909", "90-135", "Kaylee Pine", "Wisconsin" },
                    { 107, "Erikbury", "0", "131", "Cleve.Goldner25@yahoo.com", "459711666", "57-107", "Buckridge Harbor", "Virginia" },
                    { 108, "Karinemouth", "83", "9668", "Jeremy48@yahoo.com", "998173020", "62-221", "Lowell Drive", "New Mexico" },
                    { 109, "West Demetrishaven", "84", "8580", "Marcelle94@hotmail.com", "543497658", "58-498", "Edythe Pass", "Delaware" },
                    { 110, "Imogeneland", "549", "6042", "Cassie_Franecki62@gmail.com", "871272982", "65-234", "Douglas Parkways", "Alaska" },
                    { 111, "South Bennett", "5H", "28651", "Beverly.Collins20@gmail.com", "329453471", "52-575", "Keshawn Harbor", "Colorado" },
                    { 112, "Creminburgh", "215", "2371", "Floy90@yahoo.com", "177622120", "51-263", "Senger Gateway", "New York" },
                    { 113, "Port Kari", "398", "375", "Kieran59@hotmail.com", "302232734", "63-663", "Marcos Inlet", "Virginia" },
                    { 114, "Lake Malinda", "894", "8411", "Oral.Kub20@hotmail.com", "504244090", "77-724", "King Crossing", "North Dakota" },
                    { 115, "North Alejandrinberg", "073O", "496", "Alyson_Koepp@gmail.com", "450415415", "18-179", "Adell Ranch", "South Carolina" },
                    { 116, "North Julianaton", "50J", "452", "Taryn.Kuvalis@hotmail.com", "378714481", "09-858", "Macy Port", "New York" },
                    { 117, "East Reaganland", "92U", "2898", "Reyes62@gmail.com", "327201576", "97-310", "Santiago Mall", "Idaho" },
                    { 118, "Immanuelview", "377", "7945", "Eleanora_OKeefe18@yahoo.com", "389778782", "80-223", "Reese Knoll", "Hawaii" },
                    { 119, "Monahanstad", "14K", "73957", "Eve.Anderson45@gmail.com", "203380171", "59-044", "Adalberto Mews", "Minnesota" },
                    { 120, "Port Lindsay", "84P", "896", "Kenyatta.Strosin46@gmail.com", "367099046", "90-427", "Mozell Rapid", "Indiana" },
                    { 121, "West Shaunmouth", "826V", "2273", "Kory.Lind@gmail.com", "496715326", "71-865", "Funk Neck", "Nebraska" },
                    { 122, "East Rustyville", "866", "0833", "Mohamed_OConnell@yahoo.com", "119962098", "92-048", "Bernier Prairie", "West Virginia" },
                    { 123, "Lake Staceyburgh", "81", "510", "Johathan94@gmail.com", "883291926", "88-225", "Alberto Cape", "New York" },
                    { 124, "East Carolyn", "19", "8516", "Benny85@gmail.com", "872670928", "51-258", "Goodwin Creek", "Montana" },
                    { 126, "South Johnathon", "4M", "163", "Keshaun_Leannon@hotmail.com", "426069122", "25-135", "Braden Stream", "Oregon" },
                    { 151, "North Chanelle", "6G", "07017", "Caleigh_MacGyver@yahoo.com", "411059628", "64-011", "Ernestina Bridge", "Alabama" },
                    { 152, "West Eldridgeberg", "7", "61535", "Melyssa.Purdy58@gmail.com", "243960126", "25-583", "Tyree Islands", "Michigan" },
                    { 153, "South Shanie", "607F", "333", "Katharina87@yahoo.com", "375567521", "69-204", "Casper Mall", "Hawaii" },
                    { 180, "West Myrna", "010", "6561", "Monique64@gmail.com", "637315551", "91-619", "Ruecker Freeway", "Wyoming" },
                    { 181, "Lake Annamarieshire", "7", "5985", "Lilla42@gmail.com", "119479170", "25-835", "Tremblay Stream", "Nevada" },
                    { 182, "New Llewellynborough", "062W", "1212", "Judd88@hotmail.com", "838319759", "05-724", "Idell Haven", "Hawaii" },
                    { 183, "Ambroseburgh", "6", "36346", "Jerrell70@hotmail.com", "677371110", "08-441", "Delphine Fall", "Michigan" },
                    { 184, "Micaelachester", "478B", "306", "Elton_Ratke98@gmail.com", "757433799", "09-344", "Lillie Shoal", "Illinois" },
                    { 185, "Volkmanberg", "7Y", "02396", "Oda_Rath34@yahoo.com", "750124608", "87-222", "Powlowski Union", "West Virginia" },
                    { 186, "Bernicefort", "456S", "0914", "Lillie.Ward@yahoo.com", "639133478", "29-879", "Zion Mountains", "Montana" },
                    { 187, "West Estelstad", "794", "933", "Liam.Wiegand@gmail.com", "419367423", "14-561", "Swift Plaza", "South Dakota" },
                    { 188, "South Consuelotown", "65", "880", "Dudley58@hotmail.com", "323126810", "27-281", "Hillard Corners", "South Carolina" },
                    { 189, "Hegmannshire", "472", "7700", "Krystina.Spencer46@hotmail.com", "158245868", "59-730", "Collier Trace", "Arkansas" },
                    { 190, "Gusikowskistad", "169", "7422", "Corine.Kilback@yahoo.com", "229138086", "61-742", "Turcotte Row", "New Jersey" },
                    { 191, "New Dereck", "722", "7846", "Estelle.Dicki@yahoo.com", "372652936", "87-119", "Arden Skyway", "Louisiana" },
                    { 192, "Greenholtstad", "577N", "6621", "Teagan58@gmail.com", "165850440", "86-781", "Nikko Motorway", "New Mexico" },
                    { 193, "Predovicport", "07X", "7743", "Kacie_Lockman37@gmail.com", "117264997", "11-485", "Deontae Freeway", "Maine" },
                    { 194, "West Jordonton", "79W", "26783", "Erna.Boyle34@yahoo.com", "462732048", "51-449", "Effertz Inlet", "Delaware" },
                    { 195, "West Camryn", "145", "690", "Rosalyn.Greenholt@gmail.com", "424328621", "34-113", "Kaycee Plaza", "Mississippi" },
                    { 196, "Monahanland", "0W", "353", "Caesar_Nikolaus@yahoo.com", "298303789", "83-658", "Hyatt Mission", "New Hampshire" },
                    { 197, "Hueltown", "2G", "7500", "Josefa_Stroman22@gmail.com", "751464112", "66-773", "Remington Court", "Kansas" },
                    { 198, "Lake Cathrinetown", "279", "678", "Gretchen.Pouros29@yahoo.com", "564017319", "21-549", "Zemlak Burgs", "Iowa" },
                    { 199, "Russellburgh", "964", "28235", "Misty20@yahoo.com", "518926897", "03-396", "Stamm Forge", "Alaska" },
                    { 200, "Armstrongville", "596", "602", "Nadia_Fisher79@yahoo.com", "252955955", "78-386", "Lindgren Prairie", "Pennsylvania" },
                    { 179, "Bernadineburgh", "2", "93252", "Janis_Flatley@hotmail.com", "921428646", "67-681", "Bode Manor", "Washington" },
                    { 178, "Ludwigville", "7Y", "859", "Vernon21@gmail.com", "843305525", "44-775", "Hosea Neck", "New Jersey" },
                    { 177, "Hortensechester", "50E", "8095", "Marjory_Von@yahoo.com", "799701087", "09-872", "Mills Street", "New York" },
                    { 176, "East Alyce", "71S", "9599", "Hortense_Bernhard77@gmail.com", "879516167", "78-414", "Luettgen Flat", "Delaware" },
                    { 154, "North Carleefort", "22", "35920", "Brennan.Cruickshank29@yahoo.com", "220435810", "70-531", "Jerry Valley", "New Mexico" },
                    { 155, "Altenwerthland", "831", "576", "Javier.Hettinger@yahoo.com", "225654617", "32-334", "Murray Via", "Iowa" },
                    { 156, "Lake Priscillaside", "97R", "762", "Chance_Funk@gmail.com", "813136686", "50-866", "Caroline Extensions", "California" },
                    { 157, "Bernierburgh", "62", "92081", "Nina33@gmail.com", "199720844", "76-056", "Kuhic Turnpike", "Vermont" },
                    { 158, "West Abehaven", "2G", "74341", "Emanuel_Grant11@hotmail.com", "765954914", "18-144", "Carlie Camp", "Ohio" },
                    { 159, "Strosinstad", "4", "008", "Kristoffer_Shields@yahoo.com", "666165764", "36-391", "Rath Loop", "Virginia" },
                    { 160, "Port Kareemport", "4O", "6435", "London.Nicolas@yahoo.com", "553229060", "55-470", "Schamberger Harbor", "North Carolina" },
                    { 161, "Emmittside", "011I", "3171", "Gretchen43@gmail.com", "121358344", "48-712", "Keon Divide", "Ohio" },
                    { 162, "Fridaborough", "25", "830", "Shaniya_Auer@gmail.com", "249061618", "21-004", "Bins Parkway", "New Hampshire" },
                    { 163, "Zulaufborough", "25X", "6200", "Zakary_Maggio52@yahoo.com", "247994407", "70-373", "Devyn Pass", "Vermont" },
                    { 102, "Theodoraview", "57", "194", "Johnathon_Boyer29@hotmail.com", "582580762", "33-446", "Katelynn Fort", "Indiana" },
                    { 164, "Emardton", "8Z", "22592", "Leonardo20@gmail.com", "658356389", "52-158", "Howe Circles", "New Jersey" },
                    { 166, "New Bernardochester", "3", "96040", "Ellen56@hotmail.com", "497671179", "71-353", "Kian Plaza", "Indiana" },
                    { 167, "Kirlinside", "312", "3045", "Darian.Strosin@hotmail.com", "166348085", "95-332", "Bernadette Falls", "New York" },
                    { 168, "Friesenhaven", "24N", "6117", "Ahmad.Morar@yahoo.com", "218139995", "19-177", "Schiller Place", "Missouri" },
                    { 169, "South Darren", "84A", "365", "Jamil.Quitzon64@hotmail.com", "790035486", "79-211", "Gutmann Stravenue", "Oklahoma" },
                    { 170, "Nikobury", "800", "995", "Alexandria.Hansen@hotmail.com", "617189196", "52-170", "Wolff Keys", "Mississippi" },
                    { 171, "Nienowton", "8K", "84419", "Oliver_Gusikowski80@yahoo.com", "942179834", "86-662", "Wilburn Spring", "Mississippi" },
                    { 172, "Diegoborough", "8I", "815", "Garnet48@yahoo.com", "275396505", "27-713", "Purdy Circles", "Louisiana" },
                    { 173, "East Jaquelineport", "562U", "540", "Sigrid_Spencer@hotmail.com", "525563332", "05-622", "Brown View", "Connecticut" },
                    { 174, "Lake Lindsayfort", "99", "74834", "Gabriella38@yahoo.com", "877940028", "62-279", "Brown Spring", "New York" },
                    { 175, "Reaganport", "65", "480", "Aniyah26@gmail.com", "359039612", "48-088", "Alejandrin Viaduct", "Connecticut" },
                    { 165, "North Greta", "3E", "186", "Gaylord_Farrell55@hotmail.com", "877307031", "34-599", "Priscilla Mall", "Nevada" },
                    { 101, "Marlenebury", "446W", "148", "Urban93@hotmail.com", "617819480", "34-666", "Russel Gateway", "Missouri" },
                    { 105, "South Gladysborough", "31T", "4607", "Heidi.Paucek@hotmail.com", "566094408", "25-408", "Adah Squares", "North Carolina" },
                    { 99, "Stoltenbergshire", "4", "9211", "Michale.Flatley93@hotmail.com", "165475553", "85-962", "Nolan Cliffs", "Virginia" },
                    { 28, "Rosenbaumhaven", "6", "529", "Caterina.Deckow75@gmail.com", "466185633", "01-599", "Gaston Island", "Montana" },
                    { 29, "North Genovevafort", "6X", "6258", "Amya_Stracke80@hotmail.com", "454542676", "20-353", "Huels Bypass", "Montana" },
                    { 30, "Wolfffort", "16", "2768", "Brian.Huel@gmail.com", "262647809", "75-548", "Hammes Crossroad", "Georgia" },
                    { 31, "Port Jamir", "0", "0437", "Elna.Stanton@hotmail.com", "785657489", "90-930", "Stracke Mews", "Indiana" },
                    { 32, "Lehnerburgh", "7W", "6473", "Marta50@hotmail.com", "734817748", "61-059", "Clement Expressway", "South Dakota" },
                    { 33, "Schambergershire", "8H", "51800", "Marcos_Bednar23@yahoo.com", "337307653", "46-023", "Brekke Via", "Nebraska" },
                    { 34, "Gutmannbury", "871S", "18941", "Sage47@hotmail.com", "169230667", "76-275", "Virginia Mission", "Louisiana" },
                    { 35, "Mitchellhaven", "5J", "108", "Caden_Rath@gmail.com", "268925757", "42-497", "Pacocha Divide", "Tennessee" },
                    { 36, "Port Elfriedabury", "0J", "90488", "Jammie_Tremblay@gmail.com", "370393625", "85-222", "Rau Groves", "West Virginia" },
                    { 37, "Port Lea", "81L", "5908", "Kamron_Krajcik@gmail.com", "460969879", "68-720", "Breanna Mission", "Indiana" },
                    { 38, "South Maureenside", "74D", "93766", "Juliana53@hotmail.com", "723505106", "05-539", "Tiffany Forks", "South Carolina" },
                    { 39, "Port Dominiquemouth", "3P", "85559", "Columbus_Wolff5@hotmail.com", "610578718", "90-401", "Blick Underpass", "Pennsylvania" },
                    { 40, "Murphyport", "1", "500", "Shemar93@gmail.com", "490741240", "32-303", "Krajcik Mission", "North Carolina" },
                    { 41, "Peytonton", "84N", "9448", "Jules_OKeefe5@yahoo.com", "481523246", "49-561", "Schneider Fields", "Nevada" },
                    { 42, "Verdahaven", "622R", "138", "Norma11@gmail.com", "744927491", "25-314", "Adams Garden", "New Jersey" },
                    { 43, "Lake Tracy", "54", "45593", "Bert_Sanford31@yahoo.com", "278828085", "81-524", "Weissnat Meadow", "Kentucky" },
                    { 44, "Morissetteland", "4X", "28126", "Devante69@yahoo.com", "589325692", "27-510", "Iliana Terrace", "Florida" },
                    { 45, "Rogahnburgh", "48", "91610", "Oren_Lind@hotmail.com", "759598069", "77-371", "Julian Harbors", "Wisconsin" },
                    { 100, "Stehrberg", "2", "261", "Jerod.Carter@hotmail.com", "172264637", "15-989", "Kailee Circles", "North Carolina" },
                    { 47, "East Hilbert", "162", "1365", "Freddie_Prohaska@yahoo.com", "636977602", "17-226", "Colt Mill", "Maryland" },
                    { 48, "Marcellaside", "0C", "9274", "Landen.Langworth61@gmail.com", "146012079", "31-178", "Jayne Forest", "Hawaii" },
                    { 27, "Aufderharstad", "59", "8391", "Jessy.Homenick41@yahoo.com", "560046478", "36-031", "Emmie Ford", "Rhode Island" },
                    { 26, "Lilianstad", "57E", "231", "Stella_Botsford@hotmail.com", "917135186", "72-344", "Mable Key", "South Carolina" },
                    { 25, "North Bret", "3", "60892", "Lera_Bashirian@yahoo.com", "471404432", "14-595", "Kolby Isle", "Georgia" },
                    { 24, "Port Christymouth", "387P", "1226", "Chelsie0@yahoo.com", "970928858", "83-340", "Nikolaus Common", "Colorado" },
                    { 2, "New Garrisonbury", "67", "2625", "Kaia25@hotmail.com", "238569164", "48-927", "Margarett Streets", "Tennessee" },
                    { 3, "New Keaton", "2R", "52912", "Frida_Armstrong@hotmail.com", "288544533", "95-582", "Ernser Courts", "Washington" },
                    { 4, "Glovermouth", "0", "74682", "Brando0@yahoo.com", "496711471", "89-438", "Goyette Plains", "Wisconsin" },
                    { 5, "West Queenville", "644H", "4926", "Scot29@yahoo.com", "115369061", "52-678", "Corene Tunnel", "Rhode Island" },
                    { 6, "Port Daren", "67F", "830", "Krystel4@hotmail.com", "505670197", "97-639", "Alyce Cape", "California" },
                    { 7, "West Patiencefurt", "1", "2375", "Alia_Connelly@gmail.com", "739039160", "13-042", "Gaetano Trace", "Colorado" },
                    { 8, "Pfannerstillshire", "3U", "605", "Gail_OReilly@yahoo.com", "884450304", "06-130", "Lessie Freeway", "Oregon" },
                    { 9, "Yasmineshire", "593", "7714", "Quinten_Considine@hotmail.com", "476800644", "66-333", "Karlee Hill", "Montana" },
                    { 10, "Port Emie", "199Q", "83300", "Esteban.Cruickshank29@gmail.com", "581868454", "95-935", "Bailey Mount", "North Dakota" },
                    { 11, "South Cyril", "22O", "6157", "Gregg44@yahoo.com", "201184793", "39-757", "Clare Way", "Massachusetts" },
                    { 49, "North Adolphus", "22O", "12885", "Nicole62@yahoo.com", "935116146", "56-208", "Russel Walk", "Oklahoma" },
                    { 12, "New Shyannborough", "293W", "752", "Abelardo45@gmail.com", "937258777", "42-521", "Johnston Turnpike", "Florida" },
                    { 14, "North Adolphusmouth", "9U", "4252", "Karlee70@hotmail.com", "597689949", "64-586", "Myrtle Dale", "Louisiana" },
                    { 15, "Lake Efren", "4M", "89534", "Emmet26@gmail.com", "749543843", "40-919", "Rosina Orchard", "South Dakota" },
                    { 16, "West Josephinechester", "863", "96137", "Geovany.Walsh19@gmail.com", "284202846", "32-321", "Waelchi Field", "New York" },
                    { 17, "Idellaland", "8", "51291", "Myron26@hotmail.com", "643601002", "66-225", "Kareem Roads", "Kansas" },
                    { 18, "Masonview", "36C", "716", "Kirk.Parker40@hotmail.com", "608897949", "19-025", "Paucek Inlet", "Utah" },
                    { 19, "Eldaside", "520", "75109", "Henri95@gmail.com", "164513456", "81-509", "Jovany Radial", "Tennessee" },
                    { 20, "Schadenfort", "1", "13838", "Sheila49@hotmail.com", "967728830", "57-645", "Everett Motorway", "Utah" },
                    { 21, "Bradtketown", "26Q", "09498", "Destiney.Bednar18@gmail.com", "726508555", "13-908", "Goodwin Cove", "Wisconsin" },
                    { 22, "North Heberhaven", "3", "911", "Dereck.Grimes@hotmail.com", "850821978", "08-304", "Rosalee Row", "Maryland" },
                    { 23, "West Berenicechester", "973", "134", "Bette51@yahoo.com", "712804335", "73-261", "Bailey Underpass", "Maine" },
                    { 13, "Kassulketown", "2", "616", "Terence_Romaguera@gmail.com", "756744512", "54-694", "Charlotte Prairie", "Illinois" },
                    { 50, "East Timmy", "0", "90350", "Eda.Feest72@hotmail.com", "219130968", "83-720", "Jacobi Mills", "Connecticut" },
                    { 46, "Port Kurtchester", "691J", "966", "Melody3@gmail.com", "812371666", "22-976", "Jerod Junction", "Alabama" },
                    { 52, "South Rosendoville", "5O", "88056", "Beryl.Mueller@hotmail.com", "493358213", "16-025", "Xzavier Mews", "New York" },
                    { 78, "Williamsonshire", "898", "3887", "Keagan67@hotmail.com", "254586466", "53-162", "Ruben Street", "Missouri" },
                    { 79, "North Brent", "148", "20756", "Alfreda_Armstrong@gmail.com", "671303219", "15-462", "Noemy Shoal", "Arkansas" },
                    { 51, "Skilesport", "326R", "3520", "Brittany24@yahoo.com", "935746757", "83-481", "Stanton Creek", "South Dakota" },
                    { 81, "Haleyport", "633L", "272", "Donnell.Terry@gmail.com", "116375990", "99-823", "Ahmad Ports", "California" },
                    { 82, "Gislasonmouth", "69", "29260", "Emmie_Wisoky@gmail.com", "998702168", "46-775", "Bobby Underpass", "New Mexico" },
                    { 83, "North Jared", "69", "92017", "Myah_Baumbach@yahoo.com", "251244114", "88-053", "Jeremy Loaf", "Vermont" },
                    { 84, "New Kian", "3", "15375", "Wilford.Lebsack66@yahoo.com", "722829118", "53-621", "Katharina Pine", "Iowa" },
                    { 85, "East Dorthaside", "8", "648", "Clair.Murray@hotmail.com", "762179396", "35-158", "Steuber Courts", "Montana" },
                    { 86, "South Carriebury", "514", "45240", "Earnest_Cruickshank@yahoo.com", "529163636", "32-470", "Feil Light", "South Dakota" },
                    { 87, "North Laurenberg", "54R", "5485", "Jaylin41@hotmail.com", "764504521", "08-093", "Jaden Lodge", "Hawaii" },
                    { 88, "New Shad", "28", "90628", "Oral.Schuppe@gmail.com", "181477652", "42-152", "Abby Junction", "Connecticut" },
                    { 89, "Klockotown", "7", "1444", "Maribel79@hotmail.com", "321860512", "79-282", "Gerhard Way", "Delaware" },
                    { 90, "Port Aldaton", "527P", "388", "Greta.Lesch11@gmail.com", "576569214", "34-416", "Spencer Stravenue", "Washington" },
                    { 91, "Icieport", "3", "92451", "Agustin.Kohler@yahoo.com", "630869486", "79-671", "Kailyn Keys", "Arizona" },
                    { 92, "Goyetteville", "79G", "08234", "Marta_Collins@hotmail.com", "747786529", "26-930", "Pfannerstill Haven", "Minnesota" },
                    { 93, "Towneborough", "3", "00888", "Mavis.Hilpert39@yahoo.com", "215628241", "07-724", "Garett Pike", "Vermont" },
                    { 94, "Ricoton", "6", "3746", "Marco_Jaskolski@hotmail.com", "365598563", "78-722", "Viola Road", "Wisconsin" },
                    { 95, "West Sibyl", "99N", "78265", "Graham_Lang27@hotmail.com", "437263101", "34-856", "Paris Mission", "Connecticut" },
                    { 96, "Bayerchester", "870", "88966", "Lorenza37@yahoo.com", "223330540", "84-768", "Broderick Shore", "Florida" },
                    { 97, "Framibury", "467", "8037", "Liana.Walter@hotmail.com", "308105086", "17-910", "Lakin Port", "Louisiana" },
                    { 98, "Wisokychester", "57", "12370", "Dalton7@gmail.com", "211884941", "78-490", "Parker Lakes", "North Dakota" },
                    { 77, "Ronnyland", "9E", "75672", "Hipolito.Osinski@yahoo.com", "444736667", "59-018", "Kevon Roads", "Wyoming" },
                    { 76, "Dibbertberg", "45", "567", "Karina.Halvorson1@gmail.com", "659531584", "51-873", "Amos Dale", "Iowa" },
                    { 80, "New Mabelleport", "299", "17892", "Ressie29@yahoo.com", "230165413", "28-824", "Okuneva Orchard", "Idaho" },
                    { 74, "West Melyssafort", "609D", "87663", "Sarina.Schmeler@yahoo.com", "183115557", "14-097", "Mante Mall", "Nebraska" },
                    { 53, "Lake Verla", "67M", "91727", "Vicente.Pfannerstill21@gmail.com", "721774833", "85-412", "Jaren Brooks", "New Mexico" },
                    { 54, "Lake Pasquale", "20", "1510", "Assunta56@yahoo.com", "647696545", "16-195", "Sanford Corner", "South Carolina" },
                    { 55, "North River", "58", "54941", "Vivienne4@yahoo.com", "334117160", "27-193", "Cary Spur", "Maine" },
                    { 56, "Herzogfort", "898H", "03475", "Gregory_Rau63@gmail.com", "519936256", "20-547", "Audra Expressway", "South Dakota" },
                    { 57, "East Katlynnmouth", "0", "734", "Micah.Runolfsdottir@gmail.com", "555821719", "02-749", "Jast Skyway", "South Carolina" },
                    { 75, "New Janelleton", "877", "200", "Myles48@yahoo.com", "322789896", "65-944", "Zane Knolls", "Minnesota" },
                    { 59, "North Donnellchester", "8D", "15379", "Shana_Kuhlman4@gmail.com", "315053399", "05-206", "Dooley Stream", "Mississippi" },
                    { 60, "East Johnathonland", "33", "22621", "Kallie83@hotmail.com", "694453909", "86-922", "Delmer Parkways", "North Dakota" },
                    { 61, "Port Ernie", "32N", "455", "Electa_Keeling@hotmail.com", "635722159", "46-957", "Jovan Keys", "Kentucky" },
                    { 62, "Whitneyburgh", "27Z", "7379", "Candelario.Schinner@yahoo.com", "473103008", "74-179", "Koss Highway", "North Dakota" },
                    { 58, "North Carterstad", "29", "2134", "Xzavier.Bartoletti@hotmail.com", "391507402", "94-334", "Reina Mountain", "Massachusetts" },
                    { 64, "East Marvin", "536", "827", "Verdie29@hotmail.com", "565858004", "11-417", "Quigley Fields", "Texas" },
                    { 63, "East Jeanetteside", "958", "317", "Enrique_Orn45@yahoo.com", "823704775", "36-669", "Gaylord Port", "Minnesota" },
                    { 72, "West Zeldastad", "10S", "71851", "Marjorie_Wiza@hotmail.com", "749891651", "57-853", "Cheyenne Union", "Maryland" },
                    { 71, "Ronaldoville", "27", "007", "Dawn_Rowe@yahoo.com", "965755514", "43-894", "Tyrese Forest", "Maine" },
                    { 70, "South Quinnside", "957Z", "3264", "Walton_Kovacek@gmail.com", "884861923", "34-883", "Nitzsche Stravenue", "New York" },
                    { 73, "Rooseveltfurt", "159", "4997", "Aniyah.Gislason80@gmail.com", "201420304", "92-817", "Abshire Ville", "Indiana" },
                    { 68, "East Aurore", "726B", "107", "Curtis_DuBuque@hotmail.com", "448473617", "46-988", "Frami Orchard", "North Carolina" },
                    { 67, "Gutmanntown", "34R", "97678", "Jean_Tremblay@yahoo.com", "580266713", "20-166", "Stark Skyway", "Idaho" },
                    { 66, "Herzogland", "60U", "775", "Chauncey_Cruickshank37@hotmail.com", "969205492", "01-020", "Hand Parks", "Alaska" },
                    { 65, "West Clare", "06H", "0185", "Priscilla.Torp@hotmail.com", "730726332", "66-347", "Muller Union", "Delaware" },
                    { 69, "North Stevefort", "4X", "1387", "Aliya_Gusikowski@hotmail.com", "941263712", "19-431", "Meagan Isle", "Mississippi" }
                });

            migrationBuilder.InsertData(
                table: "UnitTypes",
                columns: new[] { "UnitTypeId", "Name" },
                values: new object[,]
                {
                    { 9, "Maine" },
                    { 1, "Concrete" },
                    { 2, "Sleek Concrete Soap" },
                    { 3, "unleash" },
                    { 4, "functionalities" },
                    { 5, "Trinidad and Tobago Dollar" },
                    { 6, "Soft" },
                    { 7, "Yen" },
                    { 8, "Steel" },
                    { 10, "Practical Metal Soap" }
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "ClientId", "ContactId", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, 1, "Tracey", "Brown" },
                    { 73, 73, "Laurie", "Schumm" },
                    { 72, 72, "Stella", "Mills" },
                    { 71, 71, "Dale", "Grady" },
                    { 70, 70, "Edmund", "Goldner" },
                    { 69, 69, "Ben", "Hilll" },
                    { 68, 68, "Perry", "Gerlach" },
                    { 67, 67, "Edmond", "Kuvalis" },
                    { 66, 66, "Jack", "Hoeger" },
                    { 65, 65, "Francisco", "Kertzmann" },
                    { 64, 64, "Elvira", "VonRueden" },
                    { 63, 63, "Amber", "Gottlieb" },
                    { 62, 62, "Marc", "Koelpin" },
                    { 61, 61, "Preston", "Barrows" },
                    { 60, 60, "Margarita", "Kautzer" },
                    { 59, 59, "Alfred", "Harvey" },
                    { 58, 58, "Lola", "Hand" },
                    { 57, 57, "Darrell", "Medhurst" },
                    { 56, 56, "Glenda", "Bauch" },
                    { 55, 55, "Stanley", "Runte" },
                    { 54, 54, "Francisco", "Howell" },
                    { 53, 53, "Maggie", "Rau" },
                    { 74, 74, "Marion", "Kertzmann" },
                    { 75, 75, "Marty", "Hansen" },
                    { 76, 76, "Teresa", "Howell" },
                    { 77, 77, "Linda", "Cronin" },
                    { 99, 99, "Carrie", "O'Kon" },
                    { 98, 98, "Felix", "Rau" },
                    { 97, 97, "Terrell", "DuBuque" },
                    { 96, 96, "Felicia", "Wyman" },
                    { 95, 95, "Tyler", "Donnelly" },
                    { 94, 94, "Jerald", "Kassulke" },
                    { 93, 93, "Wilfred", "Ruecker" },
                    { 92, 92, "Iris", "Bashirian" },
                    { 91, 91, "Adrienne", "Flatley" },
                    { 90, 90, "Cameron", "Rodriguez" },
                    { 52, 52, "Kendra", "Mann" },
                    { 89, 89, "Jodi", "Bauch" },
                    { 87, 87, "Charlene", "Kunze" },
                    { 86, 86, "Nichole", "Larson" },
                    { 85, 85, "Laverne", "Zieme" },
                    { 84, 84, "Dianna", "McDermott" },
                    { 83, 83, "Dianna", "Witting" },
                    { 82, 82, "Jenna", "Kunde" },
                    { 81, 81, "Anita", "Langworth" },
                    { 80, 80, "Vicky", "Ward" },
                    { 79, 79, "Caroline", "Gerlach" },
                    { 78, 78, "Guadalupe", "Goyette" },
                    { 88, 88, "Dolores", "Schiller" },
                    { 51, 51, "Maggie", "Pfeffer" },
                    { 100, 100, "Earl", "Ratke" },
                    { 49, 49, "Gordon", "Cole" },
                    { 22, 22, "Jan", "Powlowski" },
                    { 21, 21, "Wilson", "Harvey" },
                    { 20, 20, "Wilbert", "Vandervort" },
                    { 19, 19, "Anna", "Schowalter" },
                    { 18, 18, "Donna", "Klein" },
                    { 17, 17, "Al", "Rolfson" },
                    { 16, 16, "Terry", "Kerluke" },
                    { 15, 15, "Penny", "Koss" },
                    { 13, 13, "Caroline", "Wunsch" },
                    { 12, 12, "Ronald", "Klocko" },
                    { 11, 11, "William", "MacGyver" },
                    { 10, 10, "Sue", "Rau" },
                    { 9, 9, "Roderick", "Huels" },
                    { 8, 8, "Calvin", "Kuhn" },
                    { 7, 7, "Margaret", "Haag" },
                    { 6, 6, "Roosevelt", "Batz" },
                    { 5, 5, "Ross", "Prosacco" },
                    { 4, 4, "Joshua", "Miller" },
                    { 3, 3, "Felix", "Oberbrunner" },
                    { 2, 2, "Dianne", "Purdy" },
                    { 50, 50, "Dexter", "Prosacco" },
                    { 23, 23, "Candice", "Grimes" },
                    { 24, 24, "Natalie", "Sporer" },
                    { 14, 14, "Darlene", "Kreiger" },
                    { 26, 26, "Willie", "Mante" },
                    { 25, 25, "Andres", "Waters" },
                    { 47, 47, "Tom", "Bartell" },
                    { 46, 46, "Jordan", "Maggio" },
                    { 45, 45, "Robin", "Aufderhar" },
                    { 44, 44, "Kayla", "Raynor" },
                    { 43, 43, "Carolyn", "Kub" },
                    { 42, 42, "Francisco", "Pollich" },
                    { 40, 40, "Ismael", "Weber" },
                    { 39, 39, "Daisy", "Langworth" },
                    { 38, 38, "Kent", "Hilpert" },
                    { 37, 37, "Judith", "Glover" },
                    { 41, 41, "Candice", "Lowe" },
                    { 48, 48, "Santos", "Franecki" },
                    { 36, 36, "Vicky", "Stark" },
                    { 28, 28, "Caroline", "Farrell" },
                    { 29, 29, "Loretta", "Langosh" },
                    { 30, 30, "Alfred", "Hermann" },
                    { 31, 31, "Amber", "Sauer" },
                    { 27, 27, "Paulette", "Ziemann" },
                    { 33, 33, "Jeff", "Thompson" },
                    { 34, 34, "Raymond", "Zboncak" },
                    { 35, 35, "Bradley", "Moore" },
                    { 32, 32, "Marcia", "Pfannerstill" }
                });

            migrationBuilder.InsertData(
                table: "Vendors",
                columns: new[] { "VendorId", "ContactId", "Name" },
                values: new object[,]
                {
                    { 64, 164, "Administrator" },
                    { 72, 172, "Designer" },
                    { 71, 171, "Supervisor" },
                    { 70, 170, "Checking Account" },
                    { 69, 169, "orchid" },
                    { 68, 168, "Rubber" },
                    { 67, 167, "Licensed Cotton Pizza" },
                    { 66, 166, "Buckinghamshire" },
                    { 65, 165, "plug-and-play" },
                    { 63, 163, "withdrawal" },
                    { 52, 152, "Sleek Cotton Towels" },
                    { 61, 161, "Forges" },
                    { 60, 160, "Comoros" },
                    { 59, 159, "Cotton" },
                    { 58, 158, "GB" },
                    { 57, 157, "Croatian Kuna" },
                    { 56, 156, "responsive" },
                    { 55, 155, "generate" },
                    { 54, 154, "Unbranded" },
                    { 53, 153, "Brand" },
                    { 73, 173, "Analyst" },
                    { 62, 162, "Small Fresh Shirt" },
                    { 74, 174, "Cayman Islands Dollar" },
                    { 98, 198, "infrastructures" },
                    { 76, 176, "azure" },
                    { 51, 151, "Generic" },
                    { 97, 197, "Outdoors & Shoes" },
                    { 96, 196, "payment" },
                    { 95, 195, "Home Loan Account" },
                    { 94, 194, "Rest" },
                    { 93, 193, "Flat" },
                    { 92, 192, "Liaison" },
                    { 91, 191, "global" },
                    { 90, 190, "Neck" },
                    { 89, 189, "Principal" },
                    { 75, 175, "Interactions" },
                    { 88, 188, "Road" },
                    { 86, 186, "Checking Account" },
                    { 85, 185, "Assistant" },
                    { 84, 184, "customized" },
                    { 83, 183, "Ergonomic Soft Ball" },
                    { 82, 182, "compelling" },
                    { 81, 181, "Berkshire" },
                    { 80, 180, "Metrics" },
                    { 79, 179, "benchmark" },
                    { 78, 178, "Pataca" },
                    { 77, 177, "24/365" },
                    { 87, 187, "Grocery, Music & Health" },
                    { 50, 150, "RSS" },
                    { 26, 126, "24/7" },
                    { 48, 148, "SCSI" },
                    { 20, 120, "Dynamic" },
                    { 19, 119, "Wall" },
                    { 18, 118, "Gorgeous Metal Keyboard" },
                    { 17, 117, "Pitcairn Islands" },
                    { 16, 116, "transmit" },
                    { 15, 115, "Books" },
                    { 14, 114, "New Jersey" },
                    { 13, 113, "incentivize" },
                    { 12, 112, "bypassing" },
                    { 11, 111, "Outdoors" },
                    { 10, 110, "Fresh" },
                    { 9, 109, "Bedfordshire" },
                    { 8, 108, "Operative" },
                    { 7, 107, "Analyst" },
                    { 6, 106, "Practical" },
                    { 5, 105, "payment" },
                    { 4, 104, "Metal" },
                    { 3, 103, "neural" },
                    { 2, 102, "calculating" },
                    { 1, 101, "Directives" },
                    { 99, 199, "Unbranded Cotton Ball" },
                    { 21, 121, "generate" },
                    { 22, 122, "Garden & Garden" },
                    { 23, 123, "payment" },
                    { 24, 124, "Investment Account" },
                    { 47, 147, "quantifying" },
                    { 46, 146, "Future" },
                    { 45, 145, "Wyoming" },
                    { 44, 144, "withdrawal" },
                    { 43, 143, "paradigms" },
                    { 42, 142, "scalable" },
                    { 41, 141, "harness" },
                    { 40, 140, "incubate" },
                    { 39, 139, "white" },
                    { 38, 138, "turn-key" },
                    { 49, 149, "invoice" },
                    { 37, 137, "Awesome" },
                    { 35, 135, "Automated" },
                    { 34, 134, "Cambridgeshire" },
                    { 33, 133, "Bedfordshire" },
                    { 32, 132, "Operations" },
                    { 31, 131, "deposit" },
                    { 30, 130, "evolve" },
                    { 29, 129, "Generic" },
                    { 28, 128, "New Jersey" },
                    { 27, 127, "Investment Account" },
                    { 25, 125, "Oregon" },
                    { 36, 136, "orchestration" },
                    { 100, 200, "Horizontal" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Amount", "Name", "Unit", "UnitTypeId", "Value", "VendorId" },
                values: new object[,]
                {
                    { 16, 41626, "Table", 95157, 3, 84815, 1 },
                    { 829, 90406, "Cheese", 30116, 8, 19149, 65 },
                    { 985, 26509, "Keyboard", 912, 7, 81092, 65 },
                    { 8, 95852, "Pizza", 72327, 10, 28712, 66 },
                    { 110, 89553, "Tuna", 83873, 2, 23779, 66 },
                    { 160, 96178, "Chips", 22073, 2, 28646, 66 },
                    { 213, 73635, "Cheese", 59882, 4, 93916, 66 },
                    { 348, 5425, "Car", 42054, 8, 17934, 66 },
                    { 587, 96839, "Pizza", 65641, 6, 63308, 66 },
                    { 704, 25271, "Pizza", 60119, 8, 20150, 66 },
                    { 74, 43239, "Sausages", 98573, 8, 40227, 67 },
                    { 244, 79732, "Towels", 18296, 7, 60444, 67 },
                    { 363, 73464, "Towels", 25831, 2, 65867, 67 },
                    { 533, 32267, "Shoes", 97739, 6, 97332, 67 },
                    { 566, 39240, "Cheese", 74851, 2, 48915, 67 },
                    { 603, 95287, "Table", 44201, 4, 98531, 67 },
                    { 682, 89022, "Bike", 77367, 1, 53916, 67 },
                    { 710, 97726, "Towels", 31423, 3, 69726, 67 },
                    { 737, 67698, "Salad", 56894, 7, 73003, 67 },
                    { 740, 92073, "Hat", 70142, 6, 39886, 67 },
                    { 810, 69537, "Tuna", 33317, 10, 51090, 67 },
                    { 847, 6655, "Computer", 83406, 10, 70020, 67 },
                    { 852, 96893, "Computer", 97871, 8, 97474, 67 },
                    { 329, 94783, "Shoes", 72356, 8, 51763, 68 },
                    { 332, 28786, "Salad", 91241, 6, 83181, 68 },
                    { 457, 52610, "Salad", 11083, 1, 19312, 68 },
                    { 649, 53718, "Shoes", 44936, 1, 5019, 68 },
                    { 671, 79551, "Towels", 21642, 5, 88824, 68 },
                    { 818, 72373, "Computer", 57259, 2, 54150, 65 },
                    { 997, 58486, "Computer", 89975, 5, 67078, 68 },
                    { 812, 66352, "Gloves", 86557, 7, 50405, 65 },
                    { 347, 31075, "Chair", 54521, 2, 85348, 65 },
                    { 532, 47966, "Keyboard", 5862, 10, 85901, 62 },
                    { 592, 50195, "Ball", 98554, 10, 82099, 62 },
                    { 635, 18116, "Towels", 49288, 10, 50414, 62 },
                    { 795, 46409, "Chips", 683, 1, 63259, 62 },
                    { 816, 61474, "Cheese", 34772, 9, 70303, 62 },
                    { 893, 68219, "Pants", 31014, 9, 49420, 62 },
                    { 971, 44888, "Bike", 37069, 4, 87339, 62 },
                    { 998, 78520, "Hat", 26819, 4, 34963, 62 },
                    { 52, 60133, "Pants", 2105, 8, 59320, 63 },
                    { 65, 27259, "Pants", 29905, 8, 97352, 63 },
                    { 341, 67292, "Salad", 32436, 7, 38940, 63 },
                    { 677, 11931, "Pants", 22390, 10, 43999, 63 },
                    { 680, 36187, "Chips", 28750, 7, 85342, 63 },
                    { 823, 48699, "Pizza", 86644, 6, 98037, 63 },
                    { 845, 62940, "Hat", 43485, 10, 13237, 63 },
                    { 906, 22489, "Gloves", 3509, 3, 6964, 63 },
                    { 173, 48889, "Shoes", 38648, 3, 67976, 64 },
                    { 460, 96389, "Mouse", 79139, 9, 73160, 64 },
                    { 561, 74361, "Table", 50087, 2, 71206, 64 },
                    { 623, 94297, "Shirt", 74935, 1, 6916, 64 },
                    { 730, 20488, "Pants", 26902, 5, 63783, 64 },
                    { 761, 26492, "Chair", 36127, 10, 2977, 64 },
                    { 819, 76332, "Chips", 98303, 9, 86959, 64 },
                    { 922, 43554, "Pants", 73263, 2, 56822, 64 },
                    { 18, 34983, "Ball", 18825, 5, 45303, 65 },
                    { 23, 93779, "Towels", 50415, 4, 32757, 65 },
                    { 180, 72634, "Keyboard", 91192, 8, 36501, 65 },
                    { 573, 22966, "Towels", 91703, 4, 77215, 65 },
                    { 143, 9722, "Bacon", 12591, 3, 10273, 69 },
                    { 152, 95726, "Cheese", 41306, 7, 79925, 69 },
                    { 165, 99271, "Computer", 36052, 2, 19622, 69 },
                    { 291, 91660, "Cheese", 20694, 1, 48726, 72 },
                    { 320, 6412, "Car", 17071, 4, 41227, 72 },
                    { 362, 32162, "Chips", 70357, 1, 77217, 72 },
                    { 442, 65675, "Tuna", 41129, 3, 80199, 72 },
                    { 448, 53146, "Tuna", 71100, 4, 75663, 72 },
                    { 539, 26205, "Bacon", 24198, 7, 7071, 72 },
                    { 703, 51381, "Gloves", 33592, 3, 13919, 72 },
                    { 769, 72512, "Shirt", 48604, 8, 88022, 72 },
                    { 787, 71732, "Chicken", 38351, 7, 2062, 72 },
                    { 878, 15777, "Chicken", 53433, 1, 72260, 72 },
                    { 58, 37479, "Ball", 90508, 8, 79555, 73 },
                    { 127, 7847, "Shirt", 20387, 9, 26064, 73 },
                    { 255, 89038, "Shirt", 73294, 4, 12225, 73 },
                    { 339, 72349, "Fish", 60834, 5, 91022, 73 },
                    { 364, 32452, "Chicken", 37492, 4, 35586, 73 },
                    { 381, 43291, "Shirt", 6942, 10, 40321, 73 },
                    { 614, 13829, "Gloves", 77108, 2, 70298, 73 },
                    { 646, 51233, "Gloves", 44417, 5, 73788, 73 },
                    { 694, 61585, "Mouse", 77184, 2, 89357, 73 },
                    { 762, 75044, "Chair", 13978, 1, 83524, 73 },
                    { 399, 95076, "Pants", 1857, 7, 57381, 74 },
                    { 422, 35858, "Bike", 63253, 10, 90556, 74 },
                    { 571, 33016, "Gloves", 65564, 7, 54850, 74 },
                    { 945, 28845, "Shirt", 32622, 10, 58401, 74 },
                    { 206, 60373, "Chips", 37691, 8, 26779, 75 },
                    { 490, 43999, "Salad", 87926, 3, 78751, 75 },
                    { 549, 25454, "Tuna", 84016, 6, 74071, 75 },
                    { 5, 69181, "Hat", 26616, 10, 29034, 72 },
                    { 855, 62322, "Chips", 72057, 1, 38760, 71 },
                    { 814, 69532, "Pizza", 98994, 2, 30292, 71 },
                    { 748, 97225, "Table", 61123, 5, 33181, 71 },
                    { 212, 94052, "Fish", 28327, 5, 79376, 69 },
                    { 264, 97288, "Cheese", 607, 7, 72843, 69 },
                    { 350, 72713, "Pizza", 63124, 1, 24993, 69 },
                    { 406, 37393, "Soap", 74321, 5, 46201, 69 },
                    { 527, 16518, "Computer", 27665, 6, 40427, 69 },
                    { 714, 56542, "Fish", 93792, 9, 1447, 69 },
                    { 731, 70351, "Pizza", 38546, 8, 53831, 69 },
                    { 775, 48569, "Pizza", 53560, 2, 54152, 69 },
                    { 796, 8278, "Bike", 33569, 3, 82164, 69 },
                    { 841, 96275, "Cheese", 18859, 4, 65993, 69 },
                    { 881, 53676, "Chips", 53980, 6, 4878, 69 },
                    { 150, 7727, "Chicken", 94025, 1, 42594, 70 },
                    { 171, 68793, "Sausages", 49935, 1, 10879, 70 },
                    { 360, 11486, "Hat", 32283, 10, 33015, 62 },
                    { 223, 16976, "Shirt", 43101, 9, 22544, 70 },
                    { 474, 19253, "Ball", 28976, 5, 76082, 70 },
                    { 585, 4173, "Ball", 27107, 4, 34688, 70 },
                    { 736, 64643, "Gloves", 39068, 7, 61484, 70 },
                    { 807, 38445, "Shirt", 28315, 4, 28206, 70 },
                    { 895, 26361, "Pants", 62227, 7, 8040, 70 },
                    { 76, 66338, "Mouse", 58543, 3, 36912, 71 },
                    { 139, 70024, "Tuna", 18783, 7, 59839, 71 },
                    { 183, 78782, "Pants", 5094, 6, 24910, 71 },
                    { 203, 22861, "Shirt", 68703, 6, 2271, 71 },
                    { 253, 27945, "Shoes", 34311, 4, 53160, 71 },
                    { 505, 79824, "Salad", 48632, 7, 29467, 71 },
                    { 609, 57435, "Table", 53758, 4, 92767, 71 },
                    { 622, 14015, "Soap", 305, 4, 49516, 71 },
                    { 454, 68897, "Shirt", 64251, 2, 24772, 70 },
                    { 648, 61178, "Tuna", 58166, 10, 23098, 75 },
                    { 301, 79037, "Towels", 33603, 8, 55281, 62 },
                    { 41, 31002, "Pants", 90820, 5, 56212, 62 },
                    { 392, 4920, "Bacon", 19425, 3, 6395, 54 },
                    { 693, 51733, "Computer", 73372, 5, 5084, 54 },
                    { 900, 54044, "Computer", 50759, 2, 70984, 54 },
                    { 965, 62911, "Cheese", 54559, 7, 64215, 54 },
                    { 995, 95424, "Bacon", 74026, 7, 25839, 54 },
                    { 158, 50023, "Keyboard", 53346, 5, 62389, 55 },
                    { 270, 30020, "Chair", 27199, 7, 48865, 55 },
                    { 282, 33646, "Soap", 67585, 5, 10887, 55 },
                    { 361, 36135, "Shirt", 53243, 3, 90131, 55 },
                    { 515, 8964, "Sausages", 81716, 10, 97077, 55 },
                    { 575, 64955, "Keyboard", 94567, 1, 64221, 55 },
                    { 616, 47969, "Salad", 74365, 2, 9535, 55 },
                    { 634, 11310, "Towels", 61784, 5, 67399, 55 },
                    { 666, 77469, "Keyboard", 24931, 8, 96294, 55 },
                    { 832, 59781, "Chicken", 18489, 5, 62620, 55 },
                    { 849, 84124, "Pizza", 64123, 5, 98111, 55 },
                    { 883, 41503, "Fish", 71682, 5, 4407, 55 },
                    { 87, 32487, "Keyboard", 1852, 10, 76518, 56 },
                    { 148, 38168, "Gloves", 30168, 9, 11247, 56 },
                    { 193, 85080, "Keyboard", 25843, 8, 28193, 56 },
                    { 200, 3940, "Shirt", 6944, 3, 89573, 56 },
                    { 271, 46541, "Ball", 96680, 1, 52354, 56 },
                    { 279, 49707, "Towels", 96088, 1, 28277, 56 },
                    { 286, 46813, "Gloves", 52278, 5, 70960, 56 },
                    { 342, 56118, "Sausages", 16482, 5, 80377, 56 },
                    { 667, 924, "Mouse", 34628, 5, 90066, 56 },
                    { 668, 86296, "Bike", 79901, 1, 66974, 56 },
                    { 296, 96808, "Towels", 87573, 2, 83488, 54 },
                    { 99, 66118, "Bacon", 27490, 10, 61679, 57 },
                    { 215, 43769, "Bacon", 45489, 2, 62115, 54 },
                    { 164, 43643, "Sausages", 30100, 10, 78521, 54 },
                    { 861, 26880, "Car", 93440, 6, 47837, 49 },
                    { 55, 12603, "Bike", 43611, 6, 81493, 50 },
                    { 61, 52843, "Soap", 6083, 1, 22327, 50 },
                    { 78, 83303, "Cheese", 54201, 10, 65359, 50 },
                    { 166, 2648, "Bike", 75515, 5, 11913, 50 },
                    { 261, 64271, "Shoes", 98147, 3, 91937, 50 },
                    { 488, 77004, "Salad", 734, 2, 43935, 50 },
                    { 497, 9258, "Sausages", 23455, 2, 59318, 50 },
                    { 147, 95986, "Table", 85665, 7, 59287, 51 },
                    { 428, 27560, "Table", 78165, 1, 62857, 51 },
                    { 607, 15770, "Table", 69031, 1, 96763, 51 },
                    { 817, 88680, "Keyboard", 70631, 5, 16663, 51 },
                    { 949, 45282, "Mouse", 29501, 7, 60512, 51 },
                    { 988, 51210, "Gloves", 32861, 10, 38698, 51 },
                    { 134, 67940, "Bacon", 99120, 9, 25531, 52 },
                    { 371, 87405, "Bacon", 42947, 5, 63693, 52 },
                    { 510, 16514, "Sausages", 36803, 10, 70501, 52 },
                    { 606, 51598, "Chips", 93158, 9, 42140, 52 },
                    { 708, 25901, "Chicken", 92564, 7, 64973, 52 },
                    { 868, 67556, "Table", 34222, 9, 51151, 52 },
                    { 222, 39295, "Pizza", 24581, 1, 63715, 53 },
                    { 433, 23328, "Keyboard", 65711, 8, 36308, 53 },
                    { 554, 76578, "Fish", 28026, 4, 69403, 53 },
                    { 579, 83524, "Mouse", 25809, 6, 14552, 53 },
                    { 619, 84074, "Chair", 72321, 1, 1644, 53 },
                    { 706, 9122, "Hat", 51404, 1, 30335, 53 },
                    { 786, 12739, "Gloves", 3761, 4, 48414, 53 },
                    { 170, 93990, "Pants", 14181, 1, 2151, 54 },
                    { 172, 29939, "Soap", 79824, 10, 20102, 57 },
                    { 374, 84577, "Fish", 69831, 2, 99226, 57 },
                    { 420, 67241, "Towels", 96673, 5, 27026, 57 },
                    { 159, 3220, "Tuna", 17383, 1, 79590, 60 },
                    { 220, 78487, "Towels", 28567, 3, 40850, 60 },
                    { 344, 65380, "Mouse", 42525, 8, 62342, 60 },
                    { 484, 30788, "Chair", 50583, 3, 94150, 60 },
                    { 519, 23670, "Pants", 52626, 2, 62619, 60 },
                    { 664, 33828, "Bike", 90510, 5, 99552, 60 },
                    { 750, 92988, "Towels", 90351, 5, 39370, 60 },
                    { 781, 70408, "Bike", 42862, 3, 4213, 60 },
                    { 955, 42065, "Table", 38724, 6, 17365, 60 },
                    { 28, 40679, "Ball", 91655, 8, 5557, 61 },
                    { 177, 29617, "Gloves", 29113, 3, 48572, 61 },
                    { 290, 92012, "Pants", 97566, 7, 36376, 61 },
                    { 355, 83433, "Ball", 52424, 8, 56262, 61 },
                    { 408, 17264, "Chair", 66342, 4, 80974, 61 },
                    { 409, 22441, "Car", 77068, 3, 77368, 61 },
                    { 468, 81541, "Mouse", 11116, 8, 47893, 61 },
                    { 482, 60004, "Ball", 68918, 4, 94141, 61 },
                    { 489, 51773, "Fish", 63044, 4, 44121, 61 },
                    { 567, 6028, "Ball", 83638, 7, 53788, 61 },
                    { 632, 70617, "Bike", 62241, 9, 13238, 61 },
                    { 676, 38801, "Salad", 68883, 5, 90347, 61 },
                    { 729, 60905, "Hat", 30247, 8, 26994, 61 },
                    { 767, 36004, "Shirt", 34655, 10, 29458, 61 },
                    { 902, 50516, "Tuna", 17480, 1, 33424, 61 },
                    { 905, 62186, "Keyboard", 46006, 9, 30288, 61 },
                    { 923, 72959, "Salad", 77968, 7, 39829, 61 },
                    { 30, 59792, "Towels", 43403, 10, 42253, 62 },
                    { 101, 27994, "Keyboard", 33704, 7, 31744, 60 },
                    { 27, 15484, "Chips", 73168, 5, 89464, 60 },
                    { 19, 31270, "Fish", 55786, 10, 6619, 60 },
                    { 3, 30318, "Mouse", 95783, 10, 35818, 60 },
                    { 784, 50281, "Sausages", 82588, 8, 33227, 57 },
                    { 813, 79550, "Cheese", 31256, 6, 80487, 57 },
                    { 858, 97736, "Ball", 24137, 9, 90391, 57 },
                    { 915, 45694, "Pants", 40435, 5, 86777, 57 },
                    { 208, 676, "Pizza", 18874, 9, 47796, 58 },
                    { 241, 28140, "Pizza", 61838, 8, 56868, 58 },
                    { 353, 77712, "Tuna", 50878, 6, 86323, 58 },
                    { 369, 65877, "Mouse", 20453, 5, 77947, 58 },
                    { 447, 35317, "Computer", 91315, 2, 7289, 58 },
                    { 453, 83736, "Car", 79269, 10, 75937, 58 },
                    { 478, 13547, "Shirt", 65107, 3, 97721, 58 },
                    { 685, 41620, "Pants", 42328, 4, 2697, 58 },
                    { 726, 22174, "Chicken", 66945, 7, 3210, 58 },
                    { 125, 50196, "Chips", 87584, 10, 30234, 62 },
                    { 760, 81199, "Pizza", 8115, 7, 72495, 58 },
                    { 867, 75716, "Chair", 35373, 6, 98917, 58 },
                    { 882, 40066, "Chips", 95903, 1, 98247, 58 },
                    { 909, 42963, "Keyboard", 26655, 7, 50999, 58 },
                    { 935, 19532, "Sausages", 70810, 4, 57799, 58 },
                    { 978, 12668, "Keyboard", 14450, 3, 24806, 58 },
                    { 191, 38709, "Chair", 90743, 8, 47958, 59 },
                    { 249, 59110, "Sausages", 66679, 3, 91297, 59 },
                    { 452, 64583, "Table", 62951, 7, 67191, 59 },
                    { 511, 26691, "Pizza", 72415, 4, 52106, 59 },
                    { 537, 24486, "Chips", 3534, 10, 65358, 59 },
                    { 718, 13660, "Table", 71911, 5, 88943, 59 },
                    { 931, 65768, "Salad", 85709, 10, 37090, 59 },
                    { 948, 74014, "Salad", 30485, 10, 31393, 59 },
                    { 789, 66706, "Bacon", 78506, 5, 71141, 58 },
                    { 712, 81291, "Sausages", 5412, 9, 20141, 49 },
                    { 834, 2701, "Sausages", 9829, 10, 17476, 75 },
                    { 951, 10630, "Cheese", 61059, 1, 60164, 75 },
                    { 491, 29111, "Keyboard", 37470, 3, 64832, 92 },
                    { 542, 14573, "Salad", 68508, 4, 16571, 92 },
                    { 773, 67793, "Chair", 96621, 4, 70958, 92 },
                    { 783, 75790, "Pizza", 40490, 5, 97097, 92 },
                    { 953, 7182, "Shirt", 35944, 1, 54602, 92 },
                    { 14, 61418, "Tuna", 38841, 1, 55313, 93 },
                    { 39, 12212, "Mouse", 2310, 7, 76763, 93 },
                    { 49, 83057, "Shirt", 99792, 7, 64744, 93 },
                    { 294, 92461, "Soap", 91047, 5, 70815, 93 },
                    { 299, 55910, "Tuna", 58368, 4, 79036, 93 },
                    { 467, 40327, "Shirt", 69118, 9, 61900, 93 },
                    { 534, 52091, "Tuna", 90017, 1, 97565, 93 },
                    { 751, 58656, "Hat", 87247, 3, 71187, 93 },
                    { 764, 3759, "Car", 28238, 5, 93830, 93 },
                    { 880, 80596, "Chair", 25446, 7, 56831, 93 },
                    { 894, 81968, "Salad", 5306, 9, 41451, 93 },
                    { 959, 28332, "Keyboard", 84529, 7, 74156, 93 },
                    { 979, 56475, "Chips", 95636, 10, 69793, 93 },
                    { 46, 74482, "Tuna", 5510, 4, 9913, 94 },
                    { 84, 50380, "Computer", 44828, 5, 53058, 94 },
                    { 189, 21149, "Fish", 81322, 4, 35330, 94 },
                    { 209, 36444, "Table", 34986, 9, 18077, 94 },
                    { 227, 85563, "Shirt", 24170, 9, 54565, 94 },
                    { 276, 9085, "Chips", 65525, 10, 75779, 94 },
                    { 498, 22424, "Shirt", 74312, 5, 57732, 94 },
                    { 545, 501, "Chair", 6428, 3, 91663, 94 },
                    { 672, 79361, "Salad", 77348, 9, 40846, 94 },
                    { 473, 17766, "Table", 99060, 2, 49359, 92 },
                    { 723, 45794, "Shirt", 69132, 2, 28594, 94 },
                    { 221, 74578, "Bacon", 63781, 3, 30820, 92 },
                    { 36, 11557, "Bacon", 94162, 1, 36119, 92 },
                    { 315, 94125, "Shoes", 8110, 1, 64656, 88 },
                    { 431, 40402, "Sausages", 15858, 1, 70838, 88 },
                    { 584, 17433, "Cheese", 8892, 5, 20807, 88 },
                    { 755, 76795, "Sausages", 90053, 4, 72206, 88 },
                    { 776, 714, "Towels", 8930, 10, 97348, 88 },
                    { 833, 72128, "Chips", 42011, 9, 47071, 88 },
                    { 874, 19812, "Computer", 83527, 3, 59096, 88 },
                    { 29, 75075, "Computer", 76560, 10, 52824, 89 },
                    { 687, 42426, "Towels", 29797, 1, 49368, 89 },
                    { 689, 90313, "Gloves", 91214, 9, 66569, 89 },
                    { 983, 51894, "Towels", 75706, 2, 42588, 89 },
                    { 24, 67016, "Fish", 36636, 4, 16541, 90 },
                    { 92, 38976, "Tuna", 68192, 6, 39533, 90 },
                    { 126, 90071, "Towels", 86499, 10, 85979, 90 },
                    { 137, 69302, "Chair", 9720, 2, 91936, 90 },
                    { 368, 94621, "Shoes", 97895, 5, 15376, 90 },
                    { 599, 21853, "Gloves", 16678, 3, 49206, 90 },
                    { 690, 82500, "Bike", 50914, 10, 20229, 90 },
                    { 788, 29727, "Gloves", 84588, 9, 65725, 90 },
                    { 20, 69690, "Shoes", 39722, 1, 10097, 91 },
                    { 153, 89034, "Bacon", 76448, 3, 33712, 91 },
                    { 247, 3931, "Chicken", 69065, 3, 53711, 91 },
                    { 351, 19429, "Keyboard", 95930, 2, 92748, 91 },
                    { 611, 98350, "Chips", 59285, 5, 50237, 91 },
                    { 647, 29480, "Keyboard", 71115, 10, 32529, 91 },
                    { 821, 8601, "Computer", 45886, 10, 16785, 91 },
                    { 830, 28324, "Bacon", 396, 3, 57336, 91 },
                    { 133, 33318, "Chair", 58922, 8, 83398, 92 },
                    { 805, 37264, "Car", 68047, 9, 99693, 94 },
                    { 825, 71629, "Bacon", 87484, 10, 99805, 94 },
                    { 908, 95911, "Bacon", 40658, 7, 35946, 94 },
                    { 96, 23102, "Chicken", 83777, 7, 95933, 98 },
                    { 256, 63473, "Salad", 82121, 3, 73122, 98 },
                    { 345, 1018, "Tuna", 47828, 9, 93798, 98 },
                    { 430, 33240, "Bike", 81845, 7, 99921, 98 },
                    { 471, 62576, "Soap", 9043, 2, 45015, 98 },
                    { 588, 4754, "Fish", 86554, 2, 36122, 98 },
                    { 705, 52360, "Ball", 7703, 3, 61930, 98 },
                    { 917, 40409, "Soap", 15170, 4, 22863, 98 },
                    { 919, 43933, "Car", 81016, 2, 9884, 98 },
                    { 1, 65763, "Ball", 93703, 2, 77562, 99 },
                    { 15, 10804, "Hat", 31788, 10, 86613, 99 },
                    { 135, 64814, "Chips", 80162, 10, 97858, 99 },
                    { 349, 81667, "Shirt", 70512, 1, 4, 99 },
                    { 472, 4623, "Table", 18679, 6, 98457, 99 },
                    { 509, 48342, "Table", 77459, 9, 86848, 99 },
                    { 577, 36685, "Sausages", 92148, 9, 14907, 99 },
                    { 589, 54188, "Sausages", 78415, 8, 48191, 99 },
                    { 605, 61160, "Bacon", 39011, 7, 53640, 99 },
                    { 630, 56760, "Gloves", 69137, 1, 83322, 99 },
                    { 695, 87162, "Tuna", 8866, 4, 41791, 99 },
                    { 808, 76230, "Bike", 13998, 1, 96631, 99 },
                    { 103, 45094, "Gloves", 27689, 8, 60522, 100 },
                    { 120, 97062, "Chips", 79617, 7, 1821, 100 },
                    { 278, 60187, "Ball", 30902, 6, 67335, 100 },
                    { 309, 85217, "Soap", 79320, 9, 93524, 100 },
                    { 316, 71175, "Computer", 80278, 9, 79338, 100 },
                    { 319, 73447, "Chair", 18894, 2, 93609, 100 },
                    { 898, 74177, "Shirt", 5239, 4, 80308, 97 },
                    { 799, 22132, "Sausages", 55274, 2, 382, 97 },
                    { 747, 60831, "Shirt", 59493, 1, 77242, 97 },
                    { 742, 28863, "Sausages", 83375, 10, 11, 97 },
                    { 112, 50681, "Hat", 16169, 8, 20708, 95 },
                    { 312, 48596, "Table", 85427, 10, 19186, 95 },
                    { 407, 45873, "Shirt", 10683, 8, 85425, 95 },
                    { 445, 73492, "Cheese", 39987, 2, 98601, 95 },
                    { 506, 90726, "Table", 6971, 3, 68398, 95 },
                    { 572, 64889, "Table", 95556, 3, 13226, 95 },
                    { 772, 80356, "Hat", 39151, 6, 60642, 95 },
                    { 780, 42853, "Shoes", 57716, 10, 21179, 95 },
                    { 827, 66546, "Car", 63934, 5, 3358, 95 },
                    { 854, 19818, "Gloves", 20083, 8, 8132, 95 },
                    { 860, 37389, "Chips", 41211, 3, 4903, 95 },
                    { 891, 53660, "Hat", 46798, 7, 38862, 95 },
                    { 986, 27159, "Computer", 33602, 5, 62558, 95 },
                    { 218, 66725, "Ball", 76811, 6, 51498, 88 },
                    { 80, 95577, "Computer", 91913, 9, 76561, 96 },
                    { 226, 66346, "Sausages", 53190, 1, 93364, 96 },
                    { 228, 36991, "Tuna", 69359, 1, 94747, 96 },
                    { 530, 33372, "Shirt", 92305, 7, 81401, 96 },
                    { 628, 1550, "Computer", 62482, 5, 87111, 96 },
                    { 670, 27225, "Table", 66526, 3, 22950, 96 },
                    { 681, 28930, "Sausages", 7287, 10, 85592, 96 },
                    { 857, 27368, "Pants", 32024, 4, 18949, 96 },
                    { 872, 89463, "Bacon", 81755, 3, 45743, 96 },
                    { 100, 66481, "Pants", 79526, 10, 86579, 97 },
                    { 185, 14793, "Tuna", 28173, 3, 84840, 97 },
                    { 595, 97438, "Salad", 68117, 10, 57082, 97 },
                    { 598, 16619, "Chips", 50619, 8, 43733, 97 },
                    { 728, 4180, "Table", 36531, 9, 29923, 97 },
                    { 192, 3264, "Chair", 55523, 8, 70225, 96 },
                    { 938, 73664, "Mouse", 43118, 1, 68778, 75 },
                    { 987, 89576, "Chips", 37308, 1, 9158, 87 },
                    { 758, 99712, "Towels", 99087, 5, 27470, 87 },
                    { 578, 93071, "Car", 38112, 6, 12318, 78 },
                    { 771, 77977, "Pants", 69178, 5, 9530, 78 },
                    { 815, 15798, "Towels", 16188, 1, 79107, 78 },
                    { 865, 88688, "Ball", 71780, 7, 71294, 78 },
                    { 90, 19344, "Hat", 6094, 10, 98431, 79 },
                    { 179, 50585, "Chips", 75874, 4, 86421, 79 },
                    { 331, 28324, "Hat", 35099, 2, 33661, 79 },
                    { 388, 1913, "Keyboard", 31169, 9, 155, 79 },
                    { 517, 83719, "Shirt", 33890, 8, 69375, 79 },
                    { 613, 30652, "Chips", 69001, 8, 20236, 79 },
                    { 656, 36523, "Bike", 95473, 5, 32427, 79 },
                    { 785, 85236, "Chair", 10340, 6, 92381, 79 },
                    { 843, 82473, "Mouse", 24189, 4, 8935, 79 },
                    { 961, 85226, "Pants", 8217, 10, 7162, 79 },
                    { 963, 38126, "Tuna", 42691, 6, 35197, 79 },
                    { 35, 35209, "Pants", 91979, 1, 85259, 80 },
                    { 105, 27475, "Keyboard", 97585, 9, 3594, 80 },
                    { 352, 46494, "Fish", 96200, 9, 32397, 80 },
                    { 372, 84100, "Cheese", 51891, 9, 20322, 80 },
                    { 802, 96162, "Car", 789, 9, 44383, 80 },
                    { 851, 20970, "Bike", 32218, 4, 16867, 80 },
                    { 856, 63330, "Table", 25288, 9, 25553, 80 },
                    { 53, 97993, "Car", 18515, 7, 94041, 81 },
                    { 131, 84878, "Keyboard", 68995, 1, 80668, 81 },
                    { 142, 51518, "Bacon", 89890, 3, 7469, 81 },
                    { 168, 81922, "Mouse", 98647, 9, 34842, 81 },
                    { 184, 73662, "Pants", 6540, 5, 79303, 81 },
                    { 557, 61656, "Pizza", 60254, 4, 40928, 78 },
                    { 246, 32847, "Fish", 47647, 8, 2459, 81 },
                    { 529, 41779, "Chair", 72191, 9, 64533, 78 },
                    { 383, 43048, "Hat", 81913, 5, 28074, 78 },
                    { 991, 63259, "Bike", 75235, 5, 85709, 75 },
                    { 50, 61327, "Bike", 38198, 6, 81247, 76 },
                    { 79, 35745, "Cheese", 1458, 9, 64069, 76 },
                    { 86, 56615, "Cheese", 67614, 4, 79366, 76 },
                    { 88, 71298, "Bacon", 72588, 4, 3571, 76 },
                    { 285, 9670, "Computer", 68215, 10, 50227, 76 },
                    { 288, 41280, "Gloves", 86184, 6, 21233, 76 },
                    { 933, 39269, "Salad", 84580, 1, 8629, 76 },
                    { 37, 65093, "Tuna", 97390, 5, 99505, 77 },
                    { 210, 31577, "Table", 7926, 1, 20195, 77 },
                    { 258, 65167, "Sausages", 68766, 2, 84552, 77 },
                    { 386, 44479, "Bacon", 37307, 1, 11984, 77 },
                    { 397, 45822, "Ball", 65247, 2, 76124, 77 },
                    { 514, 13021, "Chips", 82719, 4, 35417, 77 },
                    { 523, 4108, "Bacon", 58137, 1, 13216, 77 },
                    { 525, 2988, "Chair", 58456, 6, 34443, 77 },
                    { 547, 50448, "Ball", 23309, 3, 20597, 77 },
                    { 757, 69042, "Computer", 3831, 2, 84971, 77 },
                    { 862, 12202, "Shirt", 11030, 3, 31675, 77 },
                    { 928, 17902, "Gloves", 97543, 6, 63187, 77 },
                    { 106, 11430, "Mouse", 63138, 5, 4772, 78 },
                    { 109, 79717, "Ball", 13342, 4, 88499, 78 },
                    { 174, 55704, "Towels", 39152, 2, 27070, 78 },
                    { 182, 9653, "Tuna", 35092, 2, 12875, 78 },
                    { 262, 37053, "Mouse", 31496, 3, 84020, 78 },
                    { 273, 73010, "Mouse", 27068, 6, 59459, 78 },
                    { 310, 2526, "Chips", 74188, 3, 72770, 78 },
                    { 462, 57147, "Sausages", 82677, 10, 99352, 78 },
                    { 688, 46391, "Bike", 7366, 3, 81168, 81 },
                    { 896, 1936, "Cheese", 68638, 4, 72714, 81 },
                    { 901, 26777, "Gloves", 17233, 2, 87788, 81 },
                    { 308, 20384, "Ball", 46466, 4, 80352, 85 },
                    { 354, 82095, "Mouse", 17433, 7, 57693, 85 },
                    { 384, 75244, "Soap", 51347, 3, 21211, 85 },
                    { 402, 54745, "Keyboard", 85515, 10, 40401, 85 },
                    { 449, 99587, "Tuna", 34921, 8, 44827, 85 },
                    { 538, 10457, "Chair", 69593, 10, 53408, 85 },
                    { 591, 35188, "Keyboard", 55000, 8, 34194, 85 },
                    { 828, 62178, "Tuna", 21839, 9, 29224, 85 },
                    { 10, 57348, "Bacon", 40060, 2, 99601, 86 },
                    { 235, 42313, "Cheese", 24512, 2, 32647, 86 },
                    { 346, 63587, "Shirt", 81847, 9, 58717, 86 },
                    { 385, 48048, "Pizza", 3643, 3, 53786, 86 },
                    { 391, 38403, "Chicken", 9502, 4, 40006, 86 },
                    { 661, 1399, "Towels", 86331, 10, 15201, 86 },
                    { 674, 72425, "Bacon", 95913, 7, 93920, 86 },
                    { 836, 73523, "Ball", 74411, 7, 76086, 86 },
                    { 863, 24402, "Bacon", 74879, 10, 1805, 86 },
                    { 866, 37074, "Shirt", 96643, 3, 96965, 86 },
                    { 960, 21887, "Fish", 51279, 7, 3249, 86 },
                    { 994, 50401, "Tuna", 82932, 2, 64502, 86 },
                    { 68, 96633, "Pizza", 35727, 10, 89836, 87 },
                    { 194, 13619, "Computer", 68738, 5, 64455, 87 },
                    { 214, 18550, "Keyboard", 19955, 3, 69189, 87 },
                    { 333, 31376, "Shoes", 93129, 10, 48950, 87 },
                    { 398, 95546, "Soap", 71300, 4, 56231, 87 },
                    { 518, 36701, "Computer", 62665, 10, 57685, 87 },
                    { 594, 29655, "Chair", 23938, 2, 23667, 87 },
                    { 265, 67038, "Chair", 21926, 9, 65900, 85 },
                    { 12, 13929, "Salad", 37318, 9, 45131, 85 },
                    { 910, 96337, "Bacon", 47887, 2, 66992, 84 },
                    { 870, 48624, "Table", 48868, 1, 91972, 84 },
                    { 6, 75652, "Chicken", 53412, 10, 54488, 82 },
                    { 107, 24732, "Tuna", 52738, 2, 78830, 82 },
                    { 167, 25089, "Soap", 89505, 4, 99606, 82 },
                    { 269, 76646, "Cheese", 84106, 6, 50619, 82 },
                    { 410, 22463, "Towels", 51812, 3, 99180, 82 },
                    { 412, 96669, "Computer", 60942, 6, 19907, 82 },
                    { 477, 13446, "Bacon", 33731, 4, 54804, 82 },
                    { 655, 76731, "Chips", 73246, 1, 76793, 82 },
                    { 673, 35137, "Sausages", 49875, 2, 20525, 82 },
                    { 929, 94502, "Mouse", 13233, 9, 39906, 82 },
                    { 63, 71635, "Soap", 88626, 2, 7963, 83 },
                    { 195, 81313, "Keyboard", 23076, 1, 16655, 83 },
                    { 239, 6113, "Cheese", 28663, 5, 44545, 83 },
                    { 976, 1457, "Shirt", 18660, 7, 94011, 87 },
                    { 365, 34691, "Sausages", 73753, 4, 16935, 83 },
                    { 450, 84155, "Pizza", 83836, 5, 55946, 83 },
                    { 493, 19795, "Car", 6179, 5, 43007, 83 },
                    { 558, 53026, "Ball", 69212, 1, 94613, 83 },
                    { 617, 25628, "Salad", 37614, 10, 1380, 83 },
                    { 794, 20429, "Fish", 10944, 1, 72189, 83 },
                    { 886, 84855, "Cheese", 43835, 1, 8511, 83 },
                    { 964, 26915, "Fish", 10268, 3, 20354, 83 },
                    { 263, 25515, "Sausages", 37440, 6, 40804, 84 },
                    { 306, 4424, "Shoes", 93241, 7, 96681, 84 },
                    { 432, 9674, "Salad", 22774, 3, 1162, 84 },
                    { 502, 83040, "Gloves", 97029, 3, 35776, 84 },
                    { 536, 32087, "Mouse", 71682, 3, 75796, 84 },
                    { 698, 46454, "Gloves", 88505, 9, 41341, 84 },
                    { 441, 20035, "Mouse", 93465, 9, 17049, 83 },
                    { 711, 18232, "Chips", 39295, 10, 36215, 49 },
                    { 675, 4868, "Computer", 74505, 4, 81795, 49 },
                    { 604, 71879, "Pants", 81426, 7, 74223, 49 },
                    { 205, 66239, "Chicken", 76019, 1, 2311, 17 },
                    { 243, 90849, "Chicken", 89590, 6, 14155, 17 },
                    { 413, 78185, "Mouse", 62036, 10, 13128, 17 },
                    { 455, 43992, "Soap", 32804, 5, 1509, 17 },
                    { 570, 46913, "Shirt", 48445, 10, 61772, 17 },
                    { 94, 80061, "Bike", 45159, 3, 36440, 18 },
                    { 303, 75582, "Bike", 32065, 1, 46168, 18 },
                    { 327, 85426, "Chips", 72696, 8, 1743, 18 },
                    { 343, 84767, "Chips", 31794, 7, 81257, 18 },
                    { 417, 21502, "Cheese", 86351, 1, 25229, 18 },
                    { 459, 26285, "Car", 59088, 5, 3625, 18 },
                    { 624, 97631, "Gloves", 79179, 3, 24635, 18 },
                    { 739, 8746, "Soap", 94003, 2, 52026, 18 },
                    { 824, 51796, "Keyboard", 66920, 2, 85092, 18 },
                    { 889, 70740, "Chicken", 7234, 5, 58696, 18 },
                    { 890, 15332, "Keyboard", 6702, 5, 39217, 18 },
                    { 966, 43778, "Fish", 12771, 3, 61993, 18 },
                    { 234, 37073, "Cheese", 21003, 6, 27400, 19 },
                    { 356, 85680, "Bike", 81173, 2, 28796, 19 },
                    { 446, 28304, "Chair", 28299, 8, 8797, 19 },
                    { 451, 46168, "Table", 65881, 7, 89426, 19 },
                    { 733, 81796, "Tuna", 98519, 7, 47978, 19 },
                    { 7, 91744, "Table", 27070, 5, 9755, 20 },
                    { 57, 58737, "Computer", 21982, 3, 53074, 20 },
                    { 128, 73829, "Cheese", 49798, 4, 15912, 20 },
                    { 251, 92797, "Bacon", 85123, 2, 28877, 20 },
                    { 358, 90956, "Chicken", 16746, 2, 94059, 20 },
                    { 146, 1385, "Car", 4670, 7, 85943, 17 },
                    { 541, 79908, "Pizza", 31894, 4, 55005, 20 },
                    { 102, 56034, "Car", 13873, 2, 87583, 17 },
                    { 700, 42711, "Computer", 70818, 6, 91610, 16 },
                    { 946, 38478, "Tuna", 92973, 6, 5134, 13 },
                    { 111, 34605, "Soap", 98073, 4, 78477, 14 },
                    { 117, 30743, "Bacon", 89185, 6, 55176, 14 },
                    { 119, 62902, "Cheese", 21216, 9, 16272, 14 },
                    { 300, 28415, "Chicken", 3195, 5, 83263, 14 },
                    { 317, 10576, "Chicken", 44419, 8, 48026, 14 },
                    { 396, 97135, "Soap", 36768, 6, 97780, 14 },
                    { 404, 99693, "Soap", 72420, 10, 41054, 14 },
                    { 475, 30188, "Car", 88134, 10, 75510, 14 },
                    { 513, 29415, "Hat", 63847, 2, 99930, 14 },
                    { 600, 68377, "Salad", 23948, 5, 84513, 14 },
                    { 707, 83222, "Tuna", 12833, 6, 81356, 14 },
                    { 188, 98168, "Chair", 68809, 2, 87417, 15 },
                    { 199, 22103, "Chicken", 12954, 6, 73236, 15 },
                    { 233, 10616, "Table", 32453, 10, 24072, 15 },
                    { 240, 86255, "Bacon", 75668, 2, 21902, 15 },
                    { 277, 90644, "Gloves", 86966, 2, 97970, 15 },
                    { 321, 97457, "Ball", 14626, 4, 50619, 15 },
                    { 574, 29738, "Sausages", 83187, 6, 45410, 15 },
                    { 766, 46687, "Ball", 19855, 7, 27796, 15 },
                    { 853, 59350, "Sausages", 91429, 10, 92964, 15 },
                    { 996, 30902, "Keyboard", 21228, 7, 45801, 15 },
                    { 22, 68500, "Salad", 37700, 2, 90771, 16 },
                    { 62, 84558, "Chips", 88555, 9, 41218, 16 },
                    { 259, 22065, "Bike", 71743, 6, 68388, 16 },
                    { 297, 15052, "Ball", 18048, 4, 40025, 16 },
                    { 662, 61083, "Shoes", 15870, 7, 30912, 16 },
                    { 800, 63811, "Mouse", 98238, 10, 28703, 16 },
                    { 562, 42687, "Salad", 34606, 3, 40025, 20 },
                    { 936, 28081, "Towels", 50561, 3, 87159, 20 },
                    { 113, 49514, "Shoes", 98900, 1, 9364, 21 },
                    { 835, 2898, "Tuna", 59326, 5, 17647, 23 },
                    { 1000, 89725, "Bike", 75645, 9, 73564, 23 },
                    { 69, 4953, "Shoes", 25968, 4, 12828, 24 },
                    { 118, 18935, "Bike", 9768, 4, 77933, 24 },
                    { 272, 10309, "Cheese", 83759, 2, 15093, 24 },
                    { 335, 49866, "Chicken", 88467, 6, 87714, 24 },
                    { 338, 5228, "Hat", 94011, 5, 17161, 24 },
                    { 486, 95078, "Shirt", 99925, 1, 43136, 24 },
                    { 496, 68941, "Pants", 8692, 5, 33808, 24 },
                    { 696, 40654, "Soap", 56186, 9, 72781, 24 },
                    { 721, 66632, "Cheese", 66027, 7, 74980, 24 },
                    { 779, 65522, "Fish", 66829, 9, 61114, 24 },
                    { 838, 75900, "Tuna", 74859, 10, 16719, 24 },
                    { 848, 43411, "Shirt", 6742, 10, 65734, 24 },
                    { 973, 5066, "Table", 46819, 2, 89157, 24 },
                    { 999, 52167, "Shirt", 62574, 9, 81658, 24 },
                    { 26, 60446, "Soap", 23688, 3, 88402, 25 },
                    { 684, 73239, "Shoes", 39806, 4, 79852, 25 },
                    { 745, 21422, "Computer", 50006, 2, 21688, 25 },
                    { 798, 37894, "Ball", 63711, 2, 94848, 25 },
                    { 956, 36288, "Sausages", 55469, 6, 17542, 25 },
                    { 981, 3642, "Shoes", 50011, 9, 48091, 25 },
                    { 141, 80822, "Chair", 44802, 3, 96075, 26 },
                    { 326, 73142, "Bacon", 17046, 9, 60504, 26 },
                    { 380, 86623, "Shirt", 49655, 3, 96133, 26 },
                    { 401, 73351, "Chips", 35739, 5, 49706, 26 },
                    { 495, 39195, "Cheese", 7035, 1, 87752, 26 },
                    { 636, 50146, "Pants", 38290, 7, 51632, 23 },
                    { 456, 8688, "Pants", 65171, 10, 25539, 23 },
                    { 425, 54114, "Shoes", 42716, 8, 82187, 23 },
                    { 393, 16443, "Shirt", 67976, 7, 38726, 23 },
                    { 115, 85589, "Tuna", 72386, 5, 38602, 21 },
                    { 123, 56338, "Gloves", 44745, 4, 69583, 21 },
                    { 216, 15122, "Chicken", 83485, 7, 50018, 21 },
                    { 373, 95938, "Chips", 43014, 9, 5417, 21 },
                    { 382, 14134, "Salad", 23844, 10, 34307, 21 },
                    { 465, 47825, "Towels", 79595, 10, 8793, 21 },
                    { 470, 88928, "Hat", 60435, 9, 52939, 21 },
                    { 596, 53651, "Cheese", 50401, 9, 62725, 21 },
                    { 669, 34705, "Chair", 25113, 3, 23815, 21 },
                    { 850, 82945, "Mouse", 85421, 5, 40074, 21 },
                    { 904, 65362, "Salad", 72660, 4, 60834, 21 },
                    { 54, 44560, "Chicken", 90725, 7, 15570, 22 },
                    { 81, 478, "Shoes", 12926, 7, 49641, 22 },
                    { 618, 19766, "Computer", 42129, 6, 52458, 13 },
                    { 129, 58688, "Chicken", 63722, 1, 39720, 22 },
                    { 560, 37592, "Computer", 53857, 7, 36141, 22 },
                    { 582, 82073, "Shirt", 4443, 3, 89813, 22 },
                    { 610, 35114, "Gloves", 62642, 3, 44471, 22 },
                    { 716, 46254, "Bike", 58126, 9, 64986, 22 },
                    { 719, 24355, "Chicken", 12198, 3, 8575, 22 },
                    { 869, 55945, "Soap", 10882, 7, 75593, 22 },
                    { 939, 96652, "Chips", 16213, 6, 10119, 22 },
                    { 944, 96650, "Salad", 52120, 3, 20599, 22 },
                    { 40, 53548, "Bike", 26854, 10, 80914, 23 },
                    { 45, 1296, "Cheese", 74033, 9, 69135, 23 },
                    { 138, 51686, "Shirt", 21593, 6, 13061, 23 },
                    { 283, 20978, "Salad", 91718, 9, 31812, 23 },
                    { 323, 56242, "Towels", 53809, 7, 74036, 23 },
                    { 187, 8874, "Car", 55132, 6, 59196, 22 },
                    { 535, 57932, "Car", 60914, 6, 78511, 26 },
                    { 553, 8838, "Bike", 73538, 6, 72336, 13 },
                    { 494, 39296, "Soap", 68526, 9, 99412, 13 },
                    { 691, 19550, "Hat", 15029, 6, 83257, 4 },
                    { 699, 97402, "Keyboard", 70890, 7, 71251, 4 },
                    { 735, 6383, "Keyboard", 28232, 9, 6672, 4 },
                    { 778, 54171, "Fish", 31204, 8, 60804, 4 },
                    { 913, 70704, "Shirt", 51077, 9, 63020, 4 },
                    { 918, 93190, "Pizza", 16858, 1, 86288, 4 },
                    { 921, 53985, "Soap", 21030, 2, 11374, 4 },
                    { 51, 31422, "Salad", 93205, 2, 48617, 5 },
                    { 66, 88142, "Shoes", 44584, 10, 39239, 5 },
                    { 245, 61590, "Towels", 75638, 4, 68065, 5 },
                    { 424, 18922, "Bike", 35228, 2, 36584, 5 },
                    { 481, 4694, "Computer", 3555, 6, 14176, 5 },
                    { 626, 27717, "Bike", 47430, 5, 5038, 5 },
                    { 876, 51648, "Pants", 98689, 10, 53619, 5 },
                    { 992, 81483, "Computer", 99404, 6, 31157, 5 },
                    { 196, 45458, "Bike", 80490, 1, 35758, 6 },
                    { 250, 95196, "Chips", 92980, 8, 4177, 6 },
                    { 289, 40901, "Tuna", 31050, 6, 97914, 6 },
                    { 322, 97167, "Keyboard", 68248, 4, 98269, 6 },
                    { 701, 50577, "Sausages", 63093, 3, 3464, 6 },
                    { 952, 89270, "Shoes", 44809, 10, 65358, 6 },
                    { 967, 85688, "Mouse", 33967, 8, 28830, 6 },
                    { 438, 74464, "Ball", 17360, 4, 72544, 7 },
                    { 528, 4126, "Shirt", 72070, 5, 8703, 7 },
                    { 754, 79840, "Cheese", 74206, 7, 12286, 7 },
                    { 899, 45548, "Pizza", 56485, 3, 47871, 7 },
                    { 990, 50885, "Chicken", 80780, 9, 89300, 7 },
                    { 657, 28144, "Shirt", 11887, 7, 44546, 4 },
                    { 70, 76096, "Gloves", 84118, 2, 89098, 8 },
                    { 564, 83886, "Bacon", 83497, 3, 56182, 4 },
                    { 389, 72170, "Soap", 48842, 3, 94506, 4 },
                    { 97, 60474, "Fish", 7841, 1, 54224, 1 },
                    { 313, 6256, "Chicken", 96734, 6, 49398, 1 },
                    { 436, 33855, "Ball", 20192, 10, 46683, 1 },
                    { 458, 76911, "Car", 79808, 10, 98623, 1 },
                    { 568, 31439, "Shoes", 10102, 2, 57840, 1 },
                    { 804, 76341, "Mouse", 49213, 6, 62107, 1 },
                    { 911, 56524, "Pants", 43594, 3, 2234, 1 },
                    { 114, 59758, "Chair", 69613, 10, 1937, 2 },
                    { 121, 95595, "Shirt", 75064, 6, 67992, 2 },
                    { 186, 64258, "Shirt", 75292, 7, 58643, 2 },
                    { 252, 8647, "Bacon", 37125, 3, 34661, 2 },
                    { 260, 37542, "Cheese", 60485, 6, 36709, 2 },
                    { 565, 33696, "Cheese", 29929, 8, 94970, 2 },
                    { 580, 51435, "Gloves", 98361, 2, 3518, 2 },
                    { 678, 31355, "Cheese", 37947, 5, 21637, 2 },
                    { 907, 24496, "Ball", 66998, 1, 10864, 2 },
                    { 217, 91290, "Fish", 26014, 3, 78466, 3 },
                    { 419, 34890, "Chips", 755, 8, 77250, 3 },
                    { 435, 74551, "Tuna", 68944, 1, 78149, 3 },
                    { 469, 67474, "Chair", 12404, 1, 21286, 3 },
                    { 741, 57788, "Shirt", 29315, 9, 34691, 3 },
                    { 21, 38417, "Computer", 49153, 8, 80151, 4 },
                    { 47, 93205, "Pizza", 38884, 9, 18810, 4 },
                    { 98, 20590, "Car", 83894, 7, 22002, 4 },
                    { 230, 19328, "Towels", 21093, 2, 23982, 4 },
                    { 257, 3197, "Car", 78858, 2, 54501, 4 },
                    { 330, 3674, "Bike", 58876, 3, 58845, 4 },
                    { 437, 90938, "Chips", 56506, 4, 3422, 4 },
                    { 136, 93074, "Ball", 29829, 10, 92520, 8 },
                    { 198, 85338, "Soap", 64154, 1, 70515, 8 },
                    { 307, 90446, "Bacon", 48535, 6, 9482, 8 },
                    { 229, 59375, "Salad", 51443, 7, 39611, 11 },
                    { 268, 93808, "Table", 45673, 4, 87247, 11 },
                    { 324, 68937, "Pants", 48882, 10, 63802, 11 },
                    { 426, 29410, "Gloves", 81598, 1, 11859, 11 },
                    { 466, 48012, "Table", 33185, 7, 94838, 11 },
                    { 526, 93344, "Mouse", 35564, 1, 42966, 11 },
                    { 593, 43376, "Cheese", 66102, 5, 79180, 11 },
                    { 627, 1026, "Computer", 48850, 7, 40866, 11 },
                    { 686, 59602, "Gloves", 75655, 2, 97544, 11 },
                    { 797, 56476, "Bike", 86747, 10, 39234, 11 },
                    { 334, 17543, "Towels", 18711, 4, 56033, 12 },
                    { 427, 88018, "Bacon", 31261, 8, 86347, 12 },
                    { 463, 97092, "Shoes", 15004, 7, 85602, 12 },
                    { 507, 38310, "Sausages", 76906, 10, 57423, 12 },
                    { 590, 24332, "Sausages", 32491, 2, 61419, 12 },
                    { 753, 14181, "Pizza", 9821, 6, 22474, 12 },
                    { 768, 9128, "Fish", 36570, 8, 55349, 12 },
                    { 777, 59179, "Salad", 6968, 6, 94340, 12 },
                    { 839, 13231, "Bike", 70671, 4, 7847, 12 },
                    { 943, 67888, "Chair", 1756, 3, 95676, 12 },
                    { 958, 23784, "Keyboard", 64329, 1, 30691, 12 },
                    { 975, 66632, "Computer", 14949, 7, 128, 12 },
                    { 83, 70371, "Chips", 14781, 7, 6821, 13 },
                    { 91, 25215, "Tuna", 84470, 10, 1336, 13 },
                    { 132, 55545, "Soap", 79536, 2, 41717, 13 },
                    { 202, 20341, "Keyboard", 22510, 6, 69454, 13 },
                    { 479, 69376, "Chair", 37570, 7, 35346, 13 },
                    { 25, 35872, "Table", 91496, 10, 10525, 11 },
                    { 941, 1530, "Salad", 75830, 10, 42943, 10 },
                    { 806, 71028, "Chicken", 46463, 3, 61066, 10 },
                    { 620, 86453, "Table", 34118, 6, 82010, 10 },
                    { 370, 80811, "Bike", 54234, 5, 5376, 8 },
                    { 418, 95825, "Chips", 23572, 1, 10854, 8 },
                    { 429, 51359, "Bacon", 57572, 5, 46085, 8 },
                    { 586, 90676, "Computer", 95769, 6, 43533, 8 },
                    { 602, 45590, "Computer", 96509, 4, 24882, 8 },
                    { 713, 46435, "Towels", 62270, 6, 593, 8 },
                    { 803, 855, "Bike", 75804, 10, 15603, 8 },
                    { 887, 84892, "Salad", 19348, 2, 16540, 8 },
                    { 903, 61108, "Pizza", 91276, 5, 33178, 8 },
                    { 916, 83977, "Keyboard", 96809, 9, 30629, 8 },
                    { 925, 99567, "Cheese", 14530, 8, 70569, 8 },
                    { 13, 73055, "Gloves", 68554, 5, 57928, 9 },
                    { 140, 17704, "Ball", 99077, 9, 46399, 9 },
                    { 551, 75285, "Keyboard", 90046, 1, 89553, 13 },
                    { 157, 86439, "Car", 68057, 7, 89752, 9 },
                    { 275, 17768, "Chair", 8961, 8, 60128, 9 },
                    { 295, 47250, "Table", 16822, 2, 89561, 9 },
                    { 375, 36988, "Soap", 13613, 2, 20558, 9 },
                    { 559, 64248, "Chair", 50493, 2, 32433, 9 },
                    { 654, 75288, "Cheese", 7340, 6, 2653, 9 },
                    { 722, 40606, "Salad", 14952, 8, 12013, 9 },
                    { 793, 11260, "Hat", 64560, 2, 23390, 9 },
                    { 75, 21547, "Pants", 99477, 6, 41997, 10 },
                    { 190, 71848, "Towels", 77417, 8, 86569, 10 },
                    { 405, 63690, "Table", 29431, 3, 64297, 10 },
                    { 444, 62337, "Computer", 40843, 4, 90816, 10 },
                    { 569, 12774, "Cheese", 87712, 6, 60332, 10 },
                    { 576, 67633, "Mouse", 56275, 8, 80947, 10 },
                    { 231, 96096, "Soap", 5180, 5, 34946, 9 },
                    { 608, 9442, "Chips", 16347, 8, 86640, 26 },
                    { 697, 3504, "Fish", 24250, 6, 4350, 26 },
                    { 801, 99956, "Ball", 70251, 7, 86933, 26 },
                    { 485, 60744, "Cheese", 89261, 6, 80572, 40 },
                    { 658, 99570, "Salad", 86758, 9, 29781, 40 },
                    { 932, 50497, "Soap", 59235, 10, 7614, 40 },
                    { 954, 73759, "Salad", 65585, 1, 67479, 40 },
                    { 42, 79882, "Shoes", 54146, 2, 79923, 41 },
                    { 95, 30804, "Pants", 95995, 1, 99320, 41 },
                    { 280, 59958, "Mouse", 62961, 5, 15950, 41 },
                    { 492, 15902, "Soap", 8851, 7, 62252, 41 },
                    { 512, 88134, "Cheese", 24750, 3, 68137, 41 },
                    { 520, 95901, "Chicken", 18100, 4, 74351, 41 },
                    { 749, 27309, "Soap", 31178, 1, 6716, 41 },
                    { 792, 88357, "Pants", 61751, 1, 71348, 41 },
                    { 11, 56543, "Fish", 61781, 8, 49671, 42 },
                    { 149, 30547, "Towels", 18568, 9, 18472, 42 },
                    { 293, 57665, "Tuna", 38872, 8, 18857, 42 },
                    { 366, 37817, "Pizza", 94290, 2, 57399, 42 },
                    { 367, 62283, "Salad", 69742, 10, 33399, 42 },
                    { 563, 50080, "Hat", 31543, 5, 11556, 42 },
                    { 581, 41328, "Cheese", 11503, 5, 79251, 42 },
                    { 615, 23034, "Table", 9768, 2, 39130, 42 },
                    { 621, 71525, "Bacon", 74419, 1, 91046, 42 },
                    { 879, 1049, "Cheese", 22306, 4, 53115, 42 },
                    { 9, 82374, "Soap", 19866, 3, 6981, 43 },
                    { 34, 30933, "Chips", 36773, 3, 2437, 43 },
                    { 72, 84008, "Fish", 9672, 6, 70577, 43 },
                    { 390, 22062, "Fish", 17621, 6, 62574, 43 },
                    { 640, 91146, "Pants", 92266, 1, 22831, 43 },
                    { 476, 48407, "Shoes", 73281, 9, 51985, 40 },
                    { 743, 45163, "Soap", 59297, 1, 41313, 43 },
                    { 461, 46241, "Pizza", 26248, 3, 99387, 40 },
                    { 318, 84857, "Chips", 99806, 2, 12010, 40 },
                    { 822, 70186, "Gloves", 99262, 7, 17395, 37 },
                    { 859, 70582, "Tuna", 44340, 6, 59219, 37 },
                    { 59, 57498, "Fish", 12403, 10, 23252, 38 },
                    { 108, 10773, "Salad", 43825, 4, 26900, 38 },
                    { 144, 57742, "Gloves", 39712, 1, 45926, 38 },
                    { 302, 85806, "Shoes", 7617, 4, 68295, 38 },
                    { 336, 69217, "Tuna", 73364, 4, 94817, 38 },
                    { 464, 32749, "Salad", 9961, 4, 83131, 38 },
                    { 625, 22265, "Chicken", 6964, 1, 4903, 38 },
                    { 782, 8942, "Pizza", 71276, 8, 236, 38 },
                    { 950, 54164, "Bacon", 19941, 7, 91284, 38 },
                    { 38, 32486, "Shoes", 54955, 9, 83205, 39 },
                    { 163, 60624, "Bike", 79543, 6, 20470, 39 },
                    { 175, 39799, "Sausages", 8800, 7, 40873, 39 },
                    { 378, 41289, "Pants", 95210, 7, 36553, 39 },
                    { 480, 40019, "Sausages", 99534, 6, 40634, 39 },
                    { 504, 13941, "Shirt", 40696, 9, 54341, 39 },
                    { 516, 25547, "Towels", 62497, 6, 78036, 39 },
                    { 550, 84958, "Shirt", 76967, 8, 10476, 39 },
                    { 643, 31903, "Shirt", 89191, 8, 26820, 39 },
                    { 683, 33346, "Soap", 98084, 10, 67276, 39 },
                    { 715, 18606, "Pants", 71438, 6, 52688, 39 },
                    { 884, 58549, "Pants", 76023, 10, 50374, 39 },
                    { 914, 52476, "Bacon", 70159, 5, 16813, 39 },
                    { 980, 5576, "Pants", 74297, 4, 97311, 39 },
                    { 989, 86061, "Keyboard", 83337, 9, 82027, 39 },
                    { 93, 89107, "Computer", 53878, 8, 79720, 40 },
                    { 325, 80524, "Chicken", 61423, 7, 35835, 40 },
                    { 877, 6189, "Salad", 76967, 9, 11683, 43 },
                    { 885, 57555, "Car", 15590, 6, 35502, 43 },
                    { 942, 65137, "Salad", 84268, 8, 60742, 43 },
                    { 154, 70559, "Car", 69413, 1, 41765, 47 },
                    { 156, 16395, "Bike", 58397, 10, 36870, 47 },
                    { 359, 5242, "Shoes", 66219, 6, 6722, 47 },
                    { 395, 33614, "Pants", 86476, 8, 7055, 47 },
                    { 439, 29845, "Shirt", 24823, 1, 98386, 47 },
                    { 521, 70435, "Cheese", 69445, 4, 67108, 47 },
                    { 544, 76195, "Bike", 85389, 8, 93942, 47 },
                    { 734, 43736, "Computer", 12010, 9, 22403, 47 },
                    { 820, 84360, "Chicken", 53019, 5, 87689, 47 },
                    { 969, 73085, "Shoes", 43544, 5, 33335, 47 },
                    { 977, 89545, "Chicken", 65272, 5, 68801, 47 },
                    { 122, 62738, "Gloves", 46210, 7, 60005, 48 },
                    { 145, 59125, "Bacon", 26403, 7, 58126, 48 },
                    { 236, 21023, "Fish", 44378, 3, 19872, 48 },
                    { 254, 45559, "Table", 29459, 7, 56508, 48 },
                    { 284, 9693, "Car", 3453, 7, 40664, 48 },
                    { 414, 68972, "Shoes", 26519, 6, 26954, 48 },
                    { 415, 13571, "Gloves", 25998, 9, 37682, 48 },
                    { 483, 47616, "Towels", 38904, 8, 12759, 48 },
                    { 531, 72404, "Salad", 70020, 1, 75274, 48 },
                    { 717, 44210, "Fish", 67230, 4, 49512, 48 },
                    { 873, 92196, "Shoes", 44291, 7, 94977, 48 },
                    { 937, 38800, "Soap", 71933, 6, 64480, 48 },
                    { 71, 26227, "Mouse", 61984, 4, 69806, 49 },
                    { 73, 66423, "Car", 45038, 9, 90664, 49 },
                    { 522, 25458, "Cheese", 48992, 10, 26927, 49 },
                    { 543, 31491, "Tuna", 6376, 6, 39518, 49 },
                    { 927, 13345, "Cheese", 71901, 6, 29461, 46 },
                    { 724, 13134, "Chips", 11236, 5, 22006, 46 },
                    { 720, 71181, "Fish", 54089, 9, 41040, 46 },
                    { 652, 16208, "Sausages", 83299, 2, 89603, 46 },
                    { 43, 60095, "Pants", 53179, 9, 32614, 44 },
                    { 151, 42780, "Chips", 42588, 5, 23083, 44 },
                    { 281, 75578, "Shoes", 39415, 2, 60455, 44 },
                    { 328, 13044, "Fish", 54267, 2, 5216, 44 },
                    { 357, 51804, "Chicken", 99745, 4, 87177, 44 },
                    { 379, 33713, "Keyboard", 22539, 1, 28500, 44 },
                    { 930, 89013, "Shoes", 72420, 8, 22890, 44 },
                    { 2, 46426, "Mouse", 27932, 10, 60852, 45 },
                    { 32, 25667, "Salad", 10753, 10, 97074, 45 },
                    { 85, 82787, "Car", 55076, 6, 84757, 45 },
                    { 104, 92343, "Pants", 30626, 5, 13539, 45 },
                    { 224, 58114, "Computer", 4508, 1, 14400, 45 },
                    { 238, 16600, "Bacon", 61836, 2, 42721, 45 },
                    { 765, 92973, "Car", 26763, 2, 58874, 37 },
                    { 411, 76040, "Chips", 15137, 10, 52839, 45 },
                    { 645, 3112, "Tuna", 50050, 2, 844, 45 },
                    { 692, 87840, "Salad", 48812, 8, 99711, 45 },
                    { 702, 50149, "Salad", 15853, 8, 67988, 45 },
                    { 725, 36342, "Ball", 40064, 8, 96525, 45 },
                    { 840, 49293, "Bacon", 62535, 5, 530, 45 },
                    { 864, 15347, "Chicken", 49641, 10, 928, 45 },
                    { 897, 55446, "Soap", 75736, 6, 22158, 45 },
                    { 947, 33489, "Fish", 73333, 9, 15507, 45 },
                    { 982, 60623, "Computer", 27552, 4, 42771, 45 },
                    { 17, 31272, "Towels", 51272, 1, 28707, 46 },
                    { 197, 9839, "Gloves", 15567, 10, 61338, 46 },
                    { 287, 86964, "Cheese", 56958, 1, 51057, 46 },
                    { 423, 8649, "Gloves", 19963, 7, 25433, 46 },
                    { 583, 84629, "Fish", 58177, 3, 56388, 45 },
                    { 744, 1233, "Bacon", 10421, 5, 15784, 37 },
                    { 665, 61070, "Bacon", 28069, 1, 99327, 37 },
                    { 642, 41721, "Bike", 62792, 1, 64668, 37 },
                    { 376, 62359, "Pizza", 91111, 9, 9916, 29 },
                    { 434, 92621, "Ball", 77869, 8, 19456, 29 },
                    { 440, 87246, "Mouse", 98941, 8, 219, 29 },
                    { 499, 5610, "Towels", 36392, 9, 68276, 29 },
                    { 597, 2088, "Computer", 65319, 8, 37505, 29 },
                    { 746, 90537, "Chips", 17007, 3, 98822, 29 },
                    { 791, 92771, "Shoes", 46453, 8, 269, 29 },
                    { 871, 33999, "Cheese", 68339, 8, 52412, 29 },
                    { 875, 75265, "Tuna", 30268, 10, 82073, 29 },
                    { 993, 85185, "Hat", 96570, 3, 27469, 29 },
                    { 44, 53338, "Pizza", 1665, 2, 1088, 30 },
                    { 48, 61873, "Pizza", 62794, 8, 37314, 30 },
                    { 64, 71349, "Gloves", 3349, 4, 85453, 30 },
                    { 124, 49364, "Salad", 5958, 1, 46993, 30 },
                    { 503, 18732, "Soap", 83049, 10, 49566, 30 },
                    { 548, 32353, "Keyboard", 73725, 7, 65321, 30 },
                    { 629, 70455, "Cheese", 80573, 6, 49658, 30 },
                    { 637, 28358, "Tuna", 93965, 8, 49451, 30 },
                    { 727, 48226, "Bacon", 28531, 3, 79117, 30 },
                    { 82, 74429, "Pizza", 69660, 10, 41447, 31 },
                    { 237, 60939, "Salad", 47474, 4, 66699, 31 },
                    { 248, 42, "Shoes", 22642, 4, 92974, 31 },
                    { 394, 25443, "Hat", 70947, 9, 84150, 31 },
                    { 403, 94503, "Towels", 65557, 7, 7891, 31 },
                    { 487, 60912, "Cheese", 43045, 9, 36970, 31 },
                    { 552, 70193, "Sausages", 1702, 1, 85692, 31 },
                    { 556, 84873, "Soap", 42445, 4, 41675, 31 },
                    { 242, 85451, "Salad", 97484, 3, 24001, 29 },
                    { 225, 49832, "Tuna", 32274, 6, 24180, 29 },
                    { 176, 36243, "Pants", 93665, 4, 67636, 29 },
                    { 161, 14933, "Table", 47163, 8, 12617, 29 },
                    { 811, 6891, "Towels", 55234, 3, 69781, 26 },
                    { 31, 27568, "Computer", 95747, 1, 53855, 27 },
                    { 155, 63330, "Ball", 97937, 4, 77781, 27 },
                    { 340, 23691, "Pizza", 99084, 7, 35415, 27 },
                    { 377, 46465, "Chips", 69648, 2, 62211, 27 },
                    { 416, 29431, "Mouse", 56293, 5, 18244, 27 },
                    { 540, 77646, "Car", 73660, 7, 35603, 27 },
                    { 638, 20001, "Pants", 63753, 6, 6550, 27 },
                    { 738, 98571, "Pants", 63170, 10, 40856, 27 },
                    { 774, 15143, "Towels", 87011, 6, 96836, 27 },
                    { 826, 23736, "Car", 67235, 8, 30070, 27 },
                    { 130, 45692, "Sausages", 61052, 10, 91333, 28 },
                    { 211, 6401, "Soap", 64933, 3, 49256, 28 },
                    { 651, 18736, "Pizza", 51444, 2, 19172, 31 },
                    { 266, 76965, "Pants", 99713, 6, 67687, 28 },
                    { 305, 94903, "Shoes", 52695, 3, 1658, 28 },
                    { 400, 79203, "Fish", 53108, 1, 43736, 28 },
                    { 555, 23288, "Computer", 66414, 4, 84053, 28 },
                    { 663, 3439, "Mouse", 33407, 9, 48714, 28 },
                    { 679, 84825, "Chicken", 12671, 5, 8773, 28 },
                    { 837, 86789, "Fish", 67090, 10, 59406, 28 },
                    { 842, 56594, "Bacon", 83756, 1, 25157, 28 },
                    { 846, 22603, "Bike", 17103, 2, 21731, 28 },
                    { 926, 81172, "Hat", 641, 9, 53600, 28 },
                    { 957, 55985, "Pizza", 28903, 3, 79264, 28 },
                    { 962, 11453, "Hat", 98121, 3, 1896, 28 },
                    { 968, 57036, "Keyboard", 50854, 7, 3513, 28 },
                    { 77, 87440, "Fish", 52227, 3, 57481, 29 },
                    { 267, 19358, "Car", 63869, 5, 28685, 28 },
                    { 443, 74712, "Sausages", 83495, 7, 35606, 100 },
                    { 653, 3797, "Chicken", 39630, 6, 61125, 31 },
                    { 809, 91055, "Mouse", 36435, 5, 18275, 31 },
                    { 650, 81216, "Shoes", 51929, 4, 61621, 35 },
                    { 659, 21728, "Ball", 1686, 1, 44165, 35 },
                    { 660, 43238, "Ball", 62048, 2, 8937, 35 },
                    { 756, 99817, "Shirt", 28965, 1, 44546, 35 },
                    { 162, 30052, "Computer", 36930, 9, 66471, 36 },
                    { 169, 83451, "Bacon", 72625, 1, 39235, 36 },
                    { 178, 16210, "Chair", 40237, 4, 49645, 36 },
                    { 201, 72706, "Pants", 64283, 8, 21103, 36 },
                    { 298, 97207, "Salad", 52436, 8, 27554, 36 },
                    { 311, 79639, "Computer", 40592, 4, 51369, 36 },
                    { 421, 13171, "Mouse", 37949, 8, 96702, 36 },
                    { 508, 53351, "Chips", 41799, 5, 71511, 36 },
                    { 639, 34338, "Tuna", 97525, 1, 61976, 36 },
                    { 644, 23216, "Salad", 94772, 6, 37349, 36 },
                    { 759, 79192, "Gloves", 81764, 2, 41756, 36 },
                    { 763, 97449, "Car", 94833, 3, 6164, 36 },
                    { 831, 5725, "Chair", 23769, 7, 57664, 36 },
                    { 844, 35652, "Chips", 25920, 9, 87523, 36 },
                    { 4, 29063, "Shoes", 92926, 4, 18278, 37 },
                    { 67, 40804, "Keyboard", 74271, 5, 74526, 37 },
                    { 89, 79378, "Soap", 10317, 9, 38989, 37 },
                    { 116, 87068, "Sausages", 63545, 7, 76810, 37 },
                    { 207, 28735, "Bacon", 91664, 7, 86326, 37 },
                    { 274, 11534, "Bike", 35893, 9, 7304, 37 },
                    { 501, 83693, "Pizza", 55246, 9, 21447, 37 },
                    { 524, 94964, "Keyboard", 1209, 8, 56179, 37 },
                    { 546, 76876, "Computer", 97353, 4, 21277, 37 },
                    { 641, 886, "Pizza", 16240, 4, 5226, 35 },
                    { 633, 68744, "Keyboard", 64497, 9, 29678, 35 },
                    { 631, 62383, "Pants", 45502, 10, 37364, 35 },
                    { 601, 2137, "Keyboard", 84004, 8, 27850, 35 },
                    { 972, 25064, "Keyboard", 14988, 2, 18930, 31 },
                    { 33, 77429, "Salad", 71284, 4, 57783, 32 },
                    { 181, 41329, "Soap", 52765, 10, 20147, 32 },
                    { 304, 81541, "Shirt", 13761, 9, 47669, 32 },
                    { 732, 11797, "Shirt", 61300, 7, 17667, 32 },
                    { 752, 30881, "Bacon", 14217, 1, 70727, 32 },
                    { 934, 38260, "Pants", 15421, 9, 57184, 32 },
                    { 974, 26773, "Gloves", 98590, 2, 18020, 32 },
                    { 204, 15701, "Bike", 10418, 2, 29725, 33 },
                    { 500, 24921, "Car", 77722, 6, 75639, 33 },
                    { 709, 99719, "Chicken", 61957, 6, 60580, 33 },
                    { 924, 36925, "Bike", 84612, 4, 41113, 33 },
                    { 970, 25232, "Fish", 80062, 2, 8862, 33 },
                    { 790, 86196, "Computer", 30310, 7, 73552, 31 },
                    { 56, 63697, "Towels", 65250, 1, 24533, 34 },
                    { 219, 42545, "Pants", 89360, 2, 71143, 34 },
                    { 292, 36586, "Chair", 87236, 5, 43715, 34 },
                    { 337, 75429, "Bacon", 90545, 3, 42602, 34 },
                    { 612, 92584, "Keyboard", 12793, 6, 93722, 34 },
                    { 770, 43283, "Ball", 56575, 3, 98271, 34 },
                    { 888, 64323, "Cheese", 50025, 4, 37023, 34 },
                    { 892, 89145, "Keyboard", 95983, 6, 85999, 34 },
                    { 912, 28889, "Towels", 10086, 4, 62930, 34 },
                    { 920, 4764, "Keyboard", 55224, 3, 82263, 34 },
                    { 940, 54501, "Ball", 56797, 8, 50724, 34 },
                    { 232, 47832, "Chips", 13351, 8, 73023, 35 },
                    { 314, 68070, "Pizza", 69357, 4, 29449, 35 },
                    { 387, 22389, "Mouse", 39951, 6, 93996, 35 },
                    { 60, 71230, "Pizza", 87008, 1, 43159, 34 },
                    { 984, 57062, "Mouse", 71271, 7, 97021, 100 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_UnitTypeId",
                table: "Products",
                column: "UnitTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_VendorId",
                table: "Products",
                column: "VendorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Vendors_VendorId",
                table: "Products",
                column: "VendorId",
                principalTable: "Vendors",
                principalColumn: "VendorId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Vendors_VendorId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_UnitTypeId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_VendorId",
                table: "Products");

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
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 499);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 504);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 505);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 506);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 507);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 508);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 509);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 510);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 511);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 512);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 513);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 514);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 515);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 516);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 517);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 518);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 519);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 520);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 521);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 522);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 523);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 524);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 525);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 526);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 527);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 528);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 529);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 530);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 531);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 532);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 533);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 534);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 535);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 536);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 537);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 538);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 539);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 540);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 541);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 542);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 543);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 544);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 545);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 546);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 547);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 548);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 549);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 550);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 551);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 552);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 553);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 554);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 555);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 556);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 557);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 558);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 559);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 560);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 561);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 562);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 563);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 564);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 565);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 566);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 567);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 568);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 569);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 570);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 571);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 572);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 573);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 574);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 575);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 576);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 577);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 578);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 579);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 580);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 581);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 582);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 583);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 584);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 585);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 586);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 587);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 588);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 589);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 590);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 591);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 592);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 593);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 594);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 595);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 596);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 597);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 598);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 599);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 600);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 601);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 602);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 603);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 604);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 605);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 606);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 607);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 608);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 609);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 610);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 611);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 612);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 613);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 614);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 615);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 616);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 617);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 618);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 619);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 620);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 621);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 622);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 623);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 624);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 625);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 626);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 627);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 628);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 629);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 630);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 631);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 632);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 633);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 634);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 635);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 636);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 637);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 638);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 639);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 640);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 641);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 642);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 643);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 644);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 645);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 646);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 647);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 648);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 649);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 650);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 651);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 652);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 653);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 654);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 655);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 656);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 657);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 658);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 659);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 660);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 661);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 662);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 663);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 664);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 665);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 666);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 667);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 668);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 669);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 670);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 671);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 672);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 673);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 674);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 675);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 676);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 677);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 678);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 679);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 680);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 681);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 682);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 683);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 684);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 685);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 686);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 687);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 688);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 689);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 690);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 691);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 692);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 693);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 694);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 695);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 696);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 697);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 698);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 699);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 700);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 701);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 702);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 703);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 704);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 705);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 706);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 707);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 708);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 709);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 710);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 711);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 712);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 713);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 714);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 715);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 716);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 717);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 718);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 719);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 720);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 721);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 722);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 723);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 724);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 725);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 726);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 727);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 728);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 729);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 730);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 731);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 732);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 733);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 734);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 735);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 736);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 737);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 738);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 739);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 740);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 741);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 742);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 743);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 744);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 745);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 746);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 747);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 748);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 749);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 750);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 751);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 752);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 753);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 754);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 755);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 756);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 757);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 758);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 759);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 760);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 761);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 762);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 763);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 764);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 765);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 766);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 767);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 768);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 769);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 770);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 771);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 772);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 773);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 774);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 775);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 776);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 777);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 778);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 779);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 780);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 781);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 782);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 783);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 784);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 785);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 786);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 787);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 788);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 789);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 790);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 791);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 792);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 793);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 794);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 795);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 796);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 797);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 798);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 799);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 800);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 801);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 802);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 803);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 804);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 805);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 806);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 807);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 808);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 809);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 810);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 811);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 812);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 813);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 814);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 815);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 816);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 817);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 818);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 819);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 820);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 821);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 822);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 823);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 824);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 825);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 826);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 827);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 828);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 829);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 830);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 831);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 832);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 833);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 834);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 835);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 836);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 837);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 838);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 839);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 840);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 841);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 842);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 843);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 844);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 845);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 846);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 847);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 848);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 849);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 850);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 851);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 852);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 853);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 854);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 855);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 856);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 857);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 858);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 859);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 860);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 861);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 862);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 863);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 864);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 865);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 866);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 867);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 868);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 869);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 870);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 871);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 872);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 873);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 874);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 875);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 876);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 877);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 878);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 879);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 880);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 881);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 882);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 883);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 884);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 885);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 886);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 887);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 888);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 889);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 890);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 891);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 892);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 893);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 894);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 895);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 896);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 897);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 898);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 899);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 900);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 901);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 902);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 903);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 904);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 905);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 906);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 907);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 908);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 909);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 910);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 911);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 912);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 913);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 914);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 915);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 916);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 917);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 918);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 919);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 920);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 921);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 922);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 923);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 924);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 925);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 926);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 927);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 928);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 929);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 930);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 931);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 932);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 933);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 934);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 935);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 936);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 937);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 938);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 939);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 940);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 941);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 942);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 943);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 944);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 945);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 946);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 947);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 948);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 949);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 950);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 951);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 952);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 953);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 954);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 955);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 956);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 957);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 958);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 959);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 960);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 961);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 962);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 963);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 964);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 965);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 966);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 967);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 968);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 969);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 970);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 971);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 972);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 973);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 974);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 975);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 976);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 977);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 978);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 979);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 980);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 981);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 982);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 983);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 984);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 985);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 986);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 987);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 988);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 989);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 990);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 991);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 992);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 993);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 994);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 995);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 996);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 997);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 998);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 999);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1000);

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
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 200);

            migrationBuilder.DropColumn(
                name: "VendorId",
                table: "Products");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "UnitTypes",
                type: "character varying(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(60)",
                oldMaxLength: 60);

            migrationBuilder.CreateIndex(
                name: "IX_Products_UnitTypeId",
                table: "Products",
                column: "UnitTypeId",
                unique: true);
        }
    }
}
