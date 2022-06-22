using FunProject.Application.Data.ActivityLogs.Command;
using FunProject.Application.Data.ActivityLogs.Query;
using FunProject.Application.Data.Customers.Command;
using FunProject.Application.Data.Customers.Query;
using FunProject.Application.Data.Orders.Command;
using FunProject.Application.Data.Orders.Query;
using FunProject.Application.Data.ProductOrders.Command;
using FunProject.Application.Data.ProductOrders.Query;
using FunProject.Application.Data.Products.Command;
using FunProject.Application.Data.Products.Query;
using FunProject.Persistence.ActivityLogs.Command;
using FunProject.Persistence.ActivityLogs.Query;
using FunProject.Persistence.Customers.Command;
using FunProject.Persistence.Customers.Query;
using FunProject.Persistence.Orders.Command;
using FunProject.Persistence.Orders.Query;
using FunProject.Persistence.ProducOrders.Command;
using FunProject.Persistence.ProducOrders.Query;
using FunProject.Persistence.Products.Command;
using FunProject.Persistence.Products.Query;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;


namespace FunProject.Persistence
{
    public static class ServicesCollectionExtension
    {
        public static void AddPersistanceLayerServices(this IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options => options.UseInMemoryDatabase("FunProjectDataBase"));

            // data services
            services.AddTransient<ISampleData, SampleData>();

            //Querys

            //Customer
            services.AddTransient<IAllCustomersQuery, AllCustomersQuery>();
            services.AddTransient<ICustomerIsExistsQuery, CustomerIsExistsQuery>();
            services.AddTransient<IGetCustomersFLnameByIdsQuery, GetCustomersFLnameByIdsQuery>();
            services.AddTransient<IGetCustomerTypeQuery, GetCustomerTypeQuery>();
            services.AddTransient<IGetCustomerByIdQuery, GetCustomerByIdQuery>();

            //Product
            services.AddTransient<IAllProductsQuery, AllProductsQuery>();
            services.AddTransient<IProductIsExistsQuery, ProductIsExistsQuery>();
            services.AddTransient<IGetProductsDesByIdsQuery, GetProductsDesByIdsQuery>();
            services.AddTransient<IGetProductPriceQuery, GetProductPriceQuery>();
            services.AddTransient<IGetProductDescQuery, GetProductDescQuery>();
            services.AddTransient<IGetProductsBySearchValueQuery, GetProductsBySearchValueQuery>();

            ////ProductOrder
            services.AddTransient<IProductOrdersByOrderIdQuery, ProductOrdersByOrderIdQuery>();

            //Order
            services.AddTransient<IAllOrdersQuery, AllOrdersQuery>();
            services.AddTransient<IOrderIsExistsQuery, OrderIsExistsQuery>();
            services.AddTransient<IOrderByIdQuery, OrderByIdQuery>();
            services.AddTransient<IOrderIsExistsByCustomerIdQuery, OrderIsExistsByCustomerIdQuery>();
            services.AddTransient<IOrderIsExistsByProductIdQuery, OrderIsExistsByProductIdQuery>();

            //ActivityLog
            services.AddTransient<IAllActivityLogsQuery, AllActivityLogsQuery>();
            services.AddTransient<IAllActivityLogsQuery, AllActivityLogsQuery>();


            //Commands
            
            //Customer
            services.AddTransient<ICreateCustomerCommand, CreateCustomerCommand>();
            services.AddTransient<IDeleteCustomerCommand, DeleteCustomerCommand>();
            services.AddTransient<IUpdateCustomerCommand, UpdateCustomerCommand>();

            //Product
            services.AddTransient<ICreateProductCommand, CreateProductCommand>();
            services.AddTransient<IDeleteProductCommand, DeleteProductCommand>();
            services.AddTransient<IUpdateProductCommand, UpdateProductCommand>();

            //ProductOrder
            services.AddTransient<IUpdateProductOrderCommand, UpdateProductOrderCommand>();
            services.AddTransient<ICreateProductOrderCommand, CreateProductOrderCommand>();
            services.AddTransient<IDeleteProductOrderRangeCommand, DeleteProductOrderRangeCommand>();


            //Order
            services.AddTransient<ICreateOrderCommand, CreateOrderCommand>();
            services.AddTransient<IDeleteOrderCommand, DeleteOrderCommand>();
            services.AddTransient<IUpdateOrderCommand, UpdateOrderCommand>();


            //ActivityLog
            services.AddTransient<ICreateActivityLogsCommand, CreateActivityLogCommand>();
        }
    }
}
