using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Agent
    {
        private string _agentID;
      
        public string AgentID
        {
            get { return _agentID; }
            set { _agentID = value; }
        }

        private string _agentName;
        public string AgentName
        {
            get { return _agentName;
            }
            set {
                _agentName= value;
               }
        }

        public Agent(string AgentID, string AgentName)
        {
            this._agentID = AgentID;
            this._agentName = AgentName;
        }
    }
}
