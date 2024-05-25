using AutoMapper;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Features.SectionMasters.Commands.CreateSectionMaster;
using TechNews.Domain.Entities;

namespace TechNews.Application.Profiles
{
    public class AddSectionMasterCustomMapper : ITypeConverter<CreateSectionMasterCommand, SectionMaster>
    {
        SectionMaster ITypeConverter<CreateSectionMasterCommand, SectionMaster>.Convert(CreateSectionMasterCommand source, SectionMaster destination, ResolutionContext context)
        {
           //JObject json = JObject.Parse(source.DynamicData);
            //var myDictionary = JsonConvert.DeserializeObject<Dictionary<string, string>>(source.DynamicData);


            //    foreach (var item2 in myDictionary.Keys)
            //    {
            //        if (myDictionary[item2] == "Article1")
            //        {
            //            string terminal = (string)myDictionary[item2];
            //            byte[] bytes = Encoding.ASCII.GetBytes(terminal);

            //        myDictionary[item2] = SaveByteArrayToFileWithFileStream(bytes, myDictionary["Article1"]);
            //        }
            //    }
            //var json = Newtonsoft.Json.JsonConvert.SerializeObject(source.DynamicData);
            //var result = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(json);
            //string UserId = result[0].userId.Value;
            dynamic json = JsonConvert.DeserializeObject(source.DynamicData);
            JObject alertObj = JObject.Parse(source.DynamicData);
            foreach (var item in alertObj)
            {


                var terminal = item.Value;
                var bytes = terminal["byteData"];
                //byte[] bytes2 = Encoding.ASCII.GetBytes(bytes);
                //terminal["byteData"] = SaveByteArrayToFileWithFileStream(bytes,(string)terminal["extensions"]);
                //JObject alertObj2 = JObject.Parse(terminal);
                //foreach (var item2 in alertObj2)
                //{
                //    var terminal2 = item2.Value;

                //}                                 
            }

            SectionMaster dest = new SectionMaster()
            {
                DynamicData = source.DynamicData,
                CreatedDate = DateTime.Now,


            };
            return dest;
        }


        public static string SaveByteArrayToFileWithFileStream(byte[] data, string filePath)
        {
            string fileName = Path.GetFileNameWithoutExtension(filePath);
            string extension = Path.GetExtension(filePath);
            fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
            string path = Path.Combine("Files/", fileName);
            //string path = Path.Combine("Files/", );
            using var stream = File.Create(path);
            stream.Write(data, 0, data.Length);
            return fileName;
        }
    }

}