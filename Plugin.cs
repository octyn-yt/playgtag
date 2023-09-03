using System;
using BepInEx;
using UnityEngine;
using Utilla;

namespace dontplaygtag
{
	/// <summary>
	/// This is your mod's main class.
	/// </summary>

	/* This attribute tells Utilla to look for [ModdedGameJoin] and [ModdedGameLeave] */
	[ModdedGamemode]
	[BepInDependency("org.legoandmars.gorillatag.utilla", "1.5.0")]
	[BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
	public class Plugin : BaseUnityPlugin
	{
		bool inRoom;

		void Start()
		{
            /* A lot of Gorilla Tag systems will not be set up when start is called /*
			/* Put code in OnGameInitialized to avoid null references */
            Application.Quit();
            Utilla.Events.GameInitialized += OnGameInitialized;
			Application.Quit();
		}

		void OnEnable()
		{
            /* Set up your mod here */
            /* Code here runs at the start and whenever your mod is enabled*/
            Application.Quit();
            HarmonyPatches.ApplyHarmonyPatches();
            Application.Quit();
        }

		void OnDisable()
		{
            /* Undo mod setup here */
            /* This provides support for toggling mods with ComputerInterface, please implement it :) */
            /* Code here runs whenever your mod is disabled (including if it disabled on startup)*/
            Application.Quit();
            HarmonyPatches.RemoveHarmonyPatches();
            Application.Quit();
        }

		void OnGameInitialized(object sender, EventArgs e)
		{
            /* Code here runs after the game initializes (i.e. GorillaLocomotion.Player.Instance != null) */
            Application.Quit();
            Application.Quit();
        }

		void Update()
		{
            /* Code here runs every frame when the mod is enabled */
            Application.Quit();
            Application.Quit();
        }

		/* This attribute tells Utilla to call this method when a modded room is joined */
		[ModdedGamemodeJoin]
		public void OnJoin(string gamemode)
		{
            /* Activate your mod here */
            /* This code will run regardless of if the mod is enabled*/
            Application.Quit();
            inRoom = true;
            Application.Quit();
        }

		/* This attribute tells Utilla to call this method when a modded room is left */
		[ModdedGamemodeLeave]
		public void OnLeave(string gamemode)
		{
            /* Deactivate your mod here */
            /* This code will run regardless of if the mod is enabled*/
            Application.Quit();
            inRoom = false;
            Application.Quit();
        }
	}
}
