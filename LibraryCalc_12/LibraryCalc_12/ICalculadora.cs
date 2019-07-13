namespace LibraryCalc_12
{
    /// <summary>
    /// Interface usada para operações matemáticas básicas 
    /// </summary>
    interface ICalculadora
    {
        /// <summary>
        /// Soma de dois números
        /// </summary>
        /// <param name="x">primeiro número</param>
        /// <param name="y">segundo número</param>
        /// <returns>Soma de dois números</returns>
        int Soma(int x, int y);

        /// <summary>
        /// Soma de dois números
        /// </summary>
        /// <param name="x">primeiro número</param>
        /// <param name="y">segundo número</param>
        /// <param name="z">terceriro número</param>
        /// <returns>Soma de dois números</returns>
        int Soma(int x, int y, int z);

        /// <summary>
        /// Subitração de dois números
        /// </summary>
        /// <param name="x">primeiro número</param>
        /// <param name="y">segundo número</param>
        /// <returns>Subitração de dois números</returns>
        int Subtracao(int x, int y);

        /// <summary>
        /// Subitração de dois números
        /// </summary>
        /// <param name="x">primeiro número</param>
        /// <param name="y">segundo número</param>
        /// <returns>Subitração de dois números</returns>
        int Subtracao(int x, int y, int z);

        /// <summary>
        /// Multiplicacao de dois números
        /// </summary>
        /// <param name="x">primeiro número</param>
        /// <param name="y">segundo número</param>
        /// <returns>Multiplicacao de dois números</returns>
        int Multiplicacao(int x, int y);

        /// <summary>
        /// Divisao de dois números
        /// </summary>
        /// <param name="x">primeiro número</param>
        /// <param name="y">segundo número</param>
        /// <returns>Divisao de dois números</returns>
        double Divisao(double x, double y);
    }
}
