using System;
public class HelloWorld
{
    public static void Main(string[] args)
    {

        const string CombinacioSecreta = "1 5 3 1";
        const string MasterMind = " /\\_/\\  /\\_/\\  /\\_/\\  /\\_/\\  /\\_/\\  /\\_/\\  /\\_/\\  /\\_/\\  /\\_/\\  /\\_/\\  /\\_/\\  /\\_/\\  /\\_/\\ \r\n( o.o )( o.o )( o.o )( o.o )( o.o )( o.o )( o.o )( o.o )( o.o )( o.o )( o.o )( o.o )( o.o )\r\n > ^ <  > ^ <  > ^ <  > ^ <  > ^ <  > ^ <  > ^ <  > ^ <  > ^ <  > ^ <  > ^ <  > ^ <  > ^ < \r\n /\\_/\\           ___    ,---.        ,-,--.  ,--.--------.    ,----.                 /\\_/\\ \r\n( o.o )   .-._ .'=.'\\ .--.'  \\     ,-.'-  _\\/==/,  -   , -\\,-.--` , \\  .-.,.---.    ( o.o )\r\n > ^ <   /==/ \\|==|  |\\==\\-/\\ \\   /==/_ ,_.'\\==\\.-.  - ,-./==|-  _.-` /==/  `   \\    > ^ < \r\n /\\_/\\   |==|,|  / - |/==/-|_\\ |  \\==\\  \\    `--`\\==\\- \\  |==|   `.-.|==|-, .=., |   /\\_/\\ \r\n( o.o )  |==|  \\/  , |\\==\\,   - \\  \\==\\ -\\        \\==\\_ \\/==/_ ,    /|==|   '='  /  ( o.o )\r\n > ^ <   |==|- ,   _ |/==/ -   ,|  _\\==\\ ,\\       |==|- ||==|    .-' |==|- ,   .'    > ^ < \r\n /\\_/\\   |==| _ /\\   /==/-  /\\ - \\/==/\\/ _ |      |==|, ||==|_  ,`-._|==|_  . ,'.    /\\_/\\ \r\n( o.o )  /==/  / / , |==\\ _.\\=\\.-'\\==\\ - , /      /==/ -//==/ ,     //==/  /\\ ,  )  ( o.o )\r\n > ^ <   `--`./  `--` `--`         `--`---'       `--`--``--`-----`` `--`-`--`--'    > ^ < \r\n /\\_/\\           ___   .=-.-..-._                                                    /\\_/\\ \r\n( o.o )   .-._ .'=.'\\ /==/_ /==/ \\  .-._  _,..---._                                 ( o.o )\r\n > ^ <   /==/ \\|==|  |==|, ||==|, \\/ /, /==/,   -  \\                                 > ^ < \r\n /\\_/\\   |==|,|  / - |==|  ||==|-  \\|  ||==|   _   _\\                                /\\_/\\ \r\n( o.o )  |==|  \\/  , |==|- ||==| ,  | -||==|  .=.   |                               ( o.o )\r\n > ^ <   |==|- ,   _ |==| ,||==| -   _ ||==|,|   | -|                                > ^ < \r\n /\\_/\\   |==| _ /\\   |==|- ||==|  /\\ , ||==|  '='   /                                /\\_/\\ \r\n( o.o )  /==/  / / , /==/. //==/, | |- ||==|-,   _`/                                ( o.o )\r\n > ^ <   `--`./  `--``--`-` `--`./  `--``-.`.____.'                                  > ^ < \r\n /\\_/\\  /\\_/\\  /\\_/\\  /\\_/\\  /\\_/\\  /\\_/\\  /\\_/\\  /\\_/\\  /\\_/\\  /\\_/\\  /\\_/\\  /\\_/\\  /\\_/\\ \r\n( o.o )( o.o )( o.o )( o.o )( o.o )( o.o )( o.o )( o.o )( o.o )( o.o )( o.o )( o.o )( o.o )\r\n > ^ <  > ^ <  > ^ <  > ^ <  > ^ <  > ^ <  > ^ <  > ^ <  > ^ <  > ^ <  > ^ <  > ^ <  > ^ < ";
        const string Presentació = "                     Aquest joc ha sigut programat per Sergio Vegas ;)";
        const string Decoracio = "\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\";  
        const string Explicacio = "Has d'encertar la combinació secreta de 4 numeros diferents, tenint en compte que els numeros dins\nde la combinació estan entre 1 i 6.";
        const string Explicacio2 = "Has d'inserir un numero i un espai,fins que tinguis una combinació de quatre numeros. Exemple:1 3 4 6";
        const string SeleccioDificultat = "Selecciona una de les següents dificultats. Has de introduïr el número asignat a la dificultat seleccionada.";
        const string DificultatNovell = "1. Dificultat novell: Disposarás de 10 intents";
        const string DificultatAficionat = "2. Dificultat aficionat: Disposarás de 6 intents";
        const string DificultatExpert = "3. Dificultat expert: Disposarás de 4 intents";
        const string DificultatMaster = "4. Dificultat Màster: Disposarás de 3 intents";
        const string DificultatPersonalitzada= "5. Dificultat Personalitzada: Disposarás del intents que tu vulguis. ";
        const string MsgIntentsDifPersonalitzada = "A continuació has d'introduïr el número d'intents que voldràs.A de ser un nombre entre 1 a 99";
        const string Go = " ________  ________  ___       \r\n|\\   ____\\|\\   __  \\|\\  \\      \r\n\\ \\  \\___|\\ \\  \\|\\  \\ \\  \\     \r\n \\ \\  \\  __\\ \\  \\\\\\  \\ \\  \\    \r\n  \\ \\  \\|\\  \\ \\  \\\\\\  \\ \\__\\   \r\n   \\ \\_______\\ \\_______\\|__|   \r\n    \\|_______|\\|_______|   ___ \r\n                          |\\__\\\r\n                          \\|__|";
        const string MsgErrorIntroduccioDades = "Les dades no han sigut introduides correctament";
        const string NoIntents = $"Ja no tens més intents, gràcies per jugar! La combinació era {CombinacioSecreta}";
        const string Guanyar = "Felicitats has guanyat!:D";
        const string ExplicacioPistes = "Durant el lloc rebras unes pistes que t'ayudarán a aconseguir el teu objectiu!";
        const string ExplicacioPistes2 = "Si surt'O' vol dir que el numero esta en la posició correcta, si surt 'Ø' el numero esta a la combinació\nperò no al lloc i per últim si surt '×' el numero no esta a la combinació.";
        const string TornarJugar = "Si vols tornar a jugar introdueix el numero 1, si no introdueix un altre numero";
        const string SortirJoc = "Si vols sortir en qualsevol moment  del joc, introdueix la paraula 'sortir' sense les cometes";
        const string GraciesJugar = "Moltes gràcies per jugar! :D";

        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine(MasterMind);
        Console.WriteLine();
        Console.WriteLine(Decoracio);
        Console.WriteLine();
        Console.WriteLine(Presentació);
        Console.WriteLine();
        Console.WriteLine(Decoracio);
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(Explicacio);
        Console.WriteLine(Explicacio2);
        

        int Reebot=0;
        while(Reebot<1)
        {
        Console.WriteLine();
        Console.WriteLine(SeleccioDificultat);
        Console.WriteLine(DificultatNovell);
        Console.WriteLine(DificultatAficionat);
        Console.WriteLine(DificultatExpert);
        Console.WriteLine(DificultatMaster);
        Console.WriteLine(DificultatPersonalitzada);
        int dificultad = 0;
        try
        {
           dificultad = int.Parse(Console.ReadLine());
        }
        catch (Exception e) { }
        
        int intents = 0;

        switch(dificultad)
        {
            case 1:
                intents = 10;
                break;
            case 2: 
                intents = 6;
                break;
            case 3:
                intents = 4;
                break;
            case 4:
                intents = 3;
                break;
            case 5:
                Console.WriteLine(MsgIntentsDifPersonalitzada);
                try
                {
                intents = int.Parse(Console.ReadLine());
                }
                catch (Exception e) { } 
                break;
        }
        if (intents < 1 || intents > 100)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(MsgErrorIntroduccioDades);
            Console.ForegroundColor = ConsoleColor.White; 
        }
        else {
        Console.WriteLine();        
        Console.WriteLine(ExplicacioPistes);
        Console.WriteLine(ExplicacioPistes2);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(Go);
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine();
            for (int i = 0; i < intents; i++)
            {
                int volTornarJugar = 0;
                string[] arrayCombinacioSecreta = CombinacioSecreta.Split(" ");

                Console.WriteLine($"Ho podrás aconseguir? Et quedan {intents-i} intents!");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(SortirJoc);
                Console.ForegroundColor = ConsoleColor.White;

                string combinacioUsuari=Console.ReadLine();
                string[] arrayCombinacioUsuari = combinacioUsuari.Split(" ");

                if (arrayCombinacioUsuari.Length == arrayCombinacioSecreta.Length)
                {
                    for (int j = 0; j < arrayCombinacioUsuari.Length; j++)
                    {
                        if (arrayCombinacioSecreta[j] == arrayCombinacioUsuari[j])
                        {
                        Console.Write("O");
                        }
                        else
                        {
                            int k = 0;
                            for (; k < arrayCombinacioSecreta.Length; k++)
                            {
                                if (arrayCombinacioUsuari[j] == arrayCombinacioSecreta[k])
                                {
                                Console.Write("Ø");
                                k = arrayCombinacioSecreta.Length + 1;
                                }
                            }
                            if (k == arrayCombinacioSecreta.Length)
                            {
                            Console.Write("×");
                            }
                        }
                    }
                    Console.WriteLine();

                    if (combinacioUsuari == CombinacioSecreta)
                    {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(Guanyar);
                    Console.ForegroundColor = ConsoleColor.White; 
                    i = intents;
                    Console.WriteLine(TornarJugar);
                    try
                    { 
                    volTornarJugar= int.Parse(Console.ReadLine());
                    }
                    catch (Exception e) 
                    { 
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine(GraciesJugar);
                    Console.ForegroundColor = ConsoleColor.White;
                    }
                    if (volTornarJugar != 1)
                    { Reebot++;
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine(GraciesJugar);
                    Console.ForegroundColor = ConsoleColor.White;
                    }
                    }
                    if (intents == i + 1)
                    {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(NoIntents);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(TornarJugar);
                    try
                    { 
                    volTornarJugar= int.Parse(Console.ReadLine());
                    }
                    catch (Exception e) 
                    { 
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine(GraciesJugar);
                    Console.ForegroundColor = ConsoleColor.White;
                    }

                    if (volTornarJugar != 1)
                    { Reebot++;
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine(GraciesJugar);
                    Console.ForegroundColor = ConsoleColor.White;}
                    }
                }
                else if(combinacioUsuari=="sortir")
                {
                    Reebot++;
                    i = intents;
                }
                else
                {
                   Console.ForegroundColor = ConsoleColor.Red;
                   Console.WriteLine(MsgErrorIntroduccioDades);
                   Console.ForegroundColor = ConsoleColor.White;
                if(i+1 == intents) {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(NoIntents);
                        Console.ForegroundColor = ConsoleColor.White;       
                        Console.WriteLine(TornarJugar);
                        try
                        { 
                        volTornarJugar= int.Parse(Console.ReadLine());
                        }
                        catch (Exception e) 
                        { 
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine(GraciesJugar);
                        Console.ForegroundColor = ConsoleColor.White;
                        }

                        if (volTornarJugar != 1)
                        { Reebot++;
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine(GraciesJugar);
                        Console.ForegroundColor = ConsoleColor.White;    }
                        }
                }
            }
        }
        }
    }
}

