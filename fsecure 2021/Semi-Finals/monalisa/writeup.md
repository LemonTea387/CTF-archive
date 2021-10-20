# Monalisa
What was annoying about this is that there was a partial exe file in the network capture, from what I think
is Microsoft Edge updating itself. Spent too long looking at that. Anyway, what we want to look at is the HTTP
capture stream.

You can use Fiddler,  but it was buggy on my system (Arch Linux, I remember having no problems with it on Windows a
long time ago). I found out that Burp Suite can, with an extension, [pcap-burp](https://github.com/nccgroup/pcap-burp).

It hasn't been updated for a while, but I tried my luck. Also, it didn't have any prebuilt binaries for the latest version of the code (which is already pretty old), so I had to re-compile it with `ant` I believe, and it would only
work with an older version of java, so I had to install `java-8-openjdk` and set my system to use that.

After loading the extension, it still took some work getting it to work, since I believe it is meant for an older
version of Burp Suite, but after fiddling around for a while (I needed to start the proxy server browser, intercept something, and then open it in the Target tab, right click, Extensions, and then select the extension and load the pcapng file) I got it to work. I see a file called client.js, socket.io.js (which I believe is a wrapper around Websockets and falls back to another implementation if the browser doesn't support it), and a stream of data.

index.html was pretty straightforward, just a simple HTML file with a canvas.
```
<!DOCTYPE html>
<html>
   <head>
      <title>monalisa</title>
      <meta charset="utf-8">
      <link rel="stylesheet" href="style.css" />
      <script src="socket.io/socket.io.js"></script>
      <script src="client.js"></script>
   </head>
   <body>
      <canvas id="board"></canvas>
   </body>
</html>
```

client.js was also relatively straightforward
```

document.addEventListener("DOMContentLoaded", function() {
    function x() {
        return Math.floor(100 * Math.random()) + 1
    }
    var n = {
            click: !1,
            move: !1,
            pos: {
                x: 0,
                y: 0
            },
            pos_prev: !1
        },
        e = document.getElementById("board"),
        t = e.getContext("2d"),
        i = window.innerWidth,
        c = window.innerHeight,
        r = io.connect();
    e.width = i, e.height = c, e.onmousedown = function(o) {
            n.click = !0
        }, e.onmouseup = function(o) {
            n.click = !1
        }, e.onmousemove = function(e) {
            n.pos.x = e.clientX / i + x(), n.pos.y = e.clientY / c + x(), n.move = !0
        }, r.on("coor", function(o) {
            var n = o.line,
                x1 = (n[0].x - Math.floor(n[0].x)) * i,
                y1 = (n[0].y - Math.floor(n[0].y)) * c,
                x2 = (n[1].x - Math.floor(n[1].x)) * i,
                y2 = (n[1].y - Math.floor(n[1].y)) * c;
            t.beginPath(), t.moveTo(x1, y1), t.lineTo(x2, y2), t.stroke()
        }),
        function o() {
            n.click && n.move && n.pos_prev && (r.emit("coor", {
                line: [n.pos, n.pos_prev]
            }), n.move = !1), n.pos_prev = {
                x: n.pos.x,
                y: n.pos.y
            }, setTimeout(o, 25)
        }()
});
```

So it looks like a "shared whiteboard".

The interesting request was the websocket stream, which had a variety of binary data, and occasionally this
JSON, which was what was being sent in client.js by r.emit("coor",/*...*/). It would look something like this:-
```
// Headers
HTTP/1.1 101 Switching Protocols
Upgrade: websocket
Connection: Upgrade
Sec-WebSocket-Accept: n5lCvbC0g56Sc0E3gqiyFmEFbM0=
["coor",{"line":[{"x":23.06351665375678,"y":74.46076794657763},{"x":23.06351665375678,"y":74.46076794657763}]}]
// Bunch of binary data
["coor",{"line":[{"x":21.066615027110767,"y":43.46076794657763},{"x":23.06351665375678,"y":74.46076794657763}]}]
//Bunch of data...

```

Me being lazy, instead of parsing it normally, came up with some regex to extract these emitted JSON strings.

Note: Some text editors use \1 some use $1 some use %1.

First extract http://192.168.0.175:8080/socket.io/?EIO=3&transport=websocket&sid=c5uVZLYJkK8l-E3HAAAB

Then, do `(\["coor".+?]}])` for find, replace with `\n\1\n`.

Then, do `^(?!\[).+` for find, replace with ``.
There will still be a couple false positives, but you can remove it manually (run on javascript, it will give errors and the line number at fault).

I then modified client.js to include an array of these values.
```
let pic  = [
    ["coor",{"line":[{"x":23.06351665375678,"y":74.46076794657763},{"x":23.06351665375678,"y":74.46076794657763}]}],
["coor",{"line":[{"x":21.066615027110767,"y":43.46076794657763},{"x":23.06351665375678,"y":74.46076794657763}]}],
["coor",{"line":[{"x":74.06816421378777,"y":39.46076794657763},{"x":21.066615027110767,"y":43.46076794657763}]}],
//...
];
```

And then iterated over each of them, and copied the drawing function from the original client.js.

```
const   i = window.innerWidth,
        e = document.getElementById("board"),
        c = window.innerHeight,
        t = e.getContext("2d");
        e.width = i;
        e.height = c;
pic.forEach(function(arr){
const n = arr[1].line,
                x1 = (n[0].x - Math.floor(n[0].x)) * i,
                y1 = (n[0].y - Math.floor(n[0].y)) * c,
                x2 = (n[1].x - Math.floor(n[1].x)) * i,
                y2 = (n[1].y - Math.floor(n[1].y)) * c;
            t.beginPath(), t.moveTo(x1, y1), t.lineTo(x2, y2), t.stroke()
//          console.log(n);
});
```

You can open index.html yourself and see. Note that I think a bit of the last character's 'r' got cut off.

Flag: `fsQu1t3sk37chycyber`

