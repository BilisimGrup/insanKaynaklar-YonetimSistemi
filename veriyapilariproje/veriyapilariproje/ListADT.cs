using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veriyapilariproje
{
    [Serializable()]
    public abstract class LinkedListADT
    {
        public Node Head;
        public int Size = 0;
        public abstract void Insertbas(object value);
        public abstract void Insertson(object value);
        public abstract void Insertpoz(int position, object value);
        public abstract void Deletebas();
        public abstract void Deleteson();
        public abstract void Deletepoz(int position);
        public abstract Node Geteleman(int position);

        public abstract string Displayeleman();
    }
}

