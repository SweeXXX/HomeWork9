using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumac
{
     class Song
    {
        string? name;
        string? author;
        Song prev;
        public string GetInfo 
        {
            get { return $"{name} - {author}. Предыдущая Песня:{this.prev?.Title() ?? "Отсутствует"}"; }
        }
        public Song() { }
        public Song(string name, string author, Song prev)
        {
            this.name = name;
            this.author = author;
            this.prev = prev;
        }
        public Song(string name, string author)
        {
            this.name = name;
            this.author = author;
            this.prev = null;
        }
        public void NewName(string name)
        {
            this.name = name;
        }
        public void NewAuthor(string author)
        {
            this.author = author;
        }
        public void NewPrev(Song prev)
        { this.prev = prev; }
        public string Title()
        {
            return $"{name} - {author}";
        }
        public override bool Equals(object d)
        {
            Song s = d as Song;
            if (d != null)
            {
                if (this.Title == s.Title)
                {
                    return true;
                }
            }
            return false;
        }
        public bool Equals(Song f)
        {
            return f.GetInfo == this.GetInfo;
        }


    }
}
