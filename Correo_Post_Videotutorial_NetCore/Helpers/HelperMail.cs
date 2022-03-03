using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Correo_Post_Videotutorial_NetCore.Helpers
{
    public class HelperMail
    {
        private IConfiguration configuration;
        public HelperMail(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        private MailMessage ConfigureMail()
        {

        }
    }
}
