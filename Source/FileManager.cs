using System;

public class FileManager
{
	const string FILENAME = "ManoNamuDarbas.txt";
		
	public void saveFile(string text)
	{
		System.IO.File.WriteAllText(@FILENAME, text);
	}
	
	public string readFile()
	{
		string text = System.IO.File.ReadAllText(@FILENAME);
		
		return text;
	}
	
	public string getFileName()
	{
		return FILENAME;
	}
}
