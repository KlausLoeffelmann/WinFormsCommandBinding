using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace WinFormsCommandBindingDemo
{
    public class TestButton : Button
    {
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            Debug.Print(m.ToString());

            if (m.Msg==12)
            {
            }
        }
    }
}
