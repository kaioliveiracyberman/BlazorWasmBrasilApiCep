using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWasmBrasilApiCep
{
    public class Cep
    {
      public string cep { get; set; }
        public string state { get; set; }
        public string city { get; set; }
        public string neighborhood { get; set; }
        public string street { get; set; }
        public string 	service { get; set; }
        public ibge ibge { get; set; }
        }
}