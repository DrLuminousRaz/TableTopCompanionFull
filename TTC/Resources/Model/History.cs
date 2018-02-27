using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite;

namespace TTC.Resources.Model
{
    
        
        class History : BaseModel
    { 
        public int Id { get; set; }
        public string DateAndTime { get; set; }
            public string Dice1Type { get; set; }
            public int Result1 { get; set; }
            /*   public string Dice2Type { get; set; }
               public int Result2 { get; set; }
               public string Dice3Type { get; set; }
               public int Result3 { get; set; }
               public string Dice4Type { get; set; }
               public int Result4 { get; set; }
               public string Dice5Type { get; set; }
               public int Result5 { get; set; }
               public string Dice6Type { get; set; }
               public int Result6 { get; set; }
               public string Dice7Type { get; set; }
               public int Result7 { get; set; }
               public string Dice8Type { get; set; }
               public int Result8 { get; set; }
               public string Dice9Type { get; set; }
               public int Result9 { get; set; }
               public string Dice10Type { get; set; }
               public int Result10 { get; set; }
               public string Dice11Type { get; set; }
               public int Result11 { get; set; }
               public string Dice12Type { get; set; }
               public int Result12 { get; set; }
               public string Dice13Type { get; set; }
               public int Result13 { get; set; }
               public string Dice14Type { get; set; }
               public int Result14 { get; set; }
               public string Dice15Type { get; set; }
               public int Result15 { get; set; }
               public string Dice16Type { get; set; }
               public int Result16 { get; set; }
               public string Dice17Type { get; set; }
               public int Result17 { get; set; }
               public string Dice18Type { get; set; }
               public int Result18 { get; set; }
               public string Dice19Type { get; set; }
               public int Result19 { get; set; }
               public string Dice20Type { get; set; }
               public int Result20 { get; set; }
               */

            public History(string dateTime, string type, int res)
            {
            DateAndTime = dateTime;
            Dice1Type = type;
            Result1 = res;
            
            
            }





            public History()
            {

            }

        public override string ToString()
        {
            return string.Format($"{DateAndTime}   Dice: {Dice1Type}   Result: {Result1}");
        }

    }
    public abstract class BaseModel
    {

        [PrimaryKey, AutoIncrement]
        public int PrimaryKey { get; set; }

    }
}
