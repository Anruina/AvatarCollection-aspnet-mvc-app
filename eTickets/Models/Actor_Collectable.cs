namespace AvatarCollections.Models
{
    public class Actor_Collectable
    {
        public int CollectableID { get; set; }
        public Collectable Collectable { get; set; }
        public int ActorID { get; set; }
        public Actor Actor { get; set; }

        //relationship

    }
}
