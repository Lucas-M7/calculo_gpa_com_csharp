string nomeDoEstudante = "Lucas Mateus";
string primeiroCurso = "Inglês 101";
string segundoCurso = "Ciências da Computação I";
string terceiroCurso = "Filosofia 101";
string quartoCurso = "Astrônomia 101";

int pontosPrimeiroCurso = 3;
int pontosSegundoCurso = 4;
int pontosTerceiroCurso = 4;
int pontosQuartoCurso = 4;

int gradeA = 4;
int gradeB = 3;

int gradePrimeiroCurso = gradeB;
int gradeSegundoCurso = gradeA;
int gradeTerceiroCurso = gradeA;
int gradeQuartoCurso = gradeA;

int totalDePontosPorHora = 0;
totalDePontosPorHora += pontosPrimeiroCurso;
totalDePontosPorHora += pontosSegundoCurso;
totalDePontosPorHora += pontosTerceiroCurso;
totalDePontosPorHora += pontosQuartoCurso;

int totalDePontosPorGrade = 0;
totalDePontosPorGrade += pontosPrimeiroCurso * gradePrimeiroCurso;
totalDePontosPorGrade += pontosSegundoCurso * gradeSegundoCurso;
totalDePontosPorGrade += pontosTerceiroCurso * gradeTerceiroCurso;
totalDePontosPorGrade += pontosQuartoCurso * gradeQuartoCurso;

decimal gradeMedia = (decimal)totalDePontosPorGrade / totalDePontosPorHora;

int digitoAEsquerda = (int)gradeMedia;
int primeiroDigito = (int)(gradeMedia * 10) % 10;
int segundoDigito = (int)(gradeMedia * 100) % 10;

Console.WriteLine($"Estudante: {nomeDoEstudante}\n");
Console.WriteLine("Curso\t\t\t\tGrade\tCarga Horária");

Console.WriteLine($"{primeiroCurso}\t\t\t{gradePrimeiroCurso}\t\t{pontosPrimeiroCurso}");
Console.WriteLine($"{segundoCurso}\t{gradeSegundoCurso}\t\t{pontosSegundoCurso}");
Console.WriteLine($"{terceiroCurso}\t\t\t{gradeTerceiroCurso}\t\t{pontosTerceiroCurso}");
Console.WriteLine($"{quartoCurso}\t\t\t{gradeQuartoCurso}\t\t{pontosQuartoCurso}\n");

Console.WriteLine($"Final GPA:\t\t\t{digitoAEsquerda}.{primeiroDigito}{segundoDigito}");