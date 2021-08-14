using System;

namespace SPSCRUDWebApi.Areas.HelpPage.ModelDescriptions
{
    /// <summary>
    /// Use this attribute to change the name of the <see cref="ModelDescription"/> generated for a type.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum, AllowMultiple = false, Inherited = false)]
    public sealed class ModelNameAttribute : Attribute
    {
#pragma warning disable CS1591 // Falta el comentario XML para el tipo o miembro visible de forma pública 'ModelNameAttribute.ModelNameAttribute(string)'
        public ModelNameAttribute(string name)
#pragma warning restore CS1591 // Falta el comentario XML para el tipo o miembro visible de forma pública 'ModelNameAttribute.ModelNameAttribute(string)'
        {
            Name = name;
        }

#pragma warning disable CS1591 // Falta el comentario XML para el tipo o miembro visible de forma pública 'ModelNameAttribute.Name'
        public string Name { get; private set; }
#pragma warning restore CS1591 // Falta el comentario XML para el tipo o miembro visible de forma pública 'ModelNameAttribute.Name'
    }
}