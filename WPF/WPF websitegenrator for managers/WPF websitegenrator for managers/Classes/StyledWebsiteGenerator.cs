// See https://aka.ms/new-console-template for more information
using System;

namespace WPF_websitegenerator_for_managers
{
    /*
     * Här ärver vi egenskaper och metoder ifrån WebsiteGenerator för att kunna återanvända delar i vår StyledWebsiteGenerator
     */
    class StyledWebsiteGenerator : WebsiteGenerator
    {
        // En extra egenskap
        string color;

        /*
         * En utökad konstruktor.
         * Vi vill lägga in alla del egenskaper som behövs i base-klassen vi ärvde ifrån
         * Och också lägga in en färg (data) i vår nya egenskap
         */
        public StyledWebsiteGenerator(string className, string color, string[] messageToClass, string[] techniques) : base(className, messageToClass, techniques)
        {
            this.color = color;
        }

        /*
         * Vi skapar en egen version av printStart (override:ar den) för att kunna få resultatet vi önskar
         */
        override protected string printStart()
        {
            return "<!DOCTYPE html>\n<html>\n<head>\n<style>\np {color: " + this.color + ";}\n" +
                              "</style>\n</head>\n<body>\n<main>\n";
        }
    }
    ///*
    // * Data ifrån API
    // */
    //string[] techniques = { "   C#", "daTAbaser", "WebbuTVeCkling ", "clean Code   " };
    //string[] messagesToClass = { "Glöm inte att övning ger färdighet!", "Öppna boken på sida 257." };




}
