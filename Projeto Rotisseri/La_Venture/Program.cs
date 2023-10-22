string? respostaAgendamento, respostaSemana, respostaPedido, respostaPagamento, respostaDia, respostaHorario, respostaEntrega;
List<string> diasDisponiveis = new()
{
    "quarta","quinta","sexta","sabado"
};
diasDisponiveis.Add("domingo");



var pagamento = () =>
{
    Console.WriteLine("Formas de pagamento");
    Console.WriteLine("--------------------");
    Console.Write("Digite 1 para pix");
    Console.WriteLine();
    Console.Write("Digite 2 para débito");
    Console.WriteLine();
    Console.WriteLine("Digite 3 para crédito");
    respostaPagamento = Console.ReadLine();
    if (respostaPagamento == "1")
    {
        Console.WriteLine("Segue chave pix sdahvf3v76tsvhsv7t");
    }
    else if (respostaPagamento == "2")
    {

    }
    else if (respostaPagamento == "3")
    {

    }
    else
    {
        Console.WriteLine("Resposta inválida");
    }
};



Console.WriteLine("Sistema Rotisserie La Venture");
Console.WriteLine();
Console.WriteLine("Você gostaria de agendar o pedido ?");
respostaAgendamento = Console.ReadLine();
if (respostaAgendamento == "sim")
{
    Console.WriteLine("Para está ou próxima semana? ");
    Console.WriteLine();
    Console.WriteLine("Digite 1 para está semana");
    Console.WriteLine();
    Console.WriteLine("Digite 2 para a próxima semana");

    respostaSemana = Console.ReadLine();
    if (respostaSemana == "1")
    {
        Console.Write("Informe o dia da semana: ");
        respostaDia = Console.ReadLine();
        Console.WriteLine();
        Console.Write("Informe o horário do dia: ");
        respostaHorario = Console.ReadLine();
        if (diasDisponiveis.Any(D => respostaDia == D))
        {
            Console.WriteLine("Dia disponível, escolha sua forma de pagamento agora!");
            Console.WriteLine("-----------------------------------------------------");
            pagamento.Invoke();
            Console.WriteLine("Pagamento concluído");
            Console.WriteLine("-------------------");
            Console.WriteLine("Digite 1 para retirada");
            Console.WriteLine();
            Console.WriteLine("Digite 2 para entrega");
            respostaEntrega = Console.ReadLine();
            if (respostaEntrega == "1")
            {
                Console.WriteLine("Pedido enviado para produção e aguardará retirada no dia agendado");
                Console.WriteLine();
                Console.WriteLine("Obrigada por escolher a Rotisserie La Venture");
            }
            else if (respostaEntrega == "2")
            {
                Console.WriteLine("Pedido enviado para produção e será entregue no dia agendado");
                Console.WriteLine();
                Console.WriteLine("Obrigada por escolher a Rotisserie La Venture");
            }
            else
            {
                Console.WriteLine("Resposta inválida");
            }
        }
        else
        {

        }
    }
    else if (respostaSemana == "2")
    {
        Console.Write("Informe o dia da semana: ");
        respostaDia = Console.ReadLine();
        Console.WriteLine();
        Console.Write("Informe o horário do dia: ");
        respostaHorario = Console.ReadLine();
        if (diasDisponiveis.Any(D => respostaDia == D))
        {
            Console.WriteLine("Dia disponível, escolha sua forma de pagamento agora!");
            Console.WriteLine();
            pagamento.Invoke();
            Console.WriteLine("Pagamento concluído");
            Console.WriteLine();
            Console.WriteLine("Digite 1 para retirada");
            Console.WriteLine();
            Console.WriteLine("Digite 2 para entrega");
            respostaEntrega = Console.ReadLine();

            if (respostaEntrega == "1")
            {
                Console.WriteLine("Pedido enviado para produção e aguardará retirada no dia agendado");
                Console.WriteLine();
                Console.WriteLine("Obrigada por escolher a Rotisserie La Venture");
            }
            else if (respostaEntrega == "2")
            {
                Console.WriteLine("Pedido enviado para produção e será entregue no dia agendado");
                Console.WriteLine();
                Console.WriteLine("Obrigada por escolher a Rotisserie La Venture");
            }
        }
        else
        {

        }
    }
    else
    {
        Console.WriteLine("Resposta inválida");
    }
}
else if (respostaAgendamento == "não")
{
    Console.WriteLine("Qual será seu pedido?");
    respostaPedido = Console.ReadLine();
    Console.WriteLine();
    pagamento.Invoke();
    Console.WriteLine();
    Console.WriteLine("Pagamento concluído");
    Console.WriteLine("Digite 1 para retirada");
    Console.WriteLine();
    Console.WriteLine("Digite 2 para entrega");
    respostaEntrega = Console.ReadLine();
    if (respostaEntrega == "1")
    {
        Console.WriteLine("Pedido está em andamento");
    }
    else if (respostaEntrega == "2")
    {
        Console.WriteLine("Pedido está em preparo e logo sairá para entrega");
    }
}
else
{
    Console.WriteLine("Resposta inválida");
}








