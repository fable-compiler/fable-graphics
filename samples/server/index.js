"use strict";

Object.defineProperty(exports, "__esModule", {
  value: true
});
exports.server = exports.relPath = exports.samplesPath = exports.port = exports.opener = exports.serveStatic = exports.finalhandler = undefined;

var _finalhandler = require("finalhandler");

var _finalhandler2 = _interopRequireDefault(_finalhandler);

var _serveStatic = require("serve-static");

var _serveStatic2 = _interopRequireDefault(_serveStatic);

var _open = require("open");

var _open2 = _interopRequireDefault(_open);

var _path = require("path");

var path = _interopRequireWildcard(_path);

var _http = require("http");

var http = _interopRequireWildcard(_http);

var _fableCore = require("fable-core");

function _interopRequireWildcard(obj) { if (obj && obj.__esModule) { return obj; } else { var newObj = {}; if (obj != null) { for (var key in obj) { if (Object.prototype.hasOwnProperty.call(obj, key)) newObj[key] = obj[key]; } } newObj.default = obj; return newObj; } }

function _interopRequireDefault(obj) { return obj && obj.__esModule ? obj : { default: obj }; }

var finalhandler = exports.finalhandler = _finalhandler2.default;
var serveStatic = exports.serveStatic = _serveStatic2.default;
var opener = exports.opener = _open2.default;

var port = exports.port = function () {
  var matchValue = process.argv;

  if (matchValue.length >= 3) {
    return Number.parseInt(matchValue[2]);
  } else {
    return 8080;
  }
}();

var samplesPath = exports.samplesPath = path.resolve("../..");
var relPath = exports.relPath = path.relative(samplesPath, ".");

var server = exports.server = function () {
  var serve = serveStatic(samplesPath);
  var server = http.createServer(function (req, res) {
    var isDone = finalhandler(req, res);
    serve(req, res, isDone);
  });
  return server.listen(port);
}();

opener(_fableCore.String.fsFormat("http://localhost:%i/%s")(function (x) {
  return x;
})(port)(relPath));