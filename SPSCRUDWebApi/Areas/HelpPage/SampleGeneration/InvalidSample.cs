using System;

namespace SPSCRUDWebApi.Areas.HelpPage
{
    /// <summary>
    /// This represents an invalid sample on the help page. There's a display template named InvalidSample associated with this class.
    /// </summary>
    public class InvalidSample
    {
#pragma warning disable CS1591 // Falta el comentario XML para el tipo o miembro visible de forma p�blica 'InvalidSample.InvalidSample(string)'
        public InvalidSample(string errorMessage)
#pragma warning restore CS1591 // Falta el comentario XML para el tipo o miembro visible de forma p�blica 'InvalidSample.InvalidSample(string)'
        {
            if (errorMessage == null)
            {
                throw new ArgumentNullException("errorMessage");
            }
            ErrorMessage = errorMessage;
        }

#pragma warning disable CS1591 // Falta el comentario XML para el tipo o miembro visible de forma p�blica 'InvalidSample.ErrorMessage'
        public string ErrorMessage { get; private set; }
#pragma warning restore CS1591 // Falta el comentario XML para el tipo o miembro visible de forma p�blica 'InvalidSample.ErrorMessage'

#pragma warning disable CS1591 // Falta el comentario XML para el tipo o miembro visible de forma p�blica 'InvalidSample.Equals(object)'
        public override bool Equals(object obj)
#pragma warning restore CS1591 // Falta el comentario XML para el tipo o miembro visible de forma p�blica 'InvalidSample.Equals(object)'
        {
            InvalidSample other = obj as InvalidSample;
            return other != null && ErrorMessage == other.ErrorMessage;
        }

#pragma warning disable CS1591 // Falta el comentario XML para el tipo o miembro visible de forma p�blica 'InvalidSample.GetHashCode()'
        public override int GetHashCode()
#pragma warning restore CS1591 // Falta el comentario XML para el tipo o miembro visible de forma p�blica 'InvalidSample.GetHashCode()'
        {
            return ErrorMessage.GetHashCode();
        }

#pragma warning disable CS1591 // Falta el comentario XML para el tipo o miembro visible de forma p�blica 'InvalidSample.ToString()'
        public override string ToString()
#pragma warning restore CS1591 // Falta el comentario XML para el tipo o miembro visible de forma p�blica 'InvalidSample.ToString()'
        {
            return ErrorMessage;
        }
    }
}