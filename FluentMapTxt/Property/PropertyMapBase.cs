using fluentMapTxt.Model;
using System;
using System.ComponentModel;
using System.Reflection;

namespace fluentMapTxt
{
    /// <summary>
    /// Serves as the base class for all property mapping implementations.
    /// </summary>
    /// <typeparam name="TPropertyMap">The type of the property mapping.</typeparam>
    public abstract class PropertyMapBase<TPropertyMap> where TPropertyMap : class, IPropertyMap
    {
        protected PropertyMapBase(PropertyInfo info)
        {
            PropertyInfo = info;
        }

        //public int Ordem { get; set; }
        public object Value { get; set; }

        public int QuantidadeDigitos { get; set; }

        public Formato Formato { get; set; }

        public string ValorPadrao { get; set; }

        public bool Brancos { get; set; }

        public string DateTimeMascara { get; set; }

        //public string[] Escolha { get; set; }

        public char PadLeftPadrao { get; set; }

        /// <summary>
        /// Gets a reference to the <see cref="System.Reflection.PropertyInfo"/> of this mapping.
        /// </summary>
        public PropertyInfo PropertyInfo { get; }

        #region
        //public TPropertyMap NaOrdem(int ordem)
        //{
        //	Ordem = ordem;
        //	return this as TPropertyMap;
        //}

        //public TPropertyMap ComFormato(Formato formato)
        //{
        //	Formato = formato;
        //	return this as TPropertyMap;
        //}

        //public TPropertyMap ComValorPadrao(string valorPadrao)
        //{
        //	ValorPadrao = valorPadrao;
        //	return this as TPropertyMap;
        //}

        //public TPropertyMap ComBrancos(bool brancos)
        //{
        //	Brancos = brancos;
        //	return this as TPropertyMap;
        //}

        //public TPropertyMap ComDigitos(int digitos)
        //{
        //	QuantidadeDigitos = digitos;
        //	return this as TPropertyMap;
        //}

        //public TPropertyMap ComEscolhas(string[] escolhas)
        //{
        //	Escolha = escolhas;
        //	return this as TPropertyMap;
        //}
        #endregion

        #region EditorBrowsableStates

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override string ToString()
        {
            return base.ToString();
        }

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public new Type GetType()
        {
            return base.GetType();
        }

        #endregion EditorBrowsableStates
    }
}