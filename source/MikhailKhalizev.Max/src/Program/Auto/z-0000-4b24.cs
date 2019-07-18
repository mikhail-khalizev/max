using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("5bc46bdd-6cbd-453c-abc6-9f555b0f7e5b")]
        public void Method_0000_4b24()
        {
            ii(0x4b24, 1);    pushw(es);                                /* push es */
            ii(0x4b25, 3);    adc(memb_a16[ds, di], 0x4);               /* adc byte [di], 0x4 */
            ii(0x4b28, 3);    add(memb_a16[ds, di + 0x1a], dh);         /* add [di+0x1a], dh */
            ii(0x4b2b, 4);    mov(memw_a16[ds, 0x1554], di);            /* mov [0x1554], di */
            ii(0x4b2f, 4);    mov(memw_a16[ds, 0x1556], es);            /* mov [0x1556], es */
            ii(0x4b33, 2);    mov(ax, es);                              /* mov ax, es */
            ii(0x4b35, 2);    or(ax, di);                               /* or ax, di */
            ii(0x4b37, 2);    if(jzw(0x4b45, 0xc)) goto l_0x4b45;       /* jz 0x4b45 */
            ii(0x4b39, 6);    mov(memw_a16[es, di + 0x8], 0x1550);      /* mov word [es:di+0x8], 0x1550 */
            ii(0x4b3f, 6);    mov(memw_a16[es, di + 0xa], 0x1a2);       /* mov word [es:di+0xa], 0x1a2 */
        l_0x4b45:
            ii(0x4b45, 1);    pushw(ds);                                /* push ds */
            ii(0x4b46, 1);    popw(es);                                 /* pop es */
            ii(0x4b47, 3);    mov(di, 0x1550);                          /* mov di, 0x1550 */
            ii(0x4b4a, 1);    popw(ds);                                 /* pop ds */
            ii(0x4b4b, 1);    popw(ax);                                 /* pop ax */
            ii(0x4b4c, 1);    popw(si);                                 /* pop si */
            ii(0x4b4d, 1);    popw(dx);                                 /* pop dx */
            ii(0x4b4e, 1);    popw(ax);                                 /* pop ax */
            ii(0x4b4f, 1);    iretw(); return;                          /* iretw */
        }
    }
}
