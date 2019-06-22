using System;

namespace Pacco.Services.Parcels.Core.Exceptions
{
    public abstract class ExceptionBase : Exception
    {
        public abstract string Code { get; }

        protected ExceptionBase()
        {
        }

        protected ExceptionBase(string message) : base(message)
        {
        }
    }
}