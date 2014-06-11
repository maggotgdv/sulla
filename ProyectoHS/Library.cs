using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Windows.Forms;
using System.Drawing;

namespace ProyectoHS
{
    public class Observer
    {
        private delegate void ColorEventHandler(string _color);
        private event ColorEventHandler ColorChangedEvent;
        private TextBox txt;

        public Observer(TextBox _txt)
        {
            this.ColorChangedEvent += new ColorEventHandler(Observer_ColorChangedEvent);
            this.txt = _txt;
        }

        private void OnChange(string _color)
        {
            if (ColorChangedEvent != null)
            {
                ColorChangedEvent(_color);
            }
        }

        public void Update(string _color)
        {
            OnChange(_color);
        }

        private void Observer_ColorChangedEvent(string _color)
        {
            switch (_color)
            {
                case "cama1":
                    txt.BackColor = Color.Red;
                    txt.Text = "Ocupado";
                    break;
                case "cama2":
                    txt.BackColor = Color.Red;
                    txt.Text = "Ocupado";
                    break;
                case "cama3":
                    txt.BackColor = Color.Red;
                    txt.Text = "Ocupado";
                    break;
                case "v1":
                    txt.BackColor = Color.Green;
                    txt.Text = "Libre";
                    break;
                case "v2":
                    txt.BackColor = Color.Green;
                    txt.Text = "Libre";
                    break;
                case "v3":
                    txt.BackColor = Color.Green;
                    txt.Text = "Libre";
                    break;
            }
        }
    }
    //Clase subject para la Dependency
    public class Subject
    {
        ArrayList arrObs = new ArrayList();
        private delegate void NotifyHandler(string _color);
        private event NotifyHandler NotifyEvent;

        public Subject()
        {
            this.NotifyEvent += new NotifyHandler(Notify);
        }

        public void UpdateClient(string _color)
        {
            OnNotify(_color);
        }

        private void OnNotify(string _color)
        {
            if (NotifyEvent != null)
            {
                NotifyEvent(_color);
            }
        }

        private void Notify(string _color)
        {
            for (int i = 0; i < arrObs.Count; i++)
            {
                Observer obs = (Observer)arrObs[i];
                obs.Update(_color);
            }
        }

        public void RegisterClient(Observer obs)
        {
            arrObs.Add(obs);
        }
    }
}