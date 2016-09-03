define(["exports", "PIXI"], function (exports, _PIXI) {
  "use strict";

  Object.defineProperty(exports, "__esModule", {
    value: true
  });
  exports.count = exports.items = exports.fl = exports.fruits = exports.stuffContainer = exports.outputSprite = exports.currentTexture = exports.renderTexture2 = exports.renderTexture = exports.stage = exports.gameDiv = exports.renderer = undefined;
  exports.animate = animate;
  var renderer = exports.renderer = new _PIXI.WebGLRenderer(800, 600);
  var gameDiv = exports.gameDiv = document.getElementById("game");
  gameDiv.appendChild(renderer.view);
  var stage = exports.stage = new _PIXI.Container();
  var renderTexture = exports.renderTexture = new _PIXI.RenderTexture(renderer, renderer.width, renderer.height);
  var renderTexture2 = exports.renderTexture2 = new _PIXI.RenderTexture(renderer, renderer.width, renderer.height);
  var currentTexture = exports.currentTexture = renderTexture;
  var outputSprite = exports.outputSprite = new _PIXI.Sprite(currentTexture);
  outputSprite.position.x = 400;
  outputSprite.position.y = 300;
  outputSprite.anchor.set(0.5);
  stage.addChild(outputSprite);
  var stuffContainer = exports.stuffContainer = new _PIXI.Container();
  stuffContainer.position.x = 400;
  stuffContainer.position.y = 300;
  stage.addChild(stuffContainer);
  var fruits = exports.fruits = ["./public/assets/spinObj_01.png", "./public/assets/spinObj_02.png", "./public/assets/spinObj_03.png", "./public/assets/spinObj_04.png", "./public/assets/spinObj_05.png", "./public/assets/spinObj_06.png", "./public/assets/spinObj_07.png", "./public/assets/spinObj_08.png"];
  var fl = exports.fl = fruits.length;
  var items = exports.items = [];

  for (var i = 0; i <= 19; i++) {
    var item = _PIXI.Sprite.fromImage(fruits[i % fl]);

    item.position.x = Math.random() * 400 - 200;
    item.position.y = Math.random() * 400 - 200;
    item.anchor.set(0.5);
    stuffContainer.addChild(item);
    items.push(item);
  }

  var count = exports.count = 0;

  function animate(dt) {
    window.requestAnimationFrame(function (delegateArg0) {
      animate(delegateArg0);
    });
    var il = items.length - 1;
    console.log(il);

    for (var i = 0; i <= il; i++) {
      var item = items[i];
      item.rotation = item.rotation + 0.1;
    }

    exports.count = count = count + 0.01;
    var temp = renderTexture;
    exports.renderTexture = renderTexture = renderTexture2;
    exports.renderTexture2 = renderTexture2 = temp;
    outputSprite.texture = renderTexture;
    stuffContainer.rotation = stuffContainer.rotation - 0.01;
    outputSprite.scale.set(1 + Math.sin(count) * 0.2);
    renderTexture2.render(stage, null, false);
    renderer.render(stage);
  }

  animate(0);
});
//# sourceMappingURL=render-texture.js.map