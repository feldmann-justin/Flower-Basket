using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

//////////////////////////////////////////////////
//                                              //
//  Word_Search                                 //
//  by Brady Smith                              //
//                                              //
//////////////////////////////////////////////////

namespace Florae_Basket
{
    class ResultsCtrl
    {
        public int[] id = new int[3];
        public Flower[] flowers = new Flower[3];
        public string[] images1;
        public string[] notes = new string[3];

        public ResultsCtrl(int id1, int id2, int id3)
        {
            id[0] = id1;
            id[1] = id2;
            id[2] = id3;
        }

        private void FetchNames(int[] id, ref bool res1, ref bool res2, ref bool res3)
        {
            

            ////////////////////////////////////////////////////////
            string query = "SELECT English, Latin, Botanical FROM Flower WHERE id = " + id[0];
            try
            {
                Database_Manager db = new Database_Manager();
                if (id[0] > -1)
                {
                    res1 = true;
                    flowers[0].setEnglishName(db.FetchEnglish(id[0]));
                    flowers[0].setLatinName(db.FetchLatin(id[0]));
                    flowers[0].setBotanicalFam(db.FetchBotan(id[0]));
                    if (id[1] > -1)
                    {
                        res2 = true;
                        flowers[1].setEnglishName(db.FetchEnglish(id[1]));
                        flowers[1].setLatinName(db.FetchLatin(id[1]));
                        flowers[1].setBotanicalFam(db.FetchBotan(id[1]));
                        if (id[2] > -1)
                        {
                            res3 = true;
                            flowers[2].setEnglishName(db.FetchEnglish(id[2]));
                            flowers[2].setLatinName(db.FetchLatin(id[2]));
                            flowers[2].setBotanicalFam(db.FetchBotan(id[2]));
                        }
                    }
                }
                
                //TODO
                //When database is implemented this method will pull name, botanical, and latin for each result
                //from the database and put it in each flower object
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
                throw;
            }
        }

        private void FetchImages(int[] id)
        {
            //FOR TESTING ONLY//
            images1 = new string[3];

            //images1[0] = images1[1] = images1[2] = "flower.jpg";
            //FOR TESTING ONLY//

            try
            {
                //TODO
                //first the number of images for each flower must be gotten from the database
                //then the arrays for the images of each flower must be initialized.
            }
            catch (Exception)
            {

                throw;
            }
            try
            {
                Database_Manager db = new Database_Manager();
                //TODO
                //Next all 3 arrays must be populated with filepaths from the database.
                //for (int i = 0; i < 3; i++)
                //{
                //    images1[i] = db.FetchFilePath(id[i]);
                //}
                if (id[0] != 0)
                {
                    images1[0] = db.FetchFilePath(id[0]);
                    if (id[1] != 0)
                    {
                        images1[1] = db.FetchFilePath(id[1]);
                        if (id[2] != 0)
                        {
                            images1[2] = db.FetchFilePath(id[2]);
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void FetchNotes(int[] id)
        {
            
            Database_Manager db = new Database_Manager();
            try
            {
                //for (int i = 0; i < 3; i++)
                //{
                //    notes[i] = db.FetchNote(id[0]);
                //}
                if (id[0] != 0)
                {
                    notes[0] = db.FetchNote(id[0]);
                    if (id[1] != 0)
                    {
                        notes[1] = db.FetchNote(id[1]);
                        if (id[2] != 0)
                        {
                            notes[2] = db.FetchNote(id[2]);
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Run(ref bool res1, ref bool res2, ref bool res3)
        {
            flowers[0] = new Flower();
            flowers[1] = new Flower();
            flowers[2] = new Flower();
            FetchNames(id, ref res1, ref res2, ref res3);
            FetchImages(id);
            FetchNotes(id);
            //ResultsGUI resultsGUI = new ResultsGUI(id, flowers, notes, images1, images2, images3);
            //resultsGUI.ShowDialog();
        }
    }
}
