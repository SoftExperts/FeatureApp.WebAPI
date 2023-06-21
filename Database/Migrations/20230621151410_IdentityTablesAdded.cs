using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Database.Migrations
{
    /// <inheritdoc />
    public partial class IdentityTablesAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0001bf54-dad7-4485-820a-3e659b5f1532"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("03b10d77-c7d8-4c56-8e7e-0d9370f51b2b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("06b9d422-12c2-48a6-b69a-df5459dab549"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0aaa9b00-00c6-4ba5-baa2-05a7215808cb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("14c25491-d1d0-4c5b-8626-9b11b1bef8b7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("17097e37-b580-4d9d-9710-829fce6cd3bb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1c50ceb2-17ef-4d00-88de-9d710bf089a8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("32a4ea55-39f1-4eca-a4f0-86b0c37280f4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("33cb5ac5-e188-46a6-a36b-9edba3840e1f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("37ab027e-579f-4d03-b906-3b173aaf2bbf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4629fa34-4adb-41c1-9b28-13f1c8401a1c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("47103682-53d9-44af-858d-1334fc158f3e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5bf19323-ea5f-4582-84a6-f60cdbaaec7a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5f5b5b7c-92cb-4d29-aaf9-afc01df898ce"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("662c166f-a7bf-4295-b381-efd2b6898ea4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6885910e-654d-4304-a686-0996960e07f2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("753b3150-d6f3-412f-985f-ef0de6428168"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("801a34ea-499a-4e3b-90cc-aeac28e142ba"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8531f7be-520c-41f3-93fe-2fb3f53b6e08"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a2cd87b8-fcaa-469c-a929-6e71aeeff7ea"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c05e6026-cc88-4518-bafa-50b63cdb30b0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c34f03e2-f73a-41f0-ba2b-1015eea686e0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d1b779b3-ff06-4064-8994-ad573ac56117"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d944e3f6-e427-445d-ac5e-d8762457ee66"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fe6fc5b7-b808-4c04-ab60-ca9a7aa0db57"));

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Custom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Description", "IsAvailable", "IsNew", "ModifiedBy", "ModifiedDate", "Name", "Price", "Sku" },
                values: new object[,]
                {
                    { new Guid("0e0d8863-3b7d-495b-ad99-0d7ba36b35c7"), new Guid("e3fc4112-6e4e-45aa-9993-44e86226c715"), new DateTime(2023, 6, 21, 20, 14, 10, 423, DateTimeKind.Local).AddTicks(2810), "", true, false, null, null, "Ultra-Soft Tank Top", 22m, "AWWUTT" },
                    { new Guid("15e8f0e6-4939-4d78-9f0c-7eadad4ab6b0"), new Guid("d3ac1cb2-442d-4d77-8f9e-d527766e7820"), new DateTime(2023, 6, 21, 20, 14, 10, 423, DateTimeKind.Local).AddTicks(2806), "", true, false, null, null, "Stretchy Dance Pants", 55m, "AWWSDP" },
                    { new Guid("1dbab901-c31e-4531-9518-955d2e9658cd"), new Guid("29ad9322-cca9-45a7-8726-6526c9111d3d"), new DateTime(2023, 6, 21, 20, 14, 10, 423, DateTimeKind.Local).AddTicks(2846), "", true, false, null, null, "Raspberry Mineral Water", 2.8m, "MWR" },
                    { new Guid("29c730ec-6870-49fb-8e97-312366b91966"), new Guid("466775ba-34d4-4654-9ea6-9796e09d228e"), new DateTime(2023, 6, 21, 20, 14, 10, 423, DateTimeKind.Local).AddTicks(2854), "", true, false, null, null, "In the Kitchen with H+ Sport", 24.99m, "PITK" },
                    { new Guid("385acc17-77a3-48e7-a54b-2a55d19ca490"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", true, false, null, null, "Polo Shirt", 35m, "AWMPS" },
                    { new Guid("3ac135ae-c046-4a07-b8f9-9fd64e171ec2"), new Guid("b0edd2dc-3b46-4a47-9481-ae71f1c460ec"), new DateTime(2023, 6, 21, 20, 14, 10, 423, DateTimeKind.Local).AddTicks(2831), "", true, false, null, null, "Lemon-Lime Mineral Water", 2.8m, "MWLL" },
                    { new Guid("4635e8b8-1647-462b-b2a8-71fc71f13bde"), new Guid("49a9873d-d0f4-4b91-b5fa-873ac8dd1ce6"), new DateTime(2023, 6, 21, 20, 14, 10, 423, DateTimeKind.Local).AddTicks(2862), "", true, false, null, null, "Calcium 400 IU (150 tablets)", 9.99m, "SC400" },
                    { new Guid("5aef10a9-8588-4669-a2c0-7f98975603a7"), new Guid("fcb8cd33-1324-422b-b910-b96c40553461"), new DateTime(2023, 6, 21, 20, 14, 10, 423, DateTimeKind.Local).AddTicks(2815), "", true, false, null, null, "Unisex Thermal Vest", 95m, "AWWUTV" },
                    { new Guid("5fc00846-0ad7-4d82-b1bf-dd88f747b4b6"), new Guid("8fdb2302-2524-4293-9e34-44a816cb91d1"), new DateTime(2023, 6, 21, 20, 14, 10, 423, DateTimeKind.Local).AddTicks(2850), "", true, false, null, null, "Strawberry Mineral Water", 2.8m, "MWS" },
                    { new Guid("60ada22c-df87-42c8-9959-2aff0528943d"), new Guid("99d3eb12-dae4-4a35-bea0-99db2203a4bf"), new DateTime(2023, 6, 21, 20, 14, 10, 423, DateTimeKind.Local).AddTicks(2822), "", true, false, null, null, "V-Next T-Shirt", 17m, "AWWVNT" },
                    { new Guid("60c23758-b27c-4b36-af56-0a494594c540"), new Guid("ae81d85d-11f8-43ee-9fe3-f1b72e0c7d82"), new DateTime(2023, 6, 21, 20, 14, 10, 423, DateTimeKind.Local).AddTicks(2843), "", true, false, null, null, "Peach Mineral Water", 2.8m, "MWP" },
                    { new Guid("6558c9d8-d197-43c8-9249-5449edc63947"), new Guid("92a329a1-6b46-41c7-ab0d-5aea81007e24"), new DateTime(2023, 6, 21, 20, 14, 10, 423, DateTimeKind.Local).AddTicks(2781), "", true, false, null, null, "V-Neck T-Shirt", 17m, "AWMVNT" },
                    { new Guid("8a529a9c-b446-494d-9af0-562e2ab06ab5"), new Guid("781c9292-fce8-43f5-ab80-cbbe08e5252a"), new DateTime(2023, 6, 21, 20, 14, 10, 423, DateTimeKind.Local).AddTicks(2835), "", true, false, null, null, "Orange Mineral Water", 2.8m, "MWO" },
                    { new Guid("8b7a42bc-7048-4cff-a281-cfa304f6c7cc"), new Guid("e947ec40-5b72-4cdb-87b6-c3292049edc7"), new DateTime(2023, 6, 21, 20, 14, 10, 423, DateTimeKind.Local).AddTicks(2827), "", true, false, null, null, "Blueberry Mineral Water", 2.8m, "MWB" },
                    { new Guid("8bdaebc1-547e-47b1-a354-ee6a5d6d5827"), new Guid("6fe9a226-26bb-4b73-9967-cde14a612cf7"), new DateTime(2023, 6, 21, 20, 14, 10, 423, DateTimeKind.Local).AddTicks(2785), "", true, false, null, null, "Bamboo Thermal Ski Coat", 99m, "AWWBTSC" },
                    { new Guid("8be7a4b9-3aec-4e6d-bec9-04b506cddcc3"), new Guid("2206460a-08a6-4a05-8665-97af481c73b1"), new DateTime(2023, 6, 21, 20, 14, 10, 423, DateTimeKind.Local).AddTicks(2770), "", true, false, null, null, "V-Neck Pullover", 65m, "AWMVNP" },
                    { new Guid("927fe8f6-a4c2-4501-a5c5-01151567be4d"), new Guid("065a17fb-b13c-4ffc-834a-00763931da2f"), new DateTime(2023, 6, 21, 20, 14, 10, 423, DateTimeKind.Local).AddTicks(2793), "", true, false, null, null, "Grunge Skater Jeans", 68m, "AWWGSJ" },
                    { new Guid("97c5c1ac-bff9-451d-a8c3-a2a332324028"), new Guid("d50d5a96-4132-4cea-878c-917e76b47fe2"), new DateTime(2023, 6, 21, 20, 14, 10, 423, DateTimeKind.Local).AddTicks(2712), "", true, false, null, null, "Thermal Fleece Jacket", 60m, "AWMTFJ" },
                    { new Guid("a5dfab4c-9e7b-4dda-b4a7-1387645e228f"), new Guid("45165d20-08b1-460a-adcc-5d35e829ebcf"), new DateTime(2023, 6, 21, 20, 14, 10, 423, DateTimeKind.Local).AddTicks(2686), "", true, false, null, null, "Grunge Skater Jeans", 68m, "AWMGSJ" },
                    { new Guid("aabc4689-24f9-4c5b-a2e5-e5f73ff679d2"), new Guid("330466d1-ea1c-4cf0-a012-1ed8062d58a6"), new DateTime(2023, 6, 21, 20, 14, 10, 423, DateTimeKind.Local).AddTicks(2774), "", true, false, null, null, "V-Neck Sweater", 65m, "AWMVNS" },
                    { new Guid("ab422ac4-6c9e-425c-afd5-75a33a613296"), new Guid("d79f2348-c0e6-4277-805c-62836d642193"), new DateTime(2023, 6, 21, 20, 14, 10, 423, DateTimeKind.Local).AddTicks(2700), "", true, false, null, null, "Skater Graphic T-Shirt", 33m, "AWMSGT" },
                    { new Guid("b0d5a1b6-c347-4de1-b33e-e1a5d6f3b402"), new Guid("f20fd41e-bc91-4317-b897-46b466e0188a"), new DateTime(2023, 6, 21, 20, 14, 10, 423, DateTimeKind.Local).AddTicks(2715), "", true, false, null, null, "Unisex Thermal Vest", 95m, "AWMUTV" },
                    { new Guid("c7559679-8c41-4118-9f85-94c89e568ad1"), new Guid("7ec95042-7236-4228-9866-1278be75c281"), new DateTime(2023, 6, 21, 20, 14, 10, 423, DateTimeKind.Local).AddTicks(2789), "", false, false, null, null, "Cross-Back Training Tank", 0m, "AWWCTT" },
                    { new Guid("d810b38d-4776-404c-b9b8-61efde8c3b7f"), new Guid("461fc088-5561-4ada-ad33-ee80e6d5a794"), new DateTime(2023, 6, 21, 20, 14, 10, 423, DateTimeKind.Local).AddTicks(2704), "", true, false, null, null, "Slicker Jacket", 125m, "AWMSJ" },
                    { new Guid("f055affd-a166-4736-8bf4-7893bb54449e"), new Guid("ebba854d-1508-4b9d-9bca-67f9846e94be"), new DateTime(2023, 6, 21, 20, 14, 10, 423, DateTimeKind.Local).AddTicks(2802), "", true, false, null, null, "Slicker Jacket", 125m, "AWWSJ" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0e0d8863-3b7d-495b-ad99-0d7ba36b35c7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("15e8f0e6-4939-4d78-9f0c-7eadad4ab6b0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1dbab901-c31e-4531-9518-955d2e9658cd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("29c730ec-6870-49fb-8e97-312366b91966"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("385acc17-77a3-48e7-a54b-2a55d19ca490"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3ac135ae-c046-4a07-b8f9-9fd64e171ec2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4635e8b8-1647-462b-b2a8-71fc71f13bde"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5aef10a9-8588-4669-a2c0-7f98975603a7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5fc00846-0ad7-4d82-b1bf-dd88f747b4b6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("60ada22c-df87-42c8-9959-2aff0528943d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("60c23758-b27c-4b36-af56-0a494594c540"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6558c9d8-d197-43c8-9249-5449edc63947"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8a529a9c-b446-494d-9af0-562e2ab06ab5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8b7a42bc-7048-4cff-a281-cfa304f6c7cc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8bdaebc1-547e-47b1-a354-ee6a5d6d5827"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8be7a4b9-3aec-4e6d-bec9-04b506cddcc3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("927fe8f6-a4c2-4501-a5c5-01151567be4d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("97c5c1ac-bff9-451d-a8c3-a2a332324028"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a5dfab4c-9e7b-4dda-b4a7-1387645e228f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aabc4689-24f9-4c5b-a2e5-e5f73ff679d2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ab422ac4-6c9e-425c-afd5-75a33a613296"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b0d5a1b6-c347-4de1-b33e-e1a5d6f3b402"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c7559679-8c41-4118-9f85-94c89e568ad1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d810b38d-4776-404c-b9b8-61efde8c3b7f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f055affd-a166-4736-8bf4-7893bb54449e"));

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
    }
}
