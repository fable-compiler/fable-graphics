define(["exports", "PIXI"], function (exports, _PIXI) {
  "use strict";

  Object.defineProperty(exports, "__esModule", {
    value: true
  });
  exports.count = exports.thing = exports.graphics = exports.stage = exports.gameDiv = exports.renderer = exports.options = undefined;
  exports.onClick = onClick;
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
    antialias: true
  };
  var renderer = exports.renderer = PIXI.autoDetectRenderer(800, 600, options);
  var gameDiv = exports.gameDiv = document.getElementById("game");
  gameDiv.appendChild(renderer.view);
  var stage = exports.stage = new _PIXI.Container();
  var graphics = exports.graphics = new _PIXI.Graphics();
  graphics.beginFill(16724736);
  graphics.lineStyle(4, 16767232, 1);
  graphics.moveTo(50, 50);
  graphics.lineTo(250, 50);
  graphics.lineTo(100, 100);
  graphics.lineTo(50, 50);
  graphics.endFill();
  graphics.lineStyle(10, 16711680, 0.8);
  graphics.beginFill(16740363, 1);
  graphics.moveTo(210, 300);
  graphics.lineTo(450, 320);
  graphics.lineTo(570, 350);
  graphics.quadraticCurveTo(600, 0, 480, 100);
  graphics.lineTo(330, 120);
  graphics.lineTo(410, 200);
  graphics.lineTo(210, 300);
  graphics.endFill();
  graphics.lineStyle(2, 255, 1);
  graphics.drawRect(50, 250, 100, 100);
  graphics.lineStyle(0);
  graphics.beginFill(16776971, 0.5);
  graphics.drawCircle(470, 200, 100);
  graphics.endFill();
  graphics.lineStyle(20, 3407616);
  graphics.moveTo(30, 30);
  graphics.lineTo(600, 300);
  stage.addChild(graphics);
  var thing = exports.thing = new _PIXI.Graphics();
  stage.addChild(thing);
  thing.position.x = 620 / 2;
  thing.position.y = 380 / 2;

  function onClick() {
    graphics.lineStyle(Math.random() * 30, Math.random() * 16777215, 1);
    graphics.moveTo(Math.random() * 620, Math.random() * 380);
    graphics.bezierCurveTo(Math.random() * 620, Math.random() * 380, Math.random() * 620, Math.random() * 380, Math.random() * 620, Math.random() * 380);
  }

  stage.interactive = true;
  stage.on("click", function (e) {
    onClick();
  });
  stage.on("tap", function (e) {
    onClick();
  });
  var count = exports.count = 0;

  function animate(dt) {
    thing.clear();
    exports.count = count = count + 0.1;
    thing.clear();
    thing.lineStyle(10, 16711680, 1);
    thing.beginFill(16776960, 0.5);
    thing.moveTo(-120 + Math.sin(count) * 20, -100 + Math.cos(count) * 20);
    thing.lineTo(120 + Math.cos(count) * 20, -100 + Math.sin(count) * 20);
    thing.lineTo(120 + Math.sin(count) * 20, 100 + Math.cos(count) * 20);
    thing.lineTo(-120 + Math.cos(count) * 20, 100 + Math.sin(count) * 20);
    thing.lineTo(-120 + Math.sin(count) * 20, -100 + Math.cos(count) * 20);
    thing.rotation = count * 0.1;
    window.requestAnimationFrame(function (delegateArg0) {
      animate(delegateArg0);
    });
    renderer.render(stage);
  }

  animate(0);
});
//# sourceMappingURL=graphics.js.map