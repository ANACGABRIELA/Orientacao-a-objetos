using System;

namespace Classe_veiculos
{
    public class Motor 
    {
        public string TipoMotor { get; set; }
        public string Combustivel { get; set; }
        public string Descricao { get; set; }
        public string Potencia { get; set;}
        public string Torque { get; set; }
        public Motor(string tipoMotor, string combustivel, string descricao, string potencia , string torque)
        {
            this.TipoMotor = tipoMotor;
            this.Combustivel = combustivel;
            this.Descricao = descricao;
            this.Potencia = potencia;
            this.Torque = torque;
        }
        public Motor ()
        { }
    }

    public class Modelo
    {
        public string Descricao { get; set; }
        public Modelo(string descricao)
        {
            this.Descricao = descricao;
        }
        public Modelo ()
        { }
    }

    public class Marca
    {
        public string Descricao { get; set; }
        public string PaisOrigem { get; set; }
        public Marca(string descricao, string paisOrigem)
        {
            this.Descricao = descricao;
            this.PaisOrigem = paisOrigem;
        }
        public Marca()
        { }
    }

    public class Veiculo
    {
        public string Chassi{ get; set; }
        public string Ano { get; set; }
        public  Modelo Modelo { get; set; }
        public   Marca Marca { get; set; }
        public string Preco { get; set; }
        public  Motor Motor { get; set; }
        public Veiculo(string chassi, string ano, string modelo )
        { }
    }

    public class Caminhao: Veiculo
    {
        
        public string Peso { get; set; }
        public string Eixo { get; set; }
        public string Carroceria { get; set; }
        public Caminhao(string peso, string eixo, string carroceria): base(string chassi, string ano, string modelo)
        { }
    }
        

class Program
    {
        static void Main(string[] args)
        {
            Motor tipoMotor = new Motor(Console.ReadLine(),Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine() );
            Modelo modelo = new Modelo(Console.ReadLine());
            Marca marca = new Marca(Console.ReadLine(), Console.ReadLine());
            Veiculo veiculo = new Veiculo(Console.ReadLine(), Console.ReadLine(), Console.ReadLine());


        }
    }
}
