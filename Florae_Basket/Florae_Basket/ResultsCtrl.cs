using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Florae_Basket
{
    class ResultsCtrl
    {
        int[] id = new int[3];
        Flower[] flowers = new Flower[3];
        string[] images1;
        string[] images2;
        string[] images3;
        string[] notes = new string[3];

        public ResultsCtrl(int id1, int id2, int id3)
        {
            id[0] = id1;
            id[1] = id2;
            id[2] = id3;
        }

        private void FetchNames(int[] id)
        {
            try
            {
                //TODO
                //When database is implemented this method will pull name, botanical, and latin for each result
                //from the database and put it in each flower object
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void FetchImages(int[] id)
        {
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
                //TODO
                //Next all 3 arrays must be populated with filepaths from the database.
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void FetchNotes(int[] id)
        {
            try
            {
                //TODO
                //Pull notes for each result
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Run()
        {
            FetchNames(id);
            FetchImages(id);
            FetchNotes(id);
        }
    }
}
