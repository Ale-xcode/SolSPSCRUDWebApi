using System;

namespace SPSCRUDWebApi.Areas.HelpPage.ModelDescriptions
{
    /// <summary>
    /// Describes a type model.
    /// </summary>
    public abstract class ModelDescription
    {
#pragma warning disable CS1591 // Falta el comentario XML para el tipo o miembro visible de forma pública 'ModelDescription.Documentation'
        public string Documentation { get; set; }
#pragma warning restore CS1591 // Falta el comentario XML para el tipo o miembro visible de forma pública 'ModelDescription.Documentation'

#pragma warning disable CS1591 // Falta el comentario XML para el tipo o miembro visible de forma pública 'ModelDescription.ModelType'
        public Type ModelType { get; set; }
#pragma warning restore CS1591 // Falta el comentario XML para el tipo o miembro visible de forma pública 'ModelDescription.ModelType'

#pragma warning disable CS1591 // Falta el comentario XML para el tipo o miembro visible de forma pública 'ModelDescription.Name'
        public string Name { get; set; }
#pragma warning restore CS1591 // Falta el comentario XML para el tipo o miembro visible de forma pública 'ModelDescription.Name'
    }
}