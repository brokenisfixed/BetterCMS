﻿using System;
using System.Collections.Generic;
using System.Reflection;
using System.Web.Mvc;

using BetterCms.Core.Environment.Assemblies;

namespace BetterCms.Core.Mvc.Extensions
{
    /// <summary>
    /// Default controller extensions implementation.
    /// </summary>
    public class DefaultControllerExtensions : IControllerExtensions
    {
        /// <summary>
        /// Assembly loader contract.
        /// </summary>
        private readonly IAssemblyLoader assemblyLoader;

        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultControllerExtensions" /> class.
        /// </summary>
        /// <param name="assemblyLoader">The assembly loader.</param>
        public DefaultControllerExtensions(IAssemblyLoader assemblyLoader)
        {
            this.assemblyLoader = assemblyLoader;
        }

        /// <summary>
        /// Determines whether type is controller type.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns>
        /// <c>true</c> if type is controller type; otherwise, <c>false</c>.
        /// </returns>
        public bool IsControllerType(Type type)
        {
            return typeof(IController).IsAssignableFrom(type) &&
                   type != null && type.IsPublic && type.IsClass && !type.IsAbstract &&
                   type.Name.EndsWith("Controller", StringComparison.OrdinalIgnoreCase);
        }

        /// <summary>
        /// Gets the name of the controller.
        /// </summary>
        /// <param name="controllerType">Type of the controller.</param>
        /// <returns>Controller name.</returns>
        public string GetControllerName(Type controllerType)
        {
            string controllerName = controllerType.Name;
            int lastIndex = controllerName.LastIndexOf("Controller", StringComparison.OrdinalIgnoreCase);
            if (lastIndex > 0)
            {
                return controllerName.Remove(lastIndex);
            }

            return null;
        }

        /// <summary>
        /// Gets the controller types from given assembly.
        /// </summary>
        /// <param name="assembly">The assembly.</param>
        /// <returns>Controller types from assembly.</returns>
        public IEnumerable<Type> GetControllerTypes(Assembly assembly)
        {
            var types = assemblyLoader.GetLoadableTypes(assembly);

            if (types != null)
            {
                foreach (var type in types)
                {
                    if (IsControllerType(type))
                    {
                        yield return type;
                    }
                }
            }            
        }

        /// <summary>
        /// Gets all unique action names from given controller type.
        /// </summary>
        /// <param name="controllerType">Type of the controller.</param>
        /// <returns>Controller action names.</returns>
        public IEnumerable<string> GetControllerActions(Type controllerType)
        {
            var methods = controllerType.GetMethods();
            var actions = new List<string>();
            foreach (var method in methods)
            {
                if (method.IsPublic && method.ReturnParameter != null && typeof(ActionResult).IsAssignableFrom(method.ReturnParameter.ParameterType) && !actions.Contains(method.Name))
                {
                    actions.Add(method.Name);
                }
            }

            return actions;
        }

        /// <summary>
        /// Gets all actions from given controller type.
        /// </summary>
        /// <typeparam name="TController">The type of the controller.</typeparam>
        /// <returns>Controller action names.</returns>
        public IEnumerable<string> GetControllerActions<TController>() where TController : ControllerBase
        {
            var controllerType = typeof(TController);
            return GetControllerActions(controllerType);
        }
    }
}
