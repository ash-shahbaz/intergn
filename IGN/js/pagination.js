/*!
 * toc - jQuery Table of Contents Plugin
 * v0.3.2
 * http://projects.jga.me/toc/
 * copyright Greg Allen 2014
 * MIT License
*/
/*!
 * smooth-scroller - Javascript lib to handle smooth scrolling
 * v0.1.2
 * https://github.com/firstandthird/smooth-scroller
 * copyright First+Third 2014
 * MIT License
*/
//smooth-scroller.js

(function ($) {
    $.fn.smoothScroller = function (options) {
        options = $.extend({}, $.fn.smoothScroller.defaults, options);
        var el = $(this);

        $(options.scrollEl).animate({
            scrollTop: el.offset().top - $(options.scrollEl).offset().top - options.offset
        }, options.speed, options.ease, function () {
            var hash = el.attr('id');

            if (hash.length) {
                if (history.pushState) {
                    history.pushState(null, null, '#' + hash);
                } else {
                    document.location.hash = hash;
                }
            }

            el.trigger('smoothScrollerComplete');
        });

        return this;
    };

    $.fn.smoothScroller.defaults = {
        speed: 400,
        ease: 'swing',
        scrollEl: 'body,html',
        offset: 0
    };

    $('body').on('click', '[data-smoothscroller]', function (e) {
        e.preventDefault();
        var href = $(this).attr('href');

        if (href.indexOf('#') === 0) {
            $(href).smoothScroller();
        }
    });
}(jQuery));

(function ($) {
    var verboseIdCache = {};
    $.fn.toc = function (options) {
        var self = this;
        var opts = $.extend({}, jQuery.fn.toc.defaults, options);

        var container = $(opts.container);
        var headings = $(opts.selectors, container);
        var headingOffsets = [];
        var activeClassName = opts.activeClass;

        var scrollTo = function (e, callback) {
            if (opts.smoothScrolling && typeof opts.smoothScrolling === 'function') {
                e.preventDefault();
                var elScrollTo = $(e.target).attr('href');

                opts.smoothScrolling(elScrollTo, opts, callback);
            }
            $('li', self).removeClass(activeClassName);
            $(e.target).parent().addClass(activeClassName);
        };

        //highlight on scroll
        var timeout;
        var highlightOnScroll = function (e) {
            if (timeout) {
                clearTimeout(timeout);
            }
            timeout = setTimeout(function () {
                var top = $(window).scrollTop(),
                    highlighted, closest = Number.MAX_VALUE, index = 0;

                for (var i = 0, c = headingOffsets.length; i < c; i++) {
                    var currentClosest = Math.abs(headingOffsets[i] - top);
                    if (currentClosest < closest) {
                        index = i;
                        closest = currentClosest;
                    }
                }

                $('li', self).removeClass(activeClassName);
                highlighted = $('li:eq(' + index + ')', self).addClass(activeClassName);
                opts.onHighlight(highlighted);
            }, 50);
        };
        if (opts.highlightOnScroll) {
            $(window).bind('scroll', highlightOnScroll);
            highlightOnScroll();
        }

        return this.each(function () {
            //build TOC
            var el = $(this);
            var ul = $(opts.listType);

            headings.each(function (i, heading) {
                var $h = $(heading);
                headingOffsets.push($h.offset().top - opts.highlightOffset);

                var anchorName = opts.anchorName(i, heading, opts.prefix);

                //add anchor
                if (heading.id !== anchorName) {
                    var anchor = $('<span/>').attr('id', anchorName).insertBefore($h);
                }

                //build TOC item
                var a = $('<a/>')
                    .text(opts.headerText(i, heading, $h))
                    .attr('href', '#' + anchorName)
                    .bind('click', function (e) {
                        $(window).unbind('scroll', highlightOnScroll);
                        scrollTo(e, function () {
                            $(window).bind('scroll', highlightOnScroll);
                        });
                        el.trigger('selected', $(this).attr('href'));
                    });

                var li = $('<li/>')
                    .addClass(opts.itemClass(i, heading, $h, opts.prefix))
                    .append(a);

                ul.append(li);
            });
            el.html(ul);
        });
    };


    jQuery.fn.toc.defaults = {
        container: 'body',
        listType: '<ul/>',
        selectors: 'h1,h2,h3',
        smoothScrolling: function (target, options, callback) {
            $(target).smoothScroller({
                offset: options.scrollToOffset
            }).on('smoothScrollerComplete', function () {
                callback();
            });
        },
        scrollToOffset: 0,
        prefix: 'toc',
        activeClass: 'toc-active',
        onHighlight: function () { },
        highlightOnScroll: true,
        highlightOffset: 100,
        anchorName: function (i, heading, prefix) {
            if (heading.id.length) {
                return heading.id;
            }

            var candidateId = $(heading).text().replace(/[^a-z0-9]/ig, ' ').replace(/\s+/g, '-').toLowerCase();
            if (verboseIdCache[candidateId]) {
                var j = 2;

                while (verboseIdCache[candidateId + j]) {
                    j++;
                }
                candidateId = candidateId + '-' + j;

            }
            verboseIdCache[candidateId] = true;

            return prefix + '-' + candidateId;
        },
        headerText: function (i, heading, $heading) {
            return $heading.text();
        },
        itemClass: function (i, heading, $heading, prefix) {
            return prefix + '-' + $heading[0].tagName.toLowerCase();
        }

    };

})(jQuery);




//----------------------------------------------------------------------------------------------------------------



/* **********************************************
     Begin prism-core.js
********************************************** */

var _self = (typeof window !== 'undefined')
    ? window   // if in browser
    : (
        (typeof WorkerGlobalScope !== 'undefined' && self instanceof WorkerGlobalScope)
            ? self // if in worker
            : {}   // if in node js
    );

/**
 * Prism: Lightweight, robust, elegant syntax highlighting
 * MIT license http://www.opensource.org/licenses/mit-license.php/
 * @author Lea Verou http://lea.verou.me
 */

var Prism = (function () {

    // Private helper vars
    var lang = /\blang(?:uage)?-(\w+)\b/i;
    var uniqueId = 0;

    var _ = _self.Prism = {
        util: {
            encode: function (tokens) {
                if (tokens instanceof Token) {
                    return new Token(tokens.type, _.util.encode(tokens.content), tokens.alias);
                } else if (_.util.type(tokens) === 'Array') {
                    return tokens.map(_.util.encode);
                } else {
                    return tokens.replace(/&/g, '&amp;').replace(/</g, '&lt;').replace(/\u00a0/g, ' ');
                }
            },

            type: function (o) {
                return Object.prototype.toString.call(o).match(/\[object (\w+)\]/)[1];
            },

            objId: function (obj) {
                if (!obj['__id']) {
                    Object.defineProperty(obj, '__id', { value: ++uniqueId });
                }
                return obj['__id'];
            },

            // Deep clone a language definition (e.g. to extend it)
            clone: function (o) {
                var type = _.util.type(o);

                switch (type) {
                    case 'Object':
                        var clone = {};

                        for (var key in o) {
                            if (o.hasOwnProperty(key)) {
                                clone[key] = _.util.clone(o[key]);
                            }
                        }

                        return clone;

                    case 'Array':
                        // Check for existence for IE8
                        return o.map && o.map(function (v) { return _.util.clone(v); });
                }

                return o;
            }
        },

        languages: {
            extend: function (id, redef) {
                var lang = _.util.clone(_.languages[id]);

                for (var key in redef) {
                    lang[key] = redef[key];
                }

                return lang;
            },

            /**
             * Insert a token before another token in a language literal
             * As this needs to recreate the object (we cannot actually insert before keys in object literals),
             * we cannot just provide an object, we need anobject and a key.
             * @param inside The key (or language id) of the parent
             * @param before The key to insert before. If not provided, the function appends instead.
             * @param insert Object with the key/value pairs to insert
             * @param root The object that contains `inside`. If equal to Prism.languages, it can be omitted.
             */
            insertBefore: function (inside, before, insert, root) {
                root = root || _.languages;
                var grammar = root[inside];

                if (arguments.length == 2) {
                    insert = arguments[1];

                    for (var newToken in insert) {
                        if (insert.hasOwnProperty(newToken)) {
                            grammar[newToken] = insert[newToken];
                        }
                    }

                    return grammar;
                }

                var ret = {};

                for (var token in grammar) {

                    if (grammar.hasOwnProperty(token)) {

                        if (token == before) {

                            for (var newToken in insert) {

                                if (insert.hasOwnProperty(newToken)) {
                                    ret[newToken] = insert[newToken];
                                }
                            }
                        }

                        ret[token] = grammar[token];
                    }
                }

                // Update references in other language definitions
                _.languages.DFS(_.languages, function (key, value) {
                    if (value === root[inside] && key != inside) {
                        this[key] = ret;
                    }
                });

                return root[inside] = ret;
            },

            // Traverse a language definition with Depth First Search
            DFS: function (o, callback, type, visited) {
                visited = visited || {};
                for (var i in o) {
                    if (o.hasOwnProperty(i)) {
                        callback.call(o, i, o[i], type || i);

                        if (_.util.type(o[i]) === 'Object' && !visited[_.util.objId(o[i])]) {
                            visited[_.util.objId(o[i])] = true;
                            _.languages.DFS(o[i], callback, null, visited);
                        }
                        else if (_.util.type(o[i]) === 'Array' && !visited[_.util.objId(o[i])]) {
                            visited[_.util.objId(o[i])] = true;
                            _.languages.DFS(o[i], callback, i, visited);
                        }
                    }
                }
            }
        },
        plugins: {},

        highlightAll: function (async, callback) {
            var env = {
                callback: callback,
                selector: 'code[class*="language-"], [class*="language-"] code, code[class*="lang-"], [class*="lang-"] code'
            };

            _.hooks.run("before-highlightall", env);

            var elements = env.elements || document.querySelectorAll(env.selector);

            for (var i = 0, element; element = elements[i++];) {
                _.highlightElement(element, async === true, env.callback);
            }
        },

        highlightElement: function (element, async, callback) {
            // Find language
            var language, grammar, parent = element;

            while (parent && !lang.test(parent.className)) {
                parent = parent.parentNode;
            }

            if (parent) {
                language = (parent.className.match(lang) || [, ''])[1].toLowerCase();
                grammar = _.languages[language];
            }

            // Set language on the element, if not present
            element.className = element.className.replace(lang, '').replace(/\s+/g, ' ') + ' language-' + language;

            // Set language on the parent, for styling
            parent = element.parentNode;

            if (/pre/i.test(parent.nodeName)) {
                parent.className = parent.className.replace(lang, '').replace(/\s+/g, ' ') + ' language-' + language;
            }

            var code = element.textContent;

            var env = {
                element: element,
                language: language,
                grammar: grammar,
                code: code
            };

            _.hooks.run('before-sanity-check', env);

            if (!env.code || !env.grammar) {
                _.hooks.run('complete', env);
                return;
            }

            _.hooks.run('before-highlight', env);

            if (async && _self.Worker) {
                var worker = new Worker(_.filename);

                worker.onmessage = function (evt) {
                    env.highlightedCode = evt.data;

                    _.hooks.run('before-insert', env);

                    env.element.innerHTML = env.highlightedCode;

                    callback && callback.call(env.element);
                    _.hooks.run('after-highlight', env);
                    _.hooks.run('complete', env);
                };

                worker.postMessage(JSON.stringify({
                    language: env.language,
                    code: env.code,
                    immediateClose: true
                }));
            }
            else {
                env.highlightedCode = _.highlight(env.code, env.grammar, env.language);

                _.hooks.run('before-insert', env);

                env.element.innerHTML = env.highlightedCode;

                callback && callback.call(element);

                _.hooks.run('after-highlight', env);
                _.hooks.run('complete', env);
            }
        },

        highlight: function (text, grammar, language) {
            var tokens = _.tokenize(text, grammar);
            return Token.stringify(_.util.encode(tokens), language);
        },

        tokenize: function (text, grammar, language) {
            var Token = _.Token;

            var strarr = [text];

            var rest = grammar.rest;

            if (rest) {
                for (var token in rest) {
                    grammar[token] = rest[token];
                }

                delete grammar.rest;
            }

            tokenloop: for (var token in grammar) {
                if (!grammar.hasOwnProperty(token) || !grammar[token]) {
                    continue;
                }

                var patterns = grammar[token];
                patterns = (_.util.type(patterns) === "Array") ? patterns : [patterns];

                for (var j = 0; j < patterns.length; ++j) {
                    var pattern = patterns[j],
                        inside = pattern.inside,
                        lookbehind = !!pattern.lookbehind,
                        greedy = !!pattern.greedy,
                        lookbehindLength = 0,
                        alias = pattern.alias;

                    pattern = pattern.pattern || pattern;

                    for (var i = 0; i < strarr.length; i++) { // Don’t cache length as it changes during the loop

                        var str = strarr[i];

                        if (strarr.length > text.length) {
                            // Something went terribly wrong, ABORT, ABORT!
                            break tokenloop;
                        }

                        if (str instanceof Token) {
                            continue;
                        }

                        pattern.lastIndex = 0;

                        var match = pattern.exec(str),
                            delNum = 1;

                        // Greedy patterns can override/remove up to two previously matched tokens
                        if (!match && greedy && i != strarr.length - 1) {
                            // Reconstruct the original text using the next two tokens
                            var nextToken = strarr[i + 1].matchedStr || strarr[i + 1],
                                combStr = str + nextToken;

                            if (i < strarr.length - 2) {
                                combStr += strarr[i + 2].matchedStr || strarr[i + 2];
                            }

                            // Try the pattern again on the reconstructed text
                            pattern.lastIndex = 0;
                            match = pattern.exec(combStr);
                            if (!match) {
                                continue;
                            }

                            var from = match.index + (lookbehind ? match[1].length : 0);
                            // To be a valid candidate, the new match has to start inside of str
                            if (from >= str.length) {
                                continue;
                            }
                            var to = match.index + match[0].length,
                                len = str.length + nextToken.length;

                            // Number of tokens to delete and replace with the new match
                            delNum = 3;

                            if (to <= len) {
                                if (strarr[i + 1].greedy) {
                                    continue;
                                }
                                delNum = 2;
                                combStr = combStr.slice(0, len);
                            }
                            str = combStr;
                        }

                        if (!match) {
                            continue;
                        }

                        if (lookbehind) {
                            lookbehindLength = match[1].length;
                        }

                        var from = match.index + lookbehindLength,
                            match = match[0].slice(lookbehindLength),
                            to = from + match.length,
                            before = str.slice(0, from),
                            after = str.slice(to);

                        var args = [i, delNum];

                        if (before) {
                            args.push(before);
                        }

                        var wrapped = new Token(token, inside ? _.tokenize(match, inside) : match, alias, match, greedy);

                        args.push(wrapped);

                        if (after) {
                            args.push(after);
                        }

                        Array.prototype.splice.apply(strarr, args);
                    }
                }
            }

            return strarr;
        },

        hooks: {
            all: {},

            add: function (name, callback) {
                var hooks = _.hooks.all;

                hooks[name] = hooks[name] || [];

                hooks[name].push(callback);
            },

            run: function (name, env) {
                var callbacks = _.hooks.all[name];

                if (!callbacks || !callbacks.length) {
                    return;
                }

                for (var i = 0, callback; callback = callbacks[i++];) {
                    callback(env);
                }
            }
        }
    };

    var Token = _.Token = function (type, content, alias, matchedStr, greedy) {
        this.type = type;
        this.content = content;
        this.alias = alias;
        // Copy of the full string this token was created from
        this.matchedStr = matchedStr || null;
        this.greedy = !!greedy;
    };

    Token.stringify = function (o, language, parent) {
        if (typeof o == 'string') {
            return o;
        }

        if (_.util.type(o) === 'Array') {
            return o.map(function (element) {
                return Token.stringify(element, language, o);
            }).join('');
        }

        var env = {
            type: o.type,
            content: Token.stringify(o.content, language, parent),
            tag: 'span',
            classes: ['token', o.type],
            attributes: {},
            language: language,
            parent: parent
        };

        if (env.type == 'comment') {
            env.attributes['spellcheck'] = 'true';
        }

        if (o.alias) {
            var aliases = _.util.type(o.alias) === 'Array' ? o.alias : [o.alias];
            Array.prototype.push.apply(env.classes, aliases);
        }

        _.hooks.run('wrap', env);

        var attributes = '';

        for (var name in env.attributes) {
            attributes += (attributes ? ' ' : '') + name + '="' + (env.attributes[name] || '') + '"';
        }

        return '<' + env.tag + ' class="' + env.classes.join(' ') + '" ' + attributes + '>' + env.content + '</' + env.tag + '>';

    };

    if (!_self.document) {
        if (!_self.addEventListener) {
            // in Node.js
            return _self.Prism;
        }
        // In worker
        _self.addEventListener('message', function (evt) {
            var message = JSON.parse(evt.data),
                lang = message.language,
                code = message.code,
                immediateClose = message.immediateClose;

            _self.postMessage(_.highlight(code, _.languages[lang], lang));
            if (immediateClose) {
                _self.close();
            }
        }, false);

        return _self.Prism;
    }

    //Get current script and highlight
    var script = document.currentScript || [].slice.call(document.getElementsByTagName("script")).pop();

    if (script) {
        _.filename = script.src;

        if (document.addEventListener && !script.hasAttribute('data-manual')) {
            if (document.readyState !== "loading") {
                requestAnimationFrame(_.highlightAll, 0);
            }
            else {
                document.addEventListener('DOMContentLoaded', _.highlightAll);
            }
        }
    }

    return _self.Prism;

})();

if (typeof module !== 'undefined' && module.exports) {
    module.exports = Prism;
}

// hack for components to work correctly in node.js
if (typeof global !== 'undefined') {
    global.Prism = Prism;
}


/* **********************************************
     Begin prism-markup.js
********************************************** */

Prism.languages.markup = {
    'comment': /<!--[\w\W]*?-->/,
    'prolog': /<\?[\w\W]+?\?>/,
    'doctype': /<!DOCTYPE[\w\W]+?>/,
    'cdata': /<!\[CDATA\[[\w\W]*?]]>/i,
    'tag': {
        pattern: /<\/?(?!\d)[^\s>\/=.$<]+(?:\s+[^\s>\/=]+(?:=(?:("|')(?:\\\1|\\?(?!\1)[\w\W])*\1|[^\s'">=]+))?)*\s*\/?>/i,
        inside: {
            'tag': {
                pattern: /^<\/?[^\s>\/]+/i,
                inside: {
                    'punctuation': /^<\/?/,
                    'namespace': /^[^\s>\/:]+:/
                }
            },
            'attr-value': {
                pattern: /=(?:('|")[\w\W]*?(\1)|[^\s>]+)/i,
                inside: {
                    'punctuation': /[=>"']/
                }
            },
            'punctuation': /\/?>/,
            'attr-name': {
                pattern: /[^\s>\/]+/,
                inside: {
                    'namespace': /^[^\s>\/:]+:/
                }
            }

        }
    },
    'entity': /&#?[\da-z]{1,8};/i
};

// Plugin to make entity title show the real entity, idea by Roman Komarov
Prism.hooks.add('wrap', function (env) {

    if (env.type === 'entity') {
        env.attributes['title'] = env.content.replace(/&amp;/, '&');
    }
});

Prism.languages.xml = Prism.languages.markup;
Prism.languages.html = Prism.languages.markup;
Prism.languages.mathml = Prism.languages.markup;
Prism.languages.svg = Prism.languages.markup;


/* **********************************************
     Begin prism-css.js
********************************************** */

Prism.languages.css = {
    'comment': /\/\*[\w\W]*?\*\//,
    'atrule': {
        pattern: /@[\w-]+?.*?(;|(?=\s*\{))/i,
        inside: {
            'rule': /@[\w-]+/
            // See rest below
        }
    },
    'url': /url\((?:(["'])(\\(?:\r\n|[\w\W])|(?!\1)[^\\\r\n])*\1|.*?)\)/i,
    'selector': /[^\{\}\s][^\{\};]*?(?=\s*\{)/,
    'string': /("|')(\\(?:\r\n|[\w\W])|(?!\1)[^\\\r\n])*\1/,
    'property': /(\b|\B)[\w-]+(?=\s*:)/i,
    'important': /\B!important\b/i,
    'function': /[-a-z0-9]+(?=\()/i,
    'punctuation': /[(){};:]/
};

Prism.languages.css['atrule'].inside.rest = Prism.util.clone(Prism.languages.css);

if (Prism.languages.markup) {
    Prism.languages.insertBefore('markup', 'tag', {
        'style': {
            pattern: /(<style[\w\W]*?>)[\w\W]*?(?=<\/style>)/i,
            lookbehind: true,
            inside: Prism.languages.css,
            alias: 'language-css'
        }
    });

    Prism.languages.insertBefore('inside', 'attr-value', {
        'style-attr': {
            pattern: /\s*style=("|').*?\1/i,
            inside: {
                'attr-name': {
                    pattern: /^\s*style/i,
                    inside: Prism.languages.markup.tag.inside
                },
                'punctuation': /^\s*=\s*['"]|['"]\s*$/,
                'attr-value': {
                    pattern: /.+/i,
                    inside: Prism.languages.css
                }
            },
            alias: 'language-css'
        }
    }, Prism.languages.markup.tag);
}

/* **********************************************
     Begin prism-clike.js
********************************************** */

Prism.languages.clike = {
    'comment': [
        {
            pattern: /(^|[^\\])\/\*[\w\W]*?\*\//,
            lookbehind: true
        },
        {
            pattern: /(^|[^\\:])\/\/.*/,
            lookbehind: true
        }
    ],
    'string': {
        pattern: /(["'])(\\(?:\r\n|[\s\S])|(?!\1)[^\\\r\n])*\1/,
        greedy: true
    },
    'class-name': {
        pattern: /((?:\b(?:class|interface|extends|implements|trait|instanceof|new)\s+)|(?:catch\s+\())[a-z0-9_\.\\]+/i,
        lookbehind: true,
        inside: {
            punctuation: /(\.|\\)/
        }
    },
    'keyword': /\b(if|else|while|do|for|return|in|instanceof|function|new|try|throw|catch|finally|null|break|continue)\b/,
    'boolean': /\b(true|false)\b/,
    'function': /[a-z0-9_]+(?=\()/i,
    'number': /\b-?(?:0x[\da-f]+|\d*\.?\d+(?:e[+-]?\d+)?)\b/i,
    'operator': /--?|\+\+?|!=?=?|<=?|>=?|==?=?|&&?|\|\|?|\?|\*|\/|~|\^|%/,
    'punctuation': /[{}[\];(),.:]/
};


/* **********************************************
     Begin prism-javascript.js
********************************************** */

Prism.languages.javascript = Prism.languages.extend('clike', {
    'keyword': /\b(as|async|await|break|case|catch|class|const|continue|debugger|default|delete|do|else|enum|export|extends|finally|for|from|function|get|if|implements|import|in|instanceof|interface|let|new|null|of|package|private|protected|public|return|set|static|super|switch|this|throw|try|typeof|var|void|while|with|yield)\b/,
    'number': /\b-?(0x[\dA-Fa-f]+|0b[01]+|0o[0-7]+|\d*\.?\d+([Ee][+-]?\d+)?|NaN|Infinity)\b/,
    // Allow for all non-ASCII characters (See http://stackoverflow.com/a/2008444)
    'function': /[_$a-zA-Z\xA0-\uFFFF][_$a-zA-Z0-9\xA0-\uFFFF]*(?=\()/i
});

Prism.languages.insertBefore('javascript', 'keyword', {
    'regex': {
        pattern: /(^|[^/])\/(?!\/)(\[.+?]|\\.|[^/\\\r\n])+\/[gimyu]{0,5}(?=\s*($|[\r\n,.;})]))/,
        lookbehind: true,
        greedy: true
    }
});

Prism.languages.insertBefore('javascript', 'string', {
    'template-string': {
        pattern: /`(?:\\\\|\\?[^\\])*?`/,
        greedy: true,
        inside: {
            'interpolation': {
                pattern: /\$\{[^}]+\}/,
                inside: {
                    'interpolation-punctuation': {
                        pattern: /^\$\{|\}$/,
                        alias: 'punctuation'
                    },
                    rest: Prism.languages.javascript
                }
            },
            'string': /[\s\S]+/
        }
    }
});

if (Prism.languages.markup) {
    Prism.languages.insertBefore('markup', 'tag', {
        'script': {
            pattern: /(<script[\w\W]*?>)[\w\W]*?(?=<\/script>)/i,
            lookbehind: true,
            inside: Prism.languages.javascript,
            alias: 'language-javascript'
        }
    });
}

Prism.languages.js = Prism.languages.javascript;

/* **********************************************
     Begin prism-file-highlight.js
********************************************** */

(function () {
    if (typeof self === 'undefined' || !self.Prism || !self.document || !document.querySelector) {
        return;
    }

    self.Prism.fileHighlight = function () {

        var Extensions = {
            'js': 'javascript',
            'py': 'python',
            'rb': 'ruby',
            'ps1': 'powershell',
            'psm1': 'powershell',
            'sh': 'bash',
            'bat': 'batch',
            'h': 'c',
            'tex': 'latex'
        };

        if (Array.prototype.forEach) { // Check to prevent error in IE8
            Array.prototype.slice.call(document.querySelectorAll('pre[data-src]')).forEach(function (pre) {
                var src = pre.getAttribute('data-src');

                var language, parent = pre;
                var lang = /\blang(?:uage)?-(?!\*)(\w+)\b/i;
                while (parent && !lang.test(parent.className)) {
                    parent = parent.parentNode;
                }

                if (parent) {
                    language = (pre.className.match(lang) || [, ''])[1];
                }

                if (!language) {
                    var extension = (src.match(/\.(\w+)$/) || [, ''])[1];
                    language = Extensions[extension] || extension;
                }

                var code = document.createElement('code');
                code.className = 'language-' + language;

                pre.textContent = '';

                code.textContent = 'Loading…';

                pre.appendChild(code);

                var xhr = new XMLHttpRequest();

                xhr.open('GET', src, true);

                xhr.onreadystatechange = function () {
                    if (xhr.readyState == 4) {

                        if (xhr.status < 400 && xhr.responseText) {
                            code.textContent = xhr.responseText;

                            Prism.highlightElement(code);
                        }
                        else if (xhr.status >= 400) {
                            code.textContent = '✖ Error ' + xhr.status + ' while fetching file: ' + xhr.statusText;
                        }
                        else {
                            code.textContent = '✖ Error: File does not exist or is empty';
                        }
                    }
                };

                xhr.send(null);
            });
        }

    };

    document.addEventListener('DOMContentLoaded', self.Prism.fileHighlight);

})();




//----------------------------------------------------------------------------------------------------

/**
* jQuery asPaginator v0.3.3
* https://github.com/amazingSurge/jquery-asPaginator
*
* Copyright (c) amazingSurge
* Released under the LGPL-3.0 license
*/
(function (global, factory) {
    if (typeof define === 'function' && define.amd) {
        define(['jquery'], factory);
    } else if (typeof exports !== 'undefined') {
        factory(require('jquery'));
    } else {
        var mod = {
            exports: {}
        };
        factory(global.jQuery);
        global.jqueryAsPaginatorEs = mod.exports;
    }
})(this, function (_jquery) {
    'use strict';

    var _jquery2 = _interopRequireDefault(_jquery);

    function _interopRequireDefault(obj) {
        return obj && obj.__esModule
            ? obj
            : {
                default: obj
            };
    }

    function _classCallCheck(instance, Constructor) {
        if (!(instance instanceof Constructor)) {
            throw new TypeError('Cannot call a class as a function');
        }
    }

    var _createClass = (function () {
        function defineProperties(target, props) {
            for (var i = 0; i < props.length; i++) {
                var descriptor = props[i];
                descriptor.enumerable = descriptor.enumerable || false;
                descriptor.configurable = true;
                if ('value' in descriptor) descriptor.writable = true;
                Object.defineProperty(target, descriptor.key, descriptor);
            }
        }

        return function (Constructor, protoProps, staticProps) {
            if (protoProps) defineProperties(Constructor.prototype, protoProps);
            if (staticProps) defineProperties(Constructor, staticProps);
            return Constructor;
        };
    })();

    var DEFAULTS = {
        namespace: 'asPaginator',

        currentPage: 1,
        itemsPerPage: 10,
        visibleNum: 5,
        resizeThrottle: 250,

        disabledClass: 'asPaginator_disable',
        activeClass: 'asPaginator_active',

        tpl: function tpl() {
            return '<ul>{{first}}{{prev}}{{lists}}{{next}}{{last}}</ul>';
        },

        skin: null,
        components: {
            first: true,
            prev: true,
            next: true,
            last: true,
            lists: true
        },

        // callback function
        onInit: null,
        onReady: null,
        onChange: null // function(page) {}
    };

    function throttle(func, wait) {
        var _this = this;

        var _now =
            Date.now ||
            function () {
                return new Date().getTime();
            };

        var timeout = void 0;
        var context = void 0;
        var args = void 0;
        var result = void 0;
        var previous = 0;
        var later = function later() {
            previous = _now();
            timeout = null;
            result = func.apply(context, args);
            if (!timeout) {
                context = args = null;
            }
        };

        return function () {
            for (
                var _len = arguments.length, params = Array(_len), _key = 0;
                _key < _len;
                _key++
            ) {
                params[_key] = arguments[_key];
            }

            /*eslint consistent-this: "off"*/
            var now = _now();
            var remaining = wait - (now - previous);
            context = _this;
            args = params;
            if (remaining <= 0 || remaining > wait) {
                if (timeout) {
                    clearTimeout(timeout);
                    timeout = null;
                }
                previous = now;
                result = func.apply(context, args);
                if (!timeout) {
                    context = args = null;
                }
            } else if (!timeout) {
                timeout = setTimeout(later, remaining);
            }
            return result;
        };
    }

    var NAMESPACE$1 = 'asPaginator';
    var COMPONENTS = {};

    /**
     * Plugin constructor
     **/

    var AsPaginator = (function () {
        function AsPaginator(element, totalItems, options) {
            _classCallCheck(this, AsPaginator);

            this.element = element;
            this.$element = (0, _jquery2.default)(element).empty();

            this.options = _jquery2.default.extend({}, DEFAULTS, options);
            this.namespace = this.options.namespace;

            this.currentPage = this.options.currentPage || 1;
            this.itemsPerPage = this.options.itemsPerPage;
            this.totalItems = totalItems;
            this.totalPages = this.getTotalPages();

            if (this.isOutOfBounds()) {
                this.currentPage = this.totalPages;
            }

            this.initialized = false;
            this.components = COMPONENTS;
            this.$element.addClass(this.namespace);

            if (this.options.skin) {
                this.$element.addClass(this.options.skin);
            }

            this.classes = {
                disabled: this.options.disabledClass,
                active: this.options.activeClass
            };

            this.disabled = false;

            this._trigger('init');
            this.init();
        }

        _createClass(
            AsPaginator,
            [
                {
                    key: 'init',
                    value: function init() {
                        var that = this;

                        that.visible = that.getVisible();

                        _jquery2.default.each(this.options.components, function (
                            key,
                            value
                        ) {
                            if (value === null || value === false) {
                                return false;
                            }

                            that.components[key].init(that);
                        });

                        that.createHtml();
                        that.bindEvents();

                        that.goTo(that.currentPage);

                        that.initialized = true;

                        // responsive
                        if (typeof this.options.visibleNum !== 'number') {
                            (0, _jquery2.default)(window).on(
                                'resize',
                                throttle(function () {
                                    that.resize();
                                }, this.options.resizeTime)
                            );
                        }

                        this._trigger('ready');
                    }
                },
                {
                    key: 'createHtml',
                    value: function createHtml() {
                        var that = this;
                        var contents = void 0;
                        that.contents = that.options.tpl();

                        var length = that.contents.match(/\{\{([^\}]+)\}\}/g).length;
                        var components = void 0;

                        for (var i = 0; i < length; i++) {
                            components = that.contents.match(/\{\{([^\}]+)\}\}/);

                            if (components[1] === 'namespace') {
                                that.contents = that.contents.replace(
                                    components[0],
                                    that.namespace
                                );
                                continue;
                            }

                            if (this.options.components[components[1]]) {
                                contents = that.components[components[1]].opts.tpl.call(that);
                                that.contents = that.contents.replace(components[0], contents);
                            }
                        }

                        that.$element.append((0, _jquery2.default)(that.contents));
                    }
                },
                {
                    key: 'bindEvents',
                    value: function bindEvents() {
                        var that = this;

                        _jquery2.default.each(this.options.components, function (
                            key,
                            value
                        ) {
                            if (value === null || value === false) {
                                return false;
                            }

                            that.components[key].bindEvents(that);
                        });
                    }
                },
                {
                    key: 'unbindEvents',
                    value: function unbindEvents() {
                        var that = this;

                        _jquery2.default.each(this.options.components, function (
                            key,
                            value
                        ) {
                            if (value === null || value === false) {
                                return false;
                            }

                            that.components[key].unbindEvents(that);
                        });
                    }
                },
                {
                    key: 'resize',
                    value: function resize() {
                        var that = this;
                        that._trigger('resize');
                        that.goTo(that.currentPage);
                        that.visible = that.getVisible();

                        _jquery2.default.each(this.options.components, function (
                            key,
                            value
                        ) {
                            if (value === null || value === false) {
                                return false;
                            }

                            if (typeof that.components[key].resize === 'undefined') {
                                return;
                            }

                            that.components[key].resize(that);
                        });
                    }
                },
                {
                    key: 'getVisible',
                    value: function getVisible() {
                        var width = (0, _jquery2.default)('body, html').width();
                        var adjacent = 0;
                        if (typeof this.options.visibleNum !== 'number') {
                            _jquery2.default.each(this.options.visibleNum, function (i, v) {
                                if (width > i) {
                                    adjacent = v;
                                }
                            });
                        } else {
                            adjacent = this.options.visibleNum;
                        }

                        return adjacent;
                    }
                },
                {
                    key: 'calculate',
                    value: function calculate(current, total, visible) {
                        var omitLeft = 1;
                        var omitRight = 1;

                        if (current <= visible + 2) {
                            omitLeft = 0;
                        }

                        if (current + visible + 1 >= total) {
                            omitRight = 0;
                        }

                        return {
                            left: omitLeft,
                            right: omitRight
                        };
                    }
                },
                {
                    key: 'goTo',
                    value: function goTo(page) {
                        page = Math.max(1, Math.min(page, this.totalPages));

                        // if true , dont relaod again
                        if (page === this.currentPage && this.initialized === true) {
                            return false;
                        }

                        this.$element
                            .find('.' + this.classes.disabled)
                            .removeClass(this.classes.disabled);

                        // when add class when go to the first one or the last one
                        if (page === this.totalPages) {
                            this.$element
                                .find('.' + this.namespace + '-next')
                                .addClass(this.classes.disabled);
                            this.$element
                                .find('.' + this.namespace + '-last')
                                .addClass(this.classes.disabled);
                        }

                        if (page === 1) {
                            this.$element
                                .find('.' + this.namespace + '-prev')
                                .addClass(this.classes.disabled);
                            this.$element
                                .find('.' + this.namespace + '-first')
                                .addClass(this.classes.disabled);
                        }

                        // here change current page first, and then trigger 'change' event
                        this.currentPage = page;

                        if (this.initialized) {
                            this._trigger('change', page);
                        }
                    }
                },
                {
                    key: 'prev',
                    value: function prev() {
                        if (this.hasPreviousPage()) {
                            this.goTo(this.getPreviousPage());
                            return true;
                        }

                        return false;
                    }
                },
                {
                    key: 'next',
                    value: function next() {
                        if (this.hasNextPage()) {
                            this.goTo(this.getNextPage());
                            return true;
                        }

                        return false;
                    }
                },
                {
                    key: 'goFirst',
                    value: function goFirst() {
                        return this.goTo(1);
                    }
                },
                {
                    key: 'goLast',
                    value: function goLast() {
                        return this.goTo(this.totalPages);
                    }
                },
                {
                    key: 'update',
                    value: function update(data, value) {
                        var changes = {};

                        if (typeof data === 'string') {
                            changes[data] = value;
                        } else {
                            changes = data;
                        }

                        for (var option in changes) {
                            if (Object.hasOwnProperty.call(changes, option)) {
                                switch (option) {
                                    case 'totalItems':
                                        this.totalItems = changes[option];
                                        break;
                                    case 'itemsPerPage':
                                        this.itemsPerPage = changes[option];
                                        break;
                                    case 'currentPage':
                                        this.currentPage = changes[option];
                                        break;
                                    default:
                                        break;
                                }
                            }
                        }

                        this.totalPages = this.totalPages();
                        // wait to do
                    }
                },
                {
                    key: 'isOutOfBounds',
                    value: function isOutOfBounds() {
                        return this.currentPage > this.totalPages;
                    }
                },
                {
                    key: 'getItemsPerPage',
                    value: function getItemsPerPage() {
                        return this.itemsPerPage;
                    }
                },
                {
                    key: 'getTotalItems',
                    value: function getTotalItems() {
                        return this.totalItems;
                    }
                },
                {
                    key: 'getTotalPages',
                    value: function getTotalPages() {
                        this.totalPages = Math.ceil(this.totalItems / this.itemsPerPage);
                        this.lastPage = this.totalPages;
                        return this.totalPages;
                    }
                },
                {
                    key: 'getCurrentPage',
                    value: function getCurrentPage() {
                        return this.currentPage;
                    }
                },
                {
                    key: 'hasPreviousPage',
                    value: function hasPreviousPage() {
                        return this.currentPage > 1;
                    }
                },
                {
                    key: 'getPreviousPage',
                    value: function getPreviousPage() {
                        if (this.hasPreviousPage()) {
                            return this.currentPage - 1;
                        }
                        return false;
                    }
                },
                {
                    key: 'hasNextPage',
                    value: function hasNextPage() {
                        return this.currentPage < this.totalPages;
                    }
                },
                {
                    key: 'getNextPage',
                    value: function getNextPage() {
                        if (this.hasNextPage()) {
                            return this.currentPage + 1;
                        }
                        return false;
                    }
                },
                {
                    key: 'enable',
                    value: function enable() {
                        if (this.disabled) {
                            this.disabled = false;

                            this.$element.removeClass(this.classes.disabled);

                            this.bindEvents();
                        }

                        this._trigger('enable');
                    }
                },
                {
                    key: 'disable',
                    value: function disable() {
                        if (this.disabled !== true) {
                            this.disabled = true;

                            this.$element.addClass(this.classes.disabled);

                            this.unbindEvents();
                        }

                        this._trigger('disable');
                    }
                },
                {
                    key: 'destroy',
                    value: function destroy() {
                        this.$element.removeClass(this.classes.disabled);
                        this.unbindEvents();
                        this.$element.data(NAMESPACE$1, null);
                        this._trigger('destroy');
                    }
                },
                {
                    key: '_trigger',
                    value: function _trigger(eventType) {
                        for (
                            var _len2 = arguments.length,
                            params = Array(_len2 > 1 ? _len2 - 1 : 0),
                            _key2 = 1;
                            _key2 < _len2;
                            _key2++
                        ) {
                            params[_key2 - 1] = arguments[_key2];
                        }

                        var data = [this].concat(params);

                        // event
                        this.$element.trigger(NAMESPACE$1 + '::' + eventType, data);

                        // callback
                        eventType = eventType.replace(/\b\w+\b/g, function (word) {
                            return word.substring(0, 1).toUpperCase() + word.substring(1);
                        });
                        var onFunction = 'on' + eventType;

                        if (typeof this.options[onFunction] === 'function') {
                            this.options[onFunction].apply(this, params);
                        }
                    }
                },
                {
                    key: 'eventName',
                    value: function eventName(events) {
                        if (typeof events !== 'string' || events === '') {
                            return '.' + this.options.namespace;
                        }
                        events = events.split(' ');

                        var length = events.length;
                        for (var i = 0; i < length; i++) {
                            events[i] = events[i] + '.' + this.options.namespace;
                        }
                        return events.join(' ');
                    }
                }
            ],
            [
                {
                    key: 'registerComponent',
                    value: function registerComponent(name, method) {
                        COMPONENTS[name] = method;
                    }
                },
                {
                    key: 'setDefaults',
                    value: function setDefaults(options) {
                        _jquery2.default.extend(
                            DEFAULTS,
                            _jquery2.default.isPlainObject(options) && options
                        );
                    }
                }
            ]
        );

        return AsPaginator;
    })();

    AsPaginator.registerComponent('prev', {
        defaults: {
            tpl: function tpl() {
                return '<li class="' + this.namespace + '-prev"><a>Prev</a></li>';
            }
        },

        init: function init(instance) {
            var opts = _jquery2.default.extend(
                {},
                this.defaults,
                instance.options.components.prev
            );

            this.opts = opts;
        },
        bindEvents: function bindEvents(instance) {
            this.$prev = instance.$element.find('.' + instance.namespace + '-prev');
            this.$prev.on(
                'click.asPaginator',
                _jquery2.default.proxy(instance.prev, instance)
            );
        },
        unbindEvents: function unbindEvents() {
            this.$prev.off('click.asPaginator');
        }
    });

    AsPaginator.registerComponent('next', {
        defaults: {
            tpl: function tpl() {
                return '<li class="' + this.namespace + '-next"><a>Next</a></li>';
            }
        },

        init: function init(instance) {
            var opts = _jquery2.default.extend(
                {},
                this.defaults,
                instance.options.components.next
            );

            this.opts = opts;
        },
        bindEvents: function bindEvents(instance) {
            this.$next = instance.$element.find('.' + instance.namespace + '-next');
            this.$next.on(
                'click.asPaginator',
                _jquery2.default.proxy(instance.next, instance)
            );
        },
        unbindEvents: function unbindEvents() {
            this.$next.off('click.asPaginator');
        }
    });

    AsPaginator.registerComponent('first', {
        defaults: {
            tpl: function tpl() {
                return '<li class="' + this.namespace + '-first"><a>First</a></li>';
            }
        },

        init: function init(instance) {
            var opts = _jquery2.default.extend(
                {},
                this.defaults,
                instance.options.components.first
            );

            this.opts = opts;
        },
        bindEvents: function bindEvents(instance) {
            this.$first = instance.$element.find('.' + instance.namespace + '-first');
            this.$first.on(
                'click.asPaginator',
                _jquery2.default.proxy(instance.goFirst, instance)
            );
        },
        unbindEvents: function unbindEvents() {
            this.$first.off('click.asPaginator');
        }
    });

    AsPaginator.registerComponent('last', {
        defaults: {
            tpl: function tpl() {
                return '<li class="' + this.namespace + '-last"><a>Last</a></li>';
            }
        },

        init: function init(instance) {
            var opts = _jquery2.default.extend(
                {},
                this.defaults,
                instance.options.components.last
            );

            this.opts = opts;
        },
        bindEvents: function bindEvents(instance) {
            this.$last = instance.$element.find('.' + instance.namespace + '-last');
            this.$last.on(
                'click.asPaginator',
                _jquery2.default.proxy(instance.goLast, instance)
            );
        },
        unbindEvents: function unbindEvents() {
            this.$last.off('click.asPaginator');
        }
    });

    AsPaginator.registerComponent('lists', {
        defaults: {
            tpl: function tpl() {
                var lists = '';
                var remainder =
                    this.currentPage >= this.visible
                        ? this.currentPage % this.visible
                        : this.currentPage;
                remainder = remainder === 0 ? this.visible : remainder;
                for (var k = 1; k < remainder; k++) {
                    lists +=
                        '<li class="' +
                        this.namespace +
                        '-items" data-value="' +
                        (this.currentPage - remainder + k) +
                        '"><a href="#">' +
                        (this.currentPage - remainder + k) +
                        '</a></li>';
                }
                lists +=
                    '<li class="' +
                    this.namespace +
                    '-items ' +
                    this.classes.active +
                    '" data-value="' +
                    this.currentPage +
                    '"><a href="#">' +
                    this.currentPage +
                    '</a></li>';
                for (
                    var i = this.currentPage + 1,
                    limit =
                        i + this.visible - remainder - 1 > this.totalPages
                            ? this.totalPages
                            : i + this.visible - remainder - 1;
                    i <= limit;
                    i++
                ) {
                    lists +=
                        '<li class="' +
                        this.namespace +
                        '-items" data-value="' +
                        i +
                        '"><a href="#">' +
                        i +
                        '</a></li>';
                }

                return lists;
            }
        },

        init: function init(instance) {
            var opts = _jquery2.default.extend(
                {},
                this.defaults,
                instance.options.components.lists
            );

            this.opts = opts;

            instance.itemsTpl = this.opts.tpl.call(instance);
        },
        bindEvents: function bindEvents(instance) {
            var that = this;
            this.$items = instance.$element.find('.' + instance.namespace + '-items');
            instance.$element.on('click', this.$items, function (e) {
                var page =
                    (0, _jquery2.default)(e.target)
                        .parent()
                        .data('value') || (0, _jquery2.default)(e.target).data('value');

                if (page === undefined) {
                    //console.log("wrong page value or prev&&next");
                    return false;
                }

                if (page === '') {
                    return false;
                }

                instance.goTo(page);
            });

            that.render(instance);
            instance.$element.on('asPaginator::change', function () {
                that.render(instance);
            });
        },
        unbindEvents: function unbindEvents(instance) {
            instance.$element.off('click', this.$items);
        },
        resize: function resize(instance) {
            this.render(instance);
        },
        render: function render(instance) {
            var current = instance.currentPage;
            var overflow = void 0;
            var that = this;

            var array = this.$items.removeClass(instance.classes.active);
            _jquery2.default.each(array, function (i, v) {
                if ((0, _jquery2.default)(v).data('value') === current) {
                    (0, _jquery2.default)(v).addClass(instance.classes.active);
                    overflow = false;
                    return false;
                }
            });

            if (overflow === false && this.visibleBefore === instance.visible) {
                return;
            }

            this.visibleBefore = instance.visible;

            _jquery2.default.each(array, function (i, v) {
                if (i === 0) {
                    (0, _jquery2.default)(v).replaceWith(that.opts.tpl.call(instance));
                } else {
                    (0, _jquery2.default)(v).remove();
                }
            });
            this.$items = instance.$element.find('.' + instance.namespace + '-items');
        }
    });

    AsPaginator.registerComponent('goTo', {
        defaults: {
            tpl: function tpl() {
                return (
                    '<div class="' +
                    this.namespace +
                    '-goTo"><input type="text" class="' +
                    this.namespace +
                    '-input" /><button type="submit" class="' +
                    this.namespace +
                    '-submit">Go</button></div>'
                );
            }
        },

        init: function init(instance) {
            var opts = _jquery2.default.extend(
                {},
                this.defaults,
                instance.options.components.goTo
            );

            this.opts = opts;
        },
        bindEvents: function bindEvents(instance) {
            var that = this;
            that.$goTo = instance.$element.find('.' + instance.namespace + '-goTo');
            that.$input = that.$goTo.find('.' + instance.namespace + '-input');
            that.$button = that.$goTo.find('.' + instance.namespace + '-submit');

            that.$button.on('click', function () {
                var page = parseInt(that.$input.val(), 10);
                page = page > 0 ? page : instance.currentPage;
                instance.goTo(page);
            });
        },
        unbindEvents: function unbindEvents() {
            this.$button.off('click');
        }
    });

    AsPaginator.registerComponent('altLists', {
        defaults: {
            tpl: function tpl() {
                var lists = '';
                var max = this.totalPages;
                var current = this.currentPage;
                var omit = this.calculate(current, max, this.visible);
                var that = this;
                var i = void 0;
                var item = function item(i, classes) {
                    if (classes === 'active') {
                        return (
                            '<li class="' +
                            that.namespace +
                            '-items ' +
                            that.classes.active +
                            '" data-value="' +
                            i +
                            '"><a href="#">' +
                            i +
                            '</a></li>'
                        );
                    } else if (classes === 'omit') {
                        return (
                            '<li class="' +
                            that.namespace +
                            '-items ' +
                            that.namespace +
                            '_ellipsis" data-value="ellipsis"><a href="#">...</a></li>'
                        );
                    } else {
                        return (
                            '<li class="' +
                            that.namespace +
                            '-items" data-value="' +
                            i +
                            '"><a href="#">' +
                            i +
                            '</a></li>'
                        );
                    }
                };

                if (omit.left === 0) {
                    for (i = 1; i <= current - 1; i++) {
                        lists += item(i);
                    }
                    lists += item(current, 'active');
                } else {
                    for (i = 1; i <= 2; i++) {
                        lists += item(i);
                    }

                    lists += item(current, 'omit');

                    for (i = current - this.visible + 1; i <= current - 1; i++) {
                        lists += item(i);
                    }

                    lists += item(current, 'active');
                }

                if (omit.right === 0) {
                    for (i = current + 1; i <= max; i++) {
                        lists += item(i);
                    }
                } else {
                    for (i = current + 1; i <= current + this.visible - 1; i++) {
                        lists += item(i);
                    }

                    lists += item(current, 'omit');

                    for (i = max - 1; i <= max; i++) {
                        lists += item(i);
                    }
                }

                return lists;
            }
        },

        init: function init(instance) {
            var opts = _jquery2.default.extend(
                {},
                this.defaults,
                instance.options.components.altLists
            );

            this.opts = opts;
        },
        bindEvents: function bindEvents(instance) {
            var that = this;
            this.$items = instance.$element.find('.' + instance.namespace + '-items');
            instance.$element.on('click', this.$items, function (e) {
                var page =
                    (0, _jquery2.default)(e.target)
                        .parent()
                        .data('value') || (0, _jquery2.default)(e.target).data('value');

                if (page === undefined) {
                    //console.log("wrong page value or prev&&next");
                    return false;
                }

                if (page === 'ellipsis') {
                    return false;
                }

                if (page === '') {
                    return false;
                }

                instance.goTo(page);
            });

            that.render(instance);
            instance.$element.on('asPaginator::change', function () {
                that.render(instance);
            });
        },
        unbindEvents: function unbindEvents(instance) {
            instance.$wrap.off('click', this.$items);
        },
        resize: function resize(instance) {
            this.render(instance);
        },
        render: function render(instance) {
            var that = this;
            var array = this.$items.removeClass(instance.classes.active);
            _jquery2.default.each(array, function (i, v) {
                if (i === 0) {
                    (0, _jquery2.default)(v).replaceWith(that.opts.tpl.call(instance));
                } else {
                    (0, _jquery2.default)(v).remove();
                }
            });
            this.$items = instance.$element.find('.' + instance.namespace + '-items');
        }
    });

    AsPaginator.registerComponent('info', {
        defaults: {
            tpl: function tpl() {
                return (
                    '<li class="' +
                    this.namespace +
                    '-info"><a href="javascript:void(0);"><span class="' +
                    this.namespace +
                    '-current"></span> / <span class="' +
                    this.namespace +
                    '-total"></span></a></li>'
                );
            }
        },

        init: function init(instance) {
            var opts = _jquery2.default.extend(
                {},
                this.defaults,
                instance.options.components.info
            );

            this.opts = opts;
        },
        bindEvents: function bindEvents(instance) {
            var $info = instance.$element.find('.' + instance.namespace + '-info');
            var $current = $info.find('.' + instance.namespace + '-current');
            $info.find('.' + instance.namespace + '-total').text(instance.totalPages);

            $current.text(instance.currentPage);
            instance.$element.on('asPaginator::change', function () {
                $current.text(instance.currentPage);
            });
        }
    });

    var info = {
        version: '0.3.3'
    };

    var NAMESPACE = 'asPaginator';
    var OtherAsPaginator = _jquery2.default.fn.asPaginator;

    var jQueryAsPaginator = function jQueryAsPaginator(totalItems) {
        for (
            var _len3 = arguments.length,
            args = Array(_len3 > 1 ? _len3 - 1 : 0),
            _key3 = 1;
            _key3 < _len3;
            _key3++
        ) {
            args[_key3 - 1] = arguments[_key3];
        }

        if (
            !_jquery2.default.isNumeric(totalItems) &&
            typeof totalItems === 'string'
        ) {
            var method = totalItems;

            if (/^_/.test(method)) {
                return false;
            } else if (/^(get)/.test(method)) {
                var instance = this.first().data(NAMESPACE);
                if (instance && typeof instance[method] === 'function') {
                    return instance[method].apply(instance, args);
                }
            } else {
                return this.each(function () {
                    var instance = _jquery2.default.data(this, NAMESPACE);
                    if (instance && typeof instance[method] === 'function') {
                        instance[method].apply(instance, args);
                    }
                });
            }
        }

        return this.each(function () {
            if (!(0, _jquery2.default)(this).data(NAMESPACE)) {
                (0, _jquery2.default)(this).data(
                    NAMESPACE,
                    new (Function.prototype.bind.apply(
                        AsPaginator,
                        [null].concat([this, totalItems], args)
                    ))()
                );
            }
        });
    };

    _jquery2.default.fn.asPaginator = jQueryAsPaginator;

    _jquery2.default.asPaginator = _jquery2.default.extend(
        {
            registerComponent: AsPaginator.registerComponent,
            setDefaults: AsPaginator.setDefaults,
            noConflict: function noConflict() {
                _jquery2.default.fn.asPaginator = OtherAsPaginator;
                return jQueryAsPaginator;
            }
        },
        info
    );
});



//----------------------------------------------------------------------------------------------------------------