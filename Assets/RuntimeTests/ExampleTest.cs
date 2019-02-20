#region License
// ====================================================
// Broject Porcupine Copyright(C) 2016 Team Porcupine
// This program comes with ABSOLUTELY NO WARRANTY; This is free software, 
// and you are welcome to redistribute it under certain conditions; See 
// file LICENSE, which is part of this source code package, for details.
// ====================================================
#endregion
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using NUnit.Framework;
using System.Collections.Generic;
using System.Collections;

/*
    This file is meant to act as an example of a runtime test.

    All it does is load the file, place a few objects wait for them to be
    constructed then confirm that they were built.
*/

public class ExampleTest {
    // `yield null` skips a single frame
    [UnityTest]
    public IEnumerator WithEnumeratorPasses() {
        // don't load scenes async (you'll have to wait for them anyways)
        SceneManager.LoadScene("_World");

        // note: any errors will fail the test which is good
        // wait for init
        while (WorldController.Instance == null || !WorldController.Instance.Initialized)
            yield return null;
        // we are done initialising so we can build

        WorldController.Instance.BuildModeController.SetModeBuildTile(TileType.Floor);
        World world = WorldController.Instance.World;
        HashSet<Tile> tiles = new HashSet<Tile>();

        for (int x = 30; x < 50; x++) {
            int y = 50;
            int z = 0;
            Tile t = world.GetTileAt(x, y, z);
            WorldController.Instance.BuildModeController.DoBuild(t);
            tiles.Add(t);
        }

        foreach (Tile t in tiles) {
            
        }

        yield return new WaitForSeconds(3);
    }
}
