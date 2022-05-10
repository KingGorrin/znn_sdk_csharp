﻿using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Zenon.Model.NoM;
using Zenon.Model.NoM.Json;

namespace Zenon.Tests.TestData.Model.NoM
{
    internal class MomentumTestData : IEnumerable<object[]>
    {
        internal static string GetManifestResourceText(Assembly assembly, string resourceName)
        {
            using (var stream = assembly.GetManifestResourceStream(resourceName))
            using (var reader = new StreamReader(stream!))
                return reader.ReadToEnd();
        }

        public IEnumerator<object[]> GetEnumerator()
        {
            var json = GetManifestResourceText(Assembly.GetExecutingAssembly(), typeof(MomentumTestData).FullName + ".json");

            dynamic jsonArray = JsonConvert.DeserializeObject(json)!;

            foreach (var item in jsonArray)
            {
                yield return new object[]
                {
                    item.ToString(),
                    typeof(JMomentum),
                    typeof(Momentum)
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}