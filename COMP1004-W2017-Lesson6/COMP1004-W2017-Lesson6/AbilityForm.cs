using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_W2017_Lesson6
{
    public partial class AbilityForm : Form
    {
        private SplashForm _previousForm;
        private Random random = new Random();
        private int _health;
        private int _karma;
        private List<TextBox> _abilities;

        public SplashForm previousForm { get; set; }

        public AbilityForm()
        {
            InitializeComponent();

            // Initialize a List of TextBox (empty container)
            _abilities = new List<TextBox>();
            _initializeAbilities();
        }

        private void _initializeAbilities()
        {
            _abilities.Add(fightingTextBox);
            _abilities.Add(agilityTextBox);
            _abilities.Add(strengthTextBox);
            _abilities.Add(enduranceTextBox);
            _abilities.Add(reasonTextBox);
            _abilities.Add(intuitioinTextBox);
            _abilities.Add(psycheTextBox);
        }

        /// <summary>
        /// This method generates a number betwnn 5 and 50.
        /// </summary>
        /// <returns>
        /// return 5 to 50.
        /// </returns>
        private int _roll5d10()
        {
            int result = 0;
            for (int count = 0; count < 5; count++)
            {
                result += random.Next(1, 11);
            }
            return result;
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            // initialize health and karma every roll
            _health = 0;
            _karma = 0;

            // Iterate through the TextBox List (_abilities)
            for (int i = 0; i < _abilities.Count; i++)
            {
                TextBox abilitiesTextBox = _abilities[i];

                // role 5d10 and assign the value to a temp variable
                int currentRole = _roll5d10();

                // if my ability is physical (ability 0 to 3) add to health
                if (i < 4)
                {
                    _health += currentRole;
                } else // otherwise add to karma
                {
                    _karma += currentRole;
                }

                // assign the urrent roll to the current ability
                abilitiesTextBox.Text = currentRole.ToString();
            }
            healthTextBox.Text = _health.ToString();
            KarmaTextBox.Text = _karma.ToString();
        }
    }
}
