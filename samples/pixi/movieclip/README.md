# To build and run the sample

* [node.js](http://nodejs.org) and [F#](http://fsharp.org) must be installed in your system.

* Be sure common dependencies are installed (in `samples` directory, type: `npm install`).

* To compile the F# code to JS, in this directory type: `npm run build`

* To start a local server and open a web with the sample, type: `npm start`

> If you wan to listen for changes and recompile
the F# code, you can use `npm build -- --watch`.
Then you need to run `npm start` in a different
terminal window.