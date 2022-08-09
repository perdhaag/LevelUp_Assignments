using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DjHaag.Persitence.Migrations
{
    public partial class SeedDatabaseMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CompetenceMatrices",
                columns: new[] { "Id", "CompetenceMatricesCategory" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 },
                    { 4, 4 },
                    { 5, 5 },
                    { 6, 6 },
                    { 7, 7 },
                    { 8, 8 },
                    { 9, 9 },
                    { 10, 10 },
                    { 11, 11 },
                    { 12, 12 },
                    { 13, 13 },
                    { 14, 14 }
                });

            migrationBuilder.InsertData(
                table: "CategoryThemes",
                columns: new[] { "Id", "CompetenceMatriceId", "Theme" },
                values: new object[,]
                {
                    { 1, 1, ".NET" },
                    { 2, 1, ".NET Core" },
                    { 3, 1, ".ASP.NET Webforms" },
                    { 4, 1, ".ASP.NET MVC" },
                    { 5, 1, "ASP.NET WebAPI" },
                    { 6, 1, "WCF" },
                    { 7, 1, "F#" },
                    { 8, 1, "PowerShell" },
                    { 9, 1, "Andre jeg kjenner godt" },
                    { 10, 2, "SCRUM" },
                    { 11, 2, "KANBAN" },
                    { 12, 2, "TDD" },
                    { 13, 2, "DDD" },
                    { 14, 2, "Design patterns" },
                    { 15, 2, "SOLID / Clean code" },
                    { 16, 2, "Microservices" },
                    { 17, 2, "Serverless" },
                    { 18, 2, "Andre jeg kjenner godt" },
                    { 19, 3, "HTML" },
                    { 20, 3, "CSS" },
                    { 21, 3, "Angular < v1" },
                    { 22, 3, "Angular > v2" },
                    { 23, 3, "Angular Store" },
                    { 24, 3, "React" },
                    { 25, 3, "Redux" },
                    { 26, 3, "JQuery" },
                    { 27, 3, "Vue" },
                    { 28, 3, "Knockout" },
                    { 29, 3, "TypeScript" },
                    { 30, 3, "Node.JS" },
                    { 31, 3, "Andre jeg kjenner godt" },
                    { 32, 4, "Karma" },
                    { 33, 4, "Jasmin" },
                    { 34, 4, "Selenium" },
                    { 35, 4, "Chutzpah" },
                    { 36, 4, "Andre jeg kjenner godt" },
                    { 37, 5, "Entity Framework" },
                    { 38, 5, "Dapper" },
                    { 39, 5, "NHibernate" },
                    { 40, 5, "Linq to SQL" },
                    { 41, 5, "Andre jeg kjenner godt" },
                    { 42, 6, "NUnit" }
                });

            migrationBuilder.InsertData(
                table: "CategoryThemes",
                columns: new[] { "Id", "CompetenceMatriceId", "Theme" },
                values: new object[,]
                {
                    { 43, 6, "MSTest" },
                    { 44, 6, "XUnit" },
                    { 45, 6, "RhinoMocks" },
                    { 46, 6, "Moq" },
                    { 47, 6, "FakeItEasy" },
                    { 48, 6, "Andre jeg kjenner godt" },
                    { 49, 7, "NServiceBus" },
                    { 50, 7, "Azure Service Bus" },
                    { 51, 7, "MassTransit" },
                    { 52, 7, "Kafka" },
                    { 53, 7, "MSMQ" },
                    { 54, 7, "RabbitMQ" },
                    { 55, 7, "Andre jeg kjenner godt" },
                    { 56, 8, "TeamCity" },
                    { 57, 8, "TFS/Visual Studio Team Services" },
                    { 58, 8, "Bamboo" },
                    { 59, 8, "Octopus Deploy" },
                    { 60, 8, "Jenkins" },
                    { 61, 8, "Docker" },
                    { 62, 8, "Cake/Psake" },
                    { 63, 8, "Kubernetes" },
                    { 64, 8, "Azure Devops" },
                    { 65, 8, "Andre jeg kjenner godt" },
                    { 66, 9, "Azure Virtual Machines" },
                    { 67, 9, "Azure App Services" },
                    { 68, 9, "Azure Storage" },
                    { 69, 9, "Azure Cosmos DB" },
                    { 70, 9, "Azure Redis Cache" },
                    { 71, 9, "Azure Event Hub" },
                    { 72, 9, "Azure Functions" },
                    { 73, 9, "Azure CLI" },
                    { 74, 9, "Andre jeg kjenner godt" },
                    { 75, 10, "ElasticSearch" },
                    { 76, 10, "Kibana" },
                    { 77, 10, "LogStash" },
                    { 78, 10, "Redis" },
                    { 79, 10, "Apache Solr" },
                    { 80, 10, "Apache Hadoop" },
                    { 81, 10, "Andre jeg kjenner godt" },
                    { 82, 11, ".NET Core Dependancy Injection" },
                    { 83, 11, "Autofac" },
                    { 84, 11, "Ninjext" }
                });

            migrationBuilder.InsertData(
                table: "CategoryThemes",
                columns: new[] { "Id", "CompetenceMatriceId", "Theme" },
                values: new object[,]
                {
                    { 85, 11, "Unity" },
                    { 86, 11, "StructureMap" },
                    { 87, 11, "Windsor" },
                    { 88, 11, "Andre jeg kjenner godt" },
                    { 89, 12, "OWASP" },
                    { 90, 12, "Identity Server" },
                    { 91, 12, "Auth0" },
                    { 92, 12, "OAuth" },
                    { 93, 12, "OpenId Connect" },
                    { 94, 12, "ASP.NET Membership" },
                    { 95, 12, "Andre jeg kjenner godt til" },
                    { 96, 13, "log4net" },
                    { 97, 13, "NLog" },
                    { 98, 13, "Serilog" },
                    { 99, 13, "Azure Application Insights" },
                    { 100, 13, "Andre jeg kjenner godt til" },
                    { 101, 14, "Nancy" },
                    { 102, 14, "ServiceStack" },
                    { 103, 14, "React Native" },
                    { 104, 14, "Xamarin" },
                    { 105, 14, "Mobilapp (native)" },
                    { 106, 14, "Andre jeg kjenner godt" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "CategoryThemes",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "CompetenceMatrices",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CompetenceMatrices",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CompetenceMatrices",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CompetenceMatrices",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CompetenceMatrices",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CompetenceMatrices",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CompetenceMatrices",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CompetenceMatrices",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "CompetenceMatrices",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "CompetenceMatrices",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "CompetenceMatrices",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "CompetenceMatrices",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "CompetenceMatrices",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "CompetenceMatrices",
                keyColumn: "Id",
                keyValue: 14);
        }
    }
}
