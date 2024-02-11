//Данный класс реализует некоторые методы, необходимые для расширения игровой логики для сетевой игры

public class MultiplayerLogic
{
  private GameLogic logicForGame;
  private Server server;
  private bool statusPlayerOne;
  private bool statusPlayerTwo;
  private long[] countPointsPlayer;
  private Account player1;
  private Account player2;
  
  public MultiplayerLogic(){
    //Запуск игровой логики для сетевой игры
  }
  
  /*методы которые вызывают методы класса GameLogic*/

  public void checkStatusPlayers(){
    /*метод проверяет состояние подключения двух игроков
    и в случае если один отключается - проводит синхронизацию,
    вызывая ожидание у второго игрока*/
  }
  public void tradePointsInfo(){
    //обмен информацией о количестве очков у обоих игроков
  }

  //Другие методы класса
}
