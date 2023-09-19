// See https://aka.ms/new-console-template for more information

using System.Text;

FileStream fs = new FileStream("./../../../input.txt", FileMode.Open);
StreamReader rd = new StreamReader(fs, Encoding.UTF8);
string content = rd.ReadToEnd();
Console.WriteLine(content);

string contentOutput = Capitalization(content);

File.WriteAllText("./../../../output.txt", contentOutput);

rd.Close();


static string Capitalization<T>(T content)
{
    return content.ToString().ToUpper();
}
