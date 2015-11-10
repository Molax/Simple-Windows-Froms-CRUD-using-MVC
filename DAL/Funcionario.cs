using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DATA;
using System.Data;

namespace DAL
{
    public class Funcionario
    {
        public DTO.Funcionario CreateNewFuncionario(DTO.Funcionario funcionario)
        {
            using (var db = new BancoEmpresaEntities())
            {
                var FuncionarioRow = db.tblFuncionario.Create();

                FuncionarioRow.nldSetor = funcionario.nldSetor;

                FuncionarioRow.sCargo = funcionario.sCargo;

                FuncionarioRow.sCPF = funcionario.sCPF;

                FuncionarioRow.sSalario = funcionario.Money;

                FuncionarioRow.sNome = funcionario.sNome;

                FuncionarioRow.sNascimento = funcionario.dNascimento;

                db.tblFuncionario.Add(FuncionarioRow);

                db.SaveChanges();

                funcionario.nldFuncionario = FuncionarioRow.nldFuncionario;

                return funcionario;
            }
        }
    }
}
