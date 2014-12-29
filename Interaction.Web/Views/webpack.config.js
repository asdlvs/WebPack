var glob = require("glob");
module.exports = {
    entry: glob.sync(".\\Blocks\\Dashboard\\Dashboard.js"),
    output: {
        path: "..\\Scripts\\",
        filename: "app.js"
    },
    module: {
        loaders: [
            { test: /\.styl$/, loader: 'style!css!stylus' },
            { test: /\.jade$/, loader: 'ng-cache!jade-html' },
            { test: /\.js$/,loader: __dirname + '\\bin\\block-loader.js' }
        ]
    }
};
