using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace MVC_MailService_Tekrar.Tools
{
    public static class MailService
    {
        //Şifre, Gönderici, Mesaj Tanımlamasından sonra protokol işlemleri ile devam edecektir
        public static void Send(string receiver, string password="ylz3153--", string body="Test mesajıdır",string subject="Email Testi",string sender = "teknoromaproject3153@gmail.com")
        {
            MailAddress senderEmail = new MailAddress(sender);
            MailAddress receiverEmail = new MailAddress(receiver);

            //SmtpClient=> Bir Protokol
            //sender => gönderici
            //receiver => alıcı
            //Gmail güvenlik ayarlarından dolayı alınan hata nedeniyle gmail üzerinde gerekli değişiklik yapılacak.

            SmtpClient smtp = new SmtpClient()
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(senderEmail.Address, password)
            };

            using (MailMessage message = new MailMessage(senderEmail, receiverEmail)
            {
                Subject = subject,
                Body = body,
            })
            {
                smtp.Send(message);
            }
        }
    }
}