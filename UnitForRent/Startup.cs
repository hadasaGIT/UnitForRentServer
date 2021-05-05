using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnitForRent.BL;
using UnitForRent.DAL;
using UnitForRent.Models;
using Microsoft.OpenApi.Models;


namespace UnitForRent
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();



            services.AddDbContext<UnitForRentContext>(options => options.UseSqlServer(
             Configuration.GetSection("ConnectionString")["UnitForRentConnection"]));

            //BL
            services.AddScoped<ITblAnswersForRentBL, TblAnswersForRentBL>();
            services.AddScoped<ITblCustomerBL, TblCustomerBL>();
            services.AddScoped<ITblFeedbackBL, TblFeedbackBL>();
            services.AddScoped<ITblFurnitureLevelBL, TblFurnitureLevelBL>();
            services.AddScoped<ITblHousingUnitBL, TblHousingUnitBL>();
            services.AddScoped<ITblHousingUnitImageBL, TblHousingUnitImageBL>();
            services.AddScoped<ITblHousingUnitRelevantBL, TblHousingUnitRelevantBL>();
            services.AddScoped<ITblManagerBL, TblManagerBL>();
            services.AddScoped<ITblQuestionsForRentBL, TblQuestionsForRentBL>();
            services.AddScoped<ITblSearchBL, TblSearchBL>();
            services.AddScoped<ITblUnitOwnerBL, TblUnitOwnerBL>();
            //DAL
            services.AddScoped<ITblAnswersForRentDAL, TblAnswersForRentDAL>();
            services.AddScoped<ITblCustomerDAL, TblCustomerDAL>();
            services.AddScoped<ITblFeedbackDAL, TblFeedbackDAL>();
            services.AddScoped<ITblFurnitureLevelDAL, TblFurnitureLevelDAL>();
            services.AddScoped<ITblHousingUnitDAL, TblHousingUnitDAL>();
            services.AddScoped<ITblHousingUnitImageDAL, TblHousingUnitImageDAL>();
            services.AddScoped<ITblHousingUnitRelevantDAL, TblHousingUnitRelevantDAL>();
            services.AddScoped<ITblManagerDAL, TblManagerDAL>();
            services.AddScoped<ITblQuestionsForRentDAL, TblQuestionsForRentDAL>();
            services.AddScoped<ITblSearchDAL, TblSearchDAL>();
            services.AddScoped<ITblUnitOwnerDAL, TblUnitOwnerDAL>();

            //services.AddSwaggerGen(c =>
            //{
            //    c.SwaggerDoc("v1", new OpenApiInfo
            //    {
            //        Title = "My API",
            //        Version = "v1"
            //    });
            //} );
            //ff
        }
         
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            app.UseSwagger();
            // app.UseSwaggerUI(c => { c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1"); });

        }
    }
}
