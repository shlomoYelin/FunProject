using FunProject.Application.ActivityLogModule.Services;
using FunProject.Application.ActivityLogModule.Services.Interfaces;
using FunProject.Application.CustomersModule.Services;
using FunProject.Application.CustomersModule.Services.Interfaces;
using FunProject.Application.CustomersModule.Validators;
using FunProject.Application.CustomersModule.Validators.Interfaces;
using FunProject.Application.CustomersModule.Validators.Validations;
using FunProject.Application.CustomersModule.Validators.Validations.Interfaces;
using FunProject.Application.CustomersModule.WorkFlows;
using FunProject.Application.CustomersModule.WorkFlows.Interfaces;
using FunProject.Application.CustomersModule.WorkFlows.Tasks;
using FunProject.Application.CustomersModule.WorkFlows.Tasks.Interfaces;
using FunProject.Application.OrdersModule.Factorys;
using FunProject.Application.OrdersModule.Factorys.Interfaces;
using FunProject.Application.OrdersModule.Services;
using FunProject.Application.OrdersModule.Services.Interfaces;
using FunProject.Application.OrdersModule.Validators;
using FunProject.Application.OrdersModule.Validators.Interfaces;
using FunProject.Application.OrdersModule.Validators.Validations;
using FunProject.Application.OrdersModule.Validators.Validations.Interfaces;
using FunProject.Application.OrdersModule.WorkFlows;
using FunProject.Application.OrdersModule.WorkFlows.Interfaces;
using FunProject.Application.OrdersModule.WorkFlows.Tasks;
using FunProject.Application.OrdersModule.WorkFlows.Tasks.Interfaces;
using FunProject.Application.ProductsModule.Services;
using FunProject.Application.ProductsModule.Services.Interfaces;
using FunProject.Application.ProductsModule.Validators;
using FunProject.Application.ProductsModule.Validators.Interfaces;
using FunProject.Application.ProductsModule.Validators.Validations;
using FunProject.Application.ProductsModule.Validators.Validations.Interfaces;
using FunProject.Application.ProductsModule.WorkFlows;
using FunProject.Application.ProductsModule.WorkFlows.Interfaces;
using FunProject.Application.ProductsModule.WorkFlows.Tasks;
using FunProject.Application.ProductsModule.WorkFlows.Tasks.Interfaces;
using FunProject.Domain.Logger;
using FunProject.Domain.Mapper;
using FunProject.Infrastructure.Logger;
using FunProject.Infrastructure.Mapper;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace FunProject.Infrastructure
{
    public static class ServicesCollectionExtension
    {
        public static void AddInrustractureLayerServices(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            services.AddSingleton(typeof(ILoggerAdapter<>), typeof(LoggerAdapter<>));
            services.AddSingleton<IMapperAdapter, MapperAdapter>();


            //appliction Tasks

            //Customer
            services.AddTransient<ICreateCustomerTask, CreateCustomerTask>();
            services.AddTransient<IDeleteCustomerTask, DeleteCustomerTask>();
            services.AddTransient<IGetAllCustomersTask, GetAllCustomersTask>();
            services.AddTransient<IUpdateCustomerTask, UpdateCustomerTask>();
            services.AddTransient<IGetCustomersFLnameByIdsTask, GetCustomersFLnameByIdsTask>();

            //Product
            services.AddTransient<ICreateProductTask, CreateProductTask>();
            services.AddTransient<IGetAllProductsTask, GetAllProductsTask>();
            services.AddTransient<IUpdateProductTask, UpdateProductTask>();
            services.AddTransient<IDeleteProductTask, DeleteProductTask>();
            services.AddTransient<IGetProductsByIdsTask, GetProductsByIdsTask>();
            services.AddTransient<IGetProductsBySearchValueTask, GetProductsBySearchValueTask>();

            //ProductOrder



            //Order
            services.AddTransient<ICreateOrderTask, CreateOrderTask>();
            services.AddTransient<IGetAllOrdersTask, GetAllOrdersTask>();
            services.AddTransient<IDeleteOrderTask, DeleteOrderTask>();
            services.AddTransient<IGetOrderByIdTask, GetOrderByIdTask>();
            services.AddTransient<IUpdateOrderTask, UpdateOrderTask>();
            services.AddTransient<IDeleteProductOrdersTask, DeleteProductOrdersTask>();
            services.AddTransient<IOrderIsExistsByCustomerIdTask, OrderIsExistsByCustomerIdTask>();

            services.AddTransient<IProductsPriceCalculationTask, ProductsPriceCalculationTask>();
            services.AddTransient<IUserDiscountPercentageFactory, UserDiscountPercentageFactory>();
            services.AddTransient<IGetOrderPaymentByDiscountPercentageTask, GetOrderPaymentByDiscountPercentageTask>();
            services.AddTransient<IGetProductOrdersByOrderIdTask, GetProductOrdersByOrderIdTask>();
            services.AddTransient<IOrderIsExistsByProductIdTask, OrderIsExistsByProductIdTask>();
            services.AddTransient<IProductOrderGetActionTypeTask, ProductOrderGetActionTypeTask>();
            services.AddTransient<IGetProductOrdersToDeleteTask, GetProductOrdersToDeleteTask>();
            services.AddTransient<ICreateProductOrderTask, CreateProductOrderTask>();
            services.AddTransient<IUpdateProductOrderTask, UpdateProductOrderTask>();


            //application work flows 

            //Customer
            services.AddTransient<ICreateCustomerWorkFlow, CreateCustomerWorkFlow>();
            services.AddTransient<IGetAllCustomersWorkFlow, GetAllCustomersWorkFlow>();
            services.AddTransient<IUpdateCustomerWorkFlow, UpdateCustomerWorkFlow>();
            services.AddTransient<IDeleteCustomerWorkFlow, DeleteCustomerWorkFlow>();
            services.AddTransient<IGetCustomerTypeTask, GetCustomerTypeTask>();

            //Product
            services.AddTransient<ICreateProductWorkFlow, CreateProductWorkFlow>();
            services.AddTransient<IGetAllProductWorkFlow, GetAllProductsWorkFlow>();
            services.AddTransient<IUpdateProductWorkFlow, UpdateProductWorkFlow>();
            services.AddTransient<IDeleteProductWorkFlow, DeleteProductWorkFlow>();
            services.AddTransient<IGetProductsBySearchValueWorkFlow, GetProductsBySearchValueWorkFlow>();

            //ProductOrder


            //Order
            services.AddTransient<ICreateOrderWorkFlow, CreateOrderWorkFlow>();
            services.AddTransient<IGetAllOrdersWorkFlow, GetAllOrdersWorkFlow>();
            services.AddTransient<IDeleteOrderWorkFlow, DeleteOrderWorkFlow>();
            services.AddTransient<IGetOrderByIdWorkFlow, GetOrderByIdWorkFlow>();
            services.AddTransient<IUpdateOrderWorkFlow, UpdateOrderWorkFlow>();
            services.AddTransient<IOrderPaymentCalculationWorkFlow, OrderPaymentCalculationWorkFlow>();



            // application validations

            //Custoer
            services.AddTransient<ICustomeRequiredValidation, CustomeRequiredValidation>();
            services.AddTransient<ICustomerIsExistsValidation, CustomerIsExistsValidation>();

            //Product
            services.AddTransient<IProductIsExistsValidation, ProductIsExistsValidataion>();
            services.AddTransient<IProductsIsExistsValidation, ProductsIsExistsValidation>();
            services.AddTransient<IProductRequierdValidation, ProductRequierdValidation>();

            //Order
            services.AddTransient<IOrderIsExistsValidation, OrderIsExistsValidation>();




            // application validators

            //Customer
            services.AddTransient<IUpdateCustomerValidator, UpdateCustomerValidator>();
            services.AddTransient<ICreateCustomerValidator, CreateCustomerValidator>();
            services.AddTransient<IDeleteCustomerValidator, DeleteCustomerValidator>();


            //Order
            services.AddTransient<ICreateOrderValidator, CreateOrderValidator>();
            services.AddTransient<IDeleteOrderValidator, DeleteOrderValidator>();
            services.AddTransient<IUpdateOrderValidator, UpdateOrderValidator>();


            //Product
            services.AddTransient<ICreateProductValidator, CreateProductValidator>();
            services.AddTransient<IUpdateProductValidator, UpdateProductValidator>();
            services.AddTransient<IDeleteProductValidator, DeleteProductValidator>();



            // application services 
            services.AddTransient<ICustomersService, CustomersService>();
            services.AddTransient<IProductsService, ProductsService>();
            services.AddTransient<IOrdersService, OrdersService>();
            services.AddTransient<IActivityLogService, ActivityLogService>();

            services.AddTransient<IOrderPaymentCalculationService, OrderPaymentCalculationService>();


        }
    }
}
