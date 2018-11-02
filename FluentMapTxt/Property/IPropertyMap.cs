﻿using fluentMapTxt.Model;
using System.Reflection;

namespace fluentMapTxt
{
    /// <summary>
    /// Represents the mapping of a property.
    /// </summary>
    public interface IPropertyMap
    {
        /// <summary>
        /// Gets the <see cref="T:System.Reflection.PropertyInfo"/> object for the current property.
        /// </summary>
        PropertyInfo PropertyInfo { get; }

        object Value { get; }

        /// <summary>
        /// Gets a value indicating wether the property should be ignored when mapping.
        /// </summary>
        //int Ordem { get; set; }

        int QuantidadeDigitos { get; set; }

        Formato Formato { get; set; }

        string ValorPadrao { get; set; }

        bool Brancos { get; set; }

        string DateTimeMascara { get; set; }

        //string[] Escolha { get; set; }

        char PadLeftPadrao { get; set; }
    }
}