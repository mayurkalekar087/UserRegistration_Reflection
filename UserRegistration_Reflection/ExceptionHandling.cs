using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistration_Reflection
{
    class ExceptionHandling : Exception
    {
        public enum ExceptionsCustomMessage
        {
            INVALID_INPUT
        }

        private readonly ExceptionsCustomMessage customMessage;
        public ExceptionHandling(ExceptionsCustomMessage customMessage, string message) : base(message)
        {
            this.customMessage = customMessage;
        }
    }
}

