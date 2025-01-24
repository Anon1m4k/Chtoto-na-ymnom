using System.Drawing;
using System.Windows.Forms;

namespace FirstWinFormsApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            this.Text = "Текст из конструктора";
            string hexValue = "#FF0000";
            Color color = ColorTranslator.FromHtml(hexValue);
            this.BackColor = color;
        }

        private bool stringIsSpaces(string str)
        {
            for(int i = 0; i < str.Length; i++) 
            {
                char symbol = str[i];
                if(symbol != ' ')
                {
                    return false;
                }
            }

            return true;
        }

        private bool lastSpaces(string input)
        {
            for (int i = input.Length-1; i >=0; i--)  //дз сделано
            {                
                if (input[i] != ' ')
                {
                    return true;
                }
            }    
            return false;
        }

        // ДЗ: добавить проверку на пробелы в конце
        private void AddPeople_Click(object sender, System.EventArgs e)
        {
            string inputText = PeopleTextBox.Text;
            if(inputText == string.Empty)
            {
                MessageBox.Show("Пустые значения недопустимы");
                return;
            }

            if(stringIsSpaces(inputText))
            {
                MessageBox.Show("Извините, у Вас одни пробелы");
                return;
            }

            if (lastSpaces(inputText))
            {
                MessageBox.Show("Извините, у Вас в конце пробел/ы");
                return;
            }

            Peoples.Items.Add(inputText);
        }

        private void Peoples_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                int selectedIndex = Peoples.SelectedIndex;
                if (selectedIndex >= 0)
                {
                    Peoples.Items.RemoveAt(selectedIndex);
                }
            }
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {

        }

        private void Peoples_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }
    }
}
