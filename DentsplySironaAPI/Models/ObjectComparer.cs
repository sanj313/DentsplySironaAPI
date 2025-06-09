namespace DentsplySironaAPI.Models
{
    public static class ObjectComparer
    {
        public static Dictionary<string, (object? OldValue, object? NewValue)> GetChangedFields(object before, object after)
        {
            var changes = new Dictionary<string, (object?, object?)>();
            if (before == null || after == null) return changes;

            var type = before.GetType();
            //foreach (var prop in type.GetProperties())
            foreach (var prop in type.GetProperties())   
            {
                if (prop.GetIndexParameters().Length == 0)
                {
                    var oldValue = prop.GetValue(before);
                    var newValue = prop.GetValue(after);
                    if (!Equals(oldValue, newValue))
                    {
                        changes[prop.Name] = (oldValue, newValue);
                    }
                }
                  
            }

            return changes;
        }
    }
    }
