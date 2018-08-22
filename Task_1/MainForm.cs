using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task_1.EntityFramework;

namespace Task_1
{
    public partial class MainForm : Form
    {
        private string[] tasks = null;

        public MainForm()
        {
            InitializeComponent();

            this.Load += MainForm_Load;
            this.textBoxTaskText.TextChanged += TextBoxTaskText_TextChanged;
        }

        private void TextBoxTaskText_TextChanged(object sender, EventArgs e)
        {
            this.dataGridViewQueryResult.DataSource = null;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.CheckConnection();

            this.tasks = new string[]
            {
                "Выведите список должников.",
                "Выведите список авторов книги №3 (по порядку из таблицы 'Book').",
                "Выведите список книг, которые доступны в данный момент.",
                "Вывести список книг, которые на руках у пользователя №2 (по порядку из таблицы 'Visitor').",
                "Обнулите задолженности всех должников"
            };
        }

        private void CheckConnection()
        {
            using (LibraryDBEntities db = new LibraryDBEntities())
            {
                try
                {
                    db.Database.Connection.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,
                        "Ошибка подключения к базе данных",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                finally
                {
                    db.Database.Connection?.Close();
                }
            }
        }

        private void buttonFirstQuery_Click(object sender, EventArgs e)
        {
            using (LibraryDBEntities db = new LibraryDBEntities())
            {
                this.textBoxTaskText.Text = this.tasks[0];

                this.dataGridViewQueryResult.DataSource
                    = (
                    from debtor in db.Debtor
                    select new { debtor.Visitor.FirstName, debtor.Visitor.LastName, debtor.Book.Title}
                    ).ToList();
            }
        }

        private void buttonSecondQuery_Click(object sender, EventArgs e)
        {
            using (LibraryDBEntities db = new LibraryDBEntities())
            {
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
                    select new { authors.Author.FirstName, authors.Author.LastName, authors.Book.Title}
                    )
                    .ToList();
            }
        }

        private void buttonThirdQuery_Click(object sender, EventArgs e)
        {
            using (LibraryDBEntities db = new LibraryDBEntities())
            {
                db.Database.Log = Console.Write;

                this.textBoxTaskText.Text = this.tasks[2];

                this.dataGridViewQueryResult.DataSource = null;

                this.dataGridViewQueryResult.DataSource
                    = (
                    from book in db.Book
                    where !(from debtor in db.Debtor
                            select debtor.BookId
                            ).Contains(book.Id)
                    select new { book.Title }
                    ).ToList();
            }
        }

        private void buttonFourthQuery_Click(object sender, EventArgs e)
        {
            using (LibraryDBEntities db = new LibraryDBEntities())
            {
                this.textBoxTaskText.Text = this.tasks[3];

                this.dataGridViewQueryResult.DataSource
                    = (
                    from debtor in db.Debtor
                    where debtor.VisitorId == (from visitor in db.Visitor
                                               orderby visitor.Id ascending
                                               select visitor.Id
                                               )
                                               .Skip(1)
                                               .FirstOrDefault()
                    select new { debtor.Book.Title, debtor.Visitor.FirstName, debtor.Visitor.LastName}
                    ).ToList();
            }
        }

        async private void buttonFifthQuery_Click(object sender, EventArgs e)
        {
            using (LibraryDBEntities db = new LibraryDBEntities())
            {
                this.textBoxTaskText.Text = this.tasks[4];

                await db.Database.ExecuteSqlCommandAsync("TRUNCATE TABLE Debtor");

                this.dataGridViewQueryResult.DataSource
                    = (
                    from debtor in db.Debtor
                    select new { debtor.Id, debtor.Visitor.LastName, debtor.Book.Title }
                    )
                    .ToList();
            }
        }
    }
}
