using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FPTBook.Migrations
{
    public partial class asd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "A",
                column: "ConcurrencyStamp",
                value: "e30e69a4-c50e-4459-8d80-7862b7e316d1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "B",
                column: "ConcurrencyStamp",
                value: "c3cf2e0e-6ff8-46a8-8799-c51e187193da");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "C",
                column: "ConcurrencyStamp",
                value: "a2c9630f-517e-4c55-9beb-bab3a2aa6799");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4c3a3993-3f07-454c-8fc4-c4ff1b2af64e", "AQAAAAEAACcQAAAAEGPPcTUA64KgHNE9koSG3RAshHCoLnrQAT2TFTpPKlwRm1/qxqy6itIqtijYGQDubg==", "4b8c139c-cce8-4094-8a21-8ffafbdc245c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9798f783-8a2b-424b-92b2-bbc0cf1a2e42", "AQAAAAEAACcQAAAAEEcMwkPf2afTUKCPyegmbsGMNdNwO6u5VX/0LRymlQ5tCTftY7kmD2Ge893TcRO1ig==", "7859a3cc-adce-40bb-be75-fa88af7b699b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c28b444e-b99c-403a-8526-642a6e7fd186", "AQAAAAEAACcQAAAAEKGxYUYGLx5TMbjqRBjViLxs70Cr8pYZOkIne+rhngJBY2K5IMLgvaXUllomDItMLA==", "c4d00c40-4c2e-4e85-a7b9-1792b1e28b74" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "916a1079-85ca-492f-907a-08bb0ae9548c", "c9d4731e-36c7-40aa-a798-ddca5cd4091d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "88d51cb2-521b-47df-a14b-992d37ba3a74", "AQAAAAEAACcQAAAAEGwBRxPdhKlT1oE7JSKbVyblENvN8NlWxR1LAKM1Q+5yhy3jBa14DJXLfH8SJORafg==", "5209de33-19f1-4f0d-a504-69ece8ac8a18" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "A",
                column: "ConcurrencyStamp",
                value: "bd34d2e9-9c41-4065-a79f-e717fb5ed94b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "B",
                column: "ConcurrencyStamp",
                value: "80398d32-69e4-443d-a01e-f4cbe46afd49");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "C",
                column: "ConcurrencyStamp",
                value: "5bd10e72-79eb-41e3-838a-632e5efd8f3d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eb1c8fb5-d1fd-4785-a537-9942f6011191", "AQAAAAEAACcQAAAAEI2rx74wDsRVGAhqV0AsN1TO2QAcAW1tDF2fxs7OHbIgXuKVUaqIuqoJTNjEO+vxwg==", "f94ec6c6-1804-4491-8c27-7affb82f103b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5b4081dd-0969-4c20-90bc-314250896ed2", "AQAAAAEAACcQAAAAEKfLq6Kyrt49QAYZnPBP/OayDfV9CYy8KP8jFS+efJe9igJmkEZFuUzUrzShOCQK+w==", "04d7a30e-883c-4ff1-a8f6-48501b1ad8d1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "56d1fc9c-56e2-491b-a363-c50e8f3e0c8a", "AQAAAAEAACcQAAAAELAiQEGI1lFlhMSQPBNrQqbhn1nbFNlT3mfyOI80t5rYOtDcjox9NiGiLQFc3/FbcA==", "26966c57-791a-4eb9-8cb0-283435656f1c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c7f529af-f04e-47a4-b657-0d1ef8e56c32", "c1dca5fa-feb7-4af9-89b9-1d0e613d40ce" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e0ebafbb-7747-4028-90fa-281309c295f5", "AQAAAAEAACcQAAAAEMk07/gNHYd2uqrcoRPGIXzEZkxqkVsGhQHGY9gqYuRl9cMkbYIXGthDeo4864PuKQ==", "cd9476f9-110a-49c3-a48b-0b1423ac01d8" });
        }
    }
}
