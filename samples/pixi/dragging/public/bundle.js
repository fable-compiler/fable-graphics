(function (exports,PIXI) {
'use strict';

function unwrapExports (x) {
	return x && x.__esModule ? x['default'] : x;
}

function createCommonjsModule(fn, module) {
	return module = { exports: {} }, fn(module, module.exports), module.exports;
}

// 7.2.1 RequireObjectCoercible(argument)
var _defined = function(it){
  if(it == undefined)throw TypeError("Can't call method on  " + it);
  return it;
};

// 7.1.13 ToObject(argument)
var defined = _defined;
var _toObject = function(it){
  return Object(defined(it));
};

var hasOwnProperty = {}.hasOwnProperty;
var _has = function(it, key){
  return hasOwnProperty.call(it, key);
};

var _global = createCommonjsModule(function (module) {
// https://github.com/zloirock/core-js/issues/86#issuecomment-115759028
var global = module.exports = typeof window != 'undefined' && window.Math == Math
  ? window : typeof self != 'undefined' && self.Math == Math ? self : Function('return this')();
if(typeof __g == 'number')__g = global; // eslint-disable-line no-undef
});

var global$1 = _global;
var SHARED = '__core-js_shared__';
var store  = global$1[SHARED] || (global$1[SHARED] = {});
var _shared = function(key){
  return store[key] || (store[key] = {});
};

var id = 0;
var px = Math.random();
var _uid = function(key){
  return 'Symbol('.concat(key === undefined ? '' : key, ')_', (++id + px).toString(36));
};

var shared = _shared('keys');
var uid    = _uid;
var _sharedKey = function(key){
  return shared[key] || (shared[key] = uid(key));
};

// 19.1.2.9 / 15.2.3.2 Object.getPrototypeOf(O)
var has$1         = _has;
var toObject$1    = _toObject;
var IE_PROTO    = _sharedKey('IE_PROTO');
var ObjectProto = Object.prototype;

var _objectGpo = Object.getPrototypeOf || function(O){
  O = toObject$1(O);
  if(has$1(O, IE_PROTO))return O[IE_PROTO];
  if(typeof O.constructor == 'function' && O instanceof O.constructor){
    return O.constructor.prototype;
  } return O instanceof Object ? ObjectProto : null;
};

var _core = createCommonjsModule(function (module) {
var core = module.exports = {version: '2.4.0'};
if(typeof __e == 'number')__e = core; // eslint-disable-line no-undef
});

var _aFunction = function(it){
  if(typeof it != 'function')throw TypeError(it + ' is not a function!');
  return it;
};

// optional / simple context binding
var aFunction = _aFunction;
var _ctx = function(fn, that, length){
  aFunction(fn);
  if(that === undefined)return fn;
  switch(length){
    case 1: return function(a){
      return fn.call(that, a);
    };
    case 2: return function(a, b){
      return fn.call(that, a, b);
    };
    case 3: return function(a, b, c){
      return fn.call(that, a, b, c);
    };
  }
  return function(/* ...args */){
    return fn.apply(that, arguments);
  };
};

var _isObject = function(it){
  return typeof it === 'object' ? it !== null : typeof it === 'function';
};

var isObject = _isObject;
var _anObject = function(it){
  if(!isObject(it))throw TypeError(it + ' is not an object!');
  return it;
};

var _fails = function(exec){
  try {
    return !!exec();
  } catch(e){
    return true;
  }
};

// Thank's IE8 for his funny defineProperty
var _descriptors = !_fails(function(){
  return Object.defineProperty({}, 'a', {get: function(){ return 7; }}).a != 7;
});

var isObject$1 = _isObject;
var document$1 = _global.document;
var is$1 = isObject$1(document$1) && isObject$1(document$1.createElement);
var _domCreate = function(it){
  return is$1 ? document$1.createElement(it) : {};
};

var _ie8DomDefine = !_descriptors && !_fails(function(){
  return Object.defineProperty(_domCreate('div'), 'a', {get: function(){ return 7; }}).a != 7;
});

// 7.1.1 ToPrimitive(input [, PreferredType])
var isObject$2 = _isObject;
// instead of the ES6 spec version, we didn't implement @@toPrimitive case
// and the second argument - flag - preferred type is a string
var _toPrimitive = function(it, S){
  if(!isObject$2(it))return it;
  var fn, val;
  if(S && typeof (fn = it.toString) == 'function' && !isObject$2(val = fn.call(it)))return val;
  if(typeof (fn = it.valueOf) == 'function' && !isObject$2(val = fn.call(it)))return val;
  if(!S && typeof (fn = it.toString) == 'function' && !isObject$2(val = fn.call(it)))return val;
  throw TypeError("Can't convert object to primitive value");
};

var anObject       = _anObject;
var IE8_DOM_DEFINE = _ie8DomDefine;
var toPrimitive    = _toPrimitive;
var dP$1             = Object.defineProperty;

var f$1 = _descriptors ? Object.defineProperty : function defineProperty(O, P, Attributes){
  anObject(O);
  P = toPrimitive(P, true);
  anObject(Attributes);
  if(IE8_DOM_DEFINE)try {
    return dP$1(O, P, Attributes);
  } catch(e){ /* empty */ }
  if('get' in Attributes || 'set' in Attributes)throw TypeError('Accessors not supported!');
  if('value' in Attributes)O[P] = Attributes.value;
  return O;
};

var _objectDp = {
	f: f$1
};

var _propertyDesc = function(bitmap, value){
  return {
    enumerable  : !(bitmap & 1),
    configurable: !(bitmap & 2),
    writable    : !(bitmap & 4),
    value       : value
  };
};

var dP         = _objectDp;
var createDesc = _propertyDesc;
var _hide = _descriptors ? function(object, key, value){
  return dP.f(object, key, createDesc(1, value));
} : function(object, key, value){
  object[key] = value;
  return object;
};

var global$2    = _global;
var core$1      = _core;
var ctx       = _ctx;
var hide      = _hide;
var PROTOTYPE = 'prototype';

var $export$1 = function(type, name, source){
  var IS_FORCED = type & $export$1.F
    , IS_GLOBAL = type & $export$1.G
    , IS_STATIC = type & $export$1.S
    , IS_PROTO  = type & $export$1.P
    , IS_BIND   = type & $export$1.B
    , IS_WRAP   = type & $export$1.W
    , exports   = IS_GLOBAL ? core$1 : core$1[name] || (core$1[name] = {})
    , expProto  = exports[PROTOTYPE]
    , target    = IS_GLOBAL ? global$2 : IS_STATIC ? global$2[name] : (global$2[name] || {})[PROTOTYPE]
    , key, own, out;
  if(IS_GLOBAL)source = name;
  for(key in source){
    // contains in native
    own = !IS_FORCED && target && target[key] !== undefined;
    if(own && key in exports)continue;
    // export native or passed
    out = own ? target[key] : source[key];
    // prevent global pollution for namespaces
    exports[key] = IS_GLOBAL && typeof target[key] != 'function' ? source[key]
    // bind timers to global for call from export context
    : IS_BIND && own ? ctx(out, global$2)
    // wrap global constructors for prevent change them in library
    : IS_WRAP && target[key] == out ? (function(C){
      var F = function(a, b, c){
        if(this instanceof C){
          switch(arguments.length){
            case 0: return new C;
            case 1: return new C(a);
            case 2: return new C(a, b);
          } return new C(a, b, c);
        } return C.apply(this, arguments);
      };
      F[PROTOTYPE] = C[PROTOTYPE];
      return F;
    // make static versions for prototype methods
    })(out) : IS_PROTO && typeof out == 'function' ? ctx(Function.call, out) : out;
    // export proto methods to core.%CONSTRUCTOR%.methods.%NAME%
    if(IS_PROTO){
      (exports.virtual || (exports.virtual = {}))[key] = out;
      // export proto methods to core.%CONSTRUCTOR%.prototype.%NAME%
      if(type & $export$1.R && expProto && !expProto[key])hide(expProto, key, out);
    }
  }
};
// type bitmap
$export$1.F = 1;   // forced
$export$1.G = 2;   // global
$export$1.S = 4;   // static
$export$1.P = 8;   // proto
$export$1.B = 16;  // bind
$export$1.W = 32;  // wrap
$export$1.U = 64;  // safe
$export$1.R = 128; // real proto method for `library` 
var _export = $export$1;

// most Object methods by ES6 should accept primitives
var $export = _export;
var core    = _core;
var fails   = _fails;
var _objectSap = function(KEY, exec){
  var fn  = (core.Object || {})[KEY] || Object[KEY]
    , exp = {};
  exp[KEY] = exec(fn);
  $export($export.S + $export.F * fails(function(){ fn(1); }), 'Object', exp);
};

// 19.1.2.9 Object.getPrototypeOf(O)
var toObject        = _toObject;
var $getPrototypeOf = _objectGpo;

_objectSap('getPrototypeOf', function(){
  return function getPrototypeOf(it){
    return $getPrototypeOf(toObject(it));
  };
});

var getPrototypeOf$2 = _core.Object.getPrototypeOf;

var getPrototypeOf$1 = createCommonjsModule(function (module) {
module.exports = { "default": getPrototypeOf$2, __esModule: true };
});

var _Object$getPrototypeOf = unwrapExports(getPrototypeOf$1);

var classCallCheck = createCommonjsModule(function (module, exports) {
"use strict";

exports.__esModule = true;

exports.default = function (instance, Constructor) {
  if (!(instance instanceof Constructor)) {
    throw new TypeError("Cannot call a class as a function");
  }
};
});

var _classCallCheck = unwrapExports(classCallCheck);

// 7.1.4 ToInteger
var ceil  = Math.ceil;
var floor = Math.floor;
var _toInteger = function(it){
  return isNaN(it = +it) ? 0 : (it > 0 ? floor : ceil)(it);
};

var toInteger = _toInteger;
var defined$1   = _defined;
// true  -> String#at
// false -> String#codePointAt
var _stringAt = function(TO_STRING){
  return function(that, pos){
    var s = String(defined$1(that))
      , i = toInteger(pos)
      , l = s.length
      , a, b;
    if(i < 0 || i >= l)return TO_STRING ? '' : undefined;
    a = s.charCodeAt(i);
    return a < 0xd800 || a > 0xdbff || i + 1 === l || (b = s.charCodeAt(i + 1)) < 0xdc00 || b > 0xdfff
      ? TO_STRING ? s.charAt(i) : a
      : TO_STRING ? s.slice(i, i + 2) : (a - 0xd800 << 10) + (b - 0xdc00) + 0x10000;
  };
};

var _library = true;

var _redefine = _hide;

var _iterators = {};

var toString$1 = {}.toString;

var _cof = function(it){
  return toString$1.call(it).slice(8, -1);
};

// fallback for non-array-like ES3 and non-enumerable old V8 strings
var cof = _cof;
var _iobject = Object('z').propertyIsEnumerable(0) ? Object : function(it){
  return cof(it) == 'String' ? it.split('') : Object(it);
};

// to indexed object, toObject with fallback for non-array-like ES3 strings
var IObject = _iobject;
var defined$2 = _defined;
var _toIobject = function(it){
  return IObject(defined$2(it));
};

// 7.1.15 ToLength
var toInteger$1 = _toInteger;
var min       = Math.min;
var _toLength = function(it){
  return it > 0 ? min(toInteger$1(it), 0x1fffffffffffff) : 0; // pow(2, 53) - 1 == 9007199254740991
};

var toInteger$2 = _toInteger;
var max       = Math.max;
var min$1       = Math.min;
var _toIndex = function(index, length){
  index = toInteger$2(index);
  return index < 0 ? max(index + length, 0) : min$1(index, length);
};

// false -> Array#indexOf
// true  -> Array#includes
var toIObject$1 = _toIobject;
var toLength  = _toLength;
var toIndex   = _toIndex;
var _arrayIncludes = function(IS_INCLUDES){
  return function($this, el, fromIndex){
    var O      = toIObject$1($this)
      , length = toLength(O.length)
      , index  = toIndex(fromIndex, length)
      , value;
    // Array#includes uses SameValueZero equality algorithm
    if(IS_INCLUDES && el != el)while(length > index){
      value = O[index++];
      if(value != value)return true;
    // Array#toIndex ignores holes, Array#includes - not
    } else for(;length > index; index++)if(IS_INCLUDES || index in O){
      if(O[index] === el)return IS_INCLUDES || index || 0;
    } return !IS_INCLUDES && -1;
  };
};

var has$3          = _has;
var toIObject    = _toIobject;
var arrayIndexOf = _arrayIncludes(false);
var IE_PROTO$2     = _sharedKey('IE_PROTO');

var _objectKeysInternal = function(object, names){
  var O      = toIObject(object)
    , i      = 0
    , result = []
    , key;
  for(key in O)if(key != IE_PROTO$2)has$3(O, key) && result.push(key);
  // Don't enum bug & hidden keys
  while(names.length > i)if(has$3(O, key = names[i++])){
    ~arrayIndexOf(result, key) || result.push(key);
  }
  return result;
};

// IE 8- don't enum bug keys
var _enumBugKeys = (
  'constructor,hasOwnProperty,isPrototypeOf,propertyIsEnumerable,toLocaleString,toString,valueOf'
).split(',');

// 19.1.2.14 / 15.2.3.14 Object.keys(O)
var $keys       = _objectKeysInternal;
var enumBugKeys$1 = _enumBugKeys;

var _objectKeys = Object.keys || function keys(O){
  return $keys(O, enumBugKeys$1);
};

var dP$2       = _objectDp;
var anObject$2 = _anObject;
var getKeys  = _objectKeys;

var _objectDps = _descriptors ? Object.defineProperties : function defineProperties(O, Properties){
  anObject$2(O);
  var keys   = getKeys(Properties)
    , length = keys.length
    , i = 0
    , P;
  while(length > i)dP$2.f(O, P = keys[i++], Properties[P]);
  return O;
};

var _html = _global.document && document.documentElement;

// 19.1.2.2 / 15.2.3.5 Object.create(O [, Properties])
var anObject$1    = _anObject;
var dPs         = _objectDps;
var enumBugKeys = _enumBugKeys;
var IE_PROTO$1    = _sharedKey('IE_PROTO');
var Empty       = function(){ /* empty */ };
var PROTOTYPE$1   = 'prototype';

// Create object with fake `null` prototype: use iframe Object with cleared prototype
var createDict = function(){
  // Thrash, waste and sodomy: IE GC bug
  var iframe = _domCreate('iframe')
    , i      = enumBugKeys.length
    , lt     = '<'
    , gt     = '>'
    , iframeDocument;
  iframe.style.display = 'none';
  _html.appendChild(iframe);
  iframe.src = 'javascript:'; // eslint-disable-line no-script-url
  // createDict = iframe.contentWindow.Object;
  // html.removeChild(iframe);
  iframeDocument = iframe.contentWindow.document;
  iframeDocument.open();
  iframeDocument.write(lt + 'script' + gt + 'document.F=Object' + lt + '/script' + gt);
  iframeDocument.close();
  createDict = iframeDocument.F;
  while(i--)delete createDict[PROTOTYPE$1][enumBugKeys[i]];
  return createDict();
};

var _objectCreate = Object.create || function create(O, Properties){
  var result;
  if(O !== null){
    Empty[PROTOTYPE$1] = anObject$1(O);
    result = new Empty;
    Empty[PROTOTYPE$1] = null;
    // add "__proto__" for Object.getPrototypeOf polyfill
    result[IE_PROTO$1] = O;
  } else result = createDict();
  return Properties === undefined ? result : dPs(result, Properties);
};

var _wks = createCommonjsModule(function (module) {
var store      = _shared('wks')
  , uid        = _uid
  , Symbol     = _global.Symbol
  , USE_SYMBOL = typeof Symbol == 'function';

var $exports = module.exports = function(name){
  return store[name] || (store[name] =
    USE_SYMBOL && Symbol[name] || (USE_SYMBOL ? Symbol : uid)('Symbol.' + name));
};

$exports.store = store;
});

var def = _objectDp.f;
var has$4 = _has;
var TAG = _wks('toStringTag');

var _setToStringTag = function(it, tag, stat){
  if(it && !has$4(it = stat ? it : it.prototype, TAG))def(it, TAG, {configurable: true, value: tag});
};

var create$1         = _objectCreate;
var descriptor     = _propertyDesc;
var setToStringTag$1 = _setToStringTag;
var IteratorPrototype = {};

// 25.1.2.1.1 %IteratorPrototype%[@@iterator]()
_hide(IteratorPrototype, _wks('iterator'), function(){ return this; });

var _iterCreate = function(Constructor, NAME, next){
  Constructor.prototype = create$1(IteratorPrototype, {next: descriptor(1, next)});
  setToStringTag$1(Constructor, NAME + ' Iterator');
};

var LIBRARY        = _library;
var $export$2        = _export;
var redefine       = _redefine;
var hide$1           = _hide;
var has$2            = _has;
var Iterators      = _iterators;
var $iterCreate    = _iterCreate;
var setToStringTag = _setToStringTag;
var getPrototypeOf$4 = _objectGpo;
var ITERATOR       = _wks('iterator');
var BUGGY          = !([].keys && 'next' in [].keys());
var FF_ITERATOR    = '@@iterator';
var KEYS           = 'keys';
var VALUES         = 'values';

var returnThis = function(){ return this; };

var _iterDefine = function(Base, NAME, Constructor, next, DEFAULT, IS_SET, FORCED){
  $iterCreate(Constructor, NAME, next);
  var getMethod = function(kind){
    if(!BUGGY && kind in proto)return proto[kind];
    switch(kind){
      case KEYS: return function keys(){ return new Constructor(this, kind); };
      case VALUES: return function values(){ return new Constructor(this, kind); };
    } return function entries(){ return new Constructor(this, kind); };
  };
  var TAG        = NAME + ' Iterator'
    , DEF_VALUES = DEFAULT == VALUES
    , VALUES_BUG = false
    , proto      = Base.prototype
    , $native    = proto[ITERATOR] || proto[FF_ITERATOR] || DEFAULT && proto[DEFAULT]
    , $default   = $native || getMethod(DEFAULT)
    , $entries   = DEFAULT ? !DEF_VALUES ? $default : getMethod('entries') : undefined
    , $anyNative = NAME == 'Array' ? proto.entries || $native : $native
    , methods, key, IteratorPrototype;
  // Fix native
  if($anyNative){
    IteratorPrototype = getPrototypeOf$4($anyNative.call(new Base));
    if(IteratorPrototype !== Object.prototype){
      // Set @@toStringTag to native iterators
      setToStringTag(IteratorPrototype, TAG, true);
      // fix for some old engines
      if(!LIBRARY && !has$2(IteratorPrototype, ITERATOR))hide$1(IteratorPrototype, ITERATOR, returnThis);
    }
  }
  // fix Array#{values, @@iterator}.name in V8 / FF
  if(DEF_VALUES && $native && $native.name !== VALUES){
    VALUES_BUG = true;
    $default = function values(){ return $native.call(this); };
  }
  // Define iterator
  if((!LIBRARY || FORCED) && (BUGGY || VALUES_BUG || !proto[ITERATOR])){
    hide$1(proto, ITERATOR, $default);
  }
  // Plug for library
  Iterators[NAME] = $default;
  Iterators[TAG]  = returnThis;
  if(DEFAULT){
    methods = {
      values:  DEF_VALUES ? $default : getMethod(VALUES),
      keys:    IS_SET     ? $default : getMethod(KEYS),
      entries: $entries
    };
    if(FORCED)for(key in methods){
      if(!(key in proto))redefine(proto, key, methods[key]);
    } else $export$2($export$2.P + $export$2.F * (BUGGY || VALUES_BUG), NAME, methods);
  }
  return methods;
};

var $at  = _stringAt(true);

// 21.1.3.27 String.prototype[@@iterator]()
_iterDefine(String, 'String', function(iterated){
  this._t = String(iterated); // target
  this._i = 0;                // next index
// 21.1.5.2.1 %StringIteratorPrototype%.next()
}, function(){
  var O     = this._t
    , index = this._i
    , point;
  if(index >= O.length)return {value: undefined, done: true};
  point = $at(O, index);
  this._i += point.length;
  return {value: point, done: false};
});

var _addToUnscopables = function(){ /* empty */ };

var _iterStep = function(done, value){
  return {value: value, done: !!done};
};

var addToUnscopables = _addToUnscopables;
var step             = _iterStep;
var Iterators$2        = _iterators;
var toIObject$2        = _toIobject;

// 22.1.3.4 Array.prototype.entries()
// 22.1.3.13 Array.prototype.keys()
// 22.1.3.29 Array.prototype.values()
// 22.1.3.30 Array.prototype[@@iterator]()
var es6_array_iterator = _iterDefine(Array, 'Array', function(iterated, kind){
  this._t = toIObject$2(iterated); // target
  this._i = 0;                   // next index
  this._k = kind;                // kind
// 22.1.5.2.1 %ArrayIteratorPrototype%.next()
}, function(){
  var O     = this._t
    , kind  = this._k
    , index = this._i++;
  if(!O || index >= O.length){
    this._t = undefined;
    return step(1);
  }
  if(kind == 'keys'  )return step(0, index);
  if(kind == 'values')return step(0, O[index]);
  return step(0, [index, O[index]]);
}, 'values');

// argumentsList[@@iterator] is %ArrayProto_values% (9.4.4.6, 9.4.4.7)
Iterators$2.Arguments = Iterators$2.Array;

addToUnscopables('keys');
addToUnscopables('values');
addToUnscopables('entries');

var global$3        = _global;
var hide$2          = _hide;
var Iterators$1     = _iterators;
var TO_STRING_TAG = _wks('toStringTag');

for(var collections = ['NodeList', 'DOMTokenList', 'MediaList', 'StyleSheetList', 'CSSRuleList'], i$1 = 0; i$1 < 5; i$1++){
  var NAME       = collections[i$1]
    , Collection = global$3[NAME]
    , proto      = Collection && Collection.prototype;
  if(proto && !proto[TO_STRING_TAG])hide$2(proto, TO_STRING_TAG, NAME);
  Iterators$1[NAME] = Iterators$1.Array;
}

var f$2 = _wks;

var _wksExt = {
	f: f$2
};

var iterator$2 = _wksExt.f('iterator');

var iterator = createCommonjsModule(function (module) {
module.exports = { "default": iterator$2, __esModule: true };
});

var _meta = createCommonjsModule(function (module) {
var META     = _uid('meta')
  , isObject = _isObject
  , has      = _has
  , setDesc  = _objectDp.f
  , id       = 0;
var isExtensible = Object.isExtensible || function(){
  return true;
};
var FREEZE = !_fails(function(){
  return isExtensible(Object.preventExtensions({}));
});
var setMeta = function(it){
  setDesc(it, META, {value: {
    i: 'O' + ++id, // object ID
    w: {}          // weak collections IDs
  }});
};
var fastKey = function(it, create){
  // return primitive with prefix
  if(!isObject(it))return typeof it == 'symbol' ? it : (typeof it == 'string' ? 'S' : 'P') + it;
  if(!has(it, META)){
    // can't set metadata to uncaught frozen object
    if(!isExtensible(it))return 'F';
    // not necessary to add metadata
    if(!create)return 'E';
    // add missing metadata
    setMeta(it);
  // return object ID
  } return it[META].i;
};
var getWeak = function(it, create){
  if(!has(it, META)){
    // can't set metadata to uncaught frozen object
    if(!isExtensible(it))return true;
    // not necessary to add metadata
    if(!create)return false;
    // add missing metadata
    setMeta(it);
  // return hash weak collections IDs
  } return it[META].w;
};
// add metadata on freeze-family methods calling
var onFreeze = function(it){
  if(FREEZE && meta.NEED && isExtensible(it) && !has(it, META))setMeta(it);
  return it;
};
var meta = module.exports = {
  KEY:      META,
  NEED:     false,
  fastKey:  fastKey,
  getWeak:  getWeak,
  onFreeze: onFreeze
};
});

var global$5         = _global;
var core$2           = _core;
var LIBRARY$1        = _library;
var wksExt$1         = _wksExt;
var defineProperty$1 = _objectDp.f;
var _wksDefine = function(name){
  var $Symbol = core$2.Symbol || (core$2.Symbol = LIBRARY$1 ? {} : global$5.Symbol || {});
  if(name.charAt(0) != '_' && !(name in $Symbol))defineProperty$1($Symbol, name, {value: wksExt$1.f(name)});
};

var getKeys$1   = _objectKeys;
var toIObject$4 = _toIobject;
var _keyof = function(object, el){
  var O      = toIObject$4(object)
    , keys   = getKeys$1(O)
    , length = keys.length
    , index  = 0
    , key;
  while(length > index)if(O[key = keys[index++]] === el)return key;
};

var f$3 = Object.getOwnPropertySymbols;

var _objectGops = {
	f: f$3
};

var f$4 = {}.propertyIsEnumerable;

var _objectPie = {
	f: f$4
};

// all enumerable object keys, includes symbols
var getKeys$2 = _objectKeys;
var gOPS    = _objectGops;
var pIE     = _objectPie;
var _enumKeys = function(it){
  var result     = getKeys$2(it)
    , getSymbols = gOPS.f;
  if(getSymbols){
    var symbols = getSymbols(it)
      , isEnum  = pIE.f
      , i       = 0
      , key;
    while(symbols.length > i)if(isEnum.call(it, key = symbols[i++]))result.push(key);
  } return result;
};

// 7.2.2 IsArray(argument)
var cof$1 = _cof;
var _isArray = Array.isArray || function isArray(arg){
  return cof$1(arg) == 'Array';
};

// 19.1.2.7 / 15.2.3.4 Object.getOwnPropertyNames(O)
var $keys$2      = _objectKeysInternal;
var hiddenKeys = _enumBugKeys.concat('length', 'prototype');

var f$6 = Object.getOwnPropertyNames || function getOwnPropertyNames(O){
  return $keys$2(O, hiddenKeys);
};

var _objectGopn = {
	f: f$6
};

// fallback for IE11 buggy Object.getOwnPropertyNames with iframe and window
var toIObject$5 = _toIobject;
var gOPN$1      = _objectGopn.f;
var toString$2  = {}.toString;

var windowNames = typeof window == 'object' && window && Object.getOwnPropertyNames
  ? Object.getOwnPropertyNames(window) : [];

var getWindowNames = function(it){
  try {
    return gOPN$1(it);
  } catch(e){
    return windowNames.slice();
  }
};

var f$5 = function getOwnPropertyNames(it){
  return windowNames && toString$2.call(it) == '[object Window]' ? getWindowNames(it) : gOPN$1(toIObject$5(it));
};

var _objectGopnExt = {
	f: f$5
};

var pIE$1            = _objectPie;
var createDesc$2     = _propertyDesc;
var toIObject$6      = _toIobject;
var toPrimitive$2    = _toPrimitive;
var has$6            = _has;
var IE8_DOM_DEFINE$1 = _ie8DomDefine;
var gOPD$1           = Object.getOwnPropertyDescriptor;

var f$7 = _descriptors ? gOPD$1 : function getOwnPropertyDescriptor(O, P){
  O = toIObject$6(O);
  P = toPrimitive$2(P, true);
  if(IE8_DOM_DEFINE$1)try {
    return gOPD$1(O, P);
  } catch(e){ /* empty */ }
  if(has$6(O, P))return createDesc$2(!pIE$1.f.call(O, P), O[P]);
};

var _objectGopd = {
	f: f$7
};

// ECMAScript 6 symbols shim
var global$4         = _global;
var has$5            = _has;
var DESCRIPTORS    = _descriptors;
var $export$3        = _export;
var redefine$1       = _redefine;
var META           = _meta.KEY;
var $fails         = _fails;
var shared$1         = _shared;
var setToStringTag$2 = _setToStringTag;
var uid$1            = _uid;
var wks            = _wks;
var wksExt         = _wksExt;
var wksDefine      = _wksDefine;
var keyOf          = _keyof;
var enumKeys       = _enumKeys;
var isArray$1        = _isArray;
var anObject$3       = _anObject;
var toIObject$3      = _toIobject;
var toPrimitive$1    = _toPrimitive;
var createDesc$1     = _propertyDesc;
var _create        = _objectCreate;
var gOPNExt        = _objectGopnExt;
var $GOPD          = _objectGopd;
var $DP            = _objectDp;
var $keys$1          = _objectKeys;
var gOPD           = $GOPD.f;
var dP$3             = $DP.f;
var gOPN           = gOPNExt.f;
var $Symbol        = global$4.Symbol;
var $JSON          = global$4.JSON;
var _stringify     = $JSON && $JSON.stringify;
var PROTOTYPE$2      = 'prototype';
var HIDDEN         = wks('_hidden');
var TO_PRIMITIVE   = wks('toPrimitive');
var isEnum         = {}.propertyIsEnumerable;
var SymbolRegistry = shared$1('symbol-registry');
var AllSymbols     = shared$1('symbols');
var OPSymbols      = shared$1('op-symbols');
var ObjectProto$1    = Object[PROTOTYPE$2];
var USE_NATIVE     = typeof $Symbol == 'function';
var QObject        = global$4.QObject;
// Don't use setters in Qt Script, https://github.com/zloirock/core-js/issues/173
var setter = !QObject || !QObject[PROTOTYPE$2] || !QObject[PROTOTYPE$2].findChild;

// fallback for old Android, https://code.google.com/p/v8/issues/detail?id=687
var setSymbolDesc = DESCRIPTORS && $fails(function(){
  return _create(dP$3({}, 'a', {
    get: function(){ return dP$3(this, 'a', {value: 7}).a; }
  })).a != 7;
}) ? function(it, key, D){
  var protoDesc = gOPD(ObjectProto$1, key);
  if(protoDesc)delete ObjectProto$1[key];
  dP$3(it, key, D);
  if(protoDesc && it !== ObjectProto$1)dP$3(ObjectProto$1, key, protoDesc);
} : dP$3;

var wrap = function(tag){
  var sym = AllSymbols[tag] = _create($Symbol[PROTOTYPE$2]);
  sym._k = tag;
  return sym;
};

var isSymbol = USE_NATIVE && typeof $Symbol.iterator == 'symbol' ? function(it){
  return typeof it == 'symbol';
} : function(it){
  return it instanceof $Symbol;
};

var $defineProperty = function defineProperty(it, key, D){
  if(it === ObjectProto$1)$defineProperty(OPSymbols, key, D);
  anObject$3(it);
  key = toPrimitive$1(key, true);
  anObject$3(D);
  if(has$5(AllSymbols, key)){
    if(!D.enumerable){
      if(!has$5(it, HIDDEN))dP$3(it, HIDDEN, createDesc$1(1, {}));
      it[HIDDEN][key] = true;
    } else {
      if(has$5(it, HIDDEN) && it[HIDDEN][key])it[HIDDEN][key] = false;
      D = _create(D, {enumerable: createDesc$1(0, false)});
    } return setSymbolDesc(it, key, D);
  } return dP$3(it, key, D);
};
var $defineProperties = function defineProperties(it, P){
  anObject$3(it);
  var keys = enumKeys(P = toIObject$3(P))
    , i    = 0
    , l = keys.length
    , key;
  while(l > i)$defineProperty(it, key = keys[i++], P[key]);
  return it;
};
var $create = function create(it, P){
  return P === undefined ? _create(it) : $defineProperties(_create(it), P);
};
var $propertyIsEnumerable = function propertyIsEnumerable(key){
  var E = isEnum.call(this, key = toPrimitive$1(key, true));
  if(this === ObjectProto$1 && has$5(AllSymbols, key) && !has$5(OPSymbols, key))return false;
  return E || !has$5(this, key) || !has$5(AllSymbols, key) || has$5(this, HIDDEN) && this[HIDDEN][key] ? E : true;
};
var $getOwnPropertyDescriptor = function getOwnPropertyDescriptor(it, key){
  it  = toIObject$3(it);
  key = toPrimitive$1(key, true);
  if(it === ObjectProto$1 && has$5(AllSymbols, key) && !has$5(OPSymbols, key))return;
  var D = gOPD(it, key);
  if(D && has$5(AllSymbols, key) && !(has$5(it, HIDDEN) && it[HIDDEN][key]))D.enumerable = true;
  return D;
};
var $getOwnPropertyNames = function getOwnPropertyNames(it){
  var names  = gOPN(toIObject$3(it))
    , result = []
    , i      = 0
    , key;
  while(names.length > i){
    if(!has$5(AllSymbols, key = names[i++]) && key != HIDDEN && key != META)result.push(key);
  } return result;
};
var $getOwnPropertySymbols = function getOwnPropertySymbols(it){
  var IS_OP  = it === ObjectProto$1
    , names  = gOPN(IS_OP ? OPSymbols : toIObject$3(it))
    , result = []
    , i      = 0
    , key;
  while(names.length > i){
    if(has$5(AllSymbols, key = names[i++]) && (IS_OP ? has$5(ObjectProto$1, key) : true))result.push(AllSymbols[key]);
  } return result;
};

// 19.4.1.1 Symbol([description])
if(!USE_NATIVE){
  $Symbol = function Symbol(){
    if(this instanceof $Symbol)throw TypeError('Symbol is not a constructor!');
    var tag = uid$1(arguments.length > 0 ? arguments[0] : undefined);
    var $set = function(value){
      if(this === ObjectProto$1)$set.call(OPSymbols, value);
      if(has$5(this, HIDDEN) && has$5(this[HIDDEN], tag))this[HIDDEN][tag] = false;
      setSymbolDesc(this, tag, createDesc$1(1, value));
    };
    if(DESCRIPTORS && setter)setSymbolDesc(ObjectProto$1, tag, {configurable: true, set: $set});
    return wrap(tag);
  };
  redefine$1($Symbol[PROTOTYPE$2], 'toString', function toString(){
    return this._k;
  });

  $GOPD.f = $getOwnPropertyDescriptor;
  $DP.f   = $defineProperty;
  _objectGopn.f = gOPNExt.f = $getOwnPropertyNames;
  _objectPie.f  = $propertyIsEnumerable;
  _objectGops.f = $getOwnPropertySymbols;

  if(DESCRIPTORS && !_library){
    redefine$1(ObjectProto$1, 'propertyIsEnumerable', $propertyIsEnumerable, true);
  }

  wksExt.f = function(name){
    return wrap(wks(name));
  };
}

$export$3($export$3.G + $export$3.W + $export$3.F * !USE_NATIVE, {Symbol: $Symbol});

for(var symbols = (
  // 19.4.2.2, 19.4.2.3, 19.4.2.4, 19.4.2.6, 19.4.2.8, 19.4.2.9, 19.4.2.10, 19.4.2.11, 19.4.2.12, 19.4.2.13, 19.4.2.14
  'hasInstance,isConcatSpreadable,iterator,match,replace,search,species,split,toPrimitive,toStringTag,unscopables'
).split(','), i$2 = 0; symbols.length > i$2; )wks(symbols[i$2++]);

for(var symbols = $keys$1(wks.store), i$2 = 0; symbols.length > i$2; )wksDefine(symbols[i$2++]);

$export$3($export$3.S + $export$3.F * !USE_NATIVE, 'Symbol', {
  // 19.4.2.1 Symbol.for(key)
  'for': function(key){
    return has$5(SymbolRegistry, key += '')
      ? SymbolRegistry[key]
      : SymbolRegistry[key] = $Symbol(key);
  },
  // 19.4.2.5 Symbol.keyFor(sym)
  keyFor: function keyFor(key){
    if(isSymbol(key))return keyOf(SymbolRegistry, key);
    throw TypeError(key + ' is not a symbol!');
  },
  useSetter: function(){ setter = true; },
  useSimple: function(){ setter = false; }
});

$export$3($export$3.S + $export$3.F * !USE_NATIVE, 'Object', {
  // 19.1.2.2 Object.create(O [, Properties])
  create: $create,
  // 19.1.2.4 Object.defineProperty(O, P, Attributes)
  defineProperty: $defineProperty,
  // 19.1.2.3 Object.defineProperties(O, Properties)
  defineProperties: $defineProperties,
  // 19.1.2.6 Object.getOwnPropertyDescriptor(O, P)
  getOwnPropertyDescriptor: $getOwnPropertyDescriptor,
  // 19.1.2.7 Object.getOwnPropertyNames(O)
  getOwnPropertyNames: $getOwnPropertyNames,
  // 19.1.2.8 Object.getOwnPropertySymbols(O)
  getOwnPropertySymbols: $getOwnPropertySymbols
});

// 24.3.2 JSON.stringify(value [, replacer [, space]])
$JSON && $export$3($export$3.S + $export$3.F * (!USE_NATIVE || $fails(function(){
  var S = $Symbol();
  // MS Edge converts symbol values to JSON as {}
  // WebKit converts symbol values to JSON as null
  // V8 throws on boxed symbols
  return _stringify([S]) != '[null]' || _stringify({a: S}) != '{}' || _stringify(Object(S)) != '{}';
})), 'JSON', {
  stringify: function stringify(it){
    if(it === undefined || isSymbol(it))return; // IE8 returns string on undefined
    var args = [it]
      , i    = 1
      , replacer, $replacer;
    while(arguments.length > i)args.push(arguments[i++]);
    replacer = args[1];
    if(typeof replacer == 'function')$replacer = replacer;
    if($replacer || !isArray$1(replacer))replacer = function(key, value){
      if($replacer)value = $replacer.call(this, key, value);
      if(!isSymbol(value))return value;
    };
    args[1] = replacer;
    return _stringify.apply($JSON, args);
  }
});

// 19.4.3.4 Symbol.prototype[@@toPrimitive](hint)
$Symbol[PROTOTYPE$2][TO_PRIMITIVE] || _hide($Symbol[PROTOTYPE$2], TO_PRIMITIVE, $Symbol[PROTOTYPE$2].valueOf);
// 19.4.3.5 Symbol.prototype[@@toStringTag]
setToStringTag$2($Symbol, 'Symbol');
// 20.2.1.9 Math[@@toStringTag]
setToStringTag$2(Math, 'Math', true);
// 24.3.3 JSON[@@toStringTag]
setToStringTag$2(global$4.JSON, 'JSON', true);

_wksDefine('asyncIterator');

_wksDefine('observable');

var index = _core.Symbol;

var symbol = createCommonjsModule(function (module) {
module.exports = { "default": index, __esModule: true };
});

var _typeof_1 = createCommonjsModule(function (module, exports) {
"use strict";

exports.__esModule = true;

var _iterator = iterator;

var _iterator2 = _interopRequireDefault(_iterator);

var _symbol = symbol;

var _symbol2 = _interopRequireDefault(_symbol);

var _typeof = typeof _symbol2.default === "function" && typeof _iterator2.default === "symbol" ? function (obj) { return typeof obj; } : function (obj) { return obj && typeof _symbol2.default === "function" && obj.constructor === _symbol2.default && obj !== _symbol2.default.prototype ? "symbol" : typeof obj; };

function _interopRequireDefault(obj) { return obj && obj.__esModule ? obj : { default: obj }; }

exports.default = typeof _symbol2.default === "function" && _typeof(_iterator2.default) === "symbol" ? function (obj) {
  return typeof obj === "undefined" ? "undefined" : _typeof(obj);
} : function (obj) {
  return obj && typeof _symbol2.default === "function" && obj.constructor === _symbol2.default && obj !== _symbol2.default.prototype ? "symbol" : typeof obj === "undefined" ? "undefined" : _typeof(obj);
};
});

var possibleConstructorReturn = createCommonjsModule(function (module, exports) {
"use strict";

exports.__esModule = true;

var _typeof2 = _typeof_1;

var _typeof3 = _interopRequireDefault(_typeof2);

function _interopRequireDefault(obj) { return obj && obj.__esModule ? obj : { default: obj }; }

exports.default = function (self, call) {
  if (!self) {
    throw new ReferenceError("this hasn't been initialised - super() hasn't been called");
  }

  return call && ((typeof call === "undefined" ? "undefined" : (0, _typeof3.default)(call)) === "object" || typeof call === "function") ? call : self;
};
});

var _possibleConstructorReturn = unwrapExports(possibleConstructorReturn);

var $export$4 = _export;
// 19.1.2.4 / 15.2.3.6 Object.defineProperty(O, P, Attributes)
$export$4($export$4.S + $export$4.F * !_descriptors, 'Object', {defineProperty: _objectDp.f});

var $Object = _core.Object;
var defineProperty$4 = function defineProperty$4(it, key, desc){
  return $Object.defineProperty(it, key, desc);
};

var defineProperty$2 = createCommonjsModule(function (module) {
module.exports = { "default": defineProperty$4, __esModule: true };
});

var createClass = createCommonjsModule(function (module, exports) {
"use strict";

exports.__esModule = true;

var _defineProperty = defineProperty$2;

var _defineProperty2 = _interopRequireDefault(_defineProperty);

function _interopRequireDefault(obj) { return obj && obj.__esModule ? obj : { default: obj }; }

exports.default = function () {
  function defineProperties(target, props) {
    for (var i = 0; i < props.length; i++) {
      var descriptor = props[i];
      descriptor.enumerable = descriptor.enumerable || false;
      descriptor.configurable = true;
      if ("value" in descriptor) descriptor.writable = true;
      (0, _defineProperty2.default)(target, descriptor.key, descriptor);
    }
  }

  return function (Constructor, protoProps, staticProps) {
    if (protoProps) defineProperties(Constructor.prototype, protoProps);
    if (staticProps) defineProperties(Constructor, staticProps);
    return Constructor;
  };
}();
});

var _createClass = unwrapExports(createClass);

// Works with __proto__ only. Old v8 can't work with null proto objects.
/* eslint-disable no-proto */
var isObject$3 = _isObject;
var anObject$4 = _anObject;
var check = function(O, proto){
  anObject$4(O);
  if(!isObject$3(proto) && proto !== null)throw TypeError(proto + ": can't set as prototype!");
};
var _setProto = {
  set: Object.setPrototypeOf || ('__proto__' in {} ? // eslint-disable-line
    function(test, buggy, set){
      try {
        set = _ctx(Function.call, _objectGopd.f(Object.prototype, '__proto__').set, 2);
        set(test, []);
        buggy = !(test instanceof Array);
      } catch(e){ buggy = true; }
      return function setPrototypeOf(O, proto){
        check(O, proto);
        if(buggy)O.__proto__ = proto;
        else set(O, proto);
        return O;
      };
    }({}, false) : undefined),
  check: check
};

// 19.1.3.19 Object.setPrototypeOf(O, proto)
var $export$5 = _export;
$export$5($export$5.S, 'Object', {setPrototypeOf: _setProto.set});

var setPrototypeOf$3 = _core.Object.setPrototypeOf;

var setPrototypeOf$1 = createCommonjsModule(function (module) {
module.exports = { "default": setPrototypeOf$3, __esModule: true };
});

var $export$6 = _export;
// 19.1.2.2 / 15.2.3.5 Object.create(O [, Properties])
$export$6($export$6.S, 'Object', {create: _objectCreate});

var $Object$1 = _core.Object;
var create$4 = function create$4(P, D){
  return $Object$1.create(P, D);
};

var create$2 = createCommonjsModule(function (module) {
module.exports = { "default": create$4, __esModule: true };
});

var inherits = createCommonjsModule(function (module, exports) {
"use strict";

exports.__esModule = true;

var _setPrototypeOf = setPrototypeOf$1;

var _setPrototypeOf2 = _interopRequireDefault(_setPrototypeOf);

var _create = create$2;

var _create2 = _interopRequireDefault(_create);

var _typeof2 = _typeof_1;

var _typeof3 = _interopRequireDefault(_typeof2);

function _interopRequireDefault(obj) { return obj && obj.__esModule ? obj : { default: obj }; }

exports.default = function (subClass, superClass) {
  if (typeof superClass !== "function" && superClass !== null) {
    throw new TypeError("Super expression must either be null or a function, not " + (typeof superClass === "undefined" ? "undefined" : (0, _typeof3.default)(superClass)));
  }

  subClass.prototype = (0, _create2.default)(superClass && superClass.prototype, {
    constructor: {
      value: subClass,
      enumerable: false,
      writable: true,
      configurable: true
    }
  });
  if (superClass) _setPrototypeOf2.default ? (0, _setPrototypeOf2.default)(subClass, superClass) : subClass.__proto__ = superClass;
};
});

var _inherits = unwrapExports(inherits);

var _global$2 = createCommonjsModule(function (module) {
// https://github.com/zloirock/core-js/issues/86#issuecomment-115759028
var global = module.exports = typeof window != 'undefined' && window.Math == Math
  ? window : typeof self != 'undefined' && self.Math == Math ? self : Function('return this')();
if(typeof __g == 'number')__g = global; // eslint-disable-line no-undef
});

var hasOwnProperty$1 = {}.hasOwnProperty;
var _has$2 = function(it, key){
  return hasOwnProperty$1.call(it, key);
};

var _fails$2 = function(exec){
  try {
    return !!exec();
  } catch(e){
    return true;
  }
};

// Thank's IE8 for his funny defineProperty
var _descriptors$2 = !_fails$2(function(){
  return Object.defineProperty({}, 'a', {get: function(){ return 7; }}).a != 7;
});

var _core$2 = createCommonjsModule(function (module) {
var core = module.exports = {version: '2.4.0'};
if(typeof __e == 'number')__e = core; // eslint-disable-line no-undef
});

var _isObject$2 = function(it){
  return typeof it === 'object' ? it !== null : typeof it === 'function';
};

var isObject$4 = _isObject$2;
var _anObject$2 = function(it){
  if(!isObject$4(it))throw TypeError(it + ' is not an object!');
  return it;
};

var isObject$5 = _isObject$2;
var document$2 = _global$2.document;
var is$2 = isObject$5(document$2) && isObject$5(document$2.createElement);
var _domCreate$2 = function(it){
  return is$2 ? document$2.createElement(it) : {};
};

var _ie8DomDefine$2 = !_descriptors$2 && !_fails$2(function(){
  return Object.defineProperty(_domCreate$2('div'), 'a', {get: function(){ return 7; }}).a != 7;
});

// 7.1.1 ToPrimitive(input [, PreferredType])
var isObject$6 = _isObject$2;
// instead of the ES6 spec version, we didn't implement @@toPrimitive case
// and the second argument - flag - preferred type is a string
var _toPrimitive$2 = function(it, S){
  if(!isObject$6(it))return it;
  var fn, val;
  if(S && typeof (fn = it.toString) == 'function' && !isObject$6(val = fn.call(it)))return val;
  if(typeof (fn = it.valueOf) == 'function' && !isObject$6(val = fn.call(it)))return val;
  if(!S && typeof (fn = it.toString) == 'function' && !isObject$6(val = fn.call(it)))return val;
  throw TypeError("Can't convert object to primitive value");
};

var anObject$6       = _anObject$2;
var IE8_DOM_DEFINE$2 = _ie8DomDefine$2;
var toPrimitive$4    = _toPrimitive$2;
var dP$6             = Object.defineProperty;

var f$8 = _descriptors$2 ? Object.defineProperty : function defineProperty(O, P, Attributes){
  anObject$6(O);
  P = toPrimitive$4(P, true);
  anObject$6(Attributes);
  if(IE8_DOM_DEFINE$2)try {
    return dP$6(O, P, Attributes);
  } catch(e){ /* empty */ }
  if('get' in Attributes || 'set' in Attributes)throw TypeError('Accessors not supported!');
  if('value' in Attributes)O[P] = Attributes.value;
  return O;
};

var _objectDp$2 = {
	f: f$8
};

var _propertyDesc$2 = function(bitmap, value){
  return {
    enumerable  : !(bitmap & 1),
    configurable: !(bitmap & 2),
    writable    : !(bitmap & 4),
    value       : value
  };
};

var dP$5         = _objectDp$2;
var createDesc$4 = _propertyDesc$2;
var _hide$2 = _descriptors$2 ? function(object, key, value){
  return dP$5.f(object, key, createDesc$4(1, value));
} : function(object, key, value){
  object[key] = value;
  return object;
};

var id$1 = 0;
var px$1 = Math.random();
var _uid$2 = function(key){
  return 'Symbol('.concat(key === undefined ? '' : key, ')_', (++id$1 + px$1).toString(36));
};

var _redefine$2 = createCommonjsModule(function (module) {
var global    = _global$2
  , hide      = _hide$2
  , has       = _has$2
  , SRC       = _uid$2('src')
  , TO_STRING = 'toString'
  , $toString = Function[TO_STRING]
  , TPL       = ('' + $toString).split(TO_STRING);

_core$2.inspectSource = function(it){
  return $toString.call(it);
};

(module.exports = function(O, key, val, safe){
  var isFunction = typeof val == 'function';
  if(isFunction)has(val, 'name') || hide(val, 'name', key);
  if(O[key] === val)return;
  if(isFunction)has(val, SRC) || hide(val, SRC, O[key] ? '' + O[key] : TPL.join(String(key)));
  if(O === global){
    O[key] = val;
  } else {
    if(!safe){
      delete O[key];
      hide(O, key, val);
    } else {
      if(O[key])O[key] = val;
      else hide(O, key, val);
    }
  }
// add fake Function#toString for correct work wrapped methods / constructors with methods like LoDash isNative
})(Function.prototype, TO_STRING, function toString(){
  return typeof this == 'function' && this[SRC] || $toString.call(this);
});
});

var _aFunction$2 = function(it){
  if(typeof it != 'function')throw TypeError(it + ' is not a function!');
  return it;
};

// optional / simple context binding
var aFunction$1 = _aFunction$2;
var _ctx$2 = function(fn, that, length){
  aFunction$1(fn);
  if(that === undefined)return fn;
  switch(length){
    case 1: return function(a){
      return fn.call(that, a);
    };
    case 2: return function(a, b){
      return fn.call(that, a, b);
    };
    case 3: return function(a, b, c){
      return fn.call(that, a, b, c);
    };
  }
  return function(/* ...args */){
    return fn.apply(that, arguments);
  };
};

var global$7    = _global$2;
var core$3      = _core$2;
var hide$3      = _hide$2;
var redefine$3  = _redefine$2;
var ctx$1       = _ctx$2;
var PROTOTYPE$4 = 'prototype';

var $export$8 = function(type, name, source){
  var IS_FORCED = type & $export$8.F
    , IS_GLOBAL = type & $export$8.G
    , IS_STATIC = type & $export$8.S
    , IS_PROTO  = type & $export$8.P
    , IS_BIND   = type & $export$8.B
    , target    = IS_GLOBAL ? global$7 : IS_STATIC ? global$7[name] || (global$7[name] = {}) : (global$7[name] || {})[PROTOTYPE$4]
    , exports   = IS_GLOBAL ? core$3 : core$3[name] || (core$3[name] = {})
    , expProto  = exports[PROTOTYPE$4] || (exports[PROTOTYPE$4] = {})
    , key, own, out, exp;
  if(IS_GLOBAL)source = name;
  for(key in source){
    // contains in native
    own = !IS_FORCED && target && target[key] !== undefined;
    // export native or passed
    out = (own ? target : source)[key];
    // bind timers to global for call from export context
    exp = IS_BIND && own ? ctx$1(out, global$7) : IS_PROTO && typeof out == 'function' ? ctx$1(Function.call, out) : out;
    // extend global
    if(target)redefine$3(target, key, out, type & $export$8.U);
    // export
    if(exports[key] != out)hide$3(exports, key, exp);
    if(IS_PROTO && expProto[key] != out)expProto[key] = out;
  }
};
global$7.core = core$3;
// type bitmap
$export$8.F = 1;   // forced
$export$8.G = 2;   // global
$export$8.S = 4;   // static
$export$8.P = 8;   // proto
$export$8.B = 16;  // bind
$export$8.W = 32;  // wrap
$export$8.U = 64;  // safe
$export$8.R = 128; // real proto method for `library` 
var _export$2 = $export$8;

var _meta$2 = createCommonjsModule(function (module) {
var META     = _uid$2('meta')
  , isObject = _isObject$2
  , has      = _has$2
  , setDesc  = _objectDp$2.f
  , id       = 0;
var isExtensible = Object.isExtensible || function(){
  return true;
};
var FREEZE = !_fails$2(function(){
  return isExtensible(Object.preventExtensions({}));
});
var setMeta = function(it){
  setDesc(it, META, {value: {
    i: 'O' + ++id, // object ID
    w: {}          // weak collections IDs
  }});
};
var fastKey = function(it, create){
  // return primitive with prefix
  if(!isObject(it))return typeof it == 'symbol' ? it : (typeof it == 'string' ? 'S' : 'P') + it;
  if(!has(it, META)){
    // can't set metadata to uncaught frozen object
    if(!isExtensible(it))return 'F';
    // not necessary to add metadata
    if(!create)return 'E';
    // add missing metadata
    setMeta(it);
  // return object ID
  } return it[META].i;
};
var getWeak = function(it, create){
  if(!has(it, META)){
    // can't set metadata to uncaught frozen object
    if(!isExtensible(it))return true;
    // not necessary to add metadata
    if(!create)return false;
    // add missing metadata
    setMeta(it);
  // return hash weak collections IDs
  } return it[META].w;
};
// add metadata on freeze-family methods calling
var onFreeze = function(it){
  if(FREEZE && meta.NEED && isExtensible(it) && !has(it, META))setMeta(it);
  return it;
};
var meta = module.exports = {
  KEY:      META,
  NEED:     false,
  fastKey:  fastKey,
  getWeak:  getWeak,
  onFreeze: onFreeze
};
});

var global$8 = _global$2;
var SHARED$1 = '__core-js_shared__';
var store$1  = global$8[SHARED$1] || (global$8[SHARED$1] = {});
var _shared$2 = function(key){
  return store$1[key] || (store$1[key] = {});
};

var _wks$2 = createCommonjsModule(function (module) {
var store      = _shared$2('wks')
  , uid        = _uid$2
  , Symbol     = _global$2.Symbol
  , USE_SYMBOL = typeof Symbol == 'function';

var $exports = module.exports = function(name){
  return store[name] || (store[name] =
    USE_SYMBOL && Symbol[name] || (USE_SYMBOL ? Symbol : uid)('Symbol.' + name));
};

$exports.store = store;
});

var def$1 = _objectDp$2.f;
var has$8 = _has$2;
var TAG$1 = _wks$2('toStringTag');

var _setToStringTag$2 = function(it, tag, stat){
  if(it && !has$8(it = stat ? it : it.prototype, TAG$1))def$1(it, TAG$1, {configurable: true, value: tag});
};

var f$9 = _wks$2;

var _wksExt$2 = {
	f: f$9
};

var _library$2 = false;

var global$9         = _global$2;
var core$4           = _core$2;
var LIBRARY$2        = _library$2;
var wksExt$3         = _wksExt$2;
var defineProperty$6 = _objectDp$2.f;
var _wksDefine$2 = function(name){
  var $Symbol = core$4.Symbol || (core$4.Symbol = LIBRARY$2 ? {} : global$9.Symbol || {});
  if(name.charAt(0) != '_' && !(name in $Symbol))defineProperty$6($Symbol, name, {value: wksExt$3.f(name)});
};

var toString$3 = {}.toString;

var _cof$2 = function(it){
  return toString$3.call(it).slice(8, -1);
};

// fallback for non-array-like ES3 and non-enumerable old V8 strings
var cof$2 = _cof$2;
var _iobject$2 = Object('z').propertyIsEnumerable(0) ? Object : function(it){
  return cof$2(it) == 'String' ? it.split('') : Object(it);
};

// 7.2.1 RequireObjectCoercible(argument)
var _defined$2 = function(it){
  if(it == undefined)throw TypeError("Can't call method on  " + it);
  return it;
};

// to indexed object, toObject with fallback for non-array-like ES3 strings
var IObject$1 = _iobject$2;
var defined$3 = _defined$2;
var _toIobject$2 = function(it){
  return IObject$1(defined$3(it));
};

// 7.1.4 ToInteger
var ceil$1  = Math.ceil;
var floor$1 = Math.floor;
var _toInteger$2 = function(it){
  return isNaN(it = +it) ? 0 : (it > 0 ? floor$1 : ceil$1)(it);
};

// 7.1.15 ToLength
var toInteger$3 = _toInteger$2;
var min$2       = Math.min;
var _toLength$2 = function(it){
  return it > 0 ? min$2(toInteger$3(it), 0x1fffffffffffff) : 0; // pow(2, 53) - 1 == 9007199254740991
};

var toInteger$4 = _toInteger$2;
var max$1       = Math.max;
var min$3       = Math.min;
var _toIndex$2 = function(index, length){
  index = toInteger$4(index);
  return index < 0 ? max$1(index + length, 0) : min$3(index, length);
};

// false -> Array#indexOf
// true  -> Array#includes
var toIObject$10 = _toIobject$2;
var toLength$1  = _toLength$2;
var toIndex$1   = _toIndex$2;
var _arrayIncludes$2 = function(IS_INCLUDES){
  return function($this, el, fromIndex){
    var O      = toIObject$10($this)
      , length = toLength$1(O.length)
      , index  = toIndex$1(fromIndex, length)
      , value;
    // Array#includes uses SameValueZero equality algorithm
    if(IS_INCLUDES && el != el)while(length > index){
      value = O[index++];
      if(value != value)return true;
    // Array#toIndex ignores holes, Array#includes - not
    } else for(;length > index; index++)if(IS_INCLUDES || index in O){
      if(O[index] === el)return IS_INCLUDES || index || 0;
    } return !IS_INCLUDES && -1;
  };
};

var shared$3 = _shared$2('keys');
var uid$3    = _uid$2;
var _sharedKey$2 = function(key){
  return shared$3[key] || (shared$3[key] = uid$3(key));
};

var has$9          = _has$2;
var toIObject$9    = _toIobject$2;
var arrayIndexOf$1 = _arrayIncludes$2(false);
var IE_PROTO$3     = _sharedKey$2('IE_PROTO');

var _objectKeysInternal$2 = function(object, names){
  var O      = toIObject$9(object)
    , i      = 0
    , result = []
    , key;
  for(key in O)if(key != IE_PROTO$3)has$9(O, key) && result.push(key);
  // Don't enum bug & hidden keys
  while(names.length > i)if(has$9(O, key = names[i++])){
    ~arrayIndexOf$1(result, key) || result.push(key);
  }
  return result;
};

// IE 8- don't enum bug keys
var _enumBugKeys$2 = (
  'constructor,hasOwnProperty,isPrototypeOf,propertyIsEnumerable,toLocaleString,toString,valueOf'
).split(',');

// 19.1.2.14 / 15.2.3.14 Object.keys(O)
var $keys$4       = _objectKeysInternal$2;
var enumBugKeys$2 = _enumBugKeys$2;

var _objectKeys$2 = Object.keys || function keys(O){
  return $keys$4(O, enumBugKeys$2);
};

var getKeys$3   = _objectKeys$2;
var toIObject$8 = _toIobject$2;
var _keyof$2 = function(object, el){
  var O      = toIObject$8(object)
    , keys   = getKeys$3(O)
    , length = keys.length
    , index  = 0
    , key;
  while(length > index)if(O[key = keys[index++]] === el)return key;
};

var f$10 = Object.getOwnPropertySymbols;

var _objectGops$2 = {
	f: f$10
};

var f$11 = {}.propertyIsEnumerable;

var _objectPie$2 = {
	f: f$11
};

// all enumerable object keys, includes symbols
var getKeys$4 = _objectKeys$2;
var gOPS$1    = _objectGops$2;
var pIE$2     = _objectPie$2;
var _enumKeys$2 = function(it){
  var result     = getKeys$4(it)
    , getSymbols = gOPS$1.f;
  if(getSymbols){
    var symbols = getSymbols(it)
      , isEnum  = pIE$2.f
      , i       = 0
      , key;
    while(symbols.length > i)if(isEnum.call(it, key = symbols[i++]))result.push(key);
  } return result;
};

// 7.2.2 IsArray(argument)
var cof$3 = _cof$2;
var _isArray$2 = Array.isArray || function isArray(arg){
  return cof$3(arg) == 'Array';
};

var dP$7       = _objectDp$2;
var anObject$8 = _anObject$2;
var getKeys$5  = _objectKeys$2;

var _objectDps$2 = _descriptors$2 ? Object.defineProperties : function defineProperties(O, Properties){
  anObject$8(O);
  var keys   = getKeys$5(Properties)
    , length = keys.length
    , i = 0
    , P;
  while(length > i)dP$7.f(O, P = keys[i++], Properties[P]);
  return O;
};

var _html$2 = _global$2.document && document.documentElement;

// 19.1.2.2 / 15.2.3.5 Object.create(O [, Properties])
var anObject$7    = _anObject$2;
var dPs$1         = _objectDps$2;
var enumBugKeys$3 = _enumBugKeys$2;
var IE_PROTO$4    = _sharedKey$2('IE_PROTO');
var Empty$1       = function(){ /* empty */ };
var PROTOTYPE$5   = 'prototype';

// Create object with fake `null` prototype: use iframe Object with cleared prototype
var createDict$1 = function(){
  // Thrash, waste and sodomy: IE GC bug
  var iframe = _domCreate$2('iframe')
    , i      = enumBugKeys$3.length
    , lt     = '<'
    , gt     = '>'
    , iframeDocument;
  iframe.style.display = 'none';
  _html$2.appendChild(iframe);
  iframe.src = 'javascript:'; // eslint-disable-line no-script-url
  // createDict = iframe.contentWindow.Object;
  // html.removeChild(iframe);
  iframeDocument = iframe.contentWindow.document;
  iframeDocument.open();
  iframeDocument.write(lt + 'script' + gt + 'document.F=Object' + lt + '/script' + gt);
  iframeDocument.close();
  createDict$1 = iframeDocument.F;
  while(i--)delete createDict$1[PROTOTYPE$5][enumBugKeys$3[i]];
  return createDict$1();
};

var _objectCreate$2 = Object.create || function create(O, Properties){
  var result;
  if(O !== null){
    Empty$1[PROTOTYPE$5] = anObject$7(O);
    result = new Empty$1;
    Empty$1[PROTOTYPE$5] = null;
    // add "__proto__" for Object.getPrototypeOf polyfill
    result[IE_PROTO$4] = O;
  } else result = createDict$1();
  return Properties === undefined ? result : dPs$1(result, Properties);
};

// 19.1.2.7 / 15.2.3.4 Object.getOwnPropertyNames(O)
var $keys$5      = _objectKeysInternal$2;
var hiddenKeys$1 = _enumBugKeys$2.concat('length', 'prototype');

var f$13 = Object.getOwnPropertyNames || function getOwnPropertyNames(O){
  return $keys$5(O, hiddenKeys$1);
};

var _objectGopn$2 = {
	f: f$13
};

// fallback for IE11 buggy Object.getOwnPropertyNames with iframe and window
var toIObject$11 = _toIobject$2;
var gOPN$3      = _objectGopn$2.f;
var toString$4  = {}.toString;

var windowNames$1 = typeof window == 'object' && window && Object.getOwnPropertyNames
  ? Object.getOwnPropertyNames(window) : [];

var getWindowNames$1 = function(it){
  try {
    return gOPN$3(it);
  } catch(e){
    return windowNames$1.slice();
  }
};

var f$12 = function getOwnPropertyNames(it){
  return windowNames$1 && toString$4.call(it) == '[object Window]' ? getWindowNames$1(it) : gOPN$3(toIObject$11(it));
};

var _objectGopnExt$2 = {
	f: f$12
};

var pIE$3            = _objectPie$2;
var createDesc$5     = _propertyDesc$2;
var toIObject$12      = _toIobject$2;
var toPrimitive$5    = _toPrimitive$2;
var has$10            = _has$2;
var IE8_DOM_DEFINE$3 = _ie8DomDefine$2;
var gOPD$3           = Object.getOwnPropertyDescriptor;

var f$14 = _descriptors$2 ? gOPD$3 : function getOwnPropertyDescriptor(O, P){
  O = toIObject$12(O);
  P = toPrimitive$5(P, true);
  if(IE8_DOM_DEFINE$3)try {
    return gOPD$3(O, P);
  } catch(e){ /* empty */ }
  if(has$10(O, P))return createDesc$5(!pIE$3.f.call(O, P), O[P]);
};

var _objectGopd$2 = {
	f: f$14
};

// ECMAScript 6 symbols shim
var global$6         = _global$2;
var has$7            = _has$2;
var DESCRIPTORS$1    = _descriptors$2;
var $export$7        = _export$2;
var redefine$2       = _redefine$2;
var META$1           = _meta$2.KEY;
var $fails$1         = _fails$2;
var shared$2         = _shared$2;
var setToStringTag$3 = _setToStringTag$2;
var uid$2            = _uid$2;
var wks$1            = _wks$2;
var wksExt$2         = _wksExt$2;
var wksDefine$1      = _wksDefine$2;
var keyOf$1          = _keyof$2;
var enumKeys$1       = _enumKeys$2;
var isArray$2        = _isArray$2;
var anObject$5       = _anObject$2;
var toIObject$7      = _toIobject$2;
var toPrimitive$3    = _toPrimitive$2;
var createDesc$3     = _propertyDesc$2;
var _create$1        = _objectCreate$2;
var gOPNExt$1        = _objectGopnExt$2;
var $GOPD$1          = _objectGopd$2;
var $DP$1            = _objectDp$2;
var $keys$3          = _objectKeys$2;
var gOPD$2           = $GOPD$1.f;
var dP$4             = $DP$1.f;
var gOPN$2           = gOPNExt$1.f;
var $Symbol$1        = global$6.Symbol;
var $JSON$1          = global$6.JSON;
var _stringify$1     = $JSON$1 && $JSON$1.stringify;
var PROTOTYPE$3      = 'prototype';
var HIDDEN$1         = wks$1('_hidden');
var TO_PRIMITIVE$1   = wks$1('toPrimitive');
var isEnum$1         = {}.propertyIsEnumerable;
var SymbolRegistry$1 = shared$2('symbol-registry');
var AllSymbols$1     = shared$2('symbols');
var OPSymbols$1      = shared$2('op-symbols');
var ObjectProto$2    = Object[PROTOTYPE$3];
var USE_NATIVE$1     = typeof $Symbol$1 == 'function';
var QObject$1        = global$6.QObject;
// Don't use setters in Qt Script, https://github.com/zloirock/core-js/issues/173
var setter$1 = !QObject$1 || !QObject$1[PROTOTYPE$3] || !QObject$1[PROTOTYPE$3].findChild;

// fallback for old Android, https://code.google.com/p/v8/issues/detail?id=687
var setSymbolDesc$1 = DESCRIPTORS$1 && $fails$1(function(){
  return _create$1(dP$4({}, 'a', {
    get: function(){ return dP$4(this, 'a', {value: 7}).a; }
  })).a != 7;
}) ? function(it, key, D){
  var protoDesc = gOPD$2(ObjectProto$2, key);
  if(protoDesc)delete ObjectProto$2[key];
  dP$4(it, key, D);
  if(protoDesc && it !== ObjectProto$2)dP$4(ObjectProto$2, key, protoDesc);
} : dP$4;

var wrap$1 = function(tag){
  var sym = AllSymbols$1[tag] = _create$1($Symbol$1[PROTOTYPE$3]);
  sym._k = tag;
  return sym;
};

var isSymbol$1 = USE_NATIVE$1 && typeof $Symbol$1.iterator == 'symbol' ? function(it){
  return typeof it == 'symbol';
} : function(it){
  return it instanceof $Symbol$1;
};

var $defineProperty$1 = function defineProperty(it, key, D){
  if(it === ObjectProto$2)$defineProperty$1(OPSymbols$1, key, D);
  anObject$5(it);
  key = toPrimitive$3(key, true);
  anObject$5(D);
  if(has$7(AllSymbols$1, key)){
    if(!D.enumerable){
      if(!has$7(it, HIDDEN$1))dP$4(it, HIDDEN$1, createDesc$3(1, {}));
      it[HIDDEN$1][key] = true;
    } else {
      if(has$7(it, HIDDEN$1) && it[HIDDEN$1][key])it[HIDDEN$1][key] = false;
      D = _create$1(D, {enumerable: createDesc$3(0, false)});
    } return setSymbolDesc$1(it, key, D);
  } return dP$4(it, key, D);
};
var $defineProperties$1 = function defineProperties(it, P){
  anObject$5(it);
  var keys = enumKeys$1(P = toIObject$7(P))
    , i    = 0
    , l = keys.length
    , key;
  while(l > i)$defineProperty$1(it, key = keys[i++], P[key]);
  return it;
};
var $create$1 = function create(it, P){
  return P === undefined ? _create$1(it) : $defineProperties$1(_create$1(it), P);
};
var $propertyIsEnumerable$1 = function propertyIsEnumerable(key){
  var E = isEnum$1.call(this, key = toPrimitive$3(key, true));
  if(this === ObjectProto$2 && has$7(AllSymbols$1, key) && !has$7(OPSymbols$1, key))return false;
  return E || !has$7(this, key) || !has$7(AllSymbols$1, key) || has$7(this, HIDDEN$1) && this[HIDDEN$1][key] ? E : true;
};
var $getOwnPropertyDescriptor$1 = function getOwnPropertyDescriptor(it, key){
  it  = toIObject$7(it);
  key = toPrimitive$3(key, true);
  if(it === ObjectProto$2 && has$7(AllSymbols$1, key) && !has$7(OPSymbols$1, key))return;
  var D = gOPD$2(it, key);
  if(D && has$7(AllSymbols$1, key) && !(has$7(it, HIDDEN$1) && it[HIDDEN$1][key]))D.enumerable = true;
  return D;
};
var $getOwnPropertyNames$1 = function getOwnPropertyNames(it){
  var names  = gOPN$2(toIObject$7(it))
    , result = []
    , i      = 0
    , key;
  while(names.length > i){
    if(!has$7(AllSymbols$1, key = names[i++]) && key != HIDDEN$1 && key != META$1)result.push(key);
  } return result;
};
var $getOwnPropertySymbols$1 = function getOwnPropertySymbols(it){
  var IS_OP  = it === ObjectProto$2
    , names  = gOPN$2(IS_OP ? OPSymbols$1 : toIObject$7(it))
    , result = []
    , i      = 0
    , key;
  while(names.length > i){
    if(has$7(AllSymbols$1, key = names[i++]) && (IS_OP ? has$7(ObjectProto$2, key) : true))result.push(AllSymbols$1[key]);
  } return result;
};

// 19.4.1.1 Symbol([description])
if(!USE_NATIVE$1){
  $Symbol$1 = function Symbol(){
    if(this instanceof $Symbol$1)throw TypeError('Symbol is not a constructor!');
    var tag = uid$2(arguments.length > 0 ? arguments[0] : undefined);
    var $set = function(value){
      if(this === ObjectProto$2)$set.call(OPSymbols$1, value);
      if(has$7(this, HIDDEN$1) && has$7(this[HIDDEN$1], tag))this[HIDDEN$1][tag] = false;
      setSymbolDesc$1(this, tag, createDesc$3(1, value));
    };
    if(DESCRIPTORS$1 && setter$1)setSymbolDesc$1(ObjectProto$2, tag, {configurable: true, set: $set});
    return wrap$1(tag);
  };
  redefine$2($Symbol$1[PROTOTYPE$3], 'toString', function toString(){
    return this._k;
  });

  $GOPD$1.f = $getOwnPropertyDescriptor$1;
  $DP$1.f   = $defineProperty$1;
  _objectGopn$2.f = gOPNExt$1.f = $getOwnPropertyNames$1;
  _objectPie$2.f  = $propertyIsEnumerable$1;
  _objectGops$2.f = $getOwnPropertySymbols$1;

  if(DESCRIPTORS$1 && !_library$2){
    redefine$2(ObjectProto$2, 'propertyIsEnumerable', $propertyIsEnumerable$1, true);
  }

  wksExt$2.f = function(name){
    return wrap$1(wks$1(name));
  };
}

$export$7($export$7.G + $export$7.W + $export$7.F * !USE_NATIVE$1, {Symbol: $Symbol$1});

for(var symbols$1 = (
  // 19.4.2.2, 19.4.2.3, 19.4.2.4, 19.4.2.6, 19.4.2.8, 19.4.2.9, 19.4.2.10, 19.4.2.11, 19.4.2.12, 19.4.2.13, 19.4.2.14
  'hasInstance,isConcatSpreadable,iterator,match,replace,search,species,split,toPrimitive,toStringTag,unscopables'
).split(','), i$3 = 0; symbols$1.length > i$3; )wks$1(symbols$1[i$3++]);

for(var symbols$1 = $keys$3(wks$1.store), i$3 = 0; symbols$1.length > i$3; )wksDefine$1(symbols$1[i$3++]);

$export$7($export$7.S + $export$7.F * !USE_NATIVE$1, 'Symbol', {
  // 19.4.2.1 Symbol.for(key)
  'for': function(key){
    return has$7(SymbolRegistry$1, key += '')
      ? SymbolRegistry$1[key]
      : SymbolRegistry$1[key] = $Symbol$1(key);
  },
  // 19.4.2.5 Symbol.keyFor(sym)
  keyFor: function keyFor(key){
    if(isSymbol$1(key))return keyOf$1(SymbolRegistry$1, key);
    throw TypeError(key + ' is not a symbol!');
  },
  useSetter: function(){ setter$1 = true; },
  useSimple: function(){ setter$1 = false; }
});

$export$7($export$7.S + $export$7.F * !USE_NATIVE$1, 'Object', {
  // 19.1.2.2 Object.create(O [, Properties])
  create: $create$1,
  // 19.1.2.4 Object.defineProperty(O, P, Attributes)
  defineProperty: $defineProperty$1,
  // 19.1.2.3 Object.defineProperties(O, Properties)
  defineProperties: $defineProperties$1,
  // 19.1.2.6 Object.getOwnPropertyDescriptor(O, P)
  getOwnPropertyDescriptor: $getOwnPropertyDescriptor$1,
  // 19.1.2.7 Object.getOwnPropertyNames(O)
  getOwnPropertyNames: $getOwnPropertyNames$1,
  // 19.1.2.8 Object.getOwnPropertySymbols(O)
  getOwnPropertySymbols: $getOwnPropertySymbols$1
});

// 24.3.2 JSON.stringify(value [, replacer [, space]])
$JSON$1 && $export$7($export$7.S + $export$7.F * (!USE_NATIVE$1 || $fails$1(function(){
  var S = $Symbol$1();
  // MS Edge converts symbol values to JSON as {}
  // WebKit converts symbol values to JSON as null
  // V8 throws on boxed symbols
  return _stringify$1([S]) != '[null]' || _stringify$1({a: S}) != '{}' || _stringify$1(Object(S)) != '{}';
})), 'JSON', {
  stringify: function stringify(it){
    if(it === undefined || isSymbol$1(it))return; // IE8 returns string on undefined
    var args = [it]
      , i    = 1
      , replacer, $replacer;
    while(arguments.length > i)args.push(arguments[i++]);
    replacer = args[1];
    if(typeof replacer == 'function')$replacer = replacer;
    if($replacer || !isArray$2(replacer))replacer = function(key, value){
      if($replacer)value = $replacer.call(this, key, value);
      if(!isSymbol$1(value))return value;
    };
    args[1] = replacer;
    return _stringify$1.apply($JSON$1, args);
  }
});

// 19.4.3.4 Symbol.prototype[@@toPrimitive](hint)
$Symbol$1[PROTOTYPE$3][TO_PRIMITIVE$1] || _hide$2($Symbol$1[PROTOTYPE$3], TO_PRIMITIVE$1, $Symbol$1[PROTOTYPE$3].valueOf);
// 19.4.3.5 Symbol.prototype[@@toStringTag]
setToStringTag$3($Symbol$1, 'Symbol');
// 20.2.1.9 Math[@@toStringTag]
setToStringTag$3(Math, 'Math', true);
// 24.3.3 JSON[@@toStringTag]
setToStringTag$3(global$6.JSON, 'JSON', true);

var $export$9 = _export$2;
// 19.1.2.2 / 15.2.3.5 Object.create(O [, Properties])
$export$9($export$9.S, 'Object', {create: _objectCreate$2});

var $export$10 = _export$2;
// 19.1.2.4 / 15.2.3.6 Object.defineProperty(O, P, Attributes)
$export$10($export$10.S + $export$10.F * !_descriptors$2, 'Object', {defineProperty: _objectDp$2.f});

var $export$11 = _export$2;
// 19.1.2.3 / 15.2.3.7 Object.defineProperties(O, Properties)
$export$11($export$11.S + $export$11.F * !_descriptors$2, 'Object', {defineProperties: _objectDps$2});

// most Object methods by ES6 should accept primitives
var $export$12 = _export$2;
var core$5    = _core$2;
var fails$1   = _fails$2;
var _objectSap$2 = function(KEY, exec){
  var fn  = (core$5.Object || {})[KEY] || Object[KEY]
    , exp = {};
  exp[KEY] = exec(fn);
  $export$12($export$12.S + $export$12.F * fails$1(function(){ fn(1); }), 'Object', exp);
};

// 19.1.2.6 Object.getOwnPropertyDescriptor(O, P)
var toIObject$13                 = _toIobject$2;
var $getOwnPropertyDescriptor$2 = _objectGopd$2.f;

_objectSap$2('getOwnPropertyDescriptor', function(){
  return function getOwnPropertyDescriptor(it, key){
    return $getOwnPropertyDescriptor$2(toIObject$13(it), key);
  };
});

// 7.1.13 ToObject(argument)
var defined$4 = _defined$2;
var _toObject$2 = function(it){
  return Object(defined$4(it));
};

// 19.1.2.9 / 15.2.3.2 Object.getPrototypeOf(O)
var has$11         = _has$2;
var toObject$3    = _toObject$2;
var IE_PROTO$5    = _sharedKey$2('IE_PROTO');
var ObjectProto$3 = Object.prototype;

var _objectGpo$2 = Object.getPrototypeOf || function(O){
  O = toObject$3(O);
  if(has$11(O, IE_PROTO$5))return O[IE_PROTO$5];
  if(typeof O.constructor == 'function' && O instanceof O.constructor){
    return O.constructor.prototype;
  } return O instanceof Object ? ObjectProto$3 : null;
};

// 19.1.2.9 Object.getPrototypeOf(O)
var toObject$2        = _toObject$2;
var $getPrototypeOf$1 = _objectGpo$2;

_objectSap$2('getPrototypeOf', function(){
  return function getPrototypeOf(it){
    return $getPrototypeOf$1(toObject$2(it));
  };
});

// 19.1.2.14 Object.keys(O)
var toObject$4 = _toObject$2;
var $keys$6    = _objectKeys$2;

_objectSap$2('keys', function(){
  return function keys(it){
    return $keys$6(toObject$4(it));
  };
});

// 19.1.2.7 Object.getOwnPropertyNames(O)
_objectSap$2('getOwnPropertyNames', function(){
  return _objectGopnExt$2.f;
});

// 19.1.2.5 Object.freeze(O)
var isObject$7 = _isObject$2;
var meta     = _meta$2.onFreeze;

_objectSap$2('freeze', function($freeze){
  return function freeze(it){
    return $freeze && isObject$7(it) ? $freeze(meta(it)) : it;
  };
});

// 19.1.2.17 Object.seal(O)
var isObject$8 = _isObject$2;
var meta$1     = _meta$2.onFreeze;

_objectSap$2('seal', function($seal){
  return function seal(it){
    return $seal && isObject$8(it) ? $seal(meta$1(it)) : it;
  };
});

// 19.1.2.15 Object.preventExtensions(O)
var isObject$9 = _isObject$2;
var meta$2     = _meta$2.onFreeze;

_objectSap$2('preventExtensions', function($preventExtensions){
  return function preventExtensions(it){
    return $preventExtensions && isObject$9(it) ? $preventExtensions(meta$2(it)) : it;
  };
});

// 19.1.2.12 Object.isFrozen(O)
var isObject$10 = _isObject$2;

_objectSap$2('isFrozen', function($isFrozen){
  return function isFrozen(it){
    return isObject$10(it) ? $isFrozen ? $isFrozen(it) : false : true;
  };
});

// 19.1.2.13 Object.isSealed(O)
var isObject$11 = _isObject$2;

_objectSap$2('isSealed', function($isSealed){
  return function isSealed(it){
    return isObject$11(it) ? $isSealed ? $isSealed(it) : false : true;
  };
});

// 19.1.2.11 Object.isExtensible(O)
var isObject$12 = _isObject$2;

_objectSap$2('isExtensible', function($isExtensible){
  return function isExtensible(it){
    return isObject$12(it) ? $isExtensible ? $isExtensible(it) : true : false;
  };
});

// 19.1.2.1 Object.assign(target, source, ...)
var getKeys$6  = _objectKeys$2;
var gOPS$2     = _objectGops$2;
var pIE$4      = _objectPie$2;
var toObject$5 = _toObject$2;
var IObject$2  = _iobject$2;
var $assign  = Object.assign;

// should work with symbols and should have deterministic property order (V8 bug)
var _objectAssign = !$assign || _fails$2(function(){
  var A = {}
    , B = {}
    , S = Symbol()
    , K = 'abcdefghijklmnopqrst';
  A[S] = 7;
  K.split('').forEach(function(k){ B[k] = k; });
  return $assign({}, A)[S] != 7 || Object.keys($assign({}, B)).join('') != K;
}) ? function assign(target, source){ // eslint-disable-line no-unused-vars
  var T     = toObject$5(target)
    , aLen  = arguments.length
    , index = 1
    , getSymbols = gOPS$2.f
    , isEnum     = pIE$4.f;
  while(aLen > index){
    var S      = IObject$2(arguments[index++])
      , keys   = getSymbols ? getKeys$6(S).concat(getSymbols(S)) : getKeys$6(S)
      , length = keys.length
      , j      = 0
      , key;
    while(length > j)if(isEnum.call(S, key = keys[j++]))T[key] = S[key];
  } return T;
} : $assign;

// 19.1.3.1 Object.assign(target, source)
var $export$13 = _export$2;

$export$13($export$13.S + $export$13.F, 'Object', {assign: _objectAssign});

// 7.2.9 SameValue(x, y)
var _sameValue = Object.is || function is(x, y){
  return x === y ? x !== 0 || 1 / x === 1 / y : x != x && y != y;
};

// 19.1.3.10 Object.is(value1, value2)
var $export$14 = _export$2;
$export$14($export$14.S, 'Object', {is: _sameValue});

// Works with __proto__ only. Old v8 can't work with null proto objects.
/* eslint-disable no-proto */
var isObject$13 = _isObject$2;
var anObject$9 = _anObject$2;
var check$1 = function(O, proto){
  anObject$9(O);
  if(!isObject$13(proto) && proto !== null)throw TypeError(proto + ": can't set as prototype!");
};
var _setProto$2 = {
  set: Object.setPrototypeOf || ('__proto__' in {} ? // eslint-disable-line
    function(test, buggy, set){
      try {
        set = _ctx$2(Function.call, _objectGopd$2.f(Object.prototype, '__proto__').set, 2);
        set(test, []);
        buggy = !(test instanceof Array);
      } catch(e){ buggy = true; }
      return function setPrototypeOf(O, proto){
        check$1(O, proto);
        if(buggy)O.__proto__ = proto;
        else set(O, proto);
        return O;
      };
    }({}, false) : undefined),
  check: check$1
};

// 19.1.3.19 Object.setPrototypeOf(O, proto)
var $export$15 = _export$2;
$export$15($export$15.S, 'Object', {setPrototypeOf: _setProto$2.set});

// getting tag from 19.1.3.6 Object.prototype.toString()
var cof$4 = _cof$2;
var TAG$2 = _wks$2('toStringTag');
var ARG = cof$4(function(){ return arguments; }()) == 'Arguments';

// fallback for IE11 Script Access Denied error
var tryGet = function(it, key){
  try {
    return it[key];
  } catch(e){ /* empty */ }
};

var _classof = function(it){
  var O, T, B;
  return it === undefined ? 'Undefined' : it === null ? 'Null'
    // @@toStringTag case
    : typeof (T = tryGet(O = Object(it), TAG$2)) == 'string' ? T
    // builtinTag case
    : ARG ? cof$4(O)
    // ES3 arguments fallback
    : (B = cof$4(O)) == 'Object' && typeof O.callee == 'function' ? 'Arguments' : B;
};

// 19.1.3.6 Object.prototype.toString()
var classof = _classof;
var test    = {};
test[_wks$2('toStringTag')] = 'z';
if(test + '' != '[object z]'){
  _redefine$2(Object.prototype, 'toString', function toString(){
    return '[object ' + classof(this) + ']';
  }, true);
}

// fast apply, http://jsperf.lnkit.com/fast-apply/5
var _invoke = function(fn, args, that){
  var un = that === undefined;
  switch(args.length){
    case 0: return un ? fn()
                      : fn.call(that);
    case 1: return un ? fn(args[0])
                      : fn.call(that, args[0]);
    case 2: return un ? fn(args[0], args[1])
                      : fn.call(that, args[0], args[1]);
    case 3: return un ? fn(args[0], args[1], args[2])
                      : fn.call(that, args[0], args[1], args[2]);
    case 4: return un ? fn(args[0], args[1], args[2], args[3])
                      : fn.call(that, args[0], args[1], args[2], args[3]);
  } return              fn.apply(that, args);
};

var aFunction$2  = _aFunction$2;
var isObject$14   = _isObject$2;
var invoke     = _invoke;
var arraySlice = [].slice;
var factories  = {};

var construct$1 = function(F, len, args){
  if(!(len in factories)){
    for(var n = [], i = 0; i < len; i++)n[i] = 'a[' + i + ']';
    factories[len] = Function('F,a', 'return new F(' + n.join(',') + ')');
  } return factories[len](F, args);
};

var _bind = Function.bind || function bind(that /*, args... */){
  var fn       = aFunction$2(this)
    , partArgs = arraySlice.call(arguments, 1);
  var bound = function(/* args... */){
    var args = partArgs.concat(arraySlice.call(arguments));
    return this instanceof bound ? construct$1(fn, args.length, args) : invoke(fn, args, that);
  };
  if(isObject$14(fn.prototype))bound.prototype = fn.prototype;
  return bound;
};

// 19.2.3.2 / 15.3.4.5 Function.prototype.bind(thisArg, args...)
var $export$16 = _export$2;

$export$16($export$16.P, 'Function', {bind: _bind});

var dP$8         = _objectDp$2.f;
var createDesc$6 = _propertyDesc$2;
var has$12        = _has$2;
var FProto     = Function.prototype;
var nameRE     = /^\s*function ([^ (]*)/;
var NAME$1       = 'name';

var isExtensible$1 = Object.isExtensible || function(){
  return true;
};

// 19.2.4.2 name
NAME$1 in FProto || _descriptors$2 && dP$8(FProto, NAME$1, {
  configurable: true,
  get: function(){
    try {
      var that = this
        , name = ('' + that).match(nameRE)[1];
      has$12(that, NAME$1) || !isExtensible$1(that) || dP$8(that, NAME$1, createDesc$6(5, name));
      return name;
    } catch(e){
      return '';
    }
  }
});

var isObject$15       = _isObject$2;
var getPrototypeOf$5 = _objectGpo$2;
var HAS_INSTANCE   = _wks$2('hasInstance');
var FunctionProto  = Function.prototype;
// 19.2.3.6 Function.prototype[@@hasInstance](V)
if(!(HAS_INSTANCE in FunctionProto))_objectDp$2.f(FunctionProto, HAS_INSTANCE, {value: function(O){
  if(typeof this != 'function' || !isObject$15(O))return false;
  if(!isObject$15(this.prototype))return O instanceof this;
  // for environment w/o native `@@hasInstance` logic enough `instanceof`, but add this:
  while(O = getPrototypeOf$5(O))if(this.prototype === O)return true;
  return false;
}});

var _stringWs = '\x09\x0A\x0B\x0C\x0D\x20\xA0\u1680\u180E\u2000\u2001\u2002\u2003' +
  '\u2004\u2005\u2006\u2007\u2008\u2009\u200A\u202F\u205F\u3000\u2028\u2029\uFEFF';

var $export$18 = _export$2;
var defined$5 = _defined$2;
var fails$2   = _fails$2;
var spaces  = _stringWs;
var space   = '[' + spaces + ']';
var non     = '\u200b\u0085';
var ltrim   = RegExp('^' + space + space + '*');
var rtrim   = RegExp(space + space + '*$');

var exporter = function(KEY, exec, ALIAS){
  var exp   = {};
  var FORCE = fails$2(function(){
    return !!spaces[KEY]() || non[KEY]() != non;
  });
  var fn = exp[KEY] = FORCE ? exec(trim$1) : spaces[KEY];
  if(ALIAS)exp[ALIAS] = fn;
  $export$18($export$18.P + $export$18.F * FORCE, 'String', exp);
};

// 1 -> String#trimLeft
// 2 -> String#trimRight
// 3 -> String#trim
var trim$1 = exporter.trim = function(string, TYPE){
  string = String(defined$5(string));
  if(TYPE & 1)string = string.replace(ltrim, '');
  if(TYPE & 2)string = string.replace(rtrim, '');
  return string;
};

var _stringTrim = exporter;

var $parseInt$1 = _global$2.parseInt;
var $trim     = _stringTrim.trim;
var ws        = _stringWs;
var hex       = /^[\-+]?0[xX]/;

var _parseInt = $parseInt$1(ws + '08') !== 8 || $parseInt$1(ws + '0x16') !== 22 ? function parseInt(str, radix){
  var string = $trim(String(str), 3);
  return $parseInt$1(string, (radix >>> 0) || (hex.test(string) ? 16 : 10));
} : $parseInt$1;

var $export$17   = _export$2;
var $parseInt = _parseInt;
// 18.2.5 parseInt(string, radix)
$export$17($export$17.G + $export$17.F * (parseInt != $parseInt), {parseInt: $parseInt});

var $parseFloat$1 = _global$2.parseFloat;
var $trim$1       = _stringTrim.trim;

var _parseFloat = 1 / $parseFloat$1(_stringWs + '-0') !== -Infinity ? function parseFloat(str){
  var string = $trim$1(String(str), 3)
    , result = $parseFloat$1(string);
  return result === 0 && string.charAt(0) == '-' ? -0 : result;
} : $parseFloat$1;

var $export$19     = _export$2;
var $parseFloat = _parseFloat;
// 18.2.4 parseFloat(string)
$export$19($export$19.G + $export$19.F * (parseFloat != $parseFloat), {parseFloat: $parseFloat});

var isObject$16       = _isObject$2;
var setPrototypeOf$5 = _setProto$2.set;
var _inheritIfRequired = function(that, target, C){
  var P, S = target.constructor;
  if(S !== C && typeof S == 'function' && (P = S.prototype) !== C.prototype && isObject$16(P) && setPrototypeOf$5){
    setPrototypeOf$5(that, P);
  } return that;
};

var global$10            = _global$2;
var has$13               = _has$2;
var cof$5               = _cof$2;
var inheritIfRequired = _inheritIfRequired;
var toPrimitive$6       = _toPrimitive$2;
var fails$3             = _fails$2;
var gOPN$4              = _objectGopn$2.f;
var gOPD$4              = _objectGopd$2.f;
var dP$9                = _objectDp$2.f;
var $trim$2             = _stringTrim.trim;
var NUMBER            = 'Number';
var $Number           = global$10[NUMBER];
var Base              = $Number;
var proto$1             = $Number.prototype;
var BROKEN_COF        = cof$5(_objectCreate$2(proto$1)) == NUMBER;
var TRIM              = 'trim' in String.prototype;

// 7.1.3 ToNumber(argument)
var toNumber = function(argument){
  var it = toPrimitive$6(argument, false);
  if(typeof it == 'string' && it.length > 2){
    it = TRIM ? it.trim() : $trim$2(it, 3);
    var first = it.charCodeAt(0)
      , third, radix, maxCode;
    if(first === 43 || first === 45){
      third = it.charCodeAt(2);
      if(third === 88 || third === 120)return NaN; // Number('+0x1') should be NaN, old V8 fix
    } else if(first === 48){
      switch(it.charCodeAt(1)){
        case 66 : case 98  : radix = 2; maxCode = 49; break; // fast equal /^0b[01]+$/i
        case 79 : case 111 : radix = 8; maxCode = 55; break; // fast equal /^0o[0-7]+$/i
        default : return +it;
      }
      for(var digits = it.slice(2), i = 0, l = digits.length, code; i < l; i++){
        code = digits.charCodeAt(i);
        // parseInt parses a string to a first unavailable symbol
        // but ToNumber should return NaN if a string contains unavailable symbols
        if(code < 48 || code > maxCode)return NaN;
      } return parseInt(digits, radix);
    }
  } return +it;
};

if(!$Number(' 0o1') || !$Number('0b1') || $Number('+0x1')){
  $Number = function Number(value){
    var it = arguments.length < 1 ? 0 : value
      , that = this;
    return that instanceof $Number
      // check on 1..constructor(foo) case
      && (BROKEN_COF ? fails$3(function(){ proto$1.valueOf.call(that); }) : cof$5(that) != NUMBER)
        ? inheritIfRequired(new Base(toNumber(it)), that, $Number) : toNumber(it);
  };
  for(var keys$1 = _descriptors$2 ? gOPN$4(Base) : (
    // ES3:
    'MAX_VALUE,MIN_VALUE,NaN,NEGATIVE_INFINITY,POSITIVE_INFINITY,' +
    // ES6 (in case, if modules with ES6 Number statics required before):
    'EPSILON,isFinite,isInteger,isNaN,isSafeInteger,MAX_SAFE_INTEGER,' +
    'MIN_SAFE_INTEGER,parseFloat,parseInt,isInteger'
  ).split(','), j = 0, key; keys$1.length > j; j++){
    if(has$13(Base, key = keys$1[j]) && !has$13($Number, key)){
      dP$9($Number, key, gOPD$4(Base, key));
    }
  }
  $Number.prototype = proto$1;
  proto$1.constructor = $Number;
  _redefine$2(global$10, NUMBER, $Number);
}

var cof$6 = _cof$2;
var _aNumberValue = function(it, msg){
  if(typeof it != 'number' && cof$6(it) != 'Number')throw TypeError(msg);
  return +it;
};

var toInteger$6 = _toInteger$2;
var defined$6   = _defined$2;

var _stringRepeat = function repeat(count){
  var str = String(defined$6(this))
    , res = ''
    , n   = toInteger$6(count);
  if(n < 0 || n == Infinity)throw RangeError("Count can't be negative");
  for(;n > 0; (n >>>= 1) && (str += str))if(n & 1)res += str;
  return res;
};

var $export$20      = _export$2;
var toInteger$5    = _toInteger$2;
var aNumberValue = _aNumberValue;
var repeat$1       = _stringRepeat;
var $toFixed     = 1..toFixed;
var floor$2        = Math.floor;
var data         = [0, 0, 0, 0, 0, 0];
var ERROR        = 'Number.toFixed: incorrect invocation!';
var ZERO         = '0';

var multiply = function(n, c){
  var i  = -1
    , c2 = c;
  while(++i < 6){
    c2 += n * data[i];
    data[i] = c2 % 1e7;
    c2 = floor$2(c2 / 1e7);
  }
};
var divide = function(n){
  var i = 6
    , c = 0;
  while(--i >= 0){
    c += data[i];
    data[i] = floor$2(c / n);
    c = (c % n) * 1e7;
  }
};
var numToString = function(){
  var i = 6
    , s = '';
  while(--i >= 0){
    if(s !== '' || i === 0 || data[i] !== 0){
      var t = String(data[i]);
      s = s === '' ? t : s + repeat$1.call(ZERO, 7 - t.length) + t;
    }
  } return s;
};
var pow = function(x, n, acc){
  return n === 0 ? acc : n % 2 === 1 ? pow(x, n - 1, acc * x) : pow(x * x, n / 2, acc);
};
var log = function(x){
  var n  = 0
    , x2 = x;
  while(x2 >= 4096){
    n += 12;
    x2 /= 4096;
  }
  while(x2 >= 2){
    n  += 1;
    x2 /= 2;
  } return n;
};

$export$20($export$20.P + $export$20.F * (!!$toFixed && (
  0.00008.toFixed(3) !== '0.000' ||
  0.9.toFixed(0) !== '1' ||
  1.255.toFixed(2) !== '1.25' ||
  1000000000000000128..toFixed(0) !== '1000000000000000128'
) || !_fails$2(function(){
  // V8 ~ Android 4.3-
  $toFixed.call({});
})), 'Number', {
  toFixed: function toFixed(fractionDigits){
    var x = aNumberValue(this, ERROR)
      , f = toInteger$5(fractionDigits)
      , s = ''
      , m = ZERO
      , e, z, j, k;
    if(f < 0 || f > 20)throw RangeError(ERROR);
    if(x != x)return 'NaN';
    if(x <= -1e21 || x >= 1e21)return String(x);
    if(x < 0){
      s = '-';
      x = -x;
    }
    if(x > 1e-21){
      e = log(x * pow(2, 69, 1)) - 69;
      z = e < 0 ? x * pow(2, -e, 1) : x / pow(2, e, 1);
      z *= 0x10000000000000;
      e = 52 - e;
      if(e > 0){
        multiply(0, z);
        j = f;
        while(j >= 7){
          multiply(1e7, 0);
          j -= 7;
        }
        multiply(pow(10, j, 1), 0);
        j = e - 1;
        while(j >= 23){
          divide(1 << 23);
          j -= 23;
        }
        divide(1 << j);
        multiply(1, 1);
        divide(2);
        m = numToString();
      } else {
        multiply(0, z);
        multiply(1 << -e, 0);
        m = numToString() + repeat$1.call(ZERO, f);
      }
    }
    if(f > 0){
      k = m.length;
      m = s + (k <= f ? '0.' + repeat$1.call(ZERO, f - k) + m : m.slice(0, k - f) + '.' + m.slice(k - f));
    } else {
      m = s + m;
    } return m;
  }
});

var $export$21      = _export$2;
var $fails$2       = _fails$2;
var aNumberValue$1 = _aNumberValue;
var $toPrecision = 1..toPrecision;

$export$21($export$21.P + $export$21.F * ($fails$2(function(){
  // IE7-
  return $toPrecision.call(1, undefined) !== '1';
}) || !$fails$2(function(){
  // V8 ~ Android 4.3-
  $toPrecision.call({});
})), 'Number', {
  toPrecision: function toPrecision(precision){
    var that = aNumberValue$1(this, 'Number#toPrecision: incorrect invocation!');
    return precision === undefined ? $toPrecision.call(that) : $toPrecision.call(that, precision); 
  }
});

// 20.1.2.1 Number.EPSILON
var $export$22 = _export$2;

$export$22($export$22.S, 'Number', {EPSILON: Math.pow(2, -52)});

// 20.1.2.2 Number.isFinite(number)
var $export$23   = _export$2;
var _isFinite = _global$2.isFinite;

$export$23($export$23.S, 'Number', {
  isFinite: function isFinite(it){
    return typeof it == 'number' && _isFinite(it);
  }
});

// 20.1.2.3 Number.isInteger(number)
var isObject$17 = _isObject$2;
var floor$3    = Math.floor;
var _isInteger = function isInteger(it){
  return !isObject$17(it) && isFinite(it) && floor$3(it) === it;
};

// 20.1.2.3 Number.isInteger(number)
var $export$24 = _export$2;

$export$24($export$24.S, 'Number', {isInteger: _isInteger});

// 20.1.2.4 Number.isNaN(number)
var $export$25 = _export$2;

$export$25($export$25.S, 'Number', {
  isNaN: function isNaN(number){
    return number != number;
  }
});

// 20.1.2.5 Number.isSafeInteger(number)
var $export$26   = _export$2;
var isInteger$1 = _isInteger;
var abs       = Math.abs;

$export$26($export$26.S, 'Number', {
  isSafeInteger: function isSafeInteger(number){
    return isInteger$1(number) && abs(number) <= 0x1fffffffffffff;
  }
});

// 20.1.2.6 Number.MAX_SAFE_INTEGER
var $export$27 = _export$2;

$export$27($export$27.S, 'Number', {MAX_SAFE_INTEGER: 0x1fffffffffffff});

// 20.1.2.10 Number.MIN_SAFE_INTEGER
var $export$28 = _export$2;

$export$28($export$28.S, 'Number', {MIN_SAFE_INTEGER: -0x1fffffffffffff});

var $export$29     = _export$2;
var $parseFloat$2 = _parseFloat;
// 20.1.2.12 Number.parseFloat(string)
$export$29($export$29.S + $export$29.F * (Number.parseFloat != $parseFloat$2), 'Number', {parseFloat: $parseFloat$2});

var $export$30   = _export$2;
var $parseInt$2 = _parseInt;
// 20.1.2.13 Number.parseInt(string, radix)
$export$30($export$30.S + $export$30.F * (Number.parseInt != $parseInt$2), 'Number', {parseInt: $parseInt$2});

// 20.2.2.20 Math.log1p(x)
var _mathLog1p = Math.log1p || function log1p(x){
  return (x = +x) > -1e-8 && x < 1e-8 ? x - x * x / 2 : Math.log(1 + x);
};

// 20.2.2.3 Math.acosh(x)
var $export$31 = _export$2;
var log1p$1   = _mathLog1p;
var sqrt    = Math.sqrt;
var $acosh  = Math.acosh;

$export$31($export$31.S + $export$31.F * !($acosh
  // V8 bug: https://code.google.com/p/v8/issues/detail?id=3509
  && Math.floor($acosh(Number.MAX_VALUE)) == 710
  // Tor Browser bug: Math.acosh(Infinity) -> NaN 
  && $acosh(Infinity) == Infinity
), 'Math', {
  acosh: function acosh(x){
    return (x = +x) < 1 ? NaN : x > 94906265.62425156
      ? Math.log(x) + Math.LN2
      : log1p$1(x - 1 + sqrt(x - 1) * sqrt(x + 1));
  }
});

// 20.2.2.5 Math.asinh(x)
var $export$32 = _export$2;
var $asinh  = Math.asinh;

function asinh(x){
  return !isFinite(x = +x) || x == 0 ? x : x < 0 ? -asinh(-x) : Math.log(x + Math.sqrt(x * x + 1));
}

// Tor Browser bug: Math.asinh(0) -> -0 
$export$32($export$32.S + $export$32.F * !($asinh && 1 / $asinh(0) > 0), 'Math', {asinh: asinh});

// 20.2.2.7 Math.atanh(x)
var $export$33 = _export$2;
var $atanh  = Math.atanh;

// Tor Browser bug: Math.atanh(-0) -> 0 
$export$33($export$33.S + $export$33.F * !($atanh && 1 / $atanh(-0) < 0), 'Math', {
  atanh: function atanh(x){
    return (x = +x) == 0 ? x : Math.log((1 + x) / (1 - x)) / 2;
  }
});

// 20.2.2.28 Math.sign(x)
var _mathSign = Math.sign || function sign(x){
  return (x = +x) == 0 || x != x ? x : x < 0 ? -1 : 1;
};

// 20.2.2.9 Math.cbrt(x)
var $export$34 = _export$2;
var sign$1    = _mathSign;

$export$34($export$34.S, 'Math', {
  cbrt: function cbrt(x){
    return sign$1(x = +x) * Math.pow(Math.abs(x), 1 / 3);
  }
});

// 20.2.2.11 Math.clz32(x)
var $export$35 = _export$2;

$export$35($export$35.S, 'Math', {
  clz32: function clz32(x){
    return (x >>>= 0) ? 31 - Math.floor(Math.log(x + 0.5) * Math.LOG2E) : 32;
  }
});

// 20.2.2.12 Math.cosh(x)
var $export$36 = _export$2;
var exp     = Math.exp;

$export$36($export$36.S, 'Math', {
  cosh: function cosh(x){
    return (exp(x = +x) + exp(-x)) / 2;
  }
});

// 20.2.2.14 Math.expm1(x)
var $expm1$1 = Math.expm1;
var _mathExpm1 = (!$expm1$1
  // Old FF bug
  || $expm1$1(10) > 22025.465794806719 || $expm1$1(10) < 22025.4657948067165168
  // Tor Browser bug
  || $expm1$1(-2e-17) != -2e-17
) ? function expm1(x){
  return (x = +x) == 0 ? x : x > -1e-6 && x < 1e-6 ? x + x * x / 2 : Math.exp(x) - 1;
} : $expm1$1;

// 20.2.2.14 Math.expm1(x)
var $export$37 = _export$2;
var $expm1  = _mathExpm1;

$export$37($export$37.S + $export$37.F * ($expm1 != Math.expm1), 'Math', {expm1: $expm1});

// 20.2.2.16 Math.fround(x)
var $export$38   = _export$2;
var sign$2      = _mathSign;
var pow$1       = Math.pow;
var EPSILON   = pow$1(2, -52);
var EPSILON32 = pow$1(2, -23);
var MAX32     = pow$1(2, 127) * (2 - EPSILON32);
var MIN32     = pow$1(2, -126);

var roundTiesToEven = function(n){
  return n + 1 / EPSILON - 1 / EPSILON;
};


$export$38($export$38.S, 'Math', {
  fround: function fround(x){
    var $abs  = Math.abs(x)
      , $sign = sign$2(x)
      , a, result;
    if($abs < MIN32)return $sign * roundTiesToEven($abs / MIN32 / EPSILON32) * MIN32 * EPSILON32;
    a = (1 + EPSILON32 / EPSILON) * $abs;
    result = a - (a - $abs);
    if(result > MAX32 || result != result)return $sign * Infinity;
    return $sign * result;
  }
});

// 20.2.2.17 Math.hypot([value1[, value2[, … ]]])
var $export$39 = _export$2;
var abs$1     = Math.abs;

$export$39($export$39.S, 'Math', {
  hypot: function hypot(value1, value2){ // eslint-disable-line no-unused-vars
    var sum  = 0
      , i    = 0
      , aLen = arguments.length
      , larg = 0
      , arg, div;
    while(i < aLen){
      arg = abs$1(arguments[i++]);
      if(larg < arg){
        div  = larg / arg;
        sum  = sum * div * div + 1;
        larg = arg;
      } else if(arg > 0){
        div  = arg / larg;
        sum += div * div;
      } else sum += arg;
    }
    return larg === Infinity ? Infinity : larg * Math.sqrt(sum);
  }
});

// 20.2.2.18 Math.imul(x, y)
var $export$40 = _export$2;
var $imul   = Math.imul;

// some WebKit versions fails with big numbers, some has wrong arity
$export$40($export$40.S + $export$40.F * _fails$2(function(){
  return $imul(0xffffffff, 5) != -5 || $imul.length != 2;
}), 'Math', {
  imul: function imul(x, y){
    var UINT16 = 0xffff
      , xn = +x
      , yn = +y
      , xl = UINT16 & xn
      , yl = UINT16 & yn;
    return 0 | xl * yl + ((UINT16 & xn >>> 16) * yl + xl * (UINT16 & yn >>> 16) << 16 >>> 0);
  }
});

// 20.2.2.21 Math.log10(x)
var $export$41 = _export$2;

$export$41($export$41.S, 'Math', {
  log10: function log10(x){
    return Math.log(x) / Math.LN10;
  }
});

// 20.2.2.20 Math.log1p(x)
var $export$42 = _export$2;

$export$42($export$42.S, 'Math', {log1p: _mathLog1p});

// 20.2.2.22 Math.log2(x)
var $export$43 = _export$2;

$export$43($export$43.S, 'Math', {
  log2: function log2(x){
    return Math.log(x) / Math.LN2;
  }
});

// 20.2.2.28 Math.sign(x)
var $export$44 = _export$2;

$export$44($export$44.S, 'Math', {sign: _mathSign});

// 20.2.2.30 Math.sinh(x)
var $export$45 = _export$2;
var expm1$1   = _mathExpm1;
var exp$1     = Math.exp;

// V8 near Chromium 38 has a problem with very small numbers
$export$45($export$45.S + $export$45.F * _fails$2(function(){
  return !Math.sinh(-2e-17) != -2e-17;
}), 'Math', {
  sinh: function sinh(x){
    return Math.abs(x = +x) < 1
      ? (expm1$1(x) - expm1$1(-x)) / 2
      : (exp$1(x - 1) - exp$1(-x - 1)) * (Math.E / 2);
  }
});

// 20.2.2.33 Math.tanh(x)
var $export$46 = _export$2;
var expm1$2   = _mathExpm1;
var exp$2     = Math.exp;

$export$46($export$46.S, 'Math', {
  tanh: function tanh(x){
    var a = expm1$2(x = +x)
      , b = expm1$2(-x);
    return a == Infinity ? 1 : b == Infinity ? -1 : (a - b) / (exp$2(x) + exp$2(-x));
  }
});

// 20.2.2.34 Math.trunc(x)
var $export$47 = _export$2;

$export$47($export$47.S, 'Math', {
  trunc: function trunc(it){
    return (it > 0 ? Math.floor : Math.ceil)(it);
  }
});

var $export$48        = _export$2;
var toIndex$2        = _toIndex$2;
var fromCharCode   = String.fromCharCode;
var $fromCodePoint = String.fromCodePoint;

// length should be 1, old FF problem
$export$48($export$48.S + $export$48.F * (!!$fromCodePoint && $fromCodePoint.length != 1), 'String', {
  // 21.1.2.2 String.fromCodePoint(...codePoints)
  fromCodePoint: function fromCodePoint(x){ // eslint-disable-line no-unused-vars
    var res  = []
      , aLen = arguments.length
      , i    = 0
      , code;
    while(aLen > i){
      code = +arguments[i++];
      if(toIndex$2(code, 0x10ffff) !== code)throw RangeError(code + ' is not a valid code point');
      res.push(code < 0x10000
        ? fromCharCode(code)
        : fromCharCode(((code -= 0x10000) >> 10) + 0xd800, code % 0x400 + 0xdc00)
      );
    } return res.join('');
  }
});

var $export$49   = _export$2;
var toIObject$14 = _toIobject$2;
var toLength$2  = _toLength$2;

$export$49($export$49.S, 'String', {
  // 21.1.2.4 String.raw(callSite, ...substitutions)
  raw: function raw(callSite){
    var tpl  = toIObject$14(callSite.raw)
      , len  = toLength$2(tpl.length)
      , aLen = arguments.length
      , res  = []
      , i    = 0;
    while(len > i){
      res.push(String(tpl[i++]));
      if(i < aLen)res.push(String(arguments[i]));
    } return res.join('');
  }
});

// 21.1.3.25 String.prototype.trim()
_stringTrim('trim', function($trim){
  return function trim(){
    return $trim(this, 3);
  };
});

var toInteger$7 = _toInteger$2;
var defined$7   = _defined$2;
// true  -> String#at
// false -> String#codePointAt
var _stringAt$2 = function(TO_STRING){
  return function(that, pos){
    var s = String(defined$7(that))
      , i = toInteger$7(pos)
      , l = s.length
      , a, b;
    if(i < 0 || i >= l)return TO_STRING ? '' : undefined;
    a = s.charCodeAt(i);
    return a < 0xd800 || a > 0xdbff || i + 1 === l || (b = s.charCodeAt(i + 1)) < 0xdc00 || b > 0xdfff
      ? TO_STRING ? s.charAt(i) : a
      : TO_STRING ? s.slice(i, i + 2) : (a - 0xd800 << 10) + (b - 0xdc00) + 0x10000;
  };
};

var _iterators$2 = {};

var create$6         = _objectCreate$2;
var descriptor$1     = _propertyDesc$2;
var setToStringTag$5 = _setToStringTag$2;
var IteratorPrototype$1 = {};

// 25.1.2.1.1 %IteratorPrototype%[@@iterator]()
_hide$2(IteratorPrototype$1, _wks$2('iterator'), function(){ return this; });

var _iterCreate$2 = function(Constructor, NAME, next){
  Constructor.prototype = create$6(IteratorPrototype$1, {next: descriptor$1(1, next)});
  setToStringTag$5(Constructor, NAME + ' Iterator');
};

var LIBRARY$3        = _library$2;
var $export$50        = _export$2;
var redefine$4       = _redefine$2;
var hide$4           = _hide$2;
var has$14            = _has$2;
var Iterators$3      = _iterators$2;
var $iterCreate$1    = _iterCreate$2;
var setToStringTag$4 = _setToStringTag$2;
var getPrototypeOf$6 = _objectGpo$2;
var ITERATOR$1       = _wks$2('iterator');
var BUGGY$1          = !([].keys && 'next' in [].keys());
var FF_ITERATOR$1    = '@@iterator';
var KEYS$1           = 'keys';
var VALUES$1         = 'values';

var returnThis$1 = function(){ return this; };

var _iterDefine$2 = function(Base, NAME, Constructor, next, DEFAULT, IS_SET, FORCED){
  $iterCreate$1(Constructor, NAME, next);
  var getMethod = function(kind){
    if(!BUGGY$1 && kind in proto)return proto[kind];
    switch(kind){
      case KEYS$1: return function keys(){ return new Constructor(this, kind); };
      case VALUES$1: return function values(){ return new Constructor(this, kind); };
    } return function entries(){ return new Constructor(this, kind); };
  };
  var TAG        = NAME + ' Iterator'
    , DEF_VALUES = DEFAULT == VALUES$1
    , VALUES_BUG = false
    , proto      = Base.prototype
    , $native    = proto[ITERATOR$1] || proto[FF_ITERATOR$1] || DEFAULT && proto[DEFAULT]
    , $default   = $native || getMethod(DEFAULT)
    , $entries   = DEFAULT ? !DEF_VALUES ? $default : getMethod('entries') : undefined
    , $anyNative = NAME == 'Array' ? proto.entries || $native : $native
    , methods, key, IteratorPrototype;
  // Fix native
  if($anyNative){
    IteratorPrototype = getPrototypeOf$6($anyNative.call(new Base));
    if(IteratorPrototype !== Object.prototype){
      // Set @@toStringTag to native iterators
      setToStringTag$4(IteratorPrototype, TAG, true);
      // fix for some old engines
      if(!LIBRARY$3 && !has$14(IteratorPrototype, ITERATOR$1))hide$4(IteratorPrototype, ITERATOR$1, returnThis$1);
    }
  }
  // fix Array#{values, @@iterator}.name in V8 / FF
  if(DEF_VALUES && $native && $native.name !== VALUES$1){
    VALUES_BUG = true;
    $default = function values(){ return $native.call(this); };
  }
  // Define iterator
  if((!LIBRARY$3 || FORCED) && (BUGGY$1 || VALUES_BUG || !proto[ITERATOR$1])){
    hide$4(proto, ITERATOR$1, $default);
  }
  // Plug for library
  Iterators$3[NAME] = $default;
  Iterators$3[TAG]  = returnThis$1;
  if(DEFAULT){
    methods = {
      values:  DEF_VALUES ? $default : getMethod(VALUES$1),
      keys:    IS_SET     ? $default : getMethod(KEYS$1),
      entries: $entries
    };
    if(FORCED)for(key in methods){
      if(!(key in proto))redefine$4(proto, key, methods[key]);
    } else $export$50($export$50.P + $export$50.F * (BUGGY$1 || VALUES_BUG), NAME, methods);
  }
  return methods;
};

var $at$1  = _stringAt$2(true);

// 21.1.3.27 String.prototype[@@iterator]()
_iterDefine$2(String, 'String', function(iterated){
  this._t = String(iterated); // target
  this._i = 0;                // next index
// 21.1.5.2.1 %StringIteratorPrototype%.next()
}, function(){
  var O     = this._t
    , index = this._i
    , point;
  if(index >= O.length)return {value: undefined, done: true};
  point = $at$1(O, index);
  this._i += point.length;
  return {value: point, done: false};
});

var $export$51 = _export$2;
var $at$2     = _stringAt$2(false);
$export$51($export$51.P, 'String', {
  // 21.1.3.3 String.prototype.codePointAt(pos)
  codePointAt: function codePointAt(pos){
    return $at$2(this, pos);
  }
});

// 7.2.8 IsRegExp(argument)
var isObject$18 = _isObject$2;
var cof$7      = _cof$2;
var MATCH    = _wks$2('match');
var _isRegexp = function(it){
  var isRegExp;
  return isObject$18(it) && ((isRegExp = it[MATCH]) !== undefined ? !!isRegExp : cof$7(it) == 'RegExp');
};

// helper for String#{startsWith, endsWith, includes}
var isRegExp = _isRegexp;
var defined$8  = _defined$2;

var _stringContext = function(that, searchString, NAME){
  if(isRegExp(searchString))throw TypeError('String#' + NAME + " doesn't accept regex!");
  return String(defined$8(that));
};

var MATCH$1 = _wks$2('match');
var _failsIsRegexp = function(KEY){
  var re = /./;
  try {
    '/./'[KEY](re);
  } catch(e){
    try {
      re[MATCH$1] = false;
      return !'/./'[KEY](re);
    } catch(f){ /* empty */ }
  } return true;
};

var $export$52   = _export$2;
var toLength$3  = _toLength$2;
var context   = _stringContext;
var ENDS_WITH = 'endsWith';
var $endsWith = ''[ENDS_WITH];

$export$52($export$52.P + $export$52.F * _failsIsRegexp(ENDS_WITH), 'String', {
  endsWith: function endsWith(searchString /*, endPosition = @length */){
    var that = context(this, searchString, ENDS_WITH)
      , endPosition = arguments.length > 1 ? arguments[1] : undefined
      , len    = toLength$3(that.length)
      , end    = endPosition === undefined ? len : Math.min(toLength$3(endPosition), len)
      , search = String(searchString);
    return $endsWith
      ? $endsWith.call(that, search, end)
      : that.slice(end - search.length, end) === search;
  }
});

var $export$53  = _export$2;
var context$1  = _stringContext;
var INCLUDES = 'includes';

$export$53($export$53.P + $export$53.F * _failsIsRegexp(INCLUDES), 'String', {
  includes: function includes(searchString /*, position = 0 */){
    return !!~context$1(this, searchString, INCLUDES)
      .indexOf(searchString, arguments.length > 1 ? arguments[1] : undefined);
  }
});

var $export$54 = _export$2;

$export$54($export$54.P, 'String', {
  // 21.1.3.13 String.prototype.repeat(count)
  repeat: _stringRepeat
});

var $export$55     = _export$2;
var toLength$4    = _toLength$2;
var context$2     = _stringContext;
var STARTS_WITH = 'startsWith';
var $startsWith = ''[STARTS_WITH];

$export$55($export$55.P + $export$55.F * _failsIsRegexp(STARTS_WITH), 'String', {
  startsWith: function startsWith(searchString /*, position = 0 */){
    var that   = context$2(this, searchString, STARTS_WITH)
      , index  = toLength$4(Math.min(arguments.length > 1 ? arguments[1] : undefined, that.length))
      , search = String(searchString);
    return $startsWith
      ? $startsWith.call(that, search, index)
      : that.slice(index, index + search.length) === search;
  }
});

var $export$56 = _export$2;
var fails$4   = _fails$2;
var defined$9 = _defined$2;
var quot    = /"/g;
// B.2.3.2.1 CreateHTML(string, tag, attribute, value)
var createHTML = function(string, tag, attribute, value) {
  var S  = String(defined$9(string))
    , p1 = '<' + tag;
  if(attribute !== '')p1 += ' ' + attribute + '="' + String(value).replace(quot, '&quot;') + '"';
  return p1 + '>' + S + '</' + tag + '>';
};
var _stringHtml = function(NAME, exec){
  var O = {};
  O[NAME] = exec(createHTML);
  $export$56($export$56.P + $export$56.F * fails$4(function(){
    var test = ''[NAME]('"');
    return test !== test.toLowerCase() || test.split('"').length > 3;
  }), 'String', O);
};

// B.2.3.2 String.prototype.anchor(name)
_stringHtml('anchor', function(createHTML){
  return function anchor(name){
    return createHTML(this, 'a', 'name', name);
  }
});

// B.2.3.3 String.prototype.big()
_stringHtml('big', function(createHTML){
  return function big(){
    return createHTML(this, 'big', '', '');
  }
});

// B.2.3.4 String.prototype.blink()
_stringHtml('blink', function(createHTML){
  return function blink(){
    return createHTML(this, 'blink', '', '');
  }
});

// B.2.3.5 String.prototype.bold()
_stringHtml('bold', function(createHTML){
  return function bold(){
    return createHTML(this, 'b', '', '');
  }
});

// B.2.3.6 String.prototype.fixed()
_stringHtml('fixed', function(createHTML){
  return function fixed(){
    return createHTML(this, 'tt', '', '');
  }
});

// B.2.3.7 String.prototype.fontcolor(color)
_stringHtml('fontcolor', function(createHTML){
  return function fontcolor(color){
    return createHTML(this, 'font', 'color', color);
  }
});

// B.2.3.8 String.prototype.fontsize(size)
_stringHtml('fontsize', function(createHTML){
  return function fontsize(size){
    return createHTML(this, 'font', 'size', size);
  }
});

// B.2.3.9 String.prototype.italics()
_stringHtml('italics', function(createHTML){
  return function italics(){
    return createHTML(this, 'i', '', '');
  }
});

// B.2.3.10 String.prototype.link(url)
_stringHtml('link', function(createHTML){
  return function link(url){
    return createHTML(this, 'a', 'href', url);
  }
});

// B.2.3.11 String.prototype.small()
_stringHtml('small', function(createHTML){
  return function small(){
    return createHTML(this, 'small', '', '');
  }
});

// B.2.3.12 String.prototype.strike()
_stringHtml('strike', function(createHTML){
  return function strike(){
    return createHTML(this, 'strike', '', '');
  }
});

// B.2.3.13 String.prototype.sub()
_stringHtml('sub', function(createHTML){
  return function sub(){
    return createHTML(this, 'sub', '', '');
  }
});

// B.2.3.14 String.prototype.sup()
_stringHtml('sup', function(createHTML){
  return function sup(){
    return createHTML(this, 'sup', '', '');
  }
});

// 20.3.3.1 / 15.9.4.4 Date.now()
var $export$57 = _export$2;

$export$57($export$57.S, 'Date', {now: function(){ return new Date().getTime(); }});

var $export$58     = _export$2;
var toObject$6    = _toObject$2;
var toPrimitive$7 = _toPrimitive$2;

$export$58($export$58.P + $export$58.F * _fails$2(function(){
  return new Date(NaN).toJSON() !== null || Date.prototype.toJSON.call({toISOString: function(){ return 1; }}) !== 1;
}), 'Date', {
  toJSON: function toJSON(key){
    var O  = toObject$6(this)
      , pv = toPrimitive$7(O);
    return typeof pv == 'number' && !isFinite(pv) ? null : O.toISOString();
  }
});

// 20.3.4.36 / 15.9.5.43 Date.prototype.toISOString()
var $export$59 = _export$2;
var fails$5   = _fails$2;
var getTime = Date.prototype.getTime;

var lz = function(num){
  return num > 9 ? num : '0' + num;
};

// PhantomJS / old WebKit has a broken implementations
$export$59($export$59.P + $export$59.F * (fails$5(function(){
  return new Date(-5e13 - 1).toISOString() != '0385-07-25T07:06:39.999Z';
}) || !fails$5(function(){
  new Date(NaN).toISOString();
})), 'Date', {
  toISOString: function toISOString(){
    if(!isFinite(getTime.call(this)))throw RangeError('Invalid time value');
    var d = this
      , y = d.getUTCFullYear()
      , m = d.getUTCMilliseconds()
      , s = y < 0 ? '-' : y > 9999 ? '+' : '';
    return s + ('00000' + Math.abs(y)).slice(s ? -6 : -4) +
      '-' + lz(d.getUTCMonth() + 1) + '-' + lz(d.getUTCDate()) +
      'T' + lz(d.getUTCHours()) + ':' + lz(d.getUTCMinutes()) +
      ':' + lz(d.getUTCSeconds()) + '.' + (m > 99 ? m : '0' + lz(m)) + 'Z';
  }
});

var DateProto    = Date.prototype;
var INVALID_DATE = 'Invalid Date';
var TO_STRING    = 'toString';
var $toString    = DateProto[TO_STRING];
var getTime$1      = DateProto.getTime;
if(new Date(NaN) + '' != INVALID_DATE){
  _redefine$2(DateProto, TO_STRING, function toString(){
    var value = getTime$1.call(this);
    return value === value ? $toString.call(this) : INVALID_DATE;
  });
}

var anObject$10    = _anObject$2;
var toPrimitive$8 = _toPrimitive$2;
var NUMBER$1      = 'number';

var _dateToPrimitive = function(hint){
  if(hint !== 'string' && hint !== NUMBER$1 && hint !== 'default')throw TypeError('Incorrect hint');
  return toPrimitive$8(anObject$10(this), hint != NUMBER$1);
};

var TO_PRIMITIVE$2 = _wks$2('toPrimitive');
var proto$2        = Date.prototype;

if(!(TO_PRIMITIVE$2 in proto$2))_hide$2(proto$2, TO_PRIMITIVE$2, _dateToPrimitive);

// 22.1.2.2 / 15.4.3.2 Array.isArray(arg)
var $export$60 = _export$2;

$export$60($export$60.S, 'Array', {isArray: _isArray$2});

// call something on iterator step with safe closing on error
var anObject$11 = _anObject$2;
var _iterCall = function(iterator, fn, value, entries){
  try {
    return entries ? fn(anObject$11(value)[0], value[1]) : fn(value);
  // 7.4.6 IteratorClose(iterator, completion)
  } catch(e){
    var ret = iterator['return'];
    if(ret !== undefined)anObject$11(ret.call(iterator));
    throw e;
  }
};

// check on default Array iterator
var Iterators$4  = _iterators$2;
var ITERATOR$2   = _wks$2('iterator');
var ArrayProto = Array.prototype;

var _isArrayIter = function(it){
  return it !== undefined && (Iterators$4.Array === it || ArrayProto[ITERATOR$2] === it);
};

var $defineProperty$2 = _objectDp$2;
var createDesc$7      = _propertyDesc$2;

var _createProperty = function(object, index, value){
  if(index in object)$defineProperty$2.f(object, index, createDesc$7(0, value));
  else object[index] = value;
};

var classof$1   = _classof;
var ITERATOR$3  = _wks$2('iterator');
var Iterators$5 = _iterators$2;
var core_getIteratorMethod = _core$2.getIteratorMethod = function(it){
  if(it != undefined)return it[ITERATOR$3]
    || it['@@iterator']
    || Iterators$5[classof$1(it)];
};

var ITERATOR$4     = _wks$2('iterator');
var SAFE_CLOSING = false;

try {
  var riter = [7][ITERATOR$4]();
  riter['return'] = function(){ SAFE_CLOSING = true; };
  Array.from(riter, function(){ throw 2; });
} catch(e){ /* empty */ }

var _iterDetect = function(exec, skipClosing){
  if(!skipClosing && !SAFE_CLOSING)return false;
  var safe = false;
  try {
    var arr  = [7]
      , iter = arr[ITERATOR$4]();
    iter.next = function(){ return {done: safe = true}; };
    arr[ITERATOR$4] = function(){ return iter; };
    exec(arr);
  } catch(e){ /* empty */ }
  return safe;
};

var ctx$2            = _ctx$2;
var $export$61        = _export$2;
var toObject$7       = _toObject$2;
var call           = _iterCall;
var isArrayIter    = _isArrayIter;
var toLength$5       = _toLength$2;
var createProperty = _createProperty;
var getIterFn      = core_getIteratorMethod;

$export$61($export$61.S + $export$61.F * !_iterDetect(function(iter){ Array.from(iter); }), 'Array', {
  // 22.1.2.1 Array.from(arrayLike, mapfn = undefined, thisArg = undefined)
  from: function from(arrayLike/*, mapfn = undefined, thisArg = undefined*/){
    var O       = toObject$7(arrayLike)
      , C       = typeof this == 'function' ? this : Array
      , aLen    = arguments.length
      , mapfn   = aLen > 1 ? arguments[1] : undefined
      , mapping = mapfn !== undefined
      , index   = 0
      , iterFn  = getIterFn(O)
      , length, result, step, iterator;
    if(mapping)mapfn = ctx$2(mapfn, aLen > 2 ? arguments[2] : undefined, 2);
    // if object isn't iterable or it's array with default iterator - use simple case
    if(iterFn != undefined && !(C == Array && isArrayIter(iterFn))){
      for(iterator = iterFn.call(O), result = new C; !(step = iterator.next()).done; index++){
        createProperty(result, index, mapping ? call(iterator, mapfn, [step.value, index], true) : step.value);
      }
    } else {
      length = toLength$5(O.length);
      for(result = new C(length); length > index; index++){
        createProperty(result, index, mapping ? mapfn(O[index], index) : O[index]);
      }
    }
    result.length = index;
    return result;
  }
});

var $export$62        = _export$2;
var createProperty$1 = _createProperty;

// WebKit Array.of isn't generic
$export$62($export$62.S + $export$62.F * _fails$2(function(){
  function F(){}
  return !(Array.of.call(F) instanceof F);
}), 'Array', {
  // 22.1.2.3 Array.of( ...items)
  of: function of(/* ...args */){
    var index  = 0
      , aLen   = arguments.length
      , result = new (typeof this == 'function' ? this : Array)(aLen);
    while(aLen > index)createProperty$1(result, index, arguments[index++]);
    result.length = aLen;
    return result;
  }
});

var fails$6 = _fails$2;

var _strictMethod = function(method, arg){
  return !!method && fails$6(function(){
    arg ? method.call(null, function(){}, 1) : method.call(null);
  });
};

// 22.1.3.13 Array.prototype.join(separator)
var $export$63   = _export$2;
var toIObject$15 = _toIobject$2;
var arrayJoin = [].join;

// fallback for not array-like strings
$export$63($export$63.P + $export$63.F * (_iobject$2 != Object || !_strictMethod(arrayJoin)), 'Array', {
  join: function join(separator){
    return arrayJoin.call(toIObject$15(this), separator === undefined ? ',' : separator);
  }
});

var $export$64    = _export$2;
var html       = _html$2;
var cof$8        = _cof$2;
var toIndex$3    = _toIndex$2;
var toLength$6   = _toLength$2;
var arraySlice$1 = [].slice;

// fallback for not array-like ES3 strings and DOM objects
$export$64($export$64.P + $export$64.F * _fails$2(function(){
  if(html)arraySlice$1.call(html);
}), 'Array', {
  slice: function slice(begin, end){
    var len   = toLength$6(this.length)
      , klass = cof$8(this);
    end = end === undefined ? len : end;
    if(klass == 'Array')return arraySlice$1.call(this, begin, end);
    var start  = toIndex$3(begin, len)
      , upTo   = toIndex$3(end, len)
      , size   = toLength$6(upTo - start)
      , cloned = Array(size)
      , i      = 0;
    for(; i < size; i++)cloned[i] = klass == 'String'
      ? this.charAt(start + i)
      : this[start + i];
    return cloned;
  }
});

var $export$65   = _export$2;
var aFunction$3 = _aFunction$2;
var toObject$8  = _toObject$2;
var fails$7     = _fails$2;
var $sort     = [].sort;
var test$1      = [1, 2, 3];

$export$65($export$65.P + $export$65.F * (fails$7(function(){
  // IE8-
  test$1.sort(undefined);
}) || !fails$7(function(){
  // V8 bug
  test$1.sort(null);
  // Old WebKit
}) || !_strictMethod($sort)), 'Array', {
  // 22.1.3.25 Array.prototype.sort(comparefn)
  sort: function sort(comparefn){
    return comparefn === undefined
      ? $sort.call(toObject$8(this))
      : $sort.call(toObject$8(this), aFunction$3(comparefn));
  }
});

var isObject$19 = _isObject$2;
var isArray$3  = _isArray$2;
var SPECIES  = _wks$2('species');

var _arraySpeciesConstructor = function(original){
  var C;
  if(isArray$3(original)){
    C = original.constructor;
    // cross-realm fallback
    if(typeof C == 'function' && (C === Array || isArray$3(C.prototype)))C = undefined;
    if(isObject$19(C)){
      C = C[SPECIES];
      if(C === null)C = undefined;
    }
  } return C === undefined ? Array : C;
};

// 9.4.2.3 ArraySpeciesCreate(originalArray, length)
var speciesConstructor = _arraySpeciesConstructor;

var _arraySpeciesCreate = function(original, length){
  return new (speciesConstructor(original))(length);
};

// 0 -> Array#forEach
// 1 -> Array#map
// 2 -> Array#filter
// 3 -> Array#some
// 4 -> Array#every
// 5 -> Array#find
// 6 -> Array#findIndex
var ctx$3      = _ctx$2;
var IObject$3  = _iobject$2;
var toObject$9 = _toObject$2;
var toLength$7 = _toLength$2;
var asc      = _arraySpeciesCreate;
var _arrayMethods = function(TYPE, $create){
  var IS_MAP        = TYPE == 1
    , IS_FILTER     = TYPE == 2
    , IS_SOME       = TYPE == 3
    , IS_EVERY      = TYPE == 4
    , IS_FIND_INDEX = TYPE == 6
    , NO_HOLES      = TYPE == 5 || IS_FIND_INDEX
    , create        = $create || asc;
  return function($this, callbackfn, that){
    var O      = toObject$9($this)
      , self   = IObject$3(O)
      , f      = ctx$3(callbackfn, that, 3)
      , length = toLength$7(self.length)
      , index  = 0
      , result = IS_MAP ? create($this, length) : IS_FILTER ? create($this, 0) : undefined
      , val, res;
    for(;length > index; index++)if(NO_HOLES || index in self){
      val = self[index];
      res = f(val, index, O);
      if(TYPE){
        if(IS_MAP)result[index] = res;            // map
        else if(res)switch(TYPE){
          case 3: return true;                    // some
          case 5: return val;                     // find
          case 6: return index;                   // findIndex
          case 2: result.push(val);               // filter
        } else if(IS_EVERY)return false;          // every
      }
    }
    return IS_FIND_INDEX ? -1 : IS_SOME || IS_EVERY ? IS_EVERY : result;
  };
};

var $export$66  = _export$2;
var $forEach = _arrayMethods(0);
var STRICT   = _strictMethod([].forEach, true);

$export$66($export$66.P + $export$66.F * !STRICT, 'Array', {
  // 22.1.3.10 / 15.4.4.18 Array.prototype.forEach(callbackfn [, thisArg])
  forEach: function forEach(callbackfn /* , thisArg */){
    return $forEach(this, callbackfn, arguments[1]);
  }
});

var $export$67 = _export$2;
var $map    = _arrayMethods(1);

$export$67($export$67.P + $export$67.F * !_strictMethod([].map, true), 'Array', {
  // 22.1.3.15 / 15.4.4.19 Array.prototype.map(callbackfn [, thisArg])
  map: function map(callbackfn /* , thisArg */){
    return $map(this, callbackfn, arguments[1]);
  }
});

var $export$68 = _export$2;
var $filter = _arrayMethods(2);

$export$68($export$68.P + $export$68.F * !_strictMethod([].filter, true), 'Array', {
  // 22.1.3.7 / 15.4.4.20 Array.prototype.filter(callbackfn [, thisArg])
  filter: function filter(callbackfn /* , thisArg */){
    return $filter(this, callbackfn, arguments[1]);
  }
});

var $export$69 = _export$2;
var $some   = _arrayMethods(3);

$export$69($export$69.P + $export$69.F * !_strictMethod([].some, true), 'Array', {
  // 22.1.3.23 / 15.4.4.17 Array.prototype.some(callbackfn [, thisArg])
  some: function some(callbackfn /* , thisArg */){
    return $some(this, callbackfn, arguments[1]);
  }
});

var $export$70 = _export$2;
var $every  = _arrayMethods(4);

$export$70($export$70.P + $export$70.F * !_strictMethod([].every, true), 'Array', {
  // 22.1.3.5 / 15.4.4.16 Array.prototype.every(callbackfn [, thisArg])
  every: function every(callbackfn /* , thisArg */){
    return $every(this, callbackfn, arguments[1]);
  }
});

var aFunction$4 = _aFunction$2;
var toObject$10  = _toObject$2;
var IObject$4   = _iobject$2;
var toLength$8  = _toLength$2;

var _arrayReduce = function(that, callbackfn, aLen, memo, isRight){
  aFunction$4(callbackfn);
  var O      = toObject$10(that)
    , self   = IObject$4(O)
    , length = toLength$8(O.length)
    , index  = isRight ? length - 1 : 0
    , i      = isRight ? -1 : 1;
  if(aLen < 2)for(;;){
    if(index in self){
      memo = self[index];
      index += i;
      break;
    }
    index += i;
    if(isRight ? index < 0 : length <= index){
      throw TypeError('Reduce of empty array with no initial value');
    }
  }
  for(;isRight ? index >= 0 : length > index; index += i)if(index in self){
    memo = callbackfn(memo, self[index], index, O);
  }
  return memo;
};

var $export$71 = _export$2;
var $reduce = _arrayReduce;

$export$71($export$71.P + $export$71.F * !_strictMethod([].reduce, true), 'Array', {
  // 22.1.3.18 / 15.4.4.21 Array.prototype.reduce(callbackfn [, initialValue])
  reduce: function reduce(callbackfn /* , initialValue */){
    return $reduce(this, callbackfn, arguments.length, arguments[1], false);
  }
});

var $export$72 = _export$2;
var $reduce$1 = _arrayReduce;

$export$72($export$72.P + $export$72.F * !_strictMethod([].reduceRight, true), 'Array', {
  // 22.1.3.19 / 15.4.4.22 Array.prototype.reduceRight(callbackfn [, initialValue])
  reduceRight: function reduceRight(callbackfn /* , initialValue */){
    return $reduce$1(this, callbackfn, arguments.length, arguments[1], true);
  }
});

var $export$73       = _export$2;
var $indexOf      = _arrayIncludes$2(false);
var $native       = [].indexOf;
var NEGATIVE_ZERO = !!$native && 1 / [1].indexOf(1, -0) < 0;

$export$73($export$73.P + $export$73.F * (NEGATIVE_ZERO || !_strictMethod($native)), 'Array', {
  // 22.1.3.11 / 15.4.4.14 Array.prototype.indexOf(searchElement [, fromIndex])
  indexOf: function indexOf(searchElement /*, fromIndex = 0 */){
    return NEGATIVE_ZERO
      // convert -0 to +0
      ? $native.apply(this, arguments) || 0
      : $indexOf(this, searchElement, arguments[1]);
  }
});

var $export$74       = _export$2;
var toIObject$16     = _toIobject$2;
var toInteger$8     = _toInteger$2;
var toLength$9      = _toLength$2;
var $native$1       = [].lastIndexOf;
var NEGATIVE_ZERO$1 = !!$native$1 && 1 / [1].lastIndexOf(1, -0) < 0;

$export$74($export$74.P + $export$74.F * (NEGATIVE_ZERO$1 || !_strictMethod($native$1)), 'Array', {
  // 22.1.3.14 / 15.4.4.15 Array.prototype.lastIndexOf(searchElement [, fromIndex])
  lastIndexOf: function lastIndexOf(searchElement /*, fromIndex = @[*-1] */){
    // convert -0 to +0
    if(NEGATIVE_ZERO$1)return $native$1.apply(this, arguments) || 0;
    var O      = toIObject$16(this)
      , length = toLength$9(O.length)
      , index  = length - 1;
    if(arguments.length > 1)index = Math.min(index, toInteger$8(arguments[1]));
    if(index < 0)index = length + index;
    for(;index >= 0; index--)if(index in O)if(O[index] === searchElement)return index || 0;
    return -1;
  }
});

var toObject$11 = _toObject$2;
var toIndex$4  = _toIndex$2;
var toLength$10 = _toLength$2;

var _arrayCopyWithin = [].copyWithin || function copyWithin(target/*= 0*/, start/*= 0, end = @length*/){
  var O     = toObject$11(this)
    , len   = toLength$10(O.length)
    , to    = toIndex$4(target, len)
    , from  = toIndex$4(start, len)
    , end   = arguments.length > 2 ? arguments[2] : undefined
    , count = Math.min((end === undefined ? len : toIndex$4(end, len)) - from, len - to)
    , inc   = 1;
  if(from < to && to < from + count){
    inc  = -1;
    from += count - 1;
    to   += count - 1;
  }
  while(count-- > 0){
    if(from in O)O[to] = O[from];
    else delete O[to];
    to   += inc;
    from += inc;
  } return O;
};

// 22.1.3.31 Array.prototype[@@unscopables]
var UNSCOPABLES = _wks$2('unscopables');
var ArrayProto$1  = Array.prototype;
if(ArrayProto$1[UNSCOPABLES] == undefined)_hide$2(ArrayProto$1, UNSCOPABLES, {});
var _addToUnscopables$2 = function(key){
  ArrayProto$1[UNSCOPABLES][key] = true;
};

// 22.1.3.3 Array.prototype.copyWithin(target, start, end = this.length)
var $export$75 = _export$2;

$export$75($export$75.P, 'Array', {copyWithin: _arrayCopyWithin});

_addToUnscopables$2('copyWithin');

var toObject$12 = _toObject$2;
var toIndex$5  = _toIndex$2;
var toLength$11 = _toLength$2;
var _arrayFill = function fill(value /*, start = 0, end = @length */){
  var O      = toObject$12(this)
    , length = toLength$11(O.length)
    , aLen   = arguments.length
    , index  = toIndex$5(aLen > 1 ? arguments[1] : undefined, length)
    , end    = aLen > 2 ? arguments[2] : undefined
    , endPos = end === undefined ? length : toIndex$5(end, length);
  while(endPos > index)O[index++] = value;
  return O;
};

// 22.1.3.6 Array.prototype.fill(value, start = 0, end = this.length)
var $export$76 = _export$2;

$export$76($export$76.P, 'Array', {fill: _arrayFill});

_addToUnscopables$2('fill');

// 22.1.3.8 Array.prototype.find(predicate, thisArg = undefined)
var $export$77 = _export$2;
var $find   = _arrayMethods(5);
var KEY$2     = 'find';
var forced  = true;
// Shouldn't skip holes
if(KEY$2 in [])Array(1)[KEY$2](function(){ forced = false; });
$export$77($export$77.P + $export$77.F * forced, 'Array', {
  find: function find(callbackfn/*, that = undefined */){
    return $find(this, callbackfn, arguments.length > 1 ? arguments[1] : undefined);
  }
});
_addToUnscopables$2(KEY$2);

// 22.1.3.9 Array.prototype.findIndex(predicate, thisArg = undefined)
var $export$78 = _export$2;
var $find$1   = _arrayMethods(6);
var KEY$3     = 'findIndex';
var forced$1  = true;
// Shouldn't skip holes
if(KEY$3 in [])Array(1)[KEY$3](function(){ forced$1 = false; });
$export$78($export$78.P + $export$78.F * forced$1, 'Array', {
  findIndex: function findIndex(callbackfn/*, that = undefined */){
    return $find$1(this, callbackfn, arguments.length > 1 ? arguments[1] : undefined);
  }
});
_addToUnscopables$2(KEY$3);

var global$11      = _global$2;
var dP$10          = _objectDp$2;
var DESCRIPTORS$2 = _descriptors$2;
var SPECIES$1     = _wks$2('species');

var _setSpecies = function(KEY){
  var C = global$11[KEY];
  if(DESCRIPTORS$2 && C && !C[SPECIES$1])dP$10.f(C, SPECIES$1, {
    configurable: true,
    get: function(){ return this; }
  });
};

_setSpecies('Array');

var _iterStep$2 = function(done, value){
  return {value: value, done: !!done};
};

var addToUnscopables$1 = _addToUnscopables$2;
var step$1             = _iterStep$2;
var Iterators$6        = _iterators$2;
var toIObject$17        = _toIobject$2;

// 22.1.3.4 Array.prototype.entries()
// 22.1.3.13 Array.prototype.keys()
// 22.1.3.29 Array.prototype.values()
// 22.1.3.30 Array.prototype[@@iterator]()
var es6_array_iterator$2 = _iterDefine$2(Array, 'Array', function(iterated, kind){
  this._t = toIObject$17(iterated); // target
  this._i = 0;                   // next index
  this._k = kind;                // kind
// 22.1.5.2.1 %ArrayIteratorPrototype%.next()
}, function(){
  var O     = this._t
    , kind  = this._k
    , index = this._i++;
  if(!O || index >= O.length){
    this._t = undefined;
    return step$1(1);
  }
  if(kind == 'keys'  )return step$1(0, index);
  if(kind == 'values')return step$1(0, O[index]);
  return step$1(0, [index, O[index]]);
}, 'values');

// argumentsList[@@iterator] is %ArrayProto_values% (9.4.4.6, 9.4.4.7)
Iterators$6.Arguments = Iterators$6.Array;

addToUnscopables$1('keys');
addToUnscopables$1('values');
addToUnscopables$1('entries');

// 21.2.5.3 get RegExp.prototype.flags
var anObject$12 = _anObject$2;
var _flags = function(){
  var that   = anObject$12(this)
    , result = '';
  if(that.global)     result += 'g';
  if(that.ignoreCase) result += 'i';
  if(that.multiline)  result += 'm';
  if(that.unicode)    result += 'u';
  if(that.sticky)     result += 'y';
  return result;
};

var global$12            = _global$2;
var inheritIfRequired$1 = _inheritIfRequired;
var dP$11                = _objectDp$2.f;
var gOPN$5              = _objectGopn$2.f;
var isRegExp$1          = _isRegexp;
var $flags            = _flags;
var $RegExp           = global$12.RegExp;
var Base$1              = $RegExp;
var proto$3             = $RegExp.prototype;
var re1               = /a/g;
var re2               = /a/g;
var CORRECT_NEW       = new $RegExp(re1) !== re1;

if(_descriptors$2 && (!CORRECT_NEW || _fails$2(function(){
  re2[_wks$2('match')] = false;
  // RegExp constructor can alter flags and IsRegExp works correct with @@match
  return $RegExp(re1) != re1 || $RegExp(re2) == re2 || $RegExp(re1, 'i') != '/a/i';
}))){
  $RegExp = function RegExp(p, f){
    var tiRE = this instanceof $RegExp
      , piRE = isRegExp$1(p)
      , fiU  = f === undefined;
    return !tiRE && piRE && p.constructor === $RegExp && fiU ? p
      : inheritIfRequired$1(CORRECT_NEW
        ? new Base$1(piRE && !fiU ? p.source : p, f)
        : Base$1((piRE = p instanceof $RegExp) ? p.source : p, piRE && fiU ? $flags.call(p) : f)
      , tiRE ? this : proto$3, $RegExp);
  };
  var proxy = function(key){
    key in $RegExp || dP$11($RegExp, key, {
      configurable: true,
      get: function(){ return Base$1[key]; },
      set: function(it){ Base$1[key] = it; }
    });
  };
  for(var keys$2 = gOPN$5(Base$1), i$4 = 0; keys$2.length > i$4; )proxy(keys$2[i$4++]);
  proto$3.constructor = $RegExp;
  $RegExp.prototype = proto$3;
  _redefine$2(global$12, 'RegExp', $RegExp);
}

_setSpecies('RegExp');

// 21.2.5.3 get RegExp.prototype.flags()
if(_descriptors$2 && /./g.flags != 'g')_objectDp$2.f(RegExp.prototype, 'flags', {
  configurable: true,
  get: _flags
});

var anObject$13    = _anObject$2;
var $flags$1      = _flags;
var DESCRIPTORS$3 = _descriptors$2;
var TO_STRING$1   = 'toString';
var $toString$1   = /./[TO_STRING$1];

var define$1 = function(fn){
  _redefine$2(RegExp.prototype, TO_STRING$1, fn, true);
};

// 21.2.5.14 RegExp.prototype.toString()
if(_fails$2(function(){ return $toString$1.call({source: 'a', flags: 'b'}) != '/a/b'; })){
  define$1(function toString(){
    var R = anObject$13(this);
    return '/'.concat(R.source, '/',
      'flags' in R ? R.flags : !DESCRIPTORS$3 && R instanceof RegExp ? $flags$1.call(R) : undefined);
  });
// FF44- RegExp#toString has a wrong name
} else if($toString$1.name != TO_STRING$1){
  define$1(function toString(){
    return $toString$1.call(this);
  });
}

var hide$5     = _hide$2;
var redefine$5 = _redefine$2;
var fails$8    = _fails$2;
var defined$10  = _defined$2;
var wks$2      = _wks$2;

var _fixReWks = function(KEY, length, exec){
  var SYMBOL   = wks$2(KEY)
    , fns      = exec(defined$10, SYMBOL, ''[KEY])
    , strfn    = fns[0]
    , rxfn     = fns[1];
  if(fails$8(function(){
    var O = {};
    O[SYMBOL] = function(){ return 7; };
    return ''[KEY](O) != 7;
  })){
    redefine$5(String.prototype, KEY, strfn);
    hide$5(RegExp.prototype, SYMBOL, length == 2
      // 21.2.5.8 RegExp.prototype[@@replace](string, replaceValue)
      // 21.2.5.11 RegExp.prototype[@@split](string, limit)
      ? function(string, arg){ return rxfn.call(string, this, arg); }
      // 21.2.5.6 RegExp.prototype[@@match](string)
      // 21.2.5.9 RegExp.prototype[@@search](string)
      : function(string){ return rxfn.call(string, this); }
    );
  }
};

// @@match logic
_fixReWks('match', 1, function(defined, MATCH, $match){
  // 21.1.3.11 String.prototype.match(regexp)
  return [function match(regexp){
    'use strict';
    var O  = defined(this)
      , fn = regexp == undefined ? undefined : regexp[MATCH];
    return fn !== undefined ? fn.call(regexp, O) : new RegExp(regexp)[MATCH](String(O));
  }, $match];
});

// @@replace logic
_fixReWks('replace', 2, function(defined, REPLACE, $replace){
  // 21.1.3.14 String.prototype.replace(searchValue, replaceValue)
  return [function replace(searchValue, replaceValue){
    'use strict';
    var O  = defined(this)
      , fn = searchValue == undefined ? undefined : searchValue[REPLACE];
    return fn !== undefined
      ? fn.call(searchValue, O, replaceValue)
      : $replace.call(String(O), searchValue, replaceValue);
  }, $replace];
});

// @@search logic
_fixReWks('search', 1, function(defined, SEARCH, $search){
  // 21.1.3.15 String.prototype.search(regexp)
  return [function search(regexp){
    'use strict';
    var O  = defined(this)
      , fn = regexp == undefined ? undefined : regexp[SEARCH];
    return fn !== undefined ? fn.call(regexp, O) : new RegExp(regexp)[SEARCH](String(O));
  }, $search];
});

// @@split logic
_fixReWks('split', 2, function(defined, SPLIT, $split){
  'use strict';
  var isRegExp   = _isRegexp
    , _split     = $split
    , $push      = [].push
    , $SPLIT     = 'split'
    , LENGTH     = 'length'
    , LAST_INDEX = 'lastIndex';
  if(
    'abbc'[$SPLIT](/(b)*/)[1] == 'c' ||
    'test'[$SPLIT](/(?:)/, -1)[LENGTH] != 4 ||
    'ab'[$SPLIT](/(?:ab)*/)[LENGTH] != 2 ||
    '.'[$SPLIT](/(.?)(.?)/)[LENGTH] != 4 ||
    '.'[$SPLIT](/()()/)[LENGTH] > 1 ||
    ''[$SPLIT](/.?/)[LENGTH]
  ){
    var NPCG = /()??/.exec('')[1] === undefined; // nonparticipating capturing group
    // based on es5-shim implementation, need to rework it
    $split = function(separator, limit){
      var string = String(this);
      if(separator === undefined && limit === 0)return [];
      // If `separator` is not a regex, use native split
      if(!isRegExp(separator))return _split.call(string, separator, limit);
      var output = [];
      var flags = (separator.ignoreCase ? 'i' : '') +
                  (separator.multiline ? 'm' : '') +
                  (separator.unicode ? 'u' : '') +
                  (separator.sticky ? 'y' : '');
      var lastLastIndex = 0;
      var splitLimit = limit === undefined ? 4294967295 : limit >>> 0;
      // Make `global` and avoid `lastIndex` issues by working with a copy
      var separatorCopy = new RegExp(separator.source, flags + 'g');
      var separator2, match, lastIndex, lastLength, i;
      // Doesn't need flags gy, but they don't hurt
      if(!NPCG)separator2 = new RegExp('^' + separatorCopy.source + '$(?!\\s)', flags);
      while(match = separatorCopy.exec(string)){
        // `separatorCopy.lastIndex` is not reliable cross-browser
        lastIndex = match.index + match[0][LENGTH];
        if(lastIndex > lastLastIndex){
          output.push(string.slice(lastLastIndex, match.index));
          // Fix browsers whose `exec` methods don't consistently return `undefined` for NPCG
          if(!NPCG && match[LENGTH] > 1)match[0].replace(separator2, function(){
            for(i = 1; i < arguments[LENGTH] - 2; i++)if(arguments[i] === undefined)match[i] = undefined;
          });
          if(match[LENGTH] > 1 && match.index < string[LENGTH])$push.apply(output, match.slice(1));
          lastLength = match[0][LENGTH];
          lastLastIndex = lastIndex;
          if(output[LENGTH] >= splitLimit)break;
        }
        if(separatorCopy[LAST_INDEX] === match.index)separatorCopy[LAST_INDEX]++; // Avoid an infinite loop
      }
      if(lastLastIndex === string[LENGTH]){
        if(lastLength || !separatorCopy.test(''))output.push('');
      } else output.push(string.slice(lastLastIndex));
      return output[LENGTH] > splitLimit ? output.slice(0, splitLimit) : output;
    };
  // Chakra, V8
  } else if('0'[$SPLIT](undefined, 0)[LENGTH]){
    $split = function(separator, limit){
      return separator === undefined && limit === 0 ? [] : _split.call(this, separator, limit);
    };
  }
  // 21.1.3.17 String.prototype.split(separator, limit)
  return [function split(separator, limit){
    var O  = defined(this)
      , fn = separator == undefined ? undefined : separator[SPLIT];
    return fn !== undefined ? fn.call(separator, O, limit) : $split.call(String(O), separator, limit);
  }, $split];
});

var _anInstance = function(it, Constructor, name, forbiddenField){
  if(!(it instanceof Constructor) || (forbiddenField !== undefined && forbiddenField in it)){
    throw TypeError(name + ': incorrect invocation!');
  } return it;
};

var _forOf = createCommonjsModule(function (module) {
var ctx         = _ctx$2
  , call        = _iterCall
  , isArrayIter = _isArrayIter
  , anObject    = _anObject$2
  , toLength    = _toLength$2
  , getIterFn   = core_getIteratorMethod
  , BREAK       = {}
  , RETURN      = {};
var exports = module.exports = function(iterable, entries, fn, that, ITERATOR){
  var iterFn = ITERATOR ? function(){ return iterable; } : getIterFn(iterable)
    , f      = ctx(fn, that, entries ? 2 : 1)
    , index  = 0
    , length, step, iterator, result;
  if(typeof iterFn != 'function')throw TypeError(iterable + ' is not iterable!');
  // fast case for arrays with default iterator
  if(isArrayIter(iterFn))for(length = toLength(iterable.length); length > index; index++){
    result = entries ? f(anObject(step = iterable[index])[0], step[1]) : f(iterable[index]);
    if(result === BREAK || result === RETURN)return result;
  } else for(iterator = iterFn.call(iterable); !(step = iterator.next()).done; ){
    result = call(iterator, f, step.value, entries);
    if(result === BREAK || result === RETURN)return result;
  }
};
exports.BREAK  = BREAK;
exports.RETURN = RETURN;
});

// 7.3.20 SpeciesConstructor(O, defaultConstructor)
var anObject$14  = _anObject$2;
var aFunction$6 = _aFunction$2;
var SPECIES$2   = _wks$2('species');
var _speciesConstructor = function(O, D){
  var C = anObject$14(O).constructor, S;
  return C === undefined || (S = anObject$14(C)[SPECIES$2]) == undefined ? D : aFunction$6(S);
};

var ctx$5                = _ctx$2;
var invoke$1             = _invoke;
var html$1               = _html$2;
var cel                = _domCreate$2;
var global$14             = _global$2;
var process$1            = global$14.process;
var setTask            = global$14.setImmediate;
var clearTask          = global$14.clearImmediate;
var MessageChannel     = global$14.MessageChannel;
var counter            = 0;
var queue              = {};
var ONREADYSTATECHANGE = 'onreadystatechange';
var defer;
var channel;
var port;
var run = function(){
  var id = +this;
  if(queue.hasOwnProperty(id)){
    var fn = queue[id];
    delete queue[id];
    fn();
  }
};
var listener = function(event){
  run.call(event.data);
};
// Node.js 0.9+ & IE10+ has setImmediate, otherwise:
if(!setTask || !clearTask){
  setTask = function setImmediate(fn){
    var args = [], i = 1;
    while(arguments.length > i)args.push(arguments[i++]);
    queue[++counter] = function(){
      invoke$1(typeof fn == 'function' ? fn : Function(fn), args);
    };
    defer(counter);
    return counter;
  };
  clearTask = function clearImmediate(id){
    delete queue[id];
  };
  // Node.js 0.8-
  if(_cof$2(process$1) == 'process'){
    defer = function(id){
      process$1.nextTick(ctx$5(run, id, 1));
    };
  // Browsers with MessageChannel, includes WebWorkers
  } else if(MessageChannel){
    channel = new MessageChannel;
    port    = channel.port2;
    channel.port1.onmessage = listener;
    defer = ctx$5(port.postMessage, port, 1);
  // Browsers with postMessage, skip WebWorkers
  // IE8 has postMessage, but it's sync & typeof its postMessage is 'object'
  } else if(global$14.addEventListener && typeof postMessage == 'function' && !global$14.importScripts){
    defer = function(id){
      global$14.postMessage(id + '', '*');
    };
    global$14.addEventListener('message', listener, false);
  // IE8-
  } else if(ONREADYSTATECHANGE in cel('script')){
    defer = function(id){
      html$1.appendChild(cel('script'))[ONREADYSTATECHANGE] = function(){
        html$1.removeChild(this);
        run.call(id);
      };
    };
  // Rest old browsers
  } else {
    defer = function(id){
      setTimeout(ctx$5(run, id, 1), 0);
    };
  }
}
var _task = {
  set:   setTask,
  clear: clearTask
};

var global$15    = _global$2;
var macrotask = _task.set;
var Observer  = global$15.MutationObserver || global$15.WebKitMutationObserver;
var process$2   = global$15.process;
var Promise$1   = global$15.Promise;
var isNode$1    = _cof$2(process$2) == 'process';

var _microtask = function(){
  var head, last, notify;

  var flush = function(){
    var parent, fn;
    if(isNode$1 && (parent = process$2.domain))parent.exit();
    while(head){
      fn   = head.fn;
      head = head.next;
      try {
        fn();
      } catch(e){
        if(head)notify();
        else last = undefined;
        throw e;
      }
    } last = undefined;
    if(parent)parent.enter();
  };

  // Node.js
  if(isNode$1){
    notify = function(){
      process$2.nextTick(flush);
    };
  // browsers with MutationObserver
  } else if(Observer){
    var toggle = true
      , node   = document.createTextNode('');
    new Observer(flush).observe(node, {characterData: true}); // eslint-disable-line no-new
    notify = function(){
      node.data = toggle = !toggle;
    };
  // environments with maybe non-completely correct, but existent Promise
  } else if(Promise$1 && Promise$1.resolve){
    var promise = Promise$1.resolve();
    notify = function(){
      promise.then(flush);
    };
  // for other environments - macrotask based on:
  // - setImmediate
  // - MessageChannel
  // - window.postMessag
  // - onreadystatechange
  // - setTimeout
  } else {
    notify = function(){
      // strange IE + webpack dev server bug - use .call(global)
      macrotask.call(global$15, flush);
    };
  }

  return function(fn){
    var task = {fn: fn, next: undefined};
    if(last)last.next = task;
    if(!head){
      head = task;
      notify();
    } last = task;
  };
};

var redefine$6 = _redefine$2;
var _redefineAll = function(target, src, safe){
  for(var key in src)redefine$6(target, key, src[key], safe);
  return target;
};

var LIBRARY$4            = _library$2;
var global$13             = _global$2;
var ctx$4                = _ctx$2;
var classof$2            = _classof;
var $export$79            = _export$2;
var isObject$20           = _isObject$2;
var aFunction$5          = _aFunction$2;
var anInstance         = _anInstance;
var forOf              = _forOf;
var speciesConstructor$1 = _speciesConstructor;
var task               = _task.set;
var microtask          = _microtask();
var PROMISE            = 'Promise';
var TypeError$1          = global$13.TypeError;
var process            = global$13.process;
var $Promise           = global$13[PROMISE];
var process            = global$13.process;
var isNode             = classof$2(process) == 'process';
var empty              = function(){ /* empty */ };
var Internal;
var GenericPromiseCapability;
var Wrapper;

var USE_NATIVE$2 = !!function(){
  try {
    // correct subclassing with @@species support
    var promise     = $Promise.resolve(1)
      , FakePromise = (promise.constructor = {})[_wks$2('species')] = function(exec){ exec(empty, empty); };
    // unhandled rejections tracking support, NodeJS Promise without it fails @@species test
    return (isNode || typeof PromiseRejectionEvent == 'function') && promise.then(empty) instanceof FakePromise;
  } catch(e){ /* empty */ }
}();

// helpers
var sameConstructor = function(a, b){
  // with library wrapper special case
  return a === b || a === $Promise && b === Wrapper;
};
var isThenable = function(it){
  var then;
  return isObject$20(it) && typeof (then = it.then) == 'function' ? then : false;
};
var newPromiseCapability = function(C){
  return sameConstructor($Promise, C)
    ? new PromiseCapability(C)
    : new GenericPromiseCapability(C);
};
var PromiseCapability = GenericPromiseCapability = function(C){
  var resolve, reject;
  this.promise = new C(function($$resolve, $$reject){
    if(resolve !== undefined || reject !== undefined)throw TypeError$1('Bad Promise constructor');
    resolve = $$resolve;
    reject  = $$reject;
  });
  this.resolve = aFunction$5(resolve);
  this.reject  = aFunction$5(reject);
};
var perform = function(exec){
  try {
    exec();
  } catch(e){
    return {error: e};
  }
};
var notify = function(promise, isReject){
  if(promise._n)return;
  promise._n = true;
  var chain = promise._c;
  microtask(function(){
    var value = promise._v
      , ok    = promise._s == 1
      , i     = 0;
    var run = function(reaction){
      var handler = ok ? reaction.ok : reaction.fail
        , resolve = reaction.resolve
        , reject  = reaction.reject
        , domain  = reaction.domain
        , result, then;
      try {
        if(handler){
          if(!ok){
            if(promise._h == 2)onHandleUnhandled(promise);
            promise._h = 1;
          }
          if(handler === true)result = value;
          else {
            if(domain)domain.enter();
            result = handler(value);
            if(domain)domain.exit();
          }
          if(result === reaction.promise){
            reject(TypeError$1('Promise-chain cycle'));
          } else if(then = isThenable(result)){
            then.call(result, resolve, reject);
          } else resolve(result);
        } else reject(value);
      } catch(e){
        reject(e);
      }
    };
    while(chain.length > i)run(chain[i++]); // variable length - can't use forEach
    promise._c = [];
    promise._n = false;
    if(isReject && !promise._h)onUnhandled(promise);
  });
};
var onUnhandled = function(promise){
  task.call(global$13, function(){
    var value = promise._v
      , abrupt, handler, console;
    if(isUnhandled(promise)){
      abrupt = perform(function(){
        if(isNode){
          process.emit('unhandledRejection', value, promise);
        } else if(handler = global$13.onunhandledrejection){
          handler({promise: promise, reason: value});
        } else if((console = global$13.console) && console.error){
          console.error('Unhandled promise rejection', value);
        }
      });
      // Browsers should not trigger `rejectionHandled` event if it was handled here, NodeJS - should
      promise._h = isNode || isUnhandled(promise) ? 2 : 1;
    } promise._a = undefined;
    if(abrupt)throw abrupt.error;
  });
};
var isUnhandled = function(promise){
  if(promise._h == 1)return false;
  var chain = promise._a || promise._c
    , i     = 0
    , reaction;
  while(chain.length > i){
    reaction = chain[i++];
    if(reaction.fail || !isUnhandled(reaction.promise))return false;
  } return true;
};
var onHandleUnhandled = function(promise){
  task.call(global$13, function(){
    var handler;
    if(isNode){
      process.emit('rejectionHandled', promise);
    } else if(handler = global$13.onrejectionhandled){
      handler({promise: promise, reason: promise._v});
    }
  });
};
var $reject = function(value){
  var promise = this;
  if(promise._d)return;
  promise._d = true;
  promise = promise._w || promise; // unwrap
  promise._v = value;
  promise._s = 2;
  if(!promise._a)promise._a = promise._c.slice();
  notify(promise, true);
};
var $resolve = function(value){
  var promise = this
    , then;
  if(promise._d)return;
  promise._d = true;
  promise = promise._w || promise; // unwrap
  try {
    if(promise === value)throw TypeError$1("Promise can't be resolved itself");
    if(then = isThenable(value)){
      microtask(function(){
        var wrapper = {_w: promise, _d: false}; // wrap
        try {
          then.call(value, ctx$4($resolve, wrapper, 1), ctx$4($reject, wrapper, 1));
        } catch(e){
          $reject.call(wrapper, e);
        }
      });
    } else {
      promise._v = value;
      promise._s = 1;
      notify(promise, false);
    }
  } catch(e){
    $reject.call({_w: promise, _d: false}, e); // wrap
  }
};

// constructor polyfill
if(!USE_NATIVE$2){
  // 25.4.3.1 Promise(executor)
  $Promise = function Promise(executor){
    anInstance(this, $Promise, PROMISE, '_h');
    aFunction$5(executor);
    Internal.call(this);
    try {
      executor(ctx$4($resolve, this, 1), ctx$4($reject, this, 1));
    } catch(err){
      $reject.call(this, err);
    }
  };
  Internal = function Promise(executor){
    this._c = [];             // <- awaiting reactions
    this._a = undefined;      // <- checked in isUnhandled reactions
    this._s = 0;              // <- state
    this._d = false;          // <- done
    this._v = undefined;      // <- value
    this._h = 0;              // <- rejection state, 0 - default, 1 - handled, 2 - unhandled
    this._n = false;          // <- notify
  };
  Internal.prototype = _redefineAll($Promise.prototype, {
    // 25.4.5.3 Promise.prototype.then(onFulfilled, onRejected)
    then: function then(onFulfilled, onRejected){
      var reaction    = newPromiseCapability(speciesConstructor$1(this, $Promise));
      reaction.ok     = typeof onFulfilled == 'function' ? onFulfilled : true;
      reaction.fail   = typeof onRejected == 'function' && onRejected;
      reaction.domain = isNode ? process.domain : undefined;
      this._c.push(reaction);
      if(this._a)this._a.push(reaction);
      if(this._s)notify(this, false);
      return reaction.promise;
    },
    // 25.4.5.1 Promise.prototype.catch(onRejected)
    'catch': function(onRejected){
      return this.then(undefined, onRejected);
    }
  });
  PromiseCapability = function(){
    var promise  = new Internal;
    this.promise = promise;
    this.resolve = ctx$4($resolve, promise, 1);
    this.reject  = ctx$4($reject, promise, 1);
  };
}

$export$79($export$79.G + $export$79.W + $export$79.F * !USE_NATIVE$2, {Promise: $Promise});
_setToStringTag$2($Promise, PROMISE);
_setSpecies(PROMISE);
Wrapper = _core$2[PROMISE];

// statics
$export$79($export$79.S + $export$79.F * !USE_NATIVE$2, PROMISE, {
  // 25.4.4.5 Promise.reject(r)
  reject: function reject(r){
    var capability = newPromiseCapability(this)
      , $$reject   = capability.reject;
    $$reject(r);
    return capability.promise;
  }
});
$export$79($export$79.S + $export$79.F * (LIBRARY$4 || !USE_NATIVE$2), PROMISE, {
  // 25.4.4.6 Promise.resolve(x)
  resolve: function resolve(x){
    // instanceof instead of internal slot check because we should fix it without replacement native Promise core
    if(x instanceof $Promise && sameConstructor(x.constructor, this))return x;
    var capability = newPromiseCapability(this)
      , $$resolve  = capability.resolve;
    $$resolve(x);
    return capability.promise;
  }
});
$export$79($export$79.S + $export$79.F * !(USE_NATIVE$2 && _iterDetect(function(iter){
  $Promise.all(iter)['catch'](empty);
})), PROMISE, {
  // 25.4.4.1 Promise.all(iterable)
  all: function all(iterable){
    var C          = this
      , capability = newPromiseCapability(C)
      , resolve    = capability.resolve
      , reject     = capability.reject;
    var abrupt = perform(function(){
      var values    = []
        , index     = 0
        , remaining = 1;
      forOf(iterable, false, function(promise){
        var $index        = index++
          , alreadyCalled = false;
        values.push(undefined);
        remaining++;
        C.resolve(promise).then(function(value){
          if(alreadyCalled)return;
          alreadyCalled  = true;
          values[$index] = value;
          --remaining || resolve(values);
        }, reject);
      });
      --remaining || resolve(values);
    });
    if(abrupt)reject(abrupt.error);
    return capability.promise;
  },
  // 25.4.4.4 Promise.race(iterable)
  race: function race(iterable){
    var C          = this
      , capability = newPromiseCapability(C)
      , reject     = capability.reject;
    var abrupt = perform(function(){
      forOf(iterable, false, function(promise){
        C.resolve(promise).then(capability.resolve, reject);
      });
    });
    if(abrupt)reject(abrupt.error);
    return capability.promise;
  }
});

var dP$12          = _objectDp$2.f;
var create$7      = _objectCreate$2;
var redefineAll = _redefineAll;
var ctx$6         = _ctx$2;
var anInstance$1  = _anInstance;
var defined$11     = _defined$2;
var forOf$1       = _forOf;
var $iterDefine = _iterDefine$2;
var step$2        = _iterStep$2;
var setSpecies  = _setSpecies;
var DESCRIPTORS$4 = _descriptors$2;
var fastKey$2     = _meta$2.fastKey;
var SIZE        = DESCRIPTORS$4 ? '_s' : 'size';

var getEntry = function(that, key){
  // fast case
  var index = fastKey$2(key), entry;
  if(index !== 'F')return that._i[index];
  // frozen object case
  for(entry = that._f; entry; entry = entry.n){
    if(entry.k == key)return entry;
  }
};

var _collectionStrong = {
  getConstructor: function(wrapper, NAME, IS_MAP, ADDER){
    var C = wrapper(function(that, iterable){
      anInstance$1(that, C, NAME, '_i');
      that._i = create$7(null); // index
      that._f = undefined;    // first entry
      that._l = undefined;    // last entry
      that[SIZE] = 0;         // size
      if(iterable != undefined)forOf$1(iterable, IS_MAP, that[ADDER], that);
    });
    redefineAll(C.prototype, {
      // 23.1.3.1 Map.prototype.clear()
      // 23.2.3.2 Set.prototype.clear()
      clear: function clear(){
        for(var that = this, data = that._i, entry = that._f; entry; entry = entry.n){
          entry.r = true;
          if(entry.p)entry.p = entry.p.n = undefined;
          delete data[entry.i];
        }
        that._f = that._l = undefined;
        that[SIZE] = 0;
      },
      // 23.1.3.3 Map.prototype.delete(key)
      // 23.2.3.4 Set.prototype.delete(value)
      'delete': function(key){
        var that  = this
          , entry = getEntry(that, key);
        if(entry){
          var next = entry.n
            , prev = entry.p;
          delete that._i[entry.i];
          entry.r = true;
          if(prev)prev.n = next;
          if(next)next.p = prev;
          if(that._f == entry)that._f = next;
          if(that._l == entry)that._l = prev;
          that[SIZE]--;
        } return !!entry;
      },
      // 23.2.3.6 Set.prototype.forEach(callbackfn, thisArg = undefined)
      // 23.1.3.5 Map.prototype.forEach(callbackfn, thisArg = undefined)
      forEach: function forEach(callbackfn /*, that = undefined */){
        anInstance$1(this, C, 'forEach');
        var f = ctx$6(callbackfn, arguments.length > 1 ? arguments[1] : undefined, 3)
          , entry;
        while(entry = entry ? entry.n : this._f){
          f(entry.v, entry.k, this);
          // revert to the last existing entry
          while(entry && entry.r)entry = entry.p;
        }
      },
      // 23.1.3.7 Map.prototype.has(key)
      // 23.2.3.7 Set.prototype.has(value)
      has: function has(key){
        return !!getEntry(this, key);
      }
    });
    if(DESCRIPTORS$4)dP$12(C.prototype, 'size', {
      get: function(){
        return defined$11(this[SIZE]);
      }
    });
    return C;
  },
  def: function(that, key, value){
    var entry = getEntry(that, key)
      , prev, index;
    // change existing entry
    if(entry){
      entry.v = value;
    // create new entry
    } else {
      that._l = entry = {
        i: index = fastKey$2(key, true), // <- index
        k: key,                        // <- key
        v: value,                      // <- value
        p: prev = that._l,             // <- previous entry
        n: undefined,                  // <- next entry
        r: false                       // <- removed
      };
      if(!that._f)that._f = entry;
      if(prev)prev.n = entry;
      that[SIZE]++;
      // add to index
      if(index !== 'F')that._i[index] = entry;
    } return that;
  },
  getEntry: getEntry,
  setStrong: function(C, NAME, IS_MAP){
    // add .keys, .values, .entries, [@@iterator]
    // 23.1.3.4, 23.1.3.8, 23.1.3.11, 23.1.3.12, 23.2.3.5, 23.2.3.8, 23.2.3.10, 23.2.3.11
    $iterDefine(C, NAME, function(iterated, kind){
      this._t = iterated;  // target
      this._k = kind;      // kind
      this._l = undefined; // previous
    }, function(){
      var that  = this
        , kind  = that._k
        , entry = that._l;
      // revert to the last existing entry
      while(entry && entry.r)entry = entry.p;
      // get next entry
      if(!that._t || !(that._l = entry = entry ? entry.n : that._t._f)){
        // or finish the iteration
        that._t = undefined;
        return step$2(1);
      }
      // return step by kind
      if(kind == 'keys'  )return step$2(0, entry.k);
      if(kind == 'values')return step$2(0, entry.v);
      return step$2(0, [entry.k, entry.v]);
    }, IS_MAP ? 'entries' : 'values' , !IS_MAP, true);

    // add [@@species], 23.1.2.2, 23.2.2.2
    setSpecies(NAME);
  }
};

var global$16            = _global$2;
var $export$80           = _export$2;
var redefine$7          = _redefine$2;
var redefineAll$1       = _redefineAll;
var meta$3              = _meta$2;
var forOf$2             = _forOf;
var anInstance$2        = _anInstance;
var isObject$21          = _isObject$2;
var fails$9             = _fails$2;
var $iterDetect       = _iterDetect;
var setToStringTag$6    = _setToStringTag$2;
var inheritIfRequired$2 = _inheritIfRequired;

var _collection = function(NAME, wrapper, methods, common, IS_MAP, IS_WEAK){
  var Base  = global$16[NAME]
    , C     = Base
    , ADDER = IS_MAP ? 'set' : 'add'
    , proto = C && C.prototype
    , O     = {};
  var fixMethod = function(KEY){
    var fn = proto[KEY];
    redefine$7(proto, KEY,
      KEY == 'delete' ? function(a){
        return IS_WEAK && !isObject$21(a) ? false : fn.call(this, a === 0 ? 0 : a);
      } : KEY == 'has' ? function has(a){
        return IS_WEAK && !isObject$21(a) ? false : fn.call(this, a === 0 ? 0 : a);
      } : KEY == 'get' ? function get(a){
        return IS_WEAK && !isObject$21(a) ? undefined : fn.call(this, a === 0 ? 0 : a);
      } : KEY == 'add' ? function add(a){ fn.call(this, a === 0 ? 0 : a); return this; }
        : function set(a, b){ fn.call(this, a === 0 ? 0 : a, b); return this; }
    );
  };
  if(typeof C != 'function' || !(IS_WEAK || proto.forEach && !fails$9(function(){
    new C().entries().next();
  }))){
    // create collection constructor
    C = common.getConstructor(wrapper, NAME, IS_MAP, ADDER);
    redefineAll$1(C.prototype, methods);
    meta$3.NEED = true;
  } else {
    var instance             = new C
      // early implementations not supports chaining
      , HASNT_CHAINING       = instance[ADDER](IS_WEAK ? {} : -0, 1) != instance
      // V8 ~  Chromium 40- weak-collections throws on primitives, but should return false
      , THROWS_ON_PRIMITIVES = fails$9(function(){ instance.has(1); })
      // most early implementations doesn't supports iterables, most modern - not close it correctly
      , ACCEPT_ITERABLES     = $iterDetect(function(iter){ new C(iter); }) // eslint-disable-line no-new
      // for early implementations -0 and +0 not the same
      , BUGGY_ZERO = !IS_WEAK && fails$9(function(){
        // V8 ~ Chromium 42- fails only with 5+ elements
        var $instance = new C()
          , index     = 5;
        while(index--)$instance[ADDER](index, index);
        return !$instance.has(-0);
      });
    if(!ACCEPT_ITERABLES){ 
      C = wrapper(function(target, iterable){
        anInstance$2(target, C, NAME);
        var that = inheritIfRequired$2(new Base, target, C);
        if(iterable != undefined)forOf$2(iterable, IS_MAP, that[ADDER], that);
        return that;
      });
      C.prototype = proto;
      proto.constructor = C;
    }
    if(THROWS_ON_PRIMITIVES || BUGGY_ZERO){
      fixMethod('delete');
      fixMethod('has');
      IS_MAP && fixMethod('get');
    }
    if(BUGGY_ZERO || HASNT_CHAINING)fixMethod(ADDER);
    // weak collections should not contains .clear method
    if(IS_WEAK && proto.clear)delete proto.clear;
  }

  setToStringTag$6(C, NAME);

  O[NAME] = C;
  $export$80($export$80.G + $export$80.W + $export$80.F * (C != Base), O);

  if(!IS_WEAK)common.setStrong(C, NAME, IS_MAP);

  return C;
};

var strong = _collectionStrong;

// 23.1 Map Objects
var es6_map = _collection('Map', function(get){
  return function Map(){ return get(this, arguments.length > 0 ? arguments[0] : undefined); };
}, {
  // 23.1.3.6 Map.prototype.get(key)
  get: function get(key){
    var entry = strong.getEntry(this, key);
    return entry && entry.v;
  },
  // 23.1.3.9 Map.prototype.set(key, value)
  set: function set(key, value){
    return strong.def(this, key === 0 ? 0 : key, value);
  }
}, strong, true);

var strong$1 = _collectionStrong;

// 23.2 Set Objects
var es6_set = _collection('Set', function(get){
  return function Set(){ return get(this, arguments.length > 0 ? arguments[0] : undefined); };
}, {
  // 23.2.3.1 Set.prototype.add(value)
  add: function add(value){
    return strong$1.def(this, value = value === 0 ? 0 : value, value);
  }
}, strong$1);

var redefineAll$2       = _redefineAll;
var getWeak$2           = _meta$2.getWeak;
var anObject$15          = _anObject$2;
var isObject$22          = _isObject$2;
var anInstance$3        = _anInstance;
var forOf$3             = _forOf;
var createArrayMethod = _arrayMethods;
var $has              = _has$2;
var arrayFind         = createArrayMethod(5);
var arrayFindIndex    = createArrayMethod(6);
var id$2                = 0;

// fallback for uncaught frozen keys
var uncaughtFrozenStore = function(that){
  return that._l || (that._l = new UncaughtFrozenStore);
};
var UncaughtFrozenStore = function(){
  this.a = [];
};
var findUncaughtFrozen = function(store, key){
  return arrayFind(store.a, function(it){
    return it[0] === key;
  });
};
UncaughtFrozenStore.prototype = {
  get: function(key){
    var entry = findUncaughtFrozen(this, key);
    if(entry)return entry[1];
  },
  has: function(key){
    return !!findUncaughtFrozen(this, key);
  },
  set: function(key, value){
    var entry = findUncaughtFrozen(this, key);
    if(entry)entry[1] = value;
    else this.a.push([key, value]);
  },
  'delete': function(key){
    var index = arrayFindIndex(this.a, function(it){
      return it[0] === key;
    });
    if(~index)this.a.splice(index, 1);
    return !!~index;
  }
};

var _collectionWeak = {
  getConstructor: function(wrapper, NAME, IS_MAP, ADDER){
    var C = wrapper(function(that, iterable){
      anInstance$3(that, C, NAME, '_i');
      that._i = id$2++;      // collection id
      that._l = undefined; // leak store for uncaught frozen objects
      if(iterable != undefined)forOf$3(iterable, IS_MAP, that[ADDER], that);
    });
    redefineAll$2(C.prototype, {
      // 23.3.3.2 WeakMap.prototype.delete(key)
      // 23.4.3.3 WeakSet.prototype.delete(value)
      'delete': function(key){
        if(!isObject$22(key))return false;
        var data = getWeak$2(key);
        if(data === true)return uncaughtFrozenStore(this)['delete'](key);
        return data && $has(data, this._i) && delete data[this._i];
      },
      // 23.3.3.4 WeakMap.prototype.has(key)
      // 23.4.3.4 WeakSet.prototype.has(value)
      has: function has(key){
        if(!isObject$22(key))return false;
        var data = getWeak$2(key);
        if(data === true)return uncaughtFrozenStore(this).has(key);
        return data && $has(data, this._i);
      }
    });
    return C;
  },
  def: function(that, key, value){
    var data = getWeak$2(anObject$15(key), true);
    if(data === true)uncaughtFrozenStore(that).set(key, value);
    else data[that._i] = value;
    return that;
  },
  ufstore: uncaughtFrozenStore
};

var es6_weakMap = createCommonjsModule(function (module) {
'use strict';
var each         = _arrayMethods(0)
  , redefine     = _redefine$2
  , meta         = _meta$2
  , assign       = _objectAssign
  , weak         = _collectionWeak
  , isObject     = _isObject$2
  , getWeak      = meta.getWeak
  , isExtensible = Object.isExtensible
  , uncaughtFrozenStore = weak.ufstore
  , tmp          = {}
  , InternalMap;

var wrapper = function(get){
  return function WeakMap(){
    return get(this, arguments.length > 0 ? arguments[0] : undefined);
  };
};

var methods = {
  // 23.3.3.3 WeakMap.prototype.get(key)
  get: function get(key){
    if(isObject(key)){
      var data = getWeak(key);
      if(data === true)return uncaughtFrozenStore(this).get(key);
      return data ? data[this._i] : undefined;
    }
  },
  // 23.3.3.5 WeakMap.prototype.set(key, value)
  set: function set(key, value){
    return weak.def(this, key, value);
  }
};

// 23.3 WeakMap Objects
var $WeakMap = module.exports = _collection('WeakMap', wrapper, methods, weak, true, true);

// IE11 WeakMap frozen keys fix
if(new $WeakMap().set((Object.freeze || Object)(tmp), 7).get(tmp) != 7){
  InternalMap = weak.getConstructor(wrapper);
  assign(InternalMap.prototype, methods);
  meta.NEED = true;
  each(['delete', 'has', 'get', 'set'], function(key){
    var proto  = $WeakMap.prototype
      , method = proto[key];
    redefine(proto, key, function(a, b){
      // store frozen objects on internal weakmap shim
      if(isObject(a) && !isExtensible(a)){
        if(!this._f)this._f = new InternalMap;
        var result = this._f[key](a, b);
        return key == 'set' ? this : result;
      // store all the rest on native weakmap
      } return method.call(this, a, b);
    });
  });
}
});

var weak = _collectionWeak;

// 23.4 WeakSet Objects
_collection('WeakSet', function(get){
  return function WeakSet(){ return get(this, arguments.length > 0 ? arguments[0] : undefined); };
}, {
  // 23.4.3.1 WeakSet.prototype.add(value)
  add: function add(value){
    return weak.def(this, value, true);
  }
}, weak, false, true);

var global$17 = _global$2;
var hide$6   = _hide$2;
var uid$4    = _uid$2;
var TYPED  = uid$4('typed_array');
var VIEW$1   = uid$4('view');
var ABV    = !!(global$17.ArrayBuffer && global$17.DataView);
var CONSTR = ABV;
var i$5 = 0;
var l = 9;
var Typed;

var TypedArrayConstructors = (
  'Int8Array,Uint8Array,Uint8ClampedArray,Int16Array,Uint16Array,Int32Array,Uint32Array,Float32Array,Float64Array'
).split(',');

while(i$5 < l){
  if(Typed = global$17[TypedArrayConstructors[i$5++]]){
    hide$6(Typed.prototype, TYPED, true);
    hide$6(Typed.prototype, VIEW$1, true);
  } else CONSTR = false;
}

var _typed = {
  ABV:    ABV,
  CONSTR: CONSTR,
  TYPED:  TYPED,
  VIEW:   VIEW$1
};

var _typedBuffer = createCommonjsModule(function (module, exports) {
'use strict';
var global         = _global$2
  , DESCRIPTORS    = _descriptors$2
  , LIBRARY        = _library$2
  , $typed         = _typed
  , hide           = _hide$2
  , redefineAll    = _redefineAll
  , fails          = _fails$2
  , anInstance     = _anInstance
  , toInteger      = _toInteger$2
  , toLength       = _toLength$2
  , gOPN           = _objectGopn$2.f
  , dP             = _objectDp$2.f
  , arrayFill      = _arrayFill
  , setToStringTag = _setToStringTag$2
  , ARRAY_BUFFER   = 'ArrayBuffer'
  , DATA_VIEW      = 'DataView'
  , PROTOTYPE      = 'prototype'
  , WRONG_LENGTH   = 'Wrong length!'
  , WRONG_INDEX    = 'Wrong index!'
  , $ArrayBuffer   = global[ARRAY_BUFFER]
  , $DataView      = global[DATA_VIEW]
  , Math           = global.Math
  , RangeError     = global.RangeError
  , Infinity       = global.Infinity
  , BaseBuffer     = $ArrayBuffer
  , abs            = Math.abs
  , pow            = Math.pow
  , floor          = Math.floor
  , log            = Math.log
  , LN2            = Math.LN2
  , BUFFER         = 'buffer'
  , BYTE_LENGTH    = 'byteLength'
  , BYTE_OFFSET    = 'byteOffset'
  , $BUFFER        = DESCRIPTORS ? '_b' : BUFFER
  , $LENGTH        = DESCRIPTORS ? '_l' : BYTE_LENGTH
  , $OFFSET        = DESCRIPTORS ? '_o' : BYTE_OFFSET;

// IEEE754 conversions based on https://github.com/feross/ieee754
var packIEEE754 = function(value, mLen, nBytes){
  var buffer = Array(nBytes)
    , eLen   = nBytes * 8 - mLen - 1
    , eMax   = (1 << eLen) - 1
    , eBias  = eMax >> 1
    , rt     = mLen === 23 ? pow(2, -24) - pow(2, -77) : 0
    , i      = 0
    , s      = value < 0 || value === 0 && 1 / value < 0 ? 1 : 0
    , e, m, c;
  value = abs(value);
  if(value != value || value === Infinity){
    m = value != value ? 1 : 0;
    e = eMax;
  } else {
    e = floor(log(value) / LN2);
    if(value * (c = pow(2, -e)) < 1){
      e--;
      c *= 2;
    }
    if(e + eBias >= 1){
      value += rt / c;
    } else {
      value += rt * pow(2, 1 - eBias);
    }
    if(value * c >= 2){
      e++;
      c /= 2;
    }
    if(e + eBias >= eMax){
      m = 0;
      e = eMax;
    } else if(e + eBias >= 1){
      m = (value * c - 1) * pow(2, mLen);
      e = e + eBias;
    } else {
      m = value * pow(2, eBias - 1) * pow(2, mLen);
      e = 0;
    }
  }
  for(; mLen >= 8; buffer[i++] = m & 255, m /= 256, mLen -= 8);
  e = e << mLen | m;
  eLen += mLen;
  for(; eLen > 0; buffer[i++] = e & 255, e /= 256, eLen -= 8);
  buffer[--i] |= s * 128;
  return buffer;
};
var unpackIEEE754 = function(buffer, mLen, nBytes){
  var eLen  = nBytes * 8 - mLen - 1
    , eMax  = (1 << eLen) - 1
    , eBias = eMax >> 1
    , nBits = eLen - 7
    , i     = nBytes - 1
    , s     = buffer[i--]
    , e     = s & 127
    , m;
  s >>= 7;
  for(; nBits > 0; e = e * 256 + buffer[i], i--, nBits -= 8);
  m = e & (1 << -nBits) - 1;
  e >>= -nBits;
  nBits += mLen;
  for(; nBits > 0; m = m * 256 + buffer[i], i--, nBits -= 8);
  if(e === 0){
    e = 1 - eBias;
  } else if(e === eMax){
    return m ? NaN : s ? -Infinity : Infinity;
  } else {
    m = m + pow(2, mLen);
    e = e - eBias;
  } return (s ? -1 : 1) * m * pow(2, e - mLen);
};

var unpackI32 = function(bytes){
  return bytes[3] << 24 | bytes[2] << 16 | bytes[1] << 8 | bytes[0];
};
var packI8 = function(it){
  return [it & 0xff];
};
var packI16 = function(it){
  return [it & 0xff, it >> 8 & 0xff];
};
var packI32 = function(it){
  return [it & 0xff, it >> 8 & 0xff, it >> 16 & 0xff, it >> 24 & 0xff];
};
var packF64 = function(it){
  return packIEEE754(it, 52, 8);
};
var packF32 = function(it){
  return packIEEE754(it, 23, 4);
};

var addGetter = function(C, key, internal){
  dP(C[PROTOTYPE], key, {get: function(){ return this[internal]; }});
};

var get = function(view, bytes, index, isLittleEndian){
  var numIndex = +index
    , intIndex = toInteger(numIndex);
  if(numIndex != intIndex || intIndex < 0 || intIndex + bytes > view[$LENGTH])throw RangeError(WRONG_INDEX);
  var store = view[$BUFFER]._b
    , start = intIndex + view[$OFFSET]
    , pack  = store.slice(start, start + bytes);
  return isLittleEndian ? pack : pack.reverse();
};
var set = function(view, bytes, index, conversion, value, isLittleEndian){
  var numIndex = +index
    , intIndex = toInteger(numIndex);
  if(numIndex != intIndex || intIndex < 0 || intIndex + bytes > view[$LENGTH])throw RangeError(WRONG_INDEX);
  var store = view[$BUFFER]._b
    , start = intIndex + view[$OFFSET]
    , pack  = conversion(+value);
  for(var i = 0; i < bytes; i++)store[start + i] = pack[isLittleEndian ? i : bytes - i - 1];
};

var validateArrayBufferArguments = function(that, length){
  anInstance(that, $ArrayBuffer, ARRAY_BUFFER);
  var numberLength = +length
    , byteLength   = toLength(numberLength);
  if(numberLength != byteLength)throw RangeError(WRONG_LENGTH);
  return byteLength;
};

if(!$typed.ABV){
  $ArrayBuffer = function ArrayBuffer(length){
    var byteLength = validateArrayBufferArguments(this, length);
    this._b       = arrayFill.call(Array(byteLength), 0);
    this[$LENGTH] = byteLength;
  };

  $DataView = function DataView(buffer, byteOffset, byteLength){
    anInstance(this, $DataView, DATA_VIEW);
    anInstance(buffer, $ArrayBuffer, DATA_VIEW);
    var bufferLength = buffer[$LENGTH]
      , offset       = toInteger(byteOffset);
    if(offset < 0 || offset > bufferLength)throw RangeError('Wrong offset!');
    byteLength = byteLength === undefined ? bufferLength - offset : toLength(byteLength);
    if(offset + byteLength > bufferLength)throw RangeError(WRONG_LENGTH);
    this[$BUFFER] = buffer;
    this[$OFFSET] = offset;
    this[$LENGTH] = byteLength;
  };

  if(DESCRIPTORS){
    addGetter($ArrayBuffer, BYTE_LENGTH, '_l');
    addGetter($DataView, BUFFER, '_b');
    addGetter($DataView, BYTE_LENGTH, '_l');
    addGetter($DataView, BYTE_OFFSET, '_o');
  }

  redefineAll($DataView[PROTOTYPE], {
    getInt8: function getInt8(byteOffset){
      return get(this, 1, byteOffset)[0] << 24 >> 24;
    },
    getUint8: function getUint8(byteOffset){
      return get(this, 1, byteOffset)[0];
    },
    getInt16: function getInt16(byteOffset /*, littleEndian */){
      var bytes = get(this, 2, byteOffset, arguments[1]);
      return (bytes[1] << 8 | bytes[0]) << 16 >> 16;
    },
    getUint16: function getUint16(byteOffset /*, littleEndian */){
      var bytes = get(this, 2, byteOffset, arguments[1]);
      return bytes[1] << 8 | bytes[0];
    },
    getInt32: function getInt32(byteOffset /*, littleEndian */){
      return unpackI32(get(this, 4, byteOffset, arguments[1]));
    },
    getUint32: function getUint32(byteOffset /*, littleEndian */){
      return unpackI32(get(this, 4, byteOffset, arguments[1])) >>> 0;
    },
    getFloat32: function getFloat32(byteOffset /*, littleEndian */){
      return unpackIEEE754(get(this, 4, byteOffset, arguments[1]), 23, 4);
    },
    getFloat64: function getFloat64(byteOffset /*, littleEndian */){
      return unpackIEEE754(get(this, 8, byteOffset, arguments[1]), 52, 8);
    },
    setInt8: function setInt8(byteOffset, value){
      set(this, 1, byteOffset, packI8, value);
    },
    setUint8: function setUint8(byteOffset, value){
      set(this, 1, byteOffset, packI8, value);
    },
    setInt16: function setInt16(byteOffset, value /*, littleEndian */){
      set(this, 2, byteOffset, packI16, value, arguments[2]);
    },
    setUint16: function setUint16(byteOffset, value /*, littleEndian */){
      set(this, 2, byteOffset, packI16, value, arguments[2]);
    },
    setInt32: function setInt32(byteOffset, value /*, littleEndian */){
      set(this, 4, byteOffset, packI32, value, arguments[2]);
    },
    setUint32: function setUint32(byteOffset, value /*, littleEndian */){
      set(this, 4, byteOffset, packI32, value, arguments[2]);
    },
    setFloat32: function setFloat32(byteOffset, value /*, littleEndian */){
      set(this, 4, byteOffset, packF32, value, arguments[2]);
    },
    setFloat64: function setFloat64(byteOffset, value /*, littleEndian */){
      set(this, 8, byteOffset, packF64, value, arguments[2]);
    }
  });
} else {
  if(!fails(function(){
    new $ArrayBuffer;     // eslint-disable-line no-new
  }) || !fails(function(){
    new $ArrayBuffer(.5); // eslint-disable-line no-new
  })){
    $ArrayBuffer = function ArrayBuffer(length){
      return new BaseBuffer(validateArrayBufferArguments(this, length));
    };
    var ArrayBufferProto = $ArrayBuffer[PROTOTYPE] = BaseBuffer[PROTOTYPE];
    for(var keys = gOPN(BaseBuffer), j = 0, key; keys.length > j; ){
      if(!((key = keys[j++]) in $ArrayBuffer))hide($ArrayBuffer, key, BaseBuffer[key]);
    }
    if(!LIBRARY)ArrayBufferProto.constructor = $ArrayBuffer;
  }
  // iOS Safari 7.x bug
  var view = new $DataView(new $ArrayBuffer(2))
    , $setInt8 = $DataView[PROTOTYPE].setInt8;
  view.setInt8(0, 2147483648);
  view.setInt8(1, 2147483649);
  if(view.getInt8(0) || !view.getInt8(1))redefineAll($DataView[PROTOTYPE], {
    setInt8: function setInt8(byteOffset, value){
      $setInt8.call(this, byteOffset, value << 24 >> 24);
    },
    setUint8: function setUint8(byteOffset, value){
      $setInt8.call(this, byteOffset, value << 24 >> 24);
    }
  }, true);
}
setToStringTag($ArrayBuffer, ARRAY_BUFFER);
setToStringTag($DataView, DATA_VIEW);
hide($DataView[PROTOTYPE], $typed.VIEW, true);
exports[ARRAY_BUFFER] = $ArrayBuffer;
exports[DATA_VIEW] = $DataView;
});

var $export$81      = _export$2;
var $typed       = _typed;
var buffer       = _typedBuffer;
var anObject$16     = _anObject$2;
var toIndex$6      = _toIndex$2;
var toLength$12     = _toLength$2;
var isObject$23     = _isObject$2;
var ArrayBuffer$1  = _global$2.ArrayBuffer;
var speciesConstructor$2 = _speciesConstructor;
var $ArrayBuffer = buffer.ArrayBuffer;
var $DataView    = buffer.DataView;
var $isView      = $typed.ABV && ArrayBuffer$1.isView;
var $slice       = $ArrayBuffer.prototype.slice;
var VIEW         = $typed.VIEW;
var ARRAY_BUFFER = 'ArrayBuffer';

$export$81($export$81.G + $export$81.W + $export$81.F * (ArrayBuffer$1 !== $ArrayBuffer), {ArrayBuffer: $ArrayBuffer});

$export$81($export$81.S + $export$81.F * !$typed.CONSTR, ARRAY_BUFFER, {
  // 24.1.3.1 ArrayBuffer.isView(arg)
  isView: function isView(it){
    return $isView && $isView(it) || isObject$23(it) && VIEW in it;
  }
});

$export$81($export$81.P + $export$81.U + $export$81.F * _fails$2(function(){
  return !new $ArrayBuffer(2).slice(1, undefined).byteLength;
}), ARRAY_BUFFER, {
  // 24.1.4.3 ArrayBuffer.prototype.slice(start, end)
  slice: function slice(start, end){
    if($slice !== undefined && end === undefined)return $slice.call(anObject$16(this), start); // FF fix
    var len    = anObject$16(this).byteLength
      , first  = toIndex$6(start, len)
      , final  = toIndex$6(end === undefined ? len : end, len)
      , result = new (speciesConstructor$2(this, $ArrayBuffer))(toLength$12(final - first))
      , viewS  = new $DataView(this)
      , viewT  = new $DataView(result)
      , index  = 0;
    while(first < final){
      viewT.setUint8(index++, viewS.getUint8(first++));
    } return result;
  }
});

_setSpecies(ARRAY_BUFFER);

var $export$82 = _export$2;
$export$82($export$82.G + $export$82.W + $export$82.F * !_typed.ABV, {
  DataView: _typedBuffer.DataView
});

var _typedArray = createCommonjsModule(function (module) {
'use strict';
if(_descriptors$2){
  var LIBRARY             = _library$2
    , global              = _global$2
    , fails               = _fails$2
    , $export             = _export$2
    , $typed              = _typed
    , $buffer             = _typedBuffer
    , ctx                 = _ctx$2
    , anInstance          = _anInstance
    , propertyDesc        = _propertyDesc$2
    , hide                = _hide$2
    , redefineAll         = _redefineAll
    , toInteger           = _toInteger$2
    , toLength            = _toLength$2
    , toIndex             = _toIndex$2
    , toPrimitive         = _toPrimitive$2
    , has                 = _has$2
    , same                = _sameValue
    , classof             = _classof
    , isObject            = _isObject$2
    , toObject            = _toObject$2
    , isArrayIter         = _isArrayIter
    , create              = _objectCreate$2
    , getPrototypeOf      = _objectGpo$2
    , gOPN                = _objectGopn$2.f
    , getIterFn           = core_getIteratorMethod
    , uid                 = _uid$2
    , wks                 = _wks$2
    , createArrayMethod   = _arrayMethods
    , createArrayIncludes = _arrayIncludes$2
    , speciesConstructor  = _speciesConstructor
    , ArrayIterators      = es6_array_iterator$2
    , Iterators           = _iterators$2
    , $iterDetect         = _iterDetect
    , setSpecies          = _setSpecies
    , arrayFill           = _arrayFill
    , arrayCopyWithin     = _arrayCopyWithin
    , $DP                 = _objectDp$2
    , $GOPD               = _objectGopd$2
    , dP                  = $DP.f
    , gOPD                = $GOPD.f
    , RangeError          = global.RangeError
    , TypeError           = global.TypeError
    , Uint8Array          = global.Uint8Array
    , ARRAY_BUFFER        = 'ArrayBuffer'
    , SHARED_BUFFER       = 'Shared' + ARRAY_BUFFER
    , BYTES_PER_ELEMENT   = 'BYTES_PER_ELEMENT'
    , PROTOTYPE           = 'prototype'
    , ArrayProto          = Array[PROTOTYPE]
    , $ArrayBuffer        = $buffer.ArrayBuffer
    , $DataView           = $buffer.DataView
    , arrayForEach        = createArrayMethod(0)
    , arrayFilter         = createArrayMethod(2)
    , arraySome           = createArrayMethod(3)
    , arrayEvery          = createArrayMethod(4)
    , arrayFind           = createArrayMethod(5)
    , arrayFindIndex      = createArrayMethod(6)
    , arrayIncludes       = createArrayIncludes(true)
    , arrayIndexOf        = createArrayIncludes(false)
    , arrayValues         = ArrayIterators.values
    , arrayKeys           = ArrayIterators.keys
    , arrayEntries        = ArrayIterators.entries
    , arrayLastIndexOf    = ArrayProto.lastIndexOf
    , arrayReduce         = ArrayProto.reduce
    , arrayReduceRight    = ArrayProto.reduceRight
    , arrayJoin           = ArrayProto.join
    , arraySort           = ArrayProto.sort
    , arraySlice          = ArrayProto.slice
    , arrayToString       = ArrayProto.toString
    , arrayToLocaleString = ArrayProto.toLocaleString
    , ITERATOR            = wks('iterator')
    , TAG                 = wks('toStringTag')
    , TYPED_CONSTRUCTOR   = uid('typed_constructor')
    , DEF_CONSTRUCTOR     = uid('def_constructor')
    , ALL_CONSTRUCTORS    = $typed.CONSTR
    , TYPED_ARRAY         = $typed.TYPED
    , VIEW                = $typed.VIEW
    , WRONG_LENGTH        = 'Wrong length!';

  var $map = createArrayMethod(1, function(O, length){
    return allocate(speciesConstructor(O, O[DEF_CONSTRUCTOR]), length);
  });

  var LITTLE_ENDIAN = fails(function(){
    return new Uint8Array(new Uint16Array([1]).buffer)[0] === 1;
  });

  var FORCED_SET = !!Uint8Array && !!Uint8Array[PROTOTYPE].set && fails(function(){
    new Uint8Array(1).set({});
  });

  var strictToLength = function(it, SAME){
    if(it === undefined)throw TypeError(WRONG_LENGTH);
    var number = +it
      , length = toLength(it);
    if(SAME && !same(number, length))throw RangeError(WRONG_LENGTH);
    return length;
  };

  var toOffset = function(it, BYTES){
    var offset = toInteger(it);
    if(offset < 0 || offset % BYTES)throw RangeError('Wrong offset!');
    return offset;
  };

  var validate = function(it){
    if(isObject(it) && TYPED_ARRAY in it)return it;
    throw TypeError(it + ' is not a typed array!');
  };

  var allocate = function(C, length){
    if(!(isObject(C) && TYPED_CONSTRUCTOR in C)){
      throw TypeError('It is not a typed array constructor!');
    } return new C(length);
  };

  var speciesFromList = function(O, list){
    return fromList(speciesConstructor(O, O[DEF_CONSTRUCTOR]), list);
  };

  var fromList = function(C, list){
    var index  = 0
      , length = list.length
      , result = allocate(C, length);
    while(length > index)result[index] = list[index++];
    return result;
  };

  var addGetter = function(it, key, internal){
    dP(it, key, {get: function(){ return this._d[internal]; }});
  };

  var $from = function from(source /*, mapfn, thisArg */){
    var O       = toObject(source)
      , aLen    = arguments.length
      , mapfn   = aLen > 1 ? arguments[1] : undefined
      , mapping = mapfn !== undefined
      , iterFn  = getIterFn(O)
      , i, length, values, result, step, iterator;
    if(iterFn != undefined && !isArrayIter(iterFn)){
      for(iterator = iterFn.call(O), values = [], i = 0; !(step = iterator.next()).done; i++){
        values.push(step.value);
      } O = values;
    }
    if(mapping && aLen > 2)mapfn = ctx(mapfn, arguments[2], 2);
    for(i = 0, length = toLength(O.length), result = allocate(this, length); length > i; i++){
      result[i] = mapping ? mapfn(O[i], i) : O[i];
    }
    return result;
  };

  var $of = function of(/*...items*/){
    var index  = 0
      , length = arguments.length
      , result = allocate(this, length);
    while(length > index)result[index] = arguments[index++];
    return result;
  };

  // iOS Safari 6.x fails here
  var TO_LOCALE_BUG = !!Uint8Array && fails(function(){ arrayToLocaleString.call(new Uint8Array(1)); });

  var $toLocaleString = function toLocaleString(){
    return arrayToLocaleString.apply(TO_LOCALE_BUG ? arraySlice.call(validate(this)) : validate(this), arguments);
  };

  var proto = {
    copyWithin: function copyWithin(target, start /*, end */){
      return arrayCopyWithin.call(validate(this), target, start, arguments.length > 2 ? arguments[2] : undefined);
    },
    every: function every(callbackfn /*, thisArg */){
      return arrayEvery(validate(this), callbackfn, arguments.length > 1 ? arguments[1] : undefined);
    },
    fill: function fill(value /*, start, end */){ // eslint-disable-line no-unused-vars
      return arrayFill.apply(validate(this), arguments);
    },
    filter: function filter(callbackfn /*, thisArg */){
      return speciesFromList(this, arrayFilter(validate(this), callbackfn,
        arguments.length > 1 ? arguments[1] : undefined));
    },
    find: function find(predicate /*, thisArg */){
      return arrayFind(validate(this), predicate, arguments.length > 1 ? arguments[1] : undefined);
    },
    findIndex: function findIndex(predicate /*, thisArg */){
      return arrayFindIndex(validate(this), predicate, arguments.length > 1 ? arguments[1] : undefined);
    },
    forEach: function forEach(callbackfn /*, thisArg */){
      arrayForEach(validate(this), callbackfn, arguments.length > 1 ? arguments[1] : undefined);
    },
    indexOf: function indexOf(searchElement /*, fromIndex */){
      return arrayIndexOf(validate(this), searchElement, arguments.length > 1 ? arguments[1] : undefined);
    },
    includes: function includes(searchElement /*, fromIndex */){
      return arrayIncludes(validate(this), searchElement, arguments.length > 1 ? arguments[1] : undefined);
    },
    join: function join(separator){ // eslint-disable-line no-unused-vars
      return arrayJoin.apply(validate(this), arguments);
    },
    lastIndexOf: function lastIndexOf(searchElement /*, fromIndex */){ // eslint-disable-line no-unused-vars
      return arrayLastIndexOf.apply(validate(this), arguments);
    },
    map: function map(mapfn /*, thisArg */){
      return $map(validate(this), mapfn, arguments.length > 1 ? arguments[1] : undefined);
    },
    reduce: function reduce(callbackfn /*, initialValue */){ // eslint-disable-line no-unused-vars
      return arrayReduce.apply(validate(this), arguments);
    },
    reduceRight: function reduceRight(callbackfn /*, initialValue */){ // eslint-disable-line no-unused-vars
      return arrayReduceRight.apply(validate(this), arguments);
    },
    reverse: function reverse(){
      var that   = this
        , length = validate(that).length
        , middle = Math.floor(length / 2)
        , index  = 0
        , value;
      while(index < middle){
        value         = that[index];
        that[index++] = that[--length];
        that[length]  = value;
      } return that;
    },
    some: function some(callbackfn /*, thisArg */){
      return arraySome(validate(this), callbackfn, arguments.length > 1 ? arguments[1] : undefined);
    },
    sort: function sort(comparefn){
      return arraySort.call(validate(this), comparefn);
    },
    subarray: function subarray(begin, end){
      var O      = validate(this)
        , length = O.length
        , $begin = toIndex(begin, length);
      return new (speciesConstructor(O, O[DEF_CONSTRUCTOR]))(
        O.buffer,
        O.byteOffset + $begin * O.BYTES_PER_ELEMENT,
        toLength((end === undefined ? length : toIndex(end, length)) - $begin)
      );
    }
  };

  var $slice = function slice(start, end){
    return speciesFromList(this, arraySlice.call(validate(this), start, end));
  };

  var $set = function set(arrayLike /*, offset */){
    validate(this);
    var offset = toOffset(arguments[1], 1)
      , length = this.length
      , src    = toObject(arrayLike)
      , len    = toLength(src.length)
      , index  = 0;
    if(len + offset > length)throw RangeError(WRONG_LENGTH);
    while(index < len)this[offset + index] = src[index++];
  };

  var $iterators = {
    entries: function entries(){
      return arrayEntries.call(validate(this));
    },
    keys: function keys(){
      return arrayKeys.call(validate(this));
    },
    values: function values(){
      return arrayValues.call(validate(this));
    }
  };

  var isTAIndex = function(target, key){
    return isObject(target)
      && target[TYPED_ARRAY]
      && typeof key != 'symbol'
      && key in target
      && String(+key) == String(key);
  };
  var $getDesc = function getOwnPropertyDescriptor(target, key){
    return isTAIndex(target, key = toPrimitive(key, true))
      ? propertyDesc(2, target[key])
      : gOPD(target, key);
  };
  var $setDesc = function defineProperty(target, key, desc){
    if(isTAIndex(target, key = toPrimitive(key, true))
      && isObject(desc)
      && has(desc, 'value')
      && !has(desc, 'get')
      && !has(desc, 'set')
      // TODO: add validation descriptor w/o calling accessors
      && !desc.configurable
      && (!has(desc, 'writable') || desc.writable)
      && (!has(desc, 'enumerable') || desc.enumerable)
    ){
      target[key] = desc.value;
      return target;
    } else return dP(target, key, desc);
  };

  if(!ALL_CONSTRUCTORS){
    $GOPD.f = $getDesc;
    $DP.f   = $setDesc;
  }

  $export($export.S + $export.F * !ALL_CONSTRUCTORS, 'Object', {
    getOwnPropertyDescriptor: $getDesc,
    defineProperty:           $setDesc
  });

  if(fails(function(){ arrayToString.call({}); })){
    arrayToString = arrayToLocaleString = function toString(){
      return arrayJoin.call(this);
    };
  }

  var $TypedArrayPrototype$ = redefineAll({}, proto);
  redefineAll($TypedArrayPrototype$, $iterators);
  hide($TypedArrayPrototype$, ITERATOR, $iterators.values);
  redefineAll($TypedArrayPrototype$, {
    slice:          $slice,
    set:            $set,
    constructor:    function(){ /* noop */ },
    toString:       arrayToString,
    toLocaleString: $toLocaleString
  });
  addGetter($TypedArrayPrototype$, 'buffer', 'b');
  addGetter($TypedArrayPrototype$, 'byteOffset', 'o');
  addGetter($TypedArrayPrototype$, 'byteLength', 'l');
  addGetter($TypedArrayPrototype$, 'length', 'e');
  dP($TypedArrayPrototype$, TAG, {
    get: function(){ return this[TYPED_ARRAY]; }
  });

  module.exports = function(KEY, BYTES, wrapper, CLAMPED){
    CLAMPED = !!CLAMPED;
    var NAME       = KEY + (CLAMPED ? 'Clamped' : '') + 'Array'
      , ISNT_UINT8 = NAME != 'Uint8Array'
      , GETTER     = 'get' + KEY
      , SETTER     = 'set' + KEY
      , TypedArray = global[NAME]
      , Base       = TypedArray || {}
      , TAC        = TypedArray && getPrototypeOf(TypedArray)
      , FORCED     = !TypedArray || !$typed.ABV
      , O          = {}
      , TypedArrayPrototype = TypedArray && TypedArray[PROTOTYPE];
    var getter = function(that, index){
      var data = that._d;
      return data.v[GETTER](index * BYTES + data.o, LITTLE_ENDIAN);
    };
    var setter = function(that, index, value){
      var data = that._d;
      if(CLAMPED)value = (value = Math.round(value)) < 0 ? 0 : value > 0xff ? 0xff : value & 0xff;
      data.v[SETTER](index * BYTES + data.o, value, LITTLE_ENDIAN);
    };
    var addElement = function(that, index){
      dP(that, index, {
        get: function(){
          return getter(this, index);
        },
        set: function(value){
          return setter(this, index, value);
        },
        enumerable: true
      });
    };
    if(FORCED){
      TypedArray = wrapper(function(that, data, $offset, $length){
        anInstance(that, TypedArray, NAME, '_d');
        var index  = 0
          , offset = 0
          , buffer, byteLength, length, klass;
        if(!isObject(data)){
          length     = strictToLength(data, true);
          byteLength = length * BYTES;
          buffer     = new $ArrayBuffer(byteLength);
        } else if(data instanceof $ArrayBuffer || (klass = classof(data)) == ARRAY_BUFFER || klass == SHARED_BUFFER){
          buffer = data;
          offset = toOffset($offset, BYTES);
          var $len = data.byteLength;
          if($length === undefined){
            if($len % BYTES)throw RangeError(WRONG_LENGTH);
            byteLength = $len - offset;
            if(byteLength < 0)throw RangeError(WRONG_LENGTH);
          } else {
            byteLength = toLength($length) * BYTES;
            if(byteLength + offset > $len)throw RangeError(WRONG_LENGTH);
          }
          length = byteLength / BYTES;
        } else if(TYPED_ARRAY in data){
          return fromList(TypedArray, data);
        } else {
          return $from.call(TypedArray, data);
        }
        hide(that, '_d', {
          b: buffer,
          o: offset,
          l: byteLength,
          e: length,
          v: new $DataView(buffer)
        });
        while(index < length)addElement(that, index++);
      });
      TypedArrayPrototype = TypedArray[PROTOTYPE] = create($TypedArrayPrototype$);
      hide(TypedArrayPrototype, 'constructor', TypedArray);
    } else if(!$iterDetect(function(iter){
      // V8 works with iterators, but fails in many other cases
      // https://code.google.com/p/v8/issues/detail?id=4552
      new TypedArray(null); // eslint-disable-line no-new
      new TypedArray(iter); // eslint-disable-line no-new
    }, true)){
      TypedArray = wrapper(function(that, data, $offset, $length){
        anInstance(that, TypedArray, NAME);
        var klass;
        // `ws` module bug, temporarily remove validation length for Uint8Array
        // https://github.com/websockets/ws/pull/645
        if(!isObject(data))return new Base(strictToLength(data, ISNT_UINT8));
        if(data instanceof $ArrayBuffer || (klass = classof(data)) == ARRAY_BUFFER || klass == SHARED_BUFFER){
          return $length !== undefined
            ? new Base(data, toOffset($offset, BYTES), $length)
            : $offset !== undefined
              ? new Base(data, toOffset($offset, BYTES))
              : new Base(data);
        }
        if(TYPED_ARRAY in data)return fromList(TypedArray, data);
        return $from.call(TypedArray, data);
      });
      arrayForEach(TAC !== Function.prototype ? gOPN(Base).concat(gOPN(TAC)) : gOPN(Base), function(key){
        if(!(key in TypedArray))hide(TypedArray, key, Base[key]);
      });
      TypedArray[PROTOTYPE] = TypedArrayPrototype;
      if(!LIBRARY)TypedArrayPrototype.constructor = TypedArray;
    }
    var $nativeIterator   = TypedArrayPrototype[ITERATOR]
      , CORRECT_ITER_NAME = !!$nativeIterator && ($nativeIterator.name == 'values' || $nativeIterator.name == undefined)
      , $iterator         = $iterators.values;
    hide(TypedArray, TYPED_CONSTRUCTOR, true);
    hide(TypedArrayPrototype, TYPED_ARRAY, NAME);
    hide(TypedArrayPrototype, VIEW, true);
    hide(TypedArrayPrototype, DEF_CONSTRUCTOR, TypedArray);

    if(CLAMPED ? new TypedArray(1)[TAG] != NAME : !(TAG in TypedArrayPrototype)){
      dP(TypedArrayPrototype, TAG, {
        get: function(){ return NAME; }
      });
    }

    O[NAME] = TypedArray;

    $export($export.G + $export.W + $export.F * (TypedArray != Base), O);

    $export($export.S, NAME, {
      BYTES_PER_ELEMENT: BYTES,
      from: $from,
      of: $of
    });

    if(!(BYTES_PER_ELEMENT in TypedArrayPrototype))hide(TypedArrayPrototype, BYTES_PER_ELEMENT, BYTES);

    $export($export.P, NAME, proto);

    setSpecies(NAME);

    $export($export.P + $export.F * FORCED_SET, NAME, {set: $set});

    $export($export.P + $export.F * !CORRECT_ITER_NAME, NAME, $iterators);

    $export($export.P + $export.F * (TypedArrayPrototype.toString != arrayToString), NAME, {toString: arrayToString});

    $export($export.P + $export.F * fails(function(){
      new TypedArray(1).slice();
    }), NAME, {slice: $slice});

    $export($export.P + $export.F * (fails(function(){
      return [1, 2].toLocaleString() != new TypedArray([1, 2]).toLocaleString()
    }) || !fails(function(){
      TypedArrayPrototype.toLocaleString.call([1, 2]);
    })), NAME, {toLocaleString: $toLocaleString});

    Iterators[NAME] = CORRECT_ITER_NAME ? $nativeIterator : $iterator;
    if(!LIBRARY && !CORRECT_ITER_NAME)hide(TypedArrayPrototype, ITERATOR, $iterator);
  };
} else module.exports = function(){ /* empty */ };
});

_typedArray('Int8', 1, function(init){
  return function Int8Array(data, byteOffset, length){
    return init(this, data, byteOffset, length);
  };
});

_typedArray('Uint8', 1, function(init){
  return function Uint8Array(data, byteOffset, length){
    return init(this, data, byteOffset, length);
  };
});

_typedArray('Uint8', 1, function(init){
  return function Uint8ClampedArray(data, byteOffset, length){
    return init(this, data, byteOffset, length);
  };
}, true);

_typedArray('Int16', 2, function(init){
  return function Int16Array(data, byteOffset, length){
    return init(this, data, byteOffset, length);
  };
});

_typedArray('Uint16', 2, function(init){
  return function Uint16Array(data, byteOffset, length){
    return init(this, data, byteOffset, length);
  };
});

_typedArray('Int32', 4, function(init){
  return function Int32Array(data, byteOffset, length){
    return init(this, data, byteOffset, length);
  };
});

_typedArray('Uint32', 4, function(init){
  return function Uint32Array(data, byteOffset, length){
    return init(this, data, byteOffset, length);
  };
});

_typedArray('Float32', 4, function(init){
  return function Float32Array(data, byteOffset, length){
    return init(this, data, byteOffset, length);
  };
});

_typedArray('Float64', 8, function(init){
  return function Float64Array(data, byteOffset, length){
    return init(this, data, byteOffset, length);
  };
});

// 26.1.1 Reflect.apply(target, thisArgument, argumentsList)
var $export$83   = _export$2;
var aFunction$7 = _aFunction$2;
var anObject$17  = _anObject$2;
var rApply    = (_global$2.Reflect || {}).apply;
var fApply    = Function.apply;
// MS Edge argumentsList argument is optional
$export$83($export$83.S + $export$83.F * !_fails$2(function(){
  rApply(function(){});
}), 'Reflect', {
  apply: function apply(target, thisArgument, argumentsList){
    var T = aFunction$7(target)
      , L = anObject$17(argumentsList);
    return rApply ? rApply(T, thisArgument, L) : fApply.call(T, thisArgument, L);
  }
});

// 26.1.2 Reflect.construct(target, argumentsList [, newTarget])
var $export$84    = _export$2;
var create$8     = _objectCreate$2;
var aFunction$8  = _aFunction$2;
var anObject$18   = _anObject$2;
var isObject$24   = _isObject$2;
var fails$10      = _fails$2;
var bind$1       = _bind;
var rConstruct = (_global$2.Reflect || {}).construct;

// MS Edge supports only 2 arguments and argumentsList argument is optional
// FF Nightly sets third argument as `new.target`, but does not create `this` from it
var NEW_TARGET_BUG = fails$10(function(){
  function F(){}
  return !(rConstruct(function(){}, [], F) instanceof F);
});
var ARGS_BUG = !fails$10(function(){
  rConstruct(function(){});
});

$export$84($export$84.S + $export$84.F * (NEW_TARGET_BUG || ARGS_BUG), 'Reflect', {
  construct: function construct(Target, args /*, newTarget*/){
    aFunction$8(Target);
    anObject$18(args);
    var newTarget = arguments.length < 3 ? Target : aFunction$8(arguments[2]);
    if(ARGS_BUG && !NEW_TARGET_BUG)return rConstruct(Target, args, newTarget);
    if(Target == newTarget){
      // w/o altered newTarget, optimization for 0-4 arguments
      switch(args.length){
        case 0: return new Target;
        case 1: return new Target(args[0]);
        case 2: return new Target(args[0], args[1]);
        case 3: return new Target(args[0], args[1], args[2]);
        case 4: return new Target(args[0], args[1], args[2], args[3]);
      }
      // w/o altered newTarget, lot of arguments case
      var $args = [null];
      $args.push.apply($args, args);
      return new (bind$1.apply(Target, $args));
    }
    // with altered newTarget, not support built-in constructors
    var proto    = newTarget.prototype
      , instance = create$8(isObject$24(proto) ? proto : Object.prototype)
      , result   = Function.apply.call(Target, instance, args);
    return isObject$24(result) ? result : instance;
  }
});

// 26.1.3 Reflect.defineProperty(target, propertyKey, attributes)
var dP$13          = _objectDp$2;
var $export$85     = _export$2;
var anObject$19    = _anObject$2;
var toPrimitive$9 = _toPrimitive$2;

// MS Edge has broken Reflect.defineProperty - throwing instead of returning false
$export$85($export$85.S + $export$85.F * _fails$2(function(){
  Reflect.defineProperty(dP$13.f({}, 1, {value: 1}), 1, {value: 2});
}), 'Reflect', {
  defineProperty: function defineProperty(target, propertyKey, attributes){
    anObject$19(target);
    propertyKey = toPrimitive$9(propertyKey, true);
    anObject$19(attributes);
    try {
      dP$13.f(target, propertyKey, attributes);
      return true;
    } catch(e){
      return false;
    }
  }
});

// 26.1.4 Reflect.deleteProperty(target, propertyKey)
var $export$86  = _export$2;
var gOPD$5     = _objectGopd$2.f;
var anObject$20 = _anObject$2;

$export$86($export$86.S, 'Reflect', {
  deleteProperty: function deleteProperty(target, propertyKey){
    var desc = gOPD$5(anObject$20(target), propertyKey);
    return desc && !desc.configurable ? false : delete target[propertyKey];
  }
});

// 26.1.5 Reflect.enumerate(target)
var $export$87  = _export$2;
var anObject$21 = _anObject$2;
var Enumerate = function(iterated){
  this._t = anObject$21(iterated); // target
  this._i = 0;                  // next index
  var keys = this._k = []       // keys
    , key;
  for(key in iterated)keys.push(key);
};
_iterCreate$2(Enumerate, 'Object', function(){
  var that = this
    , keys = that._k
    , key;
  do {
    if(that._i >= keys.length)return {value: undefined, done: true};
  } while(!((key = keys[that._i++]) in that._t));
  return {value: key, done: false};
});

$export$87($export$87.S, 'Reflect', {
  enumerate: function enumerate(target){
    return new Enumerate(target);
  }
});

// 26.1.6 Reflect.get(target, propertyKey [, receiver])
var gOPD$6           = _objectGopd$2;
var getPrototypeOf$7 = _objectGpo$2;
var has$15            = _has$2;
var $export$88        = _export$2;
var isObject$25       = _isObject$2;
var anObject$22       = _anObject$2;

function get$1(target, propertyKey/*, receiver*/){
  var receiver = arguments.length < 3 ? target : arguments[2]
    , desc, proto;
  if(anObject$22(target) === receiver)return target[propertyKey];
  if(desc = gOPD$6.f(target, propertyKey))return has$15(desc, 'value')
    ? desc.value
    : desc.get !== undefined
      ? desc.get.call(receiver)
      : undefined;
  if(isObject$25(proto = getPrototypeOf$7(target)))return get$1(proto, propertyKey, receiver);
}

$export$88($export$88.S, 'Reflect', {get: get$1});

// 26.1.7 Reflect.getOwnPropertyDescriptor(target, propertyKey)
var gOPD$7     = _objectGopd$2;
var $export$89  = _export$2;
var anObject$23 = _anObject$2;

$export$89($export$89.S, 'Reflect', {
  getOwnPropertyDescriptor: function getOwnPropertyDescriptor(target, propertyKey){
    return gOPD$7.f(anObject$23(target), propertyKey);
  }
});

// 26.1.8 Reflect.getPrototypeOf(target)
var $export$90  = _export$2;
var getProto = _objectGpo$2;
var anObject$24 = _anObject$2;

$export$90($export$90.S, 'Reflect', {
  getPrototypeOf: function getPrototypeOf(target){
    return getProto(anObject$24(target));
  }
});

// 26.1.9 Reflect.has(target, propertyKey)
var $export$91 = _export$2;

$export$91($export$91.S, 'Reflect', {
  has: function has(target, propertyKey){
    return propertyKey in target;
  }
});

// 26.1.10 Reflect.isExtensible(target)
var $export$92       = _export$2;
var anObject$25      = _anObject$2;
var $isExtensible = Object.isExtensible;

$export$92($export$92.S, 'Reflect', {
  isExtensible: function isExtensible(target){
    anObject$25(target);
    return $isExtensible ? $isExtensible(target) : true;
  }
});

// all object keys, includes non-enumerable and symbols
var gOPN$6     = _objectGopn$2;
var gOPS$3     = _objectGops$2;
var anObject$26 = _anObject$2;
var Reflect$1  = _global$2.Reflect;
var _ownKeys = Reflect$1 && Reflect$1.ownKeys || function ownKeys(it){
  var keys       = gOPN$6.f(anObject$26(it))
    , getSymbols = gOPS$3.f;
  return getSymbols ? keys.concat(getSymbols(it)) : keys;
};

// 26.1.11 Reflect.ownKeys(target)
var $export$93 = _export$2;

$export$93($export$93.S, 'Reflect', {ownKeys: _ownKeys});

// 26.1.12 Reflect.preventExtensions(target)
var $export$94            = _export$2;
var anObject$27           = _anObject$2;
var $preventExtensions = Object.preventExtensions;

$export$94($export$94.S, 'Reflect', {
  preventExtensions: function preventExtensions(target){
    anObject$27(target);
    try {
      if($preventExtensions)$preventExtensions(target);
      return true;
    } catch(e){
      return false;
    }
  }
});

// 26.1.13 Reflect.set(target, propertyKey, V [, receiver])
var dP$14             = _objectDp$2;
var gOPD$8           = _objectGopd$2;
var getPrototypeOf$8 = _objectGpo$2;
var has$16            = _has$2;
var $export$95        = _export$2;
var createDesc$8     = _propertyDesc$2;
var anObject$28       = _anObject$2;
var isObject$26       = _isObject$2;

function set$1(target, propertyKey, V/*, receiver*/){
  var receiver = arguments.length < 4 ? target : arguments[3]
    , ownDesc  = gOPD$8.f(anObject$28(target), propertyKey)
    , existingDescriptor, proto;
  if(!ownDesc){
    if(isObject$26(proto = getPrototypeOf$8(target))){
      return set$1(proto, propertyKey, V, receiver);
    }
    ownDesc = createDesc$8(0);
  }
  if(has$16(ownDesc, 'value')){
    if(ownDesc.writable === false || !isObject$26(receiver))return false;
    existingDescriptor = gOPD$8.f(receiver, propertyKey) || createDesc$8(0);
    existingDescriptor.value = V;
    dP$14.f(receiver, propertyKey, existingDescriptor);
    return true;
  }
  return ownDesc.set === undefined ? false : (ownDesc.set.call(receiver, V), true);
}

$export$95($export$95.S, 'Reflect', {set: set$1});

// 26.1.14 Reflect.setPrototypeOf(target, proto)
var $export$96  = _export$2;
var setProto = _setProto$2;

if(setProto)$export$96($export$96.S, 'Reflect', {
  setPrototypeOf: function setPrototypeOf(target, proto){
    setProto.check(target, proto);
    try {
      setProto.set(target, proto);
      return true;
    } catch(e){
      return false;
    }
  }
});

// https://github.com/tc39/Array.prototype.includes
var $export$97   = _export$2;
var $includes = _arrayIncludes$2(true);

$export$97($export$97.P, 'Array', {
  includes: function includes(el /*, fromIndex = 0 */){
    return $includes(this, el, arguments.length > 1 ? arguments[1] : undefined);
  }
});

_addToUnscopables$2('includes');

// https://github.com/mathiasbynens/String.prototype.at
var $export$98 = _export$2;
var $at$3     = _stringAt$2(true);

$export$98($export$98.P, 'String', {
  at: function at(pos){
    return $at$3(this, pos);
  }
});

// https://github.com/tc39/proposal-string-pad-start-end
var toLength$13 = _toLength$2;
var repeat$2   = _stringRepeat;
var defined$12  = _defined$2;

var _stringPad = function(that, maxLength, fillString, left){
  var S            = String(defined$12(that))
    , stringLength = S.length
    , fillStr      = fillString === undefined ? ' ' : String(fillString)
    , intMaxLength = toLength$13(maxLength);
  if(intMaxLength <= stringLength || fillStr == '')return S;
  var fillLen = intMaxLength - stringLength
    , stringFiller = repeat$2.call(fillStr, Math.ceil(fillLen / fillStr.length));
  if(stringFiller.length > fillLen)stringFiller = stringFiller.slice(0, fillLen);
  return left ? stringFiller + S : S + stringFiller;
};

// https://github.com/tc39/proposal-string-pad-start-end
var $export$99 = _export$2;
var $pad    = _stringPad;

$export$99($export$99.P, 'String', {
  padStart: function padStart(maxLength /*, fillString = ' ' */){
    return $pad(this, maxLength, arguments.length > 1 ? arguments[1] : undefined, true);
  }
});

// https://github.com/tc39/proposal-string-pad-start-end
var $export$100 = _export$2;
var $pad$1    = _stringPad;

$export$100($export$100.P, 'String', {
  padEnd: function padEnd(maxLength /*, fillString = ' ' */){
    return $pad$1(this, maxLength, arguments.length > 1 ? arguments[1] : undefined, false);
  }
});

// https://github.com/sebmarkbage/ecmascript-string-left-right-trim
_stringTrim('trimLeft', function($trim){
  return function trimLeft(){
    return $trim(this, 1);
  };
}, 'trimStart');

// https://github.com/sebmarkbage/ecmascript-string-left-right-trim
_stringTrim('trimRight', function($trim){
  return function trimRight(){
    return $trim(this, 2);
  };
}, 'trimEnd');

// https://tc39.github.io/String.prototype.matchAll/
var $export$101     = _export$2;
var defined$13     = _defined$2;
var toLength$14    = _toLength$2;
var isRegExp$2    = _isRegexp;
var getFlags    = _flags;
var RegExpProto = RegExp.prototype;

var $RegExpStringIterator = function(regexp, string){
  this._r = regexp;
  this._s = string;
};

_iterCreate$2($RegExpStringIterator, 'RegExp String', function next(){
  var match = this._r.exec(this._s);
  return {value: match, done: match === null};
});

$export$101($export$101.P, 'String', {
  matchAll: function matchAll(regexp){
    defined$13(this);
    if(!isRegExp$2(regexp))throw TypeError(regexp + ' is not a regexp!');
    var S     = String(this)
      , flags = 'flags' in RegExpProto ? String(regexp.flags) : getFlags.call(regexp)
      , rx    = new RegExp(regexp.source, ~flags.indexOf('g') ? flags : 'g' + flags);
    rx.lastIndex = toLength$14(regexp.lastIndex);
    return new $RegExpStringIterator(rx, S);
  }
});

_wksDefine$2('asyncIterator');

_wksDefine$2('observable');

// https://github.com/tc39/proposal-object-getownpropertydescriptors
var $export$102        = _export$2;
var ownKeys$1        = _ownKeys;
var toIObject$18      = _toIobject$2;
var gOPD$9           = _objectGopd$2;
var createProperty$2 = _createProperty;

$export$102($export$102.S, 'Object', {
  getOwnPropertyDescriptors: function getOwnPropertyDescriptors(object){
    var O       = toIObject$18(object)
      , getDesc = gOPD$9.f
      , keys    = ownKeys$1(O)
      , result  = {}
      , i       = 0
      , key;
    while(keys.length > i)createProperty$2(result, key = keys[i++], getDesc(O, key));
    return result;
  }
});

var getKeys$7   = _objectKeys$2;
var toIObject$19 = _toIobject$2;
var isEnum$2    = _objectPie$2.f;
var _objectToArray = function(isEntries){
  return function(it){
    var O      = toIObject$19(it)
      , keys   = getKeys$7(O)
      , length = keys.length
      , i      = 0
      , result = []
      , key;
    while(length > i)if(isEnum$2.call(O, key = keys[i++])){
      result.push(isEntries ? [key, O[key]] : O[key]);
    } return result;
  };
};

// https://github.com/tc39/proposal-object-values-entries
var $export$103 = _export$2;
var $values = _objectToArray(false);

$export$103($export$103.S, 'Object', {
  values: function values(it){
    return $values(it);
  }
});

// https://github.com/tc39/proposal-object-values-entries
var $export$104  = _export$2;
var $entries = _objectToArray(true);

$export$104($export$104.S, 'Object', {
  entries: function entries(it){
    return $entries(it);
  }
});

// Forced replacement prototype accessors methods
var _objectForcedPam = _library$2|| !_fails$2(function(){
  var K = Math.random();
  // In FF throws only define methods
  __defineSetter__.call(null, K, function(){ /* empty */});
  delete _global$2[K];
});

var $export$105         = _export$2;
var toObject$13        = _toObject$2;
var aFunction$9       = _aFunction$2;
var $defineProperty$3 = _objectDp$2;

// B.2.2.2 Object.prototype.__defineGetter__(P, getter)
_descriptors$2 && $export$105($export$105.P + _objectForcedPam, 'Object', {
  __defineGetter__: function __defineGetter__(P, getter){
    $defineProperty$3.f(toObject$13(this), P, {get: aFunction$9(getter), enumerable: true, configurable: true});
  }
});

var $export$106         = _export$2;
var toObject$14        = _toObject$2;
var aFunction$10       = _aFunction$2;
var $defineProperty$4 = _objectDp$2;

// B.2.2.3 Object.prototype.__defineSetter__(P, setter)
_descriptors$2 && $export$106($export$106.P + _objectForcedPam, 'Object', {
  __defineSetter__: function __defineSetter__(P, setter){
    $defineProperty$4.f(toObject$14(this), P, {set: aFunction$10(setter), enumerable: true, configurable: true});
  }
});

var $export$107                  = _export$2;
var toObject$15                 = _toObject$2;
var toPrimitive$10              = _toPrimitive$2;
var getPrototypeOf$9           = _objectGpo$2;
var getOwnPropertyDescriptor$1 = _objectGopd$2.f;

// B.2.2.4 Object.prototype.__lookupGetter__(P)
_descriptors$2 && $export$107($export$107.P + _objectForcedPam, 'Object', {
  __lookupGetter__: function __lookupGetter__(P){
    var O = toObject$15(this)
      , K = toPrimitive$10(P, true)
      , D;
    do {
      if(D = getOwnPropertyDescriptor$1(O, K))return D.get;
    } while(O = getPrototypeOf$9(O));
  }
});

var $export$108                  = _export$2;
var toObject$16                 = _toObject$2;
var toPrimitive$11              = _toPrimitive$2;
var getPrototypeOf$10           = _objectGpo$2;
var getOwnPropertyDescriptor$2 = _objectGopd$2.f;

// B.2.2.5 Object.prototype.__lookupSetter__(P)
_descriptors$2 && $export$108($export$108.P + _objectForcedPam, 'Object', {
  __lookupSetter__: function __lookupSetter__(P){
    var O = toObject$16(this)
      , K = toPrimitive$11(P, true)
      , D;
    do {
      if(D = getOwnPropertyDescriptor$2(O, K))return D.set;
    } while(O = getPrototypeOf$10(O));
  }
});

var forOf$4 = _forOf;

var _arrayFromIterable = function(iter, ITERATOR){
  var result = [];
  forOf$4(iter, false, result.push, result, ITERATOR);
  return result;
};

// https://github.com/DavidBruant/Map-Set.prototype.toJSON
var classof$3 = _classof;
var from$1    = _arrayFromIterable;
var _collectionToJson = function(NAME){
  return function toJSON(){
    if(classof$3(this) != NAME)throw TypeError(NAME + "#toJSON isn't generic");
    return from$1(this);
  };
};

// https://github.com/DavidBruant/Map-Set.prototype.toJSON
var $export$109  = _export$2;

$export$109($export$109.P + $export$109.R, 'Map', {toJSON: _collectionToJson('Map')});

// https://github.com/DavidBruant/Map-Set.prototype.toJSON
var $export$110  = _export$2;

$export$110($export$110.P + $export$110.R, 'Set', {toJSON: _collectionToJson('Set')});

// https://github.com/ljharb/proposal-global
var $export$111 = _export$2;

$export$111($export$111.S, 'System', {global: _global$2});

// https://github.com/ljharb/proposal-is-error
var $export$112 = _export$2;
var cof$9     = _cof$2;

$export$112($export$112.S, 'Error', {
  isError: function isError(it){
    return cof$9(it) === 'Error';
  }
});

// https://gist.github.com/BrendanEich/4294d5c212a6d2254703
var $export$113 = _export$2;

$export$113($export$113.S, 'Math', {
  iaddh: function iaddh(x0, x1, y0, y1){
    var $x0 = x0 >>> 0
      , $x1 = x1 >>> 0
      , $y0 = y0 >>> 0;
    return $x1 + (y1 >>> 0) + (($x0 & $y0 | ($x0 | $y0) & ~($x0 + $y0 >>> 0)) >>> 31) | 0;
  }
});

// https://gist.github.com/BrendanEich/4294d5c212a6d2254703
var $export$114 = _export$2;

$export$114($export$114.S, 'Math', {
  isubh: function isubh(x0, x1, y0, y1){
    var $x0 = x0 >>> 0
      , $x1 = x1 >>> 0
      , $y0 = y0 >>> 0;
    return $x1 - (y1 >>> 0) - ((~$x0 & $y0 | ~($x0 ^ $y0) & $x0 - $y0 >>> 0) >>> 31) | 0;
  }
});

// https://gist.github.com/BrendanEich/4294d5c212a6d2254703
var $export$115 = _export$2;

$export$115($export$115.S, 'Math', {
  imulh: function imulh(u, v){
    var UINT16 = 0xffff
      , $u = +u
      , $v = +v
      , u0 = $u & UINT16
      , v0 = $v & UINT16
      , u1 = $u >> 16
      , v1 = $v >> 16
      , t  = (u1 * v0 >>> 0) + (u0 * v0 >>> 16);
    return u1 * v1 + (t >> 16) + ((u0 * v1 >>> 0) + (t & UINT16) >> 16);
  }
});

// https://gist.github.com/BrendanEich/4294d5c212a6d2254703
var $export$116 = _export$2;

$export$116($export$116.S, 'Math', {
  umulh: function umulh(u, v){
    var UINT16 = 0xffff
      , $u = +u
      , $v = +v
      , u0 = $u & UINT16
      , v0 = $v & UINT16
      , u1 = $u >>> 16
      , v1 = $v >>> 16
      , t  = (u1 * v0 >>> 0) + (u0 * v0 >>> 16);
    return u1 * v1 + (t >>> 16) + ((u0 * v1 >>> 0) + (t & UINT16) >>> 16);
  }
});

var Map$1     = es6_map;
var $export$117 = _export$2;
var shared$4  = _shared$2('metadata');
var store$2   = shared$4.store || (shared$4.store = new (es6_weakMap));

var getOrCreateMetadataMap = function(target, targetKey, create){
  var targetMetadata = store$2.get(target);
  if(!targetMetadata){
    if(!create)return undefined;
    store$2.set(target, targetMetadata = new Map$1);
  }
  var keyMetadata = targetMetadata.get(targetKey);
  if(!keyMetadata){
    if(!create)return undefined;
    targetMetadata.set(targetKey, keyMetadata = new Map$1);
  } return keyMetadata;
};
var ordinaryHasOwnMetadata = function(MetadataKey, O, P){
  var metadataMap = getOrCreateMetadataMap(O, P, false);
  return metadataMap === undefined ? false : metadataMap.has(MetadataKey);
};
var ordinaryGetOwnMetadata = function(MetadataKey, O, P){
  var metadataMap = getOrCreateMetadataMap(O, P, false);
  return metadataMap === undefined ? undefined : metadataMap.get(MetadataKey);
};
var ordinaryDefineOwnMetadata$1 = function(MetadataKey, MetadataValue, O, P){
  getOrCreateMetadataMap(O, P, true).set(MetadataKey, MetadataValue);
};
var ordinaryOwnMetadataKeys = function(target, targetKey){
  var metadataMap = getOrCreateMetadataMap(target, targetKey, false)
    , keys        = [];
  if(metadataMap)metadataMap.forEach(function(_, key){ keys.push(key); });
  return keys;
};
var toMetaKey$1 = function(it){
  return it === undefined || typeof it == 'symbol' ? it : String(it);
};
var exp$3 = function(O){
  $export$117($export$117.S, 'Reflect', O);
};

var _metadata = {
  store: store$2,
  map: getOrCreateMetadataMap,
  has: ordinaryHasOwnMetadata,
  get: ordinaryGetOwnMetadata,
  set: ordinaryDefineOwnMetadata$1,
  keys: ordinaryOwnMetadataKeys,
  key: toMetaKey$1,
  exp: exp$3
};

var metadata                  = _metadata;
var anObject$29                  = _anObject$2;
var toMetaKey                 = metadata.key;
var ordinaryDefineOwnMetadata = metadata.set;

metadata.exp({defineMetadata: function defineMetadata(metadataKey, metadataValue, target, targetKey){
  ordinaryDefineOwnMetadata(metadataKey, metadataValue, anObject$29(target), toMetaKey(targetKey));
}});

var metadata$1               = _metadata;
var anObject$30               = _anObject$2;
var toMetaKey$2              = metadata$1.key;
var getOrCreateMetadataMap$1 = metadata$1.map;
var store$3                  = metadata$1.store;

metadata$1.exp({deleteMetadata: function deleteMetadata(metadataKey, target /*, targetKey */){
  var targetKey   = arguments.length < 3 ? undefined : toMetaKey$2(arguments[2])
    , metadataMap = getOrCreateMetadataMap$1(anObject$30(target), targetKey, false);
  if(metadataMap === undefined || !metadataMap['delete'](metadataKey))return false;
  if(metadataMap.size)return true;
  var targetMetadata = store$3.get(target);
  targetMetadata['delete'](targetKey);
  return !!targetMetadata.size || store$3['delete'](target);
}});

var metadata$2               = _metadata;
var anObject$31               = _anObject$2;
var getPrototypeOf$11         = _objectGpo$2;
var ordinaryHasOwnMetadata$1 = metadata$2.has;
var ordinaryGetOwnMetadata$1 = metadata$2.get;
var toMetaKey$3              = metadata$2.key;

var ordinaryGetMetadata = function(MetadataKey, O, P){
  var hasOwn = ordinaryHasOwnMetadata$1(MetadataKey, O, P);
  if(hasOwn)return ordinaryGetOwnMetadata$1(MetadataKey, O, P);
  var parent = getPrototypeOf$11(O);
  return parent !== null ? ordinaryGetMetadata(MetadataKey, parent, P) : undefined;
};

metadata$2.exp({getMetadata: function getMetadata(metadataKey, target /*, targetKey */){
  return ordinaryGetMetadata(metadataKey, anObject$31(target), arguments.length < 3 ? undefined : toMetaKey$3(arguments[2]));
}});

var Set$1                     = es6_set;
var from$2                    = _arrayFromIterable;
var metadata$3                = _metadata;
var anObject$32                = _anObject$2;
var getPrototypeOf$12          = _objectGpo$2;
var ordinaryOwnMetadataKeys$1 = metadata$3.keys;
var toMetaKey$4               = metadata$3.key;

var ordinaryMetadataKeys = function(O, P){
  var oKeys  = ordinaryOwnMetadataKeys$1(O, P)
    , parent = getPrototypeOf$12(O);
  if(parent === null)return oKeys;
  var pKeys  = ordinaryMetadataKeys(parent, P);
  return pKeys.length ? oKeys.length ? from$2(new Set$1(oKeys.concat(pKeys))) : pKeys : oKeys;
};

metadata$3.exp({getMetadataKeys: function getMetadataKeys(target /*, targetKey */){
  return ordinaryMetadataKeys(anObject$32(target), arguments.length < 2 ? undefined : toMetaKey$4(arguments[1]));
}});

var metadata$4               = _metadata;
var anObject$33               = _anObject$2;
var ordinaryGetOwnMetadata$2 = metadata$4.get;
var toMetaKey$5              = metadata$4.key;

metadata$4.exp({getOwnMetadata: function getOwnMetadata(metadataKey, target /*, targetKey */){
  return ordinaryGetOwnMetadata$2(metadataKey, anObject$33(target)
    , arguments.length < 3 ? undefined : toMetaKey$5(arguments[2]));
}});

var metadata$5                = _metadata;
var anObject$34                = _anObject$2;
var ordinaryOwnMetadataKeys$2 = metadata$5.keys;
var toMetaKey$6               = metadata$5.key;

metadata$5.exp({getOwnMetadataKeys: function getOwnMetadataKeys(target /*, targetKey */){
  return ordinaryOwnMetadataKeys$2(anObject$34(target), arguments.length < 2 ? undefined : toMetaKey$6(arguments[1]));
}});

var metadata$6               = _metadata;
var anObject$35               = _anObject$2;
var getPrototypeOf$13         = _objectGpo$2;
var ordinaryHasOwnMetadata$2 = metadata$6.has;
var toMetaKey$7              = metadata$6.key;

var ordinaryHasMetadata = function(MetadataKey, O, P){
  var hasOwn = ordinaryHasOwnMetadata$2(MetadataKey, O, P);
  if(hasOwn)return true;
  var parent = getPrototypeOf$13(O);
  return parent !== null ? ordinaryHasMetadata(MetadataKey, parent, P) : false;
};

metadata$6.exp({hasMetadata: function hasMetadata(metadataKey, target /*, targetKey */){
  return ordinaryHasMetadata(metadataKey, anObject$35(target), arguments.length < 3 ? undefined : toMetaKey$7(arguments[2]));
}});

var metadata$7               = _metadata;
var anObject$36               = _anObject$2;
var ordinaryHasOwnMetadata$3 = metadata$7.has;
var toMetaKey$8              = metadata$7.key;

metadata$7.exp({hasOwnMetadata: function hasOwnMetadata(metadataKey, target /*, targetKey */){
  return ordinaryHasOwnMetadata$3(metadataKey, anObject$36(target)
    , arguments.length < 3 ? undefined : toMetaKey$8(arguments[2]));
}});

var metadata$8                  = _metadata;
var anObject$37                  = _anObject$2;
var aFunction$11                 = _aFunction$2;
var toMetaKey$9                 = metadata$8.key;
var ordinaryDefineOwnMetadata$2 = metadata$8.set;

metadata$8.exp({metadata: function metadata$8(metadataKey, metadataValue){
  return function decorator(target, targetKey){
    ordinaryDefineOwnMetadata$2(
      metadataKey, metadataValue,
      (targetKey !== undefined ? anObject$37 : aFunction$11)(target),
      toMetaKey$9(targetKey)
    );
  };
}});

// https://github.com/rwaldron/tc39-notes/blob/master/es6/2014-09/sept-25.md#510-globalasap-for-enqueuing-a-microtask
var $export$118   = _export$2;
var microtask$1 = _microtask();
var process$3   = _global$2.process;
var isNode$2    = _cof$2(process$3) == 'process';

$export$118($export$118.G, {
  asap: function asap(fn){
    var domain = isNode$2 && process$3.domain;
    microtask$1(domain ? domain.bind(fn) : fn);
  }
});

// https://github.com/zenparsing/es-observable
var $export$119     = _export$2;
var global$18      = _global$2;
var core$6        = _core$2;
var microtask$2   = _microtask();
var OBSERVABLE  = _wks$2('observable');
var aFunction$12   = _aFunction$2;
var anObject$38    = _anObject$2;
var anInstance$4  = _anInstance;
var redefineAll$3 = _redefineAll;
var hide$7        = _hide$2;
var forOf$5       = _forOf;
var RETURN      = forOf$5.RETURN;

var getMethod = function(fn){
  return fn == null ? undefined : aFunction$12(fn);
};

var cleanupSubscription = function(subscription){
  var cleanup = subscription._c;
  if(cleanup){
    subscription._c = undefined;
    cleanup();
  }
};

var subscriptionClosed = function(subscription){
  return subscription._o === undefined;
};

var closeSubscription = function(subscription){
  if(!subscriptionClosed(subscription)){
    subscription._o = undefined;
    cleanupSubscription(subscription);
  }
};

var Subscription = function(observer, subscriber){
  anObject$38(observer);
  this._c = undefined;
  this._o = observer;
  observer = new SubscriptionObserver(this);
  try {
    var cleanup      = subscriber(observer)
      , subscription = cleanup;
    if(cleanup != null){
      if(typeof cleanup.unsubscribe === 'function')cleanup = function(){ subscription.unsubscribe(); };
      else aFunction$12(cleanup);
      this._c = cleanup;
    }
  } catch(e){
    observer.error(e);
    return;
  } if(subscriptionClosed(this))cleanupSubscription(this);
};

Subscription.prototype = redefineAll$3({}, {
  unsubscribe: function unsubscribe(){ closeSubscription(this); }
});

var SubscriptionObserver = function(subscription){
  this._s = subscription;
};

SubscriptionObserver.prototype = redefineAll$3({}, {
  next: function next(value){
    var subscription = this._s;
    if(!subscriptionClosed(subscription)){
      var observer = subscription._o;
      try {
        var m = getMethod(observer.next);
        if(m)return m.call(observer, value);
      } catch(e){
        try {
          closeSubscription(subscription);
        } finally {
          throw e;
        }
      }
    }
  },
  error: function error(value){
    var subscription = this._s;
    if(subscriptionClosed(subscription))throw value;
    var observer = subscription._o;
    subscription._o = undefined;
    try {
      var m = getMethod(observer.error);
      if(!m)throw value;
      value = m.call(observer, value);
    } catch(e){
      try {
        cleanupSubscription(subscription);
      } finally {
        throw e;
      }
    } cleanupSubscription(subscription);
    return value;
  },
  complete: function complete(value){
    var subscription = this._s;
    if(!subscriptionClosed(subscription)){
      var observer = subscription._o;
      subscription._o = undefined;
      try {
        var m = getMethod(observer.complete);
        value = m ? m.call(observer, value) : undefined;
      } catch(e){
        try {
          cleanupSubscription(subscription);
        } finally {
          throw e;
        }
      } cleanupSubscription(subscription);
      return value;
    }
  }
});

var $Observable = function Observable(subscriber){
  anInstance$4(this, $Observable, 'Observable', '_f')._f = aFunction$12(subscriber);
};

redefineAll$3($Observable.prototype, {
  subscribe: function subscribe(observer){
    return new Subscription(observer, this._f);
  },
  forEach: function forEach(fn){
    var that = this;
    return new (core$6.Promise || global$18.Promise)(function(resolve, reject){
      aFunction$12(fn);
      var subscription = that.subscribe({
        next : function(value){
          try {
            return fn(value);
          } catch(e){
            reject(e);
            subscription.unsubscribe();
          }
        },
        error: reject,
        complete: resolve
      });
    });
  }
});

redefineAll$3($Observable, {
  from: function from(x){
    var C = typeof this === 'function' ? this : $Observable;
    var method = getMethod(anObject$38(x)[OBSERVABLE]);
    if(method){
      var observable = anObject$38(method.call(x));
      return observable.constructor === C ? observable : new C(function(observer){
        return observable.subscribe(observer);
      });
    }
    return new C(function(observer){
      var done = false;
      microtask$2(function(){
        if(!done){
          try {
            if(forOf$5(x, false, function(it){
              observer.next(it);
              if(done)return RETURN;
            }) === RETURN)return;
          } catch(e){
            if(done)throw e;
            observer.error(e);
            return;
          } observer.complete();
        }
      });
      return function(){ done = true; };
    });
  },
  of: function of(){
    for(var i = 0, l = arguments.length, items = Array(l); i < l;)items[i] = arguments[i++];
    return new (typeof this === 'function' ? this : $Observable)(function(observer){
      var done = false;
      microtask$2(function(){
        if(!done){
          for(var i = 0; i < items.length; ++i){
            observer.next(items[i]);
            if(done)return;
          } observer.complete();
        }
      });
      return function(){ done = true; };
    });
  }
});

hide$7($Observable.prototype, OBSERVABLE, function(){ return this; });

$export$119($export$119.G, {Observable: $Observable});

_setSpecies('Observable');

var _path = _global$2;

var path      = _path;
var invoke$3    = _invoke;
var aFunction$13 = _aFunction$2;
var _partial = function(/* ...pargs */){
  var fn     = aFunction$13(this)
    , length = arguments.length
    , pargs  = Array(length)
    , i      = 0
    , _      = path._
    , holder = false;
  while(length > i)if((pargs[i] = arguments[i++]) === _)holder = true;
  return function(/* ...args */){
    var that = this
      , aLen = arguments.length
      , j = 0, k = 0, args;
    if(!holder && !aLen)return invoke$3(fn, pargs, that);
    args = pargs.slice();
    if(holder)for(;length > j; j++)if(args[j] === _)args[j] = arguments[k++];
    while(aLen > k)args.push(arguments[k++]);
    return invoke$3(fn, args, that);
  };
};

// ie9- setTimeout & setInterval additional parameters fix
var global$19     = _global$2;
var $export$120    = _export$2;
var invoke$2     = _invoke;
var partial    = _partial;
var navigator  = global$19.navigator;
var MSIE       = !!navigator && /MSIE .\./.test(navigator.userAgent); // <- dirty ie9- check
var wrap$2 = function(set){
  return MSIE ? function(fn, time /*, ...args */){
    return set(invoke$2(
      partial,
      [].slice.call(arguments, 2),
      typeof fn == 'function' ? fn : Function(fn)
    ), time);
  } : set;
};
$export$120($export$120.G + $export$120.B + $export$120.F * MSIE, {
  setTimeout:  wrap$2(global$19.setTimeout),
  setInterval: wrap$2(global$19.setInterval)
});

var $export$121 = _export$2;
var $task   = _task;
$export$121($export$121.G + $export$121.B, {
  setImmediate:   $task.set,
  clearImmediate: $task.clear
});

var $iterators    = es6_array_iterator$2;
var redefine$8      = _redefine$2;
var global$20        = _global$2;
var hide$8          = _hide$2;
var Iterators$7     = _iterators$2;
var wks$3           = _wks$2;
var ITERATOR$5      = wks$3('iterator');
var TO_STRING_TAG$1 = wks$3('toStringTag');
var ArrayValues   = Iterators$7.Array;

for(var collections$1 = ['NodeList', 'DOMTokenList', 'MediaList', 'StyleSheetList', 'CSSRuleList'], i$6 = 0; i$6 < 5; i$6++){
  var NAME$2       = collections$1[i$6]
    , Collection$1 = global$20[NAME$2]
    , proto$4      = Collection$1 && Collection$1.prototype
    , key$1;
  if(proto$4){
    if(!proto$4[ITERATOR$5])hide$8(proto$4, ITERATOR$5, ArrayValues);
    if(!proto$4[TO_STRING_TAG$1])hide$8(proto$4, TO_STRING_TAG$1, NAME$2);
    Iterators$7[NAME$2] = ArrayValues;
    for(key$1 in $iterators)if(!proto$4[key$1])redefine$8(proto$4, key$1, $iterators[key$1], true);
  }
}

var classof$4   = _classof;
var ITERATOR$6  = _wks$2('iterator');
var Iterators$8 = _iterators$2;
var core_isIterable = _core$2.isIterable = function(it){
  var O = Object(it);
  return O[ITERATOR$6] !== undefined
    || '@@iterator' in O
    || Iterators$8.hasOwnProperty(classof$4(O));
};

var ctx$7            = _ctx$2;
var $export$122        = _export$2;
var createDesc$9     = _propertyDesc$2;
var assign$1         = _objectAssign;
var create$9         = _objectCreate$2;
var getPrototypeOf$14 = _objectGpo$2;
var getKeys$8        = _objectKeys$2;
var dP$15             = _objectDp$2;
var keyOf$2          = _keyof$2;
var aFunction$14      = _aFunction$2;
var forOf$6          = _forOf;
var isIterable     = core_isIterable;
var $iterCreate$2    = _iterCreate$2;
var step$3           = _iterStep$2;
var isObject$27       = _isObject$2;
var toIObject$20      = _toIobject$2;
var DESCRIPTORS$5    = _descriptors$2;
var has$17            = _has$2;

// 0 -> Dict.forEach
// 1 -> Dict.map
// 2 -> Dict.filter
// 3 -> Dict.some
// 4 -> Dict.every
// 5 -> Dict.find
// 6 -> Dict.findKey
// 7 -> Dict.mapPairs
var createDictMethod = function(TYPE){
  var IS_MAP   = TYPE == 1
    , IS_EVERY = TYPE == 4;
  return function(object, callbackfn, that /* = undefined */){
    var f      = ctx$7(callbackfn, that, 3)
      , O      = toIObject$20(object)
      , result = IS_MAP || TYPE == 7 || TYPE == 2
          ? new (typeof this == 'function' ? this : Dict) : undefined
      , key, val, res;
    for(key in O)if(has$17(O, key)){
      val = O[key];
      res = f(val, key, object);
      if(TYPE){
        if(IS_MAP)result[key] = res;            // map
        else if(res)switch(TYPE){
          case 2: result[key] = val; break;     // filter
          case 3: return true;                  // some
          case 5: return val;                   // find
          case 6: return key;                   // findKey
          case 7: result[res[0]] = res[1];      // mapPairs
        } else if(IS_EVERY)return false;        // every
      }
    }
    return TYPE == 3 || IS_EVERY ? IS_EVERY : result;
  };
};
var findKey = createDictMethod(6);

var createDictIter = function(kind){
  return function(it){
    return new DictIterator(it, kind);
  };
};
var DictIterator = function(iterated, kind){
  this._t = toIObject$20(iterated); // target
  this._a = getKeys$8(iterated);   // keys
  this._i = 0;                   // next index
  this._k = kind;                // kind
};
$iterCreate$2(DictIterator, 'Dict', function(){
  var that = this
    , O    = that._t
    , keys = that._a
    , kind = that._k
    , key;
  do {
    if(that._i >= keys.length){
      that._t = undefined;
      return step$3(1);
    }
  } while(!has$17(O, key = keys[that._i++]));
  if(kind == 'keys'  )return step$3(0, key);
  if(kind == 'values')return step$3(0, O[key]);
  return step$3(0, [key, O[key]]);
});

function Dict(iterable){
  var dict = create$9(null);
  if(iterable != undefined){
    if(isIterable(iterable)){
      forOf$6(iterable, true, function(key, value){
        dict[key] = value;
      });
    } else assign$1(dict, iterable);
  }
  return dict;
}
Dict.prototype = null;

function reduce$1(object, mapfn, init){
  aFunction$14(mapfn);
  var O      = toIObject$20(object)
    , keys   = getKeys$8(O)
    , length = keys.length
    , i      = 0
    , memo, key;
  if(arguments.length < 3){
    if(!length)throw TypeError('Reduce of empty object with no initial value');
    memo = O[keys[i++]];
  } else memo = Object(init);
  while(length > i)if(has$17(O, key = keys[i++])){
    memo = mapfn(memo, O[key], key, object);
  }
  return memo;
}

function includes$1(object, el){
  return (el == el ? keyOf$2(object, el) : findKey(object, function(it){
    return it != it;
  })) !== undefined;
}

function get$2(object, key){
  if(has$17(object, key))return object[key];
}
function set$2(object, key, value){
  if(DESCRIPTORS$5 && key in Object)dP$15.f(object, key, createDesc$9(0, value));
  else object[key] = value;
  return object;
}

function isDict(it){
  return isObject$27(it) && getPrototypeOf$14(it) === Dict.prototype;
}

$export$122($export$122.G + $export$122.F, {Dict: Dict});

$export$122($export$122.S, 'Dict', {
  keys:     createDictIter('keys'),
  values:   createDictIter('values'),
  entries:  createDictIter('entries'),
  forEach:  createDictMethod(0),
  map:      createDictMethod(1),
  filter:   createDictMethod(2),
  some:     createDictMethod(3),
  every:    createDictMethod(4),
  find:     createDictMethod(5),
  findKey:  findKey,
  mapPairs: createDictMethod(7),
  reduce:   reduce$1,
  keyOf:    keyOf$2,
  includes: includes$1,
  has:      has$17,
  get:      get$2,
  set:      set$2,
  isDict:   isDict
});

var anObject$39 = _anObject$2;
var get$3      = core_getIteratorMethod;
var core_getIterator = _core$2.getIterator = function(it){
  var iterFn = get$3(it);
  if(typeof iterFn != 'function')throw TypeError(it + ' is not iterable!');
  return anObject$39(iterFn.call(it));
};

var global$21  = _global$2;
var core$7    = _core$2;
var $export$123 = _export$2;
var partial$1 = _partial;
// https://esdiscuss.org/topic/promise-returning-delay-function
$export$123($export$123.G + $export$123.F, {
  delay: function delay(time){
    return new (core$7.Promise || global$21.Promise)(function(resolve){
      setTimeout(partial$1.call(resolve, true), time);
    });
  }
});

var path$1    = _path;
var $export$124 = _export$2;

// Placeholder
_core$2._ = path$1._ = path$1._ || {};

$export$124($export$124.P + $export$124.F, 'Function', {part: _partial});

var $export$125 = _export$2;

$export$125($export$125.S + $export$125.F, 'Object', {isObject: _isObject$2});

var $export$126 = _export$2;

$export$126($export$126.S + $export$126.F, 'Object', {classof: _classof});

var dP$16        = _objectDp$2;
var gOPD$10      = _objectGopd$2;
var ownKeys$2   = _ownKeys;
var toIObject$21 = _toIobject$2;

var _objectDefine = function define(target, mixin){
  var keys   = ownKeys$2(toIObject$21(mixin))
    , length = keys.length
    , i = 0, key;
  while(length > i)dP$16.f(target, key = keys[i++], gOPD$10.f(mixin, key));
  return target;
};

var $export$127 = _export$2;
var define$2  = _objectDefine;

$export$127($export$127.S + $export$127.F, 'Object', {define: define$2});

var $export$128 = _export$2;
var define$3  = _objectDefine;
var create$10  = _objectCreate$2;

$export$128($export$128.S + $export$128.F, 'Object', {
  make: function(proto, mixin){
    return define$3(create$10(proto), mixin);
  }
});

_iterDefine$2(Number, 'Number', function(iterated){
  this._l = +iterated;
  this._i = 0;
}, function(){
  var i    = this._i++
    , done = !(i < this._l);
  return {done: done, value: done ? undefined : i};
});

var _replacer = function(regExp, replace){
  var replacer = replace === Object(replace) ? function(part){
    return replace[part];
  } : replace;
  return function(it){
    return String(it).replace(regExp, replacer);
  };
};

// https://github.com/benjamingr/RexExp.escape
var $export$129 = _export$2;
var $re     = _replacer(/[\\^$*+?.()|[\]{}]/g, '\\$&');

$export$129($export$129.S, 'RegExp', {escape: function escape(it){ return $re(it); }});

var $export$130 = _export$2;
var $re$1 = _replacer(/[&<>"']/g, {
  '&': '&amp;',
  '<': '&lt;',
  '>': '&gt;',
  '"': '&quot;',
  "'": '&apos;'
});

$export$130($export$130.P + $export$130.F, 'String', {escapeHTML: function escapeHTML(){ return $re$1(this); }});

var $export$131 = _export$2;
var $re$2 = _replacer(/&(?:amp|lt|gt|quot|apos);/g, {
  '&amp;':  '&',
  '&lt;':   '<',
  '&gt;':   '>',
  '&quot;': '"',
  '&apos;': "'"
});

$export$131($export$131.P + $export$131.F, 'String', {unescapeHTML:  function unescapeHTML(){ return $re$2(this); }});

var fableGlobal = function () {
    var globalObj = typeof window !== "undefined" ? window : typeof global !== "undefined" ? global : typeof self !== "undefined" ? self : null;
    if (typeof globalObj.__FABLE_CORE__ === "undefined") {
        globalObj.__FABLE_CORE__ = {
            types: new Map(),
            symbols: {
                reflection: Symbol("reflection"),
                generics: Symbol("generics")
            }
        };
    }
    return globalObj.__FABLE_CORE__;
}();
function setType(fullName, cons) {
    fableGlobal.types.set(fullName, cons);
}

var FSymbol = fableGlobal.symbols;

var _typeof$1 = typeof Symbol === "function" && typeof Symbol.iterator === "symbol" ? function (obj) { return typeof obj; } : function (obj) { return obj && typeof Symbol === "function" && obj.constructor === Symbol && obj !== Symbol.prototype ? "symbol" : typeof obj; };

var _createClass$1 = function () { function defineProperties(target, props) { for (var i = 0; i < props.length; i++) { var descriptor = props[i]; descriptor.enumerable = descriptor.enumerable || false; descriptor.configurable = true; if ("value" in descriptor) descriptor.writable = true; Object.defineProperty(target, descriptor.key, descriptor); } } return function (Constructor, protoProps, staticProps) { if (protoProps) defineProperties(Constructor.prototype, protoProps); if (staticProps) defineProperties(Constructor, staticProps); return Constructor; }; }();

function _possibleConstructorReturn$1(self, call) { if (!self) { throw new ReferenceError("this hasn't been initialised - super() hasn't been called"); } return call && (typeof call === "object" || typeof call === "function") ? call : self; }

function _inherits$1(subClass, superClass) { if (typeof superClass !== "function" && superClass !== null) { throw new TypeError("Super expression must either be null or a function, not " + typeof superClass); } subClass.prototype = Object.create(superClass && superClass.prototype, { constructor: { value: subClass, enumerable: false, writable: true, configurable: true } }); if (superClass) Object.setPrototypeOf ? Object.setPrototypeOf(subClass, superClass) : subClass.__proto__ = superClass; }

function _classCallCheck$1(instance, Constructor) { if (!(instance instanceof Constructor)) { throw new TypeError("Cannot call a class as a function"); } }

var NonDeclaredType = function () {
    function NonDeclaredType(kind, name, generics) {
        _classCallCheck$1(this, NonDeclaredType);

        this.kind = kind;
        this.name = name;
        this.generics = generics || [];
    }

    _createClass$1(NonDeclaredType, [{
        key: "Equals",
        value: function Equals(other) {
            return this.kind === other.kind && this.name === other.name && equals(this.generics, other.generics);
        }
    }]);

    return NonDeclaredType;
}();

var GenericNonDeclaredType = function (_NonDeclaredType) {
    _inherits$1(GenericNonDeclaredType, _NonDeclaredType);

    function GenericNonDeclaredType(kind, generics) {
        _classCallCheck$1(this, GenericNonDeclaredType);

        return _possibleConstructorReturn$1(this, (GenericNonDeclaredType.__proto__ || Object.getPrototypeOf(GenericNonDeclaredType)).call(this, kind, null, generics));
    }

    _createClass$1(GenericNonDeclaredType, [{
        key: FSymbol.generics,
        value: function value() {
            return this.generics;
        }
    }]);

    return GenericNonDeclaredType;
}(NonDeclaredType);

var Any = new NonDeclaredType("Any");
var Unit = new NonDeclaredType("Unit");





/**
 * Checks if this a function constructor extending another with generic info.
 */
function isGeneric(typ) {
    return typeof typ === "function" && !!typ.prototype[FSymbol.generics];
}
/**
 * Returns the parent if this is a declared generic type or the argument otherwise.
 * Attention: Unlike .NET this doesn't throw an exception if type is not generic.
*/
function getDefinition(typ) {
    return typeof typ === "function" && typ.prototype[FSymbol.generics] ? Object.getPrototypeOf(typ.prototype).constructor : typ;
}
function extendInfo(cons, info) {
    var parent = Object.getPrototypeOf(cons.prototype);
    if (typeof parent[FSymbol.reflection] === "function") {
        var _ret = function () {
            var newInfo = {},
                parentInfo = parent[FSymbol.reflection]();
            Object.getOwnPropertyNames(info).forEach(function (k) {
                var i = info[k];
                if ((typeof i === "undefined" ? "undefined" : _typeof$1(i)) === "object") {
                    newInfo[k] = Array.isArray(i) ? (parentInfo[k] || []).concat(i) : Object.assign(parentInfo[k] || {}, i);
                } else {
                    newInfo[k] = i;
                }
            });
            return {
                v: newInfo
            };
        }();

        if ((typeof _ret === "undefined" ? "undefined" : _typeof$1(_ret)) === "object") return _ret.v;
    }
    return info;
}
function hasInterface(obj, interfaceName) {
    if (typeof obj[FSymbol.reflection] === "function") {
        var interfaces = obj[FSymbol.reflection]().interfaces;
        return Array.isArray(interfaces) && interfaces.indexOf(interfaceName) > -1;
    }
    return false;
}




function equals(x, y) {
    // Optimization if they are referencially equal
    if (x === y) return true;else if (x == null) return y == null;else if (y == null) return false;else if (isGeneric(x) && isGeneric(y)) return getDefinition(x) === getDefinition(y) && equalsRecords(x.prototype[FSymbol.generics](), y.prototype[FSymbol.generics]());else if (Object.getPrototypeOf(x) !== Object.getPrototypeOf(y)) return false;else if (typeof x.Equals === "function") return x.Equals(y);else if (Array.isArray(x)) {
        if (x.length != y.length) return false;
        for (var i = 0; i < x.length; i++) {
            if (!equals(x[i], y[i])) return false;
        }return true;
    } else if (ArrayBuffer.isView(x)) {
        if (x.byteLength !== y.byteLength) return false;
        var dv1 = new DataView(x.buffer),
            dv2 = new DataView(y.buffer);
        for (var _i = 0; _i < x.byteLength; _i++) {
            if (dv1.getUint8(_i) !== dv2.getUint8(_i)) return false;
        }return true;
    } else if (x instanceof Date) return x.getTime() == y.getTime();else return false;
}
function compare(x, y) {
    // Optimization if they are referencially equal
    if (x === y) return 0;
    if (x == null) return y == null ? 0 : -1;else if (y == null) return -1;else if (Object.getPrototypeOf(x) !== Object.getPrototypeOf(y)) return -1;else if (hasInterface(x, "System.IComparable")) return x.CompareTo(y);else if (Array.isArray(x)) {
        if (x.length != y.length) return x.length < y.length ? -1 : 1;
        for (var i = 0, j = 0; i < x.length; i++) {
            if ((j = compare(x[i], y[i])) !== 0) return j;
        }return 0;
    } else if (ArrayBuffer.isView(x)) {
        if (x.byteLength != y.byteLength) return x.byteLength < y.byteLength ? -1 : 1;
        var dv1 = new DataView(x.buffer),
            dv2 = new DataView(y.buffer);
        for (var _i2 = 0, b1 = 0, b2 = 0; _i2 < x.byteLength; _i2++) {
            b1 = dv1.getUint8(_i2), b2 = dv2.getUint8(_i2);
            if (b1 < b2) return -1;
            if (b1 > b2) return 1;
        }
        return 0;
    } else if (x instanceof Date) return compare(x.getTime(), y.getTime());else return x < y ? -1 : 1;
}
function equalsRecords(x, y) {
    // Optimization if they are referencially equal
    if (x === y) {
        return true;
    } else {
        var keys = Object.getOwnPropertyNames(x);
        for (var i = 0; i < keys.length; i++) {
            if (!equals(x[keys[i]], y[keys[i]])) return false;
        }
        return true;
    }
}

var renderer = PIXI.autoDetectRenderer(800, 600);
var gameDiv = document.getElementById("game");
gameDiv.appendChild(renderer.view);
var stage = new PIXI.Container();
var texture = PIXI.Texture.fromImage("./public/assets/bunny.png");
var MyBunny = function (_Sprite) {
  _inherits(MyBunny, _Sprite);

  _createClass(MyBunny, [{
    key: FSymbol.reflection,
    value: function () {
      return extendInfo(MyBunny, {
        type: "Dragging.MyBunny",
        interfaces: [],
        properties: {
          click: "function",
          mouseupoutside: "function",
          tap: "function",
          touchend: "function",
          touchendoutside: "function",
          touchmove: "function",
          touchstart: "function"
        }
      });
    }
  }]);

  function MyBunny(texture_1) {
    _classCallCheck(this, MyBunny);

    var _this = _possibleConstructorReturn(this, (MyBunny.__proto__ || _Object$getPrototypeOf(MyBunny)).call(this, texture_1));

    return _this;
  }

  _createClass(MyBunny, [{
    key: "noop",
    value: function () {
      console.log("click");
    }
  }, {
    key: "mousedown",
    value: function (event) {
      this.data = event.data;
      this.alpha = 0.5;
      this.dragging = true;
    }
  }, {
    key: "mouseup",
    value: function () {
      this.data = null;
      this.alpha = 1;
      this.dragging = false;
    }
  }, {
    key: "mousemove",
    value: function () {
      if (this.dragging) {
        var newPosition = this.data.getLocalPosition(this.parent);
        this.position.x = newPosition.x;
        this.position.y = newPosition.y;
      }
    }
  }, {
    key: "tap",
    get: function () {
      var _this2 = this;

      return function () {
        _this2.noop();
      };
    }
  }, {
    key: "click",
    get: function () {
      var _this3 = this;

      return function () {
        _this3.noop();
      };
    }
  }, {
    key: "touchstart",
    get: function () {
      var _this4 = this;

      return function (arg00) {
        _this4.mousedown(arg00);
      };
    }
  }, {
    key: "touchend",
    get: function () {
      var _this5 = this;

      return function () {
        _this5.mouseup();
      };
    }
  }, {
    key: "touchendoutside",
    get: function () {
      var _this6 = this;

      return function () {
        _this6.mouseup();
      };
    }
  }, {
    key: "mouseupoutside",
    get: function () {
      var _this7 = this;

      return function () {
        _this7.mouseup();
      };
    }
  }, {
    key: "touchmove",
    get: function () {
      var _this8 = this;

      return function () {
        _this8.mousemove();
      };
    }
  }]);

  return MyBunny;
}(PIXI.Sprite);
setType("Dragging.MyBunny", MyBunny);
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

exports.renderer = renderer;
exports.gameDiv = gameDiv;
exports.stage = stage;
exports.texture = texture;
exports.MyBunny = MyBunny;
exports.createBunny = createBunny;
exports.animate = animate;

}((this.dragging = this.dragging || {}),PIXI));

//# sourceMappingURL=bundle.js.map