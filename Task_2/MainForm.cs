using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            this.Load += MainForm_Load;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.buttonFind.Enabled = false;
            this.textBoxFind.MaxLength = 35;
        }

        private void textBoxFind_TextChanged(object sender, EventArgs e)
        {
            if (this.textBoxFind.Text.Length > 0)
            {
                this.buttonFind.Enabled = true;
            }
            else
            {
                this.buttonFind.Enabled = false;
            }
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            using (LibraryDBEntities db = new LibraryDBEntities())
            {
                db.Database.Log = Console.Write;

                this.dataGridViewQueryResult.DataSource
                    = (
                    from book in db.BookAuthor
                    where book.Author.LastName.Contains(this.textBoxFind.Text)
                    select new { book.Book.Title }
                    )
                    .Distinct()
                    .ToList();
            }

            this.ShowTheAuthorsOfTheBook();
        }

        private void dataGridViewQueryResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.ShowTheAuthorsOfTheBook();
        }

        private void ShowTheAuthorsOfTheBook()
        {
            if (this.dataGridViewQueryResult.Rows.Count > 0)
            {
                using (LibraryDBEntities db = new LibraryDBEntities())
                {
                    db.Database.Log = Console.Write;

                    //string selectBookTitle = dataGridViewQueryResult.CurrentRow.Cells[0].Value.ToString();
                    string selectBookTitle =
                        this.dataGridViewQueryResult[
                            this.dataGridViewQueryResult.CurrentCell.ColumnIndex,
                            this.dataGridViewQueryResult.CurrentCell.RowIndex]
                            .Value.ToString();

                    var temp
                        = (
                        from author in db.BookAuthor
                        where author.Book.Title == selectBookTitle
                        select author.Author.LastName
                        )
                        .ToArray<string>();

                    this.listBoxAuthors.Items.Clear();
                    this.listBoxAuthors.Items.AddRange(temp);
                }
            }
        }
    }
}
