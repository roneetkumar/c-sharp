namespace exam_prep_console
{
    class ConvertArea
    {
        private double num1;
        public double Num1
        {
            get => num1;
            set => num1 = value;
        }
        public ConvertArea() { }
        public ConvertArea(double n1) => Num1 = n1;
        public double cmToIn() => (Num1 * 0.1550);
        public double mToYd() => (Num1 * 1.1960);
        public double hectarToAcre() => (Num1 * 2.4711);
        public double kmToMile() => (Num1 * 0.3861);
    }
}
