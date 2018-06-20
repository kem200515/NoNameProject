
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLL.Implement
{
    public class BaseBLL<K, T>
    {
        public static K ConvertFromModel(T userModel)
        {
            K user = (K)Activator.CreateInstance(typeof(K)); ;
            var properties = typeof(T).GetProperties();
            foreach (var property in properties)
            {
                user.GetType().GetProperty(property.Name).SetValue(user, userModel.GetType().GetProperty(property.Name).GetValue(userModel, null), null);
            }
            return user;
        }
    }
}
