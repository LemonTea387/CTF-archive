# Regexec

My teammate found the following code somewhere in the registry.
```
var env = new ActiveXObject("WScript.Shell").Environment("Process");
var name = env("COMPUTERNAME");
var chars = new Array(
  47,
  54,
  16,
  33,
  126,
  2,
  61,
  12,
  57,
  61,
  38,
  4,
  27,
  32,
  48,
  120,
  61,
  0,
  59,
  28,
  52,
  48,
  44,
  82,
  59
);
var flag = "";
for (i in chars) {
  flag += String.fromCharCode(name.charCodeAt(i % name.length) ^ chars[i]);
}
alert(flag);
```

The COMPUTERNAME wasn't in the registry unfortunately.

Okay, that seems rather suspicious. It seems to be just a XOR cipher once again, so let's xor with the values we know of (It starts with `fs` and ends with `cyber` or `cyberx`).
At the time, I remembered the `fs` trick, but completely forgot about it ending with a known value and was wondering how to get it, luckily my teammate realised it.

Look at the solver.py file to see how my teammate figured out the COMPUTERNAME (which is 'IEWIN7' btw). Then it's simple to decrypt it.

Flag: `fsGh05tInth3Reg1s7rYcyber`
Side-Note: Author is a fan of Ghost in the Shell? Flag seems to be a reference to that.
