using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Florae_Basket
{
    class Word_Search
    {
        struct Candidate
        {
            string contents;
            int id;
            int score;
        };

        private int[] results = new int[3];
        private string name;
        private string latin;
        private string botan;
        private LinkedList<Candidate> possible_names;
        private LinkedList<Candidate> possible_latin;
        private LinkedList<Candidate> possible_botan;

        public Word_Search(string enl_name, string latin_name, string botan_name)
        {
            name = enl_name;
            latin = latin_name;
            botan = botan_name;
        }

        public string get_name()
        {
            return name;
        }

        public string get_latin()
        {
            return latin;
        }

        public string get_botan()
        {
            return botan;
        }

        public int[] get_results()
        {
            return results;
        }

        private int LCS(string entry, string cand, int x, int y)
        {
            if (x == 0 || y == 0)
            {
                return 0;
            }
            else if (entry[x] == cand[y])
            {
                return Math.Max(1 + LCS(entry, cand, x - 1, y - 1), Math.Max(LCS(entry, cand, x - 1, y), LCS(entry, cand, x, y - 1)));
            }
            else
            {
                return Math.Max(LCS(entry, cand, x - 1, y), LCS(entry, cand, x, y - 1));
            }
        }

        private void Fetch_names(string name)
        {
            
        }

        private void Fetch_latin(string latin)
        {

        }

        private void Fetch_botan(string botan)
        {

        }

        public void Search()
        {

        }
    }
}
