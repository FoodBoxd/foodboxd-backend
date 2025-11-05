using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace foodboxd_backend.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Dishes",
                columns: table => new
                {
                    DishId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "TEXT", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Photo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dishes", x => x.DishId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    IngredientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.IngredientId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProfilePhoto = table.Column<byte[]>(type: "longblob", nullable: true),
                    Email = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Password = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Biography = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Birthdate = table.Column<DateOnly>(type: "date", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "NOW()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    RecipeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Instructions = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DishId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.RecipeId);
                    table.ForeignKey(
                        name: "FK_Recipes_Dishes_DishId",
                        column: x => x.DishId,
                        principalTable: "Dishes",
                        principalColumn: "DishId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Favorites",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    DishId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favorites", x => new { x.UserId, x.DishId });
                    table.ForeignKey(
                        name: "FK_Favorites_Dishes_DishId",
                        column: x => x.DishId,
                        principalTable: "Dishes",
                        principalColumn: "DishId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Favorites_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Publications",
                columns: table => new
                {
                    PublicationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Comment = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Photo = table.Column<byte[]>(type: "longblob", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "NOW()"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    DishId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publications", x => x.PublicationId);
                    table.ForeignKey(
                        name: "FK_Publications_Dishes_DishId",
                        column: x => x.DishId,
                        principalTable: "Dishes",
                        principalColumn: "DishId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Publications_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    RatingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Score = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "NOW()"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    DishId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.RatingId);
                    table.ForeignKey(
                        name: "FK_Ratings_Dishes_DishId",
                        column: x => x.DishId,
                        principalTable: "Dishes",
                        principalColumn: "DishId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ratings_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RecipeIngredient",
                columns: table => new
                {
                    RecipeId = table.Column<int>(type: "int", nullable: false),
                    IngredientId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<double>(type: "double", nullable: false),
                    MeasurementUnit = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipeIngredient", x => new { x.RecipeId, x.IngredientId });
                    table.ForeignKey(
                        name: "FK_RecipeIngredient_Ingredients_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "Ingredients",
                        principalColumn: "IngredientId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RecipeIngredient_Recipes_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipes",
                        principalColumn: "RecipeId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Dishes",
                columns: new[] { "DishId", "Description", "Name", "Photo" },
                values: new object[,]
                {
                    { 1, "A Pizza Marguerita é um clássico napolitano, famosa por seus ingredientes simples e frescos que representam as cores da bandeira italiana.", "Pizza Marguerita", "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                    { 2, "Um prato de massa italiano de Roma, feito com ovos, queijo duro, carne de porco curada e pimenta preta.", "Spaghetti Carbonara", "https://res.cloudinary.com/dslsxyvkp/image/upload/spaghetti_carbonara_twqcuv.png" },
                    { 3, "Camadas de massa com molho à bolonhesa, molho branco e queijo, assadas à perfeição.", "Lasanha à Bolonhesa", "https://res.cloudinary.com/dslsxyvkp/image/upload/lasanha_bolonhesa_gjtar8.png" },
                    { 4, "Um suculento hambúrguer de carne com queijo, alface, tomate em um pão macio.", "Hambúrguer Clássico", "https://res.cloudinary.com/dslsxyvkp/image/upload/hamburguer_classico_ki7xad.png" },
                    { 5, "Peito de frango empanado, coberto com molho de tomate e queijo muçarela derretido.", "Frango à Parmegiana", "https://res.cloudinary.com/dslsxyvkp/image/upload/frango_parmegiana_os4ych.png" },
                    { 6, "Arroz cremoso cozido lentamente com cogumelos frescos, queijo parmesão e um toque de vinho branco.", "Risoto de Cogumelos", "https://res.cloudinary.com/dslsxyvkp/image/upload/risoto_cogumelos_pxqd7w.png" },
                    { 7, "Alface romana crocante com frango grelhado, croutons, queijo parmesão e molho Caesar cremoso.", "Salada Caesar", "https://res.cloudinary.com/dslsxyvkp/image/upload/salada_caesar_cd6w4z.png" },
                    { 8, "Tortillas de milho macias recheadas com carne temperada, coentro fresco, cebola e um toque de limão.", "Tacos de Carne", "https://res.cloudinary.com/dslsxyvkp/image/upload/tacos_carne_bnmami.png" },
                    { 9, "Rolinhos de arroz temperado com alga nori, recheados com salmão fresco.", "Sushi de Salmão", "https://res.cloudinary.com/dslsxyvkp/image/upload/sushi_salmao_mxw2ro.png" },
                    { 10, "Uma sobremesa aerada e intensa, feita com chocolate meio amargo e creme de leite.", "Mousse de Chocolate", "https://res.cloudinary.com/dslsxyvkp/image/upload/mousse_chocolate_lutgwl.png" }
                });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "IngredientId", "Name" },
                values: new object[,]
                {
                    { 1, "Massa de Pizza" },
                    { 2, "Molho de Tomate" },
                    { 3, "Queijo Muçarela" },
                    { 4, "Manjericão" },
                    { 5, "Azeite de Oliva" },
                    { 6, "Orégano" },
                    { 7, "Espaguete" },
                    { 8, "Ovo" },
                    { 9, "Queijo Parmesão" },
                    { 10, "Bacon" },
                    { 11, "Pimenta do Reino" },
                    { 12, "Massa de Lasanha" },
                    { 13, "Carne Moída" },
                    { 14, "Molho Branco" },
                    { 15, "Pão de Hambúrguer" },
                    { 16, "Hambúrguer de Carne" },
                    { 17, "Alface" },
                    { 18, "Tomate" },
                    { 19, "Queijo Cheddar" },
                    { 20, "Peito de Frango" },
                    { 21, "Farinha de Rosca" },
                    { 22, "Arroz Arbóreo" },
                    { 23, "Cogumelos" },
                    { 24, "Cebola" },
                    { 25, "Vinho Branco" },
                    { 26, "Caldo de Legumes" },
                    { 27, "Alface Romana" },
                    { 28, "Croutons" },
                    { 29, "Molho Caesar" },
                    { 30, "Tortillas de milho" },
                    { 31, "Carne em tiras" },
                    { 32, "Coentro" },
                    { 33, "Limão" },
                    { 34, "Arroz de Sushi" },
                    { 35, "Alga Nori" },
                    { 36, "Salmão" },
                    { 37, "Chocolate Meio Amargo" },
                    { 38, "Creme de Leite" },
                    { 39, "Açúcar" }
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "RecipeId", "DishId", "Instructions" },
                values: new object[,]
                {
                    { 1, 1, "Pré-aqueça o forno na temperatura mais alta possível (mínimo 220°C). Abra o disco de massa de pizza em uma superfície levemente enfarinhada e transfira para uma assadeira. Espalhe uma camada generosa de molho de tomate sobre a massa, deixando uma pequena borda. Distribua uniformemente a muçarela ralada por cima do molho. Regue com um fio de azeite e leve ao forno por 10-15 minutos, ou até a borda dourar e o queijo derreter. Retire do forno e espalhe as folhas de manjericão fresco por cima antes de servir." },
                    { 2, 2, "Cozinhe o espaguete em água salgada fervente até ficar 'al dente'. Enquanto isso, frite o bacon em cubos até ficar crocante. Em uma tigela, bata as gemas com o queijo parmesão ralado e pimenta do reino. Escorra a massa, reservando um pouco da água. Fora do fogo, misture a massa com o bacon e, em seguida, adicione a mistura de ovos, mexendo rapidamente para criar um molho cremoso. Use a água do cozimento para ajustar a consistência, se necessário. Sirva imediatamente." },
                    { 3, 3, "Em uma travessa, monte a lasanha alternando camadas: comece com molho à bolonhesa, seguido por uma camada de massa de lasanha, molho branco e queijo muçarela. Repita as camadas até preencher a travessa, finalizando com uma camada generosa de molho branco e queijo parmesão por cima. Leve ao forno pré-aquecido a 180°C por cerca de 30-40 minutos, ou até dourar." },
                    { 4, 4, "Molde a carne no formato de hambúrguer e tempere com sal e pimenta. Grelhe em uma frigideira quente ou churrasqueira até atingir o ponto desejado. Nos últimos minutos, coloque a fatia de queijo cheddar sobre o hambúrguer para derreter. Toste levemente o pão e monte o lanche com o hambúrguer, alface fresca e rodelas de tomate." },
                    { 5, 5, "Tempere o peito de frango e passe-o no ovo batido e depois na farinha de rosca. Frite em óleo quente até dourar dos dois lados. Em uma travessa, coloque o frango frito, cubra com molho de tomate e queijo muçarela. Leve ao forno pré-aquecido a 200°C apenas para gratinar o queijo, por cerca de 10 minutos." },
                    { 6, 6, "Em uma panela, refogue a cebola picada na manteiga até ficar transparente. Adicione o arroz arbóreo e refogue por mais um minuto. Despeje o vinho branco e mexa até evaporar. Aos poucos, adicione o caldo de legumes quente, uma concha por vez, mexendo sempre até o arroz absorver o líquido. Quando o arroz estiver 'al dente', adicione os cogumelos fatiados, o queijo parmesão e mais uma colher de manteiga. Misture bem e sirva." },
                    { 7, 7, "Grelhe o peito de frango temperado e corte em tiras. Em uma saladeira, misture a alface romana rasgada, os croutons e as lascas de parmesão. Adicione o frango grelhado por cima e regue tudo com o molho Caesar, misturando delicadamente para cobrir todos os ingredientes." },
                    { 8, 8, "Tempere as tiras de carne com sal, pimenta e cominho. Grelhe em uma frigideira bem quente até dourarem. Aqueça as tortillas em outra frigideira ou no micro-ondas. Monte os tacos recheando cada tortilla com a carne grelhada, cebola picada e folhas de coentro. Sirva imediatamente com fatias de limão para espremer por cima." },
                    { 9, 9, "Em uma esteira de bambu (sudare), coloque uma folha de alga nori com o lado brilhante para baixo. Umedeça as mãos e espalhe uma camada fina e uniforme de arroz de sushi sobre a alga, deixando uma borda livre. Posicione as tiras de salmão no centro do arroz. Enrole firmemente a alga com a ajuda da esteira. Com uma faca afiada e úmida, corte o rolo em 8 peças iguais." },
                    { 10, 10, "Derreta o chocolate meio amargo em banho-maria ou no micro-ondas. Em outra tigela, bata o creme de leite fresco (ou as claras em neve com açúcar) até formar picos firmes. Incorpore delicadamente o chocolate derretido e já morno à mistura, com movimentos de baixo para cima para não perder a aeração. Despeje em taças individuais e leve à geladeira por pelo menos 4 horas antes de servir." }
                });

            migrationBuilder.InsertData(
                table: "RecipeIngredient",
                columns: new[] { "IngredientId", "RecipeId", "MeasurementUnit", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, "unidade(s)", 1.0 },
                    { 2, 1, "grama(s)", 150.0 },
                    { 3, 1, "grama(s)", 200.0 },
                    { 4, 1, "punhado(s)", 1.0 },
                    { 5, 1, "fio(s)", 1.0 },
                    { 6, 1, "pitada(s)", 1.0 },
                    { 7, 2, "grama(s)", 200.0 },
                    { 8, 2, "unidade(s)", 2.0 },
                    { 9, 2, "grama(s)", 50.0 },
                    { 10, 2, "grama(s)", 100.0 },
                    { 11, 2, "pitada(s)", 1.0 },
                    { 2, 3, "grama(s)", 300.0 },
                    { 3, 3, "grama(s)", 250.0 },
                    { 12, 3, "grama(s)", 250.0 },
                    { 13, 3, "grama(s)", 300.0 },
                    { 14, 3, "ml", 200.0 },
                    { 15, 4, "unidade(s)", 1.0 },
                    { 16, 4, "grama(s)", 150.0 },
                    { 17, 4, "folha(s)", 2.0 },
                    { 18, 4, "fatia(s)", 2.0 },
                    { 19, 4, "fatia(s)", 1.0 },
                    { 2, 5, "grama(s)", 150.0 },
                    { 3, 5, "grama(s)", 100.0 },
                    { 8, 5, "unidade(s)", 1.0 },
                    { 20, 5, "unidade(s)", 1.0 },
                    { 21, 5, "grama(s)", 100.0 },
                    { 9, 6, "grama(s)", 50.0 },
                    { 22, 6, "grama(s)", 150.0 },
                    { 23, 6, "grama(s)", 100.0 },
                    { 24, 6, "unidade(s)", 0.5 },
                    { 25, 6, "ml", 50.0 },
                    { 26, 6, "ml", 500.0 },
                    { 9, 7, "grama(s)", 30.0 },
                    { 20, 7, "grama(s)", 150.0 },
                    { 27, 7, "unidade(s)", 1.0 },
                    { 28, 7, "grama(s)", 50.0 },
                    { 29, 7, "ml", 50.0 },
                    { 24, 8, "unidade(s)", 0.25 },
                    { 30, 8, "unidade(s)", 3.0 },
                    { 31, 8, "grama(s)", 150.0 },
                    { 32, 8, "punhado(s)", 1.0 },
                    { 33, 8, "unidade(s)", 0.5 },
                    { 34, 9, "grama(s)", 100.0 },
                    { 35, 9, "folha(s)", 1.0 },
                    { 36, 9, "grama(s)", 50.0 },
                    { 8, 10, "unidade(s)", 2.0 },
                    { 37, 10, "grama(s)", 150.0 },
                    { 38, 10, "grama(s)", 100.0 },
                    { 39, 10, "grama(s)", 50.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Favorites_DishId",
                table: "Favorites",
                column: "DishId");

            migrationBuilder.CreateIndex(
                name: "IX_Publications_DishId",
                table: "Publications",
                column: "DishId");

            migrationBuilder.CreateIndex(
                name: "IX_Publications_UserId",
                table: "Publications",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_DishId",
                table: "Ratings",
                column: "DishId");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_UserId",
                table: "Ratings",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeIngredient_IngredientId",
                table: "RecipeIngredient",
                column: "IngredientId");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_DishId",
                table: "Recipes",
                column: "DishId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Favorites");

            migrationBuilder.DropTable(
                name: "Publications");

            migrationBuilder.DropTable(
                name: "Ratings");

            migrationBuilder.DropTable(
                name: "RecipeIngredient");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Ingredients");

            migrationBuilder.DropTable(
                name: "Recipes");

            migrationBuilder.DropTable(
                name: "Dishes");
        }
    }
}
