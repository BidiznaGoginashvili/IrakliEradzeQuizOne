using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IrakliEradzeQuizOne
{
    public partial class CrudForm : Form
    {
        public CrudForm()
        {
            InitializeComponent();
        }

        private void CrudForm_Load(object sender, EventArgs e)
        {
            BookModify.ReadBooks(BooksGridView);

            this.Refresh();
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            BookModify create = new BookModify();

            MessageBox.Show(create.CreateBook(title: TitleCTxt.Text, authorName: AuthorNameCTxt.Text));

            this.Refresh();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            BookModify update = new BookModify();

            int id = Convert.ToInt32(IdUpdate.Value);

            MessageBox.Show(update.UpdateBook(id: id, title: TitleCTxt.Text, authorName: AuthorNameCTxt.Text));

            this.Refresh();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            BookModify delete = new BookModify();

            int id = Convert.ToInt32(IdDelete.Value);

            delete.DeleteBook(id: id);

            this.Refresh();
        }

        private void TransactionBtn_Click(object sender, EventArgs e)
        {
            BookModify transaction = new BookModify();

            transaction.Transactions();

            this.Refresh();
        }

        private void ExecuteProcedureBtn_Click(object sender, EventArgs e)
        {
            BookModify procedure = new BookModify();

            procedure.ExecuteProcedure(TitleProcedure.Text,AuthorNameProcedure.Text);

            this.Refresh();
        }
    }
}
