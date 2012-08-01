﻿namespace Areas.Lib.HttpModules.FileUploadHelper
{
    using System.IO;
    using System.Web;
    using System.Web.Script.Serialization;

    public sealed class RadProgressContext : ProgressData
    {
        private RadProgressContext()
        {
        }

        private static RadProgressContext GetProgressContext(HttpContext context)
        {
            return (context.Application["RadProgressContext" + RadUploadContext.GetUploadUniqueIdentifier(context)] as RadProgressContext);
        }

        private ProgressData GetProgressData()
        {
            RadUploadContext current = RadUploadContext.GetCurrent(HttpContext.Current);
            if ((current != null) && !current.UploadComplete)
            {
                return current.GetProgressData();
            }
            return null;
        }

        public static void RemoveProgressContext(HttpContext context)
        {
            context.Application.Remove("RadProgressContext" + RadUploadContext.GetUploadUniqueIdentifier(context));
        }

        public override void Serialize(TextWriter writer)
        {
            ProgressData progressData = this.GetProgressData();
            if (progressData == null)
            {
                base.Serialize(writer);
            }
            else
            {
                progressData.Serialize(writer);
            }
        }

        public void Serialize(TextWriter writer, bool isJSON)
        {
            if (!isJSON)
            {
                this.Serialize(writer);
            }
            else
            {
                ProgressData progressData = this.GetProgressData();
                if (progressData == null)
                {
                    base.Serialize(writer);
                }
                else
                {
                    JavaScriptSerializer serializer = new JavaScriptSerializer();
                    writer.Write(serializer.Serialize(progressData));
                }
            }
        }

        private static RadProgressContext SetProgressContext(HttpContext context)
        {
            RadProgressContext context2 = new RadProgressContext();
            context.Application["RadProgressContext" + RadUploadContext.GetUploadUniqueIdentifier(context)] = context2;
            return context2;
        }

        public static RadProgressContext Current
        {
            get
            {
                RadProgressContext progressContext = GetProgressContext(HttpContext.Current);
                if (progressContext == null)
                {
                    progressContext = SetProgressContext(HttpContext.Current);
                }
                return progressContext;
            }
        }
    }

}