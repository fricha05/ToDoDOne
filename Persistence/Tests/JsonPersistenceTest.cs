using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

using Xunit;

using Persistence;


namespace Tests
{
    public class JsonPersistenceTest
    {
        private class ObjectToWrite
        {
            public int num;

            public int Num
            {
                get => num;
                set => num = value;
            }

            public string Name
            {
                get => name;
                set => name = value;
            }

            public string name;

            public ObjectToWrite(int num, string name)
            {
                this.num = num;
                this.name = name;
            }
        }

        private ObjectToWrite _objectToWrite = new ObjectToWrite(0, "name");

        private string _objectToWriteStr = "{\"Num\":0,\"Name\":\"name\"}";

        private string file = "test.json";


        // [Fact]
        // public void Write_should_write_objectToWrite()
        // {
        //     File.Write<ObjectToWrite>(_objectToWrite, file);
        //     Assert.Equals(_objectToWriteStr, File.ReadAllText(file));
        // }

        // [Fact]
        // public void ReadAll_should_read_objectToWriteStr()
        // {
        //     File.WriteAllText(file, _objectToWriteStr);
        //     Assert.Equals(_objectToWrite,  ReadAll<ObjectToWrite>(file));
        // }

    }
}

