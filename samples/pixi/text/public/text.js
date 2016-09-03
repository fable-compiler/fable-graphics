define(["exports", "PIXI", "fable-core"], function (exports, _PIXI, _fableCore) {
  "use strict";

  Object.defineProperty(exports, "__esModule", {
    value: true
  });
  exports.animate = exports.countingText = exports.countingStyle = exports.spinningText = exports.funStyle = exports.textSample = exports.style = exports.background = exports.stage = exports.gameDiv = exports.renderer = undefined;
  exports.onAssetsLoad = onAssetsLoad;

  var PIXI = _interopRequireWildcard(_PIXI);

  function _interopRequireWildcard(obj) {
    if (obj && obj.__esModule) {
      return obj;
    } else {
      var newObj = {};

      if (obj != null) {
        for (var key in obj) {
          if (Object.prototype.hasOwnProperty.call(obj, key)) newObj[key] = obj[key];
        }
      }

      newObj.default = obj;
      return newObj;
    }
  }

  var renderer = exports.renderer = PIXI.autoDetectRenderer(800, 600);
  var gameDiv = exports.gameDiv = document.getElementById("game");
  gameDiv.appendChild(renderer.view);
  var stage = exports.stage = new _PIXI.Container();

  function onAssetsLoad(resources) {
    var fontStyle = {
      font: "35px Desyrel",
      align: "right"
    };
    var bitmapFontText = new _PIXI.extras.BitmapText("bitmap fonts are\n now supported", fontStyle);
    bitmapFontText.position.x = 600 - bitmapFontText.textWidth;
    bitmapFontText.position.y = 20;
    stage.addChild(bitmapFontText);
  }

  var background = exports.background = _PIXI.Sprite.fromImage("./public/assets/textDemoBG.jpg");

  stage.addChild(background);
  var style = exports.style = {
    font: "35px Arial",
    fill: "white",
    align: "left"
  };
  var textSample = exports.textSample = new _PIXI.Text("Pixi.js can have\n multiline text!", style);
  textSample.position.set(20);
  var funStyle = exports.funStyle = {
    font: "bold 60px Arial",
    fill: "#cc00ff",
    align: "center",
    stroke: "#FFFFFF",
    strokeThickness: 6
  };
  var spinningText = exports.spinningText = new _PIXI.Text("I'm fun!", funStyle);
  spinningText.anchor.set(0.5);
  spinningText.position.x = 310;
  spinningText.position.y = 200;
  var countingStyle = exports.countingStyle = {
    font: "bold italic 60px Arial",
    fill: "#3e1707",
    align: "center",
    stroke: "#a4410e",
    strokeThickness: 7
  };
  var countingText = exports.countingText = new _PIXI.Text("COUNT 4EVAR: 0", countingStyle);
  countingText.position.x = 310;
  countingText.position.y = 320;
  countingText.anchor.x = 0.5;
  stage.addChild(textSample);
  stage.addChild(spinningText);
  stage.addChild(countingText);
  PIXI.loader.add("desyrel", "./public/assets/desyrel.xml").load(function (_arg1, resources) {
    onAssetsLoad(resources);
  });

  var animate = exports.animate = function () {
    var count = 0;

    var animate = function animate(dt) {
      renderer.render(stage);
      count = count + 0.5;
      countingText.text = _fableCore.String.fsFormat("COUNT 4EVAR: %.0f")(function (x) {
        return x;
      })(Math.floor(count));
      spinningText.rotation = spinningText.rotation + 0.03;
      window.requestAnimationFrame(function (delegateArg0) {
        animate(delegateArg0);
      });
    };

    return animate;
  }();

  animate(0);
});
//# sourceMappingURL=text.js.map