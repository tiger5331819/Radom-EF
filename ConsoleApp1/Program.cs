using System;

namespace ConsoleApp1
{
    class NewMailEvent:EventArgs
    {
        public int i;
        public string s;
        public NewMailEvent(int a,string c) { i = a;s = c; }
    }
    delegate void NewMailEventHandler(object sender, NewMailEvent e);
    class MailManager
    {
        public event NewMailEventHandler NewMail;
        public virtual void OnNewMail(NewMailEvent e)
        {
            NewMail?.Invoke(this, e);
        }
        public void SimulateNewMail(int i,string s)
        {
            NewMailEvent e = new NewMailEvent(i, s);
            OnNewMail(e);
        }
    }
    class Fax
    {
        public Fax(MailManager m)
        {
            m.NewMail += new NewMailEventHandler(Fax_NewMail);
        }
        void Fax_NewMail(object o,NewMailEvent e)
        {
            Console.WriteLine("Fax's EventMessage is {0},'{1}'", e.i, e.s);
        }
        public void Unregister(MailManager m)
        {
            m.NewMail -=new NewMailEventHandler(Fax_NewMail);
        }
    }
    class Print
    {
        public Print(MailManager m)
        {
            m.NewMail += new NewMailEventHandler(Print_NewMail);
        }
        void Print_NewMail(object o, NewMailEvent e)
        {
            Console.WriteLine("Print's EventMessage is {0},'{1}'", e.i, e.s);
        }
        public void Unregister(MailManager m)
        {
            m.NewMail -=new NewMailEventHandler(Print_NewMail);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MailManager mm = new MailManager();
            Fax f = new Fax(mm);
            Print p = new Print(mm);
            mm.SimulateNewMail(123, "su");
        }
    }
}
