﻿using DotNetCoreConvertJson.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;

namespace DotNetCoreConvertJson
{
    class Program
    {
        static void Main(string[] args)
        {
            var settings = new DataContractJsonSerializerSettings
            {
                UseSimpleDictionaryFormat = true,
                DateTimeFormat = new DateTimeFormat("yyyy-MM-dd'T'HH:mm:ss.fff'Z'"),
            };

            var model = new SampleModel
            {
                IntValue = 10,
                StringValue = "ABC",
                DateTimeValue = DateTime.Now,
                ListtValue = new List<string> { "First", "Second", "Third" },
                MapValue = new Dictionary<string, string>() { { "Key01", "Val01" }, { "Key02", "Val02" } },
                SubSampleModel = new SubSampleModel { IntValue = 20, StringValue = "DEF" }
            };

            using (MemoryStream ms = new MemoryStream())
            {
                var serializer = new DataContractJsonSerializer(typeof(SampleModel), settings);
                serializer.WriteObject(ms, model);
                Console.WriteLine(Encoding.UTF8.GetString(ms.ToArray()));
            }
        }
    }
}
