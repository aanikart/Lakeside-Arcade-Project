using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveScript
{
    //public static void Save()
    //{
    //    BinaryFormatter formatter = new BinaryFormatter();
    //    string path = Application.persistentDataPath + "/data.saved";
    //    FileStream stream = new FileStream(path, FileMode.Create);
    //    SaveData data = new SaveData();
    //    formatter.Serialize(stream, data);
    //    stream.Close();
        
    //}
    //public static SaveData Load()
    //{
    //    string path = Application.persistentDataPath + "/data.saved";
    //    if (File.Exists(path))
    //    {
    //        BinaryFormatter formatter = new BinaryFormatter();
    //        FileStream stream = new FileStream(path, FileMode.Open);
    //        if (stream.Length == 0)
    //        {
    //            stream.Close();
    //            return null;
    //        }
    //        else
    //        {
    //            SaveData data = formatter.Deserialize(stream) as SaveData;
    //            stream.Close();
    //            return data;
    //        }          
    //    }
    //    else {
    //        return null;
    //    }
    //}
}
