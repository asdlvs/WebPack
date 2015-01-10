
module.exports = {
    entry: [".\\Blocks\\Dashboard\\Dashboard.js", ".\\Blocks\\Contacts\\Contacts.js"],
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
