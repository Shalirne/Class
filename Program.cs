using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ClassesTotal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = new Stack("Артём", "Борис", "Влад", "Максим");
            a.Add("Сергей", "Юрий", "Иннокентий");
            a.Merge(new Stack("1", "2", "3"), new Stack ("Ильдар", "Николай"));
            var Deleted = a.Pop();
            var s = Stack.Concat(new Stack("a", "b", "c"), new Stack("1", "2", "3"), new Stack("А", "Б", "В"));
            Console.WriteLine($"Извлек верхний элемент {Deleted}, Size = {a.Size}, Top = {a.Top}");
        }
    }
}
