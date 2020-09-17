using System.Diagnostics;

namespace ValidaCNPJCore
{
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public class Validar
    {
        //public Validar()
        //{
        //}

        public static bool CNPJ(string cnpj)
        {
            int soma, resto;
            string digitoVerificador, cnpjValidado;

            cnpj = cnpj.Trim();
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");

            if (cnpj.Length == 14)
            {
                cnpjValidado = cnpj.Substring(0, 12);

                soma = 0;
                for (int i = 12 - 1; i >= 0; i--)
                {
                    int[] vs = new int[12]
                    {
                5,4,3,2,9,8,7,6,5,4,3,2
                    };
                    soma += int.Parse(cnpjValidado[i].ToString()) * vs[i];
                }

                resto = soma % 11;
                resto = resto < 2 ? 0 : 11 - resto;

                digitoVerificador = resto.ToString();

                cnpjValidado += digitoVerificador;
                soma = 0;
                for (int i = 13 - 1; i >= 0; i--)
                {
                    int[] vs1 = new int[13]
                    {
                6,5,4,3,2,9,8,7,6,5,4,3,2
                    };
                    soma += int.Parse(cnpjValidado[i].ToString()) * vs1[i];
                }

                resto = soma % 11;
                resto = resto < 2 ? 0 : 11 - resto;

                digitoVerificador += resto.ToString();

                return cnpj.EndsWith(digitoVerificador);
            }
            return false;
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}
