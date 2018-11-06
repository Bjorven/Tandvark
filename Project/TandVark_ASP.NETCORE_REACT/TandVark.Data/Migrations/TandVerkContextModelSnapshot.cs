﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TandVark.Data.Data1;

namespace TandVark.Data.Migrations
{
    [DbContext(typeof(TandVerkContext))]
    partial class TandVerkContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TandVark.Domain.DataLatHund1.TblUser", b =>
                {
                    b.Property<int>("FldId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FldAccountName");

                    b.Property<string>("FldPassword");

                    b.Property<int?>("UserTypeId");

                    b.HasKey("FldId");

                    b.HasIndex("UserTypeId");

                    b.ToTable("TblUsers");
                });

            modelBuilder.Entity("TandVark.Domain.DataLatHund1.TblUserType", b =>
                {
                    b.Property<int>("FldId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FldEmployeeTypeName");

                    b.HasKey("FldId");

                    b.ToTable("TblUserTypes");
                });

            modelBuilder.Entity("TandVark.Domain.DataLatHund1.TblUser", b =>
                {
                    b.HasOne("TandVark.Domain.DataLatHund1.TblUserType", "FldUserType")
                        .WithMany("TblUsers")
                        .HasForeignKey("UserTypeId");
                });
#pragma warning restore 612, 618
        }
    }
}
