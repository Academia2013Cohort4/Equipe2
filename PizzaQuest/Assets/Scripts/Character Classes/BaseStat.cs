public class BaseStat {
	private int _baseValue;				//base value of stats
	private int _buffValue;				//amount of the buff to this stat
	private int _expToLevel;			//total amount of exp needed to raise the skill
	private float _LevelModifier;		//the modifier applied to the exp needed to raise the skill
	
	public BaseStat() {
		_baseValue = 0;
		_buffValue = 0;
		_LevelModifier = 1.1f;
		_expToLevel = 100;
	}
	
#region Basic Setters and getters
	//Basic Setters and getters
	public int BaseValue {
		get{ return _baseValue; }
		set{ _baseValue = value; }
	}
	
	public int BuffValue {
		get{ return _buffValue; }
		set{ _buffValue = value; }
	}
	
	
	public int ExpToLevel {
		get{ return _expToLevel; }
		set{ _expToLevel = value; }
	}
	
	
	public float LevelModifier {
		get{ return _LevelModifier; }
		set{ _LevelModifier = value; }
	}
#endregion

	private int CalculateExpToLevel() {
		return (int)(_expToLevel * _LevelModifier);
	}
	
	public void LevelUp () {
		_expToLevel = CalculateExpToLevel();
		_baseValue++;
	}
	
	public int AdjustedBaseValue {
		get{ return _baseValue + _buffValue; }
	}
}
