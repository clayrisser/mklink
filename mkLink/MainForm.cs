using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mkLink {
    public partial class mkLink : Form {
        public mkLink() {
            InitializeComponent();
            this.typeComboBox.Text = "Symbolic Link";
            this.descriptionContent.Text = MyMethods.findDescription(this.typeComboBox.Text);
        }

        private void tableLayoutPanel_Paint(object sender, PaintEventArgs e) {

        }

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            this.descriptionContent.Text = MyMethods.findDescription(this.typeComboBox.Text);
        }
    }
}
