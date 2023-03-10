using System;

namespace Task1_2
{
    class StringList
    {
        string[] strList;
        int currentIndex = 0;
        const int listSize = 100;

        public StringList()
        {
            strList = new string[listSize];
        }

        public void Insert(string str)
        {
            if (currentIndex <= listSize - 1)
            {
                strList[currentIndex] = str;
                currentIndex++;
            }
            else
            {
                throw new Exception("The array is filled up!");
            }
        }

        public void Delete(int position)
        {
            if ((position >= 0) && (position <= listSize - 1))
            {
                for (int i = position; i < currentIndex; i++)
                {
                    strList[i] = strList[i+1];
                }
                currentIndex--;
            }
            else
            {
                throw new Exception("Incorrect index to delete!");
            }
        }

        public int Search(string str)
        {
            for (int i = 0; i < currentIndex; i++)
            {
                if (strList[i] == str)
                {
                    return i;
                }
            }
            return -1;
        }

        public void Update(int position, string newstr)
        {
            if ((position >= 0) && (position < currentIndex))
            {
                strList[position] = newstr;
                return;
            }
            else
            {
                throw new Exception("Incorrect index to update!");
            }
        }

        public string GetAt(int position)
        {
            if ((position >= 0) && (position < currentIndex))
            {
                return strList[position];
            }
            else
            {
                throw new Exception("Incorrect index to get string!");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            StringList stringList = new StringList();

            stringList.Insert("The");
            stringList.Insert("quick");
            stringList.Insert("brown");
            stringList.Insert("fox...");

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(stringList.GetAt(i));
            }
            Console.WriteLine("");

            stringList.Delete(1);

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(stringList.GetAt(i));
            }
            Console.WriteLine("");

            stringList.Update(1, "black");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(stringList.GetAt(i));
            }
            Console.WriteLine("");
        }
    }
}
