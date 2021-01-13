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
using System.Collections;


namespace test1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void stopWordsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.stopWordsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.stopWordsDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stopWordsDataSet.StopWords' table. You can move, or remove it, as needed.
            this.stopWordsTableAdapter.Fill(this.stopWordsDataSet.StopWords);

        }

        private void add_entry_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow newRow = stopWordsDataSet.Tables["StopWords"].NewRow();
                newRow["word"] = add_word.Text;
                add_word.Text = "";                

                stopWordsDataSet.Tables["Stopwords"].Rows.Add(newRow);
                stopWordsTableAdapter.Update(stopWordsDataSet);
                MessageBox.Show("Added " + newRow["word"] + " to database!");

            }
            catch (Exception error)
            {
                MessageBox.Show("An error occured" + error);
            }
        }

        private void remove_entry_Click(object sender, EventArgs e)
        {
            try
            {
                StopWordsDataSet.StopWordsRow wordsRow = stopWordsDataSet.StopWords.FindByword(delete_word.Text);

                wordsRow.Delete();
                delete_word.Text = "";
                
                MessageBox.Show("Removed " + "" + " from database!");

            }
            catch (Exception error)
            {
                MessageBox.Show("An error occured" + error);
            }
        }

        private void search_entry_Click(object sender, EventArgs e)
        {
            StopWordsDataSet.StopWordsRow wordsRow = stopWordsDataSet.StopWords.FindByword(search_word.Text);
            if (wordsRow != null)
            {
                string[] strList = wordsRow.word.ToString().Split(',');
                string str = "";
                foreach (string s in strList)
                {
                    str += s + "\r\n";
                }
                search_word.Text = str;
                search_word.Text = "";
                MessageBox.Show(str + " was found in database");
            }
            else
            {
                search_word.Text = "No results";
            }
        }

        private void update_entry_Click(object sender, EventArgs e)
        {
            try
            {
                StopWordsDataSet.StopWordsRow wordsRow = stopWordsDataSet.StopWords.FindByword(update_word.Text);

                wordsRow.Frequency =Convert.ToDecimal( update_frequency.Text);
                MessageBox.Show("Updated row!");

            }
            catch (Exception error)
            {
                MessageBox.Show("An error occured" + error);
            }
        }

        private void browse_button_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string folderPath = folderBrowserDialog1.SelectedPath;
                string[] files = Directory.GetFiles(folderPath);

                select_folder.Text = folderPath;

            }
            else
            {
                MessageBox.Show("No File Found");
            }
        }

        private void scan_files_Click(object sender, EventArgs e)
        {
            string folderPath = select_folder.Text; // get the folderPath from output TextBox 

            foreach (string file in Directory.GetFiles(folderPath))
            {

                Hashtable wf = new Hashtable();//Creating a new hashtable
                string ReadFile = File.ReadAllText(file);//Reading file

                // Convert our input to lowercase
                ReadFile = ReadFile.ToLower();

                //Removing Special Characters

                string[] stripChars = {":" ,"::", ";", ",", ".", "-", "_", "^", "(", ")", "[", "]",
                        "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "\n", "\t", "\r" ,"#","$","%","/","@",};
                foreach (string character in stripChars)
                {
                    ReadFile = ReadFile.Replace(character, "");
                }



                // Split on spaces into a List of strings
                List<string> wordList = ReadFile.Split(' ').ToList();

                // Removing Stopwords
                string[] stopwords = new string[] {     "but","a","about","above","after","again","all","am","an","and","any",
                                                        "are","aren't","as","at","be","becase","been","before","being",
                                                        "below","between","both","but","by","can","can't","could","did",
                                                        "do","does","doing","don't","down","during","each","few","for",
                                                        "from","get","had","has","have","having","he","her","here","hers",
                                                        "herself","he's","him","himself","his","how","i","id","if","ill",
                                                        "I'm","in","into","is","isnt","it","its","itself","I've","let's",
                                                        "me","most","my","no","not","now","of","off","on","only","or","our",
                                                        "ours","over","said","than","that","the","their","they","this","to",
                                                        "was","we","were","what","when","where","who","will","with","you","so"," ",
                                                   };
                foreach (string word in stopwords)
                {
                //using while to clear StopWords 
                    while (wordList.Contains(word))
                    {
                        wordList.Remove(word);
                    }
                }


                //using Hashtable for counting the frequency

                foreach (string word in wordList)
                {

                    if (wf.ContainsKey(word))
                    {
                        wf[word] = double.Parse(wf[word].ToString()) + 1; // adding 1 to the frequency
                    }

                    else
                    {
                        wf.Add(word, 1.0); //first time this word is read
                    }

                }

                //Displaying frequency into the listBox
                foreach (string word in wordList)
                {
                    if (word.Length < 10)
                    {                       
                        double frequency = (double)wf[word] / (double)wordList.Count;
                        double tf = frequency;
                        tf = Math.Round(tf, 3);
                        listBox1.Items.Add(word + " \r\r\r" + tf);
                       
                    }
                    else
                    {
                        // Error 

                    }
                }

            }
        }

        //Word Added to ArayList

        private void button3_Click(object sender, EventArgs e)
        {
            if(this.textBox3.Text != "")
            {
                listBox1.Items.Add(this.textBox3.Text);
                this.textBox3.Focus();
                this.listBox1.Update();
                MessageBox.Show("Word Added to the ArrayList");
                this.textBox3.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a Word ");
                this.textBox3.Focus();
            }
        }

        //Word Removed From ArrayList
        private void button4_Click(object sender, EventArgs e)
        {
            if (this.textBox4.Text != "")
            {
                listBox1.Items.Remove(this.textBox4.Text);
                this.textBox4.Focus();
                this.listBox1.Update();
                MessageBox.Show("Word Removed from the ArrayList");
                this.textBox4.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a Word ");
                this.textBox4.Focus();
            }
        }


        //Display frequency in TextBox
        private void button5_Click(object sender, EventArgs e)
        {
            textBox6.Clear();

            if (listBox1.FindString(textBox5.Text) != -1)
            {
                if (textBox6.Text == "")
                {
                    textBox6.Text += listBox1.FindString(textBox5.Text).ToString();
                }
                else
                {
                    MessageBox.Show("No Result Found");
                  
                }
            }
        }
    }
}
