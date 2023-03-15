
        string[] cibiPreferiti = { "Pizza", "Piada Romagnola", "Lasagne", "Sushi", "Cacio e Pepe" };

        Console.WriteLine("La lunghezza della classifica è: " + cibiPreferiti.Length);

    Console.WriteLine("La classifica è:");
    for (int i = 0; i < cibiPreferiti.Length; i++)
    {
        Console.WriteLine((i + 1) + ")" + cibiPreferiti[i]);
    }

    Console.WriteLine("Il cibo top è: " + cibiPreferiti[0]);

    Console.WriteLine("Il cibo flop è: " + cibiPreferiti[cibiPreferiti.Length - 1]);

    Console.ReadLine();
