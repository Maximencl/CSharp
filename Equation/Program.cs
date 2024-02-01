Console.WriteLine("Entrez la valeur de a :");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Entrez la valeur de b :");
        double b = Convert.ToDouble(Console.ReadLine());

        if (a == 0)
        {
            if (b == 0)
            {
                Console.WriteLine("L'équation a une infinité de solutions.");
            }
            else
            {
                Console.WriteLine("L'équation n'a pas de solution.");
            }
        }
        else
        {
            double solution = -b / a;
            Console.WriteLine("La solution de l'équation est x = " + solution);
        }