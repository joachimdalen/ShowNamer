using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShowNamer {
    public enum AddType {
        Add,
        ClearAdd
    }

    public partial class DragAndDropForm : Form {
        public AddType addType = AddType.Add;
        public DragAndDropForm() {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.OK;
            this.addType = AddType.Add;
        }

        private void btnClearAdd_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.OK;
            this.addType = AddType.ClearAdd;
        }
    }
}
