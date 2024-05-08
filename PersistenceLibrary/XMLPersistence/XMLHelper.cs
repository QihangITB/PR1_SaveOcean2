using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ObjectLibrary;
using static System.Collections.Specialized.BitVector32;

namespace PersistenceLibrary.XMLPersistence
{
    public class XMLHelper
    {
        private const string DefaultStringValue = "";
        private const int DefaultIntValue = 0;

        public static void CreateGamesDataXML(Player player,Rescue rescue, int userAction, int finalAG, int finalExp)
        {
            string path = "../../../Files/XML/games_data.xml";

            string action = userAction == 1 ? "Heal in the current location" : "Move to a medical center";

            XDocument xmlDoc = new XDocument(
                new XElement("games_data",
                    new XElement("game",
                        new XElement("player",
                            new XElement("name", player.Name),
                            new XElement("role", player.Role),
                            new XElement("experience", player.Experience)
                            ),
                        new XElement("rescue",
                            new XElement("code", rescue.Code),
                            new XElement("date", rescue.Date),
                            new XElement("animal",
                                new XElement("id", rescue.Family?.Id),
                                new XElement("name", rescue.Family?.Name),
                                new XElement("superFamily", rescue.Family?.SuperFamily),
                                new XElement("species", rescue.Family?.Species),
                                new XElement("weight", rescue.Family?.Weight)
                            ),
                            new XElement("affectationGrade", rescue.AffectationGrade),
                            new XElement("location", rescue.Location)
                        ),
                        new XElement("userAction", action),
                        new XElement("finalAffectationGrade", finalAG),
                        new XElement("finalPlayerExperience", finalExp)
                    )
                )
            );
            xmlDoc.Save(path);
        }

        public static void AddGamesDataXML(Player player, Rescue rescue, Animal animal, int userAction, int finalAG, int finalExp)
        {
            string path = "../../../Files/XML/games_data.xml";

            string action = userAction == 1 ? "Heal in the current location" : "Move to a medical center";

            XDocument xmlDoc = XDocument.Load(path);

            XElement newGameData = new XElement("game",
                        new XElement("player",
                            new XElement("name", player.Name),
                            new XElement("role", player.Role),
                            new XElement("experience", player.Experience)
                            ),
                        new XElement("rescue",
                            new XElement("code", rescue.Code),
                            new XElement("date", rescue.Date),
                            new XElement("animal",
                                new XElement("id", animal.Id),
                                new XElement("name", animal.Name),
                                new XElement("superFamily", animal.SuperFamily),
                                new XElement("species", animal.Species),
                                new XElement("weight", animal.Weight)
                            ),
                            new XElement("affectationGrade", rescue.AffectationGrade),
                            new XElement("location", rescue.Location)
                        ),
                        new XElement("userAction", action),
                        new XElement("finalAffectationGrade", finalAG),
                        new XElement("finalPlayerExperience", finalExp)
                    );

            xmlDoc.Root?.Add(newGameData);
            xmlDoc.Save(path);
        }

        public static void DeleteGamesDataXML()
        {
            string path = "../../../Files/XML/games_data.xml";
            File.Delete(path);
        }

        public static List<Rescue> GetRescueList()
        {
            string path = "../../../Files/XML/games_data.xml";

            XDocument xmlDoc = XDocument.Load(path);

            var rescues = from rescue in xmlDoc.Descendants("rescue")
                          select new Rescue(
                              (string?)rescue.Element("code") ?? DefaultStringValue,
                              (string?)rescue.Element("date") ?? DefaultStringValue,
                              new Animal(
                                  (int?)rescue.Element("animal")?.Element("id") ?? DefaultIntValue,
                                  (string?)rescue.Element("animal")?.Element("name") ?? DefaultStringValue,
                                  (string?)rescue.Element("animal")?.Element("superFamily") ?? DefaultStringValue,
                                  (string?)rescue.Element("animal")?.Element("species") ?? DefaultStringValue,
                                  (float?)rescue.Element("animal")?.Element("weight") ?? DefaultIntValue
                              ),
                              (int?)rescue.Element("affectationGrade") ?? DefaultIntValue,
                              (string?)rescue.Element("location") ?? DefaultStringValue
                          );
            return rescues.ToList();
        }
    }
}
