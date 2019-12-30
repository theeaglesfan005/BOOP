using System;

public abstract class Developer
{
    private string _mainDevLanguage;    
    
    public Developer(string mainDevLanguage)
    {
        this._mainDevLanguage = mainDevLanguage;
    }

    public virtual void Code()
    {
        Console.WriteLine(String.Format("I am coding using my main dev language {0}.", this._mainDevLanguage));
    }

    public virtual void Code(string ExtraDevLanguage)
    {
        Console.WriteLine(String.Format("I am coding using my main dev language {0}. Additonally, I am using {1} as extra dev language.", this._mainDevLanguage, ExtraDevLanguage));
    }

    public virtual void Code(string firstExtraDevLanguage = null, string secondExtraDevLanguage = null)
    {
        Console.WriteLine(String.Format("I am coding using my main dev language {0}. Additonally, I am using {1} and {2} as extra dev languages.", this._mainDevLanguage, firstExtraDevLanguage, secondExtraDevLanguage));
    }
}