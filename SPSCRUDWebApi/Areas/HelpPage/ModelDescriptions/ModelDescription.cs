using System;

namespace SPSCRUDWebApi.Areas.HelpPage.ModelDescriptions
{
    /// <summary>
    /// Describes a type model.
    /// </summary>
    public abstract class ModelDescription
    {
#pragma warning disable CS1591 // Falta el comentario XML para el tipo o miembro visible de forma p�blica 'ModelDescription.Documentation'
        public string Documentation { get; set; }
#pragma warning restore CS1591 // Falta el comentario XML para el tipo o miembro visible de forma p�blica 'ModelDescription.Documentation'

#pragma warning disable CS1591 // Falta el comentario XML para el tipo o miembro visible de forma p�blica 'ModelDescription.ModelType'
        public Type ModelType { get; set; }
#pragma warning restore CS1591 // Falta el comentario XML para el tipo o miembro visible de forma p�blica 'ModelDescription.ModelType'

#pragma warning disable CS1591 // Falta el comentario XML para el tipo o miembro visible de forma p�blica 'ModelDescription.Name'
        public string Name { get; set; }
#pragma warning restore CS1591 // Falta el comentario XML para el tipo o miembro visible de forma p�blica 'ModelDescription.Name'
    }
}