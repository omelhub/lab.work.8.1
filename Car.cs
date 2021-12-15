using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab.work._8._1
{
    class Car
    {
        public int Number { set; get; }
        private Engine _engine;
        public Car(int size)
        {
            _engine = new Engine() { Size = size };
        }
        public Engine engine { get { return _engine; } }
    }
}
