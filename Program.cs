//Console.WriteLine("Digite a nota:");

//double nota = double.Parse(Console.ReadLine());

//if (nota < 5)
//{
//    Console.WriteLine("Aluno Reprovado");
//}

//if (5 <= nota && nota < 7)
//{
//    Console.WriteLine("Aluno de Recuperação");
//}

//if (nota >= 7)
//{
//    Console.WriteLine("Aluno Aprovado");
//}


Console.WriteLine("Digite a nota:");

double nota = double.Parse(Console.ReadLine());

var recuperacao = nota >= 5 ? "Recuperacao" : "Reprovado";
var aprovacao = nota >= 7 ? "Aprovado" : recuperacao;



Console.WriteLine($"Situação: {aprovacao}");
