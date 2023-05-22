    //By NicholasDev

    double glicemia;

    Console.WriteLine("---- Diabetes Gestacional ----");
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine();
    
    Console.WriteLine("Digite o valor da glicemia em mg/dL....: ");
    glicemia = double.Parse(Console.ReadLine()!);
    Console.ResetColor();
    Console.Clear();

    if (glicemia < 92)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Nível de glicemia....: {glicemia}");
        Console.WriteLine("Reavaliar entre 24 e 28 semanas com TTOG 75g de glicose");
    }
    if (glicemia >= 92 && glicemia < 126)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Nível de glicemia....: {glicemia}");
        Console.WriteLine("Compátivel com Diabetes Gestacional");
    }
    if (glicemia >= 126)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Nível de glicemia....: {glicemia}");
        Console.WriteLine("Diavetes de Mellitus na Gravidez");
    }