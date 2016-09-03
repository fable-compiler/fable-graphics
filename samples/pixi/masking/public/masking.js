define(["exports", "PIXI"], function (exports, _PIXI) {
  "use strict";

  Object.defineProperty(exports, "__esModule", {
    value: true
  });
  exports.animate = exports.help = exports.style = exports.thing = exports.panda = exports.light1 = exports.light2 = exports.bgFront = exports.container = exports.bg = exports.stage = exports.gameDiv = exports.renderer = undefined;
  exports.onClick = onClick;
  var renderer = exports.renderer = new _PIXI.WebGLRenderer(800, 600);
  var gameDiv = exports.gameDiv = document.getElementById("game");
  gameDiv.appendChild(renderer.view);
  var stage = exports.stage = new _PIXI.Container();
  stage.interactive = true;

  var bg = exports.bg = _PIXI.Sprite.fromImage("./public/assets/BGrotate.jpg");

  bg.anchor.x = 0.5;
  bg.anchor.y = 0.5;
  bg.position.x = renderer.width / 2;
  bg.position.y = renderer.height / 2;
  stage.addChild(bg);
  var container = exports.container = new _PIXI.Container();
  container.position.x = renderer.width / 2;
  container.position.y = renderer.height / 2;

  var bgFront = exports.bgFront = _PIXI.Sprite.fromImage("./public/assets/SceneRotate.jpg");

  bgFront.anchor.x = 0.5;
  bgFront.anchor.y = 0.5;
  container.addChild(bgFront);

  var light2 = exports.light2 = _PIXI.Sprite.fromImage("./public/assets/LightRotate2.png");

  light2.anchor.x = 0.5;
  light2.anchor.y = 0.5;
  container.addChild(light2);

  var light1 = exports.light1 = _PIXI.Sprite.fromImage("./public/assets/LightRotate1.png");

  light1.anchor.x = 0.5;
  light1.anchor.y = 0.5;
  container.addChild(light1);

  var panda = exports.panda = _PIXI.Sprite.fromImage("./public/assets/panda.png");

  panda.anchor.x = 0.5;
  panda.anchor.y = 0.5;
  container.addChild(panda);
  stage.addChild(container);
  var thing = exports.thing = new _PIXI.Graphics();
  stage.addChild(thing);
  thing.position.x = renderer.width / 2;
  thing.position.y = renderer.height / 2;
  thing.lineStyle(0);
  container.mask = thing;

  function onClick() {
    var matchValue = container.mask;

    if (matchValue != null) {
      container.mask = null;
    } else {
      container.mask = thing;
    }
  }

  stage.on('click', function (_arg1) {
    onClick();
  });
  stage.on('tap', function (_arg2) {
    onClick();
  });
  var style = exports.style = {
    font: "bold 12pt Arial",
    fill: "white"
  };
  var help = exports.help = new _PIXI.Text("Click to turn masking on / off.", style);
  help.position.y = renderer.height - 26;
  help.position.x = 10;
  stage.addChild(help);

  var animate = exports.animate = function () {
    var count = 0;

    var animate = function animate(dt) {
      bg.rotation = bg.rotation + 0.01;
      bgFront.rotation = bgFront.rotation - 0.01;
      light1.rotation = light1.rotation + 0.02;
      light2.rotation = light2.rotation + 0.01;
      panda.scale.x = 1 + Math.sin(count) * 0.04;
      panda.scale.y = 1 + Math.cos(count) * 0.04;
      count = count + 0.1;
      thing.clear();
      thing.beginFill(9160191, 0.4);
      var myangle = 20;
      var mysin = Math.sin(count) * myangle;
      var mycos = Math.cos(count) * myangle;
      thing.moveTo(-120 + mysin, -100 + mycos);
      thing.lineTo(-320 + mycos, 100 + mysin);
      thing.lineTo(120 + mycos, -100 + mysin);
      thing.lineTo(120 + mysin, 100 + mycos);
      thing.lineTo(-120 + mycos, 100 + mysin);
      thing.lineTo(-120 + mysin, -300 + mycos);
      thing.lineTo(-320 + mysin, -100 + mycos);
      thing.rotation = count * 0.1;
      window.requestAnimationFrame(function (delegateArg0) {
        animate(delegateArg0);
      });
      renderer.render(stage);
    };

    return animate;
  }();

  animate(0);
});
//# sourceMappingURL=masking.js.map