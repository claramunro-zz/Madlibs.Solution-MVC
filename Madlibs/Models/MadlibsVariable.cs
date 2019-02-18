namespace Madlibs.Models
{
    public class MadlibsVariable
    {
        private string _person1;
        private string _person2;
        private string _animal;
        private string _exclamation;
        private string _verb;
        private string _noun;

        public string GetPerson1()
        {
            return _person1;
        }

        public void SetPerson1(string newPerson1)
        {
            _person1 = newPerson1;
        }

        public string GetPerson2()
        {
            return _person2;
        }

        public void SetPerson2(string newPerson2)
        {
            _person2 = newPerson2;
        }

        public string GetAnimal()
        {
            return _animal;
        }

        public void SetAnimal(string newAnimal)
        {
            _animal = newAnimal;
        }

        public string GetExclamation()
        {
            return _exclamation;
        }

        public void SetExclamation(string newExclamation)
        {
            _exclamation = newExclamation;
        }

        public string GetVerb()
        {
            return _verb;
        }

        public void SetVerb(string newVerb)
        {
            _verb = newVerb;
        }

        public string GetNoun()
        {
            return _noun;
        }

        public void SetNoun(string newNoun)
        {
            _noun = newNoun;
        }
    }
}