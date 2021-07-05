using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GestionEtudiants.Migrations
{
    public partial class ff : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "departements",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nom = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_departements", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Etat",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    etat = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Etat", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Filieres",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    departementId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filieres", x => x.id);
                    table.ForeignKey(
                        name: "FK_Filieres_departements_departementId",
                        column: x => x.departementId,
                        principalTable: "departements",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Professeurs",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    prenom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    login = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    departementId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professeurs", x => x.id);
                    table.ForeignKey(
                        name: "FK_Professeurs_departements_departementId",
                        column: x => x.departementId,
                        principalTable: "departements",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "classes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    filiereId = table.Column<int>(type: "int", nullable: false),
                    annee = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_classes", x => x.id);
                    table.ForeignKey(
                        name: "FK_classes_Filieres_filiereId",
                        column: x => x.filiereId,
                        principalTable: "Filieres",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Etudiants",
                columns: table => new
                {
                    apogee = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cne = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    firstname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lastname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ddn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ldn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    natio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    annee = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    classeId = table.Column<int>(type: "int", nullable: false),
                    picture = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sexe = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Etudiants", x => x.apogee);
                    table.ForeignKey(
                        name: "FK_Etudiants_classes_classeId",
                        column: x => x.classeId,
                        principalTable: "classes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Modules",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    classeId = table.Column<int>(type: "int", nullable: false),
                    professeurId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modules", x => x.id);
                    table.ForeignKey(
                        name: "FK_Modules_classes_classeId",
                        column: x => x.classeId,
                        principalTable: "classes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Modules_Professeurs_professeurId",
                        column: x => x.professeurId,
                        principalTable: "Professeurs",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Documents",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    date_demande = table.Column<DateTime>(type: "datetime2", nullable: false),
                    id_etudiant = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documents", x => x.id);
                    table.ForeignKey(
                        name: "FK_Documents_Etudiants_id_etudiant",
                        column: x => x.id_etudiant,
                        principalTable: "Etudiants",
                        principalColumn: "apogee",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Notes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NotePdfUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    semestre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    moduleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notes", x => x.id);
                    table.ForeignKey(
                        name: "FK_Notes_Modules_moduleId",
                        column: x => x.moduleId,
                        principalTable: "Modules",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Etat",
                columns: new[] { "Id", "etat" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 1 },
                    { 4, 1 }
                });

            migrationBuilder.InsertData(
                table: "departements",
                columns: new[] { "id", "nom" },
                values: new object[,]
                {
                    { 1, "Informatique" },
                    { 2, "Industrielle" }
                });

            migrationBuilder.InsertData(
                table: "Filieres",
                columns: new[] { "id", "departementId", "nom" },
                values: new object[,]
                {
                    { 1, 1, "GINFO" },
                    { 4, 2, "GINDUS" },
                    { 3, 2, "GPMC" },
                    { 2, 1, "GTR" }
                });

            migrationBuilder.InsertData(
                table: "Professeurs",
                columns: new[] { "id", "departementId", "email", "login", "nom", "password", "prenom" },
                values: new object[,]
                {
                    { 22, 2, "Leslie_Feeney18@hotmail.com", "metrics", "Feeney", "0000", "Leslie" },
                    { 16, 2, "Lindsey.Carroll80@hotmail.com", "Kroon", "Carroll", "0000", "Lindsey" },
                    { 15, 2, "Jan98@gmail.com", "Small Frozen Shirt", "Abshire", "0000", "Jan" },
                    { 14, 2, "Josh18@gmail.com", "override", "Zieme", "0000", "Josh" },
                    { 13, 2, "Jamie98@hotmail.com", "Technician", "Bernhard", "0000", "Jamie" },
                    { 12, 2, "May_Emard88@gmail.com", "Inverse", "Emard", "0000", "May" },
                    { 7, 2, "Camille_Grant@yahoo.com", "sky blue", "Grant", "0000", "Camille" },
                    { 6, 2, "Sandy.Legros55@hotmail.com", "Mountains", "Legros", "0000", "Sandy" },
                    { 4, 2, "Shelia_Ziemann@gmail.com", "Division", "Ziemann", "0000", "Shelia" },
                    { 3, 2, "Marcia.Spinka64@gmail.com", "Maine", "Spinka", "0000", "Marcia" },
                    { 1, 2, "Diana_Lynch@gmail.com", "synthesizing", "Lynch", "0000", "Diana" },
                    { 5, 1, "Irving_Corkery81@hotmail.com", "mission-critical", "Corkery", "0000", "Irving" },
                    { 23, 2, "Fannie.Bartoletti@yahoo.com", "full-range", "Bartoletti", "0000", "Fannie" },
                    { 24, 1, "Charles.Abernathy86@gmail.com", "Intelligent", "Abernathy", "0000", "Charles" },
                    { 21, 1, "Dexter.Trantow20@hotmail.com", "sky blue", "Trantow", "0000", "Dexter" },
                    { 20, 1, "Edwin.Carter@hotmail.com", "Iran", "Carter", "0000", "Edwin" },
                    { 19, 1, "Bennie_Steuber47@gmail.com", "Uzbekistan Sum", "Steuber", "0000", "Bennie" },
                    { 18, 1, "Ernest.Sipes85@yahoo.com", "Human", "Sipes", "0000", "Ernest" },
                    { 17, 1, "Darrel_Cremin42@gmail.com", "emulation", "Cremin", "0000", "Darrel" },
                    { 11, 1, "Adam91@yahoo.com", "solutions", "Christiansen", "0000", "Adam" },
                    { 10, 1, "Muriel5@yahoo.com", "European Unit of Account 17(E.U.A.-17)", "Wehner", "0000", "Muriel" },
                    { 9, 1, "Kenneth_Reichert54@gmail.com", "index", "Reichert", "0000", "Kenneth" },
                    { 8, 1, "Joan80@gmail.com", "Fantastic Granite Bike", "Reilly", "0000", "Joan" },
                    { 2, 1, "Charlotte_Anderson86@hotmail.com", "Clothing & Music", "Anderson", "0000", "Charlotte" },
                    { 25, 2, "Sophie_Keeling2@hotmail.com", "Congolese Franc", "Keeling", "0000", "Sophie" }
                });

            migrationBuilder.InsertData(
                table: "classes",
                columns: new[] { "id", "annee", "filiereId" },
                values: new object[,]
                {
                    { 4, 2021, 1 },
                    { 3, 2021, 2 },
                    { 2, 2021, 3 },
                    { 1, 2021, 4 }
                });

            migrationBuilder.InsertData(
                table: "Etudiants",
                columns: new[] { "apogee", "address", "annee", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "ldn", "natio", "password", "phone", "picture", "sexe" },
                values: new object[,]
                {
                    { 2000, "Trantowmouth", "2021", "EE22858", 4, "G153757", new DateTime(1978, 10, 14, 0, 0, 0, 0, DateTimeKind.Local), "Alberta.Casper@gmail.com", "Alberta", "Casper", null, "Macedonia", "0000", "633-707-3077 x93852", null, "Female" },
                    { 2369, "Wolfhaven", "2021", "EE15152", 2, "G255530", new DateTime(1957, 6, 23, 0, 0, 0, 0, DateTimeKind.Local), "Lee91@yahoo.com", "Lee", "Kuphal", null, "Solomon Islands", "0000", "297-960-8167 x02958", null, "Female" },
                    { 2364, "North Austynberg", "2021", "EE55030", 2, "G188719", new DateTime(1972, 5, 26, 0, 0, 0, 0, DateTimeKind.Local), "Gilberto_Parker@yahoo.com", "Gilberto", "Parker", null, "Cambodia", "0000", "1-573-778-8959 x98125", null, "Male" },
                    { 2363, "New Jovannyville", "2021", "EE16929", 2, "G166809", new DateTime(1972, 12, 1, 0, 0, 0, 0, DateTimeKind.Local), "Kristen84@yahoo.com", "Kristen", "Volkman", null, "Gibraltar", "0000", "1-221-981-9266 x595", null, "Female" },
                    { 2359, "Daishamouth", "2021", "EE30463", 2, "G483447", new DateTime(1997, 12, 22, 0, 0, 0, 0, DateTimeKind.Local), "Alma.Harber@yahoo.com", "Alma", "Harber", null, "Poland", "0000", "833.961.2197 x0563", null, "Female" },
                    { 2353, "East Alessandrastad", "2021", "EE4082", 2, "G196379", new DateTime(1954, 2, 20, 0, 0, 0, 0, DateTimeKind.Local), "Tabitha_Marvin@yahoo.com", "Tabitha", "Marvin", null, "Bahrain", "0000", "(561) 861-4783 x90890", null, "Female" },
                    { 2347, "East Lucindabury", "2021", "EE17383", 2, "G175126", new DateTime(1984, 8, 2, 0, 0, 0, 0, DateTimeKind.Local), "Curtis.Farrell50@yahoo.com", "Curtis", "Farrell", null, "Singapore", "0000", "(964) 247-9518 x4840", null, "Male" },
                    { 2340, "Jarredhaven", "2021", "EE39215", 2, "G588197", new DateTime(1987, 11, 16, 0, 0, 0, 0, DateTimeKind.Local), "Toni_Kihn@hotmail.com", "Toni", "Kihn", null, "Vietnam", "0000", "1-569-644-1823 x090", null, "Female" },
                    { 2329, "Kreigerton", "2021", "EE35045", 2, "G537955", new DateTime(1966, 2, 23, 0, 0, 0, 0, DateTimeKind.Local), "Claude.Kuphal@yahoo.com", "Claude", "Kuphal", null, "Palau", "0000", "1-283-434-1092", null, "Male" },
                    { 2328, "New Kylieport", "2021", "EE39361", 2, "G83889", new DateTime(1978, 11, 12, 0, 0, 0, 0, DateTimeKind.Local), "Doreen_Morar@yahoo.com", "Doreen", "Morar", null, "Georgia", "0000", "781-414-3577", null, "Female" },
                    { 2322, "Lake Cliftonfurt", "2021", "EE6544", 2, "G475236", new DateTime(1991, 6, 14, 0, 0, 0, 0, DateTimeKind.Local), "Christy_Hickle80@hotmail.com", "Christy", "Hickle", null, "Mali", "0000", "878.662.8809 x0957", null, "Female" },
                    { 2316, "North Ashlynnborough", "2021", "EE28820", 2, "G59627", new DateTime(1965, 1, 18, 0, 0, 0, 0, DateTimeKind.Local), "Hector84@yahoo.com", "Hector", "MacGyver", null, "South Georgia and the South Sandwich Islands", "0000", "1-432-348-1022 x825", null, "Male" },
                    { 2309, "West Kenny", "2021", "EE38704", 2, "G38959", new DateTime(1974, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), "Kayla_Considine4@hotmail.com", "Kayla", "Considine", null, "Greenland", "0000", "749.470.9543", null, "Female" },
                    { 2303, "Leopoldland", "2021", "EE54996", 2, "G578912", new DateTime(1992, 6, 12, 0, 0, 0, 0, DateTimeKind.Local), "Chris.Heaney@gmail.com", "Chris", "Heaney", null, "Myanmar", "0000", "1-922-232-9352", null, "Male" },
                    { 2301, "Torphychester", "2021", "EE38562", 2, "G132976", new DateTime(1959, 6, 15, 0, 0, 0, 0, DateTimeKind.Local), "Edmond.Connelly@yahoo.com", "Edmond", "Connelly", null, "Cuba", "0000", "1-491-213-1272 x8071", null, "Male" },
                    { 2296, "Frederikberg", "2021", "EE28247", 2, "G422512", new DateTime(1953, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), "Pauline.Sipes@hotmail.com", "Pauline", "Sipes", null, "China", "0000", "403-295-7434", null, "Female" },
                    { 2289, "West Korey", "2021", "EE59518", 2, "G323638", new DateTime(1966, 1, 10, 0, 0, 0, 0, DateTimeKind.Local), "Lorena.King@yahoo.com", "Lorena", "King", null, "Sao Tome and Principe", "0000", "1-238-854-6840", null, "Female" },
                    { 2281, "Abbottstad", "2021", "EE44315", 2, "G173676", new DateTime(1978, 12, 29, 0, 0, 0, 0, DateTimeKind.Local), "Cora_Pacocha61@yahoo.com", "Cora", "Pacocha", null, "San Marino", "0000", "387.538.4455 x35141", null, "Female" },
                    { 2279, "Jacobsborough", "2021", "EE16943", 2, "G420587", new DateTime(1951, 10, 2, 0, 0, 0, 0, DateTimeKind.Local), "Douglas_Carter72@yahoo.com", "Douglas", "Carter", null, "Nicaragua", "0000", "612-549-9748 x00665", null, "Male" },
                    { 2275, "South Mark", "2021", "EE585", 2, "G400455", new DateTime(1961, 7, 2, 0, 0, 0, 0, DateTimeKind.Local), "Sidney92@yahoo.com", "Sidney", "Hoppe", null, "Cayman Islands", "0000", "(535) 769-8075", null, "Male" },
                    { 2271, "South John", "2021", "EE8454", 2, "G197792", new DateTime(1987, 6, 4, 0, 0, 0, 0, DateTimeKind.Local), "Ignacio_Romaguera@gmail.com", "Ignacio", "Romaguera", null, "Australia", "0000", "765-912-9052", null, "Male" },
                    { 2270, "New Hectorfurt", "2021", "EE20816", 2, "G359872", new DateTime(1990, 1, 8, 0, 0, 0, 0, DateTimeKind.Local), "Jenny_Glover31@gmail.com", "Jenny", "Glover", null, "Chile", "0000", "706-274-4895 x0316", null, "Female" },
                    { 2262, "East Jazmin", "2021", "EE45264", 2, "G538237", new DateTime(1997, 3, 5, 0, 0, 0, 0, DateTimeKind.Local), "Marian89@hotmail.com", "Marian", "Hayes", null, "Seychelles", "0000", "(816) 696-1565", null, "Female" },
                    { 2260, "Port Elwinberg", "2021", "EE53833", 2, "G111929", new DateTime(1991, 7, 1, 0, 0, 0, 0, DateTimeKind.Local), "Ebony.Ward@gmail.com", "Ebony", "Ward", null, "Gibraltar", "0000", "1-584-857-5910 x39338", null, "Female" },
                    { 2254, "Dachland", "2021", "EE32045", 2, "G57761", new DateTime(1996, 5, 21, 0, 0, 0, 0, DateTimeKind.Local), "Bonnie86@hotmail.com", "Bonnie", "Simonis", null, "Morocco", "0000", "(714) 519-5543 x598", null, "Female" },
                    { 2250, "North Lauraton", "2021", "EE27307", 2, "G156277", new DateTime(1961, 3, 10, 0, 0, 0, 0, DateTimeKind.Local), "Krystal_Swift@hotmail.com", "Krystal", "Swift", null, "Greece", "0000", "(236) 350-7242 x7216", null, "Female" },
                    { 2246, "Kesslerport", "2021", "EE25095", 2, "G152460", new DateTime(1988, 4, 28, 0, 0, 0, 0, DateTimeKind.Local), "Leslie_Larson73@yahoo.com", "Leslie", "Larson", null, "Nepal", "0000", "1-713-565-3965", null, "Female" },
                    { 2245, "Roycestad", "2021", "EE9660", 2, "G441228", new DateTime(1962, 11, 25, 0, 0, 0, 0, DateTimeKind.Local), "Nicolas_Swift@yahoo.com", "Nicolas", "Swift", null, "Gibraltar", "0000", "835.622.5882", null, "Male" },
                    { 2377, "Melbaville", "2021", "EE15572", 2, "G380206", new DateTime(1960, 6, 20, 0, 0, 0, 0, DateTimeKind.Local), "Irma.Rice@gmail.com", "Irma", "Rice", null, "Isle of Man", "0000", "(274) 714-1550 x757", null, "Female" },
                    { 2378, "North Micaela", "2021", "EE25092", 2, "G145448", new DateTime(2000, 2, 24, 0, 0, 0, 0, DateTimeKind.Local), "Victoria_Labadie95@yahoo.com", "Victoria", "Labadie", null, "Indonesia", "0000", "958-872-3228 x5727", null, "Female" },
                    { 2380, "West Kristinshire", "2021", "EE19625", 2, "G468739", new DateTime(1998, 10, 19, 0, 0, 0, 0, DateTimeKind.Local), "Brenda_Stroman69@yahoo.com", "Brenda", "Stroman", null, "Palau", "0000", "1-787-691-1879 x3361", null, "Female" },
                    { 2389, "Holliemouth", "2021", "EE11597", 2, "G447450", new DateTime(1991, 3, 3, 0, 0, 0, 0, DateTimeKind.Local), "Jay.Swaniawski@yahoo.com", "Jay", "Swaniawski", null, "Fiji", "0000", "630-806-0900 x13042", null, "Male" },
                    { 2498, "Pfefferhaven", "2021", "EE11372", 2, "G249735", new DateTime(1978, 4, 22, 0, 0, 0, 0, DateTimeKind.Local), "Jodi43@yahoo.com", "Jodi", "Cormier", null, "Tunisia", "0000", "1-747-820-3725 x187", null, "Female" },
                    { 2495, "Lake Heavenfort", "2021", "EE24835", 2, "G420078", new DateTime(1984, 10, 13, 0, 0, 0, 0, DateTimeKind.Local), "Curtis55@hotmail.com", "Curtis", "Gorczany", null, "Rwanda", "0000", "(580) 652-9472 x19913", null, "Male" },
                    { 2494, "Port Ambrosechester", "2021", "EE59607", 2, "G445073", new DateTime(1958, 11, 4, 0, 0, 0, 0, DateTimeKind.Local), "Courtney_Hane70@gmail.com", "Courtney", "Hane", null, "Nauru", "0000", "1-825-976-8812 x91858", null, "Female" },
                    { 2492, "Lake Sarinaside", "2021", "EE5305", 2, "G355087", new DateTime(1963, 4, 6, 0, 0, 0, 0, DateTimeKind.Local), "Sarah69@gmail.com", "Sarah", "Herzog", null, "Burundi", "0000", "1-754-841-8452 x2642", null, "Female" },
                    { 2491, "Gleichnerburgh", "2021", "EE55782", 2, "G99138", new DateTime(1972, 9, 21, 0, 0, 0, 0, DateTimeKind.Local), "Nadine_Aufderhar@gmail.com", "Nadine", "Aufderhar", null, "Latvia", "0000", "1-964-423-0546", null, "Female" },
                    { 2483, "Jonasfurt", "2021", "EE58547", 2, "G215308", new DateTime(1989, 11, 6, 0, 0, 0, 0, DateTimeKind.Local), "Pamela.Watsica@yahoo.com", "Pamela", "Watsica", null, "China", "0000", "810-613-3467 x6238", null, "Female" },
                    { 2473, "South Fidelfort", "2021", "EE13641", 2, "G391559", new DateTime(1959, 6, 24, 0, 0, 0, 0, DateTimeKind.Local), "Walter_Johns@hotmail.com", "Walter", "Johns", null, "Liechtenstein", "0000", "899-491-7638 x7421", null, "Male" },
                    { 2468, "New Rebekah", "2021", "EE37423", 2, "G222619", new DateTime(1989, 6, 16, 0, 0, 0, 0, DateTimeKind.Local), "Cameron.Becker57@hotmail.com", "Cameron", "Becker", null, "Saint Martin", "0000", "1-669-520-6342", null, "Male" },
                    { 2463, "Swiftside", "2021", "EE24963", 2, "G160561", new DateTime(1963, 10, 23, 0, 0, 0, 0, DateTimeKind.Local), "Greg_Keebler@gmail.com", "Greg", "Keebler", null, "Sierra Leone", "0000", "1-565-407-8932 x7086", null, "Male" },
                    { 2457, "Tessview", "2021", "EE34120", 2, "G391706", new DateTime(1956, 2, 8, 0, 0, 0, 0, DateTimeKind.Local), "Faye.DAmore20@gmail.com", "Faye", "D'Amore", null, "British Indian Ocean Territory (Chagos Archipelago)", "0000", "581.991.3296", null, "Female" }
                });

            migrationBuilder.InsertData(
                table: "Etudiants",
                columns: new[] { "apogee", "address", "annee", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "ldn", "natio", "password", "phone", "picture", "sexe" },
                values: new object[,]
                {
                    { 2454, "North Clementine", "2021", "EE38186", 2, "G186933", new DateTime(1984, 5, 3, 0, 0, 0, 0, DateTimeKind.Local), "Andrew.Carter76@gmail.com", "Andrew", "Carter", null, "Lesotho", "0000", "513-977-7128", null, "Male" },
                    { 2453, "East Jettview", "2021", "EE16739", 2, "G197552", new DateTime(1970, 2, 22, 0, 0, 0, 0, DateTimeKind.Local), "Jake20@gmail.com", "Jake", "Gaylord", null, "Democratic People's Republic of Korea", "0000", "(423) 779-9642 x92633", null, "Male" },
                    { 2446, "New Brionnaside", "2021", "EE36004", 2, "G509511", new DateTime(1968, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), "Marie.Dooley60@yahoo.com", "Marie", "Dooley", null, "Christmas Island", "0000", "1-211-867-6344 x98141", null, "Female" },
                    { 2244, "Malindastad", "2021", "EE7666", 2, "G219404", new DateTime(1998, 12, 1, 0, 0, 0, 0, DateTimeKind.Local), "Shelia89@gmail.com", "Shelia", "Weber", null, "Slovenia", "0000", "(319) 340-1468 x3538", null, "Female" },
                    { 2441, "Carterfort", "2021", "EE53860", 2, "G80784", new DateTime(1992, 10, 1, 0, 0, 0, 0, DateTimeKind.Local), "Mario85@hotmail.com", "Mario", "Von", null, "Belize", "0000", "1-359-225-5911 x869", null, "Male" },
                    { 2430, "South Susannaburgh", "2021", "EE22125", 2, "G292662", new DateTime(1972, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), "Ashley.Hammes@hotmail.com", "Ashley", "Hammes", null, "Austria", "0000", "509.593.4812 x3469", null, "Female" },
                    { 2429, "Angelineville", "2021", "EE18929", 2, "G390992", new DateTime(1973, 8, 1, 0, 0, 0, 0, DateTimeKind.Local), "Fannie_Brakus93@hotmail.com", "Fannie", "Brakus", null, "Haiti", "0000", "245.290.7633 x4001", null, "Female" },
                    { 2427, "West Stantonland", "2021", "EE2830", 2, "G88500", new DateTime(1973, 10, 7, 0, 0, 0, 0, DateTimeKind.Local), "Phillip.Price@hotmail.com", "Phillip", "Price", null, "Slovakia (Slovak Republic)", "0000", "1-463-596-6541", null, "Male" },
                    { 2424, "Zoiechester", "2021", "EE10668", 2, "G505265", new DateTime(1996, 7, 2, 0, 0, 0, 0, DateTimeKind.Local), "Abraham_Weissnat49@gmail.com", "Abraham", "Weissnat", null, "Australia", "0000", "465-235-2353", null, "Male" },
                    { 2422, "West Daren", "2021", "EE42363", 2, "G89131", new DateTime(1972, 10, 3, 0, 0, 0, 0, DateTimeKind.Local), "Laurie_Lemke20@hotmail.com", "Laurie", "Lemke", null, "Ukraine", "0000", "(660) 992-3784 x259", null, "Female" },
                    { 2420, "East Santiago", "2021", "EE23781", 2, "G116867", new DateTime(1995, 10, 24, 0, 0, 0, 0, DateTimeKind.Local), "Julio.Koepp@gmail.com", "Julio", "Koepp", null, "Belgium", "0000", "817.569.5218 x5054", null, "Male" },
                    { 2415, "Vidahaven", "2021", "EE41607", 2, "G502762", new DateTime(1998, 1, 2, 0, 0, 0, 0, DateTimeKind.Local), "Garry66@hotmail.com", "Garry", "Stiedemann", null, "Hungary", "0000", "458.453.7485 x404", null, "Male" },
                    { 2414, "West Madonna", "2021", "EE49968", 2, "G280385", new DateTime(1956, 3, 11, 0, 0, 0, 0, DateTimeKind.Local), "Tami.OKeefe@gmail.com", "Tami", "O'Keefe", null, "Canada", "0000", "(970) 498-2931", null, "Female" },
                    { 2411, "Godfreybury", "2021", "EE15664", 2, "G176235", new DateTime(1989, 4, 9, 0, 0, 0, 0, DateTimeKind.Local), "Dewey82@yahoo.com", "Dewey", "Greenholt", null, "Poland", "0000", "890.256.8337", null, "Male" },
                    { 2410, "Hettingerburgh", "2021", "EE51613", 2, "G121614", new DateTime(1957, 11, 14, 0, 0, 0, 0, DateTimeKind.Local), "Amy7@hotmail.com", "Amy", "Mann", null, "Pakistan", "0000", "(547) 683-9502 x7980", null, "Female" },
                    { 2407, "North Jazminchester", "2021", "EE45534", 2, "G70714", new DateTime(1965, 6, 5, 0, 0, 0, 0, DateTimeKind.Local), "Rufus.Moen34@yahoo.com", "Rufus", "Moen", null, "Botswana", "0000", "1-520-638-9914 x105", null, "Male" },
                    { 2403, "North Macborough", "2021", "EE11033", 2, "G10392", new DateTime(1995, 8, 20, 0, 0, 0, 0, DateTimeKind.Local), "Harvey_Okuneva@yahoo.com", "Harvey", "Okuneva", null, "Iran", "0000", "865.294.5612", null, "Male" },
                    { 2398, "Cronaville", "2021", "EE5844", 2, "G357632", new DateTime(1982, 7, 16, 0, 0, 0, 0, DateTimeKind.Local), "Ismael.Stokes@hotmail.com", "Ismael", "Stokes", null, "Isle of Man", "0000", "1-860-801-3077 x88107", null, "Male" },
                    { 2435, "Lake Pamela", "2021", "EE4167", 2, "G514806", new DateTime(1966, 5, 26, 0, 0, 0, 0, DateTimeKind.Local), "Lowell88@gmail.com", "Lowell", "Ziemann", null, "Malawi", "0000", "(980) 864-1502 x02884", null, "Male" },
                    { 2242, "West Nicklausberg", "2021", "EE19481", 2, "G100154", new DateTime(1994, 1, 20, 0, 0, 0, 0, DateTimeKind.Local), "Carrie52@gmail.com", "Carrie", "Lesch", null, "Belarus", "0000", "(508) 700-0761 x757", null, "Female" },
                    { 2239, "South Domenicabury", "2021", "EE43760", 2, "G209017", new DateTime(1954, 6, 23, 0, 0, 0, 0, DateTimeKind.Local), "Tamara_Zulauf26@yahoo.com", "Tamara", "Zulauf", null, "Libyan Arab Jamahiriya", "0000", "1-212-884-4497 x922", null, "Female" },
                    { 2238, "Bartolettihaven", "2021", "EE5801", 2, "G507238", new DateTime(1995, 4, 19, 0, 0, 0, 0, DateTimeKind.Local), "Kathleen_Pacocha14@hotmail.com", "Kathleen", "Pacocha", null, "Thailand", "0000", "547-691-0400", null, "Female" },
                    { 2107, "North Alek", "2021", "EE31604", 2, "G368278", new DateTime(1952, 2, 15, 0, 0, 0, 0, DateTimeKind.Local), "Esther.Gleason0@yahoo.com", "Esther", "Gleason", null, "Niger", "0000", "747.466.2089", null, "Female" },
                    { 2099, "Jorgeland", "2021", "EE1612", 2, "G83738", new DateTime(1952, 12, 10, 0, 0, 0, 0, DateTimeKind.Local), "Sheila.Beatty@hotmail.com", "Sheila", "Beatty", null, "Morocco", "0000", "247.468.1639", null, "Female" },
                    { 2082, "Port Gertrude", "2021", "EE58467", 2, "G192915", new DateTime(1970, 1, 14, 0, 0, 0, 0, DateTimeKind.Local), "Laurence_Gleason61@yahoo.com", "Laurence", "Gleason", null, "San Marino", "0000", "1-983-604-8621 x744", null, "Male" },
                    { 2078, "Hilllville", "2021", "EE34890", 2, "G434796", new DateTime(1970, 5, 6, 0, 0, 0, 0, DateTimeKind.Local), "Gustavo_Lemke@yahoo.com", "Gustavo", "Lemke", null, "Holy See (Vatican City State)", "0000", "(817) 354-9157 x0682", null, "Male" },
                    { 2063, "Gaylordbury", "2021", "EE39317", 2, "G196074", new DateTime(1955, 9, 26, 0, 0, 0, 0, DateTimeKind.Local), "Jeannie.Bogan@yahoo.com", "Jeannie", "Bogan", null, "Taiwan", "0000", "634-424-1629 x209", null, "Female" },
                    { 2062, "East Jarrellshire", "2021", "EE34591", 2, "G292762", new DateTime(1957, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), "Henry_Walsh25@hotmail.com", "Henry", "Walsh", null, "Turkey", "0000", "597-644-4788 x5030", null, "Male" },
                    { 2048, "Beckerton", "2021", "EE8008", 2, "G388489", new DateTime(1987, 3, 28, 0, 0, 0, 0, DateTimeKind.Local), "Alison_Parisian58@yahoo.com", "Alison", "Parisian", null, "Rwanda", "0000", "1-905-511-2217 x98710", null, "Female" },
                    { 2046, "Boscoburgh", "2021", "EE2972", 2, "G152093", new DateTime(1995, 7, 22, 0, 0, 0, 0, DateTimeKind.Local), "Irvin_Kuphal18@yahoo.com", "Irvin", "Kuphal", null, "Guinea-Bissau", "0000", "1-614-646-6858 x978", null, "Male" },
                    { 2045, "Jeromychester", "2021", "EE51398", 2, "G24004", new DateTime(1969, 11, 6, 0, 0, 0, 0, DateTimeKind.Local), "Katrina.Bashirian@hotmail.com", "Katrina", "Bashirian", null, "Saint Pierre and Miquelon", "0000", "1-423-330-9698", null, "Female" },
                    { 2043, "South Cordellhaven", "2021", "EE40285", 2, "G186178", new DateTime(1967, 5, 30, 0, 0, 0, 0, DateTimeKind.Local), "Florence_Frami28@hotmail.com", "Florence", "Frami", null, "Albania", "0000", "(865) 691-9233", null, "Female" },
                    { 2040, "Bulahshire", "2021", "EE15478", 2, "G218534", new DateTime(1952, 12, 20, 0, 0, 0, 0, DateTimeKind.Local), "John15@gmail.com", "John", "Pagac", null, "Brazil", "0000", "1-824-825-6669 x3410", null, "Male" },
                    { 2034, "South Leora", "2021", "EE45056", 2, "G216820", new DateTime(1986, 9, 19, 0, 0, 0, 0, DateTimeKind.Local), "Kent.Skiles55@yahoo.com", "Kent", "Skiles", null, "Armenia", "0000", "(553) 228-0051", null, "Male" },
                    { 2024, "Flavieshire", "2021", "EE22342", 2, "G329611", new DateTime(1964, 9, 10, 0, 0, 0, 0, DateTimeKind.Local), "Allan.Kozey@yahoo.com", "Allan", "Kozey", null, "Aruba", "0000", "330-972-2541 x53296", null, "Male" },
                    { 2109, "South Breana", "2021", "EE55360", 2, "G245768", new DateTime(1951, 9, 4, 0, 0, 0, 0, DateTimeKind.Local), "Bert_Heathcote77@gmail.com", "Bert", "Heathcote", null, "Cuba", "0000", "1-361-499-1890 x4371", null, "Male" },
                    { 2023, "North Alanis", "2021", "EE30304", 2, "G187401", new DateTime(1971, 7, 21, 0, 0, 0, 0, DateTimeKind.Local), "Tiffany.Sawayn@hotmail.com", "Tiffany", "Sawayn", null, "Spain", "0000", "1-686-637-0252", null, "Female" },
                    { 2011, "New Gennarostad", "2021", "EE19708", 2, "G197826", new DateTime(1960, 10, 7, 0, 0, 0, 0, DateTimeKind.Local), "Sadie.Tromp62@yahoo.com", "Sadie", "Tromp", null, "Ecuador", "0000", "394-448-2227 x31528", null, "Female" },
                    { 2010, "East Darrion", "2021", "EE57200", 2, "G156142", new DateTime(1984, 5, 17, 0, 0, 0, 0, DateTimeKind.Local), "Jacqueline_Stamm@gmail.com", "Jacqueline", "Stamm", null, "Serbia", "0000", "485-464-1713 x0937", null, "Female" },
                    { 2499, "Klingberg", "2021", "EE3734", 3, "G230520", new DateTime(1975, 8, 1, 0, 0, 0, 0, DateTimeKind.Local), "Leah.Predovic@gmail.com", "Leah", "Predovic", null, "Faroe Islands", "0000", "(941) 244-9316", null, "Female" },
                    { 2487, "Monahanfort", "2021", "EE46356", 3, "G177566", new DateTime(1972, 5, 25, 0, 0, 0, 0, DateTimeKind.Local), "Cristina.Daugherty15@hotmail.com", "Cristina", "Daugherty", null, "Republic of Korea", "0000", "501-410-3124", null, "Female" },
                    { 2484, "Beiershire", "2021", "EE35326", 3, "G487631", new DateTime(1997, 1, 2, 0, 0, 0, 0, DateTimeKind.Local), "Angelica88@hotmail.com", "Angelica", "Koch", null, "Pitcairn Islands", "0000", "1-211-958-7010 x7784", null, "Female" }
                });

            migrationBuilder.InsertData(
                table: "Etudiants",
                columns: new[] { "apogee", "address", "annee", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "ldn", "natio", "password", "phone", "picture", "sexe" },
                values: new object[,]
                {
                    { 2481, "West Esmeralda", "2021", "EE56853", 3, "G430277", new DateTime(1990, 12, 27, 0, 0, 0, 0, DateTimeKind.Local), "Sheila_Johnston@hotmail.com", "Sheila", "Johnston", null, "Qatar", "0000", "972-410-4367 x8462", null, "Female" },
                    { 2477, "Haagton", "2021", "EE40346", 3, "G190036", new DateTime(1992, 11, 20, 0, 0, 0, 0, DateTimeKind.Local), "Amy.Rolfson@gmail.com", "Amy", "Rolfson", null, "Djibouti", "0000", "(308) 820-8656 x44108", null, "Female" },
                    { 2471, "New Ruben", "2021", "EE2560", 3, "G426078", new DateTime(1957, 6, 15, 0, 0, 0, 0, DateTimeKind.Local), "Sharon_Jast@hotmail.com", "Sharon", "Jast", null, "Moldova", "0000", "286-498-8515 x22953", null, "Female" },
                    { 2469, "North Devin", "2021", "EE49044", 3, "G536119", new DateTime(1956, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), "Aaron_Bauch44@hotmail.com", "Aaron", "Bauch", null, "Ireland", "0000", "363.707.2177 x24089", null, "Male" },
                    { 2465, "North Chaimstad", "2021", "EE39858", 3, "G532853", new DateTime(1978, 10, 8, 0, 0, 0, 0, DateTimeKind.Local), "Blanca_Gorczany48@gmail.com", "Blanca", "Gorczany", null, "Uzbekistan", "0000", "(334) 816-3401 x939", null, "Female" },
                    { 2462, "Dickinsonfurt", "2021", "EE31653", 3, "G551609", new DateTime(1957, 12, 10, 0, 0, 0, 0, DateTimeKind.Local), "Jake_Wisozk@gmail.com", "Jake", "Wisozk", null, "China", "0000", "1-968-644-4084", null, "Male" },
                    { 2459, "Lake Garrick", "2021", "EE41940", 3, "G237916", new DateTime(1991, 9, 21, 0, 0, 0, 0, DateTimeKind.Local), "Jenny.Sauer90@hotmail.com", "Jenny", "Sauer", null, "Trinidad and Tobago", "0000", "1-533-734-3484", null, "Female" },
                    { 2456, "Jodyfurt", "2021", "EE46007", 3, "G193916", new DateTime(1995, 1, 6, 0, 0, 0, 0, DateTimeKind.Local), "Josefina96@hotmail.com", "Josefina", "Crooks", null, "Tokelau", "0000", "770.302.7287", null, "Female" },
                    { 2016, "East Princemouth", "2021", "EE7160", 2, "G216743", new DateTime(1976, 11, 24, 0, 0, 0, 0, DateTimeKind.Local), "Saul66@gmail.com", "Saul", "Hudson", null, "Western Sahara", "0000", "730-624-3314 x360", null, "Male" },
                    { 2001, "Tavaresshire", "2021", "EE3087", 1, "G14787", new DateTime(1968, 4, 10, 0, 0, 0, 0, DateTimeKind.Local), "Angelica46@gmail.com", "Angelica", "O'Conner", null, "Netherlands Antilles", "0000", "1-233-373-2857", null, "Female" },
                    { 2112, "South Alffort", "2021", "EE54564", 2, "G115624", new DateTime(1959, 12, 5, 0, 0, 0, 0, DateTimeKind.Local), "Marion_Bogisich44@gmail.com", "Marion", "Bogisich", null, "Uzbekistan", "0000", "1-690-549-8298 x829", null, "Female" },
                    { 2117, "Cieloburgh", "2021", "EE1008", 2, "G480501", new DateTime(1953, 6, 1, 0, 0, 0, 0, DateTimeKind.Local), "Shawna77@gmail.com", "Shawna", "Graham", null, "Vietnam", "0000", "649-214-1326", null, "Female" },
                    { 2235, "Port Daphneyview", "2021", "EE45330", 2, "G346902", new DateTime(1961, 10, 23, 0, 0, 0, 0, DateTimeKind.Local), "Tracy.Goyette68@hotmail.com", "Tracy", "Goyette", null, "Iran", "0000", "603-738-3745", null, "Female" },
                    { 2230, "Monahanfort", "2021", "EE41998", 2, "G348191", new DateTime(1972, 7, 20, 0, 0, 0, 0, DateTimeKind.Local), "Cecelia69@gmail.com", "Cecelia", "Ferry", null, "New Caledonia", "0000", "711.901.3194", null, "Female" },
                    { 2227, "Runolfssonborough", "2021", "EE16357", 2, "G522696", new DateTime(1995, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), "Timothy_Herman@hotmail.com", "Timothy", "Herman", null, "El Salvador", "0000", "1-292-907-3324", null, "Male" },
                    { 2224, "Ilianaburgh", "2021", "EE44139", 2, "G474959", new DateTime(1956, 8, 31, 0, 0, 0, 0, DateTimeKind.Local), "Nichole18@hotmail.com", "Nichole", "Stroman", null, "Palestinian Territory", "0000", "1-642-969-5649 x08645", null, "Female" },
                    { 2216, "Ashachester", "2021", "EE27541", 2, "G551603", new DateTime(1952, 10, 9, 0, 0, 0, 0, DateTimeKind.Local), "Dexter87@hotmail.com", "Dexter", "West", null, "Paraguay", "0000", "1-979-999-0493 x324", null, "Male" },
                    { 2215, "New Patiencebury", "2021", "EE34444", 2, "G81550", new DateTime(1977, 3, 21, 0, 0, 0, 0, DateTimeKind.Local), "Angelina.Dare@yahoo.com", "Angelina", "Dare", null, "Benin", "0000", "1-440-533-1231", null, "Female" },
                    { 2214, "Austentown", "2021", "EE12647", 2, "G324604", new DateTime(1990, 3, 16, 0, 0, 0, 0, DateTimeKind.Local), "Aaron.Schuppe@gmail.com", "Aaron", "Schuppe", null, "Bangladesh", "0000", "376.705.5154 x74211", null, "Male" },
                    { 2204, "West Letitiaborough", "2021", "EE13954", 2, "G485751", new DateTime(1963, 4, 22, 0, 0, 0, 0, DateTimeKind.Local), "Sara.Schmidt@gmail.com", "Sara", "Schmidt", null, "Samoa", "0000", "(457) 233-6426 x893", null, "Female" },
                    { 2203, "Wandaton", "2021", "EE1037", 2, "G418744", new DateTime(1965, 6, 2, 0, 0, 0, 0, DateTimeKind.Local), "Myrtle_Douglas69@yahoo.com", "Myrtle", "Douglas", null, "Cape Verde", "0000", "295-413-9861", null, "Female" },
                    { 2195, "Russelhaven", "2021", "EE56820", 2, "G198287", new DateTime(1956, 6, 8, 0, 0, 0, 0, DateTimeKind.Local), "Kathleen_Murazik@yahoo.com", "Kathleen", "Murazik", null, "Georgia", "0000", "223.225.4264 x9542", null, "Female" },
                    { 2192, "East Harry", "2021", "EE47132", 2, "G383018", new DateTime(1951, 12, 20, 0, 0, 0, 0, DateTimeKind.Local), "Kevin_Bradtke@yahoo.com", "Kevin", "Bradtke", null, "Poland", "0000", "1-360-620-7709 x481", null, "Male" },
                    { 2188, "West Ozellaland", "2021", "EE24758", 2, "G321682", new DateTime(1972, 11, 29, 0, 0, 0, 0, DateTimeKind.Local), "Rhonda_Gleason69@gmail.com", "Rhonda", "Gleason", null, "Chile", "0000", "835-245-0661 x5792", null, "Female" },
                    { 2187, "South Hunterview", "2021", "EE36185", 2, "G57496", new DateTime(1961, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), "Priscilla_Cole@hotmail.com", "Priscilla", "Cole", null, "Gibraltar", "0000", "1-431-689-4613 x1324", null, "Female" },
                    { 2114, "Reingerview", "2021", "EE30637", 2, "G314844", new DateTime(1975, 3, 10, 0, 0, 0, 0, DateTimeKind.Local), "Robert88@gmail.com", "Robert", "Prohaska", null, "Mongolia", "0000", "(538) 346-1123 x5283", null, "Male" },
                    { 2182, "Branditown", "2021", "EE32999", 2, "G518599", new DateTime(1970, 5, 12, 0, 0, 0, 0, DateTimeKind.Local), "Leona.Beer52@yahoo.com", "Leona", "Beer", null, "Burundi", "0000", "961-222-3408 x9642", null, "Female" },
                    { 2180, "Connshire", "2021", "EE17904", 2, "G71946", new DateTime(1990, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), "Mildred_Hartmann@yahoo.com", "Mildred", "Hartmann", null, "Costa Rica", "0000", "904.401.8282 x9155", null, "Female" },
                    { 2177, "Huelmouth", "2021", "EE2068", 2, "G589068", new DateTime(1995, 6, 22, 0, 0, 0, 0, DateTimeKind.Local), "Candice34@hotmail.com", "Candice", "Hermann", null, "Canada", "0000", "(390) 981-8088", null, "Female" },
                    { 2169, "North Deliatown", "2021", "EE59676", 2, "G213230", new DateTime(1966, 11, 6, 0, 0, 0, 0, DateTimeKind.Local), "Ernest_Bechtelar8@yahoo.com", "Ernest", "Bechtelar", null, "Honduras", "0000", "1-699-504-3458 x364", null, "Male" },
                    { 2162, "Randallborough", "2021", "EE55971", 2, "G469582", new DateTime(1999, 3, 6, 0, 0, 0, 0, DateTimeKind.Local), "Roderick97@yahoo.com", "Roderick", "Mann", null, "Estonia", "0000", "(294) 274-1932", null, "Male" },
                    { 2161, "Botsfordland", "2021", "EE7264", 2, "G164290", new DateTime(1986, 11, 22, 0, 0, 0, 0, DateTimeKind.Local), "Arlene30@gmail.com", "Arlene", "Schmidt", null, "Reunion", "0000", "1-262-738-9233 x5467", null, "Female" },
                    { 2151, "West Colton", "2021", "EE9910", 2, "G258582", new DateTime(1957, 2, 16, 0, 0, 0, 0, DateTimeKind.Local), "Willard.Lockman@hotmail.com", "Willard", "Lockman", null, "Belgium", "0000", "302.540.4051 x277", null, "Male" },
                    { 2150, "Maximillianport", "2021", "EE2166", 2, "G274541", new DateTime(1968, 8, 25, 0, 0, 0, 0, DateTimeKind.Local), "Oliver_Terry@gmail.com", "Oliver", "Terry", null, "Falkland Islands (Malvinas)", "0000", "833-531-4211 x99906", null, "Male" },
                    { 2146, "Boehmbury", "2021", "EE8073", 2, "G359540", new DateTime(1980, 8, 20, 0, 0, 0, 0, DateTimeKind.Local), "Mercedes0@hotmail.com", "Mercedes", "Sipes", null, "Armenia", "0000", "(766) 995-5737 x033", null, "Female" },
                    { 2135, "Lake Pedro", "2021", "EE724", 2, "G318968", new DateTime(1987, 2, 3, 0, 0, 0, 0, DateTimeKind.Local), "Andrew_Heidenreich27@gmail.com", "Andrew", "Heidenreich", null, "Angola", "0000", "840.518.3395 x36199", null, "Male" },
                    { 2131, "Deckowmouth", "2021", "EE207", 2, "G389533", new DateTime(1993, 10, 19, 0, 0, 0, 0, DateTimeKind.Local), "Enrique.Hansen@hotmail.com", "Enrique", "Hansen", null, "France", "0000", "1-875-740-6765 x177", null, "Male" },
                    { 2126, "New Rickey", "2021", "EE22948", 2, "G537043", new DateTime(1982, 1, 25, 0, 0, 0, 0, DateTimeKind.Local), "Megan5@gmail.com", "Megan", "Bartoletti", null, "French Guiana", "0000", "(993) 287-2089 x4436", null, "Female" },
                    { 2125, "New Uniquebury", "2021", "EE30991", 2, "G353053", new DateTime(1991, 1, 17, 0, 0, 0, 0, DateTimeKind.Local), "Gordon_McGlynn@yahoo.com", "Gordon", "McGlynn", null, "Zimbabwe", "0000", "280-561-2213 x619", null, "Male" },
                    { 2124, "Braxtonberg", "2021", "EE43198", 2, "G307055", new DateTime(1956, 11, 25, 0, 0, 0, 0, DateTimeKind.Local), "Wilma_Satterfield84@yahoo.com", "Wilma", "Satterfield", null, "Puerto Rico", "0000", "630.949.1174", null, "Female" },
                    { 2181, "Edwardview", "2021", "EE32209", 2, "G308902", new DateTime(1976, 2, 23, 0, 0, 0, 0, DateTimeKind.Local), "Desiree.Gottlieb72@gmail.com", "Desiree", "Gottlieb", null, "Puerto Rico", "0000", "799.805.1009", null, "Female" },
                    { 2455, "New Ludie", "2021", "EE3576", 3, "G379823", new DateTime(1956, 7, 11, 0, 0, 0, 0, DateTimeKind.Local), "Rufus.Runte@hotmail.com", "Rufus", "Runte", null, "Sao Tome and Principe", "0000", "1-685-771-7062", null, "Male" }
                });

            migrationBuilder.InsertData(
                table: "Etudiants",
                columns: new[] { "apogee", "address", "annee", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "ldn", "natio", "password", "phone", "picture", "sexe" },
                values: new object[,]
                {
                    { 2002, "Predovicmouth", "2021", "EE15320", 1, "G264866", new DateTime(1970, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), "Darrel.Weber55@yahoo.com", "Darrel", "Weber", null, "Togo", "0000", "519.405.3028 x797", null, "Male" },
                    { 2004, "Port Myles", "2021", "EE57358", 1, "G133217", new DateTime(1975, 10, 4, 0, 0, 0, 0, DateTimeKind.Local), "Milton_Reinger@gmail.com", "Milton", "Reinger", null, "Costa Rica", "0000", "275-575-0273 x848", null, "Male" },
                    { 2372, "Lake Cyrilville", "2021", "EE57297", 1, "G498264", new DateTime(1990, 2, 10, 0, 0, 0, 0, DateTimeKind.Local), "Audrey_Jerde@gmail.com", "Audrey", "Jerde", null, "Mauritania", "0000", "1-474-787-1943 x98696", null, "Female" },
                    { 2370, "Cheyanneborough", "2021", "EE18856", 1, "G564555", new DateTime(1977, 9, 18, 0, 0, 0, 0, DateTimeKind.Local), "Jon.Strosin9@gmail.com", "Jon", "Strosin", null, "Latvia", "0000", "1-704-282-6544", null, "Male" },
                    { 2366, "East Christianamouth", "2021", "EE55502", 1, "G554195", new DateTime(1981, 11, 28, 0, 0, 0, 0, DateTimeKind.Local), "Frankie_Veum@gmail.com", "Frankie", "Veum", null, "Luxembourg", "0000", "319.479.1828 x6598", null, "Male" },
                    { 2358, "Andersonchester", "2021", "EE51533", 1, "G397000", new DateTime(1975, 2, 15, 0, 0, 0, 0, DateTimeKind.Local), "Fred_Hane72@hotmail.com", "Fred", "Hane", null, "Moldova", "0000", "(349) 396-9009", null, "Male" },
                    { 2357, "Port Reese", "2021", "EE20450", 1, "G231600", new DateTime(1974, 6, 25, 0, 0, 0, 0, DateTimeKind.Local), "Frank10@hotmail.com", "Frank", "Fisher", null, "Liechtenstein", "0000", "257-308-4127", null, "Male" },
                    { 2354, "Brayanton", "2021", "EE52549", 1, "G267959", new DateTime(1973, 11, 25, 0, 0, 0, 0, DateTimeKind.Local), "Darin.Walsh79@gmail.com", "Darin", "Walsh", null, "Wallis and Futuna", "0000", "652-326-3150", null, "Male" },
                    { 2348, "Lake Gerhardstad", "2021", "EE22105", 1, "G18867", new DateTime(1969, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), "Kerry24@gmail.com", "Kerry", "Schmitt", null, "Somalia", "0000", "774.368.0089 x49560", null, "Female" },
                    { 2345, "Hudsonport", "2021", "EE32016", 1, "G317223", new DateTime(1965, 3, 10, 0, 0, 0, 0, DateTimeKind.Local), "Elbert_Deckow@hotmail.com", "Elbert", "Deckow", null, "Sudan", "0000", "211-565-8872", null, "Male" },
                    { 2344, "Lake Elodymouth", "2021", "EE7939", 1, "G144629", new DateTime(1990, 10, 14, 0, 0, 0, 0, DateTimeKind.Local), "Courtney_Donnelly61@hotmail.com", "Courtney", "Donnelly", null, "Algeria", "0000", "318-202-9069 x3767", null, "Male" },
                    { 2343, "Mariannaton", "2021", "EE45962", 1, "G331359", new DateTime(1990, 3, 10, 0, 0, 0, 0, DateTimeKind.Local), "Elias.Romaguera@gmail.com", "Elias", "Romaguera", null, "Egypt", "0000", "1-589-913-1399 x37109", null, "Male" },
                    { 2341, "Elisaland", "2021", "EE15446", 1, "G81366", new DateTime(1973, 5, 17, 0, 0, 0, 0, DateTimeKind.Local), "Courtney_Johnston@hotmail.com", "Courtney", "Johnston", null, "Libyan Arab Jamahiriya", "0000", "982.524.3959 x563", null, "Female" },
                    { 2339, "Burleyhaven", "2021", "EE45973", 1, "G67984", new DateTime(1988, 7, 30, 0, 0, 0, 0, DateTimeKind.Local), "Elias.Ziemann81@yahoo.com", "Elias", "Ziemann", null, "Armenia", "0000", "333.667.2451", null, "Male" },
                    { 2336, "Prohaskamouth", "2021", "EE16614", 1, "G528313", new DateTime(1953, 5, 15, 0, 0, 0, 0, DateTimeKind.Local), "Danny.Langosh99@gmail.com", "Danny", "Langosh", null, "Turkmenistan", "0000", "743-552-2039", null, "Male" },
                    { 2330, "West Jennifer", "2021", "EE15190", 1, "G283154", new DateTime(1999, 10, 6, 0, 0, 0, 0, DateTimeKind.Local), "Alberta.Ortiz70@gmail.com", "Alberta", "Ortiz", null, "Saint Lucia", "0000", "321.602.9621", null, "Female" },
                    { 2320, "Nicolasfurt", "2021", "EE4573", 1, "G211645", new DateTime(1987, 3, 20, 0, 0, 0, 0, DateTimeKind.Local), "Ora61@hotmail.com", "Ora", "Friesen", null, "Bangladesh", "0000", "648-337-6324", null, "Female" },
                    { 2317, "Robertsstad", "2021", "EE8556", 1, "G277037", new DateTime(1975, 3, 2, 0, 0, 0, 0, DateTimeKind.Local), "Rhonda_Corwin22@gmail.com", "Rhonda", "Corwin", null, "Belgium", "0000", "712-417-9239 x95320", null, "Female" },
                    { 2315, "New Morris", "2021", "EE35399", 1, "G426957", new DateTime(1955, 11, 11, 0, 0, 0, 0, DateTimeKind.Local), "Irvin13@hotmail.com", "Irvin", "Denesik", null, "Nicaragua", "0000", "885-741-2036", null, "Male" },
                    { 2308, "Mayraburgh", "2021", "EE39000", 1, "G566115", new DateTime(1993, 4, 19, 0, 0, 0, 0, DateTimeKind.Local), "Melba80@hotmail.com", "Melba", "Mayer", null, "Trinidad and Tobago", "0000", "1-374-464-7749 x3987", null, "Female" },
                    { 2302, "South Beaulah", "2021", "EE4716", 1, "G460584", new DateTime(1980, 10, 27, 0, 0, 0, 0, DateTimeKind.Local), "Michele.Bauch17@yahoo.com", "Michele", "Bauch", null, "Holy See (Vatican City State)", "0000", "(767) 776-9139 x52600", null, "Female" },
                    { 2300, "Ryanfort", "2021", "EE35956", 1, "G422622", new DateTime(1964, 2, 7, 0, 0, 0, 0, DateTimeKind.Local), "Willie.Reinger76@hotmail.com", "Willie", "Reinger", null, "Montserrat", "0000", "(759) 963-5856", null, "Female" },
                    { 2299, "South Litzy", "2021", "EE9170", 1, "G509792", new DateTime(1969, 6, 21, 0, 0, 0, 0, DateTimeKind.Local), "Shawna.DuBuque86@gmail.com", "Shawna", "DuBuque", null, "French Southern Territories", "0000", "872.885.4246 x5439", null, "Female" },
                    { 2298, "Port Unaside", "2021", "EE32540", 1, "G286866", new DateTime(1995, 1, 16, 0, 0, 0, 0, DateTimeKind.Local), "Ross_Schimmel39@gmail.com", "Ross", "Schimmel", null, "Lithuania", "0000", "207.625.1010", null, "Male" },
                    { 2294, "Sipeshaven", "2021", "EE12223", 1, "G197137", new DateTime(1962, 11, 11, 0, 0, 0, 0, DateTimeKind.Local), "Carol_Casper53@gmail.com", "Carol", "Casper", null, "Netherlands", "0000", "(719) 939-9293 x001", null, "Female" },
                    { 2293, "Lake Allison", "2021", "EE3820", 1, "G454508", new DateTime(1969, 11, 11, 0, 0, 0, 0, DateTimeKind.Local), "Homer31@yahoo.com", "Homer", "Powlowski", null, "Central African Republic", "0000", "572.783.8499 x789", null, "Male" },
                    { 2291, "Haneton", "2021", "EE18020", 1, "G113778", new DateTime(1965, 8, 28, 0, 0, 0, 0, DateTimeKind.Local), "Rose94@hotmail.com", "Rose", "Breitenberg", null, "Ethiopia", "0000", "(513) 827-4169 x978", null, "Female" },
                    { 2285, "South Alexie", "2021", "EE36409", 1, "G175462", new DateTime(1964, 8, 23, 0, 0, 0, 0, DateTimeKind.Local), "Cecelia_Vandervort@hotmail.com", "Cecelia", "Vandervort", null, "Iceland", "0000", "766.513.7813 x459", null, "Female" },
                    { 2280, "Wuckertberg", "2021", "EE15717", 1, "G362261", new DateTime(1958, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), "Byron_Prohaska97@gmail.com", "Byron", "Prohaska", null, "Guinea", "0000", "423-370-8662", null, "Male" },
                    { 2375, "Domenicofurt", "2021", "EE271", 1, "G279101", new DateTime(1964, 9, 14, 0, 0, 0, 0, DateTimeKind.Local), "Diane.Kunde29@gmail.com", "Diane", "Kunde", null, "Malta", "0000", "(800) 457-4251", null, "Female" },
                    { 2379, "East Amelie", "2021", "EE11403", 1, "G582672", new DateTime(1965, 10, 5, 0, 0, 0, 0, DateTimeKind.Local), "Colin_Fahey@gmail.com", "Colin", "Fahey", null, "Madagascar", "0000", "1-415-859-4754 x191", null, "Male" },
                    { 2382, "New Ezequielhaven", "2021", "EE5560", 1, "G537219", new DateTime(1957, 1, 4, 0, 0, 0, 0, DateTimeKind.Local), "Amy_Jones15@hotmail.com", "Amy", "Jones", null, "Montenegro", "0000", "1-334-663-4144 x6379", null, "Female" },
                    { 2387, "South Jadeburgh", "2021", "EE10449", 1, "G78291", new DateTime(1988, 9, 3, 0, 0, 0, 0, DateTimeKind.Local), "Mildred58@hotmail.com", "Mildred", "Hoeger", null, "Central African Republic", "0000", "(216) 882-6894", null, "Female" },
                    { 2496, "North Aracelychester", "2021", "EE40472", 1, "G476260", new DateTime(1959, 7, 23, 0, 0, 0, 0, DateTimeKind.Local), "Marlene_Keeling55@yahoo.com", "Marlene", "Keeling", null, "Djibouti", "0000", "847-784-9236", null, "Female" },
                    { 2493, "Lisandromouth", "2021", "EE52883", 1, "G271266", new DateTime(1989, 9, 27, 0, 0, 0, 0, DateTimeKind.Local), "Monique_Langworth93@gmail.com", "Monique", "Langworth", null, "Kiribati", "0000", "936-855-9689", null, "Female" },
                    { 2490, "Hillsmouth", "2021", "EE54786", 1, "G288350", new DateTime(1983, 4, 25, 0, 0, 0, 0, DateTimeKind.Local), "Leon17@gmail.com", "Leon", "Wisozk", null, "Lebanon", "0000", "1-255-532-0910 x899", null, "Male" },
                    { 2488, "Hesselview", "2021", "EE26670", 1, "G257403", new DateTime(1972, 10, 26, 0, 0, 0, 0, DateTimeKind.Local), "Willie.Feest0@gmail.com", "Willie", "Feest", null, "Greece", "0000", "351.399.4931 x78414", null, "Female" },
                    { 2486, "New Leanna", "2021", "EE49649", 1, "G306104", new DateTime(1963, 5, 13, 0, 0, 0, 0, DateTimeKind.Local), "Jerome_DuBuque41@yahoo.com", "Jerome", "DuBuque", null, "Netherlands", "0000", "701.955.4739", null, "Male" },
                    { 2482, "South Conorborough", "2021", "EE55961", 1, "G338851", new DateTime(1968, 12, 14, 0, 0, 0, 0, DateTimeKind.Local), "Holly3@hotmail.com", "Holly", "Corkery", null, "Croatia", "0000", "442.402.9732 x563", null, "Female" },
                    { 2479, "Fayeport", "2021", "EE36837", 1, "G579190", new DateTime(1969, 6, 10, 0, 0, 0, 0, DateTimeKind.Local), "Johnnie.Schowalter@hotmail.com", "Johnnie", "Schowalter", null, "Western Sahara", "0000", "299-520-2950 x007", null, "Male" },
                    { 2476, "Jimmyville", "2021", "EE3799", 1, "G184196", new DateTime(1972, 9, 9, 0, 0, 0, 0, DateTimeKind.Local), "Jackie.Zboncak39@yahoo.com", "Jackie", "Zboncak", null, "Kenya", "0000", "(546) 542-6383 x344", null, "Female" },
                    { 2466, "Cassinstad", "2021", "EE54830", 1, "G334762", new DateTime(1973, 10, 9, 0, 0, 0, 0, DateTimeKind.Local), "Rita3@hotmail.com", "Rita", "Kuvalis", null, "Uganda", "0000", "1-388-524-8339 x8662", null, "Female" }
                });

            migrationBuilder.InsertData(
                table: "Etudiants",
                columns: new[] { "apogee", "address", "annee", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "ldn", "natio", "password", "phone", "picture", "sexe" },
                values: new object[,]
                {
                    { 2460, "Lake Sterlingside", "2021", "EE30048", 1, "G100995", new DateTime(1957, 10, 31, 0, 0, 0, 0, DateTimeKind.Local), "Edmund_Ratke@gmail.com", "Edmund", "Ratke", null, "Bolivia", "0000", "(439) 275-5566 x6551", null, "Male" },
                    { 2458, "Fayfort", "2021", "EE11839", 1, "G378473", new DateTime(1967, 6, 5, 0, 0, 0, 0, DateTimeKind.Local), "Loren86@yahoo.com", "Loren", "Klein", null, "Guam", "0000", "935.677.1065 x3379", null, "Male" },
                    { 2452, "Bartellville", "2021", "EE35110", 1, "G517727", new DateTime(1993, 11, 21, 0, 0, 0, 0, DateTimeKind.Local), "Grant.Ward@hotmail.com", "Grant", "Ward", null, "Guinea-Bissau", "0000", "(870) 339-9098", null, "Male" },
                    { 2449, "Florianmouth", "2021", "EE11202", 1, "G583487", new DateTime(1953, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), "Edna8@gmail.com", "Edna", "Ritchie", null, "Denmark", "0000", "1-624-920-0990 x489", null, "Female" },
                    { 2274, "Marquardtmouth", "2021", "EE12392", 1, "G271413", new DateTime(1987, 5, 31, 0, 0, 0, 0, DateTimeKind.Local), "Olga59@yahoo.com", "Olga", "Fahey", null, "American Samoa", "0000", "(600) 204-2824 x8591", null, "Female" },
                    { 2448, "New Orlandstad", "2021", "EE26272", 1, "G215997", new DateTime(1972, 2, 13, 0, 0, 0, 0, DateTimeKind.Local), "Dominick.Harber1@hotmail.com", "Dominick", "Harber", null, "Isle of Man", "0000", "390-367-4120", null, "Male" },
                    { 2438, "South Lambert", "2021", "EE55801", 1, "G585606", new DateTime(1988, 2, 10, 0, 0, 0, 0, DateTimeKind.Local), "Kathy.Gerlach@hotmail.com", "Kathy", "Gerlach", null, "Uganda", "0000", "637.213.0909 x05794", null, "Female" },
                    { 2436, "South Emerson", "2021", "EE49980", 1, "G216647", new DateTime(1982, 1, 18, 0, 0, 0, 0, DateTimeKind.Local), "Terrence.Steuber28@hotmail.com", "Terrence", "Steuber", null, "Grenada", "0000", "1-954-323-0030", null, "Male" },
                    { 2434, "New Nat", "2021", "EE1290", 1, "G303999", new DateTime(1951, 7, 31, 0, 0, 0, 0, DateTimeKind.Local), "Wilfred67@hotmail.com", "Wilfred", "Zulauf", null, "Angola", "0000", "1-548-569-6845 x035", null, "Male" },
                    { 2433, "Lake Matildestad", "2021", "EE12082", 1, "G395155", new DateTime(1960, 12, 5, 0, 0, 0, 0, DateTimeKind.Local), "Jane.Padberg@gmail.com", "Jane", "Padberg", null, "Malawi", "0000", "(881) 539-4733 x6210", null, "Female" },
                    { 2432, "New Rebastad", "2021", "EE49560", 1, "G47990", new DateTime(1975, 6, 24, 0, 0, 0, 0, DateTimeKind.Local), "Tabitha.Ondricka@yahoo.com", "Tabitha", "Ondricka", null, "Czech Republic", "0000", "338.229.0822 x6790", null, "Female" },
                    { 2423, "North Lucindafurt", "2021", "EE8954", 1, "G598333", new DateTime(1951, 8, 29, 0, 0, 0, 0, DateTimeKind.Local), "Becky.Zemlak89@gmail.com", "Becky", "Zemlak", null, "Faroe Islands", "0000", "1-963-895-4340", null, "Female" },
                    { 2421, "Gregghaven", "2021", "EE56635", 1, "G241066", new DateTime(1996, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), "Maureen27@gmail.com", "Maureen", "Howe", null, "French Guiana", "0000", "682.566.5025", null, "Female" },
                    { 2412, "North Dwight", "2021", "EE31278", 1, "G385937", new DateTime(1988, 3, 3, 0, 0, 0, 0, DateTimeKind.Local), "Natalie0@gmail.com", "Natalie", "Feest", null, "Niger", "0000", "765.830.4163", null, "Female" },
                    { 2396, "West Domenic", "2021", "EE26496", 1, "G455089", new DateTime(1978, 1, 29, 0, 0, 0, 0, DateTimeKind.Local), "Jennifer.Heathcote@gmail.com", "Jennifer", "Heathcote", null, "Bahrain", "0000", "418.933.2982 x5174", null, "Female" },
                    { 2395, "East Saul", "2021", "EE31837", 1, "G541485", new DateTime(1984, 11, 11, 0, 0, 0, 0, DateTimeKind.Local), "Sonya.Weimann@yahoo.com", "Sonya", "Weimann", null, "Gibraltar", "0000", "887.647.6908 x338", null, "Female" },
                    { 2391, "New Ludwigtown", "2021", "EE54452", 1, "G479521", new DateTime(1953, 1, 6, 0, 0, 0, 0, DateTimeKind.Local), "Leona.Gottlieb@yahoo.com", "Leona", "Gottlieb", null, "Djibouti", "0000", "(545) 210-1318 x57985", null, "Female" },
                    { 2390, "Ronaldofurt", "2021", "EE8435", 1, "G96883", new DateTime(1954, 7, 10, 0, 0, 0, 0, DateTimeKind.Local), "Edmond_Macejkovic65@hotmail.com", "Edmond", "Macejkovic", null, "Lao People's Democratic Republic", "0000", "(325) 251-2200 x12906", null, "Male" },
                    { 2388, "Collinschester", "2021", "EE51262", 1, "G9814", new DateTime(1985, 7, 27, 0, 0, 0, 0, DateTimeKind.Local), "Kerry.Torp90@gmail.com", "Kerry", "Torp", null, "Slovenia", "0000", "308.786.0400 x262", null, "Female" },
                    { 2440, "Gutkowskiport", "2021", "EE19626", 1, "G356888", new DateTime(1974, 11, 10, 0, 0, 0, 0, DateTimeKind.Local), "Mark_Considine86@gmail.com", "Mark", "Considine", null, "Saudi Arabia", "0000", "(815) 771-3417", null, "Male" },
                    { 2269, "North Maggie", "2021", "EE47846", 1, "G599209", new DateTime(1989, 10, 17, 0, 0, 0, 0, DateTimeKind.Local), "Pete.Grant76@yahoo.com", "Pete", "Grant", null, "Hong Kong", "0000", "(905) 469-1792", null, "Male" },
                    { 2266, "Dawnmouth", "2021", "EE37124", 1, "G460014", new DateTime(1953, 5, 9, 0, 0, 0, 0, DateTimeKind.Local), "Herbert_Breitenberg43@yahoo.com", "Herbert", "Breitenberg", null, "Virgin Islands, U.S.", "0000", "855.669.2492 x39886", null, "Male" },
                    { 2265, "Friesenville", "2021", "EE21274", 1, "G278176", new DateTime(1971, 4, 25, 0, 0, 0, 0, DateTimeKind.Local), "Bryan_Hudson@hotmail.com", "Bryan", "Hudson", null, "Brunei Darussalam", "0000", "(721) 565-3560 x90269", null, "Male" },
                    { 2097, "Zemlakburgh", "2021", "EE59584", 1, "G572683", new DateTime(1978, 7, 19, 0, 0, 0, 0, DateTimeKind.Local), "Paul_Wolff72@hotmail.com", "Paul", "Wolff", null, "Argentina", "0000", "266-231-0889", null, "Male" },
                    { 2096, "Robertoburgh", "2021", "EE34307", 1, "G69948", new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), "Nora.Veum27@gmail.com", "Nora", "Veum", null, "Azerbaijan", "0000", "461-627-8680", null, "Female" },
                    { 2095, "North William", "2021", "EE12704", 1, "G492936", new DateTime(1965, 2, 15, 0, 0, 0, 0, DateTimeKind.Local), "Andre.Ortiz@yahoo.com", "Andre", "Ortiz", null, "Monaco", "0000", "(237) 637-9260", null, "Male" },
                    { 2087, "Klingfort", "2021", "EE49509", 1, "G539139", new DateTime(1991, 9, 16, 0, 0, 0, 0, DateTimeKind.Local), "Nathaniel2@yahoo.com", "Nathaniel", "Tremblay", null, "Turkey", "0000", "1-368-999-2291", null, "Male" },
                    { 2085, "Percivalmouth", "2021", "EE55017", 1, "G588241", new DateTime(1951, 9, 24, 0, 0, 0, 0, DateTimeKind.Local), "Holly4@yahoo.com", "Holly", "Jacobson", null, "Bhutan", "0000", "432.373.1487 x638", null, "Female" },
                    { 2083, "Wardshire", "2021", "EE3999", 1, "G500947", new DateTime(1989, 6, 27, 0, 0, 0, 0, DateTimeKind.Local), "Gordon64@hotmail.com", "Gordon", "Mante", null, "Singapore", "0000", "589-708-6836", null, "Male" },
                    { 2080, "West Geovannifort", "2021", "EE40557", 1, "G315251", new DateTime(1990, 9, 8, 0, 0, 0, 0, DateTimeKind.Local), "Denise17@hotmail.com", "Denise", "Bartoletti", null, "Senegal", "0000", "1-239-684-0959", null, "Female" },
                    { 2079, "North Astrid", "2021", "EE11713", 1, "G504646", new DateTime(1963, 5, 1, 0, 0, 0, 0, DateTimeKind.Local), "Margie_Kertzmann@gmail.com", "Margie", "Kertzmann", null, "Samoa", "0000", "974-767-7837 x580", null, "Female" },
                    { 2076, "Lake Lelahville", "2021", "EE56033", 1, "G409556", new DateTime(1988, 4, 2, 0, 0, 0, 0, DateTimeKind.Local), "Rodolfo_Smith@gmail.com", "Rodolfo", "Smith", null, "Cape Verde", "0000", "(948) 812-1250 x728", null, "Male" },
                    { 2070, "Harberport", "2021", "EE24623", 1, "G537391", new DateTime(1963, 11, 17, 0, 0, 0, 0, DateTimeKind.Local), "Erma73@hotmail.com", "Erma", "Kuhlman", null, "Chad", "0000", "385-711-1310 x012", null, "Female" },
                    { 2066, "North Myriam", "2021", "EE14817", 1, "G284614", new DateTime(1981, 6, 23, 0, 0, 0, 0, DateTimeKind.Local), "Stacy28@gmail.com", "Stacy", "Conn", null, "Mauritius", "0000", "1-761-421-0338", null, "Female" },
                    { 2058, "Lake Theresamouth", "2021", "EE44521", 1, "G228201", new DateTime(1961, 6, 18, 0, 0, 0, 0, DateTimeKind.Local), "Angelica_Swift38@gmail.com", "Angelica", "Swift", null, "India", "0000", "963-898-0296 x486", null, "Female" },
                    { 2055, "West Christopheview", "2021", "EE36147", 1, "G439881", new DateTime(1963, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), "Keith_Ernser@hotmail.com", "Keith", "Ernser", null, "Russian Federation", "0000", "1-621-741-6398", null, "Male" },
                    { 2098, "New Wyman", "2021", "EE52129", 1, "G158001", new DateTime(1997, 2, 3, 0, 0, 0, 0, DateTimeKind.Local), "Stewart80@hotmail.com", "Stewart", "Auer", null, "Uganda", "0000", "1-881-252-5707 x95928", null, "Male" },
                    { 2054, "Fredericland", "2021", "EE51210", 1, "G280598", new DateTime(1990, 3, 30, 0, 0, 0, 0, DateTimeKind.Local), "Archie99@hotmail.com", "Archie", "Erdman", null, "Hungary", "0000", "(221) 241-7948 x776", null, "Male" },
                    { 2052, "East Quinn", "2021", "EE18578", 1, "G223915", new DateTime(1961, 7, 11, 0, 0, 0, 0, DateTimeKind.Local), "Joy72@yahoo.com", "Joy", "Lesch", null, "Sierra Leone", "0000", "374.388.3287 x2231", null, "Female" },
                    { 2039, "New Leslie", "2021", "EE37096", 1, "G435383", new DateTime(1954, 6, 26, 0, 0, 0, 0, DateTimeKind.Local), "Kyle.Paucek98@gmail.com", "Kyle", "Paucek", null, "Albania", "0000", "1-649-474-9719", null, "Male" },
                    { 2035, "North Fordton", "2021", "EE44580", 1, "G249889", new DateTime(1976, 6, 8, 0, 0, 0, 0, DateTimeKind.Local), "Brandi.Schaefer99@yahoo.com", "Brandi", "Schaefer", null, "Virgin Islands, British", "0000", "1-352-702-9700 x742", null, "Female" },
                    { 2033, "Chanceside", "2021", "EE43613", 1, "G47774", new DateTime(1990, 5, 21, 0, 0, 0, 0, DateTimeKind.Local), "Rex.Stiedemann89@gmail.com", "Rex", "Stiedemann", null, "Holy See (Vatican City State)", "0000", "1-636-368-8126", null, "Male" }
                });

            migrationBuilder.InsertData(
                table: "Etudiants",
                columns: new[] { "apogee", "address", "annee", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "ldn", "natio", "password", "phone", "picture", "sexe" },
                values: new object[,]
                {
                    { 2031, "Feeneystad", "2021", "EE18369", 1, "G235722", new DateTime(1970, 7, 1, 0, 0, 0, 0, DateTimeKind.Local), "Saul_Pfannerstill@hotmail.com", "Saul", "Pfannerstill", null, "Austria", "0000", "(925) 204-6430 x5194", null, "Male" },
                    { 2029, "North Clarabelleborough", "2021", "EE4054", 1, "G490359", new DateTime(1966, 7, 5, 0, 0, 0, 0, DateTimeKind.Local), "Philip.Welch99@yahoo.com", "Philip", "Welch", null, "Jamaica", "0000", "927-728-1451 x71855", null, "Male" },
                    { 2026, "Hoseashire", "2021", "EE7056", 1, "G59795", new DateTime(1962, 1, 21, 0, 0, 0, 0, DateTimeKind.Local), "Carl98@gmail.com", "Carl", "Murray", null, "Philippines", "0000", "1-494-818-1191 x007", null, "Male" },
                    { 2022, "West Magnusstad", "2021", "EE2078", 1, "G275569", new DateTime(1958, 9, 6, 0, 0, 0, 0, DateTimeKind.Local), "Jared_Hermann@yahoo.com", "Jared", "Hermann", null, "Bulgaria", "0000", "601.602.5907", null, "Male" },
                    { 2018, "Port Elisabethton", "2021", "EE54695", 1, "G352843", new DateTime(1962, 10, 21, 0, 0, 0, 0, DateTimeKind.Local), "Noel74@hotmail.com", "Noel", "Mitchell", null, "Algeria", "0000", "1-347-498-6122 x99454", null, "Male" },
                    { 2017, "Brekkeport", "2021", "EE50981", 1, "G243934", new DateTime(1961, 5, 12, 0, 0, 0, 0, DateTimeKind.Local), "Roman1@hotmail.com", "Roman", "Kub", null, "Wallis and Futuna", "0000", "(538) 285-5065", null, "Male" },
                    { 2013, "Halleside", "2021", "EE13283", 1, "G56552", new DateTime(1997, 2, 4, 0, 0, 0, 0, DateTimeKind.Local), "Sherry.Flatley@hotmail.com", "Sherry", "Flatley", null, "Samoa", "0000", "611.352.7696 x101", null, "Female" },
                    { 2006, "East Leta", "2021", "EE17106", 1, "G556021", new DateTime(1976, 1, 12, 0, 0, 0, 0, DateTimeKind.Local), "Erin61@yahoo.com", "Erin", "Labadie", null, "Democratic People's Republic of Korea", "0000", "(858) 669-4483 x946", null, "Female" },
                    { 2005, "Rathbury", "2021", "EE28153", 1, "G146087", new DateTime(1988, 2, 16, 0, 0, 0, 0, DateTimeKind.Local), "Elias_Ernser19@gmail.com", "Elias", "Ernser", null, "Philippines", "0000", "1-508-626-0971", null, "Male" },
                    { 2053, "Stanleyborough", "2021", "EE50571", 1, "G563970", new DateTime(1953, 12, 22, 0, 0, 0, 0, DateTimeKind.Local), "Elena90@gmail.com", "Elena", "Heathcote", null, "Costa Rica", "0000", "339.225.0258", null, "Female" },
                    { 2003, "Wunschmouth", "2021", "EE29178", 1, "G145789", new DateTime(1994, 8, 4, 0, 0, 0, 0, DateTimeKind.Local), "Javier_Boehm@yahoo.com", "Javier", "Boehm", null, "Republic of Korea", "0000", "429.834.5628 x09298", null, "Male" },
                    { 2101, "Johannamouth", "2021", "EE43858", 1, "G509118", new DateTime(1999, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), "Cathy.Marvin57@hotmail.com", "Cathy", "Marvin", null, "Lao People's Democratic Republic", "0000", "985-890-6620 x83598", null, "Female" },
                    { 2108, "West Ahmad", "2021", "EE47323", 1, "G227346", new DateTime(1990, 4, 2, 0, 0, 0, 0, DateTimeKind.Local), "Marlene_Zemlak@yahoo.com", "Marlene", "Zemlak", null, "Mauritius", "0000", "(893) 526-1711", null, "Female" },
                    { 2257, "Ethylton", "2021", "EE55421", 1, "G323532", new DateTime(1951, 9, 21, 0, 0, 0, 0, DateTimeKind.Local), "Jill_Jaskolski@yahoo.com", "Jill", "Jaskolski", null, "South Africa", "0000", "1-780-575-8900 x17059", null, "Female" },
                    { 2253, "Jonesstad", "2021", "EE59568", 1, "G577161", new DateTime(1952, 12, 12, 0, 0, 0, 0, DateTimeKind.Local), "Miriam36@hotmail.com", "Miriam", "Watsica", null, "Sweden", "0000", "1-706-468-4319", null, "Female" },
                    { 2240, "North Issachaven", "2021", "EE34267", 1, "G103893", new DateTime(1968, 4, 1, 0, 0, 0, 0, DateTimeKind.Local), "Troy_Dibbert15@yahoo.com", "Troy", "Dibbert", null, "Saint Kitts and Nevis", "0000", "(230) 486-9608 x571", null, "Male" },
                    { 2234, "Morarside", "2021", "EE1530", 1, "G462716", new DateTime(1989, 7, 6, 0, 0, 0, 0, DateTimeKind.Local), "Leroy.Klocko@yahoo.com", "Leroy", "Klocko", null, "Vanuatu", "0000", "(715) 692-5909", null, "Male" },
                    { 2233, "South Amie", "2021", "EE23294", 1, "G73661", new DateTime(1980, 4, 2, 0, 0, 0, 0, DateTimeKind.Local), "Ellis_Schimmel8@hotmail.com", "Ellis", "Schimmel", null, "Austria", "0000", "(384) 762-3864", null, "Male" },
                    { 2226, "Macejkovicview", "2021", "EE31322", 1, "G232885", new DateTime(1983, 4, 16, 0, 0, 0, 0, DateTimeKind.Local), "Velma.Jaskolski79@gmail.com", "Velma", "Jaskolski", null, "Portugal", "0000", "1-247-256-8395 x0374", null, "Female" },
                    { 2225, "West Trentton", "2021", "EE40091", 1, "G38206", new DateTime(1969, 5, 10, 0, 0, 0, 0, DateTimeKind.Local), "Kerry90@hotmail.com", "Kerry", "Abernathy", null, "Germany", "0000", "1-463-959-8743 x159", null, "Male" },
                    { 2222, "Ledamouth", "2021", "EE4866", 1, "G26330", new DateTime(1960, 5, 2, 0, 0, 0, 0, DateTimeKind.Local), "Patti_Kling@hotmail.com", "Patti", "Kling", null, "Djibouti", "0000", "1-780-535-9528 x1757", null, "Female" },
                    { 2212, "Port Keeley", "2021", "EE24242", 1, "G227895", new DateTime(1975, 5, 29, 0, 0, 0, 0, DateTimeKind.Local), "Eva58@yahoo.com", "Eva", "Langworth", null, "Niue", "0000", "295-621-5946", null, "Female" },
                    { 2205, "Hirtheburgh", "2021", "EE49843", 1, "G162980", new DateTime(1994, 9, 15, 0, 0, 0, 0, DateTimeKind.Local), "Darlene.White67@hotmail.com", "Darlene", "White", null, "Tuvalu", "0000", "883.714.0036", null, "Female" },
                    { 2202, "Schusterberg", "2021", "EE3986", 1, "G508332", new DateTime(1987, 5, 30, 0, 0, 0, 0, DateTimeKind.Local), "Marguerite.Doyle@hotmail.com", "Marguerite", "Doyle", null, "Gabon", "0000", "1-837-690-4335", null, "Female" },
                    { 2199, "Lambertside", "2021", "EE57201", 1, "G174189", new DateTime(1963, 8, 27, 0, 0, 0, 0, DateTimeKind.Local), "Joann63@gmail.com", "Joann", "Wehner", null, "Denmark", "0000", "688.660.7082 x363", null, "Female" },
                    { 2196, "South Yasminefort", "2021", "EE27556", 1, "G488107", new DateTime(1991, 5, 6, 0, 0, 0, 0, DateTimeKind.Local), "Vanessa_Emard@yahoo.com", "Vanessa", "Emard", null, "New Zealand", "0000", "1-632-475-7203 x6980", null, "Female" },
                    { 2102, "Farrellburgh", "2021", "EE26107", 1, "G102487", new DateTime(1974, 10, 22, 0, 0, 0, 0, DateTimeKind.Local), "Cesar45@gmail.com", "Cesar", "Strosin", null, "Norway", "0000", "385-628-0714", null, "Male" },
                    { 2178, "Lake Edwin", "2021", "EE35666", 1, "G82059", new DateTime(1978, 10, 16, 0, 0, 0, 0, DateTimeKind.Local), "Nora.Bergnaum@yahoo.com", "Nora", "Bergnaum", null, "Colombia", "0000", "1-480-884-4929 x800", null, "Female" },
                    { 2173, "Terryview", "2021", "EE41134", 1, "G375328", new DateTime(1984, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), "Thomas.Davis@gmail.com", "Thomas", "Davis", null, "Palestinian Territory", "0000", "523.864.5181", null, "Male" },
                    { 2165, "North Hermann", "2021", "EE45546", 1, "G105098", new DateTime(1978, 9, 9, 0, 0, 0, 0, DateTimeKind.Local), "Paulette_Wiegand@yahoo.com", "Paulette", "Wiegand", null, "Morocco", "0000", "(749) 355-0427 x666", null, "Female" },
                    { 2163, "West Nikita", "2021", "EE48956", 1, "G299524", new DateTime(1971, 4, 21, 0, 0, 0, 0, DateTimeKind.Local), "Casey.Moen3@hotmail.com", "Casey", "Moen", null, "Hungary", "0000", "1-200-806-0137", null, "Male" },
                    { 2159, "East Mayabury", "2021", "EE32054", 1, "G38291", new DateTime(1984, 11, 10, 0, 0, 0, 0, DateTimeKind.Local), "Traci3@hotmail.com", "Traci", "Will", null, "Monaco", "0000", "482.969.3974 x4324", null, "Female" },
                    { 2156, "South Noraton", "2021", "EE49079", 1, "G419608", new DateTime(1990, 3, 16, 0, 0, 0, 0, DateTimeKind.Local), "Lester_Nitzsche@hotmail.com", "Lester", "Nitzsche", null, "Djibouti", "0000", "1-903-527-3949", null, "Male" },
                    { 2145, "Turcotteberg", "2021", "EE10038", 1, "G49074", new DateTime(1995, 12, 11, 0, 0, 0, 0, DateTimeKind.Local), "Daryl.Block75@yahoo.com", "Daryl", "Block", null, "Monaco", "0000", "(605) 376-5560 x22592", null, "Male" },
                    { 2142, "Boganmouth", "2021", "EE7490", 1, "G566522", new DateTime(1981, 9, 27, 0, 0, 0, 0, DateTimeKind.Local), "Cedric.Hettinger14@yahoo.com", "Cedric", "Hettinger", null, "Democratic People's Republic of Korea", "0000", "814-237-6814", null, "Male" },
                    { 2130, "Osinskiland", "2021", "EE17683", 1, "G106842", new DateTime(1992, 4, 22, 0, 0, 0, 0, DateTimeKind.Local), "Ana.Kreiger55@yahoo.com", "Ana", "Kreiger", null, "Trinidad and Tobago", "0000", "(593) 471-9990", null, "Female" },
                    { 2127, "Langworthchester", "2021", "EE57505", 1, "G58543", new DateTime(1987, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), "Jaime35@gmail.com", "Jaime", "VonRueden", null, "Kuwait", "0000", "(910) 612-5829", null, "Female" },
                    { 2119, "West Erinshire", "2021", "EE46615", 1, "G243930", new DateTime(1976, 9, 25, 0, 0, 0, 0, DateTimeKind.Local), "Lamar.Conroy@hotmail.com", "Lamar", "Conroy", null, "Cocos (Keeling) Islands", "0000", "(437) 406-7547 x2687", null, "Male" },
                    { 2118, "Heidenreichmouth", "2021", "EE2934", 1, "G82256", new DateTime(2000, 3, 13, 0, 0, 0, 0, DateTimeKind.Local), "Marsha60@hotmail.com", "Marsha", "Jast", null, "Bhutan", "0000", "364-389-0006 x972", null, "Female" },
                    { 2113, "Roobmouth", "2021", "EE21156", 1, "G479741", new DateTime(1985, 4, 6, 0, 0, 0, 0, DateTimeKind.Local), "Garrett.Wunsch86@yahoo.com", "Garrett", "Wunsch", null, "Holy See (Vatican City State)", "0000", "249.742.2799 x0387", null, "Male" },
                    { 2111, "Nannieshire", "2021", "EE11640", 1, "G292611", new DateTime(1981, 12, 13, 0, 0, 0, 0, DateTimeKind.Local), "Maurice44@yahoo.com", "Maurice", "Treutel", null, "Maldives", "0000", "986.924.8268 x93079", null, "Male" },
                    { 2176, "West Elsaton", "2021", "EE38812", 1, "G44062", new DateTime(1983, 5, 28, 0, 0, 0, 0, DateTimeKind.Local), "Maggie.Lang@hotmail.com", "Maggie", "Lang", null, "Libyan Arab Jamahiriya", "0000", "(495) 632-2256", null, "Female" }
                });

            migrationBuilder.InsertData(
                table: "Etudiants",
                columns: new[] { "apogee", "address", "annee", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "ldn", "natio", "password", "phone", "picture", "sexe" },
                values: new object[,]
                {
                    { 2444, "Port Stefan", "2021", "EE32113", 3, "G413086", new DateTime(2000, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), "Charlotte.Bergnaum68@yahoo.com", "Charlotte", "Bergnaum", null, "Mali", "0000", "414.888.6987", null, "Female" },
                    { 2470, "East Amos", "2021", "EE26409", 3, "G574621", new DateTime(1999, 7, 16, 0, 0, 0, 0, DateTimeKind.Local), "Roman_Collins91@yahoo.com", "Roman", "Collins", null, "Namibia", "0000", "326.739.0768 x2114", null, "Male" },
                    { 2439, "Venabury", "2021", "EE36031", 3, "G178988", new DateTime(1951, 7, 13, 0, 0, 0, 0, DateTimeKind.Local), "Cathy_Lubowitz59@hotmail.com", "Cathy", "Lubowitz", null, "Tajikistan", "0000", "695.516.4360 x2097", null, "Female" },
                    { 2451, "McCluretown", "2021", "EE39710", 4, "G270899", new DateTime(1997, 6, 18, 0, 0, 0, 0, DateTimeKind.Local), "Rick_Maggio88@hotmail.com", "Rick", "Maggio", null, "Qatar", "0000", "698.230.2810 x98412", null, "Male" },
                    { 2450, "Lake Mckaylamouth", "2021", "EE48807", 4, "G261507", new DateTime(1997, 10, 12, 0, 0, 0, 0, DateTimeKind.Local), "Mack_Funk@hotmail.com", "Mack", "Funk", null, "Lebanon", "0000", "1-307-634-4215", null, "Male" },
                    { 2447, "Laurynstad", "2021", "EE50475", 4, "G457358", new DateTime(1974, 1, 18, 0, 0, 0, 0, DateTimeKind.Local), "Julio.Goldner@gmail.com", "Julio", "Goldner", null, "Antarctica (the territory South of 60 deg S)", "0000", "724-922-9198 x178", null, "Male" },
                    { 2445, "Nitzscheland", "2021", "EE50407", 4, "G400641", new DateTime(1978, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), "Frankie.Satterfield5@hotmail.com", "Frankie", "Satterfield", null, "Guinea-Bissau", "0000", "775.714.5718 x1941", null, "Male" },
                    { 2442, "Ulisesmouth", "2021", "EE16974", 4, "G212502", new DateTime(1965, 12, 9, 0, 0, 0, 0, DateTimeKind.Local), "Clara_Anderson@yahoo.com", "Clara", "Anderson", null, "Niger", "0000", "(774) 555-7268 x317", null, "Female" },
                    { 2426, "North Imani", "2021", "EE45593", 4, "G56794", new DateTime(1986, 2, 14, 0, 0, 0, 0, DateTimeKind.Local), "Ray39@hotmail.com", "Ray", "Oberbrunner", null, "Guernsey", "0000", "1-780-508-8196", null, "Male" },
                    { 2425, "West Tyson", "2021", "EE54132", 4, "G560773", new DateTime(1960, 9, 6, 0, 0, 0, 0, DateTimeKind.Local), "Dianna_Erdman@gmail.com", "Dianna", "Erdman", null, "Slovenia", "0000", "1-327-541-2770 x659", null, "Female" },
                    { 2417, "Roelfurt", "2021", "EE40774", 4, "G82680", new DateTime(1954, 5, 7, 0, 0, 0, 0, DateTimeKind.Local), "Felicia_Little37@gmail.com", "Felicia", "Little", null, "Sao Tome and Principe", "0000", "(332) 769-3950 x638", null, "Female" },
                    { 2416, "Lake Jerrold", "2021", "EE11717", 4, "G468850", new DateTime(1994, 1, 2, 0, 0, 0, 0, DateTimeKind.Local), "Velma_Morar64@yahoo.com", "Velma", "Morar", null, "Norway", "0000", "279.885.9690", null, "Female" },
                    { 2406, "North Millie", "2021", "EE8617", 4, "G250523", new DateTime(1960, 8, 6, 0, 0, 0, 0, DateTimeKind.Local), "Evan59@yahoo.com", "Evan", "Raynor", null, "New Zealand", "0000", "788.648.1737 x092", null, "Male" },
                    { 2405, "North Khalidton", "2021", "EE18900", 4, "G364491", new DateTime(1980, 10, 30, 0, 0, 0, 0, DateTimeKind.Local), "Jeremiah.Jacobs@yahoo.com", "Jeremiah", "Jacobs", null, "Mauritania", "0000", "1-505-455-0686 x46905", null, "Male" },
                    { 2402, "Port Berylmouth", "2021", "EE883", 4, "G243841", new DateTime(1994, 7, 2, 0, 0, 0, 0, DateTimeKind.Local), "Salvatore76@yahoo.com", "Salvatore", "Bogan", null, "Germany", "0000", "966-522-6221", null, "Male" },
                    { 2399, "Rafaelstad", "2021", "EE9455", 4, "G193427", new DateTime(1964, 3, 25, 0, 0, 0, 0, DateTimeKind.Local), "Ethel_Thompson84@gmail.com", "Ethel", "Thompson", null, "Barbados", "0000", "212.565.0176", null, "Female" },
                    { 2397, "North Kyler", "2021", "EE12674", 4, "G511904", new DateTime(1961, 10, 5, 0, 0, 0, 0, DateTimeKind.Local), "Tasha.Beatty@yahoo.com", "Tasha", "Beatty", null, "Somalia", "0000", "1-419-298-5168 x71775", null, "Female" },
                    { 2386, "New Cathrynside", "2021", "EE27399", 4, "G260944", new DateTime(1966, 5, 21, 0, 0, 0, 0, DateTimeKind.Local), "Willie_Champlin@hotmail.com", "Willie", "Champlin", null, "Guadeloupe", "0000", "(776) 379-9293", null, "Male" },
                    { 2373, "Pfefferfort", "2021", "EE50982", 4, "G107164", new DateTime(1959, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), "Kenneth.Bayer11@gmail.com", "Kenneth", "Bayer", null, "Nepal", "0000", "1-857-936-6039 x99292", null, "Male" },
                    { 2368, "North Desiree", "2021", "EE5534", 4, "G433391", new DateTime(1959, 6, 14, 0, 0, 0, 0, DateTimeKind.Local), "Courtney37@yahoo.com", "Courtney", "Vandervort", null, "Andorra", "0000", "(986) 254-5859", null, "Female" },
                    { 2365, "Feestside", "2021", "EE2572", 4, "G276345", new DateTime(1963, 3, 21, 0, 0, 0, 0, DateTimeKind.Local), "Jenny.Borer@yahoo.com", "Jenny", "Borer", null, "Palau", "0000", "616-339-4646 x11243", null, "Female" },
                    { 2355, "Port Raymondstad", "2021", "EE53738", 4, "G587220", new DateTime(1979, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), "Bradford.Morissette@gmail.com", "Bradford", "Morissette", null, "Kyrgyz Republic", "0000", "299-634-5598 x43508", null, "Male" },
                    { 2352, "South Esta", "2021", "EE55929", 4, "G568942", new DateTime(1990, 5, 2, 0, 0, 0, 0, DateTimeKind.Local), "Anita64@hotmail.com", "Anita", "Grady", null, "Democratic People's Republic of Korea", "0000", "469-266-4077 x88813", null, "Female" },
                    { 2351, "Townemouth", "2021", "EE46691", 4, "G336935", new DateTime(1989, 3, 30, 0, 0, 0, 0, DateTimeKind.Local), "Pedro67@hotmail.com", "Pedro", "Erdman", null, "Palestinian Territory", "0000", "1-881-317-7680 x22931", null, "Male" },
                    { 2350, "Port Alexzander", "2021", "EE872", 4, "G458284", new DateTime(1958, 9, 27, 0, 0, 0, 0, DateTimeKind.Local), "Al_Roberts@hotmail.com", "Al", "Roberts", null, "Guam", "0000", "372.861.0017 x3263", null, "Male" },
                    { 2346, "West Kielland", "2021", "EE18718", 4, "G476706", new DateTime(1972, 8, 28, 0, 0, 0, 0, DateTimeKind.Local), "Beth7@hotmail.com", "Beth", "Effertz", null, "Portugal", "0000", "767-410-7016 x740", null, "Female" },
                    { 2337, "South Shadtown", "2021", "EE44293", 4, "G56013", new DateTime(1971, 3, 30, 0, 0, 0, 0, DateTimeKind.Local), "Amber_Blick@hotmail.com", "Amber", "Blick", null, "Solomon Islands", "0000", "784.806.3547 x2622", null, "Female" },
                    { 2335, "New Chadd", "2021", "EE31890", 4, "G315926", new DateTime(1975, 10, 12, 0, 0, 0, 0, DateTimeKind.Local), "Sheri_Kutch92@yahoo.com", "Sheri", "Kutch", null, "Brunei Darussalam", "0000", "(484) 977-8024", null, "Female" },
                    { 2334, "New Rosaliafort", "2021", "EE34812", 4, "G357162", new DateTime(1964, 2, 13, 0, 0, 0, 0, DateTimeKind.Local), "Derrick47@yahoo.com", "Derrick", "Beatty", null, "Bolivia", "0000", "275-688-5562 x5389", null, "Male" },
                    { 2332, "Emmerichburgh", "2021", "EE270", 4, "G500875", new DateTime(1987, 2, 22, 0, 0, 0, 0, DateTimeKind.Local), "Ernestine_Dickinson97@hotmail.com", "Ernestine", "Dickinson", null, "Wallis and Futuna", "0000", "1-963-946-9965 x195", null, "Female" },
                    { 2461, "Keelingmouth", "2021", "EE52643", 4, "G38621", new DateTime(1977, 7, 23, 0, 0, 0, 0, DateTimeKind.Local), "Alfonso_Mosciski@hotmail.com", "Alfonso", "Mosciski", null, "Palau", "0000", "1-213-683-5656", null, "Male" },
                    { 2331, "North Nella", "2021", "EE49031", 4, "G25059", new DateTime(1992, 7, 6, 0, 0, 0, 0, DateTimeKind.Local), "Lyle_Ryan74@hotmail.com", "Lyle", "Ryan", null, "Burundi", "0000", "1-383-846-8689", null, "Male" },
                    { 2464, "West Euna", "2021", "EE9957", 4, "G199324", new DateTime(1955, 10, 21, 0, 0, 0, 0, DateTimeKind.Local), "Camille41@hotmail.com", "Camille", "Waelchi", null, "Georgia", "0000", "980.901.1330 x35581", null, "Female" },
                    { 2472, "Francofort", "2021", "EE35107", 4, "G225181", new DateTime(1978, 12, 9, 0, 0, 0, 0, DateTimeKind.Local), "Silvia.Larkin7@hotmail.com", "Silvia", "Larkin", null, "Nepal", "0000", "456-963-0949", null, "Female" },
                    { 2037, "Kristofferfort", "2021", "EE16072", 3, "G75361", new DateTime(1961, 8, 30, 0, 0, 0, 0, DateTimeKind.Local), "Brent_Murazik@yahoo.com", "Brent", "Murazik", null, "Guatemala", "0000", "1-822-305-5468 x7125", null, "Male" },
                    { 2036, "Lake Mohammadburgh", "2021", "EE9385", 3, "G95973", new DateTime(1997, 3, 19, 0, 0, 0, 0, DateTimeKind.Local), "Miriam_Jerde@hotmail.com", "Miriam", "Jerde", null, "Congo", "0000", "809.819.7036", null, "Female" },
                    { 2028, "New Xander", "2021", "EE20976", 3, "G24804", new DateTime(1996, 3, 12, 0, 0, 0, 0, DateTimeKind.Local), "Shawna_Ratke87@hotmail.com", "Shawna", "Ratke", null, "Niger", "0000", "(778) 418-2272 x57062", null, "Female" },
                    { 2025, "East Torreystad", "2021", "EE7401", 3, "G490007", new DateTime(1952, 12, 3, 0, 0, 0, 0, DateTimeKind.Local), "Henrietta51@hotmail.com", "Henrietta", "Hayes", null, "Heard Island and McDonald Islands", "0000", "920.675.9075", null, "Female" },
                    { 2015, "Port Cordiaberg", "2021", "EE53861", 3, "G256496", new DateTime(1957, 7, 16, 0, 0, 0, 0, DateTimeKind.Local), "Thomas90@gmail.com", "Thomas", "Reilly", null, "Antigua and Barbuda", "0000", "582.913.2708", null, "Male" },
                    { 2009, "Pagacburgh", "2021", "EE37483", 3, "G61787", new DateTime(1955, 1, 29, 0, 0, 0, 0, DateTimeKind.Local), "Cesar.Ankunding@yahoo.com", "Cesar", "Ankunding", null, "Italy", "0000", "809-246-7308", null, "Male" },
                    { 2007, "Hankside", "2021", "EE9337", 3, "G593024", new DateTime(1961, 4, 28, 0, 0, 0, 0, DateTimeKind.Local), "Keith.Monahan@yahoo.com", "Keith", "Monahan", null, "Sudan", "0000", "(369) 568-4554", null, "Male" },
                    { 2032, "Lake Pasqualefurt", "2021", "EE2262", 4, "G353582", new DateTime(2000, 10, 29, 0, 0, 0, 0, DateTimeKind.Local), "Betty6@hotmail.com", "Betty", "Harvey", null, "Germany", "0000", "623.813.7130 x3041", null, "Female" }
                });

            migrationBuilder.InsertData(
                table: "Etudiants",
                columns: new[] { "apogee", "address", "annee", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "ldn", "natio", "password", "phone", "picture", "sexe" },
                values: new object[,]
                {
                    { 2042, "Alannabury", "2021", "EE45582", 4, "G308838", new DateTime(1995, 4, 16, 0, 0, 0, 0, DateTimeKind.Local), "Erik66@gmail.com", "Erik", "Bogan", null, "Namibia", "0000", "219.520.3668 x667", null, "Male" },
                    { 2443, "North Rahulville", "2021", "EE23038", 3, "G335583", new DateTime(1958, 6, 2, 0, 0, 0, 0, DateTimeKind.Local), "Jodi67@hotmail.com", "Jodi", "O'Kon", null, "Northern Mariana Islands", "0000", "(966) 876-2306", null, "Female" },
                    { 2050, "East Santos", "2021", "EE28953", 4, "G103623", new DateTime(1984, 6, 18, 0, 0, 0, 0, DateTimeKind.Local), "Marcus.Grant@hotmail.com", "Marcus", "Grant", null, "Croatia", "0000", "1-574-660-4080", null, "Male" },
                    { 2051, "Keeblerport", "2021", "EE38360", 4, "G32540", new DateTime(1966, 6, 23, 0, 0, 0, 0, DateTimeKind.Local), "Orville_Rutherford@yahoo.com", "Orville", "Rutherford", null, "Sierra Leone", "0000", "596.816.6962 x65046", null, "Male" },
                    { 2060, "Shanellebury", "2021", "EE54258", 4, "G595652", new DateTime(1968, 9, 30, 0, 0, 0, 0, DateTimeKind.Local), "Jackie.Pagac@yahoo.com", "Jackie", "Pagac", null, "Malta", "0000", "1-945-761-0045", null, "Female" },
                    { 2064, "East Jamaalside", "2021", "EE36371", 4, "G295384", new DateTime(1983, 6, 17, 0, 0, 0, 0, DateTimeKind.Local), "Alejandro.Kovacek34@yahoo.com", "Alejandro", "Kovacek", null, "Moldova", "0000", "(392) 492-2860", null, "Male" },
                    { 2067, "Port Rustyfort", "2021", "EE39875", 4, "G96482", new DateTime(1979, 10, 17, 0, 0, 0, 0, DateTimeKind.Local), "Merle91@hotmail.com", "Merle", "Ryan", null, "Cameroon", "0000", "959.367.8931 x446", null, "Male" },
                    { 2069, "North Gwen", "2021", "EE32916", 4, "G318322", new DateTime(1993, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), "Floyd37@yahoo.com", "Floyd", "Brown", null, "Guam", "0000", "465-430-1056 x710", null, "Male" },
                    { 2081, "Georgiannahaven", "2021", "EE2138", 4, "G33150", new DateTime(1975, 4, 19, 0, 0, 0, 0, DateTimeKind.Local), "Mabel17@yahoo.com", "Mabel", "Metz", null, "United Arab Emirates", "0000", "1-200-877-8211", null, "Female" },
                    { 2086, "West Eliseohaven", "2021", "EE15216", 4, "G305834", new DateTime(1984, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), "Leland_Rau62@yahoo.com", "Leland", "Rau", null, "Belgium", "0000", "697-309-7058 x397", null, "Male" },
                    { 2088, "South Laurinehaven", "2021", "EE45085", 4, "G105223", new DateTime(1992, 11, 3, 0, 0, 0, 0, DateTimeKind.Local), "Simon.Shanahan38@gmail.com", "Simon", "Shanahan", null, "Solomon Islands", "0000", "(404) 720-1709", null, "Male" },
                    { 2089, "North Reilly", "2021", "EE12944", 4, "G123086", new DateTime(1998, 9, 14, 0, 0, 0, 0, DateTimeKind.Local), "Lucia.Emard29@yahoo.com", "Lucia", "Emard", null, "Cyprus", "0000", "(965) 351-8790 x8508", null, "Female" },
                    { 2497, "Harriston", "2021", "EE16338", 4, "G396820", new DateTime(1960, 10, 15, 0, 0, 0, 0, DateTimeKind.Local), "Donald63@gmail.com", "Donald", "Lakin", null, "Moldova", "0000", "1-310-875-3719 x23940", null, "Male" },
                    { 2489, "North Guillermo", "2021", "EE25061", 4, "G225121", new DateTime(1967, 2, 28, 0, 0, 0, 0, DateTimeKind.Local), "Jody.White2@yahoo.com", "Jody", "White", null, "Northern Mariana Islands", "0000", "988-866-1544 x195", null, "Male" },
                    { 2485, "West Barrett", "2021", "EE20508", 4, "G537980", new DateTime(1963, 11, 3, 0, 0, 0, 0, DateTimeKind.Local), "Brendan.Sawayn15@gmail.com", "Brendan", "Sawayn", null, "New Caledonia", "0000", "711-479-9136 x5533", null, "Male" },
                    { 2480, "North Ellie", "2021", "EE59277", 4, "G120985", new DateTime(1955, 8, 24, 0, 0, 0, 0, DateTimeKind.Local), "Cynthia_Fisher72@gmail.com", "Cynthia", "Fisher", null, "Solomon Islands", "0000", "215.992.9337 x611", null, "Female" },
                    { 2478, "Chesterborough", "2021", "EE7318", 4, "G498375", new DateTime(1981, 3, 14, 0, 0, 0, 0, DateTimeKind.Local), "Martha.Block@gmail.com", "Martha", "Block", null, "French Southern Territories", "0000", "948.449.4037", null, "Female" },
                    { 2475, "Darenmouth", "2021", "EE21356", 4, "G31710", new DateTime(1987, 4, 25, 0, 0, 0, 0, DateTimeKind.Local), "Desiree_Mante@gmail.com", "Desiree", "Mante", null, "Saint Kitts and Nevis", "0000", "279.353.1197 x8418", null, "Female" },
                    { 2474, "New Lottieside", "2021", "EE33442", 4, "G594964", new DateTime(1959, 2, 12, 0, 0, 0, 0, DateTimeKind.Local), "Veronica59@gmail.com", "Veronica", "O'Kon", null, "Tonga", "0000", "1-353-372-9639 x4225", null, "Female" },
                    { 2467, "New Elwinport", "2021", "EE25717", 4, "G160201", new DateTime(1984, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), "Jacqueline_Conroy83@yahoo.com", "Jacqueline", "Conroy", null, "Slovenia", "0000", "460-285-2400 x91505", null, "Female" },
                    { 2038, "Langworthtown", "2021", "EE31315", 3, "G575723", new DateTime(1965, 10, 13, 0, 0, 0, 0, DateTimeKind.Local), "Greg1@hotmail.com", "Greg", "Gutkowski", null, "Maldives", "0000", "930-538-7707 x70817", null, "Male" },
                    { 2326, "Weberville", "2021", "EE45249", 4, "G398102", new DateTime(1959, 1, 29, 0, 0, 0, 0, DateTimeKind.Local), "Betty65@gmail.com", "Betty", "Harber", null, "Morocco", "0000", "1-451-964-7941 x353", null, "Female" },
                    { 2321, "Port Lorenza", "2021", "EE36355", 4, "G251623", new DateTime(1974, 10, 1, 0, 0, 0, 0, DateTimeKind.Local), "Jean.Windler97@gmail.com", "Jean", "Windler", null, "Grenada", "0000", "(417) 725-4871", null, "Male" },
                    { 2179, "Kianmouth", "2021", "EE33238", 4, "G293420", new DateTime(1962, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), "Brandon_Donnelly@yahoo.com", "Brandon", "Donnelly", null, "Syrian Arab Republic", "0000", "878-581-0135 x31024", null, "Male" },
                    { 2175, "Katelynstad", "2021", "EE6943", 4, "G16545", new DateTime(1959, 2, 5, 0, 0, 0, 0, DateTimeKind.Local), "Nicholas_Hane0@yahoo.com", "Nicholas", "Hane", null, "Kazakhstan", "0000", "664-771-2229", null, "Male" },
                    { 2174, "Handtown", "2021", "EE2568", 4, "G356020", new DateTime(1969, 1, 12, 0, 0, 0, 0, DateTimeKind.Local), "Geraldine_Batz@yahoo.com", "Geraldine", "Batz", null, "Equatorial Guinea", "0000", "671-771-3283 x855", null, "Female" },
                    { 2172, "Hintzfurt", "2021", "EE9281", 4, "G485615", new DateTime(1962, 1, 25, 0, 0, 0, 0, DateTimeKind.Local), "Edward.Kunde@hotmail.com", "Edward", "Kunde", null, "Belize", "0000", "542-525-7431", null, "Male" },
                    { 2171, "Schadenland", "2021", "EE59137", 4, "G452374", new DateTime(1969, 1, 12, 0, 0, 0, 0, DateTimeKind.Local), "Albert_Greenfelder96@hotmail.com", "Albert", "Greenfelder", null, "Grenada", "0000", "796.689.2723", null, "Male" },
                    { 2168, "Nitzscheton", "2021", "EE55263", 4, "G328447", new DateTime(1958, 10, 6, 0, 0, 0, 0, DateTimeKind.Local), "Guillermo17@gmail.com", "Guillermo", "Huel", null, "Democratic People's Republic of Korea", "0000", "(491) 949-5339 x61571", null, "Male" },
                    { 2167, "New Dock", "2021", "EE54062", 4, "G408688", new DateTime(1974, 12, 31, 0, 0, 0, 0, DateTimeKind.Local), "Aaron.Wyman@hotmail.com", "Aaron", "Wyman", null, "Belize", "0000", "(350) 406-7745 x56047", null, "Male" },
                    { 2160, "Ornberg", "2021", "EE12329", 4, "G163383", new DateTime(1951, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), "Caroline.Huels74@gmail.com", "Caroline", "Huels", null, "Virgin Islands, British", "0000", "253-796-3101 x8676", null, "Female" },
                    { 2158, "West Amiebury", "2021", "EE33845", 4, "G380076", new DateTime(1970, 1, 8, 0, 0, 0, 0, DateTimeKind.Local), "Eileen75@hotmail.com", "Eileen", "Gaylord", null, "Cuba", "0000", "1-451-344-8307 x862", null, "Female" },
                    { 2155, "Kennashire", "2021", "EE15591", 4, "G70991", new DateTime(1965, 9, 20, 0, 0, 0, 0, DateTimeKind.Local), "Johanna_McCullough@hotmail.com", "Johanna", "McCullough", null, "Kyrgyz Republic", "0000", "656.761.5507 x4136", null, "Female" },
                    { 2154, "South Gianni", "2021", "EE170", 4, "G307034", new DateTime(1959, 4, 6, 0, 0, 0, 0, DateTimeKind.Local), "Scott64@hotmail.com", "Scott", "Aufderhar", null, "Afghanistan", "0000", "(515) 872-4893 x229", null, "Male" },
                    { 2153, "Wymanmouth", "2021", "EE55520", 4, "G510279", new DateTime(1992, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), "Theodore28@hotmail.com", "Theodore", "Barton", null, "Brazil", "0000", "629.848.1395 x9894", null, "Male" },
                    { 2149, "Williamsonbury", "2021", "EE35574", 4, "G499620", new DateTime(1967, 12, 28, 0, 0, 0, 0, DateTimeKind.Local), "Carolyn_Hoppe75@yahoo.com", "Carolyn", "Hoppe", null, "Turkmenistan", "0000", "829-472-3533 x00289", null, "Female" },
                    { 2148, "Kutchshire", "2021", "EE27883", 4, "G439260", new DateTime(1958, 12, 4, 0, 0, 0, 0, DateTimeKind.Local), "Jeremy.McClure@hotmail.com", "Jeremy", "McClure", null, "Pitcairn Islands", "0000", "540.830.6619 x57670", null, "Male" },
                    { 2144, "Bodeborough", "2021", "EE55386", 4, "G411774", new DateTime(1998, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), "Jeffery.Hegmann@gmail.com", "Jeffery", "Hegmann", null, "Falkland Islands (Malvinas)", "0000", "517.378.2676 x55360", null, "Male" },
                    { 2143, "Rowenastad", "2021", "EE43787", 4, "G283771", new DateTime(1955, 4, 29, 0, 0, 0, 0, DateTimeKind.Local), "Rafael67@gmail.com", "Rafael", "Marquardt", null, "Algeria", "0000", "(972) 246-8651 x825", null, "Male" },
                    { 2132, "Port Ursulaberg", "2021", "EE45794", 4, "G545843", new DateTime(1998, 1, 11, 0, 0, 0, 0, DateTimeKind.Local), "Sadie.Kuhic69@yahoo.com", "Sadie", "Kuhic", null, "Senegal", "0000", "1-536-480-4013", null, "Female" },
                    { 2123, "Naderbury", "2021", "EE10107", 4, "G84886", new DateTime(1986, 5, 1, 0, 0, 0, 0, DateTimeKind.Local), "Elisa73@yahoo.com", "Elisa", "Koelpin", null, "Gibraltar", "0000", "850.751.0308 x3400", null, "Female" },
                    { 2122, "Kalebshire", "2021", "EE12372", 4, "G101103", new DateTime(1966, 9, 22, 0, 0, 0, 0, DateTimeKind.Local), "Nora.Weissnat9@yahoo.com", "Nora", "Weissnat", null, "Iran", "0000", "950.763.9305", null, "Female" }
                });

            migrationBuilder.InsertData(
                table: "Etudiants",
                columns: new[] { "apogee", "address", "annee", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "ldn", "natio", "password", "phone", "picture", "sexe" },
                values: new object[,]
                {
                    { 2120, "North Yadiraside", "2021", "EE3323", 4, "G23309", new DateTime(1988, 1, 27, 0, 0, 0, 0, DateTimeKind.Local), "Patty.Kassulke@gmail.com", "Patty", "Kassulke", null, "South Georgia and the South Sandwich Islands", "0000", "701.897.1026", null, "Female" },
                    { 2116, "Tessieport", "2021", "EE28496", 4, "G214341", new DateTime(1987, 12, 4, 0, 0, 0, 0, DateTimeKind.Local), "Meghan.Balistreri@yahoo.com", "Meghan", "Balistreri", null, "Malawi", "0000", "1-590-676-9239 x583", null, "Female" },
                    { 2110, "Derekfurt", "2021", "EE39417", 4, "G189839", new DateTime(1961, 1, 20, 0, 0, 0, 0, DateTimeKind.Local), "Antonia_Leffler@hotmail.com", "Antonia", "Leffler", null, "Turkmenistan", "0000", "481.870.2241 x8131", null, "Female" },
                    { 2105, "East Aureliafort", "2021", "EE34237", 4, "G410371", new DateTime(1988, 7, 10, 0, 0, 0, 0, DateTimeKind.Local), "Bill.Pollich@hotmail.com", "Bill", "Pollich", null, "Puerto Rico", "0000", "854.797.9749 x90251", null, "Male" },
                    { 2104, "Port Johnpaul", "2021", "EE40915", 4, "G509886", new DateTime(1988, 5, 5, 0, 0, 0, 0, DateTimeKind.Local), "Bert.Torphy@gmail.com", "Bert", "Torphy", null, "Montenegro", "0000", "882.427.9094", null, "Male" },
                    { 2100, "Cheyannehaven", "2021", "EE27114", 4, "G82866", new DateTime(1964, 4, 6, 0, 0, 0, 0, DateTimeKind.Local), "Ginger_Lubowitz@yahoo.com", "Ginger", "Lubowitz", null, "Spain", "0000", "713.376.2687 x2100", null, "Female" },
                    { 2094, "East Adolphusborough", "2021", "EE23584", 4, "G13981", new DateTime(1988, 1, 8, 0, 0, 0, 0, DateTimeKind.Local), "Elsa_Kessler@hotmail.com", "Elsa", "Kessler", null, "Burundi", "0000", "878.516.4751 x81131", null, "Female" },
                    { 2093, "Ondrickaton", "2021", "EE41890", 4, "G312395", new DateTime(1965, 1, 30, 0, 0, 0, 0, DateTimeKind.Local), "Barry_Tillman@gmail.com", "Barry", "Tillman", null, "Poland", "0000", "409-379-1851 x52139", null, "Male" },
                    { 2183, "Port Charity", "2021", "EE25702", 4, "G394004", new DateTime(1976, 5, 8, 0, 0, 0, 0, DateTimeKind.Local), "Catherine_Gorczany92@hotmail.com", "Catherine", "Gorczany", null, "United States Minor Outlying Islands", "0000", "1-612-634-1619 x9381", null, "Female" },
                    { 2323, "Lake Cornell", "2021", "EE20850", 4, "G280098", new DateTime(1958, 8, 8, 0, 0, 0, 0, DateTimeKind.Local), "Kim.Koelpin56@gmail.com", "Kim", "Koelpin", null, "Barbados", "0000", "461-617-6590", null, "Male" },
                    { 2184, "Maggioville", "2021", "EE24765", 4, "G48713", new DateTime(1965, 6, 8, 0, 0, 0, 0, DateTimeKind.Local), "Jody.Bergstrom55@gmail.com", "Jody", "Bergstrom", null, "Mayotte", "0000", "208-486-2246", null, "Female" },
                    { 2186, "Mortimerborough", "2021", "EE43578", 4, "G93547", new DateTime(1960, 8, 1, 0, 0, 0, 0, DateTimeKind.Local), "Sean_Douglas@gmail.com", "Sean", "Douglas", null, "Cape Verde", "0000", "965.376.5812 x11721", null, "Male" },
                    { 2312, "North Natasha", "2021", "EE49825", 4, "G480334", new DateTime(1980, 7, 30, 0, 0, 0, 0, DateTimeKind.Local), "Iris.Kuvalis11@gmail.com", "Iris", "Kuvalis", null, "Mongolia", "0000", "502.863.5207 x488", null, "Female" },
                    { 2310, "Flatleyfurt", "2021", "EE16797", 4, "G189069", new DateTime(1962, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), "Celia_Spencer10@yahoo.com", "Celia", "Spencer", null, "Lao People's Democratic Republic", "0000", "545.781.8705", null, "Female" },
                    { 2304, "Lake Nilsfurt", "2021", "EE53606", 4, "G583100", new DateTime(1992, 9, 12, 0, 0, 0, 0, DateTimeKind.Local), "Shelly95@gmail.com", "Shelly", "Sipes", null, "Moldova", "0000", "455-337-2761 x43573", null, "Female" },
                    { 2297, "Lake Eloisefort", "2021", "EE703", 4, "G39012", new DateTime(1961, 9, 24, 0, 0, 0, 0, DateTimeKind.Local), "Dorothy_Schroeder@hotmail.com", "Dorothy", "Schroeder", null, "Albania", "0000", "840-661-0565", null, "Female" },
                    { 2292, "South Otis", "2021", "EE39607", 4, "G562256", new DateTime(1960, 8, 20, 0, 0, 0, 0, DateTimeKind.Local), "Damon.Hodkiewicz@gmail.com", "Damon", "Hodkiewicz", null, "Cocos (Keeling) Islands", "0000", "602-203-8494 x137", null, "Male" },
                    { 2287, "North Chance", "2021", "EE56339", 4, "G333955", new DateTime(1982, 12, 17, 0, 0, 0, 0, DateTimeKind.Local), "Omar86@yahoo.com", "Omar", "Schulist", null, "Mali", "0000", "992.855.4150", null, "Male" },
                    { 2286, "South Antoinettemouth", "2021", "EE11995", 4, "G469596", new DateTime(1991, 4, 7, 0, 0, 0, 0, DateTimeKind.Local), "Jim83@gmail.com", "Jim", "Frami", null, "Pakistan", "0000", "1-332-374-7395", null, "Male" },
                    { 2284, "East Harry", "2021", "EE3476", 4, "G78141", new DateTime(1954, 3, 29, 0, 0, 0, 0, DateTimeKind.Local), "Ellen.Fadel@yahoo.com", "Ellen", "Fadel", null, "Guyana", "0000", "1-481-308-8478", null, "Female" },
                    { 2277, "Port Gerardotown", "2021", "EE7374", 4, "G97009", new DateTime(1971, 4, 29, 0, 0, 0, 0, DateTimeKind.Local), "Earnest69@hotmail.com", "Earnest", "Erdman", null, "Kiribati", "0000", "759-619-4606 x7412", null, "Male" },
                    { 2276, "Zionview", "2021", "EE36579", 4, "G563496", new DateTime(1974, 9, 6, 0, 0, 0, 0, DateTimeKind.Local), "Myra.Dooley28@gmail.com", "Myra", "Dooley", null, "Germany", "0000", "1-425-681-9768 x98148", null, "Female" },
                    { 2268, "North Hadleyborough", "2021", "EE34541", 4, "G319133", new DateTime(1983, 10, 2, 0, 0, 0, 0, DateTimeKind.Local), "Calvin98@hotmail.com", "Calvin", "Okuneva", null, "Vietnam", "0000", "703-498-0369", null, "Male" },
                    { 2263, "Laruehaven", "2021", "EE33813", 4, "G277607", new DateTime(1990, 12, 22, 0, 0, 0, 0, DateTimeKind.Local), "Velma_Schowalter@yahoo.com", "Velma", "Schowalter", null, "Chile", "0000", "(480) 353-5963", null, "Female" },
                    { 2259, "Boscostad", "2021", "EE14999", 4, "G364208", new DateTime(1961, 11, 10, 0, 0, 0, 0, DateTimeKind.Local), "Kelley_OReilly@gmail.com", "Kelley", "O'Reilly", null, "Ecuador", "0000", "(890) 348-9442 x432", null, "Female" },
                    { 2258, "North Daisyton", "2021", "EE18102", 4, "G214082", new DateTime(1955, 5, 13, 0, 0, 0, 0, DateTimeKind.Local), "Natasha79@gmail.com", "Natasha", "Powlowski", null, "Tuvalu", "0000", "799-472-8137 x057", null, "Female" },
                    { 2248, "Solonburgh", "2021", "EE43730", 4, "G72011", new DateTime(1951, 9, 25, 0, 0, 0, 0, DateTimeKind.Local), "Fred_Ruecker@yahoo.com", "Fred", "Ruecker", null, "Maldives", "0000", "1-596-404-6614 x33890", null, "Male" },
                    { 2243, "Shaunborough", "2021", "EE6944", 4, "G181722", new DateTime(1961, 4, 6, 0, 0, 0, 0, DateTimeKind.Local), "Paulette39@yahoo.com", "Paulette", "Daugherty", null, "Vanuatu", "0000", "(749) 400-3449 x46168", null, "Female" },
                    { 2241, "South Brendonton", "2021", "EE34200", 4, "G379545", new DateTime(1955, 5, 27, 0, 0, 0, 0, DateTimeKind.Local), "Dolores_Torphy@yahoo.com", "Dolores", "Torphy", null, "Maldives", "0000", "727.324.4899", null, "Female" },
                    { 2236, "East Brandtport", "2021", "EE19945", 4, "G543259", new DateTime(1957, 4, 11, 0, 0, 0, 0, DateTimeKind.Local), "Marcos_Kub@gmail.com", "Marcos", "Kub", null, "Italy", "0000", "(329) 684-3788", null, "Male" },
                    { 2231, "Medhurstchester", "2021", "EE58912", 4, "G395698", new DateTime(1993, 2, 12, 0, 0, 0, 0, DateTimeKind.Local), "Irene.Jacobs@hotmail.com", "Irene", "Jacobs", null, "Iran", "0000", "1-522-809-6146", null, "Female" },
                    { 2229, "Port Flo", "2021", "EE15660", 4, "G263257", new DateTime(1968, 11, 15, 0, 0, 0, 0, DateTimeKind.Local), "Cody.West57@hotmail.com", "Cody", "West", null, "Saint Lucia", "0000", "424.554.5792", null, "Male" },
                    { 2223, "South Kendall", "2021", "EE34886", 4, "G206984", new DateTime(1989, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), "Matthew.Schoen79@yahoo.com", "Matthew", "Schoen", null, "Iraq", "0000", "761.445.4514 x82476", null, "Male" },
                    { 2219, "Port Juana", "2021", "EE29559", 4, "G401125", new DateTime(1980, 1, 31, 0, 0, 0, 0, DateTimeKind.Local), "Frederick_Crona@hotmail.com", "Frederick", "Crona", null, "Slovakia (Slovak Republic)", "0000", "1-436-568-8593 x0032", null, "Male" },
                    { 2213, "Sandrineshire", "2021", "EE47927", 4, "G410654", new DateTime(1968, 11, 6, 0, 0, 0, 0, DateTimeKind.Local), "Howard73@yahoo.com", "Howard", "Dickinson", null, "American Samoa", "0000", "(450) 893-1380 x79066", null, "Male" },
                    { 2211, "Lake Mason", "2021", "EE14764", 4, "G283941", new DateTime(1975, 12, 6, 0, 0, 0, 0, DateTimeKind.Local), "Corey.Herzog72@yahoo.com", "Corey", "Herzog", null, "Philippines", "0000", "(507) 430-0519 x608", null, "Male" },
                    { 2209, "Gaylefort", "2021", "EE46385", 4, "G370045", new DateTime(1995, 10, 4, 0, 0, 0, 0, DateTimeKind.Local), "Luther.Watsica@hotmail.com", "Luther", "Watsica", null, "Saint Pierre and Miquelon", "0000", "(811) 238-1934 x612", null, "Male" },
                    { 2198, "Hodkiewiczbury", "2021", "EE16442", 4, "G415216", new DateTime(1998, 3, 12, 0, 0, 0, 0, DateTimeKind.Local), "Bennie2@hotmail.com", "Bennie", "Jenkins", null, "Uruguay", "0000", "1-638-250-4734 x269", null, "Male" },
                    { 2191, "West Jazmyneville", "2021", "EE25105", 4, "G135126", new DateTime(2000, 11, 20, 0, 0, 0, 0, DateTimeKind.Local), "Rachel86@yahoo.com", "Rachel", "Hickle", null, "Slovenia", "0000", "(248) 272-6720", null, "Female" },
                    { 2185, "East Theresia", "2021", "EE47245", 4, "G180529", new DateTime(1964, 10, 5, 0, 0, 0, 0, DateTimeKind.Local), "Fannie98@hotmail.com", "Fannie", "Keeling", null, "Faroe Islands", "0000", "1-636-588-6152 x45736", null, "Female" },
                    { 2091, "Lake Sofia", "2021", "EE21123", 4, "G307177", new DateTime(1956, 8, 1, 0, 0, 0, 0, DateTimeKind.Local), "Ellen93@hotmail.com", "Ellen", "Herman", null, "Guernsey", "0000", "627.388.1592 x752", null, "Female" },
                    { 2041, "Lake Joelle", "2021", "EE59385", 3, "G95974", new DateTime(1978, 12, 20, 0, 0, 0, 0, DateTimeKind.Local), "Georgia53@yahoo.com", "Georgia", "Cruickshank", null, "Turks and Caicos Islands", "0000", "891-782-6952", null, "Female" }
                });

            migrationBuilder.InsertData(
                table: "Etudiants",
                columns: new[] { "apogee", "address", "annee", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "ldn", "natio", "password", "phone", "picture", "sexe" },
                values: new object[,]
                {
                    { 2047, "Wittingborough", "2021", "EE58793", 3, "G116267", new DateTime(1971, 9, 10, 0, 0, 0, 0, DateTimeKind.Local), "Merle40@hotmail.com", "Merle", "Mante", null, "Syrian Arab Republic", "0000", "675-236-6428 x973", null, "Male" },
                    { 2361, "Hahnside", "2021", "EE37342", 3, "G325548", new DateTime(1973, 10, 14, 0, 0, 0, 0, DateTimeKind.Local), "Edgar_Mueller@yahoo.com", "Edgar", "Mueller", null, "Heard Island and McDonald Islands", "0000", "254-209-8308 x66294", null, "Male" },
                    { 2360, "Louveniaside", "2021", "EE30199", 3, "G134776", new DateTime(1990, 12, 12, 0, 0, 0, 0, DateTimeKind.Local), "Verna80@gmail.com", "Verna", "Koss", null, "Micronesia", "0000", "1-937-354-2490 x40004", null, "Female" },
                    { 2356, "Kiehnton", "2021", "EE13931", 3, "G576628", new DateTime(1998, 1, 21, 0, 0, 0, 0, DateTimeKind.Local), "Elsa_Lesch@gmail.com", "Elsa", "Lesch", null, "Saint Kitts and Nevis", "0000", "697-354-3951 x3766", null, "Female" },
                    { 2349, "Thompsonhaven", "2021", "EE23324", 3, "G408257", new DateTime(1985, 5, 15, 0, 0, 0, 0, DateTimeKind.Local), "Margaret39@gmail.com", "Margaret", "Greenfelder", null, "Russian Federation", "0000", "(450) 907-0512 x09708", null, "Female" },
                    { 2342, "Port Mateomouth", "2021", "EE25349", 3, "G10186", new DateTime(1980, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), "Rachel_Wilkinson31@gmail.com", "Rachel", "Wilkinson", null, "Suriname", "0000", "(273) 585-8174", null, "Female" },
                    { 2338, "Micaelafort", "2021", "EE6878", 3, "G14812", new DateTime(1967, 7, 23, 0, 0, 0, 0, DateTimeKind.Local), "Miriam4@hotmail.com", "Miriam", "Borer", null, "Qatar", "0000", "(626) 403-5703", null, "Female" },
                    { 2333, "North Ambershire", "2021", "EE52361", 3, "G481239", new DateTime(1958, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), "Ora_Langworth@yahoo.com", "Ora", "Langworth", null, "Bosnia and Herzegovina", "0000", "913-594-1508", null, "Female" },
                    { 2327, "Reeceshire", "2021", "EE44882", 3, "G169274", new DateTime(1970, 7, 29, 0, 0, 0, 0, DateTimeKind.Local), "Hazel_Hintz64@yahoo.com", "Hazel", "Hintz", null, "Isle of Man", "0000", "(522) 345-9182", null, "Female" },
                    { 2325, "Armanistad", "2021", "EE51490", 3, "G552751", new DateTime(1977, 12, 16, 0, 0, 0, 0, DateTimeKind.Local), "Shawn.Stark70@yahoo.com", "Shawn", "Stark", null, "Kenya", "0000", "1-415-385-3907 x555", null, "Male" },
                    { 2324, "Carsontown", "2021", "EE52748", 3, "G51032", new DateTime(1985, 7, 25, 0, 0, 0, 0, DateTimeKind.Local), "Leah.Parker12@hotmail.com", "Leah", "Parker", null, "Guadeloupe", "0000", "(704) 415-7047", null, "Female" },
                    { 2319, "Fritzfort", "2021", "EE48214", 3, "G497626", new DateTime(1980, 10, 21, 0, 0, 0, 0, DateTimeKind.Local), "Mabel_Paucek98@yahoo.com", "Mabel", "Paucek", null, "French Polynesia", "0000", "(600) 853-3288 x09217", null, "Female" },
                    { 2318, "South Lilyanborough", "2021", "EE51561", 3, "G377021", new DateTime(1990, 3, 5, 0, 0, 0, 0, DateTimeKind.Local), "Jana_Maggio77@gmail.com", "Jana", "Maggio", null, "Bahamas", "0000", "1-602-215-1522 x759", null, "Female" },
                    { 2362, "North Devanberg", "2021", "EE36940", 3, "G476264", new DateTime(1953, 1, 12, 0, 0, 0, 0, DateTimeKind.Local), "Janie_Monahan@gmail.com", "Janie", "Monahan", null, "United Kingdom", "0000", "322.921.9854 x940", null, "Female" },
                    { 2314, "Jaleelfort", "2021", "EE30147", 3, "G260752", new DateTime(1977, 6, 18, 0, 0, 0, 0, DateTimeKind.Local), "Johnnie_Dibbert@yahoo.com", "Johnnie", "Dibbert", null, "Iraq", "0000", "379-863-1666 x74289", null, "Male" },
                    { 2311, "New Constantinmouth", "2021", "EE44883", 3, "G275208", new DateTime(1971, 2, 20, 0, 0, 0, 0, DateTimeKind.Local), "Jean86@hotmail.com", "Jean", "Yundt", null, "Germany", "0000", "1-942-372-3779 x08469", null, "Male" },
                    { 2307, "Hagenesborough", "2021", "EE53227", 3, "G421039", new DateTime(1998, 10, 7, 0, 0, 0, 0, DateTimeKind.Local), "Rolando_Ward87@yahoo.com", "Rolando", "Ward", null, "Somalia", "0000", "368.555.1335", null, "Male" },
                    { 2306, "Fredaburgh", "2021", "EE5052", 3, "G101430", new DateTime(1955, 6, 7, 0, 0, 0, 0, DateTimeKind.Local), "Jane98@gmail.com", "Jane", "Reichert", null, "Ghana", "0000", "(236) 798-7805 x8714", null, "Female" },
                    { 2305, "East Yazminstad", "2021", "EE43749", 3, "G293648", new DateTime(1992, 5, 4, 0, 0, 0, 0, DateTimeKind.Local), "Dwayne_Kuhic86@hotmail.com", "Dwayne", "Kuhic", null, "Myanmar", "0000", "1-791-392-1826 x96353", null, "Male" },
                    { 2295, "New Jalen", "2021", "EE30664", 3, "G500803", new DateTime(1994, 4, 8, 0, 0, 0, 0, DateTimeKind.Local), "Sidney96@gmail.com", "Sidney", "Dietrich", null, "United States of America", "0000", "490.853.1034 x49590", null, "Male" },
                    { 2290, "Garettfort", "2021", "EE56779", 3, "G108109", new DateTime(1955, 2, 11, 0, 0, 0, 0, DateTimeKind.Local), "Conrad98@hotmail.com", "Conrad", "Reilly", null, "Finland", "0000", "1-426-272-9298", null, "Male" },
                    { 2288, "East Mauricio", "2021", "EE13640", 3, "G224454", new DateTime(1967, 2, 1, 0, 0, 0, 0, DateTimeKind.Local), "Bertha_Homenick82@hotmail.com", "Bertha", "Homenick", null, "Angola", "0000", "1-497-873-9859", null, "Female" },
                    { 2283, "East Maud", "2021", "EE36118", 3, "G360347", new DateTime(1967, 10, 16, 0, 0, 0, 0, DateTimeKind.Local), "Latoya.Wisozk@gmail.com", "Latoya", "Wisozk", null, "India", "0000", "(448) 385-6332 x638", null, "Female" },
                    { 2282, "South Beulahburgh", "2021", "EE31905", 3, "G3061", new DateTime(1951, 12, 10, 0, 0, 0, 0, DateTimeKind.Local), "Donnie_Sauer46@hotmail.com", "Donnie", "Sauer", null, "Palau", "0000", "1-767-955-9378", null, "Male" },
                    { 2278, "Strackemouth", "2021", "EE21649", 3, "G360521", new DateTime(1974, 6, 1, 0, 0, 0, 0, DateTimeKind.Local), "Jodi_Ernser27@gmail.com", "Jodi", "Ernser", null, "Czech Republic", "0000", "594-726-1474", null, "Female" },
                    { 2273, "Desmondside", "2021", "EE12448", 3, "G250075", new DateTime(1974, 12, 18, 0, 0, 0, 0, DateTimeKind.Local), "Elvira_Schamberger@yahoo.com", "Elvira", "Schamberger", null, "Tanzania", "0000", "(373) 333-0736", null, "Female" },
                    { 2272, "Alecville", "2021", "EE6759", 3, "G176669", new DateTime(1994, 8, 29, 0, 0, 0, 0, DateTimeKind.Local), "Joshua99@yahoo.com", "Joshua", "Bruen", null, "French Guiana", "0000", "486.908.5824 x9866", null, "Male" },
                    { 2313, "North Kenyatta", "2021", "EE8898", 3, "G496652", new DateTime(1999, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), "Sergio82@gmail.com", "Sergio", "Kertzmann", null, "Mongolia", "0000", "1-841-647-5083 x531", null, "Male" },
                    { 2367, "Port Sven", "2021", "EE3546", 3, "G348841", new DateTime(1960, 4, 21, 0, 0, 0, 0, DateTimeKind.Local), "Eva.Hayes86@hotmail.com", "Eva", "Hayes", null, "Hungary", "0000", "290-612-9963", null, "Female" },
                    { 2371, "West Jacintheton", "2021", "EE41230", 3, "G503976", new DateTime(1977, 2, 22, 0, 0, 0, 0, DateTimeKind.Local), "Ruben.Huels@gmail.com", "Ruben", "Huels", null, "Isle of Man", "0000", "844-934-5042", null, "Male" },
                    { 2374, "Goldnermouth", "2021", "EE55867", 3, "G47874", new DateTime(1992, 3, 19, 0, 0, 0, 0, DateTimeKind.Local), "Willard79@yahoo.com", "Willard", "McKenzie", null, "Kiribati", "0000", "(475) 574-0018 x975", null, "Male" },
                    { 2437, "South Christa", "2021", "EE2222", 3, "G316244", new DateTime(1959, 1, 15, 0, 0, 0, 0, DateTimeKind.Local), "Sabrina.Leffler@yahoo.com", "Sabrina", "Leffler", null, "Mauritius", "0000", "(725) 371-2681", null, "Female" },
                    { 2431, "Willland", "2021", "EE26033", 3, "G139039", new DateTime(1979, 6, 25, 0, 0, 0, 0, DateTimeKind.Local), "Shane.Graham23@hotmail.com", "Shane", "Graham", null, "Seychelles", "0000", "(313) 611-9835 x20807", null, "Male" },
                    { 2428, "Hackettport", "2021", "EE49410", 3, "G404753", new DateTime(1994, 10, 3, 0, 0, 0, 0, DateTimeKind.Local), "Cesar_Berge84@yahoo.com", "Cesar", "Berge", null, "Brunei Darussalam", "0000", "(724) 416-3472", null, "Male" },
                    { 2419, "East Odellside", "2021", "EE33833", 3, "G348429", new DateTime(1985, 1, 19, 0, 0, 0, 0, DateTimeKind.Local), "Kenny.Wiza91@hotmail.com", "Kenny", "Wiza", null, "Namibia", "0000", "1-409-386-7877", null, "Male" },
                    { 2418, "Elishaview", "2021", "EE32636", 3, "G432350", new DateTime(1960, 5, 10, 0, 0, 0, 0, DateTimeKind.Local), "Tommie.Spinka@gmail.com", "Tommie", "Spinka", null, "Belgium", "0000", "496-756-6713", null, "Male" },
                    { 2413, "Prosaccotown", "2021", "EE53617", 3, "G24611", new DateTime(1962, 2, 20, 0, 0, 0, 0, DateTimeKind.Local), "Kristin80@gmail.com", "Kristin", "Runolfsdottir", null, "Argentina", "0000", "1-395-529-0349 x79677", null, "Female" },
                    { 2409, "West Alfordfort", "2021", "EE45107", 3, "G188712", new DateTime(1990, 12, 27, 0, 0, 0, 0, DateTimeKind.Local), "Lucille_Ratke28@yahoo.com", "Lucille", "Ratke", null, "Virgin Islands, British", "0000", "799.654.0381 x725", null, "Female" },
                    { 2408, "Pollichtown", "2021", "EE942", 3, "G236075", new DateTime(1968, 11, 18, 0, 0, 0, 0, DateTimeKind.Local), "Orlando.MacGyver@hotmail.com", "Orlando", "MacGyver", null, "Kazakhstan", "0000", "965-740-3383 x18972", null, "Male" },
                    { 2404, "Lake Caleview", "2021", "EE52571", 3, "G568127", new DateTime(1953, 1, 18, 0, 0, 0, 0, DateTimeKind.Local), "Harriet7@yahoo.com", "Harriet", "Gleason", null, "Mexico", "0000", "245.723.2392 x249", null, "Female" },
                    { 2401, "Patriciaview", "2021", "EE13168", 3, "G414444", new DateTime(1994, 12, 31, 0, 0, 0, 0, DateTimeKind.Local), "Leon0@gmail.com", "Leon", "Langworth", null, "British Indian Ocean Territory (Chagos Archipelago)", "0000", "1-735-741-1821 x099", null, "Male" },
                    { 2400, "West Soniamouth", "2021", "EE3962", 3, "G238609", new DateTime(1953, 12, 12, 0, 0, 0, 0, DateTimeKind.Local), "Della21@gmail.com", "Della", "Crona", null, "Georgia", "0000", "549.296.8583", null, "Female" }
                });

            migrationBuilder.InsertData(
                table: "Etudiants",
                columns: new[] { "apogee", "address", "annee", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "ldn", "natio", "password", "phone", "picture", "sexe" },
                values: new object[,]
                {
                    { 2394, "Port Joel", "2021", "EE27798", 3, "G459785", new DateTime(1956, 1, 14, 0, 0, 0, 0, DateTimeKind.Local), "Clifton18@hotmail.com", "Clifton", "D'Amore", null, "Jersey", "0000", "1-372-666-0146 x1552", null, "Male" },
                    { 2008, "Lake Freeda", "2021", "EE50983", 4, "G319037", new DateTime(1955, 1, 26, 0, 0, 0, 0, DateTimeKind.Local), "Jeannie8@hotmail.com", "Jeannie", "Herzog", null, "South Georgia and the South Sandwich Islands", "0000", "327.260.7559", null, "Female" },
                    { 2012, "Lebsackview", "2021", "EE50778", 4, "G541575", new DateTime(1963, 9, 30, 0, 0, 0, 0, DateTimeKind.Local), "Mary_Prosacco@hotmail.com", "Mary", "Prosacco", null, "Kiribati", "0000", "1-959-293-9453 x52847", null, "Female" },
                    { 2014, "Whitneymouth", "2021", "EE30308", 4, "G85402", new DateTime(1961, 7, 12, 0, 0, 0, 0, DateTimeKind.Local), "Jermaine_Moen10@yahoo.com", "Jermaine", "Moen", null, "Slovakia (Slovak Republic)", "0000", "1-579-335-3322 x164", null, "Male" },
                    { 2019, "Port Lewismouth", "2021", "EE16772", 4, "G587331", new DateTime(1994, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), "Lynn.Schaden@hotmail.com", "Lynn", "Schaden", null, "Samoa", "0000", "1-881-332-8169", null, "Female" },
                    { 2020, "Morissetteton", "2021", "EE2716", 4, "G348172", new DateTime(1975, 5, 25, 0, 0, 0, 0, DateTimeKind.Local), "Brent.Sanford74@yahoo.com", "Brent", "Sanford", null, "Turkmenistan", "0000", "553-843-1564 x681", null, "Male" },
                    { 2021, "East Oda", "2021", "EE8760", 4, "G5504", new DateTime(1985, 1, 23, 0, 0, 0, 0, DateTimeKind.Local), "Kristopher.OHara33@hotmail.com", "Kristopher", "O'Hara", null, "Madagascar", "0000", "875-775-6107", null, "Male" },
                    { 2027, "Hermannfort", "2021", "EE34390", 4, "G367884", new DateTime(1959, 12, 6, 0, 0, 0, 0, DateTimeKind.Local), "Priscilla_Dickens78@yahoo.com", "Priscilla", "Dickens", null, "Trinidad and Tobago", "0000", "1-847-425-0462", null, "Female" },
                    { 2030, "Woodrowport", "2021", "EE18395", 4, "G527785", new DateTime(1957, 11, 22, 0, 0, 0, 0, DateTimeKind.Local), "Abraham.Veum@hotmail.com", "Abraham", "Veum", null, "Tanzania", "0000", "922-243-1747", null, "Male" },
                    { 2393, "Bartside", "2021", "EE54829", 3, "G440007", new DateTime(1982, 3, 16, 0, 0, 0, 0, DateTimeKind.Local), "Lance.Runolfsdottir@yahoo.com", "Lance", "Runolfsdottir", null, "Cayman Islands", "0000", "666.517.0148", null, "Male" },
                    { 2392, "Port Aureliaville", "2021", "EE18116", 3, "G557778", new DateTime(1980, 9, 3, 0, 0, 0, 0, DateTimeKind.Local), "Jon48@yahoo.com", "Jon", "Treutel", null, "Sudan", "0000", "1-287-662-4946 x5659", null, "Male" },
                    { 2385, "East Suzanneburgh", "2021", "EE5505", 3, "G473640", new DateTime(1952, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), "Maryann86@yahoo.com", "Maryann", "Hegmann", null, "Portugal", "0000", "545.995.6704 x8777", null, "Female" },
                    { 2384, "Lake Ethelyn", "2021", "EE56727", 3, "G511521", new DateTime(1957, 12, 20, 0, 0, 0, 0, DateTimeKind.Local), "Marcus.Paucek32@gmail.com", "Marcus", "Paucek", null, "Nepal", "0000", "(326) 732-8410", null, "Male" },
                    { 2383, "Huelfort", "2021", "EE19873", 3, "G137590", new DateTime(1987, 7, 27, 0, 0, 0, 0, DateTimeKind.Local), "Ramon82@hotmail.com", "Ramon", "Gerlach", null, "Switzerland", "0000", "1-317-996-0061", null, "Male" },
                    { 2381, "West Delores", "2021", "EE27980", 3, "G569045", new DateTime(1963, 12, 10, 0, 0, 0, 0, DateTimeKind.Local), "Kate78@gmail.com", "Kate", "Yundt", null, "Zambia", "0000", "323.283.8110 x8785", null, "Female" },
                    { 2376, "Lake Bo", "2021", "EE9377", 3, "G313728", new DateTime(1960, 4, 30, 0, 0, 0, 0, DateTimeKind.Local), "Cody_Lynch@hotmail.com", "Cody", "Lynch", null, "Malawi", "0000", "(981) 989-1337", null, "Male" },
                    { 2267, "South Faustino", "2021", "EE27089", 3, "G252656", new DateTime(1997, 12, 10, 0, 0, 0, 0, DateTimeKind.Local), "Tasha57@yahoo.com", "Tasha", "Kertzmann", null, "Bouvet Island (Bouvetoya)", "0000", "1-443-737-9152", null, "Female" },
                    { 2044, "North Lamont", "2021", "EE47447", 3, "G308450", new DateTime(1998, 4, 10, 0, 0, 0, 0, DateTimeKind.Local), "Maurice.Nitzsche@gmail.com", "Maurice", "Nitzsche", null, "Falkland Islands (Malvinas)", "0000", "321.776.0503", null, "Male" },
                    { 2264, "West Rethastad", "2021", "EE45449", 3, "G506885", new DateTime(1969, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), "Hattie_Nader@gmail.com", "Hattie", "Nader", null, "Saudi Arabia", "0000", "690.253.8703 x18890", null, "Female" },
                    { 2256, "South Cyrus", "2021", "EE11603", 3, "G286993", new DateTime(1999, 7, 26, 0, 0, 0, 0, DateTimeKind.Local), "Santiago_Daniel@gmail.com", "Santiago", "Daniel", null, "South Africa", "0000", "344-857-2875 x220", null, "Male" },
                    { 2139, "Port Garthfurt", "2021", "EE26244", 3, "G309990", new DateTime(1966, 3, 8, 0, 0, 0, 0, DateTimeKind.Local), "Inez_Ernser53@hotmail.com", "Inez", "Ernser", null, "Denmark", "0000", "1-961-698-0696 x919", null, "Female" },
                    { 2138, "Hamillside", "2021", "EE44398", 3, "G54308", new DateTime(1957, 8, 13, 0, 0, 0, 0, DateTimeKind.Local), "Marjorie_Bruen@hotmail.com", "Marjorie", "Bruen", null, "Macedonia", "0000", "292-762-9578 x2843", null, "Female" },
                    { 2137, "South Darienmouth", "2021", "EE55502", 3, "G12426", new DateTime(1967, 1, 12, 0, 0, 0, 0, DateTimeKind.Local), "Olivia41@yahoo.com", "Olivia", "Nienow", null, "Haiti", "0000", "572.687.7456 x10737", null, "Female" },
                    { 2136, "Hilarioborough", "2021", "EE23632", 3, "G301569", new DateTime(1955, 12, 10, 0, 0, 0, 0, DateTimeKind.Local), "Florence_Hettinger57@yahoo.com", "Florence", "Hettinger", null, "Georgia", "0000", "1-668-816-3086 x44893", null, "Female" },
                    { 2134, "Eloisaburgh", "2021", "EE19983", 3, "G256422", new DateTime(1952, 12, 11, 0, 0, 0, 0, DateTimeKind.Local), "Douglas_Wisoky@hotmail.com", "Douglas", "Wisoky", null, "Palau", "0000", "(591) 836-1027 x422", null, "Male" },
                    { 2133, "Port Carley", "2021", "EE18320", 3, "G151777", new DateTime(1992, 4, 29, 0, 0, 0, 0, DateTimeKind.Local), "Dean22@yahoo.com", "Dean", "Kihn", null, "Bouvet Island (Bouvetoya)", "0000", "1-287-496-4492", null, "Male" },
                    { 2129, "East Christianamouth", "2021", "EE53729", 3, "G133181", new DateTime(1980, 4, 6, 0, 0, 0, 0, DateTimeKind.Local), "Jean81@yahoo.com", "Jean", "Waelchi", null, "South Georgia and the South Sandwich Islands", "0000", "665-293-5580 x20655", null, "Male" },
                    { 2128, "Port Ivyfort", "2021", "EE16048", 3, "G577501", new DateTime(1994, 8, 4, 0, 0, 0, 0, DateTimeKind.Local), "Wayne_Stokes75@gmail.com", "Wayne", "Stokes", null, "Finland", "0000", "(667) 286-3808 x0736", null, "Male" },
                    { 2121, "Rohanhaven", "2021", "EE20975", 3, "G342466", new DateTime(1983, 12, 20, 0, 0, 0, 0, DateTimeKind.Local), "Ross.Lang@gmail.com", "Ross", "Lang", null, "Gabon", "0000", "(206) 918-3427 x27080", null, "Male" },
                    { 2115, "Gerholdhaven", "2021", "EE55401", 3, "G25558", new DateTime(1976, 4, 18, 0, 0, 0, 0, DateTimeKind.Local), "Roxanne_Abbott71@yahoo.com", "Roxanne", "Abbott", null, "Lithuania", "0000", "(570) 800-5960", null, "Female" },
                    { 2106, "Lake Jamesonfurt", "2021", "EE31975", 3, "G204874", new DateTime(1956, 2, 14, 0, 0, 0, 0, DateTimeKind.Local), "Lydia72@gmail.com", "Lydia", "Wunsch", null, "Pakistan", "0000", "583-468-7414 x00253", null, "Female" },
                    { 2103, "Maddisonburgh", "2021", "EE31296", 3, "G370348", new DateTime(1968, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), "Phillip52@yahoo.com", "Phillip", "Schumm", null, "Israel", "0000", "(472) 501-7704 x3299", null, "Male" },
                    { 2092, "Considineberg", "2021", "EE9972", 3, "G590506", new DateTime(1953, 12, 10, 0, 0, 0, 0, DateTimeKind.Local), "Dixie_Rutherford81@hotmail.com", "Dixie", "Rutherford", null, "Guadeloupe", "0000", "746.537.7592 x9302", null, "Female" },
                    { 2084, "Breitenbergshire", "2021", "EE55890", 3, "G164178", new DateTime(1971, 10, 29, 0, 0, 0, 0, DateTimeKind.Local), "Rose.Cormier85@gmail.com", "Rose", "Cormier", null, "Palestinian Territory", "0000", "(295) 837-2935", null, "Female" },
                    { 2077, "Port Maximilianmouth", "2021", "EE21393", 3, "G95541", new DateTime(1966, 9, 26, 0, 0, 0, 0, DateTimeKind.Local), "Roderick_Harris95@hotmail.com", "Roderick", "Harris", null, "Oman", "0000", "300-487-9235 x9936", null, "Male" },
                    { 2075, "Lake Breanne", "2021", "EE51121", 3, "G328617", new DateTime(1964, 6, 6, 0, 0, 0, 0, DateTimeKind.Local), "Abraham.Huel@yahoo.com", "Abraham", "Huel", null, "Mauritania", "0000", "1-835-963-4393 x85723", null, "Male" },
                    { 2074, "New Josue", "2021", "EE9617", 3, "G518748", new DateTime(1979, 4, 26, 0, 0, 0, 0, DateTimeKind.Local), "Bryan72@hotmail.com", "Bryan", "Gusikowski", null, "Ghana", "0000", "1-930-324-0128 x162", null, "Male" },
                    { 2073, "Torpmouth", "2021", "EE41119", 3, "G285440", new DateTime(1980, 9, 10, 0, 0, 0, 0, DateTimeKind.Local), "Brent_Mann60@yahoo.com", "Brent", "Mann", null, "Algeria", "0000", "1-493-438-7160 x51207", null, "Male" },
                    { 2072, "Marquesview", "2021", "EE29795", 3, "G27936", new DateTime(1966, 8, 30, 0, 0, 0, 0, DateTimeKind.Local), "Beverly_Mueller@gmail.com", "Beverly", "Mueller", null, "Seychelles", "0000", "1-912-868-0246 x95729", null, "Female" },
                    { 2071, "West Kathleenton", "2021", "EE28050", 3, "G75441", new DateTime(1960, 12, 21, 0, 0, 0, 0, DateTimeKind.Local), "Darrell.Predovic@yahoo.com", "Darrell", "Predovic", null, "Slovakia (Slovak Republic)", "0000", "851.882.0132 x8364", null, "Male" },
                    { 2068, "North Kole", "2021", "EE38053", 3, "G195439", new DateTime(1992, 7, 26, 0, 0, 0, 0, DateTimeKind.Local), "Gwen_Gibson@gmail.com", "Gwen", "Gibson", null, "Malawi", "0000", "1-965-985-6869 x428", null, "Female" },
                    { 2065, "North Deshawnberg", "2021", "EE23331", 3, "G559082", new DateTime(1986, 7, 16, 0, 0, 0, 0, DateTimeKind.Local), "Jose_Marvin@gmail.com", "Jose", "Marvin", null, "Mongolia", "0000", "(836) 825-5777 x26987", null, "Male" }
                });

            migrationBuilder.InsertData(
                table: "Etudiants",
                columns: new[] { "apogee", "address", "annee", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "ldn", "natio", "password", "phone", "picture", "sexe" },
                values: new object[,]
                {
                    { 2061, "South Adeleborough", "2021", "EE14617", 3, "G286128", new DateTime(1994, 6, 28, 0, 0, 0, 0, DateTimeKind.Local), "Sonia59@yahoo.com", "Sonia", "Upton", null, "French Polynesia", "0000", "702-917-3125", null, "Female" },
                    { 2059, "New Oswald", "2021", "EE46917", 3, "G343111", new DateTime(1962, 9, 24, 0, 0, 0, 0, DateTimeKind.Local), "Wesley.McLaughlin@gmail.com", "Wesley", "McLaughlin", null, "Grenada", "0000", "(350) 637-3035", null, "Male" },
                    { 2057, "East Antoinette", "2021", "EE38390", 3, "G25978", new DateTime(1958, 1, 4, 0, 0, 0, 0, DateTimeKind.Local), "Sylvia_Reichel@yahoo.com", "Sylvia", "Reichel", null, "Ecuador", "0000", "(214) 851-0269 x45327", null, "Female" },
                    { 2056, "Walkermouth", "2021", "EE10003", 3, "G270940", new DateTime(1964, 9, 26, 0, 0, 0, 0, DateTimeKind.Local), "Dianna_Marks3@hotmail.com", "Dianna", "Marks", null, "Burkina Faso", "0000", "(335) 651-5049", null, "Female" },
                    { 2049, "West Jaydenmouth", "2021", "EE36039", 3, "G384858", new DateTime(1984, 8, 3, 0, 0, 0, 0, DateTimeKind.Local), "Rex_Sawayn@hotmail.com", "Rex", "Sawayn", null, "Botswana", "0000", "231-296-7747 x53849", null, "Male" },
                    { 2140, "South Jovany", "2021", "EE11501", 3, "G327685", new DateTime(2000, 3, 15, 0, 0, 0, 0, DateTimeKind.Local), "Rebecca25@gmail.com", "Rebecca", "Dach", null, "Estonia", "0000", "251-835-1632 x0073", null, "Female" },
                    { 2261, "Eleanoraton", "2021", "EE1175", 3, "G95550", new DateTime(1958, 4, 15, 0, 0, 0, 0, DateTimeKind.Local), "Warren8@yahoo.com", "Warren", "Adams", null, "Nepal", "0000", "851-512-7249", null, "Male" },
                    { 2141, "North Vivientown", "2021", "EE45467", 3, "G274605", new DateTime(1957, 1, 3, 0, 0, 0, 0, DateTimeKind.Local), "Eloise4@gmail.com", "Eloise", "Pouros", null, "Holy See (Vatican City State)", "0000", "1-240-793-8388 x248", null, "Female" },
                    { 2152, "North Larissa", "2021", "EE22005", 3, "G530045", new DateTime(1963, 10, 23, 0, 0, 0, 0, DateTimeKind.Local), "Terri83@hotmail.com", "Terri", "Donnelly", null, "Bermuda", "0000", "(978) 729-9026", null, "Female" },
                    { 2255, "New Willis", "2021", "EE45698", 3, "G456681", new DateTime(2001, 2, 24, 0, 0, 0, 0, DateTimeKind.Local), "Vernon_Larkin3@hotmail.com", "Vernon", "Larkin", null, "Guam", "0000", "1-496-828-1443", null, "Male" },
                    { 2252, "Hauckmouth", "2021", "EE21063", 3, "G52936", new DateTime(1988, 6, 18, 0, 0, 0, 0, DateTimeKind.Local), "Jimmy54@hotmail.com", "Jimmy", "Heidenreich", null, "Pitcairn Islands", "0000", "926-657-4119", null, "Male" },
                    { 2251, "Torphyside", "2021", "EE20470", 3, "G475449", new DateTime(1968, 8, 2, 0, 0, 0, 0, DateTimeKind.Local), "Devin.Brakus38@gmail.com", "Devin", "Brakus", null, "Argentina", "0000", "(585) 804-0965 x2278", null, "Male" },
                    { 2249, "South Samirbury", "2021", "EE47133", 3, "G568244", new DateTime(1960, 8, 23, 0, 0, 0, 0, DateTimeKind.Local), "Kelly_Purdy@yahoo.com", "Kelly", "Purdy", null, "Moldova", "0000", "1-912-521-9887", null, "Male" },
                    { 2247, "Lake Elianville", "2021", "EE24298", 3, "G250525", new DateTime(1992, 12, 31, 0, 0, 0, 0, DateTimeKind.Local), "Dominic_Boehm88@hotmail.com", "Dominic", "Boehm", null, "British Indian Ocean Territory (Chagos Archipelago)", "0000", "(771) 757-6918 x7524", null, "Male" },
                    { 2237, "Dooleyshire", "2021", "EE3082", 3, "G508423", new DateTime(2000, 12, 8, 0, 0, 0, 0, DateTimeKind.Local), "Joann86@hotmail.com", "Joann", "Gutkowski", null, "South Africa", "0000", "936.493.5974 x350", null, "Female" },
                    { 2232, "Titusmouth", "2021", "EE30791", 3, "G559688", new DateTime(1990, 4, 6, 0, 0, 0, 0, DateTimeKind.Local), "Eddie58@hotmail.com", "Eddie", "Mayer", null, "Niue", "0000", "1-992-375-5405 x3231", null, "Male" },
                    { 2228, "Marleyville", "2021", "EE54050", 3, "G416884", new DateTime(1960, 10, 29, 0, 0, 0, 0, DateTimeKind.Local), "Delbert38@yahoo.com", "Delbert", "Smith", null, "Bahrain", "0000", "775.990.8437", null, "Male" },
                    { 2221, "South Hailie", "2021", "EE13722", 3, "G493235", new DateTime(1997, 4, 11, 0, 0, 0, 0, DateTimeKind.Local), "Nick3@hotmail.com", "Nick", "Volkman", null, "Spain", "0000", "840.538.8626", null, "Male" },
                    { 2220, "South Axelhaven", "2021", "EE39188", 3, "G216637", new DateTime(1987, 11, 25, 0, 0, 0, 0, DateTimeKind.Local), "Aubrey0@hotmail.com", "Aubrey", "Stokes", null, "Marshall Islands", "0000", "615-979-0361", null, "Male" },
                    { 2218, "West Devanteland", "2021", "EE53306", 3, "G32660", new DateTime(1991, 3, 13, 0, 0, 0, 0, DateTimeKind.Local), "Renee87@gmail.com", "Renee", "Conroy", null, "Faroe Islands", "0000", "1-255-306-5821 x78417", null, "Female" },
                    { 2217, "Schmittchester", "2021", "EE8553", 3, "G506944", new DateTime(1966, 1, 21, 0, 0, 0, 0, DateTimeKind.Local), "Maureen_Hahn26@gmail.com", "Maureen", "Hahn", null, "Congo", "0000", "294-342-3098 x56253", null, "Female" },
                    { 2147, "East Royce", "2021", "EE45519", 3, "G510759", new DateTime(1954, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), "Denise32@hotmail.com", "Denise", "Morissette", null, "Gambia", "0000", "774.702.5292 x329", null, "Female" },
                    { 2210, "Brendanland", "2021", "EE10128", 3, "G358008", new DateTime(1987, 3, 11, 0, 0, 0, 0, DateTimeKind.Local), "Jerry_Greenholt34@yahoo.com", "Jerry", "Greenholt", null, "Turkmenistan", "0000", "1-479-892-9067", null, "Male" },
                    { 2207, "Haydenberg", "2021", "EE47727", 3, "G567657", new DateTime(1952, 6, 1, 0, 0, 0, 0, DateTimeKind.Local), "Thelma_Sporer@gmail.com", "Thelma", "Sporer", null, "Netherlands Antilles", "0000", "(842) 284-0477 x8913", null, "Female" },
                    { 2206, "Koeppbury", "2021", "EE20364", 3, "G219311", new DateTime(1956, 10, 14, 0, 0, 0, 0, DateTimeKind.Local), "Charlene_Kunde87@hotmail.com", "Charlene", "Kunde", null, "Cuba", "0000", "1-708-313-2322", null, "Female" },
                    { 2201, "Weissnatshire", "2021", "EE18421", 3, "G592967", new DateTime(1994, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), "Jerry.Kessler@yahoo.com", "Jerry", "Kessler", null, "Bahrain", "0000", "710-671-0683", null, "Male" },
                    { 2200, "Croninport", "2021", "EE39115", 3, "G518532", new DateTime(1959, 7, 13, 0, 0, 0, 0, DateTimeKind.Local), "Ricky.Lowe50@yahoo.com", "Ricky", "Lowe", null, "Gambia", "0000", "647.368.6660 x0233", null, "Male" },
                    { 2197, "Dinoberg", "2021", "EE24933", 3, "G528096", new DateTime(1955, 11, 14, 0, 0, 0, 0, DateTimeKind.Local), "Wilson60@hotmail.com", "Wilson", "Collier", null, "Serbia", "0000", "(728) 305-6408 x9743", null, "Male" },
                    { 2194, "New Alessia", "2021", "EE15621", 3, "G403908", new DateTime(1954, 7, 28, 0, 0, 0, 0, DateTimeKind.Local), "Misty.Lang@hotmail.com", "Misty", "Lang", null, "Jordan", "0000", "989.773.8853", null, "Female" },
                    { 2193, "North Lisamouth", "2021", "EE42177", 3, "G534433", new DateTime(1992, 10, 28, 0, 0, 0, 0, DateTimeKind.Local), "Ian0@gmail.com", "Ian", "Conroy", null, "Egypt", "0000", "740-834-7177 x5327", null, "Male" },
                    { 2190, "New Stacey", "2021", "EE44384", 3, "G255962", new DateTime(1951, 7, 31, 0, 0, 0, 0, DateTimeKind.Local), "Laurence.Gerlach@yahoo.com", "Laurence", "Gerlach", null, "Montenegro", "0000", "898.480.3317 x4844", null, "Male" },
                    { 2189, "Lake Alleneborough", "2021", "EE47272", 3, "G528557", new DateTime(1996, 9, 3, 0, 0, 0, 0, DateTimeKind.Local), "Edwin47@hotmail.com", "Edwin", "Hoeger", null, "Spain", "0000", "1-328-300-4458 x30066", null, "Male" },
                    { 2170, "Winfieldstad", "2021", "EE9642", 3, "G160321", new DateTime(1955, 1, 13, 0, 0, 0, 0, DateTimeKind.Local), "Pete.Leffler29@gmail.com", "Pete", "Leffler", null, "New Zealand", "0000", "1-476-470-0602", null, "Male" },
                    { 2166, "Cadenshire", "2021", "EE29398", 3, "G44745", new DateTime(1965, 3, 9, 0, 0, 0, 0, DateTimeKind.Local), "Raul_Nolan12@hotmail.com", "Raul", "Nolan", null, "Croatia", "0000", "219.252.3915", null, "Male" },
                    { 2164, "North Furmanborough", "2021", "EE51307", 3, "G465587", new DateTime(1990, 1, 23, 0, 0, 0, 0, DateTimeKind.Local), "Lynda.Maggio23@hotmail.com", "Lynda", "Maggio", null, "Republic of Korea", "0000", "594-646-9749", null, "Female" },
                    { 2157, "Wilfredbury", "2021", "EE52492", 3, "G420653", new DateTime(1974, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), "Penny.Wolff41@yahoo.com", "Penny", "Wolff", null, "Fiji", "0000", "(853) 504-5209 x464", null, "Female" },
                    { 2208, "Jacobiville", "2021", "EE28995", 3, "G357616", new DateTime(1977, 2, 18, 0, 0, 0, 0, DateTimeKind.Local), "Misty53@yahoo.com", "Misty", "Lebsack", null, "Bahamas", "0000", "1-620-418-9268 x1090", null, "Female" },
                    { 2090, "Crystelview", "2021", "EE35698", 4, "G547889", new DateTime(1952, 9, 26, 0, 0, 0, 0, DateTimeKind.Local), "Leslie54@yahoo.com", "Leslie", "Yost", null, "Brazil", "0000", "774.682.0580 x50047", null, "Male" }
                });

            migrationBuilder.InsertData(
                table: "Modules",
                columns: new[] { "id", "classeId", "nom", "professeurId" },
                values: new object[,]
                {
                    { 1, 1, "Tools, Home & Toys streamline mint green", 10 },
                    { 9, 2, "Cambridgeshire calculate Stravenue", 14 },
                    { 5, 4, "collaborative Regional Incredible Concrete Fish", 2 },
                    { 11, 1, "Investment Account green Markets", 4 }
                });

            migrationBuilder.InsertData(
                table: "Modules",
                columns: new[] { "id", "classeId", "nom", "professeurId" },
                values: new object[,]
                {
                    { 3, 3, "Facilitator New Hampshire users", 7 },
                    { 4, 3, "Savings Account Colorado zero administration", 20 },
                    { 6, 3, "compress Canadian Dollar Handmade", 16 },
                    { 8, 3, "Money Market Account online Metal", 2 },
                    { 10, 3, "Supervisor indexing Soft", 13 },
                    { 13, 3, "multi-tasking Quality Philippine Peso", 20 },
                    { 16, 3, "CFA Franc BCEAO navigating Pataca", 21 },
                    { 18, 3, "Group clicks-and-mortar District", 12 },
                    { 24, 4, "analyzer Incredible Granite Soap Forge", 8 },
                    { 21, 4, "programming navigate Versatile", 8 },
                    { 12, 2, "SQL Soft Gorgeous Wooden Chair", 2 },
                    { 14, 2, "Dominican Republic Sports, Jewelery & Jewelery Synergistic", 17 },
                    { 15, 2, "Handmade Steel Pizza Rhode Island cross-platform", 19 },
                    { 22, 2, "Regional array info-mediaries", 8 },
                    { 23, 2, "Incredible Frozen Ball Practical Rubber Bike Toys", 1 },
                    { 20, 4, "circuit Burkina Faso well-modulated", 16 },
                    { 19, 4, "Electronics, Sports & Tools Regional Program", 9 },
                    { 7, 4, "B2C Grove Home & Sports", 11 },
                    { 2, 4, "Cambridgeshire killer Investment Account", 10 },
                    { 17, 1, "Data Indiana cutting-edge", 22 }
                });

            migrationBuilder.InsertData(
                table: "Documents",
                columns: new[] { "id", "date_demande", "id_etudiant", "type" },
                values: new object[,]
                {
                    { 5, new DateTime(2021, 6, 29, 2, 4, 3, 577, DateTimeKind.Local).AddTicks(619), 2087, "Attestation de stage" },
                    { 2, new DateTime(2021, 6, 29, 2, 4, 3, 577, DateTimeKind.Local).AddTicks(483), 2301, "Attestation de stage" },
                    { 3, new DateTime(2021, 6, 29, 2, 4, 3, 577, DateTimeKind.Local).AddTicks(573), 2216, "Attestation de scolarite" },
                    { 4, new DateTime(2021, 6, 29, 2, 4, 3, 577, DateTimeKind.Local).AddTicks(596), 2125, "Attestation de stage" },
                    { 1, new DateTime(2021, 6, 29, 2, 4, 3, 576, DateTimeKind.Local).AddTicks(1830), 2117, "Releve de note" }
                });

            migrationBuilder.InsertData(
                table: "Notes",
                columns: new[] { "id", "NotePdfUrl", "moduleId", "semestre" },
                values: new object[,]
                {
                    { 1, "A", 2, "2" },
                    { 14, "B", 1, "2" },
                    { 25, "B", 15, "0" },
                    { 2, "A", 15, "1" },
                    { 7, "A", 9, "1" },
                    { 17, "A", 16, "2" },
                    { 23, "C", 13, "1" },
                    { 3, "C", 13, "2" },
                    { 6, "B", 10, "2" },
                    { 9, "C", 8, "1" },
                    { 16, "A", 4, "0" },
                    { 15, "A", 4, "2" },
                    { 12, "A", 4, "1" },
                    { 11, "C", 4, "2" },
                    { 4, "A", 4, "2" },
                    { 21, "C", 24, "1" },
                    { 13, "A", 24, "2" },
                    { 5, "B", 24, "2" },
                    { 24, "B", 21, "0" },
                    { 20, "A", 21, "1" },
                    { 10, "C", 20, "0" },
                    { 8, "B", 7, "1" },
                    { 22, "C", 5, "2" },
                    { 19, "C", 11, "2" },
                    { 18, "C", 17, "0" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_classes_filiereId",
                table: "classes",
                column: "filiereId");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_id_etudiant",
                table: "Documents",
                column: "id_etudiant");

            migrationBuilder.CreateIndex(
                name: "IX_Etudiants_classeId",
                table: "Etudiants",
                column: "classeId");

            migrationBuilder.CreateIndex(
                name: "IX_Filieres_departementId",
                table: "Filieres",
                column: "departementId");

            migrationBuilder.CreateIndex(
                name: "IX_Modules_classeId",
                table: "Modules",
                column: "classeId");

            migrationBuilder.CreateIndex(
                name: "IX_Modules_professeurId",
                table: "Modules",
                column: "professeurId");

            migrationBuilder.CreateIndex(
                name: "IX_Notes_moduleId",
                table: "Notes",
                column: "moduleId");

            migrationBuilder.CreateIndex(
                name: "IX_Professeurs_departementId",
                table: "Professeurs",
                column: "departementId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Documents");

            migrationBuilder.DropTable(
                name: "Etat");

            migrationBuilder.DropTable(
                name: "Notes");

            migrationBuilder.DropTable(
                name: "Etudiants");

            migrationBuilder.DropTable(
                name: "Modules");

            migrationBuilder.DropTable(
                name: "classes");

            migrationBuilder.DropTable(
                name: "Professeurs");

            migrationBuilder.DropTable(
                name: "Filieres");

            migrationBuilder.DropTable(
                name: "departements");
        }
    }
}
