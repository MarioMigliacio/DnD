using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HeroMaker.Enums;

namespace HeroMaker.Forms
{
    public partial class Stat : Form
    {
        #region Form Essentials

        public Stat()
        {
            InitializeComponent();
        }

        /// <summary>
        /// A failsafe for the user. If the user clicks the exit button on the top right of the application, signal that
        /// we are done using the app and want it closed.
        /// </summary>
        private void Stat_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormControl.GS = GameState.Final;
            this.Dispose();
        }

        /// <summary>
        /// 
        /// </summary>
        private void NextState_Click(object sender, EventArgs e)
        {
            FormControl.GS = GameState.Final;
            this.Dispose();
        }

        #endregion
    }
}
