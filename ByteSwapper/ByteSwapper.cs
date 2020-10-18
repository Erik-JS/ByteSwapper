using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteSwapper
{
    class ByteSwapper
    {
        
        public static byte[] ByteSwap(byte[] data, int swapSize)
        {
            // assuming data.Length is divisible by swapSize
            int progressvalue;
            MemoryStream ms = new MemoryStream();
            var subarray = new byte[swapSize];
            for (int i = 0; i < data.Length; i += swapSize)
            {
                Array.Copy(data, i, subarray, 0, swapSize);
                Array.Reverse(subarray);
                ms.Write(subarray, 0, swapSize);
                progressvalue = (int)(((float)(i + swapSize) / data.Length) * 100);
                Form1.SetProgress(progressvalue);
            }
            return ms.ToArray();
        }
    }
}
