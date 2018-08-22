using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_1
{
    public partial class MainForm : Form
    {
        private string[] tasks = null;

        public MainForm()
        {
            InitializeComponent();

            this.Load += MainForm_Load;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.tasks = new string[]
            {
                "Выведите список должников.",
                "Выведите список авторов книги №3 (по порядку из таблицы 'Book').",
                "Выведите список книг, которые доступны в данный момент.",
                "Вывести список книг, которые на руках у пользователя №2.",
                "Обнулите задолженности всех должников"
            };
        }

        private void buttonFirstQuery_Click(object sender, EventArgs e)
        {
            using (LibraryDBEntities db = new LibraryDBEntities())
            {
                db.Database.Log = Console.Write;

                this.textBoxTaskText.Text = this.tasks[0];

                this.dataGridViewQueryResult.DataSource
                    = (
                    from debtor in db.Debtor
                    select new { debtor.Visitor.LastName, debtor.Visitor.FirstName, debtor.Book.Title}
                    ).ToList();
            }
        }

        private void buttonSecondQuery_Click(object sender, EventArgs e)
        {
            using (LibraryDBEntities db = new LibraryDBEntities())
            {
                db.Database.Log = Console.Write;

                this.textBoxTaskText.Text = this.tasks[1];

                this.dataGridViewQueryResult.DataSource
                    = (
                    from authors in db.BookAuthor
                    // example #1
                    //where authors.Book.Id == db.Book.OrderBy(x => x.Id).Skip(2).Select( x => x.Id).FirstOrDefault()
                    // example #2
                    where authors.Book.Id == (from book in db.Book
                                              orderby book.Id ascending
                                              select book.Id
                                              )
                                              .Skip(2)
                                              .FirstOrDefault()
                    select new { authors.Author.LastName, authors.Author.FirstName, authors.Book.Title}
                    )
                    .ToList();
            }
        }
    }
}
