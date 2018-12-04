### Содержание
  1. [Введение](#1)
  2. [Объект тестирования](#2)
  3. [Риски](#3)
  4. [Аспекты тестирования](#4)<br>
    4.1. [Возможность начать игру](#001)<br>
    4.2. [Возможность посетить раздел FAQ](#002)<br>
    4.3. [Возможность изменить громкость музыки](#003)<br>
    4.4. [Возможность изменить громкость звуковых эффектов](#004)<br>
    4.5. [Возможность отключить/включить отображение кадров в секунду](#005)<br>
    4.6. [Возможность поставить игру на паузу](#006)<br>
    4.7. [Отображение счета](#007)<br>
    4.8. [Возможность получить внутриигровую валюту](#008)<br>
    4.9. [Возможность приобрести бонусы в магазине за внутриигровую валюту](#009)<br>
    4.10. [Просмотр таблицы лидеров](#010)<br>
    4.11. [Возможность игры по сети](#011)<br>
5. [Подходы к тестированию](#5)
6. [Представление результатов](#6)
7. [Выводы](#7)


<a name="1"></a>
### 1. Введение
Этот план был разработан для тестирования приложения "MyDragonHills". Цель тестирования - проверка работоспособности и пригодности приложения для практического использования.
В данном плане используется особые термины, значение которых описано в Глоссарии [Ru](https://github.com/ZiGNicK/MyDragonHills/blob/master/Documentation/GlossaryRU.md), [Eng](https://github.com/ZiGNicK/MyDragonHills/blob/master/Documentation/GlossaryENG.md)

<a name="2"></a>
### 2. Объект тестирования
Объект тестирования представляет собой инди-игру для платформы Android, которая должна обладать следующими атрибутами качества:
1. Функциональность:
    - функциональная полнота: приложение должно выполнять все заявленные функции в соответствии с SRS
    - функциональная корректность: приложение должно выполнять все заявленные функции безошибочно
    - функциональная целесообразность: отсутствуют не заявленные функции, которые бы мешали приложению выполнять первоначально поставленные задачи.
2. Удобство использования:
    - простота пользовательского интерфейса: интерфейс должен быть достаточно простым для интуитивного использования новым пользователем.


<a name="3"></a>
### 3. Риски
1. При использовании приложения на устарелых смартфонах, которые используют процессоры прошлого поколения, геймплей может стать значительно медленнее
2. Приложение может не запуститься на устройстве с версией Android менее 4.4


<a name="4"></a>
### 4. Аспекты тестирования
В ходе тестирования должна быть проверена реализация основных функций приложения, к которым относятся:

- Возможность начать игру;
- Возможность посетить раздел FAQ;
- Возможность изменить громкость музыки;
- Возможность изменить громкость звуковых эффектов:
- Возможность отключить/включить отображение кадров в секунду;
- Возможность поставить игру на паузу;
- Отображение счета;
- Возможность получить внутриигровую валюту;
- Возможность приобрести бонусы в магазине за внутриигровую валюту;
- Просмотр таблицы лидеров;
- Возможность игры по сети.

#### Функциональные требования:

<a name="001"></a>
##### Возможность начать игру
Этот вариант использования небходимо протестировать на:
1. Реакцию приложения после нажатия кнопки "Старт".
2. Переход из главного меню в режим игры.

<a name="002"></a>
##### Возможность посетить раздел FAQ
Этот вариант использования небходимо протестировать на:
1. Переход на окно вопросов-ответом после нажатия кнопки "FAQ".
2. Корректное отображение вопросов-ответов.

<a name="003"></a>
##### Возможность изменить громкость музыки
Этот вариант использования небходимо протестировать на:
1. Переход на окно настроек после нажатия кнопки "Settings".
2. Циклическое понижение громкости музыки на 25% с каждым нажатием кнопки "Music".

<a name="004"></a>
##### Возможность изменить громкость звуковых эффектов
Этот вариант использования небходимо протестировать на:
1. Переход на окно настроек после нажатия кнопки "Settings".
2. Циклическое понижение громкости звуковых эффектов на 25% с каждым нажатием кнопки "Sound".

<a name="005"></a>
##### Возможность отключить/включить отображение кадров в секунду
Этот вариант использования небходимо протестировать на:
1. Переход на окно настроек после нажатия кнопки "Settings".
2. Включение/выключения отображения кадров в секунду в верхнем правом углу в режиме игры после нажатия кнопки "FPS".

<a name="006"></a>
##### Возможность поставить игру на паузу
Этот вариант использования небходимо протестировать на:
1. Приостановку всех действий в игре,, после нажатия кнопки паузы.

<a name="007"></a>
##### Отображение счета
Этот вариант использования небходимо протестировать на:
1. Корректное отображение текущего максимального счета за уровень.

<a name="008"></a>
##### Возможность получить внутриигровую валюту
Этот вариант использования небходимо протестировать на:
1. Измение количества внутриигровой валюты после подбора кристаллов в режиме игры.

<a name="009"></a>
##### Возможность приобрести бонусы в магазине за внутриигровую валюту
Этот вариант использования небходимо протестировать на:
1. Переход из главного меню в меню магазина после нажатия кнопки "Shop";
2. Возможность покупки бонусов за наковленные кристаллы.

<a name="010"></a>
##### Просмотр таблицы лидеров
Этот вариант использования небходимо протестировать на:
1. Переход из главного меню в меню лидеров после нажатия кнопки "Leaderboards";
2. Нахождение Игрока в списке лидеров после нажатия кнопки "Find me".

<a name="011"></a>
##### Возможность игры по сети
Этот вариант использования небходимо протестировать на:
1. Переход из главного меню в меню мультиплеера после нажатия кнопки "Multiplayer";
2. Старт игры по сети.

#### Нефункциональные требования:
- быстрый запуск приложения;
- все элементы пользовательского интерфейса имеют значки, описывающее действие которое они выполняют.

<a name="5"></a>
### 5. Подходы к тестированию
Тестирование каждого аспекта будет проводиться ручным подходом

<a name="6"></a>
### 6. Представление результатов
Результаты тестирования представлены в [таблице](https://github.com/ZiGNicK/MyDragonHills/blob/master/Documentation/TestResult.md).

<a name="7"></a>
### 7. Выводы
Данный тестовый план позволяет протестировать основной функционал приложения. Успешное прохождение всех тестов не гарантирует полной работоспособности на всех версиях платформ и архитектурах, однако позволяет полагать, что данное программное обеспечение работает корректно.