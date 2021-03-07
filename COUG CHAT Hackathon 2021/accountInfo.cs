using System;
using System.Collections.Generic;
using System.Text;

namespace COUG_CHAT_Hackathon_2021
{
    class accountInfo
    {
        private string mName;
        private string mGrad;
        private string mHobbies;
        private string mMajor;
        
        //constructor
        public accountInfo(string newName = "", string newGrad = "",
            string newHobbies = "", string newMajor = "")
        {
            mName = newName;
            mGrad = newGrad;
            mHobbies = newHobbies;
            mMajor =  newMajor; 
        }
        public void printInfo()
        {
            Console.WriteLine("Student Record: ");
            Console.WriteLine("\t" + mName);
            Console.WriteLine("\t" + mGrad);
            Console.WriteLine("\t" + mHobbies);
            Console.WriteLine("\t" + mMajor);
        }

        //getters
        public string getName()
        {
            return mName;
        }
        public string getGrad()
        {
            return mGrad;
        }
        public string getHobbies()
        {
            return mHobbies;
        }
        public string getMajor()
        {
            return mMajor;
        }

         //setters
        public void SetName(string copy)
        {
            mName = copy;
        }
        public void SetGrad(string copy)
        {
            mGrad = copy;
        }
        public void SetHobbies(string copy)
        {
            mHobbies = copy;
        }
        public void SetMajor(string copy)
        {
            mMajor = copy;
        }


    }
}