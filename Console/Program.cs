var text = "                        ";

Console.WriteLine(StringUtils.StringUtils.Letters(text));
Console.WriteLine(StringUtils.StringUtils.Sentences(text));
Console.WriteLine(StringUtils.StringUtils.Words(text));

var readability = StringUtils.StringUtils.Readability(text);

if (readability is double.NaN)
    Console.WriteLine("Error");
else
    Console.WriteLine(readability);