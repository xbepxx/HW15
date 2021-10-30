using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW15
{
    class Program
	{
		public static void Main(string[] args)
		{
		}
	}

	interface ISeries
	{
		void SetStart(int x);
		int GetNext();
		void Reset();
	}

	class ArithProgression : ISeries
	{
		public int first; // первый член
		public int value; //значение
		public int d =Convert.ToInt32(Console.ReadLine()); //на сколько увеличиваем прогрессию
		
		public void SetStart(int x) //устанавливаем начальное значение
		{
			x = Convert.ToInt32(Console.ReadLine());
			first = x;
		}
		public int GetNext() //увеличим на d
		{
			value +=d;
			return value;
		}

		public void Reset() //сбросим к началу
		{
			value = first;
		}
	}

	class GeomProgression : ISeries
	{
		private int first; // первый член
		public int value; //значение
		private int d = Convert.ToInt32(Console.ReadLine()); //во сколько увеличиваем прогрессию;
		public int D
        {
			set
            {
                if (d!=0)
                {
					D = value;
                }
				else
                {
                    Console.WriteLine("Введите число, отличное от 0");
                }
            }
			get
            {
				return d;
            }
        }
		public void SetStart(int x) //устанавливаем начальное значение
		{
			x = Convert.ToInt32(Console.ReadLine());
			first = x;
		}
		public int First
		{
			set
			{
				if (first != 0)
				{
					First = value;
				}
				else
				{
					Console.WriteLine("Введите число, отличное от 0");
				}
			}
			get
            {
				return first;
            }
		}
		public int GetNext() //умножим d
		{
			value *= D;
			return value;
		}

		public void Reset() //сбросим к началу
		{
			value = first;
		}
	}
}
