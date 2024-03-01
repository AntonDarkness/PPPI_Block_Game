public class Server
{
  private long[] id_user;
  private string[] username;

  public Server(){
    //выполняется запуск сервера
  }
  public void unloadServer(){
    //выполняется выключение сервера
  }
  public void connectionClients(int user_id_1, int user_id_2){
    //здесь происходит подключение клиентов к игре, а потом
    //происходит создание игровой сессии
  }
  public void createGameSession(int user_id_1, int user_id_2){
    //происходит создание игровой сессии между игроками между 2 игроками.
    //Потом происходит запуск игрового процесса
  }
  public void createGameProcess(int user_id_1, int user_id_2){
    //создание игрового поля и начало игрового процесса
    //в случае проблем с интернетом выполняется синхронизация данных
    //в случае выигрыша/или выхода одного из игроков - вывод результатов и уничтожение сессии
  }
  public void deleteGameSession(int user_id_1, int user_id_2){
    //уничтожение игровой сесии
  }
  ///<summary>
  ///Другие методы, которые необходимы для корректной работы
  ///</summary>
  /*Другие методы, необходимые для корректной работы сервера*/
}
