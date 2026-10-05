namespace Testy_Cezara.Tests
{
    [TestClass]
    public sealed class Test1
    {
        [DataTestMethod]
        [DataRow("abc", 3, "def")]
        [DataRow("xyz", 3, "abc")]
        [DataRow("def", -3, "abc")]
        [DataRow("abc", 29, "def")]
        [DataRow("ab cd", 2, "cd ef")]
        public void Run_DlaPodanychDanych_ZwracaPoprawnieZaszyfrowanyTekst(string wejscie, int klucz, string oczekiwanyWynik)
        {
            string aktualnyWynik = Program.RunCeaser(wejscie, klucz);

            Assert.AreEqual(oczekiwanyWynik, aktualnyWynik);
        }
    }
}
