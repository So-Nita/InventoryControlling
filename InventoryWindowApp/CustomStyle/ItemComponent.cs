using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryWindowApp.CustomStyle
{
    public class ItemComponent : Form
    {
        public static void SetupDefaultDataGridView(DataGridView dataGridView, List<Tuple<string, int>?> columns, DataGridViewCellEventHandler BtnSubstract_Click = null!,int RowHeight=0)
        {
            dataGridView.ColumnCount = columns.Count;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView.RowTemplate.Height = RowHeight;

            for (int i = 0; i < columns.Count; i++)
            {
                dataGridView.Columns[i].Name = columns[i]?.Item1;
                if (columns[i]?.Item2 != null)
                {
                    dataGridView.Columns[i].Width = columns[i]!.Item2;
                }
                if (columns[i]?.Item1 == "Image")
                {
                    var imageColumn = new DataGridViewImageColumn();
                    imageColumn.Name = "Image";
                    imageColumn.HeaderText = "Image";
                    imageColumn.Width = columns[i]?.Item2 ?? 50;
                    imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;

                    var existingImageColumn = dataGridView.Columns["Image"];
                    if (existingImageColumn != null)
                    {
                        dataGridView.Columns.Remove(existingImageColumn);
                    }
                    dataGridView.Columns.Insert(i, imageColumn);
                }
            }

            if (BtnSubstract_Click != null)
            {
                dataGridView.CellContentClick += BtnSubstract_Click;
            }
        }
        // Get Image 
        public static async Task<Image> GetImageFromUrl(string url)
        {
            try
            {

                HttpClient client = new HttpClient();
                
                byte[] imageBytes = await client.GetByteArrayAsync(url);
                var stream = new MemoryStream(imageBytes);
                return Image.FromStream(stream);
            }
            catch  
            {
                return await GetImageFromUrl("https://cdn.spinn.com/assets/img/empty.jpeg");
            }
        }

        // Create Button Substract QTY
       public static DataGridViewButtonCell CreateButtonSubstract(string buttonText)
        {
            CenteredButtonCell buttonSubstract = new CenteredButtonCell();
            buttonSubstract.UseColumnTextForButtonValue = true;
            buttonSubstract.Value = buttonText;
            buttonSubstract.Style.ForeColor = Color.Red;
            return buttonSubstract;
        }
        /*  public static DataGridViewButtonCell CreateButtonView(string text)
         {
             CenteredButtonCell btnUpdate = new CenteredButtonCell();
             btnUpdate.UseColumnTextForButtonValue = true;
             btnUpdate.Value = text;
             btnUpdate.FlatStyle = FlatStyle.System;
             //btnUpdate.Style.BackColor = Color.LightGreen;
             btnUpdate.Style.ForeColor = Color.LightGreen;

             return btnUpdate;
         }
         public static DataGridViewButtonCell CreateButtonUpdate()
         {
             CenteredButtonCell btnUpdate = new CenteredButtonCell();
             btnUpdate.UseColumnTextForButtonValue = true;
             btnUpdate.Value = "Update";
             btnUpdate.FlatStyle = FlatStyle.System;
             //btnUpdate.Style.BackColor = Color.LightGreen;
             btnUpdate.Style.ForeColor = Color.LightGreen;

             return btnUpdate;
         }
         public static DataGridViewButtonCell CreateButtonDelete()
         {
             CenteredButtonCell btnDelete = new CenteredButtonCell();
             btnDelete.UseColumnTextForButtonValue = true;
             btnDelete.Value = "Delete";
             btnDelete.FlatStyle = FlatStyle.System;
             //tnDelete.Style.SelectionBackColor = Color.DarkRed;
             btnDelete.Style.ForeColor = Color.DarkRed;
             return btnDelete;
         }*/


        [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
        [return: System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.Bool)]
        public static extern bool AnimateWindow(IntPtr hwnd, int dwTime, int dwFlags);

    }
}
