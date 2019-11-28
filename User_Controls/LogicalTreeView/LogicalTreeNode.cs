using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bcs.LogicalTree
{
   enum NodeType
   {
      RootNode,
      PassThroughNode,
      TerminalNode
   }


   class LogicalTreeNode : TreeNode
   {
      private ComboBox m_ComboBox = new ComboBox();
      private NodeType nodeType;

      public ComboBox ComboBox
      {
         get
         {
            this.m_ComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            return this.m_ComboBox;
         }
         set
         {
            this.m_ComboBox = value;
            this.m_ComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
         }
      }

      public NodeType NodeType
      {
         get
         {
            return nodeType;
         }

         set
         {
            nodeType = value;
         }
      }


   }
}
