using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bogcha.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class noAction : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ActivityManagements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Time = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Task = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Led_by = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityManagements", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AssessmentRecKGs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClassId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AssessmentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Know_100 = table.Column<int>(type: "int", nullable: false),
                    Math_100 = table.Column<int>(type: "int", nullable: false),
                    Read_100 = table.Column<int>(type: "int", nullable: false),
                    Spell_100 = table.Column<int>(type: "int", nullable: false),
                    Camera_Reading_100 = table.Column<int>(type: "int", nullable: false),
                    Camera_Spelling_100 = table.Column<int>(type: "int", nullable: false),
                    Sentence_reading_100 = table.Column<int>(type: "int", nullable: false),
                    Pattern_assessment_100 = table.Column<int>(type: "int", nullable: false),
                    Name_writing_100 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssessmentRecKGs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AssessmentRecNurseries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClassId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AssessmentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Reflection_5 = table.Column<int>(type: "int", nullable: false),
                    Social_development_5 = table.Column<int>(type: "int", nullable: false),
                    Emotional_development_5 = table.Column<int>(type: "int", nullable: false),
                    Conflict_resolution_5 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssessmentRecNurseries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AssessmentRecPreKs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClassId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AssessmentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Alphabet_assessment_50 = table.Column<int>(type: "int", nullable: false),
                    Math_assessment_50 = table.Column<int>(type: "int", nullable: false),
                    Team_work_50 = table.Column<int>(type: "int", nullable: false),
                    Scissor_skills_50 = table.Column<int>(type: "int", nullable: false),
                    patteren_assessment_50 = table.Column<int>(type: "int", nullable: false),
                    Name_writing_50 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssessmentRecPreKs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClassInfos",
                columns: table => new
                {
                    ClassId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClassName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AgeGroup = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoomNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HeadTeacher = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AssistantTeacher = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassInfos", x => x.ClassId);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmpId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EmpFName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmpLName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Passport = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DoB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EmployedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StrAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmpType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmpId);
                });

            migrationBuilder.CreateTable(
                name: "ImmunizationRecords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Chickenpox = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diphtheria_Tetanus_WhoopingCough = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Haemophilus_influenza_typeB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hepatsis_A = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hepatsis_B = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Influenza = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Measles = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Meningococcal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pneumococcal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Polio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rotavirus = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImmunizationRecords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MealPlans",
                columns: table => new
                {
                    MealNo = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    DateName = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    AM_Snack = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Lunch = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Fruit = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PM_Snack = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MealPlans", x => x.MealNo);
                });

            migrationBuilder.CreateTable(
                name: "Parents",
                columns: table => new
                {
                    ChId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FatherFullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MotherFullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Passport = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StrAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNo1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNo2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parents", x => x.ChId);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    CHId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ChFName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChLName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChDoB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RegisteredDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EnrollmentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhyImpairment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AllergyType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AllergySymptom = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.CHId);
                });

            migrationBuilder.CreateTable(
                name: "Withdrawals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Expense = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DatePaid = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WithDrawnBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Withdrawals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AccidentRecords",
                columns: table => new
                {
                    AccNo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AccidentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TypeOfAccident = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Location = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    FirstAid = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccidentRecords", x => x.AccNo);
                    table.ForeignKey(
                        name: "FK_AccidentRecords_Students_ChId",
                        column: x => x.ChId,
                        principalTable: "Students",
                        principalColumn: "CHId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Attendances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SignIn_Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SignOut_Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StudnetCHId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attendances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Attendances_Students_StudnetCHId",
                        column: x => x.StudnetCHId,
                        principalTable: "Students",
                        principalColumn: "CHId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AuthorizedPickUps",
                columns: table => new
                {
                    ChId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AuthFName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    AuthLName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    gender = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    Passport = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    strAddress = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    city = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    region = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    zipCode = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    phoneNo = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorizedPickUps", x => x.ChId);
                    table.ForeignKey(
                        name: "FK_AuthorizedPickUps_Students_ChId",
                        column: x => x.ChId,
                        principalTable: "Students",
                        principalColumn: "CHId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BlackLists",
                columns: table => new
                {
                    ChId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UnauthFName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UnauthLName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Passport = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    strAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    city = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    state = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    zipCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phoneNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudnetCHId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlackLists", x => x.ChId);
                    table.ForeignKey(
                        name: "FK_BlackLists_Students_StudnetCHId",
                        column: x => x.StudnetCHId,
                        principalTable: "Students",
                        principalColumn: "CHId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MenuManagements",
                columns: table => new
                {
                    ChId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Monday = table.Column<string>(type: "nvarchar(4)", nullable: false),
                    Tuesday = table.Column<string>(type: "nvarchar(4)", nullable: false),
                    Wednesday = table.Column<string>(type: "nvarchar(4)", nullable: false),
                    Thursday = table.Column<string>(type: "nvarchar(4)", nullable: false),
                    FridayId = table.Column<string>(type: "nvarchar(4)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuManagements", x => x.ChId);
                    table.ForeignKey(
                        name: "FK_MenuManagements_MealPlans_FridayId",
                        column: x => x.FridayId,
                        principalTable: "MealPlans",
                        principalColumn: "MealNo");
                    table.ForeignKey(
                        name: "FK_MenuManagements_MealPlans_Monday",
                        column: x => x.Monday,
                        principalTable: "MealPlans",
                        principalColumn: "MealNo");
                    table.ForeignKey(
                        name: "FK_MenuManagements_MealPlans_Thursday",
                        column: x => x.Thursday,
                        principalTable: "MealPlans",
                        principalColumn: "MealNo");
                    table.ForeignKey(
                        name: "FK_MenuManagements_MealPlans_Tuesday",
                        column: x => x.Tuesday,
                        principalTable: "MealPlans",
                        principalColumn: "MealNo");
                    table.ForeignKey(
                        name: "FK_MenuManagements_MealPlans_Wednesday",
                        column: x => x.Wednesday,
                        principalTable: "MealPlans",
                        principalColumn: "MealNo");
                    table.ForeignKey(
                        name: "FK_MenuManagements_Students_ChId",
                        column: x => x.ChId,
                        principalTable: "Students",
                        principalColumn: "CHId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RegularHealthChecks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CheckupDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Symptom = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ActionRequired = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    StudnetCHId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegularHealthChecks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RegularHealthChecks_Students_StudnetCHId",
                        column: x => x.StudnetCHId,
                        principalTable: "Students",
                        principalColumn: "CHId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Revenues",
                columns: table => new
                {
                    ChId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RegistrationFee = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Term1 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Term2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Term3 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Book = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    InvoiceNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    RecieptNo = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Revenues", x => x.ChId);
                    table.ForeignKey(
                        name: "FK_Revenues_Students_ChId",
                        column: x => x.ChId,
                        principalTable: "Students",
                        principalColumn: "CHId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AccidentRecords_ChId",
                table: "AccidentRecords",
                column: "ChId");

            migrationBuilder.CreateIndex(
                name: "IX_Attendances_StudnetCHId",
                table: "Attendances",
                column: "StudnetCHId");

            migrationBuilder.CreateIndex(
                name: "IX_BlackLists_StudnetCHId",
                table: "BlackLists",
                column: "StudnetCHId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuManagements_FridayId",
                table: "MenuManagements",
                column: "FridayId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuManagements_Monday",
                table: "MenuManagements",
                column: "Monday");

            migrationBuilder.CreateIndex(
                name: "IX_MenuManagements_Thursday",
                table: "MenuManagements",
                column: "Thursday");

            migrationBuilder.CreateIndex(
                name: "IX_MenuManagements_Tuesday",
                table: "MenuManagements",
                column: "Tuesday");

            migrationBuilder.CreateIndex(
                name: "IX_MenuManagements_Wednesday",
                table: "MenuManagements",
                column: "Wednesday");

            migrationBuilder.CreateIndex(
                name: "IX_RegularHealthChecks_StudnetCHId",
                table: "RegularHealthChecks",
                column: "StudnetCHId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccidentRecords");

            migrationBuilder.DropTable(
                name: "ActivityManagements");

            migrationBuilder.DropTable(
                name: "AssessmentRecKGs");

            migrationBuilder.DropTable(
                name: "AssessmentRecNurseries");

            migrationBuilder.DropTable(
                name: "AssessmentRecPreKs");

            migrationBuilder.DropTable(
                name: "Attendances");

            migrationBuilder.DropTable(
                name: "AuthorizedPickUps");

            migrationBuilder.DropTable(
                name: "BlackLists");

            migrationBuilder.DropTable(
                name: "ClassInfos");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "ImmunizationRecords");

            migrationBuilder.DropTable(
                name: "MenuManagements");

            migrationBuilder.DropTable(
                name: "Parents");

            migrationBuilder.DropTable(
                name: "RegularHealthChecks");

            migrationBuilder.DropTable(
                name: "Revenues");

            migrationBuilder.DropTable(
                name: "Withdrawals");

            migrationBuilder.DropTable(
                name: "MealPlans");

            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
