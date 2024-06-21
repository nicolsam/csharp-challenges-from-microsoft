string pangram = "The quick brown fox jumps over the lazy dog";
string pangramReversedWords;

string[] words = pangram.Split(" ");
string[] reversedWords = new string[pangram.Length];

Console.WriteLine(words);

for (int i = 0; i < words.Length; i++)
{
    char[] letters = words[i].ToCharArray();
    Array.Reverse(letters);

    reversedWords[i] = String.Join("", letters);

}

pangramReversedWords = String.Join(" ", reversedWords);
Console.WriteLine(pangramReversedWords);

