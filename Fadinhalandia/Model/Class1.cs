using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Class1
    {
        private string nome;
        private string corAsa;
        private string elemento;
        private string familia;
        private int idade;
        private double tamanhoAsa;
        private bool asaQuebrada;
        private bool sexo;
        private bool fazBarulho;

        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Nome deve ser preenchido.");
                }
                if (value.Trim().ToLower().Count() < 2)
                {
                    throw new Exception("Nome deve conter no minimo 2 caracteres");
                }
                if (value.Trim().ToLower().Count() > 10)
                {
                    throw new Exception("Nome deve conter no maximo 10 caracteres.");
                }
                elemento = value;
            }
        }
        public string Familia
        {
            get
            {
                return familia;
            }
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new Exception("Familia deve ser preenchido");
                }
                if (value.Trim().ToLower().Count() < 3)
                {
                    throw new Exception("familia deve conter no minimo 3 caracteres");
                }
                if (value.Trim().ToLower().Count() > 20)
                {
                    throw new Exception("Familia deve conter no maximo 20 caracteres");
                }
                familia = value;
            }
        }
        public string CorAsa
        {
            get
            {
                return corAsa;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Cor da asa deve ser preenchido");
                }
                if (value.Trim().ToLower().Count() < 3)
                {
                    throw new Exception("")
                }
            }
        }
    }
}
