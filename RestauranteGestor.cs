using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using MesaGestor;

namespace Restaurante_POO
{
    public class RestauranteGestor
    {
        private List<MesaGestor> _tableGestors;
        private List<IngredienteGestor> _ingredientGestors;

        public RestauranteGestor(List<MesaGestor> tableGestors, List<IngredienteGestor> ingredientGestors)
        {
            this._tableGestors = new List<MesaGestor>();
            this._ingredientGestors= new List<IngredienteGestor>();
            for(int i = 1; i < tableGestors.Count; i++)
            {
                tableGestors.Add(new MesaGestor(i));
            }
        }
        //se esta formando una lista con las propiedades de otra clase
        //me distraje asi que no se que tan precisa es la linea superior

        public void AsignarMesa(int numero)
        {
            MesaGestor mesa = _tableGestors.Find(m => m.numero == numero);
            if (mesa == null && mesa.estadoOcupado)
            {
                MesaGestor.Asignar();
            }
        }
        public void LiberarMesa(int numero)
        {
            MesaGestor mesa = _tableGestors.Find(m => m.numero == numero);
            if (mesa == null && mesa.estadoOcupado)
            {
                MesaGestor.Liberar();
            }
        }
        public List<MesaGestor> ObtenerMesa()
        {
            return new List<MesaGestor>(_tableGestors);
        }
        //metodos
        public void TomarPedido (int numeroMesas, PedidoGestor pedidoGestor)
        {
            MesaGestor mesa = _tableGestors.Find(m=>m.numero == numeroMesas);
            if (mesa != null && mesa.estadoOcupado)
            {
                mesa.pedidos.Add(pedidoGestor);
            }
        }
        public List<PedidoGestor> ObtenerPedido (int numeroMesas)
        {
            MesaGestor mesa = _tableGestors.Find(m => m.numero == numeroMesas);
            if (mesa != null && mesa.estadoOcupado)
            {
                return new List<PedidoGestor>(mesa.pedidos);
            }
            return new List<PedidoGestor>();
        }
        public void AnadirIngrediente(IngredienteGestor ingredientGestor)
        {

        }
        public void EliminarIngrediente(string nombre)
        {
            IngredienteGestor ingrediente = _ingredientGestors.Find(i => i._nomIngrediente == nombre);
            if (ingrediente != null &&)
            {
                ingrediente.ActualizarCantidad(cantIngrediente);
            }
        }
        public List<IngredienteGestor> ObtenerInventario()
        {
            return new List<IngredienteGestor>();
        }
    }
}
