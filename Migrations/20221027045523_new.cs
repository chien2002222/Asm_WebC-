using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FPTBook.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 20, nullable: false),
                    Description = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Requests",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requests", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
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
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
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
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
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
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
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
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
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

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 100, nullable: false),
                    Image = table.Column<string>(nullable: false),
                    Author = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Customer = table.Column<string>(nullable: true),
                    OrderDate = table.Column<DateTime>(nullable: false),
                    OrderQuantity = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    OrderPrice = table.Column<double>(nullable: false),
                    OrderName = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    BookId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "A", "c02b3f1e-628c-46de-98d1-510117a75a56", "Administrator", "Administrator" },
                    { "B", "711f3d3c-c1f1-4abb-98c8-9b8bc494cd6c", "BookOwner", "BookOwner" },
                    { "C", "9607d9f5-0434-4e07-813b-b069eceff248", "Customer", "Customer" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, "2087d27a-581c-4fb5-a5a4-43d67ff88d8c", "admin@gmail.com", true, false, null, null, "admin@gmail.com", "AQAAAAEAACcQAAAAEP44y9McgPjkSOyhag7rU1THUMdom0mAS+d4bBqpdo4Zf47MrbXgzMOMncIRdvMogQ==", "1234567890", false, "8dd2a970-7261-43cb-a6c1-5d536a58948a", false, "admin@gmail.com" },
                    { "2", 0, "3c956b8c-1f3e-4674-9090-80bb83b19025", "bookowner1@gmail.com", true, false, null, null, "bookowner1@gmail.com", "AQAAAAEAACcQAAAAEIh20n+6q72/i4K7cP2Mw9P35cTw8h4mEgvMuZlzfbxbS9Pgu5Q+beWIBRkMckx2sg==", "0987654321", false, "b2079a9b-61bd-4ea6-9d28-ac2b033e52c0", false, "bookowner1@gmail.com" },
                    { "3", 0, "4610ad9e-aecf-4a0f-b674-412bb13d1bbb", "bookowner2@gmail.com", true, false, null, null, "bookowner2@gmail.com", "AQAAAAEAACcQAAAAELiHzpBfXrumLdwxlBDYi76eKBujIDQ+TDBj2RJoW5Efc/uYRXzq5K+1XiTlAN9c6w==", "0987227890", false, "2eb97e30-9e5d-45c2-9942-b10ba7c4eb36", false, "bookowner2@gmail.com" },
                    { "4", 0, "96bfbc61-7256-4e6e-aba9-2c1f52558d91", "bookowner3@gmail.com", true, false, null, null, "bookowner@gmail.com", null, "0222567890", false, "2a83547a-29ab-4005-b0c4-fd8f78c785d5", false, "bookowner3@gmail.com" },
                    { "5", 0, "f2f73dd4-0485-49dd-8bc7-5b6d0a7a98e0", "customer@gmail.com", true, false, null, null, "customer@gmail.com", "AQAAAAEAACcQAAAAELHmbRoulUYQ8OUS7IEJ9PHIhozN0VuL3wuQ4xCNwJbEfbu123fzlqsfHEfdNo6q0Q==", "0123456789", false, "bad23795-0b0d-49db-9df8-1430508ef43b", false, "customer@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Advance your understanding of black and white photography, color processing, or find the perfect lighting for portrait shots with our selection of photography books devoted to the learning and curious artist. Or perhaps you prefer to channel your creative side with a backstage tour of the ballet, an intimate look into the lives of Hollywood icons, or by delving into the history of fashion.", "Arts & Music" },
                    { 3, "Our selection of Comics and Graphic Novels is perfect for the collector looking to discover a new story line or booklovers new to the art form. Find new and used manga, DC comics, Marvel comics, Dark Horse, and more. We have everything from children’s favorites to bestselling graphic novels, popular classic comic strips, superheroes, villains, fantasy, action, humor, science fiction.", "Comics" },
                    { 2, "Whether it's the final journey of a spiritual mentor or the art of innovation from a young computer genius, the courage to survive insurmountable odds, or the private and personal autobiography of a public personality, you'll find these stories and much more in our Biographies and Memoirs section.", "Biographies" },
                    { 4, "Whether you’re looking for a great escape or planning a retreat from the pressure of everyday life, you’ll find the Travel Book you’re looking for at Thriftbooks.com. You can learn what it’s like to live in another culture, jump into the history and making of some of the most beautiful and celebrated places and people on this planet. Prepare for your next trip or get lost in a culture far away – all at the lowest prices.", "Travel" },
                    { 5, "Whether it's the final journey of a spiritual mentor or the art of innovation from a young computer genius, the courage to survive insurmountable odds, or the private and personal autobiography of a public personality, you'll find these stories and much more in our Biographies and Memoirs section.", "Education" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "1", "A" },
                    { "2", "B" },
                    { "3", "B" },
                    { "4", "B" },
                    { "5", "C" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CategoryId", "Description", "Image", "Price", "Quantity", "Title" },
                values: new object[,]
                {
                    { 3, "Fujiko FuJio", 1, @"Not only famous in Japan, but Doraemon is also known in many different countries around the world. In 2002, Doraemon was voted by Time Asia magazine as one of the twenty-two most lovable heroes of Asia.
                ", "data:image/png;base64,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", 5.0, 30, "Doraemonblablabla" },
                    { 1, "Fujiko Fujio", 3, @"Not only famous in Japan, but Doraemon is also known in many different countries around the world. In 2002, Doraemon was voted by Time Asia magazine as one of the twenty-two most lovable heroes of Asia.
                ", "data:image/png;base64,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", 15.0, 30, "Doraemon123" },
                    { 2, "Fujiko FuJio", 2, @"Not only famous in Japan, but Doraemon is also known in many different countries around the world. In 2002, Doraemon was voted by Time Asia magazine as one of the twenty-two most lovable heroes of Asia.
                ", "data:image/png;base64,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", 10.0, 20, "DoraemonABC" }
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

            migrationBuilder.CreateIndex(
                name: "IX_Books_CategoryId",
                table: "Books",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_BookId",
                table: "Orders",
                column: "BookId");
        }

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
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Requests");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
