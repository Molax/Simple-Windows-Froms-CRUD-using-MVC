using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Setor
    {
        private DAL.Setor _SetorDAL;

        public Setor()
        {
            if (_SetorDAL == null)
            {
                _SetorDAL = new DAL.Setor();
            }
        }

        public void CreateNewSetor(string nomeSetor)
        {
            DTO.Setor Setor = _SetorDAL.CreateNewSetor(new DTO.Setor {
            
                sSetor = nomeSetor
            
            });
        }

        public List<DTO.Setor> GetAllSetors()
        {
            List<DTO.Setor> Setores = _SetorDAL.GetAllSetors();

            return Setores;
        }
    }
}
