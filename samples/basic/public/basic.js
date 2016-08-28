define(["exports", "PIXI"], function (exports, _PIXI) {
  "use strict";

  Object.defineProperty(exports, "__esModule", {
    value: true
  });
  exports.bunny = exports.texture = exports.stage = exports.gameDiv = exports.renderer = exports.options = undefined;
  exports.animate = animate;

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

  var options = exports.options = {
    backgroundColor: 1087931,
    resolution: 1
  };
  var renderer = exports.renderer = PIXI.autoDetectRenderer(800, 600, options);
  var gameDiv = exports.gameDiv = document.getElementById("game");
  gameDiv.appendChild(renderer.view);
  var stage = exports.stage = new _PIXI.Container();

  var texture = exports.texture = _PIXI.Texture.fromImage("/public/assets/bunny.png");

  var bunny = exports.bunny = null;
  exports.bunny = bunny = new _PIXI.Sprite(texture);
  bunny.anchor.x = 0.5;
  bunny.anchor.y = 0.5;
  bunny.position.x = 200;
  bunny.position.y = 150;
  stage.addChild(bunny);

  function animate(dt) {
    window.requestAnimationFrame(function (delegateArg0) {
      animate(delegateArg0);
    });
    bunny.rotation = bunny.rotation + 0.1;
    renderer.render(stage);
  }

  animate(0);
});
//# sourceMappingURL=basic.js.map