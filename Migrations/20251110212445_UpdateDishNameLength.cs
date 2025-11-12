using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace foodboxd_backend.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDishNameLength : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Dishes",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(30)",
                oldMaxLength: 30)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Dishes",
                columns: new[] { "DishId", "Description", "Name", "Photo" },
                values: new object[,]
                {
                    { 11, "Sobremesa clássica francesa com creme aveludado e cobertura crocante de açúcar queimado.", "Creme Brûlée", "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                    { 12, "Salada leve do Oriente Médio, à base de trigo para quibe (bulgur), ervas frescas, tomate e limão.", "Tabule", "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                    { 13, "Panquecas fofas de banana, simples e reconfortantes, servidas com manteiga ou mel.", "Panqueca de Banana", "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                    { 14, "Ensopado brasileiro de peixe cozido em leite de coco, tomate, cebola e coentro.", "Moqueca de Peixe", "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                    { 15, "Doce brasileiro cremoso à base de leite condensado e chocolate, enrolado em bolinhas cobertas com granulado.", "Brigadeiro", "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                    { 16, "Ensopado cremoso brasileiro feito com camarão, mandioca e leite de coco, aromatizado com coentro.", "Bobó de Camarão", "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                    { 17, "Torta salgada francesa recheada com bacon, queijo e creme, de textura firme e sabor levemente amanteigado.", "Quiche Lorraine", "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                    { 18, "Pão crocante coberto por uma mistura aromática de manteiga, alho e ervas, perfeito como acompanhamento para churrascos.", "Pão de Alho e Ervas", "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                    { 19, "Prato refrescante de origem peruana: cubos de salmão marinados em limão com cebola, coentro e pimenta.", "Ceviche de Salmão", "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                    { 20, "Sobremesa em camadas com biscoito, creme de chocolate e leite condensado, servida gelada.", "Pavê de Chocolate", "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                    { 21, "Prato tradicional brasileiro à base de feijão preto, carnes salgadas e acompanhamentos como arroz e farofa.", "Feijoada", "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                    { 22, "Bolinho frito de feijão-fradinho recheado com vatapá e camarão, típico da culinária baiana.", "Acarajé", "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                    { 23, "Creme rico e aromático à base de pão, camarão, leite de coco, azeite de dendê e amendoim, servido com arroz ou acarajé.", "Vatapá", "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                    { 24, "Prato rural de arroz com carne seca e linguiça, saboroso e pronto para aproveitar sobras de carne.", "Arroz Carreteiro", "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                    { 25, "Clássico nordestino que combina arroz e feijão de corda com queijo coalho e temperos, cremoso e nutritivo.", "Baião de Dois", "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                    { 26, "Purê de mandioca cobrindo um recheio suculento de carne seca desfiada, gratinado com queijo.", "Escondidinho de Carne Seca", "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                    { 27, "Peça nobre do churrasco brasileiro, temperada e assada até formar crosta dourada e suculenta por dentro.", "Picanha Assada", "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                    { 28, "Salgado frito recheado (carne, queijo ou outros), crocante por fora e muito popular em feiras e lanchonetes.", "Pastel de Feira", "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                    { 29, "Salgadinho de massa de farinha recheado com frango desfiado, empanado e frito até ficar dourado.", "Coxinha", "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                    { 30, "Sobremesa cremosa feita com milho branco, leite de coco, leite condensado e canela, servida gelada ou morna.", "Canjica", "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                    { 31, "Clássico prato de macarrão tailandês, sabor agridoce com amendoim e limão.", "Pad Thai", "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                    { 32, "Sopa japonesa reconfortante com caldo aromático, noodles e toppings variados.", "Ramen", "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                    { 33, "Prato chinês apimentado e agridoce com pedaços de frango empanados e molho caramelizado.", "Frango General Tso", "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                    { 34, "Pastelzinho japonês recheado, levemente dourado e servido com molho shoyu.", "Gyoza", "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                    { 35, "Prato coreano colorido com arroz, legumes, carne e ovo, servido com óleo de gergelim.", "Bibimbap", "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                    { 36, "Curry aromático com leite de coco, ervas e pimenta, geralmente servido com arroz.", "Curry Verde Tailandês", "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                    { 37, "Peito de frango glaceado em molho teriyaki, levemente adocicado e brilhante.", "Frango Teriyaki", "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                    { 38, "Receita indiana cremosa com molho à base de tomate, especiarias e manteiga.", "Frango Manteiga (Butter Chicken)", "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                    { 39, "Prato picante chinês com tofu macio e carne em molho apimentado e aromático.", "Mapo Tofu", "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                    { 40, "Carne bovina marinada e grelhada no estilo coreano, saborosa e levemente adocicada.", "Bulgogi", "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                    { 41, "Ensopado francês de carne cozida lentamente em vinho tinto, com bacon, cebolas e ervas.", "Beef Bourguignon", "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                    { 42, "Sobremesa italiana clássica feita com camadas de biscoito embebido em café, creme de mascarpone e cacau.", "Tiramisù", "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                    { 43, "Massa italiana com molho robusto de tomate, azeitonas, alcaparras e alho.", "Pasta Puttanesca", "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                    { 44, "Ícone espanhol de arroz com frutos do mar, açafrão e pimentões, cozido em uma panela larga.", "Paella Valenciana", "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                    { 45, "Assado grego em camadas de berinjela, carne temperada e molho cremoso, gratinado com queijo.", "Moussaka", "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                    { 46, "Nhoques leves feitos com batata e farinha, servidos com manteiga ou molho de sua preferência.", "Gnocchi de Batata", "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                    { 47, "Guarnição francesa de legumes (berinjela, pimentão, tomate) lentamente cozidos com ervas.", "Ratatouille", "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                    { 48, "Entrada italiana simples: pão tostado com tomate fresco, alho e manjericão.", "Bruschetta al Pomodoro", "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                    { 49, "Sopa de peixe tradicional de Marselha, rica em sabores do mar e temperos como açafrão.", "Bouillabaisse", "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                    { 50, "Risoto italiano aromatizado com açafrão, cremoso e finalizado com queijo parmesão.", "Risotto alla Milanese", "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                    { 51, "Torta invertida de maçã caramelizada, servida quente com crosta amanteigada.", "Tarte Tatin", "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                    { 52, "Sobremesa italiana cremosa feita com creme de leite, açúcar e gelatina, aromatizada com baunilha.", "Panna Cotta", "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                    { 53, "Cheesecake clássico com base de biscoito e recheio cremoso de cream cheese.", "New York Cheesecake", "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                    { 54, "Merengue crocante por fora e macio por dentro, servido com chantilly e frutas vermelhas.", "Pavlova de Frutas Vermelhas", "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                    { 55, "Torta de maçã tradicional com massa amanteigada e recheio levemente caramelizado.", "Apple Pie", "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                    { 56, "Bolinh0s de massa choux recheados, servidos com molho quente de chocolate.", "Profiteroles com Chocolate", "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                    { 57, "Petit gateau com interior cremoso de chocolate derretido; servido quente.", "Chocolate Fondant (Lava Cake)", "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                    { 58, "Tarte de limão com recheio cítrico e massa amanteigada, finalizada com merengue ou creme.", "Tarte de Limão", "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                    { 59, "Sorvete cremoso de baunilha, textura densa e sabor puro de baunilha.", "Gelato de Baunilha", "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                    { 60, "Creme espanhol semelhante ao crème brûlée, coberto por uma crosta de açúcar queimado.", "Crème Catalane", "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                    { 61, "Típica da Venezuela e Colômbia, massa de milho grelhada ou frita, geralmente recheada com queijo ou carnes.", "Arepa", "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                    { 62, "Bolinho frito de grão-de-bico temperado, servido em pão sírio com tahine e salada.", "Falafel Wrap", "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                    { 63, "Sanduíche vietnamita em baguete crocante, com carne marinada, vegetais em conserva e ervas frescas.", "Bánh Mì", "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                    { 64, "Salgado frito típico do Sul da Ásia: massa crocante recheada com batata temperada e ervilhas.", "Samosa", "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                    { 65, "Clássico brasileiro em formato de bolinha, leve e borrachudo, feito com polvilho e queijo.", "Pão de Queijo", "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                    { 66, "Pastel assado ou frito recheado com carne temperada, muito popular como comida de rua na Argentina.", "Empanada Argentina", "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                    { 67, "Carne temperada fatiada servida em pão sírio com molhos e vegetais - clássico do Oriente Médio.", "Shawarma", "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                    { 68, "Doce frito em massa simples polvilhado com açúcar e canela, frequentemente servido com chocolate.", "Churros", "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                    { 69, "Pãozinho chinês cozido no vapor, macio e levemente adocicado, geralmente recheado com carne ou legumes.", "Bao Bun", "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                    { 70, "Especialidade de El Salvador: tortilla grossa de milho recheada com queijo e feijão, grelhada até dourar.", "Pupusa", "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                    { 71, "Salada fresca e colorida com tomate, pepino, azeitonas e queijo feta, temperada com azeite e orégãos.", "Salada Grega", "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                    { 72, "Ensopado de tomates e pimentões com ovos pochê, temperado com alho e especiarias, típico do Mediterrâneo oriental.", "Shakshuka", "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                    { 73, "Berinjela grelhada servida com molho de tahine, alho e limão, ótima como entrada ou acompanhamento.", "Berinjela Assada com Tahine", "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                    { 74, "Peito de frango marinado em ervas e limão, assado até ficar dourado e suculento.", "Frango Assado ao Limão e Ervas", "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                    { 75, "Mexilhões cozidos em caldo aromático de vinho branco, alho e ervas, servidos com pão.", "Mexilhões ao Alho e Vinho Branco", "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                    { 76, "Pastinha cremosa de grão-de-bico e tahine servida com pão sírio aquecido e azeite.", "Hummus com Pão Sírio", "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                    { 77, "Patê rústico de azeitonas e alcaparras, perfeito para barrar em fatias de baguete torradas.", "Tapenade de Azeitonas com Baguete", "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                    { 78, "Queijo feta assado com tomates, alho e ervas, servido quente com pão crocante.", "Feta Assado com Tomates", "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                    { 79, "Batatas assadas com limão, alho e ervas aromáticas, crocantes por fora e macias por dentro.", "Batatas Gregas ao Limão e Ervas", "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                    { 80, "Pimentões assados recheados com bulgur temperado, tomate, ervas e queijo feta.", "Pimentões Recheados com Bulgur", "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                    { 81, "Arroz aromático rico em tomate e especiarias, clássico de vários países da África Ocidental, normalmente servido com carne ou frango.", "Jollof Rice", "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                    { 82, "Prato sul-africano assado com carne temperada, camada de ovos e leite formando uma textura cremosa por cima, levemente adocicado com especiarias.", "Bobotie", "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                    { 83, "Espetinhos de carne secos e bem temperados com mistura de amendoim e especiarias, grelhados até ficarem crocantes nas bordas.", "Suya", "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                    { 84, "Ensopado marroquino de carne e especiarias, cozido lentamente com legumes até o molho ficar concentrado e aromático.", "Tagine de Carne", "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                    { 85, "Prato senegalês de frango marinado em cebola e limão, lentamente cozido até ficar suculento e com sabor ácido e levemente caramelizado.", "Poulet Yassa", "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                    { 86, "Camarões temperados com piri-piri e alho, grelhados rapidamente e servidos com molho picante e limão.", "Piri-Piri Camarão", "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                    { 87, "Fritos doces do Leste Africano, semelhantes a donuts leves e aromáticos, perfeitos como lanche ou sobremesa.", "Mandazi", "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                    { 88, "Papa de farinha de milho (ou fubá) tradicional, acompanhamento simples e reconfortante consumido em várias regiões da África.", "Pap (Ugali)", "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                    { 89, "Mistura egípcia de arroz, macarrão e grão-de-bico, servida com molho de tomate picante e cebola crocante por cima.", "Koshari", "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                    { 90, "Pão oco recheado com curry rico e picante — um clássico de Durban com raízes indianas e africanas.", "Bunny Chow", "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                    { 91, "Clássico britânico: filé de peixe empanado e frito servido com batatas fritas crocantes e vinagre para acompanhar.", "Fish and Chips", "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                    { 92, "Ensopado etíope de frango com berbere e cebolas caramelizadas, servido tradicionalmente com injera.", "Doro Wat", "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                    { 93, "Frango jamaicano marinado em especiarias e pimenta, grelhado até ficar defumado e aromático.", "Jerk Chicken", "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                    { 94, "Especialidade georgiana: pão recheado generosamente com queijo derretido e ovo no centro.", "Khachapuri", "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                    { 95, "Carne marinada em vinagre e molho de soja, cozida até ficar macia e rica em sabor; prato essencial filipino.", "Adobo (Filipinas)", "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                    { 96, "Ensopado persa rico com nozes e molho de romã, complexo e aveludado, tradicionalmente servido com arroz.", "Fesenjan", "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                    { 97, "Bolinho polonês recheado (batata e queijo ou outras variações), cozido e por vezes dourado na manteiga; reconfortante e versátil.", "Pierogi", "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                    { 98, "Tigela havaiana com peixe cru marinado, arroz, algas e acompanhamentos frescos; leve e customizável.", "Poke Bowl", "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                    { 99, "Doce português: creme de ovos sobre massa folhada crocante, polvilhado levemente com canela e servido quente.", "Pastel de Nata", "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" },
                    { 100, "Papa de mandioca servida com um ensopado rico de amendoim e carne, muito comum em várias cozinhas da África Ocidental.", "Fufu com Ensopado de Amendoim", "https://res.cloudinary.com/dslsxyvkp/image/upload/pizza_marguerita_so8rnj.png" }
                });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "IngredientId", "Name" },
                values: new object[,]
                {
                    { 40, "Baunilha" },
                    { 41, "Bulgur (Trigo para Kibe)" },
                    { 42, "Salsinha" },
                    { 43, "Hortelã" },
                    { 44, "Farinha de Trigo" },
                    { 45, "Leite" },
                    { 46, "Banana" },
                    { 47, "Manteiga" },
                    { 48, "Leite de Coco" },
                    { 49, "Pimentão" },
                    { 50, "Leite Condensado" },
                    { 51, "Camarão" },
                    { 52, "Mandioca (Aipim)" },
                    { 53, "Massa Folhada" },
                    { 54, "Alho" },
                    { 55, "Biscoito (Maizena)" },
                    { 56, "Feijão Preto" },
                    { 57, "Azeite de Dendê" },
                    { 58, "Carne Seca" },
                    { 59, "Linguiça" },
                    { 60, "Farinha de Mandioca" },
                    { 61, "Feijão-Fradinho" },
                    { 62, "Amendoim" },
                    { 63, "Queijo Coalho" },
                    { 64, "Picanha" },
                    { 65, "Óleo para Fritura" },
                    { 66, "Feijão de Corda" },
                    { 67, "Milho para Canjica" },
                    { 68, "Canela" },
                    { 69, "Molho de Soja" },
                    { 70, "Gengibre" },
                    { 71, "Óleo de Gergelim" },
                    { 72, "Cebolinha" },
                    { 73, "Noodles (Macarrão Asiático)" },
                    { 74, "Curry em Pó" },
                    { 75, "Tofu" },
                    { 76, "Molho de Peixe" },
                    { 77, "Mirin" },
                    { 78, "Pimenta Dedo-de-Moça" },
                    { 79, "Sementes de Gergelim" },
                    { 80, "Shiitake" },
                    { 81, "Vinho Tinto" },
                    { 82, "Mascarpone" },
                    { 83, "Azeitonas" },
                    { 84, "Alcaparras" },
                    { 85, "Açafrão" },
                    { 86, "Mexilhão" },
                    { 87, "Berinjela" },
                    { 88, "Batata" },
                    { 89, "Tomilho" },
                    { 90, "Alecrim" },
                    { 91, "Café" },
                    { 92, "Frutas Vermelhas" },
                    { 93, "Cream Cheese" },
                    { 94, "Gelatina" },
                    { 95, "Maçã" },
                    { 96, "Farinha de Milho" },
                    { 97, "Grão-de-bico" },
                    { 98, "Tahine" },
                    { 99, "Baguete" },
                    { 100, "Polvilho Doce" },
                    { 101, "Ervilha" },
                    { 102, "Pão Sírio" },
                    { 103, "Queijo Feta" },
                    { 104, "Pepino" },
                    { 105, "Quiabo" },
                    { 106, "Cuscuz" },
                    { 107, "Iogurte" },
                    { 108, "Peixe Branco" },
                    { 109, "Berbere (tempero)" },
                    { 110, "Allspice (Pimenta-da-Jamaica)" },
                    { 111, "Queijo Sulguni" },
                    { 112, "Vinagre" },
                    { 113, "Pimenta Scotch Bonnet" },
                    { 114, "Noz (Walnut)" },
                    { 115, "Molho de Romã" }
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "RecipeId", "DishId", "Instructions" },
                values: new object[,]
                {
                    { 11, 11, "Aqueça o forno a 150°C. Misture gemas com açúcar até ficar cremoso e acrescente o creme de leite e a baunilha; coe. Distribua em ramequins e asse em banho-maria por cerca de 35-40 minutos, até firmar nas bordas e ficar levemente tremido no centro. Resfrie, leve à geladeira por algumas horas e, na hora de servir, polvilhe açúcar por cima e queime com maçarico até formar uma crosta dourada." },
                    { 12, 12, "Hidrate o bulgur em água por alguns minutos e escorra bem. Pique tomate, cebola, salsinha e hortelã em pedaços pequenos. Misture tudo em uma tigela, tempere com suco de limão, azeite, sal e pimenta. Ajuste acidez e sirva bem frio como acompanhamento ou entrada." },
                    { 13, 13, "Amasse as bananas e misture com ovo, leite, farinha e açúcar até formar uma massa homogênea. Aqueça uma frigideira com manteiga, coloque porções da massa e frite até dourar dos dois lados. Sirva quente com fatias de banana ou mel." },
                    { 14, 14, "Tempere o peixe com sal e limão. Em uma panela, refogue cebola e pimentão no azeite, acrescente tomates picados e deixe apurar. Junte o peixe, o leite de coco e cozinhe em fogo baixo até o peixe ficar macio. Finalize com coentro fresco picado e sirva com arroz branco." },
                    { 15, 15, "Em uma panela, misture o leite condensado, o chocolate picado e a manteiga. Cozinhe em fogo médio, mexendo sempre, até desgrudar do fundo (ponto de brigadeiro). Deixe esfriar, enrole em bolinhas e passe no granulado, ou sirva em copinhos como brigadeiro de colher." },
                    { 16, 16, "Cozinhe a mandioca até ficar macia e reserve. Refogue cebola e alho no azeite, acrescente o camarão e cozinhe rapidamente. Bata a mandioca com parte do caldo no liquidificador até obter um creme e volte à panela. Junte o leite de coco, o camarão refogado e ajuste o sal. Finalize com coentro picado e sirva quente." },
                    { 17, 17, "Forre uma forma com massa folhada, bata ovos com creme de leite, adicione bacon frito e queijo ralado, tempere com sal e pimenta. Despeje o recheio sobre a massa e asse em forno pré-aquecido a 180°C por cerca de 30-40 minutos, até firmar e dourar levemente." },
                    { 18, 18, "Misture manteiga amolecida com alho picado, salsinha, sal e pimenta até formar uma pasta. Corte o pão em fatias ou abra um pão grande, espalhe a mistura entre as fatias e por cima. Leve ao forno para gratinar até ficar dourado e crocante." },
                    { 19, 19, "Corte o salmão em cubos pequenos e coloque em uma tigela. Adicione suco de limão suficiente para cobrir o peixe, junte cebola roxa fatiada, pimenta picada e coentro. Deixe marinar por 10-20 minutos até o peixe firmar. Sirva gelado com fatias de limão." },
                    { 20, 20, "Intercale camadas de biscoito embebido no leite com camadas de creme feito com chocolate derretido e leite condensado. Repita as camadas, finalize com raspas de chocolate e leve à geladeira por pelo menos 4 horas antes de servir." },
                    { 21, 21, "Deixe o feijão preto de molho e cozinhe até ficar macio. Cozinhe separadamente as carnes salgadas e linguiça; junte ao feijão e cozinhe lentamente até apurar. Sirva com arroz branco, couve refogada e farofa de farinha de mandioca." },
                    { 22, 22, "Prepare uma massa com feijão-fradinho cozido e amassado; modele bolinhos e frite em óleo quente. Recheie com vatapá e camarão refogado; sirva quente com pimenta e salada." },
                    { 23, 23, "Refogue cebola e alho, junte pão amanhecido, amendoim e camarão seco. Bata com leite de coco e azeite de dendê até formar um creme. Ajuste sal e pimenta e sirva com arroz branco ou como recheio de acarajé." },
                    { 24, 24, "Corte a carne seca em cubos e refogue com linguiça e cebola. Acrescente arroz lavado e água quente, cozinhe até o arroz absorver o caldo. Ajuste temperos e finalize com cheiro-verde." },
                    { 25, 25, "Cozinhe o feijão de corda separadamente até ficar macio. Refogue cebola e alho, junte arroz e o feijão, adicione pedaços de queijo coalho e manteiga e mexa até ficar cremoso. Sirva quente como prato principal." },
                    { 26, 26, "Cozinhe a mandioca e bata em purê. Refogue a carne seca desfiada com cebola e temperos. Monte em camadas: purê por cima da carne, salpique queijo coalho e leve ao forno para gratinar até dourar." },
                    { 27, 27, "Tempere a picanha com sal grosso e deixe descansar. Asse em churrasqueira ou forno em temperatura alta, virando para formar uma crosta dourada. Fatie e sirva suculenta, acompanhe com farofa e vinagrete." },
                    { 28, 28, "Prepare uma massa leve com farinha e água; abra, recheie com carne moída refogada ou queijo e feche. Frite em óleo abundante até dourar e escorra em papel absorvente. Sirva quente." },
                    { 29, 29, "Cozinhe e desfie o peito de frango, refogue com cebola e temperos. Faça uma massa com farinha e caldo, molde em forma de coxinha, recheie com frango, empane na farinha de rosca e frite até dourar." },
                    { 30, 30, "Cozinhe o milho para canjica até ficar macio. Misture com leite de coco, leite condensado, açúcar e canela. Cozinhe em fogo baixo até engrossar; sirva quente ou gelado, polvilhado com canela." },
                    { 31, 31, "Cozinhe os noodles conforme instruções. Em wok, refogue gengibre e alho, acrescente tofu e camarão até cozinhar. Misture os noodles com molho de soja e amendoim picado. Finalize com suco de limão e cebolinha antes de servir." },
                    { 32, 32, "Prepare um caldo aromático com caldo de legumes e molho de soja. Cozinhe noodles no caldo, adicione shiitake fatiado e finalize com ovo cozido e cebolinha fatiada. Sirva quente." },
                    { 33, 33, "Tempere pedaços de frango, empane levemente e frite até dourar. Em uma panela, faça um molho com gengibre, alho, molho de soja e açúcar; reduza até engrossar e junte o frango frito para caramelizar. Sirva quente." },
                    { 34, 34, "Misture carne moída com cebolinha, gengibre e alho. Recheie pequenas folhas de massa (ou massa folhada fina), feche formando pastéis e doure em frigideira ou frite. Sirva com molho de soja." },
                    { 35, 35, "Grelhe fatias finas de carne temperada. Em uma tigela, coloque arroz quente, legumes salteados, fatias de carne e ovo frito por cima. Tempere com óleo de gergelim e molho de soja antes de misturar e comer." },
                    { 36, 36, "Refogue pasta de curry com um pouco de óleo, acrescente pedaços de frango e pimentão. Despeje leite de coco e deixe cozinhar em fogo baixo até o frango ficar macio e o molho incorporar. Sirva com arroz." },
                    { 37, 37, "Marine o frango em molho de soja, mirin, gengibre e açúcar. Grelhe ou frite até caramelizar e pincele com o restante da marinada reduzida. Sirva com cebolinha por cima." },
                    { 38, 38, "Refogue alho e gengibre na manteiga, junte pedaços de frango e tomates. Adicione creme de leite e curry em pó, cozinhe até obter um molho cremoso e sirva com arroz basmati ou pão." },
                    { 39, 39, "Refogue carne moída com alho e gengibre, acrescente tofu em cubos e molho de soja. Cozinhe até o tofu absorver sabores; finalize com óleo de gergelim e cebolinha picada." },
                    { 40, 40, "Marine a carne em molho de soja, açúcar, gengibre e óleo de gergelim por pelo menos 30 minutos. Grelhe em fogo alto rapidamente para selar e sirva fatiada, com cebolinha por cima." },
                    { 41, 41, "Corte a carne em cubos grandes e doure com bacon. Adicione cebola, refogue, polvilhe um pouco de farinha, junte vinho tinto e caldo, tempere com tomilho e cozinhe lentamente até a carne ficar macia. Sirva com batatas." },
                    { 42, 42, "Bata as gemas com açúcar até ficarem claras e cremosas, misture o mascarpone. Umedeça levemente os biscoitos no café e monte camadas intercalando com o creme. Polvilhe cacau e refrigere por algumas horas antes de servir." },
                    { 43, 43, "Cozinhe a massa até ficar al dente. Em uma frigideira, refogue alho no azeite, acrescente molho de tomate, azeitonas e alcaparras; misture com a massa e sirva imediatamente." },
                    { 44, 44, "Refogue cebola e pimentão, adicione arroz e açafrão, regue com vinho branco e caldo. Cozinhe sem mexer demais e adicione frutos do mar, como mexilhões, nos minutos finais até tudo cozinhar por igual." },
                    { 45, 45, "Grelhe fatias de berinjela até dourar. Faça um ragu com carne moída, cebola e tomate. Monte camadas de berinjela e ragu, cubra com molho branco e leve ao forno até gratinar." },
                    { 46, 46, "Cozinhe as batatas até ficarem macias, amasse bem e misture com farinha e ovo até formar uma massa. Modele os nhoques e cozinhe em água fervente até subirem. Sirva com manteiga e parmesão ralado." },
                    { 47, 47, "Corte berinjela, pimentão, tomate e cebola em pedaços uniformes. Refogue separadamente e depois junte tudo com ervas (tomilho, alecrim) e azeite. Cozinhe até os legumes ficarem macios e bem temperados." },
                    { 48, 48, "Toste fatias de pão até ficarem crocantes. Esfregue um dente de alho, cubra com tomate picado, folhas de manjericão e regue com azeite de oliva; sirva imediatamente." },
                    { 49, 49, "Refogue cebola e alho, junte tomate e vinho branco, acrescente uma variedade de peixes e mexilhões. Cozinhe até os frutos do mar estarem cozidos e sirva com fatias de pão." },
                    { 50, 50, "Refogue cebola na manteiga, acrescente o arroz arbóreo e uma taça de vinho branco. Aos poucos, adicione caldo com açafrão, mexendo sempre até o arroz ficar cremoso. Finalize com manteiga e parmesão ralado." },
                    { 51, 51, "Descasque e corte maçãs em quartos. Caramelize açúcar e manteiga na frigideira, disponha as maçãs e cozinhe até amaciar. Cubra com massa e asse até dourar; desenforme morno para servir." },
                    { 52, 52, "Aqueça creme de leite com açúcar e baunilha. Hidrate gelatina, dissolva no creme quente, distribua em formas e refrigere até firmar. Sirva com calda de frutas se desejar." },
                    { 53, 53, "Triture biscoitos e misture com manteiga derretida para a base; pressione na forma. Misture cream cheese com açúcar, ovos e baunilha, despeje sobre a base e asse até firmar. Resfrie antes de desenformar." },
                    { 54, 54, "Bata claras em neve com açúcar até formar suspiro firme. Asse merengues em baixa temperatura até secar. Monte com chantilly e frutas vermelhas por cima antes de servir." },
                    { 55, 55, "Corte maçãs em fatias e misture com açúcar e canela. Forre forma com massa, recheie com as maçãs e cubra. Asse até a massa dourar e o recheio borbulhar." },
                    { 56, 56, "Prepare massa choux com farinha, ovos e manteiga; forme pequenas porções e asse até inflar. Recheie com creme e regue com molho quente de chocolate feito com chocolate e creme de leite." },
                    { 57, 57, "Derreta chocolate com manteiga. Misture ovos, açúcar e um pouco de farinha; incorpore o chocolate derretido. Asse em forminhas individuais pouco tempo para obter o interior cremoso." },
                    { 58, 58, "Prepare massa quebrada e asse parcialmente. Faça um creme de limão com suco e raspas, ovos e açúcar; asse sobre a massa até firmar. Resfrie e sirva gelado ou com merengue." },
                    { 59, 59, "Aqueça leite, creme e baunilha até quase ferver, mexendo para dissolver o açúcar; resfrie a mistura rapidamente antes de levar à sorveteira. Bata na sorveteira até obter textura cremosa e transfira para o congelador por algumas horas para firmar. Sirva em bolas suaves, puro ou acompanhado de caldas e frutas frescas para contraste." },
                    { 60, 60, "Aqueça leite com canela e casca de limão para infundir aroma; bata gemas com açúcar até clarear e, aos poucos, incorpore o leite quente, mexendo sem parar. Cozinhe em banho-maria até o creme cobrir as costas da colher e resfrie completamente. Na hora de servir, polvilhe uma camada fina de açúcar e queime para formar a crosta caramelizada característica." },
                    { 61, 61, "Misture farinha de milho com água e sal até formar uma massa maleável; modele discos e cozinhe em chapa ou frigideira até dourarem levemente dos dois lados. Corte as arepas ao meio e recheie com cream cheese ou outro queijo, e, se desejar, peças de carne grelhada. Sirva quentes, aproveitando a textura levemente crocante por fora e macia por dentro." },
                    { 62, 62, "Deixe o grão-de-bico de molho por algumas horas e cozinhe até ficar macio, ou use grão-de-bico enlatado bem escorrido; processe com alho, cebola, cominho e sal até formar uma massa maleável. Modele bolinhos e frite até ficarem dourados e crocantes por fora. Aqueça pão sírio, recheie com os falafels, adicione tahine, folhas de alface e fatias de tomate; sirva imediatamente para manter contraste de texturas." },
                    { 63, 63, "Marine tiras de carne em um molho aromático por pelo menos 30 minutos. Grelhe rapidamente até dourarem e monte a baguete crocante com a carne, cebola levemente em conserva (ou crua), coentro fresco e um fio de azeite. Sirva cortado ao meio para preservar crocância do pão e suculência do recheio." },
                    { 64, 64, "Cozinhe batatas até ficarem macias e amasse; misture com ervilhas cozidas, cebola refogada, especiarias (como cominho e curry em pó) e ajuste sal. Abra porções da massa de farinha, recheie com a mistura e feche formando triângulos; frite em óleo quente até dourar ou asse para versão mais leve. Sirva quente, acompanhando com chutney ou molho picante." },
                    { 65, 65, "Misture polvilho doce com leite, ovos e queijo coalho ralado até obter uma massa pegajosa; modele pequenas bolinhas e asse ou frite até crescerem e formarem casca leve. Sirva quentes, aproveitando o interior elástico e o sabor salgado do queijo; são ótimas como lanche ou acompanhamento." },
                    { 66, 66, "Refogue cebola e alho até ficarem translúcidos; acrescente carne moída e cozinhe até dourar, temperando com páprica, sal e pimenta. Recheie discos de massa folhada com a carne refogada, feche bem e asse até dourarem. Sirva quentes, como lanche prático e saboroso de rua." },
                    { 67, 67, "Tempere a carne em tiras com especiarias e deixe marinar brevemente; grelhe em fogo alto até selar e ficar suculenta. Aqueça o pão sírio e recheie com a carne fatiada, cebola, tahine e folhas frescas, enrolando ou dobrando para servir. A combinação de carne bem temperada e molho cremoso cria o clássico sabor do shawarma." },
                    { 68, 68, "Prepare uma massa simples com farinha, água, ovo e manteiga; cozinhe rapidamente em panela até formar uma pasta e molde tiras compridas. Frite em óleo quente até dourar e escorra em papel; passe no açúcar misturado com canela enquanto ainda estiverem quentes. Sirva com molho de chocolate quente para mergulhar." },
                    { 69, 69, "Misture farinha com leite, ovo e um pouco de fermento (se disponível) até formar uma massa macia; modele bolinhos ou discos e cozinhe no vapor até crescerem e ficarem macios. Corte ao meio e recheie com carne grelhada, vegetais em conserva e molhos à escolha; sirva quente para aproveitar a textura aerada do bao." },
                    { 70, 70, "Misture farinha de milho com água e sal até obter massa maleável; abra discos e recheie com uma mistura de feijão refrito e queijo coalho ralado, fechando e moldando. Grelhe os pupusas em chapa até dourar ambos os lados e o recheio aquecer; sirva quente com curtido e molho de tomate ou pimenta para equilibrar os sabores." },
                    { 71, 71, "Corte tomates e pepino em cubos regulares; fatie a cebola finamente. Em uma tigela grande, misture os tomates, pepino, cebola, azeitonas e pedaços generosos de queijo feta. Tempere com suco de limão fresco, bastante azeite de oliva, orégãos secos, sal e pimenta. Misture delicadamente, ajuste os temperos e sirva imediatamente para manter a textura crocante dos vegetais." },
                    { 72, 72, "Aqueça azeite em uma frigideira larga e refogue cebola e alho até ficarem translúcidos. Adicione pimentões picados e deixe murchar; junte tomates (frescos ou molho de tomate), tempere com sal, pimenta e pimenta dedo-de-moça a gosto e cozinhe em fogo médio até formar um molho espesso. Faça pequenos poços no molho e quebre ovos por cima; tampe e cozinhe até as claras firmarem e as gemas ficarem ao ponto desejado. Polvilhe salsinha por cima e sirva com pão." },
                    { 73, 73, "Corte berinjelas ao meio, faça cortes superficiais na polpa, pincele com azeite e grelhe até ficarem macias e com marcas de grelha. Enquanto isso, misture tahine com suco de limão, um pouco de água para ajustar a textura, alho picado e sal. Regue as berinjelas grelhadas com o molho de tahine, finalize com salsinha picada, um fio de azeite e pimenta moída. Sirva morno ou à temperatura ambiente." },
                    { 74, 74, "Tempere os peitos de frango com suco de limão, alho picado, azeite, ramos de alecrim e tomilho, sal e pimenta; deixe marinar por ao menos 30 minutos. Pré-aqueça o forno e asse o frango até dourar e atingir temperatura interna adequada, regando ocasionalmente com a marinada. Deixe repousar alguns minutos antes de fatiar; sirva com batatas ou salada e regue com o molho formado durante o cozimento." },
                    { 75, 75, "Lave bem os mexilhões e descarte os que estiverem abertos. Em uma panela larga, aqueça azeite e refogue alho e cebola até ficarem translúcidos; acrescente tomates picados e vinho branco, deixe reduzir levemente. Junte os mexilhões, tampe e cozinhe até abrirem (descartar os que não abrirem). Finalize com salsinha picada e sirva com fatias de pão para molhar no caldo aromático." },
                    { 76, 76, "Escorra e cozinhe grão-de-bico até ficar macio (ou use enlatado bem escorrido). Processe o grão-de-bico com tahine, suco de limão, alho, sal e um fio generoso de azeite até obter uma pasta lisa; ajuste a textura com água se necessário. Sirva o hummus regado com azeite extra e acompanhe com pão sírio aquecido e fatias de pepino para frescor." },
                    { 77, 77, "No processador, junte azeitonas sem caroço, alcaparras, alho, salsinha e um fio de azeite; pulse até obter uma pasta rústica. Ajuste sal e acidez se necessário. Fatie a baguete, torre levemente e espalhe a tapenade sobre as fatias antes de servir como aperitivo." },
                    { 78, 78, "Coloque um bloco de queijo feta em uma travessa pequena, disponha tomates cortados ao redor e regue tudo com azeite, alho fatiado e orégãos. Leve ao forno pré-aquecido até os tomates murcharem levemente e o feta aquecer; sirva quente com fatias de baguette para acompanhar e molhar no suco formado." },
                    { 79, 79, "Corte batatas em pedaços médios e tempere com suco de limão, azeite, alho picado, orégãos secos, alecrim, sal e pimenta. Asse em forno quente até ficarem douradas e crocantes por fora, macias por dentro. Sirva imediatamente, finalizando com mais ervas frescas se desejar." },
                    { 80, 80, "Cozinhe bulgur conforme instruções até ficar macio; misture com tomate picado, cebola refogada, salsinha, azeite e pedaços de queijo feta. Recheie pimentões limpos com essa mistura, disponha em um refratário, regue com um fio de azeite e asse até os pimentões ficarem macios e o recheio aquecer. Sirva quente como prato principal leve." },
                    { 81, 81, "Refogue cebola e alho em azeite até amaciarem; adicione tomates picados, pasta de tomate e especiarias, deixando o molho apurar. Junte arroz lavado e caldo quente, misture bem e acrescente pedaços de frango previamente dourados. Cozinhe em fogo médio-baixo, mexendo ocasionalmente, até o arroz absorver os sabores e ficar macio. Ajuste sal e pimenta e sirva com folhas frescas e fatias de limão ao lado." },
                    { 82, 82, "Misture carne moída com cebola picada, alho, curry em pó, pimenta e um pouco de açúcar; coloque em uma travessa untada. Por cima, bata ovos com leite e despeje sobre a carne. Asse em forno médio até a cobertura firmar e dourar levemente. Sirva morno, tradicionalmente acompanhado de arroz e chutney de frutas quando disponível." },
                    { 83, 83, "Corte a carne em tiras finas e tempere com uma mistura de amendoim moído, alho, pimenta e sal; deixe absorver os temperos por pelo menos 30 minutos. Espete as tiras em palitos e grelhe em fogo alto até desenvolver crostas douradas. Sirva com fatias de cebola e rodelas de pepino para refrescar entre as mordidas." },
                    { 84, 84, "Sele a carne em panela ampla, retire e refogue cebola, alho e pimentões até amaciarem. Acrescente tomates, caldo e especiarias (açafrão, cominho), devolva a carne e cozinhe em fogo baixo até ficar macia e o molho reduzir. Finalize com ervas frescas e sirva com cuscuz ou pão para aproveitar o molho." },
                    { 85, 85, "Marine pedaços de frango com suco de limão, alho, pimenta e sal por algumas horas. Refogue uma grande quantidade de cebola até caramelizar levemente, acrescente o frango e cozinhe lentamente no líquido da marinada até ficar suculento e com sabor equilibrado entre ácido e caramelizado. Sirva com arroz ou cuscuz." },
                    { 86, 86, "Tempere camarões limpos com pimenta, alho picado e suco de limão; deixe marinar brevemente. Aqueça azeite em frigideira, frite os camarões rapidamente até ficarem opacos e ligeiramente dourados, regando com a marinada reduzida. Sirva com mais limão e pão para molhar no molho picante." },
                    { 87, 87, "Misture farinha, açúcar, ovo, leite de coco e uma pitada de fermento (se disponível) formando uma massa levemente pegajosa. Modele em porções e frite em óleo quente até dourarem por fora e cozinharem por dentro. Polvilhe açúcar e sirva quentes, acompanhados de chá ou café." },
                    { 88, 88, "Misture farinha de milho com água quente e sal, mexendo até obter uma papa espessa e lisa; cozinhe por alguns minutos, mexendo, até o ponto desejado. Sirva quente com um fio de manteiga ou acompanhando um ensopado rico para absorver o molho." },
                    { 89, 89, "Cozinhe arroz até ficar macio e reserve. Cozinhe grão-de-bico até amaciar. Cozinhe macarrão curto separadamente. Prepare um molho de tomate bem temperado com alho e cebola e ajuste o picante. Monte camadas com arroz, macarrão e grão-de-bico, regando com o molho de tomate e finalizando com cebolas crocantes. Sirva quente, permitindo que cada porção receba molho generoso." },
                    { 90, 90, "Corte uma baguete e retire parte do miolo formando uma cavidade; prepare um curry espesso com carne refogada, tomate e especiarias até reduzir bem. Recheie o pão com o curry quente e sirva imediatamente, acompanhando com arroz ou salada se desejar." },
                    { 91, 91, "Prepare uma massa leve de cerveja ou tempêra (farinha, água/gás, ovo) e tempere o filé de peixe. Corte batatas em palitos regulares e seque bem. Frite as batatas até dourar e reserve. Passe o peixe na massa e frite em óleo quente até a crosta ficar dourada. Sirva o peixe com as batatas, polvilhe sal e ofereça vinagre à parte; sirva quente para manter a crocância." },
                    { 92, 92, "Pique e cozinhe uma grande quantidade de cebolas em fogo baixo até caramelizarem; junte manteiga clarificada e alho. Adicione pedaços de frango e a mistura de berbere, mexendo para cobrir bem; acrescente caldo e cozinhe lentamente até o frango ficar macio e o molho espesso. Cozinhe ovos até o ponto desejado e sirva por cima, decorando com um fio de azeite e fatias de pão injera se quiser uma apresentação tradicional." },
                    { 93, 93, "Marine pedaços de frango com uma mistura de allspice, pimenta, alho, cebola, suco de limão e óleo; deixe marinar por algumas horas. Grelhe em fogo médio-alto até o exterior ficar levemente carbonizado e o interior cozido. Regue com suco de limão extra ao servir e acompanhe com arroz, salada e molhos à base de iogurte para equilibrar o picante." },
                    { 94, 94, "Prepare uma massa de pão relativamente macia com farinha, água, leite e fermento; abra em disco e recheie generosamente com queijo sulguni ralado. Dobre as bordas formando um barco e asse em forno quente até o queijo borbulhar; no final, quebre um ovo no centro e asse rapidamente até a clara firmar. Sirva quente e corte em fatias para compartilhar." },
                    { 95, 95, "Marine pedaços de carne ou frango em uma mistura de molho de soja, vinagre e alho por pelo menos 30 minutos. Refogue alho e cebola, junte a carne com a marinada e cozinhe em fogo baixo até o líquido reduzir e os sabores ficarem concentrados. Sirva com arroz e um pouco de cebolinha picada por cima para frescor." },
                    { 96, 96, "Doure cebola e alho em azeite, acrescente nozes trituradas e deixe tostar levemente; junte pedaços de frango e cubra com caldo. Adicione molho de romã e cozinhe em fogo baixo até o molho engrossar e as nozes estiverem integradas, formando uma textura aveludada. Ajuste sal e acidez e sirva com arroz basmati solto." },
                    { 97, 97, "Cozinhe batatas e amasse até ficarem lisas; misture com queijo (ou cream cheese), tempere e use como recheio. Prepare uma massa com farinha, ovo e água, abra, corte discos e recheie com uma porção do recheio; feche bem e cozinhe em água fervente até subirem. Opcional: doure na manteiga antes de servir para textura adicional." },
                    { 98, 98, "Tempere cubos de peixe cru com molho de soja, óleo de gergelim, suco de limão e sementes de gergelim; deixe marinar por alguns minutos. Monte tigelas com arroz de sushi, coloque o peixe marinado por cima e adicione complementos como pepino fatiado, algas, abacate e cebolinha. Finalize com sementes de gergelim e um fio de molho adicional se desejar." },
                    { 99, 99, "Pré-aqueça o forno. Forre forminhas com massa folhada e reserve. Em uma panela, aqueça leite com baunilha; bata gemas com açúcar até clarear e incorpore o leite quente aos poucos. Coe e despeje o creme nas forminhas forradas. Asse em forno quente até o topo caramelizar levemente; deixe esfriar antes de desenformar e polvilhe canela a gosto." },
                    { 100, 100, "Cozinhe mandioca (ou farinha de mandioca/cuscuz) até formar uma papa firme e maleável (fufu). Para o ensopado, refogue cebola e alho, acrescente carne e cozinhe; junte pasta de amendoim e caldo, cozinhe até o molho ficar espesso e bem temperado. Sirva porções do fufu com o guisado de amendoim por cima, permitindo que cada pessoa molde o fufu e pegue o molho com a mão." }
                });

            migrationBuilder.InsertData(
                table: "RecipeIngredient",
                columns: new[] { "IngredientId", "RecipeId", "MeasurementUnit", "Quantity" },
                values: new object[,]
                {
                    { 8, 11, "unidade(s)", 4.0 },
                    { 38, 11, "ml", 500.0 },
                    { 39, 11, "grama(s)", 100.0 },
                    { 40, 11, "colher(es) de chá", 1.0 },
                    { 5, 12, "colher(es) de sopa", 2.0 },
                    { 18, 12, "unidade(s)", 2.0 },
                    { 24, 12, "unidade(s)", 0.25 },
                    { 33, 12, "unidade(s)", 1.0 },
                    { 41, 12, "grama(s)", 200.0 },
                    { 42, 12, "punhado(s)", 1.0 },
                    { 43, 12, "punhado(s)", 1.0 },
                    { 8, 13, "unidade(s)", 2.0 },
                    { 39, 13, "grama(s)", 50.0 },
                    { 44, 13, "grama(s)", 200.0 },
                    { 45, 13, "ml", 250.0 },
                    { 46, 13, "unidade(s)", 2.0 },
                    { 47, 13, "grama(s)", 30.0 },
                    { 5, 14, "colher(es) de sopa", 2.0 },
                    { 18, 14, "unidade(s)", 2.0 },
                    { 24, 14, "unidade(s)", 1.0 },
                    { 32, 14, "punhado(s)", 1.0 },
                    { 33, 14, "unidade(s)", 1.0 },
                    { 36, 14, "grama(s)", 400.0 },
                    { 48, 14, "ml", 200.0 },
                    { 49, 14, "unidade(s)", 1.0 },
                    { 37, 15, "grama(s)", 200.0 },
                    { 39, 15, "colher(es) de sopa", 2.0 },
                    { 47, 15, "colher(es) de sopa", 1.0 },
                    { 50, 15, "unidade(s)", 1.0 },
                    { 5, 16, "colher(es) de sopa", 2.0 },
                    { 24, 16, "unidade(s)", 1.0 },
                    { 32, 16, "punhado(s)", 1.0 },
                    { 48, 16, "ml", 200.0 },
                    { 51, 16, "grama(s)", 300.0 },
                    { 52, 16, "grama(s)", 500.0 },
                    { 8, 17, "unidade(s)", 3.0 },
                    { 9, 17, "grama(s)", 50.0 },
                    { 10, 17, "grama(s)", 100.0 },
                    { 38, 17, "ml", 200.0 },
                    { 53, 17, "unidade(s)", 1.0 },
                    { 15, 18, "unidade(s)", 1.0 },
                    { 42, 18, "punhado(s)", 1.0 },
                    { 47, 18, "grama(s)", 50.0 },
                    { 54, 18, "dente(s)", 3.0 },
                    { 11, 19, "pitada(s)", 1.0 },
                    { 24, 19, "unidade(s)", 0.5 },
                    { 32, 19, "punhado(s)", 1.0 },
                    { 33, 19, "unidade(s)", 3.0 },
                    { 36, 19, "grama(s)", 250.0 },
                    { 37, 20, "grama(s)", 150.0 },
                    { 38, 20, "ml", 200.0 },
                    { 50, 20, "grama(s)", 200.0 },
                    { 55, 20, "grama(s)", 200.0 },
                    { 10, 21, "grama(s)", 150.0 },
                    { 22, 21, "grama(s)", 200.0 },
                    { 47, 21, "grama(s)", 50.0 },
                    { 54, 21, "dente(s)", 4.0 },
                    { 56, 21, "grama(s)", 500.0 },
                    { 58, 21, "grama(s)", 300.0 },
                    { 59, 21, "grama(s)", 200.0 },
                    { 60, 21, "grama(s)", 150.0 },
                    { 11, 22, "pitada(s)", 1.0 },
                    { 24, 22, "unidade(s)", 1.0 },
                    { 32, 22, "punhado(s)", 1.0 },
                    { 51, 22, "grama(s)", 150.0 },
                    { 54, 22, "dente(s)", 2.0 },
                    { 57, 22, "ml", 100.0 },
                    { 61, 22, "grama(s)", 500.0 },
                    { 5, 23, "colher(es) de sopa", 2.0 },
                    { 24, 23, "unidade(s)", 0.5 },
                    { 48, 23, "ml", 250.0 },
                    { 51, 23, "grama(s)", 200.0 },
                    { 57, 23, "ml", 50.0 },
                    { 60, 23, "grama(s)", 120.0 },
                    { 62, 23, "grama(s)", 80.0 },
                    { 5, 24, "colher(es) de sopa", 2.0 },
                    { 22, 24, "grama(s)", 300.0 },
                    { 24, 24, "unidade(s)", 1.0 },
                    { 47, 24, "grama(s)", 30.0 },
                    { 54, 24, "dente(s)", 3.0 },
                    { 58, 24, "grama(s)", 250.0 },
                    { 59, 24, "grama(s)", 150.0 },
                    { 22, 25, "grama(s)", 200.0 },
                    { 47, 25, "grama(s)", 30.0 },
                    { 54, 25, "dente(s)", 2.0 },
                    { 58, 25, "grama(s)", 120.0 },
                    { 63, 25, "grama(s)", 150.0 },
                    { 66, 25, "grama(s)", 200.0 },
                    { 5, 26, "colher(es) de sopa", 1.0 },
                    { 24, 26, "unidade(s)", 1.0 },
                    { 47, 26, "grama(s)", 50.0 },
                    { 52, 26, "grama(s)", 700.0 },
                    { 54, 26, "dente(s)", 2.0 },
                    { 58, 26, "grama(s)", 350.0 },
                    { 63, 26, "grama(s)", 150.0 },
                    { 5, 27, "colher(es) de sopa", 2.0 },
                    { 11, 27, "pitada(s)", 2.0 },
                    { 33, 27, "unidade(s)", 1.0 },
                    { 47, 27, "grama(s)", 10.0 },
                    { 54, 27, "dente(s)", 3.0 },
                    { 64, 27, "grama(s)", 800.0 },
                    { 3, 28, "grama(s)", 150.0 },
                    { 13, 28, "grama(s)", 250.0 },
                    { 24, 28, "unidade(s)", 1.0 },
                    { 44, 28, "grama(s)", 300.0 },
                    { 47, 28, "grama(s)", 20.0 },
                    { 54, 28, "dente(s)", 2.0 },
                    { 65, 28, "ml", 600.0 },
                    { 20, 29, "grama(s)", 350.0 },
                    { 21, 29, "grama(s)", 150.0 },
                    { 24, 29, "unidade(s)", 1.0 },
                    { 44, 29, "grama(s)", 200.0 },
                    { 45, 29, "ml", 250.0 },
                    { 47, 29, "grama(s)", 50.0 },
                    { 54, 29, "dente(s)", 2.0 },
                    { 39, 30, "grama(s)", 150.0 },
                    { 47, 30, "grama(s)", 20.0 },
                    { 48, 30, "ml", 300.0 },
                    { 50, 30, "grama(s)", 300.0 },
                    { 67, 30, "grama(s)", 400.0 },
                    { 68, 30, "colher(es) de chá", 2.0 },
                    { 5, 31, "colher(es) de sopa", 1.0 },
                    { 8, 31, "unidade(s)", 2.0 },
                    { 33, 31, "unidade(s)", 1.0 },
                    { 51, 31, "grama(s)", 120.0 },
                    { 62, 31, "grama(s)", 40.0 },
                    { 69, 31, "ml", 40.0 },
                    { 70, 31, "grama(s)", 15.0 },
                    { 73, 31, "grama(s)", 200.0 },
                    { 75, 31, "grama(s)", 120.0 },
                    { 8, 32, "unidade(s)", 2.0 },
                    { 26, 32, "ml", 600.0 },
                    { 54, 32, "dente(s)", 2.0 },
                    { 69, 32, "ml", 40.0 },
                    { 72, 32, "punhado(s)", 1.0 },
                    { 73, 32, "grama(s)", 200.0 },
                    { 80, 32, "grama(s)", 60.0 },
                    { 20, 33, "grama(s)", 350.0 },
                    { 39, 33, "grama(s)", 30.0 },
                    { 44, 33, "grama(s)", 120.0 },
                    { 54, 33, "dente(s)", 3.0 },
                    { 65, 33, "ml", 300.0 },
                    { 69, 33, "ml", 60.0 },
                    { 70, 33, "grama(s)", 15.0 },
                    { 5, 34, "colher(es) de sopa", 1.0 },
                    { 13, 34, "grama(s)", 220.0 },
                    { 53, 34, "unidade(s)", 1.0 },
                    { 54, 34, "dente(s)", 2.0 },
                    { 69, 34, "ml", 40.0 },
                    { 70, 34, "grama(s)", 8.0 },
                    { 72, 34, "punhado(s)", 1.0 },
                    { 8, 35, "unidade(s)", 1.0 },
                    { 22, 35, "grama(s)", 200.0 },
                    { 23, 35, "grama(s)", 60.0 },
                    { 54, 35, "dente(s)", 1.0 },
                    { 64, 35, "grama(s)", 150.0 },
                    { 71, 35, "colher(es) de sopa", 1.0 },
                    { 72, 35, "punhado(s)", 1.0 },
                    { 5, 36, "colher(es) de sopa", 1.0 },
                    { 20, 36, "grama(s)", 300.0 },
                    { 48, 36, "ml", 250.0 },
                    { 49, 36, "unidade(s)", 1.0 },
                    { 71, 36, "colher(es) de sopa", 2.0 },
                    { 74, 36, "grama(s)", 12.0 },
                    { 78, 36, "unidade(s)", 1.0 },
                    { 20, 37, "grama(s)", 300.0 },
                    { 39, 37, "grama(s)", 30.0 },
                    { 54, 37, "dente(s)", 2.0 },
                    { 69, 37, "ml", 60.0 },
                    { 70, 37, "grama(s)", 15.0 },
                    { 72, 37, "punhado(s)", 1.0 },
                    { 77, 37, "ml", 40.0 },
                    { 5, 38, "colher(es) de sopa", 1.0 },
                    { 18, 38, "grama(s)", 250.0 },
                    { 20, 38, "grama(s)", 350.0 },
                    { 38, 38, "ml", 150.0 },
                    { 47, 38, "grama(s)", 40.0 },
                    { 54, 38, "dente(s)", 3.0 },
                    { 74, 38, "grama(s)", 20.0 },
                    { 13, 39, "grama(s)", 150.0 },
                    { 54, 39, "dente(s)", 2.0 },
                    { 69, 39, "ml", 40.0 },
                    { 71, 39, "colher(es) de sopa", 1.0 },
                    { 72, 39, "punhado(s)", 2.0 },
                    { 75, 39, "grama(s)", 300.0 },
                    { 78, 39, "unidade(s)", 1.0 },
                    { 39, 40, "grama(s)", 30.0 },
                    { 54, 40, "dente(s)", 1.0 },
                    { 64, 40, "grama(s)", 350.0 },
                    { 69, 40, "ml", 50.0 },
                    { 70, 40, "grama(s)", 15.0 },
                    { 71, 40, "colher(es) de sopa", 1.0 },
                    { 72, 40, "punhado(s)", 2.0 },
                    { 10, 41, "grama(s)", 100.0 },
                    { 13, 41, "grama(s)", 800.0 },
                    { 24, 41, "unidade(s)", 2.0 },
                    { 26, 41, "ml", 500.0 },
                    { 44, 41, "grama(s)", 20.0 },
                    { 47, 41, "grama(s)", 30.0 },
                    { 54, 41, "dente(s)", 3.0 },
                    { 81, 41, "ml", 500.0 },
                    { 89, 41, "ramos", 2.0 },
                    { 8, 42, "unidade(s)", 3.0 },
                    { 37, 42, "grama(s)", 30.0 },
                    { 39, 42, "grama(s)", 120.0 },
                    { 40, 42, "colher(es) de chá", 1.0 },
                    { 55, 42, "grama(s)", 200.0 },
                    { 82, 42, "grama(s)", 500.0 },
                    { 91, 42, "ml", 200.0 },
                    { 2, 43, "grama(s)", 200.0 },
                    { 5, 43, "colher(es) de sopa", 2.0 },
                    { 7, 43, "grama(s)", 200.0 },
                    { 11, 43, "pitada(s)", 1.0 },
                    { 54, 43, "dente(s)", 2.0 },
                    { 83, 43, "grama(s)", 50.0 },
                    { 84, 43, "grama(s)", 20.0 },
                    { 5, 44, "colher(es) de sopa", 2.0 },
                    { 18, 44, "grama(s)", 200.0 },
                    { 22, 44, "grama(s)", 300.0 },
                    { 25, 44, "ml", 100.0 },
                    { 26, 44, "ml", 800.0 },
                    { 49, 44, "unidade(s)", 1.0 },
                    { 51, 44, "grama(s)", 200.0 },
                    { 54, 44, "dente(s)", 3.0 },
                    { 85, 44, "colher(es) de chá", 1.0 },
                    { 86, 44, "grama(s)", 200.0 },
                    { 8, 45, "unidade(s)", 1.0 },
                    { 9, 45, "grama(s)", 50.0 },
                    { 13, 45, "grama(s)", 300.0 },
                    { 14, 45, "ml", 250.0 },
                    { 18, 45, "grama(s)", 200.0 },
                    { 44, 45, "grama(s)", 30.0 },
                    { 47, 45, "grama(s)", 30.0 },
                    { 87, 45, "unidade(s)", 2.0 },
                    { 8, 46, "unidade(s)", 2.0 },
                    { 9, 46, "grama(s)", 50.0 },
                    { 11, 46, "pitada(s)", 1.0 },
                    { 44, 46, "grama(s)", 200.0 },
                    { 45, 46, "ml", 50.0 },
                    { 47, 46, "grama(s)", 30.0 },
                    { 88, 46, "grama(s)", 500.0 },
                    { 5, 47, "colher(es) de sopa", 2.0 },
                    { 18, 47, "unidade(s)", 2.0 },
                    { 24, 47, "unidade(s)", 1.0 },
                    { 49, 47, "unidade(s)", 1.0 },
                    { 54, 47, "dente(s)", 2.0 },
                    { 87, 47, "unidade(s)", 1.0 },
                    { 89, 47, "ramos", 2.0 },
                    { 90, 47, "ramo(s)", 1.0 },
                    { 4, 48, "punhado(s)", 1.0 },
                    { 5, 48, "colher(es) de sopa", 2.0 },
                    { 9, 48, "grama(s)", 20.0 },
                    { 11, 48, "pitada(s)", 1.0 },
                    { 15, 48, "fatia(s)", 4.0 },
                    { 18, 48, "grama(s)", 250.0 },
                    { 54, 48, "dente(s)", 1.0 },
                    { 5, 49, "colher(es) de sopa", 2.0 },
                    { 11, 49, "pitada(s)", 1.0 },
                    { 18, 49, "grama(s)", 200.0 },
                    { 25, 49, "ml", 100.0 },
                    { 26, 49, "ml", 1000.0 },
                    { 36, 49, "grama(s)", 200.0 },
                    { 47, 49, "grama(s)", 20.0 },
                    { 54, 49, "dente(s)", 2.0 },
                    { 85, 49, "colher(es) de chá", 1.0 },
                    { 86, 49, "grama(s)", 300.0 },
                    { 5, 50, "colher(es) de sopa", 1.0 },
                    { 9, 50, "grama(s)", 60.0 },
                    { 22, 50, "grama(s)", 200.0 },
                    { 24, 50, "unidade(s)", 0.5 },
                    { 25, 50, "ml", 50.0 },
                    { 26, 50, "ml", 700.0 },
                    { 47, 50, "grama(s)", 40.0 },
                    { 85, 50, "colher(es) de chá", 1.0 },
                    { 39, 51, "grama(s)", 150.0 },
                    { 40, 51, "colher(es) de chá", 1.0 },
                    { 47, 51, "grama(s)", 100.0 },
                    { 53, 51, "unidade(s)", 1.0 },
                    { 95, 51, "unidade(s)", 6.0 },
                    { 38, 52, "ml", 500.0 },
                    { 39, 52, "grama(s)", 80.0 },
                    { 40, 52, "colher(es) de chá", 1.0 },
                    { 45, 52, "ml", 200.0 },
                    { 92, 52, "grama(s)", 100.0 },
                    { 94, 52, "grama(s)", 10.0 },
                    { 8, 53, "unidade(s)", 3.0 },
                    { 38, 53, "ml", 100.0 },
                    { 39, 53, "grama(s)", 150.0 },
                    { 40, 53, "colher(es) de chá", 1.0 },
                    { 47, 53, "grama(s)", 80.0 },
                    { 55, 53, "grama(s)", 200.0 },
                    { 93, 53, "grama(s)", 600.0 },
                    { 8, 54, "unidade(s)", 4.0 },
                    { 38, 54, "ml", 200.0 },
                    { 39, 54, "grama(s)", 200.0 },
                    { 40, 54, "colher(es) de chá", 1.0 },
                    { 92, 54, "grama(s)", 150.0 },
                    { 8, 55, "unidade(s)", 1.0 },
                    { 39, 55, "grama(s)", 120.0 },
                    { 40, 55, "colher(es) de chá", 1.0 },
                    { 44, 55, "grama(s)", 300.0 },
                    { 47, 55, "grama(s)", 100.0 },
                    { 68, 55, "colher(es) de chá", 1.0 },
                    { 95, 55, "unidade(s)", 6.0 },
                    { 8, 56, "unidade(s)", 4.0 },
                    { 37, 56, "grama(s)", 150.0 },
                    { 38, 56, "ml", 200.0 },
                    { 39, 56, "grama(s)", 80.0 },
                    { 44, 56, "grama(s)", 200.0 },
                    { 45, 56, "ml", 100.0 },
                    { 47, 56, "grama(s)", 80.0 },
                    { 8, 57, "unidade(s)", 3.0 },
                    { 37, 57, "grama(s)", 200.0 },
                    { 38, 57, "ml", 50.0 },
                    { 39, 57, "grama(s)", 80.0 },
                    { 44, 57, "grama(s)", 30.0 },
                    { 47, 57, "grama(s)", 100.0 },
                    { 8, 58, "unidade(s)", 3.0 },
                    { 33, 58, "unidade(s)", 3.0 },
                    { 39, 58, "grama(s)", 120.0 },
                    { 40, 58, "colher(es) de chá", 1.0 },
                    { 44, 58, "grama(s)", 250.0 },
                    { 45, 58, "ml", 50.0 },
                    { 47, 58, "grama(s)", 80.0 },
                    { 8, 59, "unidade(s)", 2.0 },
                    { 38, 59, "ml", 200.0 },
                    { 39, 59, "grama(s)", 120.0 },
                    { 40, 59, "colher(es) de chá", 1.0 },
                    { 45, 59, "ml", 400.0 },
                    { 8, 60, "unidade(s)", 4.0 },
                    { 33, 60, "unidade(s)", 1.0 },
                    { 39, 60, "grama(s)", 80.0 },
                    { 40, 60, "colher(es) de chá", 1.0 },
                    { 45, 60, "ml", 500.0 },
                    { 68, 60, "colher(es) de chá", 1.0 },
                    { 5, 61, "colher(es) de sopa", 1.0 },
                    { 11, 61, "pitada(s)", 1.0 },
                    { 31, 61, "grama(s)", 120.0 },
                    { 45, 61, "ml", 150.0 },
                    { 47, 61, "grama(s)", 10.0 },
                    { 93, 61, "grama(s)", 60.0 },
                    { 96, 61, "grama(s)", 200.0 },
                    { 17, 62, "punhado(s)", 1.0 },
                    { 24, 62, "unidade(s)", 1.0 },
                    { 33, 62, "unidade(s)", 1.0 },
                    { 54, 62, "dente(s)", 3.0 },
                    { 70, 62, "grama(s)", 10.0 },
                    { 97, 62, "grama(s)", 250.0 },
                    { 98, 62, "grama(s)", 40.0 },
                    { 102, 62, "unidade(s)", 2.0 },
                    { 5, 63, "colher(es) de sopa", 1.0 },
                    { 18, 63, "unidade(s)", 1.0 },
                    { 24, 63, "unidade(s)", 0.5 },
                    { 31, 63, "grama(s)", 180.0 },
                    { 32, 63, "punhado(s)", 1.0 },
                    { 39, 63, "grama(s)", 10.0 },
                    { 99, 63, "unidade(s)", 1.0 },
                    { 24, 64, "unidade(s)", 1.0 },
                    { 44, 64, "grama(s)", 200.0 },
                    { 54, 64, "dente(s)", 2.0 },
                    { 70, 64, "grama(s)", 10.0 },
                    { 74, 64, "grama(s)", 5.0 },
                    { 88, 64, "grama(s)", 300.0 },
                    { 101, 64, "grama(s)", 120.0 },
                    { 8, 65, "unidade(s)", 2.0 },
                    { 45, 65, "ml", 150.0 },
                    { 47, 65, "grama(s)", 30.0 },
                    { 63, 65, "grama(s)", 180.0 },
                    { 100, 65, "grama(s)", 250.0 },
                    { 11, 66, "pitada(s)", 1.0 },
                    { 13, 66, "grama(s)", 300.0 },
                    { 24, 66, "unidade(s)", 1.0 },
                    { 47, 66, "grama(s)", 20.0 },
                    { 53, 66, "unidade(s)", 2.0 },
                    { 54, 66, "dente(s)", 2.0 },
                    { 5, 67, "colher(es) de sopa", 1.0 },
                    { 24, 67, "unidade(s)", 0.5 },
                    { 31, 67, "grama(s)", 220.0 },
                    { 32, 67, "punhado(s)", 1.0 },
                    { 33, 67, "unidade(s)", 1.0 },
                    { 98, 67, "grama(s)", 30.0 },
                    { 102, 67, "unidade(s)", 2.0 },
                    { 8, 68, "unidade(s)", 2.0 },
                    { 39, 68, "grama(s)", 80.0 },
                    { 44, 68, "grama(s)", 200.0 },
                    { 45, 68, "ml", 150.0 },
                    { 47, 68, "grama(s)", 30.0 },
                    { 65, 68, "ml", 800.0 },
                    { 68, 68, "colher(es) de chá", 2.0 },
                    { 8, 69, "unidade(s)", 1.0 },
                    { 24, 69, "unidade(s)", 0.5 },
                    { 31, 69, "grama(s)", 150.0 },
                    { 44, 69, "grama(s)", 300.0 },
                    { 45, 69, "ml", 180.0 },
                    { 47, 69, "grama(s)", 20.0 },
                    { 72, 69, "punhado(s)", 1.0 },
                    { 5, 70, "colher(es) de sopa", 1.0 },
                    { 24, 70, "unidade(s)", 0.5 },
                    { 47, 70, "grama(s)", 20.0 },
                    { 61, 70, "grama(s)", 180.0 },
                    { 63, 70, "grama(s)", 120.0 },
                    { 96, 70, "grama(s)", 300.0 },
                    { 5, 71, "colher(es) de sopa", 2.0 },
                    { 6, 71, "pitada(s)", 1.0 },
                    { 18, 71, "grama(s)", 200.0 },
                    { 24, 71, "unidade(s)", 0.5 },
                    { 33, 71, "unidade(s)", 1.0 },
                    { 83, 71, "grama(s)", 50.0 },
                    { 103, 71, "grama(s)", 150.0 },
                    { 104, 71, "unidade(s)", 1.0 },
                    { 2, 72, "grama(s)", 400.0 },
                    { 5, 72, "colher(es) de sopa", 2.0 },
                    { 8, 72, "unidade(s)", 4.0 },
                    { 24, 72, "unidade(s)", 1.0 },
                    { 42, 72, "punhado(s)", 1.0 },
                    { 49, 72, "unidade(s)", 1.0 },
                    { 54, 72, "dente(s)", 2.0 },
                    { 78, 72, "unidade(s)", 1.0 },
                    { 5, 73, "colher(es) de sopa", 2.0 },
                    { 11, 73, "pitada(s)", 1.0 },
                    { 33, 73, "unidade(s)", 1.0 },
                    { 42, 73, "punhado(s)", 1.0 },
                    { 54, 73, "dente(s)", 2.0 },
                    { 87, 73, "unidade(s)", 2.0 },
                    { 98, 73, "grama(s)", 50.0 },
                    { 5, 74, "colher(es) de sopa", 2.0 },
                    { 11, 74, "pitada(s)", 1.0 },
                    { 20, 74, "grama(s)", 500.0 },
                    { 33, 74, "unidade(s)", 2.0 },
                    { 54, 74, "dente(s)", 4.0 },
                    { 89, 74, "ramos", 2.0 },
                    { 90, 74, "ramo(s)", 2.0 },
                    { 5, 75, "colher(es) de sopa", 2.0 },
                    { 18, 75, "grama(s)", 200.0 },
                    { 24, 75, "unidade(s)", 1.0 },
                    { 25, 75, "ml", 150.0 },
                    { 42, 75, "punhado(s)", 1.0 },
                    { 54, 75, "dente(s)", 4.0 },
                    { 86, 75, "grama(s)", 800.0 },
                    { 5, 76, "colher(es) de sopa", 2.0 },
                    { 11, 76, "pitada(s)", 1.0 },
                    { 33, 76, "unidade(s)", 1.0 },
                    { 54, 76, "dente(s)", 2.0 },
                    { 97, 76, "grama(s)", 300.0 },
                    { 98, 76, "grama(s)", 60.0 },
                    { 102, 76, "unidade(s)", 2.0 },
                    { 5, 77, "colher(es) de sopa", 2.0 },
                    { 9, 77, "grama(s)", 20.0 },
                    { 42, 77, "punhado(s)", 1.0 },
                    { 54, 77, "dente(s)", 1.0 },
                    { 83, 77, "grama(s)", 150.0 },
                    { 84, 77, "grama(s)", 30.0 },
                    { 99, 77, "unidade(s)", 1.0 },
                    { 5, 78, "colher(es) de sopa", 2.0 },
                    { 6, 78, "pitada(s)", 1.0 },
                    { 11, 78, "pitada(s)", 1.0 },
                    { 18, 78, "grama(s)", 300.0 },
                    { 54, 78, "dente(s)", 2.0 },
                    { 99, 78, "unidade(s)", 1.0 },
                    { 103, 78, "grama(s)", 200.0 },
                    { 5, 79, "colher(es) de sopa", 3.0 },
                    { 6, 79, "colher(es) de chá", 1.0 },
                    { 11, 79, "pitada(s)", 1.0 },
                    { 33, 79, "unidade(s)", 2.0 },
                    { 54, 79, "dente(s)", 4.0 },
                    { 88, 79, "grama(s)", 800.0 },
                    { 90, 79, "ramo(s)", 2.0 },
                    { 5, 80, "colher(es) de sopa", 2.0 },
                    { 18, 80, "grama(s)", 150.0 },
                    { 24, 80, "unidade(s)", 1.0 },
                    { 41, 80, "grama(s)", 200.0 },
                    { 42, 80, "punhado(s)", 1.0 },
                    { 49, 80, "unidade(s)", 4.0 },
                    { 103, 80, "grama(s)", 100.0 },
                    { 5, 81, "colher(es) de sopa", 3.0 },
                    { 11, 81, "pitada(s)", 1.0 },
                    { 18, 81, "grama(s)", 400.0 },
                    { 20, 81, "grama(s)", 400.0 },
                    { 22, 81, "grama(s)", 300.0 },
                    { 24, 81, "unidade(s)", 1.0 },
                    { 33, 81, "unidade(s)", 1.0 },
                    { 54, 81, "dente(s)", 2.0 },
                    { 8, 82, "unidade(s)", 2.0 },
                    { 13, 82, "grama(s)", 500.0 },
                    { 39, 82, "grama(s)", 20.0 },
                    { 44, 82, "grama(s)", 100.0 },
                    { 45, 82, "ml", 200.0 },
                    { 54, 82, "dente(s)", 2.0 },
                    { 74, 82, "grama(s)", 5.0 },
                    { 5, 83, "colher(es) de sopa", 2.0 },
                    { 11, 83, "pitada(s)", 1.0 },
                    { 33, 83, "unidade(s)", 1.0 },
                    { 54, 83, "dente(s)", 2.0 },
                    { 62, 83, "grama(s)", 100.0 },
                    { 64, 83, "grama(s)", 500.0 },
                    { 70, 83, "grama(s)", 10.0 },
                    { 5, 84, "colher(es) de sopa", 2.0 },
                    { 13, 84, "grama(s)", 600.0 },
                    { 18, 84, "grama(s)", 200.0 },
                    { 24, 84, "unidade(s)", 1.0 },
                    { 26, 84, "ml", 400.0 },
                    { 49, 84, "unidade(s)", 1.0 },
                    { 85, 84, "colher(es) de chá", 1.0 },
                    { 5, 85, "colher(es) de sopa", 3.0 },
                    { 11, 85, "pitada(s)", 1.0 },
                    { 20, 85, "grama(s)", 800.0 },
                    { 24, 85, "unidade(s)", 3.0 },
                    { 33, 85, "unidade(s)", 3.0 },
                    { 54, 85, "dente(s)", 3.0 },
                    { 78, 85, "unidade(s)", 1.0 },
                    { 5, 86, "colher(es) de sopa", 2.0 },
                    { 33, 86, "unidade(s)", 1.0 },
                    { 42, 86, "punhado(s)", 1.0 },
                    { 47, 86, "grama(s)", 20.0 },
                    { 51, 86, "grama(s)", 400.0 },
                    { 54, 86, "dente(s)", 3.0 },
                    { 78, 86, "unidade(s)", 2.0 },
                    { 8, 87, "unidade(s)", 1.0 },
                    { 11, 87, "pitada(s)", 1.0 },
                    { 39, 87, "grama(s)", 80.0 },
                    { 44, 87, "grama(s)", 300.0 },
                    { 45, 87, "ml", 50.0 },
                    { 47, 87, "grama(s)", 30.0 },
                    { 48, 87, "ml", 150.0 },
                    { 5, 88, "colher(es) de sopa", 1.0 },
                    { 11, 88, "pitada(s)", 1.0 },
                    { 33, 88, "unidade(s)", 1.0 },
                    { 45, 88, "ml", 200.0 },
                    { 47, 88, "grama(s)", 30.0 },
                    { 54, 88, "dente(s)", 1.0 },
                    { 96, 88, "grama(s)", 300.0 },
                    { 2, 89, "grama(s)", 300.0 },
                    { 5, 89, "colher(es) de sopa", 2.0 },
                    { 22, 89, "grama(s)", 200.0 },
                    { 24, 89, "unidade(s)", 1.0 },
                    { 54, 89, "dente(s)", 2.0 },
                    { 73, 89, "grama(s)", 150.0 },
                    { 97, 89, "grama(s)", 200.0 },
                    { 2, 90, "grama(s)", 200.0 },
                    { 5, 90, "colher(es) de sopa", 1.0 },
                    { 13, 90, "grama(s)", 300.0 },
                    { 22, 90, "grama(s)", 150.0 },
                    { 24, 90, "unidade(s)", 1.0 },
                    { 78, 90, "unidade(s)", 1.0 },
                    { 99, 90, "unidade(s)", 1.0 },
                    { 8, 91, "unidade(s)", 1.0 },
                    { 11, 91, "pitada(s)", 1.0 },
                    { 44, 91, "grama(s)", 200.0 },
                    { 65, 91, "ml", 1000.0 },
                    { 88, 91, "grama(s)", 600.0 },
                    { 108, 91, "grama(s)", 400.0 },
                    { 112, 91, "ml", 50.0 },
                    { 5, 92, "colher(es) de sopa", 2.0 },
                    { 8, 92, "unidade(s)", 3.0 },
                    { 20, 92, "grama(s)", 800.0 },
                    { 24, 92, "unidade(s)", 3.0 },
                    { 47, 92, "grama(s)", 50.0 },
                    { 54, 92, "dente(s)", 4.0 },
                    { 109, 92, "grama(s)", 20.0 },
                    { 5, 93, "colher(es) de sopa", 2.0 },
                    { 11, 93, "pitada(s)", 1.0 },
                    { 20, 93, "grama(s)", 800.0 },
                    { 33, 93, "unidade(s)", 1.0 },
                    { 54, 93, "dente(s)", 3.0 },
                    { 110, 93, "grama(s)", 10.0 },
                    { 113, 93, "unidade(s)", 2.0 },
                    { 5, 94, "colher(es) de sopa", 1.0 },
                    { 8, 94, "unidade(s)", 2.0 },
                    { 39, 94, "grama(s)", 5.0 },
                    { 44, 94, "grama(s)", 300.0 },
                    { 45, 94, "ml", 100.0 },
                    { 47, 94, "grama(s)", 30.0 },
                    { 111, 94, "grama(s)", 300.0 },
                    { 5, 95, "colher(es) de sopa", 1.0 },
                    { 11, 95, "pitada(s)", 1.0 },
                    { 20, 95, "grama(s)", 600.0 },
                    { 24, 95, "unidade(s)", 1.0 },
                    { 54, 95, "dente(s)", 3.0 },
                    { 69, 95, "ml", 80.0 },
                    { 112, 95, "ml", 100.0 },
                    { 5, 96, "colher(es) de sopa", 2.0 },
                    { 20, 96, "grama(s)", 500.0 },
                    { 24, 96, "unidade(s)", 1.0 },
                    { 39, 96, "grama(s)", 10.0 },
                    { 54, 96, "dente(s)", 2.0 },
                    { 114, 96, "grama(s)", 200.0 },
                    { 115, 96, "ml", 120.0 },
                    { 8, 97, "unidade(s)", 1.0 },
                    { 11, 97, "pitada(s)", 1.0 },
                    { 44, 97, "grama(s)", 300.0 },
                    { 45, 97, "ml", 50.0 },
                    { 47, 97, "grama(s)", 30.0 },
                    { 88, 97, "grama(s)", 400.0 },
                    { 93, 97, "grama(s)", 200.0 },
                    { 32, 98, "punhado(s)", 1.0 },
                    { 33, 98, "unidade(s)", 1.0 },
                    { 34, 98, "grama(s)", 150.0 },
                    { 35, 98, "folha(s)", 1.0 },
                    { 36, 98, "grama(s)", 200.0 },
                    { 69, 98, "ml", 30.0 },
                    { 79, 98, "grama(s)", 10.0 },
                    { 8, 99, "unidade(s)", 4.0 },
                    { 39, 99, "grama(s)", 120.0 },
                    { 40, 99, "colher(es) de chá", 1.0 },
                    { 45, 99, "ml", 200.0 },
                    { 47, 99, "grama(s)", 20.0 },
                    { 53, 99, "unidade(s)", 1.0 },
                    { 68, 99, "colher(es) de chá", 1.0 },
                    { 5, 100, "colher(es) de sopa", 2.0 },
                    { 13, 100, "grama(s)", 300.0 },
                    { 24, 100, "unidade(s)", 1.0 },
                    { 32, 100, "punhado(s)", 1.0 },
                    { 52, 100, "grama(s)", 500.0 },
                    { 54, 100, "dente(s)", 2.0 },
                    { 62, 100, "grama(s)", 150.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 8, 11 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 38, 11 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 39, 11 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 40, 11 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 5, 12 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 18, 12 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 24, 12 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 33, 12 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 41, 12 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 42, 12 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 43, 12 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 8, 13 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 39, 13 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 44, 13 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 45, 13 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 46, 13 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 47, 13 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 5, 14 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 18, 14 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 24, 14 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 32, 14 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 33, 14 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 36, 14 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 48, 14 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 49, 14 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 37, 15 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 39, 15 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 47, 15 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 50, 15 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 5, 16 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 24, 16 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 32, 16 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 48, 16 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 51, 16 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 52, 16 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 8, 17 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 9, 17 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 10, 17 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 38, 17 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 53, 17 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 15, 18 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 42, 18 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 47, 18 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 54, 18 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 11, 19 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 24, 19 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 32, 19 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 33, 19 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 36, 19 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 37, 20 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 38, 20 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 50, 20 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 55, 20 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 10, 21 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 22, 21 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 47, 21 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 54, 21 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 56, 21 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 58, 21 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 59, 21 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 60, 21 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 11, 22 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 24, 22 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 32, 22 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 51, 22 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 54, 22 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 57, 22 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 61, 22 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 5, 23 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 24, 23 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 48, 23 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 51, 23 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 57, 23 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 60, 23 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 62, 23 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 5, 24 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 22, 24 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 24, 24 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 47, 24 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 54, 24 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 58, 24 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 59, 24 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 22, 25 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 47, 25 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 54, 25 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 58, 25 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 63, 25 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 66, 25 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 5, 26 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 24, 26 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 47, 26 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 52, 26 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 54, 26 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 58, 26 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 63, 26 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 5, 27 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 11, 27 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 33, 27 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 47, 27 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 54, 27 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 64, 27 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 3, 28 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 13, 28 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 24, 28 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 44, 28 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 47, 28 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 54, 28 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 65, 28 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 20, 29 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 21, 29 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 24, 29 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 44, 29 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 45, 29 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 47, 29 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 54, 29 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 39, 30 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 47, 30 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 48, 30 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 50, 30 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 67, 30 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 68, 30 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 5, 31 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 8, 31 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 33, 31 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 51, 31 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 62, 31 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 69, 31 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 70, 31 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 73, 31 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 75, 31 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 8, 32 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 26, 32 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 54, 32 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 69, 32 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 72, 32 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 73, 32 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 80, 32 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 20, 33 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 39, 33 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 44, 33 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 54, 33 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 65, 33 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 69, 33 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 70, 33 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 5, 34 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 13, 34 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 53, 34 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 54, 34 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 69, 34 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 70, 34 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 72, 34 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 8, 35 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 22, 35 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 23, 35 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 54, 35 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 64, 35 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 71, 35 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 72, 35 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 5, 36 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 20, 36 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 48, 36 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 49, 36 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 71, 36 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 74, 36 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 78, 36 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 20, 37 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 39, 37 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 54, 37 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 69, 37 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 70, 37 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 72, 37 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 77, 37 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 5, 38 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 18, 38 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 20, 38 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 38, 38 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 47, 38 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 54, 38 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 74, 38 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 13, 39 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 54, 39 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 69, 39 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 71, 39 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 72, 39 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 75, 39 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 78, 39 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 39, 40 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 54, 40 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 64, 40 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 69, 40 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 70, 40 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 71, 40 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 72, 40 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 10, 41 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 13, 41 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 24, 41 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 26, 41 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 44, 41 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 47, 41 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 54, 41 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 81, 41 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 89, 41 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 8, 42 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 37, 42 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 39, 42 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 40, 42 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 55, 42 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 82, 42 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 91, 42 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 2, 43 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 5, 43 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 7, 43 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 11, 43 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 54, 43 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 83, 43 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 84, 43 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 5, 44 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 18, 44 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 22, 44 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 25, 44 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 26, 44 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 49, 44 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 51, 44 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 54, 44 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 85, 44 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 86, 44 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 8, 45 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 9, 45 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 13, 45 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 14, 45 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 18, 45 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 44, 45 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 47, 45 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 87, 45 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 8, 46 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 9, 46 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 11, 46 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 44, 46 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 45, 46 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 47, 46 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 88, 46 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 5, 47 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 18, 47 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 24, 47 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 49, 47 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 54, 47 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 87, 47 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 89, 47 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 90, 47 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 4, 48 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 5, 48 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 9, 48 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 11, 48 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 15, 48 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 18, 48 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 54, 48 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 5, 49 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 11, 49 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 18, 49 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 25, 49 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 26, 49 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 36, 49 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 47, 49 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 54, 49 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 85, 49 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 86, 49 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 5, 50 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 9, 50 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 22, 50 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 24, 50 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 25, 50 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 26, 50 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 47, 50 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 85, 50 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 39, 51 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 40, 51 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 47, 51 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 53, 51 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 95, 51 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 38, 52 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 39, 52 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 40, 52 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 45, 52 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 92, 52 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 94, 52 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 8, 53 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 38, 53 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 39, 53 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 40, 53 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 47, 53 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 55, 53 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 93, 53 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 8, 54 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 38, 54 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 39, 54 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 40, 54 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 92, 54 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 8, 55 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 39, 55 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 40, 55 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 44, 55 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 47, 55 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 68, 55 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 95, 55 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 8, 56 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 37, 56 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 38, 56 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 39, 56 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 44, 56 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 45, 56 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 47, 56 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 8, 57 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 37, 57 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 38, 57 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 39, 57 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 44, 57 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 47, 57 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 8, 58 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 33, 58 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 39, 58 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 40, 58 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 44, 58 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 45, 58 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 47, 58 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 8, 59 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 38, 59 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 39, 59 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 40, 59 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 45, 59 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 8, 60 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 33, 60 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 39, 60 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 40, 60 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 45, 60 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 68, 60 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 5, 61 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 11, 61 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 31, 61 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 45, 61 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 47, 61 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 93, 61 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 96, 61 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 17, 62 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 24, 62 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 33, 62 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 54, 62 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 70, 62 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 97, 62 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 98, 62 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 102, 62 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 5, 63 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 18, 63 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 24, 63 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 31, 63 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 32, 63 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 39, 63 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 99, 63 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 24, 64 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 44, 64 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 54, 64 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 70, 64 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 74, 64 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 88, 64 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 101, 64 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 8, 65 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 45, 65 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 47, 65 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 63, 65 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 100, 65 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 11, 66 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 13, 66 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 24, 66 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 47, 66 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 53, 66 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 54, 66 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 5, 67 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 24, 67 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 31, 67 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 32, 67 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 33, 67 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 98, 67 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 102, 67 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 8, 68 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 39, 68 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 44, 68 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 45, 68 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 47, 68 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 65, 68 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 68, 68 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 8, 69 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 24, 69 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 31, 69 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 44, 69 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 45, 69 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 47, 69 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 72, 69 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 5, 70 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 24, 70 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 47, 70 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 61, 70 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 63, 70 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 96, 70 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 5, 71 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 6, 71 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 18, 71 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 24, 71 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 33, 71 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 83, 71 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 103, 71 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 104, 71 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 2, 72 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 5, 72 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 8, 72 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 24, 72 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 42, 72 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 49, 72 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 54, 72 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 78, 72 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 5, 73 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 11, 73 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 33, 73 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 42, 73 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 54, 73 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 87, 73 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 98, 73 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 5, 74 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 11, 74 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 20, 74 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 33, 74 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 54, 74 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 89, 74 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 90, 74 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 5, 75 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 18, 75 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 24, 75 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 25, 75 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 42, 75 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 54, 75 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 86, 75 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 5, 76 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 11, 76 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 33, 76 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 54, 76 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 97, 76 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 98, 76 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 102, 76 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 5, 77 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 9, 77 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 42, 77 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 54, 77 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 83, 77 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 84, 77 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 99, 77 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 5, 78 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 6, 78 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 11, 78 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 18, 78 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 54, 78 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 99, 78 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 103, 78 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 5, 79 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 6, 79 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 11, 79 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 33, 79 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 54, 79 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 88, 79 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 90, 79 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 5, 80 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 18, 80 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 24, 80 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 41, 80 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 42, 80 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 49, 80 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 103, 80 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 5, 81 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 11, 81 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 18, 81 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 20, 81 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 22, 81 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 24, 81 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 33, 81 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 54, 81 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 8, 82 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 13, 82 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 39, 82 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 44, 82 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 45, 82 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 54, 82 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 74, 82 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 5, 83 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 11, 83 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 33, 83 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 54, 83 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 62, 83 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 64, 83 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 70, 83 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 5, 84 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 13, 84 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 18, 84 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 24, 84 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 26, 84 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 49, 84 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 85, 84 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 5, 85 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 11, 85 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 20, 85 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 24, 85 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 33, 85 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 54, 85 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 78, 85 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 5, 86 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 33, 86 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 42, 86 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 47, 86 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 51, 86 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 54, 86 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 78, 86 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 8, 87 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 11, 87 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 39, 87 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 44, 87 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 45, 87 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 47, 87 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 48, 87 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 5, 88 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 11, 88 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 33, 88 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 45, 88 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 47, 88 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 54, 88 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 96, 88 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 2, 89 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 5, 89 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 22, 89 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 24, 89 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 54, 89 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 73, 89 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 97, 89 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 2, 90 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 5, 90 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 13, 90 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 22, 90 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 24, 90 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 78, 90 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 99, 90 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 8, 91 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 11, 91 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 44, 91 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 65, 91 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 88, 91 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 108, 91 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 112, 91 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 5, 92 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 8, 92 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 20, 92 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 24, 92 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 47, 92 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 54, 92 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 109, 92 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 5, 93 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 11, 93 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 20, 93 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 33, 93 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 54, 93 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 110, 93 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 113, 93 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 5, 94 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 8, 94 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 39, 94 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 44, 94 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 45, 94 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 47, 94 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 111, 94 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 5, 95 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 11, 95 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 20, 95 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 24, 95 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 54, 95 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 69, 95 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 112, 95 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 5, 96 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 20, 96 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 24, 96 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 39, 96 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 54, 96 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 114, 96 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 115, 96 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 8, 97 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 11, 97 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 44, 97 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 45, 97 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 47, 97 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 88, 97 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 93, 97 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 32, 98 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 33, 98 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 34, 98 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 35, 98 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 36, 98 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 69, 98 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 79, 98 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 8, 99 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 39, 99 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 40, 99 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 45, 99 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 47, 99 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 53, 99 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 68, 99 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 5, 100 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 13, 100 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 24, 100 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 32, 100 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 52, 100 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 54, 100 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 62, 100 });

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Dishes",
                type: "varchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
