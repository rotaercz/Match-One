namespace Entitas {
    public partial class Entity {
        public ResourceComponent resource { get { return (ResourceComponent)GetComponent(ComponentIds.Resource); } }

        public bool hasResource { get { return HasComponent(ComponentIds.Resource); } }

        public Entity AddResource(string newName) {
            var componentPool = GetComponentPool(ComponentIds.Resource);
            var component = (ResourceComponent)(componentPool.Count > 0 ? componentPool.Pop() : new ResourceComponent());
            component.name = newName;
            return AddComponent(ComponentIds.Resource, component);
        }

        public Entity ReplaceResource(string newName) {
            var componentPool = GetComponentPool(ComponentIds.Resource);
            var component = (ResourceComponent)(componentPool.Count > 0 ? componentPool.Pop() : new ResourceComponent());
            component.name = newName;
            ReplaceComponent(ComponentIds.Resource, component);
            return this;
        }

        public Entity RemoveResource() {
            return RemoveComponent(ComponentIds.Resource);;
        }
    }

    public partial class Matcher {
        static IMatcher _matcherResource;

        public static IMatcher Resource {
            get {
                if (_matcherResource == null) {
                    var matcher = (Matcher)Matcher.AllOf(ComponentIds.Resource);
                    matcher.componentNames = ComponentIds.componentNames;
                    _matcherResource = matcher;
                }

                return _matcherResource;
            }
        }
    }
}
