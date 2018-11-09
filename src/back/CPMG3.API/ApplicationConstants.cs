using System;
namespace CPMG3.API
{
    public struct ApplicationConstants
    {
        public struct Documentation
        {
            public const string API_NAME = "Campus Party MG 2018";

            public const string API_CURRENT_VERSION = "v1";

            public const string API_DESCRIPTION = "Esta API tem como objetivo o propósito didático como base para o Workshop da Campus Party 2018 em Belo Horizonte, Minas Gerais.";

            public const string API_CONTACT_NAME = "Albert Sena Tanure";

            public const string API_CONTACT_EMAIL = "tanure@live.com";

            public const string API_TERMS = "Livre para uso com créditos ao autor";
        }

        public struct Services
        {
            public const string API_BASE_ADDRESS = "https://api.github.com";
        }

        public struct FeatureToggle
        {
            public const string LISTAR_REPOSITORIOS = "listarRepositorios";
        }
    }
}
