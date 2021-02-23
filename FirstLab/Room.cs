using System;
using System.Collections.Generic;


namespace Lecture
{
    public class Room
    {
        private List<IListener> listeners = new List<IListener>();
        public void Say(string voice)
        {
            Distrib(voice);
        }
        public void Enter(IListener l)
        {
            Console.WriteLine($"{l.GetType()} came into the room");
            listeners.Add(l);
        }
        public void Exit(IListener l)
        {
            Console.WriteLine($"{l.GetType()} came out of the room");
            listeners.Remove(l);
        }
        void Distrib(string voice)
        {
            foreach (var l in listeners)
            {
                l.Listen(voice);
            }
        }
    }
}