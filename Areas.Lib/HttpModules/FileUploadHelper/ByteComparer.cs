﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Areas.Lib.HttpModules.FileUploadHelper
{
    using System;

    internal class ByteComparer
    {
        private static byte GetByteAtPosition(int position, byte[] buffer1, byte[] buffer2)
        {
            if (position < buffer1.Length)
            {
                return buffer1[position];
            }
            return buffer2[position - buffer1.Length];
        }

        public static int IndexOf(byte[] pattern, byte[] buffer, int start)
        {
            int index = 0;
            int num2 = Array.IndexOf<byte>(buffer, pattern[0], start);
            if (num2 != -1)
            {
                while ((num2 + index) < buffer.Length)
                {
                    if (buffer[num2 + index] == pattern[index])
                    {
                        index++;
                        if (index != pattern.Length)
                        {
                            continue;
                        }
                        break;
                    }
                    num2 = Array.IndexOf<byte>(buffer, pattern[0], num2 + index);
                    if (num2 == -1)
                    {
                        break;
                    }
                    index = 0;
                }
            }
            if (index == pattern.Length)
            {
                return num2;
            }
            return -1;
        }

        private static int IndexOf(byte pattern, byte[] buffer1, byte[] buffer2, int start)
        {
            if (start >= buffer1.Length)
            {
                int num = Array.IndexOf<byte>(buffer2, pattern, start - buffer1.Length);
                if (num < 0)
                {
                    return num;
                }
                return (buffer1.Length + num);
            }
            int num2 = Array.IndexOf<byte>(buffer1, pattern, start);
            if (num2 >= 0)
            {
                return num2;
            }
            int index = Array.IndexOf<byte>(buffer2, pattern);
            if (index < 0)
            {
                return index;
            }
            return (buffer1.Length + index);
        }

        public static int IndexOf(byte[] pattern, byte[] buffer1, byte[] buffer2, int start)
        {
            int index = 0;
            int num2 = IndexOf(pattern[0], buffer1, buffer2, start);
            int num3 = buffer1.Length + buffer2.Length;
            if (num2 != -1)
            {
                while ((num2 + index) < num3)
                {
                    if (GetByteAtPosition(num2 + index, buffer1, buffer2) == pattern[index])
                    {
                        index++;
                        if (index != pattern.Length)
                        {
                            continue;
                        }
                        break;
                    }
                    num2 = IndexOf(pattern[0], buffer1, buffer2, num2 + index);
                    if (num2 == -1)
                    {
                        break;
                    }
                    index = 0;
                }
            }
            if (index == pattern.Length)
            {
                return num2;
            }
            return -1;
        }
    }
}