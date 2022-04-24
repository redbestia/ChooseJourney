using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Utility
{
    public enum Option { Option1, Option2, Defult }

    public static Option ChooseLastUsedOption(bool option1, bool option2, ref Option lastUsedOption)
    {
        if (option1 && option2)
        {
            if (lastUsedOption == Option.Option1)
            {
                return Option.Option2;
            }
            if (lastUsedOption == Option.Option2)
            {
                return Option.Option1;
            }
        }
        if (option1)
        {
            lastUsedOption = Option.Option1;
            return Option.Option1;
        }
        if (option2)
        {
            lastUsedOption = Option.Option2;
            return Option.Option2;
        }
        return Option.Defult;
    }

}
