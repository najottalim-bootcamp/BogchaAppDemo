﻿// <auto-generated />
using System;
using Bogcha.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Bogcha.DataAccess.Migrations
{
    [DbContext(typeof(PreschoolDbContext))]
    [Migration("20231116150057_noAction")]
    partial class noAction
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Bogcha.Domain.Entities.AccidentRecords", b =>
                {
                    b.Property<int>("AccNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AccNo"));

                    b.Property<DateTime?>("AccidentDate")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("ChId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FirstAid")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("TypeOfAccident")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("AccNo");

                    b.HasIndex("ChId");

                    b.ToTable("AccidentRecords");
                });

            modelBuilder.Entity("Bogcha.Domain.Entities.ActivityManagement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Led_by")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Task")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Time")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ActivityManagements");
                });

            modelBuilder.Entity("Bogcha.Domain.Entities.AssessmentRecKG", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("AssessmentDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Camera_Reading_100")
                        .HasColumnType("int");

                    b.Property<int>("Camera_Spelling_100")
                        .HasColumnType("int");

                    b.Property<string>("ChId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClassId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Know_100")
                        .HasColumnType("int");

                    b.Property<int>("Math_100")
                        .HasColumnType("int");

                    b.Property<int>("Name_writing_100")
                        .HasColumnType("int");

                    b.Property<int>("Pattern_assessment_100")
                        .HasColumnType("int");

                    b.Property<int>("Read_100")
                        .HasColumnType("int");

                    b.Property<int>("Sentence_reading_100")
                        .HasColumnType("int");

                    b.Property<int>("Spell_100")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("AssessmentRecKGs");
                });

            modelBuilder.Entity("Bogcha.Domain.Entities.AssessmentRecNursery", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("AssessmentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ChId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClassId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Conflict_resolution_5")
                        .HasColumnType("int");

                    b.Property<int>("Emotional_development_5")
                        .HasColumnType("int");

                    b.Property<int>("Reflection_5")
                        .HasColumnType("int");

                    b.Property<int>("Social_development_5")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("AssessmentRecNurseries");
                });

            modelBuilder.Entity("Bogcha.Domain.Entities.AssessmentRecPreK", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Alphabet_assessment_50")
                        .HasColumnType("int");

                    b.Property<DateTime>("AssessmentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ChId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClassId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Math_assessment_50")
                        .HasColumnType("int");

                    b.Property<int>("Name_writing_50")
                        .HasColumnType("int");

                    b.Property<int>("Scissor_skills_50")
                        .HasColumnType("int");

                    b.Property<int>("Team_work_50")
                        .HasColumnType("int");

                    b.Property<int>("patteren_assessment_50")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("AssessmentRecPreKs");
                });

            modelBuilder.Entity("Bogcha.Domain.Entities.Attendance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ChId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("SignIn_Time")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("SignOut_Time")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("StudnetCHId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("StudnetCHId");

                    b.ToTable("Attendances");
                });

            modelBuilder.Entity("Bogcha.Domain.Entities.AuthorizedPickUp", b =>
                {
                    b.Property<string>("ChId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AuthFName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("AuthLName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Passport")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("city")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("gender")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("phoneNo")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("region")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("strAddress")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("zipCode")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.HasKey("ChId");

                    b.ToTable("AuthorizedPickUps");
                });

            modelBuilder.Entity("Bogcha.Domain.Entities.BlackList", b =>
                {
                    b.Property<string>("ChId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Passport")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudnetCHId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UnauthFName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UnauthLName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("city")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phoneNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("state")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("zipCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ChId");

                    b.HasIndex("StudnetCHId");

                    b.ToTable("BlackLists");
                });

            modelBuilder.Entity("Bogcha.Domain.Entities.ClassInfo", b =>
                {
                    b.Property<string>("ClassId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AgeGroup")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AssistantTeacher")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClassName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HeadTeacher")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoomNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClassId");

                    b.ToTable("ClassInfos");
                });

            modelBuilder.Entity("Bogcha.Domain.Entities.Employee", b =>
                {
                    b.Property<string>("EmpId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Apt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DoB")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmpFName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmpLName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmpType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EmployedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Passport")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("StrAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmpId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Bogcha.Domain.Entities.ImmunizationRecord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ChId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Chickenpox")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Diphtheria_Tetanus_WhoopingCough")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Haemophilus_influenza_typeB")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hepatsis_A")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hepatsis_B")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Influenza")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Measles")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Meningococcal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pneumococcal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Polio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rotavirus")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ImmunizationRecords");
                });

            modelBuilder.Entity("Bogcha.Domain.Entities.MealPlan", b =>
                {
                    b.Property<string>("MealNo")
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("AM_Snack")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("DateName")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("nvarchar(9)");

                    b.Property<string>("Fruit")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Lunch")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PM_Snack")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("MealNo");

                    b.ToTable("MealPlans");
                });

            modelBuilder.Entity("Bogcha.Domain.Entities.MenuManagement", b =>
                {
                    b.Property<string>("ChId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FridayId")
                        .IsRequired()
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("Monday")
                        .IsRequired()
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("Thursday")
                        .IsRequired()
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("Tuesday")
                        .IsRequired()
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("Wednesday")
                        .IsRequired()
                        .HasColumnType("nvarchar(4)");

                    b.HasKey("ChId");

                    b.HasIndex("FridayId");

                    b.HasIndex("Monday");

                    b.HasIndex("Thursday");

                    b.HasIndex("Tuesday");

                    b.HasIndex("Wednesday");

                    b.ToTable("MenuManagements");
                });

            modelBuilder.Entity("Bogcha.Domain.Entities.Parents", b =>
                {
                    b.Property<string>("ChId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FatherFullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotherFullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Passport")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNo1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNo2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StrAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ChId");

                    b.ToTable("Parents");
                });

            modelBuilder.Entity("Bogcha.Domain.Entities.RegularHealthCheck", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ActionRequired")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ChId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CheckupDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("StudnetCHId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Symptom")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("StudnetCHId");

                    b.ToTable("RegularHealthChecks");
                });

            modelBuilder.Entity("Bogcha.Domain.Entities.Revenue", b =>
                {
                    b.Property<string>("ChId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal?>("Book")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("InvoiceNo")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("RecieptNo")
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.Property<decimal?>("RegistrationFee")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("Term1")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("Term2")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("Term3")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ChId");

                    b.ToTable("Revenues");
                });

            modelBuilder.Entity("Bogcha.Domain.Entities.Student", b =>
                {
                    b.Property<string>("CHId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AllergySymptom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AllergyType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ChDoB")
                        .HasColumnType("datetime2");

                    b.Property<string>("ChFName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ChLName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EnrollmentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhyImpairment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RegisteredDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("StAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CHId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Bogcha.Domain.Entities.Withdrawal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("DatePaid")
                        .HasColumnType("datetime2");

                    b.Property<string>("Expense")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WithDrawnBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Withdrawals");
                });

            modelBuilder.Entity("Bogcha.Domain.Entities.AccidentRecords", b =>
                {
                    b.HasOne("Bogcha.Domain.Entities.Student", "Studnet")
                        .WithMany("Accident_Records")
                        .HasForeignKey("ChId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Studnet");
                });

            modelBuilder.Entity("Bogcha.Domain.Entities.Attendance", b =>
                {
                    b.HasOne("Bogcha.Domain.Entities.Student", "Studnet")
                        .WithMany("Attendances")
                        .HasForeignKey("StudnetCHId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Studnet");
                });

            modelBuilder.Entity("Bogcha.Domain.Entities.AuthorizedPickUp", b =>
                {
                    b.HasOne("Bogcha.Domain.Entities.Student", "Studnet")
                        .WithMany("AuthorizedPickUps")
                        .HasForeignKey("ChId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Studnet");
                });

            modelBuilder.Entity("Bogcha.Domain.Entities.BlackList", b =>
                {
                    b.HasOne("Bogcha.Domain.Entities.Student", "Studnet")
                        .WithMany("BlackLists")
                        .HasForeignKey("StudnetCHId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Studnet");
                });

            modelBuilder.Entity("Bogcha.Domain.Entities.MenuManagement", b =>
                {
                    b.HasOne("Bogcha.Domain.Entities.Student", "Studnet")
                        .WithMany("MenuManagements")
                        .HasForeignKey("ChId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bogcha.Domain.Entities.MealPlan", "FridayMeal")
                        .WithMany("FridayManagements")
                        .HasForeignKey("FridayId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Bogcha.Domain.Entities.MealPlan", "MondayMeal")
                        .WithMany("MondayManagements")
                        .HasForeignKey("Monday")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Bogcha.Domain.Entities.MealPlan", "ThursdayMeal")
                        .WithMany("ThursdayManagements")
                        .HasForeignKey("Thursday")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Bogcha.Domain.Entities.MealPlan", "TuesdayMeal")
                        .WithMany("TuesdayManagements")
                        .HasForeignKey("Tuesday")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Bogcha.Domain.Entities.MealPlan", "WednesdayMeal")
                        .WithMany("WednesdayManagements")
                        .HasForeignKey("Wednesday")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("FridayMeal");

                    b.Navigation("MondayMeal");

                    b.Navigation("Studnet");

                    b.Navigation("ThursdayMeal");

                    b.Navigation("TuesdayMeal");

                    b.Navigation("WednesdayMeal");
                });

            modelBuilder.Entity("Bogcha.Domain.Entities.RegularHealthCheck", b =>
                {
                    b.HasOne("Bogcha.Domain.Entities.Student", "Studnet")
                        .WithMany("RegularHealthChecks")
                        .HasForeignKey("StudnetCHId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Studnet");
                });

            modelBuilder.Entity("Bogcha.Domain.Entities.Revenue", b =>
                {
                    b.HasOne("Bogcha.Domain.Entities.Student", "Studnet")
                        .WithMany("Revenues")
                        .HasForeignKey("ChId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Studnet");
                });

            modelBuilder.Entity("Bogcha.Domain.Entities.MealPlan", b =>
                {
                    b.Navigation("FridayManagements");

                    b.Navigation("MondayManagements");

                    b.Navigation("ThursdayManagements");

                    b.Navigation("TuesdayManagements");

                    b.Navigation("WednesdayManagements");
                });

            modelBuilder.Entity("Bogcha.Domain.Entities.Student", b =>
                {
                    b.Navigation("Accident_Records");

                    b.Navigation("Attendances");

                    b.Navigation("AuthorizedPickUps");

                    b.Navigation("BlackLists");

                    b.Navigation("MenuManagements");

                    b.Navigation("RegularHealthChecks");

                    b.Navigation("Revenues");
                });
#pragma warning restore 612, 618
        }
    }
}
