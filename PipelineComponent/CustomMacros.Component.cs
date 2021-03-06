using System;
using System.Collections.Generic;
using System.Resources;
using System.Drawing;
using System.Collections;
using System.Reflection;
using System.ComponentModel;
using System.Text;
using System.Xml;
using System.Xml.Xsl;
using System.IO;
using Microsoft.BizTalk.Streaming;
using Microsoft.BizTalk.Message.Interop;
using Microsoft.BizTalk.Component.Interop;
using Microsoft.BizTalk.ScalableTransformation;
using Microsoft.XLANGs.RuntimeTypes;
using BizTalkComponents.Utils;

namespace BizTalkComponents.PipelineComponents
{
    /// <summary>
    ///  Transforms original message stream using streaming scalable transformation via provided map specification.
    /// </summary>
    public partial class CustomMacros : Microsoft.BizTalk.Component.Interop.IComponent, IComponentUI, IPersistPropertyBag
    {
      

        #region IBaseComponent Members

        public string Description
        {
            get { return "Pipeline Component that adds new sendport macros."; }
        }

        public string Name
        {
            get { return "SendPort Macros"; }
        }

        public string Version
        {
            get { return "1.0.0"; }
        }

        #endregion

        #region IComponentUI Members

        public IntPtr Icon
        {
            get
            {
                return new IntPtr();
            }
        }

        public IEnumerator Validate(object projectSystem)
        {
            return ValidationHelper.Validate(this, false).GetEnumerator();
        }

        #endregion



        public void GetClassID(out Guid classID)
        {
            classID = new Guid("45A34C0D-8D73-45fd-960D-DB365CD56371");
        }

        public void InitNew()
        {
            throw new Exception("The method or operation is not implemented.");
        }

       
    }

}
