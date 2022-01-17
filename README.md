---
<h1>Envio de E-mail via SMTP, .NET Core 6, MailKit e MimeKit</h1>

---

<p>Os Pacotes utilizados foram:</p>
<pre><code>using MailKit.Net.Smtp;
using MimeKit;
</code></pre>
<p>Para criação do e-mail:</p>
<pre><code>MimeMessage message = new();
</code></pre>
<p>Adicionar nome e e-mail de exibição</p>
<pre><code>message.From.Add(new MailboxAddress(
    "Nome de Exibição", "Email de Exibição"
));
</code></pre>
<p>Adicionar e-mail de destino:</p>
<pre><code>message.To.Add(MailboxAddress.Parse("Email de destino"));
</code></pre>
<p>Adicionar Titulo da mensagem:</p>
<pre><code>message.Subject = "Titulo da Mensagem";
</code></pre>
<p>Adicionar corpo e mensagem do e-mail:</p>
<pre><code>message.Body = new TextPart("plain")
{
    Text = "Mensagem que "
};
</code></pre>
<p>Criar conexão para cliente SMTP :</p>
<pre><code>SmtpClient client = new();
client.Connect("host", port, /*useSSL*/ true);
</code></pre>
<p>E-mail e senha para autenticação:</p>
<pre><code>client.Authenticate("Email de Envio", "Senha");
</code></pre>
<p>Enviar mensagem:</p>
<pre><code>client.Send(message);
</code></pre>
<p>Desconectar do cliente SMTP:</p>
<pre><code>client.Disconnect(true);
client.Dispose();
</code></pre>

