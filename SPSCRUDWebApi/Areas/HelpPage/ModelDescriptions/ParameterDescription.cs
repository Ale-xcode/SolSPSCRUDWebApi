using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SPSCRUDWebApi.Areas.HelpPage.ModelDescriptions
{
#pragma warning disable CS1591 // Falta el comentario XML para el tipo o miembro visible de forma pública 'ParameterDescription'
    public class ParameterDescription
#pragma warning restore CS1591 // Falta el comentario XML para el tipo o miembro visible de forma pública 'ParameterDescription'
    {
#pragma warning disable CS1591 // Falta el comentario XML para el tipo o miembro visible de forma pública 'ParameterDescription.ParameterDescription()'
        public ParameterDescription()
#pragma warning restore CS1591 // Falta el comentario XML para el tipo o miembro visible de forma pública 'ParameterDescription.ParameterDescription()'
        {
            Annotations = new Collection<ParameterAnnotation>();
        }

#pragma warning disable CS1591 // Falta el comentario XML para el tipo o miembro visible de forma pública 'ParameterDescription.Annotations'
        public Collection<ParameterAnnotation> Annotations { get; private set; }
#pragma warning restore CS1591 // Falta el comentario XML para el tipo o miembro visible de forma pública 'ParameterDescription.Annotations'

#pragma warning disable CS1591 // Falta el comentario XML para el tipo o miembro visible de forma pública 'ParameterDescription.Documentation'
        public string Documentation { get; set; }
#pragma warning restore CS1591 // Falta el comentario XML para el tipo o miembro visible de forma pública 'ParameterDescription.Documentation'

#pragma warning disable CS1591 // Falta el comentario XML para el tipo o miembro visible de forma pública 'ParameterDescription.Name'
        public string Name { get; set; }
#pragma warning restore CS1591 // Falta el comentario XML para el tipo o miembro visible de forma pública 'ParameterDescription.Name'

#pragma warning disable CS1591 // Falta el comentario XML para el tipo o miembro visible de forma pública 'ParameterDescription.TypeDescription'
        public ModelDescription TypeDescription { get; set; }
#pragma warning restore CS1591 // Falta el comentario XML para el tipo o miembro visible de forma pública 'ParameterDescription.TypeDescription'
    }
}