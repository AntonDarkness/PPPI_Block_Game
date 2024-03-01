///<summary>
///Класс отвечающий за окно меню для многопользовательской игры
///</summary>
public class MultiplayerMenu
{
  ///<summary>
  ///Статус игрока в сети или нет
  ///</summary>
  private bool statusPlayer;
  ///<summary>
  ///Состояние музыки (включена или нет)
  ///</summary>
  private bool musicOn;
  ///<summary>
  ///Состояние музыкальных эффектов (включены или нет)
  ///</summary>
  private bool musicEffectsOn;
  ///<summary>
  ///Наличие игрового аккаунта (есть или нет)
  ///</summary>
  private bool accountPerson;
  ///<summary>
  ///IP адресс пользователя
  ///</summary>
  private string ipAdress;
  ///<summary>
  ///Аккаунт пользователя
  ///</summary>
  ///<remarks>Если аккаунта нет, может быть равным значеню NULL.<br/>
  ///Значение NULL будет означать игру как гость (без сохранения результатов)</remarks>
  private Account person;
  ///<summary>
  ///Конструктор класса для создания окна меню
  ///</summary>
  public MultiplayerMenu(){
    //загрузка интерфейса многопользовательской игры
  }
  ///<summary>
  ///Метод загрузки аккаунта пользователя
  ///</summary>
  public void loadPersonAccount(){
    /*Метод в котором проверяется наличие аккаунта у пользователя.
    Если аккаунт есть - происходит его загрузка, 
    а если аккаунт нет - происходит выбор:
    создать аккаунт или играть как гость*/
  }
  ///<summary>
  ///Метод обработки нажатия кнопки "Назад"
  ///</summary>
  public void buttonExit(){
    //метод обработки нажатия кнопки "назад"
  }
  ///<summary>
  ///Метод обработки нажатия кнопки "Поиск игры"
  ///</summary>
  public void buttonStartGame(){
    //метод обработки нажатия кнопки "поиск игры"
  }
  ///<summary>
  ///Метод проверки соединения с интернетом
  ///</summary>
  public bool checkInternetConnection(){
    //метод проверки интернет соединения
  }
  ///<summary>
  ///Другие методы, которые необходимы для корректной работы
  ///</summary>
  //другие методы
}
