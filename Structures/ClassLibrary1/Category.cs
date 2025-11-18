public struct Categroy
{
    private int _categoryID;
    private string _categoryName;
    public Categroy(int categoryID,string categoryName)
    {
        _categoryID = categoryID;
        _categoryName = categoryName;
    }

    public int CategoryID
    {
        set
        {
            if(value >=1 && value <= 100)
            {
                _categoryID  = value;
            }
        }
        get
        {
            return _categoryID;
        }
    }
    public string CategroyName
    {
        set
        {
            if (value.Length <= 40){
             _categoryName = value;   
            }
        }
        get
        {
            return _categoryName;
        }
    }
    public int GetCategroyNameLength()
    {
        return this._categoryName.Length;
    }
}