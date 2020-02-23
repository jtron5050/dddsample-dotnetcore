
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Domain.Shared;

namespace DDDSample.Domain.Model.Location
{
    public class UNLocode : ValueObject
    {
        private const string LOCODE_REGEX = "^[a-zA-Z]{2} [a-zA-Z2-9]{3}$";

        public string Locode { get; private set; }

        public UNLocode(string locode)
        {
            if (string.IsNullOrWhiteSpace(locode))
                throw new ArgumentException("Locode cannot be null or whitespace");
            Regex regex = new Regex(LOCODE_REGEX);
            if (!regex.IsMatch(locode))
                throw new ArgumentException("Locode format is invalid. Expected two letters, a space, then three letters or numbers(2-9)");
            Locode = locode;
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Locode;
        }
    }
}