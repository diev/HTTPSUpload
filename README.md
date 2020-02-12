# [HTTPSUpload]

[![Build status]][appveyor]
[![GitHub Release]][releases]

Compatible program to send files to NBKI, Moscow.

## Зачем это

Исходная программа, предоставленная НБКИ, (c) 2009, не стала работать в 
какой-то нашей версии Microsoft .NET Framework. В итоге была быстро создана 
ей замена со своими исходными кодами, которые можно скомпилировать под любую 
среду прилагаемым скриптом `make.cmd` из файлов \*.cs в этой директории.

В 2020 году понадобилось добавить игнорирование ошибок сертификата сервера.
Переход на TLS 1.2 потребовал исключить поддержку устаревших версий .NET.

## Командная строка

Требуется лишь единственный вариант - ради совместимости - отправить файл 
`file.zip.enc`.

```
HTTPSUpload https://icrs.nbki.ru/inout/cgi-bin/uploadvb.cgi uploads file.zip.enc
```

## Настройки прокси

Используются системные:

You can display the Internet Explorer Local Area Network (LAN) Settings 
dialog box by selecting *Tools* from the Internet Explorer main menu and then 
selecting *Internet Options*. Next, select the *Connections* tab, and click 
*LAN Settings*.

## История версий

Нумерация версий ведется по принципам [семантического версионирования]
со следующими особенностями (для примера - пусть будет версия *1.2.3*):

* Старшая цифра (*1*) меняется, когда сильно 
меняется внешний вид (требуется новое обучение пользователей) или внутренний 
функционал программы (требуется обратить внимание администраторов и сделать 
вдумчивые перенастройки);
* Средняя цифра (*2*) - когда что-то добавляется во внешний вид 
(требуется обратить внимание пользователей - добавлена какая-то их хотелка) 
или добавлен параметр в файл настройки, поведение которого по умолчанию 
ничего для администраторов не меняет;
* Младшая цифра (*3*) - когда в программе сделаны какие-то незначительные 
изменения в коде или исправлены ошибки.

Полная история версий в файле [CHANGELOG].

## License

Licensed under the [Apache License, Version 2.0].

[HTTPSUpload]: http://diev.github.io/HTTPSUpload/
[CHANGELOG]: CHANGELOG.md
[Apache License, Version 2.0]: LICENSE
[Build status]: https://ci.appveyor.com/api/projects/status/mleec5ofn81nlssa?svg=true
[GitHub Release]: https://img.shields.io/github/release/diev/HTTPSUpload.svg
[appveyor]: https://ci.appveyor.com/project/diev/httpsupload
[releases]: https://github.com/diev/HTTPSUpload/releases/latest
