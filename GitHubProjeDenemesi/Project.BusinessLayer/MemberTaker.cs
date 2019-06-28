using Project.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Entity;

namespace Project.BusinessLayer
{
    public class MemberTaker
    {
        private DataCreater dataCreater;

        public MemberTaker()
        {
            dataCreater = new DataCreater();

        }

        public List<string> TakeProjectMembersNames()
        {
            List<string> memberNames = new List<string>();

            foreach (var projectMember in dataCreater.TakeData())
            {
                memberNames.Add(projectMember.MemberName);
            }

            return memberNames;
        }
    }
}
