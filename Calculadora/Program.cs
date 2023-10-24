using Calculadora.Services;

CalculadoraImp c = new CalculadoraImp();

int a = 1;
int b = 1;

Console.WriteLine($"Soma de {a} + {b} = {c.Somar(a,b)}");
