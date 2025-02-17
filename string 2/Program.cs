bool controllo(string esp)
{
    int contaA = 0, contaC = 0;
    for (int i = 0; i < esp.Length; i++)
    {
        if (esp[i] == '(')
        {
            contaA++;
        }
        else if (esp[i] == ')')
        {
            contaC++;
            if (contaA < contaC)
            {
                return false;
            }
        }
        if (contaC == contaA)
        {
            return true;
        }
    }
    return false;
}

Console.WriteLine("dimmi la tua espressione matematica ");
string esp = Console.ReadLine();
Console.WriteLine(controllo(esp));