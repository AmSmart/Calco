using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Linq;
using Android.Support.V4.Widget;


namespace Calco
{
    [Activity(Label = "Calco", MainLauncher = true, Icon = "@drawable/icon",ScreenOrientation =Android.Content.PM.ScreenOrientation.Landscape)]
    public class MainActivity : Activity
    {
        public string x ; 
         protected override void OnCreate(Bundle savedInstanceState)
           {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Main);
            EditText resultText = FindViewById<EditText>(Resource.Id.resultText);
            Button button0 = FindViewById<Button>(Resource.Id.button0);
            Button button1 = FindViewById<Button>(Resource.Id.button1);
            Button button2 = FindViewById<Button>(Resource.Id.button2);
            Button button3 = FindViewById<Button>(Resource.Id.button3);
            Button button4 = FindViewById<Button>(Resource.Id.button4);
            Button button5 = FindViewById<Button>(Resource.Id.button5);
            Button button6 = FindViewById<Button>(Resource.Id.button6);
            Button button7 = FindViewById<Button>(Resource.Id.button7);
            Button button8 = FindViewById<Button>(Resource.Id.button8);
            Button button9 = FindViewById<Button>(Resource.Id.button9);
            Button buttonClear = FindViewById<Button>(Resource.Id.buttonClear);
            Button buttonDot = FindViewById<Button>(Resource.Id.buttonDot);
            Button buttonDivide = FindViewById<Button>(Resource.Id.buttonDivide);
            Button buttonAdd = FindViewById<Button>(Resource.Id.buttonAdd);
            Button buttonAns = FindViewById<Button>(Resource.Id.buttonAns);
            Button buttonEquals = FindViewById<Button>(Resource.Id.buttonEquals);
            Button buttonMultiply = FindViewById<Button>(Resource.Id.buttonMultiply);
            Button buttonSubtract = FindViewById<Button>(Resource.Id.buttonSubtract);
            EditText questionText = FindViewById<EditText>(Resource.Id.questionText);
            Button buttonCREDITS = FindViewById<Button>(Resource.Id.buttonCREDITS);
            Button buttonSine = FindViewById<Button>(Resource.Id.buttonSine);
            Button buttonCosine = FindViewById<Button>(Resource.Id.buttonCosine);
            Button buttonTangent = FindViewById<Button>(Resource.Id.buttonTangent);
            Button buttonRoot = FindViewById<Button>(Resource.Id.buttonRoot);
            Button oBrac = FindViewById<Button>(Resource.Id.oBrac);
            Button cBrac = FindViewById<Button>(Resource.Id.cBrac);
            Button buttonHelp = FindViewById<Button>(Resource.Id.buttonHelp);
            Button bSwitch = FindViewById<Button>(Resource.Id.bSwitch);
            Button bPower = FindViewById<Button>(Resource.Id.bPower);
            

            bSwitch.Click += delegate { if (bSwitch.Text == "DRG") { bSwitch.Text = "RAD"; } else { bSwitch.Text = "DRG"; } };
                buttonClear.LongClick += delegate { try { questionText.Text = ""; resultText.Text = ""; } catch { } };
            bPower.Click += delegate { questionText.Text += "^"; }; 


                buttonClear.Click += delegate
                {
                    try
                    {
                        questionText.Text = questionText.Text.Substring(0, questionText.Text.Length - 1);
                    }
                    catch { } };
                string multiply = "*";
                button0.Click += delegate { if (resultText.Text.Length > 0) { questionText.Text = (button0.Text); resultText.Text = ""; } else { questionText.Text += (button0.Text); resultText.Text = ""; } };
                button1.Click += delegate { if (resultText.Text.Length > 0) { questionText.Text = (button1.Text); resultText.Text = ""; } else { questionText.Text += (button1.Text); resultText.Text = ""; } };
                button2.Click += delegate { if (resultText.Text.Length > 0) { questionText.Text = (button2.Text); resultText.Text = ""; } else { questionText.Text += (button2.Text); resultText.Text = ""; } };
                button3.Click += delegate { if (resultText.Text.Length > 0) { questionText.Text = (button3.Text); resultText.Text = ""; } else { questionText.Text += (button3.Text); resultText.Text = ""; } };
                button4.Click += delegate { if (resultText.Text.Length > 0) { questionText.Text = (button4.Text); resultText.Text = ""; } else { questionText.Text += (button4.Text); resultText.Text = ""; } };
                button5.Click += delegate { if (resultText.Text.Length > 0) { questionText.Text = (button5.Text); resultText.Text = ""; } else { questionText.Text += (button5.Text); resultText.Text = ""; } };
                button6.Click += delegate { if (resultText.Text.Length > 0) { questionText.Text = (button6.Text); resultText.Text = ""; } else { questionText.Text += (button6.Text); resultText.Text = ""; } };
                button7.Click += delegate { if (resultText.Text.Length > 0) { questionText.Text = (button7.Text); resultText.Text = ""; } else { questionText.Text += (button7.Text); resultText.Text = ""; } };
                button8.Click += delegate { if (resultText.Text.Length > 0) { questionText.Text = (button8.Text); resultText.Text = ""; } else { questionText.Text += (button8.Text); resultText.Text = ""; } };
                button9.Click += delegate { if (resultText.Text.Length > 0) { questionText.Text = (button9.Text); resultText.Text = ""; } else { questionText.Text += (button9.Text); resultText.Text = ""; } };
                buttonDot.Click += delegate { if (resultText.Text.Length > 0) { questionText.Text = (buttonDot.Text); resultText.Text = ""; } else { questionText.Text += (buttonDot.Text); resultText.Text = ""; } };
                buttonAdd.Click += delegate { questionText.Text += buttonAdd.Text; resultText.Text = ""; };
                buttonDivide.Click += delegate { questionText.Text += buttonDivide.Text; resultText.Text = ""; };
                buttonSubtract.Click += delegate { questionText.Text += buttonSubtract.Text; resultText.Text = ""; };
                buttonMultiply.Click += delegate { questionText.Text += multiply; resultText.Text = ""; };
                oBrac.Click += delegate { questionText.Text += oBrac.Text; };
                cBrac.Click += delegate { questionText.Text += cBrac.Text; };

            buttonEquals.Click += delegate
            {
                try { resultText.Text = (Parser.process(questionText.Text)).ToString(); }
                catch { new AlertDialog.Builder(this).SetMessage("Invalid use of Operator, Check the question.\n !!!!!").SetTitle("ERROR").Show(); }
                try { x = (Parser.process(questionText.Text)).ToString(); } catch { }

              //  resultText.Text = OurParser.TimothyAndSmartParser.DoCalc(questionText.Text);
              // new code to be implemented
            };
            

             buttonSine.Click += delegate {
                 try { if (bSwitch.Text == "DRG") { resultText.Text = (Math.Sin(Convert.D2R(double.Parse(questionText.Text)))).ToString(); } else { resultText.Text = Math.Sin(double.Parse(questionText.Text)).ToString(); } } catch { new AlertDialog.Builder(this).SetTitle("ERROR").SetMessage("Syntax Error\nInvalid Use of Functions. \nSee Help.").Show(); }};

             buttonCosine.Click += delegate {
                 try { if (bSwitch.Text == "DRG") { resultText.Text = (Math.Cos(Convert.D2R(double.Parse(questionText.Text)))).ToString(); } else { resultText.Text = Math.Cos(double.Parse(questionText.Text)).ToString(); } } catch { new AlertDialog.Builder(this).SetTitle("ERROR").SetMessage("Syntax Error\nInvalid Use of Functions. \nSee Help.").Show(); }};

             buttonTangent.Click += delegate {
                 try { if (bSwitch.Text == "DRG") { resultText.Text = (Math.Tan(Convert.D2R(double.Parse(questionText.Text)))).ToString(); } else { resultText.Text = Math.Tan(double.Parse(questionText.Text)).ToString(); } } catch { new AlertDialog.Builder(this).SetTitle("ERROR").SetMessage("Syntax Error\nInvalid Use of Functions. \nSee Help.").Show(); }};



             buttonRoot.Click += delegate { try { resultText.Text = (Math.Sqrt(double.Parse(questionText.Text))).ToString(); } catch { new AlertDialog.Builder(this).SetTitle("ERROR").SetMessage("Syntax Error\nInvalid Use of Functions. \nSee Help.").Show(); } };
            buttonAns.Click += delegate { if (resultText.Text.Length > 0) { questionText.Text = string.Copy(resultText.Text); } else { questionText.Text += x ; }  };



            buttonCREDITS.Click += delegate { new AlertDialog.Builder(this).SetMessage("The total credits of \"Smart Calculator(Calco)\" goes to God Almighty who made it a success. \n This App was created by Adebiyi Emmanuel Oluwagbemiga, the C.E.O and founder of SmartE Inc. \n Many thanks to MSDN for giving me the mathematical expression parser and also to my parents, six sibblings, two brother in laws(brothers actually) and my two nephews for all their support in making this a success. \n      BIG THANKS").SetTitle("CREDITS").Show(); };
            buttonHelp.Click += delegate { new AlertDialog.Builder(this).SetTitle("Help").SetMessage("1. To remove a newly inputed digit, click \"DEL\".\n2. To totally remove all inputed digits, press and hold \"DEL\".\n3. To use scientific operators, press digit before clicking the function and never vice versa in order to avoid an error message.\n3. Whenever you are using the parenthesis, do not assume that any number placed before or after it signifies multiplication. Always put signs between numbers and parenthesis.\n ENJOY YOUR CALCULATIONS!").Show(); };
           





        }
    }
    
}

