using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace foodboxd_backend.Migrations
{
    /// <inheritdoc />
    public partial class UpdateRecipeIngredientsColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Quantity",
                table: "RecipeIngredient",
                type: "double",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 1,
                column: "Description",
                value: "A Pizza Marguerita é um clássico napolitano, famosa por seus ingredientes simples e frescos que representam as cores da bandeira italiana.");

            migrationBuilder.InsertData(
                table: "Dishes",
                columns: new[] { "DishId", "Description", "Name", "Photo" },
                values: new object[,]
                {
                    { 2, "Um prato de massa italiano de Roma, feito com ovos, queijo duro, carne de porco curada e pimenta preta.", "Spaghetti Carbonara", new byte[0] },
                    { 3, "Camadas de massa com molho à bolonhesa, molho branco e queijo, assadas à perfeição.", "Lasanha à Bolonhesa", new byte[0] },
                    { 4, "Um suculento hambúrguer de carne com queijo, alface, tomate em um pão macio.", "Hambúrguer Clássico", new byte[0] },
                    { 5, "Peito de frango empanado, coberto com molho de tomate e queijo muçarela derretido.", "Frango à Parmegiana", new byte[0] },
                    { 6, "Arroz cremoso cozido lentamente com cogumelos frescos, queijo parmesão e um toque de vinho branco.", "Risoto de Cogumelos", new byte[0] },
                    { 7, "Alface romana crocante com frango grelhado, croutons, queijo parmesão e molho Caesar cremoso.", "Salada Caesar", new byte[0] },
                    { 8, "Tortillas de milho macias recheadas com carne temperada, coentro fresco, cebola e um toque de limão.", "Tacos de Carne", new byte[0] },
                    { 9, "Rolinhos de arroz temperado com alga nori, recheados com salmão fresco.", "Sushi de Salmão", new byte[0] },
                    { 10, "Uma sobremesa aerada e intensa, feita com chocolate meio amargo e creme de leite.", "Mousse de Chocolate", new byte[0] }
                });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "IngredientId", "Name" },
                values: new object[,]
                {
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

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 1, 1 },
                column: "Quantity",
                value: 1.0);

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 2, 1 },
                column: "Quantity",
                value: 150.0);

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 3, 1 },
                column: "Quantity",
                value: 200.0);

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 4, 1 },
                column: "Quantity",
                value: 1.0);

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 5, 1 },
                column: "Quantity",
                value: 1.0);

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 6, 1 },
                column: "Quantity",
                value: 1.0);

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 1,
                column: "Instructions",
                value: "Pré-aqueça o forno. Abra a massa, espalhe molho de tomate, cubra com muçarela e manjericão. Asse até dourar.");

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "RecipeId", "DishId", "Instructions" },
                values: new object[,]
                {
                    { 2, 2, "Cozinhe o espaguete. Frite o bacon. Misture as gemas com queijo parmesão e pimenta. Junte tudo rapidamente fora do fogo." },
                    { 3, 3, "Monte camadas de massa, molho à bolonhesa, molho branco e queijo. Repita e finalize com queijo. Asse até borbulhar." },
                    { 4, 4, "Grelhe o hambúrguer. Monte no pão com queijo, alface e tomate." },
                    { 5, 5, "Empane e frite o frango. Cubra com molho de tomate e queijo. Gratine no forno." },
                    { 6, 6, "Refogue a cebola, adicione o arroz e o vinho. Vá adicionando caldo de legumes aos poucos, mexendo sempre. Finalize com cogumelos, manteiga e parmesão." },
                    { 7, 7, "Grelhe o frango. Misture a alface, os croutons e o queijo. Adicione o frango fatiado e regue com molho Caesar." },
                    { 8, 8, "Aqueça as tortillas. Recheie com a carne, cebola picada e coentro. Sirva com limão." },
                    { 9, 9, "Espalhe o arroz sobre a alga nori. Adicione uma tira de salmão e enrole firmemente. Fatie os rolinhos." },
                    { 10, 10, "Derreta o chocolate. Incorpore o creme de leite e as claras em neve (opcional). Leve à geladeira por 4 horas." }
                });

            migrationBuilder.InsertData(
                table: "RecipeIngredient",
                columns: new[] { "IngredientId", "RecipeId", "MeasurementUnit", "Quantity" },
                values: new object[,]
                {
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 7, 2 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 8, 2 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 9, 2 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 10, 2 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 11, 2 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 12, 3 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 13, 3 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 14, 3 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 15, 4 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 16, 4 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 17, 4 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 18, 4 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 19, 4 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 8, 5 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 20, 5 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 21, 5 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 9, 6 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 22, 6 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 23, 6 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 24, 6 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 25, 6 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 26, 6 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 9, 7 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 20, 7 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 27, 7 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 28, 7 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 29, 7 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 24, 8 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 30, 8 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 31, 8 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 32, 8 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 33, 8 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 34, 9 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 35, 9 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 36, 9 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 8, 10 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 37, 10 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 38, 10 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 39, 10 });

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 10);

            migrationBuilder.AlterColumn<int>(
                name: "Quantity",
                table: "RecipeIngredient",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double");

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 1,
                column: "Description",
                value: "A Pizza Marguerita é um clássico napolitano, famosa por seus ingredientes simples e frescos que representam as cores da bandeira italiana: tomate (vermelho), muçarela (branco) e manjericão (verde). É uma pizza leve, aromática e icônica.");

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 1, 1 },
                column: "Quantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 2, 1 },
                column: "Quantity",
                value: 150);

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 3, 1 },
                column: "Quantity",
                value: 200);

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 4, 1 },
                column: "Quantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 5, 1 },
                column: "Quantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 6, 1 },
                column: "Quantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 1,
                column: "Instructions",
                value: "Pré-aqueça o forno na temperatura mais alta possível (mínimo 220°C). Abra o disco de massa de pizza em uma superfície levemente enfarinhada e transfira para uma assadeira. Espalhe uma camada generosa de molho de tomate pronto sobre a massa, deixando uma pequena borda. Distribua uniformemente a muçarela ralada ou em pedaços por cima do molho. Polvilhe o orégano (se estiver usando) e regue tudo com um fio de azeite. Leve ao forno quente por aproximadamente 10 a 15 minutos, ou até que a borda da massa esteja dourada e o queijo esteja completamente derretido e borbulhante. Retire do forno e espalhe as folhas de manjericão fresco por cima antes de servir.");
        }
    }
}
