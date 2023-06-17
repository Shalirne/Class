using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTotal
{
    static class StackExtensions
    {
        public static Stack Merge (this Stack StorageList1, params Stack [] Calculate)
        {
            foreach (Stack Storage in Calculate)
            {
                for (int i = 0; i < Storage.Size + 1 ; i++)
                {
                    StorageList1.Add(Storage.Pop());
                }
            }

            return StorageList1;
        }

    }

}
        

