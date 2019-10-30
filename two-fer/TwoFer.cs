using System;

public static class TwoFer
{
    // In order to get the tests running, first you need to make sure the Speak method 
    // can be called both without any arguments and also by passing one string argument.

    // 3rd iteration to update method to an expression-bodied method, at suggestion of
    // mentor @Tom01098.  Thanks for the help, Tom!
    
    public static string Speak(string userName = "you") => $"One for {userName}, one for me.";
}
