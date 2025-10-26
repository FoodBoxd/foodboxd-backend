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
                new Ingredient { IngredientId = 1, Name = "Massa de Pizza"},
                new Ingredient { IngredientId = 2, Name = "Molho de Tomate" },
                new Ingredient { IngredientId = 3, Name = "Queijo Muçarela" },
                new Ingredient { IngredientId = 4, Name = "Manjericão" },
                new Ingredient { IngredientId = 5, Name = "Azeite de Oliva" },
                new Ingredient { IngredientId = 6, Name = "Orégano" }
            );
        }

        // Função para popular Dishes, Recipes e seus relacionamentos
        private static void SeedDishesRecipes(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dish>().HasData(
                new Dish { DishId = 1, Name = "Pizza Marguerita", Description = "A Pizza Marguerita é um clássico napolitano, famosa por seus ingredientes simples e frescos que representam as cores da bandeira italiana: tomate (vermelho), muçarela (branco) e manjericão (verde). É uma pizza leve, aromática e icônica.", Photo = ReadImageFile("pizza_marguerita.png") }
            );

            modelBuilder.Entity<Recipe>().HasData(
                new Recipe { RecipeId = 1, DishId = 1, Instructions = "Pré-aqueça o forno na temperatura mais alta possível (mínimo 220°C). Abra o disco de massa de pizza em uma superfície levemente enfarinhada e transfira para uma assadeira. Espalhe uma camada generosa de molho de tomate pronto sobre a massa, deixando uma pequena borda. Distribua uniformemente a muçarela ralada ou em pedaços por cima do molho. Polvilhe o orégano (se estiver usando) e regue tudo com um fio de azeite. Leve ao forno quente por aproximadamente 10 a 15 minutos, ou até que a borda da massa esteja dourada e o queijo esteja completamente derretido e borbulhante. Retire do forno e espalhe as folhas de manjericão fresco por cima antes de servir." }
            );

            modelBuilder.Entity<RecipeIngredient>().HasData(
                new RecipeIngredient { RecipeId = 1, IngredientId = 1, Quantity = 1, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 1, IngredientId = 2, Quantity = 150, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 1, IngredientId = 3, Quantity = 200, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 1, IngredientId = 4, Quantity = 1, MeasurementUnit = "punhado(s)" },
                new RecipeIngredient { RecipeId = 1, IngredientId = 5, Quantity = 1, MeasurementUnit = "fio(s)" },
                new RecipeIngredient { RecipeId = 1, IngredientId = 6, Quantity = 1, MeasurementUnit = "pitada(s)" }
            );
        }
    }
}