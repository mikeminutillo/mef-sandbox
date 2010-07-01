using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel.Composition;
using Contracts;

namespace WinFormsHost
{
    [Export("Main", typeof(Form))]
    [Export(typeof(IFeedbackProvider))]
    public partial class Form1 : Form, IFeedbackProvider
    {
        public Form1()
        {
            InitializeComponent();
            CommandTextbox.Focus();
        }

        public void ProvideFeedback(string format, params object[] args)
        {
            FeedbackTextbox.AppendText(String.Format(format + Environment.NewLine, args));
        }

        [Import]
        CommandRunner _runner;

        private void GoButton_Click(object sender, EventArgs e)
        {
            _runner.ExecuteCommand(CommandTextbox.Text);
            CommandTextbox.Clear();
            CommandTextbox.Focus();
        }
    }
}
