using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Period_to_Frequency_vice_versa
{
    public class Period_Frequency_Converter
    {

        private Dictionary<string, double> timeUnits = new Dictionary<string, double>
        {
            { "s", 1.0 },          // Seconds
            { "ms", 1e-3 },        // Milliseconds
            { "μs", 1e-6 },        // Microseconds
            { "ns", 1e-9 },        // Nanoseconds
            { "ps", 1e-12 },       // Picoseconds
         };

        private Dictionary<string, double> frequencyUnits = new Dictionary<string, double>
        {
            { "Hz", 1.0 },       // Hertz
            { "kHz", 1e3 },     // Kilohertz
            { "MHz", 1e6 },     // Megahertz
            { "GHz", 1e9 },     // Gigahertz
            { "THz", 1e12 },    // Terahertz
        };
        public double PeriodToFrequency(double value, string periodUnit, string frequencyUnit)
        {
            if (value == 0)
            {
                throw new ArgumentException("Value cannot be zero.");
            }

            if (!timeUnits.ContainsKey(periodUnit) || !frequencyUnits.ContainsKey(frequencyUnit))
            {
                throw new ArgumentException("Invalid units.");
            }

            double periodInSeconds = value * timeUnits[periodUnit];
            double frequency = 1.0 / periodInSeconds;
            double result = frequency / frequencyUnits[frequencyUnit];

            return result;
        }

        public double FrequencyToPeriod(double value, string frequencyUnit, string periodUnit)
        {
            if (value == 0)
            {
                throw new ArgumentException("Value cannot be zero.");
            }

            if (!frequencyUnits.ContainsKey(frequencyUnit) || !timeUnits.ContainsKey(periodUnit))
            {
                throw new ArgumentException("Invalid units.");
            }

            double frequencyInHertz = value * frequencyUnits[frequencyUnit];
            double period = 1.0 / frequencyInHertz;
            double result = period / timeUnits[periodUnit];

            return result;
        }
    }
}
