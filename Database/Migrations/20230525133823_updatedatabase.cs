using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Database.Migrations
{
    /// <inheritdoc />
    public partial class updatedatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Products");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Description", "IsAvailable", "IsNew", "ModifiedBy", "ModifiedDate", "Name", "Price", "Sku" },
                values: new object[,]
                {
                    { new Guid("08edee98-66d5-4069-923b-902320bd23dd"), new Guid("4b09b6c3-e101-46a6-9b4f-3eb292aad80b"), new DateTime(2023, 5, 25, 18, 38, 23, 48, DateTimeKind.Local).AddTicks(8916), "", true, false, null, null, "V-Neck Sweater", 65m, "AWMVNS" },
                    { new Guid("2d6922c8-d514-42b8-908c-fab3dc7db594"), new Guid("6aad02a9-8b12-4639-aa6e-91fce2715199"), new DateTime(2023, 5, 25, 18, 38, 23, 48, DateTimeKind.Local).AddTicks(8902), "", true, false, null, null, "Thermal Fleece Jacket", 60m, "AWMTFJ" },
                    { new Guid("39faf3ba-bc1c-446c-9cfa-b5a9eba3369d"), new Guid("2bae3a44-35b0-4b97-b69f-821280596c1d"), new DateTime(2023, 5, 25, 18, 38, 23, 48, DateTimeKind.Local).AddTicks(8937), "", false, false, null, null, "Cross-Back Training Tank", 0m, "AWWCTT" },
                    { new Guid("44332d9c-b567-43ca-b64d-2376ffbe7bf6"), new Guid("7582a606-22e4-4e6f-a97e-433a880a1cf8"), new DateTime(2023, 5, 25, 18, 38, 23, 48, DateTimeKind.Local).AddTicks(8953), "", true, false, null, null, "Slicker Jacket", 125m, "AWWSJ" },
                    { new Guid("4e18bdbd-e25d-4d3e-9bd9-8c381503f97c"), new Guid("ca5f9830-61ca-4334-a84f-547ea7519104"), new DateTime(2023, 5, 25, 18, 38, 23, 48, DateTimeKind.Local).AddTicks(9160), "", true, false, null, null, "Orange Mineral Water", 2.8m, "MWO" },
                    { new Guid("5539c177-9621-471d-86e0-54d488299c58"), new Guid("10c49d9f-898f-42ee-89c1-7ddb8b300b10"), new DateTime(2023, 5, 25, 18, 38, 23, 48, DateTimeKind.Local).AddTicks(9166), "", true, false, null, null, "Peach Mineral Water", 2.8m, "MWP" },
                    { new Guid("5d462dc6-0d12-4b92-ae04-7e40bd611763"), new Guid("e2449132-01d8-440b-956b-84d2b1ad3b99"), new DateTime(2023, 5, 25, 18, 38, 23, 48, DateTimeKind.Local).AddTicks(8942), "", true, false, null, null, "Grunge Skater Jeans", 68m, "AWWGSJ" },
                    { new Guid("7b38a6c6-01d6-47b8-9c70-21b007a6aa27"), new Guid("fbd44789-d213-4482-a89e-4f20499ac88b"), new DateTime(2023, 5, 25, 18, 38, 23, 48, DateTimeKind.Local).AddTicks(8881), "", true, false, null, null, "Slicker Jacket", 125m, "AWMSJ" },
                    { new Guid("93d6a877-2e2d-4928-a192-5ada937f7e52"), new Guid("0613730e-c5f6-482b-994b-56c4589ef30a"), new DateTime(2023, 5, 25, 18, 38, 23, 48, DateTimeKind.Local).AddTicks(8906), "", true, false, null, null, "Unisex Thermal Vest", 95m, "AWMUTV" },
                    { new Guid("98ba6056-8467-47ee-9b6d-4e5f4843d191"), new Guid("30fc29b5-aff8-474b-a2b1-a9e2592844aa"), new DateTime(2023, 5, 25, 18, 38, 23, 48, DateTimeKind.Local).AddTicks(8876), "", true, false, null, null, "Skater Graphic T-Shirt", 33m, "AWMSGT" },
                    { new Guid("99fc1098-87e5-427b-811b-81b503410ec6"), new Guid("6ab4137d-b362-4b88-aa18-a1cd352bec45"), new DateTime(2023, 5, 25, 18, 38, 23, 48, DateTimeKind.Local).AddTicks(9182), "", true, false, null, null, "Calcium 400 IU (150 tablets)", 9.99m, "SC400" },
                    { new Guid("a3cdb4af-bae4-4888-b7ef-d39f661089b0"), new Guid("116a1a2e-cd1b-43c4-a5ad-ab575fea16b7"), new DateTime(2023, 5, 25, 18, 38, 23, 48, DateTimeKind.Local).AddTicks(9170), "", true, false, null, null, "Raspberry Mineral Water", 2.8m, "MWR" },
                    { new Guid("a807c153-ab09-4ae3-a656-ef1efc339be7"), new Guid("8df2d7a1-53a3-4579-b4ba-6fcd9f6759eb"), new DateTime(2023, 5, 25, 18, 38, 23, 48, DateTimeKind.Local).AddTicks(8932), "", true, false, null, null, "Bamboo Thermal Ski Coat", 99m, "AWWBTSC" },
                    { new Guid("aa6ebdd6-b9b9-4fe5-8211-48c1ce45b57c"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", true, false, null, null, "Polo Shirt", 35m, "AWMPS" },
                    { new Guid("adb78f6e-afdf-45ca-968a-a03ae4a8877e"), new Guid("4792910e-6ffa-4f56-8c54-724e78e092c7"), new DateTime(2023, 5, 25, 18, 38, 23, 48, DateTimeKind.Local).AddTicks(9146), "", true, false, null, null, "V-Next T-Shirt", 17m, "AWWVNT" },
                    { new Guid("ae61e959-d1de-4712-8cd2-a0f4a27156a4"), new Guid("1bf164a7-6e21-45dc-8650-13d8bf076c3e"), new DateTime(2023, 5, 25, 18, 38, 23, 48, DateTimeKind.Local).AddTicks(8849), "", true, false, null, null, "Grunge Skater Jeans", 68m, "AWMGSJ" },
                    { new Guid("ae876fa9-e83a-4242-b9de-f46fdd10748d"), new Guid("62e5da14-d316-4bd6-a26b-80864cf5c761"), new DateTime(2023, 5, 25, 18, 38, 23, 48, DateTimeKind.Local).AddTicks(8964), "", true, false, null, null, "Ultra-Soft Tank Top", 22m, "AWWUTT" },
                    { new Guid("b3d7c044-5ffd-40f0-a95f-44c727dea350"), new Guid("f7708a18-96cc-409b-a399-54f845ab9d0c"), new DateTime(2023, 5, 25, 18, 38, 23, 48, DateTimeKind.Local).AddTicks(8926), "", true, false, null, null, "V-Neck T-Shirt", 17m, "AWMVNT" },
                    { new Guid("ba65699e-328f-4159-a193-e2fc49c7ff07"), new Guid("99b73bdb-e838-404b-a263-cd23e5325ff1"), new DateTime(2023, 5, 25, 18, 38, 23, 48, DateTimeKind.Local).AddTicks(8911), "", true, false, null, null, "V-Neck Pullover", 65m, "AWMVNP" },
                    { new Guid("c8698c08-2514-48eb-9b23-1b2e32120a81"), new Guid("977d9979-57ce-4180-bd91-4cb910fcebb6"), new DateTime(2023, 5, 25, 18, 38, 23, 48, DateTimeKind.Local).AddTicks(9153), "", true, false, null, null, "Blueberry Mineral Water", 2.8m, "MWB" },
                    { new Guid("d58e4a7e-2d66-4129-b419-ffd6c8c85d7e"), new Guid("2bdacefb-eef3-4d8d-b84d-52988480adba"), new DateTime(2023, 5, 25, 18, 38, 23, 48, DateTimeKind.Local).AddTicks(9176), "", true, false, null, null, "In the Kitchen with H+ Sport", 24.99m, "PITK" },
                    { new Guid("dc64c838-d59e-4983-91c2-17fa0a5334db"), new Guid("97b47faa-a1cf-4222-b46a-12b8e954adf0"), new DateTime(2023, 5, 25, 18, 38, 23, 48, DateTimeKind.Local).AddTicks(9157), "", true, false, null, null, "Lemon-Lime Mineral Water", 2.8m, "MWLL" },
                    { new Guid("e7a41e4c-df22-4209-aebf-e71f408873f5"), new Guid("181c6169-298c-4410-be16-be22877daf8f"), new DateTime(2023, 5, 25, 18, 38, 23, 48, DateTimeKind.Local).AddTicks(8969), "", true, false, null, null, "Unisex Thermal Vest", 95m, "AWWUTV" },
                    { new Guid("f505f2cf-1dae-4b9c-ace8-fbed77f4cf34"), new Guid("c1934d0f-0d1c-43df-b74d-71f22f050c13"), new DateTime(2023, 5, 25, 18, 38, 23, 48, DateTimeKind.Local).AddTicks(8959), "", true, false, null, null, "Stretchy Dance Pants", 55m, "AWWSDP" },
                    { new Guid("fdeb992a-6465-472a-b2e6-b2cc0e3258d7"), new Guid("d8f8fc88-c132-418b-875c-8c4b6f449c5b"), new DateTime(2023, 5, 25, 18, 38, 23, 48, DateTimeKind.Local).AddTicks(9173), "", true, false, null, null, "Strawberry Mineral Water", 2.8m, "MWS" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("08edee98-66d5-4069-923b-902320bd23dd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2d6922c8-d514-42b8-908c-fab3dc7db594"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("39faf3ba-bc1c-446c-9cfa-b5a9eba3369d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("44332d9c-b567-43ca-b64d-2376ffbe7bf6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4e18bdbd-e25d-4d3e-9bd9-8c381503f97c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5539c177-9621-471d-86e0-54d488299c58"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5d462dc6-0d12-4b92-ae04-7e40bd611763"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7b38a6c6-01d6-47b8-9c70-21b007a6aa27"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("93d6a877-2e2d-4928-a192-5ada937f7e52"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("98ba6056-8467-47ee-9b6d-4e5f4843d191"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("99fc1098-87e5-427b-811b-81b503410ec6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a3cdb4af-bae4-4888-b7ef-d39f661089b0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a807c153-ab09-4ae3-a656-ef1efc339be7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aa6ebdd6-b9b9-4fe5-8211-48c1ce45b57c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("adb78f6e-afdf-45ca-968a-a03ae4a8877e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ae61e959-d1de-4712-8cd2-a0f4a27156a4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ae876fa9-e83a-4242-b9de-f46fdd10748d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b3d7c044-5ffd-40f0-a95f-44c727dea350"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ba65699e-328f-4159-a193-e2fc49c7ff07"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c8698c08-2514-48eb-9b23-1b2e32120a81"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d58e4a7e-2d66-4129-b419-ffd6c8c85d7e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dc64c838-d59e-4983-91c2-17fa0a5334db"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e7a41e4c-df22-4209-aebf-e71f408873f5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f505f2cf-1dae-4b9c-ace8-fbed77f4cf34"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fdeb992a-6465-472a-b2e6-b2cc0e3258d7"));

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
