﻿using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        private DateTime testDate;
        public DateTime dateAdded
        {
            get
            {
                return dateAdded;
            }
            set
            {
                date = value;
            }
        }
        private Int32 idToFind;
        public int id {
            get
            {
                // this line of code sends data out of the property
                return idToFind;
            }
            set
            {
                // this line of code allows data into the property
                idToFind = value;
            } 
        }

        private string nameToFind;
        public string name {
            get 
            {
                return name;
            }
            set
            {
                nameToFind = value;
            }
                }

        private string passToFind;
        public string pass { 
            get
            {
                return pass;
            }
            set
            {
                passToFind = value;
            }
               }

        private string mailToFind;
        public string email { 
            get
            {
                return email;
            }
            set
            {
                mailToFind = value;
            }
                }

        public bool maybe;
        public bool exists { 
            get
            {
                return exists;
            }
            set
            {
                maybe = value;
            } 
        }

        public bool Find(int id)
        {
            idToFind = 3401;
            testDate = new DateTime("21/03/2110");
            nameToFind = "Shpaximirr Maxan";
            mailToFind = "shpaximir@mail.com";
            passToFind = "asdfgh12";
            maybe = true;
        }

        public string GetUserData()
        {
            string data = this.dateAdded.ToString() + "\n" 
                + this.name + "\n" + this.pass + "\n" 
                + this.email + "\n" + this.exists + "\n";
            return data;
        }
    }
}