public class Server
{
  ///<summary>
  ///Массив идентификационных номеров пользователя
  ///</summary>
  private long[] id_user;
  ///<summary>
  ///Массив имен пользоветелей
  ///</summary>
  private string[] username;
  ///<summary>
  ///Конструктор класса, отвечающий за запуск сервера
  ///</summary>
  public Server(){
    //выполняется запуск сервера
  }
  ///<summary>
  ///Метод отключения сервера и отключения всех игроков
  ///</summary>
  public void unloadServer(){
    //выполняется выключение сервера
  }
  ///<summary>
  ///Метод подключения клиентов к игре
  ///</summary>
  ///<param name="user_id_1">Идентификационный номер первого пользователя</param>
  ///<param name="user_id_2">Идентификационный номер второго пользователя</param>
  ///<remarks>Данный метод также обращается к методу<br/>
  ///createGameSession для создания игровой сессии. </remarks>
  public void connectionClients(int user_id_1, int user_id_2){
    //здесь происходит подключение клиентов к игре, а потом
    //происходит создание игровой сессии
  }
  ///<summary>
  ///Метод создания игровой сессии для двух игроков
  ///</summary>
  ///<param name="user_id_1">Идентификационный номер первого пользователя</param>
  ///<param name="user_id_2">Идентификационный номер второго пользователя</param>
  ///<remarks>Данный метод также обращается к методу<br/>
  ///createGameProcess для создания игрового поля и начала игрового процесса<br/>
  ///между двумя игроками. </remarks>
  public void createGameSession(int user_id_1, int user_id_2){
    //происходит создание игровой сессии между игроками между 2 игроками.
    //Потом происходит запуск игрового процесса
  }
  ///<summary>
  ///Метод создания игрового процесса и обеспечения его корректной работы
  ///</summary>
  ///<param name="user_id_1">Идентификационный номер первого пользователя</param>
  ///<param name="user_id_2">Идентификационный номер второго пользователя</param>
  public void createGameProcess(int user_id_1, int user_id_2){
    //создание игрового поля и начало игрового процесса
    //в случае проблем с интернетом выполняется синхронизация данных
    //в случае выигрыша/или выхода одного из игроков - вывод результатов и уничтожение сессии
  }
  ///<summary>
  ///Метод уничтожения игровой сессии при наступлении победы (поражения)<br/>
  ///или выхода одного из игроков
  ///</summary>
  ///<param name="user_id_1">Идентификационный номер первого пользователя</param>
  ///<param name="user_id_2">Идентификационный номер второго пользователя</param>
  public void deleteGameSession(int user_id_1, int user_id_2){
    //уничтожение игровой сесии
  }
  ///<summary>
  ///Другие методы, которые необходимы для корректной работы
  ///</summary>
  /*Другие методы, необходимые для корректной работы сервера*/
}
