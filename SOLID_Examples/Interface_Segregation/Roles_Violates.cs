using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation
{
    //internal class Roles_Violates
    //{
    //}

    //This principle specifically applies to interfaces.
    //Classes that implement interfaces should not be forced
    //to implement methods they don't use. So, instead of
    //writing one large interface with many methods, it is
    //generally preferred to write many small interfaces with
    //related methods.

    //Assume that we have 3 roles: Team Lead, Manager, Programmer

    //Things they can do:
    // - Evaluate Projects
    // - Create Tickets
    // - Assign Tickets
    // - Work on tickets

    //Team Lead can do everything
    //Manager cannot work on tickets
    //Programmers can ONLY work on tickets

    //Example that violates ISP:

    public interface ILead
    {
        void EvaluateProjects();

        void CreateTicket();

        void AssignTicket();

        void WorkOnTicket();
    }


    public class TeamLead : ILead
    {
        public void EvaluateProject()
        {

        }

        public void CreateTicket()
        {

        }

        public void AssignTicket()
        {

        }

        public void WorkOnTicket()
        {

        }
    }

    public class Manager : ILead
    {
        public void EvaluateProject()
        {

        }

        public void CreateTicket()
        {

        }

        public void AssignTicket()
        {

        }

        //Manager shouldn't have to implement this -- it's not one of their duties.
        //But, since it's required by the ILead interface, we have to have something
        //here for WorkOnTicket().

        public void WorkOnTicket()
        {
            throw new Exception("Manager cannot work on tickets.");
        }
    }

}
    
