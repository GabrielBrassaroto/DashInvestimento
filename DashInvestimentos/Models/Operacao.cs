using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DashInvestimentos.Models
{
    public class Operacao
    {
        public int Id { get; set; }

        public string Tipo { get; set; }

        public string Ativo { get; set; }

        public DateTime Date { get; set; }

        public float ValorOperacao { get; set; }

        public int Quantida { get; set; }

    }
}
