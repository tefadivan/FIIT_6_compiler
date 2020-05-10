# FIIT_6_compiler
![CI](https://github.com/Taally/FIIT_6_compiler/workflows/CI/badge.svg)

|Название команды |Аббревиатура|Участники команды|
|:-----------------:|:-------------:|:-----------------:|
|Икеевские акулы|ИА|Татарова А., Шкуро Т.|
|Ростов-Москва|РМ|Володин Д., Моздоров Н.|
|void|void|Карякин В., Карякин Д.|
|Пираты|П|Рыженков С., Евсеенко А.|
|Dedsec|D|Галицкий К., Черкашин А.|
|Hot6|H6|Пацеев А., Ушаков И.|
||| Письменский М., Лутченко Д.|
||| Потапов И. |

## Задания

| Команда  | Задания | |3-адресный код
| :---------- |:-------:|:--:|:-:
| ИА | 1 \* ex, ex \* 1, ex / 1 => ex | if (true) st1; else st2; => st1 |Def-Use информация: накопление информации и удаление мертвого кода на ее основе
| Dedsec | a > a, a != a => false | if (false) st1; else st2; => st2 |Устранение переходов к переходам
| H6 | 2 == 4 => false | while (false) st; => null |Очистка кода от пустых операторов
| void | x = x => null | if (ex) null; else null; => null |Устранение переходов через переходы
| Пираты | 0 \* expr, expr \* 0 => 0 | 0 + expr => expr  |Учет алгебраических тождеств
| РМ | a == a, a >= a => true | if (true) st1; else st2; => st1 |Живые и мертвые перем и удаление мертвого кода (замена на пустой оператор)
| Письменский, Лутченко| 2 < 3 => true | if (false) st1; else st2; => st2 |Оптимизация общих подвыражений
| Потапов | 2 * 3 => 6 | a - a => 0 |Протяжка констант, Протяжка копий
