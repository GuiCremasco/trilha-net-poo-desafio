namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Abrindo a App Store...");
            Thread.Sleep(100); // Simula o tempo de abertura da App Store (tempo menor, pois é mais rápido)

            Console.WriteLine($"Buscando o nome do aplicativo '{nomeApp}'...");
            Thread.Sleep(100); // Simula o tempo de busca do aplicativo

            Console.WriteLine($"Instalando o aplicativo '{nomeApp}' no seu iPhone...");
            Thread.Sleep(100); // Simula o tempo de instalação do aplicativo

            Console.WriteLine($"'{nomeApp}' instalado com sucesso no seu iPhone! 🍎");
        }
    }
}