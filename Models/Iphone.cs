namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        //construtor por herança. vazio herdando os dados de base, que é o Smartphone
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }

        public override void InstalarAplicativo(string nome)
        {
            Console.WriteLine("Instalando App" + nome + "no Iphone");
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
    }
}