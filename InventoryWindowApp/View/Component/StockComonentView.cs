using InventoryApiClient.Model.Product;
using InventoryApiClient.Model.Stocking;
using InventoryApiClient.Services;
using InventoryWindowApp.CustomStyle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryWindowApp.View.Component;

public partial class StockComonentView : Form
{
    private readonly StockingService _service;
    private readonly StockUpdateReq _stock;
    public StockComonentView(StockUpdateReq stocking = null)
    {
        InitializeComponent();
        _service = new StockingService();
        _stock = stocking;
        InitData();
        if (stocking != null) { PopulateFormForUpdate(); }
    }

    private void AddControlls(Form form)
    {
        if (this.Controls.Count > 0)
        {
            this.Controls.RemoveAt(0);
        }
        this.Controls.Clear();
        form.Dock = DockStyle.Fill;
        form.TopLevel = false;
        this.Controls.Add(form);
        form.Show();
    }

    private void InitData()
    {
        InitListStockingAsync();
        _ = _stock == null ? labelTitle.Text = "Create New Stock" : labelTitle.Text = "Update Stock";
    }

    private async Task InitListStockingAsync()
    {
        try
        {
            var product = new ProductService();
            var products = await product.ReadAllAsync();
            if (products != null)
            {
                foreach (var item in products)
                {
                    comboStatus.Items.Add(new Test(item.Name, item.Id));
                    /*comboCategory.Items.Add(item.Name);*/
                    comboStatus.DisplayMember = item.Name;
                    comboStatus.ValueMember = item.Id;
                }
                var itemType = typeof(Test);
                var displayMemberProperty = itemType.GetProperty("Name");
                var valueMemberProperty = itemType.GetProperty("Value");

                if (displayMemberProperty != null && valueMemberProperty != null)
                {
                    comboStatus.DisplayMember = displayMemberProperty.Name;
                    comboStatus.ValueMember = valueMemberProperty.Name;
                }
            }
        }
        catch
        {
            throw new Exception();
        }
    }

    private void PopulateFormForUpdate()
    {
        throw new NotImplementedException();
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        CreateOrUpdate();
    }

    private void btn_Cancel_Click(object sender, EventArgs e)
    {
        AddControlls(new StockingView());
    }

    private async void CreateOrUpdate()
    {
        if (_stock == null)
        {
            Create();
        }
        else
        {
            var category = new CategoryService();
            var updateReq = new StockUpdateReq()
            {
                Id = _stock.Id,
                Qty  = Convert.ToInt32(txtQty.Text),
                Status = txtQty.Text,
                Note = txtNote.Text,
            };
            var update = await _service.UpdateAsync(updateReq);
        }
    }
    private async void Create()
    {
        var data = await _service.ReadAllAsync();
        //var category = data.FirstOrDefault(e => e.Name.Equals(comboStatus.SelectedItem.ToString()));
        var createReq = new StockCreateReq()
        {
            Id = _stock.Id,
            Qty = Convert.ToInt32(txtQty.Text),
            Status = txtQty.Text,
            Note = _stock.Note,
        };
        var create = await _service.CreateAsync(createReq);
        if (create.Status == 200)
        {
            CustomMessageBox.ShowMessageBox("Create Stock Successfully", true);
            AddControlls(new StockingView());
        }
        else
        {
            CustomMessageBox.ShowMessageBox(create.Result.ToString()!, false);
        }
    }
}

internal class Test
{
    public string Name { get; private set; }
    public string Value { get; private set; }
    public Test(string _name, string _value)
    {
        Name = _name; Value = _value;
    }
}