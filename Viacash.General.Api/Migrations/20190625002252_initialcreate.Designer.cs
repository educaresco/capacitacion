﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Viacash.General.Api.Data;

namespace Viacash.General.Api.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20190625002252_initialcreate")]
    partial class initialcreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Viacash.General.Api.Models.SenderWB", b =>
                {
                    b.Property<int>("ID_SENDER");

                    b.Property<string>("ID_BRANCH");

                    b.Property<string>("SEN_FNAME");

                    b.Property<string>("SEN_LNAME");

                    b.HasKey("ID_SENDER", "ID_BRANCH");

                    b.ToTable("SendersWB");
                });
#pragma warning restore 612, 618
        }
    }
}
