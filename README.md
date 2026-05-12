Car Management System
Описание

Проектът представлява система за управление на автомобили, написана на C#.

Целта на проекта е да демонстрира използването на 3 Design Pattern шаблона:

Factory Method
Adapter
Observer
Използвани технологии
C#
.NET
Visual Studio
Използвани Design Patterns
1. Factory Method

Използва се за създаване на различни видове автомобили:

BMW
Audi
Основни класове:
ICar
BMW
Audi
CarFactory
BMWFactory
AudiFactory
2. Adapter

Използва се за свързване на стара GPS система към нов интерфейс.

Основни класове:
IGPS
OldGPS
GPSAdapter
3. Observer

Използва се за известяване на клиенти при промяна на информация.

Основни класове:
IObserver
Customer
CarMarket
Как работи програмата
Създава се автомобил чрез Factory Method.
GPS системата се използва чрез Adapter.
Клиентите се абонират към CarMarket.
При промяна се изпращат известия към всички клиенти.
Примерен изход
BMW created
Old GPS navigation...
Ivan received: BMW price decreased!
Maria received: BMW price decreased!
Заключение

Проектът демонстрира как Design Patterns могат да направят кода:

по-гъвкав;
по-структуриран;
по-лесен за разширяване и поддръжка.
