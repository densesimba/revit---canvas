using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Econfaire.Monada.Models
{
    public class Room
    {
        public int Index { get; set; }
        public int LocationX { get; set; }
        public int LocationY { get; set; }
        public int LengthX { get; set; }
        public int LengthY { get; set; }
        public string Name { get; set; }
        public Label Label { get; set; } = new Label();
        public List<List<Point>> Polygon { get; set; } = new List<List<Point>>();
    }
}
