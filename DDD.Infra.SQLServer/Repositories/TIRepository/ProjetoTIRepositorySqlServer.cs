using DDD.Domain.TI;
using DDD.Infra.SQLServer.Interfaces.TIInterface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Infra.SQLServer.Repositories.TIRepository
{
    public class ProjetoTIRepositorySqlServer : IProjetoTIRepository
    {
        private readonly SqlContext _context;
        public ProjetoTIRepositorySqlServer(SqlContext context)
        {
            _context = context;
        }
        public List<ProjetoTI> GetProjetosTI()
        {
            return _context.ProjetosTI.ToList();
        }
        public ProjetoTI GetProjetoTIById(int id)
        {
            return _context.ProjetosTI.Find(id);
        }
        public void InsertProjetoTI(ProjetoTI projetoTI)
        {
            _context.ProjetosTI.Add(projetoTI);
            _context.SaveChanges();
        }
        public void UpdateProjetoTI(ProjetoTI projetoTI)
        {
            _context.Entry(projetoTI).State = EntityState.Modified;
            _context.SaveChanges();
        }
        public void DeleteProjetoTI(ProjetoTI projetoTI)
        {
            _context.Set<ProjetoTI>().Remove(projetoTI);
            _context.SaveChanges();
        }
    }
}
