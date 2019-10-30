using System;

public static class RnaTranscription
{
    public static string ToRna(string nucleotide)
    {
        char[] arrayOfNucleotides = nucleotide.ToCharArray();
        string rna = "";

        foreach (char element in arrayOfNucleotides)
        {
            switch (element)
            { 
                case 'G':
                    rna += 'C';
                    break;
                case 'C':
                    rna += 'G';
                    break;
                case 'T':
                    rna += 'A';
                    break;
                case 'A':
                    rna += 'U';
                    break;
             }   
        }

        return rna;
    }
}