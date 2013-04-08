// Generated by Reflector from D:\eConsular\src\Areas\Lib\RadWebUI\Areas.Lib.UploadProgress.dll
namespace Areas.Lib.UploadProgress.Upload
{
    using System;
    using System.Text;

    internal class RequestField
    {
        private byte[] _bufferedBytes = new byte[0];
        private bool _complete;
        private int _completeBodyBytes;
        private Encoding _encoding;
        private FieldHeaderInfo _header;
        private bool _headerComplete;
        private byte[] _headerData = new byte[0];
        private static byte[] _headerEnd = new byte[] { 13, 10, 13, 10 };

        public RequestField(Encoding encoding)
        {
            this._encoding = encoding;
        }

        public void AddData(byte[] data, bool lastData)
        {
            if (!this._headerComplete)
            {
                int num = ByteComparer.IndexOf(_headerEnd, this._bufferedBytes, data, 0);
                int headerBytesToStore = (num < 0) ? data.Length : num;
                this._headerComplete = num >= 0;
                int length = this._bufferedBytes.Length;
                this.AddHeaderData(data, headerBytesToStore, !this._headerComplete);
                if (this._headerComplete)
                {
                    this.Header = this.CreateHeader(this._headerData);
                    this._completeBodyBytes += ((data.Length - num) - _headerEnd.Length) + length;
                }
            }
            else
            {
                this._completeBodyBytes += data.Length;
            }
            this._complete = lastData;
        }

        private void AddHeaderData(byte[] data, int headerBytesToStore, bool preserveNewBuffer)
        {
            if (headerBytesToStore != 0)
            {
                bool flag = (this._headerData.Length == 0) && ((this._bufferedBytes.Length + headerBytesToStore) <= _headerEnd.Length);
                int length = this._bufferedBytes.Length;
                if (flag)
                {
                    Array.Resize<byte>(ref this._bufferedBytes, this._bufferedBytes.Length + headerBytesToStore);
                    Array.Copy(data, 0, this._bufferedBytes, length, headerBytesToStore);
                }
                else
                {
                    int destinationIndex = this._headerData.Length;
                    int newSize = destinationIndex + headerBytesToStore;
                    int num4 = _headerEnd.Length;
                    if (preserveNewBuffer && (length != num4))
                    {
                        newSize -= num4;
                    }
                    Array.Resize<byte>(ref this._headerData, newSize);
                    if (this._bufferedBytes.Length > 0)
                    {
                        if (headerBytesToStore <= this._bufferedBytes.Length)
                        {
                            Array.Copy(this._bufferedBytes, 0, this._headerData, destinationIndex, headerBytesToStore);
                            return;
                        }
                        Array.Copy(this._bufferedBytes, 0, this._headerData, destinationIndex, this._bufferedBytes.Length);
                    }
                    int num5 = 0;
                    int num6 = 0;
                    if (preserveNewBuffer)
                    {
                        Array.Resize<byte>(ref this._bufferedBytes, _headerEnd.Length);
                        Array.Copy(data, headerBytesToStore - this._bufferedBytes.Length, this._bufferedBytes, 0, this._bufferedBytes.Length);
                        num6 = this._bufferedBytes.Length;
                        if (length == num4)
                        {
                            num5 = length;
                        }
                    }
                    else
                    {
                        this._bufferedBytes = new byte[0];
                        num5 = length;
                        num6 = length;
                    }
                    Array.Copy(data, 0, this._headerData, destinationIndex + num5, headerBytesToStore - num6);
                }
            }
        }

        private FieldHeaderInfo CreateHeader(byte[] headerData)
        {
            if (FileHeaderInfo.IsFileHeaderInfo(headerData, this._encoding))
            {
                return new FileHeaderInfo(headerData, this._encoding);
            }
            return new FieldHeaderInfo(headerData, this._encoding);
        }

        private byte[] Body
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool Complete
        {
            get
            {
                return this._complete;
            }
        }

        public int CompleteBodyBytes
        {
            get
            {
                return this._completeBodyBytes;
            }
        }

        public FieldHeaderInfo Header
        {
            get
            {
                return this._header;
            }
            internal set
            {
                this._header = value;
            }
        }
    }
}
