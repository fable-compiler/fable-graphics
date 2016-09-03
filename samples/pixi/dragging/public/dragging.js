define(["exports", "PIXI", "fable-core"], function (exports, _PIXI, _fableCore) {
  "use strict";

  Object.defineProperty(exports, "__esModule", {
    value: true
  });
  exports.MyBunny = exports.texture = exports.stage = exports.gameDiv = exports.renderer = undefined;
  exports.createBunny = createBunny;
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

  function _classCallCheck(instance, Constructor) {
    if (!(instance instanceof Constructor)) {
      throw new TypeError("Cannot call a class as a function");
    }
  }

  var _createClass = function () {
    function defineProperties(target, props) {
      for (var i = 0; i < props.length; i++) {
        var descriptor = props[i];
        descriptor.enumerable = descriptor.enumerable || false;
        descriptor.configurable = true;
        if ("value" in descriptor) descriptor.writable = true;
        Object.defineProperty(target, descriptor.key, descriptor);
      }
    }

    return function (Constructor, protoProps, staticProps) {
      if (protoProps) defineProperties(Constructor.prototype, protoProps);
      if (staticProps) defineProperties(Constructor, staticProps);
      return Constructor;
    };
  }();

  function _possibleConstructorReturn(self, call) {
    if (!self) {
      throw new ReferenceError("this hasn't been initialised - super() hasn't been called");
    }

    return call && (typeof call === "object" || typeof call === "function") ? call : self;
  }

  function _inherits(subClass, superClass) {
    if (typeof superClass !== "function" && superClass !== null) {
      throw new TypeError("Super expression must either be null or a function, not " + typeof superClass);
    }

    subClass.prototype = Object.create(superClass && superClass.prototype, {
      constructor: {
        value: subClass,
        enumerable: false,
        writable: true,
        configurable: true
      }
    });
    if (superClass) Object.setPrototypeOf ? Object.setPrototypeOf(subClass, superClass) : subClass.__proto__ = superClass;
  }

  var renderer = exports.renderer = PIXI.autoDetectRenderer(800, 600);
  var gameDiv = exports.gameDiv = document.getElementById("game");
  gameDiv.appendChild(renderer.view);
  var stage = exports.stage = new _PIXI.Container();

  var texture = exports.texture = _PIXI.Texture.fromImage("./public/assets/bunny.png");

  var MyBunny = exports.MyBunny = function (_Sprite) {
    _inherits(MyBunny, _Sprite);

    function MyBunny(texture_1) {
      _classCallCheck(this, MyBunny);

      var _this = _possibleConstructorReturn(this, (MyBunny.__proto__ || Object.getPrototypeOf(MyBunny)).call(this, texture_1));

      return _this;
    }

    _createClass(MyBunny, [{
      key: "noop",
      value: function noop() {
        console.log("click");
      }
    }, {
      key: "mousedown",
      value: function mousedown(event) {
        this.data = event.data;
        this.alpha = 0.5;
        this.dragging = true;
      }
    }, {
      key: "mouseup",
      value: function mouseup() {
        this.data = null;
        this.alpha = 1;
        this.dragging = false;
      }
    }, {
      key: "mousemove",
      value: function mousemove() {
        var isDragging = this.dragging;

        if (isDragging) {
          var newPosition = this.data.getLocalPosition(this.parent);
          this.position.x = newPosition.x;
          this.position.y = newPosition.y;
        }
      }
    }, {
      key: "tap",
      get: function get() {
        var _this2 = this;

        return function (unitVar) {
          _this2.noop();
        };
      }
    }, {
      key: "click",
      get: function get() {
        var _this3 = this;

        return function (unitVar) {
          _this3.noop();
        };
      }
    }, {
      key: "touchstart",
      get: function get() {
        var _this4 = this;

        return function (arg00) {
          _this4.mousedown(arg00);
        };
      }
    }, {
      key: "touchend",
      get: function get() {
        var _this5 = this;

        return function (unitVar) {
          _this5.mouseup();
        };
      }
    }, {
      key: "touchendoutside",
      get: function get() {
        var _this6 = this;

        return function (unitVar) {
          _this6.mouseup();
        };
      }
    }, {
      key: "mouseupoutside",
      get: function get() {
        var _this7 = this;

        return function (unitVar) {
          _this7.mouseup();
        };
      }
    }, {
      key: "touchmove",
      get: function get() {
        var _this8 = this;

        return function (unitVar) {
          _this8.mousemove();
        };
      }
    }]);

    return MyBunny;
  }(_PIXI.Sprite);

  _fableCore.Util.setInterfaces(MyBunny.prototype, [], "Dragging.MyBunny");

  function createBunny(x, y) {
    var bunny = new MyBunny(texture);
    bunny.interactive = true;
    bunny.buttonMode = true;
    bunny.anchor.set(0.5);
    bunny.scale.set(3);
    bunny.position.x = x;
    bunny.position.y = y;
    return stage.addChild(bunny);
  }

  for (var i = 0; i <= 9; i++) {
    var x = Math.floor(Math.random() * 800);
    var y = Math.floor(Math.random() * 600);
    createBunny(x, y);
  }

  function animate(dt) {
    window.requestAnimationFrame(function (delegateArg0) {
      animate(delegateArg0);
    });
    renderer.render(stage);
  }

  animate(0);
});
//# sourceMappingURL=dragging.js.map