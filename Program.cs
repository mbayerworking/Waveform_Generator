using System;
using WaveformGenerator;


WaveformService waveformService = new();
double[] outputArray = new double[100];
for(int i = 0; i < outputArray.Length; i++){outputArray[i] = i;};
waveformService.WaveformGenerator += (double[] output) => Array.ForEach(output, Console.WriteLine);
waveformService.GenerateWaveform(
    60,1,0,(x,m,b) => outputArray.Select(i => m*Math.Sin(Math.PI*(i * x)/180)+b).ToArray()
);
