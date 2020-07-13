
<p align="center">
	
![](https://sun9-47.userapi.com/c857720/v857720273/221376/psNUjOoLEWI.jpg)

</p>

# Что это?
«Вселенная» состоит из клеток, в которых может быть жизнь. Она «тороидальная»: если зайти за её правый край, окажешься на левом, с верхом и низом то же самое. У каждой клетки есть 8 соседей.
Она может находиться в двух состояниях: быть «живой» (заполненной) или «мёртвой» (пустой).
Распределение живых клеток в начале игры называется первым поколением. 
Каждое следующее рассчитывается по таким правилам:
- Если у живой клетки меньше 2 соседей, она умирает от одиночества
- Если у живой клетки 2 или 3 соседа, она продолжает жить
- Если у клетки более 3 соседей, она умирает от перенаселения
- Если у неживой клетки ровно 3 соседа, происходит размножение и клетка становится живой

<p align="center">
состояния точки описывается с помощью enum (живая, неживая и т.д.)
после рандомного распределения точек первого поколения мы рисуем следующие.
</p>
кстати, если провести по полю с зажатой левой кнопкой мыши, то будут рождаться новые клетки. 
с правой мы их будем убивать.

----

<p align="center">
  <a>
      <img src="https://psv4.userapi.com/c856216/u406800279/docs/d3/b03d35028bc6/i.gif?extra=DIYSTbg9AG10AYW-PH1PtFyjgqZ_P36M05noNVAE6XK0Ic2y_IcPJOz_YQcQb9FUA_7aUqKxpQ4a8ozdGnaWQkdY-Dbh7nmE7KL_wO1UbaEqoOeD7kYtKr-a_AcQQNwlgp72DM8xxf_iMBcgMjBWuNI" alt="Game Of Life" width="500">
	  </a>
</p>


