using CNAB240.BB.Model;
using System.Reflection;

namespace FluentMapTxt
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

		/// <summary>
		/// Gets a value indicating wether the property should be ignored when mapping.
		/// </summary>
		int Ordem { get; set; }

		int Digitos { get; set; }
		Formato Formato { get; set; }
		string Instrucao { get; set; }
		bool Brancos { get; set; }
		string[] Escolha { get; set; }
	}
}