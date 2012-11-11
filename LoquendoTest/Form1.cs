using System;
using System.Windows.Forms;
using LTTS7Lib;

namespace LoquendoTest
{
    public partial class Form1 : Form
    {
        private LTTS7Class _tt;

        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
        }

        void Form1_Load(object sender, EventArgs e)
        {
            string s = string.Empty;
            _tt = new LTTS7Class();

            s = _tt.EnumFirstVoice("");

            while (!string.IsNullOrEmpty(s))
            {
                cb_voice.Items.Add(s);
                s = _tt.EnumNextVoice();
            }

            s = _tt.EnumFirstLanguage("");

            while (!string.IsNullOrEmpty(s))
            {
                cb_language.Items.Add(s);
                s = _tt.EnumNextLanguage();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ( !string.IsNullOrEmpty( txt.Text ))
            {
                _tt.Read(txt.Text);
            }
        }

        private void cb_persons_SelectedIndexChanged(object sender, EventArgs e)
        {
            _tt.Voice = cb_voice.Text;
        }

        private void cb_voice_SelectedIndexChanged(object sender, EventArgs e)
        {
            _tt.Language = cb_language.Text;
        }
    }
}
