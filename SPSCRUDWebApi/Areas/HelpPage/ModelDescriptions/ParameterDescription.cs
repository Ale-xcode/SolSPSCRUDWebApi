using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SPSCRUDWebApi.Areas.HelpPage.ModelDescriptions
{
#pragma warning disable CS1591 // Falta el comentario XML para el tipo o miembro visible de forma p�blica 'ParameterDescription'
    public class ParameterDescription
#pragma warning restore CS1591 // Falta el comentario XML para el tipo o miembro visible de forma p�blica 'ParameterDescription'
    {
#pragma warning disable CS1591 // Falta el comentario XML para el tipo o miembro visible de forma p�blica 'ParameterDescription.ParameterDescription()'
        public ParameterDescription()
#pragma warning restore CS1591 // Falta el comentario XML para el tipo o miembro visible de forma p�blica 'ParameterDescription.ParameterDescription()'
        {
            Annotations = new Collection<ParameterAnnotation>();
        }

#pragma warning disable CS1591 // Falta el comentario XML para el tipo o miembro visible de forma p�blica 'ParameterDescription.Annotations'
        public Collection<ParameterAnnotation> Annotations { get; private set; }
#pragma warning restore CS1591 // Falta el comentario XML para el tipo o miembro visible de forma p�blica 'ParameterDescription.Annotations'

#pragma warning disable CS1591 // Falta el comentario XML para el tipo o miembro visible de forma p�blica 'ParameterDescription.Documentation'
        public string Documentation { get; set; }
#pragma warning restore CS1591 // Falta el comentario XML para el tipo o miembro visible de forma p�blica 'ParameterDescription.Documentation'

#pragma warning disable CS1591 // Falta el comentario XML para el tipo o miembro visible de forma p�blica 'ParameterDescription.Name'
        public string Name { get; set; }
#pragma warning restore CS1591 // Falta el comentario XML para el tipo o miembro visible de forma p�blica 'ParameterDescription.Name'

#pragma warning disable CS1591 // Falta el comentario XML para el tipo o miembro visible de forma p�blica 'ParameterDescription.TypeDescription'
        public ModelDescription TypeDescription { get; set; }
#pragma warning restore CS1591 // Falta el comentario XML para el tipo o miembro visible de forma p�blica 'ParameterDescription.TypeDescription'
    }
}