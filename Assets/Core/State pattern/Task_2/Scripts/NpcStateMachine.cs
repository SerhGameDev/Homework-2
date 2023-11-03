using System.Collections.Generic;
public class NpcStateMachine
{
    public NpcStateMachine(List<StateNpc> listStates) => SetListStates(listStates);

    private List<StateNpc> _listStates;
    private int _currentStateIndex = 0;
    private StateNpc _currentState;
    
    public void UpdateState() => _currentState.Update();
    public void SwitchToNextState()
    {
        _currentState = null;
        _currentStateIndex = (_currentStateIndex + 1) % _listStates.Count;
        SetState(_currentStateIndex);
    }

    private void SetState(int index)
    {
        if (IsValidStateIndex(index))
        {
            _currentStateIndex = index;
            _currentState = _listStates[_currentStateIndex];
            _currentState.Start();
        }
    }
    private bool IsValidStateIndex(int index) => index >= 0 && index < _listStates.Count; 
    private void SetListStates(List<StateNpc> listStates)
    {
        _listStates = listStates;
        _listStates.ForEach(states => states.Initializ(this));
        SetState(0);
    }
}
