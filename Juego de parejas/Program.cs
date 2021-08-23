using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juego_de_parejas
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
public partial class Form1 : Form
{
    // Use this Random object to choose random icons for the squares
    Random random = new Random();

    // Each of these letters is an interesting icon
    // in the Webdings font,
    // and each icon appears twice in this list
    List<string> icons = new List<string>()
    {
        "!", "!", "N", "N", ",", ",", "k", "k",
        "b", "b", "v", "v", "w", "w", "z", "z"
    };
    /// <summary>
    /// Every label's Click event is handled by this event handler
    /// </summary>
    /// <param name="sender">The label that was clicked</param>
    /// <param name="e"></param>
    private void label_Click(object sender, EventArgs e)
    {
        Label clickedLabel = sender as Label;

        if (clickedLabel != null)
        {
            // If the clicked label is black, the player clicked
            // an icon that's already been revealed --
            // ignore the click
            if (clickedLabel.ForeColor == Color.Black)
                return;

            // If firstClicked is null, this is the first icon 
            // in the pair that the player clicked,
            // so set firstClicked to the label that the player 
            // clicked, change its color to black, and return
            if (firstClicked == null)
            {
                firstClicked = clickedLabel;
                firstClicked.ForeColor = Color.Black;

                return;
            }
        }
    }




