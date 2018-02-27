using Android.App;
using Android.Widget;
using Android.OS;
using System;
using System.IO;
using SQLite;
using System.Collections.Generic;
using System.Linq;
using TTC.Resources.Model;

namespace TTC
{
    
    [Activity(Label = "TTC", MainLauncher = true)]
    public class MainActivity : Activity
    {
        public string dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "dbHistory.db3");


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            string folder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            int res;
            var spinner = FindViewById<Spinner>(Resource.Id.spinner);
            Button button = FindViewById<Button>(Resource.Id.button);
            Button getbutton = FindViewById<Button>(Resource.Id.getButton);
            var text = FindViewById<TextView>(Resource.Id.result);
            string dateTime = DateTime.Now.ToString();
            spinner.Prompt = "Choose A Dice";
            var adapter = ArrayAdapter.CreateFromResource(this, Resource.Array.Counter, Android.Resource.Layout.SimpleSpinnerItem);
            adapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            spinner.Adapter = adapter;
            
            var db = new SQLiteConnection(dbPath);
            db.CreateTable<History>();
            


            button.Click += delegate
            {
                
                switch (spinner.SelectedItem.ToString())
                {

                    case "D4":

                        res = Roll.Roll.D4();
                        text.Text = "D4: " + res.ToString();
                        History d4 = new History(dateTime, "D4", res);
                        db.Insert(d4);
                        break;
                    case "D6":

                        res = Roll.Roll.D6();
                        text.Text = "D6: " + res.ToString();
                        History d6 = new History(dateTime, "D6", res);
                        db.Insert(d6);
                        break;
                    case "D8":

                        res = Roll.Roll.D8();
                        text.Text = "D8: " + res.ToString();
                        History d8 = new History(dateTime, "D8", res);
                        db.Insert(d8);
                        break;
                    case "D10":
                        res = Roll.Roll.D10();
                        text.Text = "D10: " + res.ToString();
                        History d10 = new History(dateTime, "D10", res);
                        db.Insert(d10);
                        break;
                    case "D10 Percentile":
                        res = Roll.Roll.D10Pecentile();
                        text.Text = "D10 Percentile: " + res.ToString();
                        History d10p = new History(dateTime, "D10 Percentile", res);
                        db.Insert(d10p);
                        break;
                    case "D12":
                        res = Roll.Roll.D12();
                        text.Text = "D12: " + res.ToString();
                        History d12 = new History(dateTime, "D12", res);
                        db.Insert(d12);
                        break;
                    case "D20":
                        res = Roll.Roll.D20();
                        text.Text = "D20: " + res.ToString();
                        History d20 = new History(dateTime, "D20", res);
                        db.Insert(d20);
                        break;


                }
            };

            getbutton.Click += delegate
            {
                TextView disp = FindViewById<TextView>(Resource.Id.textViewHistory);
                disp.Text = "";
                var conn = new SQLiteConnection(dbPath);
                var table = conn.Table<History>();
                
                foreach(var item in table)
                {
                    History myHistory = new History(item.DateAndTime, item.Dice1Type, item.Result1);
                    disp.Text += myHistory + "\n";
                    
                }
                
                
            };
        }

        

    }
    }


