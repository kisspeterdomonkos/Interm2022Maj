/*8. feladat: K�sz�tsen grafikus alkalmaz�st, melynek a projektj�t SuperBowlGUI n�ven mentse el,
    melynek seg�ts�g�vel r�mai �s arab sz�mok k�zt tud �tv�lt�st k�sz�teni 1 �s 10 (I �s X) k�z�tt!*/
namespace SuperBowlGUI
{
    class Changer
    {
        public static string RtoA(string roman)
        {
            Dictionary<string, string> helper = new Dictionary<string, string>
            {
               {"I", "1"},
               {"II", "2"},
               {"III", "3"},
               {"IV", "4"},
               {"V", "5"},
               {"VI", "6"},
               {"VII", "7"},
               {"VIII", "8"},
               {"IX", "9"},
               {"X", "10"}
            };
            return helper.ContainsKey(roman.ToUpper()) ? helper[roman.ToUpper()] : "Hiba!";
        }
        public static string AtoR(string arabic)
        {
            Dictionary<string, string> helper = new Dictionary<string, string>
            {
               {"1", "I"},
               {"2", "II"},
               {"3", "III"},
               {"4", "IV"},
               {"5", "V"},
               {"6", "VI"},
               {"7", "VII"},
               {"8", "VIII"},
               {"9", "IX"},
               {"10", "X"}
            };
            return helper.ContainsKey(arabic) ? helper[arabic] : "Hiba!";
        }
    }
    public partial class SuperBowlGUI : Form
    {
        public SuperBowlGUI()
        {
            InitializeComponent();
        }

        private void SuperBowlGUI_Load(object sender, EventArgs e)
        {

        }

        private void switchButton_Click(object sender, EventArgs e)
        {
            
            if (switchButton.Text == "--->")
            {
                switchButton.Text = "<---";
                romanTextBox.Clear();
                romanTextBox.Enabled = false;
                arabicTextBox.Enabled = true;
            }
            else
            {
                switchButton.Text = "--->";
                arabicTextBox.Clear();
                arabicTextBox.Enabled = false;
                romanTextBox.Enabled = true;
            }

        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            if (romanTextBox.Enabled)
            {
                arabicTextBox.Text = Changer.RtoA(romanTextBox.Text);
            }
            else
            {
                romanTextBox.Text = Changer.AtoR(arabicTextBox.Text);
            }
        }
    }
}