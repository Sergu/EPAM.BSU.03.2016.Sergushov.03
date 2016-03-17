using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Polinom
    {
        public int[] arr { get; private set; }

        public Polinom(params int[] arr)
        {
            if (arr == null)
            {
                throw new NullReferenceException();
            }
            this.arr = arr;
        }
        public static Polinom operator +(Polinom polinom1, Polinom polinom2)
        {
            int[] sumResult;
            if (polinom1.arr.Length > polinom2.arr.Length)
            {
                sumResult = new int[polinom1.arr.Length];
                for (int i = 0; i < polinom2.arr.Length; i++)
                {
                    sumResult[i] = polinom1.arr[i] + polinom2.arr[i];
                }
                for (int i = polinom2.arr.Length; i < polinom1.arr.Length; i++)
                {
                    sumResult[i] = polinom1.arr[i];
                }
            }
            else
            {
                sumResult = new int[polinom2.arr.Length];
                for (int i = 0; i < polinom1.arr.Length; i++)
                {
                    sumResult[i] = polinom1.arr[i] + polinom2.arr[i];
                }
                for (int i = polinom1.arr.Length; i < polinom2.arr.Length; i++)
                {
                    sumResult[i] = polinom2.arr[i];
                }
            }
            Polinom sumPolinom = new Polinom(sumResult);
            return sumPolinom;
        }
        public static Polinom operator -(Polinom polinom1, Polinom polinom2)
        {
            int[] subResult;
            if (polinom1.arr.Length > polinom2.arr.Length)
            {
                subResult = new int[polinom1.arr.Length];
                for (int i = 0; i < polinom2.arr.Length; i++)
                {
                    subResult[i] = polinom1.arr[i] - polinom2.arr[i];
                }
                for (int i = polinom2.arr.Length; i < polinom1.arr.Length; i++)
                {
                    subResult[i] = polinom1.arr[i];
                }
            }
            else
            {
                subResult = new int[polinom2.arr.Length];
                for (int i = 0; i < polinom1.arr.Length; i++)
                {
                    subResult[i] = polinom1.arr[i] - polinom2.arr[i];
                }
                for (int i = polinom1.arr.Length; i < polinom2.arr.Length; i++)
                {
                    subResult[i] = 0 - polinom1.arr[i];
                }
            }
            return new Polinom(subResult);
        }
        public static Polinom operator *(Polinom polinom1, Polinom polinom2)
        {
            int[] mulResult;
            if (polinom1.arr.Length > polinom2.arr.Length)
            {
                mulResult = new int[polinom2.arr.Length];
                for (int i = 0; i < polinom2.arr.Length; i++)
                {
                    mulResult[i] = polinom1.arr[i] * polinom2.arr[i];
                }

            }
            else
            {
                mulResult = new int[polinom1.arr.Length];
                for (int i = 0; i < polinom1.arr.Length; i++)
                {
                    mulResult[i] = polinom1.arr[i] * polinom2.arr[i];
                }
            }
            return new Polinom(mulResult);
        }
        public override int GetHashCode()
        {
            unchecked
            {
                if (arr == null)
                {
                    return 0;
                }
                int hash = 13;
                foreach (int element in arr)
                {
                    hash = hash * 19 + element;
                }
                return hash;
            }
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            Polinom polinom = obj as Polinom;
            if (polinom == null)
            {
                return false;
            }
            if (this == (Polinom)obj)
            {
                return true;
            }
            if (this.arr.Length != polinom.arr.Length)
            {
                return false;
            }
            for (int i = 0; i < this.arr.Length; i++)
            {
                if (this.arr[i] != polinom.arr[i])
                {
                    return false;
                }
            }
            return true;
        }
        public override string ToString()
        {
            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < this.arr.Length; i++)
            {
                strBuilder.Append("{0}*X({1}) + ", this.arr[i], i);
            }
            return strBuilder.ToString();
        }
    }
}
