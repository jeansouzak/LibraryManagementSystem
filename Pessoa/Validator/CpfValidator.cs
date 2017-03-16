using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Pessoa.Validator
{
    class CpfValidator
    {
        public int calcularDigitoVerificador(int somatorio)
        {
            int resto = somatorio % 11;
            int digitoVerificador = 0;
            if (resto > 2)
            {
                digitoVerificador = 11 - resto;
            }
            return digitoVerificador;
        }
        public int calculaSomatorio(int baseDecrescente, string cpf)
        {
            int somatorio = 0;
            for (int i = 0; i < cpf.Length; i++)
            {
                somatorio += baseDecrescente * int.Parse(cpf[i].ToString());
                baseDecrescente--;

            }
            return somatorio;
        }

        public bool validarCpf(string cpf)
        {            
            int[] digitoVerificado = new int[2];
            int[] somatorio = new int[2];

            if (cpf.Length != 11)
            {
                return false;
            }
            string cpfAlgoritmo = cpf.Substring(0, 9);
            somatorio[0] = calculaSomatorio(10, cpfAlgoritmo);
            digitoVerificado[0] = calcularDigitoVerificador(somatorio[0]);
            cpfAlgoritmo += digitoVerificado[0];
            somatorio[1] = calculaSomatorio(11, cpfAlgoritmo);
            digitoVerificado[1] = calcularDigitoVerificador(somatorio[1]);
            cpfAlgoritmo += digitoVerificado[1];
            if (cpfAlgoritmo.Equals(cpf))
            {
                return true;
            }
            return false;
        }
    }
}
