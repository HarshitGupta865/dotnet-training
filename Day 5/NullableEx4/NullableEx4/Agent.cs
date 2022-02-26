using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableEx4
{
    internal class Agent
    {
        public int agentNo;
        public string agentName;
        public int agentStatus;
        public int ? businessAmount;

        public override string ToString()
        {
            return "Agent No. = " + agentNo + ", agentName = " + agentName + ", businessAmount = " + businessAmount + ", Status = " + agentStatus;
        }

    }
}
