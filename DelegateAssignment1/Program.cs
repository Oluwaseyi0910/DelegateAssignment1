using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAssignment1
{
    /// <summary>
    /// This is the Predicate Class
    /// </summary>
    internal class Delegates1
    {
        public delegate bool Predicate(XClass x);

        void LambdaExpansion()
        {

            var likelyUsername = "Oluwaseyi";

            Predicate classwork = (XClass x) =>
            {
                if (x.UserName == likelyUsername)  //check if Username is equal to LikelyUsername
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };
        }
    }


    /// <summary>
    /// This is the property class
    /// </summary>
    class XClass
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }

        public string UserName { get; set; }

    }
}


