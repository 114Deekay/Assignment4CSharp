using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating array of 5 words
            ArrayList WordDictionary = new ArrayList();
            WordDictionary.Add("Boat");
            WordDictionary.Add("House");
            WordDictionary.Add("Cat");
            WordDictionary.Add("River");
            WordDictionary.Add("Cupboard");

            //Printing the plurals of all words.
            Console.WriteLine("Plural form of all the words :");
            foreach (string word in WordDictionary)
            {
                Console.WriteLine(word+"---->"+word+"s");
            }

            //Replacing the 2nd word, with its synonym and printintig.
            for (int i = 0; i <WordDictionary.Count; i++)
            {
                if ((string)WordDictionary[i] == "House")
                {
                    WordDictionary[i] = "Residence";
                    Console.WriteLine("The word 'House has been replaced with-->"+WordDictionary[i]);
                }
            }

            //Adding a new word to the array list and printing the length of the list.
            WordDictionary.Add("Correct");
            Console.WriteLine("Updated length of the list = "+WordDictionary.Count);


            //Printing the list of words which contains the length of characters as 7.
            Console.WriteLine("Words having the 7 characters length are :-");
            foreach(string word in WordDictionary)
            {
                if(word.Length==7)
                {
                    Console.WriteLine(word);
                }
            }


            //Printing the word on 3rd position.
            Console.WriteLine("The word on 3rd position is-->"+WordDictionary[2]);


            //Printing all the words in ascending order.
            Console.WriteLine("Words Sorted in Ascending order :-");
            WordDictionary.Sort();
            foreach (string word in WordDictionary)
            {
                Console.WriteLine(word);
            }


            //Printing the reverse of an array.
            Console.WriteLine("Words in the reverse order of the list :-");
            WordDictionary.Reverse();
            foreach (string word in WordDictionary)
            {
                Console.WriteLine(word);
            }


            Console.ReadKey();

        }

    }
}
