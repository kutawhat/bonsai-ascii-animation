# Этот код добавит анимированное дерево бонсай в ваш терминал

## Как запустить:
1. Установите компилятор c# для терминала:
```zsh
brew install mono
```
2. Измените путь к файлам .txt в коде файла Program.cs:
```csh
public static void SelectAnimation()
{
    Console.Clear();

    //Путь до папки со всеми ascii деревьями
    string mainPath = "/Users/ku/Documents/coding/ascii-animations/bonsai/trees/";
	...
}
```
3. Откройте терминал и перейдите к директиве bonsai
4. Вбейте в терминале:
```zsh
csc Program.cs
mono Program.exe
```
<!--```zsh
              		       ,.,
              		      MMMM_    ,..,
              		        "_ "__"MMMMM          ,...,,
              		 ,..., __." --"    ,.,     _-"MMMMMMM
              		MMMMMM"___ "_._   MMM"_."" _ """"""
              		 """""    "" , \_.   "_. ."       #
              		 #      ,,, _"__ \__./ ."      #
              		    #  MMMMM_"  "_    ./          #
              		 #      ''''      (    )
              		  _______________.-'____"---._
              		  \                          /
              		   \________________________/
              		     |_|                |_|
```-->
5. Наслаждайтесь ∗

![preview](https://github.com/kutawhat/bonsai-ascii-animation/assets/64655969/0cf99a2a-640e-4e23-8bc9-ad1067f451a0)