namespace DnD.Enums.Qualities
{
    /// <summary>
    /// Represents the particular quality state of an accessory/armor/weapon item.
    /// </summary>
    public enum ItemQualities
    {
        /// <summary>
        /// Represents an Item quality that is of type Dimensional.
        /// (PLAN: dimensional objects are 50% more powerful than normal counterparts BUT cannot be repaired)
        /// (When broken, the objects are forever destroyed and unusable) - NOT REPAIRABLE BY ANY MEANS!!!!!!!
        /// </summary>
        Dimensional,

        /// <summary>
        /// Represents an Item quality that is of type Borken. (lol)
        /// </summary>
        Broken,

        /// <summary>
        /// Represents an Item quality that is of type Inferior.
        /// </summary>
        Inferior,

        /// <summary>
        /// Represents an Item quality that is of type Normal.
        /// </summary>
        Normal,

        /// <summary>
        /// Represents an Item quality that is of type Magic.
        /// </summary>
        Magic,

        /// <summary>
        /// Represents an Item quality that is of type Rare.
        /// </summary>
        Rare,

        /// <summary>
        /// Represents an Item quality that is of type Unique.
        /// </summary>
        Unique,

        /// <summary>
        /// Represents an Item quality that is of type Set.
        /// </summary>
        Set,

        /// <summary>
        /// Represents an Item quality that is of type Legend.
        /// </summary>
        Legend
    }
}
