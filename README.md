# Minion Bot
This repository is where the Minion Bot responses are stored. 

## Adding a new language
You don't have to be a programmer to add a new language. 
Start by downloading and unzipping [english responses](https://github.com/devhl-labs/MinionBot5.Language/raw/main/responses-to-be-translated.zip)
Translate the reponses using a simple text editor like Notepad or VS Code (not Word).
Once translated just send me the files over Discord.
You don't have to translate everything. If no translation is provided, we can just default to English.

## Okay but how?
Only change what is between the quotes. Here is an example:
```cs
public string HelloWorld => "Hello, world!";
public string HelloWorld => "¡Hola Mundo!";
```
## But what are these funny characters?
Some responses have variables in them. Variables will usually be string (aka text) but can also be int (a number) or other.
Feel free to move the variable within the response so it makes sense in your langague. Here is an example.
```cs
public string MyNameIs(string name) => $"My name is {name}.";
public string MyNameIs(string name) => $"Me llamo es {name}.";
```

## Programmers
If you are a programmer, feel free to submit a pull request. Just give me a heads up so we don't have a conflict.