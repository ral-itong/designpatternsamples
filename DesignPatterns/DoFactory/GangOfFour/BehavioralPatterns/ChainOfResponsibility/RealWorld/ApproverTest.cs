﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DoFactory.GangOfFour.BehavioralPatterns.ChainOfResponsibility.RealWorld
{
    public class ApproverTest
    {
        public void Test()
        {
            Console.WriteLine();

            Approver larry = new Director();
            Approver sam = new VicePresident();
            Approver tammy = new President();

            larry.SetSuccessor(sam);
            sam.SetSuccessor(tammy);

            Purchase p = new Purchase(2034, 350.00, "Assets");
            larry.ProcessRequest(p);

            p = new Purchase(2035, 32590.10, "Project X");
            larry.ProcessRequest(p);

            p = new Purchase(2036, 122100.00, "Project Y");
            larry.ProcessRequest(p);
        }
    }
}
