using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace hotel
{
    static class Program
    {
        public static IServiceProvider ServiceProvider { get; set; }
        public static IServiceProvider ServiceProviderPayment { get; set; }
        static void ConfigureServices()
        {
            var services = new ServiceCollection();
            services.AddTransient<IDataAccess, SqlDataAccess>();
            ServiceProvider = services.BuildServiceProvider();

            var servicesPayment = new ServiceCollection();
            servicesPayment.AddTransient<IPayment, Payment>();
            ServiceProviderPayment = servicesPayment.BuildServiceProvider();
        }


       
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ConfigureServices();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AdminLogin());
        }
    }
}
