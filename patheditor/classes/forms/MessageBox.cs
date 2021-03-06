#region Using directives

using System;
using System.Windows.Forms;
using com.jds.PathEditor.classes.services;

#endregion

namespace com.jds.PathEditor.classes.forms
{
    public partial class MessageBox : Form
    {
        public static string TitleFormat = "{0}";
        public static string MessageFormat = "{0}";

        public static string TextSeparator = "________________________________________________";
        public static string TextError = "Error";
        public static string TextInfo = "Information";

        public static Form parentForm;

        public MessageBox(string message, string title, bool info)
        {
            InitializeComponent();


            if (title == TextError)
                title = Localizate.getMessage(Word.ERROR);
            else
                title = Localizate.getMessage(Word.INFO);

            Text = String.Format(TitleFormat, title);
            text.Text = String.Format(MessageFormat, message);

            if (info)
                picture.Image = Resources.Information;

            if (parentForm != null)
            {
                if (parentForm.InvokeRequired)
                {
                    ShowDialogDelegate d = ShowDialog;
                    parentForm.Invoke(d, parentForm);
                }
                else
                {
                    ShowDialog(parentForm);
                }
            }
            else
                ShowDialog();
        }

        public MessageBox(Exception e) : this(e, false)
        {
        }

        public MessageBox(Exception e, bool info) : this(e.ToString(), TextError, info)
        {
        }

        public MessageBox(string message, Exception e) : this(message, e, false)
        {
        }

        public MessageBox(string message, Exception e, bool info)
            : this(
                String.Format(
                    "{0}\n\n\n\nTechnical error description:\n" + TextSeparator + "\n{1}\n" + TextSeparator + "\n{2}",
                    message, e.Message, e), TextError, info)
        {
        }

        public MessageBox(string message, bool info) : this(message, info ? TextInfo : TextError, info)
        {
        }

        public MessageBox(string message) : this(message, false)
        {
        }

        private void MessageBox_Load(object sender, EventArgs e)
        {
        }

        private void MessageBox_Shown(object sender, EventArgs e)
        {
            BringToFront();
            Activate();
        }

        #region Nested type: ShowDialogDelegate

        private delegate DialogResult ShowDialogDelegate(Form parent);

        #endregion
    }
}