using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_ASM
{
    public class UserProfile
    {
        public string Name { get; set; }
    }
    public class Bai5
    {
            public string GetName(UserProfile profile)
            {
                if (profile == null)
                {
                    throw new NullReferenceException("Đối tượng hồ sơ không được phép null.");
                }

                return profile.Name;
            }
        
    }
}
