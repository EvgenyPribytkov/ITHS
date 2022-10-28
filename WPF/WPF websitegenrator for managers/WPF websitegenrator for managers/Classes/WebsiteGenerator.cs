using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_websitegenerator_for_managers
{
    /*
     * Vi skapar vår WebsiteGenerator klass, med denna kan vi skapa objekt senare
     * Klassen innehåller data och behavior 
     */
    class WebsiteGenerator : Website
    {

        /*
         * De olika egenskaperna (datat) i varje objekt
         */
        string[] messagesToClass, techniques;
        string className;
        string kurser = "";

        /*
         * En konstruktor som tillåter oss att lägga in egen data i objektens egenskaper
         */
        public WebsiteGenerator(string className, string[] messageToClass, string[] techniques)
        {
            this.className = className;
            this.messagesToClass = messageToClass;
            this.techniques = techniques;
        }

        /*
         * Flera olika metoder för att utföra diverse funktionalitet
         * virtual = tillåter oss att override:a (göra egen version utav) metoden i ärvda klasser
         */
        virtual protected string printStart()
        {
            string start = "<!DOCTYPE html>\n<html>\n<body>\n<main>\n";
            return start;
        }
        string printWelcome(string className, string[] message)
        {
            string welcome = $"<h1> Välkomna {className}! </h1>";

            string welcomeMessage = "";

            foreach (string msg in message)
            {
                welcomeMessage += $"\n<p><b> Meddelande: </b> {msg} </p>";
            }

            return welcome + welcomeMessage;
        }
        string printKurser()
        {
            string kurser = courseGenerator(this.techniques);
            return kurser;
        }
        string printEnd()
        {
            string end = "</main>\n</body>\n</html>";
            return end;
        }

        public string printPage()
        {

            return printStart() + printWelcome(this.className, this.messagesToClass) + printKurser() + printEnd(); ;
        }

        /*
         * En utility metod
         */
        string courseGenerator(string[] techniques)
        {

            foreach (string technique in techniques)
            {
                string tmp = technique.Trim();
                kurser += "<p>" + tmp[0].ToString().ToUpper() + tmp.Substring(1).ToLower() + "</p>\n";
            }

            return kurser;
        }
    }
}