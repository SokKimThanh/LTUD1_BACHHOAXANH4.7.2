using System.Collections.Generic;
using System.Windows.Forms;
using Size = System.Drawing.Size;

namespace LTUD1_BACHHOAXANH472.Model
{
    public class TableLayoutHelper : TableLayoutPanel
    {

        private List<GroupBox> groupBoxes;

        public List<GroupBox> GroupBoxes { get => groupBoxes; set => groupBoxes = value; }

        public TableLayoutHelper(int rowCount, int columnCount, Size size)
        {
            // Set the Dock property of the TableLayoutPanel to Fill.
            this.Dock = DockStyle.Fill;
            this.RowCount = rowCount;// so dong
            this.ColumnCount = columnCount;// so cot
            this.AutoScroll = true;
            this.RowStyles.Clear();
            this.MaximumSize = size;
        }

        public new void Size(Size size)
        {
            this.MaximumSize = size;
        }
        public void AddGroupBox()
        {
            for (int i = 0; i < this.RowCount; i++)
            {
                this.RowStyles.Add(new RowStyle(SizeType.Absolute, groupBoxes[i].Height));
                this.Controls.Add(groupBoxes[i], 0, i);
            }
        }

    }

}
