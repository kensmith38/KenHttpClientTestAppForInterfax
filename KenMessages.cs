﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KenHttpClientTestAppForInterfax
{

    public static class KenMessages
    {
        public const string WindowShortTitleText = "KenHttpClientTestApp";

        public static void DisplayInfoMessage(string message)
        {
            MessageBox.Show(message, WindowShortTitleText, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void DisplayErrorMessage(string message)
        {
            MessageBox.Show(message, WindowShortTitleText, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void DisplayExceptionMessage(Exception exc)
        {
            if (exc == null)
            {
                throw new ArgumentNullException(nameof(exc));
            }
            // 2/25/2024 exc.InnerExceptions can be "nested" but the base exception is usually what we want!
            Exception baseException = exc.GetBaseException();
            string primaryMessage = baseException.Message;
            string message = primaryMessage + "\n\nStack trace:\n" + exc.StackTrace;
            MessageBox.Show(message, WindowShortTitleText, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static DialogResult AskYesNoQuestion(string question)
        {
            DialogResult result = MessageBox.Show(question, WindowShortTitleText,
                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return result;
        }
    }
}
