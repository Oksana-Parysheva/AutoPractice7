using AutoPractice7.CSV.Models;
using System.Collections.Generic;
using System.IO;

namespace AutoPractice7.CSV
{
    public class MyCsvReader
    {
        public static List<T> ReadData<T>(string filePath) where T : IDto<T>, new()
        {
            List<T> list = new List<T>();
            using (StreamReader stream = new StreamReader(filePath))
            {
                bool isHeaders = true;
                while (!stream.EndOfStream)
                {
                    if (!isHeaders)
                    {
                        T t = new T();
                        T data = t.GetData(stream.ReadLine());

                        list.Add(data);
                    }
                    else
                    {
                        stream.ReadLine();
                        isHeaders = false;
                    }
                }
            }

            return list;
        }
    }
}
