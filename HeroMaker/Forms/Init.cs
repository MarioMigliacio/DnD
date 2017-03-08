using System;
using System.Windows.Forms;
using HeroMaker.Enums;

namespace HeroMaker.Forms
{
    /// <summary>
    /// The initial form for the character creation application.
    /// </summary>
    public partial class Init : Form
    {
        #region Form Essentials

        /// <summary>
        /// Upon form construction, this method is called. It is core to the construction of WinForm objects.
        /// </summary>
        public Init()
        {
            InitializeComponent();
        }

        /// <summary>
        /// When we are ready to begin the character creation process, the button click signals the FormControl object to change states.
        /// </summary>
        private void create_Click(object sender, EventArgs e)
        {
            //FormControl.Gs = FormControl.GetNextState();
            FormControl.Gs = GameState.Feat;
            this.Dispose();
        }

        /// <summary>
        /// A failsafe for the user. If the user clicks the exit button on the top right of the application, signal that
        /// we are done using the app and want it closed.
        /// </summary>
        private void Init_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormControl.Gs = GameState.Final;
            this.Dispose();
        }

        #endregion
    }
}
