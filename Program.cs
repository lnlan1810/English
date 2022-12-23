using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace English
{
    class Program
    {
        static void Main()
        {
            int caseSwitch = new int();

            start:
            Console.WriteLine("What function would you like to perform? enter '1' or '2' ");

            caseSwitch = int.Parse(Console.ReadLine());

            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine("enter a passive sentence: ");
                    string stringToCheck = Console.ReadLine();

                    string ans = "a";

                    string[] stringArray = { "will be", "won't be", "will not be" };
                    string[] preSimple = { "am", "is", "are", "am not", "isn't", "aren't", "is not", "are not" };
                    string[] past = { "were", "was", "weren't", "wasn't", "were not", "was not" };
                    string[] pastPer = { "had been", "had not been" };
                    string[] modal = { "can be", "will be", "might be", "may be", "can not be", "will not be", "might not be", "may not be" };
                    string[] modalCon = { "could be being", "may be being", "must be being", "could not be being", "may not be being", "must not be being" };
                    string[] modalPer = { "could have been", "must have been", "could have not been", "must have not been" };
                    string[] presentPerfectPass = { "has been", "have been", "has not been", "have not been" };
                    string[] presentCont = { "am being", "is being", "are being", "am not being", "is not being", "are being" };
                    string[] pastCont = { "was being", "were being", "was not being", "were not being", "wasn't being", "weren't being" };
                    string[] presentPerCon = { "has been being", "have been being" };
                    string[] pastPerCon = { "had been being" };
                    string[] m = { "can", "could", "must", "might", "may" };

                //    string[] verb3 = { "ed", "read", "arisen", "awoken", "been", "borne", "become", "given"
                //, "begun", "broken", "brought", "broadcast" ,"built", "burnt", "bought", "cast"
                //,"caught", "chid", "chosen", "come", "cost", "crowed", "cut", "drawn", "driven", "eaten", "fed", "felt", "fought", "found"};

                    string[] verb3 = {"ed","abode","abided","arisen","awoken","been","borne","become","befallen","begun",
"beheld","bent","beset","bespoken","bid","bound","bled","blown","broken","bred","brought","broadcast","built","burnt",
                        "burned","bought","cast","caught","chid"," chidden"," chided","chosen","cloven","cleft","cleaved","cleaved","come","cost",
                        "crowed","cut","dealt",
"dug","dived","drawn","dreamt","dreamed","drunk","driven","dwelt","eaten","fallen","fed","felt","fought","found",
                        "fled","flung","flown","forborne","forbidden","forecast","forecasted","forseen","foretold",
                        "forgotten","forgiven","forsaken","frozen","got","gotten","gilt","gilded","girt","girded","given",
                        "gone","ground","grown","hung","heard","hove","heaved","hidden","hit","hurt","inlaid",
"input","inset","kept","knelt","kneeled","knit","knitted","known","laid","led","leapt","learnt",
"learned","left","lent","let","lain","lit","lighted","lost","made","meant","met","mislaid","misread",
"misspelt","mistaken","misundersood","mown","mowed","outbid","outdone","outgrown",
"output","outrun","outsold","overcome","overeaten","overflown","overhung","overheard","overlaid","overpaid","overrun","overseen",
                        "overshot","overslept","overtaken","overthrown","paid","proven","proved","put","read ",
"red","rebuilt","redone","remade","rent","repaid","resold","retaken","rewritten","rid","ridden","rung","risen","run","sawn","said","seen",
                        "sought","sold","sent","sewn","sewed","shaken","shorn","shed","shone","shot","shown"," showed",
                        "shrunk","shut","sung","sunk","sat","slain","slept","slid","slung","slunk","smelt","smitten","sown"," sewed","spoken","sped"," speeded","spelt",
                        " spelled","spent","spilt"," spilled","spun","spat","spoilt"," spoiled","spread","sprung","stood","stove"," staved","stolen","stuck","stung","stunk",
                        "strewn"," strewed","stridden","struck","strung","striven","sworn","swept","swollen"," swelled","swum","swung","taken","taught","torn","told","thought",
                        "thrown","thrust","trodden","trod","unbent","undercut","undergone","underlain","underpaid","undersold","understood","undertaken",
                        "underwritten","undone","unfrozen","unwound","upheld","upset","woken", "waked","waylaid","worn","woven"," weaved","wed"," wedded","wept",
                        "wet”,”wetted","won","wound","withdrawn","withheld","withstood","worked","wrung","written"
 };

                    ////!!!!!
                    ///
                    foreach (string x in m)
                    {
                        foreach (string y in verb3)
                        {
                            if (stringToCheck.Contains(x) && stringToCheck.Contains(y) && stringToCheck.Contains("be") && stringToCheck.Contains("being") == false)
                            {
                                ans = "modal simple Passive";

                            }
                        }
                    }

                    foreach (string x in m)
                    {
                        foreach (string y in verb3)
                        {
                            if (stringToCheck.Contains(x) && stringToCheck.Contains(y) && stringToCheck.Contains("be being") )
                            {
                                ans = "modal continuous Passive";

                            }
                        }
                    }

                    // could/ must + have been + v3 -> modal perfect simple

                    foreach (string x in stringArray)
                    {
                        foreach (string y in verb3)
                        {
                            if (stringToCheck.Contains(x) && stringToCheck.Contains(y) && stringToCheck.Contains("being")== false)
                            {
                                ans = "Future Simple Passive";
               
                            }
                        }
                    }

                    foreach (string x in preSimple)
                    {
                        //if (stringToCheck.Contains(x))
                        //{
                        //    Console.WriteLine("Present simple Passive");
                        //}
                        foreach (string y in verb3)
                        {
                            if (stringToCheck.Contains(x) && stringToCheck.Contains(y) && stringToCheck.Contains("being") == false)
                            {
                                ans = "Present simple Passive";

                            }
                        }
                    }
                  

                    foreach (string x in past)
                    {
                        //if (stringToCheck.Contains(x))
                        //{
                        //    Console.WriteLine("pass simple Passive");
                        //}

                        foreach (string y in verb3)
                        {
                            if (stringToCheck.Contains(x) && stringToCheck.Contains(y) && stringToCheck.Contains("being") == false  )
                            {
                                ans = "pass simple Passive";
                  
                            }
                        }
                    }

                    foreach (string x in modal)
                    {
                        foreach (string y in verb3)
                        {
                            if (stringToCheck.Contains(x) && stringToCheck.Contains(y) && stringToCheck.Contains("being") == false)
                            {
                                ans = "modal simple Passive";

                            }
                        }
                    }

                    foreach (string x in pastPer)
                    {
                        foreach (string y in verb3)
                        {
                            if (stringToCheck.Contains(x) && stringToCheck.Contains(y) && stringToCheck.Contains("being") == false)
                            {
                                ans = "past perfect Passive";

                            }
                        }
                    }

                    foreach (string x in modalCon)
                    {
                        foreach (string y in verb3)
                        {
                            if (stringToCheck.Contains(x) && stringToCheck.Contains(y))
                            {
                                ans = "modal continuous z";

                            }
                        }
                    }

                    foreach (string x in modalPer)
                    {
                        foreach (string y in verb3)
                        {
                            if (stringToCheck.Contains(x) && stringToCheck.Contains(y))
                            {
                                ans = "modal perfect simple Passive";

                            }
                        }
                    }

                    ///

                    foreach (string x in presentPerfectPass)
                    {
                        foreach (string y in verb3)
                        {
                            if (stringToCheck.Contains(x) && stringToCheck.Contains(y) && stringToCheck.Contains("being") == false)
                            {
                                ans = "Present perfect passive";

                            }
                        }
                    }

                    foreach (string x in presentCont)
                    {
                        foreach (string y in verb3)
                        {
                            if (stringToCheck.Contains(x) && stringToCheck.Contains(y))
                            {
                                ans = "Present Continuous Passive";

                            }
                        }
                    }

                    foreach (string x in pastCont)
                    {
                        foreach (string y in verb3)
                        {
                            if (stringToCheck.Contains(x) && stringToCheck.Contains(y))
                            {
                                ans = "Past Continuous Passive";

                            }
                        }
                    }

                    foreach (string x in presentPerCon)
                    {
                        foreach (string y in verb3)
                        {
                            if (stringToCheck.Contains(x) && stringToCheck.Contains(y))
                            {
                                ans = "Present perfect Continuous Passive";

                            }
                        }
                    }

                    foreach (string x in pastPerCon)
                    {
                        foreach (string y in verb3)
                        {
                            if (stringToCheck.Contains(x) && stringToCheck.Contains(y))
                            {
                                ans = "Past perfect Continuous Passive";

                            }
                        }
                    }

                    if (ans == "a")
                    {
                        Console.WriteLine("This is not a passive sentence");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine(ans);
                        Console.WriteLine();
                    }

                    break;


                case 2:
                    Console.WriteLine("enter the tense you want to give an example: \n" +
                   " enter 'future simple' or 'present simple' or 'pass simple' or \n" +
                   "'present continuous' or'pass continuous' or 'Modal passive'");
                    Console.WriteLine();

                    string stringsen = Console.ReadLine();

                    if(stringsen == "future simple")
                    {
                        Console.WriteLine("I will finish it tomorrow");
                        Console.WriteLine("->> It will be finished tomorrow.");
                        Console.WriteLine();
                    }

                    if (stringsen == "present simple")
                    {
                        Console.WriteLine("They make Fords in Cologne.");
                        Console.WriteLine("->> Fords are made in Cologne ");
                        Console.WriteLine();
                    }

                    if (stringsen == "pass simple")
                    {
                        Console.WriteLine("James Joyce wrote 'Dubliners'");
                        Console.WriteLine("->> 'Dubliners' was written by James Joyce.");
                        Console.WriteLine();
                    }

                    if (stringsen == "present continuous")
                    {
                        Console.WriteLine("Susan is cooking dinner.");
                        Console.WriteLine(" ->> Dinner is being cooked by Susan");
                        Console.WriteLine();
                    }

                    if (stringsen == "pass continuous")
                    {
                        Console.WriteLine("They were painting the house when I arrived.");
                        Console.WriteLine(" ->> The house was being painted when I arrived.");
                        Console.WriteLine();
                    }

                    if (stringsen == "Modal passive")
                    {
                        Console.WriteLine("An exam may be given by our Math teacher today.");
                        Console.WriteLine();
                    }

                    break;

                default:

                    Console.WriteLine("Error, invalid input");
                    goto start;
            }

            Console.WriteLine("For a new check, press 1, to close the program, press any number");
            Console.WriteLine();
            if (int.Parse(Console.ReadLine()) == 1) goto start;

        }
    }
}
