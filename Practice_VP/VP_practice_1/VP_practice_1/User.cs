using System;

namespace VP_practice_1
{
    public class User
    {
        private int _userId;
        private int _departmentId;
        private string _userUserName;
        private string _userPassword;
        private string _userName;
        private Gender _userGender;
        private string _userEmail;
        private RoleUser _userRole;

        //private Department _department; нужен если есть _departmentId?
        private Proposal[] _proposals;
        private Report[] _reports;
                

        public void UserLogin() { }
        public void AddProposal() { }
        public void ViewProposal() { }
        public void ConfirmProposal() { }
        public void CreateReports() { }
        public void ViewReports() { }
        public void UpdateDepartment() { }
    }
}
