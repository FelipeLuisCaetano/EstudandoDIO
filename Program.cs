// See https://aka.ms/new-console-template for more information
using ProjetoRPG.src.Entities;

Knight arus = new Knight("Arus", 23, "Knight");
Wizard wizard = new Wizard("Jennica", 23, "White Wizard");
Wizard bruxao = new Wizard("Geralt", 90, "Bruxo");
 

Console.WriteLine(arus.Attack());
Console.WriteLine(wizard.Attack());
Console.WriteLine(wizard.Attack(5));
Console.WriteLine(bruxao.Attack(8));

