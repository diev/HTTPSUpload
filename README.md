# HTTPSUpload
[![Build status](https://ci.appveyor.com/api/projects/status/mleec5ofn81nlssa?svg=true)](https://ci.appveyor.com/project/diev/httpsupload)

Compatible program to send files to NBKI, Moscow.

## Зачем это
Исходная программа, предоставленная НБКИ, (c) 2009, не стала работать в какой-то нашей версии Microsoft .NET Framework. В итоге была быстро создана ей замена со своими исходными кодами, которые можно скомпилировать под любую среду прилагаемым скриптом `make.cmd`.

## Командная строка
Требуется лишь единственный вариант - ради совместимости - отправить файл `file.zip.enc`.

```
HTTPSUpload https://icrs.nbki.ru/inout/cgi-bin/uploadvb.cgi uploads file.zip.enc
```

## Настройки прокси
Используются системные:

You can display the Internet Explorer Local Area Network (LAN) Settings dialog box by selecting Tools from the Internet Explorer main menu and then selecting Internet Options. Next, select the Connections tab, and click LAN Settings.

## License
[Sources](https://github.com/diev/HTTPSUpload) licensed under the Apache [License](LICENSE), Version 2.0.


