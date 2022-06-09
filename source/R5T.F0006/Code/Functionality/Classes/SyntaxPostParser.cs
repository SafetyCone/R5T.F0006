using System;


namespace R5T.F0006
{
	public class SyntaxPostParser : ISyntaxPostParser
	{
    	#region Infrastructure

	    public static SyntaxPostParser Instance { get; } = new();

	    private SyntaxPostParser()
	    {
	    }

    	#endregion
	}
}