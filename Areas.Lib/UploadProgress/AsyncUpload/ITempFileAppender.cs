// Generated by Reflector from D:\eConsular\src\Areas\Lib\RadWebUI\Areas.Lib.UploadProgress.dll
namespace Areas.Lib.UploadProgress.AsyncUpload
{
    using System;

    public interface ITempFileAppender
    {
        void AppendTo(string fullPath);

        int AppendedContentLength { get; }
    }
}
