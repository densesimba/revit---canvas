using Econfaire.Monada.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Econfaire.Monada.UI
{
    public partial class FormRoom : Form
    {
        FormMain frmMain;
        public FormRoom(FormMain frmMain)
        {
            this.frmMain = frmMain;
            InitializeComponent();
        }

        public FormRoom()
        {
        }

        private void btnCreateRoom_Click(object sender, EventArgs e)
        {
            Room newRoom = new Room
            {
                LengthX = (int)numLengthX.Value,
                LengthY = (int)numLengthY.Value,
                LocationX = (int)numLocationX.Value,
                LocationY = (int)numLocationY.Value
            };

            if (!IsNameValid(txtName.Text))
            {
                MessageBox.Show("Introduceti o valoare pentru nume!");
                return;
            }

            newRoom.Name = txtName.Text;

            if (FormMain.rooms.Keys.Count > 0)
            {
                newRoom.Index = FormMain.rooms.Keys.Max() + 1;
            }

            FormMain.NewPolygon = new List<Point>();
            Point x1 = new Point(newRoom.LocationX, newRoom.LocationY);
            FormMain.NewPolygon.Add(x1);
            Point x2 = new Point(newRoom.LocationX + newRoom.LengthX, newRoom.LocationY);
            FormMain.NewPolygon.Add(x2);
            Point x3 = new Point(newRoom.LocationX + newRoom.LengthX, newRoom.LocationY + newRoom.LengthY);
            FormMain.NewPolygon.Add(x3);
            Point x4 = new Point(newRoom.LocationX, newRoom.LocationY + newRoom.LengthY);
            FormMain.NewPolygon.Add(x4);
            newRoom.Polygon.Add(FormMain.NewPolygon);

           newRoom.Label = new Label
            {
                Size = new Size(47, 13),
                Visible = true,
                Text = newRoom.Name,
                Location = new Point(newRoom.LocationX + (newRoom.LengthX / 2) - Text.Length - 5, newRoom.LocationY + (newRoom.LengthY / 2))
            };

            frmMain.picCanvas.Controls.Add(newRoom.Label);

            FormMain.rooms.Add(newRoom.Index, newRoom);

            if (FormMain.NewPolygon.Count > 2)
            {
                frmMain.roomPolygons.Add(FormMain.NewPolygon);
            }
            FormMain.NewPolygon = null;

            this.Dispose();
        }

        public bool IsNameValid(string input)
        {
            if (input.All(char.IsDigit))
            {
                return false;
            }

            return true;
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            else if (ModifierKeys == Keys.None && keyData == Keys.Enter)
            {
                btnCreateRoom.PerformClick();
                return true;
            }

            return base.ProcessDialogKey(keyData);
        }
    }
}
