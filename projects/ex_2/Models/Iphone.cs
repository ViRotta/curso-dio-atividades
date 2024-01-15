
namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"


    public class Iphone : Smartphone
    {
        public Iphone(string numero) : base(numero)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
           Console.WriteLine($"Instalado aplicativo {nomeApp} no Iphone");
        }

    }
}