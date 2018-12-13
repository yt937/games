using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private List<Movie> movieList;
        private MyTree tree;

        public Form1()
        {
            InitializeComponent();
            this.movieList = new List<Movie>();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            StreamReader streamReader = new StreamReader(new FileStream(openFileDialog.FileName, FileMode.OpenOrCreate));
            string str = "";
            while (true)
            {
                str = streamReader.ReadLine();
                if (str == null)
                {
                    break;
                }
                string[] strArrays = str.Split(new char[] { ';' });
                Movie movie = new Movie(strArrays[0], Convert.ToDateTime(strArrays[1]), Convert.ToInt32(strArrays[2]), strArrays[3], Convert.ToDouble(strArrays[4]));
                if (this.movieList.Contains(movie))
                {
                    MessageBox.Show(string.Concat("Duplicate Movie Not Inserted: ", movie.Title));
                }
                else
                {
                    this.movieList.Add(movie);
                }
            }
            streamReader.Close();
            this.movieList.Sort();
            this.tree = new MyTree(this.movieList);
            this.lblListy.Text = this.tree.PrintTree();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.Valid(this.txtaddTitle, this.dtpDatetime, this.txtRunetime, this.txtDirector, this.txtRaiting))
            {
                Movie movie = new Movie(this.txtaddTitle.Text, this.dtpDatetime.Value, Convert.ToInt32(this.txtRunetime.Text), this.txtDirector.Text, Convert.ToDouble(this.txtRaiting.Text));
                if (this.movieList.Contains(movie))
                {
                    MessageBox.Show(string.Concat("your double movie wasen't added: ", movie.Title));
                }
                else
                {
                    this.movieList.Add(movie);
                    this.movieList.Sort();
                    this.tree = new MyTree(this.movieList);
                    this.lblListy.Text = this.tree.PrintTree();
                }
                this.txtaddTitle.Clear();
                this.dtpDatetime.ResetText();
                this.txtRunetime.Clear();
                this.txtDirector.Clear();
                this.txtRaiting.Clear();
            }
        }

        private void Form_Load(object sender, EventArgs e)
        {
            
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (this.Valid(this.txtTitleFind, this.txtReleaseYear))
            {
                if (this.tree.Search(this.txtTitleFind.Text, Convert.ToInt32(this.txtReleaseYear.Text)) != null)
                {
                    MessageBox.Show("You own this movie already.");
                }
                else
                {
                    MessageBox.Show("You do not own this movie yet.");
                }
                this.txtTitleFind.Clear();
                this.txtReleaseYear.Clear();
            }
        }

        private bool Valid(TextBox titleBox, TextBox releaseYearBox)
        {
            bool flag;
            string str = "";
            if (titleBox.Text == "")
            {
                str = string.Concat(str, "Please enter the movie title.\n");
            }
            int num = 0;
            if (!int.TryParse(releaseYearBox.Text, out num))
            {
                str = string.Concat(str, "Please enter a valid release year.");
            }
            else if ((num > DateTime.Now.Year ? true : num < 1900))
            {
                str = string.Concat(str, "Please enter a valid release year between 1900 and now.");
            }
            if (str == "")
            {
                flag = true;
            }
            else
            {
                MessageBox.Show(str, "Error in Find a Movie Form");
                flag = false;
            }
            return flag;
        }

        private bool Valid(TextBox titleBox, DateTimePicker dateBox, TextBox runtimeBox, TextBox dirBox, TextBox ratingBox)
        {
            bool flag;
            string str = "";
            if (titleBox.Text == "")
            {
                str = string.Concat(str, "Please enter the movie title.\n");
            }
            if (dateBox.Value > DateTime.Now)
            {
                str = string.Concat(str, "Please enter a release date that is in the past.\n");
            }
            int num = 0;
            if (!int.TryParse(runtimeBox.Text, out num))
            {
                str = string.Concat(str, "Please enter a valid runtime.");
            }
            else if (num <= 0)
            {
                str = string.Concat(str, "Please enter a runtime greater than 0.\n");
            }
            if (dirBox.Text == "")
            {
                str = string.Concat(str, "Please enter the director's name.\n");
            }
            double num1 = -1;
            if (!double.TryParse(ratingBox.Text, out num1))
            {
                str = string.Concat(str, "Please enter a valid rating.\n");
            }
            else if ((num1 < 0 ? true : num1 > 10))
            {
                str = string.Concat(str, "Please enter a rating between 0 and 10.\n");
            }
            if (str == "")
            {
                flag = true;
            }
            else
            {
                MessageBox.Show(str, "Error in Add a Movie Form");
                flag = false;
            }
            return flag;
        }

        

        
    }
}
