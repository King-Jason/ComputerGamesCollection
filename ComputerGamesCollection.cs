using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace ComputerGamesCollection
{
    //Name: Jason King
    //Date: 28/03/2019
    //ID: P465642
    /*
        ComputerGamesCollection
        This program can keep track of all your games. You can add them to the 
        list, delete, update and more. All data is saved to a binary file so
        you don't have to enter the infomation in all the time.
    */

    public partial class ComputerGamesCollection : Form
    {

        static int MAX = 20;
        string[] gameNameArray = new string[MAX];
        string[] gamePlatformArray = new string[MAX];
        string[] gameGenreArray = new string[MAX];
        int PTR = 0;
        string filePath = "myGames.dat";

        public ComputerGamesCollection()
        {
            InitializeComponent();
            onRunLoadFileData();
        }

        /*
        Program Criteria 1: The program loads the data from mygames.dat 
        if there is one on startup. If there isn't then it just 
        populates the program with empty values.
        */
        private void onRunLoadFileData()
        {
            Open();
        }

        private void initArray()
        {
            for (int i = 0; i < MAX; i++)
            {
                gameNameArray[i] = "~empty";
                gamePlatformArray[i] = "";
                gameGenreArray[i] = "";
            }
            displayArray();
        }

        /*
        Program Criteria 2: When all the textbox fields have valid data in 
        them it adds the value to the three arrays 
        and then displays it in the listbox.
        */
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbGameNameInput.Text) || string.IsNullOrWhiteSpace(tbGamePlatformInput.Text) || string.IsNullOrWhiteSpace(tbGameGenreInput.Text))
            {
                MessageBox.Show("Please fill in all fields");
            }
            else
            {
                insertDataArray();
                clearTextBoxes();
            }
        }

        //Adds the data from the textboxes to the array
        private void insertDataArray()
        {
            try
            {
                gameNameArray[PTR] = tbGameNameInput.Text;
                gamePlatformArray[PTR] = tbGamePlatformInput.Text;
                gameGenreArray[PTR] = tbGameGenreInput.Text;
                PTR++;
                bubbleSort();
                displayArray();
            }
            catch (Exception e)
            {
                MessageBox.Show("Your list is full. \nPlease change an already existing game.\n"  + e);
            }

        }

        //Clears the textboxes
        private void clearTextBoxes()
        {
            tbGameNameInput.Clear();
            tbGamePlatformInput.Clear();
            tbGameGenreInput.Clear();
        }

        /*
        Program Criteria 3: Deletes the record that is selected in the listbox, 
        clears the textboxes after and then sorts the the array.
        */
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (lbGameOutput.Items.Count > 0)
            {
                PTR = lbGameOutput.SelectedIndex;
                gameNameArray[lbGameOutput.SelectedIndex] = "~empty";
                gamePlatformArray[lbGameOutput.SelectedIndex] = "";
                gameGenreArray[lbGameOutput.SelectedIndex] = "";
            }
            else
            {
                MessageBox.Show("Please select something to delete.");
            }
            bubbleSort();
            displayArray();
            clearTextBoxes();
        }

        /*
        Deletes all data and records in the program.
        */
        private void buttonClear_Click(object sender, EventArgs e)
        {
            initArray();
            lbGameOutput.Items.Clear();
            clearTextBoxes();
            displayArray();
        }

        /*
        Program Criteria 4: You can select a record from the listbox and type in 
        different value and click update and it will change the record name 
        and sort the array
        */
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbGameNameInput.Text) || string.IsNullOrWhiteSpace(tbGamePlatformInput.Text) || string.IsNullOrWhiteSpace(tbGameGenreInput.Text))
            {
                MessageBox.Show("Please fill in all fields");
            }
            else
            {
                gameNameArray[lbGameOutput.SelectedIndex] = tbGameNameInput.Text;
                gamePlatformArray[lbGameOutput.SelectedIndex] = tbGamePlatformInput.Text;
                gameGenreArray[lbGameOutput.SelectedIndex] = tbGameGenreInput.Text;
                int value = lbGameOutput.SelectedIndex;
                bubbleSort();
                displayArray();
            }
        }

        //Program Criteria 6: Populates the textboxes with what record has been selected in the listbox
        private void lbGameOutput_SelectedIndexChanged(object sender, EventArgs e)
        {
            clearTextBoxes();
            int value = lbGameOutput.SelectedIndex;
            if (value >= 0 && value <= 19)
            {
                tbGameNameInput.Text += gameNameArray[value];
                tbGamePlatformInput.Text += gamePlatformArray[value];
                tbGameGenreInput.Text += gameGenreArray[value];
            }
        }

        //Program Criteria 10: Writes all the data from the arrays to a binary file when the button save is clicked
        private void buttonSave_Click(object sender, EventArgs e)
        {
            filePath = "mygames.dat";
            Save();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "dat files (*.dat)|*.dat|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                }
            }
            Open();
        }

        /*
        Program Criteria 5: When the reset button is clicked it changes 
        whatever the selected record is too empty and sorts the arrays.
        */
        private void buttonReset_Click(object sender, EventArgs e)
        {
            if (lbGameOutput.SelectedIndex != -1)
            {
                gameNameArray[lbGameOutput.SelectedIndex] = "~empty";
                gamePlatformArray[lbGameOutput.SelectedIndex] = "";
                gameGenreArray[lbGameOutput.SelectedIndex] = "";
                bubbleSort();
                displayArray();
            }
            else
            {
                MessageBox.Show("Please select a record to reset!");
            }

        }

        /*
        Program Criteria 8: If there is a game name in the textbox when the search button 
        is clicked it will search the gameNameArray for the game then fill the rest of 
        the boxes with the infomation.
        */
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            binarySearch();
        }

        private void binarySearch()
        {
            if (string.IsNullOrWhiteSpace(tbGameNameInput.Text))
            {
                MessageBox.Show("Please enter a word to search");
            }
            else
            {
                bubbleSort();
                bool found = false;
                int min = 0;
                int max = MAX - 1;
                string target = tbGameNameInput.Text;
                while (min <= max)
                {
                    int mid = ((min + max) / 2);
                    if (string.CompareOrdinal(target, gameNameArray[mid]) == 0)
                    {
                        found = true;
                        lbGameOutput.SetSelected(mid, true);
                        break;
                    }
                    else if (string.CompareOrdinal(target, gameNameArray[mid]) < 0)
                    {
                        max = mid - 1;
                    }
                    else
                    {
                        min = mid + 1;
                    }

                    ;
                }// end of WHILE
                if (!found)
                {
                    MessageBox.Show("Could not find " + target);
                    clearTextBoxes();
                }

            }
        }

        //Program Criteria 7: Sorts the game names by alphabetically order using a bubblesort
        private void bubbleSort()
        {
            int pos = 1;
            while (pos < gameNameArray.Length)
            {
                if (string.CompareOrdinal(gameNameArray[pos], gameNameArray[pos - 1]) >= 0 || gameNameArray[pos] == "~empty")
                {
                    pos++;
                }
                else
                {

                    arrayAlphabeticSort(gameNameArray, pos);
                    arrayAlphabeticSort(gamePlatformArray, pos);
                    arrayAlphabeticSort(gameGenreArray, pos);

                    if (pos > 1)
                    {
                        pos--;
                    }
                }
            }
        }

        private void arrayAlphabeticSort(String[] array, int pos)
        {
            string temp;
            temp = array[pos];
            array[pos] = array[pos - 1];
            array[pos - 1] = temp;
        }

        //Displays all the data in the arrays in the listbox
        private void displayArray()
        {
            lbGameOutput.Items.Clear();
            for (int i = 0; i < MAX; i++)
            {
                lbGameOutput.Items.Add(gameNameArray[lbGameOutput.Items.Count] + " " + gamePlatformArray[lbGameOutput.Items.Count] + " " + gameGenreArray[lbGameOutput.Items.Count]);
            }
        }

        /*
        Program Criteria 9: When the user exits the problem before it closes all data is saved to mygames.dat
        */
        private void ComputerGamesCollection_FormClosing(object sender, FormClosingEventArgs e)
        {
            filePath = "myGames.dat";
            Save();
        }

        private void Save()
        {
            try
            {
                BinaryWriter bw = new BinaryWriter(new FileStream(filePath, FileMode.Create));
                for (int i = 0; i < MAX; i++)
                {
                    bw.Write(gameNameArray[i]);
                    bw.Write(gamePlatformArray[i]);
                    bw.Write(gameGenreArray[i]);

                }
                bw.Close();
                MessageBox.Show("Successfully Saved");
            }
            catch (Exception fe)
            {
                MessageBox.Show("There was an error saving! \n" + fe);
            }
        }

        private void Open()
        {
            try
            {
                BinaryReader br = new BinaryReader(new FileStream(filePath, FileMode.Open));
                for (int i = 0; i < MAX; i++)
                {
                    gameNameArray[i] = br.ReadString();
                    gamePlatformArray[i] = br.ReadString();
                    gameGenreArray[i] = br.ReadString();
                }
                br.Close();
            }
            catch (Exception fe)
            {
                if (File.Exists("mygames.dat"))
                {
                    MessageBox.Show("There was an error opening your file \n" + fe);
                    initArray();
                }
                else
                {
                    initArray();
                }

            }
            bubbleSort();
            displayArray();

            for (int i = 0; i < 20; i++)
            {
                if (gameNameArray[i] != "~empty")
                {
                    PTR++;
                }
            }
        }

        private void buttonSaveAS_Click(object sender, EventArgs e)
        {
            using(FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog()) {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = folderBrowserDialog.SelectedPath;
                    filePath += "mygames.dat";
                }
            }
            Save();
        }
    }

}


