define(["exports", "PIXI"], function (exports, _PIXI) {
  "use strict";

  Object.defineProperty(exports, "__esModule", {
    value: true
  });
  exports.stage = exports.gameDiv = exports.renderer = undefined;
  exports.animate = animate;
  exports.onLoad = onLoad;

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

  var renderer = exports.renderer = new _PIXI.WebGLRenderer(800, 600);
  var gameDiv = exports.gameDiv = document.getElementById("game");
  gameDiv.appendChild(renderer.view);
  var stage = exports.stage = new _PIXI.Container();

  function animate(dt) {
    window.requestAnimationFrame(function (delegateArg0) {
      animate(delegateArg0);
    });
    renderer.render(stage);
  }

  function onLoad(resources) {
    var explosionTextures = [];

    for (var i = 0; i <= 25; i++) {
      (function (arg00) {
        explosionTextures.push(arg00);
      })(_PIXI.Texture.fromFrame("Explosion_Sequence_A " + String(i + 1) + ".png"));
    }

    for (var i = 0; i <= 49; i++) {
      var explosion = new _PIXI.extras.MovieClip(explosionTextures);
      explosion.position.x = Math.random() * 800;
      explosion.position.y = Math.random() * 600;
      explosion.anchor.x = 0.5;
      explosion.anchor.y = 0.5;
      explosion.rotation = Math.random() * Math.PI;
      explosion.scale.set(0.75 + Math.random() * 0.5);
      explosion.gotoAndPlay(Math.random() * 27);
      stage.addChild(explosion);
    }

    animate(0);
  }

  PIXI.loader.add("spritesheet", "./public/assets/mc.json").load(function (loader, resources) {
    onLoad(resources);
  });
});
//# sourceMappingURL=movieclip.js.map