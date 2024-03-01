public class GameLogic
{
  ///<summary>
  ///Количество линий на игровом поле
  ///</summary>
  private int countLines;
  ///<summary>
  ///Количество столбцов на игровом поле
  ///</summary>
  private int countCollumns;
  ///<summary>
  ///Количество линий, которые были уничтожены
  ///</summary>
  private int countDestructionLines;
  ///<summary>
  ///Переменная ответственная за анализ идёт игровой процесс или нет
  ///</summary>
  private bool gameProcess;
  ///<summary>
  ///Количество текущих игровых очков пользователя
  ///</summary>
  private long countPoints;
  ///<summary>
  ///Переменная скорости падения блоков на игровое поле
  ///</summary>
  private double tempSpeed;
  ///<summary>
  ///Текущая сложность игрового процесса
  ///</summary>
  private int gameDifficult;
  ///<summary>
  ///Фигура, которая появится следующей
  ///</summary>
  private Figure nextFigure;
  ///<summary>
  ///Фигура, которая падает в текущий момент
  ///</summary>
  private Figure tempFigure;
  ///<summary>
  ///Конкструктор класса, создающий игру по установленной сложности
  ///</summary>
  ///<param name="difficult">Сложность игры</param>
  ///<returns>Игровое поле</returns>
  public GameLogic(int difficult){
    //запуск игровой логике - появление первой фигуры
    //и установка начальной скорости игры
  }
  ///<summary>
  ///Метод создания игрового процесса
  ///</summary>
  private void gameProcess(){
    //метод отвечающий за начало игрового процесса
  }
  ///<summary>
  ///Метод генерации следующей фигуры и установка новой текущей фигуры
  ///</summary>
  public void generateNextFigure(){
    /*Метод ссылается на класс Figure и выполняет две функции:
    установка текущей фигуры, которая появилась и падает;
    установка следующей фигуры, которая будет после текущей;*/
  }
  ///<summary>
  ///Метод анализа игрового поля
  ///</summary>
  private void analysGameField(){
    /*метод анализирует игровое поле и удаляет
    линию из блоков (если игру можно продолжить), 
    или же сообщает что игра закончилась*/
  }
  ///<summary>
  ///Удаление строки блоков
  ///</summary>
  ///<param name="indexString">Массив индексов строк</param>
  private void deleteLineBlock(int[] indexString){
    //удаляет строку(-и) по номеру, если они заполненны
    //а также опускает другие блоки на линию ниже
  }
  ///<summary>
  ///Метод изменения текущей скорости игры
  ///</summary>
  private void changeSpeedGame(){
    //метод изменения скорости игры в зависимости
    //от количества уничтоженых линий
  }
  ///<summary>
  ///Метод расчёта количества очков
  ///</summary>
  private void pointsCalculation(){
    /*метод, отвечающий за расчёт количества
    очков, в зависимости от уничтоженых линий
    и сложности игрового процесса*/
  }
  ///<summary>
  ///Метод завершения игрового процесса
  ///</summary>
  private void endGame(){
    //метод завершения игрового процесса
  }
  ///<summary>
  ///Другие методы, которые необходимы для корректной работы
  ///</summary>
  //другие методы класса
}
