using Project.BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitHubProjeDenemesi
{
    public partial class UIProjectMembersShow : Form
    {
        public UIProjectMembersShow()
        {
            InitializeComponent();
        }

        private void UIProjectMembersShow_Load(object sender, EventArgs e)
        {
            MemberTaker memberTaker = new MemberTaker();

            List<string> projectMembersName = memberTaker.TakeProjectMembersNames();

            foreach (var projectMemberName in projectMembersName)
            {
                MessageBox.Show(projectMemberName);
            }
        }
    }
}
