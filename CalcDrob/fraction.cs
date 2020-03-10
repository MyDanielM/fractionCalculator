using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcDrob
{
    class fraction
    {
        int bot;

        public int TOP { set; get; }
        public int BOT
        {
            set
            {
                if (value == 0) throw new Exception("Значенатель равен нулю, деление на ноль невозможно!");
                else bot = value;
            }
            get
            {
                return bot;
            }

        }
        /// <summary>
        /// Нахождение НОД
        /// </summary>
        /// <param name="a">первое число</param>
        /// <param name="b">второе число</param>
        /// <returns>НОД</returns>
        private static int gcd(int a, int b)
        {
            if (b == 0)
                return Math.Abs(a);
            return gcd(b, a % b);
        }

        /// <summary>
        /// Перегрузка сложения
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static fraction operator+(fraction a, fraction b)
        {

            fraction result = new fraction();
            if(a.BOT != b.BOT)//если значенатели не равны, то нужно привести к общему знаменателю
            {

            }
            else
            {
                result.TOP = a.TOP + b.TOP;
                result.BOT = a.BOT;
            }

            return result;
        }

        /// <summary>
        /// Перегрузка вычитания
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static fraction operator -(fraction a, fraction b)
        {

            fraction result = new fraction();
            if (a.BOT != b.BOT)//если значенатели не равны, то нужно привести к общему знаменателю
            {

            }
            else
            {
                result.TOP = a.TOP - b.TOP;
                result.BOT = a.BOT;
            }

            return result;
        }
        /// <summary>
        /// Перегрузка умножения
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static fraction operator *(fraction a, fraction b)
        {

            fraction result = new fraction();
            if (a.BOT != b.BOT)//если значенатели не равны, то нужно привести к общему знаменателю
            {

            }
            else
            {
                result.TOP = a.TOP * b.TOP;
                result.BOT = a.BOT;
            }

            return result;
        }

        /// <summary>
        /// Перегрузка деления
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static fraction operator /(fraction a, fraction b)
        {

            fraction result = new fraction();
            if (a.BOT != b.BOT)//если значенатели не равны, то нужно привести к общему знаменателю
            {

            }
            else
            {
               
            }

            return result;
        }
    }
}
