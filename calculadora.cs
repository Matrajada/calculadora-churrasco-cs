Console.Clear();

// Exercício Churrasco
// Faça um programa que calcule a quantidade de itens necessários para um churrasco a partir da quantidade de adultos (que consomem e que não consomem bebidas alcoólicas) e de crianças.

// Item	Por adulto	Por criança
// Carne	400g	200g
// Acompanhamentos	200g	200g
// Cerveja	2l	--
// Refrigerante	500ml	500ml
// Água	400ml	400ml
// Estime cerveja e refrigerantes de acordo com a indicação de consumo dos adultos. Estime refrigerante para todas as crianças. Estime água para todos.

// Exemplo:

// --- Churrasco ---

// Adultos (que consomem bebidas alcoólicas).......: 5
// Adultos (que não consomem bebidas alcoólicas)...: 3
// Crianças........................................: 6

// Carne.............: 4,4kg
// Acompanhamentos...: 2,8kg
// Cerveja...........: 10,0l
// Refrigerante......: 4,5l
// Água..............: 5,6l

// 1° passo: informar o numero de pessoas

Console.WriteLine("Adultos (que consomem bebidas alcoólicas): ");
int adultosBebem = int.Parse(Console.ReadLine()!);
Console.WriteLine("Adultos (que não consomem bebidas alcoólicas): ");
int adultosNaoBebem = int.Parse(Console.ReadLine()!);
Console.WriteLine("Crianças: ");
int criancas = int.Parse(Console.ReadLine()!);
Console.WriteLine();

// 2° passo: calcular a quantidade de cada item

int totalDeAdultos = adultosBebem + adultosNaoBebem;

int totalDePessoas = totalDeAdultos + criancas;

double carne = (totalDeAdultos * 0.4) + (criancas * 0.2); // em Kilogramas
double acompanhamentos = totalDePessoas * 0.2; // em Kilogramas
double cerveja = adultosBebem * 2.0; // em litros
double refrigerante = (adultosNaoBebem * 0.5) + (criancas * 0.5); // em litros
double agua = totalDePessoas * 0.4; // em litros

// 3° passo: arredondar as respostas
cerveja = Math.Round(cerveja, 1);
refrigerante = Math.Round(refrigerante, 1);
agua = Math.Round(agua, 1);
carne = Math.Round(carne, 1);
acompanhamentos = Math.Round(acompanhamentos);

// 4° passo: exibir a quantidade de cada item

Console.WriteLine($"Carne = {carne}kg");
Console.WriteLine($"Acompanhamentos = {acompanhamentos}kg");
Console.WriteLine($"Cerveja = {cerveja}L");
Console.WriteLine($"Refrigerante = {refrigerante}L");
Console.WriteLine($"Água = {agua}L");
