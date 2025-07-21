using System;
using System.ComponentModel;

namespace CommandBindablePropertyGrid
{
    internal class FilterableObjectProxy : ICustomTypeDescriptor
    {
        private object _originalObject;
        private string _filter;

        public FilterableObjectProxy(object originalObject, string filter)
        {
            _originalObject = originalObject;
            _filter = filter ?? string.Empty;
        }

        public string Filter
        {
            get => _filter;
            set => _filter = value ?? string.Empty;
        }

        public object Value
        {
            get => _originalObject;
            set => _originalObject = value;
        }

        public AttributeCollection GetAttributes()
            => _originalObject is null ? null : TypeDescriptor.GetAttributes(_originalObject);

        public string GetClassName()
            => _originalObject is null ? null : TypeDescriptor.GetClassName(_originalObject);

        public string GetComponentName()
            => _originalObject is null ? null : TypeDescriptor.GetComponentName(_originalObject);

        public TypeConverter GetConverter()
            => _originalObject is null ? null : TypeDescriptor.GetConverter(_originalObject);

        public EventDescriptor GetDefaultEvent()
        {
            EventDescriptor defaultEvent = TypeDescriptor.GetDefaultEvent(_originalObject);
            
            // Apply filter to default event if filter is specified
            if (!string.IsNullOrEmpty(_filter) && defaultEvent != null)
            {
                if (!defaultEvent.Name.Contains(_filter))
                {
                    return null; // Filter out the default event if it doesn't match
                }
            }
            
            return defaultEvent;
        }

        public PropertyDescriptor GetDefaultProperty()
        {
            PropertyDescriptor defaultProperty = TypeDescriptor.GetDefaultProperty(_originalObject);
            
            // Apply filter to default property if filter is specified
            if (!string.IsNullOrEmpty(_filter) && defaultProperty != null)
            {
                if (!defaultProperty.Name.Contains(_filter))
                {
                    return null; // Filter out the default property if it doesn't match
                }
            }
            
            return defaultProperty;
        }

        public object GetEditor(Type editorBaseType)
            => _originalObject is null ? null : TypeDescriptor.GetEditor(_originalObject, editorBaseType);

        public EventDescriptorCollection GetEvents()
        {
            EventDescriptorCollection originalEvents = TypeDescriptor.GetEvents(_originalObject);
            
            // If no filter is specified, return all events
            if (string.IsNullOrEmpty(_filter))
            {
                return originalEvents;
            }

            EventDescriptorCollection filteredEvents = new EventDescriptorCollection(null);

            foreach (EventDescriptor eventDescriptor in originalEvents)
            {
                if (eventDescriptor.Name.Contains(_filter))
                {
                    filteredEvents.Add(eventDescriptor);
                }
            }

            return filteredEvents;
        }

        public EventDescriptorCollection GetEvents(Attribute[] attributes)
        {
            EventDescriptorCollection originalEvents = TypeDescriptor.GetEvents(_originalObject, attributes);
            
            // If no filter is specified, return all events
            if (string.IsNullOrEmpty(_filter))
            {
                return originalEvents;
            }

            EventDescriptorCollection filteredEvents = new EventDescriptorCollection(null);

            foreach (EventDescriptor eventDescriptor in originalEvents)
            {
                if (eventDescriptor.Name.Contains(_filter))
                {
                    filteredEvents.Add(eventDescriptor);
                }
            }

            return filteredEvents;
        }

        public PropertyDescriptorCollection GetProperties()
        {
            PropertyDescriptorCollection originalProperties = TypeDescriptor.GetProperties(_originalObject);
            
            // If no filter is specified, return all properties
            if (string.IsNullOrEmpty(_filter))
            {
                return originalProperties;
            }

            PropertyDescriptorCollection filteredProperties = new PropertyDescriptorCollection(null);

            foreach (PropertyDescriptor prop in originalProperties)
            {
                if (prop.Name.Contains(_filter))
                {
                    filteredProperties.Add(prop);
                }
            }

            return filteredProperties;
        }

        public PropertyDescriptorCollection GetProperties(Attribute[] attributes)
        {
            PropertyDescriptorCollection originalProperties = TypeDescriptor.GetProperties(_originalObject, attributes);
            
            // If no filter is specified, return all properties
            if (string.IsNullOrEmpty(_filter))
            {
                return originalProperties;
            }

            PropertyDescriptorCollection filteredProperties = new PropertyDescriptorCollection(null);

            foreach (PropertyDescriptor prop in originalProperties)
            {
                if (prop.Name.Contains(_filter))
                {
                    filteredProperties.Add(prop);
                }
            }

            return filteredProperties;
        }

        public object GetPropertyOwner(PropertyDescriptor pd)
            => _originalObject;
    }

    //// Then you would create a TypeDescriptionProvider to use this FilterableObjectProxy
    //public class FilterableTypeDescriptionProvider : TypeDescriptionProvider
    //{
    //    private string _filter;

    //    public FilterableTypeDescriptionProvider(string filter = "")
    //    {
    //        _filter = filter;
    //    }

    //    public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance)
    //    {
    //        return new FilterableObjectProxy(instance, _filter);
    //    }
    //}
}
