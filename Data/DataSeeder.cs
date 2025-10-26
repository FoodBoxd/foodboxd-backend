using foodboxd_backend.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;

namespace foodboxd_backend.Data
{
    public static class DataSeeder
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            SeedIngredients(modelBuilder);
            SeedDishesRecipes(modelBuilder);
        }

        // Função auxiliar para ler um arquivo de imagem e retorna seus bytes (para armazenar no banco)
        private static byte[] ReadImageFile(string fileName)
        {
            string imagePath = Path.Combine("Data", "SeedImages", fileName);

            try
            {
                if (File.Exists(imagePath))
                {
                    return File.ReadAllBytes(imagePath);
                }

                // Caminho alternativo (fallback) para o 'dotnet ef'
                string altPath = Path.Combine(AppContext.BaseDirectory, imagePath);
                if (File.Exists(altPath))
                {
                    return File.ReadAllBytes(altPath);
                }
            }
            catch
            {
                // Retorna vazio se der erro ou não encontrar
            }
            return Array.Empty<byte>();
        }

        // Função para popular Ingredients
        private static void SeedIngredients(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ingredient>().HasData(
                new Ingredient { IngredientId = 1, Name = "Massa de Pizza" },
                new Ingredient { IngredientId = 2, Name = "Molho de Tomate" },
                new Ingredient { IngredientId = 3, Name = "Queijo Muçarela" },
                new Ingredient { IngredientId = 4, Name = "Manjericão" },
                new Ingredient { IngredientId = 5, Name = "Azeite de Oliva" },
                new Ingredient { IngredientId = 6, Name = "Orégano" },
                new Ingredient { IngredientId = 7, Name = "Espaguete" },
                new Ingredient { IngredientId = 8, Name = "Ovo" },
                new Ingredient { IngredientId = 9, Name = "Queijo Parmesão" },
                new Ingredient { IngredientId = 10, Name = "Bacon" },
                new Ingredient { IngredientId = 11, Name = "Pimenta do Reino" },
                new Ingredient { IngredientId = 12, Name = "Massa de Lasanha" },
                new Ingredient { IngredientId = 13, Name = "Carne Moída" },
                new Ingredient { IngredientId = 14, Name = "Molho Branco" },
                new Ingredient { IngredientId = 15, Name = "Pão de Hambúrguer" },
                new Ingredient { IngredientId = 16, Name = "Hambúrguer de Carne" },
                new Ingredient { IngredientId = 17, Name = "Alface" },
                new Ingredient { IngredientId = 18, Name = "Tomate" },
                new Ingredient { IngredientId = 19, Name = "Queijo Cheddar" },
                new Ingredient { IngredientId = 20, Name = "Peito de Frango" },
                new Ingredient { IngredientId = 21, Name = "Farinha de Rosca" },
                new Ingredient { IngredientId = 22, Name = "Arroz Arbóreo" },
                new Ingredient { IngredientId = 23, Name = "Cogumelos" },
                new Ingredient { IngredientId = 24, Name = "Cebola" },
                new Ingredient { IngredientId = 25, Name = "Vinho Branco" },
                new Ingredient { IngredientId = 26, Name = "Caldo de Legumes" },
                new Ingredient { IngredientId = 27, Name = "Alface Romana" },
                new Ingredient { IngredientId = 28, Name = "Croutons" },
                new Ingredient { IngredientId = 29, Name = "Molho Caesar" },
                new Ingredient { IngredientId = 30, Name = "Tortillas de milho" },
                new Ingredient { IngredientId = 31, Name = "Carne em tiras" },
                new Ingredient { IngredientId = 32, Name = "Coentro" },
                new Ingredient { IngredientId = 33, Name = "Limão" },
                new Ingredient { IngredientId = 34, Name = "Arroz de Sushi" },
                new Ingredient { IngredientId = 35, Name = "Alga Nori" },
                new Ingredient { IngredientId = 36, Name = "Salmão" },
                new Ingredient { IngredientId = 37, Name = "Chocolate Meio Amargo" },
                new Ingredient { IngredientId = 38, Name = "Creme de Leite" },
                new Ingredient { IngredientId = 39, Name = "Açúcar" }
            );
        }

        // Função para popular Dishes, Recipes e seus relacionamentos
        private static void SeedDishesRecipes(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dish>().HasData(
                new Dish { DishId = 1, Name = "Pizza Marguerita", Description = "A Pizza Marguerita é um clássico napolitano, famosa por seus ingredientes simples e frescos que representam as cores da bandeira italiana.", Photo = ReadImageFile("pizza_marguerita.png") },
                new Dish { DishId = 2, Name = "Spaghetti Carbonara", Description = "Um prato de massa italiano de Roma, feito com ovos, queijo duro, carne de porco curada e pimenta preta.", Photo = ReadImageFile("spaghetti_carbonara.png") },
                new Dish { DishId = 3, Name = "Lasanha à Bolonhesa", Description = "Camadas de massa com molho à bolonhesa, molho branco e queijo, assadas à perfeição.", Photo = ReadImageFile("lasanha_bolonhesa.png") },
                new Dish { DishId = 4, Name = "Hambúrguer Clássico", Description = "Um suculento hambúrguer de carne com queijo, alface, tomate em um pão macio.", Photo = ReadImageFile("hamburguer_classico.png") },
                new Dish { DishId = 5, Name = "Frango à Parmegiana", Description = "Peito de frango empanado, coberto com molho de tomate e queijo muçarela derretido.", Photo = ReadImageFile("frango_parmegiana.png") },
                new Dish { DishId = 6, Name = "Risoto de Cogumelos", Description = "Arroz cremoso cozido lentamente com cogumelos frescos, queijo parmesão e um toque de vinho branco.", Photo = ReadImageFile("risoto_cogumelos.png") },
                new Dish { DishId = 7, Name = "Salada Caesar", Description = "Alface romana crocante com frango grelhado, croutons, queijo parmesão e molho Caesar cremoso.", Photo = ReadImageFile("salada_caesar.png") },
                new Dish { DishId = 8, Name = "Tacos de Carne", Description = "Tortillas de milho macias recheadas com carne temperada, coentro fresco, cebola e um toque de limão.", Photo = ReadImageFile("tacos_carne.png") },
                new Dish { DishId = 9, Name = "Sushi de Salmão", Description = "Rolinhos de arroz temperado com alga nori, recheados com salmão fresco.", Photo = ReadImageFile("sushi_salmao.png") },
                new Dish { DishId = 10, Name = "Mousse de Chocolate", Description = "Uma sobremesa aerada e intensa, feita com chocolate meio amargo e creme de leite.", Photo = ReadImageFile("mousse_chocolate.png") }
            );

            modelBuilder.Entity<Recipe>().HasData(
                new Recipe { RecipeId = 1, DishId = 1, Instructions = "Pré-aqueça o forno na temperatura mais alta possível (mínimo 220°C). Abra o disco de massa de pizza em uma superfície levemente enfarinhada e transfira para uma assadeira. Espalhe uma camada generosa de molho de tomate sobre a massa, deixando uma pequena borda. Distribua uniformemente a muçarela ralada por cima do molho. Regue com um fio de azeite e leve ao forno por 10-15 minutos, ou até a borda dourar e o queijo derreter. Retire do forno e espalhe as folhas de manjericão fresco por cima antes de servir." },
                new Recipe { RecipeId = 2, DishId = 2, Instructions = "Cozinhe o espaguete em água salgada fervente até ficar 'al dente'. Enquanto isso, frite o bacon em cubos até ficar crocante. Em uma tigela, bata as gemas com o queijo parmesão ralado e pimenta do reino. Escorra a massa, reservando um pouco da água. Fora do fogo, misture a massa com o bacon e, em seguida, adicione a mistura de ovos, mexendo rapidamente para criar um molho cremoso. Use a água do cozimento para ajustar a consistência, se necessário. Sirva imediatamente." },
                new Recipe { RecipeId = 3, DishId = 3, Instructions = "Em uma travessa, monte a lasanha alternando camadas: comece com molho à bolonhesa, seguido por uma camada de massa de lasanha, molho branco e queijo muçarela. Repita as camadas até preencher a travessa, finalizando com uma camada generosa de molho branco e queijo parmesão por cima. Leve ao forno pré-aquecido a 180°C por cerca de 30-40 minutos, ou até dourar." },
                new Recipe { RecipeId = 4, DishId = 4, Instructions = "Molde a carne no formato de hambúrguer e tempere com sal e pimenta. Grelhe em uma frigideira quente ou churrasqueira até atingir o ponto desejado. Nos últimos minutos, coloque a fatia de queijo cheddar sobre o hambúrguer para derreter. Toste levemente o pão e monte o lanche com o hambúrguer, alface fresca e rodelas de tomate." },
                new Recipe { RecipeId = 5, DishId = 5, Instructions = "Tempere o peito de frango e passe-o no ovo batido e depois na farinha de rosca. Frite em óleo quente até dourar dos dois lados. Em uma travessa, coloque o frango frito, cubra com molho de tomate e queijo muçarela. Leve ao forno pré-aquecido a 200°C apenas para gratinar o queijo, por cerca de 10 minutos." },
                new Recipe { RecipeId = 6, DishId = 6, Instructions = "Em uma panela, refogue a cebola picada na manteiga até ficar transparente. Adicione o arroz arbóreo e refogue por mais um minuto. Despeje o vinho branco e mexa até evaporar. Aos poucos, adicione o caldo de legumes quente, uma concha por vez, mexendo sempre até o arroz absorver o líquido. Quando o arroz estiver 'al dente', adicione os cogumelos fatiados, o queijo parmesão e mais uma colher de manteiga. Misture bem e sirva." },
                new Recipe { RecipeId = 7, DishId = 7, Instructions = "Grelhe o peito de frango temperado e corte em tiras. Em uma saladeira, misture a alface romana rasgada, os croutons e as lascas de parmesão. Adicione o frango grelhado por cima e regue tudo com o molho Caesar, misturando delicadamente para cobrir todos os ingredientes." },
                new Recipe { RecipeId = 8, DishId = 8, Instructions = "Tempere as tiras de carne com sal, pimenta e cominho. Grelhe em uma frigideira bem quente até dourarem. Aqueça as tortillas em outra frigideira ou no micro-ondas. Monte os tacos recheando cada tortilla com a carne grelhada, cebola picada e folhas de coentro. Sirva imediatamente com fatias de limão para espremer por cima." },
                new Recipe { RecipeId = 9, DishId = 9, Instructions = "Em uma esteira de bambu (sudare), coloque uma folha de alga nori com o lado brilhante para baixo. Umedeça as mãos e espalhe uma camada fina e uniforme de arroz de sushi sobre a alga, deixando uma borda livre. Posicione as tiras de salmão no centro do arroz. Enrole firmemente a alga com a ajuda da esteira. Com uma faca afiada e úmida, corte o rolo em 8 peças iguais." },
                new Recipe { RecipeId = 10, DishId = 10, Instructions = "Derreta o chocolate meio amargo em banho-maria ou no micro-ondas. Em outra tigela, bata o creme de leite fresco (ou as claras em neve com açúcar) até formar picos firmes. Incorpore delicadamente o chocolate derretido e já morno à mistura, com movimentos de baixo para cima para não perder a aeração. Despeje em taças individuais e leve à geladeira por pelo menos 4 horas antes de servir." }
            );

            modelBuilder.Entity<RecipeIngredient>().HasData(
                // Pizza Marguerita (1)
                new RecipeIngredient { RecipeId = 1, IngredientId = 1, Quantity = 1, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 1, IngredientId = 2, Quantity = 150, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 1, IngredientId = 3, Quantity = 200, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 1, IngredientId = 4, Quantity = 1, MeasurementUnit = "punhado(s)" },
                new RecipeIngredient { RecipeId = 1, IngredientId = 5, Quantity = 1, MeasurementUnit = "fio(s)" },
                new RecipeIngredient { RecipeId = 1, IngredientId = 6, Quantity = 1, MeasurementUnit = "pitada(s)" },
                // Spaghetti Carbonara (2)
                new RecipeIngredient { RecipeId = 2, IngredientId = 7, Quantity = 200, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 2, IngredientId = 8, Quantity = 2, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 2, IngredientId = 9, Quantity = 50, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 2, IngredientId = 10, Quantity = 100, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 2, IngredientId = 11, Quantity = 1, MeasurementUnit = "pitada(s)" },
                // Lasanha à Bolonhesa (3)
                new RecipeIngredient { RecipeId = 3, IngredientId = 12, Quantity = 250, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 3, IngredientId = 13, Quantity = 300, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 3, IngredientId = 2, Quantity = 300, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 3, IngredientId = 14, Quantity = 200, MeasurementUnit = "ml" },
                new RecipeIngredient { RecipeId = 3, IngredientId = 3, Quantity = 250, MeasurementUnit = "grama(s)" },
                // Hambúrguer Clássico (4)
                new RecipeIngredient { RecipeId = 4, IngredientId = 15, Quantity = 1, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 4, IngredientId = 16, Quantity = 150, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 4, IngredientId = 17, Quantity = 2, MeasurementUnit = "folha(s)" },
                new RecipeIngredient { RecipeId = 4, IngredientId = 18, Quantity = 2, MeasurementUnit = "fatia(s)" },
                new RecipeIngredient { RecipeId = 4, IngredientId = 19, Quantity = 1, MeasurementUnit = "fatia(s)" },
                // Frango à Parmegiana (5)
                new RecipeIngredient { RecipeId = 5, IngredientId = 20, Quantity = 1, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 5, IngredientId = 21, Quantity = 100, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 5, IngredientId = 8, Quantity = 1, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 5, IngredientId = 2, Quantity = 150, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 5, IngredientId = 3, Quantity = 100, MeasurementUnit = "grama(s)" },
                // Risoto de Cogumelos (6)
                new RecipeIngredient { RecipeId = 6, IngredientId = 22, Quantity = 150, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 6, IngredientId = 23, Quantity = 100, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 6, IngredientId = 24, Quantity = 0.5, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 6, IngredientId = 25, Quantity = 50, MeasurementUnit = "ml" },
                new RecipeIngredient { RecipeId = 6, IngredientId = 26, Quantity = 500, MeasurementUnit = "ml" },
                new RecipeIngredient { RecipeId = 6, IngredientId = 9, Quantity = 50, MeasurementUnit = "grama(s)" },
                // Salada Caesar (7)
                new RecipeIngredient { RecipeId = 7, IngredientId = 27, Quantity = 1, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 7, IngredientId = 20, Quantity = 150, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 7, IngredientId = 28, Quantity = 50, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 7, IngredientId = 9, Quantity = 30, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 7, IngredientId = 29, Quantity = 50, MeasurementUnit = "ml" },
                // Tacos de Carne (8)
                new RecipeIngredient { RecipeId = 8, IngredientId = 30, Quantity = 3, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 8, IngredientId = 31, Quantity = 150, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 8, IngredientId = 24, Quantity = 0.25, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 8, IngredientId = 32, Quantity = 1, MeasurementUnit = "punhado(s)" },
                new RecipeIngredient { RecipeId = 8, IngredientId = 33, Quantity = 0.5, MeasurementUnit = "unidade(s)" },
                // Sushi de Salmão (9)
                new RecipeIngredient { RecipeId = 9, IngredientId = 34, Quantity = 100, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 9, IngredientId = 35, Quantity = 1, MeasurementUnit = "folha(s)" },
                new RecipeIngredient { RecipeId = 9, IngredientId = 36, Quantity = 50, MeasurementUnit = "grama(s)" },
                // Mousse de Chocolate (10)
                new RecipeIngredient { RecipeId = 10, IngredientId = 37, Quantity = 150, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 10, IngredientId = 38, Quantity = 100, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 10, IngredientId = 39, Quantity = 50, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 10, IngredientId = 8, Quantity = 2, MeasurementUnit = "unidade(s)" }
            );
        }
    }
}