﻿using System.Runtime.Serialization;

namespace Sharc.Core.Exceptions; 

public class UserOperationException : Exception {
    public UserOperationException() { }
    protected UserOperationException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    public UserOperationException(string? message) : base(message) { }
    public UserOperationException(string? message, Exception? innerException) : base(message, innerException) { }
}