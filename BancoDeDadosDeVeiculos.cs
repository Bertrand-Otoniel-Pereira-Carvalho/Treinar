using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Treinar
{
    // Classe Pai Veiculo
    public class Veiculo
    {
        private List<string> nome {get;set;}= new List<string>();
        
        public void Apresentar()
        {
            System.Console.WriteLine($"{nome[0]}");
            foreach (string nomes in nome)
            {
                System.Console.Write($"{nomes}, ");
            }
        }
        public string Adicionar
        {
            set
            {
                string a = value;
                nome.Add(a);
            }
        }
    }
    // Classe Filha Carro
    public class Carro : Veiculo
    {
        Veiculo x = new Veiculo();
        public void DefinirNome()
        {
            x.Adicionar = "Corolla";
        }
    }
    public class Motos
    {

    }
    public class Caminhões
    {

    }

}