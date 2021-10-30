using System;
using System.Collections.Generic;
using System.Text;

namespace APS_Front.Models
{
    class Poluicao
    {
        public string arPoluicao { get; set; }

        public Poluicao() { }

        public Poluicao(string arPoluicao) {
            this.arPoluicao = arPoluicao;
        }
    }
}