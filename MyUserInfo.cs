using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamir.SharpSsh.jsch;

namespace Simple_Inventory
{
    class MyUserInfo : UserInfo
    {
        /// <summary>
        /// Holds the user password
        /// </summary>
        private String passwd;

        /// <summary>
        /// Returns the user password
        /// </summary>
        public String getPassword() { return passwd; }

        /// <summary>
        /// Prompt the user for a Yes/No input
        /// </summary>
        public bool promptYesNo(String str)
        {
            return true;
        }

        /// <summary>
        /// Returns the user passphrase (passwd for the private key file)
        /// </summary>
        public String getPassphrase() { return null; }

        /// <summary>
        /// Prompt the user for a passphrase (passwd for the private key file)
        /// </summary>
        public bool promptPassphrase(String message) { return true; }

        /// <summary>
        /// Prompt the user for a password
        /// </summary>
        public bool promptPassword(String message) { return true; }

        /// <summary>
        /// Shows a message to the user
        /// </summary>
        public void showMessage(String message) { }
    }
}
