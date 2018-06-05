using CNAB240.BB.Model;
using System;
using System.ComponentModel;
using System.Reflection;

namespace FluentMapTxt
{
	/// <summary>
	/// Serves as the base class for all property mapping implementations.
	/// </summary>
	/// <typeparam name="TPropertyMap">The type of the property mapping.</typeparam>
	public abstract class PropertyMapBase<TPropertyMap> where TPropertyMap : class, IPropertyMap
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="T:Dapper.FluentMap.Mapping.PropertyMap"/> using
		/// the specified <see cref="T:System.Reflection.PropertyInfo"/> object representing the property to map.
		/// </summary>
		/// <param name="info">The <see cref="T:System.Reflection.PropertyInfo"/> object representing to the property to map.</param>
		protected PropertyMapBase(PropertyInfo info)
		{
			PropertyInfo = info;
		}

		public int Ordem { get; set; }
		public int Digitos { get; set; }
		public Formato Formato { get; set; }
		public string Instrucao { get; set; }
		public bool Brancos { get; set; }
		public string[] Escolha { get; set; }

		/// <summary>
		/// Gets a reference to the <see cref="System.Reflection.PropertyInfo"/> of this mapping.
		/// </summary>
		public PropertyInfo PropertyInfo { get; }

		public TPropertyMap NaOrdem(int ordem)
		{
			Ordem = ordem;
			return this as TPropertyMap;
		}

		public TPropertyMap ComFormato(Formato formato)
		{
			Formato = formato;
			return this as TPropertyMap;
		}

		public TPropertyMap ComInstrucao(string instrucao)
		{
			Instrucao = instrucao;
			return this as TPropertyMap;
		}

		public TPropertyMap ComBrancos(bool brancos)
		{
			Brancos = brancos;
			return this as TPropertyMap;
		}

		public TPropertyMap ComDigitos(int digitos)
		{
			Digitos = digitos;
			return this as TPropertyMap;
		}

		public TPropertyMap ComEscolhas(string[] escolhas)
		{
			Escolha = escolhas;
			return this as TPropertyMap;
		}

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