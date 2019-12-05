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

namespace Text_Analysis
{
    public partial class Form1 : Form
    {
        //Filter
        const string FILTER = "Text Files|*.txt|All Files|*.*";
        //Lists
        List<string> Distinct = new List<string>();
        List<string> totalWord = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Method to check if word is repeated
        /// </summary>
        /// <param name="word">the word</param>
        /// <returns></returns>
        private bool wordRepitition(string word)
        {
            //Repeat until count of list is reached incrementing i each time
            for(int i = 0; i < Distinct.Count; i++)
            {
                //If word is the same
                if (word == Distinct[i])
                {
                    return true;
                } 
            }
            return false;
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            //Variables
            string line = "";
            string[] txtArray;
            //All delimeters
            char[] delim = {' ',',','.',';',':','?','!'};
            int wordCount = 0;
            int lineCount = 0;
            StreamReader reader;

            openFileDialog1.Filter = FILTER;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Open file
                reader = File.OpenText(openFileDialog1.FileName);
                //While not end of the file
                while (!reader.EndOfStream)
                {
                    try
                    {
                        //Read line
                        line = reader.ReadLine();
                        //Split at delimeter
                        txtArray = line.Split(delim);
                        for(int i = 0; i < txtArray.Length; i++)
                        {     
                            //If the word is not repeated
                            if (wordRepitition(txtArray[i]) == false)
                            {
                                //Make words low case
                                Distinct.ToString().ToLower();
                                //Add array to listbox
                                listBoxWords.Items.Add(txtArray[i].ToString().Trim());
                                //Add array to distinct
                                Distinct.Add(txtArray[i].ToString().Trim());
                            }
                            //Add array to totalword list
                            totalWord.Add(txtArray[i].ToString().Trim());
                            
                        }
                        //Repeat till end of txtArray length
                        for(int i =0; i < txtArray.Length; i++)
                        {
                            //Increment wordcount by 1
                            wordCount++;
                        }

                       //Add variables to textboxes
                        textBoxVocabulary.Text = Distinct.Count.ToString();
                        textBoxWords.Text = wordCount.ToString();
                        textBoxLines.Text = lineCount.ToString();
                        //Increment linecount by 1
                        lineCount++;
                    }
                    catch
                    {
                        //Error message and the line it occurs
                        Console.WriteLine("Error: " + line);
                    }

                }
                //Close file
                reader.Close();
            }
        }
        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Select individual words
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxWords_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Variables
            string wordDistinct = "";
            int count = 0;
            if (listBoxWords.SelectedIndex >= 0)
            {
                //Word is selected
                wordDistinct = listBoxWords.SelectedItem.ToString();
                for (int i = 0; i < totalWord.Count; i++)
                {
                    if (wordDistinct == totalWord[i])
                    {
                        //Increment count by 1
                        count++;
                    }
                }
            }
            //Display count in textbox
            textBoxRepetition.Text = count.ToString();
        }

        /// <summary>
        /// Count size of vocabulary
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void countSizeOfVocabularyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Clears all textboxes
            textBoxVocabulary.Clear();
            textBoxWords.Clear();
            textBoxLines.Clear();
            textBoxRepetition.Clear();
        }
        /// <summary>
        /// Exit button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
