using MailKit.Net.Smtp;
using MimeKit;

MimeMessage message = new();
message.From.Add(new MailboxAddress("Nome de Exibição", "Email de Exibição"));
message.To.Add(MailboxAddress.Parse("Email de destino"));
message.Subject = "Titulo da Mensagem";
message.Body = new TextPart("plain")
{
    Text = "Mensagem que "
};
SmtpClient client = new();
try
{
    client.Connect("host", port, true);
    client.Authenticate("Email de Envio", "Senha");
    client.Send(message);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    client.Disconnect(true);
    client.Dispose();
}