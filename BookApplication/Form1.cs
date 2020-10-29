using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace BookApplication
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // initializing a new instance of the OpenFileDialog class
        OpenFileDialog openFileDialog = new OpenFileDialog();

        private void btnGetFileDirectory_Click(object sender, EventArgs e)
        {
            // open the file dialog for the application
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // display the file directory in the text box
                txtFilePath.Text = openFileDialog.FileName;
            }
        }

        private void btnReadAndProcessFile_Click(object sender, EventArgs e)
        {
            // initializing a new instance of the Stopwatch class
            Stopwatch stw = new Stopwatch();
            stw.Start(); // start measuring elapsed time

            // display the starting time
            var pro = DateTime.Now.ToString("HH:mm:ss");
            rtbProcessTime.Text = $"Start time: {pro}";

            // display the text file in the applcation
            rtbBookOutput.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.PlainText);

            CountNumberOfLines(); // call method to display number of lines
            CountNumberOfWords(); // call method to display number of words in text file

            // create a new string to read all text in the file
            string textFile = File.ReadAllText(txtFilePath.Text);

            // call of method 
            Dictionary<string,int> words = WordCountOccurances(textFile);

            DisplayTopWords(words); // method to display to 50 words
            TopWordsWithLenghtGreaterOfSix(words); // method to display top 50 words which are > 6

            stw.Stop(); // stop measuring elapsed time
            // gets the total elapsed time measured by the current instance
            Text = stw.Elapsed.TotalSeconds.ToString();

            // display ending time
            var pro2 = DateTime.Now.ToString("HH:mm:ss");
            rtbProcessTime.Text += $"\nEnd Time: {pro2}";

            // display the overall process time of the application
            rtbProcessTime.Text += $"\nOverall Process Time: {Text}";

            // display of message box of overall time to complete the task
            MessageBox.Show($"Processing and counts completed!\n{Text} second(s)",
                             "File selection required to process",MessageBoxButtons.OK,
                              MessageBoxIcon.Information);
        }

        // method to display the number of lines in the text file
        private void CountNumberOfLines()
        {
            var countLines = File.ReadAllLines(txtFilePath.Text).Count();
            rtbLinesAndWordsInFile.Text = $"Lines in File : {countLines}";
        }

        // method to display the number of words in the text file
        private void CountNumberOfWords()
        {
            string[] countWords = rtbBookOutput.Text.Split();
            int counter = countWords.Count();
            rtbLinesAndWordsInFile.Text += $"\nWords in File : {counter}";
        }

        private Dictionary<string, int> WordCountOccurances(String textFile)
        {
            // creating the dictionary to store words and it's frequency
            Dictionary<string, int> occurances = new Dictionary<string, int>();

            String txt = textFile.ToLower(); // convert all the text to lower text
            String[] words = Regex.Split(txt, "\\W+"); // split the text with Regex

            // iterate through the array of words
            for (int i = 0; i < words.Length; i++)
            {
                // if word exist in array
                if (occurances.ContainsKey(words[i]))
                {
                    // increase by 1
                    occurances[words[i]] += 1;
                }
                else // else add to dictionary
                {
                    occurances.Add(words[i], 1);
                }
            }

            return occurances;
        }

        // method to display the top 50 words count
        private void DisplayTopWords(Dictionary<string, int> words)
        {
            // LINQ query to retrieve top 50 words
            var list = words.OrderByDescending(x => x.Value).Take(50);

            foreach (KeyValuePair<string, int> keyValue in list)
            {
                // display the words on the richTextBox field
                richTextBoxTopWords.Text += $"{keyValue.Key} occurred {keyValue.Value} times\n";
            }
        }

        // method to display the top 50 words that are greater than 6
        private void TopWordsWithLenghtGreaterOfSix(Dictionary<string, int> words)
        {
            // LINQ query to retrieve top 50 words
            var list = words.Where(x => x.Key.Length > 6).OrderByDescending(x => x.Value).Take(50);

            foreach (KeyValuePair<string, int> keyValue in list)
            {
                // display the words on the richTextBox field
                richTextBoxTopWords2.Text += $"{keyValue.Key} occurred {keyValue.Value} times\n";
            }
        }
    }
}
