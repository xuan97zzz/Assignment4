using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webDesign.Model
{
    public class Paper
    {
        private int PaperID;
        private int AuthorID;
        private int Active;
        private string FilenameOriginal;
        private string Filename;
        private string Title;
        private string Certification;
        private string NotesToReviewers;

        public int PaperID1 { get => PaperID; set => PaperID = value; }
        public int AuthorID1 { get => AuthorID; set => AuthorID = value; }
        public int Active1 { get => Active; set => Active = value; }
        public string FilenameOriginal1 { get => FilenameOriginal; set => FilenameOriginal = value; }
        public string Filename1 { get => Filename; set => Filename = value; }
        public string Title1 { get => Title; set => Title = value; }
        public string Certification1 { get => Certification; set => Certification = value; }
        public string NotesToReviewers1 { get => NotesToReviewers; set => NotesToReviewers = value; }
    }
}
