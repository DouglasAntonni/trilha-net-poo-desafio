using DesafioPOO.Models;

       
        Smartphone iphone = new Iphone("123456789", "iPhone 14", "26765355626652", 128);
        Smartphone nokia = new Nokia("987654321", "Nokia Lumia", "72986523416", 64);

        
        Console.WriteLine("Testando iPhone:");
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("WhatsApp");

        Console.WriteLine("\nTestando Nokia:");
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("Telegram");

       

