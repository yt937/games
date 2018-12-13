using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
        internal class Movie : IComparable<Movie>, IEquatable<Movie>
        {
            private string title;

            private DateTime releaseDate;

            private int runtime;

            private string director;

            private double rating;

            public string Director
            {
                get
                {
                    return this.director;
                }
            }

            public Movie Left
            {
                get;
                set;
            }

            public double Rating
            {
                get
                {
                    return this.rating;
                }
            }

            public DateTime ReleaseDate
            {
                get
                {
                    return this.releaseDate;
                }
            }

            public Movie Right
            {
                get;
                set;
            }

            public int Runtime
            {
                get
                {
                    return this.runtime;
                }
            }

            public string Title
            {
                get
                {
                    return this.title;
                }
            }

            public Movie(string t, DateTime r, int run, string direct, double rate)
            {
                this.title = t;
                this.releaseDate = r;
                this.runtime = run;
                this.director = direct;
                this.rating = rate;
                this.Left = null;
                this.Right = null;
            }

            public int CompareTo(Movie other)
            {
                int num;
                if (this.releaseDate != other.releaseDate)
                {
                    num = (this.releaseDate >= other.releaseDate ? 1 : -1);
                }
                else
                {
                    num = this.title.CompareTo(other.title);
                }
                return num;
            }

            public bool Equals(Movie other)
            {
                return (!(this.title == other.title) || !(this.releaseDate == other.releaseDate) || this.runtime != other.runtime || !(this.director == other.director) ? false : this.rating == other.rating);
            }
        }
}
