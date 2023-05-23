namespace AlexanderCA.ProMenu.LoadBar
{
  using AlexanderCA.ProMenu.ToolsInspector;
  [System.Serializable]
  public class PrM_LoadGameInfo
  {

    [System.Serializable]
    public class Explicacion
    {
      public ExplicacionEspa�ol Espa�ol;
      public ExplicacionIngles English;
    }
    public Explicacion _language;

    #region LoadBar Explanation

    #region Spanish
    [System.Serializable]
    public class ExplicacionEspa�ol
    {
      public ExplicacionTotalEspa�ol Explicaci�n;
      public ExplicacionUsoEspa�ol Uso;
      public ExplicacionAdvertenciaEspa�ol Advertencia;
    }

    [System.Serializable]
    public class ExplicacionTotalEspa�ol
    {
        #if UNITY_EDITOR
        [PrM_BoxInspector("En este apartado, seg�n lo que quieras, puedes personalizar un nivel de Carga o indicar que ese nivel, al empezar, tendr� una pantalla de carga. La idea es que cada vez que cambies de nivel salte un pantalla de carga si se ha seleccionado previamente. En la personalizaci�n tendr�s que indicar si lo quieres solo con un temporizador o que se muestre con una barra de carga. El contenido del nivel lo tendr�is que hacer vosotros y tambi�n indicar que tendr� que hacer una vez  se haya cargado todo: que se quite ese nivel autom�ticamente o mediante la acci�n de un bot�n/tecla/joystick \n\n Uso: Si quieres que ese nivel tenga una pantalla de carga, activa la opci�n, pero si quieres que el nivel sea la pantalla de carga, entonces activa la opci�n que m�s te guste, que sea con barra o autom�ticamente y tambi�n como quieres salir de la pantalla una vez haya cargado, eligiendo la opci�n autom�tica o mediante la activaci�n de una tecla m�s el extra de que salte un sonido o un objeto <Panel> para indicar que ya se ha cargado. Solo tienes que arrastrar cada cosa a su hueco. \n\n Advertencia: El contenido del nivel, texto, im�genes, animaciones y otros efectos ser�n trabajo del propio usuario. Lo �nico que ofrece este sistema es un temporizador interno que calcula el tiempo que tarda en renderizar el nivel que se jugar� y una vez terminado, que salte la opci�n que hayas escogido, el autom�tico o con bot�n/tecla/joystick En el caso de que se quiera utilizar la opci�n de pantalla de carga fuera de las opciones que ofrece el sistema, le pongo las dos v�as externas: acceder funcion Mediante bot�n propio del usuario o cuando pase X evento ajeno al sistema proporcionado, cargue la pantalla de cargar \n\n 1)Mediante bot�n propio: Boton> On Click> colocar objeto que tenga la scritp SC_MenuProPantallCarga> en Sin funci�n colocar SC_MenuProPantallCarga> BotonCargarPantallaButtonLoadingScreen \n2)Cuando pase X evento ajeno : Si se quiere llamar la funci�n de forma externa para que se ejecute cuando sea en una scritp del propio usuario y externo al sistema Referenciar \n Scritpt ej: Public SC_MenuProPantallCarga SC_MP siguiente:> despu�s en funci�n colocar lo SC_MP.m_nivel = <El nivel deseado que se cargara para jugar> y en el siguiente l�nea de codigo SC_MP.CargarPantallaLoadingScreen(); \n***Por la forma en que se ha tenido de programar, la correcta visualizaci�n de la carga con barra se ver� �ptima cuando est� el juego compilado, de mientras dentro del proyecto se puede ver, que se queda pillado y luego carga de golpe", UnityEditor.MessageType.Info)]
        public bool _a;
        #endif
    }

    [System.Serializable]
    public class ExplicacionUsoEspa�ol
    {
        #if UNITY_EDITOR
        [PrM_BoxInspector("Uso: Si quieres que ese nivel tenga una pantalla de carga, activa la opci�n, pero si quieres que el nivel sea la pantalla de carga, entonces activa la opci�n que m�s te guste, que sea con barra o autom�ticamente y tambi�n como quieres salir de la pantalla una vez haya cargado, eligiendo la opci�n autom�tica o mediante la activaci�n de una tecla m�s el extra de que salte un sonido o un objeto <Panel> para indicar que ya se ha cargado. Solo tienes que arrastrar cada cosa a su hueco.", UnityEditor.MessageType.Warning)]
        public bool _a;
        #endif
    }


    [System.Serializable]
    public class ExplicacionAdvertenciaEspa�ol
    {
        #if UNITY_EDITOR
        [PrM_BoxInspector("Advertencia: El contenido del nivel, texto, im�genes, animaciones y otros efectos ser�n trabajo del propio usuario. Lo �nico que ofrece este sistema es un temporizador interno que calcula el tiempo que tarda en renderizar el nivel que se jugar� y una vez terminado, que salte la opci�n que hayas escogido, el autom�tico o con bot�n/tecla/joystick En el caso de que se quiera utilizar la opci�n de pantalla de carga fuera de las opciones que ofrece el sistema, le pongo las dos v�as externas: acceder funcion Mediante bot�n propio del usuario o cuando pase X evento ajeno al sistema proporcionado, cargue la pantalla de cargar\n\n 1)Mediante bot�n propio: Boton> On Click> colocar objeto que tenga la scritp SC_MenuProPantallCarga> en Sin funci�n colocar SC_MenuProPantallCarga> BotonCargarPantallaButtonLoadingScreen\n 2)Cuando pase X evento ajeno : Si se quiere llamar la funci�n de forma externa para que se ejecute cuando sea en una scritp del propio usuario y externo al sistema Referenciar Scritpt ej: Public SC_MenuProPantallCarga SC_MP siguiente:> despu�s en funci�n colocar lo SC_MP.m_nivel = <El nivel deseado que se cargara para jugar> y en el siguiente l�nea de codigo SC_MP.CargarPantallaLoadingScreen(); \n***Por la forma en que se ha tenido de programar, la correcta visualizaci�n de la carga con barra se ver� �ptima cuando est� el juego compilado, de mientras dentro del proyecto se puede ver, que se queda pillado y luego carga de golpe", UnityEditor.MessageType.Error)]
        public bool _a;
        #endif
    }
    #endregion

    #region English
    [System.Serializable]
    public class ExplicacionIngles
    {
      public ExplicacionTotalIngles Explanation;
      public ExplicacionUsoIngles Use;
      public ExplicacionAdverteciaIngles Warning;
    }
    [System.Serializable]
    public class ExplicacionTotalIngles
    {
        #if UNITY_EDITOR
        [PrM_BoxInspector("In this section, depending on what you want, you can customize a Loading level or indicate that this level will have a loading screen at the beginning. The idea is that every time you change levels a loading screen will appear if it has been previously selected. In the customization you will have to indicate if you want it only with a timer or that it is shown with a loading bar. You will have to do the content of the level and also indicate what you will have to do once everything has been loaded: remove that level automatically or through the action of a button / key / joystick. \n\n Use: If you want that level to have a loading screen, activate the option, but if you want the level to be the loading screen, then activate the option that you like the most, be it with a bar or automatically and also how you want to exit the screen once it has loaded, by choosing the automatic option or by activating a key plus the extra that a sound or a <Panel> object pops up to indicate that it has already been loaded. You just have to drag each thing into its slot. \n\n Warning: The content of the level, text, images, animations and other effects will be the user's own work The only thing that this system offers is an internal timer that calculates the time it takes to render the level that will be played and once finished, the option you have chosen will jump, the automatic or with button / key / joystick. In the event that you want to use the loading screen option outside of the options offered by the system, I put the two external ways: Using the user's own button or when X event occurs outside the provided system, load the loading screen \n\n 1) Button> On Click> place object that has the SC_MenuProPantallCarga script> in No function place SC_MenuProPantallCarga> BotonCargarPantallaButtonLoadingScreen \n2) If you want to call the function externally so that it is executed when it is in a user's own script and external to the system Reference Scritpt ex: Public SC_MenuProPantallCarga SC_MP :> then in function place the SC_MP.m_nivel = <The desired level that will be loaded to play > and in the following line of code SC_MP.CargarPantallaLoadingScreen ();\n ***Due to the way it has been programmed, the correct visualization of the load bar will look optimal when the game is compiled, while inside the project you can see that it gets caught and then loads suddenly", UnityEditor.MessageType.Info)]
        public bool _a;
        #endif
    }

    [System.Serializable]
    public class ExplicacionUsoIngles
    {
       #if UNITY_EDITOR
        [PrM_BoxInspector("Use: If you want that level to have a loading screen, activate the option, but if you want the level to be the loading screen, then activate the option that you like the most, be it with a bar or automatically and also how you want to exit the screen once it has loaded, by choosing the automatic option or by activating a key plus the extra that a sound or a <Panel> object pops up to indicate that it has already been loaded. You just have to drag each thing into its slot.", UnityEditor.MessageType.Warning)]
        public bool _a;
        #endif
    }
    [System.Serializable]
    public class ExplicacionAdverteciaIngles
    {
       #if UNITY_EDITOR
        [PrM_BoxInspector("Warning: The content of the level, text, images, animations and other effects will be the user's own work The only thing that this system offers is an internal timer that calculates the time it takes to render the level that will be played and once finished, the option you have chosen will jump, the automatic or with button / key / joystick. In the event that you want to use the loading screen option outside of the options offered by the system, I put the two external ways: Using the user's own button or when X event occurs outside the provided system, load the loading screen \n\n 1) Button> On Click> place object that has the SC_MenuProPantallCarga script> in No function place SC_MenuProPantallCarga> BotonCargarPantallaButtonLoadingScreen \n 2) If you want to call the function externally so that it is executed when it is in a user's own script and external to the system Reference Scritpt ex: Public SC_MenuProPantallCarga SC_MP :> then in function place the SC_MP.m_nivel = <The desired level that will be loaded to play > and in the following line of code SC_MP.CargarPantallaLoadingScreen (); \n***Due to the way it has been programmed, the correct visualization of the load bar will look optimal when the game is compiled, while inside the project you can see that it gets caught and then loads suddenly", UnityEditor.MessageType.Error)]
        public bool _a;
        #endif
    }
    #endregion

    #endregion

  }
}
