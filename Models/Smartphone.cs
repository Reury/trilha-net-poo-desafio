namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        public String Modelo { get; set;}
        public  String  Imei { get; set; }
        public int Memoria {get;set;}   

        public Smartphone(string numero,string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
            // TODO: Passar os parâmetros do construtor para as propriedades
        }

        protected Smartphone(string numero)
        {
            Numero = numero;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}