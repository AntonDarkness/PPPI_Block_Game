//Класс содержащий локальные данные игрока (для одичной игры)
public class LocalAccount
{
  ///<summary>
  ///Последний режим сложности, установленный пользователем
  ///</summary>
  private int lastDificultMode; //последний режим сложности
  ///<summary>
  ///Максимальный рекорд по очкам для пользователя
  ///</summary>
  private long maxRecordInGame; //максимальный рекорд очков
  ///<summary>
  ///Время продолжительности последний игры
  ///</summary>
  private long timeLastGame; //время последней игры
  ///<summary>
  ///Конструктор класса для создания локального аккаунта
  ///</summary>
  public LocalAccount(){
    //метод загрузки данных о последней игре из локальных файлов
  }
  ///<summary>
  ///Метод перезаписи результатов игры по параметрам
  ///</summary>
  ///<param name="dificult">Сложность игры</param>
  ///<param name="recordGame">Игровой рекорд</param>
  ///<param name="timeGame">Время игры</param>
  public void reSave(int dificult, long recordGame, long timeGame){
    /*метод в котором происходит сохранение результатов прошлой игры
    , а также происходит проверка нового рекорда со старым, и
    если новый рекорд больше, чем старый - перезапись рекорда*/
  }
  ///<summary>
  ///Другие методы, которые необходимы для корректной работы
  ///</summary>
  //некоторые другие методы
}
