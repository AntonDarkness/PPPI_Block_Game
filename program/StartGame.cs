///<summary>
///Класс который реализует задачи запуска игры
///</summary>
public class StartGame
{
  ///<summary>
  ///Состояние игры
  ///</summary>
  private bool statusGame;
  ///<summary>
  ///Состояние музыки (включена или нет)
  ///</summary>
  ///<remarks>true - включена<br/>false - выключена</remarks>
  private bool musicOn;
  ///<summary>
  ///Состояние музыкальных эффектов (включены или нет)
  ///</summary>
  ///<remarks>true - включены<br/>false - выключены</remarks>
  private bool musicEffects;
  ///<summary>
  ///Конструктор класса для создания заставки, пока игра загружается
  ///</summary>
  public StartGame(){
    //метод определяющий заставку во время загрузки игры
  }
  ///<summary>
  ///Метод для загрузки главного меню, когда началья заставка закончилась
  ///</summary>
  public void changedMenu(){
    //метод загрузающий главное меню, после заставки
  }
  ///<summary>
  ///Другие методы, которые необходимы для корректной работы
  ///</summary>
  //некоторые другие методы
}
