﻿// <auto-generated />
using DjHaag.Persitence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DjHaag.Persitence.Migrations
{
    [DbContext(typeof(DjHaagDbContext))]
    [Migration("20220809114216_SeedDatabaseMigration")]
    partial class SeedDatabaseMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DjHaag.Persitence.CategoryTheme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CompetenceMatriceId")
                        .HasColumnType("int");

                    b.Property<string>("Theme")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CompetenceMatriceId");

                    b.ToTable("CategoryThemes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CompetenceMatriceId = 1,
                            Theme = ".NET"
                        },
                        new
                        {
                            Id = 2,
                            CompetenceMatriceId = 1,
                            Theme = ".NET Core"
                        },
                        new
                        {
                            Id = 3,
                            CompetenceMatriceId = 1,
                            Theme = ".ASP.NET Webforms"
                        },
                        new
                        {
                            Id = 4,
                            CompetenceMatriceId = 1,
                            Theme = ".ASP.NET MVC"
                        },
                        new
                        {
                            Id = 5,
                            CompetenceMatriceId = 1,
                            Theme = "ASP.NET WebAPI"
                        },
                        new
                        {
                            Id = 6,
                            CompetenceMatriceId = 1,
                            Theme = "WCF"
                        },
                        new
                        {
                            Id = 7,
                            CompetenceMatriceId = 1,
                            Theme = "F#"
                        },
                        new
                        {
                            Id = 8,
                            CompetenceMatriceId = 1,
                            Theme = "PowerShell"
                        },
                        new
                        {
                            Id = 9,
                            CompetenceMatriceId = 1,
                            Theme = "Andre jeg kjenner godt"
                        },
                        new
                        {
                            Id = 10,
                            CompetenceMatriceId = 2,
                            Theme = "SCRUM"
                        },
                        new
                        {
                            Id = 11,
                            CompetenceMatriceId = 2,
                            Theme = "KANBAN"
                        },
                        new
                        {
                            Id = 12,
                            CompetenceMatriceId = 2,
                            Theme = "TDD"
                        },
                        new
                        {
                            Id = 13,
                            CompetenceMatriceId = 2,
                            Theme = "DDD"
                        },
                        new
                        {
                            Id = 14,
                            CompetenceMatriceId = 2,
                            Theme = "Design patterns"
                        },
                        new
                        {
                            Id = 15,
                            CompetenceMatriceId = 2,
                            Theme = "SOLID / Clean code"
                        },
                        new
                        {
                            Id = 16,
                            CompetenceMatriceId = 2,
                            Theme = "Microservices"
                        },
                        new
                        {
                            Id = 17,
                            CompetenceMatriceId = 2,
                            Theme = "Serverless"
                        },
                        new
                        {
                            Id = 18,
                            CompetenceMatriceId = 2,
                            Theme = "Andre jeg kjenner godt"
                        },
                        new
                        {
                            Id = 19,
                            CompetenceMatriceId = 3,
                            Theme = "HTML"
                        },
                        new
                        {
                            Id = 20,
                            CompetenceMatriceId = 3,
                            Theme = "CSS"
                        },
                        new
                        {
                            Id = 21,
                            CompetenceMatriceId = 3,
                            Theme = "Angular < v1"
                        },
                        new
                        {
                            Id = 22,
                            CompetenceMatriceId = 3,
                            Theme = "Angular > v2"
                        },
                        new
                        {
                            Id = 23,
                            CompetenceMatriceId = 3,
                            Theme = "Angular Store"
                        },
                        new
                        {
                            Id = 24,
                            CompetenceMatriceId = 3,
                            Theme = "React"
                        },
                        new
                        {
                            Id = 25,
                            CompetenceMatriceId = 3,
                            Theme = "Redux"
                        },
                        new
                        {
                            Id = 26,
                            CompetenceMatriceId = 3,
                            Theme = "JQuery"
                        },
                        new
                        {
                            Id = 27,
                            CompetenceMatriceId = 3,
                            Theme = "Vue"
                        },
                        new
                        {
                            Id = 28,
                            CompetenceMatriceId = 3,
                            Theme = "Knockout"
                        },
                        new
                        {
                            Id = 29,
                            CompetenceMatriceId = 3,
                            Theme = "TypeScript"
                        },
                        new
                        {
                            Id = 30,
                            CompetenceMatriceId = 3,
                            Theme = "Node.JS"
                        },
                        new
                        {
                            Id = 31,
                            CompetenceMatriceId = 3,
                            Theme = "Andre jeg kjenner godt"
                        },
                        new
                        {
                            Id = 32,
                            CompetenceMatriceId = 4,
                            Theme = "Karma"
                        },
                        new
                        {
                            Id = 33,
                            CompetenceMatriceId = 4,
                            Theme = "Jasmin"
                        },
                        new
                        {
                            Id = 34,
                            CompetenceMatriceId = 4,
                            Theme = "Selenium"
                        },
                        new
                        {
                            Id = 35,
                            CompetenceMatriceId = 4,
                            Theme = "Chutzpah"
                        },
                        new
                        {
                            Id = 36,
                            CompetenceMatriceId = 4,
                            Theme = "Andre jeg kjenner godt"
                        },
                        new
                        {
                            Id = 37,
                            CompetenceMatriceId = 5,
                            Theme = "Entity Framework"
                        },
                        new
                        {
                            Id = 38,
                            CompetenceMatriceId = 5,
                            Theme = "Dapper"
                        },
                        new
                        {
                            Id = 39,
                            CompetenceMatriceId = 5,
                            Theme = "NHibernate"
                        },
                        new
                        {
                            Id = 40,
                            CompetenceMatriceId = 5,
                            Theme = "Linq to SQL"
                        },
                        new
                        {
                            Id = 41,
                            CompetenceMatriceId = 5,
                            Theme = "Andre jeg kjenner godt"
                        },
                        new
                        {
                            Id = 42,
                            CompetenceMatriceId = 6,
                            Theme = "NUnit"
                        },
                        new
                        {
                            Id = 43,
                            CompetenceMatriceId = 6,
                            Theme = "MSTest"
                        },
                        new
                        {
                            Id = 44,
                            CompetenceMatriceId = 6,
                            Theme = "XUnit"
                        },
                        new
                        {
                            Id = 45,
                            CompetenceMatriceId = 6,
                            Theme = "RhinoMocks"
                        },
                        new
                        {
                            Id = 46,
                            CompetenceMatriceId = 6,
                            Theme = "Moq"
                        },
                        new
                        {
                            Id = 47,
                            CompetenceMatriceId = 6,
                            Theme = "FakeItEasy"
                        },
                        new
                        {
                            Id = 48,
                            CompetenceMatriceId = 6,
                            Theme = "Andre jeg kjenner godt"
                        },
                        new
                        {
                            Id = 49,
                            CompetenceMatriceId = 7,
                            Theme = "NServiceBus"
                        },
                        new
                        {
                            Id = 50,
                            CompetenceMatriceId = 7,
                            Theme = "Azure Service Bus"
                        },
                        new
                        {
                            Id = 51,
                            CompetenceMatriceId = 7,
                            Theme = "MassTransit"
                        },
                        new
                        {
                            Id = 52,
                            CompetenceMatriceId = 7,
                            Theme = "Kafka"
                        },
                        new
                        {
                            Id = 53,
                            CompetenceMatriceId = 7,
                            Theme = "MSMQ"
                        },
                        new
                        {
                            Id = 54,
                            CompetenceMatriceId = 7,
                            Theme = "RabbitMQ"
                        },
                        new
                        {
                            Id = 55,
                            CompetenceMatriceId = 7,
                            Theme = "Andre jeg kjenner godt"
                        },
                        new
                        {
                            Id = 56,
                            CompetenceMatriceId = 8,
                            Theme = "TeamCity"
                        },
                        new
                        {
                            Id = 57,
                            CompetenceMatriceId = 8,
                            Theme = "TFS/Visual Studio Team Services"
                        },
                        new
                        {
                            Id = 58,
                            CompetenceMatriceId = 8,
                            Theme = "Bamboo"
                        },
                        new
                        {
                            Id = 59,
                            CompetenceMatriceId = 8,
                            Theme = "Octopus Deploy"
                        },
                        new
                        {
                            Id = 60,
                            CompetenceMatriceId = 8,
                            Theme = "Jenkins"
                        },
                        new
                        {
                            Id = 61,
                            CompetenceMatriceId = 8,
                            Theme = "Docker"
                        },
                        new
                        {
                            Id = 62,
                            CompetenceMatriceId = 8,
                            Theme = "Cake/Psake"
                        },
                        new
                        {
                            Id = 63,
                            CompetenceMatriceId = 8,
                            Theme = "Kubernetes"
                        },
                        new
                        {
                            Id = 64,
                            CompetenceMatriceId = 8,
                            Theme = "Azure Devops"
                        },
                        new
                        {
                            Id = 65,
                            CompetenceMatriceId = 8,
                            Theme = "Andre jeg kjenner godt"
                        },
                        new
                        {
                            Id = 66,
                            CompetenceMatriceId = 9,
                            Theme = "Azure Virtual Machines"
                        },
                        new
                        {
                            Id = 67,
                            CompetenceMatriceId = 9,
                            Theme = "Azure App Services"
                        },
                        new
                        {
                            Id = 68,
                            CompetenceMatriceId = 9,
                            Theme = "Azure Storage"
                        },
                        new
                        {
                            Id = 69,
                            CompetenceMatriceId = 9,
                            Theme = "Azure Cosmos DB"
                        },
                        new
                        {
                            Id = 70,
                            CompetenceMatriceId = 9,
                            Theme = "Azure Redis Cache"
                        },
                        new
                        {
                            Id = 71,
                            CompetenceMatriceId = 9,
                            Theme = "Azure Event Hub"
                        },
                        new
                        {
                            Id = 72,
                            CompetenceMatriceId = 9,
                            Theme = "Azure Functions"
                        },
                        new
                        {
                            Id = 73,
                            CompetenceMatriceId = 9,
                            Theme = "Azure CLI"
                        },
                        new
                        {
                            Id = 74,
                            CompetenceMatriceId = 9,
                            Theme = "Andre jeg kjenner godt"
                        },
                        new
                        {
                            Id = 75,
                            CompetenceMatriceId = 10,
                            Theme = "ElasticSearch"
                        },
                        new
                        {
                            Id = 76,
                            CompetenceMatriceId = 10,
                            Theme = "Kibana"
                        },
                        new
                        {
                            Id = 77,
                            CompetenceMatriceId = 10,
                            Theme = "LogStash"
                        },
                        new
                        {
                            Id = 78,
                            CompetenceMatriceId = 10,
                            Theme = "Redis"
                        },
                        new
                        {
                            Id = 79,
                            CompetenceMatriceId = 10,
                            Theme = "Apache Solr"
                        },
                        new
                        {
                            Id = 80,
                            CompetenceMatriceId = 10,
                            Theme = "Apache Hadoop"
                        },
                        new
                        {
                            Id = 81,
                            CompetenceMatriceId = 10,
                            Theme = "Andre jeg kjenner godt"
                        },
                        new
                        {
                            Id = 82,
                            CompetenceMatriceId = 11,
                            Theme = ".NET Core Dependancy Injection"
                        },
                        new
                        {
                            Id = 83,
                            CompetenceMatriceId = 11,
                            Theme = "Autofac"
                        },
                        new
                        {
                            Id = 84,
                            CompetenceMatriceId = 11,
                            Theme = "Ninjext"
                        },
                        new
                        {
                            Id = 85,
                            CompetenceMatriceId = 11,
                            Theme = "Unity"
                        },
                        new
                        {
                            Id = 86,
                            CompetenceMatriceId = 11,
                            Theme = "StructureMap"
                        },
                        new
                        {
                            Id = 87,
                            CompetenceMatriceId = 11,
                            Theme = "Windsor"
                        },
                        new
                        {
                            Id = 88,
                            CompetenceMatriceId = 11,
                            Theme = "Andre jeg kjenner godt"
                        },
                        new
                        {
                            Id = 89,
                            CompetenceMatriceId = 12,
                            Theme = "OWASP"
                        },
                        new
                        {
                            Id = 90,
                            CompetenceMatriceId = 12,
                            Theme = "Identity Server"
                        },
                        new
                        {
                            Id = 91,
                            CompetenceMatriceId = 12,
                            Theme = "Auth0"
                        },
                        new
                        {
                            Id = 92,
                            CompetenceMatriceId = 12,
                            Theme = "OAuth"
                        },
                        new
                        {
                            Id = 93,
                            CompetenceMatriceId = 12,
                            Theme = "OpenId Connect"
                        },
                        new
                        {
                            Id = 94,
                            CompetenceMatriceId = 12,
                            Theme = "ASP.NET Membership"
                        },
                        new
                        {
                            Id = 95,
                            CompetenceMatriceId = 12,
                            Theme = "Andre jeg kjenner godt til"
                        },
                        new
                        {
                            Id = 96,
                            CompetenceMatriceId = 13,
                            Theme = "log4net"
                        },
                        new
                        {
                            Id = 97,
                            CompetenceMatriceId = 13,
                            Theme = "NLog"
                        },
                        new
                        {
                            Id = 98,
                            CompetenceMatriceId = 13,
                            Theme = "Serilog"
                        },
                        new
                        {
                            Id = 99,
                            CompetenceMatriceId = 13,
                            Theme = "Azure Application Insights"
                        },
                        new
                        {
                            Id = 100,
                            CompetenceMatriceId = 13,
                            Theme = "Andre jeg kjenner godt til"
                        },
                        new
                        {
                            Id = 101,
                            CompetenceMatriceId = 14,
                            Theme = "Nancy"
                        },
                        new
                        {
                            Id = 102,
                            CompetenceMatriceId = 14,
                            Theme = "ServiceStack"
                        },
                        new
                        {
                            Id = 103,
                            CompetenceMatriceId = 14,
                            Theme = "React Native"
                        },
                        new
                        {
                            Id = 104,
                            CompetenceMatriceId = 14,
                            Theme = "Xamarin"
                        },
                        new
                        {
                            Id = 105,
                            CompetenceMatriceId = 14,
                            Theme = "Mobilapp (native)"
                        },
                        new
                        {
                            Id = 106,
                            CompetenceMatriceId = 14,
                            Theme = "Andre jeg kjenner godt"
                        });
                });

            modelBuilder.Entity("DjHaag.Persitence.CompetenceMatrice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CompetenceMatricesCategory")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("CompetenceMatrices");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CompetenceMatricesCategory = 1
                        },
                        new
                        {
                            Id = 2,
                            CompetenceMatricesCategory = 2
                        },
                        new
                        {
                            Id = 3,
                            CompetenceMatricesCategory = 3
                        },
                        new
                        {
                            Id = 4,
                            CompetenceMatricesCategory = 4
                        },
                        new
                        {
                            Id = 5,
                            CompetenceMatricesCategory = 5
                        },
                        new
                        {
                            Id = 6,
                            CompetenceMatricesCategory = 6
                        },
                        new
                        {
                            Id = 7,
                            CompetenceMatricesCategory = 7
                        },
                        new
                        {
                            Id = 8,
                            CompetenceMatricesCategory = 8
                        },
                        new
                        {
                            Id = 9,
                            CompetenceMatricesCategory = 9
                        },
                        new
                        {
                            Id = 10,
                            CompetenceMatricesCategory = 10
                        },
                        new
                        {
                            Id = 11,
                            CompetenceMatricesCategory = 11
                        },
                        new
                        {
                            Id = 12,
                            CompetenceMatricesCategory = 12
                        },
                        new
                        {
                            Id = 13,
                            CompetenceMatricesCategory = 13
                        },
                        new
                        {
                            Id = 14,
                            CompetenceMatricesCategory = 14
                        });
                });

            modelBuilder.Entity("DjHaag.Persitence.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("DjHaag.Persitence.CategoryTheme", b =>
                {
                    b.HasOne("DjHaag.Persitence.CompetenceMatrice", "CompetenceMatrice")
                        .WithMany("CategoryThemes")
                        .HasForeignKey("CompetenceMatriceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CompetenceMatrice");
                });

            modelBuilder.Entity("DjHaag.Persitence.CompetenceMatrice", b =>
                {
                    b.Navigation("CategoryThemes");
                });
#pragma warning restore 612, 618
        }
    }
}
