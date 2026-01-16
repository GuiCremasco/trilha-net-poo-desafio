namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Abrindo a loja de aplicativos Nokia...");
            Thread.Sleep(1000); // Simula o tempo de abertura da loja

            Console.WriteLine($"Buscando o nome do aplicativo '{nomeApp}'...");
            Thread.Sleep(1000); // Simula o tempo de busca do aplicativo

            Console.WriteLine($"Instalando o aplicativo '{nomeApp}' no seu Nokia...");
            Thread.Sleep(1000); // Simula o tempo de instalação do aplicativo

            Console.WriteLine($"'{nomeApp}' instalado com sucesso no seu Nokia! 🧱");
        }
    }
}