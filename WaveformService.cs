namespace WaveformGenerator
{
    public class WaveformService
    {
        public Action<double[]> WaveformGenerator;

        public void GenerateWaveform(double frequency, double amplitude, double phase, Func<double,double,double,double[]> calculation)
        {
            WaveformGenerator(calculation(frequency, amplitude, phase));
        }
    }
}