using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bcs.arcSpace.Business_Layer
{
    public static class BusinessLayer<T>
    {
      static public ObjectSaveType recordSaveType = ObjectSaveType.UpdateObject;

       public enum ObjectSaveType
       {
          InsertObject = 1,
          UpdateObject = 2
       }


       public static  T ReturnCurrentTypeObject(BindingSource bindingSource)
       {
          T obj;
          obj = (T) bindingSource.Current;
          return obj;
       }

    }
}
