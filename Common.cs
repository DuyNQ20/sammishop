using Sammishop.Models;
using System.Collections.Generic;

namespace Sammishop
{
    public class Common
    {
        public static List<Order> ShowOrderList(List<Order> listOrder)
        {
            var codeOld = "";
            var list = new List<Order>();
            foreach (var item in listOrder)
            {
                var codeNew = item.Code;
                if (codeNew != codeOld)
                {
                    list.Add(item);
                }
                else
                {

                }
                codeOld = codeNew;
            }
            return list;
        }
    }
}
