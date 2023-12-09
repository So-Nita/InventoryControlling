using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryWindowApp.CustomStyle
{
    public class CenteredButtonCell : DataGridViewButtonCell
    {
        protected override void Paint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, int rowIndex, DataGridViewElementStates elementState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts)
        {
            DataGridViewCellStyle centeredStyle = new DataGridViewCellStyle(cellStyle);
            centeredStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //centeredStyle.ApplyStyle(cellStyle);
            base.Paint(graphics, clipBounds, cellBounds, rowIndex, elementState, value, formattedValue, errorText, centeredStyle, advancedBorderStyle, paintParts);
        }
    }
    public class CenteredButtonColumn : DataGridViewButtonColumn
    {
        public CenteredButtonColumn()
        {
            CellTemplate = new CenteredButtonCell();
        }
    }


}
