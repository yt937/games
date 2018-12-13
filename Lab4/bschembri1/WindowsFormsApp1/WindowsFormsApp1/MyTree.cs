using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class MyTree
    {
        private Movie root;
        private List<Movie> movieList;

        public string ToPrint
        {
            get;
            private set;
        }

        public MyTree(List<Movie> newList)
        {
            this.movieList = newList;
            this.root = this.Build(0, this.movieList.Count - 1);
        }

        private Movie Build(int startIndex, int endIndex)
        {
            Movie movie;
            if (startIndex <= endIndex)
            {
                int num = (int)Math.Floor(((double)startIndex + (double)endIndex) / 2);
                Movie item = this.movieList[num];
                item.Left = this.Build(startIndex, num - 1);
                item.Right = this.Build(num + 1, endIndex);
                movie = item;
            }
            else
            {
                movie = null;
            }
            return movie;
        }

        public string PrintTree()
        {
            this.ToPrint = "";
            this.PrintTree(this.root);
            return this.ToPrint;
        }

        private void PrintTree(Movie aNode)
        {
            if (aNode != null)
            {
                this.PrintTree(aNode.Left);
                this.PrintTree(aNode.Right);
                string[] toPrint = new string[] { this.ToPrint, aNode.Title, " ", null, null };
                toPrint[3] = aNode.ReleaseDate.ToShortDateString();
                toPrint[4] = "\n";
                this.ToPrint = string.Concat(toPrint);
            }
        }

        private void PrintTreeWithInfo(Movie aNode, int level, bool isleft)
        {
            if (aNode != null)
            {
                this.PrintTreeWithInfo(aNode.Left, level + 1, true);
                string str = (isleft ? " Left: " : " Right: ");
                this.PrintTreeWithInfo(aNode.Right, level + 1, false);
                object[] toPrint = new object[] { this.ToPrint, "Level ", level, str, aNode.Title, " ", null, null };
                toPrint[6] = aNode.ReleaseDate.ToShortDateString();
                toPrint[7] = "\n";
                this.ToPrint = string.Concat(toPrint);
            }
        }

        public Movie Search(string titleFind, int yearFind)
        {
            return this.Search(this.root, titleFind, yearFind);
        }

        private Movie Search(Movie current, string titleFind, int yearFind)
        {
            Movie movie;
            if (current == null)
            {
                movie = null;
            }
            else if (yearFind < current.ReleaseDate.Year)
            {
                movie = this.Search(current.Left, titleFind, yearFind);
            }
            else if (yearFind > current.ReleaseDate.Year)
            {
                movie = this.Search(current.Right, titleFind, yearFind);
            }
            else if (titleFind != current.Title)
            {
                Movie movie1 = this.Search(current.Left, titleFind, yearFind);
                movie = (movie1 != null ? movie1 : this.Search(current.Right, titleFind, yearFind));
            }
            else
            {
                movie = current;
            }
            return movie;
        }
    }
}
