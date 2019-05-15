using System;
using System.Runtime.Serialization;

namespace SecretAgent
{
    [Serializable]
    internal class ItemNotFoundException : Exception
    {
        public ItemNotFoundException()
        {
        }

        public ItemNotFoundException(string message) : base(message)
        {
            Console.WriteLine("Item not found");
        }

        public ItemNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ItemNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}