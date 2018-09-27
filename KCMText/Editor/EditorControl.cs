using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KCMText.Editor
{
    public partial class EditorControl : UserControl
    {
        /// <summary>
        /// Occurs when the cursor has moved.
        /// </summary>
        public event EventHandler CursorPositionChanged;
        /// <summary>
        /// Occurs when a modifier key has been pressed (CAPS, NUMLOCK, or SCROLL).
        /// </summary>
        public event KeyEventHandler ModifierKeyPressed;
        /// <summary>
        /// Occurs when an about dialog has been requested. (About item selected in context menu).
        /// </summary>
        public event EventHandler AboutDialogRequested;

        /// <summary>
        /// Create a new default instance.
        /// </summary>
        public EditorControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Determines whether data can be cut from the control.
        /// </summary>
        public bool CanCut
        {
            get {if (txtMain.SelectionLength == 0) { return false; } else { return true; }}
        }
        /// <summary>
        /// Determines whether data can be copied from the control.
        /// </summary>
        public bool CanCopy
        {
            get { if (txtMain.SelectionLength == 0) { return false; } else { return true; } }
        }
        /// <summary>
        /// Determines whether data can be pasted into the control.
        /// </summary>
        public bool CanPaste
        {
            get { return Clipboard.ContainsText(); }
        }
        /// <summary>
        /// Gets whether Word Wrap is turned on. Can also be used to control the setting.
        /// </summary>
        public bool WordWrap
        {
            get { return txtMain.WordWrap; }
            set { txtMain.WordWrap = value; RaiseCursorPositionModified(this, new EventArgs()); }
        }
        /// <summary>
        /// Perform a cut action on the currently selected text.
        /// </summary>
        public void Cut()
        {
            txtMain.Cut();
        }
        /// <summary>
        /// Perform a copy action on the currently selected text.
        /// </summary>
        public void Copy()
        {
            txtMain.Copy();
        }
        /// <summary>
        /// Perform a paste action at the current location in the control.
        /// </summary>
        public void Paste()
        {
            txtMain.Paste();
        }
        /// <summary>
        /// Selects all text in the control.
        /// </summary>
        public void SelectAll()
        {
            txtMain.Focus();
            txtMain.SelectAll();
        }
        /// <summary>
        /// Determine and return the current line number where the cursor is located.
        /// </summary>
        /// <returns>An integer value (current line number).</returns>
        public int GetLineNumber()
        {
            return txtMain.GetLineFromCharIndex(txtMain.GetFirstCharIndexOfCurrentLine()) + 1;
        }
        /// <summary>
        /// Determine and return the current character in the current line where the cursor is located.
        /// </summary>
        /// <returns>An integer value (current character minus the first character on the current line).</returns>
        public int GetCurrentChar()
        {
            return (txtMain.SelectionStart - txtMain.GetFirstCharIndexOfCurrentLine()) + 1;
        }
        /// <summary>
        /// Requests and performs a font change on the editor.
        /// </summary>
        /// <returns></returns>
        public bool RequestFontChange()
        {
            fontSelector.Font = txtMain.Font;
            DialogResult result = fontSelector.ShowDialog(this.Parent);
            if (result == DialogResult.OK)
            {
                txtMain.Font = fontSelector.Font;
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Purposefully raise the "CursorPositionModified" event.
        /// </summary>
        /// <param name="sender">Sender of the event.</param>
        /// <param name="e">Basic event arguments.</param>
        protected virtual void RaiseCursorPositionModified(object sender, EventArgs e)
        {
            if (CursorPositionChanged != null)
                CursorPositionChanged(sender, e);
        }

        /// <summary>
        /// Purposefully raise the "ModifierKeyPressed" event.
        /// </summary>
        /// <param name="sender">The sender of the event.</param>
        /// <param name="e">Event arguments containing which keys were pressed.</param>
        protected virtual void RaiseModifierKeyPressed(object sender, KeyEventArgs e)
        {
            if (ModifierKeyPressed != null)
                ModifierKeyPressed(sender, e);
        }

        protected virtual void RaiseAboutDialogRequested(object sender, EventArgs e)
        {
            if (AboutDialogRequested != null)
                AboutDialogRequested(sender, e);
        }

        /// <summary>
        /// Catch when a key is pressed within the text box.
        /// </summary>
        /// <param name="sender">The sender of the event.</param>
        /// <param name="e">Event arguments containing which keys were pressed.</param>
        private void txtMain_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.CapsLock 
                || e.KeyCode == Keys.NumLock 
                || e.KeyCode == Keys.Scroll)
            {
                // A modifier key has been pressed. Raise the appropriate event.
                RaiseModifierKeyPressed(sender, e);
            }
            // A key has been pressed. The cursor position has likely updated.
            CursorPositionChanged(sender, e);
        }
        /// <summary>
        /// Handle enabling/disabling of menu items before the menu is finished opening.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void contextStrip_Opening(object sender, CancelEventArgs e)
        {
            cutMenuItem.Enabled = CanCut;
            copyMenuItem.Enabled = CanCopy;
            pasteMenuItem.Enabled = CanPaste;
            wordWrapMenuItem.Checked = WordWrap;
        }
        /// <summary>
        /// Open the about dialog. Send event to parent.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutMenuItem_Click(object sender, EventArgs e)
        {
            RaiseAboutDialogRequested(sender, e);
        }
        /// <summary>
        /// User clicked the "Font..." menu item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fontMenuItem_Click(object sender, EventArgs e)
        {
            RequestFontChange();
        }
        /// <summary>
        /// User clicked the "Select All" menu item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void selectAllMenuItem_Click(object sender, EventArgs e)
        {
            SelectAll();
        }

        private void cutMenuItem_Click(object sender, EventArgs e)
        {
            Cut();
        }

        private void copyMenuItem_Click(object sender, EventArgs e)
        {
            Copy();
        }

        private void pasteMenuItem_Click(object sender, EventArgs e)
        {
            Paste();
        }

        private void wordWrapMenuItem_Click(object sender, EventArgs e)
        {
            WordWrap = wordWrapMenuItem.Checked;
            if (!WordWrap)
                txtMain.ScrollBars = ScrollBars.Both;
            else
                txtMain.ScrollBars = ScrollBars.Vertical;
        }
    }

}
