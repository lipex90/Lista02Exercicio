using System;
using System.Collections.Generic;
using System.Text;

namespace Lista_2_exercicios03
{
    class AjusteSalario
    {
        public double  Salario { get; set; }
        public string Funcionario { get; set; }

        public double Reajuste { get; set; }

        public AjusteSalario()
        {

        }

        public AjusteSalario(double salario, string funcionario, double reajuste)
        {
            Salario = salario;
            Funcionario = funcionario;
            Reajuste = reajuste;
        }
       public void SalarioReajuse()
        {
           Reajuste = Reajuste / 100;
        }
        public void SalarioAumento()
        {
            Salario *= Reajuste;
            return;
        }


    }
}
