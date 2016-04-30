var path = require('path');
var webpack = require('webpack');

module.exports = 
{
    context: path.resolve('Scripts'),
    entry: 
    {
        libraries: './libraries.js',
        app: './app.js'
    },
    output: 
    {
        path: path.resolve(__dirname, "dist/"),
        filename: "Scripts/[name].js"
    },
    module: 
    {
        loaders: 
        [
            {
                test: /\.css$/,
                loader: "style!css"
            },
            {
                test: /\.scss$/,
                loader: "style!css!sass"
            },
            {
                test: /\.ttf|eot|svg|woff|woff(2)$/,
                loader: "file?name=fonts/[name].[ext]&limit=10000" 
            }
        ]
    },
    resolve:
    {
        extensions: ['', '.js']
    }
};