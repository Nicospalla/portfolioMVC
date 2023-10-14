using PortfolioMVC.Models;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace PortfolioMVC.Servicios
{
    public interface IServicioEmail
    {
        Task Enviar(ContactoViewModel contacto);
    }
    public class ServicioEmailSendGrid : IServicioEmail
    {
        public IConfiguration Configuration { get; }
        public ServicioEmailSendGrid(IConfiguration configuration)
        {
            Configuration = configuration;
        }


        public async Task Enviar(ContactoViewModel contacto)
        {
            var apiKey = Configuration.GetValue<string>("SENDGRID_API_KEY");
            var email = Configuration.GetValue<string>("SENGRID_FROM");
            var nombre = Configuration.GetValue<string>("SENDRIG_NOMBRE");

            var cliente = new SendGridClient(apiKey);
            var from = new EmailAddress(email, nombre);
            var subjet = $"El cliente {contacto.Mail} quiere contactarte.";
            var to = new EmailAddress(email, nombre);
            var mensajeTextoPlano = contacto.Mensaje;
            var contenidoHTML = $@"De: {contacto.Nombre} - 
                               Email: {contacto.Mail} -   
                               Mensaje: {contacto.Mensaje}";

            var singleEmail = MailHelper.CreateSingleEmail(from, to, subjet, mensajeTextoPlano, contenidoHTML);
            var respuesta = await cliente.SendEmailAsync(singleEmail);
        }
    }
}
