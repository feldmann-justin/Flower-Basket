using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//////////////////////////////////////////////////
//                                              //
//  Word_Search                                 //
//  by Brady Smith                              //
//                                              //
//////////////////////////////////////////////////

namespace Florae_Basket
{
    class Word_Search
    {
        //contains the string of the candidate, as well as the database key
        //and the score calculated from the LCS method.
        public struct Candidate
        {
            public string contents;
            public int    id;
            public double score;
        };

        //value for a candidate to be considered a "winner"
        private const double THRESHOLD = 0.66;

        private Candidate[] results    = new Candidate[3];          //array containing the database id of the 3 best results.
        private Candidate[] best_names = new Candidate[3];          //arrays containging the 3 best candidates for every entry.
        private Candidate[] best_latin = new Candidate[3];
        private Candidate[] best_botan = new Candidate[3];
        private string name;
        private string latin;
        private string botan;
        private LinkedList<Candidate> possible_names = new LinkedList<Candidate>();  //Linked list containing the Candidates pulled from the database.

        public Word_Search(string enl_name, string latin_name, string botan_name)
        {
            name =  enl_name;
            latin = latin_name;
            botan = botan_name;
        }

        //***THIS METHOD IS FOR TESTING PURPOSES ONLY, IT SHOULD NOT EXIST IN THE FINAL PRODUCT!***//
        private void Test_PN_populate(string one, string two, string three, string four,
                                      int id1, int id2, int id3, int id4)
        {
            Candidate temp = new Candidate();
            temp.contents = one;
            temp.id = id1;
            possible_names.AddLast(temp);
            temp.contents = two;
            temp.id = id2;
            possible_names.AddLast(temp);
            temp.contents = three;
            temp.id = id3;
            possible_names.AddLast(temp);
            temp.contents = four;
            temp.id = id4;
            possible_names.AddLast(temp);

        }

        public string Get_name()
        {
            return name;
        }

        public string Get_latin()
        {
            return latin;
        }

        public string Get_botan()
        {
            return botan;
        }

        public Candidate[] Get_results()
        {
            return results;
        }

        //Longest Common SubString
        //Calculates the match score for two strings.
        //This score represents the number of characters each string has in common.
        private int LCS(string entry, string cand, int x, int y)
        {
            //base case
            if (x == 0 || y == 0)
            {
                if (x == 0 && y == 0 && entry[x] == cand[y])
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            //when a letter matches add one to score
            else if (entry[x] == cand[y])
            {
                return Math.Max(1 + LCS(entry, cand, x - 1, y - 1), Math.Max(LCS(entry, cand, x - 1, y), LCS(entry, cand, x, y - 1)));
            }
            //when letter does not match evaluate 
            else
            {
                return Math.Max(LCS(entry, cand, x - 1, y), LCS(entry, cand, x, y - 1));
            }
        }

        //Fetch english names from the Database using just first letter of the search entry
        //Stores results into linked list that is passed by reference
        private void Fetch_names(string name, ref LinkedList<Candidate> list)
        {
            try
            {
                //TODO
                //Query the database using ***ONLY THE FIRST LETTER*** of the entered word
                //The database will return every entry it holds that begins with that letter
                //The database will only return candidates from that column.
            }
            catch (Exception)
            {
                throw;
            }
        }

        private string Fetch_botanical(int id)
        {
            try
            {
                //TODO 
                //Query the database using the ID of the entry in question.
                //Will return the botanical name of the entry
                //This exists in order to compare English names and Latin names in order to help decide
                //which one the user might be looking for.
            }
            catch (Exception)
            {
                throw;
            }
            return "";
        }

        //compares the english and latin name candidates to find the best 3 candidates.
        //uses botanical family if scores of english and latin names being compared are too close.
        private void Compare()
        {
            //These integers will increment if a candidate out of a certain category is selected. 
            //This makes sure the next candidate in that category will be evaluated next.
            int name_itr  = 0;
            int latin_itr = 0;
            int botan_itr = 0;
            //temporary string for comparing botanical families between english names and latin names.
            string temp_botan1, temp_botan2 = "";
            double temp_score1, temp_score2 = 0;

            //loops 3 times in order to populate results
            for (int i = 0; i < 3; i++)
            {
                //checks best_latin to see if there was any score at all
                //if latin score is zero best english name will take the next spot in results.
                if (best_latin[latin_itr].score == 0 && best_names[name_itr].score > 0)
                {
                    results[i] = best_names[name_itr];
                    name_itr++;
                }
                //does the same as previous statement but with the latin name
                else if (best_names[name_itr].score == 0 && best_latin[latin_itr].score > 0)
                {
                    results[i] = best_latin[latin_itr];
                    latin_itr++;
                }
                //if both latin and english scores are zero best next botanical candidate is used.
                else if (best_names[name_itr].score == 0 && best_latin[latin_itr].score == 0)
                {
                    results[i] = best_botan[botan_itr];
                    botan_itr++;
                }
                //if both latin and english scores are above zero a more thorough comparison will follow.
                else if (best_latin[latin_itr].score > 0 && best_names[name_itr].score > 0)
                {
                    //makes sure latin and english names are not actually from the same entry.
                    if (best_latin[latin_itr].id == best_names[name_itr].id)
                    {
                        results[i] = best_names[name_itr];
                        name_itr++;
                        latin_itr++;
                    }
                    //checks if both names are above a predetermined scoring threshold 
                    else if (best_names[name_itr].score > THRESHOLD && best_latin[latin_itr].score < THRESHOLD)
                    {
                        results[i] = best_names[name_itr];
                        name_itr++;
                    }
                    else if (best_latin[latin_itr].score > THRESHOLD && best_names[name_itr].score < THRESHOLD)
                    {
                        results[i] = best_latin[latin_itr];
                        latin_itr++;
                    }
                    //if both names are above the threshold and a botanical candidate has a score greater than 0
                    //this will run LCS on the botanical families of both names. The closest match is selected.
                    else if(best_botan[0].score > 0)
                    {
                        temp_botan1 = Fetch_botanical(best_names[name_itr].id);
                        temp_botan2 = Fetch_botanical(best_latin[latin_itr].id);
                        temp_score1 = LCS(temp_botan1, best_botan[0].contents, temp_botan1.Length-1, best_botan[0].contents.Length-1);
                        temp_score2 = LCS(temp_botan2, best_botan[0].contents, temp_botan2.Length-1, best_botan[0].contents.Length-1);

                        if (temp_score1 > temp_score2)
                        {
                            results[i] = best_names[name_itr];
                            name_itr++;
                        }
                        else
                        {
                            results[i] = best_latin[latin_itr];
                            latin_itr++;
                        }
                    }
                    else
                    {
                        if (best_names[name_itr].score > best_latin[latin_itr].score)
                        {
                            results[i] = best_names[name_itr];
                            name_itr++;
                        }
                        else
                        {
                            results[i] = best_latin[latin_itr];
                            latin_itr++;
                        }
                    }
                }
            }
        }

        //executes the word search and populates the results array
        public void Search()
        {
            for (int i = 0; i < 3; i++)
            {
                best_names[i].score = 0.0;
                best_latin[i].score = 0.0;
                best_botan[i].score = 0.0;
            }
            Candidate temp;
            //Makes sure name has a value
            if (name != null && name != "")
            {
                Fetch_names(name, ref possible_names);

                //***REMOVE Test_PN_populate() BEFORE RELEASE, FOR TESTING ONLY!***//
                Test_PN_populate("rose", "violet", "buttercup", "common lilac", 1, 5, 3, 8);

                //Loops through pulled list
                for (int i = 0; i < possible_names.Count; i++)
                {
                    //stores current candidate into for testing
                    temp = possible_names.ElementAt(i);
                    //runs LCS on current candidate
                    temp.score = (double) LCS(name, temp.contents, name.Length-1, temp.contents.Length-1) / (double) temp.contents.Length;
                    //Compares score with current best score
                    if (temp.score > best_names[0].score)
                    {
                        best_names[2] = best_names[1];
                        best_names[1] = best_names[0];
                        best_names[0] = temp;
                    }
                    //compares with second highest
                    else if (temp.score > best_names[1].score)
                    {
                        best_names[2] = best_names[1];
                        best_names[1] = temp;
                    }
                    //compares with third highest
                    else if (temp.score > best_names[2].score)
                    {
                        best_names[2] = temp;
                    }
                    //reseting temp value
                    temp.score = 0.0;
                    temp.id = 0;
                    temp.contents = "";
                }
            }
            //clearing list for next word to be run
            possible_names.Clear();
            if (latin != null && latin != "")
            {
                Fetch_names(latin, ref possible_names);
                //***REMOVE Test_PN_populate() BEFORE RELEASE, FOR TESTING ONLY!***//
                Test_PN_populate("syringa vulgaris", "begonia coccinea", "helianthus annuus", "amorphophallus titanum", 8, 13, 2, 7);

                //Loops through pulled list
                for (int i = 0; i < possible_names.Count; i++)
                {
                    //stores current candidate into for testing
                    temp = possible_names.ElementAt(i);
                    //runs LCS on current candidate
                    temp.score = (double) LCS(latin, temp.contents, latin.Length-1, temp.contents.Length-1) / (double) temp.contents.Length;
                    //Compares score with current best score
                    if (temp.score > best_latin[0].score)
                    {
                        best_latin[2] = best_latin[1];
                        best_latin[1] = best_latin[0];
                        best_latin[0] = temp;
                    }
                    //compares with second highest
                    else if (temp.score > best_latin[1].score)
                    {
                        best_latin[2] = best_latin[1];
                        best_latin[1] = temp;
                    }
                    //compares with third highest
                    else if (temp.score > best_latin[2].score)
                    {
                        best_latin[2] = temp;
                    }
                    //reseting temp value
                    temp.score = 0.0;
                    temp.id = 0;
                    temp.contents = "";
                }
            }
            //clearing list for next word to be run
            possible_names.Clear();
            if (botan != null && botan != "")
            {
                Fetch_names(botan, ref possible_names);

                //***REMOVE Test_PN_populate() BEFORE RELEASE, FOR TESTING ONLY!***//
                Test_PN_populate("asteraceae", "amaryllidaceae", "amaryllidaceae", "oleaceae", 2, 20, 2, 8);

                //Loops through pulled list
                for (int i = 0; i < possible_names.Count; i++)
                {
                    //stores current candidate into for testing
                    temp = possible_names.ElementAt(i);
                    //runs LCS on current candidate
                    temp.score = (double) LCS(botan, temp.contents, botan.Length-1, temp.contents.Length-1) / (double) temp.contents.Length;
                    //Compares score with current best score
                    if (temp.score > best_botan[0].score)
                    {
                        best_botan[2] = best_botan[1];
                        best_botan[1] = best_botan[0];
                        best_botan[0] = temp;
                    }
                    //compares with second highest
                    else if (temp.score > best_botan[1].score)
                    {
                        best_botan[2] = best_botan[1];
                        best_botan[1] = temp;
                    }
                    //compares with third highest
                    else if (temp.score > best_botan[2].score)
                    {
                        best_botan[2] = temp;
                    }
                    //reseting temp value
                    temp.score = 0.0;
                    temp.id = 0;
                    temp.contents = "";
                }
            }
            Compare();
        }
    }
}
