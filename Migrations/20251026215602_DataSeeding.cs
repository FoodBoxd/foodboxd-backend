using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace foodboxd_backend.Migrations
{
    /// <inheritdoc />
    public partial class DataSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 1,
                column: "Instructions",
                value: "Pré-aqueça o forno na temperatura mais alta possível (mínimo 220°C). Abra o disco de massa de pizza em uma superfície levemente enfarinhada e transfira para uma assadeira. Espalhe uma camada generosa de molho de tomate sobre a massa, deixando uma pequena borda. Distribua uniformemente a muçarela ralada por cima do molho. Regue com um fio de azeite e leve ao forno por 10-15 minutos, ou até a borda dourar e o queijo derreter. Retire do forno e espalhe as folhas de manjericão fresco por cima antes de servir.");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 2,
                column: "Instructions",
                value: "Cozinhe o espaguete em água salgada fervente até ficar 'al dente'. Enquanto isso, frite o bacon em cubos até ficar crocante. Em uma tigela, bata as gemas com o queijo parmesão ralado e pimenta do reino. Escorra a massa, reservando um pouco da água. Fora do fogo, misture a massa com o bacon e, em seguida, adicione a mistura de ovos, mexendo rapidamente para criar um molho cremoso. Use a água do cozimento para ajustar a consistência, se necessário. Sirva imediatamente.");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 3,
                column: "Instructions",
                value: "Em uma travessa, monte a lasanha alternando camadas: comece com molho à bolonhesa, seguido por uma camada de massa de lasanha, molho branco e queijo muçarela. Repita as camadas até preencher a travessa, finalizando com uma camada generosa de molho branco e queijo parmesão por cima. Leve ao forno pré-aquecido a 180°C por cerca de 30-40 minutos, ou até dourar.");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 4,
                column: "Instructions",
                value: "Molde a carne no formato de hambúrguer e tempere com sal e pimenta. Grelhe em uma frigideira quente ou churrasqueira até atingir o ponto desejado. Nos últimos minutos, coloque a fatia de queijo cheddar sobre o hambúrguer para derreter. Toste levemente o pão e monte o lanche com o hambúrguer, alface fresca e rodelas de tomate.");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 5,
                column: "Instructions",
                value: "Tempere o peito de frango e passe-o no ovo batido e depois na farinha de rosca. Frite em óleo quente até dourar dos dois lados. Em uma travessa, coloque o frango frito, cubra com molho de tomate e queijo muçarela. Leve ao forno pré-aquecido a 200°C apenas para gratinar o queijo, por cerca de 10 minutos.");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 6,
                column: "Instructions",
                value: "Em uma panela, refogue a cebola picada na manteiga até ficar transparente. Adicione o arroz arbóreo e refogue por mais um minuto. Despeje o vinho branco e mexa até evaporar. Aos poucos, adicione o caldo de legumes quente, uma concha por vez, mexendo sempre até o arroz absorver o líquido. Quando o arroz estiver 'al dente', adicione os cogumelos fatiados, o queijo parmesão e mais uma colher de manteiga. Misture bem e sirva.");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 7,
                column: "Instructions",
                value: "Grelhe o peito de frango temperado e corte em tiras. Em uma saladeira, misture a alface romana rasgada, os croutons e as lascas de parmesão. Adicione o frango grelhado por cima e regue tudo com o molho Caesar, misturando delicadamente para cobrir todos os ingredientes.");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 8,
                column: "Instructions",
                value: "Tempere as tiras de carne com sal, pimenta e cominho. Grelhe em uma frigideira bem quente até dourarem. Aqueça as tortillas em outra frigideira ou no micro-ondas. Monte os tacos recheando cada tortilla com a carne grelhada, cebola picada e folhas de coentro. Sirva imediatamente com fatias de limão para espremer por cima.");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 9,
                column: "Instructions",
                value: "Em uma esteira de bambu (sudare), coloque uma folha de alga nori com o lado brilhante para baixo. Umedeça as mãos e espalhe uma camada fina e uniforme de arroz de sushi sobre a alga, deixando uma borda livre. Posicione as tiras de salmão no centro do arroz. Enrole firmemente a alga com a ajuda da esteira. Com uma faca afiada e úmida, corte o rolo em 8 peças iguais.");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 10,
                column: "Instructions",
                value: "Derreta o chocolate meio amargo em banho-maria ou no micro-ondas. Em outra tigela, bata o creme de leite fresco (ou as claras em neve com açúcar) até formar picos firmes. Incorpore delicadamente o chocolate derretido e já morno à mistura, com movimentos de baixo para cima para não perder a aeração. Despeje em taças individuais e leve à geladeira por pelo menos 4 horas antes de servir.");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 1,
                column: "Instructions",
                value: "Pré-aqueça o forno. Abra a massa, espalhe molho de tomate, cubra com muçarela e manjericão. Asse até dourar.");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 2,
                column: "Instructions",
                value: "Cozinhe o espaguete. Frite o bacon. Misture as gemas com queijo parmesão e pimenta. Junte tudo rapidamente fora do fogo.");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 3,
                column: "Instructions",
                value: "Monte camadas de massa, molho à bolonhesa, molho branco e queijo. Repita e finalize com queijo. Asse até borbulhar.");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 4,
                column: "Instructions",
                value: "Grelhe o hambúrguer. Monte no pão com queijo, alface e tomate.");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 5,
                column: "Instructions",
                value: "Empane e frite o frango. Cubra com molho de tomate e queijo. Gratine no forno.");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 6,
                column: "Instructions",
                value: "Refogue a cebola, adicione o arroz e o vinho. Vá adicionando caldo de legumes aos poucos, mexendo sempre. Finalize com cogumelos, manteiga e parmesão.");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 7,
                column: "Instructions",
                value: "Grelhe o frango. Misture a alface, os croutons e o queijo. Adicione o frango fatiado e regue com molho Caesar.");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 8,
                column: "Instructions",
                value: "Aqueça as tortillas. Recheie com a carne, cebola picada e coentro. Sirva com limão.");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 9,
                column: "Instructions",
                value: "Espalhe o arroz sobre a alga nori. Adicione uma tira de salmão e enrole firmemente. Fatie os rolinhos.");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 10,
                column: "Instructions",
                value: "Derreta o chocolate. Incorpore o creme de leite e as claras em neve (opcional). Leve à geladeira por 4 horas.");
        }
    }
}
