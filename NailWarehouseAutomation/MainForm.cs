using NailWarehouseAutomation.Helpers;
using NailWarehouseAutomation.Models;
using NailWarehouseAutomation.Models.ClassEnums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Reflection;
using System.Text.Json.Serialization;
using Serilog;
using Serilog.Sinks.File;
using Serilog.Core;



namespace NailWarehouseAutomation
{
    public partial class MainForm : Form
    {
        private readonly BindingSource bindingSource;
        private readonly BindingList<Nail> nails;
        private const double VAT = 20;

        public MainForm()
        {
            InitializeComponent();
            bindingSource = new BindingSource();
            nails = new BindingList<Nail>();
            WarehouseDataGridView
                .AutoGenerateColumns = false;
            bindingSource.DataSource = nails;
            WarehouseDataGridView.DataSource = bindingSource;
            WarehouseDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            WarehouseDataGridView.ReadOnly = true;
            WarehouseDataGridView.MultiSelect = false;
            FormattingHeaders(typeof(Nail));
            CalculateStatus();
        }

        private async void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var managerForm = new WarehouseManager();
            if (managerForm.ShowDialog() == DialogResult.OK)
            {
                Log.Information("Start adding a {Type} object.", nameof(Nail));
                
                using (var context = new NailContext())
                {
                    context.Nails.Add(managerForm.nail);
                    await context.SaveChangesAsync();
                }
                nails.Add(managerForm.nail);
                Log.Information("Ending the addition of an object. It has {@Nail}", managerForm.nail);
            }
            CalculateStatus();
        }

        private async void ChangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (WarehouseDataGridView.SelectedRows.Count != 0)
            {
                var nail = (Nail)WarehouseDataGridView.SelectedRows[0].DataBoundItem;
                var managerForm = new WarehouseManager(nail);
                if (managerForm.ShowDialog() == DialogResult.OK)
                {
                    Log.Information("start of changing \"{Type}\" object with field values {@Nail}", nameof(Nail), nail);

                    using (var context = new NailContext())
                    {
                        var newNail = context.Nails.Find(managerForm.nail.id);
                        newNail.Name = managerForm.nail.Name;
                        newNail.Diameter = managerForm.nail.Diameter;
                        newNail.Length = managerForm.nail.Length;
                        newNail.Material = managerForm.nail.Material;
                        newNail.PriceExcludingVAT = managerForm.nail.PriceExcludingVAT;
                        newNail.Quantity = managerForm.nail.Quantity;
                        await context.SaveChangesAsync();
                        nail.Name = managerForm.nail.Name;
                        nail.Diameter = managerForm.nail.Diameter;
                        nail.Length = managerForm.nail.Length;
                        nail.Material = managerForm.nail.Material;
                        nail.PriceExcludingVAT = managerForm.nail.PriceExcludingVAT;
                        nail.Quantity = managerForm.nail.Quantity;
                    }
                    Log.Information("End of modification of object. It now has {@Nail}", nail);
                }
                CalculateStatus();
            }
        }

        private void FormattingHeaders(Type type)
        {
            Type soursType = type;
            int numberOfColumns = 0;
            foreach (PropertyInfo property in soursType.GetProperties())
            {
                numberOfColumns++;
            }
            foreach (PropertyInfo property in soursType.GetProperties())
            {
                foreach (DisplayAttribute attr in property.GetCustomAttributes(typeof(DisplayAttribute)))
                {
                    WarehouseDataGridView.Columns.Add(property.Name.ToString(), attr.GetName());
                    WarehouseDataGridView.Columns[property.Name.ToString()].Width = WarehouseDataGridView.Width / numberOfColumns;
                    WarehouseDataGridView.Columns[property.Name.ToString()].DataPropertyName = property.Name;
                }
            }
        }

        private void WarehouseDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (WarehouseDataGridView.Columns[e.ColumnIndex].Name == nameof(Nail.Quantity))
            {
                if ((int)e.Value < Nail.minQuantity)
                {
                    for (int i = 0; i < WarehouseDataGridView.ColumnCount; i++)
                    {
                        WarehouseDataGridView.Rows[e.RowIndex].Cells[i].Style.BackColor = Color.FromArgb(190, 47, 51);
                    }
                }
            }

            if (WarehouseDataGridView.Columns[e.ColumnIndex].Name == nameof(Nail.Material))
            {
                e.Value = ((Enum)e.Value).DisplayName();
            }
        }

        private async void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (WarehouseDataGridView.SelectedRows.Count != 0)
            {
                var resualt = MessageBox.Show("�� ������������� ������ ������� ���� ��� �������?",
                    "������������� ��������",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                if (resualt == DialogResult.Yes)
                {
                    var nail = (Nail)WarehouseDataGridView.SelectedRows[0].DataBoundItem;
                    Log.Information("start of deleting the \"{Type}\" object with field values {@Nail}", nameof(Nail), nail);
                    using (var context = new NailContext())
                    {
                        var newNail = context.Nails.Find(nail.id);
                        context.Nails.Remove(newNail);
                        await context.SaveChangesAsync();
                    }
                    nails.Remove(nail);
                    Log.Information("object {@Nail} successfully deleted", nail);
                    CalculateStatus();
                }
            }
        }

        private void CalculateStatus()
        {
            using var log = new LoggerConfiguration()
            .WriteTo.File("Log\\log.txt",
                    rollingInterval: RollingInterval.Day,
                    rollOnFileSizeLimit: true,
                    outputTemplate: "{Timestamp:dd-MM-yyyy HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj}{NewLine}{Exception} {Properties:j}"
                    )
            .CreateLogger();
            int totalNumberOfNails = 0;
            int count = 0;
            double AVGPrice = 0.0;
            double totalCostIncludingVAT = 0.0;
            double TotalCostWithVAT = 0.0;

            foreach (Nail nail in nails)
            {
                count++;
                totalNumberOfNails += nail.Quantity;
                AVGPrice += nail.PriceExcludingVAT;
                totalCostIncludingVAT += nail.PriceExcludingVAT * nail.Quantity;
                TotalCostWithVAT += nail.PriceIncludingVAT(VAT) * nail.Quantity;
            }
            if (count > 0)
            {
                AVGPrice /= count;
            }
            TotalNumberOfNailsToolStripStatusLabel.Text = $"����� ���������� ������� �� ������: {totalNumberOfNails} ��.";
            TotalCostIncludingVATOfGoodsToolStripStatusLabel.Text = $"����� ��������� ��� ���: {totalCostIncludingVAT:C2} ���.";
            NumberOfProductLinesToolStripStatusLabel.Text = $"���������� �������� �������: {count}";
            TotalCostWithVATToolStripStatusLabel.Text = $"����� ��������� � ���: {TotalCostWithVAT:C2}";
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            using (var context = new NailContext())
            {
                var items = await context.Nails.ToListAsync();
                foreach (var item in items)
                {
                    nails.Add(item);
                }
            }

            Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Debug()
            .WriteTo.File("Log\\log.txt",
            rollingInterval: RollingInterval.Day,
            rollOnFileSizeLimit: true,
            outputTemplate: "{Timestamp:dd-MM-yyyy HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj}{NewLine}{Exception} {Properties:j}"
            )
            .CreateLogger();

            Log.Information("Start program");

            CalculateStatus();
		}

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Log.Information("\nEnd of program");
            Log.CloseAndFlush();
        }
    }
}
