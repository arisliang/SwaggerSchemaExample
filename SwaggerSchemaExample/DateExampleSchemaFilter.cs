using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwaggerSchemaExample
{
    /// <summary>
    /// Formats examples for OpenApi "date" format strings as <c>yyyy-MM-dd</c>.
    /// </summary>
    public class DateExampleSchemaFilter : ISchemaFilter
    {
        public void Apply(OpenApiSchema schema, SchemaFilterContext context)
        {
            // strongly-typed example values get serialized as JSON in ISO 8601 format, with undesired precision,
            // so replace them with a string
            if (schema.Format == "date" &&
                schema.Example is OpenApiDate date)
            {
                schema.Example = new OpenApiString(date.Value.ToString("yyyy-MM-dd"));
            }
        }
    }
}
