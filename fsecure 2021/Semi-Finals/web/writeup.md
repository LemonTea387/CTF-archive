# web

Probably one of the most straightforward reversing challenges.
One of the checks is just ROT13. The others should be straightforward to figure out.
You don't need to reverse the giant function at the start, just aa bb and cc.

```
// var url_string = window["location"]["href"],
//   url = new URL(url_string),
//   p = url["searchParams"]["get"]("p"); // https://.../index.html?p=FLAG_HERE
var p = '';
function ebg13(_0x394e9e) {
  var _0x1bad7e = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz",
    _0xe7ba36 = "NOPQRSTUVWXYZABCDEFGHIJKLMnopqrstuvwxyzabcdefghijklm",
    _0x178280 = (_0x4299b3) => _0x1bad7e["indexOf"](_0x4299b3),
    _0x4e7551 = (_0x228b79) =>
      _0x178280(_0x228b79) > -0x1 ? _0xe7ba36[_0x178280(_0x228b79)] : _0x228b79;
  return _0x394e9e["split"]("")["map"](_0x4e7551)["join"]("");
}
var ansdweasd = function ansdweasd(_0x235976) {
  function _0x3a6f22(_0x19cf15, _0x3e2829) {
    return (_0x19cf15 >>> _0x3e2829) | (_0x19cf15 << (0x20 - _0x3e2829));
  }
  var _0x8e84d4 = Math["pow"],
    _0x12d7c4 = _0x8e84d4(0x2, 0x20),
    _0x1c3ba2 = "length",
    _0x5c74d0,
    _0x59c65e,
    _0x1ee073 = "",
    _0x8c6859 = [],
    _0x57e3b2 = _0x235976[_0x1c3ba2] * 0x8,
    _0x3ab8f9 = (ansdweasd["h"] = ansdweasd["h"] || []),
    _0x4c457f = (ansdweasd["k"] = ansdweasd["k"] || []),
    _0x333e1d = _0x4c457f[_0x1c3ba2],
    _0x230663 = {};
  for (var _0x519ae7 = 0x2; _0x333e1d < 0x40; _0x519ae7++) {
    if (!_0x230663[_0x519ae7]) {
      for (_0x5c74d0 = 0x0; _0x5c74d0 < 0x139; _0x5c74d0 += _0x519ae7) {
        _0x230663[_0x5c74d0] = _0x519ae7;
      }
      (_0x3ab8f9[_0x333e1d] = (_0x8e84d4(_0x519ae7, 0.5) * _0x12d7c4) | 0x0),
        (_0x4c457f[_0x333e1d++] =
          (_0x8e84d4(_0x519ae7, 0x1 / 0x3) * _0x12d7c4) | 0x0);
    }
  }
  _0x235976 += "\u0080";
  while ((_0x235976[_0x1c3ba2] % 0x40) - 0x38) _0x235976 += "\x00";
  for (_0x5c74d0 = 0x0; _0x5c74d0 < _0x235976[_0x1c3ba2]; _0x5c74d0++) {
    _0x59c65e = _0x235976["charCodeAt"](_0x5c74d0);
    if (_0x59c65e >> 0x8) return;
    _0x8c6859[_0x5c74d0 >> 0x2] |=
      _0x59c65e << (((0x3 - _0x5c74d0) % 0x4) * 0x8);
  }
  (_0x8c6859[_0x8c6859[_0x1c3ba2]] = (_0x57e3b2 / _0x12d7c4) | 0x0),
    (_0x8c6859[_0x8c6859[_0x1c3ba2]] = _0x57e3b2);
  for (_0x59c65e = 0x0; _0x59c65e < _0x8c6859[_0x1c3ba2]; ) {
    var _0xce3948 = _0x8c6859["slice"](_0x59c65e, (_0x59c65e += 0x10)),
      _0x5dd751 = _0x3ab8f9;
    _0x3ab8f9 = _0x3ab8f9["slice"](0x0, 0x8);
    for (_0x5c74d0 = 0x0; _0x5c74d0 < 0x40; _0x5c74d0++) {
      var _0x2c8156 = _0x5c74d0 + _0x59c65e,
        _0x1894a7 = _0xce3948[_0x5c74d0 - 0xf],
        _0x23bd02 = _0xce3948[_0x5c74d0 - 0x2],
        _0x90c875 = _0x3ab8f9[0x0],
        _0x5ef357 = _0x3ab8f9[0x4],
        _0x203948 =
          _0x3ab8f9[0x7] +
          (_0x3a6f22(_0x5ef357, 0x6) ^
            _0x3a6f22(_0x5ef357, 0xb) ^
            _0x3a6f22(_0x5ef357, 0x19)) +
          ((_0x5ef357 & _0x3ab8f9[0x5]) ^ (~_0x5ef357 & _0x3ab8f9[0x6])) +
          _0x4c457f[_0x5c74d0] +
          (_0xce3948[_0x5c74d0] =
            _0x5c74d0 < 0x10
              ? _0xce3948[_0x5c74d0]
              : (_0xce3948[_0x5c74d0 - 0x10] +
                  (_0x3a6f22(_0x1894a7, 0x7) ^
                    _0x3a6f22(_0x1894a7, 0x12) ^
                    (_0x1894a7 >>> 0x3)) +
                  _0xce3948[_0x5c74d0 - 0x7] +
                  (_0x3a6f22(_0x23bd02, 0x11) ^
                    _0x3a6f22(_0x23bd02, 0x13) ^
                    (_0x23bd02 >>> 0xa))) |
                0x0),
        _0x4cbb13 =
          (_0x3a6f22(_0x90c875, 0x2) ^
            _0x3a6f22(_0x90c875, 0xd) ^
            _0x3a6f22(_0x90c875, 0x16)) +
          ((_0x90c875 & _0x3ab8f9[0x1]) ^
            (_0x90c875 & _0x3ab8f9[0x2]) ^
            (_0x3ab8f9[0x1] & _0x3ab8f9[0x2]));
      (_0x3ab8f9 = [(_0x203948 + _0x4cbb13) | 0x0]["concat"](_0x3ab8f9)),
        (_0x3ab8f9[0x4] = (_0x3ab8f9[0x4] + _0x203948) | 0x0);
    }
    for (_0x5c74d0 = 0x0; _0x5c74d0 < 0x8; _0x5c74d0++) {
      _0x3ab8f9[_0x5c74d0] =
        (_0x3ab8f9[_0x5c74d0] + _0x5dd751[_0x5c74d0]) | 0x0;
    }
  }
  for (_0x5c74d0 = 0x0; _0x5c74d0 < 0x8; _0x5c74d0++) {
    for (_0x59c65e = 0x3; _0x59c65e + 0x1; _0x59c65e--) {
      var _0x143863 = (_0x3ab8f9[_0x5c74d0] >> (_0x59c65e * 0x8)) & 0xff;
      _0x1ee073 += (_0x143863 < 0x10 ? 0x0 : "") + _0x143863["toString"](0x10);
    }
  }
  return _0x1ee073;
};


// let hashes = [
//     "dce7cce055566bed799f788cd0048e209a27a473c0f48b956fa1f1780e80d2c1",
//     "635ca73d00d4f28b5f573b16eea56e9e4579d77e561c32aa68189d9769fa1753",
//     "a4d0ef23161b5b7c6a8d5b287543fd74e16b3bf313d71aa187c24cdd728a7b1e",
//     "e0b9a8799f32453a478c9122f8b83cee68e16db18f493ac81bc1d474594b5df4",
//   ];
//   for (let cur_hash of hashes){
//     for (let i = 0; i < 256; i++){
//         for (let ii = 0; ii < 256; ii++){
//             let possibility = String.fromCharCode(i) + String.fromCharCode(ii);
//             if (cur_hash == ansdweasd(possibility)){
//                 console.log(possibility);
//             }
//         }
//     }
//   }

function aa(flag) {
  var hashes = [
      "dce7cce055566bed799f788cd0048e209a27a473c0f48b956fa1f1780e80d2c1",
      "635ca73d00d4f28b5f573b16eea56e9e4579d77e561c32aa68189d9769fa1753",
      "a4d0ef23161b5b7c6a8d5b287543fd74e16b3bf313d71aa187c24cdd728a7b1e",
      "e0b9a8799f32453a478c9122f8b83cee68e16db18f493ac81bc1d474594b5df4",
    ],
    flag_chunks_of_twos = flag.substring(0x0, 0x8).match(/.{1,2}/g);
    // andswead(["<first_two_char>"]) must return hashes[0]
    // andswead(["<next_two_char>"]) must return hashes[1]
    // andswead(["<next_two_char>"]) must return hashes[2]
    // andswead(["<next_two_char>"]) must return hashes[3]
  for (var index = 0x0; index < flag_chunks_of_twos.length; index++) {
    var return_ansdweasd = ansdweasd(flag_chunks_of_twos[index]);
    if (return_ansdweasd != hashes[index]) return ![];
  }
  return !![];
}



let xor_values = [0x52, 0x7, 0x4a, 0x6, 0x4, 0xa, 0x0, 0x12];

let xored_known = [121, 98, 101, 114];

let pass = "";
for (let i=0; i < xor_values.length; i++){
    let val = xor_values[i] ^ xored_known[i % xored_known.length];
    pass += (String.fromCharCode(val));
}
console.log(pass);
function bb(flag) {
  // So far the flag is "fs0bfusc???????????cyber"
  // flag_substr_1 would be "fsyb"
  var flag_substr_1 = "fs" + flag.substring(20, 22),
    flag_substr_2 = flag.substring(8, 16),
    xor_values = [0x52, 0x7, 0x4a, 0x6, 0x4, 0xa, 0x0, 0x12];

    //Ignore these comments, wrong value (yber instead of fsyb)
    // 8th value xored with the 20th value is 0x52
    // 8th value xored with y is 0x52
    // 9th value xored with b is 0x7
    // 10th value xored with e is 0x4a
    // 11th value xored with r is 0x6
    // 12th value xored with y is 0x4

    //ord("y") = 121
    //ord("b") = 98
    //ord('e') = 101
    //ord("r") = 114

    //Ignore these comments, wrong value (yber instead of fsyb)
    // flag_substr_1 = "ab"
    // flag_substr_2 = "efgh"
  for (var index = 0x0; index < flag_substr_2["length"]; ++index) {
    //Ignore these comments, wrong value (yber instead of fsyb)
      // for first iteration
    // 0x2e8... = 97;
    // 0x40bb... = 101;
    // 0x2e8... = 98;
    // 0x40bb... = ...;
    // 0x2e8... = 97;
    // 0x40bb... = ...;
    var flag_substr_1_cur_char = flag_substr_1[index % flag_substr_1.length].charCodeAt(0x0);
    var flag_substr_2_cur_char = flag_substr_2[index].charCodeAt(0x0);

    if (xor_values[index] != (flag_substr_1_cur_char ^ flag_substr_2_cur_char)){
         return false;
    }
  }
  return !![];
}
function cc(flag) {
  var _0x593622 = ebg13(flag["substring"](0x10, 0x18));
  return _0x593622 == "4egplore";
}
function check(flag) {
  var functions = [aa, bb, cc];
  for (var index = 0x0; index < functions["length"]; index++) {
      let current_function = functions[index];

    var function_ret = current_function(flag);

    if (!function_ret) {
      alert("Not\x20quite\x20right");
      return;
    }
  }
  alert("Accepted\x20:)");
}
p != null && p["length"] == 24 && check(p);

```

Flag: `fs0bfusc4t3dbyyp4rtcyber`
