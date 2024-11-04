namespace quản_lý_khách_hàng
{
    public partial class Form1 : Form
    {
        private List<Customer> customers = new List<Customer>();
        private List<Service> services = new List<Service>();
        private List<Invoice> invoices = new List<Invoice>();
        private int customerIDCounter = 1;
        private int invoiceIDCounter = 1;
        public Form1()
        {
            InitializeComponent();
            InitializeServices();
        }
        private void InitializeServices()
        {
            // Thêm các dịch vụ mẫu
            services.Add(new Service { ServiceID = 1, ServiceName = "Internet", Price = 200 });
            services.Add(new Service { ServiceID = 2, ServiceName = "Hosting", Price = 150 });
            services.Add(new Service { ServiceID = 3, ServiceName = "Domain", Price = 100 });
            servicesDataGridView.DataSource = services;
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            var customer = new Customer
            {
                CustomerID = customerIDCounter++,
                Name = nameTextBox.Text,
                Phone = phoneTextBox.Text,
                Address = addressTextBox.Text
            };
            customers.Add(customer);
            customersDataGridView.DataSource = null;
            customersDataGridView.DataSource = customers;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (customersDataGridView.CurrentRow != null)
            {
                var customer = (Customer)customersDataGridView.CurrentRow.DataBoundItem;
                customer.Name = nameTextBox.Text;
                customer.Phone = phoneTextBox.Text;
                customer.Address = addressTextBox.Text;
                customersDataGridView.Refresh();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (customersDataGridView.CurrentRow != null)
            {
                var customer = (Customer)customersDataGridView.CurrentRow.DataBoundItem;
                customers.Remove(customer);
                customersDataGridView.DataSource = null;
                customersDataGridView.DataSource = customers;
            }
        }

        private void createInvoiceButton_Click(object sender, EventArgs e)
        {
            if (customersDataGridView.CurrentRow != null)
            {
                var selectedCustomer = (Customer)customersDataGridView.CurrentRow.DataBoundItem;
                var selectedServices = servicesDataGridView.SelectedRows
                    .Cast<DataGridViewRow>()
                    .Select(row => (Service)row.DataBoundItem)
                    .ToList();

                var invoice = new Invoice
                {
                    InvoiceID = invoiceIDCounter++,
                    Customer = selectedCustomer,
                    Services = selectedServices
                };
                invoices.Add(invoice);
                DisplayInvoice(invoice);
            }
        }
        private void DisplayInvoice(Invoice invoice)
        {
            // Hiển thị thông tin hóa đơn ở giao diện
            MessageBox.Show($"Mã hóa đơn: {invoice.InvoiceID}\nKhách hàng: {invoice.Customer?.Name}\n" +
                            $"Tổng tiền: {invoice.TotalAmount:C}");
        }
    }
    public class Customer
    {
        public int CustomerID { get; set; }
        public string ?Name { get; set; }
        public string ?Phone { get; set; }
        public string ?Address { get; set; }
    }
    public class Service
    {
        public int ServiceID { get; set; }
        public string? ServiceName { get; set; }
        public decimal Price { get; set; }
    }
    public class Invoice
    {
        public int InvoiceID { get; set; }
        public Customer ?Customer { get; set; }
        public List<Service> Services { get; set; } = new List<Service>();
        public decimal TotalAmount => Services.Sum(s => s.Price);
    }
}
