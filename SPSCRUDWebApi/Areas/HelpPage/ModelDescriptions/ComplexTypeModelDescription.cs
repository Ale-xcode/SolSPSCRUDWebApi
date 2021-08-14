using System.Collections.ObjectModel;

namespace SPSCRUDWebApi.Areas.HelpPage.ModelDescriptions
{
#pragma warning disable CS1591 // Falta el comentario XML para el tipo o miembro visible de forma pública 'ComplexTypeModelDescription'
    public class ComplexTypeModelDescription : ModelDescription
#pragma warning restore CS1591 // Falta el comentario XML para el tipo o miembro visible de forma pública 'ComplexTypeModelDescription'
    {
#pragma warning disable CS1591 // Falta el comentario XML para el tipo o miembro visible de forma pública 'ComplexTypeModelDescription.ComplexTypeModelDescription()'
        public ComplexTypeModelDescription()
#pragma warning restore CS1591 // Falta el comentario XML para el tipo o miembro visible de forma pública 'ComplexTypeModelDescription.ComplexTypeModelDescription()'
        {
            Properties = new Collection<ParameterDescription>();
        }

#pragma warning disable CS1591 // Falta el comentario XML para el tipo o miembro visible de forma pública 'ComplexTypeModelDescription.Properties'
        public Collection<ParameterDescription> Properties { get; private set; }
#pragma warning restore CS1591 // Falta el comentario XML para el tipo o miembro visible de forma pública 'ComplexTypeModelDescription.Properties'
    }
}