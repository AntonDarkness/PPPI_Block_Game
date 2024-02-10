public class GameLogic
{
  private int countLines;
  private int countCollumns;
  private int countDestructionLines;
  private bool gameProcess;
  private long countPoints;
  private double tempSpeed;
  private int gameDifficult;
  private Figure nextFigure;
  private Figure tempFigure;
  
  public GameLogic(int difficult){
    //запуск игровой логике - появление первой фигуры
    //и установка начальной скорости игры
  }
  private void gameProcess(){
    //метод отвечающий за начало игрового процесса
  }
  public void generateNextFigure(){
    /*Метод ссылается на класс Figure и выполняет две функции:
    установка текущей фигуры, которая появилась и падает;
    установка следующей фигуры, которая будет после текущей;*/
  }
  private void analysGameField(){
    /*метод анализирует игровое поле и удаляет
    линию из блоков (если игру можно продолжить), 
    или же сообщает что игра закончилась*/
  }
  private void deleteLineBlock(int[] indexString){
    //удаляет строку(-и) по номеру, если они заполненны
    //а также опускает другие блоки на линию ниже
  }
  private void changeSpeedGame(){
    //метод изменения скорости игры в зависимости
    //от количества уничтоженых линий
  }
  private void pointsCalculation(){
    /*метод, отвечающий за расчёт количества
    очков, в зависимости от уничтоженых линий
    и сложности игрового процесса*/
  }

  private void endGame(){
    //метод завершения игрового процесса
  }
  //другие методы класса
}
