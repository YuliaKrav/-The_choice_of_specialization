### **Выбор специализации**

**Задача:** Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте исполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

**Примеры:**
["hello", "2", "world", ":-)"]->["2", ":-)"]
["1234", "1567", "-2", "computer science"]->["-2"]
["Russia", "Denmark", "Kazan"]->[]

**Описание решения**
1. В программе задается первоначальный массив *arrayString* для поиска и число *lessLength* - длина строк, которые должны быть добавлениы в новый массив должна быть меньше или равно этому числу.
2. В заданном массиве *arrayString* считается количество слов, длина которых меньше или равна *lessLength* => *countWordsLengthLessGivenIntLen()*.
3. Создается массив *arrayResult*, длина которого равна значению, полученному на предыдущем шаге.
4. Массив *arrayResult* заполняется словами из первоначального массива *arrayString*, длина которых меньше или равна *lessLength*.
5. Выводится полученный результат.