using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextDictionaryProject.Model;

namespace TextDictionaryProject
{
    public partial class Form1 : Form
    { 
        DB db = new DB();

        private string currentInput = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        // Обработчик события
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            string inputText = textBox.Text;

            // Проверка на наличие символов и очистка
            if (string.IsNullOrEmpty(inputText) && inputText.All(char.IsLetter))
            {
                richTextBox1.Clear();
                currentInput = string.Empty;
                return;
            }

            if (inputText.Length >= 2)
            {
                // Получение последнего символа, второго и третьего с конца текста
                char lastChar = inputText.LastOrDefault();

                char secondToLastChar = inputText.ElementAtOrDefault(inputText.Length - 2);

                char thirdToLastChar = inputText.ElementAtOrDefault(inputText.Length - 3);

                if ((lastChar == ',' || lastChar == '.') && secondToLastChar == ' ' && thirdToLastChar != ' ')
                {
                    int selectionStart = textBox1.SelectionStart;

                    // Удаление пробела
                    int indexToRemove = inputText.Length - 2;
                    if (indexToRemove >= 0 && inputText[indexToRemove] == ' ')
                    {
                        inputText = inputText.Remove(indexToRemove, 1);

                        textBox1.Text = inputText;

                        textBox1.SelectionStart = selectionStart;
                        textBox1.SelectionLength = 0;
                    }
                }
            }


            currentInput = inputText;

            // Получение слов из базы данных
            var words = db.Words
                .Where(x => x.Word.StartsWith(currentInput))
                .GroupBy(w => w.Word)
                .OrderByDescending(g => g.Count()) 
                .ThenBy(g => g.Key)
                .SelectMany(g => g)
                .Take(5)
                .ToList();

            richTextBox1.Clear();

            foreach (var word in words)
            {
                richTextBox1.AppendText(word.Word + Environment.NewLine);
            }
        }

        private void созданиеСловаряToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                db.Words.RemoveRange(db.Words.ToList());
                string filePath = openFileDialog.FileName;
                LoadTextFromFile(filePath);
            }
        }

        private void LoadTextFromFile(string filePath)
        {
            foreach (var item in File.ReadLines(filePath))
            {
                db.Words.Add(new TextDictionary { Word = item });
            }
            Save();
        }

        private void Save()
        {
            db.SaveChanges();
        }

        private void обновлениеСловаряToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                LoadTextFromFile(filePath);
            }
        }

        private void удалениеСловаряToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            db.Words.RemoveRange(db.Words.ToList());
            Save();
        }

        private void richTextBox1_MouseClick(object sender, MouseEventArgs e)
        {
            //позиция клика в RichTextBox
            int charIndex = richTextBox1.GetCharIndexFromPosition(e.Location);

            //индексначала слова
            int startIndex = GetStartOfWordIndex(charIndex);

            //индекс конца слова
            int endIndex = GetEndOfWordIndex(charIndex);

            // Пометка слова синим цветом
            MarkWordWithColor(startIndex, endIndex, Color.Blue);


        }

        // Метод индекса начала слова
        private int GetStartOfWordIndex(int charIndex)
        {
            string text = richTextBox1.Text;
            int startIndex = charIndex;

            // Находит начало слова, от текущего индекса, влево
            while (startIndex > 0 && !char.IsWhiteSpace(text[startIndex - 1]))
            {
                startIndex--;
            }

            return startIndex;
        }

        // Метод для получения индекса конца слова
        private int GetEndOfWordIndex(int charIndex)
        {
            string text = richTextBox1.Text;
            int endIndex = charIndex;

            // Находит конец слова, от текущего индекса, вправо
            while (endIndex < text.Length && !char.IsWhiteSpace(text[endIndex]))
            {
                endIndex++;
            }

            return endIndex;
        }

        // Пометка слова цветом
        private void MarkWordWithColor(int startIndex, int endIndex, Color color)
        {
            int currentPosition = richTextBox1.SelectionStart;

            richTextBox1.SelectionStart = startIndex;

            richTextBox1.SelectionLength = endIndex - startIndex;

            richTextBox1.SelectionColor = color;

            richTextBox1.SelectionLength = 0;

            richTextBox1.SelectionStart = currentPosition;
            richTextBox1.SelectionColor = richTextBox1.ForeColor; // Сброс цвета по умолчанию
        }

        private void richTextBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int charIndex = richTextBox1.GetCharIndexFromPosition(e.Location);

            int startIndex = GetStartOfWordIndex(charIndex);

            int endIndex = GetEndOfWordIndex(charIndex);

            string selectedWord = richTextBox1.Text.Substring(startIndex, endIndex - startIndex);


            // Присвоение значения выбранного слова в TextBox
            textBox1.Text = selectedWord + " ";


        }
    }

}
