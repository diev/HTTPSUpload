﻿# История версий

Нумерация версий старается следовать принципам 
[семантического версионирования] со следующими 
особенностями в смене трех чисел через точку (`1.2.3`):

1. Когда сильно меняется внешний вид *(требуется новое обучение 
пользователей)* или функционал программы *(требуется обратить внимание 
администраторов и сделать вдумчивые перенастройки)*;
2. Когда что-то добавляется во внешний вид *(требуется обратить внимание 
пользователей - добавлена какая-то их хотелка)* или добавлен параметр в файл 
настройки *(поведение которого по умолчанию ничего для администраторов не 
меняет)*;
3. Когда сделаны какие-то незначительные изменения в коде или исправлены 
ошибки *(но по-началу изменения могут быть и значительными - пока идет 
процесс устаканивания всех нововведений)*.

## v1
### 1.1
#### 1.1.1 (2023-07-03): Update to .NET Framework 4.8
- Обновлено кое-что по коду
- Целевая среда обновлена на .NET Framework 4.8
- Компиляция в Microsoft Visual Studio 2022

#### 1.1.0 (2020-02-12): Add TLS 1.2
- Добавлена поддержка TLS 1.2
- Добавлено игнорирование ошибок сертификата сервера
- Убрана компиляция в устаревших .NET
- Добавлен проект на Microsoft Visual Studio 2019
- Добавлен этот CHANGELOG
- Правка документации
- Правка скрипта AppVeyor

### 1.0
#### 1.0.0 (2017-01-07): Initial release
- Первый релиз на GitHub

*[top]*

[семантического версионирования]: http://semver.org/lang/ru/
[top]: #top
