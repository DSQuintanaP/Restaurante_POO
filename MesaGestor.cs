using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante_POO
{
    //Clase
    public class MesaGestor
    {
        //Propiedades
        public int numero { get; set; }
        public bool estadoOcupado { get; set; }
        public List<PedidoGestor> pedidos { get; set;}

        //Constructor
        //se puede considerar borrar el bool y list del constructor, el profe dice que no deberia afectar el codigo
        //al ser bool se puede escribir false o true en este caso se escogio false
        public MesaGestor(int numero)
        {
            this.numero = numero;
            this.estadoOcupado = false;
            this.pedidos = new List<PedidoGestor>();
        }
        //metodos
        public void Asignar ()
        {
            estadoOcupado = true;
        }
        public void Liberar ()
        {
            estadoOcupado &= true;
            pedidos.Clear();
        }
        public override string ToString()
        {
            //return base.ToString();
            return $"Mesa{numero}:{estadoOcupado}: ocupado : libre";
        }
    }
}
