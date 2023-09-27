// ====== Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить черточками, 
// маленькие буквы заменить "к" заменить большими "К"
// а большие "С" заменить маленькими "с"

string textIs = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";



string Rplace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int len = text.Length;
    for (int i=0; i < len; i++)
    {
        if (text[i] == oldValue) result += $"{newValue}";
        else result += $"{text[i]}";
    }

    return result;
} 

string newText = Rplace(textIs, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();

newText = Rplace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();

newText = Rplace(newText, 'С', 'с');
Console.WriteLine(newText);


