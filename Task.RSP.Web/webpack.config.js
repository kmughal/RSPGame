var HtmlWebpackPlugin = require('html-webpack-plugin');
var CleanWebpackPlugin = require('clean-webpack-plugin');
var CopyWebpackPlugin = require('copy-webpack-plugin');

var path = require('path');

var rootPath = __dirname;

module.exports = {
    devtool: 'source-map',
    context: path.join(rootPath, 'src'),
    entry: {
        index: './index.js',
    },
    output: {
        path: path.join(rootPath, 'dist'),
        filename: '[name].[hash].min.js'
    },
    resolve: {
        extensions: ['', '.js', '.css', '.scss']
    },
    devServer: {
        contentBase: path.join(rootPath, 'src'),
        hot: true
    },
    module: {
        loaders: [
            {
                test: /\.css$/,
                loaders: ["style-loader", "css-loader"]
            },
            {
                test: /\.scss$/,
                loaders: ["style-loader", "css-loader", 'sass-loader']
            }
        ]
    },
    plugins: [
        new HtmlWebpackPlugin({
            title: 'Rock,Paper,Scissors',
            filename: 'index.html',
            template: 'index.html',
            appMountId: 'app',
            controllerName : 'gameCoreController',
            chunks: ['index']
        }),
        new CleanWebpackPlugin(['dist'], {
          root: rootPath,
          verbose: true,
          dry: false
        }),
        new CopyWebpackPlugin([
            { from: 'index.html' }
        ])
    ]
};