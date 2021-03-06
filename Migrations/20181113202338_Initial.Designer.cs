﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RandyPowell.Models;

namespace RandyPowell.Migrations
{
    [DbContext(typeof(RandyPowellContext))]
    [Migration("20181113202338_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.2-rtm-30932")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RandyPowell.Models.Experience", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Dates");

                    b.Property<string>("Location");

                    b.Property<string>("Organization");

                    b.Property<string>("Title");

                    b.Property<int>("Type");

                    b.Property<string>("_desc");

                    b.HasKey("ID");

                    b.ToTable("Experience");
                });

            modelBuilder.Entity("RandyPowell.Models.ExperienceSkill", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ExperienceId");

                    b.Property<int>("SkillId");

                    b.HasKey("ID");

                    b.HasIndex("ExperienceId");

                    b.HasIndex("SkillId");

                    b.ToTable("ExperienceSkill");
                });

            modelBuilder.Entity("RandyPowell.Models.Skill", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Title");

                    b.Property<int>("Type");

                    b.HasKey("ID");

                    b.ToTable("Skill");
                });

            modelBuilder.Entity("RandyPowell.Models.ExperienceSkill", b =>
                {
                    b.HasOne("RandyPowell.Models.Experience", "Experience")
                        .WithMany("ExperienceSkills")
                        .HasForeignKey("ExperienceId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RandyPowell.Models.Skill", "Skill")
                        .WithMany("ExperienceSkills")
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
