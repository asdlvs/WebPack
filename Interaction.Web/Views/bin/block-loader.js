var fs = require('fs');
module.exports = function (source) {
    this.cacheable(true);
    var js = this.resourcePath,
        jade = js.replace('.js', '.jade').replace(/\\/g, '/'),
        styl = js.replace('.js', '.styl').replace(/\\/g, '/'),
        append = '';

    append += '//' + jade + '\n';
    append += '//' + styl + '\n';

    if (fs.existsSync(jade)) {
        append += 'require("' + jade + '");\n';
    }

    if (fs.existsSync(styl)) {
        append += 'require("' + styl + '");\n';
    }
    return append + source;
};