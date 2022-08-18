using System;
using static System.Console;
using System.Collections.Generic;
using System.Text;

namespace QUTChampionship
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int fee = 30;
            int participantNum;
            string name;
            while (true)
            {
                WriteLine("*************************Task a******************************");
                WriteLine("Input number of participants");
                participantNum = int.Parse(ReadLine());
                if (participantNum > 0 && participantNum < 40)
                {

                    Athelete[] participantList = new Athelete[participantNum];

                    WriteLine("**********************Task c ****************************");
                    // methods
                    for (int i = 0; i < participantList.Length; i++)
                    {
                        WriteLine("\n input information for participant {0}", i + 1);
                        WriteLine("Input name of participants");
                        name = ReadLine();
                        string[] events = new string[10];
                        Athelete aParticipant = new Athelete(name, events);
                        participantList[i] = aParticipant;
                        //aParticipant.Display();

                    }
                    WriteLine("*****************Task d**************************");
                    WriteLine("Events Catagories are :");
                    WriteLine("T     Tennis");
                    WriteLine("B     Badminton");
                    WriteLine("S     Tennis");
                    WriteLine("R     Running");
                    WriteLine("O     Other");
                    WriteLine("List of all participants\n");
                    for (int i = 0; i < participantList.Length; i++)
                    {
                        participantList[i].Display();
                    }
                    WriteLine("       ");
                    WriteLine("**************************taskb*********************");
                    WriteLine("\n per participant fee ${0} >>", fee);
                    double totalfee = fee * participantNum;
                    WriteLine("total fee {0} >>", totalfee);

                    WriteLine("*************************Task e***********************");
                    for (int i = 0; i < participantList.Length; i++)
                    {
                        participantList[0].checkevent();
                    }

                }
                else
                {
                    WriteLine("\n Please enter number of participants between 0 to 40 inclusive >>");
                    participantNum = int.Parse(ReadLine());
                    continue;
                }
                break;


            }
        }

    }
}