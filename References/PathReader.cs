using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class PathReader : MonoBehaviour
{
    void Start()
    {
        // DirectoryInfo assetsDirectory = new DirectoryInfo(Application.persistentDataPath);
        DirectoryInfo assetsDirectory = new DirectoryInfo(Application.dataPath);
        DirectoryInfo resourcesDirectory = new DirectoryInfo(assetsDirectory + "/Resources");
        DirectoryInfo musicDirectory = new DirectoryInfo(resourcesDirectory + "/Music");

        // Debug.Log(resourcesDirectory);

        // foreach (DirectoryInfo musicTitle in musicDirectory.GetDirectories())
        // {
        //     Debug.Log(musicTitle.Name);
        // }

        // foreach (FileInfo file in assetsDirectory.GetFiles())
        // {
        //     Debug.Log("파일명 : " + file.Name);
        // }
    }
}