using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
namespace QUTChampionship
{
    class Athelete
    {

        //private int praticipantID;
        private string participantName;
        private string[] participantEvent;
        //private string[] checkevent;
        public static string[] eventCodes = { "T", "B", "S", "R", "O" };
        public static String[] eventName = { "Tennis", "Badminton", "Swimming", "Running", "Other" };
        //private int fee;
        //private object participantNumber;

        //default constructor
        public class Athlete
        {

        }
        public Athelete(string name, string[] events)
        {

            participantName = name;
            InputArray(events);
            
            participantEvent = events;
            

        }
        //methods
        public static void InputArray(string[] arrayEvents)
        {
            WriteLine("total number of events are as follows :");
            WriteLine("T     Tennis");
            WriteLine("B     Badminton");
            WriteLine("S     Tennis");
            WriteLine("R     Running");
            WriteLine("O     Other");
            while (true)
            {
                Write("\n Please input number of events for participation >> ");
                int eventofParticipants = Convert.ToInt32(ReadLine());
                if (eventofParticipants < 6)
                {

                    for (int count = 0; count < eventofParticipants; count++)
                    {




                        Write("\n Please input event code >>", count + 1);
                        string eventInput = ReadLine();
                        bool correctEvent = false;
                        int x = 0;
                        while ((correctEvent == false) && (x < eventCodes.Length))
                        {
                            if (eventInput == eventCodes[x])
                            {
                                correctEvent = true;
                                arrayEvents[count] = eventInput;

                            }
                            else
                            {
                                x++;
                            }
                            if (correctEvent == false && x == eventCodes.Length)
                            {
                                WriteLine("Please input correct event code!>>");
                                eventInput = ReadLine();
                                x = 0;
                            }
                        }


                    }
                }
                else
                {
                    WriteLine("\n please enter valid number between 0 to 5 ");
                    eventofParticipants = int.Parse(ReadLine());
                    continue;
                }
                break;
            }
        }
        public void checkevent()
        {
                Write("\n enter input to check participants >> ");
                string checkInput = ReadLine();
                bool correctInput = false;
                int x = 0;
                while ((correctInput == false) && (x < eventCodes.Length))
                {
                    if (checkInput == eventCodes[x])
                    {
                        correctInput = true;
                        WriteLine("\n Participant Name {0}", participantName);

                    }
                    else
                    {
                        x++;
                    }
                    if (correctInput == false && x == eventCodes.Length)
                    {
                        WriteLine("please input correct code >>");
                        checkInput = ReadLine();
                        x = 0;
                    }
                }
            
        }


        public void Display()
        {
            
            WriteLine("\n Participant Name {0}", participantName);
            //foreach (char aParticipants in participantName)
            //Write("{0,10}", aParticipants);
         
            WriteLine("\n List of Events ");
            foreach (string aEvent in participantEvent)
                Write("{0,10}", aEvent);
            
            WriteLine("\n events ");
            
            foreach (string aevent in eventName)
                Write("{0,10}", aevent);
            
            
        }

    }
}

