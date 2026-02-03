using System.Linq.Expressions;
using David_BritoAP1_P1.DAL;
using David_BritoAP1_P1.Models;
using Microsoft.EntityFrameworkCore;

namespace David_BritoAP1_P1.Services
{
    public class ViajesEspacialesService(IDbContextFactory<Contexto> DbFactory)
    {
        public async Task<bool> Guardar(ViajesEspaciales viajesEspaciales)
        {
            return true;
        }

        public async Task<bool> Existe(ViajesEspaciales viajesEspaciales)
        {
            return true;
        }

        public async Task<bool> Insertar(ViajesEspaciales viajesEspaciales)
        {
            return true;
        }

        public async Task<bool> Modificar(ViajesEspaciales viajesespaciales)
        {
            return true;
        }


        /*public async Task<ViajesEspaciales?> Buscar(int ViajeId)
        {
            return 
        }
        */

        public async Task<bool> Eliminar(int ViajeID)
        {
            return true;
        }
        public async Task<List<ViajesEspaciales>> Listar(Expression<Func<ViajesEspaciales, bool>> criterio)
        {
            await using var contexto = await DbFactory.CreateDbContextAsync();
            return await contexto.ViajesEspaciales.Where(criterio).AsNoTracking().ToListAsync();
        }

    }
}
