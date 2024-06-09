using UnityEngine;

public class LoadTextureFromPNG : MonoBehaviour
{
    public string pngFilePath; // Path to your PNG file

    void Start()
    {
        // Load the PNG file from disk
        byte[] fileData = System.IO.File.ReadAllBytes(pngFilePath);

        // Create a new Texture2D and load the PNG file into it
        Texture2D texture = new Texture2D(2, 2); // You can change these dimensions as per your PNG file's size
        texture.LoadImage(fileData); // Load PNG data into the texture

        // Assign the texture to a material or use it in your game
        GetComponent<Renderer>().material.mainTexture = texture;
    }
}
