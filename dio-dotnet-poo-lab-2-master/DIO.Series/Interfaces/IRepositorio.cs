using System.Collections.Generic;

namespace DIO.Series.Interfaces
{
    public interface IRepositorio<T>
    {
       List<T> Lista();
       T RetornPorId(int id);
       void Insere(T entidade);
       void Excluir(int id);
       void Atualizar(int id, T entidade);
       int ProximoId();
    }
}