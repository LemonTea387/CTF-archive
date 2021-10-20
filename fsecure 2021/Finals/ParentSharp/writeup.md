# ParentSharp

The thing about this challenge, is that it took me too long to realise that the decompiler I use, [AvaloniaILSpy](https://github.com/icsharpcode/AvaloniaILSpy),
 was not in fact broken. I thought it couldn't export projects for me to play around with, but it turns out that was indeed possible.

I was just running the wrong command. I had previously used "csharp" or something similar for compilation on my Linux machine. What I
really needed was `mcs -out:hello.exe Parent_Sharp.cs -unsafe`.

There were some errors about some exclamation marks, but removing those exclamation marks seemed to work.

Then I needed to remove the [assembly ] and [module ] lines.

Also, in the decompilation for some reason they try to directly invoke the get\_ method. Just remove all instances of get\_ and parentheses,
i.e: `val.get_ElapsedMilliseconds()` should simply be `val.ElapsedMilliseconds`
Luckily there's only one instance of this.

Finally, get rid of the question mark in `Type? type = Assembly.Load(new bsd(Encoding.UTF8.GetString(bytes).ToCharArray()).gdgdgd()).GetType("Baby_Sharp.shark_call");`

Compile, and now you can run the program with `wine hello.exe`. And now you can modify the C Sharp code to your heart's content!

First off, I dump the array variable to a file, as well as the stage 2 code you see (it's the `new bsd()` thing.) I again use ILSpy/Avalonia to decompile
the stage 2 code (which is a DLL actually), and get stage\_2.cs. 

I copy that stage\_2.cs code to stage\_2\_modified.cs that I can play around with.


I then comment out the [assembly ] and [module ] lines, and comment out the inside of the cmr function (I think it's Windows-specific code that is messing up my
system)

I also add a Main function, which has to be static.
 Additionally, to call the Sharp function, I need to make that function static too.
 I use the array values from the array.bin dump earlier.

 Running that executable gives me the flag.

 Interestingly, it seems like the condition checked is if the file "MessageFromAuthor.txt" exists. If there were a way to make it not exist, that would
 be an easier way of getting the flag. Simply changing the filename created in Stage 1 should also have worked.

 Flag: `fsB4bySh4rpcyberx`
