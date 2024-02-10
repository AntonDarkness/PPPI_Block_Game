public class Game
{
  private long tempRecord;
  private Figure nextFigure;
  private long timeGame;
  //другие параметры

  public Game(){
    //метод загрузки интерфейса для одиночной и многопользовательской игры
  }
  public void changeRecord(string newRecord){
    //метод изменения текущего рекорда
  }
  public void buttonExit(){
    //нажатие кнопки "Покинуть игру (сдаться)"
  }

  /*в этом классе также присутствуют также другие методы, которые
  отвечают за прорисовку фигур, анимацию. Для многопользовательской игры
  также предусмотрены методы работы с сервером*/
}
