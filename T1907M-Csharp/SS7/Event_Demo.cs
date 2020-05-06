using System;

namespace buoi2.SS7
{
    public delegate void ButtonHander(string msg);
    public class Event_Demo
    {
        public event ButtonHander OnClick;

        public void clickButton()
        {
            Console.WriteLine("Da bam vao day");
            DateTime now = DateTime.Now;
            if (OnClick == null)
            {
                OnClick += show;
            }

            OnClick("Avs" + now);
        }

        public static void show(string msg)
        {
         Console.WriteLine(msg);   
        }
        
    }
}