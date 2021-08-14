using System;

namespace SPSCRUDWebApi.Areas.HelpPage
{
    /// <summary>
    /// This represents a preformatted text sample on the help page. There's a display template named TextSample associated with this class.
    /// </summary>
    public class TextSample
    {
#pragma warning disable CS1591 // Falta el comentario XML para el tipo o miembro visible de forma p�blica 'TextSample.TextSample(string)'
        public TextSample(string text)
#pragma warning restore CS1591 // Falta el comentario XML para el tipo o miembro visible de forma p�blica 'TextSample.TextSample(string)'
        {
            if (text == null)
            {
                throw new ArgumentNullException("text");
            }
            Text = text;
        }

#pragma warning disable CS1591 // Falta el comentario XML para el tipo o miembro visible de forma p�blica 'TextSample.Text'
        public string Text { get; private set; }
#pragma warning restore CS1591 // Falta el comentario XML para el tipo o miembro visible de forma p�blica 'TextSample.Text'

#pragma warning disable CS1591 // Falta el comentario XML para el tipo o miembro visible de forma p�blica 'TextSample.Equals(object)'
        public override bool Equals(object obj)
#pragma warning restore CS1591 // Falta el comentario XML para el tipo o miembro visible de forma p�blica 'TextSample.Equals(object)'
        {
            TextSample other = obj as TextSample;
            return other != null && Text == other.Text;
        }

#pragma warning disable CS1591 // Falta el comentario XML para el tipo o miembro visible de forma p�blica 'TextSample.GetHashCode()'
        public override int GetHashCode()
#pragma warning restore CS1591 // Falta el comentario XML para el tipo o miembro visible de forma p�blica 'TextSample.GetHashCode()'
        {
            return Text.GetHashCode();
        }

#pragma warning disable CS1591 // Falta el comentario XML para el tipo o miembro visible de forma p�blica 'TextSample.ToString()'
        public override string ToString()
#pragma warning restore CS1591 // Falta el comentario XML para el tipo o miembro visible de forma p�blica 'TextSample.ToString()'
        {
            return Text;
        }
    }
}