    
    string[] cibiPreferiti = { "Pizza", "Piada Romagnola", "Lasagne", "Sushi", "Cacio e Pepe", "Börek" };

    // .Lenght per indicare la lunghezza dell'array
    Console.WriteLine("La lunghezza della classifica è: " + cibiPreferiti.Length + "\r\n");

    Console.WriteLine("La classifica è:");
    
    // Ciclo for per stampare gli elementi in ordine
    for (int i = 0; i < cibiPreferiti.Length; i++)
    {
        Console.WriteLine((i + 1) + ")" + cibiPreferiti[i]);
    }

    Console.WriteLine();

    // Stampa del primo elemento dell'array tramite console.WriteLine
    Console.WriteLine("Il cibo top è: " + cibiPreferiti[0]);

    // Stampa dell'ultimo elemento dell'array tramite console.WriteLine
    Console.WriteLine("Il cibo flop è: " + cibiPreferiti[cibiPreferiti.Length - 1]);


    // Ciclo if per indicare se l'array è pari (if) o dispari (else)
    if (cibiPreferiti.Length % 2 == 0)
    {
        // La classifica ha un numero pari di elementi
        int meta1 = cibiPreferiti.Length / 2 - 1;
        int meta2 = cibiPreferiti.Length / 2;
        Console.WriteLine("I cibi di metà classifica sono: " + cibiPreferiti[meta1] + " e " + cibiPreferiti[meta2]);
    }
    else
    {
        // La classifica ha un numero dispari di elementi
        int metaPrecisa = cibiPreferiti.Length / 2;
        Console.WriteLine("Il cibo di metà classifica è: " + cibiPreferiti[metaPrecisa]);
    }

Console.ReadLine();
