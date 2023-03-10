using System;
using System.Resources;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace LanchoneteProvaLab.ConsoleApp
{
    internal class Idioma
    {
        private readonly ResourceManager rm;
        private readonly CultureInfo ci;

        public Idioma(string idioma)
        {
            rm = new ResourceManager("LanchoneteProvaLab.ConsoleApp.Resources.String", Assembly.GetExecutingAssembly());
            ci = CultureInfo.CreateSpecificCulture(idioma);
        }

        public string GetMensagem(string chave)
        {
            return rm.GetString(chave, ci);
        }
    }
}
