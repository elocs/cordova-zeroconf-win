
var exec = require('cordova/exec');
var zeroConfWinExport = {};

zeroConfWinExport.browse = function (successCallback, errorCallback) {
    alert("browse");
    exec(successCallback, errorCallback, "Zeroconf_win", "browse", []);
}

module.exports = zeroConfWinExport;