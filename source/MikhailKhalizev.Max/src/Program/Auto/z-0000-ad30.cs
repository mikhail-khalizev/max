using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("446d50f1-830b-4e90-b8b1-eaa087c79e87")]
        public void Method_0000_ad30()
        {
            ii(0xad30, 3);    callw(0x9cc4, -0x106f);                   /* call 0x9cc4 */
            ii(0xad33, 1);    pushw(ax);                                /* push ax */
            ii(0xad34, 3);    callw(0x60cb, -0x4c6c);                   /* call 0x60cb */
            ii(0xad37, 2);    xor(ax, ax);                              /* xor ax, ax */
            ii(0xad39, 1);    popw(cx);                                 /* pop cx */
            ii(0xad3a, 2);    if(jcxzw(0xad3d, 0x1)) goto l_0xad3d;     /* jcxz 0xad3d */
            ii(0xad3c, 1);    dec(ax);                                  /* dec ax */
        l_0xad3d:
            ii(0xad3d, 1);    popw(di);                                 /* pop di */
            ii(0xad3e, 1);    popw(si);                                 /* pop si */
            ii(0xad3f, 1);    retw();                                   /* ret */
        }
    }
}
