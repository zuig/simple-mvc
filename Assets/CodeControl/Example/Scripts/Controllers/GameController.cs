﻿using UnityEngine;
using System.Collections;

public class GameController : Controller<GameModel> {

    protected override void OnInitialize() {
        Controller.Instantiate<LevelController>("Level", model.Level.Model, transform);

        foreach (RocketModel rocketModel in model.Rockets) {
            Controller.Instantiate<RocketController>("Rocket", rocketModel, transform);
        }
    }
	
}
