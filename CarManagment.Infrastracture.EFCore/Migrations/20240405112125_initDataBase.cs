using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarManagment.Infrastracture.EFCore.Migrations
{
    /// <inheritdoc />
    public partial class initDataBase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarCategories",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Picture = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    PictureAlt = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    PictureTitle = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Keywords = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    MetaDescription = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Slug = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ProducingCountry = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BodyClass = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Weight = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PassengerSpaces = table.Column<int>(type: "int", nullable: false),
                    TheDimensionsAndTypeOfTiresOfTheFrontWheels = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TheDimensionsAndTypeOfTiresOfTheRearWheels = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EngineVolume = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EngineType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cylinders = table.Column<int>(type: "int", nullable: false),
                    Valves = table.Column<int>(type: "int", nullable: false),
                    ArrangementOfCylinders = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FuelSystem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaximumOutputPower = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaximumOutputTorque = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TankCapacity = table.Column<int>(type: "int", nullable: false),
                    TypeOfGearbox = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfGears = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VehicleMotionSystem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FrontDiskType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RearDiskType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FrontShockAbsorbers = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RearShockAbsorbers = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypeOfSteeringSystem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaximumSpeed = table.Column<int>(type: "int", nullable: false),
                    AccelerationFrom0To100 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UrbanFuelConsumption = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoadFuelConsumption = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CombinedFuelConsumption = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmissionStandard = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SafetyStar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Airbags = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StabilityAndDriverAssistanceSystems = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecurityAndProtectionSystems = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AirConditioningSystems = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AudioAndVideoSystem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MultimediaSystems = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FrontSeatSystem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RearSeatSystem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MirrorSystem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GlasssSystem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoofSystems = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FrontLightingSystem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RearLightingSystem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DrivingAssistanceSystems = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Picture = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PictureAlt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PictureTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Slug = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Keywords = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    MetaDescription = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CarCategoryId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cars_CarCategories_CarCategoryId",
                        column: x => x.CarCategoryId,
                        principalTable: "CarCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CarComments",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Message = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    CommentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CarId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarComments_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarComments_CarId",
                table: "CarComments",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_CarCategoryId",
                table: "Cars",
                column: "CarCategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarComments");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "CarCategories");
        }
    }
}
