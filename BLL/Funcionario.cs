using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Funcionario
    {
        private DAL.Funcionario _FuncionarioDAL;

        public Funcionario()
        {
            if (_FuncionarioDAL == null)
            {
                _FuncionarioDAL = new DAL.Funcionario();
            }
        }

        public void CreateNewFuncionario(string nome, string cpf, DateTime dtNascimento, string cargo, string salario, int setor)
        {
            DTO.Funcionario Funcionario = _FuncionarioDAL.CreateNewFuncionario(new DTO.Funcionario { 
            
                sNome = nome,
                dNascimento = dtNascimento,
                Money = salario,
                sCargo = cargo,
                nldSetor = setor,
                sCPF = cpf
            
            });
        }
    }
}
