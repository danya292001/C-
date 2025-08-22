string Name = "ACME";
string EN = $@"c:\Exercise\{Name}\data.txt";
Console.WriteLine($"View English output:\n\t{EN}\n");

string ru = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434:";
string RU = $@"c:\Exercise\{Name}\ru-RU\data.txt";
Console.WriteLine($"{ru}\n\t{RU}\n");

