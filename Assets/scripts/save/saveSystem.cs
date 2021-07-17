using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public static class saveSystem
{
  public static void SavePlayer(Player player){
    string path = Application.persistentDataPath + "/data.save";
    BinaryFormatter formatter = new BinaryFormatter();
    FileStream stream = new FileStream(path, FileMode.Create);
    PlayerData data = new PlayerData(player);

    formatter.Serialize(stream, data);
    stream.Close();
  }

  public static PlayerData loadData()
  {
    string path = Application.persistentDataPath + "/data.save";
    if (File.Exists(path)) {
      BinaryFormatter formatter=new BinaryFormatter();
      FileStream stream= new FileStream(path,FileMode.Open);

      PlayerData data = formatter.Deserialize(stream) as PlayerData;
      stream.Close();
      return data;
    }else{
      Debug.Log(path+" don't exist");
      return null;
    }
  }

}
