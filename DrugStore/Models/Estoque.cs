using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrugStore.Models
{
    public class Estoque
    {
        public int Id { get; set; }
        public Medicamento Medicamento { get; set; }
        public int Quantidade { get; set; }

        public Estoque()
        {
        }

        public Estoque(int id, Medicamento medicamento)
        {
            Id = medicamento.Id;
            Medicamento = medicamento;
            Quantidade = 0;
        }
    }
}
