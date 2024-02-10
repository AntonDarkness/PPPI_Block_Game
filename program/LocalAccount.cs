//Класс содержащий локальные данные игрока (для одичной игры)
public class LocalAccount
{
  private int lastDificultMode; //последний режим сложности
  private long maxRecordInGame; //максимальный рекорд очков
  private long timeLastGame; //время последней игры

  public LocalAccount(){
    //метод загрузки данных о последней игре из локальных файлов
  }
  public void reSave(int dificult, long recordGame, long timeGame){
    /*метод в котором происходит сохранение результатов прошлой игры
    , а также происходит проверка нового рекорда со старым, и
    если новый рекорд больше, чем старый - перезапись рекорда*/
  }
  //некоторые другие методы
}
