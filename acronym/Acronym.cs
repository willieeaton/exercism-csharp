using System;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        //goal one: break everything into words

        string[] wordsInPhrase = {};
        int increment = 0;
        
        while (phrase.Contains(' '))
        {
            int spacePosition = phrase.IndexOf(' ');

            wordsInPhrase[increment] = phrase.Substring(0, spacePosition);
            phrase = phrase.Substring(spacePosition);

            increment++;
        }
        /* goal two: get first letter of words
        step 1: identify first letter of each word
        step 2: concatenate to result string
        step 3: return result string */ 

        string result = "";
        
        foreach(string element in wordsInPhrase)
        {
            result += element.Substring(0,1);
        }

        return result;
       
    }
}