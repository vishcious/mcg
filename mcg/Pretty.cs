using System;

namespace mcg {
    public static class Pretty {
        public static string Prettify(Int64 input) {
            return input switch {
                var x when x >= 1000000000000 => PrettifyTrillion(input),
                var x when x >= 1000000000 => PrettifyBillion(input),
                var x when x >= 1000000 => PrettifyMillion(input),
                _ => input.ToString()
            };
        }

        public static string PrettifyTrillion(Int64 input) {
            var result = PrettifyAfterDigits(input, 12);
            if(string.IsNullOrEmpty(result)) {
                return "";
            }
            return result + "T";
        }

        public static string PrettifyBillion(Int64 input) {
            var result = PrettifyAfterDigits(input, 9);
            if(string.IsNullOrEmpty(result)) {
                return "";
            }
            return result + "B";
        }

        public static string PrettifyMillion(Int64 input) {
            var result = PrettifyAfterDigits(input, 6);
            if(string.IsNullOrEmpty(result)) {
                return "";
            }
            return result + "M";
        }

        public static string PrettifyAfterDigits(Int64 input, Int64 numberOfDigitsToSkip) {
            (var trillions, var remainder) = GetDigitsAfter(input, numberOfDigitsToSkip);
            if(string.IsNullOrEmpty(trillions)) {
                return "";
            } else {
                (var before, _) = GetDigitsAfter(remainder, numberOfDigitsToSkip - 1);
                if(string.IsNullOrEmpty(before)) {
                    return trillions;
                } else {
                    return $"{trillions}.{before}";
                }
            }
        }

        public static (string digits, Int64 remainder) GetDigitsAfter(Int64 number, Int64 numberOfDigitsToSkip) {
            var divideBy = Convert.ToInt64(Math.Pow(10, numberOfDigitsToSkip));
            var quotient = Math.DivRem(number, divideBy, out var remainder);
            return (quotient == 0 ? "" : quotient.ToString(), remainder);
        }
    }
}