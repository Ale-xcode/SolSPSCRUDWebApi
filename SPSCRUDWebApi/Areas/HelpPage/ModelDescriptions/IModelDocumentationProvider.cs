using System;
using System.Reflection;

namespace SPSCRUDWebApi.Areas.HelpPage.ModelDescriptions
{
#pragma warning disable CS1591 // Falta el comentario XML para el tipo o miembro visible de forma p�blica 'IModelDocumentationProvider'
    public interface IModelDocumentationProvider
#pragma warning restore CS1591 // Falta el comentario XML para el tipo o miembro visible de forma p�blica 'IModelDocumentationProvider'
    {
#pragma warning disable CS1591 // Falta el comentario XML para el tipo o miembro visible de forma p�blica 'IModelDocumentationProvider.GetDocumentation(MemberInfo)'
        string GetDocumentation(MemberInfo member);
#pragma warning restore CS1591 // Falta el comentario XML para el tipo o miembro visible de forma p�blica 'IModelDocumentationProvider.GetDocumentation(MemberInfo)'

#pragma warning disable CS1591 // Falta el comentario XML para el tipo o miembro visible de forma p�blica 'IModelDocumentationProvider.GetDocumentation(Type)'
        string GetDocumentation(Type type);
#pragma warning restore CS1591 // Falta el comentario XML para el tipo o miembro visible de forma p�blica 'IModelDocumentationProvider.GetDocumentation(Type)'
    }
}