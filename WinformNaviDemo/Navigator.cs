using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WinformNaviDemo
{
    public class Navigator
    {
        private static Dictionary<string, NavPage> _pages = new Dictionary<string, NavPage>();
        private const string NS = "WinformNaviDemo";

        public static Form FirstPage()
        {
            return _pages[_pages.Keys.First()].Current;
        }
        public static void Go()
        {
            try
            {
                var fileName = Config.SettingFile();

                var settingStr = File.ReadAllText(fileName);
                var pages = JsonConvert.DeserializeObject<IList<NavJsonPage>>(settingStr);

                if (pages.Count > 0)
                {
                    
                    var assemb = Assembly.GetExecutingAssembly();
                    foreach (var navPage in pages)
                    {
                        //var current = assemb.GetType($"{NS}.{navPage.Current}");

                        ////should always new
                        Form frmCurrent = GetOrAdd(navPage.Current, assemb);
                        if (frmCurrent == null)
                        {
                            SettingError();
                            return;
                        }

                        Button btnPre = null;
                        if (!string.IsNullOrWhiteSpace(navPage.PreviousBtn))
                        {
                            //var pre = assemb.GetType($"{NS}.{navPage.Previous}");
                            //Form frmPre = _pages.ContainsKey(navPage.Previous) 
                            //    ? _pages[navPage.Previous].Current
                            //    : (Form)Activator.CreateInstance(pre);
                            Form frmPre = GetOrAdd(navPage.Previous, assemb);
                            if (frmPre == null)
                            {
                                SettingError();
                                return;
                            }

                            btnPre = frmCurrent.Controls.Find(navPage.PreviousBtn, true).FirstOrDefault() as Button;
                            if (btnPre == null)
                            {
                                SettingError();
                                return;
                            }


                            btnPre.Click += (sender, args) =>
                            {
                                frmCurrent.Hide();
                                frmPre.Show();
                            };
                            
                        }


                        Button btnNext = null;
                        if (!string.IsNullOrWhiteSpace(navPage.NextBtn))
                        {
                            //var next = assemb.GetType($"{NS}.{navPage.Next}");

                            //Form frmNext = _pages.ContainsKey(navPage.Next)
                            //    ? _pages[navPage.Next].Current
                            //    :(Form)Activator.CreateInstance(next);
                            Form frmNext = GetOrAdd(navPage.Next, assemb);
                            if (frmNext == null)
                            {
                                SettingError();
                                return;
                            }

                            btnNext = frmCurrent.Controls.Find(navPage.NextBtn, true).FirstOrDefault() as Button;
                            if (btnNext == null)
                            {
                                SettingError();
                                return;
                            }

                            btnNext.Click += (sender, args) =>
                            {
                                frmCurrent.Hide();
                                frmNext.Show();
                            };
                           
                        }

                    }
                }
            }
            catch (Exception ex)
            {
              SettingError();
            }
           
        }

        private static Form GetOrAdd(string formName, Assembly assemb)
        {
            var key = formName;
            if (!_pages.ContainsKey(key))
            {
                _pages.Add(key,new NavPage(){});
            }

            if (_pages[key].Current == null)
            {
                var ns = assemb.GetType($"{NS}.{key}");
                var newFrm = (Form) Activator.CreateInstance(ns);
                _pages[key].Current = newFrm;
            }
            else
            {
                //do nothing. no update for form
            }
            
            return _pages[key].Current;
        }

        private static void SettingError()
        {
            MessageBox.Show("Please check setting file");
        }

    }
}
