public enum KeyState : byte
{
    Still = 0x0,            ///00000000  0
    Runing = 0x1,           ///00000001  1
    WalkBack = 0x2,         ///00000010  2
    RuningBack = 0x3,       ///00000011  3
    WalkStrafeLeft = 0x4,   ///00000101  4
    WalkStrafeRight = 0x5,  ///00000110  5
    RunStrafeLeft = 0x6,    ///00001010  6
    RunStrafeRight = 0x7,   ///00001011  7
    Walking = 0x8,          ///00001111  8
}
