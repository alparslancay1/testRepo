using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Entity;

namespace Project.DataAccessLayer
{
    public class DataCreater
    {
        private List<ProjectMember> ProjectMembers { get; set; }

        public DataCreater()
        {
            ProjectMembers = new List<ProjectMember>();
            ProjectMember projectMember = new ProjectMember();
            projectMember.MemberName = "Alparslan ÇAY";

            ProjeMusteri projeMusteri = new ProjeMusteri();
            projeMusteri.MemberName = "Proje SAhibi";
            projeMusteri.verilenFiyat = 100.3;

            //If you want to join our project, do new operations like above operations.
            /*Example
             * ProjectMember projectMember = new ProjectMember();
             * projectMember.MemberName = "YourName YourSurname";
             */
            ProjectMembers.Add(projectMember);
            ProjectMembers.Add(projeMusteri);
        }

        public List<ProjectMember> TakeData() { return ProjectMembers; }
    }
}
