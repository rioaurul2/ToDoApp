namespace DesignPatternsPractice.Behavioral.Mediator
{
    public class DialogMediator : IMediator
    {
        private readonly Button _button;
        private readonly TextBox _textBox;
        private readonly Checkbox _checkbox;

        public DialogMediator(Button button, TextBox textBox, Checkbox checkbox)
        {
            _button = button;
            _textBox = textBox;
            _checkbox = checkbox;
        }

        public void Notify(object sender, string ev)
        {
            if (sender == _button && ev == "Click")
            {
                if (_checkbox.IsChecked)
                {
                    _textBox.ShowMessage("Trimitem datele...");
                }
                else
                {
                    _textBox.ShowMessage("Te rog acceptă termenii!");
                }
            }
            else if (sender == _checkbox && ev == "Toggle")
            {
                _textBox.Clear();
            }
        }
    }
}
