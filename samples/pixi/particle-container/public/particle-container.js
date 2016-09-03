define(["exports", "PIXI"], function (exports, _PIXI) {
  "use strict";

  Object.defineProperty(exports, "__esModule", {
    value: true
  });
  exports.animate = exports.dudeBounds = exports.dudeBoundsPadding = exports.totalSprites = exports.maggots = exports.sprites = exports.options = exports.stage = exports.gameDiv = exports.isWebGL = exports.renderer = undefined;

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

  var patternInput_19 = function () {
    var matchValue = PIXI.autoDetectRenderer(800, 600);

    if (matchValue instanceof _PIXI.CanvasRenderer) {
      return [false, matchValue];
    } else {
      return [true, matchValue];
    }
  }();

  var renderer = exports.renderer = patternInput_19[1];
  var isWebGL = exports.isWebGL = patternInput_19[0];
  var gameDiv = exports.gameDiv = document.getElementById("game");
  gameDiv.appendChild(renderer.view);
  var stage = exports.stage = new _PIXI.Container();
  var options = exports.options = {
    scale: true,
    position: true,
    rotation: true,
    uvs: true,
    alpha: true
  };
  var sprites = exports.sprites = new _PIXI.ParticleContainer(10000, options);
  stage.addChild(sprites);
  var maggots = exports.maggots = [];
  var totalSprites = exports.totalSprites = isWebGL ? 10000 : 100;

  for (var i = 0; i <= totalSprites - 1; i++) {
    var dude = _PIXI.Sprite.fromImage("./public/assets/tinyMaggot.png");

    dude.anchor.set(0.5);
    dude.scale.set(0.8 + Math.random() * 0.3);
    dude.position.x = Math.floor(Math.random() * renderer.width);
    dude.position.y = Math.floor(Math.random() * renderer.height);
    dude.direction = Math.random() * Math.PI * 2;
    dude.turningSpeed = Math.random() - 0.8;
    dude.speed = 2 + Math.random() * 2 * 0.2;
    dude.offset = Math.random() * 100;
    maggots.push(dude);
    stage.addChild(dude);
  }

  var dudeBoundsPadding = exports.dudeBoundsPadding = 100;
  var dudeBounds = exports.dudeBounds = new _PIXI.Rectangle(-dudeBoundsPadding, -dudeBoundsPadding, renderer.width + dudeBoundsPadding * 2, renderer.height + dudeBoundsPadding * 2);

  var animate = exports.animate = function () {
    var tick = 0;

    var animate = function animate(dt) {
      var dc = maggots.length - 1;

      for (var i = 0; i <= dc; i++) {
        var dude = maggots[i];
        dude.scale.y = 0.95 + Math.sin(tick + dude.offset) * 0.05;
        dude.direction = dude.direction + dude.turningSpeed * 0.01;
        dude.position.x = dude.position.x + Math.sin(dude.direction) * dude.speed * dude.scale.y;
        dude.position.y = dude.position.y + Math.cos(dude.direction) * dude.speed * dude.scale.y;
        dude.rotation = -dude.direction - Math.PI;

        if (dude.position.x < dudeBounds.x) {
          dude.position.x = dude.position.x + dudeBounds.width;
        } else {
          if (dude.position.x > dudeBounds.x + dudeBounds.width) {
            dude.position.x = dude.position.x - dudeBounds.width;
          }
        }

        if (dude.position.y < dudeBounds.y) {
          dude.position.y = dude.position.y + dudeBounds.height;
        } else {
          if (dude.position.y > dudeBounds.y + dudeBounds.height) {
            dude.position.y = dude.position.y - dudeBounds.height;
          }
        }
      }

      tick = tick + 0.1;
      window.requestAnimationFrame(function (delegateArg0) {
        animate(delegateArg0);
      });
      renderer.render(stage);
    };

    return animate;
  }();

  animate(0);
});
//# sourceMappingURL=particle-container.js.map