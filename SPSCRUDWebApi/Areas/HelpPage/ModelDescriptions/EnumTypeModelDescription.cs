using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SPSCRUDWebApi.Areas.HelpPage.ModelDescriptions
{
#pragma warning disable CS1591 // Falta el comentario XML para el tipo o miembro visible de forma pública 'EnumTypeModelDescription'
    public class EnumTypeModelDescription : ModelDescription
#pragma warning restore CS1591 // Falta el comentario XML para el tipo o miembro visible de forma pública 'EnumTypeModelDescription'
    {
#pragma warning disable CS1591 // Falta el comentario XML para el tipo o miembro visible de forma pública 'EnumTypeModelDescription.EnumTypeModelDescription()'
        public EnumTypeModelDescription()
#pragma warning restore CS1591 // Falta el comentario XML para el tipo o miembro visible de forma pública 'EnumTypeModelDescription.EnumTypeModelDescription()'
        {
            Values = new Collection<EnumValueDescription>();
        }

#pragma warning disable CS1591 // Falta el comentario XML para el tipo o miembro visible de forma pública 'EnumTypeModelDescription.Values'
        public Collection<EnumValueDescription> Values { get; private set; }
#pragma warning restore CS1591 // Falta el comentario XML para el tipo o miembro visible de forma pública 'EnumTypeModelDescription.Values'
    }
}