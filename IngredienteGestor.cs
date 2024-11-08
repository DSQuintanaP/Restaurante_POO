using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante_POO
{
    public class IngredienteGestor
    {
        public string _nomIngrediente { get; set; }
        public int _cantIngrediente { get; set; }

        public IngredienteGestor(string nomIngrediente, int cantIngrediente)
        {
            _nomIngrediente = nomIngrediente;
            _cantIngrediente = cantIngrediente;
        }
        public void ActualizarCantidad(int cantIngrediente)
        {
            _cantIngrediente = cantIngrediente;
            
        }
        public override string ToString()
        {
            //return base.ToString();
            return $"Ingrediente {_nomIngrediente}, Cantidad {_cantIngrediente}";
        }
    }
}
