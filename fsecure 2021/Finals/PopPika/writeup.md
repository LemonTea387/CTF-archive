# Poppika

I was told by my teammate that this was a viral game some months before the competition.

Anyway, I could not decompile the apk file for some reason. I tried several tools. Only after the competition did I realise only [JadX](https://github.com/skylot/jadx)
works. No, I don't know why. And I feel dumb because I realised I had the exact same problem before in the past, but I forgot about it.

Anyway, it seemed that in the function getInformationContext the java code was creating a file in a path called dexOutputDir. It was supposedly a JSON file (looking at the extension)
and it was created in the setHandlerApp file in the run() function. Just to play it safe, instead of reverse-engineering how the file is created, I ran the code in an emulator with root capabilities and extracted the app.json file directly
with `adb pull "/data/data/com.fscyberx.poppika/app_dexOutputDir/app.json"`. Anyway, the code seems to imply that it is not in fact a json file, and is a DEX file (used in java, I think it's something like the compiled java code?).

Opening the json file in a hex editor also confirms this, with a "dex" magic on top of the file.

The code responsible for running the app.json code is the following:-
```
   public String getInformationContext(Context context, Integer num) {
        File dir = context.getDir("dexOutputDir", 0);
        File file = new File(dir + File.separator + "app.json");
        if (!file.exists() || !dir.exists()) {
            Log.d(this.TAG_NAME, "/(X.x)\\: Something missing!");
        } else {
            try {
                Class loadClass = new DexClassLoader(file.getAbsolutePath(), dir.getAbsolutePath(), null, getClass().getClassLoader()).loadClass("pkpk");
                Method declaredMethod = loadClass.getDeclaredMethod("pstr", new Class[0]);
                declaredMethod.setAccessible(true);
                String str = (String) declaredMethod.invoke(loadClass.newInstance(), new Object[0]);
                Method declaredMethod2 = loadClass.getDeclaredMethod("ply", String.class);
                declaredMethod2.setAccessible(true);
                String str2 = (String) declaredMethod2.invoke(loadClass.newInstance(), "d8e3887ffadf22b9");
                Method declaredMethod3 = loadClass.getDeclaredMethod("pikapop", String.class, Integer.TYPE);
                declaredMethod3.setAccessible(true);
                return (String) declaredMethod3.invoke(loadClass.newInstance(), str2, Integer.valueOf(str2.length()));
            } catch (Exception e) {
                e.printStackTrace();
                Log.d(this.TAG_NAME, "/(X.x)\\: WooOt Error! ");
            }
        }
        return "";
    }
```
It seems to be callig three functions in there. pstr, ply and pikapop.

Now to decompile app.json. You might need to rename this to have a 'dex' extension.

```
package defpackage;

import java.math.BigInteger;
import java.security.MessageDigest;
import java.security.NoSuchAlgorithmException;
import java.util.Random;

/* renamed from: pkpk  reason: default package */
public class pkpk {
    static int[] heh = {33, 59, 0, 117, 32, 0, 44, 1, 23, 121, 15, 114, 32, 56, 32, 32, 53, 48};

    public static String print() {
        return "I am the hidden Pika";
    }

    public String pstr() {
        return "LOLOLOLOLOL, You made IT";
    }

    public static void initialize() {
        heh[4] = 59;
    }

    private static String hashMD5(String str) {
        try {
            initialize();
            String bigInteger = new BigInteger(1, MessageDigest.getInstance("MD5").digest(str.getBytes())).toString(16);
            while (bigInteger.length() < 32) {
                bigInteger = "0" + bigInteger;
            }
            return bigInteger;
        } catch (NoSuchAlgorithmException e) {
            throw new RuntimeException(e);
        }
    }

    public static String ply(String str) {
        char[] cArr = {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H'};
        Random random = new Random();
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < cArr.length; i++) {
            int nextInt = random.nextInt(cArr.length);
            char c = cArr[nextInt];
            cArr[nextInt] = cArr[i];
            cArr[i] = c;
        }
        sb.append(String.valueOf(cArr));
        if (hashMD5(sb.toString()) == (str + "e8dbc3f52fe0b372")) {
            return sb.toString();
        }
        return "/(x.x)\\ GGWP This is not popmeow";
    }

    public static String pikapop(String str, int i) {
        if (str.contains("GGWP")) {
            return "/(x.x)\\ Think smoaort!";
        }
        StringBuilder sb = new StringBuilder();
        for (int i2 = 0; i2 < heh.length; i2++) {
            sb.append(Character.toString((char) (str.charAt(i2 % i) ^ heh[i2])));
        }
        return sb.toString();
    }
}
```

I think the pstr function call is useless, and is just a message to the player that they're on the right track decompiling the app.json file.

The first stage is the ply function, which is called with the argument 'd8e3...'
and its result is put into str.

Looking at the function, you see that argument is appended with another string, 'e8dbc...' and is compared to with an MD5 hash. The hash is a hash of a random string with the characters "ABCDEFGH", and is what will be returned.

I made a rudimentary brute-forcer for this in "solver.py". It will take a while to run, 
but it will give "GHDFCABE" as the value eventually.

Next is the pikapop, which will take the "GHDFCABE", and use it as a key (wrapping itself to the beginning when needed) to decrypt the "heh" array, which
is the final flag. I wrote a solver in `solver2.py` for this.

Flag: `fsD3cAnDP1K4cyberx`
Side-Note: WHat is "Dec And Pika"? Decompiling and Pika?
