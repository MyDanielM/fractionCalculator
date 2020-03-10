using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcDrob
{
    class fullFraction:fraction
    {
        int fullValue;
        public int FULLValue{
            set { fullValue = value; }
            get { return fullValue; }
        }

        public fullFraction()
        {
            fullValue = 0;
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
        private static fraction getFraction(fullFraction tmp)
        {
            fraction newFr = new fraction();
            if (tmp.FULLValue == 0)
            {
                newFr.TOP = tmp.TOP;
                newFr.BOT = tmp.BOT;
            }
            else
            {
                newFr.TOP = tmp.fullValue * tmp.BOT + tmp.TOP;
                newFr.BOT = tmp.BOT;
            }

            return newFr;
        }
        public static fullFraction operator +(fullFraction a, fullFraction b)
        {

            fullFraction result = new fullFraction();
            if (a.BOT != b.BOT)//если значенатели не равны, то нужно привести к общему знаменателю
            {
                fraction first = getFraction(a);
                fraction second = getFraction(b);


                int LCD = first.BOT * second.BOT / (gcd(first.BOT, second.BOT));
                first.TOP*= LCD / first.BOT;
                second.TOP *= LCD / second.BOT;
                result.TOP = first.TOP + second.TOP;
                result.BOT = LCD;

            }
            else
            {
                fraction first = getFraction(a);
                fraction second = getFraction(b);

                result.TOP = first.TOP + second.TOP;
                result.BOT = first.BOT;

            }
            while (result.TOP >= result.BOT)
            {
                result.FULLValue++;
                result.TOP -= result.BOT;
            }


            return result;
        }

        /// <summary>
        /// Перегрузка вычитания
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static fullFraction operator -(fullFraction a, fullFraction b)
        {

            fullFraction result = new fullFraction();
            if (a.BOT != b.BOT)//если значенатели не равны, то нужно привести к общему знаменателю
            {
                fraction first = getFraction(a);
                fraction second = getFraction(b);

                int LCD = first.BOT * second.BOT / (gcd(first.BOT, second.BOT));
                first.TOP *= LCD / first.BOT;
                second.TOP *= LCD / second.BOT;
                result.TOP = first.TOP - second.TOP;
                result.BOT = LCD;
            }
            else
            {
                fraction first = getFraction(a);
                fraction second = getFraction(b);

                result.TOP = first.TOP - second.TOP;
                result.BOT = first.BOT;
            }
            while (result.TOP >= result.BOT)
            {
                result.FULLValue++;
                result.TOP -= result.BOT;
            }

            return result;
        }
        /// <summary>
        /// Перегрузка умножения
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static fullFraction operator *(fullFraction a, fullFraction b)
        {

            fullFraction result = new fullFraction();
            
                fraction first = getFraction(a);
                fraction second = getFraction(b);

                result.TOP = first.TOP * second.TOP;
                result.BOT = first.BOT * second.BOT;
            
            while (result.TOP >= result.BOT)
            {
                result.FULLValue++;
                result.TOP -= result.BOT;
            }

            return result;
        }

        /// <summary>
        /// Перегрузка деления
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static fullFraction operator /(fullFraction a, fullFraction b)
        {

            fullFraction result = new fullFraction();

                fraction first = getFraction(a);
                fraction second = getFraction(b);

                result.TOP = first.TOP * second.BOT;
                result.BOT = first.BOT * second.TOP;

            while (result.TOP >= result.BOT)
            {
                result.FULLValue++;
                result.TOP -= result.BOT;
            }

            return result;
        }




    }
}
