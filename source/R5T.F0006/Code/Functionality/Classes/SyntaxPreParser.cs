using System;


namespace R5T.F0006
{
	public class SyntaxPreParser : ISyntaxPreParser
	{
    	#region Infrastructure

	    public static SyntaxPreParser Instance { get; } = new();

	    private SyntaxPreParser()
	    {
	    }

    	#endregion
	}
}