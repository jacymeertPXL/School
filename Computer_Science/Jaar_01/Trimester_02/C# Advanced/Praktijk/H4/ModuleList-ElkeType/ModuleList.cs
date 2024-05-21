using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleList_ElkeType
{
    public class ModuleList<T> // T Wordt gerbuikt voor elk datetype
    {
        private List<T> list = new List<T>();

        public void Add(T item)
        {
            list.Add(item);
        }

        public int count
        {
            get { return list.Count; }
        }

        public override string ToString()
        {
            string listGeg = "";
            {
                for (int i = 0; i < list.Count; i++)
                {
                    listGeg += list[i].ToString() + "\n";
                }
                return listGeg;
            }
        }
    }
}
