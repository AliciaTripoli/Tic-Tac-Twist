using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe_version2
{
    public partial class Twist : Form
    {
        public Twist()
        {
            InitializeComponent();
        }
     
        //Dare
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            string title = "DARE";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            string[] messages = { " Balance a spoon on your nose for a minute. ",
                                  " Smell another player's feet. ",
                                  "Act like a chicken for a minute.",
                                  "Eat a spoonful of a condiment.",
                                  "Take a bite of a lemon.",
                                  "Spin fast 15 times and walk from one end of the room to the other in a straight line.",
                                  "For the next 10 minutes sing anything you want to say like opera.",
                                  "Let three ice cubes melt in your mouth.",
                                  "Make the face you make after eating something nasty and hold it until your next turn.",
                                  "Juggle three objects picked by the other players.",
                                  "Take a screenshot of your browsing history and send it to the group.",
                                  "Drop an ice cube down your underwear and leave it there until it melts." };
            DialogResult result = MessageBox.Show(messages[(int)(DateTime.Now.Ticks % messages.Length)],title, buttons);
            if (result == DialogResult.OK)
            {
               
                this.Hide();
            }

        }
        //TRUTH
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string title = "TRUTH";
            MessageBoxButtons buttons = MessageBoxButtons.OK;

            string[] messages = { "What's a secret you've never shared about yourself?",
                                  "What was the last thing that made you cry?",
                                  "Who was your first love?",
                                  "Does aging scare you?",
                                  "What's a skill you wish you had?",
                                  "What was the last lie you told?",
                                  "What's your worst personality trait?",
                                  "What's your all-time favorite book?",
                                  "Do you find it easy to trust people?",
                                  "Have you ever been so angry you hit someone?",
                                  "Who is your hero?",
                                  "Can you keep a secret?" };
            DialogResult result = MessageBox.Show(messages[(int)(DateTime.Now.Ticks % messages.Length)], title, buttons);
            if (result == DialogResult.OK)
            {
                this.Hide();
            }
        }
    }
}
