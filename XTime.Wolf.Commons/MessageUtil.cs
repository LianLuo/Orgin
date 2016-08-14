using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XTime.Wolf.Commons
{
    public class MessageUtil
    {
        public static bool ConfirmYesNo(string prompt)
        {
            return (MessageBox.Show(prompt, "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes);
        }

        public static DialogResult ConfirmYesNoCancel(string prompt)
        {
            return MessageBox.Show(prompt, "系统提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
        }

        public static DialogResult ShowError(string message)
        {
            return MessageBox.Show(message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        public static DialogResult ShowTips(string message)
        {
            return MessageBox.Show(message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        public static DialogResult ShowWarning(string message)
        {
            return MessageBox.Show(message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public static DialogResult ShowYesNoAndError(string message)
        {
            return MessageBox.Show(message, "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
        }

        public static DialogResult ShowYesNoAndTips(string message)
        {
            return MessageBox.Show(message, "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
        }

        public static DialogResult ShowYesNoAndWarning(string message)
        {
            return MessageBox.Show(message, "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
        }

        public static DialogResult ShowYesNoCancelAndTips(string message)
        {
            return MessageBox.Show(message, "系统提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk);
        }
    }
}
