using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Database.Migrations
{
    /// <inheritdoc />
    public partial class CreateProductsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Sku = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false),
                    IsNew = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Description", "IsAvailable", "IsNew", "ModifiedBy", "ModifiedDate", "Name", "Price", "Sku" },
                values: new object[,]
                {
                    { new Guid("0001bf54-dad7-4485-820a-3e659b5f1532"), new Guid("11ae6566-0cdf-4275-9bfa-8bf638f8c8c2"), new DateTime(2023, 6, 20, 16, 54, 31, 795, DateTimeKind.Local).AddTicks(455), "", true, false, null, null, "Unisex Thermal Vest", 95m, "AWWUTV" },
                    { new Guid("03b10d77-c7d8-4c56-8e7e-0d9370f51b2b"), new Guid("0812c0c3-ca82-4b97-89dd-7b5bffab2362"), new DateTime(2023, 6, 20, 16, 54, 31, 795, DateTimeKind.Local).AddTicks(479), "", true, false, null, null, "Orange Mineral Water", 2.8m, "MWO" },
                    { new Guid("06b9d422-12c2-48a6-b69a-df5459dab549"), new Guid("7e22a0c8-075e-43e0-a523-f80afdcba511"), new DateTime(2023, 6, 20, 16, 54, 31, 795, DateTimeKind.Local).AddTicks(460), "", true, false, null, null, "V-Next T-Shirt", 17m, "AWWVNT" },
                    { new Guid("0aaa9b00-00c6-4ba5-baa2-05a7215808cb"), new Guid("901effc6-1fa9-48ae-be6b-bd643d7e72a8"), new DateTime(2023, 6, 20, 16, 54, 31, 795, DateTimeKind.Local).AddTicks(356), "", true, false, null, null, "V-Neck Pullover", 65m, "AWMVNP" },
                    { new Guid("14c25491-d1d0-4c5b-8626-9b11b1bef8b7"), new Guid("e6c150fe-de66-4814-adf3-d3223f46c339"), new DateTime(2023, 6, 20, 16, 54, 31, 795, DateTimeKind.Local).AddTicks(420), "", false, false, null, null, "Cross-Back Training Tank", 0m, "AWWCTT" },
                    { new Guid("17097e37-b580-4d9d-9710-829fce6cd3bb"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", true, false, null, null, "Polo Shirt", 35m, "AWMPS" },
                    { new Guid("1c50ceb2-17ef-4d00-88de-9d710bf089a8"), new Guid("36a126ac-7f08-43dd-ad44-a7c5a65f0848"), new DateTime(2023, 6, 20, 16, 54, 31, 795, DateTimeKind.Local).AddTicks(494), "", true, false, null, null, "Strawberry Mineral Water", 2.8m, "MWS" },
                    { new Guid("32a4ea55-39f1-4eca-a4f0-86b0c37280f4"), new Guid("301a39c9-1716-47da-9df2-1ffd6540ead2"), new DateTime(2023, 6, 20, 16, 54, 31, 795, DateTimeKind.Local).AddTicks(292), "", true, false, null, null, "Skater Graphic T-Shirt", 33m, "AWMSGT" },
                    { new Guid("33cb5ac5-e188-46a6-a36b-9edba3840e1f"), new Guid("2405c6dd-7518-4df7-9cca-821aceb6dd66"), new DateTime(2023, 6, 20, 16, 54, 31, 795, DateTimeKind.Local).AddTicks(435), "", true, false, null, null, "Stretchy Dance Pants", 55m, "AWWSDP" },
                    { new Guid("37ab027e-579f-4d03-b906-3b173aaf2bbf"), new Guid("1e1013ee-a58e-47f6-9dd0-7bdadc9d1beb"), new DateTime(2023, 6, 20, 16, 54, 31, 795, DateTimeKind.Local).AddTicks(430), "", true, false, null, null, "Slicker Jacket", 125m, "AWWSJ" },
                    { new Guid("4629fa34-4adb-41c1-9b28-13f1c8401a1c"), new Guid("d732f60f-9909-4db1-a709-3e5f6dddae36"), new DateTime(2023, 6, 20, 16, 54, 31, 795, DateTimeKind.Local).AddTicks(303), "", true, false, null, null, "Thermal Fleece Jacket", 60m, "AWMTFJ" },
                    { new Guid("47103682-53d9-44af-858d-1334fc158f3e"), new Guid("84290e11-97f7-4783-93b1-2d3a83b78db5"), new DateTime(2023, 6, 20, 16, 54, 31, 795, DateTimeKind.Local).AddTicks(466), "", true, false, null, null, "Blueberry Mineral Water", 2.8m, "MWB" },
                    { new Guid("5bf19323-ea5f-4582-84a6-f60cdbaaec7a"), new Guid("382a9873-3a2d-4668-bd84-8855c73dfdcd"), new DateTime(2023, 6, 20, 16, 54, 31, 795, DateTimeKind.Local).AddTicks(510), "", true, false, null, null, "Calcium 400 IU (150 tablets)", 9.99m, "SC400" },
                    { new Guid("5f5b5b7c-92cb-4d29-aaf9-afc01df898ce"), new Guid("e56d0288-9e4f-49ca-9c23-fcaa9c9dfd02"), new DateTime(2023, 6, 20, 16, 54, 31, 795, DateTimeKind.Local).AddTicks(223), "", true, false, null, null, "Grunge Skater Jeans", 68m, "AWMGSJ" },
                    { new Guid("662c166f-a7bf-4295-b381-efd2b6898ea4"), new Guid("24ca322f-3233-4bb8-9046-ba7cc3681039"), new DateTime(2023, 6, 20, 16, 54, 31, 795, DateTimeKind.Local).AddTicks(487), "", true, false, null, null, "Raspberry Mineral Water", 2.8m, "MWR" },
                    { new Guid("6885910e-654d-4304-a686-0996960e07f2"), new Guid("1ec3139e-6eb4-4411-b5a4-b7e8dc0d2e9d"), new DateTime(2023, 6, 20, 16, 54, 31, 795, DateTimeKind.Local).AddTicks(446), "", true, false, null, null, "Ultra-Soft Tank Top", 22m, "AWWUTT" },
                    { new Guid("753b3150-d6f3-412f-985f-ef0de6428168"), new Guid("392b751c-0f29-4159-ac97-9215a3cbcff3"), new DateTime(2023, 6, 20, 16, 54, 31, 795, DateTimeKind.Local).AddTicks(406), "", true, false, null, null, "V-Neck T-Shirt", 17m, "AWMVNT" },
                    { new Guid("801a34ea-499a-4e3b-90cc-aeac28e142ba"), new Guid("4b342a2c-cf76-4040-afba-086c1dffb071"), new DateTime(2023, 6, 20, 16, 54, 31, 795, DateTimeKind.Local).AddTicks(298), "", true, false, null, null, "Slicker Jacket", 125m, "AWMSJ" },
                    { new Guid("8531f7be-520c-41f3-93fe-2fb3f53b6e08"), new Guid("4f95fdf7-fdfc-4205-9819-bfc54c4e70c2"), new DateTime(2023, 6, 20, 16, 54, 31, 795, DateTimeKind.Local).AddTicks(425), "", true, false, null, null, "Grunge Skater Jeans", 68m, "AWWGSJ" },
                    { new Guid("a2cd87b8-fcaa-469c-a929-6e71aeeff7ea"), new Guid("338ff618-61d4-4bda-ac42-2630ed407bc0"), new DateTime(2023, 6, 20, 16, 54, 31, 795, DateTimeKind.Local).AddTicks(364), "", true, false, null, null, "V-Neck Sweater", 65m, "AWMVNS" },
                    { new Guid("c05e6026-cc88-4518-bafa-50b63cdb30b0"), new Guid("e6db081c-141a-47b7-8cc8-86af7e56270d"), new DateTime(2023, 6, 20, 16, 54, 31, 795, DateTimeKind.Local).AddTicks(307), "", true, false, null, null, "Unisex Thermal Vest", 95m, "AWMUTV" },
                    { new Guid("c34f03e2-f73a-41f0-ba2b-1015eea686e0"), new Guid("a6a54f09-749f-4336-af42-97e03772573f"), new DateTime(2023, 6, 20, 16, 54, 31, 795, DateTimeKind.Local).AddTicks(502), "", true, false, null, null, "In the Kitchen with H+ Sport", 24.99m, "PITK" },
                    { new Guid("d1b779b3-ff06-4064-8994-ad573ac56117"), new Guid("beb90bae-b46c-4a14-bc20-9ec1599fc162"), new DateTime(2023, 6, 20, 16, 54, 31, 795, DateTimeKind.Local).AddTicks(474), "", true, false, null, null, "Lemon-Lime Mineral Water", 2.8m, "MWLL" },
                    { new Guid("d944e3f6-e427-445d-ac5e-d8762457ee66"), new Guid("7c13d4fb-c44a-416d-bfed-ba06eb87f1c8"), new DateTime(2023, 6, 20, 16, 54, 31, 795, DateTimeKind.Local).AddTicks(410), "", true, false, null, null, "Bamboo Thermal Ski Coat", 99m, "AWWBTSC" },
                    { new Guid("fe6fc5b7-b808-4c04-ab60-ca9a7aa0db57"), new Guid("e66f737d-38aa-4648-8f73-d27b9dac63c4"), new DateTime(2023, 6, 20, 16, 54, 31, 795, DateTimeKind.Local).AddTicks(483), "", true, false, null, null, "Peach Mineral Water", 2.8m, "MWP" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
