using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Construtor
{
    public class Cadeira 
    {
        public string cor;
        public double peso; 
        public double altura;


        
     public Cadeira()
    {
        
    }

    public Cadeira(string _cor, double _peso, double _altura)
    {
        this.cor = _cor;
        this.peso = _peso;
        this.altura = _altura;
        
    }

    }

}