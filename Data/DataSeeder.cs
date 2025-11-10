using foodboxd_backend.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace foodboxd_backend.Data
{
    public static class DataSeeder
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            SeedIngredients(modelBuilder);
            SeedDishesRecipes(modelBuilder);
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
                new Ingredient { IngredientId = 39, Name = "Açúcar" },
                new Ingredient { IngredientId = 40, Name = "Baunilha" },
                new Ingredient { IngredientId = 41, Name = "Bulgur (Trigo para Kibe)" },
                new Ingredient { IngredientId = 42, Name = "Salsinha" },
                new Ingredient { IngredientId = 43, Name = "Hortelã" },
                new Ingredient { IngredientId = 44, Name = "Farinha de Trigo" },
                new Ingredient { IngredientId = 45, Name = "Leite" },
                new Ingredient { IngredientId = 46, Name = "Banana" },
                new Ingredient { IngredientId = 47, Name = "Manteiga" },
                new Ingredient { IngredientId = 48, Name = "Leite de Coco" },
                new Ingredient { IngredientId = 49, Name = "Pimentão" },
                new Ingredient { IngredientId = 50, Name = "Leite Condensado" },
                new Ingredient { IngredientId = 51, Name = "Camarão" },
                new Ingredient { IngredientId = 52, Name = "Mandioca (Aipim)" },
                new Ingredient { IngredientId = 53, Name = "Massa Folhada" },
                new Ingredient { IngredientId = 54, Name = "Alho" },
                new Ingredient { IngredientId = 55, Name = "Biscoito (Maizena)" },
                new Ingredient { IngredientId = 56, Name = "Feijão Preto" },
                new Ingredient { IngredientId = 57, Name = "Azeite de Dendê" },
                new Ingredient { IngredientId = 58, Name = "Carne Seca" },
                new Ingredient { IngredientId = 59, Name = "Linguiça" },
                new Ingredient { IngredientId = 60, Name = "Farinha de Mandioca" },
                new Ingredient { IngredientId = 61, Name = "Feijão-Fradinho" },
                new Ingredient { IngredientId = 62, Name = "Amendoim" },
                new Ingredient { IngredientId = 63, Name = "Queijo Coalho" },
                new Ingredient { IngredientId = 64, Name = "Picanha" },
                new Ingredient { IngredientId = 65, Name = "Óleo para Fritura" },
                new Ingredient { IngredientId = 66, Name = "Feijão de Corda" },
                new Ingredient { IngredientId = 67, Name = "Milho para Canjica" },
                new Ingredient { IngredientId = 68, Name = "Canela" },
                new Ingredient { IngredientId = 69, Name = "Molho de Soja" },
                new Ingredient { IngredientId = 70, Name = "Gengibre" },
                new Ingredient { IngredientId = 71, Name = "Óleo de Gergelim" },
                new Ingredient { IngredientId = 72, Name = "Cebolinha" },
                new Ingredient { IngredientId = 73, Name = "Noodles (Macarrão Asiático)" },
                new Ingredient { IngredientId = 74, Name = "Curry em Pó" },
                new Ingredient { IngredientId = 75, Name = "Tofu" },
                new Ingredient { IngredientId = 76, Name = "Molho de Peixe" },
                new Ingredient { IngredientId = 77, Name = "Mirin" },
                new Ingredient { IngredientId = 78, Name = "Pimenta Dedo-de-Moça" },
                new Ingredient { IngredientId = 79, Name = "Sementes de Gergelim" },
                new Ingredient { IngredientId = 80, Name = "Shiitake" },
                new Ingredient { IngredientId = 81, Name = "Vinho Tinto" },
                new Ingredient { IngredientId = 82, Name = "Mascarpone" },
                new Ingredient { IngredientId = 83, Name = "Azeitonas" },
                new Ingredient { IngredientId = 84, Name = "Alcaparras" },
                new Ingredient { IngredientId = 85, Name = "Açafrão" },
                new Ingredient { IngredientId = 86, Name = "Mexilhão" },
                new Ingredient { IngredientId = 87, Name = "Berinjela" },
                new Ingredient { IngredientId = 88, Name = "Batata" },
                new Ingredient { IngredientId = 89, Name = "Tomilho" },
                new Ingredient { IngredientId = 90, Name = "Alecrim" },
                new Ingredient { IngredientId = 91, Name = "Café" },
                new Ingredient { IngredientId = 92, Name = "Frutas Vermelhas" },
                new Ingredient { IngredientId = 93, Name = "Cream Cheese" },
                new Ingredient { IngredientId = 94, Name = "Gelatina" },
                new Ingredient { IngredientId = 95, Name = "Maçã" },
                // Ingredientes adicionais para Street Foods
                new Ingredient { IngredientId = 96, Name = "Farinha de Milho" },
                new Ingredient { IngredientId = 97, Name = "Grão-de-bico" },
                new Ingredient { IngredientId = 98, Name = "Tahine" },
                new Ingredient { IngredientId = 99, Name = "Baguete" },
                new Ingredient { IngredientId = 100, Name = "Polvilho Doce" },
                new Ingredient { IngredientId = 101, Name = "Ervilha" },
                new Ingredient { IngredientId = 102, Name = "Pão Sírio" },
                // Ingredientes mediterrâneos adicionais
                new Ingredient { IngredientId = 103, Name = "Queijo Feta" },
                new Ingredient { IngredientId = 104, Name = "Pepino" },
                // Ingredientes africanos adicionais
                new Ingredient { IngredientId = 105, Name = "Quiabo" },
                new Ingredient { IngredientId = 106, Name = "Cuscuz" },
                new Ingredient { IngredientId = 107, Name = "Iogurte" },
                // Ingredientes adicionais para novos lotes (91..100)
                new Ingredient { IngredientId = 108, Name = "Peixe Branco" },
                new Ingredient { IngredientId = 109, Name = "Berbere (tempero)" },
                new Ingredient { IngredientId = 110, Name = "Allspice (Pimenta-da-Jamaica)" },
                new Ingredient { IngredientId = 111, Name = "Queijo Sulguni" },
                new Ingredient { IngredientId = 112, Name = "Vinagre" },
                new Ingredient { IngredientId = 113, Name = "Pimenta Scotch Bonnet" },
                new Ingredient { IngredientId = 114, Name = "Noz (Walnut)" },
                new Ingredient { IngredientId = 115, Name = "Molho de Romã" }
            );
        }

        // Função para popular Dishes, Recipes e seus relacionamentos
        private static void SeedDishesRecipes(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dish>().HasData(
                new Dish { DishId = 1, Name = "Pizza Marguerita", Description = "A Pizza Marguerita é um clássico napolitano, famosa por seus ingredientes simples e frescos que representam as cores da bandeira italiana.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                new Dish { DishId = 2, Name = "Spaghetti Carbonara", Description = "Um prato de massa italiano de Roma, feito com ovos, queijo duro, carne de porco curada e pimenta preta.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/spaghetti_carbonara_twqcuv.png" },
                new Dish { DishId = 3, Name = "Lasanha à Bolonhesa", Description = "Camadas de massa com molho à bolonhesa, molho branco e queijo, assadas à perfeição.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/lasanha_bolonhesa_gjtar8.png" },
                new Dish { DishId = 4, Name = "Hambúrguer Clássico", Description = "Um suculento hambúrguer de carne com queijo, alface, tomate em um pão macio.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/hamburguer_classico_ki7xad.png" },
                new Dish { DishId = 5, Name = "Frango à Parmegiana", Description = "Peito de frango empanado, coberto com molho de tomate e queijo muçarela derretido.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/frango_parmegiana_os4ych.png" },
                new Dish { DishId = 6, Name = "Risoto de Cogumelos", Description = "Arroz cremoso cozido lentamente com cogumelos frescos, queijo parmesão e um toque de vinho branco.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/risoto_cogumelos_pxqd7w.png" },
                new Dish { DishId = 7, Name = "Salada Caesar", Description = "Alface romana crocante com frango grelhado, croutons, queijo parmesão e molho Caesar cremoso.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/salada_caesar_cd6w4z.png" },
                new Dish { DishId = 8, Name = "Tacos de Carne", Description = "Tortillas de milho macias recheadas com carne temperada, coentro fresco, cebola e um toque de limão.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/tacos_carne_bnmami.png" },
                new Dish { DishId = 9, Name = "Sushi de Salmão", Description = "Rolinhos de arroz temperado com alga nori, recheados com salmão fresco.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/sushi_salmao_mxw2ro.png" },
                new Dish { DishId = 10, Name = "Mousse de Chocolate", Description = "Uma sobremesa aerada e intensa, feita com chocolate meio amargo e creme de leite.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/mousse_chocolate_lutgwl.png" },
                new Dish { DishId = 11, Name = "Creme Brûlée", Description = "Sobremesa clássica francesa com creme aveludado e cobertura crocante de açúcar queimado.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                new Dish { DishId = 12, Name = "Tabule", Description = "Salada leve do Oriente Médio, à base de trigo para quibe (bulgur), ervas frescas, tomate e limão.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                new Dish { DishId = 13, Name = "Panqueca de Banana", Description = "Panquecas fofas de banana, simples e reconfortantes, servidas com manteiga ou mel.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                new Dish { DishId = 14, Name = "Moqueca de Peixe", Description = "Ensopado brasileiro de peixe cozido em leite de coco, tomate, cebola e coentro.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                new Dish { DishId = 15, Name = "Brigadeiro", Description = "Doce brasileiro cremoso à base de leite condensado e chocolate, enrolado em bolinhas cobertas com granulado.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                new Dish { DishId = 16, Name = "Bobó de Camarão", Description = "Ensopado cremoso brasileiro feito com camarão, mandioca e leite de coco, aromatizado com coentro.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                new Dish { DishId = 17, Name = "Quiche Lorraine", Description = "Torta salgada francesa recheada com bacon, queijo e creme, de textura firme e sabor levemente amanteigado.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                new Dish { DishId = 18, Name = "Pão de Alho e Ervas", Description = "Pão crocante coberto por uma mistura aromática de manteiga, alho e ervas, perfeito como acompanhamento para churrascos.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                new Dish { DishId = 19, Name = "Ceviche de Salmão", Description = "Prato refrescante de origem peruana: cubos de salmão marinados em limão com cebola, coentro e pimenta.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                new Dish { DishId = 20, Name = "Pavê de Chocolate", Description = "Sobremesa em camadas com biscoito, creme de chocolate e leite condensado, servida gelada.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                // Lote brasileiro adicional (21-30)
                new Dish { DishId = 21, Name = "Feijoada", Description = "Prato tradicional brasileiro à base de feijão preto, carnes salgadas e acompanhamentos como arroz e farofa.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                new Dish { DishId = 22, Name = "Acarajé", Description = "Bolinho frito de feijão-fradinho recheado com vatapá e camarão, típico da culinária baiana.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                new Dish { DishId = 23, Name = "Vatapá", Description = "Creme rico e aromático à base de pão, camarão, leite de coco, azeite de dendê e amendoim, servido com arroz ou acarajé.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                new Dish { DishId = 24, Name = "Arroz Carreteiro", Description = "Prato rural de arroz com carne seca e linguiça, saboroso e pronto para aproveitar sobras de carne.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                new Dish { DishId = 25, Name = "Baião de Dois", Description = "Clássico nordestino que combina arroz e feijão de corda com queijo coalho e temperos, cremoso e nutritivo.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                new Dish { DishId = 26, Name = "Escondidinho de Carne Seca", Description = "Purê de mandioca cobrindo um recheio suculento de carne seca desfiada, gratinado com queijo.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                new Dish { DishId = 27, Name = "Picanha Assada", Description = "Peça nobre do churrasco brasileiro, temperada e assada até formar crosta dourada e suculenta por dentro.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                new Dish { DishId = 28, Name = "Pastel de Feira", Description = "Salgado frito recheado (carne, queijo ou outros), crocante por fora e muito popular em feiras e lanchonetes.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                new Dish { DishId = 29, Name = "Coxinha", Description = "Salgadinho de massa de farinha recheado com frango desfiado, empanado e frito até ficar dourado.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                new Dish { DishId = 30, Name = "Canjica", Description = "Sobremesa cremosa feita com milho branco, leite de coco, leite condensado e canela, servida gelada ou morna.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                // Receitas do continente asiático (31-40)
                new Dish { DishId = 31, Name = "Pad Thai", Description = "Clássico prato de macarrão tailandês, sabor agridoce com amendoim e limão.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                new Dish { DishId = 32, Name = "Ramen", Description = "Sopa japonesa reconfortante com caldo aromático, noodles e toppings variados.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                new Dish { DishId = 33, Name = "Frango General Tso", Description = "Prato chinês apimentado e agridoce com pedaços de frango empanados e molho caramelizado.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                new Dish { DishId = 34, Name = "Gyoza", Description = "Pastelzinho japonês recheado, levemente dourado e servido com molho shoyu.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                new Dish { DishId = 35, Name = "Bibimbap", Description = "Prato coreano colorido com arroz, legumes, carne e ovo, servido com óleo de gergelim.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                new Dish { DishId = 36, Name = "Curry Verde Tailandês", Description = "Curry aromático com leite de coco, ervas e pimenta, geralmente servido com arroz.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                new Dish { DishId = 37, Name = "Frango Teriyaki", Description = "Peito de frango glaceado em molho teriyaki, levemente adocicado e brilhante.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                new Dish { DishId = 38, Name = "Frango Manteiga (Butter Chicken)", Description = "Receita indiana cremosa com molho à base de tomate, especiarias e manteiga.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                new Dish { DishId = 39, Name = "Mapo Tofu", Description = "Prato picante chinês com tofu macio e carne em molho apimentado e aromático.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                new Dish { DishId = 40, Name = "Bulgogi", Description = "Carne bovina marinada e grelhada no estilo coreano, saborosa e levemente adocicada.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                // Culinária clássica (41-50)
                new Dish { DishId = 41, Name = "Beef Bourguignon", Description = "Ensopado francês de carne cozida lentamente em vinho tinto, com bacon, cebolas e ervas.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                new Dish { DishId = 42, Name = "Tiramisù", Description = "Sobremesa italiana clássica feita com camadas de biscoito embebido em café, creme de mascarpone e cacau.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                new Dish { DishId = 43, Name = "Pasta Puttanesca", Description = "Massa italiana com molho robusto de tomate, azeitonas, alcaparras e alho.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                new Dish { DishId = 44, Name = "Paella Valenciana", Description = "Ícone espanhol de arroz com frutos do mar, açafrão e pimentões, cozido em uma panela larga.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                new Dish { DishId = 45, Name = "Moussaka", Description = "Assado grego em camadas de berinjela, carne temperada e molho cremoso, gratinado com queijo.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                new Dish { DishId = 46, Name = "Gnocchi de Batata", Description = "Nhoques leves feitos com batata e farinha, servidos com manteiga ou molho de sua preferência.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                new Dish { DishId = 47, Name = "Ratatouille", Description = "Guarnição francesa de legumes (berinjela, pimentão, tomate) lentamente cozidos com ervas.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                new Dish { DishId = 48, Name = "Bruschetta al Pomodoro", Description = "Entrada italiana simples: pão tostado com tomate fresco, alho e manjericão.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                new Dish { DishId = 49, Name = "Bouillabaisse", Description = "Sopa de peixe tradicional de Marselha, rica em sabores do mar e temperos como açafrão.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                new Dish { DishId = 50, Name = "Risotto alla Milanese", Description = "Risoto italiano aromatizado com açafrão, cremoso e finalizado com queijo parmesão.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                // Sobremesas (51-60)
                new Dish { DishId = 51, Name = "Tarte Tatin", Description = "Torta invertida de maçã caramelizada, servida quente com crosta amanteigada.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                new Dish { DishId = 52, Name = "Panna Cotta", Description = "Sobremesa italiana cremosa feita com creme de leite, açúcar e gelatina, aromatizada com baunilha.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                new Dish { DishId = 53, Name = "New York Cheesecake", Description = "Cheesecake clássico com base de biscoito e recheio cremoso de cream cheese.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                new Dish { DishId = 54, Name = "Pavlova de Frutas Vermelhas", Description = "Merengue crocante por fora e macio por dentro, servido com chantilly e frutas vermelhas.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                new Dish { DishId = 55, Name = "Apple Pie", Description = "Torta de maçã tradicional com massa amanteigada e recheio levemente caramelizado.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                new Dish { DishId = 56, Name = "Profiteroles com Chocolate", Description = "Bolinh0s de massa choux recheados, servidos com molho quente de chocolate.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                new Dish { DishId = 57, Name = "Chocolate Fondant (Lava Cake)", Description = "Petit gateau com interior cremoso de chocolate derretido; servido quente.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                new Dish { DishId = 58, Name = "Tarte de Limão", Description = "Tarte de limão com recheio cítrico e massa amanteigada, finalizada com merengue ou creme.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                new Dish { DishId = 59, Name = "Gelato de Baunilha", Description = "Sorvete cremoso de baunilha, textura densa e sabor puro de baunilha.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                new Dish { DishId = 60, Name = "Crème Catalane", Description = "Creme espanhol semelhante ao crème brûlée, coberto por uma crosta de açúcar queimado.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },

                // Street Foods do Mundo (61-70)
                new Dish { DishId = 61, Name = "Arepa", Description = "Típica da Venezuela e Colômbia, massa de milho grelhada ou frita, geralmente recheada com queijo ou carnes.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                new Dish { DishId = 62, Name = "Falafel Wrap", Description = "Bolinho frito de grão-de-bico temperado, servido em pão sírio com tahine e salada.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                new Dish { DishId = 63, Name = "Bánh Mì", Description = "Sanduíche vietnamita em baguete crocante, com carne marinada, vegetais em conserva e ervas frescas.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                new Dish { DishId = 64, Name = "Samosa", Description = "Salgado frito típico do Sul da Ásia: massa crocante recheada com batata temperada e ervilhas.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                new Dish { DishId = 65, Name = "Pão de Queijo", Description = "Clássico brasileiro em formato de bolinha, leve e borrachudo, feito com polvilho e queijo.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                new Dish { DishId = 66, Name = "Empanada Argentina", Description = "Pastel assado ou frito recheado com carne temperada, muito popular como comida de rua na Argentina.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                new Dish { DishId = 67, Name = "Shawarma", Description = "Carne temperada fatiada servida em pão sírio com molhos e vegetais - clássico do Oriente Médio.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                new Dish { DishId = 68, Name = "Churros", Description = "Doce frito em massa simples polvilhado com açúcar e canela, frequentemente servido com chocolate.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                new Dish { DishId = 69, Name = "Bao Bun", Description = "Pãozinho chinês cozido no vapor, macio e levemente adocicado, geralmente recheado com carne ou legumes.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                new Dish { DishId = 70, Name = "Pupusa", Description = "Especialidade de El Salvador: tortilla grossa de milho recheada com queijo e feijão, grelhada até dourar.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },

                // Culinária Mediterrânea (71-80)
                new Dish { DishId = 71, Name = "Salada Grega", Description = "Salada fresca e colorida com tomate, pepino, azeitonas e queijo feta, temperada com azeite e orégãos.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                new Dish { DishId = 72, Name = "Shakshuka", Description = "Ensopado de tomates e pimentões com ovos pochê, temperado com alho e especiarias, típico do Mediterrâneo oriental.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                new Dish { DishId = 73, Name = "Berinjela Assada com Tahine", Description = "Berinjela grelhada servida com molho de tahine, alho e limão, ótima como entrada ou acompanhamento.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                new Dish { DishId = 74, Name = "Frango Assado ao Limão e Ervas", Description = "Peito de frango marinado em ervas e limão, assado até ficar dourado e suculento.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                new Dish { DishId = 75, Name = "Mexilhões ao Alho e Vinho Branco", Description = "Mexilhões cozidos em caldo aromático de vinho branco, alho e ervas, servidos com pão.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                new Dish { DishId = 76, Name = "Hummus com Pão Sírio", Description = "Pastinha cremosa de grão-de-bico e tahine servida com pão sírio aquecido e azeite.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                new Dish { DishId = 77, Name = "Tapenade de Azeitonas com Baguete", Description = "Patê rústico de azeitonas e alcaparras, perfeito para barrar em fatias de baguete torradas.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                new Dish { DishId = 78, Name = "Feta Assado com Tomates", Description = "Queijo feta assado com tomates, alho e ervas, servido quente com pão crocante.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                new Dish { DishId = 79, Name = "Batatas Gregas ao Limão e Ervas", Description = "Batatas assadas com limão, alho e ervas aromáticas, crocantes por fora e macias por dentro.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                new Dish { DishId = 80, Name = "Pimentões Recheados com Bulgur", Description = "Pimentões assados recheados com bulgur temperado, tomate, ervas e queijo feta.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },

                // Culinária Africana (81-90)
                new Dish { DishId = 81, Name = "Jollof Rice", Description = "Arroz aromático rico em tomate e especiarias, clássico de vários países da África Ocidental, normalmente servido com carne ou frango.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                new Dish { DishId = 82, Name = "Bobotie", Description = "Prato sul-africano assado com carne temperada, camada de ovos e leite formando uma textura cremosa por cima, levemente adocicado com especiarias.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                new Dish { DishId = 83, Name = "Suya", Description = "Espetinhos de carne secos e bem temperados com mistura de amendoim e especiarias, grelhados até ficarem crocantes nas bordas.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                new Dish { DishId = 84, Name = "Tagine de Carne", Description = "Ensopado marroquino de carne e especiarias, cozido lentamente com legumes até o molho ficar concentrado e aromático.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                new Dish { DishId = 85, Name = "Poulet Yassa", Description = "Prato senegalês de frango marinado em cebola e limão, lentamente cozido até ficar suculento e com sabor ácido e levemente caramelizado.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                new Dish { DishId = 86, Name = "Piri-Piri Camarão", Description = "Camarões temperados com piri-piri e alho, grelhados rapidamente e servidos com molho picante e limão.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                new Dish { DishId = 87, Name = "Mandazi", Description = "Fritos doces do Leste Africano, semelhantes a donuts leves e aromáticos, perfeitos como lanche ou sobremesa.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                new Dish { DishId = 88, Name = "Pap (Ugali)", Description = "Papa de farinha de milho (ou fubá) tradicional, acompanhamento simples e reconfortante consumido em várias regiões da África.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                new Dish { DishId = 89, Name = "Koshari", Description = "Mistura egípcia de arroz, macarrão e grão-de-bico, servida com molho de tomate picante e cebola crocante por cima.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                new Dish { DishId = 90, Name = "Bunny Chow", Description = "Pão oco recheado com curry rico e picante — um clássico de Durban com raízes indianas e africanas.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },

                // Cozinhas variadas / inéditas (91-100)
                new Dish { DishId = 91, Name = "Fish and Chips", Description = "Clássico britânico: filé de peixe empanado e frito servido com batatas fritas crocantes e vinagre para acompanhar.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                new Dish { DishId = 92, Name = "Doro Wat", Description = "Ensopado etíope de frango com berbere e cebolas caramelizadas, servido tradicionalmente com injera.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                new Dish { DishId = 93, Name = "Jerk Chicken", Description = "Frango jamaicano marinado em especiarias e pimenta, grelhado até ficar defumado e aromático.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                new Dish { DishId = 94, Name = "Khachapuri", Description = "Especialidade georgiana: pão recheado generosamente com queijo derretido e ovo no centro.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                new Dish { DishId = 95, Name = "Adobo (Filipinas)", Description = "Carne marinada em vinagre e molho de soja, cozida até ficar macia e rica em sabor; prato essencial filipino.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                new Dish { DishId = 96, Name = "Fesenjan", Description = "Ensopado persa rico com nozes e molho de romã, complexo e aveludado, tradicionalmente servido com arroz.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                new Dish { DishId = 97, Name = "Pierogi", Description = "Bolinho polonês recheado (batata e queijo ou outras variações), cozido e por vezes dourado na manteiga; reconfortante e versátil.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                new Dish { DishId = 98, Name = "Poke Bowl", Description = "Tigela havaiana com peixe cru marinado, arroz, algas e acompanhamentos frescos; leve e customizável.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                new Dish { DishId = 99, Name = "Pastel de Nata", Description = "Doce português: creme de ovos sobre massa folhada crocante, polvilhado levemente com canela e servido quente.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                new Dish { DishId = 100, Name = "Fufu com Ensopado de Amendoim", Description = "Papa de mandioca servida com um ensopado rico de amendoim e carne, muito comum em várias cozinhas da África Ocidental.", Photo = "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" }
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
                new Recipe { RecipeId = 10, DishId = 10, Instructions = "Derreta o chocolate meio amargo em banho-maria ou no micro-ondas. Em outra tigela, bata o creme de leite fresco (ou as claras em neve com açúcar) até formar picos firmes. Incorpore delicadamente o chocolate derretido e já morno à mistura, com movimentos de baixo para cima para não perder a aeração. Despeje em taças individuais e leve à geladeira por pelo menos 4 horas antes de servir." },
                new Recipe { RecipeId = 11, DishId = 11, Instructions = "Aqueça o forno a 150°C. Misture gemas com açúcar até ficar cremoso e acrescente o creme de leite e a baunilha; coe. Distribua em ramequins e asse em banho-maria por cerca de 35-40 minutos, até firmar nas bordas e ficar levemente tremido no centro. Resfrie, leve à geladeira por algumas horas e, na hora de servir, polvilhe açúcar por cima e queime com maçarico até formar uma crosta dourada." },
                new Recipe { RecipeId = 12, DishId = 12, Instructions = "Hidrate o bulgur em água por alguns minutos e escorra bem. Pique tomate, cebola, salsinha e hortelã em pedaços pequenos. Misture tudo em uma tigela, tempere com suco de limão, azeite, sal e pimenta. Ajuste acidez e sirva bem frio como acompanhamento ou entrada." },
                new Recipe { RecipeId = 13, DishId = 13, Instructions = "Amasse as bananas e misture com ovo, leite, farinha e açúcar até formar uma massa homogênea. Aqueça uma frigideira com manteiga, coloque porções da massa e frite até dourar dos dois lados. Sirva quente com fatias de banana ou mel." },
                new Recipe { RecipeId = 14, DishId = 14, Instructions = "Tempere o peixe com sal e limão. Em uma panela, refogue cebola e pimentão no azeite, acrescente tomates picados e deixe apurar. Junte o peixe, o leite de coco e cozinhe em fogo baixo até o peixe ficar macio. Finalize com coentro fresco picado e sirva com arroz branco." },
                new Recipe { RecipeId = 15, DishId = 15, Instructions = "Em uma panela, misture o leite condensado, o chocolate picado e a manteiga. Cozinhe em fogo médio, mexendo sempre, até desgrudar do fundo (ponto de brigadeiro). Deixe esfriar, enrole em bolinhas e passe no granulado, ou sirva em copinhos como brigadeiro de colher." },
                new Recipe { RecipeId = 16, DishId = 16, Instructions = "Cozinhe a mandioca até ficar macia e reserve. Refogue cebola e alho no azeite, acrescente o camarão e cozinhe rapidamente. Bata a mandioca com parte do caldo no liquidificador até obter um creme e volte à panela. Junte o leite de coco, o camarão refogado e ajuste o sal. Finalize com coentro picado e sirva quente." },
                new Recipe { RecipeId = 17, DishId = 17, Instructions = "Forre uma forma com massa folhada, bata ovos com creme de leite, adicione bacon frito e queijo ralado, tempere com sal e pimenta. Despeje o recheio sobre a massa e asse em forno pré-aquecido a 180°C por cerca de 30-40 minutos, até firmar e dourar levemente." },
                new Recipe { RecipeId = 18, DishId = 18, Instructions = "Misture manteiga amolecida com alho picado, salsinha, sal e pimenta até formar uma pasta. Corte o pão em fatias ou abra um pão grande, espalhe a mistura entre as fatias e por cima. Leve ao forno para gratinar até ficar dourado e crocante." },
                new Recipe { RecipeId = 19, DishId = 19, Instructions = "Corte o salmão em cubos pequenos e coloque em uma tigela. Adicione suco de limão suficiente para cobrir o peixe, junte cebola roxa fatiada, pimenta picada e coentro. Deixe marinar por 10-20 minutos até o peixe firmar. Sirva gelado com fatias de limão." },
                new Recipe { RecipeId = 20, DishId = 20, Instructions = "Intercale camadas de biscoito embebido no leite com camadas de creme feito com chocolate derretido e leite condensado. Repita as camadas, finalize com raspas de chocolate e leve à geladeira por pelo menos 4 horas antes de servir." },
                // Receitas brasileiras (21-30)
                new Recipe { RecipeId = 21, DishId = 21, Instructions = "Deixe o feijão preto de molho e cozinhe até ficar macio. Cozinhe separadamente as carnes salgadas e linguiça; junte ao feijão e cozinhe lentamente até apurar. Sirva com arroz branco, couve refogada e farofa de farinha de mandioca." },
                new Recipe { RecipeId = 22, DishId = 22, Instructions = "Prepare uma massa com feijão-fradinho cozido e amassado; modele bolinhos e frite em óleo quente. Recheie com vatapá e camarão refogado; sirva quente com pimenta e salada." },
                new Recipe { RecipeId = 23, DishId = 23, Instructions = "Refogue cebola e alho, junte pão amanhecido, amendoim e camarão seco. Bata com leite de coco e azeite de dendê até formar um creme. Ajuste sal e pimenta e sirva com arroz branco ou como recheio de acarajé." },
                new Recipe { RecipeId = 24, DishId = 24, Instructions = "Corte a carne seca em cubos e refogue com linguiça e cebola. Acrescente arroz lavado e água quente, cozinhe até o arroz absorver o caldo. Ajuste temperos e finalize com cheiro-verde." },
                new Recipe { RecipeId = 25, DishId = 25, Instructions = "Cozinhe o feijão de corda separadamente até ficar macio. Refogue cebola e alho, junte arroz e o feijão, adicione pedaços de queijo coalho e manteiga e mexa até ficar cremoso. Sirva quente como prato principal." },
                new Recipe { RecipeId = 26, DishId = 26, Instructions = "Cozinhe a mandioca e bata em purê. Refogue a carne seca desfiada com cebola e temperos. Monte em camadas: purê por cima da carne, salpique queijo coalho e leve ao forno para gratinar até dourar." },
                new Recipe { RecipeId = 27, DishId = 27, Instructions = "Tempere a picanha com sal grosso e deixe descansar. Asse em churrasqueira ou forno em temperatura alta, virando para formar uma crosta dourada. Fatie e sirva suculenta, acompanhe com farofa e vinagrete." },
                new Recipe { RecipeId = 28, DishId = 28, Instructions = "Prepare uma massa leve com farinha e água; abra, recheie com carne moída refogada ou queijo e feche. Frite em óleo abundante até dourar e escorra em papel absorvente. Sirva quente." },
                new Recipe { RecipeId = 29, DishId = 29, Instructions = "Cozinhe e desfie o peito de frango, refogue com cebola e temperos. Faça uma massa com farinha e caldo, molde em forma de coxinha, recheie com frango, empane na farinha de rosca e frite até dourar." },
                new Recipe { RecipeId = 30, DishId = 30, Instructions = "Cozinhe o milho para canjica até ficar macio. Misture com leite de coco, leite condensado, açúcar e canela. Cozinhe em fogo baixo até engrossar; sirva quente ou gelado, polvilhado com canela." }
                // Receitas asiáticas (31-40)
                , new Recipe { RecipeId = 31, DishId = 31, Instructions = "Cozinhe os noodles conforme instruções. Em wok, refogue gengibre e alho, acrescente tofu e camarão até cozinhar. Misture os noodles com molho de soja e amendoim picado. Finalize com suco de limão e cebolinha antes de servir." },
                new Recipe { RecipeId = 32, DishId = 32, Instructions = "Prepare um caldo aromático com caldo de legumes e molho de soja. Cozinhe noodles no caldo, adicione shiitake fatiado e finalize com ovo cozido e cebolinha fatiada. Sirva quente." },
                new Recipe { RecipeId = 33, DishId = 33, Instructions = "Tempere pedaços de frango, empane levemente e frite até dourar. Em uma panela, faça um molho com gengibre, alho, molho de soja e açúcar; reduza até engrossar e junte o frango frito para caramelizar. Sirva quente." },
                new Recipe { RecipeId = 34, DishId = 34, Instructions = "Misture carne moída com cebolinha, gengibre e alho. Recheie pequenas folhas de massa (ou massa folhada fina), feche formando pastéis e doure em frigideira ou frite. Sirva com molho de soja." },
                new Recipe { RecipeId = 35, DishId = 35, Instructions = "Grelhe fatias finas de carne temperada. Em uma tigela, coloque arroz quente, legumes salteados, fatias de carne e ovo frito por cima. Tempere com óleo de gergelim e molho de soja antes de misturar e comer." },
                new Recipe { RecipeId = 36, DishId = 36, Instructions = "Refogue pasta de curry com um pouco de óleo, acrescente pedaços de frango e pimentão. Despeje leite de coco e deixe cozinhar em fogo baixo até o frango ficar macio e o molho incorporar. Sirva com arroz." },
                new Recipe { RecipeId = 37, DishId = 37, Instructions = "Marine o frango em molho de soja, mirin, gengibre e açúcar. Grelhe ou frite até caramelizar e pincele com o restante da marinada reduzida. Sirva com cebolinha por cima." },
                new Recipe { RecipeId = 38, DishId = 38, Instructions = "Refogue alho e gengibre na manteiga, junte pedaços de frango e tomates. Adicione creme de leite e curry em pó, cozinhe até obter um molho cremoso e sirva com arroz basmati ou pão." },
                new Recipe { RecipeId = 39, DishId = 39, Instructions = "Refogue carne moída com alho e gengibre, acrescente tofu em cubos e molho de soja. Cozinhe até o tofu absorver sabores; finalize com óleo de gergelim e cebolinha picada." },
                new Recipe { RecipeId = 40, DishId = 40, Instructions = "Marine a carne em molho de soja, açúcar, gengibre e óleo de gergelim por pelo menos 30 minutos. Grelhe em fogo alto rapidamente para selar e sirva fatiada, com cebolinha por cima." },

                // Culinária clássica (41-50)
                new Recipe { RecipeId = 41, DishId = 41, Instructions = "Corte a carne em cubos grandes e doure com bacon. Adicione cebola, refogue, polvilhe um pouco de farinha, junte vinho tinto e caldo, tempere com tomilho e cozinhe lentamente até a carne ficar macia. Sirva com batatas." },
                new Recipe { RecipeId = 42, DishId = 42, Instructions = "Bata as gemas com açúcar até ficarem claras e cremosas, misture o mascarpone. Umedeça levemente os biscoitos no café e monte camadas intercalando com o creme. Polvilhe cacau e refrigere por algumas horas antes de servir." },
                new Recipe { RecipeId = 43, DishId = 43, Instructions = "Cozinhe a massa até ficar al dente. Em uma frigideira, refogue alho no azeite, acrescente molho de tomate, azeitonas e alcaparras; misture com a massa e sirva imediatamente." },
                new Recipe { RecipeId = 44, DishId = 44, Instructions = "Refogue cebola e pimentão, adicione arroz e açafrão, regue com vinho branco e caldo. Cozinhe sem mexer demais e adicione frutos do mar, como mexilhões, nos minutos finais até tudo cozinhar por igual." },
                new Recipe { RecipeId = 45, DishId = 45, Instructions = "Grelhe fatias de berinjela até dourar. Faça um ragu com carne moída, cebola e tomate. Monte camadas de berinjela e ragu, cubra com molho branco e leve ao forno até gratinar." },
                new Recipe { RecipeId = 46, DishId = 46, Instructions = "Cozinhe as batatas até ficarem macias, amasse bem e misture com farinha e ovo até formar uma massa. Modele os nhoques e cozinhe em água fervente até subirem. Sirva com manteiga e parmesão ralado." },
                new Recipe { RecipeId = 47, DishId = 47, Instructions = "Corte berinjela, pimentão, tomate e cebola em pedaços uniformes. Refogue separadamente e depois junte tudo com ervas (tomilho, alecrim) e azeite. Cozinhe até os legumes ficarem macios e bem temperados." },
                new Recipe { RecipeId = 48, DishId = 48, Instructions = "Toste fatias de pão até ficarem crocantes. Esfregue um dente de alho, cubra com tomate picado, folhas de manjericão e regue com azeite de oliva; sirva imediatamente." },
                new Recipe { RecipeId = 49, DishId = 49, Instructions = "Refogue cebola e alho, junte tomate e vinho branco, acrescente uma variedade de peixes e mexilhões. Cozinhe até os frutos do mar estarem cozidos e sirva com fatias de pão." },
                new Recipe { RecipeId = 50, DishId = 50, Instructions = "Refogue cebola na manteiga, acrescente o arroz arbóreo e uma taça de vinho branco. Aos poucos, adicione caldo com açafrão, mexendo sempre até o arroz ficar cremoso. Finalize com manteiga e parmesão ralado." },

                // Sobremesas (51-60)
                new Recipe { RecipeId = 51, DishId = 51, Instructions = "Descasque e corte maçãs em quartos. Caramelize açúcar e manteiga na frigideira, disponha as maçãs e cozinhe até amaciar. Cubra com massa e asse até dourar; desenforme morno para servir." },
                new Recipe { RecipeId = 52, DishId = 52, Instructions = "Aqueça creme de leite com açúcar e baunilha. Hidrate gelatina, dissolva no creme quente, distribua em formas e refrigere até firmar. Sirva com calda de frutas se desejar." },
                new Recipe { RecipeId = 53, DishId = 53, Instructions = "Triture biscoitos e misture com manteiga derretida para a base; pressione na forma. Misture cream cheese com açúcar, ovos e baunilha, despeje sobre a base e asse até firmar. Resfrie antes de desenformar." },
                new Recipe { RecipeId = 54, DishId = 54, Instructions = "Bata claras em neve com açúcar até formar suspiro firme. Asse merengues em baixa temperatura até secar. Monte com chantilly e frutas vermelhas por cima antes de servir." },
                new Recipe { RecipeId = 55, DishId = 55, Instructions = "Corte maçãs em fatias e misture com açúcar e canela. Forre forma com massa, recheie com as maçãs e cubra. Asse até a massa dourar e o recheio borbulhar." },
                new Recipe { RecipeId = 56, DishId = 56, Instructions = "Prepare massa choux com farinha, ovos e manteiga; forme pequenas porções e asse até inflar. Recheie com creme e regue com molho quente de chocolate feito com chocolate e creme de leite." },
                new Recipe { RecipeId = 57, DishId = 57, Instructions = "Derreta chocolate com manteiga. Misture ovos, açúcar e um pouco de farinha; incorpore o chocolate derretido. Asse em forminhas individuais pouco tempo para obter o interior cremoso." },
                new Recipe { RecipeId = 58, DishId = 58, Instructions = "Prepare massa quebrada e asse parcialmente. Faça um creme de limão com suco e raspas, ovos e açúcar; asse sobre a massa até firmar. Resfrie e sirva gelado ou com merengue." },
                new Recipe { RecipeId = 59, DishId = 59, Instructions = "Aqueça leite, creme e baunilha até quase ferver, mexendo para dissolver o açúcar; resfrie a mistura rapidamente antes de levar à sorveteira. Bata na sorveteira até obter textura cremosa e transfira para o congelador por algumas horas para firmar. Sirva em bolas suaves, puro ou acompanhado de caldas e frutas frescas para contraste." },
                new Recipe { RecipeId = 60, DishId = 60, Instructions = "Aqueça leite com canela e casca de limão para infundir aroma; bata gemas com açúcar até clarear e, aos poucos, incorpore o leite quente, mexendo sem parar. Cozinhe em banho-maria até o creme cobrir as costas da colher e resfrie completamente. Na hora de servir, polvilhe uma camada fina de açúcar e queime para formar a crosta caramelizada característica." },

                // Street Foods do Mundo (61-70)
                new Recipe { RecipeId = 61, DishId = 61, Instructions = "Misture farinha de milho com água e sal até formar uma massa maleável; modele discos e cozinhe em chapa ou frigideira até dourarem levemente dos dois lados. Corte as arepas ao meio e recheie com cream cheese ou outro queijo, e, se desejar, peças de carne grelhada. Sirva quentes, aproveitando a textura levemente crocante por fora e macia por dentro." },
                new Recipe { RecipeId = 62, DishId = 62, Instructions = "Deixe o grão-de-bico de molho por algumas horas e cozinhe até ficar macio, ou use grão-de-bico enlatado bem escorrido; processe com alho, cebola, cominho e sal até formar uma massa maleável. Modele bolinhos e frite até ficarem dourados e crocantes por fora. Aqueça pão sírio, recheie com os falafels, adicione tahine, folhas de alface e fatias de tomate; sirva imediatamente para manter contraste de texturas." },
                new Recipe { RecipeId = 63, DishId = 63, Instructions = "Marine tiras de carne em um molho aromático por pelo menos 30 minutos. Grelhe rapidamente até dourarem e monte a baguete crocante com a carne, cebola levemente em conserva (ou crua), coentro fresco e um fio de azeite. Sirva cortado ao meio para preservar crocância do pão e suculência do recheio." },
                new Recipe { RecipeId = 64, DishId = 64, Instructions = "Cozinhe batatas até ficarem macias e amasse; misture com ervilhas cozidas, cebola refogada, especiarias (como cominho e curry em pó) e ajuste sal. Abra porções da massa de farinha, recheie com a mistura e feche formando triângulos; frite em óleo quente até dourar ou asse para versão mais leve. Sirva quente, acompanhando com chutney ou molho picante." },
                new Recipe { RecipeId = 65, DishId = 65, Instructions = "Misture polvilho doce com leite, ovos e queijo coalho ralado até obter uma massa pegajosa; modele pequenas bolinhas e asse ou frite até crescerem e formarem casca leve. Sirva quentes, aproveitando o interior elástico e o sabor salgado do queijo; são ótimas como lanche ou acompanhamento." },
                new Recipe { RecipeId = 66, DishId = 66, Instructions = "Refogue cebola e alho até ficarem translúcidos; acrescente carne moída e cozinhe até dourar, temperando com páprica, sal e pimenta. Recheie discos de massa folhada com a carne refogada, feche bem e asse até dourarem. Sirva quentes, como lanche prático e saboroso de rua." },
                new Recipe { RecipeId = 67, DishId = 67, Instructions = "Tempere a carne em tiras com especiarias e deixe marinar brevemente; grelhe em fogo alto até selar e ficar suculenta. Aqueça o pão sírio e recheie com a carne fatiada, cebola, tahine e folhas frescas, enrolando ou dobrando para servir. A combinação de carne bem temperada e molho cremoso cria o clássico sabor do shawarma." },
                new Recipe { RecipeId = 68, DishId = 68, Instructions = "Prepare uma massa simples com farinha, água, ovo e manteiga; cozinhe rapidamente em panela até formar uma pasta e molde tiras compridas. Frite em óleo quente até dourar e escorra em papel; passe no açúcar misturado com canela enquanto ainda estiverem quentes. Sirva com molho de chocolate quente para mergulhar." },
                new Recipe { RecipeId = 69, DishId = 69, Instructions = "Misture farinha com leite, ovo e um pouco de fermento (se disponível) até formar uma massa macia; modele bolinhos ou discos e cozinhe no vapor até crescerem e ficarem macios. Corte ao meio e recheie com carne grelhada, vegetais em conserva e molhos à escolha; sirva quente para aproveitar a textura aerada do bao." },
                new Recipe { RecipeId = 70, DishId = 70, Instructions = "Misture farinha de milho com água e sal até obter massa maleável; abra discos e recheie com uma mistura de feijão refrito e queijo coalho ralado, fechando e moldando. Grelhe os pupusas em chapa até dourar ambos os lados e o recheio aquecer; sirva quente com curtido e molho de tomate ou pimenta para equilibrar os sabores." },

                // Receitas Mediterrâneas (71-80)
                new Recipe { RecipeId = 71, DishId = 71, Instructions = "Corte tomates e pepino em cubos regulares; fatie a cebola finamente. Em uma tigela grande, misture os tomates, pepino, cebola, azeitonas e pedaços generosos de queijo feta. Tempere com suco de limão fresco, bastante azeite de oliva, orégãos secos, sal e pimenta. Misture delicadamente, ajuste os temperos e sirva imediatamente para manter a textura crocante dos vegetais." },
                new Recipe { RecipeId = 72, DishId = 72, Instructions = "Aqueça azeite em uma frigideira larga e refogue cebola e alho até ficarem translúcidos. Adicione pimentões picados e deixe murchar; junte tomates (frescos ou molho de tomate), tempere com sal, pimenta e pimenta dedo-de-moça a gosto e cozinhe em fogo médio até formar um molho espesso. Faça pequenos poços no molho e quebre ovos por cima; tampe e cozinhe até as claras firmarem e as gemas ficarem ao ponto desejado. Polvilhe salsinha por cima e sirva com pão." },
                new Recipe { RecipeId = 73, DishId = 73, Instructions = "Corte berinjelas ao meio, faça cortes superficiais na polpa, pincele com azeite e grelhe até ficarem macias e com marcas de grelha. Enquanto isso, misture tahine com suco de limão, um pouco de água para ajustar a textura, alho picado e sal. Regue as berinjelas grelhadas com o molho de tahine, finalize com salsinha picada, um fio de azeite e pimenta moída. Sirva morno ou à temperatura ambiente." },
                new Recipe { RecipeId = 74, DishId = 74, Instructions = "Tempere os peitos de frango com suco de limão, alho picado, azeite, ramos de alecrim e tomilho, sal e pimenta; deixe marinar por ao menos 30 minutos. Pré-aqueça o forno e asse o frango até dourar e atingir temperatura interna adequada, regando ocasionalmente com a marinada. Deixe repousar alguns minutos antes de fatiar; sirva com batatas ou salada e regue com o molho formado durante o cozimento." },
                new Recipe { RecipeId = 75, DishId = 75, Instructions = "Lave bem os mexilhões e descarte os que estiverem abertos. Em uma panela larga, aqueça azeite e refogue alho e cebola até ficarem translúcidos; acrescente tomates picados e vinho branco, deixe reduzir levemente. Junte os mexilhões, tampe e cozinhe até abrirem (descartar os que não abrirem). Finalize com salsinha picada e sirva com fatias de pão para molhar no caldo aromático." },
                new Recipe { RecipeId = 76, DishId = 76, Instructions = "Escorra e cozinhe grão-de-bico até ficar macio (ou use enlatado bem escorrido). Processe o grão-de-bico com tahine, suco de limão, alho, sal e um fio generoso de azeite até obter uma pasta lisa; ajuste a textura com água se necessário. Sirva o hummus regado com azeite extra e acompanhe com pão sírio aquecido e fatias de pepino para frescor." },
                new Recipe { RecipeId = 77, DishId = 77, Instructions = "No processador, junte azeitonas sem caroço, alcaparras, alho, salsinha e um fio de azeite; pulse até obter uma pasta rústica. Ajuste sal e acidez se necessário. Fatie a baguete, torre levemente e espalhe a tapenade sobre as fatias antes de servir como aperitivo." },
                new Recipe { RecipeId = 78, DishId = 78, Instructions = "Coloque um bloco de queijo feta em uma travessa pequena, disponha tomates cortados ao redor e regue tudo com azeite, alho fatiado e orégãos. Leve ao forno pré-aquecido até os tomates murcharem levemente e o feta aquecer; sirva quente com fatias de baguette para acompanhar e molhar no suco formado." },
                new Recipe { RecipeId = 79, DishId = 79, Instructions = "Corte batatas em pedaços médios e tempere com suco de limão, azeite, alho picado, orégãos secos, alecrim, sal e pimenta. Asse em forno quente até ficarem douradas e crocantes por fora, macias por dentro. Sirva imediatamente, finalizando com mais ervas frescas se desejar." },
                new Recipe { RecipeId = 80, DishId = 80, Instructions = "Cozinhe bulgur conforme instruções até ficar macio; misture com tomate picado, cebola refogada, salsinha, azeite e pedaços de queijo feta. Recheie pimentões limpos com essa mistura, disponha em um refratário, regue com um fio de azeite e asse até os pimentões ficarem macios e o recheio aquecer. Sirva quente como prato principal leve." },

                // Receitas Africanas (81-90)
                new Recipe { RecipeId = 81, DishId = 81, Instructions = "Refogue cebola e alho em azeite até amaciarem; adicione tomates picados, pasta de tomate e especiarias, deixando o molho apurar. Junte arroz lavado e caldo quente, misture bem e acrescente pedaços de frango previamente dourados. Cozinhe em fogo médio-baixo, mexendo ocasionalmente, até o arroz absorver os sabores e ficar macio. Ajuste sal e pimenta e sirva com folhas frescas e fatias de limão ao lado." },
                new Recipe { RecipeId = 82, DishId = 82, Instructions = "Misture carne moída com cebola picada, alho, curry em pó, pimenta e um pouco de açúcar; coloque em uma travessa untada. Por cima, bata ovos com leite e despeje sobre a carne. Asse em forno médio até a cobertura firmar e dourar levemente. Sirva morno, tradicionalmente acompanhado de arroz e chutney de frutas quando disponível." },
                new Recipe { RecipeId = 83, DishId = 83, Instructions = "Corte a carne em tiras finas e tempere com uma mistura de amendoim moído, alho, pimenta e sal; deixe absorver os temperos por pelo menos 30 minutos. Espete as tiras em palitos e grelhe em fogo alto até desenvolver crostas douradas. Sirva com fatias de cebola e rodelas de pepino para refrescar entre as mordidas." },
                new Recipe { RecipeId = 84, DishId = 84, Instructions = "Sele a carne em panela ampla, retire e refogue cebola, alho e pimentões até amaciarem. Acrescente tomates, caldo e especiarias (açafrão, cominho), devolva a carne e cozinhe em fogo baixo até ficar macia e o molho reduzir. Finalize com ervas frescas e sirva com cuscuz ou pão para aproveitar o molho." },
                new Recipe { RecipeId = 85, DishId = 85, Instructions = "Marine pedaços de frango com suco de limão, alho, pimenta e sal por algumas horas. Refogue uma grande quantidade de cebola até caramelizar levemente, acrescente o frango e cozinhe lentamente no líquido da marinada até ficar suculento e com sabor equilibrado entre ácido e caramelizado. Sirva com arroz ou cuscuz." },
                new Recipe { RecipeId = 86, DishId = 86, Instructions = "Tempere camarões limpos com pimenta, alho picado e suco de limão; deixe marinar brevemente. Aqueça azeite em frigideira, frite os camarões rapidamente até ficarem opacos e ligeiramente dourados, regando com a marinada reduzida. Sirva com mais limão e pão para molhar no molho picante." },
                new Recipe { RecipeId = 87, DishId = 87, Instructions = "Misture farinha, açúcar, ovo, leite de coco e uma pitada de fermento (se disponível) formando uma massa levemente pegajosa. Modele em porções e frite em óleo quente até dourarem por fora e cozinharem por dentro. Polvilhe açúcar e sirva quentes, acompanhados de chá ou café." },
                new Recipe { RecipeId = 88, DishId = 88, Instructions = "Misture farinha de milho com água quente e sal, mexendo até obter uma papa espessa e lisa; cozinhe por alguns minutos, mexendo, até o ponto desejado. Sirva quente com um fio de manteiga ou acompanhando um ensopado rico para absorver o molho." },
                new Recipe { RecipeId = 89, DishId = 89, Instructions = "Cozinhe arroz até ficar macio e reserve. Cozinhe grão-de-bico até amaciar. Cozinhe macarrão curto separadamente. Prepare um molho de tomate bem temperado com alho e cebola e ajuste o picante. Monte camadas com arroz, macarrão e grão-de-bico, regando com o molho de tomate e finalizando com cebolas crocantes. Sirva quente, permitindo que cada porção receba molho generoso." },
                new Recipe { RecipeId = 90, DishId = 90, Instructions = "Corte uma baguete e retire parte do miolo formando uma cavidade; prepare um curry espesso com carne refogada, tomate e especiarias até reduzir bem. Recheie o pão com o curry quente e sirva imediatamente, acompanhando com arroz ou salada se desejar." },

                // Novas receitas (91-100) - variadas
                new Recipe { RecipeId = 91, DishId = 91, Instructions = "Prepare uma massa leve de cerveja ou tempêra (farinha, água/gás, ovo) e tempere o filé de peixe. Corte batatas em palitos regulares e seque bem. Frite as batatas até dourar e reserve. Passe o peixe na massa e frite em óleo quente até a crosta ficar dourada. Sirva o peixe com as batatas, polvilhe sal e ofereça vinagre à parte; sirva quente para manter a crocância." },
                new Recipe { RecipeId = 92, DishId = 92, Instructions = "Pique e cozinhe uma grande quantidade de cebolas em fogo baixo até caramelizarem; junte manteiga clarificada e alho. Adicione pedaços de frango e a mistura de berbere, mexendo para cobrir bem; acrescente caldo e cozinhe lentamente até o frango ficar macio e o molho espesso. Cozinhe ovos até o ponto desejado e sirva por cima, decorando com um fio de azeite e fatias de pão injera se quiser uma apresentação tradicional." },
                new Recipe { RecipeId = 93, DishId = 93, Instructions = "Marine pedaços de frango com uma mistura de allspice, pimenta, alho, cebola, suco de limão e óleo; deixe marinar por algumas horas. Grelhe em fogo médio-alto até o exterior ficar levemente carbonizado e o interior cozido. Regue com suco de limão extra ao servir e acompanhe com arroz, salada e molhos à base de iogurte para equilibrar o picante." },
                new Recipe { RecipeId = 94, DishId = 94, Instructions = "Prepare uma massa de pão relativamente macia com farinha, água, leite e fermento; abra em disco e recheie generosamente com queijo sulguni ralado. Dobre as bordas formando um barco e asse em forno quente até o queijo borbulhar; no final, quebre um ovo no centro e asse rapidamente até a clara firmar. Sirva quente e corte em fatias para compartilhar." },
                new Recipe { RecipeId = 95, DishId = 95, Instructions = "Marine pedaços de carne ou frango em uma mistura de molho de soja, vinagre e alho por pelo menos 30 minutos. Refogue alho e cebola, junte a carne com a marinada e cozinhe em fogo baixo até o líquido reduzir e os sabores ficarem concentrados. Sirva com arroz e um pouco de cebolinha picada por cima para frescor." },
                new Recipe { RecipeId = 96, DishId = 96, Instructions = "Doure cebola e alho em azeite, acrescente nozes trituradas e deixe tostar levemente; junte pedaços de frango e cubra com caldo. Adicione molho de romã e cozinhe em fogo baixo até o molho engrossar e as nozes estiverem integradas, formando uma textura aveludada. Ajuste sal e acidez e sirva com arroz basmati solto." },
                new Recipe { RecipeId = 97, DishId = 97, Instructions = "Cozinhe batatas e amasse até ficarem lisas; misture com queijo (ou cream cheese), tempere e use como recheio. Prepare uma massa com farinha, ovo e água, abra, corte discos e recheie com uma porção do recheio; feche bem e cozinhe em água fervente até subirem. Opcional: doure na manteiga antes de servir para textura adicional." },
                new Recipe { RecipeId = 98, DishId = 98, Instructions = "Tempere cubos de peixe cru com molho de soja, óleo de gergelim, suco de limão e sementes de gergelim; deixe marinar por alguns minutos. Monte tigelas com arroz de sushi, coloque o peixe marinado por cima e adicione complementos como pepino fatiado, algas, abacate e cebolinha. Finalize com sementes de gergelim e um fio de molho adicional se desejar." },
                new Recipe { RecipeId = 99, DishId = 99, Instructions = "Pré-aqueça o forno. Forre forminhas com massa folhada e reserve. Em uma panela, aqueça leite com baunilha; bata gemas com açúcar até clarear e incorpore o leite quente aos poucos. Coe e despeje o creme nas forminhas forradas. Asse em forno quente até o topo caramelizar levemente; deixe esfriar antes de desenformar e polvilhe canela a gosto." },
                new Recipe { RecipeId = 100, DishId = 100, Instructions = "Cozinhe mandioca (ou farinha de mandioca/cuscuz) até formar uma papa firme e maleável (fufu). Para o ensopado, refogue cebola e alho, acrescente carne e cozinhe; junte pasta de amendoim e caldo, cozinhe até o molho ficar espesso e bem temperado. Sirva porções do fufu com o guisado de amendoim por cima, permitindo que cada pessoa molde o fufu e pegue o molho com a mão." }
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
                new RecipeIngredient { RecipeId = 10, IngredientId = 8, Quantity = 2, MeasurementUnit = "unidade(s)" },
                // Creme Brûlée (11)
                new RecipeIngredient { RecipeId = 11, IngredientId = 8, Quantity = 4, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 11, IngredientId = 38, Quantity = 500, MeasurementUnit = "ml" },
                new RecipeIngredient { RecipeId = 11, IngredientId = 39, Quantity = 100, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 11, IngredientId = 40, Quantity = 1, MeasurementUnit = "colher(es) de chá" },

                // Tabule (12)
                new RecipeIngredient { RecipeId = 12, IngredientId = 41, Quantity = 200, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 12, IngredientId = 18, Quantity = 2, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 12, IngredientId = 42, Quantity = 1, MeasurementUnit = "punhado(s)" },
                new RecipeIngredient { RecipeId = 12, IngredientId = 43, Quantity = 1, MeasurementUnit = "punhado(s)" },
                new RecipeIngredient { RecipeId = 12, IngredientId = 33, Quantity = 1, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 12, IngredientId = 5, Quantity = 2, MeasurementUnit = "colher(es) de sopa" },
                new RecipeIngredient { RecipeId = 12, IngredientId = 24, Quantity = 0.25, MeasurementUnit = "unidade(s)" },

                // Panqueca de Banana (13)
                new RecipeIngredient { RecipeId = 13, IngredientId = 44, Quantity = 200, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 13, IngredientId = 45, Quantity = 250, MeasurementUnit = "ml" },
                new RecipeIngredient { RecipeId = 13, IngredientId = 46, Quantity = 2, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 13, IngredientId = 8, Quantity = 2, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 13, IngredientId = 47, Quantity = 30, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 13, IngredientId = 39, Quantity = 50, MeasurementUnit = "grama(s)" },

                // Moqueca de Peixe (14)
                new RecipeIngredient { RecipeId = 14, IngredientId = 36, Quantity = 400, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 14, IngredientId = 24, Quantity = 1, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 14, IngredientId = 18, Quantity = 2, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 14, IngredientId = 49, Quantity = 1, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 14, IngredientId = 48, Quantity = 200, MeasurementUnit = "ml" },
                new RecipeIngredient { RecipeId = 14, IngredientId = 32, Quantity = 1, MeasurementUnit = "punhado(s)" },
                new RecipeIngredient { RecipeId = 14, IngredientId = 5, Quantity = 2, MeasurementUnit = "colher(es) de sopa" },
                new RecipeIngredient { RecipeId = 14, IngredientId = 33, Quantity = 1, MeasurementUnit = "unidade(s)" },

                // Brigadeiro (15)
                new RecipeIngredient { RecipeId = 15, IngredientId = 37, Quantity = 200, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 15, IngredientId = 50, Quantity = 1, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 15, IngredientId = 47, Quantity = 1, MeasurementUnit = "colher(es) de sopa" },
                new RecipeIngredient { RecipeId = 15, IngredientId = 39, Quantity = 2, MeasurementUnit = "colher(es) de sopa" }
                ,
                // Bobó de Camarão (16)
                new RecipeIngredient { RecipeId = 16, IngredientId = 51, Quantity = 300, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 16, IngredientId = 52, Quantity = 500, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 16, IngredientId = 48, Quantity = 200, MeasurementUnit = "ml" },
                new RecipeIngredient { RecipeId = 16, IngredientId = 24, Quantity = 1, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 16, IngredientId = 5, Quantity = 2, MeasurementUnit = "colher(es) de sopa" },
                new RecipeIngredient { RecipeId = 16, IngredientId = 32, Quantity = 1, MeasurementUnit = "punhado(s)" },

                // Quiche Lorraine (17)
                new RecipeIngredient { RecipeId = 17, IngredientId = 53, Quantity = 1, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 17, IngredientId = 8, Quantity = 3, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 17, IngredientId = 38, Quantity = 200, MeasurementUnit = "ml" },
                new RecipeIngredient { RecipeId = 17, IngredientId = 10, Quantity = 100, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 17, IngredientId = 9, Quantity = 50, MeasurementUnit = "grama(s)" },

                // Pão de Alho e Ervas (18)
                new RecipeIngredient { RecipeId = 18, IngredientId = 15, Quantity = 1, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 18, IngredientId = 47, Quantity = 50, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 18, IngredientId = 54, Quantity = 3, MeasurementUnit = "dente(s)" },
                new RecipeIngredient { RecipeId = 18, IngredientId = 42, Quantity = 1, MeasurementUnit = "punhado(s)" },

                // Ceviche de Salmão (19)
                new RecipeIngredient { RecipeId = 19, IngredientId = 36, Quantity = 250, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 19, IngredientId = 33, Quantity = 3, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 19, IngredientId = 24, Quantity = 0.5, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 19, IngredientId = 32, Quantity = 1, MeasurementUnit = "punhado(s)" },
                new RecipeIngredient { RecipeId = 19, IngredientId = 11, Quantity = 1, MeasurementUnit = "pitada(s)" },

                // Pavê de Chocolate (20)
                new RecipeIngredient { RecipeId = 20, IngredientId = 55, Quantity = 200, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 20, IngredientId = 37, Quantity = 150, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 20, IngredientId = 38, Quantity = 200, MeasurementUnit = "ml" },
                new RecipeIngredient { RecipeId = 20, IngredientId = 50, Quantity = 200, MeasurementUnit = "grama(s)" },
                // Feijoada (21) - ampliado
                new RecipeIngredient { RecipeId = 21, IngredientId = 56, Quantity = 500, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 21, IngredientId = 58, Quantity = 300, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 21, IngredientId = 59, Quantity = 200, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 21, IngredientId = 10, Quantity = 150, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 21, IngredientId = 22, Quantity = 200, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 21, IngredientId = 60, Quantity = 150, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 21, IngredientId = 54, Quantity = 4, MeasurementUnit = "dente(s)" },
                new RecipeIngredient { RecipeId = 21, IngredientId = 47, Quantity = 50, MeasurementUnit = "grama(s)" },

                // Acarajé (22) - ampliado
                new RecipeIngredient { RecipeId = 22, IngredientId = 61, Quantity = 500, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 22, IngredientId = 57, Quantity = 100, MeasurementUnit = "ml" },
                new RecipeIngredient { RecipeId = 22, IngredientId = 51, Quantity = 150, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 22, IngredientId = 24, Quantity = 1, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 22, IngredientId = 54, Quantity = 2, MeasurementUnit = "dente(s)" },
                new RecipeIngredient { RecipeId = 22, IngredientId = 11, Quantity = 1, MeasurementUnit = "pitada(s)" },
                new RecipeIngredient { RecipeId = 22, IngredientId = 32, Quantity = 1, MeasurementUnit = "punhado(s)" },

                // Vatapá (23) - ampliado
                new RecipeIngredient { RecipeId = 23, IngredientId = 51, Quantity = 200, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 23, IngredientId = 48, Quantity = 250, MeasurementUnit = "ml" },
                new RecipeIngredient { RecipeId = 23, IngredientId = 57, Quantity = 50, MeasurementUnit = "ml" },
                new RecipeIngredient { RecipeId = 23, IngredientId = 62, Quantity = 80, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 23, IngredientId = 60, Quantity = 120, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 23, IngredientId = 24, Quantity = 0.5, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 23, IngredientId = 5, Quantity = 2, MeasurementUnit = "colher(es) de sopa" },

                // Arroz Carreteiro (24) - ampliado
                new RecipeIngredient { RecipeId = 24, IngredientId = 22, Quantity = 300, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 24, IngredientId = 58, Quantity = 250, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 24, IngredientId = 59, Quantity = 150, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 24, IngredientId = 24, Quantity = 1, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 24, IngredientId = 54, Quantity = 3, MeasurementUnit = "dente(s)" },
                new RecipeIngredient { RecipeId = 24, IngredientId = 5, Quantity = 2, MeasurementUnit = "colher(es) de sopa" },
                new RecipeIngredient { RecipeId = 24, IngredientId = 47, Quantity = 30, MeasurementUnit = "grama(s)" },

                // Baião de Dois (25) - ampliado
                new RecipeIngredient { RecipeId = 25, IngredientId = 22, Quantity = 200, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 25, IngredientId = 66, Quantity = 200, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 25, IngredientId = 63, Quantity = 150, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 25, IngredientId = 47, Quantity = 30, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 25, IngredientId = 58, Quantity = 120, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 25, IngredientId = 54, Quantity = 2, MeasurementUnit = "dente(s)" },

                // Escondidinho de Carne Seca (26) - ampliado
                new RecipeIngredient { RecipeId = 26, IngredientId = 58, Quantity = 350, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 26, IngredientId = 52, Quantity = 700, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 26, IngredientId = 47, Quantity = 50, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 26, IngredientId = 63, Quantity = 150, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 26, IngredientId = 24, Quantity = 1, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 26, IngredientId = 54, Quantity = 2, MeasurementUnit = "dente(s)" },
                new RecipeIngredient { RecipeId = 26, IngredientId = 5, Quantity = 1, MeasurementUnit = "colher(es) de sopa" },

                // Picanha Assada (27) - ampliado
                new RecipeIngredient { RecipeId = 27, IngredientId = 64, Quantity = 800, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 27, IngredientId = 11, Quantity = 2, MeasurementUnit = "pitada(s)" },
                new RecipeIngredient { RecipeId = 27, IngredientId = 33, Quantity = 1, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 27, IngredientId = 5, Quantity = 2, MeasurementUnit = "colher(es) de sopa" },
                new RecipeIngredient { RecipeId = 27, IngredientId = 54, Quantity = 3, MeasurementUnit = "dente(s)" },
                new RecipeIngredient { RecipeId = 27, IngredientId = 47, Quantity = 10, MeasurementUnit = "grama(s)" },

                // Pastel de Feira (28) - ampliado
                new RecipeIngredient { RecipeId = 28, IngredientId = 44, Quantity = 300, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 28, IngredientId = 13, Quantity = 250, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 28, IngredientId = 3, Quantity = 150, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 28, IngredientId = 65, Quantity = 600, MeasurementUnit = "ml" },
                new RecipeIngredient { RecipeId = 28, IngredientId = 24, Quantity = 1, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 28, IngredientId = 54, Quantity = 2, MeasurementUnit = "dente(s)" },
                new RecipeIngredient { RecipeId = 28, IngredientId = 47, Quantity = 20, MeasurementUnit = "grama(s)" },

                // Coxinha (29) - ampliado
                new RecipeIngredient { RecipeId = 29, IngredientId = 20, Quantity = 350, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 29, IngredientId = 44, Quantity = 200, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 29, IngredientId = 45, Quantity = 250, MeasurementUnit = "ml" },
                new RecipeIngredient { RecipeId = 29, IngredientId = 47, Quantity = 50, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 29, IngredientId = 24, Quantity = 1, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 29, IngredientId = 21, Quantity = 150, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 29, IngredientId = 54, Quantity = 2, MeasurementUnit = "dente(s)" },

                // Canjica (30) - ampliado
                new RecipeIngredient { RecipeId = 30, IngredientId = 67, Quantity = 400, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 30, IngredientId = 48, Quantity = 300, MeasurementUnit = "ml" },
                new RecipeIngredient { RecipeId = 30, IngredientId = 50, Quantity = 300, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 30, IngredientId = 68, Quantity = 2, MeasurementUnit = "colher(es) de chá" },
                new RecipeIngredient { RecipeId = 30, IngredientId = 39, Quantity = 150, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 30, IngredientId = 47, Quantity = 20, MeasurementUnit = "grama(s)" },

                // Pad Thai (31) - confirmado/ajustado
                new RecipeIngredient { RecipeId = 31, IngredientId = 73, Quantity = 200, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 31, IngredientId = 75, Quantity = 120, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 31, IngredientId = 51, Quantity = 120, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 31, IngredientId = 8, Quantity = 2, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 31, IngredientId = 62, Quantity = 40, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 31, IngredientId = 69, Quantity = 40, MeasurementUnit = "ml" },
                new RecipeIngredient { RecipeId = 31, IngredientId = 70, Quantity = 15, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 31, IngredientId = 33, Quantity = 1, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 31, IngredientId = 5, Quantity = 1, MeasurementUnit = "colher(es) de sopa" },

                // Ramen (32) - confirmado/ajustado
                new RecipeIngredient { RecipeId = 32, IngredientId = 73, Quantity = 200, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 32, IngredientId = 26, Quantity = 600, MeasurementUnit = "ml" },
                new RecipeIngredient { RecipeId = 32, IngredientId = 80, Quantity = 60, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 32, IngredientId = 8, Quantity = 2, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 32, IngredientId = 69, Quantity = 40, MeasurementUnit = "ml" },
                new RecipeIngredient { RecipeId = 32, IngredientId = 72, Quantity = 1, MeasurementUnit = "punhado(s)" },
                new RecipeIngredient { RecipeId = 32, IngredientId = 54, Quantity = 2, MeasurementUnit = "dente(s)" },

                // Frango General Tso (33) - confirmado/ajustado
                new RecipeIngredient { RecipeId = 33, IngredientId = 20, Quantity = 350, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 33, IngredientId = 44, Quantity = 120, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 33, IngredientId = 65, Quantity = 300, MeasurementUnit = "ml" },
                new RecipeIngredient { RecipeId = 33, IngredientId = 69, Quantity = 60, MeasurementUnit = "ml" },
                new RecipeIngredient { RecipeId = 33, IngredientId = 39, Quantity = 30, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 33, IngredientId = 70, Quantity = 15, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 33, IngredientId = 54, Quantity = 3, MeasurementUnit = "dente(s)" },

                // Gyoza (34) - confirmado/ajustado
                new RecipeIngredient { RecipeId = 34, IngredientId = 13, Quantity = 220, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 34, IngredientId = 53, Quantity = 1, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 34, IngredientId = 72, Quantity = 1, MeasurementUnit = "punhado(s)" },
                new RecipeIngredient { RecipeId = 34, IngredientId = 70, Quantity = 8, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 34, IngredientId = 54, Quantity = 2, MeasurementUnit = "dente(s)" },
                new RecipeIngredient { RecipeId = 34, IngredientId = 69, Quantity = 40, MeasurementUnit = "ml" },
                new RecipeIngredient { RecipeId = 34, IngredientId = 5, Quantity = 1, MeasurementUnit = "colher(es) de sopa" },

                // Bibimbap (35) - confirmado/ajustado
                new RecipeIngredient { RecipeId = 35, IngredientId = 22, Quantity = 200, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 35, IngredientId = 64, Quantity = 150, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 35, IngredientId = 8, Quantity = 1, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 35, IngredientId = 23, Quantity = 60, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 35, IngredientId = 71, Quantity = 1, MeasurementUnit = "colher(es) de sopa" },
                new RecipeIngredient { RecipeId = 35, IngredientId = 72, Quantity = 1, MeasurementUnit = "punhado(s)" },
                new RecipeIngredient { RecipeId = 35, IngredientId = 54, Quantity = 1, MeasurementUnit = "dente(s)" },

                // Curry Verde Tailandês (36) - confirmado/ajustado
                new RecipeIngredient { RecipeId = 36, IngredientId = 20, Quantity = 300, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 36, IngredientId = 48, Quantity = 250, MeasurementUnit = "ml" },
                new RecipeIngredient { RecipeId = 36, IngredientId = 74, Quantity = 12, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 36, IngredientId = 49, Quantity = 1, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 36, IngredientId = 71, Quantity = 2, MeasurementUnit = "colher(es) de sopa" },
                new RecipeIngredient { RecipeId = 36, IngredientId = 78, Quantity = 1, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 36, IngredientId = 5, Quantity = 1, MeasurementUnit = "colher(es) de sopa" },

                // Frango Teriyaki (37) - confirmado/ajustado
                new RecipeIngredient { RecipeId = 37, IngredientId = 20, Quantity = 300, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 37, IngredientId = 69, Quantity = 60, MeasurementUnit = "ml" },
                new RecipeIngredient { RecipeId = 37, IngredientId = 77, Quantity = 40, MeasurementUnit = "ml" },
                new RecipeIngredient { RecipeId = 37, IngredientId = 70, Quantity = 15, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 37, IngredientId = 39, Quantity = 30, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 37, IngredientId = 72, Quantity = 1, MeasurementUnit = "punhado(s)" },
                new RecipeIngredient { RecipeId = 37, IngredientId = 54, Quantity = 2, MeasurementUnit = "dente(s)" },

                // Frango Manteiga (38) - confirmado/ajustado
                new RecipeIngredient { RecipeId = 38, IngredientId = 20, Quantity = 350, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 38, IngredientId = 38, Quantity = 150, MeasurementUnit = "ml" },
                new RecipeIngredient { RecipeId = 38, IngredientId = 74, Quantity = 20, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 38, IngredientId = 18, Quantity = 250, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 38, IngredientId = 54, Quantity = 3, MeasurementUnit = "dente(s)" },
                new RecipeIngredient { RecipeId = 38, IngredientId = 47, Quantity = 40, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 38, IngredientId = 5, Quantity = 1, MeasurementUnit = "colher(es) de sopa" },

                // Mapo Tofu (39) - confirmado/ajustado
                new RecipeIngredient { RecipeId = 39, IngredientId = 75, Quantity = 300, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 39, IngredientId = 13, Quantity = 150, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 39, IngredientId = 69, Quantity = 40, MeasurementUnit = "ml" },
                new RecipeIngredient { RecipeId = 39, IngredientId = 71, Quantity = 1, MeasurementUnit = "colher(es) de sopa" },
                new RecipeIngredient { RecipeId = 39, IngredientId = 78, Quantity = 1, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 39, IngredientId = 72, Quantity = 2, MeasurementUnit = "punhado(s)" },
                new RecipeIngredient { RecipeId = 39, IngredientId = 54, Quantity = 2, MeasurementUnit = "dente(s)" },

                // Bulgogi (40) - confirmado/ajustado
                new RecipeIngredient { RecipeId = 40, IngredientId = 64, Quantity = 350, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 40, IngredientId = 69, Quantity = 50, MeasurementUnit = "ml" },
                new RecipeIngredient { RecipeId = 40, IngredientId = 39, Quantity = 30, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 40, IngredientId = 70, Quantity = 15, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 40, IngredientId = 71, Quantity = 1, MeasurementUnit = "colher(es) de sopa" },
                new RecipeIngredient { RecipeId = 40, IngredientId = 72, Quantity = 2, MeasurementUnit = "punhado(s)" },
                new RecipeIngredient { RecipeId = 40, IngredientId = 54, Quantity = 1, MeasurementUnit = "dente(s)" },

                // Beef Bourguignon (41) - ampliado
                new RecipeIngredient { RecipeId = 41, IngredientId = 13, Quantity = 800, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 41, IngredientId = 10, Quantity = 100, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 41, IngredientId = 24, Quantity = 2, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 41, IngredientId = 54, Quantity = 3, MeasurementUnit = "dente(s)" },
                new RecipeIngredient { RecipeId = 41, IngredientId = 81, Quantity = 500, MeasurementUnit = "ml" },
                new RecipeIngredient { RecipeId = 41, IngredientId = 26, Quantity = 500, MeasurementUnit = "ml" },
                new RecipeIngredient { RecipeId = 41, IngredientId = 44, Quantity = 20, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 41, IngredientId = 89, Quantity = 2, MeasurementUnit = "ramos" },
                new RecipeIngredient { RecipeId = 41, IngredientId = 47, Quantity = 30, MeasurementUnit = "grama(s)" },

                // Tiramisù (42) - ampliado
                new RecipeIngredient { RecipeId = 42, IngredientId = 82, Quantity = 500, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 42, IngredientId = 91, Quantity = 200, MeasurementUnit = "ml" },
                new RecipeIngredient { RecipeId = 42, IngredientId = 8, Quantity = 3, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 42, IngredientId = 39, Quantity = 120, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 42, IngredientId = 55, Quantity = 200, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 42, IngredientId = 40, Quantity = 1, MeasurementUnit = "colher(es) de chá" },
                new RecipeIngredient { RecipeId = 42, IngredientId = 37, Quantity = 30, MeasurementUnit = "grama(s)" },

                // Pasta Puttanesca (43) - ampliado
                new RecipeIngredient { RecipeId = 43, IngredientId = 7, Quantity = 200, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 43, IngredientId = 2, Quantity = 200, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 43, IngredientId = 54, Quantity = 2, MeasurementUnit = "dente(s)" },
                new RecipeIngredient { RecipeId = 43, IngredientId = 83, Quantity = 50, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 43, IngredientId = 84, Quantity = 20, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 43, IngredientId = 5, Quantity = 2, MeasurementUnit = "colher(es) de sopa" },
                new RecipeIngredient { RecipeId = 43, IngredientId = 11, Quantity = 1, MeasurementUnit = "pitada(s)" },

                // Paella Valenciana (44) - ampliado
                new RecipeIngredient { RecipeId = 44, IngredientId = 22, Quantity = 300, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 44, IngredientId = 85, Quantity = 1, MeasurementUnit = "colher(es) de chá" },
                new RecipeIngredient { RecipeId = 44, IngredientId = 86, Quantity = 200, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 44, IngredientId = 51, Quantity = 200, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 44, IngredientId = 49, Quantity = 1, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 44, IngredientId = 18, Quantity = 200, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 44, IngredientId = 54, Quantity = 3, MeasurementUnit = "dente(s)" },
                new RecipeIngredient { RecipeId = 44, IngredientId = 25, Quantity = 100, MeasurementUnit = "ml" },
                new RecipeIngredient { RecipeId = 44, IngredientId = 26, Quantity = 800, MeasurementUnit = "ml" },
                new RecipeIngredient { RecipeId = 44, IngredientId = 5, Quantity = 2, MeasurementUnit = "colher(es) de sopa" },

                // Moussaka (45) - ampliado
                new RecipeIngredient { RecipeId = 45, IngredientId = 87, Quantity = 2, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 45, IngredientId = 13, Quantity = 300, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 45, IngredientId = 18, Quantity = 200, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 45, IngredientId = 14, Quantity = 250, MeasurementUnit = "ml" },
                new RecipeIngredient { RecipeId = 45, IngredientId = 44, Quantity = 30, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 45, IngredientId = 47, Quantity = 30, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 45, IngredientId = 9, Quantity = 50, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 45, IngredientId = 8, Quantity = 1, MeasurementUnit = "unidade(s)" },

                // Gnocchi de Batata (46) - ampliado
                new RecipeIngredient { RecipeId = 46, IngredientId = 88, Quantity = 500, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 46, IngredientId = 44, Quantity = 200, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 46, IngredientId = 8, Quantity = 2, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 46, IngredientId = 45, Quantity = 50, MeasurementUnit = "ml" },
                new RecipeIngredient { RecipeId = 46, IngredientId = 47, Quantity = 30, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 46, IngredientId = 9, Quantity = 50, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 46, IngredientId = 11, Quantity = 1, MeasurementUnit = "pitada(s)" },

                // Ratatouille (47) - ampliado
                new RecipeIngredient { RecipeId = 47, IngredientId = 87, Quantity = 1, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 47, IngredientId = 49, Quantity = 1, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 47, IngredientId = 18, Quantity = 2, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 47, IngredientId = 24, Quantity = 1, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 47, IngredientId = 54, Quantity = 2, MeasurementUnit = "dente(s)" },
                new RecipeIngredient { RecipeId = 47, IngredientId = 89, Quantity = 2, MeasurementUnit = "ramos" },
                new RecipeIngredient { RecipeId = 47, IngredientId = 90, Quantity = 1, MeasurementUnit = "ramo(s)" },
                new RecipeIngredient { RecipeId = 47, IngredientId = 5, Quantity = 2, MeasurementUnit = "colher(es) de sopa" },

                // Bruschetta al Pomodoro (48) - ampliado
                new RecipeIngredient { RecipeId = 48, IngredientId = 15, Quantity = 4, MeasurementUnit = "fatia(s)" },
                new RecipeIngredient { RecipeId = 48, IngredientId = 18, Quantity = 250, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 48, IngredientId = 54, Quantity = 1, MeasurementUnit = "dente(s)" },
                new RecipeIngredient { RecipeId = 48, IngredientId = 4, Quantity = 1, MeasurementUnit = "punhado(s)" },
                new RecipeIngredient { RecipeId = 48, IngredientId = 5, Quantity = 2, MeasurementUnit = "colher(es) de sopa" },
                new RecipeIngredient { RecipeId = 48, IngredientId = 11, Quantity = 1, MeasurementUnit = "pitada(s)" },
                new RecipeIngredient { RecipeId = 48, IngredientId = 9, Quantity = 20, MeasurementUnit = "grama(s)" },

                // Bouillabaisse (49) - ampliado
                new RecipeIngredient { RecipeId = 49, IngredientId = 86, Quantity = 300, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 49, IngredientId = 36, Quantity = 200, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 49, IngredientId = 18, Quantity = 200, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 49, IngredientId = 54, Quantity = 2, MeasurementUnit = "dente(s)" },
                new RecipeIngredient { RecipeId = 49, IngredientId = 25, Quantity = 100, MeasurementUnit = "ml" },
                new RecipeIngredient { RecipeId = 49, IngredientId = 85, Quantity = 1, MeasurementUnit = "colher(es) de chá" },
                new RecipeIngredient { RecipeId = 49, IngredientId = 26, Quantity = 1000, MeasurementUnit = "ml" },
                new RecipeIngredient { RecipeId = 49, IngredientId = 5, Quantity = 2, MeasurementUnit = "colher(es) de sopa" },
                new RecipeIngredient { RecipeId = 49, IngredientId = 47, Quantity = 20, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 49, IngredientId = 11, Quantity = 1, MeasurementUnit = "pitada(s)" },

                // Risotto alla Milanese (50) - ampliado
                new RecipeIngredient { RecipeId = 50, IngredientId = 22, Quantity = 200, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 50, IngredientId = 24, Quantity = 0.5, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 50, IngredientId = 25, Quantity = 50, MeasurementUnit = "ml" },
                new RecipeIngredient { RecipeId = 50, IngredientId = 26, Quantity = 700, MeasurementUnit = "ml" },
                new RecipeIngredient { RecipeId = 50, IngredientId = 85, Quantity = 1, MeasurementUnit = "colher(es) de chá" },
                new RecipeIngredient { RecipeId = 50, IngredientId = 9, Quantity = 60, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 50, IngredientId = 47, Quantity = 40, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 50, IngredientId = 5, Quantity = 1, MeasurementUnit = "colher(es) de sopa" },

                // Tarte Tatin (51) - ampliado
                new RecipeIngredient { RecipeId = 51, IngredientId = 95, Quantity = 6, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 51, IngredientId = 39, Quantity = 150, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 51, IngredientId = 47, Quantity = 100, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 51, IngredientId = 53, Quantity = 1, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 51, IngredientId = 40, Quantity = 1, MeasurementUnit = "colher(es) de chá" },

                // Panna Cotta (52) - ampliado
                new RecipeIngredient { RecipeId = 52, IngredientId = 38, Quantity = 500, MeasurementUnit = "ml" },
                new RecipeIngredient { RecipeId = 52, IngredientId = 45, Quantity = 200, MeasurementUnit = "ml" },
                new RecipeIngredient { RecipeId = 52, IngredientId = 39, Quantity = 80, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 52, IngredientId = 94, Quantity = 10, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 52, IngredientId = 40, Quantity = 1, MeasurementUnit = "colher(es) de chá" },
                new RecipeIngredient { RecipeId = 52, IngredientId = 92, Quantity = 100, MeasurementUnit = "grama(s)" },

                // New York Cheesecake (53) - ampliado
                new RecipeIngredient { RecipeId = 53, IngredientId = 55, Quantity = 200, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 53, IngredientId = 47, Quantity = 80, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 53, IngredientId = 93, Quantity = 600, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 53, IngredientId = 39, Quantity = 150, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 53, IngredientId = 8, Quantity = 3, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 53, IngredientId = 40, Quantity = 1, MeasurementUnit = "colher(es) de chá" },
                new RecipeIngredient { RecipeId = 53, IngredientId = 38, Quantity = 100, MeasurementUnit = "ml" },

                // Pavlova de Frutas Vermelhas (54) - ampliado
                new RecipeIngredient { RecipeId = 54, IngredientId = 8, Quantity = 4, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 54, IngredientId = 39, Quantity = 200, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 54, IngredientId = 38, Quantity = 200, MeasurementUnit = "ml" },
                new RecipeIngredient { RecipeId = 54, IngredientId = 92, Quantity = 150, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 54, IngredientId = 40, Quantity = 1, MeasurementUnit = "colher(es) de chá" },

                // Apple Pie (55) - ampliado
                new RecipeIngredient { RecipeId = 55, IngredientId = 95, Quantity = 6, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 55, IngredientId = 39, Quantity = 120, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 55, IngredientId = 44, Quantity = 300, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 55, IngredientId = 47, Quantity = 100, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 55, IngredientId = 8, Quantity = 1, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 55, IngredientId = 40, Quantity = 1, MeasurementUnit = "colher(es) de chá" },
                new RecipeIngredient { RecipeId = 55, IngredientId = 68, Quantity = 1, MeasurementUnit = "colher(es) de chá" },

                // Profiteroles com Chocolate (56) - ampliado
                new RecipeIngredient { RecipeId = 56, IngredientId = 44, Quantity = 200, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 56, IngredientId = 8, Quantity = 4, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 56, IngredientId = 47, Quantity = 80, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 56, IngredientId = 37, Quantity = 150, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 56, IngredientId = 38, Quantity = 200, MeasurementUnit = "ml" },
                new RecipeIngredient { RecipeId = 56, IngredientId = 39, Quantity = 80, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 56, IngredientId = 45, Quantity = 100, MeasurementUnit = "ml" },

                // Chocolate Fondant (57) - ampliado
                new RecipeIngredient { RecipeId = 57, IngredientId = 37, Quantity = 200, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 57, IngredientId = 47, Quantity = 100, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 57, IngredientId = 8, Quantity = 3, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 57, IngredientId = 39, Quantity = 80, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 57, IngredientId = 44, Quantity = 30, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 57, IngredientId = 38, Quantity = 50, MeasurementUnit = "ml" },

                // Tarte de Limão (58) - ampliado
                new RecipeIngredient { RecipeId = 58, IngredientId = 33, Quantity = 3, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 58, IngredientId = 8, Quantity = 3, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 58, IngredientId = 39, Quantity = 120, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 58, IngredientId = 44, Quantity = 250, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 58, IngredientId = 47, Quantity = 80, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 58, IngredientId = 40, Quantity = 1, MeasurementUnit = "colher(es) de chá" },
                new RecipeIngredient { RecipeId = 58, IngredientId = 45, Quantity = 50, MeasurementUnit = "ml" },

                // Gelato de Baunilha (59) - ampliado
                new RecipeIngredient { RecipeId = 59, IngredientId = 45, Quantity = 400, MeasurementUnit = "ml" },
                new RecipeIngredient { RecipeId = 59, IngredientId = 38, Quantity = 200, MeasurementUnit = "ml" },
                new RecipeIngredient { RecipeId = 59, IngredientId = 39, Quantity = 120, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 59, IngredientId = 40, Quantity = 1, MeasurementUnit = "colher(es) de chá" },
                new RecipeIngredient { RecipeId = 59, IngredientId = 8, Quantity = 2, MeasurementUnit = "unidade(s)" },

                // Crème Catalane (60) - ampliado
                new RecipeIngredient { RecipeId = 60, IngredientId = 45, Quantity = 500, MeasurementUnit = "ml" },
                new RecipeIngredient { RecipeId = 60, IngredientId = 8, Quantity = 4, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 60, IngredientId = 39, Quantity = 80, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 60, IngredientId = 40, Quantity = 1, MeasurementUnit = "colher(es) de chá" },
                new RecipeIngredient { RecipeId = 60, IngredientId = 68, Quantity = 1, MeasurementUnit = "colher(es) de chá" },
                new RecipeIngredient { RecipeId = 60, IngredientId = 33, Quantity = 1, MeasurementUnit = "unidade(s)" },

                // RecipeIngredient entries for Street Foods (61-70) — ampliadas
                // Arepa (61)
                new RecipeIngredient { RecipeId = 61, IngredientId = 96, Quantity = 200, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 61, IngredientId = 45, Quantity = 150, MeasurementUnit = "ml" },
                new RecipeIngredient { RecipeId = 61, IngredientId = 5, Quantity = 1, MeasurementUnit = "colher(es) de sopa" },
                new RecipeIngredient { RecipeId = 61, IngredientId = 47, Quantity = 10, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 61, IngredientId = 93, Quantity = 60, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 61, IngredientId = 31, Quantity = 120, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 61, IngredientId = 11, Quantity = 1, MeasurementUnit = "pitada(s)" },

                // Falafel Wrap (62)
                new RecipeIngredient { RecipeId = 62, IngredientId = 97, Quantity = 250, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 62, IngredientId = 24, Quantity = 1, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 62, IngredientId = 54, Quantity = 3, MeasurementUnit = "dente(s)" },
                new RecipeIngredient { RecipeId = 62, IngredientId = 70, Quantity = 10, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 62, IngredientId = 98, Quantity = 40, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 62, IngredientId = 102, Quantity = 2, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 62, IngredientId = 17, Quantity = 1, MeasurementUnit = "punhado(s)" },
                new RecipeIngredient { RecipeId = 62, IngredientId = 33, Quantity = 1, MeasurementUnit = "unidade(s)" },

                // Bánh Mì (63)
                new RecipeIngredient { RecipeId = 63, IngredientId = 99, Quantity = 1, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 63, IngredientId = 31, Quantity = 180, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 63, IngredientId = 24, Quantity = 0.5, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 63, IngredientId = 18, Quantity = 1, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 63, IngredientId = 32, Quantity = 1, MeasurementUnit = "punhado(s)" },
                new RecipeIngredient { RecipeId = 63, IngredientId = 5, Quantity = 1, MeasurementUnit = "colher(es) de sopa" },
                new RecipeIngredient { RecipeId = 63, IngredientId = 39, Quantity = 10, MeasurementUnit = "grama(s)" },

                // Samosa (64)
                new RecipeIngredient { RecipeId = 64, IngredientId = 88, Quantity = 300, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 64, IngredientId = 101, Quantity = 120, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 64, IngredientId = 24, Quantity = 1, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 64, IngredientId = 54, Quantity = 2, MeasurementUnit = "dente(s)" },
                new RecipeIngredient { RecipeId = 64, IngredientId = 70, Quantity = 10, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 64, IngredientId = 74, Quantity = 5, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 64, IngredientId = 44, Quantity = 200, MeasurementUnit = "grama(s)" },

                // Pão de Queijo (65)
                new RecipeIngredient { RecipeId = 65, IngredientId = 100, Quantity = 250, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 65, IngredientId = 63, Quantity = 180, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 65, IngredientId = 8, Quantity = 2, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 65, IngredientId = 45, Quantity = 150, MeasurementUnit = "ml" },
                new RecipeIngredient { RecipeId = 65, IngredientId = 47, Quantity = 30, MeasurementUnit = "grama(s)" },

                // Empanada Argentina (66)
                new RecipeIngredient { RecipeId = 66, IngredientId = 53, Quantity = 2, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 66, IngredientId = 13, Quantity = 300, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 66, IngredientId = 24, Quantity = 1, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 66, IngredientId = 54, Quantity = 2, MeasurementUnit = "dente(s)" },
                new RecipeIngredient { RecipeId = 66, IngredientId = 11, Quantity = 1, MeasurementUnit = "pitada(s)" },
                new RecipeIngredient { RecipeId = 66, IngredientId = 47, Quantity = 20, MeasurementUnit = "grama(s)" },

                // Shawarma (67)
                new RecipeIngredient { RecipeId = 67, IngredientId = 102, Quantity = 2, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 67, IngredientId = 31, Quantity = 220, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 67, IngredientId = 24, Quantity = 0.5, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 67, IngredientId = 98, Quantity = 30, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 67, IngredientId = 33, Quantity = 1, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 67, IngredientId = 5, Quantity = 1, MeasurementUnit = "colher(es) de sopa" },
                new RecipeIngredient { RecipeId = 67, IngredientId = 32, Quantity = 1, MeasurementUnit = "punhado(s)" },

                // Churros (68)
                new RecipeIngredient { RecipeId = 68, IngredientId = 44, Quantity = 200, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 68, IngredientId = 8, Quantity = 2, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 68, IngredientId = 47, Quantity = 30, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 68, IngredientId = 45, Quantity = 150, MeasurementUnit = "ml" },
                new RecipeIngredient { RecipeId = 68, IngredientId = 65, Quantity = 800, MeasurementUnit = "ml" },
                new RecipeIngredient { RecipeId = 68, IngredientId = 39, Quantity = 80, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 68, IngredientId = 68, Quantity = 2, MeasurementUnit = "colher(es) de chá" },

                // Bao Bun (69)
                new RecipeIngredient { RecipeId = 69, IngredientId = 44, Quantity = 300, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 69, IngredientId = 45, Quantity = 180, MeasurementUnit = "ml" },
                new RecipeIngredient { RecipeId = 69, IngredientId = 8, Quantity = 1, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 69, IngredientId = 47, Quantity = 20, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 69, IngredientId = 31, Quantity = 150, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 69, IngredientId = 24, Quantity = 0.5, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 69, IngredientId = 72, Quantity = 1, MeasurementUnit = "punhado(s)" },

                // Pupusa (70)
                new RecipeIngredient { RecipeId = 70, IngredientId = 96, Quantity = 300, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 70, IngredientId = 61, Quantity = 180, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 70, IngredientId = 63, Quantity = 120, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 70, IngredientId = 24, Quantity = 0.5, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 70, IngredientId = 47, Quantity = 20, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 70, IngredientId = 5, Quantity = 1, MeasurementUnit = "colher(es) de sopa" },

                // RecipeIngredient entries for Mediterranean recipes (71-80)
                // Salada Grega (71)
                new RecipeIngredient { RecipeId = 71, IngredientId = 104, Quantity = 1, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 71, IngredientId = 18, Quantity = 200, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 71, IngredientId = 83, Quantity = 50, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 71, IngredientId = 103, Quantity = 150, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 71, IngredientId = 24, Quantity = 0.5, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 71, IngredientId = 5, Quantity = 2, MeasurementUnit = "colher(es) de sopa" },
                new RecipeIngredient { RecipeId = 71, IngredientId = 6, Quantity = 1, MeasurementUnit = "pitada(s)" },
                new RecipeIngredient { RecipeId = 71, IngredientId = 33, Quantity = 1, MeasurementUnit = "unidade(s)" },

                // Shakshuka (72)
                new RecipeIngredient { RecipeId = 72, IngredientId = 2, Quantity = 400, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 72, IngredientId = 49, Quantity = 1, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 72, IngredientId = 24, Quantity = 1, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 72, IngredientId = 8, Quantity = 4, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 72, IngredientId = 54, Quantity = 2, MeasurementUnit = "dente(s)" },
                new RecipeIngredient { RecipeId = 72, IngredientId = 5, Quantity = 2, MeasurementUnit = "colher(es) de sopa" },
                new RecipeIngredient { RecipeId = 72, IngredientId = 78, Quantity = 1, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 72, IngredientId = 42, Quantity = 1, MeasurementUnit = "punhado(s)" },

                // Berinjela Assada com Tahine (73)
                new RecipeIngredient { RecipeId = 73, IngredientId = 87, Quantity = 2, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 73, IngredientId = 98, Quantity = 50, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 73, IngredientId = 54, Quantity = 2, MeasurementUnit = "dente(s)" },
                new RecipeIngredient { RecipeId = 73, IngredientId = 33, Quantity = 1, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 73, IngredientId = 5, Quantity = 2, MeasurementUnit = "colher(es) de sopa" },
                new RecipeIngredient { RecipeId = 73, IngredientId = 42, Quantity = 1, MeasurementUnit = "punhado(s)" },
                new RecipeIngredient { RecipeId = 73, IngredientId = 11, Quantity = 1, MeasurementUnit = "pitada(s)" },

                // Frango Assado ao Limão e Ervas (74)
                new RecipeIngredient { RecipeId = 74, IngredientId = 20, Quantity = 500, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 74, IngredientId = 33, Quantity = 2, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 74, IngredientId = 90, Quantity = 2, MeasurementUnit = "ramo(s)" },
                new RecipeIngredient { RecipeId = 74, IngredientId = 89, Quantity = 2, MeasurementUnit = "ramos" },
                new RecipeIngredient { RecipeId = 74, IngredientId = 54, Quantity = 4, MeasurementUnit = "dente(s)" },
                new RecipeIngredient { RecipeId = 74, IngredientId = 5, Quantity = 2, MeasurementUnit = "colher(es) de sopa" },
                new RecipeIngredient { RecipeId = 74, IngredientId = 11, Quantity = 1, MeasurementUnit = "pitada(s)" },

                // Mexilhões ao Alho e Vinho Branco (75)
                new RecipeIngredient { RecipeId = 75, IngredientId = 86, Quantity = 800, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 75, IngredientId = 25, Quantity = 150, MeasurementUnit = "ml" },
                new RecipeIngredient { RecipeId = 75, IngredientId = 54, Quantity = 4, MeasurementUnit = "dente(s)" },
                new RecipeIngredient { RecipeId = 75, IngredientId = 24, Quantity = 1, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 75, IngredientId = 18, Quantity = 200, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 75, IngredientId = 5, Quantity = 2, MeasurementUnit = "colher(es) de sopa" },
                new RecipeIngredient { RecipeId = 75, IngredientId = 42, Quantity = 1, MeasurementUnit = "punhado(s)" },

                // Hummus com Pão Sírio (76)
                new RecipeIngredient { RecipeId = 76, IngredientId = 97, Quantity = 300, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 76, IngredientId = 98, Quantity = 60, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 76, IngredientId = 33, Quantity = 1, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 76, IngredientId = 54, Quantity = 2, MeasurementUnit = "dente(s)" },
                new RecipeIngredient { RecipeId = 76, IngredientId = 5, Quantity = 2, MeasurementUnit = "colher(es) de sopa" },
                new RecipeIngredient { RecipeId = 76, IngredientId = 11, Quantity = 1, MeasurementUnit = "pitada(s)" },
                new RecipeIngredient { RecipeId = 76, IngredientId = 102, Quantity = 2, MeasurementUnit = "unidade(s)" },

                // Tapenade de Azeitonas com Baguete (77)
                new RecipeIngredient { RecipeId = 77, IngredientId = 83, Quantity = 150, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 77, IngredientId = 84, Quantity = 30, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 77, IngredientId = 5, Quantity = 2, MeasurementUnit = "colher(es) de sopa" },
                new RecipeIngredient { RecipeId = 77, IngredientId = 54, Quantity = 1, MeasurementUnit = "dente(s)" },
                new RecipeIngredient { RecipeId = 77, IngredientId = 99, Quantity = 1, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 77, IngredientId = 9, Quantity = 20, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 77, IngredientId = 42, Quantity = 1, MeasurementUnit = "punhado(s)" },

                // Feta Assado com Tomates (78)
                new RecipeIngredient { RecipeId = 78, IngredientId = 103, Quantity = 200, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 78, IngredientId = 18, Quantity = 300, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 78, IngredientId = 5, Quantity = 2, MeasurementUnit = "colher(es) de sopa" },
                new RecipeIngredient { RecipeId = 78, IngredientId = 54, Quantity = 2, MeasurementUnit = "dente(s)" },
                new RecipeIngredient { RecipeId = 78, IngredientId = 6, Quantity = 1, MeasurementUnit = "pitada(s)" },
                new RecipeIngredient { RecipeId = 78, IngredientId = 11, Quantity = 1, MeasurementUnit = "pitada(s)" },
                new RecipeIngredient { RecipeId = 78, IngredientId = 99, Quantity = 1, MeasurementUnit = "unidade(s)" },

                // Batatas Gregas ao Limão e Ervas (79)
                new RecipeIngredient { RecipeId = 79, IngredientId = 88, Quantity = 800, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 79, IngredientId = 33, Quantity = 2, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 79, IngredientId = 6, Quantity = 1, MeasurementUnit = "colher(es) de chá" },
                new RecipeIngredient { RecipeId = 79, IngredientId = 90, Quantity = 2, MeasurementUnit = "ramo(s)" },
                new RecipeIngredient { RecipeId = 79, IngredientId = 5, Quantity = 3, MeasurementUnit = "colher(es) de sopa" },
                new RecipeIngredient { RecipeId = 79, IngredientId = 54, Quantity = 4, MeasurementUnit = "dente(s)" },
                new RecipeIngredient { RecipeId = 79, IngredientId = 11, Quantity = 1, MeasurementUnit = "pitada(s)" },

                // Pimentões Recheados com Bulgur (80)
                new RecipeIngredient { RecipeId = 80, IngredientId = 49, Quantity = 4, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 80, IngredientId = 41, Quantity = 200, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 80, IngredientId = 18, Quantity = 150, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 80, IngredientId = 24, Quantity = 1, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 80, IngredientId = 5, Quantity = 2, MeasurementUnit = "colher(es) de sopa" },
                new RecipeIngredient { RecipeId = 80, IngredientId = 103, Quantity = 100, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 80, IngredientId = 42, Quantity = 1, MeasurementUnit = "punhado(s)" },

                // RecipeIngredient entries for African recipes (81-90)
                // Jollof Rice (81)
                new RecipeIngredient { RecipeId = 81, IngredientId = 24, Quantity = 1, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 81, IngredientId = 54, Quantity = 2, MeasurementUnit = "dente(s)" },
                new RecipeIngredient { RecipeId = 81, IngredientId = 18, Quantity = 400, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 81, IngredientId = 22, Quantity = 300, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 81, IngredientId = 20, Quantity = 400, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 81, IngredientId = 5, Quantity = 3, MeasurementUnit = "colher(es) de sopa" },
                new RecipeIngredient { RecipeId = 81, IngredientId = 11, Quantity = 1, MeasurementUnit = "pitada(s)" },
                new RecipeIngredient { RecipeId = 81, IngredientId = 33, Quantity = 1, MeasurementUnit = "unidade(s)" },

                // Bobotie (82)
                new RecipeIngredient { RecipeId = 82, IngredientId = 13, Quantity = 500, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 82, IngredientId = 44, Quantity = 100, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 82, IngredientId = 45, Quantity = 200, MeasurementUnit = "ml" },
                new RecipeIngredient { RecipeId = 82, IngredientId = 8, Quantity = 2, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 82, IngredientId = 74, Quantity = 5, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 82, IngredientId = 39, Quantity = 20, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 82, IngredientId = 54, Quantity = 2, MeasurementUnit = "dente(s)" },

                // Suya (83)
                new RecipeIngredient { RecipeId = 83, IngredientId = 64, Quantity = 500, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 83, IngredientId = 62, Quantity = 100, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 83, IngredientId = 54, Quantity = 2, MeasurementUnit = "dente(s)" },
                new RecipeIngredient { RecipeId = 83, IngredientId = 11, Quantity = 1, MeasurementUnit = "pitada(s)" },
                new RecipeIngredient { RecipeId = 83, IngredientId = 5, Quantity = 2, MeasurementUnit = "colher(es) de sopa" },
                new RecipeIngredient { RecipeId = 83, IngredientId = 33, Quantity = 1, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 83, IngredientId = 70, Quantity = 10, MeasurementUnit = "grama(s)" },

                // Tagine de Carne (84)
                new RecipeIngredient { RecipeId = 84, IngredientId = 13, Quantity = 600, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 84, IngredientId = 24, Quantity = 1, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 84, IngredientId = 49, Quantity = 1, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 84, IngredientId = 18, Quantity = 200, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 84, IngredientId = 85, Quantity = 1, MeasurementUnit = "colher(es) de chá" },
                new RecipeIngredient { RecipeId = 84, IngredientId = 26, Quantity = 400, MeasurementUnit = "ml" },
                new RecipeIngredient { RecipeId = 84, IngredientId = 5, Quantity = 2, MeasurementUnit = "colher(es) de sopa" },

                // Poulet Yassa (85)
                new RecipeIngredient { RecipeId = 85, IngredientId = 20, Quantity = 800, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 85, IngredientId = 24, Quantity = 3, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 85, IngredientId = 33, Quantity = 3, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 85, IngredientId = 54, Quantity = 3, MeasurementUnit = "dente(s)" },
                new RecipeIngredient { RecipeId = 85, IngredientId = 5, Quantity = 3, MeasurementUnit = "colher(es) de sopa" },
                new RecipeIngredient { RecipeId = 85, IngredientId = 78, Quantity = 1, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 85, IngredientId = 11, Quantity = 1, MeasurementUnit = "pitada(s)" },

                // Piri-Piri Camarão (86)
                new RecipeIngredient { RecipeId = 86, IngredientId = 51, Quantity = 400, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 86, IngredientId = 78, Quantity = 2, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 86, IngredientId = 54, Quantity = 3, MeasurementUnit = "dente(s)" },
                new RecipeIngredient { RecipeId = 86, IngredientId = 5, Quantity = 2, MeasurementUnit = "colher(es) de sopa" },
                new RecipeIngredient { RecipeId = 86, IngredientId = 33, Quantity = 1, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 86, IngredientId = 42, Quantity = 1, MeasurementUnit = "punhado(s)" },
                new RecipeIngredient { RecipeId = 86, IngredientId = 47, Quantity = 20, MeasurementUnit = "grama(s)" },

                // Mandazi (87)
                new RecipeIngredient { RecipeId = 87, IngredientId = 44, Quantity = 300, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 87, IngredientId = 39, Quantity = 80, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 87, IngredientId = 8, Quantity = 1, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 87, IngredientId = 48, Quantity = 150, MeasurementUnit = "ml" },
                new RecipeIngredient { RecipeId = 87, IngredientId = 47, Quantity = 30, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 87, IngredientId = 45, Quantity = 50, MeasurementUnit = "ml" },
                new RecipeIngredient { RecipeId = 87, IngredientId = 11, Quantity = 1, MeasurementUnit = "pitada(s)" },

                // Pap (Ugali) (88)
                new RecipeIngredient { RecipeId = 88, IngredientId = 96, Quantity = 300, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 88, IngredientId = 45, Quantity = 200, MeasurementUnit = "ml" },
                new RecipeIngredient { RecipeId = 88, IngredientId = 47, Quantity = 30, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 88, IngredientId = 11, Quantity = 1, MeasurementUnit = "pitada(s)" },
                new RecipeIngredient { RecipeId = 88, IngredientId = 5, Quantity = 1, MeasurementUnit = "colher(es) de sopa" },
                new RecipeIngredient { RecipeId = 88, IngredientId = 54, Quantity = 1, MeasurementUnit = "dente(s)" },
                new RecipeIngredient { RecipeId = 88, IngredientId = 33, Quantity = 1, MeasurementUnit = "unidade(s)" },

                // Koshari (89)
                new RecipeIngredient { RecipeId = 89, IngredientId = 22, Quantity = 200, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 89, IngredientId = 97, Quantity = 200, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 89, IngredientId = 73, Quantity = 150, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 89, IngredientId = 2, Quantity = 300, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 89, IngredientId = 24, Quantity = 1, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 89, IngredientId = 54, Quantity = 2, MeasurementUnit = "dente(s)" },
                new RecipeIngredient { RecipeId = 89, IngredientId = 5, Quantity = 2, MeasurementUnit = "colher(es) de sopa" },

                // Bunny Chow (90)
                new RecipeIngredient { RecipeId = 90, IngredientId = 99, Quantity = 1, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 90, IngredientId = 13, Quantity = 300, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 90, IngredientId = 2, Quantity = 200, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 90, IngredientId = 24, Quantity = 1, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 90, IngredientId = 78, Quantity = 1, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 90, IngredientId = 5, Quantity = 1, MeasurementUnit = "colher(es) de sopa" },
                new RecipeIngredient { RecipeId = 90, IngredientId = 22, Quantity = 150, MeasurementUnit = "grama(s)" },

                // Fish and Chips (91)
                new RecipeIngredient { RecipeId = 91, IngredientId = 108, Quantity = 400, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 91, IngredientId = 44, Quantity = 200, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 91, IngredientId = 8, Quantity = 1, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 91, IngredientId = 88, Quantity = 600, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 91, IngredientId = 65, Quantity = 1000, MeasurementUnit = "ml" },
                new RecipeIngredient { RecipeId = 91, IngredientId = 112, Quantity = 50, MeasurementUnit = "ml" },
                new RecipeIngredient { RecipeId = 91, IngredientId = 11, Quantity = 1, MeasurementUnit = "pitada(s)" },

                // Doro Wat (92)
                new RecipeIngredient { RecipeId = 92, IngredientId = 20, Quantity = 800, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 92, IngredientId = 24, Quantity = 3, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 92, IngredientId = 109, Quantity = 20, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 92, IngredientId = 54, Quantity = 4, MeasurementUnit = "dente(s)" },
                new RecipeIngredient { RecipeId = 92, IngredientId = 47, Quantity = 50, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 92, IngredientId = 8, Quantity = 3, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 92, IngredientId = 5, Quantity = 2, MeasurementUnit = "colher(es) de sopa" },

                // Jerk Chicken (93)
                new RecipeIngredient { RecipeId = 93, IngredientId = 20, Quantity = 800, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 93, IngredientId = 110, Quantity = 10, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 93, IngredientId = 113, Quantity = 2, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 93, IngredientId = 54, Quantity = 3, MeasurementUnit = "dente(s)" },
                new RecipeIngredient { RecipeId = 93, IngredientId = 33, Quantity = 1, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 93, IngredientId = 5, Quantity = 2, MeasurementUnit = "colher(es) de sopa" },
                new RecipeIngredient { RecipeId = 93, IngredientId = 11, Quantity = 1, MeasurementUnit = "pitada(s)" },

                // Khachapuri (94)
                new RecipeIngredient { RecipeId = 94, IngredientId = 111, Quantity = 300, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 94, IngredientId = 44, Quantity = 300, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 94, IngredientId = 8, Quantity = 2, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 94, IngredientId = 47, Quantity = 30, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 94, IngredientId = 45, Quantity = 100, MeasurementUnit = "ml" },
                new RecipeIngredient { RecipeId = 94, IngredientId = 5, Quantity = 1, MeasurementUnit = "colher(es) de sopa" },
                new RecipeIngredient { RecipeId = 94, IngredientId = 39, Quantity = 5, MeasurementUnit = "grama(s)" },

                // Adobo (95)
                new RecipeIngredient { RecipeId = 95, IngredientId = 20, Quantity = 600, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 95, IngredientId = 69, Quantity = 80, MeasurementUnit = "ml" },
                new RecipeIngredient { RecipeId = 95, IngredientId = 112, Quantity = 100, MeasurementUnit = "ml" },
                new RecipeIngredient { RecipeId = 95, IngredientId = 54, Quantity = 3, MeasurementUnit = "dente(s)" },
                new RecipeIngredient { RecipeId = 95, IngredientId = 24, Quantity = 1, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 95, IngredientId = 5, Quantity = 1, MeasurementUnit = "colher(es) de sopa" },
                new RecipeIngredient { RecipeId = 95, IngredientId = 11, Quantity = 1, MeasurementUnit = "pitada(s)" },

                // Fesenjan (96)
                new RecipeIngredient { RecipeId = 96, IngredientId = 20, Quantity = 500, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 96, IngredientId = 114, Quantity = 200, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 96, IngredientId = 115, Quantity = 120, MeasurementUnit = "ml" },
                new RecipeIngredient { RecipeId = 96, IngredientId = 24, Quantity = 1, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 96, IngredientId = 54, Quantity = 2, MeasurementUnit = "dente(s)" },
                new RecipeIngredient { RecipeId = 96, IngredientId = 5, Quantity = 2, MeasurementUnit = "colher(es) de sopa" },
                new RecipeIngredient { RecipeId = 96, IngredientId = 39, Quantity = 10, MeasurementUnit = "grama(s)" },

                // Pierogi (97)
                new RecipeIngredient { RecipeId = 97, IngredientId = 44, Quantity = 300, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 97, IngredientId = 88, Quantity = 400, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 97, IngredientId = 93, Quantity = 200, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 97, IngredientId = 8, Quantity = 1, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 97, IngredientId = 45, Quantity = 50, MeasurementUnit = "ml" },
                new RecipeIngredient { RecipeId = 97, IngredientId = 47, Quantity = 30, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 97, IngredientId = 11, Quantity = 1, MeasurementUnit = "pitada(s)" },

                // Poke Bowl (98)
                new RecipeIngredient { RecipeId = 98, IngredientId = 36, Quantity = 200, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 98, IngredientId = 34, Quantity = 150, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 98, IngredientId = 35, Quantity = 1, MeasurementUnit = "folha(s)" },
                new RecipeIngredient { RecipeId = 98, IngredientId = 79, Quantity = 10, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 98, IngredientId = 69, Quantity = 30, MeasurementUnit = "ml" },
                new RecipeIngredient { RecipeId = 98, IngredientId = 32, Quantity = 1, MeasurementUnit = "punhado(s)" },
                new RecipeIngredient { RecipeId = 98, IngredientId = 33, Quantity = 1, MeasurementUnit = "unidade(s)" },

                // Pastel de Nata (99)
                new RecipeIngredient { RecipeId = 99, IngredientId = 53, Quantity = 1, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 99, IngredientId = 8, Quantity = 4, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 99, IngredientId = 45, Quantity = 200, MeasurementUnit = "ml" },
                new RecipeIngredient { RecipeId = 99, IngredientId = 39, Quantity = 120, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 99, IngredientId = 40, Quantity = 1, MeasurementUnit = "colher(es) de chá" },
                new RecipeIngredient { RecipeId = 99, IngredientId = 47, Quantity = 20, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 99, IngredientId = 68, Quantity = 1, MeasurementUnit = "colher(es) de chá" },

                // Fufu com Ensopado de Amendoim (100)
                new RecipeIngredient { RecipeId = 100, IngredientId = 52, Quantity = 500, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 100, IngredientId = 62, Quantity = 150, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 100, IngredientId = 13, Quantity = 300, MeasurementUnit = "grama(s)" },
                new RecipeIngredient { RecipeId = 100, IngredientId = 24, Quantity = 1, MeasurementUnit = "unidade(s)" },
                new RecipeIngredient { RecipeId = 100, IngredientId = 54, Quantity = 2, MeasurementUnit = "dente(s)" },
                new RecipeIngredient { RecipeId = 100, IngredientId = 5, Quantity = 2, MeasurementUnit = "colher(es) de sopa" },
                new RecipeIngredient { RecipeId = 100, IngredientId = 32, Quantity = 1, MeasurementUnit = "punhado(s)" }
            );
        }
    }
}