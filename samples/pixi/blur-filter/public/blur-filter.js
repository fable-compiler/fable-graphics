define(["exports", "PIXI"], function (exports, _PIXI) {
  "use strict";

  Object.defineProperty(exports, "__esModule", {
    value: true
  });
  exports.animate = exports.blurFilter2 = exports.blurFilter1 = exports.littleRobot = exports.littleDudes = exports.bg = exports.stage = exports.gameDiv = exports.renderer = undefined;

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

  var bg = exports.bg = _PIXI.Sprite.fromImage("./public/assets/depth_blur_BG.jpg");

  bg.width = renderer.width;
  bg.height = renderer.height;
  stage.addChild(bg);

  var littleDudes = exports.littleDudes = _PIXI.Sprite.fromImage("./public/assets/depth_blur_dudes.jpg");

  littleDudes.position.x = renderer.width / 2 - 315;
  littleDudes.position.y = 200;
  stage.addChild(littleDudes);

  var littleRobot = exports.littleRobot = _PIXI.Sprite.fromImage("./public/assets/depth_blur_moby.jpg");

  littleRobot.position.x = renderer.width / 2 - 200;
  littleRobot.position.y = 100;
  stage.addChild(littleRobot);
  var blurFilter1 = exports.blurFilter1 = new _PIXI.filters.BlurFilter();
  var blurFilter2 = exports.blurFilter2 = new _PIXI.filters.BlurFilter();
  littleDudes.filters = [blurFilter1];
  littleRobot.filters = [blurFilter2];

  var animate = exports.animate = function () {
    var count = 0;

    var animate = function animate(dt) {
      count = count + 0.005;
      var blurAmount = Math.cos(count);
      var blurAmount2 = Math.sin(count);
      blurFilter1.blur = 20 * blurAmount;
      blurFilter2.blur = 20 * blurAmount2;
      window.requestAnimationFrame(function (delegateArg0) {
        animate(delegateArg0);
      });
      renderer.render(stage);
    };

    return animate;
  }();

  animate(0);
});
//# sourceMappingURL=blur-filter.js.map