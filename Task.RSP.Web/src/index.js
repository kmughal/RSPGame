let angular = require("angular"),
    styles = require("./styles/custom-style.scss");

let GameCoreController = require("./game/game.core-controller.js") ,
    GamePlayService  = require("./game/game.play-service.js") ,
    Constants  = require("./game/game.constants.js") ;

angular.module("app",[])
       .controller("gameCoreController",GameCoreController)
       .factory("gamePlayService" , GamePlayService)
       .constant("serviceUrlForplay" ,Constants.serviceUrlForplay)
       .constant("serviceUrlForComputerInput" ,Constants.serviceUrlForComputerInput);