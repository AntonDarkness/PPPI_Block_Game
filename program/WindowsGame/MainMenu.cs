///<summary>
///Класс, который реализует окно главного меню
///</summary>
public class MainMenu
{
  ///<summary>
  ///Версия игры
  ///</summary>
  private string gameVersion;
  ///<summary>
  ///Статус клиента игрока в сети
  ///</summary>
  ///<remarks>true - в сети<br/>false - не в сети</remarks>
  private bool statusGameClientInOnline;
  ///<summary>
  ///Текущие параметры для игры (настройки)
  ///</summary>
  private int[] parametrsForMenu;
  ///<summary>
  ///Конструктор класса, для создания окна
  ///</summary>
  public MainMenu(){
    //Запуск приложение и вывод главного меню
  }
  ///<summary>
  ///Метод проверки версии игры
  ///</summary>
  ///<returns>true - версия совпадает<br/>
  ///false - версия не совпадает, предлагает обновить игру</returns>
  public bool checkVersionGame(){
    //проверка версии игры, если есть подключение к сети.
    //Если подключение есть и версия на сервере не 
    //совпадает с версией клиента - предлагает обновление
  }
  ///<summary>
  ///Метод подключения к серверу
  ///</summary>
  ///<returns>true - подключение успешно<br/>
  ///false - подключение не удалось</returns>
  public bool connectionWithServer(){
    //метод подключения к серверу
  }
  ///<summary>
  ///Метод обработки нажатия на кнопку "Одиночная игра"
  ///</summary>
  public void onePlayerGameButton(){
    //метод обработки нажатия на кнопку "одиночная игра"
  }
  ///<summary>
  ///Метод обработки нажатия на кнопку "Многопользовательская игра"
  ///</summary>
  public void multiplayerGameButton(){
    //метод обработки нажатия на кнопку "многопользовательская игра"
  }
  ///<summary>
  ///Метод обработки нажатия на кнопку "Выход"
  ///</summary>
  public void exitButton(){
    //метод обработки нажатия на кнопку "выход"
  }
  ///<summary>
  ///Метод обработки нажатия на кнопку "Настройки"
  ///</summary>
  public void buttonSetting(){
    //метод обработки нажатия на кнопку "настройки"
  }
  ///<summary>
  ///Метод загрузки других окон при нажатии на определённые кнопки
  ///</summary>
  public void loadWindows(){
    //метод загрузки других окон при нажатии кнопок
  }
  ///<summary>
  ///Другие методы, которые необходимы для корректной работы
  ///</summary>
  //другие методы класса

}
