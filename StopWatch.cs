using System;


//Design a class called Stopwatch.The job of this class is to simulate a stopwatch. It should
//provide two methods: Start and Stop. We call the start method first, and the stop method next.
//Then we ask the stopwatch about the duration between start and stop. Duration should be a
//value in TimeSpan. Display the duration on the console.

//We should also be able to use a stopwatch multiple times. So we may start and stop it and then
//start and stop it again. Make sure the duration value each time is calculated properly.

//We should not be able to start a stopwatch twice in a row (because that may overwrite the initial
//start time). So the class should throw an InvalidOperationException if its started twice.

//Educational tip: The aim of this exercise is to make you understand that a class should be
//always in a valid state.We use encapsulation and information hiding to achieve that.The class
//should not reveal its implementation detail.It only reveals a little bit, like a blackbox.From the
//outside, you should not be able to misuse a class because you shouldn’t be able to see the
//implementation detail.

namespace Lecture15Exercise
{
    class StopWatch
    {
        private DateTime _Started;
        private DateTime _Stopped;
        private bool _isRunning = false;

        public void Start()
        {
            if (_isRunning)
                throw new InvalidOperationException("Stopwatch is already running. It must be stopped first.");
            _Started = DateTime.Now;
            _isRunning = true;
        }

        public void Stop()
        {
            if (!_isRunning)
                throw new InvalidOperationException("Stopwatch is not started, so can not be stopped.");
            _Stopped = DateTime.Now;
            _isRunning = false;

        }

        public TimeSpan GetDuration()
        {
            if (_isRunning)
                throw new InvalidOperationException("Stopwatch is currently running, duration can not be calculated.");
            return _Stopped - _Started;
        }

        public bool GetStatus() => _isRunning;
    }
}