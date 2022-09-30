﻿/*
Foi solicitado que você adicionasse um recurso ao software de sua empresa. 
O recurso destina-se a melhorar a taxa de renovação das assinaturas do software. 
Sua tarefa é exibir uma mensagem de renovação quando um usuário entrar no sistema 
de software e receber a notificação de que a assinatura está prestes a ser encerrada. 
Você precisará adicionar um par de instruções de decisão para adicionar corretamente 
a lógica de ramificação ao aplicativo para atender aos requisitos.
*/

/*
Use duas instruções IF para implementar as seguintes regras de negócios (ramificação 
ou aninhamento três na primeira instrução IF)

Regra 1. Se a assinatura do usuário expirar em dez dias ou menos, será exibida a mensagem:
Your subscription will expire soon. Renew now!

Regra 2. Se a assinatura do usuário for expirar em cinco dias ou menos, exiba as mensagens:
Your subscription expires in x days.
Renew now and save 10%!

Regra 3. Se a assinatura do usuário for expirar em um dia, exiba a mensagem:
Your subscription expires within a day!
Renew now and save 20%!

Regra 4. Se a assinatura do usuário tiver expirado, será exibida a mensagem:
Your subscription has expired.

Regra 5. Se a assinatura do usuário expirar em mais de dez dias, nada será exibido.

*/

Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

if (daysUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired.");
}
else if (daysUntilExpiration == 1)
{
    Console.WriteLine("Your subscription expires within a day!");
    discountPercentage = 20;
}
else if (daysUntilExpiration <= 5)
{
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
    discountPercentage = 10;
}
else if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}

if (discountPercentage > 0)
{
    Console.WriteLine($"Renew now and save {discountPercentage}%.");
}