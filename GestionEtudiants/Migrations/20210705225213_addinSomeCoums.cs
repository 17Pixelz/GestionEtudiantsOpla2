using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GestionEtudiants.Migrations
{
    public partial class addinSomeCoums : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "academie",
                table: "Etudiants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "adresse",
                table: "Etudiants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "annee_bac",
                table: "Etudiants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "code_promo",
                table: "Etudiants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "delegation",
                table: "Etudiants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "diplome",
                table: "Etudiants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ecole",
                table: "Etudiants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "father_job",
                table: "Etudiants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "father_name",
                table: "Etudiants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "filiere",
                table: "Etudiants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "firstname_ar",
                table: "Etudiants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "firstname_fr",
                table: "Etudiants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "lastname_ar",
                table: "Etudiants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "lycee",
                table: "Etudiants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "mention_bac",
                table: "Etudiants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "mother_job",
                table: "Etudiants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "mother_name",
                table: "Etudiants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "nom",
                table: "Etudiants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "parents_adress",
                table: "Etudiants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "parents_phone",
                table: "Etudiants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "prenom",
                table: "Etudiants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tel",
                table: "Etudiants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "type_bac",
                table: "Etudiants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "validated",
                table: "Etudiants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ville_diplome",
                table: "Etudiants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "date_demande", "id_etudiant", "type" },
                values: new object[] { new DateTime(2021, 7, 5, 23, 52, 11, 609, DateTimeKind.Local).AddTicks(9805), 2428, "Attestation de scolarite" });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "date_demande", "id_etudiant", "type" },
                values: new object[] { new DateTime(2021, 7, 5, 23, 52, 11, 610, DateTimeKind.Local).AddTicks(8687), 2194, "Releve de note" });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "date_demande", "id_etudiant", "type" },
                values: new object[] { new DateTime(2021, 7, 5, 23, 52, 11, 610, DateTimeKind.Local).AddTicks(8777), 2280, "Attestation de stage" });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "date_demande", "id_etudiant" },
                values: new object[] { new DateTime(2021, 7, 5, 23, 52, 11, 610, DateTimeKind.Local).AddTicks(8799), 2402 });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "date_demande", "id_etudiant" },
                values: new object[] { new DateTime(2021, 7, 5, 23, 52, 11, 610, DateTimeKind.Local).AddTicks(8814), 2181 });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2000,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lockmantown", "EE5332", 2, "G298966", new DateTime(1993, 3, 2, 0, 0, 0, 0, DateTimeKind.Local), "Tracy56@hotmail.com", "Tracy", "Ondricka", "Oman", "(899) 517-1999 x568", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2001,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Kennaside", "EE57845", 4, "G555024", new DateTime(1997, 2, 4, 0, 0, 0, 0, DateTimeKind.Local), "Michael_Kerluke@gmail.com", "Michael", "Kerluke", "Montserrat", "(385) 799-5937", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2002,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Jamalshire", "EE45920", "G310811", new DateTime(1989, 6, 2, 0, 0, 0, 0, DateTimeKind.Local), "Yvette_Buckridge@hotmail.com", "Yvette", "Buckridge", "Egypt", "576.275.1994", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2003,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "East Cleoland", "EE33340", "G526812", new DateTime(1962, 3, 10, 0, 0, 0, 0, DateTimeKind.Local), "Ellis91@yahoo.com", "Ellis", "Carroll", "Iceland", "972.543.2513" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2004,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Filomenaburgh", "EE35949", 4, "G375877", new DateTime(1980, 8, 2, 0, 0, 0, 0, DateTimeKind.Local), "Stuart_Donnelly6@hotmail.com", "Stuart", "Donnelly", "Mexico", "390-602-7937" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2005,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Sister", "EE27010", 3, "G497945", new DateTime(1960, 5, 1, 0, 0, 0, 0, DateTimeKind.Local), "Tamara.Witting@hotmail.com", "Tamara", "Witting", "Virgin Islands, British", "1-798-571-4959 x210", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2006,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lowebury", "EE43219", 2, "G161979", new DateTime(1962, 4, 9, 0, 0, 0, 0, DateTimeKind.Local), "Cristina.Spencer@yahoo.com", "Cristina", "Spencer", "Sudan", "1-659-398-3131" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2007,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Christophetown", "EE5533", "G469002", new DateTime(1972, 7, 17, 0, 0, 0, 0, DateTimeKind.Local), "Martha_Donnelly@hotmail.com", "Martha", "Donnelly", "Aruba", "1-699-263-5621 x04171", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2008,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Waylonshire", "EE58013", 3, "G329769", new DateTime(1969, 9, 10, 0, 0, 0, 0, DateTimeKind.Local), "Wm.Murray@gmail.com", "Wm", "Murray", "Romania", "577-428-4576", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2009,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Raquelfurt", "EE26701", "G296854", new DateTime(1988, 10, 23, 0, 0, 0, 0, DateTimeKind.Local), "Lynda.Murray20@gmail.com", "Lynda", "Murray", "United States Minor Outlying Islands", "1-392-930-4810 x1017", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2010,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Kristopherview", "EE40963", "G440846", new DateTime(1983, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), "Fredrick55@hotmail.com", "Fredrick", "Schuster", "Hungary", "(951) 330-3888", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2011,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Skileshaven", "EE38546", "G200511", new DateTime(1983, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), "Nettie_Marks21@hotmail.com", "Nettie", "Marks", "Turks and Caicos Islands", "1-813-332-5022 x637" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2012,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Jeremyton", "EE8474", "G209588", new DateTime(1976, 1, 28, 0, 0, 0, 0, DateTimeKind.Local), "Desiree56@gmail.com", "Desiree", "Ryan", "Finland", "332-609-6936" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2013,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Patiencetown", "EE58144", 3, "G358199", new DateTime(1959, 9, 21, 0, 0, 0, 0, DateTimeKind.Local), "Sarah63@gmail.com", "Sarah", "Christiansen", "Nauru", "1-321-318-2825 x724" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2014,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "North Francesco", "EE38872", "G561721", new DateTime(1980, 10, 24, 0, 0, 0, 0, DateTimeKind.Local), "Angel8@yahoo.com", "Angel", "Balistreri", "Bulgaria", "1-995-274-9383 x601" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2015,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Tremblayland", "EE49981", 2, "G48545", new DateTime(1990, 7, 9, 0, 0, 0, 0, DateTimeKind.Local), "Ebony.Ryan@yahoo.com", "Ebony", "Ryan", "Malta", "815-641-3277", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2016,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Porterport", "EE4063", "G413395", new DateTime(1992, 12, 27, 0, 0, 0, 0, DateTimeKind.Local), "Gloria47@hotmail.com", "Gloria", "Tromp", "Norway", "(725) 790-9497 x81974", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2017,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "East Emersonchester", "EE15937", 3, "G333036", new DateTime(1982, 4, 15, 0, 0, 0, 0, DateTimeKind.Local), "Russell.Predovic99@yahoo.com", "Russell", "Predovic", "Turks and Caicos Islands", "522.596.8256 x3552" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2018,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Howellfort", "EE34177", 4, "G482358", new DateTime(1984, 6, 6, 0, 0, 0, 0, DateTimeKind.Local), "Jeff_Kertzmann65@hotmail.com", "Jeff", "Kertzmann", "Yemen", "669.530.1868 x03694" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2019,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Ferryview", "EE51460", 2, "G261740", new DateTime(2000, 5, 5, 0, 0, 0, 0, DateTimeKind.Local), "Lyle7@yahoo.com", "Lyle", "Fahey", "Yemen", "1-990-718-5478 x0707", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2020,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Nitzscheport", "EE8136", 1, "G323723", new DateTime(1994, 10, 5, 0, 0, 0, 0, DateTimeKind.Local), "Kim.Moore@yahoo.com", "Kim", "Moore", "Portugal", "807-975-2663", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2021,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "New Esteban", "EE15192", "G118348", new DateTime(1963, 10, 24, 0, 0, 0, 0, DateTimeKind.Local), "Megan30@gmail.com", "Megan", "McKenzie", "Paraguay", "(667) 352-4382", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2022,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Tevinstad", "EE6482", 4, "G39098", new DateTime(1953, 5, 18, 0, 0, 0, 0, DateTimeKind.Local), "Delbert19@gmail.com", "Delbert", "Lakin", "Peru", "1-266-238-5796" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2023,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Julieport", "EE14991", 1, "G422253", new DateTime(1975, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), "Jennifer_Johnson35@yahoo.com", "Jennifer", "Johnson", "Moldova", "1-321-768-0265" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2024,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Roslynmouth", "EE40708", "G262393", new DateTime(1986, 1, 29, 0, 0, 0, 0, DateTimeKind.Local), "Sara12@yahoo.com", "Sara", "Bashirian", "Luxembourg", "(815) 650-8842 x813", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2025,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Kristian", "EE24798", 2, "G335867", new DateTime(2000, 1, 6, 0, 0, 0, 0, DateTimeKind.Local), "Erika.Gleason86@hotmail.com", "Erika", "Gleason", "Suriname", "(235) 253-5299 x962" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2026,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "New Nealburgh", "EE14249", 3, "G402043", new DateTime(1970, 11, 20, 0, 0, 0, 0, DateTimeKind.Local), "Allison.Witting95@hotmail.com", "Allison", "Witting", "Pitcairn Islands", "1-325-988-1968", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2027,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Bernardoview", "EE556", "G592133", new DateTime(1952, 12, 31, 0, 0, 0, 0, DateTimeKind.Local), "Bennie_Satterfield@yahoo.com", "Bennie", "Satterfield", "El Salvador", "388-801-2837", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2028,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Travisville", "EE3987", 2, "G231046", new DateTime(1964, 10, 21, 0, 0, 0, 0, DateTimeKind.Local), "Katrina_Trantow87@hotmail.com", "Katrina", "Trantow", "Italy", "(874) 931-7630 x175" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2029,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "North Thomastown", "EE14117", 2, "G276593", new DateTime(1976, 4, 26, 0, 0, 0, 0, DateTimeKind.Local), "Willard57@hotmail.com", "Willard", "Bogisich", "Nigeria", "(707) 261-8924 x8080" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2030,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Kevinstad", "EE28838", 1, "G30842", new DateTime(1957, 3, 11, 0, 0, 0, 0, DateTimeKind.Local), "Violet.Crona80@yahoo.com", "Violet", "Crona", "Guinea", "871.964.5738 x5166", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2031,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Joyce", "EE52810", 2, "G245521", new DateTime(1999, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), "Ray40@hotmail.com", "Ray", "Bailey", "Venezuela", "1-317-876-2963 x5438" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2032,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Brownchester", "EE38930", "G359506", new DateTime(1953, 8, 24, 0, 0, 0, 0, DateTimeKind.Local), "Salvador_Gerhold46@yahoo.com", "Salvador", "Gerhold", "Guinea", "1-910-415-5601", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2033,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Labadieland", "EE4058", 4, "G496516", new DateTime(1980, 8, 20, 0, 0, 0, 0, DateTimeKind.Local), "Susan8@hotmail.com", "Susan", "Abbott", "French Southern Territories", "1-566-706-8059 x8832", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2034,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Brianachester", "EE48080", 4, "G25397", new DateTime(1979, 5, 24, 0, 0, 0, 0, DateTimeKind.Local), "Preston_Halvorson99@gmail.com", "Preston", "Halvorson", "Andorra", "680.678.2190 x29085" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2035,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Robertaland", "EE13660", 2, "G155821", new DateTime(1985, 3, 6, 0, 0, 0, 0, DateTimeKind.Local), "Vincent.Lakin@yahoo.com", "Vincent", "Lakin", "Svalbard & Jan Mayen Islands", "(775) 214-9618 x2914", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2036,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Donnellyton", "EE10179", "G342999", new DateTime(2000, 5, 7, 0, 0, 0, 0, DateTimeKind.Local), "Constance_Cormier@yahoo.com", "Constance", "Cormier", "Falkland Islands (Malvinas)", "(941) 653-9608" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2037,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Gerholdstad", "EE34001", 1, "G90857", new DateTime(1997, 11, 15, 0, 0, 0, 0, DateTimeKind.Local), "Nicholas_Nitzsche73@gmail.com", "Nicholas", "Nitzsche", "Spain", "824.763.3127 x5769" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2038,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "DuBuquetown", "EE5253", "G567457", new DateTime(1981, 7, 1, 0, 0, 0, 0, DateTimeKind.Local), "Sabrina.Olson@yahoo.com", "Sabrina", "Olson", "France", "726-239-3279", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2039,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Kaceyhaven", "EE42058", 4, "G277147", new DateTime(1983, 7, 31, 0, 0, 0, 0, DateTimeKind.Local), "Henry_Walter@gmail.com", "Henry", "Walter", "Holy See (Vatican City State)", "658.509.8645 x77036" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2040,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Noemystad", "EE210", 1, "G159808", new DateTime(1966, 4, 12, 0, 0, 0, 0, DateTimeKind.Local), "Dianna92@yahoo.com", "Dianna", "Rippin", "Gambia", "286-214-6461 x5253", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2041,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Christymouth", "EE23373", 4, "G466531", new DateTime(1951, 11, 25, 0, 0, 0, 0, DateTimeKind.Local), "Troy18@yahoo.com", "Troy", "Schulist", "Iceland", "1-532-965-7796 x40679", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2042,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Jewellville", "EE44564", 1, "G190628", new DateTime(1995, 8, 31, 0, 0, 0, 0, DateTimeKind.Local), "Kendra_McGlynn@hotmail.com", "Kendra", "McGlynn", "Equatorial Guinea", "(464) 397-7675 x59681", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2043,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Gerardshire", "EE4423", 4, "G58740", new DateTime(1969, 6, 26, 0, 0, 0, 0, DateTimeKind.Local), "Katherine74@gmail.com", "Katherine", "Pfannerstill", "Gabon", "(644) 648-0108" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2044,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "North Keenan", "EE44795", "G589587", new DateTime(1953, 9, 26, 0, 0, 0, 0, DateTimeKind.Local), "Wayne.Nikolaus@gmail.com", "Wayne", "Nikolaus", "Norway", "(851) 860-5314 x27837" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2045,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Madisyn", "EE18621", 4, "G593057", new DateTime(1970, 5, 11, 0, 0, 0, 0, DateTimeKind.Local), "Antonia_Feeney@hotmail.com", "Antonia", "Feeney", "Saint Martin", "274.865.4404 x9385" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2046,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Abrahamstad", "EE53526", "G63772", new DateTime(1996, 7, 13, 0, 0, 0, 0, DateTimeKind.Local), "Willard_Cruickshank13@gmail.com", "Willard", "Cruickshank", "India", "1-208-341-2792" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2047,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Karlborough", "EE20153", "G453466", new DateTime(1954, 4, 1, 0, 0, 0, 0, DateTimeKind.Local), "Ebony71@yahoo.com", "Ebony", "Ryan", "Bouvet Island (Bouvetoya)", "662.402.7368 x2597", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2048,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Hughbury", "EE17789", 4, "G345439", new DateTime(1963, 3, 5, 0, 0, 0, 0, DateTimeKind.Local), "William_Effertz17@gmail.com", "William", "Effertz", "Bahamas", "1-343-607-9380 x674", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2049,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Padbergmouth", "EE40102", "G286472", new DateTime(1955, 8, 25, 0, 0, 0, 0, DateTimeKind.Local), "Flora.Balistreri@yahoo.com", "Flora", "Balistreri", "Algeria", "825-564-9004", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2050,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Theodoraville", "EE48095", 2, "G25956", new DateTime(1985, 8, 27, 0, 0, 0, 0, DateTimeKind.Local), "Clara.Daniel73@yahoo.com", "Clara", "Daniel", "Macedonia", "215.655.2361 x826", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2051,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Orlandchester", "EE15149", "G79775", new DateTime(1984, 10, 5, 0, 0, 0, 0, DateTimeKind.Local), "Felipe84@yahoo.com", "Felipe", "Bashirian", "Martinique", "491.938.2446" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2052,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Athenaland", "EE16283", "G232848", new DateTime(1998, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), "Dominick_Murphy@yahoo.com", "Dominick", "Murphy", "Hong Kong", "1-771-738-6428 x15778", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2053,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Enriqueshire", "EE11894", "G488422", new DateTime(1993, 9, 8, 0, 0, 0, 0, DateTimeKind.Local), "Marlene.Larson@yahoo.com", "Marlene", "Larson", "Cocos (Keeling) Islands", "(663) 870-4915 x4366" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2054,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Keyshawnborough", "EE47910", 2, "G383915", new DateTime(1979, 10, 14, 0, 0, 0, 0, DateTimeKind.Local), "Fernando_Dickinson@gmail.com", "Fernando", "Dickinson", "Palestinian Territory", "539.456.6399 x048" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2055,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Gracielamouth", "EE42348", 3, "G555583", new DateTime(1971, 6, 6, 0, 0, 0, 0, DateTimeKind.Local), "Amos_Wolf18@gmail.com", "Amos", "Wolf", "Bermuda", "773-921-8159" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2056,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "North Vita", "EE31602", 4, "G245967", new DateTime(1997, 12, 3, 0, 0, 0, 0, DateTimeKind.Local), "Leigh_Emmerich@hotmail.com", "Leigh", "Emmerich", "Morocco", "(434) 228-2929" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2057,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Anya", "EE31842", 2, "G410033", new DateTime(1963, 1, 28, 0, 0, 0, 0, DateTimeKind.Local), "Andy.Lubowitz@hotmail.com", "Andy", "Lubowitz", "Saint Vincent and the Grenadines", "966-414-5820", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2058,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Ericamouth", "EE18835", "G428095", new DateTime(1982, 3, 23, 0, 0, 0, 0, DateTimeKind.Local), "Adrian.Rowe@yahoo.com", "Adrian", "Rowe", "Belarus", "587-714-8416 x0177", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2059,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Port Cecilia", "EE44817", 2, "G250313", new DateTime(1973, 5, 14, 0, 0, 0, 0, DateTimeKind.Local), "Bob34@hotmail.com", "Bob", "Hermann", "Moldova", "1-352-956-3733" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2060,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Imogene", "EE1621", 2, "G310078", new DateTime(1962, 2, 24, 0, 0, 0, 0, DateTimeKind.Local), "Dennis.White@yahoo.com", "Dennis", "White", "Mayotte", "858-238-2070 x667", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2061,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Zanemouth", "EE17413", 1, "G568450", new DateTime(1974, 12, 13, 0, 0, 0, 0, DateTimeKind.Local), "Joseph.Lueilwitz95@gmail.com", "Joseph", "Lueilwitz", "Lithuania", "365-353-2961", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2062,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Eriberto", "EE43129", "G249779", new DateTime(1978, 4, 23, 0, 0, 0, 0, DateTimeKind.Local), "Dallas_Walker58@gmail.com", "Dallas", "Walker", "Samoa", "(918) 660-7906 x60447" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2063,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Crawfordchester", "EE57953", 4, "G406518", new DateTime(1979, 12, 23, 0, 0, 0, 0, DateTimeKind.Local), "Elena.Prohaska@hotmail.com", "Elena", "Prohaska", "Sweden", "600.252.0121 x734" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2064,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Ellsworthside", "EE48715", 1, "G387257", new DateTime(1975, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), "Jimmie.Yundt@hotmail.com", "Jimmie", "Yundt", "Greenland", "1-515-658-5225" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2065,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Gwen", "EE3902", 1, "G560415", new DateTime(1998, 2, 28, 0, 0, 0, 0, DateTimeKind.Local), "Valerie.Lubowitz@yahoo.com", "Valerie", "Lubowitz", "Lebanon", "(866) 863-9306 x275", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2066,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Hayesport", "EE53264", "G495680", new DateTime(1972, 5, 8, 0, 0, 0, 0, DateTimeKind.Local), "Austin45@yahoo.com", "Austin", "Wyman", "Poland", "939.976.6936", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2067,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Raynortown", "EE57018", 1, "G112880", new DateTime(1973, 6, 2, 0, 0, 0, 0, DateTimeKind.Local), "Pamela82@yahoo.com", "Pamela", "Schuster", "Macedonia", "1-372-892-7968 x061", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2068,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Boydport", "EE22081", 2, "G560043", new DateTime(1954, 11, 28, 0, 0, 0, 0, DateTimeKind.Local), "Donald_Gerlach@yahoo.com", "Donald", "Gerlach", "Fiji", "894-651-3792 x28395", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2069,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Demario", "EE11396", 2, "G509806", new DateTime(1985, 3, 3, 0, 0, 0, 0, DateTimeKind.Local), "Jenna2@yahoo.com", "Jenna", "Lynch", "Belgium", "666-211-2718 x99014", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2070,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Ondrickamouth", "EE34120", 4, "G388892", new DateTime(1971, 6, 28, 0, 0, 0, 0, DateTimeKind.Local), "Johnnie_Connelly25@yahoo.com", "Johnnie", "Connelly", "Falkland Islands (Malvinas)", "898.697.8856 x041", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2071,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Clemensport", "EE39530", 2, "G536589", new DateTime(1999, 2, 16, 0, 0, 0, 0, DateTimeKind.Local), "Ben25@hotmail.com", "Ben", "Gleason", "Guinea", "732-426-8907 x7082" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2072,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Kalemouth", "EE42560", "G467843", new DateTime(1982, 10, 14, 0, 0, 0, 0, DateTimeKind.Local), "Gayle_Von7@yahoo.com", "Gayle", "Von", "Aruba", "(923) 951-8376 x01489" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2073,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lake Lilianaville", "EE41007", 4, "G17866", new DateTime(1989, 12, 6, 0, 0, 0, 0, DateTimeKind.Local), "Mamie50@gmail.com", "Mamie", "Lemke", "France", "1-767-470-5299 x687", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2074,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Amayaside", "EE11410", 1, "G559129", new DateTime(1995, 3, 29, 0, 0, 0, 0, DateTimeKind.Local), "Lynne_Weber30@yahoo.com", "Lynne", "Weber", "Macedonia", "(914) 972-8333 x332", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2075,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Batzborough", "EE30387", 2, "G427564", new DateTime(1968, 4, 13, 0, 0, 0, 0, DateTimeKind.Local), "Ed96@gmail.com", "Ed", "Davis", "Azerbaijan", "535.573.6947 x11756" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2076,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Hillsville", "EE24721", "G10520", new DateTime(1953, 11, 28, 0, 0, 0, 0, DateTimeKind.Local), "Norma7@hotmail.com", "Norma", "Bergstrom", "Lebanon", "(487) 921-3143 x8429", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2077,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Hollie", "EE37263", "G565109", new DateTime(2000, 5, 9, 0, 0, 0, 0, DateTimeKind.Local), "Erik74@gmail.com", "Erik", "Goldner", "San Marino", "788.653.8244 x1414" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2078,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Brendanfort", "EE35183", 4, "G166253", new DateTime(1992, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), "Taylor_Luettgen97@gmail.com", "Taylor", "Luettgen", "Mozambique", "229.267.3107" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2079,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Fanniebury", "EE40356", 2, "G278090", new DateTime(1957, 3, 7, 0, 0, 0, 0, DateTimeKind.Local), "Morris75@yahoo.com", "Morris", "Christiansen", "Antarctica (the territory South of 60 deg S)", "(922) 945-1636 x547", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2080,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Port Maudeburgh", "EE53839", 3, "G248905", new DateTime(1964, 8, 24, 0, 0, 0, 0, DateTimeKind.Local), "Michelle_Corkery90@gmail.com", "Michelle", "Corkery", "Thailand", "(717) 970-7746 x8692" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2081,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Andersonmouth", "EE36694", 1, "G160718", new DateTime(1959, 10, 4, 0, 0, 0, 0, DateTimeKind.Local), "Dorothy5@gmail.com", "Dorothy", "Toy", "Gambia", "1-546-576-5430" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2082,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Providencimouth", "EE6256", "G172659", new DateTime(1998, 2, 8, 0, 0, 0, 0, DateTimeKind.Local), "Dana.Parisian46@hotmail.com", "Dana", "Parisian", "Namibia", "855-712-4041" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2083,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Jeanetteburgh", "EE6720", 3, "G161579", new DateTime(1976, 6, 4, 0, 0, 0, 0, DateTimeKind.Local), "Johnathan_Nicolas61@hotmail.com", "Johnathan", "Nicolas", "Mauritania", "790-723-4686 x61040" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2084,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Carmelaborough", "EE16915", "G444721", new DateTime(1988, 1, 9, 0, 0, 0, 0, DateTimeKind.Local), "Dominic.Franecki@hotmail.com", "Dominic", "Franecki", "Spain", "1-380-337-0410", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2085,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Delores", "EE17893", 2, "G175200", new DateTime(1974, 12, 25, 0, 0, 0, 0, DateTimeKind.Local), "Guy.Kemmer@gmail.com", "Guy", "Kemmer", "Kazakhstan", "773.566.4375 x48586", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2086,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Elvis", "EE45548", 2, "G517061", new DateTime(1987, 4, 28, 0, 0, 0, 0, DateTimeKind.Local), "Annette.Hagenes@gmail.com", "Annette", "Hagenes", "Vietnam", "(824) 435-3755", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2087,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "North Willishaven", "EE22373", 4, "G90183", new DateTime(1981, 5, 8, 0, 0, 0, 0, DateTimeKind.Local), "Bert87@yahoo.com", "Bert", "Pollich", "Samoa", "878-710-1375" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2088,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Laynemouth", "EE12295", 3, "G289594", new DateTime(1987, 7, 30, 0, 0, 0, 0, DateTimeKind.Local), "Ruth63@yahoo.com", "Ruth", "Schamberger", "Timor-Leste", "695-612-9888 x121", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2089,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Mosciskibury", "EE51679", 1, "G384314", new DateTime(1979, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), "Milton39@gmail.com", "Milton", "Schowalter", "Taiwan", "(893) 689-8225", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2090,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Izaiahview", "EE40437", 1, "G272528", new DateTime(1952, 9, 9, 0, 0, 0, 0, DateTimeKind.Local), "Roberta87@yahoo.com", "Roberta", "Mante", "Cuba", "994.430.4144 x45010", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2091,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Edytheburgh", "EE16746", "G175713", new DateTime(1954, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), "Otis5@gmail.com", "Otis", "Boehm", "Tuvalu", "1-890-335-7615", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2092,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Ernaborough", "EE24129", 1, "G574729", new DateTime(1999, 1, 13, 0, 0, 0, 0, DateTimeKind.Local), "Kellie61@gmail.com", "Kellie", "Fritsch", "Hungary", "(724) 854-1775" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2093,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Wilford", "EE29002", 3, "G36205", new DateTime(1967, 4, 18, 0, 0, 0, 0, DateTimeKind.Local), "Lorraine57@gmail.com", "Lorraine", "Buckridge", "Guatemala", "524.677.6061 x91899", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2094,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Schultztown", "EE44660", "G93326", new DateTime(1995, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), "Micheal77@gmail.com", "Micheal", "Thompson", "Virgin Islands, U.S.", "1-904-243-3895", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2095,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lake Mariomouth", "EE54764", 4, "G89845", new DateTime(1965, 2, 28, 0, 0, 0, 0, DateTimeKind.Local), "Amanda65@gmail.com", "Amanda", "Funk", "Australia", "533.678.3543 x424", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2096,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Kovacekchester", "EE11844", 3, "G211873", new DateTime(1964, 10, 20, 0, 0, 0, 0, DateTimeKind.Local), "Darnell.Greenholt78@hotmail.com", "Darnell", "Greenholt", "Sri Lanka", "893-408-8704", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2097,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Friedabury", "EE11870", 4, "G29788", new DateTime(1988, 9, 25, 0, 0, 0, 0, DateTimeKind.Local), "Jim19@yahoo.com", "Jim", "Cummings", "Luxembourg", "529-704-5125 x235" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2098,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Romaineton", "EE27112", 4, "G254807", new DateTime(1995, 6, 14, 0, 0, 0, 0, DateTimeKind.Local), "Susan64@hotmail.com", "Susan", "Walker", "American Samoa", "780-373-4601", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2099,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Koeppland", "EE8904", 3, "G347159", new DateTime(1953, 12, 28, 0, 0, 0, 0, DateTimeKind.Local), "Lorene.Dach@gmail.com", "Lorene", "Dach", "El Salvador", "912.361.2631 x6263" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2100,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Roweshire", "EE7818", 3, "G494353", new DateTime(1982, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), "Myron42@yahoo.com", "Myron", "Stroman", "Lesotho", "480-930-0837", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2101,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Emie", "EE10394", 4, "G352645", new DateTime(1988, 5, 19, 0, 0, 0, 0, DateTimeKind.Local), "Terrance17@gmail.com", "Terrance", "Mante", "Rwanda", "497.975.2518 x6667", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2102,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Harrymouth", "EE20875", 3, "G139003", new DateTime(1993, 11, 11, 0, 0, 0, 0, DateTimeKind.Local), "Doug.Hackett18@gmail.com", "Doug", "Hackett", "Mongolia", "228.451.1765 x909" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2103,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "lastname", "natio", "phone" },
                values: new object[] { "East Stuart", "EE41931", 2, "G494184", new DateTime(1978, 10, 21, 0, 0, 0, 0, DateTimeKind.Local), "Phillip_Goldner55@hotmail.com", "Goldner", "Sweden", "(404) 835-8783" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2104,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "VonRuedenmouth", "EE46875", 2, "G296494", new DateTime(1977, 7, 19, 0, 0, 0, 0, DateTimeKind.Local), "Michelle.Bode@hotmail.com", "Michelle", "Bode", "Jamaica", "(373) 732-2698", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2105,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Adrien", "EE28361", 1, "G118321", new DateTime(1955, 12, 20, 0, 0, 0, 0, DateTimeKind.Local), "Bernice30@yahoo.com", "Bernice", "Lueilwitz", "India", "969.612.9139", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2106,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lake Esmeralda", "EE20130", 2, "G244517", new DateTime(1981, 3, 29, 0, 0, 0, 0, DateTimeKind.Local), "Lawrence_Weimann69@hotmail.com", "Lawrence", "Weimann", "Guinea-Bissau", "(805) 980-3352 x01673", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2107,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "East Corachester", "EE42154", 3, "G280110", new DateTime(1988, 9, 19, 0, 0, 0, 0, DateTimeKind.Local), "Madeline8@gmail.com", "Madeline", "Fadel", "United States of America", "829-517-9829" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2108,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Khalil", "EE25330", "G312517", new DateTime(2001, 2, 22, 0, 0, 0, 0, DateTimeKind.Local), "Francisco.Gerhold43@gmail.com", "Francisco", "Gerhold", "Swaziland", "585.967.9751 x43539", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2109,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Destinistad", "EE23151", 4, "G582982", new DateTime(2000, 1, 31, 0, 0, 0, 0, DateTimeKind.Local), "Josephine_Gislason92@gmail.com", "Josephine", "Gislason", "Lithuania", "422.532.5411 x83039", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2110,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Laurynland", "EE4792", "G457391", new DateTime(1955, 9, 22, 0, 0, 0, 0, DateTimeKind.Local), "Claude.Hickle@gmail.com", "Claude", "Hickle", "Portugal", "(958) 640-4734", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2111,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Fosterhaven", "EE51377", 2, "G158006", new DateTime(1986, 5, 10, 0, 0, 0, 0, DateTimeKind.Local), "Marvin_Brekke@yahoo.com", "Marvin", "Brekke", "Pakistan", "942.899.2155 x882" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2112,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Gleichnerfort", "EE13383", 3, "G168045", new DateTime(1991, 1, 10, 0, 0, 0, 0, DateTimeKind.Local), "Debra69@yahoo.com", "Debra", "Wintheiser", "Bahrain", "1-642-445-3997 x005" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2113,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Teaganmouth", "EE36563", 4, "G486389", new DateTime(1974, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), "Tiffany_Kohler@gmail.com", "Tiffany", "Kohler", "United States Minor Outlying Islands", "(603) 209-2535 x67831", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2114,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Myah", "EE27995", 1, "G189620", new DateTime(1995, 11, 18, 0, 0, 0, 0, DateTimeKind.Local), "Lynne_Christiansen@hotmail.com", "Lynne", "Christiansen", "French Southern Territories", "(740) 860-8207 x2456", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2115,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Ornport", "EE59034", 2, "G93260", new DateTime(1995, 10, 26, 0, 0, 0, 0, DateTimeKind.Local), "Diane_Cartwright45@yahoo.com", "Diane", "Cartwright", "Myanmar", "898-559-6280 x1149" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2116,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Princeland", "EE44363", 1, "G470819", new DateTime(1954, 11, 24, 0, 0, 0, 0, DateTimeKind.Local), "Noah.Rath@hotmail.com", "Noah", "Rath", "Australia", "1-996-584-4305 x91576", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2117,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Itzelchester", "EE9037", 1, "G186851", new DateTime(1999, 5, 3, 0, 0, 0, 0, DateTimeKind.Local), "Jay.Brakus@yahoo.com", "Jay", "Brakus", "India", "(609) 258-7727 x1167", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2118,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "North Lucindastad", "EE18459", 2, "G558586", new DateTime(1951, 10, 12, 0, 0, 0, 0, DateTimeKind.Local), "Marta_Ryan24@yahoo.com", "Marta", "Ryan", "Madagascar", "488.401.7367" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2119,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Franeckibury", "EE9535", 4, "G486431", new DateTime(1985, 3, 17, 0, 0, 0, 0, DateTimeKind.Local), "Monique.Rau75@yahoo.com", "Monique", "Rau", "Lao People's Democratic Republic", "425.437.5069", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2120,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Arnoldoland", "EE57454", 2, "G213237", new DateTime(1982, 2, 13, 0, 0, 0, 0, DateTimeKind.Local), "Ella74@hotmail.com", "Ella", "Gutmann", "New Zealand", "437.267.5082" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2121,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Jacobsfurt", "EE43938", 2, "G99264", new DateTime(1994, 10, 20, 0, 0, 0, 0, DateTimeKind.Local), "Joan.Rau@hotmail.com", "Joan", "Rau", "Bulgaria", "(296) 632-8312", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2122,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Theron", "EE11939", 3, "G200110", new DateTime(1957, 2, 13, 0, 0, 0, 0, DateTimeKind.Local), "Jan68@gmail.com", "Jan", "Abshire", "Samoa", "570.684.9237 x0860" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2123,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Runolfssonshire", "EE43955", 3, "G454047", new DateTime(1958, 9, 27, 0, 0, 0, 0, DateTimeKind.Local), "Lorraine34@hotmail.com", "Lorraine", "Hermiston", "Virgin Islands, U.S.", "804.306.8052 x494" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2124,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lake Wendellburgh", "EE21348", 4, "G180710", new DateTime(1990, 2, 21, 0, 0, 0, 0, DateTimeKind.Local), "Tony_Franecki30@gmail.com", "Tony", "Franecki", "Cayman Islands", "1-260-422-2769 x653", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2125,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Walterborough", "EE1495", 4, "G204099", new DateTime(1989, 11, 3, 0, 0, 0, 0, DateTimeKind.Local), "Karen47@yahoo.com", "Karen", "Lueilwitz", "Palestinian Territory", "410.753.6250", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2126,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Skylarmouth", "EE27081", "G377614", new DateTime(1963, 9, 6, 0, 0, 0, 0, DateTimeKind.Local), "Kristina17@hotmail.com", "Kristina", "Skiles", "Poland", "1-237-604-0841" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2127,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Nyasia", "EE51388", 3, "G396629", new DateTime(1965, 3, 19, 0, 0, 0, 0, DateTimeKind.Local), "Sylvia13@gmail.com", "Sylvia", "Schroeder", "Sweden", "(738) 529-2846 x970" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2128,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lockmanfurt", "EE10701", 1, "G71954", new DateTime(1999, 11, 19, 0, 0, 0, 0, DateTimeKind.Local), "William.Schneider@hotmail.com", "William", "Schneider", "Equatorial Guinea", "901-750-6645 x1171" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2129,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Chelsieton", "EE55011", 2, "G291740", new DateTime(1961, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), "Teri_Rodriguez24@hotmail.com", "Teri", "Rodriguez", "Monaco", "873.599.1225 x0712", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2130,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Fostershire", "EE40595", 2, "G585779", new DateTime(1976, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), "Terrence24@hotmail.com", "Terrence", "Breitenberg", "Hong Kong", "(328) 760-1762 x5103", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2131,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Brielleland", "EE44239", 3, "G363781", new DateTime(1986, 10, 9, 0, 0, 0, 0, DateTimeKind.Local), "Nathaniel_Haley@yahoo.com", "Nathaniel", "Haley", "Portugal", "(879) 347-2307 x92336" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2132,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Weston", "EE22005", "G56984", new DateTime(1977, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), "Guillermo_Senger36@hotmail.com", "Guillermo", "Senger", "Paraguay", "1-913-629-8985 x1225", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2133,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "New Warren", "EE14593", "G64162", new DateTime(1951, 12, 20, 0, 0, 0, 0, DateTimeKind.Local), "Patti24@gmail.com", "Patti", "Witting", "Afghanistan", "466-383-9465", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2134,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Rasheed", "EE11159", "G402240", new DateTime(1975, 10, 25, 0, 0, 0, 0, DateTimeKind.Local), "Marjorie12@hotmail.com", "Marjorie", "Ratke", "Jersey", "355-422-7283 x254", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2135,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Carrollview", "EE52949", 4, "G347498", new DateTime(1953, 2, 7, 0, 0, 0, 0, DateTimeKind.Local), "Walter90@gmail.com", "Walter", "Tremblay", "Cameroon", "(665) 347-1857" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2136,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Lyrictown", "EE58973", 2, "G468317", new DateTime(1967, 1, 14, 0, 0, 0, 0, DateTimeKind.Local), "Willie_Robel@gmail.com", "Willie", "Robel", "India", "(398) 647-6756 x06396", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2137,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Armstrongstad", "EE9708", 1, "G289650", new DateTime(1954, 9, 17, 0, 0, 0, 0, DateTimeKind.Local), "Crystal_Kshlerin@hotmail.com", "Crystal", "Kshlerin", "Cook Islands", "687.419.1861" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2138,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Linda", "EE38192", 4, "G554231", new DateTime(1985, 11, 15, 0, 0, 0, 0, DateTimeKind.Local), "Rogelio46@gmail.com", "Rogelio", "Macejkovic", "Croatia", "847-927-4432 x1697", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2139,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Matteomouth", "EE25640", "G515401", new DateTime(1955, 10, 15, 0, 0, 0, 0, DateTimeKind.Local), "Troy34@hotmail.com", "Troy", "Jast", "Tonga", "387.968.2167 x606", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2140,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Port Alessiafort", "EE9553", "G173956", new DateTime(1964, 2, 3, 0, 0, 0, 0, DateTimeKind.Local), "Roxanne_Schaden74@gmail.com", "Roxanne", "Schaden", "Faroe Islands", "513-604-9858 x197" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2141,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Talonhaven", "EE4298", 2, "G261993", new DateTime(1977, 7, 30, 0, 0, 0, 0, DateTimeKind.Local), "Jared.Nolan94@gmail.com", "Jared", "Nolan", "China", "470.397.0683", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2142,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Clementineview", "EE24831", "G325724", new DateTime(1981, 11, 24, 0, 0, 0, 0, DateTimeKind.Local), "Chelsea89@yahoo.com", "Chelsea", "Klein", "Montserrat", "1-570-253-7345", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2143,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lexiport", "EE13337", "G43820", new DateTime(1999, 4, 26, 0, 0, 0, 0, DateTimeKind.Local), "Albert_Bogisich@yahoo.com", "Albert", "Bogisich", "Gambia", "1-535-414-0164 x904" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2144,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Haileyberg", "EE53958", 3, "G288062", new DateTime(1994, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "Victoria_Deckow98@yahoo.com", "Victoria", "Deckow", "Burundi", "637-901-9635 x32866", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2145,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Ramiroton", "EE38419", "G139715", new DateTime(1966, 2, 5, 0, 0, 0, 0, DateTimeKind.Local), "Wendy54@gmail.com", "Wendy", "Grimes", "Cocos (Keeling) Islands", "(242) 794-4241 x413", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2146,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Pearlfurt", "EE15289", 1, "G491034", new DateTime(1992, 9, 22, 0, 0, 0, 0, DateTimeKind.Local), "Douglas.Veum@hotmail.com", "Douglas", "Veum", "Saint Lucia", "(973) 646-0533 x57566", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2147,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Faheyville", "EE19262", 1, "G12565", new DateTime(1956, 3, 5, 0, 0, 0, 0, DateTimeKind.Local), "James_Hayes@yahoo.com", "James", "Hayes", "Australia", "707.712.1153", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2148,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lake Dennis", "EE10266", 1, "G25338", new DateTime(1992, 10, 14, 0, 0, 0, 0, DateTimeKind.Local), "Laverne.Lemke98@hotmail.com", "Laverne", "Lemke", "Syrian Arab Republic", "1-255-374-8323", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2149,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Whiteside", "EE37051", 2, "G599989", new DateTime(1988, 9, 9, 0, 0, 0, 0, DateTimeKind.Local), "Charlie40@yahoo.com", "Charlie", "Orn", "Moldova", "378.406.8092", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2150,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Abernathyville", "EE1764", 4, "G464570", new DateTime(1974, 11, 22, 0, 0, 0, 0, DateTimeKind.Local), "Josh.Reinger22@hotmail.com", "Josh", "Reinger", "Iceland", "(857) 751-1333 x593" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2151,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Hammesland", "EE15223", 3, "G143311", new DateTime(1994, 10, 11, 0, 0, 0, 0, DateTimeKind.Local), "Karl_Hagenes@gmail.com", "Karl", "Hagenes", "Guinea", "(932) 364-7390" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2152,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Kuhnbury", "EE27293", 1, "G287819", new DateTime(1976, 4, 19, 0, 0, 0, 0, DateTimeKind.Local), "Darrel9@gmail.com", "Darrel", "Hettinger", "United Arab Emirates", "818.767.8649 x17658", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2153,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Dantebury", "EE52339", 3, "G482748", new DateTime(1961, 1, 4, 0, 0, 0, 0, DateTimeKind.Local), "Katherine58@yahoo.com", "Katherine", "Gusikowski", "Brunei Darussalam", "979-277-9173", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2154,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Aileenhaven", "EE11326", 2, "G304508", new DateTime(1981, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), "Kim_Gerhold@hotmail.com", "Kim", "Gerhold", "Spain", "647-654-9952 x9228" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2155,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Marvinchester", "EE34380", "G225676", new DateTime(1959, 9, 9, 0, 0, 0, 0, DateTimeKind.Local), "Vanessa4@gmail.com", "Vanessa", "Schroeder", "China", "420-270-2701" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2156,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Darienmouth", "EE3148", "G191455", new DateTime(1954, 7, 13, 0, 0, 0, 0, DateTimeKind.Local), "Bradley_Lynch@yahoo.com", "Bradley", "Lynch", "Nepal", "948.370.0866 x80731" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2157,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Schmittville", "EE38887", 4, "G137164", new DateTime(1979, 2, 15, 0, 0, 0, 0, DateTimeKind.Local), "Elias.Wehner@yahoo.com", "Elias", "Wehner", "Anguilla", "(852) 805-2835", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2158,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Domenicport", "EE49898", 2, "G229337", new DateTime(1989, 2, 7, 0, 0, 0, 0, DateTimeKind.Local), "Jose99@gmail.com", "Jose", "Hickle", "Taiwan", "611.567.1898 x69119", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2159,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Nilsmouth", "EE14583", "G187786", new DateTime(1963, 8, 21, 0, 0, 0, 0, DateTimeKind.Local), "Mary.Schmitt@gmail.com", "Mary", "Schmitt", "Cameroon", "(786) 991-0693" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2160,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "New Zoie", "EE30611", 2, "G573779", new DateTime(1984, 6, 22, 0, 0, 0, 0, DateTimeKind.Local), "Ted28@hotmail.com", "Ted", "Lockman", "Kiribati", "(953) 698-2448 x3943", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2161,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Berryhaven", "EE41593", 4, "G262932", new DateTime(1969, 2, 26, 0, 0, 0, 0, DateTimeKind.Local), "Robert.Hilll53@yahoo.com", "Robert", "Hilll", "Serbia", "1-792-238-2019", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2162,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Katharinaburgh", "EE57742", 1, "G88052", new DateTime(1980, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), "Tricia.Legros@hotmail.com", "Tricia", "Legros", "Myanmar", "989-656-9204", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2163,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Isabella", "EE48688", 4, "G374584", new DateTime(1985, 11, 26, 0, 0, 0, 0, DateTimeKind.Local), "Ivan58@yahoo.com", "Ivan", "Windler", "Burkina Faso", "(866) 360-5410 x32925" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2164,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "North Rosamond", "EE17045", 1, "G235752", new DateTime(1989, 6, 14, 0, 0, 0, 0, DateTimeKind.Local), "Sarah.Beahan@hotmail.com", "Sarah", "Beahan", "Qatar", "401-609-9887 x643" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2165,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Larsonshire", "EE9687", 2, "G252886", new DateTime(1966, 3, 2, 0, 0, 0, 0, DateTimeKind.Local), "Marjorie.Bruen23@yahoo.com", "Marjorie", "Bruen", "El Salvador", "1-618-688-8767" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2166,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Elda", "EE49966", "G414328", new DateTime(1963, 9, 24, 0, 0, 0, 0, DateTimeKind.Local), "Hugh.Herzog73@hotmail.com", "Hugh", "Herzog", "Russian Federation", "1-523-297-1997 x3152" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2167,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Kuvalischester", "EE11911", "G7061", new DateTime(1963, 12, 19, 0, 0, 0, 0, DateTimeKind.Local), "Mattie.Reilly@yahoo.com", "Mattie", "Reilly", "Honduras", "927.671.7762", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2168,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Rextown", "EE38857", "G325627", new DateTime(2001, 4, 12, 0, 0, 0, 0, DateTimeKind.Local), "Kim79@gmail.com", "Kim", "Wolff", "Samoa", "625-404-9356" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2169,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "phone", "sexe" },
                values: new object[] { "Reesetown", "EE53606", 3, "G448499", new DateTime(1952, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), "Laverne_Reynolds98@hotmail.com", "Laverne", "Reynolds", "305.616.1049 x969", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2170,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Arden", "EE3972", 4, "G488269", new DateTime(1967, 11, 16, 0, 0, 0, 0, DateTimeKind.Local), "Danielle_OReilly@gmail.com", "Danielle", "O'Reilly", "Kenya", "(900) 710-2147 x584", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2171,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lake Margot", "EE23627", 1, "G132284", new DateTime(1984, 12, 18, 0, 0, 0, 0, DateTimeKind.Local), "Lana92@hotmail.com", "Lana", "Bahringer", "Poland", "(650) 767-4084 x072", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2172,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Syble", "EE22689", 3, "G208102", new DateTime(1990, 1, 29, 0, 0, 0, 0, DateTimeKind.Local), "Ken.Rau@yahoo.com", "Ken", "Rau", "Antigua and Barbuda", "491.899.6606 x9396" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2173,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Conroymouth", "EE18485", 2, "G206535", new DateTime(1985, 4, 16, 0, 0, 0, 0, DateTimeKind.Local), "Pauline6@yahoo.com", "Pauline", "Wiza", "Angola", "566-370-9330 x4904", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2174,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Okunevaberg", "EE56712", 1, "G589507", new DateTime(1985, 3, 12, 0, 0, 0, 0, DateTimeKind.Local), "Nathan_Fahey@hotmail.com", "Nathan", "Fahey", "Paraguay", "(522) 882-9679", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2175,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Roweton", "EE2408", "G257765", new DateTime(1959, 4, 9, 0, 0, 0, 0, DateTimeKind.Local), "Gustavo.Bednar@yahoo.com", "Gustavo", "Bednar", "Andorra", "1-642-363-1667 x9572" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2176,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Hagenesmouth", "EE29192", "G475517", new DateTime(1978, 4, 28, 0, 0, 0, 0, DateTimeKind.Local), "Boyd_Weimann82@gmail.com", "Boyd", "Weimann", "Brunei Darussalam", "1-371-792-3848 x926", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2177,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "New Robin", "EE13856", "G449498", new DateTime(1960, 7, 27, 0, 0, 0, 0, DateTimeKind.Local), "Anthony_Weimann@hotmail.com", "Anthony", "Weimann", "Niue", "875.964.5517", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2178,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Marques", "EE20103", 2, "G537191", new DateTime(1962, 3, 16, 0, 0, 0, 0, DateTimeKind.Local), "Tabitha64@gmail.com", "Tabitha", "Brakus", "Cape Verde", "1-972-258-8543" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2179,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Florianstad", "EE19623", 2, "G294445", new DateTime(1991, 2, 12, 0, 0, 0, 0, DateTimeKind.Local), "Janie_Stroman@hotmail.com", "Janie", "Stroman", "Lebanon", "(693) 274-8732 x01460", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2180,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Micheal", "EE38122", 4, "G195766", new DateTime(2001, 3, 30, 0, 0, 0, 0, DateTimeKind.Local), "Israel.Friesen51@hotmail.com", "Israel", "Friesen", "Malta", "427-242-6891 x2893", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2181,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Eden", "EE6338", 1, "G583710", new DateTime(1994, 5, 25, 0, 0, 0, 0, DateTimeKind.Local), "Kimberly73@hotmail.com", "Kimberly", "Schuster", "Afghanistan", "(760) 656-5055 x419" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2182,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Joshuatown", "EE44043", 1, "G271544", new DateTime(1976, 6, 18, 0, 0, 0, 0, DateTimeKind.Local), "Debbie30@gmail.com", "Debbie", "Daugherty", "Malta", "1-887-241-5019 x9664" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2183,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Laurettaland", "EE23355", 1, "G303067", new DateTime(1952, 11, 30, 0, 0, 0, 0, DateTimeKind.Local), "April86@hotmail.com", "April", "Dach", "Montenegro", "681.407.4906 x550" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2184,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lake Camrynside", "EE16357", 1, "G371813", new DateTime(1958, 2, 1, 0, 0, 0, 0, DateTimeKind.Local), "Joey_Wintheiser73@yahoo.com", "Joey", "Wintheiser", "Lithuania", "343-289-2663 x6641", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2185,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Port Kylaside", "EE17546", 1, "G157619", new DateTime(1978, 1, 30, 0, 0, 0, 0, DateTimeKind.Local), "Paula23@gmail.com", "Paula", "Douglas", "Liberia", "530.946.7765 x649" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2186,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Elna", "EE6714", "G11510", new DateTime(1970, 12, 24, 0, 0, 0, 0, DateTimeKind.Local), "Melissa37@hotmail.com", "Melissa", "Rempel", "Malta", "801-686-1756 x496", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2187,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Monahanport", "EE12370", 1, "G116375", new DateTime(1982, 2, 2, 0, 0, 0, 0, DateTimeKind.Local), "Paulette.Olson@hotmail.com", "Paulette", "Olson", "Lesotho", "(958) 402-3448" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2188,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Kautzerview", "EE50526", 1, "G413470", new DateTime(1963, 2, 13, 0, 0, 0, 0, DateTimeKind.Local), "Jackie34@yahoo.com", "Jackie", "Cruickshank", "San Marino", "(330) 373-2476" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2189,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Pollichberg", "EE25086", 4, "G588754", new DateTime(1961, 8, 30, 0, 0, 0, 0, DateTimeKind.Local), "Josh.Goodwin94@hotmail.com", "Josh", "Goodwin", "Anguilla", "(635) 978-7054" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2190,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Dudleyshire", "EE55238", 2, "G106316", new DateTime(1966, 4, 18, 0, 0, 0, 0, DateTimeKind.Local), "Harry82@hotmail.com", "Harry", "Tromp", "South Africa", "(750) 515-2687" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2191,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "East Addisonmouth", "EE52285", 1, "G59336", new DateTime(1974, 9, 16, 0, 0, 0, 0, DateTimeKind.Local), "Sylvia.Bednar51@hotmail.com", "Sylvia", "Bednar", "Zimbabwe", "1-719-408-3082" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2192,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lake Danton", "EE10257", 1, "G554114", new DateTime(1967, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), "Velma20@hotmail.com", "Velma", "Lowe", "Ecuador", "(429) 746-1079", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2193,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Dejon", "EE48550", 2, "G77785", new DateTime(1983, 1, 13, 0, 0, 0, 0, DateTimeKind.Local), "Tamara.Runolfsdottir@gmail.com", "Tamara", "Runolfsdottir", "Netherlands", "893-516-2619", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2194,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Medhurstburgh", "EE14781", 4, "G279013", new DateTime(1955, 6, 25, 0, 0, 0, 0, DateTimeKind.Local), "Gregory.Rath@hotmail.com", "Gregory", "Rath", "Hong Kong", "(772) 251-4150 x17537", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2195,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Bergestad", "EE21585", 1, "G267270", new DateTime(1999, 5, 25, 0, 0, 0, 0, DateTimeKind.Local), "Lynn.Keebler58@yahoo.com", "Lynn", "Keebler", "Ireland", "620.217.4406", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2196,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Rogerfort", "EE8117", 2, "G101704", new DateTime(1974, 10, 28, 0, 0, 0, 0, DateTimeKind.Local), "Sheri.Stoltenberg@gmail.com", "Sheri", "Stoltenberg", "Jamaica", "412.317.1427" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2197,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lake Okeyfort", "EE56403", 1, "G485361", new DateTime(1952, 4, 1, 0, 0, 0, 0, DateTimeKind.Local), "Jenny_Tremblay@gmail.com", "Jenny", "Tremblay", "Norfolk Island", "478.487.6636 x115", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2198,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Laronchester", "EE57795", 3, "G564665", new DateTime(1957, 10, 29, 0, 0, 0, 0, DateTimeKind.Local), "Anna14@gmail.com", "Anna", "Conn", "Portugal", "(574) 651-2236 x290", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2199,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Klockoville", "EE35684", 4, "G556406", new DateTime(1988, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), "Sandra60@yahoo.com", "Sandra", "Mills", "Russian Federation", "1-824-627-9212" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2200,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Herminiaton", "EE56278", 4, "G132712", new DateTime(1971, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), "Hugh.Orn44@gmail.com", "Hugh", "Orn", "Grenada", "(454) 807-3122 x49283" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2201,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Brant", "EE2925", "G549401", new DateTime(1996, 12, 20, 0, 0, 0, 0, DateTimeKind.Local), "Lula_Schuster87@yahoo.com", "Lula", "Schuster", "Mayotte", "411.809.9723", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2202,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Buddyburgh", "EE28714", 3, "G493087", new DateTime(1965, 11, 13, 0, 0, 0, 0, DateTimeKind.Local), "Katherine_Sporer@hotmail.com", "Katherine", "Sporer", "Maldives", "809.478.5039 x433" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2203,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Maverickmouth", "EE25720", 4, "G244998", new DateTime(1965, 3, 16, 0, 0, 0, 0, DateTimeKind.Local), "Rudolph63@yahoo.com", "Rudolph", "Schaefer", "Bolivia", "954-865-6065 x94574", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2204,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Friesenchester", "EE37492", 3, "G381096", new DateTime(1974, 3, 8, 0, 0, 0, 0, DateTimeKind.Local), "Meghan.Treutel67@gmail.com", "Meghan", "Treutel", "Uzbekistan", "(570) 810-8367" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2205,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Rainamouth", "EE10924", "G433010", new DateTime(1986, 4, 7, 0, 0, 0, 0, DateTimeKind.Local), "Guadalupe.Larson49@hotmail.com", "Guadalupe", "Larson", "Portugal", "(965) 737-0389 x1556" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2206,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Justicemouth", "EE10152", "G63015", new DateTime(1960, 9, 1, 0, 0, 0, 0, DateTimeKind.Local), "Amos_Keebler@hotmail.com", "Amos", "Keebler", "Saint Helena", "968.394.6991 x30032", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2207,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Lindsey", "EE57433", "G356186", new DateTime(1989, 1, 26, 0, 0, 0, 0, DateTimeKind.Local), "Darrin25@gmail.com", "Darrin", "Harber", "Virgin Islands, British", "(337) 545-4178", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2208,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Karianehaven", "EE2063", 2, "G167914", new DateTime(1961, 7, 31, 0, 0, 0, 0, DateTimeKind.Local), "Virgil.Smitham64@gmail.com", "Virgil", "Smitham", "Armenia", "(275) 554-5003", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2209,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Port Cathrine", "EE33809", 1, "G345459", new DateTime(1995, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), "Phillip61@hotmail.com", "Phillip", "Schneider", "Belgium", "906-917-2081" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2210,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "New Tatyana", "EE7770", 1, "G79928", new DateTime(1989, 6, 20, 0, 0, 0, 0, DateTimeKind.Local), "Susan.Daniel@gmail.com", "Susan", "Daniel", "Jersey", "707-720-0113", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2211,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Vonhaven", "EE54943", 3, "G547229", new DateTime(1987, 8, 27, 0, 0, 0, 0, DateTimeKind.Local), "Kendra.Sauer56@yahoo.com", "Kendra", "Sauer", "Central African Republic", "1-314-938-4940 x88178", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2212,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Barryshire", "EE6219", 4, "G411372", new DateTime(1965, 6, 12, 0, 0, 0, 0, DateTimeKind.Local), "Austin.Hoppe@hotmail.com", "Austin", "Hoppe", "American Samoa", "505-201-6364 x72274", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2213,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Jayceetown", "EE29969", "G236514", new DateTime(1995, 11, 23, 0, 0, 0, 0, DateTimeKind.Local), "Kristin91@gmail.com", "Kristin", "Marks", "Bahrain", "(511) 995-8302 x90446", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2214,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Hayleeside", "EE30600", "G150468", new DateTime(1975, 1, 29, 0, 0, 0, 0, DateTimeKind.Local), "Cathy.Cummings@hotmail.com", "Cathy", "Cummings", "Togo", "865.549.0824", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2215,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Beauburgh", "EE49386", 4, "G479477", new DateTime(1968, 3, 27, 0, 0, 0, 0, DateTimeKind.Local), "Mamie.Walsh@gmail.com", "Mamie", "Walsh", "Brazil", "1-481-852-0675" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2216,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Clayshire", "EE10175", "G365264", new DateTime(1996, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), "Miguel22@gmail.com", "Miguel", "Rutherford", "Saint Kitts and Nevis", "429-738-8139 x078" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2217,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Sanfordhaven", "EE39295", 1, "G105241", new DateTime(1998, 8, 28, 0, 0, 0, 0, DateTimeKind.Local), "Salvador.Halvorson93@gmail.com", "Salvador", "Halvorson", "Guinea", "1-335-564-0609 x2362", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2218,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "East Aliyah", "EE35367", 2, "G380289", new DateTime(1952, 8, 8, 0, 0, 0, 0, DateTimeKind.Local), "Ashley34@hotmail.com", "Ashley", "Greenholt", "Nepal", "870.713.3073" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2219,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Loustad", "EE45759", "G9542", new DateTime(1984, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), "Vanessa37@yahoo.com", "Vanessa", "O'Reilly", "Aruba", "910.676.4667", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2220,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Ritchieside", "EE12684", 2, "G372994", new DateTime(1971, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), "Grady.Grady@yahoo.com", "Grady", "Grady", "Poland", "485-845-7962 x16145" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2221,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Keshawnhaven", "EE44738", 1, "G349340", new DateTime(1987, 10, 16, 0, 0, 0, 0, DateTimeKind.Local), "Sergio71@hotmail.com", "Sergio", "Kuvalis", "Bouvet Island (Bouvetoya)", "406-826-2401 x2510" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2222,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Reynoldsbury", "EE24283", 4, "G303099", new DateTime(1963, 12, 15, 0, 0, 0, 0, DateTimeKind.Local), "Lionel.Legros@hotmail.com", "Lionel", "Legros", "Micronesia", "(846) 777-6952 x197", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2223,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Keeblershire", "EE17544", 3, "G387105", new DateTime(1990, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), "Pete94@yahoo.com", "Pete", "Bode", "Faroe Islands", "564-746-6691" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2224,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Santosside", "EE32729", 3, "G67129", new DateTime(1985, 9, 5, 0, 0, 0, 0, DateTimeKind.Local), "Ebony80@yahoo.com", "Ebony", "Kerluke", "Colombia", "571.735.8051 x643" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2225,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Jarrett", "EE17155", "G328488", new DateTime(1980, 10, 9, 0, 0, 0, 0, DateTimeKind.Local), "Emanuel_Schoen@hotmail.com", "Emanuel", "Schoen", "Gabon", "256.572.2392 x0942" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2226,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Mia", "EE29610", "G393950", new DateTime(1963, 9, 12, 0, 0, 0, 0, DateTimeKind.Local), "Kent72@gmail.com", "Kent", "Sauer", "Libyan Arab Jamahiriya", "(329) 856-5000 x7855", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2227,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Parkerview", "EE37439", 1, "G244923", new DateTime(1957, 1, 4, 0, 0, 0, 0, DateTimeKind.Local), "Steve_Pfeffer@hotmail.com", "Steve", "Pfeffer", "Belize", "1-858-971-9964" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2228,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "East Damienville", "EE58605", "G175326", new DateTime(1985, 7, 10, 0, 0, 0, 0, DateTimeKind.Local), "Samuel60@gmail.com", "Samuel", "Hirthe", "Tunisia", "632-528-3765 x781" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2229,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Wilmaview", "EE5230", 2, "G372405", new DateTime(1963, 10, 23, 0, 0, 0, 0, DateTimeKind.Local), "Ellis.Wuckert@yahoo.com", "Ellis", "Wuckert", "Slovenia", "(326) 324-1865" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2230,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Cristville", "EE58992", 4, "G76940", new DateTime(1972, 5, 25, 0, 0, 0, 0, DateTimeKind.Local), "Clifford16@yahoo.com", "Clifford", "Larkin", "Cape Verde", "(995) 394-8888 x7152", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2231,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lake Mortonburgh", "EE48412", 3, "G337337", new DateTime(1963, 6, 9, 0, 0, 0, 0, DateTimeKind.Local), "Ira_OConner14@hotmail.com", "Ira", "O'Conner", "Indonesia", "1-355-742-1155 x949", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2232,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Cassidy", "EE58193", 4, "G458551", new DateTime(1959, 7, 25, 0, 0, 0, 0, DateTimeKind.Local), "Wade.Schaefer@hotmail.com", "Wade", "Schaefer", "Myanmar", "583-373-3927 x63860" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2233,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Marcelinoton", "EE57779", "G448830", new DateTime(1996, 1, 13, 0, 0, 0, 0, DateTimeKind.Local), "Jamie_Rice81@yahoo.com", "Jamie", "Rice", "Haiti", "297-848-4777", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2234,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Gerholdfort", "EE1941", 2, "G33989", new DateTime(1991, 5, 17, 0, 0, 0, 0, DateTimeKind.Local), "Jermaine.Beier@hotmail.com", "Jermaine", "Beier", "Barbados", "220-207-7262 x340" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2235,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "New Robbiemouth", "EE54575", 4, "G301006", new DateTime(1988, 3, 15, 0, 0, 0, 0, DateTimeKind.Local), "Ron_Tillman@yahoo.com", "Ron", "Tillman", "Marshall Islands", "1-586-508-1788", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2236,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Effertzfurt", "EE41499", 2, "G417521", new DateTime(1963, 2, 27, 0, 0, 0, 0, DateTimeKind.Local), "Erma4@gmail.com", "Erma", "Towne", "Ukraine", "1-920-404-8019 x8959", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2237,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Littelshire", "EE52256", 4, "G29091", new DateTime(1974, 7, 22, 0, 0, 0, 0, DateTimeKind.Local), "Vincent.Shanahan13@yahoo.com", "Vincent", "Shanahan", "Finland", "725-919-8981 x8688", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2238,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Beierside", "EE23969", "G119176", new DateTime(1991, 12, 1, 0, 0, 0, 0, DateTimeKind.Local), "Dominic.Prosacco@yahoo.com", "Dominic", "Prosacco", "Bhutan", "(413) 549-0763 x6159", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2239,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Marlen", "EE10126", 1, "G446904", new DateTime(1958, 10, 24, 0, 0, 0, 0, DateTimeKind.Local), "Gustavo12@hotmail.com", "Gustavo", "Larson", "Bermuda", "965-701-1653 x439", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2240,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Dejuanfort", "EE56905", "G18015", new DateTime(1994, 5, 15, 0, 0, 0, 0, DateTimeKind.Local), "Felix.Kihn@hotmail.com", "Felix", "Kihn", "United Kingdom", "(805) 608-8297 x879" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2241,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Port Collin", "EE51307", 1, "G385281", new DateTime(1970, 3, 7, 0, 0, 0, 0, DateTimeKind.Local), "Patricia77@yahoo.com", "Patricia", "Langworth", "Singapore", "918-950-5997 x32690" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2242,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Christiana", "EE37645", 4, "G421320", new DateTime(1974, 1, 6, 0, 0, 0, 0, DateTimeKind.Local), "Monique.Doyle@hotmail.com", "Monique", "Doyle", "Cayman Islands", "(381) 684-7042 x67162" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2243,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lorineburgh", "EE56493", 2, "G353258", new DateTime(1965, 6, 29, 0, 0, 0, 0, DateTimeKind.Local), "Kathryn_Cormier@hotmail.com", "Kathryn", "Cormier", "Venezuela", "(630) 329-3852 x92246" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2244,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Greenfelderville", "EE12302", 3, "G441473", new DateTime(1979, 3, 29, 0, 0, 0, 0, DateTimeKind.Local), "Norma_Bergnaum@yahoo.com", "Norma", "Bergnaum", "Angola", "324.300.1511 x50311" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2245,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Kellieberg", "EE31482", 1, "G73886", new DateTime(1984, 4, 13, 0, 0, 0, 0, DateTimeKind.Local), "Dianne53@hotmail.com", "Dianne", "Hills", "Japan", "1-807-381-1483", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2246,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "East Antonioview", "EE33610", 1, "G3308", new DateTime(1955, 3, 8, 0, 0, 0, 0, DateTimeKind.Local), "Meghan96@yahoo.com", "Meghan", "Leffler", "Saint Martin", "1-730-992-5325 x72461" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2247,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Adeliafurt", "EE45287", "G19210", new DateTime(1971, 2, 3, 0, 0, 0, 0, DateTimeKind.Local), "Terry.Hammes40@hotmail.com", "Terry", "Hammes", "Sao Tome and Principe", "1-996-666-5998" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2248,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Sylviafort", "EE6838", "G72534", new DateTime(1974, 10, 12, 0, 0, 0, 0, DateTimeKind.Local), "Tom_Beer92@hotmail.com", "Tom", "Beer", "Burundi", "(892) 730-6506" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2249,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Cathrynland", "EE29436", 1, "G369628", new DateTime(1988, 8, 1, 0, 0, 0, 0, DateTimeKind.Local), "Eddie_Howell36@hotmail.com", "Eddie", "Howell", "Svalbard & Jan Mayen Islands", "1-798-804-2528" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2250,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Filomenaborough", "EE17667", 1, "G262218", new DateTime(1990, 9, 1, 0, 0, 0, 0, DateTimeKind.Local), "Ismael.Dooley57@hotmail.com", "Ismael", "Dooley", "Costa Rica", "(917) 872-5016", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2251,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Ellsworth", "EE52623", 4, "G191261", new DateTime(1965, 3, 23, 0, 0, 0, 0, DateTimeKind.Local), "Mathew.Carter@yahoo.com", "Mathew", "Carter", "Pakistan", "(911) 712-2662 x56951" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2252,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "New Devante", "EE7609", 1, "G91932", new DateTime(1991, 11, 17, 0, 0, 0, 0, DateTimeKind.Local), "Lana65@yahoo.com", "Lana", "Thiel", "Lithuania", "529.531.9334 x142", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2253,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Barrytown", "EE36021", 4, "G312843", new DateTime(1992, 3, 12, 0, 0, 0, 0, DateTimeKind.Local), "Brittany47@gmail.com", "Brittany", "Kuhic", "Zambia", "1-246-656-1950" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2254,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Koelpinberg", "EE48104", 3, "G507082", new DateTime(1982, 1, 31, 0, 0, 0, 0, DateTimeKind.Local), "Bradley_Bayer@gmail.com", "Bradley", "Bayer", "Palau", "722.778.8891 x268", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2255,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Halietown", "EE12444", 1, "G497830", new DateTime(1973, 8, 13, 0, 0, 0, 0, DateTimeKind.Local), "Wilma_Buckridge@yahoo.com", "Wilma", "Buckridge", "Reunion", "636.235.5904", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2256,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Freemanton", "EE39718", 1, "G427317", new DateTime(1979, 4, 15, 0, 0, 0, 0, DateTimeKind.Local), "Micheal76@gmail.com", "Micheal", "Walker", "Guinea-Bissau", "(296) 514-8505" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2257,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Rutherfordborough", "EE40447", 2, "G256870", new DateTime(1976, 4, 13, 0, 0, 0, 0, DateTimeKind.Local), "Angelo_Connelly@yahoo.com", "Angelo", "Connelly", "Hong Kong", "998.518.3434", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2258,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "New Reggie", "EE50767", 1, "G593696", new DateTime(1961, 8, 20, 0, 0, 0, 0, DateTimeKind.Local), "Jean.Moen@yahoo.com", "Jean", "Moen", "Syrian Arab Republic", "646-524-7015 x56802", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2259,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Timmyville", "EE10463", 3, "G240854", new DateTime(1954, 9, 16, 0, 0, 0, 0, DateTimeKind.Local), "Joanna53@gmail.com", "Joanna", "Casper", "Bolivia", "815.569.0581 x3979" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2260,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Earlport", "EE50302", 1, "G545741", new DateTime(1954, 9, 24, 0, 0, 0, 0, DateTimeKind.Local), "Salvador.Halvorson52@gmail.com", "Salvador", "Halvorson", "Mayotte", "773.413.0487", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2261,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Gusikowskiview", "EE11776", 1, "G422854", new DateTime(1955, 2, 21, 0, 0, 0, 0, DateTimeKind.Local), "Philip.Beatty87@hotmail.com", "Philip", "Beatty", "Spain", "1-819-945-9387" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2262,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Nora", "EE2229", 1, "G8184", new DateTime(1989, 8, 24, 0, 0, 0, 0, DateTimeKind.Local), "Erick_Kuhlman4@gmail.com", "Erick", "Kuhlman", "Papua New Guinea", "866.506.0751 x9549", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2263,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Port Dejaport", "EE11504", "G555148", new DateTime(1979, 6, 1, 0, 0, 0, 0, DateTimeKind.Local), "Hazel_Heathcote67@yahoo.com", "Hazel", "Heathcote", "Austria", "872-611-9182 x518" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2264,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Oberbrunnerburgh", "EE3953", "G393423", new DateTime(1972, 12, 14, 0, 0, 0, 0, DateTimeKind.Local), "Jerald.Davis@gmail.com", "Jerald", "Davis", "Chile", "(708) 458-5452", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2265,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Watersberg", "EE3575", 3, "G335484", new DateTime(1998, 6, 21, 0, 0, 0, 0, DateTimeKind.Local), "Zachary_Runolfsson@yahoo.com", "Zachary", "Runolfsson", "Latvia", "694-978-7356 x06105" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2266,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Lemuel", "EE18253", "G361723", new DateTime(1959, 8, 5, 0, 0, 0, 0, DateTimeKind.Local), "Chester.Schaefer@yahoo.com", "Chester", "Schaefer", "Tokelau", "538-853-8550 x67621" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2267,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Emmerichside", "EE34438", 2, "G450891", new DateTime(1992, 8, 3, 0, 0, 0, 0, DateTimeKind.Local), "Gina94@yahoo.com", "Gina", "Hirthe", "Marshall Islands", "802.235.8658 x11591" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2268,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Tedfort", "EE35936", 3, "G413370", new DateTime(1976, 10, 9, 0, 0, 0, 0, DateTimeKind.Local), "Lloyd93@hotmail.com", "Lloyd", "Muller", "Lesotho", "835.358.8134 x95065" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2269,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Osvaldofort", "EE50578", "G67293", new DateTime(1989, 7, 9, 0, 0, 0, 0, DateTimeKind.Local), "Ronnie66@gmail.com", "Ronnie", "Grimes", "Montenegro", "(214) 429-7174 x057" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2270,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Kirkstad", "EE7690", "G99022", new DateTime(1953, 5, 3, 0, 0, 0, 0, DateTimeKind.Local), "Dennis89@yahoo.com", "Dennis", "Corkery", "Hungary", "1-507-719-3415", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2271,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Mariahville", "EE55960", 4, "G348427", new DateTime(1959, 7, 17, 0, 0, 0, 0, DateTimeKind.Local), "Alex51@yahoo.com", "Alex", "Jones", "Saint Martin", "(387) 781-3132" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2272,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Clemens", "EE2512", 1, "G493336", new DateTime(1971, 1, 7, 0, 0, 0, 0, DateTimeKind.Local), "Bobbie45@hotmail.com", "Bobbie", "Mitchell", "Serbia", "1-246-274-9910", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2273,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Jacques", "EE16057", 4, "G251235", new DateTime(1957, 12, 18, 0, 0, 0, 0, DateTimeKind.Local), "Rosa.Lindgren@yahoo.com", "Rosa", "Lindgren", "Bhutan", "1-793-432-9214 x9621" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2274,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Teresafurt", "EE5533", "G255567", new DateTime(1954, 7, 10, 0, 0, 0, 0, DateTimeKind.Local), "Angelina_White64@gmail.com", "Angelina", "White", "Mali", "214.786.7687 x12020" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2275,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "New Santiago", "EE16741", 3, "G80730", new DateTime(1954, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), "Yvette_Feest12@hotmail.com", "Yvette", "Feest", "Sao Tome and Principe", "325.282.0179", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2276,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Delfinastad", "EE37816", 3, "G360287", new DateTime(1986, 4, 1, 0, 0, 0, 0, DateTimeKind.Local), "Meghan98@hotmail.com", "Meghan", "Crist", "Eritrea", "224-488-8415" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2277,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Agustinashire", "EE33047", "G588336", new DateTime(1986, 5, 11, 0, 0, 0, 0, DateTimeKind.Local), "Blanca_Hauck@yahoo.com", "Blanca", "Hauck", "Ukraine", "1-697-854-0185 x321", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2278,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "North Keeley", "EE17762", 2, "G405277", new DateTime(1967, 8, 7, 0, 0, 0, 0, DateTimeKind.Local), "Kristie81@yahoo.com", "Kristie", "Zieme", "Niue", "1-618-741-0769 x8621" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2279,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Bridgetteview", "EE38485", 1, "G25618", new DateTime(1982, 9, 19, 0, 0, 0, 0, DateTimeKind.Local), "Gabriel72@hotmail.com", "Gabriel", "Towne", "Algeria", "661.389.0613 x7882" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2280,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Port Lurline", "EE25727", 3, "G561375", new DateTime(1968, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), "Bradley94@yahoo.com", "Bradley", "Bradtke", "Congo", "573-267-6088" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2281,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Jacinthetown", "EE30567", "G483316", new DateTime(1965, 4, 25, 0, 0, 0, 0, DateTimeKind.Local), "Veronica27@yahoo.com", "Veronica", "Hodkiewicz", "Ethiopia", "420.601.3234 x9197" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2282,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Darrellberg", "EE53431", 4, "G331624", new DateTime(1966, 12, 29, 0, 0, 0, 0, DateTimeKind.Local), "Paulette.Runolfsson13@yahoo.com", "Paulette", "Runolfsson", "Estonia", "356.925.0380 x4792", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2283,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "North Madalynberg", "EE24191", 4, "G565444", new DateTime(1984, 6, 24, 0, 0, 0, 0, DateTimeKind.Local), "Gwen_Boehm@gmail.com", "Gwen", "Boehm", "Japan", "746.438.9478 x44278" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2284,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Swaniawskiland", "EE53235", 2, "G387194", new DateTime(1966, 11, 3, 0, 0, 0, 0, DateTimeKind.Local), "Shelly54@hotmail.com", "Shelly", "Maggio", "Armenia", "631-588-0775 x060" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2285,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Edwinamouth", "EE57611", "G180180", new DateTime(1991, 3, 3, 0, 0, 0, 0, DateTimeKind.Local), "Glen_Lang@yahoo.com", "Glen", "Lang", "Vietnam", "558.826.2178 x627", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2286,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Orphashire", "EE43560", 1, "G327212", new DateTime(1964, 8, 27, 0, 0, 0, 0, DateTimeKind.Local), "Marlon_Lockman@gmail.com", "Marlon", "Lockman", "Singapore", "(816) 721-6388" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2287,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lomaville", "EE14554", "G226754", new DateTime(1998, 2, 17, 0, 0, 0, 0, DateTimeKind.Local), "Shari.Hilll@hotmail.com", "Shari", "Hilll", "Jordan", "1-266-217-7669 x82959", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2288,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Keeblerbury", "EE42268", 1, "G12594", new DateTime(1957, 12, 1, 0, 0, 0, 0, DateTimeKind.Local), "Alejandro_Frami32@yahoo.com", "Alejandro", "Frami", "South Africa", "298.435.6684 x71275", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2289,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Misaelborough", "EE29159", 4, "G311543", new DateTime(1982, 10, 3, 0, 0, 0, 0, DateTimeKind.Local), "Evan59@yahoo.com", "Evan", "Marvin", "Isle of Man", "280.435.2136", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2290,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "North Augustusstad", "EE33044", "G279380", new DateTime(1972, 8, 8, 0, 0, 0, 0, DateTimeKind.Local), "Owen39@yahoo.com", "Owen", "Gerlach", "Ukraine", "928.422.2815 x441" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2291,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Greysonfurt", "EE11052", 2, "G15330", new DateTime(1987, 9, 27, 0, 0, 0, 0, DateTimeKind.Local), "Ruben.Lindgren@gmail.com", "Ruben", "Lindgren", "Bahrain", "1-454-424-3852", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2292,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Lydaberg", "EE34729", 2, "G288397", new DateTime(1986, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), "Leroy.Ferry62@yahoo.com", "Leroy", "Ferry", "Marshall Islands", "621.663.1234 x2606" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2293,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Terrellburgh", "EE16822", 4, "G520886", new DateTime(1980, 7, 9, 0, 0, 0, 0, DateTimeKind.Local), "Marion.Zboncak84@hotmail.com", "Marion", "Zboncak", "Taiwan", "693.321.0991 x713", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2294,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Selmer", "EE9469", "G570056", new DateTime(1967, 4, 19, 0, 0, 0, 0, DateTimeKind.Local), "Ella.Adams42@gmail.com", "Ella", "Adams", "Madagascar", "769.212.4205 x6253" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2295,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Jerry", "EE40814", 2, "G361706", new DateTime(2001, 5, 23, 0, 0, 0, 0, DateTimeKind.Local), "Maryann.Jacobson85@gmail.com", "Maryann", "Jacobson", "India", "1-361-763-4939 x6048", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2296,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Mauricio", "EE19820", 4, "G87148", new DateTime(1978, 12, 20, 0, 0, 0, 0, DateTimeKind.Local), "Joshua.Bergnaum63@hotmail.com", "Joshua", "Bergnaum", "Iraq", "1-758-636-5819 x7961", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2297,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Hilmabury", "EE46282", 1, "G441890", new DateTime(1968, 5, 13, 0, 0, 0, 0, DateTimeKind.Local), "Crystal.McDermott75@gmail.com", "Crystal", "McDermott", "Ireland", "(813) 459-8659" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2298,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Samanta", "EE44746", 3, "G416269", new DateTime(1959, 5, 20, 0, 0, 0, 0, DateTimeKind.Local), "Glenn.Bogisich@gmail.com", "Glenn", "Bogisich", "Pitcairn Islands", "1-828-729-0608" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2299,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Dellmouth", "EE51423", 2, "G333104", new DateTime(1955, 11, 16, 0, 0, 0, 0, DateTimeKind.Local), "Van.Trantow@yahoo.com", "Van", "Trantow", "Kazakhstan", "722.875.5379 x69055", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2300,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Pagacfurt", "EE46416", 4, "G13056", new DateTime(1953, 11, 6, 0, 0, 0, 0, DateTimeKind.Local), "Margarita.Toy@gmail.com", "Margarita", "Toy", "Senegal", "1-811-496-0538 x822" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2301,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Daniellatown", "EE57504", 1, "G204465", new DateTime(1986, 3, 10, 0, 0, 0, 0, DateTimeKind.Local), "Natalie_Altenwerth@hotmail.com", "Natalie", "Altenwerth", "Comoros", "443-873-7961 x04740", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2302,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "East Haleighmouth", "EE5571", "G500323", new DateTime(1977, 5, 20, 0, 0, 0, 0, DateTimeKind.Local), "Grace_Hegmann@yahoo.com", "Grace", "Hegmann", "Lao People's Democratic Republic", "(606) 450-0973 x114" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2303,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Newtonstad", "EE55860", 3, "G53697", new DateTime(1994, 11, 18, 0, 0, 0, 0, DateTimeKind.Local), "Lauren74@hotmail.com", "Lauren", "Raynor", "Guernsey", "975.248.9483", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2304,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Weimannchester", "EE40057", "G288068", new DateTime(1973, 11, 26, 0, 0, 0, 0, DateTimeKind.Local), "Stuart.Tillman42@hotmail.com", "Stuart", "Tillman", "Hungary", "391-880-5457 x4579", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2305,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lake Hollis", "EE47414", 2, "G415130", new DateTime(1979, 1, 19, 0, 0, 0, 0, DateTimeKind.Local), "Miriam.Gibson78@yahoo.com", "Miriam", "Gibson", "Cape Verde", "(876) 765-1238", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2306,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Mullershire", "EE2931", 1, "G216190", new DateTime(1975, 11, 17, 0, 0, 0, 0, DateTimeKind.Local), "Susan.VonRueden79@yahoo.com", "Susan", "VonRueden", "Liechtenstein", "(281) 844-6361 x083" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2307,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Orvilleside", "EE39595", 4, "G399731", new DateTime(1976, 8, 21, 0, 0, 0, 0, DateTimeKind.Local), "Emily37@yahoo.com", "Emily", "Mayert", "Ecuador", "211.326.8791 x66958", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2308,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lisettemouth", "EE13851", "G13785", new DateTime(1973, 4, 12, 0, 0, 0, 0, DateTimeKind.Local), "Margaret_Bins83@gmail.com", "Margaret", "Bins", "Marshall Islands", "305.394.6868 x1096" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2309,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "New Bethanystad", "EE51859", "G45085", new DateTime(1972, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), "Sherman_Auer60@gmail.com", "Sherman", "Auer", "Jersey", "640-252-1666 x58222", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2310,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Yvetteview", "EE35058", "G152162", new DateTime(1973, 9, 4, 0, 0, 0, 0, DateTimeKind.Local), "Lloyd.Dietrich2@yahoo.com", "Lloyd", "Dietrich", "Lithuania", "1-437-470-2029 x8217", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2311,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lake Tellyside", "EE26033", "G359336", new DateTime(1968, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), "Nina_Kunde@yahoo.com", "Nina", "Kunde", "Tonga", "(992) 722-7490 x974", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2312,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Yesseniafort", "EE30519", 2, "G454438", new DateTime(1995, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), "Rita.Jacobs@hotmail.com", "Rita", "Jacobs", "Mozambique", "950.222.2541" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2313,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "North Christelle", "EE50420", 2, "G316992", new DateTime(1952, 6, 13, 0, 0, 0, 0, DateTimeKind.Local), "Benny97@hotmail.com", "Benny", "Rolfson", "Serbia", "957.857.9103" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2314,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Ava", "EE34494", 4, "G35765", new DateTime(1985, 5, 28, 0, 0, 0, 0, DateTimeKind.Local), "Bryan_Russel@gmail.com", "Bryan", "Russel", "Libyan Arab Jamahiriya", "817-976-5037 x018" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2315,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Mooreton", "EE42751", "G67676", new DateTime(1988, 7, 31, 0, 0, 0, 0, DateTimeKind.Local), "Spencer.Mueller@gmail.com", "Spencer", "Mueller", "Aruba", "528-200-6346" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2316,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Adelemouth", "EE46980", 4, "G490679", new DateTime(1955, 7, 28, 0, 0, 0, 0, DateTimeKind.Local), "Samuel_Kovacek23@gmail.com", "Samuel", "Kovacek", "Botswana", "1-957-936-2549 x49201" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2317,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Pfefferville", "EE44661", "G274037", new DateTime(1960, 3, 27, 0, 0, 0, 0, DateTimeKind.Local), "Ken75@hotmail.com", "Ken", "Walsh", "Monaco", "1-609-520-2164", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2318,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Vincemouth", "EE56691", 2, "G565204", new DateTime(1982, 12, 18, 0, 0, 0, 0, DateTimeKind.Local), "Omar_Marvin@hotmail.com", "Omar", "Marvin", "Mayotte", "369.985.6437", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2319,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Averyside", "EE54838", 4, "G571961", new DateTime(1986, 1, 9, 0, 0, 0, 0, DateTimeKind.Local), "Darrell11@gmail.com", "Darrell", "Borer", "Antarctica (the territory South of 60 deg S)", "512-459-6073", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2320,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Blairmouth", "EE34129", "G429620", new DateTime(1957, 7, 12, 0, 0, 0, 0, DateTimeKind.Local), "Darnell29@yahoo.com", "Darnell", "Hane", "Turks and Caicos Islands", "1-336-479-2340", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2321,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Garnettville", "EE17848", 3, "G512995", new DateTime(1994, 2, 1, 0, 0, 0, 0, DateTimeKind.Local), "Stanley65@yahoo.com", "Stanley", "Steuber", "Norfolk Island", "954-924-8793 x413" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2322,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Ressietown", "EE33983", 3, "G591146", new DateTime(1983, 5, 6, 0, 0, 0, 0, DateTimeKind.Local), "Sara_Lakin@hotmail.com", "Sara", "Lakin", "Saint Kitts and Nevis", "308.511.4233" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2323,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Johnsonmouth", "EE26283", 1, "G434346", new DateTime(1965, 2, 28, 0, 0, 0, 0, DateTimeKind.Local), "Jeannette_Leannon@hotmail.com", "Jeannette", "Leannon", "Bhutan", "1-798-708-9710 x74877", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2324,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Welchborough", "EE17033", 4, "G476133", new DateTime(1990, 3, 29, 0, 0, 0, 0, DateTimeKind.Local), "Dallas44@yahoo.com", "Dallas", "Pfannerstill", "Saint Pierre and Miquelon", "1-663-837-8874 x3110", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2325,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Crystalberg", "EE12567", 4, "G265750", new DateTime(1997, 2, 21, 0, 0, 0, 0, DateTimeKind.Local), "Archie_Breitenberg17@hotmail.com", "Archie", "Breitenberg", "Reunion", "260.772.5761" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2326,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "East Queenie", "EE55516", "G70910", new DateTime(1960, 3, 18, 0, 0, 0, 0, DateTimeKind.Local), "Elena.Armstrong@yahoo.com", "Elena", "Armstrong", "Norfolk Island", "806.296.7942 x269" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2327,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Willburgh", "EE41330", 2, "G115311", new DateTime(1995, 1, 13, 0, 0, 0, 0, DateTimeKind.Local), "Donna_Gorczany71@yahoo.com", "Donna", "Gorczany", "Poland", "948-467-3730 x27696" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2328,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Yosthaven", "EE8775", "G185731", new DateTime(1954, 9, 28, 0, 0, 0, 0, DateTimeKind.Local), "Leland.Considine39@gmail.com", "Leland", "Considine", "Bulgaria", "237.621.8939", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2329,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Christianview", "EE94", 1, "G503928", new DateTime(1955, 5, 15, 0, 0, 0, 0, DateTimeKind.Local), "Peter_Ziemann64@yahoo.com", "Peter", "Ziemann", "Papua New Guinea", "1-251-818-6259" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2330,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Treutelchester", "EE44762", "G484296", new DateTime(1962, 1, 22, 0, 0, 0, 0, DateTimeKind.Local), "Wayne_Kunze70@gmail.com", "Wayne", "Kunze", "Virgin Islands, U.S.", "801.624.6207", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2331,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Schmidtberg", "EE16886", 1, "G586570", new DateTime(1969, 10, 2, 0, 0, 0, 0, DateTimeKind.Local), "Hugh.Connelly@hotmail.com", "Hugh", "Connelly", "Georgia", "400-498-7230" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2332,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "North Jack", "EE48500", 3, "G48839", new DateTime(1999, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), "Tammy73@gmail.com", "Tammy", "Connelly", "Kuwait", "1-563-662-5261 x2669" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2333,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Nickchester", "EE37423", 2, "G188927", new DateTime(1987, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "Kari21@gmail.com", "Kari", "Mueller", "Bulgaria", "1-808-751-3888" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2334,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lake Cleora", "EE30672", 1, "G156827", new DateTime(1968, 4, 9, 0, 0, 0, 0, DateTimeKind.Local), "Danielle_Kassulke@hotmail.com", "Danielle", "Kassulke", "Maldives", "1-585-487-5267", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2335,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lafayetteport", "EE4423", 1, "G311671", new DateTime(1982, 9, 25, 0, 0, 0, 0, DateTimeKind.Local), "Brittany76@hotmail.com", "Brittany", "Cole", "Mali", "(659) 776-4645" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2336,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Katherynton", "EE30535", 3, "G64507", new DateTime(1975, 11, 17, 0, 0, 0, 0, DateTimeKind.Local), "Beulah.Shields@hotmail.com", "Beulah", "Shields", "Greece", "1-439-306-0985 x99639", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2337,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Beverlychester", "EE32055", 3, "G166734", new DateTime(1972, 5, 29, 0, 0, 0, 0, DateTimeKind.Local), "Darrell.Blanda@yahoo.com", "Darrell", "Blanda", "Liberia", "449.414.6832 x0949", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2338,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Jamesonland", "EE58020", "G548020", new DateTime(1965, 10, 23, 0, 0, 0, 0, DateTimeKind.Local), "Stephanie56@yahoo.com", "Stephanie", "Gusikowski", "Sudan", "302.636.9672 x8953" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2339,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "North Clarabelle", "EE58263", "G256470", new DateTime(1986, 9, 2, 0, 0, 0, 0, DateTimeKind.Local), "Sylvester_Larkin@gmail.com", "Sylvester", "Larkin", "Liberia", "(315) 218-3261 x44136" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2340,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Auguststad", "EE17635", "G292296", new DateTime(1985, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), "Miranda69@gmail.com", "Miranda", "Wilderman", "Syrian Arab Republic", "(968) 580-6530 x4164" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2341,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Taylor", "EE30793", 3, "G147552", new DateTime(1986, 2, 5, 0, 0, 0, 0, DateTimeKind.Local), "Cameron_Nikolaus69@yahoo.com", "Cameron", "Nikolaus", "Czech Republic", "451.865.2016", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2342,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "North Ryanburgh", "EE18317", 1, "G571814", new DateTime(1968, 4, 29, 0, 0, 0, 0, DateTimeKind.Local), "Brittany55@hotmail.com", "Brittany", "Schulist", "Hong Kong", "1-811-657-1848 x254" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2343,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Rickychester", "EE44617", 2, "G301967", new DateTime(1969, 7, 1, 0, 0, 0, 0, DateTimeKind.Local), "Beth_Bogan@gmail.com", "Beth", "Bogan", "Bermuda", "715-220-8025 x455", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2344,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Dalton", "EE35946", 3, "G496413", new DateTime(1973, 9, 17, 0, 0, 0, 0, DateTimeKind.Local), "Lisa.Lang@gmail.com", "Lisa", "Lang", "Niger", "268.898.2861", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2345,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Madgemouth", "EE35842", 2, "G301994", new DateTime(1970, 10, 29, 0, 0, 0, 0, DateTimeKind.Local), "Courtney.Grant@gmail.com", "Courtney", "Grant", "Monaco", "688-207-4959 x7755" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2346,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Alenafurt", "EE27206", 3, "G96985", new DateTime(1956, 10, 18, 0, 0, 0, 0, DateTimeKind.Local), "Doreen.Barton86@yahoo.com", "Doreen", "Barton", "Bosnia and Herzegovina", "(313) 263-3203 x366" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2347,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Douglasborough", "EE7936", 1, "G77966", new DateTime(2000, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), "Alberto_Mann@yahoo.com", "Alberto", "Mann", "United Arab Emirates", "201-913-7373 x59952" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2348,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "East Karianne", "EE28364", "G57587", new DateTime(1998, 12, 13, 0, 0, 0, 0, DateTimeKind.Local), "Donna44@hotmail.com", "Donna", "Crist", "French Guiana", "1-653-765-6290" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2349,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Hudsonburgh", "EE22028", "G392779", new DateTime(1977, 12, 13, 0, 0, 0, 0, DateTimeKind.Local), "Donnie_Herman29@gmail.com", "Donnie", "Herman", "Heard Island and McDonald Islands", "(520) 979-2160", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2350,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Vernview", "EE45828", "G278662", new DateTime(1965, 12, 27, 0, 0, 0, 0, DateTimeKind.Local), "Naomi.Volkman94@yahoo.com", "Naomi", "Volkman", "American Samoa", "(835) 623-0793 x944", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2351,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "East Blakeport", "EE11717", 2, "G346547", new DateTime(1975, 12, 23, 0, 0, 0, 0, DateTimeKind.Local), "Rodolfo.Hermiston@gmail.com", "Rodolfo", "Hermiston", "Belize", "249.680.6624" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2352,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Goldashire", "EE18690", 3, "G434380", new DateTime(1997, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "Noah_Kirlin@hotmail.com", "Noah", "Kirlin", "Antigua and Barbuda", "1-583-441-5694", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2353,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Pricetown", "EE7886", 4, "G384333", new DateTime(1987, 11, 20, 0, 0, 0, 0, DateTimeKind.Local), "Bert.Kessler@yahoo.com", "Bert", "Kessler", "Canada", "(863) 249-5963", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2354,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Theresiafurt", "EE35909", 3, "G310436", new DateTime(1984, 12, 26, 0, 0, 0, 0, DateTimeKind.Local), "Alma.Brakus@gmail.com", "Alma", "Brakus", "Seychelles", "589.878.4417 x34388", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2355,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Brookstown", "EE29637", 3, "G253452", new DateTime(1998, 1, 21, 0, 0, 0, 0, DateTimeKind.Local), "Delia_Okuneva@gmail.com", "Delia", "Okuneva", "Austria", "518.436.2515 x0581", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2356,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Jennyferbury", "EE44000", 2, "G421416", new DateTime(1961, 2, 8, 0, 0, 0, 0, DateTimeKind.Local), "Sheila98@yahoo.com", "Sheila", "Sporer", "Uruguay", "827.744.4532" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2357,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Wunschberg", "EE3852", 3, "G378352", new DateTime(1976, 6, 15, 0, 0, 0, 0, DateTimeKind.Local), "Christina48@gmail.com", "Christina", "Konopelski", "Israel", "745-812-3270", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2358,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Feilfort", "EE26378", "G484512", new DateTime(1971, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), "Tricia_Ankunding34@gmail.com", "Tricia", "Ankunding", "Colombia", "1-519-772-3084", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2359,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Schillermouth", "EE21302", 1, "G178777", new DateTime(1961, 7, 6, 0, 0, 0, 0, DateTimeKind.Local), "Tracey_Simonis42@gmail.com", "Tracey", "Simonis", "Thailand", "509.497.5685 x982" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2360,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "East Verda", "EE52337", 1, "G541569", new DateTime(1958, 11, 17, 0, 0, 0, 0, DateTimeKind.Local), "Connie.Schmeler68@yahoo.com", "Connie", "Schmeler", "Kazakhstan", "1-936-897-7236" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2361,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Skylarview", "EE28931", "G473166", new DateTime(1966, 7, 9, 0, 0, 0, 0, DateTimeKind.Local), "Olga_Fay9@hotmail.com", "Olga", "Fay", "Gabon", "1-626-536-5875", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2362,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Petermouth", "EE10239", 4, "G351176", new DateTime(1973, 6, 19, 0, 0, 0, 0, DateTimeKind.Local), "Frederick.King@yahoo.com", "Frederick", "King", "Sweden", "484.799.6376", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2363,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Mortimerburgh", "EE26009", 1, "G401104", new DateTime(1969, 12, 9, 0, 0, 0, 0, DateTimeKind.Local), "Cora30@hotmail.com", "Cora", "Wilderman", "Serbia", "689-967-0528 x023" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2364,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Dedrick", "EE37867", 4, "G56167", new DateTime(1952, 11, 22, 0, 0, 0, 0, DateTimeKind.Local), "Charles_Runolfsdottir65@yahoo.com", "Charles", "Runolfsdottir", "Rwanda", "825.225.1301" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2365,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "natio", "phone" },
                values: new object[] { "Stanchester", "EE14094", "G408792", new DateTime(1953, 7, 27, 0, 0, 0, 0, DateTimeKind.Local), "Georgia.Borer@hotmail.com", "Georgia", "Costa Rica", "1-871-810-1084" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2366,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Kayceemouth", "EE29715", "G344938", new DateTime(1966, 3, 18, 0, 0, 0, 0, DateTimeKind.Local), "Tommie_Greenfelder@gmail.com", "Tommie", "Greenfelder", "Cocos (Keeling) Islands", "335-342-3964 x0550" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2367,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Stokesfort", "EE48407", 1, "G117524", new DateTime(1976, 9, 14, 0, 0, 0, 0, DateTimeKind.Local), "Ramona.Flatley@hotmail.com", "Ramona", "Flatley", "Canada", "1-649-219-7635 x6969" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2368,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Amandaport", "EE8688", 1, "G46370", new DateTime(1960, 8, 6, 0, 0, 0, 0, DateTimeKind.Local), "Andrew9@gmail.com", "Andrew", "Russel", "Portugal", "555-473-2373 x2779", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2369,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Eudorachester", "EE7455", 3, "G278682", new DateTime(1985, 3, 4, 0, 0, 0, 0, DateTimeKind.Local), "Jessica95@gmail.com", "Jessica", "Abbott", "Cocos (Keeling) Islands", "608-376-1517 x051" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2370,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Christyhaven", "EE49447", 2, "G75084", new DateTime(1985, 3, 23, 0, 0, 0, 0, DateTimeKind.Local), "Winston.McLaughlin11@hotmail.com", "Winston", "McLaughlin", "Guinea", "1-413-926-1402 x66614" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2371,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Roymouth", "EE58624", "G562397", new DateTime(1993, 1, 13, 0, 0, 0, 0, DateTimeKind.Local), "Laurence52@gmail.com", "Laurence", "Rippin", "Colombia", "1-498-214-9229 x12498" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2372,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Haileeland", "EE28734", "G384700", new DateTime(1980, 12, 2, 0, 0, 0, 0, DateTimeKind.Local), "Pearl23@gmail.com", "Pearl", "Howe", "Singapore", "(954) 510-3188 x841" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2373,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Baileyfort", "EE3431", 2, "G271206", new DateTime(1989, 10, 24, 0, 0, 0, 0, DateTimeKind.Local), "Kristopher_Hintz@yahoo.com", "Kristopher", "Hintz", "Democratic People's Republic of Korea", "(365) 479-3797 x534" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2374,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Padbergfurt", "EE26404", 4, "G46923", new DateTime(1983, 7, 22, 0, 0, 0, 0, DateTimeKind.Local), "Lucia_Lebsack@gmail.com", "Lucia", "Lebsack", "Denmark", "(269) 328-3522", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2375,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "East Erling", "EE19932", 2, "G453190", new DateTime(1977, 2, 10, 0, 0, 0, 0, DateTimeKind.Local), "Hilda26@yahoo.com", "Hilda", "Gibson", "Netherlands Antilles", "1-367-608-5393" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2376,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Dachtown", "EE59046", "G80115", new DateTime(1991, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), "Loretta_Corwin17@yahoo.com", "Loretta", "Corwin", "Ethiopia", "(264) 546-4645 x042", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2377,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Leviview", "EE33833", "G59273", new DateTime(1975, 2, 3, 0, 0, 0, 0, DateTimeKind.Local), "Sherri.Schuster@hotmail.com", "Sherri", "Schuster", "Saint Helena", "(668) 441-2425 x122" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2378,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Judsonberg", "EE20131", "G307943", new DateTime(1994, 12, 12, 0, 0, 0, 0, DateTimeKind.Local), "Marsha.Osinski15@hotmail.com", "Marsha", "Osinski", "Turkmenistan", "1-994-258-4423 x9535" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2379,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Clayview", "EE2800", "G268696", new DateTime(1970, 4, 21, 0, 0, 0, 0, DateTimeKind.Local), "Dewey_Collins96@hotmail.com", "Dewey", "Collins", "Ecuador", "(857) 837-1000" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2380,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Haleightown", "EE26993", 3, "G125544", new DateTime(1983, 6, 15, 0, 0, 0, 0, DateTimeKind.Local), "Elisa_Friesen@hotmail.com", "Elisa", "Friesen", "Haiti", "578.861.4409 x491" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2381,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Koreyborough", "EE51359", 4, "G475901", new DateTime(1982, 6, 1, 0, 0, 0, 0, DateTimeKind.Local), "Elizabeth_Altenwerth99@yahoo.com", "Elizabeth", "Altenwerth", "Namibia", "(308) 632-2759" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2382,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Rodriguezview", "EE42187", 4, "G510972", new DateTime(1977, 9, 10, 0, 0, 0, 0, DateTimeKind.Local), "Christian_Gorczany@yahoo.com", "Christian", "Gorczany", "Marshall Islands", "(762) 492-5355", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2383,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Geoffreyhaven", "EE20656", 1, "G312032", new DateTime(1966, 7, 29, 0, 0, 0, 0, DateTimeKind.Local), "Gabriel86@gmail.com", "Gabriel", "Greenholt", "Equatorial Guinea", "426.754.0044" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2384,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Runolfssonburgh", "EE52391", 1, "G491219", new DateTime(1976, 7, 27, 0, 0, 0, 0, DateTimeKind.Local), "Garrett60@gmail.com", "Garrett", "Hahn", "South Africa", "212-985-0476 x3328" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2385,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Daneville", "EE10044", 1, "G576577", new DateTime(1995, 1, 25, 0, 0, 0, 0, DateTimeKind.Local), "Inez.Metz@gmail.com", "Inez", "Metz", "Nauru", "1-897-504-0114" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2386,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Weldonside", "EE12122", 1, "G294721", new DateTime(1984, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), "Terrell_Osinski24@gmail.com", "Terrell", "Osinski", "Iraq", "220.259.0701" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2387,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Moorestad", "EE44236", 4, "G474458", new DateTime(1989, 2, 11, 0, 0, 0, 0, DateTimeKind.Local), "Maureen.Wolff@gmail.com", "Maureen", "Wolff", "Svalbard & Jan Mayen Islands", "(693) 572-8944 x208" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2388,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Faeberg", "EE15041", 2, "G364612", new DateTime(1963, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), "Hugo_Goyette55@gmail.com", "Hugo", "Goyette", "Western Sahara", "1-508-464-5903 x653", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2389,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "New Laurinehaven", "EE16802", 3, "G462434", new DateTime(1971, 9, 30, 0, 0, 0, 0, DateTimeKind.Local), "Christy27@hotmail.com", "Christy", "Berge", "Honduras", "609.660.8160 x29477", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2390,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "New Rey", "EE19340", 4, "G30651", new DateTime(1968, 5, 8, 0, 0, 0, 0, DateTimeKind.Local), "Natalie_Feeney0@hotmail.com", "Natalie", "Feeney", "Mauritania", "(434) 791-8218", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2391,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Gutkowskiborough", "EE4183", "G500153", new DateTime(1996, 5, 6, 0, 0, 0, 0, DateTimeKind.Local), "Penny_OHara0@yahoo.com", "Penny", "O'Hara", "Seychelles", "1-832-541-4692" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2392,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Batzberg", "EE41269", 1, "G254794", new DateTime(1991, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), "Ignacio.Nolan37@yahoo.com", "Ignacio", "Nolan", "Antigua and Barbuda", "296.717.1285 x688" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2393,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Adelinemouth", "EE16121", "G532570", new DateTime(1991, 12, 24, 0, 0, 0, 0, DateTimeKind.Local), "Antoinette.Dickens77@gmail.com", "Antoinette", "Dickens", "Bangladesh", "(543) 468-2371 x833", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2394,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Port Mozelleland", "EE4365", 2, "G174025", new DateTime(1972, 8, 4, 0, 0, 0, 0, DateTimeKind.Local), "Pete_Graham@hotmail.com", "Pete", "Graham", "Georgia", "1-895-864-2190" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2395,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Wavafort", "EE16345", "G481039", new DateTime(1998, 1, 4, 0, 0, 0, 0, DateTimeKind.Local), "Shari.Leannon17@gmail.com", "Shari", "Leannon", "Grenada", "596.940.6273" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2396,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Antonetteside", "EE21711", 3, "G424389", new DateTime(1977, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), "Phil_Emard29@yahoo.com", "Phil", "Emard", "Niger", "508-977-7910", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2397,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Genesis", "EE25900", 1, "G306237", new DateTime(1961, 10, 14, 0, 0, 0, 0, DateTimeKind.Local), "Phyllis11@gmail.com", "Phyllis", "Walter", "India", "638-685-3696 x29282" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2398,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Port Clemmiefurt", "EE57046", 3, "G11971", new DateTime(1978, 10, 17, 0, 0, 0, 0, DateTimeKind.Local), "Lester58@gmail.com", "Lester", "Hirthe", "New Zealand", "465.310.5962" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2399,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Darrelland", "EE31128", 3, "G309068", new DateTime(1984, 5, 25, 0, 0, 0, 0, DateTimeKind.Local), "Ruth_McClure@gmail.com", "Ruth", "McClure", "New Caledonia", "1-747-430-9254 x8937" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2400,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Madisynhaven", "EE37770", 4, "G579014", new DateTime(2000, 11, 18, 0, 0, 0, 0, DateTimeKind.Local), "Gilberto.Haag@gmail.com", "Gilberto", "Haag", "Zimbabwe", "(758) 456-5022 x29141", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2401,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Geoview", "EE5070", 2, "G571938", new DateTime(1974, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), "Hazel.Hoeger@hotmail.com", "Hazel", "Hoeger", "Andorra", "574.449.4611", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2402,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Lanceberg", "EE30071", 1, "G379304", new DateTime(1953, 5, 3, 0, 0, 0, 0, DateTimeKind.Local), "Ismael25@hotmail.com", "Ismael", "Pollich", "Malawi", "595-937-9589 x08801" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2403,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Rolfsonport", "EE52186", 3, "G333579", new DateTime(1972, 7, 26, 0, 0, 0, 0, DateTimeKind.Local), "May.Kulas@hotmail.com", "May", "Kulas", "Kuwait", "1-944-981-3930 x8411", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2404,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Port Mona", "EE18525", 1, "G489471", new DateTime(1983, 4, 28, 0, 0, 0, 0, DateTimeKind.Local), "Guadalupe_Greenfelder10@hotmail.com", "Guadalupe", "Greenfelder", "Heard Island and McDonald Islands", "(314) 635-5933" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2405,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Romagueraville", "EE4647", 3, "G279513", new DateTime(1990, 3, 30, 0, 0, 0, 0, DateTimeKind.Local), "Ian_Cruickshank@yahoo.com", "Ian", "Cruickshank", "Belarus", "1-744-914-0118 x59579" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2406,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Maribelborough", "EE986", 1, "G146126", new DateTime(1988, 5, 22, 0, 0, 0, 0, DateTimeKind.Local), "Miranda_Murazik@gmail.com", "Miranda", "Murazik", "Peru", "559-691-1260 x659", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2407,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Augustastad", "EE26521", 4, "G330267", new DateTime(1966, 9, 25, 0, 0, 0, 0, DateTimeKind.Local), "Donnie_Fritsch@hotmail.com", "Donnie", "Fritsch", "Austria", "1-401-642-4508" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2408,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Merle", "EE8200", 4, "G584278", new DateTime(1989, 5, 8, 0, 0, 0, 0, DateTimeKind.Local), "Warren.Jacobs@yahoo.com", "Warren", "Jacobs", "Trinidad and Tobago", "(281) 846-2854 x764" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2409,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lillianaburgh", "EE16742", 4, "G402", new DateTime(1992, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), "Stacey.Streich22@yahoo.com", "Stacey", "Streich", "South Africa", "261-972-4894" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2410,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Bodeborough", "EE19766", 4, "G495875", new DateTime(1992, 11, 18, 0, 0, 0, 0, DateTimeKind.Local), "Merle85@gmail.com", "Merle", "Sauer", "Aruba", "609.659.0651 x996", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2411,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Anitaberg", "EE15021", "G316536", new DateTime(1975, 4, 22, 0, 0, 0, 0, DateTimeKind.Local), "Virgil.Wehner42@hotmail.com", "Virgil", "Wehner", "Venezuela", "818-459-8796 x056" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2412,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Opheliaborough", "EE57690", 3, "G511558", new DateTime(1972, 4, 23, 0, 0, 0, 0, DateTimeKind.Local), "Sophie.OReilly91@gmail.com", "Sophie", "O'Reilly", "China", "222-932-5245 x7969" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2413,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Georgeview", "EE20623", 2, "G465129", new DateTime(1956, 2, 11, 0, 0, 0, 0, DateTimeKind.Local), "Jeff_Larson7@gmail.com", "Jeff", "Larson", "Bulgaria", "538.695.3721", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2414,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Trompburgh", "EE21354", 4, "G551517", new DateTime(1990, 5, 21, 0, 0, 0, 0, DateTimeKind.Local), "Jermaine.Smitham@gmail.com", "Jermaine", "Smitham", "Virgin Islands, British", "1-205-971-2560 x5731", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2415,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lake Mervin", "EE26489", "G43609", new DateTime(1965, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), "Darla.Olson@hotmail.com", "Darla", "Olson", "Denmark", "711-634-5340", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2416,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Gerlachside", "EE31512", 1, "G80347", new DateTime(1970, 10, 10, 0, 0, 0, 0, DateTimeKind.Local), "Thelma24@yahoo.com", "Thelma", "Baumbach", "Cape Verde", "290.674.7938 x635" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2417,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Millshaven", "EE33561", 1, "G506679", new DateTime(1969, 7, 9, 0, 0, 0, 0, DateTimeKind.Local), "Terri.Keebler65@hotmail.com", "Terri", "Keebler", "Papua New Guinea", "311.298.7116" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2418,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "East Emil", "EE55031", 1, "G261348", new DateTime(1970, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), "Gene.Keeling@gmail.com", "Gene", "Keeling", "Samoa", "562-227-1472" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2419,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Eino", "EE7830", 2, "G151333", new DateTime(1978, 8, 7, 0, 0, 0, 0, DateTimeKind.Local), "Clifford88@yahoo.com", "Clifford", "Lindgren", "Hungary", "844-539-1847 x85023" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2420,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Gonzalofurt", "EE41921", 1, "G329204", new DateTime(1979, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), "Natasha80@yahoo.com", "Natasha", "Gutmann", "Guernsey", "419-769-3398 x933", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2421,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Nathanielville", "EE14715", 2, "G462008", new DateTime(2001, 4, 19, 0, 0, 0, 0, DateTimeKind.Local), "Eleanor97@hotmail.com", "Eleanor", "Casper", "Guam", "289-780-3045 x637" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2422,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Kubshire", "EE23896", "G20444", new DateTime(1996, 7, 8, 0, 0, 0, 0, DateTimeKind.Local), "Ronnie46@gmail.com", "Ronnie", "Upton", "Yemen", "785.351.8022", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2423,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Percivalmouth", "EE6476", 4, "G491276", new DateTime(1986, 7, 3, 0, 0, 0, 0, DateTimeKind.Local), "Brandi.Lang@gmail.com", "Brandi", "Lang", "Uganda", "(728) 460-4605" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2424,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Bernice", "EE48056", 1, "G567537", new DateTime(1988, 7, 14, 0, 0, 0, 0, DateTimeKind.Local), "Shelly_OKeefe@hotmail.com", "Shelly", "O'Keefe", "Norway", "1-266-567-7624 x6638", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2425,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Hailiebury", "EE32724", 2, "G429068", new DateTime(1966, 9, 1, 0, 0, 0, 0, DateTimeKind.Local), "Charlie.Donnelly@gmail.com", "Charlie", "Donnelly", "Saint Helena", "1-265-433-5294 x84449", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2426,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Abagailfort", "EE11413", 2, "G571833", new DateTime(1977, 7, 12, 0, 0, 0, 0, DateTimeKind.Local), "Nicole.Ferry@yahoo.com", "Nicole", "Ferry", "Vietnam", "351-467-0708 x73030", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2427,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Alenachester", "EE3868", 4, "G284812", new DateTime(1953, 2, 12, 0, 0, 0, 0, DateTimeKind.Local), "Jorge_Kris39@hotmail.com", "Jorge", "Kris", "Mexico", "566-860-3948 x6687" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2428,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Consueloport", "EE42977", 2, "G2127", new DateTime(1958, 7, 5, 0, 0, 0, 0, DateTimeKind.Local), "Alison.Hessel46@hotmail.com", "Alison", "Hessel", "French Polynesia", "1-847-987-2544 x432", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2429,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Oleshire", "EE52077", 4, "G210476", new DateTime(1967, 11, 4, 0, 0, 0, 0, DateTimeKind.Local), "Latoya.Conroy93@hotmail.com", "Latoya", "Conroy", "French Guiana", "(630) 688-4292" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2430,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Lisaview", "EE29095", 1, "G6691", new DateTime(1996, 9, 26, 0, 0, 0, 0, DateTimeKind.Local), "Alvin67@yahoo.com", "Alvin", "Wilkinson", "Belarus", "(785) 999-1797 x530", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2431,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Luzborough", "EE54844", 2, "G368638", new DateTime(1970, 2, 3, 0, 0, 0, 0, DateTimeKind.Local), "Cecil.Streich47@yahoo.com", "Cecil", "Streich", "Mauritius", "1-477-218-9463 x6927" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2432,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Dena", "EE21585", 3, "G159447", new DateTime(1954, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), "Edith66@hotmail.com", "Edith", "Hessel", "Kuwait", "385-915-2905 x913" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2433,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Gutkowskiton", "EE21742", 4, "G98209", new DateTime(1962, 4, 19, 0, 0, 0, 0, DateTimeKind.Local), "Yvonne.Cronin72@gmail.com", "Yvonne", "Cronin", "Iceland", "(585) 251-3348" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2434,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "New Jewel", "EE8982", "G470764", new DateTime(1971, 11, 7, 0, 0, 0, 0, DateTimeKind.Local), "Ruby_Welch@gmail.com", "Ruby", "Welch", "Malawi", "598-842-2331 x624", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2435,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Jazminchester", "EE51295", 1, "G217653", new DateTime(1956, 1, 14, 0, 0, 0, 0, DateTimeKind.Local), "Lester_Crooks9@hotmail.com", "Lester", "Crooks", "Burundi", "1-858-520-7618" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2436,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Ramona", "EE2059", 3, "G147275", new DateTime(1982, 5, 29, 0, 0, 0, 0, DateTimeKind.Local), "Horace60@gmail.com", "Horace", "Toy", "Kyrgyz Republic", "602-629-1856 x88257" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2437,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "East Edmond", "EE2081", 4, "G199289", new DateTime(1962, 5, 4, 0, 0, 0, 0, DateTimeKind.Local), "Cynthia_Abshire26@gmail.com", "Cynthia", "Abshire", "Virgin Islands, U.S.", "554.988.8321" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2438,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Koelpinhaven", "EE13682", "G212141", new DateTime(1993, 7, 11, 0, 0, 0, 0, DateTimeKind.Local), "Rachael61@gmail.com", "Rachael", "Baumbach", "Saint Pierre and Miquelon", "400-827-4648" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2439,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Alexandrinemouth", "EE52436", 2, "G167388", new DateTime(1980, 8, 23, 0, 0, 0, 0, DateTimeKind.Local), "Ronald.Christiansen@hotmail.com", "Ronald", "Christiansen", "Namibia", "865.751.0299 x886", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2440,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Milesside", "EE17034", 2, "G457731", new DateTime(1965, 9, 7, 0, 0, 0, 0, DateTimeKind.Local), "Austin77@yahoo.com", "Austin", "Herzog", "Virgin Islands, U.S.", "1-910-950-9952 x3159" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2441,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Grimesburgh", "EE21687", "G467952", new DateTime(1994, 1, 28, 0, 0, 0, 0, DateTimeKind.Local), "Meghan8@gmail.com", "Meghan", "West", "Egypt", "(234) 542-2893 x74901", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2442,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Kallie", "EE3989", 1, "G265631", new DateTime(1999, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), "Roosevelt_Reichel@gmail.com", "Roosevelt", "Reichel", "Christmas Island", "1-662-991-9263", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2443,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Verner", "EE41541", 1, "G412292", new DateTime(1969, 8, 23, 0, 0, 0, 0, DateTimeKind.Local), "Tara_Flatley@gmail.com", "Tara", "Flatley", "Republic of Korea", "1-828-578-8894 x529" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2444,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Averymouth", "EE17937", "G6133", new DateTime(1962, 8, 26, 0, 0, 0, 0, DateTimeKind.Local), "Tara_Stracke32@gmail.com", "Tara", "Stracke", "United Kingdom", "(643) 418-6751 x15988" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2445,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Romagueraview", "EE12362", "G43195", new DateTime(1981, 2, 10, 0, 0, 0, 0, DateTimeKind.Local), "Stephen_Hane@yahoo.com", "Stephen", "Hane", "Saudi Arabia", "585-676-6789" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2446,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Leonelland", "EE52151", "G210328", new DateTime(1990, 6, 4, 0, 0, 0, 0, DateTimeKind.Local), "Kathryn.Jacobs@gmail.com", "Kathryn", "Jacobs", "Mayotte", "(772) 882-6336 x001" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2447,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Maryamville", "EE42457", 3, "G590441", new DateTime(1986, 10, 28, 0, 0, 0, 0, DateTimeKind.Local), "Sammy25@gmail.com", "Sammy", "Ziemann", "Lithuania", "823-984-6844 x2727" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2448,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Hirthemouth", "EE2231", 2, "G334617", new DateTime(1968, 7, 21, 0, 0, 0, 0, DateTimeKind.Local), "Myron.Hermann20@gmail.com", "Myron", "Hermann", "Costa Rica", "793.548.8568" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2449,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Port Hallie", "EE43560", 3, "G160452", new DateTime(1990, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), "Kristy.Zieme@hotmail.com", "Kristy", "Zieme", "New Zealand", "497.230.0557 x0652" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2450,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Bria", "EE44026", 2, "G54691", new DateTime(1997, 1, 15, 0, 0, 0, 0, DateTimeKind.Local), "Renee.Gusikowski19@hotmail.com", "Renee", "Gusikowski", "Virgin Islands, U.S.", "302.250.6281 x55406", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2451,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Edmundfurt", "EE19205", 1, "G15208", new DateTime(1956, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), "Tasha43@yahoo.com", "Tasha", "O'Kon", "Palestinian Territory", "(617) 595-8883 x76520", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2452,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Port Juanafort", "EE38086", 3, "G401833", new DateTime(1987, 2, 22, 0, 0, 0, 0, DateTimeKind.Local), "Rolando.Hettinger@hotmail.com", "Rolando", "Hettinger", "Senegal", "1-461-232-0440" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2453,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Weissnatshire", "EE6515", "G198287", new DateTime(1975, 6, 13, 0, 0, 0, 0, DateTimeKind.Local), "Gary_Larson@hotmail.com", "Gary", "Larson", "Poland", "1-470-910-4923" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2454,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Samson", "EE19299", 3, "G447953", new DateTime(1975, 3, 31, 0, 0, 0, 0, DateTimeKind.Local), "Bethany31@gmail.com", "Bethany", "Metz", "Solomon Islands", "(905) 635-4141 x94870", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2455,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Mollieview", "EE40681", 1, "G278271", new DateTime(1961, 6, 1, 0, 0, 0, 0, DateTimeKind.Local), "Greg3@gmail.com", "Greg", "Jakubowski", "Cape Verde", "762.797.4812 x1742" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2456,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Rexside", "EE55947", 4, "G175819", new DateTime(1984, 8, 1, 0, 0, 0, 0, DateTimeKind.Local), "Lorene_Treutel63@hotmail.com", "Lorene", "Treutel", "Croatia", "1-703-894-6660 x27894" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2457,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Hackettville", "EE54836", "G418106", new DateTime(1988, 10, 13, 0, 0, 0, 0, DateTimeKind.Local), "Winifred.Mosciski@gmail.com", "Winifred", "Mosciski", "Northern Mariana Islands", "1-260-846-9696" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2458,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lake Merritt", "EE20490", 4, "G270904", new DateTime(1988, 4, 16, 0, 0, 0, 0, DateTimeKind.Local), "Johanna_Smitham@hotmail.com", "Johanna", "Smitham", "Malta", "(821) 491-5869 x1735", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2459,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Kristamouth", "EE9402", 2, "G206282", new DateTime(1995, 2, 24, 0, 0, 0, 0, DateTimeKind.Local), "Verna39@hotmail.com", "Verna", "Murazik", "Heard Island and McDonald Islands", "287.835.1059 x92907" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2460,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Casandraburgh", "EE50096", 4, "G93898", new DateTime(1965, 6, 25, 0, 0, 0, 0, DateTimeKind.Local), "Eduardo_Dooley@yahoo.com", "Eduardo", "Dooley", "Chile", "(572) 667-5506 x0859" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2461,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Handbury", "EE38093", 3, "G439453", new DateTime(1999, 12, 3, 0, 0, 0, 0, DateTimeKind.Local), "Lynne_Yost@hotmail.com", "Lynne", "Yost", "Gambia", "846.618.8922 x6697", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2462,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Eastershire", "EE25230", 1, "G481922", new DateTime(1960, 2, 20, 0, 0, 0, 0, DateTimeKind.Local), "Penny_Crist58@yahoo.com", "Penny", "Crist", "Somalia", "(484) 712-6921", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2463,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Nikita", "EE56925", 1, "G508216", new DateTime(1991, 1, 8, 0, 0, 0, 0, DateTimeKind.Local), "Santiago.Abshire@hotmail.com", "Santiago", "Abshire", "Niger", "333.421.0758" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2464,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Franciscaborough", "EE34238", 2, "G323523", new DateTime(1960, 9, 21, 0, 0, 0, 0, DateTimeKind.Local), "Traci.Jones@yahoo.com", "Traci", "Jones", "Iran", "(447) 211-8359 x8719" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2465,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Alene", "EE43812", 4, "G499247", new DateTime(1998, 8, 2, 0, 0, 0, 0, DateTimeKind.Local), "Tony_Abbott@yahoo.com", "Tony", "Abbott", "Iran", "1-631-557-0651 x248", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2466,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Georgianashire", "EE55977", 4, "G205001", new DateTime(1983, 5, 20, 0, 0, 0, 0, DateTimeKind.Local), "Katrina48@gmail.com", "Katrina", "Huels", "Zimbabwe", "968.781.7002" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2467,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Jazmintown", "EE56184", "G334355", new DateTime(2001, 3, 2, 0, 0, 0, 0, DateTimeKind.Local), "Jack.Stracke91@hotmail.com", "Jack", "Stracke", "Barbados", "965.374.1171 x491", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2468,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Feeneyborough", "EE27335", 1, "G411257", new DateTime(1997, 1, 19, 0, 0, 0, 0, DateTimeKind.Local), "Rita.Zemlak96@yahoo.com", "Rita", "Zemlak", "Syrian Arab Republic", "970-714-1868 x4211", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2469,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Vernerport", "EE43744", 4, "G162340", new DateTime(1981, 6, 29, 0, 0, 0, 0, DateTimeKind.Local), "Essie.Connelly96@yahoo.com", "Essie", "Connelly", "Lithuania", "378-287-0657", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2470,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Prosaccochester", "EE55136", 2, "G546497", new DateTime(1970, 8, 1, 0, 0, 0, 0, DateTimeKind.Local), "Jody_Armstrong@hotmail.com", "Jody", "Armstrong", "Argentina", "222-702-5557 x6390" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2471,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Tyriqueburgh", "EE25425", 2, "G46433", new DateTime(1956, 10, 4, 0, 0, 0, 0, DateTimeKind.Local), "Bobbie29@hotmail.com", "Bobbie", "Goyette", "Dominica", "(670) 510-5404 x11158" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2472,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lake Joelbury", "EE52304", "G279735", new DateTime(1974, 2, 9, 0, 0, 0, 0, DateTimeKind.Local), "Willis.Hyatt@yahoo.com", "Willis", "Hyatt", "Gibraltar", "1-859-919-2635 x2980", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2473,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Hillsfurt", "EE6258", 4, "G244102", new DateTime(1956, 3, 26, 0, 0, 0, 0, DateTimeKind.Local), "Florence.Predovic75@yahoo.com", "Florence", "Predovic", "Burkina Faso", "1-754-385-2133 x20787", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2474,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "New Kaliview", "EE6490", 2, "G145166", new DateTime(1961, 3, 26, 0, 0, 0, 0, DateTimeKind.Local), "Ray_Kshlerin@hotmail.com", "Ray", "Kshlerin", "Latvia", "(838) 655-4291", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2475,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Casperborough", "EE12300", "G34568", new DateTime(1978, 8, 27, 0, 0, 0, 0, DateTimeKind.Local), "Samuel9@gmail.com", "Samuel", "Shields", "Tonga", "209.704.7475 x78897", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2476,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Arianna", "EE34837", 3, "G527785", new DateTime(1966, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), "Carlos29@yahoo.com", "Carlos", "Okuneva", "Finland", "1-515-894-2919", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2477,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Chadbury", "EE55099", 1, "G397907", new DateTime(2001, 5, 7, 0, 0, 0, 0, DateTimeKind.Local), "Jacob.Gislason@gmail.com", "Jacob", "Gislason", "Solomon Islands", "(673) 717-1270", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2478,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Jolie", "EE42775", 1, "G119615", new DateTime(1997, 9, 18, 0, 0, 0, 0, DateTimeKind.Local), "Zachary73@yahoo.com", "Zachary", "Terry", "Gibraltar", "996.971.1734", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2479,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Zoemouth", "EE20530", "G135420", new DateTime(1986, 7, 16, 0, 0, 0, 0, DateTimeKind.Local), "Juanita.Hegmann@yahoo.com", "Juanita", "Hegmann", "Finland", "(989) 766-6380 x58461", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2480,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Lelafurt", "EE51902", 2, "G372044", new DateTime(1969, 6, 24, 0, 0, 0, 0, DateTimeKind.Local), "Wade.Green@hotmail.com", "Wade", "Green", "Yemen", "388.532.0909", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2481,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Magnuston", "EE49522", 4, "G535335", new DateTime(1966, 3, 9, 0, 0, 0, 0, DateTimeKind.Local), "Walter_Pouros@yahoo.com", "Walter", "Pouros", "Cambodia", "877-482-2354", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2482,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Koelpinmouth", "EE28365", 2, "G33956", new DateTime(1966, 7, 17, 0, 0, 0, 0, DateTimeKind.Local), "Dexter_Schinner59@gmail.com", "Dexter", "Schinner", "Holy See (Vatican City State)", "329-458-9134 x7984", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2483,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Rachaelview", "EE18251", "G376834", new DateTime(1962, 6, 30, 0, 0, 0, 0, DateTimeKind.Local), "Marion_Sauer@yahoo.com", "Marion", "Sauer", "Benin", "1-460-666-1712 x541", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2484,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Leo", "EE43310", 2, "G566347", new DateTime(1971, 8, 3, 0, 0, 0, 0, DateTimeKind.Local), "Bonnie_Powlowski93@hotmail.com", "Bonnie", "Powlowski", "Jamaica", "509-667-5180" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2485,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Judsonport", "EE9334", 2, "G7419", new DateTime(1960, 9, 22, 0, 0, 0, 0, DateTimeKind.Local), "Tamara.Monahan@hotmail.com", "Tamara", "Monahan", "Tuvalu", "(988) 625-2053 x33562", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2486,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Graciemouth", "EE12191", 3, "G313338", new DateTime(1980, 8, 29, 0, 0, 0, 0, DateTimeKind.Local), "Christian_Rodriguez53@hotmail.com", "Christian", "Rodriguez", "Cayman Islands", "(261) 323-0556 x3240" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2487,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Lomaberg", "EE54345", 2, "G36859", new DateTime(1957, 5, 26, 0, 0, 0, 0, DateTimeKind.Local), "Derrick1@gmail.com", "Derrick", "Klein", "Luxembourg", "669.487.5200 x8841", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2488,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Hodkiewiczfort", "EE7458", 2, "G440759", new DateTime(1975, 6, 23, 0, 0, 0, 0, DateTimeKind.Local), "Merle_Crona3@hotmail.com", "Merle", "Crona", "France", "1-269-423-8158", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2489,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Rachelshire", "EE58431", 3, "G152617", new DateTime(1955, 10, 28, 0, 0, 0, 0, DateTimeKind.Local), "Helen28@hotmail.com", "Helen", "Spencer", "Venezuela", "695.985.3307 x5397", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2490,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Matildehaven", "EE14793", "G315366", new DateTime(1956, 2, 3, 0, 0, 0, 0, DateTimeKind.Local), "Marie72@yahoo.com", "Marie", "Kihn", "Panama", "1-678-375-9949 x588", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2491,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Laurynborough", "EE5368", 3, "G118077", new DateTime(1973, 12, 24, 0, 0, 0, 0, DateTimeKind.Local), "Wayne56@hotmail.com", "Wayne", "Runte", "Armenia", "1-735-898-6565", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2492,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Hegmannshire", "EE1822", "G148450", new DateTime(1994, 6, 30, 0, 0, 0, 0, DateTimeKind.Local), "Jo.Donnelly@yahoo.com", "Jo", "Donnelly", "Greenland", "609-409-4529 x2562" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2493,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Beiermouth", "EE26082", 4, "G78661", new DateTime(1973, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), "Tina58@gmail.com", "Tina", "Lehner", "Romania", "751.450.5768" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2494,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Littelchester", "EE7612", 1, "G231408", new DateTime(1977, 7, 6, 0, 0, 0, 0, DateTimeKind.Local), "Sadie_Hayes59@yahoo.com", "Sadie", "Hayes", "Ireland", "410-838-5233" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2495,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Carrollside", "EE45592", 1, "G341377", new DateTime(1963, 12, 4, 0, 0, 0, 0, DateTimeKind.Local), "Jeffery.Willms38@yahoo.com", "Jeffery", "Willms", "San Marino", "596-928-2960 x7160" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2496,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Chynaburgh", "EE16052", 2, "G577906", new DateTime(1993, 7, 24, 0, 0, 0, 0, DateTimeKind.Local), "Rickey.Deckow@hotmail.com", "Rickey", "Deckow", "Reunion", "(821) 827-3015", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2497,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Mullerland", "EE13624", 3, "G324925", new DateTime(1997, 5, 28, 0, 0, 0, 0, DateTimeKind.Local), "Frank_Daugherty@hotmail.com", "Frank", "Daugherty", "Saint Barthelemy", "859.243.9623 x82898" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2498,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Murphyhaven", "EE14277", 4, "G417714", new DateTime(1974, 12, 4, 0, 0, 0, 0, DateTimeKind.Local), "Clifton38@yahoo.com", "Clifton", "Ryan", "Trinidad and Tobago", "374.634.5067", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2499,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Arnaldo", "EE43848", 2, "G256342", new DateTime(1957, 4, 18, 0, 0, 0, 0, DateTimeKind.Local), "Karl11@hotmail.com", "Karl", "Bogan", "Peru", "929-698-2930", "Male" });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "nom", "professeurId" },
                values: new object[] { "capacitor Senior transmitter", 16 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "nom", "professeurId" },
                values: new object[] { "Outdoors compelling Auto Loan Account", 12 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "nom", "professeurId" },
                values: new object[] { "Tasty Granite Bike functionalities deposit", 1 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "classeId", "nom", "professeurId" },
                values: new object[] { 4, "Australia synergistic Mall", 24 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "classeId", "nom" },
                values: new object[] { 1, "Sports & Shoes Oval solid state" });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "classeId", "nom", "professeurId" },
                values: new object[] { 1, "override B2C 6th generation", 10 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "classeId", "nom", "professeurId" },
                values: new object[] { 2, "Borders adapter Synchronised", 19 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "classeId", "nom", "professeurId" },
                values: new object[] { 4, "Rustic payment strategy", 1 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "classeId", "nom", "professeurId" },
                values: new object[] { 3, "program Paradigm redefine", 11 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "classeId", "nom", "professeurId" },
                values: new object[] { 2, "connecting Stream Intelligent Soft Gloves", 9 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "classeId", "nom", "professeurId" },
                values: new object[] { 2, "Specialist Cambridgeshire redefine", 1 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "classeId", "nom", "professeurId" },
                values: new object[] { 3, "Prairie Open-source programming", 5 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "classeId", "nom", "professeurId" },
                values: new object[] { 4, "Maryland Steel Denar", 7 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "classeId", "nom", "professeurId" },
                values: new object[] { 4, "Handmade Cotton Salad Fresh dynamic", 5 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "classeId", "nom", "professeurId" },
                values: new object[] { 1, "Legacy enterprise Venezuela", 9 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "nom", "professeurId" },
                values: new object[] { "Saint Kitts and Nevis empowering Rufiyaa", 17 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "classeId", "nom", "professeurId" },
                values: new object[] { 3, "withdrawal orange connect", 1 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "classeId", "nom", "professeurId" },
                values: new object[] { 4, "bluetooth Common Awesome Plastic Pizza", 9 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "classeId", "nom", "professeurId" },
                values: new object[] { 2, "Games & Jewelery GB pixel", 25 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "classeId", "nom", "professeurId" },
                values: new object[] { 1, "Svalbard & Jan Mayen Islands Computers, Health & Electronics Directives", 23 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "nom", "professeurId" },
                values: new object[] { "Ridge invoice PCI", 6 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "classeId", "nom", "professeurId" },
                values: new object[] { 3, "Division synergies Ouguiya", 6 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "classeId", "nom", "professeurId" },
                values: new object[] { 3, "EXE Awesome Wooden Table Florida", 25 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "nom", "professeurId" },
                values: new object[] { "bus Bhutanese Ngultrum visualize", 11 });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "NotePdfUrl", "moduleId", "semestre" },
                values: new object[] { "B", 18, "1" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "NotePdfUrl", "moduleId", "semestre" },
                values: new object[] { "C", 1, "2" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "NotePdfUrl", "moduleId", "semestre" },
                values: new object[] { "A", 17, "1" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "NotePdfUrl", "semestre" },
                values: new object[] { "C", "0" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "NotePdfUrl", "moduleId", "semestre" },
                values: new object[] { "A", 8, "0" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 6,
                column: "moduleId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "NotePdfUrl", "semestre" },
                values: new object[] { "C", "0" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "moduleId", "semestre" },
                values: new object[] { 4, "2" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "NotePdfUrl", "moduleId", "semestre" },
                values: new object[] { "B", 7, "2" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "NotePdfUrl", "moduleId", "semestre" },
                values: new object[] { "B", 5, "1" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "NotePdfUrl", "moduleId", "semestre" },
                values: new object[] { "B", 17, "0" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "NotePdfUrl", "moduleId", "semestre" },
                values: new object[] { "B", 24, "2" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "NotePdfUrl", "moduleId", "semestre" },
                values: new object[] { "B", 1, "0" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "moduleId", "semestre" },
                values: new object[] { 2, "0" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "moduleId", "semestre" },
                values: new object[] { 12, "1" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "NotePdfUrl", "moduleId" },
                values: new object[] { "B", 7 });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 17,
                column: "moduleId",
                value: 19);

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "NotePdfUrl", "moduleId", "semestre" },
                values: new object[] { "A", 13, "2" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "NotePdfUrl", "moduleId" },
                values: new object[] { "B", 14 });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "NotePdfUrl", "moduleId", "semestre" },
                values: new object[] { "C", 22, "0" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "NotePdfUrl", "moduleId", "semestre" },
                values: new object[] { "B", 3, "0" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "NotePdfUrl", "moduleId", "semestre" },
                values: new object[] { "B", 24, "1" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "NotePdfUrl", "semestre" },
                values: new object[] { "A", "0" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "NotePdfUrl", "moduleId", "semestre" },
                values: new object[] { "A", 23, "1" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "NotePdfUrl", "moduleId", "semestre" },
                values: new object[] { "A", 21, "2" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "email", "login", "nom", "prenom" },
                values: new object[] { "Blake.Abbott83@gmail.com", "Tasty", "Abbott", "Blake" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "departementId", "email", "login", "nom", "prenom" },
                values: new object[] { 2, "Constance_Price77@yahoo.com", "reintermediate", "Price", "Constance" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "departementId", "email", "login", "nom", "prenom" },
                values: new object[] { 1, "Vernon_Hand65@yahoo.com", "Concrete", "Hand", "Vernon" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "email", "login", "nom", "prenom" },
                values: new object[] { "Justin92@hotmail.com", "Cook Islands", "West", "Justin" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "departementId", "email", "login", "nom", "prenom" },
                values: new object[] { 2, "Robin.Casper9@hotmail.com", "Electronics, Music & Beauty", "Casper", "Robin" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "departementId", "email", "login", "nom", "prenom" },
                values: new object[] { 1, "Maureen_Gorczany84@hotmail.com", "PNG", "Gorczany", "Maureen" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "email", "login", "nom", "prenom" },
                values: new object[] { "Jerald_Howell@hotmail.com", "Quality-focused", "Howell", "Jerald" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "email", "login", "nom", "prenom" },
                values: new object[] { "Cornelius63@hotmail.com", "Borders", "Conn", "Cornelius" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "departementId", "email", "login", "nom", "prenom" },
                values: new object[] { 2, "Billie93@yahoo.com", "invoice", "Kerluke", "Billie" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "departementId", "email", "login", "nom", "prenom" },
                values: new object[] { 2, "Norman_Lang25@gmail.com", "pixel", "Lang", "Norman" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "email", "login", "nom", "prenom" },
                values: new object[] { "Naomi30@yahoo.com", "PCI", "Heller", "Naomi" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "departementId", "email", "login", "nom", "prenom" },
                values: new object[] { 1, "Alan5@gmail.com", "Guam", "Rippin", "Alan" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "email", "login", "nom", "prenom" },
                values: new object[] { "Amanda57@yahoo.com", "Rustic", "Ortiz", "Amanda" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "departementId", "email", "login", "nom", "prenom" },
                values: new object[] { 1, "Brooke40@gmail.com", "Ergonomic", "Roberts", "Brooke" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "departementId", "email", "login", "nom", "prenom" },
                values: new object[] { 1, "Mindy.Dickens8@yahoo.com", "initiatives", "Dickens", "Mindy" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "email", "login", "nom", "prenom" },
                values: new object[] { "Andres_Schaefer@hotmail.com", "USB", "Schaefer", "Andres" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "email", "login", "nom", "prenom" },
                values: new object[] { "Ted34@gmail.com", "Tasty Concrete Car", "Ortiz", "Ted" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "email", "login", "nom", "prenom" },
                values: new object[] { "Terrence.Cronin53@yahoo.com", "dynamic", "Cronin", "Terrence" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "departementId", "email", "login", "nom", "prenom" },
                values: new object[] { 2, "Marian59@hotmail.com", "Response", "Bernier", "Marian" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "departementId", "email", "login", "nom", "prenom" },
                values: new object[] { 2, "Jaime.Koch@gmail.com", "Incredible Wooden Chicken", "Koch", "Jaime" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "departementId", "email", "login", "nom", "prenom" },
                values: new object[] { 2, "Brett76@gmail.com", "supply-chains", "Wilkinson", "Brett" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "email", "login", "nom", "prenom" },
                values: new object[] { "Colleen.Carroll@gmail.com", "International", "Carroll", "Colleen" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "departementId", "email", "login", "nom", "prenom" },
                values: new object[] { 1, "Daisy.Ankunding33@gmail.com", "Versatile", "Ankunding", "Daisy" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "departementId", "email", "login", "nom", "prenom" },
                values: new object[] { 2, "Ashley38@gmail.com", "Connecticut", "Haley", "Ashley" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "departementId", "email", "login", "nom", "prenom" },
                values: new object[] { 1, "Pedro_Hintz96@gmail.com", "transmitter", "Hintz", "Pedro" });

            migrationBuilder.UpdateData(
                table: "classes",
                keyColumn: "id",
                keyValue: 1,
                column: "filiereId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "classes",
                keyColumn: "id",
                keyValue: 2,
                column: "filiereId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "classes",
                keyColumn: "id",
                keyValue: 3,
                column: "filiereId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "classes",
                keyColumn: "id",
                keyValue: 4,
                column: "filiereId",
                value: 4);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "academie",
                table: "Etudiants");

            migrationBuilder.DropColumn(
                name: "adresse",
                table: "Etudiants");

            migrationBuilder.DropColumn(
                name: "annee_bac",
                table: "Etudiants");

            migrationBuilder.DropColumn(
                name: "code_promo",
                table: "Etudiants");

            migrationBuilder.DropColumn(
                name: "delegation",
                table: "Etudiants");

            migrationBuilder.DropColumn(
                name: "diplome",
                table: "Etudiants");

            migrationBuilder.DropColumn(
                name: "ecole",
                table: "Etudiants");

            migrationBuilder.DropColumn(
                name: "father_job",
                table: "Etudiants");

            migrationBuilder.DropColumn(
                name: "father_name",
                table: "Etudiants");

            migrationBuilder.DropColumn(
                name: "filiere",
                table: "Etudiants");

            migrationBuilder.DropColumn(
                name: "firstname_ar",
                table: "Etudiants");

            migrationBuilder.DropColumn(
                name: "firstname_fr",
                table: "Etudiants");

            migrationBuilder.DropColumn(
                name: "lastname_ar",
                table: "Etudiants");

            migrationBuilder.DropColumn(
                name: "lycee",
                table: "Etudiants");

            migrationBuilder.DropColumn(
                name: "mention_bac",
                table: "Etudiants");

            migrationBuilder.DropColumn(
                name: "mother_job",
                table: "Etudiants");

            migrationBuilder.DropColumn(
                name: "mother_name",
                table: "Etudiants");

            migrationBuilder.DropColumn(
                name: "nom",
                table: "Etudiants");

            migrationBuilder.DropColumn(
                name: "parents_adress",
                table: "Etudiants");

            migrationBuilder.DropColumn(
                name: "parents_phone",
                table: "Etudiants");

            migrationBuilder.DropColumn(
                name: "prenom",
                table: "Etudiants");

            migrationBuilder.DropColumn(
                name: "tel",
                table: "Etudiants");

            migrationBuilder.DropColumn(
                name: "type_bac",
                table: "Etudiants");

            migrationBuilder.DropColumn(
                name: "validated",
                table: "Etudiants");

            migrationBuilder.DropColumn(
                name: "ville_diplome",
                table: "Etudiants");

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "date_demande", "id_etudiant", "type" },
                values: new object[] { new DateTime(2021, 6, 29, 2, 4, 3, 576, DateTimeKind.Local).AddTicks(1830), 2117, "Releve de note" });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "date_demande", "id_etudiant", "type" },
                values: new object[] { new DateTime(2021, 6, 29, 2, 4, 3, 577, DateTimeKind.Local).AddTicks(483), 2301, "Attestation de stage" });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "date_demande", "id_etudiant", "type" },
                values: new object[] { new DateTime(2021, 6, 29, 2, 4, 3, 577, DateTimeKind.Local).AddTicks(573), 2216, "Attestation de scolarite" });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "date_demande", "id_etudiant" },
                values: new object[] { new DateTime(2021, 6, 29, 2, 4, 3, 577, DateTimeKind.Local).AddTicks(596), 2125 });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "date_demande", "id_etudiant" },
                values: new object[] { new DateTime(2021, 6, 29, 2, 4, 3, 577, DateTimeKind.Local).AddTicks(619), 2087 });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2000,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Trantowmouth", "EE22858", 4, "G153757", new DateTime(1978, 10, 14, 0, 0, 0, 0, DateTimeKind.Local), "Alberta.Casper@gmail.com", "Alberta", "Casper", "Macedonia", "633-707-3077 x93852", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2001,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Tavaresshire", "EE3087", 1, "G14787", new DateTime(1968, 4, 10, 0, 0, 0, 0, DateTimeKind.Local), "Angelica46@gmail.com", "Angelica", "O'Conner", "Netherlands Antilles", "1-233-373-2857", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2002,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Predovicmouth", "EE15320", "G264866", new DateTime(1970, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), "Darrel.Weber55@yahoo.com", "Darrel", "Weber", "Togo", "519.405.3028 x797", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2003,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Wunschmouth", "EE29178", "G145789", new DateTime(1994, 8, 4, 0, 0, 0, 0, DateTimeKind.Local), "Javier_Boehm@yahoo.com", "Javier", "Boehm", "Republic of Korea", "429.834.5628 x09298" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2004,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Port Myles", "EE57358", 1, "G133217", new DateTime(1975, 10, 4, 0, 0, 0, 0, DateTimeKind.Local), "Milton_Reinger@gmail.com", "Milton", "Reinger", "Costa Rica", "275-575-0273 x848" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2005,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Rathbury", "EE28153", 1, "G146087", new DateTime(1988, 2, 16, 0, 0, 0, 0, DateTimeKind.Local), "Elias_Ernser19@gmail.com", "Elias", "Ernser", "Philippines", "1-508-626-0971", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2006,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "East Leta", "EE17106", 1, "G556021", new DateTime(1976, 1, 12, 0, 0, 0, 0, DateTimeKind.Local), "Erin61@yahoo.com", "Erin", "Labadie", "Democratic People's Republic of Korea", "(858) 669-4483 x946" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2007,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Hankside", "EE9337", "G593024", new DateTime(1961, 4, 28, 0, 0, 0, 0, DateTimeKind.Local), "Keith.Monahan@yahoo.com", "Keith", "Monahan", "Sudan", "(369) 568-4554", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2008,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lake Freeda", "EE50983", 4, "G319037", new DateTime(1955, 1, 26, 0, 0, 0, 0, DateTimeKind.Local), "Jeannie8@hotmail.com", "Jeannie", "Herzog", "South Georgia and the South Sandwich Islands", "327.260.7559", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2009,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Pagacburgh", "EE37483", "G61787", new DateTime(1955, 1, 29, 0, 0, 0, 0, DateTimeKind.Local), "Cesar.Ankunding@yahoo.com", "Cesar", "Ankunding", "Italy", "809-246-7308", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2010,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Darrion", "EE57200", "G156142", new DateTime(1984, 5, 17, 0, 0, 0, 0, DateTimeKind.Local), "Jacqueline_Stamm@gmail.com", "Jacqueline", "Stamm", "Serbia", "485-464-1713 x0937", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2011,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Gennarostad", "EE19708", "G197826", new DateTime(1960, 10, 7, 0, 0, 0, 0, DateTimeKind.Local), "Sadie.Tromp62@yahoo.com", "Sadie", "Tromp", "Ecuador", "394-448-2227 x31528" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2012,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lebsackview", "EE50778", "G541575", new DateTime(1963, 9, 30, 0, 0, 0, 0, DateTimeKind.Local), "Mary_Prosacco@hotmail.com", "Mary", "Prosacco", "Kiribati", "1-959-293-9453 x52847" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2013,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Halleside", "EE13283", 1, "G56552", new DateTime(1997, 2, 4, 0, 0, 0, 0, DateTimeKind.Local), "Sherry.Flatley@hotmail.com", "Sherry", "Flatley", "Samoa", "611.352.7696 x101" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2014,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Whitneymouth", "EE30308", "G85402", new DateTime(1961, 7, 12, 0, 0, 0, 0, DateTimeKind.Local), "Jermaine_Moen10@yahoo.com", "Jermaine", "Moen", "Slovakia (Slovak Republic)", "1-579-335-3322 x164" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2015,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Cordiaberg", "EE53861", 3, "G256496", new DateTime(1957, 7, 16, 0, 0, 0, 0, DateTimeKind.Local), "Thomas90@gmail.com", "Thomas", "Reilly", "Antigua and Barbuda", "582.913.2708", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2016,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Princemouth", "EE7160", "G216743", new DateTime(1976, 11, 24, 0, 0, 0, 0, DateTimeKind.Local), "Saul66@gmail.com", "Saul", "Hudson", "Western Sahara", "730-624-3314 x360", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2017,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Brekkeport", "EE50981", 1, "G243934", new DateTime(1961, 5, 12, 0, 0, 0, 0, DateTimeKind.Local), "Roman1@hotmail.com", "Roman", "Kub", "Wallis and Futuna", "(538) 285-5065" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2018,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Port Elisabethton", "EE54695", 1, "G352843", new DateTime(1962, 10, 21, 0, 0, 0, 0, DateTimeKind.Local), "Noel74@hotmail.com", "Noel", "Mitchell", "Algeria", "1-347-498-6122 x99454" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2019,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Lewismouth", "EE16772", 4, "G587331", new DateTime(1994, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), "Lynn.Schaden@hotmail.com", "Lynn", "Schaden", "Samoa", "1-881-332-8169", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2020,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Morissetteton", "EE2716", 4, "G348172", new DateTime(1975, 5, 25, 0, 0, 0, 0, DateTimeKind.Local), "Brent.Sanford74@yahoo.com", "Brent", "Sanford", "Turkmenistan", "553-843-1564 x681", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2021,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Oda", "EE8760", "G5504", new DateTime(1985, 1, 23, 0, 0, 0, 0, DateTimeKind.Local), "Kristopher.OHara33@hotmail.com", "Kristopher", "O'Hara", "Madagascar", "875-775-6107", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2022,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Magnusstad", "EE2078", 1, "G275569", new DateTime(1958, 9, 6, 0, 0, 0, 0, DateTimeKind.Local), "Jared_Hermann@yahoo.com", "Jared", "Hermann", "Bulgaria", "601.602.5907" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2023,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "North Alanis", "EE30304", 2, "G187401", new DateTime(1971, 7, 21, 0, 0, 0, 0, DateTimeKind.Local), "Tiffany.Sawayn@hotmail.com", "Tiffany", "Sawayn", "Spain", "1-686-637-0252" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2024,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Flavieshire", "EE22342", "G329611", new DateTime(1964, 9, 10, 0, 0, 0, 0, DateTimeKind.Local), "Allan.Kozey@yahoo.com", "Allan", "Kozey", "Aruba", "330-972-2541 x53296", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2025,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "East Torreystad", "EE7401", 3, "G490007", new DateTime(1952, 12, 3, 0, 0, 0, 0, DateTimeKind.Local), "Henrietta51@hotmail.com", "Henrietta", "Hayes", "Heard Island and McDonald Islands", "920.675.9075" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2026,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Hoseashire", "EE7056", 1, "G59795", new DateTime(1962, 1, 21, 0, 0, 0, 0, DateTimeKind.Local), "Carl98@gmail.com", "Carl", "Murray", "Philippines", "1-494-818-1191 x007", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2027,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Hermannfort", "EE34390", "G367884", new DateTime(1959, 12, 6, 0, 0, 0, 0, DateTimeKind.Local), "Priscilla_Dickens78@yahoo.com", "Priscilla", "Dickens", "Trinidad and Tobago", "1-847-425-0462", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2028,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Xander", "EE20976", 3, "G24804", new DateTime(1996, 3, 12, 0, 0, 0, 0, DateTimeKind.Local), "Shawna_Ratke87@hotmail.com", "Shawna", "Ratke", "Niger", "(778) 418-2272 x57062" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2029,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "North Clarabelleborough", "EE4054", 1, "G490359", new DateTime(1966, 7, 5, 0, 0, 0, 0, DateTimeKind.Local), "Philip.Welch99@yahoo.com", "Philip", "Welch", "Jamaica", "927-728-1451 x71855" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2030,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Woodrowport", "EE18395", 4, "G527785", new DateTime(1957, 11, 22, 0, 0, 0, 0, DateTimeKind.Local), "Abraham.Veum@hotmail.com", "Abraham", "Veum", "Tanzania", "922-243-1747", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2031,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Feeneystad", "EE18369", 1, "G235722", new DateTime(1970, 7, 1, 0, 0, 0, 0, DateTimeKind.Local), "Saul_Pfannerstill@hotmail.com", "Saul", "Pfannerstill", "Austria", "(925) 204-6430 x5194" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2032,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lake Pasqualefurt", "EE2262", "G353582", new DateTime(2000, 10, 29, 0, 0, 0, 0, DateTimeKind.Local), "Betty6@hotmail.com", "Betty", "Harvey", "Germany", "623.813.7130 x3041", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2033,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Chanceside", "EE43613", 1, "G47774", new DateTime(1990, 5, 21, 0, 0, 0, 0, DateTimeKind.Local), "Rex.Stiedemann89@gmail.com", "Rex", "Stiedemann", "Holy See (Vatican City State)", "1-636-368-8126", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2034,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Leora", "EE45056", 2, "G216820", new DateTime(1986, 9, 19, 0, 0, 0, 0, DateTimeKind.Local), "Kent.Skiles55@yahoo.com", "Kent", "Skiles", "Armenia", "(553) 228-0051" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2035,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Fordton", "EE44580", 1, "G249889", new DateTime(1976, 6, 8, 0, 0, 0, 0, DateTimeKind.Local), "Brandi.Schaefer99@yahoo.com", "Brandi", "Schaefer", "Virgin Islands, British", "1-352-702-9700 x742", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2036,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Mohammadburgh", "EE9385", "G95973", new DateTime(1997, 3, 19, 0, 0, 0, 0, DateTimeKind.Local), "Miriam_Jerde@hotmail.com", "Miriam", "Jerde", "Congo", "809.819.7036" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2037,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Kristofferfort", "EE16072", 3, "G75361", new DateTime(1961, 8, 30, 0, 0, 0, 0, DateTimeKind.Local), "Brent_Murazik@yahoo.com", "Brent", "Murazik", "Guatemala", "1-822-305-5468 x7125" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2038,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Langworthtown", "EE31315", "G575723", new DateTime(1965, 10, 13, 0, 0, 0, 0, DateTimeKind.Local), "Greg1@hotmail.com", "Greg", "Gutkowski", "Maldives", "930-538-7707 x70817", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2039,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Leslie", "EE37096", 1, "G435383", new DateTime(1954, 6, 26, 0, 0, 0, 0, DateTimeKind.Local), "Kyle.Paucek98@gmail.com", "Kyle", "Paucek", "Albania", "1-649-474-9719" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2040,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Bulahshire", "EE15478", 2, "G218534", new DateTime(1952, 12, 20, 0, 0, 0, 0, DateTimeKind.Local), "John15@gmail.com", "John", "Pagac", "Brazil", "1-824-825-6669 x3410", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2041,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lake Joelle", "EE59385", 3, "G95974", new DateTime(1978, 12, 20, 0, 0, 0, 0, DateTimeKind.Local), "Georgia53@yahoo.com", "Georgia", "Cruickshank", "Turks and Caicos Islands", "891-782-6952", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2042,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Alannabury", "EE45582", 4, "G308838", new DateTime(1995, 4, 16, 0, 0, 0, 0, DateTimeKind.Local), "Erik66@gmail.com", "Erik", "Bogan", "Namibia", "219.520.3668 x667", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2043,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Cordellhaven", "EE40285", 2, "G186178", new DateTime(1967, 5, 30, 0, 0, 0, 0, DateTimeKind.Local), "Florence_Frami28@hotmail.com", "Florence", "Frami", "Albania", "(865) 691-9233" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2044,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "North Lamont", "EE47447", "G308450", new DateTime(1998, 4, 10, 0, 0, 0, 0, DateTimeKind.Local), "Maurice.Nitzsche@gmail.com", "Maurice", "Nitzsche", "Falkland Islands (Malvinas)", "321.776.0503" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2045,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Jeromychester", "EE51398", 2, "G24004", new DateTime(1969, 11, 6, 0, 0, 0, 0, DateTimeKind.Local), "Katrina.Bashirian@hotmail.com", "Katrina", "Bashirian", "Saint Pierre and Miquelon", "1-423-330-9698" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2046,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Boscoburgh", "EE2972", "G152093", new DateTime(1995, 7, 22, 0, 0, 0, 0, DateTimeKind.Local), "Irvin_Kuphal18@yahoo.com", "Irvin", "Kuphal", "Guinea-Bissau", "1-614-646-6858 x978" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2047,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Wittingborough", "EE58793", "G116267", new DateTime(1971, 9, 10, 0, 0, 0, 0, DateTimeKind.Local), "Merle40@hotmail.com", "Merle", "Mante", "Syrian Arab Republic", "675-236-6428 x973", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2048,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Beckerton", "EE8008", 2, "G388489", new DateTime(1987, 3, 28, 0, 0, 0, 0, DateTimeKind.Local), "Alison_Parisian58@yahoo.com", "Alison", "Parisian", "Rwanda", "1-905-511-2217 x98710", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2049,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Jaydenmouth", "EE36039", "G384858", new DateTime(1984, 8, 3, 0, 0, 0, 0, DateTimeKind.Local), "Rex_Sawayn@hotmail.com", "Rex", "Sawayn", "Botswana", "231-296-7747 x53849", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2050,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Santos", "EE28953", 4, "G103623", new DateTime(1984, 6, 18, 0, 0, 0, 0, DateTimeKind.Local), "Marcus.Grant@hotmail.com", "Marcus", "Grant", "Croatia", "1-574-660-4080", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2051,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Keeblerport", "EE38360", "G32540", new DateTime(1966, 6, 23, 0, 0, 0, 0, DateTimeKind.Local), "Orville_Rutherford@yahoo.com", "Orville", "Rutherford", "Sierra Leone", "596.816.6962 x65046" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2052,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Quinn", "EE18578", "G223915", new DateTime(1961, 7, 11, 0, 0, 0, 0, DateTimeKind.Local), "Joy72@yahoo.com", "Joy", "Lesch", "Sierra Leone", "374.388.3287 x2231", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2053,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Stanleyborough", "EE50571", "G563970", new DateTime(1953, 12, 22, 0, 0, 0, 0, DateTimeKind.Local), "Elena90@gmail.com", "Elena", "Heathcote", "Costa Rica", "339.225.0258" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2054,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Fredericland", "EE51210", 1, "G280598", new DateTime(1990, 3, 30, 0, 0, 0, 0, DateTimeKind.Local), "Archie99@hotmail.com", "Archie", "Erdman", "Hungary", "(221) 241-7948 x776" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2055,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Christopheview", "EE36147", 1, "G439881", new DateTime(1963, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), "Keith_Ernser@hotmail.com", "Keith", "Ernser", "Russian Federation", "1-621-741-6398" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2056,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Walkermouth", "EE10003", 3, "G270940", new DateTime(1964, 9, 26, 0, 0, 0, 0, DateTimeKind.Local), "Dianna_Marks3@hotmail.com", "Dianna", "Marks", "Burkina Faso", "(335) 651-5049" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2057,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Antoinette", "EE38390", 3, "G25978", new DateTime(1958, 1, 4, 0, 0, 0, 0, DateTimeKind.Local), "Sylvia_Reichel@yahoo.com", "Sylvia", "Reichel", "Ecuador", "(214) 851-0269 x45327", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2058,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lake Theresamouth", "EE44521", "G228201", new DateTime(1961, 6, 18, 0, 0, 0, 0, DateTimeKind.Local), "Angelica_Swift38@gmail.com", "Angelica", "Swift", "India", "963-898-0296 x486", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2059,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Oswald", "EE46917", 3, "G343111", new DateTime(1962, 9, 24, 0, 0, 0, 0, DateTimeKind.Local), "Wesley.McLaughlin@gmail.com", "Wesley", "McLaughlin", "Grenada", "(350) 637-3035" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2060,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Shanellebury", "EE54258", 4, "G595652", new DateTime(1968, 9, 30, 0, 0, 0, 0, DateTimeKind.Local), "Jackie.Pagac@yahoo.com", "Jackie", "Pagac", "Malta", "1-945-761-0045", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2061,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Adeleborough", "EE14617", 3, "G286128", new DateTime(1994, 6, 28, 0, 0, 0, 0, DateTimeKind.Local), "Sonia59@yahoo.com", "Sonia", "Upton", "French Polynesia", "702-917-3125", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2062,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "East Jarrellshire", "EE34591", "G292762", new DateTime(1957, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), "Henry_Walsh25@hotmail.com", "Henry", "Walsh", "Turkey", "597-644-4788 x5030" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2063,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Gaylordbury", "EE39317", 2, "G196074", new DateTime(1955, 9, 26, 0, 0, 0, 0, DateTimeKind.Local), "Jeannie.Bogan@yahoo.com", "Jeannie", "Bogan", "Taiwan", "634-424-1629 x209" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2064,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "East Jamaalside", "EE36371", 4, "G295384", new DateTime(1983, 6, 17, 0, 0, 0, 0, DateTimeKind.Local), "Alejandro.Kovacek34@yahoo.com", "Alejandro", "Kovacek", "Moldova", "(392) 492-2860" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2065,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Deshawnberg", "EE23331", 3, "G559082", new DateTime(1986, 7, 16, 0, 0, 0, 0, DateTimeKind.Local), "Jose_Marvin@gmail.com", "Jose", "Marvin", "Mongolia", "(836) 825-5777 x26987", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2066,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Myriam", "EE14817", "G284614", new DateTime(1981, 6, 23, 0, 0, 0, 0, DateTimeKind.Local), "Stacy28@gmail.com", "Stacy", "Conn", "Mauritius", "1-761-421-0338", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2067,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Rustyfort", "EE39875", 4, "G96482", new DateTime(1979, 10, 17, 0, 0, 0, 0, DateTimeKind.Local), "Merle91@hotmail.com", "Merle", "Ryan", "Cameroon", "959.367.8931 x446", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2068,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Kole", "EE38053", 3, "G195439", new DateTime(1992, 7, 26, 0, 0, 0, 0, DateTimeKind.Local), "Gwen_Gibson@gmail.com", "Gwen", "Gibson", "Malawi", "1-965-985-6869 x428", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2069,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Gwen", "EE32916", 4, "G318322", new DateTime(1993, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), "Floyd37@yahoo.com", "Floyd", "Brown", "Guam", "465-430-1056 x710", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2070,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Harberport", "EE24623", 1, "G537391", new DateTime(1963, 11, 17, 0, 0, 0, 0, DateTimeKind.Local), "Erma73@hotmail.com", "Erma", "Kuhlman", "Chad", "385-711-1310 x012", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2071,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Kathleenton", "EE28050", 3, "G75441", new DateTime(1960, 12, 21, 0, 0, 0, 0, DateTimeKind.Local), "Darrell.Predovic@yahoo.com", "Darrell", "Predovic", "Slovakia (Slovak Republic)", "851.882.0132 x8364" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2072,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Marquesview", "EE29795", "G27936", new DateTime(1966, 8, 30, 0, 0, 0, 0, DateTimeKind.Local), "Beverly_Mueller@gmail.com", "Beverly", "Mueller", "Seychelles", "1-912-868-0246 x95729" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2073,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Torpmouth", "EE41119", 3, "G285440", new DateTime(1980, 9, 10, 0, 0, 0, 0, DateTimeKind.Local), "Brent_Mann60@yahoo.com", "Brent", "Mann", "Algeria", "1-493-438-7160 x51207", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2074,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "New Josue", "EE9617", 3, "G518748", new DateTime(1979, 4, 26, 0, 0, 0, 0, DateTimeKind.Local), "Bryan72@hotmail.com", "Bryan", "Gusikowski", "Ghana", "1-930-324-0128 x162", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2075,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Breanne", "EE51121", 3, "G328617", new DateTime(1964, 6, 6, 0, 0, 0, 0, DateTimeKind.Local), "Abraham.Huel@yahoo.com", "Abraham", "Huel", "Mauritania", "1-835-963-4393 x85723" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2076,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lake Lelahville", "EE56033", "G409556", new DateTime(1988, 4, 2, 0, 0, 0, 0, DateTimeKind.Local), "Rodolfo_Smith@gmail.com", "Rodolfo", "Smith", "Cape Verde", "(948) 812-1250 x728", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2077,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Port Maximilianmouth", "EE21393", "G95541", new DateTime(1966, 9, 26, 0, 0, 0, 0, DateTimeKind.Local), "Roderick_Harris95@hotmail.com", "Roderick", "Harris", "Oman", "300-487-9235 x9936" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2078,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Hilllville", "EE34890", 2, "G434796", new DateTime(1970, 5, 6, 0, 0, 0, 0, DateTimeKind.Local), "Gustavo_Lemke@yahoo.com", "Gustavo", "Lemke", "Holy See (Vatican City State)", "(817) 354-9157 x0682" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2079,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Astrid", "EE11713", 1, "G504646", new DateTime(1963, 5, 1, 0, 0, 0, 0, DateTimeKind.Local), "Margie_Kertzmann@gmail.com", "Margie", "Kertzmann", "Samoa", "974-767-7837 x580", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2080,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Geovannifort", "EE40557", 1, "G315251", new DateTime(1990, 9, 8, 0, 0, 0, 0, DateTimeKind.Local), "Denise17@hotmail.com", "Denise", "Bartoletti", "Senegal", "1-239-684-0959" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2081,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Georgiannahaven", "EE2138", 4, "G33150", new DateTime(1975, 4, 19, 0, 0, 0, 0, DateTimeKind.Local), "Mabel17@yahoo.com", "Mabel", "Metz", "United Arab Emirates", "1-200-877-8211" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2082,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Port Gertrude", "EE58467", "G192915", new DateTime(1970, 1, 14, 0, 0, 0, 0, DateTimeKind.Local), "Laurence_Gleason61@yahoo.com", "Laurence", "Gleason", "San Marino", "1-983-604-8621 x744" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2083,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Wardshire", "EE3999", 1, "G500947", new DateTime(1989, 6, 27, 0, 0, 0, 0, DateTimeKind.Local), "Gordon64@hotmail.com", "Gordon", "Mante", "Singapore", "589-708-6836" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2084,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Breitenbergshire", "EE55890", "G164178", new DateTime(1971, 10, 29, 0, 0, 0, 0, DateTimeKind.Local), "Rose.Cormier85@gmail.com", "Rose", "Cormier", "Palestinian Territory", "(295) 837-2935", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2085,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Percivalmouth", "EE55017", 1, "G588241", new DateTime(1951, 9, 24, 0, 0, 0, 0, DateTimeKind.Local), "Holly4@yahoo.com", "Holly", "Jacobson", "Bhutan", "432.373.1487 x638", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2086,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Eliseohaven", "EE15216", 4, "G305834", new DateTime(1984, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), "Leland_Rau62@yahoo.com", "Leland", "Rau", "Belgium", "697-309-7058 x397", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2087,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Klingfort", "EE49509", 1, "G539139", new DateTime(1991, 9, 16, 0, 0, 0, 0, DateTimeKind.Local), "Nathaniel2@yahoo.com", "Nathaniel", "Tremblay", "Turkey", "1-368-999-2291" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2088,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Laurinehaven", "EE45085", 4, "G105223", new DateTime(1992, 11, 3, 0, 0, 0, 0, DateTimeKind.Local), "Simon.Shanahan38@gmail.com", "Simon", "Shanahan", "Solomon Islands", "(404) 720-1709", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2089,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Reilly", "EE12944", 4, "G123086", new DateTime(1998, 9, 14, 0, 0, 0, 0, DateTimeKind.Local), "Lucia.Emard29@yahoo.com", "Lucia", "Emard", "Cyprus", "(965) 351-8790 x8508", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2090,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Crystelview", "EE35698", 4, "G547889", new DateTime(1952, 9, 26, 0, 0, 0, 0, DateTimeKind.Local), "Leslie54@yahoo.com", "Leslie", "Yost", "Brazil", "774.682.0580 x50047", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2091,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lake Sofia", "EE21123", "G307177", new DateTime(1956, 8, 1, 0, 0, 0, 0, DateTimeKind.Local), "Ellen93@hotmail.com", "Ellen", "Herman", "Guernsey", "627.388.1592 x752", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2092,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Considineberg", "EE9972", 3, "G590506", new DateTime(1953, 12, 10, 0, 0, 0, 0, DateTimeKind.Local), "Dixie_Rutherford81@hotmail.com", "Dixie", "Rutherford", "Guadeloupe", "746.537.7592 x9302" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2093,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Ondrickaton", "EE41890", 4, "G312395", new DateTime(1965, 1, 30, 0, 0, 0, 0, DateTimeKind.Local), "Barry_Tillman@gmail.com", "Barry", "Tillman", "Poland", "409-379-1851 x52139", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2094,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Adolphusborough", "EE23584", "G13981", new DateTime(1988, 1, 8, 0, 0, 0, 0, DateTimeKind.Local), "Elsa_Kessler@hotmail.com", "Elsa", "Kessler", "Burundi", "878.516.4751 x81131", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2095,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North William", "EE12704", 1, "G492936", new DateTime(1965, 2, 15, 0, 0, 0, 0, DateTimeKind.Local), "Andre.Ortiz@yahoo.com", "Andre", "Ortiz", "Monaco", "(237) 637-9260", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2096,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Robertoburgh", "EE34307", 1, "G69948", new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), "Nora.Veum27@gmail.com", "Nora", "Veum", "Azerbaijan", "461-627-8680", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2097,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Zemlakburgh", "EE59584", 1, "G572683", new DateTime(1978, 7, 19, 0, 0, 0, 0, DateTimeKind.Local), "Paul_Wolff72@hotmail.com", "Paul", "Wolff", "Argentina", "266-231-0889" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2098,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "New Wyman", "EE52129", 1, "G158001", new DateTime(1997, 2, 3, 0, 0, 0, 0, DateTimeKind.Local), "Stewart80@hotmail.com", "Stewart", "Auer", "Uganda", "1-881-252-5707 x95928", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2099,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Jorgeland", "EE1612", 2, "G83738", new DateTime(1952, 12, 10, 0, 0, 0, 0, DateTimeKind.Local), "Sheila.Beatty@hotmail.com", "Sheila", "Beatty", "Morocco", "247.468.1639" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2100,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Cheyannehaven", "EE27114", 4, "G82866", new DateTime(1964, 4, 6, 0, 0, 0, 0, DateTimeKind.Local), "Ginger_Lubowitz@yahoo.com", "Ginger", "Lubowitz", "Spain", "713.376.2687 x2100", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2101,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Johannamouth", "EE43858", 1, "G509118", new DateTime(1999, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), "Cathy.Marvin57@hotmail.com", "Cathy", "Marvin", "Lao People's Democratic Republic", "985-890-6620 x83598", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2102,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Farrellburgh", "EE26107", 1, "G102487", new DateTime(1974, 10, 22, 0, 0, 0, 0, DateTimeKind.Local), "Cesar45@gmail.com", "Cesar", "Strosin", "Norway", "385-628-0714" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2103,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "lastname", "natio", "phone" },
                values: new object[] { "Maddisonburgh", "EE31296", 3, "G370348", new DateTime(1968, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), "Phillip52@yahoo.com", "Schumm", "Israel", "(472) 501-7704 x3299" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2104,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Johnpaul", "EE40915", 4, "G509886", new DateTime(1988, 5, 5, 0, 0, 0, 0, DateTimeKind.Local), "Bert.Torphy@gmail.com", "Bert", "Torphy", "Montenegro", "882.427.9094", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2105,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Aureliafort", "EE34237", 4, "G410371", new DateTime(1988, 7, 10, 0, 0, 0, 0, DateTimeKind.Local), "Bill.Pollich@hotmail.com", "Bill", "Pollich", "Puerto Rico", "854.797.9749 x90251", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2106,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lake Jamesonfurt", "EE31975", 3, "G204874", new DateTime(1956, 2, 14, 0, 0, 0, 0, DateTimeKind.Local), "Lydia72@gmail.com", "Lydia", "Wunsch", "Pakistan", "583-468-7414 x00253", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2107,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "North Alek", "EE31604", 2, "G368278", new DateTime(1952, 2, 15, 0, 0, 0, 0, DateTimeKind.Local), "Esther.Gleason0@yahoo.com", "Esther", "Gleason", "Niger", "747.466.2089" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2108,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Ahmad", "EE47323", "G227346", new DateTime(1990, 4, 2, 0, 0, 0, 0, DateTimeKind.Local), "Marlene_Zemlak@yahoo.com", "Marlene", "Zemlak", "Mauritius", "(893) 526-1711", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2109,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Breana", "EE55360", 2, "G245768", new DateTime(1951, 9, 4, 0, 0, 0, 0, DateTimeKind.Local), "Bert_Heathcote77@gmail.com", "Bert", "Heathcote", "Cuba", "1-361-499-1890 x4371", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2110,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Derekfurt", "EE39417", "G189839", new DateTime(1961, 1, 20, 0, 0, 0, 0, DateTimeKind.Local), "Antonia_Leffler@hotmail.com", "Antonia", "Leffler", "Turkmenistan", "481.870.2241 x8131", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2111,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Nannieshire", "EE11640", 1, "G292611", new DateTime(1981, 12, 13, 0, 0, 0, 0, DateTimeKind.Local), "Maurice44@yahoo.com", "Maurice", "Treutel", "Maldives", "986.924.8268 x93079" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2112,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Alffort", "EE54564", 2, "G115624", new DateTime(1959, 12, 5, 0, 0, 0, 0, DateTimeKind.Local), "Marion_Bogisich44@gmail.com", "Marion", "Bogisich", "Uzbekistan", "1-690-549-8298 x829" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2113,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Roobmouth", "EE21156", 1, "G479741", new DateTime(1985, 4, 6, 0, 0, 0, 0, DateTimeKind.Local), "Garrett.Wunsch86@yahoo.com", "Garrett", "Wunsch", "Holy See (Vatican City State)", "249.742.2799 x0387", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2114,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Reingerview", "EE30637", 2, "G314844", new DateTime(1975, 3, 10, 0, 0, 0, 0, DateTimeKind.Local), "Robert88@gmail.com", "Robert", "Prohaska", "Mongolia", "(538) 346-1123 x5283", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2115,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Gerholdhaven", "EE55401", 3, "G25558", new DateTime(1976, 4, 18, 0, 0, 0, 0, DateTimeKind.Local), "Roxanne_Abbott71@yahoo.com", "Roxanne", "Abbott", "Lithuania", "(570) 800-5960" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2116,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Tessieport", "EE28496", 4, "G214341", new DateTime(1987, 12, 4, 0, 0, 0, 0, DateTimeKind.Local), "Meghan.Balistreri@yahoo.com", "Meghan", "Balistreri", "Malawi", "1-590-676-9239 x583", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2117,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Cieloburgh", "EE1008", 2, "G480501", new DateTime(1953, 6, 1, 0, 0, 0, 0, DateTimeKind.Local), "Shawna77@gmail.com", "Shawna", "Graham", "Vietnam", "649-214-1326", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2118,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Heidenreichmouth", "EE2934", 1, "G82256", new DateTime(2000, 3, 13, 0, 0, 0, 0, DateTimeKind.Local), "Marsha60@hotmail.com", "Marsha", "Jast", "Bhutan", "364-389-0006 x972" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2119,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Erinshire", "EE46615", 1, "G243930", new DateTime(1976, 9, 25, 0, 0, 0, 0, DateTimeKind.Local), "Lamar.Conroy@hotmail.com", "Lamar", "Conroy", "Cocos (Keeling) Islands", "(437) 406-7547 x2687", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2120,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "North Yadiraside", "EE3323", 4, "G23309", new DateTime(1988, 1, 27, 0, 0, 0, 0, DateTimeKind.Local), "Patty.Kassulke@gmail.com", "Patty", "Kassulke", "South Georgia and the South Sandwich Islands", "701.897.1026" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2121,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Rohanhaven", "EE20975", 3, "G342466", new DateTime(1983, 12, 20, 0, 0, 0, 0, DateTimeKind.Local), "Ross.Lang@gmail.com", "Ross", "Lang", "Gabon", "(206) 918-3427 x27080", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2122,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Kalebshire", "EE12372", 4, "G101103", new DateTime(1966, 9, 22, 0, 0, 0, 0, DateTimeKind.Local), "Nora.Weissnat9@yahoo.com", "Nora", "Weissnat", "Iran", "950.763.9305" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2123,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Naderbury", "EE10107", 4, "G84886", new DateTime(1986, 5, 1, 0, 0, 0, 0, DateTimeKind.Local), "Elisa73@yahoo.com", "Elisa", "Koelpin", "Gibraltar", "850.751.0308 x3400" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2124,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Braxtonberg", "EE43198", 2, "G307055", new DateTime(1956, 11, 25, 0, 0, 0, 0, DateTimeKind.Local), "Wilma_Satterfield84@yahoo.com", "Wilma", "Satterfield", "Puerto Rico", "630.949.1174", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2125,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "New Uniquebury", "EE30991", 2, "G353053", new DateTime(1991, 1, 17, 0, 0, 0, 0, DateTimeKind.Local), "Gordon_McGlynn@yahoo.com", "Gordon", "McGlynn", "Zimbabwe", "280-561-2213 x619", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2126,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Rickey", "EE22948", "G537043", new DateTime(1982, 1, 25, 0, 0, 0, 0, DateTimeKind.Local), "Megan5@gmail.com", "Megan", "Bartoletti", "French Guiana", "(993) 287-2089 x4436" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2127,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Langworthchester", "EE57505", 1, "G58543", new DateTime(1987, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), "Jaime35@gmail.com", "Jaime", "VonRueden", "Kuwait", "(910) 612-5829" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2128,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Port Ivyfort", "EE16048", 3, "G577501", new DateTime(1994, 8, 4, 0, 0, 0, 0, DateTimeKind.Local), "Wayne_Stokes75@gmail.com", "Wayne", "Stokes", "Finland", "(667) 286-3808 x0736" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2129,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Christianamouth", "EE53729", 3, "G133181", new DateTime(1980, 4, 6, 0, 0, 0, 0, DateTimeKind.Local), "Jean81@yahoo.com", "Jean", "Waelchi", "South Georgia and the South Sandwich Islands", "665-293-5580 x20655", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2130,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Osinskiland", "EE17683", 1, "G106842", new DateTime(1992, 4, 22, 0, 0, 0, 0, DateTimeKind.Local), "Ana.Kreiger55@yahoo.com", "Ana", "Kreiger", "Trinidad and Tobago", "(593) 471-9990", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2131,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Deckowmouth", "EE207", 2, "G389533", new DateTime(1993, 10, 19, 0, 0, 0, 0, DateTimeKind.Local), "Enrique.Hansen@hotmail.com", "Enrique", "Hansen", "France", "1-875-740-6765 x177" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2132,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Ursulaberg", "EE45794", "G545843", new DateTime(1998, 1, 11, 0, 0, 0, 0, DateTimeKind.Local), "Sadie.Kuhic69@yahoo.com", "Sadie", "Kuhic", "Senegal", "1-536-480-4013", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2133,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Carley", "EE18320", "G151777", new DateTime(1992, 4, 29, 0, 0, 0, 0, DateTimeKind.Local), "Dean22@yahoo.com", "Dean", "Kihn", "Bouvet Island (Bouvetoya)", "1-287-496-4492", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2134,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Eloisaburgh", "EE19983", "G256422", new DateTime(1952, 12, 11, 0, 0, 0, 0, DateTimeKind.Local), "Douglas_Wisoky@hotmail.com", "Douglas", "Wisoky", "Palau", "(591) 836-1027 x422", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2135,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Pedro", "EE724", 2, "G318968", new DateTime(1987, 2, 3, 0, 0, 0, 0, DateTimeKind.Local), "Andrew_Heidenreich27@gmail.com", "Andrew", "Heidenreich", "Angola", "840.518.3395 x36199" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2136,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Hilarioborough", "EE23632", 3, "G301569", new DateTime(1955, 12, 10, 0, 0, 0, 0, DateTimeKind.Local), "Florence_Hettinger57@yahoo.com", "Florence", "Hettinger", "Georgia", "1-668-816-3086 x44893", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2137,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Darienmouth", "EE55502", 3, "G12426", new DateTime(1967, 1, 12, 0, 0, 0, 0, DateTimeKind.Local), "Olivia41@yahoo.com", "Olivia", "Nienow", "Haiti", "572.687.7456 x10737" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2138,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Hamillside", "EE44398", 3, "G54308", new DateTime(1957, 8, 13, 0, 0, 0, 0, DateTimeKind.Local), "Marjorie_Bruen@hotmail.com", "Marjorie", "Bruen", "Macedonia", "292-762-9578 x2843", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2139,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Garthfurt", "EE26244", "G309990", new DateTime(1966, 3, 8, 0, 0, 0, 0, DateTimeKind.Local), "Inez_Ernser53@hotmail.com", "Inez", "Ernser", "Denmark", "1-961-698-0696 x919", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2140,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Jovany", "EE11501", "G327685", new DateTime(2000, 3, 15, 0, 0, 0, 0, DateTimeKind.Local), "Rebecca25@gmail.com", "Rebecca", "Dach", "Estonia", "251-835-1632 x0073" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2141,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Vivientown", "EE45467", 3, "G274605", new DateTime(1957, 1, 3, 0, 0, 0, 0, DateTimeKind.Local), "Eloise4@gmail.com", "Eloise", "Pouros", "Holy See (Vatican City State)", "1-240-793-8388 x248", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2142,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Boganmouth", "EE7490", "G566522", new DateTime(1981, 9, 27, 0, 0, 0, 0, DateTimeKind.Local), "Cedric.Hettinger14@yahoo.com", "Cedric", "Hettinger", "Democratic People's Republic of Korea", "814-237-6814", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2143,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Rowenastad", "EE43787", "G283771", new DateTime(1955, 4, 29, 0, 0, 0, 0, DateTimeKind.Local), "Rafael67@gmail.com", "Rafael", "Marquardt", "Algeria", "(972) 246-8651 x825" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2144,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Bodeborough", "EE55386", 4, "G411774", new DateTime(1998, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), "Jeffery.Hegmann@gmail.com", "Jeffery", "Hegmann", "Falkland Islands (Malvinas)", "517.378.2676 x55360", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2145,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Turcotteberg", "EE10038", "G49074", new DateTime(1995, 12, 11, 0, 0, 0, 0, DateTimeKind.Local), "Daryl.Block75@yahoo.com", "Daryl", "Block", "Monaco", "(605) 376-5560 x22592", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2146,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Boehmbury", "EE8073", 2, "G359540", new DateTime(1980, 8, 20, 0, 0, 0, 0, DateTimeKind.Local), "Mercedes0@hotmail.com", "Mercedes", "Sipes", "Armenia", "(766) 995-5737 x033", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2147,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Royce", "EE45519", 3, "G510759", new DateTime(1954, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), "Denise32@hotmail.com", "Denise", "Morissette", "Gambia", "774.702.5292 x329", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2148,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Kutchshire", "EE27883", 4, "G439260", new DateTime(1958, 12, 4, 0, 0, 0, 0, DateTimeKind.Local), "Jeremy.McClure@hotmail.com", "Jeremy", "McClure", "Pitcairn Islands", "540.830.6619 x57670", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2149,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Williamsonbury", "EE35574", 4, "G499620", new DateTime(1967, 12, 28, 0, 0, 0, 0, DateTimeKind.Local), "Carolyn_Hoppe75@yahoo.com", "Carolyn", "Hoppe", "Turkmenistan", "829-472-3533 x00289", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2150,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Maximillianport", "EE2166", 2, "G274541", new DateTime(1968, 8, 25, 0, 0, 0, 0, DateTimeKind.Local), "Oliver_Terry@gmail.com", "Oliver", "Terry", "Falkland Islands (Malvinas)", "833-531-4211 x99906" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2151,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Colton", "EE9910", 2, "G258582", new DateTime(1957, 2, 16, 0, 0, 0, 0, DateTimeKind.Local), "Willard.Lockman@hotmail.com", "Willard", "Lockman", "Belgium", "302.540.4051 x277" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2152,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Larissa", "EE22005", 3, "G530045", new DateTime(1963, 10, 23, 0, 0, 0, 0, DateTimeKind.Local), "Terri83@hotmail.com", "Terri", "Donnelly", "Bermuda", "(978) 729-9026", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2153,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Wymanmouth", "EE55520", 4, "G510279", new DateTime(1992, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), "Theodore28@hotmail.com", "Theodore", "Barton", "Brazil", "629.848.1395 x9894", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2154,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Gianni", "EE170", 4, "G307034", new DateTime(1959, 4, 6, 0, 0, 0, 0, DateTimeKind.Local), "Scott64@hotmail.com", "Scott", "Aufderhar", "Afghanistan", "(515) 872-4893 x229" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2155,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Kennashire", "EE15591", "G70991", new DateTime(1965, 9, 20, 0, 0, 0, 0, DateTimeKind.Local), "Johanna_McCullough@hotmail.com", "Johanna", "McCullough", "Kyrgyz Republic", "656.761.5507 x4136" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2156,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Noraton", "EE49079", "G419608", new DateTime(1990, 3, 16, 0, 0, 0, 0, DateTimeKind.Local), "Lester_Nitzsche@hotmail.com", "Lester", "Nitzsche", "Djibouti", "1-903-527-3949" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2157,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Wilfredbury", "EE52492", 3, "G420653", new DateTime(1974, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), "Penny.Wolff41@yahoo.com", "Penny", "Wolff", "Fiji", "(853) 504-5209 x464", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2158,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Amiebury", "EE33845", 4, "G380076", new DateTime(1970, 1, 8, 0, 0, 0, 0, DateTimeKind.Local), "Eileen75@hotmail.com", "Eileen", "Gaylord", "Cuba", "1-451-344-8307 x862", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2159,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "East Mayabury", "EE32054", "G38291", new DateTime(1984, 11, 10, 0, 0, 0, 0, DateTimeKind.Local), "Traci3@hotmail.com", "Traci", "Will", "Monaco", "482.969.3974 x4324" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2160,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Ornberg", "EE12329", 4, "G163383", new DateTime(1951, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), "Caroline.Huels74@gmail.com", "Caroline", "Huels", "Virgin Islands, British", "253-796-3101 x8676", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2161,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Botsfordland", "EE7264", 2, "G164290", new DateTime(1986, 11, 22, 0, 0, 0, 0, DateTimeKind.Local), "Arlene30@gmail.com", "Arlene", "Schmidt", "Reunion", "1-262-738-9233 x5467", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2162,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Randallborough", "EE55971", 2, "G469582", new DateTime(1999, 3, 6, 0, 0, 0, 0, DateTimeKind.Local), "Roderick97@yahoo.com", "Roderick", "Mann", "Estonia", "(294) 274-1932", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2163,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Nikita", "EE48956", 1, "G299524", new DateTime(1971, 4, 21, 0, 0, 0, 0, DateTimeKind.Local), "Casey.Moen3@hotmail.com", "Casey", "Moen", "Hungary", "1-200-806-0137" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2164,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "North Furmanborough", "EE51307", 3, "G465587", new DateTime(1990, 1, 23, 0, 0, 0, 0, DateTimeKind.Local), "Lynda.Maggio23@hotmail.com", "Lynda", "Maggio", "Republic of Korea", "594-646-9749" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2165,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "North Hermann", "EE45546", 1, "G105098", new DateTime(1978, 9, 9, 0, 0, 0, 0, DateTimeKind.Local), "Paulette_Wiegand@yahoo.com", "Paulette", "Wiegand", "Morocco", "(749) 355-0427 x666" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2166,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Cadenshire", "EE29398", "G44745", new DateTime(1965, 3, 9, 0, 0, 0, 0, DateTimeKind.Local), "Raul_Nolan12@hotmail.com", "Raul", "Nolan", "Croatia", "219.252.3915" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2167,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "New Dock", "EE54062", "G408688", new DateTime(1974, 12, 31, 0, 0, 0, 0, DateTimeKind.Local), "Aaron.Wyman@hotmail.com", "Aaron", "Wyman", "Belize", "(350) 406-7745 x56047", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2168,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Nitzscheton", "EE55263", "G328447", new DateTime(1958, 10, 6, 0, 0, 0, 0, DateTimeKind.Local), "Guillermo17@gmail.com", "Guillermo", "Huel", "Democratic People's Republic of Korea", "(491) 949-5339 x61571" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2169,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "phone", "sexe" },
                values: new object[] { "North Deliatown", "EE59676", 2, "G213230", new DateTime(1966, 11, 6, 0, 0, 0, 0, DateTimeKind.Local), "Ernest_Bechtelar8@yahoo.com", "Ernest", "Bechtelar", "1-699-504-3458 x364", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2170,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Winfieldstad", "EE9642", 3, "G160321", new DateTime(1955, 1, 13, 0, 0, 0, 0, DateTimeKind.Local), "Pete.Leffler29@gmail.com", "Pete", "Leffler", "New Zealand", "1-476-470-0602", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2171,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Schadenland", "EE59137", 4, "G452374", new DateTime(1969, 1, 12, 0, 0, 0, 0, DateTimeKind.Local), "Albert_Greenfelder96@hotmail.com", "Albert", "Greenfelder", "Grenada", "796.689.2723", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2172,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Hintzfurt", "EE9281", 4, "G485615", new DateTime(1962, 1, 25, 0, 0, 0, 0, DateTimeKind.Local), "Edward.Kunde@hotmail.com", "Edward", "Kunde", "Belize", "542-525-7431" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2173,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Terryview", "EE41134", 1, "G375328", new DateTime(1984, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), "Thomas.Davis@gmail.com", "Thomas", "Davis", "Palestinian Territory", "523.864.5181", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2174,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Handtown", "EE2568", 4, "G356020", new DateTime(1969, 1, 12, 0, 0, 0, 0, DateTimeKind.Local), "Geraldine_Batz@yahoo.com", "Geraldine", "Batz", "Equatorial Guinea", "671-771-3283 x855", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2175,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Katelynstad", "EE6943", "G16545", new DateTime(1959, 2, 5, 0, 0, 0, 0, DateTimeKind.Local), "Nicholas_Hane0@yahoo.com", "Nicholas", "Hane", "Kazakhstan", "664-771-2229" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2176,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Elsaton", "EE38812", "G44062", new DateTime(1983, 5, 28, 0, 0, 0, 0, DateTimeKind.Local), "Maggie.Lang@hotmail.com", "Maggie", "Lang", "Libyan Arab Jamahiriya", "(495) 632-2256", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2177,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Huelmouth", "EE2068", "G589068", new DateTime(1995, 6, 22, 0, 0, 0, 0, DateTimeKind.Local), "Candice34@hotmail.com", "Candice", "Hermann", "Canada", "(390) 981-8088", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2178,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Edwin", "EE35666", 1, "G82059", new DateTime(1978, 10, 16, 0, 0, 0, 0, DateTimeKind.Local), "Nora.Bergnaum@yahoo.com", "Nora", "Bergnaum", "Colombia", "1-480-884-4929 x800" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2179,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Kianmouth", "EE33238", 4, "G293420", new DateTime(1962, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), "Brandon_Donnelly@yahoo.com", "Brandon", "Donnelly", "Syrian Arab Republic", "878-581-0135 x31024", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2180,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Connshire", "EE17904", 2, "G71946", new DateTime(1990, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), "Mildred_Hartmann@yahoo.com", "Mildred", "Hartmann", "Costa Rica", "904.401.8282 x9155", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2181,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Edwardview", "EE32209", 2, "G308902", new DateTime(1976, 2, 23, 0, 0, 0, 0, DateTimeKind.Local), "Desiree.Gottlieb72@gmail.com", "Desiree", "Gottlieb", "Puerto Rico", "799.805.1009" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2182,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Branditown", "EE32999", 2, "G518599", new DateTime(1970, 5, 12, 0, 0, 0, 0, DateTimeKind.Local), "Leona.Beer52@yahoo.com", "Leona", "Beer", "Burundi", "961-222-3408 x9642" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2183,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Port Charity", "EE25702", 4, "G394004", new DateTime(1976, 5, 8, 0, 0, 0, 0, DateTimeKind.Local), "Catherine_Gorczany92@hotmail.com", "Catherine", "Gorczany", "United States Minor Outlying Islands", "1-612-634-1619 x9381" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2184,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Maggioville", "EE24765", 4, "G48713", new DateTime(1965, 6, 8, 0, 0, 0, 0, DateTimeKind.Local), "Jody.Bergstrom55@gmail.com", "Jody", "Bergstrom", "Mayotte", "208-486-2246", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2185,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "East Theresia", "EE47245", 4, "G180529", new DateTime(1964, 10, 5, 0, 0, 0, 0, DateTimeKind.Local), "Fannie98@hotmail.com", "Fannie", "Keeling", "Faroe Islands", "1-636-588-6152 x45736" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2186,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Mortimerborough", "EE43578", "G93547", new DateTime(1960, 8, 1, 0, 0, 0, 0, DateTimeKind.Local), "Sean_Douglas@gmail.com", "Sean", "Douglas", "Cape Verde", "965.376.5812 x11721", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2187,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Hunterview", "EE36185", 2, "G57496", new DateTime(1961, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), "Priscilla_Cole@hotmail.com", "Priscilla", "Cole", "Gibraltar", "1-431-689-4613 x1324" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2188,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Ozellaland", "EE24758", 2, "G321682", new DateTime(1972, 11, 29, 0, 0, 0, 0, DateTimeKind.Local), "Rhonda_Gleason69@gmail.com", "Rhonda", "Gleason", "Chile", "835-245-0661 x5792" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2189,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Alleneborough", "EE47272", 3, "G528557", new DateTime(1996, 9, 3, 0, 0, 0, 0, DateTimeKind.Local), "Edwin47@hotmail.com", "Edwin", "Hoeger", "Spain", "1-328-300-4458 x30066" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2190,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Stacey", "EE44384", 3, "G255962", new DateTime(1951, 7, 31, 0, 0, 0, 0, DateTimeKind.Local), "Laurence.Gerlach@yahoo.com", "Laurence", "Gerlach", "Montenegro", "898.480.3317 x4844" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2191,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Jazmyneville", "EE25105", 4, "G135126", new DateTime(2000, 11, 20, 0, 0, 0, 0, DateTimeKind.Local), "Rachel86@yahoo.com", "Rachel", "Hickle", "Slovenia", "(248) 272-6720" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2192,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Harry", "EE47132", 2, "G383018", new DateTime(1951, 12, 20, 0, 0, 0, 0, DateTimeKind.Local), "Kevin_Bradtke@yahoo.com", "Kevin", "Bradtke", "Poland", "1-360-620-7709 x481", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2193,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Lisamouth", "EE42177", 3, "G534433", new DateTime(1992, 10, 28, 0, 0, 0, 0, DateTimeKind.Local), "Ian0@gmail.com", "Ian", "Conroy", "Egypt", "740-834-7177 x5327", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2194,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "New Alessia", "EE15621", 3, "G403908", new DateTime(1954, 7, 28, 0, 0, 0, 0, DateTimeKind.Local), "Misty.Lang@hotmail.com", "Misty", "Lang", "Jordan", "989.773.8853", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2195,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Russelhaven", "EE56820", 2, "G198287", new DateTime(1956, 6, 8, 0, 0, 0, 0, DateTimeKind.Local), "Kathleen_Murazik@yahoo.com", "Kathleen", "Murazik", "Georgia", "223.225.4264 x9542", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2196,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Yasminefort", "EE27556", 1, "G488107", new DateTime(1991, 5, 6, 0, 0, 0, 0, DateTimeKind.Local), "Vanessa_Emard@yahoo.com", "Vanessa", "Emard", "New Zealand", "1-632-475-7203 x6980" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2197,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Dinoberg", "EE24933", 3, "G528096", new DateTime(1955, 11, 14, 0, 0, 0, 0, DateTimeKind.Local), "Wilson60@hotmail.com", "Wilson", "Collier", "Serbia", "(728) 305-6408 x9743", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2198,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Hodkiewiczbury", "EE16442", 4, "G415216", new DateTime(1998, 3, 12, 0, 0, 0, 0, DateTimeKind.Local), "Bennie2@hotmail.com", "Bennie", "Jenkins", "Uruguay", "1-638-250-4734 x269", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2199,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lambertside", "EE57201", 1, "G174189", new DateTime(1963, 8, 27, 0, 0, 0, 0, DateTimeKind.Local), "Joann63@gmail.com", "Joann", "Wehner", "Denmark", "688.660.7082 x363" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2200,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Croninport", "EE39115", 3, "G518532", new DateTime(1959, 7, 13, 0, 0, 0, 0, DateTimeKind.Local), "Ricky.Lowe50@yahoo.com", "Ricky", "Lowe", "Gambia", "647.368.6660 x0233" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2201,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Weissnatshire", "EE18421", "G592967", new DateTime(1994, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), "Jerry.Kessler@yahoo.com", "Jerry", "Kessler", "Bahrain", "710-671-0683", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2202,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Schusterberg", "EE3986", 1, "G508332", new DateTime(1987, 5, 30, 0, 0, 0, 0, DateTimeKind.Local), "Marguerite.Doyle@hotmail.com", "Marguerite", "Doyle", "Gabon", "1-837-690-4335" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2203,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Wandaton", "EE1037", 2, "G418744", new DateTime(1965, 6, 2, 0, 0, 0, 0, DateTimeKind.Local), "Myrtle_Douglas69@yahoo.com", "Myrtle", "Douglas", "Cape Verde", "295-413-9861", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2204,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Letitiaborough", "EE13954", 2, "G485751", new DateTime(1963, 4, 22, 0, 0, 0, 0, DateTimeKind.Local), "Sara.Schmidt@gmail.com", "Sara", "Schmidt", "Samoa", "(457) 233-6426 x893" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2205,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Hirtheburgh", "EE49843", "G162980", new DateTime(1994, 9, 15, 0, 0, 0, 0, DateTimeKind.Local), "Darlene.White67@hotmail.com", "Darlene", "White", "Tuvalu", "883.714.0036" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2206,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Koeppbury", "EE20364", "G219311", new DateTime(1956, 10, 14, 0, 0, 0, 0, DateTimeKind.Local), "Charlene_Kunde87@hotmail.com", "Charlene", "Kunde", "Cuba", "1-708-313-2322", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2207,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Haydenberg", "EE47727", "G567657", new DateTime(1952, 6, 1, 0, 0, 0, 0, DateTimeKind.Local), "Thelma_Sporer@gmail.com", "Thelma", "Sporer", "Netherlands Antilles", "(842) 284-0477 x8913", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2208,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Jacobiville", "EE28995", 3, "G357616", new DateTime(1977, 2, 18, 0, 0, 0, 0, DateTimeKind.Local), "Misty53@yahoo.com", "Misty", "Lebsack", "Bahamas", "1-620-418-9268 x1090", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2209,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Gaylefort", "EE46385", 4, "G370045", new DateTime(1995, 10, 4, 0, 0, 0, 0, DateTimeKind.Local), "Luther.Watsica@hotmail.com", "Luther", "Watsica", "Saint Pierre and Miquelon", "(811) 238-1934 x612" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2210,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Brendanland", "EE10128", 3, "G358008", new DateTime(1987, 3, 11, 0, 0, 0, 0, DateTimeKind.Local), "Jerry_Greenholt34@yahoo.com", "Jerry", "Greenholt", "Turkmenistan", "1-479-892-9067", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2211,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lake Mason", "EE14764", 4, "G283941", new DateTime(1975, 12, 6, 0, 0, 0, 0, DateTimeKind.Local), "Corey.Herzog72@yahoo.com", "Corey", "Herzog", "Philippines", "(507) 430-0519 x608", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2212,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Keeley", "EE24242", 1, "G227895", new DateTime(1975, 5, 29, 0, 0, 0, 0, DateTimeKind.Local), "Eva58@yahoo.com", "Eva", "Langworth", "Niue", "295-621-5946", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2213,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Sandrineshire", "EE47927", "G410654", new DateTime(1968, 11, 6, 0, 0, 0, 0, DateTimeKind.Local), "Howard73@yahoo.com", "Howard", "Dickinson", "American Samoa", "(450) 893-1380 x79066", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2214,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Austentown", "EE12647", "G324604", new DateTime(1990, 3, 16, 0, 0, 0, 0, DateTimeKind.Local), "Aaron.Schuppe@gmail.com", "Aaron", "Schuppe", "Bangladesh", "376.705.5154 x74211", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2215,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Patiencebury", "EE34444", 2, "G81550", new DateTime(1977, 3, 21, 0, 0, 0, 0, DateTimeKind.Local), "Angelina.Dare@yahoo.com", "Angelina", "Dare", "Benin", "1-440-533-1231" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2216,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Ashachester", "EE27541", "G551603", new DateTime(1952, 10, 9, 0, 0, 0, 0, DateTimeKind.Local), "Dexter87@hotmail.com", "Dexter", "West", "Paraguay", "1-979-999-0493 x324" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2217,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Schmittchester", "EE8553", 3, "G506944", new DateTime(1966, 1, 21, 0, 0, 0, 0, DateTimeKind.Local), "Maureen_Hahn26@gmail.com", "Maureen", "Hahn", "Congo", "294-342-3098 x56253", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2218,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Devanteland", "EE53306", 3, "G32660", new DateTime(1991, 3, 13, 0, 0, 0, 0, DateTimeKind.Local), "Renee87@gmail.com", "Renee", "Conroy", "Faroe Islands", "1-255-306-5821 x78417" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2219,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Juana", "EE29559", "G401125", new DateTime(1980, 1, 31, 0, 0, 0, 0, DateTimeKind.Local), "Frederick_Crona@hotmail.com", "Frederick", "Crona", "Slovakia (Slovak Republic)", "1-436-568-8593 x0032", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2220,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Axelhaven", "EE39188", 3, "G216637", new DateTime(1987, 11, 25, 0, 0, 0, 0, DateTimeKind.Local), "Aubrey0@hotmail.com", "Aubrey", "Stokes", "Marshall Islands", "615-979-0361" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2221,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Hailie", "EE13722", 3, "G493235", new DateTime(1997, 4, 11, 0, 0, 0, 0, DateTimeKind.Local), "Nick3@hotmail.com", "Nick", "Volkman", "Spain", "840.538.8626" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2222,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Ledamouth", "EE4866", 1, "G26330", new DateTime(1960, 5, 2, 0, 0, 0, 0, DateTimeKind.Local), "Patti_Kling@hotmail.com", "Patti", "Kling", "Djibouti", "1-780-535-9528 x1757", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2223,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Kendall", "EE34886", 4, "G206984", new DateTime(1989, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), "Matthew.Schoen79@yahoo.com", "Matthew", "Schoen", "Iraq", "761.445.4514 x82476" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2224,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Ilianaburgh", "EE44139", 2, "G474959", new DateTime(1956, 8, 31, 0, 0, 0, 0, DateTimeKind.Local), "Nichole18@hotmail.com", "Nichole", "Stroman", "Palestinian Territory", "1-642-969-5649 x08645" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2225,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Trentton", "EE40091", "G38206", new DateTime(1969, 5, 10, 0, 0, 0, 0, DateTimeKind.Local), "Kerry90@hotmail.com", "Kerry", "Abernathy", "Germany", "1-463-959-8743 x159" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2226,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Macejkovicview", "EE31322", "G232885", new DateTime(1983, 4, 16, 0, 0, 0, 0, DateTimeKind.Local), "Velma.Jaskolski79@gmail.com", "Velma", "Jaskolski", "Portugal", "1-247-256-8395 x0374", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2227,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Runolfssonborough", "EE16357", 2, "G522696", new DateTime(1995, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), "Timothy_Herman@hotmail.com", "Timothy", "Herman", "El Salvador", "1-292-907-3324" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2228,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Marleyville", "EE54050", "G416884", new DateTime(1960, 10, 29, 0, 0, 0, 0, DateTimeKind.Local), "Delbert38@yahoo.com", "Delbert", "Smith", "Bahrain", "775.990.8437" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2229,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Port Flo", "EE15660", 4, "G263257", new DateTime(1968, 11, 15, 0, 0, 0, 0, DateTimeKind.Local), "Cody.West57@hotmail.com", "Cody", "West", "Saint Lucia", "424.554.5792" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2230,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Monahanfort", "EE41998", 2, "G348191", new DateTime(1972, 7, 20, 0, 0, 0, 0, DateTimeKind.Local), "Cecelia69@gmail.com", "Cecelia", "Ferry", "New Caledonia", "711.901.3194", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2231,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Medhurstchester", "EE58912", 4, "G395698", new DateTime(1993, 2, 12, 0, 0, 0, 0, DateTimeKind.Local), "Irene.Jacobs@hotmail.com", "Irene", "Jacobs", "Iran", "1-522-809-6146", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2232,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Titusmouth", "EE30791", 3, "G559688", new DateTime(1990, 4, 6, 0, 0, 0, 0, DateTimeKind.Local), "Eddie58@hotmail.com", "Eddie", "Mayer", "Niue", "1-992-375-5405 x3231" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2233,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Amie", "EE23294", "G73661", new DateTime(1980, 4, 2, 0, 0, 0, 0, DateTimeKind.Local), "Ellis_Schimmel8@hotmail.com", "Ellis", "Schimmel", "Austria", "(384) 762-3864", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2234,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Morarside", "EE1530", 1, "G462716", new DateTime(1989, 7, 6, 0, 0, 0, 0, DateTimeKind.Local), "Leroy.Klocko@yahoo.com", "Leroy", "Klocko", "Vanuatu", "(715) 692-5909" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2235,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Daphneyview", "EE45330", 2, "G346902", new DateTime(1961, 10, 23, 0, 0, 0, 0, DateTimeKind.Local), "Tracy.Goyette68@hotmail.com", "Tracy", "Goyette", "Iran", "603-738-3745", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2236,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Brandtport", "EE19945", 4, "G543259", new DateTime(1957, 4, 11, 0, 0, 0, 0, DateTimeKind.Local), "Marcos_Kub@gmail.com", "Marcos", "Kub", "Italy", "(329) 684-3788", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2237,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Dooleyshire", "EE3082", 3, "G508423", new DateTime(2000, 12, 8, 0, 0, 0, 0, DateTimeKind.Local), "Joann86@hotmail.com", "Joann", "Gutkowski", "South Africa", "936.493.5974 x350", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2238,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Bartolettihaven", "EE5801", "G507238", new DateTime(1995, 4, 19, 0, 0, 0, 0, DateTimeKind.Local), "Kathleen_Pacocha14@hotmail.com", "Kathleen", "Pacocha", "Thailand", "547-691-0400", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2239,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Domenicabury", "EE43760", 2, "G209017", new DateTime(1954, 6, 23, 0, 0, 0, 0, DateTimeKind.Local), "Tamara_Zulauf26@yahoo.com", "Tamara", "Zulauf", "Libyan Arab Jamahiriya", "1-212-884-4497 x922", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2240,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "North Issachaven", "EE34267", "G103893", new DateTime(1968, 4, 1, 0, 0, 0, 0, DateTimeKind.Local), "Troy_Dibbert15@yahoo.com", "Troy", "Dibbert", "Saint Kitts and Nevis", "(230) 486-9608 x571" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2241,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Brendonton", "EE34200", 4, "G379545", new DateTime(1955, 5, 27, 0, 0, 0, 0, DateTimeKind.Local), "Dolores_Torphy@yahoo.com", "Dolores", "Torphy", "Maldives", "727.324.4899" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2242,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Nicklausberg", "EE19481", 2, "G100154", new DateTime(1994, 1, 20, 0, 0, 0, 0, DateTimeKind.Local), "Carrie52@gmail.com", "Carrie", "Lesch", "Belarus", "(508) 700-0761 x757" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2243,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Shaunborough", "EE6944", 4, "G181722", new DateTime(1961, 4, 6, 0, 0, 0, 0, DateTimeKind.Local), "Paulette39@yahoo.com", "Paulette", "Daugherty", "Vanuatu", "(749) 400-3449 x46168" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2244,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Malindastad", "EE7666", 2, "G219404", new DateTime(1998, 12, 1, 0, 0, 0, 0, DateTimeKind.Local), "Shelia89@gmail.com", "Shelia", "Weber", "Slovenia", "(319) 340-1468 x3538" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2245,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Roycestad", "EE9660", 2, "G441228", new DateTime(1962, 11, 25, 0, 0, 0, 0, DateTimeKind.Local), "Nicolas_Swift@yahoo.com", "Nicolas", "Swift", "Gibraltar", "835.622.5882", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2246,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Kesslerport", "EE25095", 2, "G152460", new DateTime(1988, 4, 28, 0, 0, 0, 0, DateTimeKind.Local), "Leslie_Larson73@yahoo.com", "Leslie", "Larson", "Nepal", "1-713-565-3965" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2247,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Elianville", "EE24298", "G250525", new DateTime(1992, 12, 31, 0, 0, 0, 0, DateTimeKind.Local), "Dominic_Boehm88@hotmail.com", "Dominic", "Boehm", "British Indian Ocean Territory (Chagos Archipelago)", "(771) 757-6918 x7524" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2248,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Solonburgh", "EE43730", "G72011", new DateTime(1951, 9, 25, 0, 0, 0, 0, DateTimeKind.Local), "Fred_Ruecker@yahoo.com", "Fred", "Ruecker", "Maldives", "1-596-404-6614 x33890" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2249,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Samirbury", "EE47133", 3, "G568244", new DateTime(1960, 8, 23, 0, 0, 0, 0, DateTimeKind.Local), "Kelly_Purdy@yahoo.com", "Kelly", "Purdy", "Moldova", "1-912-521-9887" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2250,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Lauraton", "EE27307", 2, "G156277", new DateTime(1961, 3, 10, 0, 0, 0, 0, DateTimeKind.Local), "Krystal_Swift@hotmail.com", "Krystal", "Swift", "Greece", "(236) 350-7242 x7216", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2251,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Torphyside", "EE20470", 3, "G475449", new DateTime(1968, 8, 2, 0, 0, 0, 0, DateTimeKind.Local), "Devin.Brakus38@gmail.com", "Devin", "Brakus", "Argentina", "(585) 804-0965 x2278" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2252,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Hauckmouth", "EE21063", 3, "G52936", new DateTime(1988, 6, 18, 0, 0, 0, 0, DateTimeKind.Local), "Jimmy54@hotmail.com", "Jimmy", "Heidenreich", "Pitcairn Islands", "926-657-4119", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2253,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Jonesstad", "EE59568", 1, "G577161", new DateTime(1952, 12, 12, 0, 0, 0, 0, DateTimeKind.Local), "Miriam36@hotmail.com", "Miriam", "Watsica", "Sweden", "1-706-468-4319" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2254,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Dachland", "EE32045", 2, "G57761", new DateTime(1996, 5, 21, 0, 0, 0, 0, DateTimeKind.Local), "Bonnie86@hotmail.com", "Bonnie", "Simonis", "Morocco", "(714) 519-5543 x598", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2255,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "New Willis", "EE45698", 3, "G456681", new DateTime(2001, 2, 24, 0, 0, 0, 0, DateTimeKind.Local), "Vernon_Larkin3@hotmail.com", "Vernon", "Larkin", "Guam", "1-496-828-1443", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2256,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Cyrus", "EE11603", 3, "G286993", new DateTime(1999, 7, 26, 0, 0, 0, 0, DateTimeKind.Local), "Santiago_Daniel@gmail.com", "Santiago", "Daniel", "South Africa", "344-857-2875 x220" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2257,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Ethylton", "EE55421", 1, "G323532", new DateTime(1951, 9, 21, 0, 0, 0, 0, DateTimeKind.Local), "Jill_Jaskolski@yahoo.com", "Jill", "Jaskolski", "South Africa", "1-780-575-8900 x17059", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2258,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Daisyton", "EE18102", 4, "G214082", new DateTime(1955, 5, 13, 0, 0, 0, 0, DateTimeKind.Local), "Natasha79@gmail.com", "Natasha", "Powlowski", "Tuvalu", "799-472-8137 x057", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2259,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Boscostad", "EE14999", 4, "G364208", new DateTime(1961, 11, 10, 0, 0, 0, 0, DateTimeKind.Local), "Kelley_OReilly@gmail.com", "Kelley", "O'Reilly", "Ecuador", "(890) 348-9442 x432" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2260,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Elwinberg", "EE53833", 2, "G111929", new DateTime(1991, 7, 1, 0, 0, 0, 0, DateTimeKind.Local), "Ebony.Ward@gmail.com", "Ebony", "Ward", "Gibraltar", "1-584-857-5910 x39338", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2261,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Eleanoraton", "EE1175", 3, "G95550", new DateTime(1958, 4, 15, 0, 0, 0, 0, DateTimeKind.Local), "Warren8@yahoo.com", "Warren", "Adams", "Nepal", "851-512-7249" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2262,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Jazmin", "EE45264", 2, "G538237", new DateTime(1997, 3, 5, 0, 0, 0, 0, DateTimeKind.Local), "Marian89@hotmail.com", "Marian", "Hayes", "Seychelles", "(816) 696-1565", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2263,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Laruehaven", "EE33813", "G277607", new DateTime(1990, 12, 22, 0, 0, 0, 0, DateTimeKind.Local), "Velma_Schowalter@yahoo.com", "Velma", "Schowalter", "Chile", "(480) 353-5963" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2264,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Rethastad", "EE45449", "G506885", new DateTime(1969, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), "Hattie_Nader@gmail.com", "Hattie", "Nader", "Saudi Arabia", "690.253.8703 x18890", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2265,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Friesenville", "EE21274", 1, "G278176", new DateTime(1971, 4, 25, 0, 0, 0, 0, DateTimeKind.Local), "Bryan_Hudson@hotmail.com", "Bryan", "Hudson", "Brunei Darussalam", "(721) 565-3560 x90269" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2266,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Dawnmouth", "EE37124", "G460014", new DateTime(1953, 5, 9, 0, 0, 0, 0, DateTimeKind.Local), "Herbert_Breitenberg43@yahoo.com", "Herbert", "Breitenberg", "Virgin Islands, U.S.", "855.669.2492 x39886" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2267,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Faustino", "EE27089", 3, "G252656", new DateTime(1997, 12, 10, 0, 0, 0, 0, DateTimeKind.Local), "Tasha57@yahoo.com", "Tasha", "Kertzmann", "Bouvet Island (Bouvetoya)", "1-443-737-9152" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2268,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "North Hadleyborough", "EE34541", 4, "G319133", new DateTime(1983, 10, 2, 0, 0, 0, 0, DateTimeKind.Local), "Calvin98@hotmail.com", "Calvin", "Okuneva", "Vietnam", "703-498-0369" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2269,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "North Maggie", "EE47846", "G599209", new DateTime(1989, 10, 17, 0, 0, 0, 0, DateTimeKind.Local), "Pete.Grant76@yahoo.com", "Pete", "Grant", "Hong Kong", "(905) 469-1792" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2270,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "New Hectorfurt", "EE20816", "G359872", new DateTime(1990, 1, 8, 0, 0, 0, 0, DateTimeKind.Local), "Jenny_Glover31@gmail.com", "Jenny", "Glover", "Chile", "706-274-4895 x0316", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2271,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South John", "EE8454", 2, "G197792", new DateTime(1987, 6, 4, 0, 0, 0, 0, DateTimeKind.Local), "Ignacio_Romaguera@gmail.com", "Ignacio", "Romaguera", "Australia", "765-912-9052" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2272,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Alecville", "EE6759", 3, "G176669", new DateTime(1994, 8, 29, 0, 0, 0, 0, DateTimeKind.Local), "Joshua99@yahoo.com", "Joshua", "Bruen", "French Guiana", "486.908.5824 x9866", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2273,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Desmondside", "EE12448", 3, "G250075", new DateTime(1974, 12, 18, 0, 0, 0, 0, DateTimeKind.Local), "Elvira_Schamberger@yahoo.com", "Elvira", "Schamberger", "Tanzania", "(373) 333-0736" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2274,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Marquardtmouth", "EE12392", "G271413", new DateTime(1987, 5, 31, 0, 0, 0, 0, DateTimeKind.Local), "Olga59@yahoo.com", "Olga", "Fahey", "American Samoa", "(600) 204-2824 x8591" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2275,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Mark", "EE585", 2, "G400455", new DateTime(1961, 7, 2, 0, 0, 0, 0, DateTimeKind.Local), "Sidney92@yahoo.com", "Sidney", "Hoppe", "Cayman Islands", "(535) 769-8075", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2276,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Zionview", "EE36579", 4, "G563496", new DateTime(1974, 9, 6, 0, 0, 0, 0, DateTimeKind.Local), "Myra.Dooley28@gmail.com", "Myra", "Dooley", "Germany", "1-425-681-9768 x98148" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2277,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Gerardotown", "EE7374", "G97009", new DateTime(1971, 4, 29, 0, 0, 0, 0, DateTimeKind.Local), "Earnest69@hotmail.com", "Earnest", "Erdman", "Kiribati", "759-619-4606 x7412", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2278,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Strackemouth", "EE21649", 3, "G360521", new DateTime(1974, 6, 1, 0, 0, 0, 0, DateTimeKind.Local), "Jodi_Ernser27@gmail.com", "Jodi", "Ernser", "Czech Republic", "594-726-1474" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2279,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Jacobsborough", "EE16943", 2, "G420587", new DateTime(1951, 10, 2, 0, 0, 0, 0, DateTimeKind.Local), "Douglas_Carter72@yahoo.com", "Douglas", "Carter", "Nicaragua", "612-549-9748 x00665" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2280,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Wuckertberg", "EE15717", 1, "G362261", new DateTime(1958, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), "Byron_Prohaska97@gmail.com", "Byron", "Prohaska", "Guinea", "423-370-8662" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2281,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Abbottstad", "EE44315", "G173676", new DateTime(1978, 12, 29, 0, 0, 0, 0, DateTimeKind.Local), "Cora_Pacocha61@yahoo.com", "Cora", "Pacocha", "San Marino", "387.538.4455 x35141" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2282,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Beulahburgh", "EE31905", 3, "G3061", new DateTime(1951, 12, 10, 0, 0, 0, 0, DateTimeKind.Local), "Donnie_Sauer46@hotmail.com", "Donnie", "Sauer", "Palau", "1-767-955-9378", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2283,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "East Maud", "EE36118", 3, "G360347", new DateTime(1967, 10, 16, 0, 0, 0, 0, DateTimeKind.Local), "Latoya.Wisozk@gmail.com", "Latoya", "Wisozk", "India", "(448) 385-6332 x638" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2284,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "East Harry", "EE3476", 4, "G78141", new DateTime(1954, 3, 29, 0, 0, 0, 0, DateTimeKind.Local), "Ellen.Fadel@yahoo.com", "Ellen", "Fadel", "Guyana", "1-481-308-8478" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2285,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Alexie", "EE36409", "G175462", new DateTime(1964, 8, 23, 0, 0, 0, 0, DateTimeKind.Local), "Cecelia_Vandervort@hotmail.com", "Cecelia", "Vandervort", "Iceland", "766.513.7813 x459", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2286,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Antoinettemouth", "EE11995", 4, "G469596", new DateTime(1991, 4, 7, 0, 0, 0, 0, DateTimeKind.Local), "Jim83@gmail.com", "Jim", "Frami", "Pakistan", "1-332-374-7395" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2287,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Chance", "EE56339", "G333955", new DateTime(1982, 12, 17, 0, 0, 0, 0, DateTimeKind.Local), "Omar86@yahoo.com", "Omar", "Schulist", "Mali", "992.855.4150", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2288,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Mauricio", "EE13640", 3, "G224454", new DateTime(1967, 2, 1, 0, 0, 0, 0, DateTimeKind.Local), "Bertha_Homenick82@hotmail.com", "Bertha", "Homenick", "Angola", "1-497-873-9859", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2289,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Korey", "EE59518", 2, "G323638", new DateTime(1966, 1, 10, 0, 0, 0, 0, DateTimeKind.Local), "Lorena.King@yahoo.com", "Lorena", "King", "Sao Tome and Principe", "1-238-854-6840", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2290,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Garettfort", "EE56779", "G108109", new DateTime(1955, 2, 11, 0, 0, 0, 0, DateTimeKind.Local), "Conrad98@hotmail.com", "Conrad", "Reilly", "Finland", "1-426-272-9298" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2291,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Haneton", "EE18020", 1, "G113778", new DateTime(1965, 8, 28, 0, 0, 0, 0, DateTimeKind.Local), "Rose94@hotmail.com", "Rose", "Breitenberg", "Ethiopia", "(513) 827-4169 x978", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2292,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Otis", "EE39607", 4, "G562256", new DateTime(1960, 8, 20, 0, 0, 0, 0, DateTimeKind.Local), "Damon.Hodkiewicz@gmail.com", "Damon", "Hodkiewicz", "Cocos (Keeling) Islands", "602-203-8494 x137" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2293,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lake Allison", "EE3820", 1, "G454508", new DateTime(1969, 11, 11, 0, 0, 0, 0, DateTimeKind.Local), "Homer31@yahoo.com", "Homer", "Powlowski", "Central African Republic", "572.783.8499 x789", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2294,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Sipeshaven", "EE12223", "G197137", new DateTime(1962, 11, 11, 0, 0, 0, 0, DateTimeKind.Local), "Carol_Casper53@gmail.com", "Carol", "Casper", "Netherlands", "(719) 939-9293 x001" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2295,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "New Jalen", "EE30664", 3, "G500803", new DateTime(1994, 4, 8, 0, 0, 0, 0, DateTimeKind.Local), "Sidney96@gmail.com", "Sidney", "Dietrich", "United States of America", "490.853.1034 x49590", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2296,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Frederikberg", "EE28247", 2, "G422512", new DateTime(1953, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), "Pauline.Sipes@hotmail.com", "Pauline", "Sipes", "China", "403-295-7434", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2297,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Eloisefort", "EE703", 4, "G39012", new DateTime(1961, 9, 24, 0, 0, 0, 0, DateTimeKind.Local), "Dorothy_Schroeder@hotmail.com", "Dorothy", "Schroeder", "Albania", "840-661-0565" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2298,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Port Unaside", "EE32540", 1, "G286866", new DateTime(1995, 1, 16, 0, 0, 0, 0, DateTimeKind.Local), "Ross_Schimmel39@gmail.com", "Ross", "Schimmel", "Lithuania", "207.625.1010" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2299,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Litzy", "EE9170", 1, "G509792", new DateTime(1969, 6, 21, 0, 0, 0, 0, DateTimeKind.Local), "Shawna.DuBuque86@gmail.com", "Shawna", "DuBuque", "French Southern Territories", "872.885.4246 x5439", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2300,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Ryanfort", "EE35956", 1, "G422622", new DateTime(1964, 2, 7, 0, 0, 0, 0, DateTimeKind.Local), "Willie.Reinger76@hotmail.com", "Willie", "Reinger", "Montserrat", "(759) 963-5856" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2301,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Torphychester", "EE38562", 2, "G132976", new DateTime(1959, 6, 15, 0, 0, 0, 0, DateTimeKind.Local), "Edmond.Connelly@yahoo.com", "Edmond", "Connelly", "Cuba", "1-491-213-1272 x8071", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2302,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Beaulah", "EE4716", "G460584", new DateTime(1980, 10, 27, 0, 0, 0, 0, DateTimeKind.Local), "Michele.Bauch17@yahoo.com", "Michele", "Bauch", "Holy See (Vatican City State)", "(767) 776-9139 x52600" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2303,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Leopoldland", "EE54996", 2, "G578912", new DateTime(1992, 6, 12, 0, 0, 0, 0, DateTimeKind.Local), "Chris.Heaney@gmail.com", "Chris", "Heaney", "Myanmar", "1-922-232-9352", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2304,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lake Nilsfurt", "EE53606", "G583100", new DateTime(1992, 9, 12, 0, 0, 0, 0, DateTimeKind.Local), "Shelly95@gmail.com", "Shelly", "Sipes", "Moldova", "455-337-2761 x43573", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2305,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Yazminstad", "EE43749", 3, "G293648", new DateTime(1992, 5, 4, 0, 0, 0, 0, DateTimeKind.Local), "Dwayne_Kuhic86@hotmail.com", "Dwayne", "Kuhic", "Myanmar", "1-791-392-1826 x96353", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2306,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Fredaburgh", "EE5052", 3, "G101430", new DateTime(1955, 6, 7, 0, 0, 0, 0, DateTimeKind.Local), "Jane98@gmail.com", "Jane", "Reichert", "Ghana", "(236) 798-7805 x8714" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2307,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Hagenesborough", "EE53227", 3, "G421039", new DateTime(1998, 10, 7, 0, 0, 0, 0, DateTimeKind.Local), "Rolando_Ward87@yahoo.com", "Rolando", "Ward", "Somalia", "368.555.1335", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2308,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Mayraburgh", "EE39000", "G566115", new DateTime(1993, 4, 19, 0, 0, 0, 0, DateTimeKind.Local), "Melba80@hotmail.com", "Melba", "Mayer", "Trinidad and Tobago", "1-374-464-7749 x3987" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2309,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Kenny", "EE38704", "G38959", new DateTime(1974, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), "Kayla_Considine4@hotmail.com", "Kayla", "Considine", "Greenland", "749.470.9543", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2310,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Flatleyfurt", "EE16797", "G189069", new DateTime(1962, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), "Celia_Spencer10@yahoo.com", "Celia", "Spencer", "Lao People's Democratic Republic", "545.781.8705", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2311,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "New Constantinmouth", "EE44883", "G275208", new DateTime(1971, 2, 20, 0, 0, 0, 0, DateTimeKind.Local), "Jean86@hotmail.com", "Jean", "Yundt", "Germany", "1-942-372-3779 x08469", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2312,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "North Natasha", "EE49825", 4, "G480334", new DateTime(1980, 7, 30, 0, 0, 0, 0, DateTimeKind.Local), "Iris.Kuvalis11@gmail.com", "Iris", "Kuvalis", "Mongolia", "502.863.5207 x488" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2313,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "North Kenyatta", "EE8898", 3, "G496652", new DateTime(1999, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), "Sergio82@gmail.com", "Sergio", "Kertzmann", "Mongolia", "1-841-647-5083 x531" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2314,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Jaleelfort", "EE30147", 3, "G260752", new DateTime(1977, 6, 18, 0, 0, 0, 0, DateTimeKind.Local), "Johnnie_Dibbert@yahoo.com", "Johnnie", "Dibbert", "Iraq", "379-863-1666 x74289" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2315,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Morris", "EE35399", "G426957", new DateTime(1955, 11, 11, 0, 0, 0, 0, DateTimeKind.Local), "Irvin13@hotmail.com", "Irvin", "Denesik", "Nicaragua", "885-741-2036" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2316,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "North Ashlynnborough", "EE28820", 2, "G59627", new DateTime(1965, 1, 18, 0, 0, 0, 0, DateTimeKind.Local), "Hector84@yahoo.com", "Hector", "MacGyver", "South Georgia and the South Sandwich Islands", "1-432-348-1022 x825" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2317,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Robertsstad", "EE8556", "G277037", new DateTime(1975, 3, 2, 0, 0, 0, 0, DateTimeKind.Local), "Rhonda_Corwin22@gmail.com", "Rhonda", "Corwin", "Belgium", "712-417-9239 x95320", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2318,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Lilyanborough", "EE51561", 3, "G377021", new DateTime(1990, 3, 5, 0, 0, 0, 0, DateTimeKind.Local), "Jana_Maggio77@gmail.com", "Jana", "Maggio", "Bahamas", "1-602-215-1522 x759", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2319,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Fritzfort", "EE48214", 3, "G497626", new DateTime(1980, 10, 21, 0, 0, 0, 0, DateTimeKind.Local), "Mabel_Paucek98@yahoo.com", "Mabel", "Paucek", "French Polynesia", "(600) 853-3288 x09217", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2320,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Nicolasfurt", "EE4573", "G211645", new DateTime(1987, 3, 20, 0, 0, 0, 0, DateTimeKind.Local), "Ora61@hotmail.com", "Ora", "Friesen", "Bangladesh", "648-337-6324", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2321,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Port Lorenza", "EE36355", 4, "G251623", new DateTime(1974, 10, 1, 0, 0, 0, 0, DateTimeKind.Local), "Jean.Windler97@gmail.com", "Jean", "Windler", "Grenada", "(417) 725-4871" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2322,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Cliftonfurt", "EE6544", 2, "G475236", new DateTime(1991, 6, 14, 0, 0, 0, 0, DateTimeKind.Local), "Christy_Hickle80@hotmail.com", "Christy", "Hickle", "Mali", "878.662.8809 x0957" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2323,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lake Cornell", "EE20850", 4, "G280098", new DateTime(1958, 8, 8, 0, 0, 0, 0, DateTimeKind.Local), "Kim.Koelpin56@gmail.com", "Kim", "Koelpin", "Barbados", "461-617-6590", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2324,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Carsontown", "EE52748", 3, "G51032", new DateTime(1985, 7, 25, 0, 0, 0, 0, DateTimeKind.Local), "Leah.Parker12@hotmail.com", "Leah", "Parker", "Guadeloupe", "(704) 415-7047", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2325,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Armanistad", "EE51490", 3, "G552751", new DateTime(1977, 12, 16, 0, 0, 0, 0, DateTimeKind.Local), "Shawn.Stark70@yahoo.com", "Shawn", "Stark", "Kenya", "1-415-385-3907 x555" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2326,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Weberville", "EE45249", "G398102", new DateTime(1959, 1, 29, 0, 0, 0, 0, DateTimeKind.Local), "Betty65@gmail.com", "Betty", "Harber", "Morocco", "1-451-964-7941 x353" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2327,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Reeceshire", "EE44882", 3, "G169274", new DateTime(1970, 7, 29, 0, 0, 0, 0, DateTimeKind.Local), "Hazel_Hintz64@yahoo.com", "Hazel", "Hintz", "Isle of Man", "(522) 345-9182" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2328,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "New Kylieport", "EE39361", "G83889", new DateTime(1978, 11, 12, 0, 0, 0, 0, DateTimeKind.Local), "Doreen_Morar@yahoo.com", "Doreen", "Morar", "Georgia", "781-414-3577", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2329,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Kreigerton", "EE35045", 2, "G537955", new DateTime(1966, 2, 23, 0, 0, 0, 0, DateTimeKind.Local), "Claude.Kuphal@yahoo.com", "Claude", "Kuphal", "Palau", "1-283-434-1092" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2330,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Jennifer", "EE15190", "G283154", new DateTime(1999, 10, 6, 0, 0, 0, 0, DateTimeKind.Local), "Alberta.Ortiz70@gmail.com", "Alberta", "Ortiz", "Saint Lucia", "321.602.9621", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2331,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "North Nella", "EE49031", 4, "G25059", new DateTime(1992, 7, 6, 0, 0, 0, 0, DateTimeKind.Local), "Lyle_Ryan74@hotmail.com", "Lyle", "Ryan", "Burundi", "1-383-846-8689" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2332,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Emmerichburgh", "EE270", 4, "G500875", new DateTime(1987, 2, 22, 0, 0, 0, 0, DateTimeKind.Local), "Ernestine_Dickinson97@hotmail.com", "Ernestine", "Dickinson", "Wallis and Futuna", "1-963-946-9965 x195" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2333,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "North Ambershire", "EE52361", 3, "G481239", new DateTime(1958, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), "Ora_Langworth@yahoo.com", "Ora", "Langworth", "Bosnia and Herzegovina", "913-594-1508" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2334,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "New Rosaliafort", "EE34812", 4, "G357162", new DateTime(1964, 2, 13, 0, 0, 0, 0, DateTimeKind.Local), "Derrick47@yahoo.com", "Derrick", "Beatty", "Bolivia", "275-688-5562 x5389", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2335,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Chadd", "EE31890", 4, "G315926", new DateTime(1975, 10, 12, 0, 0, 0, 0, DateTimeKind.Local), "Sheri_Kutch92@yahoo.com", "Sheri", "Kutch", "Brunei Darussalam", "(484) 977-8024" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2336,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Prohaskamouth", "EE16614", 1, "G528313", new DateTime(1953, 5, 15, 0, 0, 0, 0, DateTimeKind.Local), "Danny.Langosh99@gmail.com", "Danny", "Langosh", "Turkmenistan", "743-552-2039", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2337,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Shadtown", "EE44293", 4, "G56013", new DateTime(1971, 3, 30, 0, 0, 0, 0, DateTimeKind.Local), "Amber_Blick@hotmail.com", "Amber", "Blick", "Solomon Islands", "784.806.3547 x2622", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2338,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Micaelafort", "EE6878", "G14812", new DateTime(1967, 7, 23, 0, 0, 0, 0, DateTimeKind.Local), "Miriam4@hotmail.com", "Miriam", "Borer", "Qatar", "(626) 403-5703" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2339,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Burleyhaven", "EE45973", "G67984", new DateTime(1988, 7, 30, 0, 0, 0, 0, DateTimeKind.Local), "Elias.Ziemann81@yahoo.com", "Elias", "Ziemann", "Armenia", "333.667.2451" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2340,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Jarredhaven", "EE39215", "G588197", new DateTime(1987, 11, 16, 0, 0, 0, 0, DateTimeKind.Local), "Toni_Kihn@hotmail.com", "Toni", "Kihn", "Vietnam", "1-569-644-1823 x090" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2341,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Elisaland", "EE15446", 1, "G81366", new DateTime(1973, 5, 17, 0, 0, 0, 0, DateTimeKind.Local), "Courtney_Johnston@hotmail.com", "Courtney", "Johnston", "Libyan Arab Jamahiriya", "982.524.3959 x563", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2342,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Port Mateomouth", "EE25349", 3, "G10186", new DateTime(1980, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), "Rachel_Wilkinson31@gmail.com", "Rachel", "Wilkinson", "Suriname", "(273) 585-8174" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2343,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Mariannaton", "EE45962", 1, "G331359", new DateTime(1990, 3, 10, 0, 0, 0, 0, DateTimeKind.Local), "Elias.Romaguera@gmail.com", "Elias", "Romaguera", "Egypt", "1-589-913-1399 x37109", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2344,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lake Elodymouth", "EE7939", 1, "G144629", new DateTime(1990, 10, 14, 0, 0, 0, 0, DateTimeKind.Local), "Courtney_Donnelly61@hotmail.com", "Courtney", "Donnelly", "Algeria", "318-202-9069 x3767", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2345,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Hudsonport", "EE32016", 1, "G317223", new DateTime(1965, 3, 10, 0, 0, 0, 0, DateTimeKind.Local), "Elbert_Deckow@hotmail.com", "Elbert", "Deckow", "Sudan", "211-565-8872" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2346,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Kielland", "EE18718", 4, "G476706", new DateTime(1972, 8, 28, 0, 0, 0, 0, DateTimeKind.Local), "Beth7@hotmail.com", "Beth", "Effertz", "Portugal", "767-410-7016 x740" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2347,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "East Lucindabury", "EE17383", 2, "G175126", new DateTime(1984, 8, 2, 0, 0, 0, 0, DateTimeKind.Local), "Curtis.Farrell50@yahoo.com", "Curtis", "Farrell", "Singapore", "(964) 247-9518 x4840" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2348,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Gerhardstad", "EE22105", "G18867", new DateTime(1969, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), "Kerry24@gmail.com", "Kerry", "Schmitt", "Somalia", "774.368.0089 x49560" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2349,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Thompsonhaven", "EE23324", "G408257", new DateTime(1985, 5, 15, 0, 0, 0, 0, DateTimeKind.Local), "Margaret39@gmail.com", "Margaret", "Greenfelder", "Russian Federation", "(450) 907-0512 x09708", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2350,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Alexzander", "EE872", "G458284", new DateTime(1958, 9, 27, 0, 0, 0, 0, DateTimeKind.Local), "Al_Roberts@hotmail.com", "Al", "Roberts", "Guam", "372.861.0017 x3263", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2351,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Townemouth", "EE46691", 4, "G336935", new DateTime(1989, 3, 30, 0, 0, 0, 0, DateTimeKind.Local), "Pedro67@hotmail.com", "Pedro", "Erdman", "Palestinian Territory", "1-881-317-7680 x22931" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2352,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Esta", "EE55929", 4, "G568942", new DateTime(1990, 5, 2, 0, 0, 0, 0, DateTimeKind.Local), "Anita64@hotmail.com", "Anita", "Grady", "Democratic People's Republic of Korea", "469-266-4077 x88813", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2353,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Alessandrastad", "EE4082", 2, "G196379", new DateTime(1954, 2, 20, 0, 0, 0, 0, DateTimeKind.Local), "Tabitha_Marvin@yahoo.com", "Tabitha", "Marvin", "Bahrain", "(561) 861-4783 x90890", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2354,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Brayanton", "EE52549", 1, "G267959", new DateTime(1973, 11, 25, 0, 0, 0, 0, DateTimeKind.Local), "Darin.Walsh79@gmail.com", "Darin", "Walsh", "Wallis and Futuna", "652-326-3150", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2355,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Raymondstad", "EE53738", 4, "G587220", new DateTime(1979, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), "Bradford.Morissette@gmail.com", "Bradford", "Morissette", "Kyrgyz Republic", "299-634-5598 x43508", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2356,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Kiehnton", "EE13931", 3, "G576628", new DateTime(1998, 1, 21, 0, 0, 0, 0, DateTimeKind.Local), "Elsa_Lesch@gmail.com", "Elsa", "Lesch", "Saint Kitts and Nevis", "697-354-3951 x3766" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2357,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Port Reese", "EE20450", 1, "G231600", new DateTime(1974, 6, 25, 0, 0, 0, 0, DateTimeKind.Local), "Frank10@hotmail.com", "Frank", "Fisher", "Liechtenstein", "257-308-4127", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2358,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Andersonchester", "EE51533", "G397000", new DateTime(1975, 2, 15, 0, 0, 0, 0, DateTimeKind.Local), "Fred_Hane72@hotmail.com", "Fred", "Hane", "Moldova", "(349) 396-9009", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2359,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Daishamouth", "EE30463", 2, "G483447", new DateTime(1997, 12, 22, 0, 0, 0, 0, DateTimeKind.Local), "Alma.Harber@yahoo.com", "Alma", "Harber", "Poland", "833.961.2197 x0563" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2360,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Louveniaside", "EE30199", 3, "G134776", new DateTime(1990, 12, 12, 0, 0, 0, 0, DateTimeKind.Local), "Verna80@gmail.com", "Verna", "Koss", "Micronesia", "1-937-354-2490 x40004" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2361,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Hahnside", "EE37342", "G325548", new DateTime(1973, 10, 14, 0, 0, 0, 0, DateTimeKind.Local), "Edgar_Mueller@yahoo.com", "Edgar", "Mueller", "Heard Island and McDonald Islands", "254-209-8308 x66294", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2362,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Devanberg", "EE36940", 3, "G476264", new DateTime(1953, 1, 12, 0, 0, 0, 0, DateTimeKind.Local), "Janie_Monahan@gmail.com", "Janie", "Monahan", "United Kingdom", "322.921.9854 x940", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2363,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Jovannyville", "EE16929", 2, "G166809", new DateTime(1972, 12, 1, 0, 0, 0, 0, DateTimeKind.Local), "Kristen84@yahoo.com", "Kristen", "Volkman", "Gibraltar", "1-221-981-9266 x595" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2364,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "North Austynberg", "EE55030", 2, "G188719", new DateTime(1972, 5, 26, 0, 0, 0, 0, DateTimeKind.Local), "Gilberto_Parker@yahoo.com", "Gilberto", "Parker", "Cambodia", "1-573-778-8959 x98125" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2365,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "natio", "phone" },
                values: new object[] { "Feestside", "EE2572", "G276345", new DateTime(1963, 3, 21, 0, 0, 0, 0, DateTimeKind.Local), "Jenny.Borer@yahoo.com", "Jenny", "Palau", "616-339-4646 x11243" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2366,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "East Christianamouth", "EE55502", "G554195", new DateTime(1981, 11, 28, 0, 0, 0, 0, DateTimeKind.Local), "Frankie_Veum@gmail.com", "Frankie", "Veum", "Luxembourg", "319.479.1828 x6598" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2367,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Port Sven", "EE3546", 3, "G348841", new DateTime(1960, 4, 21, 0, 0, 0, 0, DateTimeKind.Local), "Eva.Hayes86@hotmail.com", "Eva", "Hayes", "Hungary", "290-612-9963" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2368,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Desiree", "EE5534", 4, "G433391", new DateTime(1959, 6, 14, 0, 0, 0, 0, DateTimeKind.Local), "Courtney37@yahoo.com", "Courtney", "Vandervort", "Andorra", "(986) 254-5859", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2369,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Wolfhaven", "EE15152", 2, "G255530", new DateTime(1957, 6, 23, 0, 0, 0, 0, DateTimeKind.Local), "Lee91@yahoo.com", "Lee", "Kuphal", "Solomon Islands", "297-960-8167 x02958" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2370,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Cheyanneborough", "EE18856", 1, "G564555", new DateTime(1977, 9, 18, 0, 0, 0, 0, DateTimeKind.Local), "Jon.Strosin9@gmail.com", "Jon", "Strosin", "Latvia", "1-704-282-6544" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2371,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Jacintheton", "EE41230", "G503976", new DateTime(1977, 2, 22, 0, 0, 0, 0, DateTimeKind.Local), "Ruben.Huels@gmail.com", "Ruben", "Huels", "Isle of Man", "844-934-5042" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2372,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Cyrilville", "EE57297", "G498264", new DateTime(1990, 2, 10, 0, 0, 0, 0, DateTimeKind.Local), "Audrey_Jerde@gmail.com", "Audrey", "Jerde", "Mauritania", "1-474-787-1943 x98696" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2373,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Pfefferfort", "EE50982", 4, "G107164", new DateTime(1959, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), "Kenneth.Bayer11@gmail.com", "Kenneth", "Bayer", "Nepal", "1-857-936-6039 x99292" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2374,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Goldnermouth", "EE55867", 3, "G47874", new DateTime(1992, 3, 19, 0, 0, 0, 0, DateTimeKind.Local), "Willard79@yahoo.com", "Willard", "McKenzie", "Kiribati", "(475) 574-0018 x975", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2375,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Domenicofurt", "EE271", 1, "G279101", new DateTime(1964, 9, 14, 0, 0, 0, 0, DateTimeKind.Local), "Diane.Kunde29@gmail.com", "Diane", "Kunde", "Malta", "(800) 457-4251" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2376,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lake Bo", "EE9377", "G313728", new DateTime(1960, 4, 30, 0, 0, 0, 0, DateTimeKind.Local), "Cody_Lynch@hotmail.com", "Cody", "Lynch", "Malawi", "(981) 989-1337", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2377,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Melbaville", "EE15572", "G380206", new DateTime(1960, 6, 20, 0, 0, 0, 0, DateTimeKind.Local), "Irma.Rice@gmail.com", "Irma", "Rice", "Isle of Man", "(274) 714-1550 x757" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2378,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "North Micaela", "EE25092", "G145448", new DateTime(2000, 2, 24, 0, 0, 0, 0, DateTimeKind.Local), "Victoria_Labadie95@yahoo.com", "Victoria", "Labadie", "Indonesia", "958-872-3228 x5727" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2379,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "East Amelie", "EE11403", "G582672", new DateTime(1965, 10, 5, 0, 0, 0, 0, DateTimeKind.Local), "Colin_Fahey@gmail.com", "Colin", "Fahey", "Madagascar", "1-415-859-4754 x191" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2380,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Kristinshire", "EE19625", 2, "G468739", new DateTime(1998, 10, 19, 0, 0, 0, 0, DateTimeKind.Local), "Brenda_Stroman69@yahoo.com", "Brenda", "Stroman", "Palau", "1-787-691-1879 x3361" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2381,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Delores", "EE27980", 3, "G569045", new DateTime(1963, 12, 10, 0, 0, 0, 0, DateTimeKind.Local), "Kate78@gmail.com", "Kate", "Yundt", "Zambia", "323.283.8110 x8785" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2382,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "New Ezequielhaven", "EE5560", 1, "G537219", new DateTime(1957, 1, 4, 0, 0, 0, 0, DateTimeKind.Local), "Amy_Jones15@hotmail.com", "Amy", "Jones", "Montenegro", "1-334-663-4144 x6379", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2383,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Huelfort", "EE19873", 3, "G137590", new DateTime(1987, 7, 27, 0, 0, 0, 0, DateTimeKind.Local), "Ramon82@hotmail.com", "Ramon", "Gerlach", "Switzerland", "1-317-996-0061" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2384,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Ethelyn", "EE56727", 3, "G511521", new DateTime(1957, 12, 20, 0, 0, 0, 0, DateTimeKind.Local), "Marcus.Paucek32@gmail.com", "Marcus", "Paucek", "Nepal", "(326) 732-8410" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2385,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "East Suzanneburgh", "EE5505", 3, "G473640", new DateTime(1952, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), "Maryann86@yahoo.com", "Maryann", "Hegmann", "Portugal", "545.995.6704 x8777" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2386,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Cathrynside", "EE27399", 4, "G260944", new DateTime(1966, 5, 21, 0, 0, 0, 0, DateTimeKind.Local), "Willie_Champlin@hotmail.com", "Willie", "Champlin", "Guadeloupe", "(776) 379-9293" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2387,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Jadeburgh", "EE10449", 1, "G78291", new DateTime(1988, 9, 3, 0, 0, 0, 0, DateTimeKind.Local), "Mildred58@hotmail.com", "Mildred", "Hoeger", "Central African Republic", "(216) 882-6894" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2388,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Collinschester", "EE51262", 1, "G9814", new DateTime(1985, 7, 27, 0, 0, 0, 0, DateTimeKind.Local), "Kerry.Torp90@gmail.com", "Kerry", "Torp", "Slovenia", "308.786.0400 x262", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2389,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Holliemouth", "EE11597", 2, "G447450", new DateTime(1991, 3, 3, 0, 0, 0, 0, DateTimeKind.Local), "Jay.Swaniawski@yahoo.com", "Jay", "Swaniawski", "Fiji", "630-806-0900 x13042", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2390,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Ronaldofurt", "EE8435", 1, "G96883", new DateTime(1954, 7, 10, 0, 0, 0, 0, DateTimeKind.Local), "Edmond_Macejkovic65@hotmail.com", "Edmond", "Macejkovic", "Lao People's Democratic Republic", "(325) 251-2200 x12906", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2391,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Ludwigtown", "EE54452", "G479521", new DateTime(1953, 1, 6, 0, 0, 0, 0, DateTimeKind.Local), "Leona.Gottlieb@yahoo.com", "Leona", "Gottlieb", "Djibouti", "(545) 210-1318 x57985" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2392,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Port Aureliaville", "EE18116", 3, "G557778", new DateTime(1980, 9, 3, 0, 0, 0, 0, DateTimeKind.Local), "Jon48@yahoo.com", "Jon", "Treutel", "Sudan", "1-287-662-4946 x5659" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2393,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Bartside", "EE54829", "G440007", new DateTime(1982, 3, 16, 0, 0, 0, 0, DateTimeKind.Local), "Lance.Runolfsdottir@yahoo.com", "Lance", "Runolfsdottir", "Cayman Islands", "666.517.0148", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2394,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Port Joel", "EE27798", 3, "G459785", new DateTime(1956, 1, 14, 0, 0, 0, 0, DateTimeKind.Local), "Clifton18@hotmail.com", "Clifton", "D'Amore", "Jersey", "1-372-666-0146 x1552" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2395,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "East Saul", "EE31837", "G541485", new DateTime(1984, 11, 11, 0, 0, 0, 0, DateTimeKind.Local), "Sonya.Weimann@yahoo.com", "Sonya", "Weimann", "Gibraltar", "887.647.6908 x338" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2396,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Domenic", "EE26496", 1, "G455089", new DateTime(1978, 1, 29, 0, 0, 0, 0, DateTimeKind.Local), "Jennifer.Heathcote@gmail.com", "Jennifer", "Heathcote", "Bahrain", "418.933.2982 x5174", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2397,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "North Kyler", "EE12674", 4, "G511904", new DateTime(1961, 10, 5, 0, 0, 0, 0, DateTimeKind.Local), "Tasha.Beatty@yahoo.com", "Tasha", "Beatty", "Somalia", "1-419-298-5168 x71775" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2398,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Cronaville", "EE5844", 2, "G357632", new DateTime(1982, 7, 16, 0, 0, 0, 0, DateTimeKind.Local), "Ismael.Stokes@hotmail.com", "Ismael", "Stokes", "Isle of Man", "1-860-801-3077 x88107" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2399,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Rafaelstad", "EE9455", 4, "G193427", new DateTime(1964, 3, 25, 0, 0, 0, 0, DateTimeKind.Local), "Ethel_Thompson84@gmail.com", "Ethel", "Thompson", "Barbados", "212.565.0176" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2400,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Soniamouth", "EE3962", 3, "G238609", new DateTime(1953, 12, 12, 0, 0, 0, 0, DateTimeKind.Local), "Della21@gmail.com", "Della", "Crona", "Georgia", "549.296.8583", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2401,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Patriciaview", "EE13168", 3, "G414444", new DateTime(1994, 12, 31, 0, 0, 0, 0, DateTimeKind.Local), "Leon0@gmail.com", "Leon", "Langworth", "British Indian Ocean Territory (Chagos Archipelago)", "1-735-741-1821 x099", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2402,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Port Berylmouth", "EE883", 4, "G243841", new DateTime(1994, 7, 2, 0, 0, 0, 0, DateTimeKind.Local), "Salvatore76@yahoo.com", "Salvatore", "Bogan", "Germany", "966-522-6221" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2403,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Macborough", "EE11033", 2, "G10392", new DateTime(1995, 8, 20, 0, 0, 0, 0, DateTimeKind.Local), "Harvey_Okuneva@yahoo.com", "Harvey", "Okuneva", "Iran", "865.294.5612", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2404,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Caleview", "EE52571", 3, "G568127", new DateTime(1953, 1, 18, 0, 0, 0, 0, DateTimeKind.Local), "Harriet7@yahoo.com", "Harriet", "Gleason", "Mexico", "245.723.2392 x249" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2405,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "North Khalidton", "EE18900", 4, "G364491", new DateTime(1980, 10, 30, 0, 0, 0, 0, DateTimeKind.Local), "Jeremiah.Jacobs@yahoo.com", "Jeremiah", "Jacobs", "Mauritania", "1-505-455-0686 x46905" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2406,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Millie", "EE8617", 4, "G250523", new DateTime(1960, 8, 6, 0, 0, 0, 0, DateTimeKind.Local), "Evan59@yahoo.com", "Evan", "Raynor", "New Zealand", "788.648.1737 x092", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2407,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "North Jazminchester", "EE45534", 2, "G70714", new DateTime(1965, 6, 5, 0, 0, 0, 0, DateTimeKind.Local), "Rufus.Moen34@yahoo.com", "Rufus", "Moen", "Botswana", "1-520-638-9914 x105" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2408,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Pollichtown", "EE942", 3, "G236075", new DateTime(1968, 11, 18, 0, 0, 0, 0, DateTimeKind.Local), "Orlando.MacGyver@hotmail.com", "Orlando", "MacGyver", "Kazakhstan", "965-740-3383 x18972" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2409,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Alfordfort", "EE45107", 3, "G188712", new DateTime(1990, 12, 27, 0, 0, 0, 0, DateTimeKind.Local), "Lucille_Ratke28@yahoo.com", "Lucille", "Ratke", "Virgin Islands, British", "799.654.0381 x725" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2410,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Hettingerburgh", "EE51613", 2, "G121614", new DateTime(1957, 11, 14, 0, 0, 0, 0, DateTimeKind.Local), "Amy7@hotmail.com", "Amy", "Mann", "Pakistan", "(547) 683-9502 x7980", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2411,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Godfreybury", "EE15664", "G176235", new DateTime(1989, 4, 9, 0, 0, 0, 0, DateTimeKind.Local), "Dewey82@yahoo.com", "Dewey", "Greenholt", "Poland", "890.256.8337" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2412,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "North Dwight", "EE31278", 1, "G385937", new DateTime(1988, 3, 3, 0, 0, 0, 0, DateTimeKind.Local), "Natalie0@gmail.com", "Natalie", "Feest", "Niger", "765.830.4163" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2413,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Prosaccotown", "EE53617", 3, "G24611", new DateTime(1962, 2, 20, 0, 0, 0, 0, DateTimeKind.Local), "Kristin80@gmail.com", "Kristin", "Runolfsdottir", "Argentina", "1-395-529-0349 x79677", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2414,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Madonna", "EE49968", 2, "G280385", new DateTime(1956, 3, 11, 0, 0, 0, 0, DateTimeKind.Local), "Tami.OKeefe@gmail.com", "Tami", "O'Keefe", "Canada", "(970) 498-2931", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2415,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Vidahaven", "EE41607", "G502762", new DateTime(1998, 1, 2, 0, 0, 0, 0, DateTimeKind.Local), "Garry66@hotmail.com", "Garry", "Stiedemann", "Hungary", "458.453.7485 x404", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2416,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Jerrold", "EE11717", 4, "G468850", new DateTime(1994, 1, 2, 0, 0, 0, 0, DateTimeKind.Local), "Velma_Morar64@yahoo.com", "Velma", "Morar", "Norway", "279.885.9690" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2417,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Roelfurt", "EE40774", 4, "G82680", new DateTime(1954, 5, 7, 0, 0, 0, 0, DateTimeKind.Local), "Felicia_Little37@gmail.com", "Felicia", "Little", "Sao Tome and Principe", "(332) 769-3950 x638" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2418,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Elishaview", "EE32636", 3, "G432350", new DateTime(1960, 5, 10, 0, 0, 0, 0, DateTimeKind.Local), "Tommie.Spinka@gmail.com", "Tommie", "Spinka", "Belgium", "496-756-6713" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2419,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "East Odellside", "EE33833", 3, "G348429", new DateTime(1985, 1, 19, 0, 0, 0, 0, DateTimeKind.Local), "Kenny.Wiza91@hotmail.com", "Kenny", "Wiza", "Namibia", "1-409-386-7877" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2420,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "East Santiago", "EE23781", 2, "G116867", new DateTime(1995, 10, 24, 0, 0, 0, 0, DateTimeKind.Local), "Julio.Koepp@gmail.com", "Julio", "Koepp", "Belgium", "817.569.5218 x5054", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2421,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Gregghaven", "EE56635", 1, "G241066", new DateTime(1996, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), "Maureen27@gmail.com", "Maureen", "Howe", "French Guiana", "682.566.5025" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2422,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Daren", "EE42363", "G89131", new DateTime(1972, 10, 3, 0, 0, 0, 0, DateTimeKind.Local), "Laurie_Lemke20@hotmail.com", "Laurie", "Lemke", "Ukraine", "(660) 992-3784 x259", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2423,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "North Lucindafurt", "EE8954", 1, "G598333", new DateTime(1951, 8, 29, 0, 0, 0, 0, DateTimeKind.Local), "Becky.Zemlak89@gmail.com", "Becky", "Zemlak", "Faroe Islands", "1-963-895-4340" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2424,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Zoiechester", "EE10668", 2, "G505265", new DateTime(1996, 7, 2, 0, 0, 0, 0, DateTimeKind.Local), "Abraham_Weissnat49@gmail.com", "Abraham", "Weissnat", "Australia", "465-235-2353", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2425,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Tyson", "EE54132", 4, "G560773", new DateTime(1960, 9, 6, 0, 0, 0, 0, DateTimeKind.Local), "Dianna_Erdman@gmail.com", "Dianna", "Erdman", "Slovenia", "1-327-541-2770 x659", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2426,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Imani", "EE45593", 4, "G56794", new DateTime(1986, 2, 14, 0, 0, 0, 0, DateTimeKind.Local), "Ray39@hotmail.com", "Ray", "Oberbrunner", "Guernsey", "1-780-508-8196", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2427,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Stantonland", "EE2830", 2, "G88500", new DateTime(1973, 10, 7, 0, 0, 0, 0, DateTimeKind.Local), "Phillip.Price@hotmail.com", "Phillip", "Price", "Slovakia (Slovak Republic)", "1-463-596-6541" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2428,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Hackettport", "EE49410", 3, "G404753", new DateTime(1994, 10, 3, 0, 0, 0, 0, DateTimeKind.Local), "Cesar_Berge84@yahoo.com", "Cesar", "Berge", "Brunei Darussalam", "(724) 416-3472", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2429,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Angelineville", "EE18929", 2, "G390992", new DateTime(1973, 8, 1, 0, 0, 0, 0, DateTimeKind.Local), "Fannie_Brakus93@hotmail.com", "Fannie", "Brakus", "Haiti", "245.290.7633 x4001" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2430,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Susannaburgh", "EE22125", 2, "G292662", new DateTime(1972, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), "Ashley.Hammes@hotmail.com", "Ashley", "Hammes", "Austria", "509.593.4812 x3469", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2431,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Willland", "EE26033", 3, "G139039", new DateTime(1979, 6, 25, 0, 0, 0, 0, DateTimeKind.Local), "Shane.Graham23@hotmail.com", "Shane", "Graham", "Seychelles", "(313) 611-9835 x20807" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2432,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Rebastad", "EE49560", 1, "G47990", new DateTime(1975, 6, 24, 0, 0, 0, 0, DateTimeKind.Local), "Tabitha.Ondricka@yahoo.com", "Tabitha", "Ondricka", "Czech Republic", "338.229.0822 x6790" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2433,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Matildestad", "EE12082", 1, "G395155", new DateTime(1960, 12, 5, 0, 0, 0, 0, DateTimeKind.Local), "Jane.Padberg@gmail.com", "Jane", "Padberg", "Malawi", "(881) 539-4733 x6210" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2434,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "New Nat", "EE1290", "G303999", new DateTime(1951, 7, 31, 0, 0, 0, 0, DateTimeKind.Local), "Wilfred67@hotmail.com", "Wilfred", "Zulauf", "Angola", "1-548-569-6845 x035", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2435,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Pamela", "EE4167", 2, "G514806", new DateTime(1966, 5, 26, 0, 0, 0, 0, DateTimeKind.Local), "Lowell88@gmail.com", "Lowell", "Ziemann", "Malawi", "(980) 864-1502 x02884" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2436,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Emerson", "EE49980", 1, "G216647", new DateTime(1982, 1, 18, 0, 0, 0, 0, DateTimeKind.Local), "Terrence.Steuber28@hotmail.com", "Terrence", "Steuber", "Grenada", "1-954-323-0030" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2437,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Christa", "EE2222", 3, "G316244", new DateTime(1959, 1, 15, 0, 0, 0, 0, DateTimeKind.Local), "Sabrina.Leffler@yahoo.com", "Sabrina", "Leffler", "Mauritius", "(725) 371-2681" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2438,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "South Lambert", "EE55801", "G585606", new DateTime(1988, 2, 10, 0, 0, 0, 0, DateTimeKind.Local), "Kathy.Gerlach@hotmail.com", "Kathy", "Gerlach", "Uganda", "637.213.0909 x05794" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2439,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Venabury", "EE36031", 3, "G178988", new DateTime(1951, 7, 13, 0, 0, 0, 0, DateTimeKind.Local), "Cathy_Lubowitz59@hotmail.com", "Cathy", "Lubowitz", "Tajikistan", "695.516.4360 x2097", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2440,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Gutkowskiport", "EE19626", 1, "G356888", new DateTime(1974, 11, 10, 0, 0, 0, 0, DateTimeKind.Local), "Mark_Considine86@gmail.com", "Mark", "Considine", "Saudi Arabia", "(815) 771-3417" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2441,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Carterfort", "EE53860", "G80784", new DateTime(1992, 10, 1, 0, 0, 0, 0, DateTimeKind.Local), "Mario85@hotmail.com", "Mario", "Von", "Belize", "1-359-225-5911 x869", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2442,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Ulisesmouth", "EE16974", 4, "G212502", new DateTime(1965, 12, 9, 0, 0, 0, 0, DateTimeKind.Local), "Clara_Anderson@yahoo.com", "Clara", "Anderson", "Niger", "(774) 555-7268 x317", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2443,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "North Rahulville", "EE23038", 3, "G335583", new DateTime(1958, 6, 2, 0, 0, 0, 0, DateTimeKind.Local), "Jodi67@hotmail.com", "Jodi", "O'Kon", "Northern Mariana Islands", "(966) 876-2306" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2444,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Port Stefan", "EE32113", "G413086", new DateTime(2000, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), "Charlotte.Bergnaum68@yahoo.com", "Charlotte", "Bergnaum", "Mali", "414.888.6987" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2445,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Nitzscheland", "EE50407", "G400641", new DateTime(1978, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), "Frankie.Satterfield5@hotmail.com", "Frankie", "Satterfield", "Guinea-Bissau", "775.714.5718 x1941" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2446,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Brionnaside", "EE36004", "G509511", new DateTime(1968, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), "Marie.Dooley60@yahoo.com", "Marie", "Dooley", "Christmas Island", "1-211-867-6344 x98141" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2447,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Laurynstad", "EE50475", 4, "G457358", new DateTime(1974, 1, 18, 0, 0, 0, 0, DateTimeKind.Local), "Julio.Goldner@gmail.com", "Julio", "Goldner", "Antarctica (the territory South of 60 deg S)", "724-922-9198 x178" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2448,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Orlandstad", "EE26272", 1, "G215997", new DateTime(1972, 2, 13, 0, 0, 0, 0, DateTimeKind.Local), "Dominick.Harber1@hotmail.com", "Dominick", "Harber", "Isle of Man", "390-367-4120" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2449,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Florianmouth", "EE11202", 1, "G583487", new DateTime(1953, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), "Edna8@gmail.com", "Edna", "Ritchie", "Denmark", "1-624-920-0990 x489" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2450,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Lake Mckaylamouth", "EE48807", 4, "G261507", new DateTime(1997, 10, 12, 0, 0, 0, 0, DateTimeKind.Local), "Mack_Funk@hotmail.com", "Mack", "Funk", "Lebanon", "1-307-634-4215", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2451,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "McCluretown", "EE39710", 4, "G270899", new DateTime(1997, 6, 18, 0, 0, 0, 0, DateTimeKind.Local), "Rick_Maggio88@hotmail.com", "Rick", "Maggio", "Qatar", "698.230.2810 x98412", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2452,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Bartellville", "EE35110", 1, "G517727", new DateTime(1993, 11, 21, 0, 0, 0, 0, DateTimeKind.Local), "Grant.Ward@hotmail.com", "Grant", "Ward", "Guinea-Bissau", "(870) 339-9098" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2453,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "East Jettview", "EE16739", "G197552", new DateTime(1970, 2, 22, 0, 0, 0, 0, DateTimeKind.Local), "Jake20@gmail.com", "Jake", "Gaylord", "Democratic People's Republic of Korea", "(423) 779-9642 x92633" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2454,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Clementine", "EE38186", 2, "G186933", new DateTime(1984, 5, 3, 0, 0, 0, 0, DateTimeKind.Local), "Andrew.Carter76@gmail.com", "Andrew", "Carter", "Lesotho", "513-977-7128", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2455,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Ludie", "EE3576", 3, "G379823", new DateTime(1956, 7, 11, 0, 0, 0, 0, DateTimeKind.Local), "Rufus.Runte@hotmail.com", "Rufus", "Runte", "Sao Tome and Principe", "1-685-771-7062" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2456,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Jodyfurt", "EE46007", 3, "G193916", new DateTime(1995, 1, 6, 0, 0, 0, 0, DateTimeKind.Local), "Josefina96@hotmail.com", "Josefina", "Crooks", "Tokelau", "770.302.7287" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2457,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Tessview", "EE34120", "G391706", new DateTime(1956, 2, 8, 0, 0, 0, 0, DateTimeKind.Local), "Faye.DAmore20@gmail.com", "Faye", "D'Amore", "British Indian Ocean Territory (Chagos Archipelago)", "581.991.3296" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2458,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Fayfort", "EE11839", 1, "G378473", new DateTime(1967, 6, 5, 0, 0, 0, 0, DateTimeKind.Local), "Loren86@yahoo.com", "Loren", "Klein", "Guam", "935.677.1065 x3379", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2459,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Garrick", "EE41940", 3, "G237916", new DateTime(1991, 9, 21, 0, 0, 0, 0, DateTimeKind.Local), "Jenny.Sauer90@hotmail.com", "Jenny", "Sauer", "Trinidad and Tobago", "1-533-734-3484" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2460,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Sterlingside", "EE30048", 1, "G100995", new DateTime(1957, 10, 31, 0, 0, 0, 0, DateTimeKind.Local), "Edmund_Ratke@gmail.com", "Edmund", "Ratke", "Bolivia", "(439) 275-5566 x6551" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2461,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Keelingmouth", "EE52643", 4, "G38621", new DateTime(1977, 7, 23, 0, 0, 0, 0, DateTimeKind.Local), "Alfonso_Mosciski@hotmail.com", "Alfonso", "Mosciski", "Palau", "1-213-683-5656", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2462,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Dickinsonfurt", "EE31653", 3, "G551609", new DateTime(1957, 12, 10, 0, 0, 0, 0, DateTimeKind.Local), "Jake_Wisozk@gmail.com", "Jake", "Wisozk", "China", "1-968-644-4084", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2463,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Swiftside", "EE24963", 2, "G160561", new DateTime(1963, 10, 23, 0, 0, 0, 0, DateTimeKind.Local), "Greg_Keebler@gmail.com", "Greg", "Keebler", "Sierra Leone", "1-565-407-8932 x7086" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2464,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "West Euna", "EE9957", 4, "G199324", new DateTime(1955, 10, 21, 0, 0, 0, 0, DateTimeKind.Local), "Camille41@hotmail.com", "Camille", "Waelchi", "Georgia", "980.901.1330 x35581" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2465,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Chaimstad", "EE39858", 3, "G532853", new DateTime(1978, 10, 8, 0, 0, 0, 0, DateTimeKind.Local), "Blanca_Gorczany48@gmail.com", "Blanca", "Gorczany", "Uzbekistan", "(334) 816-3401 x939", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2466,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Cassinstad", "EE54830", 1, "G334762", new DateTime(1973, 10, 9, 0, 0, 0, 0, DateTimeKind.Local), "Rita3@hotmail.com", "Rita", "Kuvalis", "Uganda", "1-388-524-8339 x8662" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2467,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "New Elwinport", "EE25717", "G160201", new DateTime(1984, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), "Jacqueline_Conroy83@yahoo.com", "Jacqueline", "Conroy", "Slovenia", "460-285-2400 x91505", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2468,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "New Rebekah", "EE37423", 2, "G222619", new DateTime(1989, 6, 16, 0, 0, 0, 0, DateTimeKind.Local), "Cameron.Becker57@hotmail.com", "Cameron", "Becker", "Saint Martin", "1-669-520-6342", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2469,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Devin", "EE49044", 3, "G536119", new DateTime(1956, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), "Aaron_Bauch44@hotmail.com", "Aaron", "Bauch", "Ireland", "363.707.2177 x24089", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2470,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "East Amos", "EE26409", 3, "G574621", new DateTime(1999, 7, 16, 0, 0, 0, 0, DateTimeKind.Local), "Roman_Collins91@yahoo.com", "Roman", "Collins", "Namibia", "326.739.0768 x2114" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2471,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Ruben", "EE2560", 3, "G426078", new DateTime(1957, 6, 15, 0, 0, 0, 0, DateTimeKind.Local), "Sharon_Jast@hotmail.com", "Sharon", "Jast", "Moldova", "286-498-8515 x22953" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2472,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Francofort", "EE35107", "G225181", new DateTime(1978, 12, 9, 0, 0, 0, 0, DateTimeKind.Local), "Silvia.Larkin7@hotmail.com", "Silvia", "Larkin", "Nepal", "456-963-0949", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2473,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Fidelfort", "EE13641", 2, "G391559", new DateTime(1959, 6, 24, 0, 0, 0, 0, DateTimeKind.Local), "Walter_Johns@hotmail.com", "Walter", "Johns", "Liechtenstein", "899-491-7638 x7421", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2474,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "New Lottieside", "EE33442", 4, "G594964", new DateTime(1959, 2, 12, 0, 0, 0, 0, DateTimeKind.Local), "Veronica59@gmail.com", "Veronica", "O'Kon", "Tonga", "1-353-372-9639 x4225", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2475,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Darenmouth", "EE21356", "G31710", new DateTime(1987, 4, 25, 0, 0, 0, 0, DateTimeKind.Local), "Desiree_Mante@gmail.com", "Desiree", "Mante", "Saint Kitts and Nevis", "279.353.1197 x8418", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2476,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Jimmyville", "EE3799", 1, "G184196", new DateTime(1972, 9, 9, 0, 0, 0, 0, DateTimeKind.Local), "Jackie.Zboncak39@yahoo.com", "Jackie", "Zboncak", "Kenya", "(546) 542-6383 x344", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2477,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Haagton", "EE40346", 3, "G190036", new DateTime(1992, 11, 20, 0, 0, 0, 0, DateTimeKind.Local), "Amy.Rolfson@gmail.com", "Amy", "Rolfson", "Djibouti", "(308) 820-8656 x44108", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2478,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Chesterborough", "EE7318", 4, "G498375", new DateTime(1981, 3, 14, 0, 0, 0, 0, DateTimeKind.Local), "Martha.Block@gmail.com", "Martha", "Block", "French Southern Territories", "948.449.4037", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2479,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Fayeport", "EE36837", "G579190", new DateTime(1969, 6, 10, 0, 0, 0, 0, DateTimeKind.Local), "Johnnie.Schowalter@hotmail.com", "Johnnie", "Schowalter", "Western Sahara", "299-520-2950 x007", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2480,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Ellie", "EE59277", 4, "G120985", new DateTime(1955, 8, 24, 0, 0, 0, 0, DateTimeKind.Local), "Cynthia_Fisher72@gmail.com", "Cynthia", "Fisher", "Solomon Islands", "215.992.9337 x611", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2481,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Esmeralda", "EE56853", 3, "G430277", new DateTime(1990, 12, 27, 0, 0, 0, 0, DateTimeKind.Local), "Sheila_Johnston@hotmail.com", "Sheila", "Johnston", "Qatar", "972-410-4367 x8462", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2482,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "South Conorborough", "EE55961", 1, "G338851", new DateTime(1968, 12, 14, 0, 0, 0, 0, DateTimeKind.Local), "Holly3@hotmail.com", "Holly", "Corkery", "Croatia", "442.402.9732 x563", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2483,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Jonasfurt", "EE58547", "G215308", new DateTime(1989, 11, 6, 0, 0, 0, 0, DateTimeKind.Local), "Pamela.Watsica@yahoo.com", "Pamela", "Watsica", "China", "810-613-3467 x6238", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2484,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Beiershire", "EE35326", 3, "G487631", new DateTime(1997, 1, 2, 0, 0, 0, 0, DateTimeKind.Local), "Angelica88@hotmail.com", "Angelica", "Koch", "Pitcairn Islands", "1-211-958-7010 x7784" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2485,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "West Barrett", "EE20508", 4, "G537980", new DateTime(1963, 11, 3, 0, 0, 0, 0, DateTimeKind.Local), "Brendan.Sawayn15@gmail.com", "Brendan", "Sawayn", "New Caledonia", "711-479-9136 x5533", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2486,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "New Leanna", "EE49649", 1, "G306104", new DateTime(1963, 5, 13, 0, 0, 0, 0, DateTimeKind.Local), "Jerome_DuBuque41@yahoo.com", "Jerome", "DuBuque", "Netherlands", "701.955.4739" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2487,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Monahanfort", "EE46356", 3, "G177566", new DateTime(1972, 5, 25, 0, 0, 0, 0, DateTimeKind.Local), "Cristina.Daugherty15@hotmail.com", "Cristina", "Daugherty", "Republic of Korea", "501-410-3124", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2488,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Hesselview", "EE26670", 1, "G257403", new DateTime(1972, 10, 26, 0, 0, 0, 0, DateTimeKind.Local), "Willie.Feest0@gmail.com", "Willie", "Feest", "Greece", "351.399.4931 x78414", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2489,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Guillermo", "EE25061", 4, "G225121", new DateTime(1967, 2, 28, 0, 0, 0, 0, DateTimeKind.Local), "Jody.White2@yahoo.com", "Jody", "White", "Northern Mariana Islands", "988-866-1544 x195", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2490,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Hillsmouth", "EE54786", "G288350", new DateTime(1983, 4, 25, 0, 0, 0, 0, DateTimeKind.Local), "Leon17@gmail.com", "Leon", "Wisozk", "Lebanon", "1-255-532-0910 x899", "Male" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2491,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Gleichnerburgh", "EE55782", 2, "G99138", new DateTime(1972, 9, 21, 0, 0, 0, 0, DateTimeKind.Local), "Nadine_Aufderhar@gmail.com", "Nadine", "Aufderhar", "Latvia", "1-964-423-0546", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2492,
                columns: new[] { "address", "cin", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Sarinaside", "EE5305", "G355087", new DateTime(1963, 4, 6, 0, 0, 0, 0, DateTimeKind.Local), "Sarah69@gmail.com", "Sarah", "Herzog", "Burundi", "1-754-841-8452 x2642" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2493,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lisandromouth", "EE52883", 1, "G271266", new DateTime(1989, 9, 27, 0, 0, 0, 0, DateTimeKind.Local), "Monique_Langworth93@gmail.com", "Monique", "Langworth", "Kiribati", "936-855-9689" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2494,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Port Ambrosechester", "EE59607", 2, "G445073", new DateTime(1958, 11, 4, 0, 0, 0, 0, DateTimeKind.Local), "Courtney_Hane70@gmail.com", "Courtney", "Hane", "Nauru", "1-825-976-8812 x91858" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2495,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Lake Heavenfort", "EE24835", 2, "G420078", new DateTime(1984, 10, 13, 0, 0, 0, 0, DateTimeKind.Local), "Curtis55@hotmail.com", "Curtis", "Gorczany", "Rwanda", "(580) 652-9472 x19913" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2496,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "North Aracelychester", "EE40472", 1, "G476260", new DateTime(1959, 7, 23, 0, 0, 0, 0, DateTimeKind.Local), "Marlene_Keeling55@yahoo.com", "Marlene", "Keeling", "Djibouti", "847-784-9236", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2497,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone" },
                values: new object[] { "Harriston", "EE16338", 4, "G396820", new DateTime(1960, 10, 15, 0, 0, 0, 0, DateTimeKind.Local), "Donald63@gmail.com", "Donald", "Lakin", "Moldova", "1-310-875-3719 x23940" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2498,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Pfefferhaven", "EE11372", 2, "G249735", new DateTime(1978, 4, 22, 0, 0, 0, 0, DateTimeKind.Local), "Jodi43@yahoo.com", "Jodi", "Cormier", "Tunisia", "1-747-820-3725 x187", "Female" });

            migrationBuilder.UpdateData(
                table: "Etudiants",
                keyColumn: "apogee",
                keyValue: 2499,
                columns: new[] { "address", "cin", "classeId", "cne", "ddn", "email", "firstname", "lastname", "natio", "phone", "sexe" },
                values: new object[] { "Klingberg", "EE3734", 3, "G230520", new DateTime(1975, 8, 1, 0, 0, 0, 0, DateTimeKind.Local), "Leah.Predovic@gmail.com", "Leah", "Predovic", "Faroe Islands", "(941) 244-9316", "Female" });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "nom", "professeurId" },
                values: new object[] { "Tools, Home & Toys streamline mint green", 10 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "nom", "professeurId" },
                values: new object[] { "Cambridgeshire killer Investment Account", 10 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "nom", "professeurId" },
                values: new object[] { "Facilitator New Hampshire users", 7 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "classeId", "nom", "professeurId" },
                values: new object[] { 3, "Savings Account Colorado zero administration", 20 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "classeId", "nom" },
                values: new object[] { 4, "collaborative Regional Incredible Concrete Fish" });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "classeId", "nom", "professeurId" },
                values: new object[] { 3, "compress Canadian Dollar Handmade", 16 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "classeId", "nom", "professeurId" },
                values: new object[] { 4, "B2C Grove Home & Sports", 11 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "classeId", "nom", "professeurId" },
                values: new object[] { 3, "Money Market Account online Metal", 2 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "classeId", "nom", "professeurId" },
                values: new object[] { 2, "Cambridgeshire calculate Stravenue", 14 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "classeId", "nom", "professeurId" },
                values: new object[] { 3, "Supervisor indexing Soft", 13 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "classeId", "nom", "professeurId" },
                values: new object[] { 1, "Investment Account green Markets", 4 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "classeId", "nom", "professeurId" },
                values: new object[] { 2, "SQL Soft Gorgeous Wooden Chair", 2 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "classeId", "nom", "professeurId" },
                values: new object[] { 3, "multi-tasking Quality Philippine Peso", 20 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "classeId", "nom", "professeurId" },
                values: new object[] { 2, "Dominican Republic Sports, Jewelery & Jewelery Synergistic", 17 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "classeId", "nom", "professeurId" },
                values: new object[] { 2, "Handmade Steel Pizza Rhode Island cross-platform", 19 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "nom", "professeurId" },
                values: new object[] { "CFA Franc BCEAO navigating Pataca", 21 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "classeId", "nom", "professeurId" },
                values: new object[] { 1, "Data Indiana cutting-edge", 22 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "classeId", "nom", "professeurId" },
                values: new object[] { 3, "Group clicks-and-mortar District", 12 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "classeId", "nom", "professeurId" },
                values: new object[] { 4, "Electronics, Sports & Tools Regional Program", 9 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "classeId", "nom", "professeurId" },
                values: new object[] { 4, "circuit Burkina Faso well-modulated", 16 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "nom", "professeurId" },
                values: new object[] { "programming navigate Versatile", 8 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "classeId", "nom", "professeurId" },
                values: new object[] { 2, "Regional array info-mediaries", 8 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "classeId", "nom", "professeurId" },
                values: new object[] { 2, "Incredible Frozen Ball Practical Rubber Bike Toys", 1 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "nom", "professeurId" },
                values: new object[] { "analyzer Incredible Granite Soap Forge", 8 });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "NotePdfUrl", "moduleId", "semestre" },
                values: new object[] { "A", 2, "2" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "NotePdfUrl", "moduleId", "semestre" },
                values: new object[] { "A", 15, "1" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "NotePdfUrl", "moduleId", "semestre" },
                values: new object[] { "C", 13, "2" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "NotePdfUrl", "semestre" },
                values: new object[] { "A", "2" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "NotePdfUrl", "moduleId", "semestre" },
                values: new object[] { "B", 24, "2" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 6,
                column: "moduleId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "NotePdfUrl", "semestre" },
                values: new object[] { "A", "1" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "moduleId", "semestre" },
                values: new object[] { 7, "1" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "NotePdfUrl", "moduleId", "semestre" },
                values: new object[] { "C", 8, "1" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "NotePdfUrl", "moduleId", "semestre" },
                values: new object[] { "C", 20, "0" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "NotePdfUrl", "moduleId", "semestre" },
                values: new object[] { "C", 4, "2" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "NotePdfUrl", "moduleId", "semestre" },
                values: new object[] { "A", 4, "1" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "NotePdfUrl", "moduleId", "semestre" },
                values: new object[] { "A", 24, "2" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "moduleId", "semestre" },
                values: new object[] { 1, "2" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "moduleId", "semestre" },
                values: new object[] { 4, "2" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "NotePdfUrl", "moduleId" },
                values: new object[] { "A", 4 });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 17,
                column: "moduleId",
                value: 16);

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "NotePdfUrl", "moduleId", "semestre" },
                values: new object[] { "C", 17, "0" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "NotePdfUrl", "moduleId" },
                values: new object[] { "C", 11 });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "NotePdfUrl", "moduleId", "semestre" },
                values: new object[] { "A", 21, "1" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "NotePdfUrl", "moduleId", "semestre" },
                values: new object[] { "C", 24, "1" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "NotePdfUrl", "moduleId", "semestre" },
                values: new object[] { "C", 5, "2" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "NotePdfUrl", "semestre" },
                values: new object[] { "C", "1" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "NotePdfUrl", "moduleId", "semestre" },
                values: new object[] { "B", 21, "0" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "NotePdfUrl", "moduleId", "semestre" },
                values: new object[] { "B", 15, "0" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "email", "login", "nom", "prenom" },
                values: new object[] { "Diana_Lynch@gmail.com", "synthesizing", "Lynch", "Diana" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "departementId", "email", "login", "nom", "prenom" },
                values: new object[] { 1, "Charlotte_Anderson86@hotmail.com", "Clothing & Music", "Anderson", "Charlotte" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "departementId", "email", "login", "nom", "prenom" },
                values: new object[] { 2, "Marcia.Spinka64@gmail.com", "Maine", "Spinka", "Marcia" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "email", "login", "nom", "prenom" },
                values: new object[] { "Shelia_Ziemann@gmail.com", "Division", "Ziemann", "Shelia" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "departementId", "email", "login", "nom", "prenom" },
                values: new object[] { 1, "Irving_Corkery81@hotmail.com", "mission-critical", "Corkery", "Irving" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "departementId", "email", "login", "nom", "prenom" },
                values: new object[] { 2, "Sandy.Legros55@hotmail.com", "Mountains", "Legros", "Sandy" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "email", "login", "nom", "prenom" },
                values: new object[] { "Camille_Grant@yahoo.com", "sky blue", "Grant", "Camille" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "email", "login", "nom", "prenom" },
                values: new object[] { "Joan80@gmail.com", "Fantastic Granite Bike", "Reilly", "Joan" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "departementId", "email", "login", "nom", "prenom" },
                values: new object[] { 1, "Kenneth_Reichert54@gmail.com", "index", "Reichert", "Kenneth" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "departementId", "email", "login", "nom", "prenom" },
                values: new object[] { 1, "Muriel5@yahoo.com", "European Unit of Account 17(E.U.A.-17)", "Wehner", "Muriel" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "email", "login", "nom", "prenom" },
                values: new object[] { "Adam91@yahoo.com", "solutions", "Christiansen", "Adam" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "departementId", "email", "login", "nom", "prenom" },
                values: new object[] { 2, "May_Emard88@gmail.com", "Inverse", "Emard", "May" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "email", "login", "nom", "prenom" },
                values: new object[] { "Jamie98@hotmail.com", "Technician", "Bernhard", "Jamie" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "departementId", "email", "login", "nom", "prenom" },
                values: new object[] { 2, "Josh18@gmail.com", "override", "Zieme", "Josh" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "departementId", "email", "login", "nom", "prenom" },
                values: new object[] { 2, "Jan98@gmail.com", "Small Frozen Shirt", "Abshire", "Jan" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "email", "login", "nom", "prenom" },
                values: new object[] { "Lindsey.Carroll80@hotmail.com", "Kroon", "Carroll", "Lindsey" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "email", "login", "nom", "prenom" },
                values: new object[] { "Darrel_Cremin42@gmail.com", "emulation", "Cremin", "Darrel" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "email", "login", "nom", "prenom" },
                values: new object[] { "Ernest.Sipes85@yahoo.com", "Human", "Sipes", "Ernest" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "departementId", "email", "login", "nom", "prenom" },
                values: new object[] { 1, "Bennie_Steuber47@gmail.com", "Uzbekistan Sum", "Steuber", "Bennie" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "departementId", "email", "login", "nom", "prenom" },
                values: new object[] { 1, "Edwin.Carter@hotmail.com", "Iran", "Carter", "Edwin" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "departementId", "email", "login", "nom", "prenom" },
                values: new object[] { 1, "Dexter.Trantow20@hotmail.com", "sky blue", "Trantow", "Dexter" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "email", "login", "nom", "prenom" },
                values: new object[] { "Leslie_Feeney18@hotmail.com", "metrics", "Feeney", "Leslie" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "departementId", "email", "login", "nom", "prenom" },
                values: new object[] { 2, "Fannie.Bartoletti@yahoo.com", "full-range", "Bartoletti", "Fannie" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "departementId", "email", "login", "nom", "prenom" },
                values: new object[] { 1, "Charles.Abernathy86@gmail.com", "Intelligent", "Abernathy", "Charles" });

            migrationBuilder.UpdateData(
                table: "Professeurs",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "departementId", "email", "login", "nom", "prenom" },
                values: new object[] { 2, "Sophie_Keeling2@hotmail.com", "Congolese Franc", "Keeling", "Sophie" });

            migrationBuilder.UpdateData(
                table: "classes",
                keyColumn: "id",
                keyValue: 1,
                column: "filiereId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "classes",
                keyColumn: "id",
                keyValue: 2,
                column: "filiereId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "classes",
                keyColumn: "id",
                keyValue: 3,
                column: "filiereId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "classes",
                keyColumn: "id",
                keyValue: 4,
                column: "filiereId",
                value: 1);
        }
    }
}
