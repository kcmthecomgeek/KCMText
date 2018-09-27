using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KCMText
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            mainEditor.WordWrap = true;
        }

        private void UpdateLineAndChar()
        {
            lineCharStatusLabel.Text = "LN: " + mainEditor.GetLineNumber().ToString() + " CH: " + mainEditor.GetCurrentChar().ToString();
        }

        private void mainEditor_CursorPositionChanged(object sender, EventArgs e)
        {
            UpdateLineAndChar();
        }

        private void mainEditor_ModifierKeyPressed(object sender, KeyEventArgs e)
        {
            numLockLabel.Enabled = Control.IsKeyLocked(Keys.NumLock);
            capsLockLabel.Enabled = Control.IsKeyLocked(Keys.CapsLock);
            scrollLockLabel.Enabled = Control.IsKeyLocked(Keys.Scroll);
            UpdateLineAndChar();
        }
    }
}
