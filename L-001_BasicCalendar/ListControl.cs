using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            int _countRow = 5;
            int _countCol = 7;
            int _countAll = _countRow * _countCol;

            var _listDays = Enumerable.Range(1, _countAll).ToArray();
            string _drawText = "";

            for (int _countDay = 0; _countDay < _countAll; _countDay++)
            {
                int _checkDay = _countDay % _countCol;

                if (_checkDay == 0)
                {
                    _drawText += "\n";
                }

                _drawText += _listDays[_countDay] + " ";
            }

            Console.WriteLine(_drawText);
        }
    }
}
