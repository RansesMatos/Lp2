using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Controllers
{
    public class Send_Email
    {
        //Metodo donde se retornara el mensaje a enviar.
        public IActionResult Index()
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Test", "csharptesting38@gmail.com"));
            //En estas comillas vacias van el nombre de la persona y su direccion de correo a donde sera enviado el mensaje, dentro de este se puede usar una clase objeto en la cual
            //Puede contener los datos de este correo.
            message.To.Add(new MailboxAddress("", ""));
            //Aqui va de que trata el correo.
            message.Subject = "";
            message.Body = new TextPart("plain") 
            { 
                Text = "This is a C# test email sender."
            };
                using (var client = new SmtpClient())
                {
                client.Connect("smtp.gmail.com", 587, false);
                //Aqui van tambien el correo base de donde se va a mandar el correo. Conjunto su contraseña.
                client.Authenticate("csharptesting38@gmail.com", "Pruebacsharp");
                client.Send(message);
                client.Disconnect(true);
                }

            return View();
        }
    }
}
