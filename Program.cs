using DesafioPOO.Models;

// Realizar os testes com as classes Nokia e Iphone
Smartphone nokia = new Nokia("(19) 99999-9999", "Asha 305", "111111111111111", 32);
nokia.Ligar();
nokia.InstalarAplicativo("Chuzzle"); // esse jogo era muuuuito bom! :D

Console.WriteLine("\n");

Smartphone iPhone = new Iphone("+1 (555) 555-5555", "iPhone 13 Pro", "222222222222222", 128_000);
iPhone.ReceberLigacao();
iPhone.InstalarAplicativo("Instagram");