![](https://sun9-47.userapi.com/c857720/v857720273/221376/psNUjOoLEWI.jpg)

#Что это?

Одномерное поле, «право-лево» которого и «верх-низ» соединены между собой (как на глобусе).
Каждая клетка на поверхности может находиться в двух состояниях: быть «живой» (заполненной) или «мёртвой» (пустой).
Распределение живых клеток в начале игры называется первым поколением. 
Каждое следующее рассчитывается на основе предыдущего по таким правилам:
- в пустой (мёртвой) клетке, рядом с которой ровно три живые клетки, зарождается жизнь;
- если у живой клетки есть две или три живые соседки, то эта клетка продолжает жить; в противном случае, если соседей меньше двух или больше трёх, клетка умирает («от одиночества» или «от перенаселённости»)
<p align="center">
состояния точки описывается с помощью enum (живая, неживая и т.д.)
после рандомного распределения точек первого поколения мы рисуем следующие.
</p>
кстати, если провести по полю с зажатой левой кнопкой мыши, то будут рождаться новые клетки. с правой мы их будем убивать.
<p align="center">
  <a>
      <img src="https://psv4.userapi.com/c856216/u406800279/docs/d3/b03d35028bc6/i.gif?extra=DIYSTbg9AG10AYW-PH1PtFyjgqZ_P36M05noNVAE6XK0Ic2y_IcPJOz_YQcQb9FUA_7aUqKxpQ4a8ozdGnaWQkdY-Dbh7nmE7KL_wO1UbaEqoOeD7kYtKr-a_AcQQNwlgp72DM8xxf_iMBcgMjBWuNI" alt="Game Of Life" width="500">
	  </a>
</p>


