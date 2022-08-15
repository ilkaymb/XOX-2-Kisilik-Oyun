using System;
using System.Windows.Forms;

namespace XOX_oyun
{

    public partial class Form1 : Form
    {
        public bool turn_checker = true;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void pos_zero_button_Click(object sender, EventArgs e)
        {
            if (turn_checker)
                pos_zero_button.Text = "X";
            else
                pos_zero_button.Text = "O";


            pos_zero_button.Enabled = false;

            control_unite();

        }

        private void pos_one_button_Click(object sender, EventArgs e)
        {
            if (turn_checker)
                pos_one_button.Text = "X";
            else
                pos_one_button.Text = "O";


            pos_one_button.Enabled = false;
            control_unite();

        }

        private void pos_two_button_Click(object sender, EventArgs e)
        {
            if (turn_checker)
                pos_two_button.Text = "X";
            else
                pos_two_button.Text = "O";


            pos_two_button.Enabled = false;
            control_unite();
        }

        private void pos_tree_button_Click(object sender, EventArgs e)
        {
            if (turn_checker)
                pos_tree_button.Text = "X";
            else
                pos_tree_button.Text = "O";


            pos_tree_button.Enabled = false;
            control_unite();

        }

        private void pos_four_button_Click(object sender, EventArgs e)
        {
            if (turn_checker)
                pos_four_button.Text = "X";
            else
                pos_four_button.Text = "O";


            pos_four_button.Enabled = false;
            control_unite();

        }

        private void pos_five_button_Click(object sender, EventArgs e)
        {
            if (turn_checker)
                pos_five_button.Text = "X";
            else
                pos_five_button.Text = "O";


            pos_five_button.Enabled = false;
            control_unite();

        }

        private void pos_six_button_Click(object sender, EventArgs e)
        {
            if (turn_checker)
                pos_six_button.Text = "X";
            else
                pos_six_button.Text = "O";


            pos_six_button.Enabled = false;
            control_unite();

        }

        private void pos_seven_button_Click(object sender, EventArgs e)
        {
            if (turn_checker)
                pos_seven_button.Text = "X";
            else
                pos_seven_button.Text = "O";


            pos_seven_button.Enabled = false;
            control_unite();


        }

        private void pos_eight_button_Click(object sender, EventArgs e)
        {
            if (turn_checker)
                pos_eight_button.Text = "X";
            else
                pos_eight_button.Text = "O";


            pos_eight_button.Enabled = false;
            control_unite();


        }
        public string[,] matrix_replacer()
        {
            string[,] matrix = new string[3, 3]{ {pos_zero_button.Text.ToString(),pos_one_button.Text.ToString(),pos_two_button.Text.ToString() },
                { pos_tree_button.Text.ToString(),pos_four_button.Text.ToString(),pos_five_button.Text.ToString() },
                { pos_six_button.Text.ToString(),pos_seven_button.Text.ToString(),pos_eight_button.Text.ToString() }
            };
            return matrix;

        }

        public void control_unite()
        {
            win_checker();

            turn_checker = !turn_checker;

        }

        public int counter = default;
        public void win_checker()
        {
            string[,] matrix = matrix_replacer();

            if (turn_checker)
            {
                x_axis_checker("X", matrix);

                y_axis_checker("X", matrix);

                corner_checker("X", matrix);

            }
            else
            {
                x_axis_checker("O", matrix);

                y_axis_checker("O", matrix);

                corner_checker("O", matrix);

            }

        }

        public void x_axis_checker(string symbol, string[,] matrix)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (matrix[i, j] == symbol)
                    {
                        counter++;
                        if (counter == 3)
                            switch (MessageBox.Show($"TEBRIKLER {symbol} KAZANDI", "kazanma", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information))
                            {
                                case DialogResult.Cancel:
                                    Application.Exit();
                                    break;
                                case DialogResult.Retry:
                                    Form1 form = new Form1();
                                    form.Show();
                                    this.Hide();
                                    break;
                                
                            }

                    }
                    else
                    {
                        counter = default;
                        break;
                    }
                }
            }
        }
        public void y_axis_checker(string symbol, string[,] matrix)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (matrix[j, i] == symbol)
                    {
                        counter++;
                        if (counter == 3)
                            switch (MessageBox.Show($"TEBRIKLER {symbol} KAZANDI", "kazanma", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information))
                            {
                                case DialogResult.Cancel:
                                    Application.Exit();
                                    break;
                                case DialogResult.Retry:
                                    Form1 form = new Form1();
                                    form.Show();
                                    this.Hide();
                                    break;

                            }
                    }
                    else
                    {
                        counter = default;
                        break;
                    }
                }
            }
        }

        public void corner_checker(string symbol, string[,] matrix)
        {
            if (matrix[0, 0] == symbol && matrix[1, 1] == symbol && matrix[2, 2] == symbol)
            {
                switch (MessageBox.Show($"TEBRIKLER {symbol} KAZANDI", "kazanma", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information))
                {
                    case DialogResult.Cancel:
                        Application.Exit();
                        break;
                    case DialogResult.Retry:
                        Form1 form = new Form1();
                        form.Show();
                        this.Hide();
                        break;

                };
            }
            else if (matrix[0, 2] == symbol && matrix[1, 1] == symbol && matrix[2, 0] == symbol)
            {
                switch (MessageBox.Show($"TEBRIKLER {symbol} KAZANDI", "kazanma", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information))
                {
                    case DialogResult.Cancel:
                        Application.Exit();
                        break;
                    case DialogResult.Retry:
                        Form1 form = new Form1();
                        form.Show();
                        this.Hide();
                        break;

                }

            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
