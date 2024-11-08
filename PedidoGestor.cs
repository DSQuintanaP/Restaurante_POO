using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante_POO
{
    public class PedidoGestor
    {
        public string _descripcion { get; set; }
        public string _estado { get;  set; }

        public PedidoGestor(string descripcion, string estado)
        {
            _descripcion = descripcion;
            _estado = "En preparacion";
        }
        public void ActualizarEstado (string estado)
        {
            _estado = estado;
        }
        public override string ToString()
        {
            //return base.ToString();
            return $"descripcion{_descripcion} :estado {_estado}";
        }
    }
}
