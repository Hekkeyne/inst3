using System.Data;

namespace inst3
{
    public partial class Form1 : Form
    {
        public Dictionary<Keys, Action<DataGridView>> dict1;
        public Form1()
        {
            InitializeComponent();
        }
        private void table_schet(DataGridView dtv)
        {
            for (int i = 0; i <= dtv.Columns.Count - 1; i++)
            {
                for (int j = 1; j <= dtv.Rows.Count; j++)
                {
                    dtv[i, j - 1].Value = i == j - 1 ? "*" : dtv[i, j - 1].Value;
                    dtv[i, j - 1].ReadOnly = true;
                }
            }
        }
        public int _sbk = 0;
        public int _str = 1;
        bool f1 = false;
        bool f2 = false;
        private void tb_kp(object sender, KeyEventArgs e)
        {
            if (dataGridView1.Columns.Count < 2)
            {
                for (int i = 0; i < 4; i++)
                {
                    dataGridView1.Columns.Add("", "");
                }
                dataGridView1.Rows.Add("*", "Вес", "L", "Flag");
                _sbk++;
            }
            if (sender == textBox2 && e.KeyCode == Keys.Enter)
            {
                if (dataGridView1.Columns.Count < 2)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        dataGridView1.Columns.Add("", "");
                    }
                    dataGridView1.Rows.Add("*", "Вес", "L", "Flag");
                    _sbk++;
                }
                DataGridViewTextBoxColumn cd = new DataGridViewTextBoxColumn();
                dataGridView1.Columns.Insert(_sbk, cd);
                dataGridView1[_sbk, 0].Value = textBox2.Text;
                dataGridView1[_sbk, 0].ReadOnly = true;
                _sbk++;
                addsome(textBox2.Text, textBox2);
                textBox2.Clear();
                L_schet();
            }
            else if (sender == textBox1 && e.KeyCode == Keys.Enter)
            {
                if (dataGridView1.Columns.Count < 2)
                {
                    dataGridView1.Columns.Add("", "");
                    dataGridView1.Rows.Add("*");
                    _str++;
                }
                dataGridView1.Rows.Add();
                dataGridView1[0, _str].Value = textBox1.Text;
                dataGridView1[0, _str].ReadOnly = true;
                _str++;
                addsome(textBox1.Text, textBox1);
                textBox1.Clear();
                flg();
                L_schet();
            }
            else if (sender == textBox3 && e.KeyCode == Keys.Enter)
            {
                f1 = true;
                textBox3.Enabled = !f1;
            }
            else if (sender == textBox4 && e.KeyCode == Keys.Enter)
            {
                
                f2 = true;
                textBox4.Enabled = !f2;
            }
            if(f1 && f2)
            {
                ALL_schet(Convert.ToDouble(textBox3.Text), Convert.ToDouble(textBox4.Text));
                textBox3.Clear();
                textBox4.Clear();
            }
        }
        public List<string> krit = new List<string>();
        public List<string> alter = new List<string>();
        private void addsome(string a, object sender)
        {
            if (sender == textBox1)
            {
                krit.Add(a);
            }
            if (sender == textBox2)
            {
                alter.Add(a);
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }
        private void flg()
        {
            DataGridViewCheckBoxCell cll = new DataGridViewCheckBoxCell();
            cll.ValueType = typeof(bool);
            for (int i = 1; i < dataGridView1.Rows.Count; i++)
            {
                var ncll = (DataGridViewCheckBoxCell)cll.Clone();
                ncll.Value = false;
                dataGridView1[dataGridView1.Columns.Count - 1, i] = ncll;
            }
        }
        private void L_schet()
        {

            for (int i = 1; i < dataGridView1.Rows.Count; i++)
            {
                double max = double.NegativeInfinity;
                double min = double.PositiveInfinity;
                for (int j = 1; j < dataGridView1.Columns.Count - 3; j++)
                {
                    try
                    {
                        max = max < Convert.ToDouble(dataGridView1[j, i].Value) ? Convert.ToDouble(dataGridView1[j, i].Value) : max;
                        min = min > Convert.ToDouble(dataGridView1[j, i].Value) ? Convert.ToDouble(dataGridView1[j, i].Value) : min;
                        //MessageBox.Show($"{dataGridView1[j, i].Value}");
                    }
                    catch
                    {
                        //MessageBox.Show($"{dataGridView1[j, i].Value} {j} {i}");
                    }
                }
                dataGridView1[dataGridView1.Columns.Count - 2, i].Value = max - min;
            }

        }

        private void dataGridView_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (sender == dataGridView1)
            {
                if (dataGridView1.IsCurrentCellDirty)
                {
                    dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
                }
            }
        }

        private void cvchg(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 1 && e.ColumnIndex < dataGridView1.Columns.Count - 3 && e.RowIndex >= 1 && e.RowIndex < dataGridView1.Rows.Count)
            {
                L_schet();
            }
        }
        private bool proverka1()
        {
            int user_ves = 0;
            for (int i = 1; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 1; j < dataGridView1.Columns.Count - 3; j++)
                {
                    var c = dataGridView1[j, i].Value;
                    if (c == null)
                    {
                        MessageBox.Show($"Проверьте Столбец {j + 1} и строку {i + 1}");
                        return false;
                    }

                }
            }
            for (int i = 1; i < dataGridView1.Rows.Count; i++)
            {
                try
                {

                    user_ves = user_ves + Convert.ToInt32(dataGridView1[dataGridView1.Columns.Count - 3, i].Value);
                }
                catch { MessageBox.Show($"столбец {dataGridView1.Columns.Count - 3} строка {i} странное значение"); return false; }
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!proverka1())
            {
                return;
            }
            int ii = 1;
            dataGridView2.Columns.Add("", "");
            dataGridView2.Rows.Add("*");
            foreach (string a in alter)
            {
                dataGridView2.Columns.Add("", "");
                dataGridView2[ii, 0].Value = a;
                dataGridView2[ii, 0].ReadOnly = true;
                dataGridView2.Rows.Add(a);
                ii++;
            }
            ii = 1;
            dataGridView3.Columns.Add("", "");
            dataGridView3.Rows.Add("*");
            foreach (string a in alter)
            {
                dataGridView3.Columns.Add("", "");
                dataGridView3[ii, 0].Value = a;
                dataGridView3[ii, 0].ReadOnly = true;
                dataGridView3.Rows.Add(a);
                ii++;
            }
            table_schet(dataGridView2);
            table_schet(dataGridView3);
            int ves = 0;
            int dlina = 0;
            for (int i = 1; i < dataGridView1.Rows.Count; i++)
            {
                ves = ves + Convert.ToInt32(dataGridView1[dataGridView1.Columns.Count - 3, i].Value);
                
            }
            int totalves = 0;
            List<int> totaldlina = new List<int>();
            for (int i = 1; i < dataGridView2.Rows.Count; i++)
            {
                for (int j = 1; j < dataGridView2.Columns.Count; j++)
                {
                    if (dataGridView2[j, i].Value != "*")
                    {
                        for (int y = 1; y < dataGridView1.Rows.Count; y++)
                        {
                            if (dataGridView1[dataGridView1.Columns.Count - 1, y].Value is bool bl && bl)
                            {
                                if (Convert.ToInt32(dataGridView1[j, y].Value) <= Convert.ToInt32(dataGridView1[i, y].Value))
                                {
                                    totalves += Convert.ToInt32(dataGridView1[dataGridView1.Columns.Count - 3, y].Value);
                                }
                                if (Convert.ToInt32(dataGridView1[j, y].Value) >= Convert.ToInt32(dataGridView1[i, y].Value))
                                {
                                    totaldlina.Add(Convert.ToInt32(dataGridView1[dataGridView1.Columns.Count - 2, y].Value));
                                }
                            }
                            if (dataGridView1[dataGridView1.Columns.Count - 1, y].Value is bool b && !b)
                            {
                                if (Convert.ToInt32(dataGridView1[j, y].Value) >= Convert.ToInt32(dataGridView1[i, y].Value))
                                {
                                    totalves += Convert.ToInt32(dataGridView1[dataGridView1.Columns.Count - 3, y].Value);
                                }
                                if (Convert.ToInt32(dataGridView1[j, y].Value) <= Convert.ToInt32(dataGridView1[i, y].Value))
                                {
                                    totaldlina.Add(Convert.ToInt32(dataGridView1[dataGridView1.Columns.Count - 2, y].Value));
                                }
                            }
                        }
                        try
                        {
                            dlina = Convert.ToInt32(dataGridView1[dataGridView1.ColumnCount - 2, i].Value);

                            totaldlina.Sort((x, y) => y.CompareTo(x));
                            dataGridView2[j, i].Value = (double)totalves / ves;
                            totalves = 0;
                            dataGridView3[j, i].Value = (double)totaldlina[0] / dlina;
                            totaldlina.Clear();
                        }
                        catch { }
                    }
                }
            }
            MessageBox.Show($"Теперь нельзя изменять критерии и альтернативы\n\rНажмите -, если необходимо что-то изменить");
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            dataGridView1.Enabled = false;
            button1.Enabled = false;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
        }
        public int yadra = 1;
        private void ALL_schet(double Z, double U)
        {
            List<string> yadro = new List<string>();
            int rc = dataGridView2.ColumnCount;
            for (int i = 1; i < rc; i++)
            {
                for (int j = 1; j < rc; j++)
                {
                    if (dataGridView2[i, j].Value != "*")
                    {
                        if (Convert.ToDouble(dataGridView2[i, j].Value) < Z || Convert.ToDouble(dataGridView3[i, j].Value) > U)
                        {
                            yadro.Add(Convert.ToString(dataGridView2[i, 0].Value));
                        }
                    }
                }
            }
            textBox5.Text += $"ядро {yadra}:";
            foreach (string g in yadro)
                textBox5.Text += $" {g} ";
            yadra++;
            f1 = false;
            f2 = false;
            textBox3.Enabled = !f1;
            textBox4.Enabled = !f2;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
