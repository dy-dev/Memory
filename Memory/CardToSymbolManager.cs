using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory
{
    class CardToSymbolManager
    {
        //Store information about card ID / Category / Symbol to display
        static Dictionary<Category, List<Symbol>> CardToSymbol;

        static public void InitManager()
        {
            CardToSymbol = new Dictionary<Category, List<Symbol>>();
            //Aller chercher dans le dossier ressource qu'il faudra coller à coté de l'executable
            //les images qui vont servir au jeu et remplir ce dictionnaire
            foreach (var item in Enum.GetValues(typeof(Category)))
            {
                var myList = new List<Symbol>();
                if (Directory.Exists($"./ressources/{item}"))
                {
                    foreach (var file in Directory.GetFiles($"./ressources/{item}"))
                    {
                        MemoryStream ms = new MemoryStream();
                        using (FileStream filestream = new FileStream(file, FileMode.Open, FileAccess.Read))
                            filestream.CopyTo(ms);
                        myList.Add(new Symbol() { Category = (Category)item, ImageContentMemoryStream = ms });
                    }
                }
                CardToSymbol[(Category)item] = myList;
            }

        }


        public static Symbol GetSymbolFromCard(Category p_cat, Card p_Card)
        {
            if (CardToSymbol.ContainsKey(p_cat))
            {
                var listSymbol = CardToSymbol[p_cat];
                return listSymbol[p_Card.CardID];
            }
            return null;
        }
    }
}
