bool controllo(string esp)
{
    string b = esp;
    for (int i = 0; i < esp.Length; i++)
    {
        esp.Contains('(');
        b.Contains(')');
    }

}

Console.WriteLine("dimmi la tua espressione matematica ");
string esp = Console.ReadLine();