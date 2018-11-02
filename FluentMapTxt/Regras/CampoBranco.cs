using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fluentMapTxt.Domain.Core.MapperTXT
{
    public class CampoBranco : IRegraCampo
    {
        public CampoBranco(IPropertyMap propertyMap)
        {
            this.PropertyMap = propertyMap;
        }

        public IPropertyMap PropertyMap { get; private set; }

        public bool PossoExecutar()
        {
            return PropertyMap.Brancos;
        }

        public string Executa(string valor)
        {
            return "".PadLeft(PropertyMap.QuantidadeDigitos, ' ');
        }
    }

    public class CampoValorPadrao : IRegraCampo
    {
        public CampoValorPadrao(IPropertyMap propertyMap)
        {
            this.PropertyMap = propertyMap;
        }

        public IPropertyMap PropertyMap { get; private set; }

        public string Executa(string valorCampo)
        {
            return PropertyMap.ValorPadrao.PadLeft(PropertyMap.QuantidadeDigitos, PropertyMap.PadLeftPadrao).Substring(0, PropertyMap.QuantidadeDigitos);
        }

        public bool PossoExecutar()
        {
            return !string.IsNullOrEmpty(PropertyMap.ValorPadrao);
        }
    }

    public class CampoPadrao : IRegraCampo
    {
        public CampoPadrao(IPropertyMap propertyMap)
        {
            this.PropertyMap = propertyMap;
        }

        public IPropertyMap PropertyMap { get; private set; }

        public string Executa(string valorCampo)
        {
            return valorCampo.PadLeft(PropertyMap.QuantidadeDigitos, PropertyMap.PadLeftPadrao).Substring(0, PropertyMap.QuantidadeDigitos);
        }

        public bool PossoExecutar()
        {
            return true;
        }
    }

    public class CampoDateTimeMascara : IRegraCampo
    {
        public CampoDateTimeMascara(IPropertyMap propertyMap)
        {
            this.PropertyMap = propertyMap;
        }

        public IPropertyMap PropertyMap { get; private set; }

        public string Executa(string valorCampo)
        {
            DateTime data;
            if (DateTime.TryParse(valorCampo, CultureInfo.InvariantCulture, DateTimeStyles.None, out data))
            {
                return data.ToString(PropertyMap.DateTimeMascara);
            }

            throw new Exception("Campo não é uma data válida");
        }

        public bool PossoExecutar()
        {
            return !string.IsNullOrEmpty(PropertyMap.DateTimeMascara);
        }


    }
}
