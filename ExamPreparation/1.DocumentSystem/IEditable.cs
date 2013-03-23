using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.DocumentSystem
{
    /// <summary>
    /// Implemented by documents that can be edited
    /// </summary>
    public interface IEditable
    {
        void ChangeContent(string newContent);
    }
}
