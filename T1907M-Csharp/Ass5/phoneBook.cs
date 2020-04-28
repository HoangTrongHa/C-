using System;
using System.Collections;
using System.Collections.Generic;

namespace buoi2.Ass5
{
    public class phoneBook : Phone
    {
        protected List<phoneNumber> phoneList;
        public override void insertPhone(string name, string phone)
        {
            foreach (phoneNumber p   in phoneList)
            {
                if (p.name.Equals(name))
                {
                    if (p.phone.Equals(phone))
                    {
                        return;
                    }
                    p.phone=p.phone +":" + phone;
                }
            }
        }

        public override void removePhone(string name)
        {
            foreach (phoneNumber p in phoneList)
            {
                if (p.name.Equals(name))
                {
                    phoneList.Remove(p);
                    return;
                }
            }
            
        }

        public override void updatePhone(string name, string newPhone)
        {
            foreach (phoneNumber VARIABLE in phoneList)
            {
                if (VARIABLE.name.Equals(name))
                {
                    VARIABLE.name = newPhone;
                }
            }
        }

        public override phoneNumber searchPhone(string name)
        {
            foreach (phoneNumber h in phoneList)
            {
                if (h.name.Equals(name))
                {
                    return h;
                }
            }

            return null;
        }
        public void show()
        {
            foreach (phoneNumber u in phoneList)
                
            {
                Console.WriteLine("Name:"+u.Name+"Phone:"+u.phone);
            }
        }
        
        
    }
}