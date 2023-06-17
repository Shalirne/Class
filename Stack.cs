using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTotal
{
    
    internal class Stack
    {
        private List<string> _storageList { get; set; }
        private int _size;
        public int Size
        {
            get
            {
                return _storageList.Count + 1;
            }
        }

        private string _top;
        public string Top
        {
            get
            {
                if (_storageList.Count - 1 < 0)
                {
                    return null;
                }
                    return _storageList[_storageList.Count - 1];
            }

        }


        public Stack(params string[] a)
        {
            _storageList = a.ToList();
            
        }

        public void Add(params string[] a)
        {
            foreach (string b in a)
            {
                _storageList.Add(b);
            
            }
        }

        public string Pop()
        {
            int a = _storageList.Count - 1;
            if (a < 0)
            {
                throw new Exception("Стек пустой");
            }
            string Deleted = _storageList[a];
            _storageList.RemoveAt(a);
            return Deleted;
        }

        public static Stack Concat(params Stack[] Ollo)
        {
            var StackConcat = new Stack();

            foreach (var item in Ollo)
            {
                for (int i = 0; item.Size - 1 > 0; i++)
                {
                    StackConcat.Add(item.Pop());
                }
                    
            }
            return StackConcat;

        }

    }
}
