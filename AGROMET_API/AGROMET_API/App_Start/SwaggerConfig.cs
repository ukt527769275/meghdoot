using System.Web.Http;
using WebActivatorEx;
using AGROMET_API;
using Swashbuckle.Application;
using Swashbuckle.Swagger;
using System.Web.Http.Description;
using static AGROMET_API.ParameterOperationFilter;
using System.Collections.Generic;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace AGROMET_API
{
    public class SwaggerConfig
    {
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration
                .EnableSwagger(c =>
                    {
                        c.SchemaId(x => x.FullName);                        
                        c.DescribeAllEnumsAsStrings();                       
                        c.SingleApiVersion("v1", "AGROMET_API");
                        c.OperationFilter<ParameterOperationFilter>();
                    })
                .EnableSwaggerUi(c =>
                    {
                        c.DocumentTitle("AGROMET API");
                    });
        }
    }
    public class ParameterOperationFilter : IOperationFilter
    {
        
        public void Apply(Operation operation, SchemaRegistry schemaRegistry, ApiDescription apiDescription)
        {
            if (operation == null) return;

            if (operation.parameters == null)
            {
                operation.parameters = new List<Parameter>();
            }
            //if(apiDescription.RelativePath.Contains("api/uploadimages"))
            if (operation.operationId.ToLower() == "uploadimages")
            {
                operation.parameters.Add(new Parameter
                {
                    description = "Upload File",
                    @in = "formData",
                    name = "uploadImges",
                    required = true,
                    type = "file"
                });
                operation.consumes.Add("multipart/form-data");//multipart  application
            }
        }
    }
}
