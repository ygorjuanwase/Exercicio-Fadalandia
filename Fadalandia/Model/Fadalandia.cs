using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Fadalandia
    {
        private string nome;
        private string familia;
        private string corAsa;
        private int tamanhoAsa;
        private bool asaQuebrada;
        private bool mulher;
        private bool fazBarulho;
        private string elemento;
        private int idade;


        public string Nome
        {
            get { return nome;}
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Nome da fada deve ser preechido carretamente");
                }
                if (value.Trim().Count() == 2)
                {
                    throw new Exception("Nome da fada deve conter no minimo 2 caracteres");
                }
                if (value.Trim().Count() > 50)
                {
                    throw new Exception("Nome da fada deve conter no maximo 50 caracteres");
                }
                nome = value;
            }
        }
        public string Familia
        {
            get { return familia; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Familia deve ser preenchido");
                }
                if (value.Trim().Count() == 6)
                {
                    throw new Exception("familia dve conter no mínimo 6 caracters");
                }
                if (value.Trim().Count() >= 100)
                {
                    throw new Exception("Familia deve conter no maximo 100 caracteres");
                }
                familia = value;
            }
        }
        public string CorAsa
        {
            get { return corAsa; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Cor da asa deve ser preenchido");
                }
                if (value.Trim().Count() == 4)
                {
                    throw new Exception("cor da asa deve conter no mínimo 4 caracters");
                }
                if (value.Trim().Count() >= 10)
                {
                    throw new Exception("Cor da asa deve conter no maximo 10 caracteres");
                }
                corAsa = value;
            }
        }
        public int TamanhoAsa
        {
            get { return tamanhoAsa; }
            set
            {
               
                if (value  <= 0)
                {
                    throw new Exception("Tamanho da asa deve ser maior que zero.");
                }
                if (value > 10)
                {
                    throw new Exception("Você não vai conseguir carregar uma asa com mais de 10 metros que eu sei.Tamanho da asa deve ser menor que 10 metros;");
                }
                tamanhoAsa = value;
            }
        }
        public bool AsaQuebrada
        {
            get { return asaQuebrada; }
            set
            {
            }
        }
        public bool Mulher
        {
            get { return mulher; }
            set
            {
            }
        }
        public bool FazBarulho
        {
            get { return fazBarulho; }
            set
            {
            }
        }
        public string Elemento
        {
            get { return elemento; }
            set
            {

                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Elemento deve ser preenchido.");
                }
                if (value.Trim().Count() < 4)
                {
                    throw new Exception("Elemento deve conter no minimo 4 caracteres.");
                }
                if (value.Trim().Count() > 15)
                {
                    throw new Exception("Elemento deve conter no maximo 15 caracteres");
                }
                elemento = value;
            }
        }
        public int Idade
        {
            get { return idade; }
            set
            {

                if (value >50)
                {
                    throw new Exception("Você esta cansada pode parar e relaxar.");
                }
                
                if (value <= 2)
                {
                    throw new Exception("Idade deve ser maior ou igual 2(dois) anos");
                }
                idade = value;
            }
        }

        

    }
}
