namespace Music {
    // borrowed from the example in https://learn.microsoft.com/en-us/dotnet/api/system.console.beep?view=net-7.0
    enum Tone {
        C = 261,
        D = 294
    }

    struct Note {
        public Tone tone;
        public int duration;
    }
  
}