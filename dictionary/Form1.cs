using Microsoft.VisualBasic;
namespace dictionary

{
    public partial class Form1 : Form
    {
        Dictionary<String, String> MyDic = new Dictionary<string, string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void showDic()
        {
            textBox3.Clear();
            foreach (KeyValuePair<String, String> element in MyDic)
            {
                textBox3.Text += "Key = " + element.Key + " , Value = "
                    + element.Value + "\r\n";
            }
        }
        public void Cleartextbox()
        {
            textBox1.Clear();
            textBox2.Clear();
        }
        private void Btn_add(object sender, EventArgs e)
        {
            try
            {
                if (!textBox1.Text.Trim().Equals("") && !textBox2.Text.Trim().Equals(""))
                {
                    MyDic.Add(textBox1.Text, textBox2.Text);
                    Cleartextbox();
                    showDic();
                }
                else
                {
                    MessageBox.Show("Please Input all Data");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("This Key is already exist");
                Cleartextbox();
            }
        }
        private void Btn_remove(object sender, EventArgs e)
        {
            string st = Interaction.InputBox("Input key", "Remove");
            if (MyDic.ContainsKey(st))
            {
                MyDic.Remove(st);
                MessageBox.Show("Key is removed");
                showDic();
            }
            else
            {
                MessageBox.Show("Key dose not exist");
                return;
            }
        }

        private void Btn_search(object sender, EventArgs e)
        {

            string st = Interaction.InputBox("Input key", "Search");
            if (MyDic.ContainsKey(st))
            {
                MessageBox.Show("Value is " + MyDic[st]);
                showDic();
            }
            else
            {
                MessageBox.Show("Key is invalid");
            }
        }

        private void Show_Click(object sender, EventArgs e)
        {
            showDic();
        }

    }
}