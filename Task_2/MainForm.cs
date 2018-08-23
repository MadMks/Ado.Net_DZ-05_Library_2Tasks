using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task_2.EntityFramework;

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
            this.CheckConnection();

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
            this.listBoxAuthors.Items.Clear();

            using (LibraryDBEntities db = new LibraryDBEntities())
            {
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

            this.dataGridViewQueryResult.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void ShowTheAuthorsOfTheBook()
        {
            if (this.dataGridViewQueryResult.Rows.Count > 0)
            {
                using (LibraryDBEntities db = new LibraryDBEntities())
                {
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

        private void dataGridViewQueryResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.ShowTheAuthorsOfTheBook();
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
                        "Ошибка подключения к серверу базы данных",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                finally
                {
                    db.Database.Connection?.Close();
                }
            }
        }
    }
}
