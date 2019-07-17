using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("14751680-3c92-4ef9-a3b2-3c13ab33d7ab")]
        public void Method_0000_9b96()
        {
            ii(0x9b96, 3);    callw(0x9b48, -0x51);                     /* call 0x9b48 */
            ii(0x9b99, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x9b9b, 2);    if(jnzw(0x9ba0, 0x3)) goto l_0x9ba0;      /* jnz 0x9ba0 */
            ii(0x9b9d, 3);    callw(0x8c70, -0xf30);                    /* call 0x8c70 */
        l_0x9ba0:
            ii(0x9ba0, 3);    mov(dx, 0x12cc);                          /* mov dx, 0x12cc */
            ii(0x9ba3, 2);    mov(ah, 0x25);                            /* mov ah, 0x25 */
            ii(0x9ba5, 3);    mov(al, memb_a16[ds, 0x34]);              /* mov al, [0x34] */
            ii(0x9ba8, 1);    pushw(cs);                                /* push cs */
            ii(0x9ba9, 1);    popw(ds);                                 /* pop ds */
            ii(0x9baa, 4);    mov(memw_a16[ds, 0x12ca], cs);            /* mov [0x12ca], cs */
            ii(0x9bae, 2);    @int(0x21);                              /* int 0x21 */
            ii(0x9bb0, 1);    pushw(ss);                                /* push ss */
            ii(0x9bb1, 1);    popw(ds);                                 /* pop ds */
            ii(0x9bb2, 1);    retw();                                   /* ret */
        }
    }
}
