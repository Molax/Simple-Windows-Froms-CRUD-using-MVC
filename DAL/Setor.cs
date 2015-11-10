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
    public class Setor
    {
        public DTO.Setor CreateNewSetor(DTO.Setor setor)
        {
            using (var db = new BancoEmpresaEntities())
            {
                var SetorRow = db.tblSetor.Create();

                SetorRow.sSetor = setor.sSetor;

                db.tblSetor.Add(SetorRow);

                db.SaveChanges();

                setor.nldSetor = SetorRow.nldSetor;

                return setor;
            }
        }

        public List<DTO.Setor> GetAllSetors()
        {
            using (var db = new BancoEmpresaEntities())
            {
                return db.tblSetor.Select(c => new DTO.Setor { 
                
                    nldSetor = c.nldSetor,
                    sSetor = c.sSetor

                }).ToList();
            }
        }
    }
}
