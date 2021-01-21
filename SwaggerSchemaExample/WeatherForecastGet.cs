using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwaggerSchemaExample
{
    public class WeatherForecastGet
    {
        /// <summary>
        /// Date created. Format yyyy-MM-dd.
        /// </summary>
        [SwaggerSchema("The date it was created", Format = "date")]
        public DateTime DateCreated { get; set; }
    }
}
