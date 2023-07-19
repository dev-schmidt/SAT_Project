using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation
{
    //internal class Roles_Adheres
    //{
    //}

    //Example that adheres to the ISP:

    public interface ILeader
    {
        void EvaluateProject();

        void CreateTicket();

        void AssignTicket();
    }

    public interface IProgrammer
    {
        void WorkOnTicket();
    }


    public class TeamLeader : ILeader, IProgrammer
    {
        public void EvaluateProject()
        {
            //Code to evaluate a project
        }

        public void CreateTicket()
        {
            //Code to create a ticket
        }

        public void AssignTicket()
        {
            //Code to assign a ticket
        }

        public void WorkOnTicket()
        {
            //Code to work on a ticket
        }
    }

    public class OrgManager : ILeader
    {
        public void EvaluateProject()
        {
            //Code to evaluate a project
        }

        public void CreateTicket()
        {
            //Code to create a ticket
        }

        public void AssignTicket()
        {
            //Code to assign a ticket
        }
    }

    public class Programmer : IProgrammer
    {
        public void WorkOnTicket()
        {
            //Code to work on a ticket
        }
    }
}
