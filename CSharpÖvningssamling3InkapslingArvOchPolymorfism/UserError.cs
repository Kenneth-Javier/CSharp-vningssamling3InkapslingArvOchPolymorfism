using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpÖvningssamling3InkapslingArvOchPolymorfism
{
    abstract class UserError
    {
        public abstract string UEMessage();

    }
    class NumericInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a numeric input in a text only field. This fired an error!";
        }
    }
    class TextInputError : UserError
    {

        public override string UEMessage()
        {
            return "You tried to use a text input in anumericonly field. This fired an error!";
        }
    }
}
