using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01Database
{
    public class Database
    {
        private int[] array;
        private int count;

        public Database()
        {
            this.array = new int[16];
        }


        public Database(int[] ints)
        {
            this.array = new int[16];
            for (int i = 0; i < ints.Length; i++)
            {
                this.array[i] = ints[i];
                count++;
            }
        }

        public int Count
        {
            get
            {
                return this.count;
            }
        }

        public int[] Array
        {
            get
            {
                return this.array;
            }
        }

        public void Add(int number)
        {
            if (count == 16)
            {
                throw new InvalidOperationException();
            }
            array[count] = number;
            count++;
        }

        public void Remove()
        {
            if (count == 0)
            {
                throw new InvalidOperationException();
            }
            array[count - 1] = 0;
            count--;
        }

        public int[] Fetch()
        {
            int[] arrayToReturn = new int[this.count];

            for (int i = 0; i < arrayToReturn.Length; i++)
            {
                arrayToReturn[i] = array[i];
            } 
            return arrayToReturn;
        }

    }
}
