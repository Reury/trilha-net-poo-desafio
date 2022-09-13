namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
      public Iphone(string numero, string modelo,string imei, int memoria) : base(numero)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            if(nomeApp == String.Empty || nomeApp == null)
            {
                throw new ArgumentException("nome do aplicativo não pode ser vazio");
            }
            else{
                 Console.WriteLine("Instalando o aplicativo " + nomeApp + " no iphone");
            }
            
        }
    }
}