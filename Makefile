all: bonsai

bonsai:
	csc Program.cs
	mono Program.exe

clean:
	rm -f Program.exe
