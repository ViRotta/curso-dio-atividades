using DesafioPOO.Models;

string numero = "12345678";
string nomeApp = "Aplicativo1";

Iphone i = new(numero);

i.Ligar();
i.ReceberLigacao();
i.InstalarAplicativo(nomeApp);

string numero1 ="1478523";
string nomeApp1 = "Aplicativo2";

Nokia n = new(numero1);

n.Ligar();
n.ReceberLigacao();
n.InstalarAplicativo(nomeApp1);