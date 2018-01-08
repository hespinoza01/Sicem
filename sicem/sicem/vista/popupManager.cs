using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Transitions;

namespace sicem.vista
{
    class popupManager
    {
        public int contador
        {
            get;
            set;
        }

        List<popup> l = new List<popup>();

        public popupManager()
        {

        }

        public void showCheck(string msj)
        {
            contador += 1;
            popup p = new popup("", contador, popup.AlertType.check);
            l.Add(p);
            new Thread(new ThreadStart(manage)).Start();
        }

        private void manage()
        {
            Thread.Sleep(6600);
            if(l.Count > 0) {
                l.RemoveAt(0);
                for (int i=0; i<l.Count; i++)
                {
                    Transition.run(l[i], "Top", l[i].Top + l[i].Height, new TransitionType_EaseInEaseOut(150));
                    //Thread.Sleep(150);
                }
                contador--;
            }
        }
    }
}
