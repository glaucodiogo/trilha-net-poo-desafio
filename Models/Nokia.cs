namespace DesafioPOO.Models
{
    
    public class Nokia : Smartphone
    {
        List<string> Aplicativos = new List<string>();
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Aplicativos.Add(nomeApp);
            Console.WriteLine($"Instalando {nomeApp}...");
        }
    }
}