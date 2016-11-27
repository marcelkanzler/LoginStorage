using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_storage.DataManager
{
    class SearchManager
    {
        private Storage_Form storageForm;

        private int getSearchMode()
        {
            return this.storageForm.clbox_SearchMode.SelectedIndex;
        }

        public SearchManager(Storage_Form storageForm)
        {
            this.storageForm = storageForm;
        }

        public List<LoginFormular> GetMatchingLoginFormulars()
        {
            List<LoginFormular> loginList = this.storageForm.GetLoginList();

            if (loginList == null)
            {
                return null;
            }
            List<LoginFormular> matchingLogins = new List<LoginFormular>();
            String searchedString = this.storageForm.txtb_Search.Text;
            for (int i = 0; i < loginList.Count; i++)
            {
                LoginFormular loginFormular = loginList[i];
                String comparison = "";
                switch (getSearchMode())
                {

                    case 0:
                        comparison = loginFormular.Website;
                        break;
                    case 1:
                        comparison = loginFormular.EMail;
                        break;
                    case 2:
                        comparison = loginFormular.FirstName;
                        break;
                    case 3:
                        comparison = loginFormular.LastName;
                        break;
                    case 4:
                        comparison = loginFormular.Password;
                        break;
                    case 5:
                        comparison = loginFormular.Username;
                        break;
                }
                if (comparison.ToLower().Contains(searchedString.ToLower()))
                {
                    if (this.storageForm.cb_ShowPassword.Checked)
                    {
                        matchingLogins.Add(loginList[i]);
                    }
                    else
                    {
                        matchingLogins.Add(this.storageForm.GetHiddenPwLoginList()[i]);
                    }
                }
            }
            return matchingLogins;
        }

    }
}
