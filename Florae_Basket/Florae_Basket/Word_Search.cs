using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

//////////////////////////////////////////////////
//                                              //
//  Word_Search                                 //
//  by Brady Smith                              //
//                                              //
//////////////////////////////////////////////////

namespace Florae_Basket
{
    public struct Candidate
    {
        public string contents;
        public int id;
        public double score;
    };

    public class Word_Search
    {
        //contains the string of the candidate, as well as the database key
        //and the score calculated from the OSA method.
        

        //value for a candidate to be considered a "winner"
        private const double THRESHOLD = 0.66;

        private Candidate[] results    = new Candidate[3];          //array containing the database id of the 3 best results.
        private Candidate[] best_names = new Candidate[3];          //arrays containging the 3 best candidates for every entry.
        private Candidate[] best_latin = new Candidate[3];
        private Candidate[] best_botan = new Candidate[3];
        private Candidate[] best_notes = new Candidate[3];
        private string name;
        private string latin;
        private string botan;
        private string note;
        private LinkedList<Candidate> possible_names = new LinkedList<Candidate>();  //Linked list containing the Candidates pulled from the database.

        public Word_Search(string enl_name, string latin_name, string botan_name, string notes)
        {
            name =  enl_name;
            latin = latin_name;
            botan = botan_name;
            note = notes;
        }

        public string Get_name() => name;

        public string Get_latin() => latin;

        public string Get_botan() => botan;

        public string Get_note() => note;

        public Candidate[] Get_results() => results;

        //Augments scores to comform to the required 0-1 range. 
        void FixScores(ref Candidate[] list, string entry)
        {
            double tempscore;
            for (int i = 0; i < 3; i++)
            {
                tempscore = list[i].score;
                if (tempscore <= -list[i].contents.Length)
                {
                    tempscore = 0;
                }
                else if (tempscore == (list[i].contents.Length * 2))
                {
                    tempscore = 1;
                }
                else
                {
                    tempscore += list[i].contents.Length;
                    tempscore = tempscore / (list[i].contents.Length * 3);
                }
                list[i].score = tempscore;
            }
        }

        //Optimal String Alignment
        //Calculates match score for two strings
        //Factors in things such as gaps, matches, and different letters.
        //More acurate than LCS because there is a max score a string can recieve
        public int OSA(string entry, string cand, int x, int y)
        {
            int gap = 2;
            int match = 2;
            int diff = 1;
            //x and y are incremented to make sure array is correct size
            x++;
            y++;
            //2 dimensional array for holding results
            int[,] A = new int[x,y];

            //Iterates through each row and column to get best results
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    //gives a score of 0 representing empty string
                    if (i == 0 && j == 0)
                    {
                        A[i, j] = 0;
                    }
                    //keeps track of the gap score for the edges of the matrix
                    else if (i == 0 && j != 0)
                    {
                        A[i, j] = A[i, j - 1] - gap;
                    }
                    else if (i != 0 && j == 0)
                    {
                        A[i, j] = A[i - 1, j] - gap;
                    }
                    //keeps track of character matches
                    else if (entry[i-1] == cand[j-1])
                    {
                        A[i, j] = Math.Max(A[i - 1, j - 1] + match, Math.Max(A[i, j - 1] - gap, A[i - 1, j] - gap));
                    }
                    else
                    {
                        //Also keeps track of gaps
                        if (entry[i-1] == ' ' || cand[j-1] == ' ')
                        {
                            A[i, j] = Math.Max(A[i - 1, j] - gap, A[i, j - 1] - gap);
                        }
                        //If characters are different but no gap
                        else
                        {
                            A[i, j] = Math.Max(A[i - 1, j - 1] - diff, Math.Max(A[i - 1, j] - gap, A[i, j - 1] - gap));
                        }
                    }
                }
            }

            return A[x-1,y-1];
        }

        //Fetch english names from the Database
        //Stores results into linked list that is passed by reference
        //type of name is passes as a string and is then passes to the database manager
        private void Fetch_names(string type, ref LinkedList<Candidate> list)
        {
            Database_Manager db = new Database_Manager();
            try
            {
                db.FetchAllNames(ref list, type);
            }
            catch (Exception e)
            {
                throw;
            }
        }

        //Query the database using the ID of the entry in question.
        //Will return the botanical name of the entry
        //This exists in order to compare English names and Latin names in order to help decide
        //which one the user might be looking for.
        private string Fetch_botanical(int id)
        {
            string temp;
            Database_Manager db = new Database_Manager();
            try
            { 
                temp = db.FetchBotan(id);
            }
            catch (Exception)
            {
                throw;
            }
            return temp;
        }

        private void Fetch_notes(string entry, ref LinkedList<Candidate> list)
        {
            Database_Manager db = new Database_Manager();
            try
            {

                //Query database for all notes containing key words
                //Put all results into list for later comparisons and testing.
                db.FetchAllNotes(entry, ref list);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }
        }

        //compares the english and latin name candidates to find the best 3 candidates.
        //uses botanical family if scores of english and latin names being compared are too close.
        public void Compare()
        {
            //These integers will increment if a candidate out of a certain category is selected. 
            //This makes sure the next candidate in that category will be evaluated next.
            int name_itr  = 0;
            int latin_itr = 0;
            int botan_itr = 0;
            int note_itr = 0;
            //temporary string for comparing botanical families between english names and latin names.
            string temp_botan1, temp_botan2 = "";
            double temp_score1, temp_score2 = 0.0;

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
                else if (best_names[name_itr].score == 0 && best_latin[latin_itr].score == 0 && best_botan[botan_itr].score != 0)
                {
                    results[i] = best_botan[botan_itr];
                    botan_itr++;
                }
                //if english, latin, and botanical do not have matches above 0, the system will check if 
                //anything was entered for these three, if nothing was, the notes shall be taken
                else if (best_names[name_itr].score == 0 && best_latin[latin_itr].score == 0 && best_botan[botan_itr].score == 0)
                {
                    if (best_names[name_itr].contents != null && best_names[name_itr].contents != "")
                    {
                        results[i] = best_names[name_itr];
                        name_itr++;
                    }
                    else if (best_latin[latin_itr].contents != null && best_latin[latin_itr].contents != "")
                    {
                        results[i] = best_latin[latin_itr];
                        latin_itr++;
                    }
                    else if (best_botan[botan_itr].contents != null && best_botan[botan_itr].contents != "")
                    {
                        results[i] = best_botan[botan_itr];
                        botan_itr++;
                    }
                    else
                    {
                        results[i] = best_notes[note_itr];
                        note_itr++;
                    }
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
                    //this will run OSA on the botanical families of both names. The closest match is selected.
                    else if(best_botan[0].score > 0)
                    {
                        temp_botan1 = Fetch_botanical(best_names[name_itr].id);
                        //temp_botan1 = "syringa vulgaris";
                        temp_botan2 = Fetch_botanical(best_latin[latin_itr].id);
                        //temp_botan2 = "helianthus annuus";
                        temp_score1 = OSA(temp_botan1, best_botan[0].contents, temp_botan1.Length, best_botan[0].contents.Length);
                        temp_score2 = OSA(temp_botan2, best_botan[0].contents, temp_botan2.Length, best_botan[0].contents.Length);

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
                    //if the top note result and the current english same share an ID, send english name 
                    //to current result.
                    else if (best_notes[0].id == best_names[name_itr].id && best_notes[0].score > 0)
                    {
                        results[i] = best_names[name_itr];
                        name_itr++;
                    }
                    //if the top note result and the current latin same share an ID, send latin name 
                    //to current result.
                    else if (best_notes[0].id == best_latin[name_itr].id && best_notes[0].score > 0)
                    {
                        results[i] = best_latin[latin_itr];
                        latin_itr++;
                    }
                    //if the top note result and the current botanical same share an ID, send botanical name 
                    //to current result.
                    else if (best_notes[0].id == best_botan[botan_itr].id && best_notes[0].score > 0)
                    {
                        results[i] = best_botan[botan_itr];
                        botan_itr++;
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

        //counts how many times the provided note keyword appears in each notes entry that contains it.
        //simply counts how many time it shows up. Nothing special
        public void Note_Search()
        {
            //Makes sure a notes entry is present
            if (note != null && note != "")
            {
                Fetch_notes(note, ref possible_names);
                double temp_score;
                //iterates through all notes pull from database
                for (int i = 0; i < possible_names.Count; i++)
                {
                    //Uses Regex to find how many matches the current candidate string contains.
                    temp_score = Regex.Matches(possible_names.ElementAt(i).contents, note, RegexOptions.IgnoreCase).Count;

                    //This section is the same as the regular search method
                    if (best_notes[0].score < temp_score)
                    {
                        best_notes[2] = best_notes[1];
                        best_notes[1] = best_notes[0];
                        best_notes[0] = possible_names.ElementAt(i);
                    }
                    else if (best_notes[1].score < temp_score)
                    {
                        best_notes[2] = best_notes[1];
                        best_notes[1] = possible_names.ElementAt(i);
                    }
                    else if (best_notes[2].score < temp_score)
                    {
                        best_notes[2] = possible_names.ElementAt(i);
                    }
                }
            }
        }

        //executes the word search and populates the results array
        public void Search()
        {
            for (int i = 0; i < 3; i++)
            {
                best_names[i].score = Int32.MinValue;
                best_latin[i].score = Int32.MinValue;
                best_botan[i].score = Int32.MinValue;
            }
            Candidate temp;
            //Makes sure name has a value
            if (name != null && name != "")
            {
                Fetch_names("English", ref possible_names);
                
                //Loops through pulled list
                for (int i = 0; i < possible_names.Count; i++)
                {
                    //stores current candidate into for testing
                    temp = possible_names.ElementAt(i);
                    //runs OSA on current candidate
                    temp.score = (double)OSA(name, temp.contents, name.Length, temp.contents.Length);
                    
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
                FixScores(ref best_names, name);
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    best_names[i].score = 0;
                }
            }
            //clearing list for next word to be run
            possible_names.Clear();
            if (latin != null && latin != "")
            {
                Fetch_names("Latin", ref possible_names);

                //Loops through pulled list
                for (int i = 0; i < possible_names.Count; i++)
                {
                    //stores current candidate into for testing
                    temp = possible_names.ElementAt(i);
                    //runs OSA on current candidate
                    temp.score = (double)OSA(latin, temp.contents, latin.Length, temp.contents.Length);
                    
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
                FixScores(ref best_latin, latin);
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    best_latin[i].score = 0;
                }
            }
            //clearing list for next word to be run
            possible_names.Clear();
            if (botan != null && botan != "")
            {
                Fetch_names("Botanical", ref possible_names);
                
                //Loops through pulled list
                for (int i = 0; i < possible_names.Count; i++)
                {
                    //stores current candidate into for testing
                    temp = possible_names.ElementAt(i);
                    //runs OSA on current candidate
                    temp.score = (double)OSA(botan, temp.contents, botan.Length, temp.contents.Length);
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
                FixScores(ref best_botan, botan);
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    best_botan[i].score = 0;
                }
            }
            possible_names.Clear();
            Note_Search();
            possible_names.Clear();
            Compare();
        }
    }
}
