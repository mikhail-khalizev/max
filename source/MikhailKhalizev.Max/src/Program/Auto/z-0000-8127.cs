using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("f252a3cf-b08f-424a-99c8-cca4eaa8dc3c")]
        public void Method_0000_8127()
        {
            ii(0x8127, 4);    enterw(0x8, 0);                           /* enter 0x8, 0x0 */
            ii(0x812b, 5);    mov(memw_a16[ss, bp - 0x4], 0x47b2);      /* mov word [bp-0x4], 0x47b2 */
            ii(0x8130, 5);    mov(memw_a16[ss, bp - 0x2], 0x35f);       /* mov word [bp-0x2], 0x35f */
            ii(0x8135, 3);    mov(memw_a16[ss, bp - 0x6], ds);          /* mov [bp-0x6], ds */
            ii(0x8138, 5);    cmp(memw_a16[ds, 0xe70], 0);              /* cmp word [0xe70], 0x0 */
            ii(0x813d, 2);    if(jgew(0x8146, 0x7)) goto l_0x8146;      /* jge 0x8146 */
            ii(0x813f, 3);    pushw(0x1190);                            /* push 0x1190 */
            ii(0x8142, 3);    callw(0x95a8, 0x1463);                    /* call 0x95a8 */
            ii(0x8145, 1);    popw(bx);                                 /* pop bx */
        l_0x8146:
            ii(0x8146, 5);    cmp(memw_a16[ds, 0xe70], 0);              /* cmp word [0xe70], 0x0 */
            ii(0x814b, 2);    if(jgew(0x8153, 0x6)) goto l_0x8153;      /* jge 0x8153 */
            ii(0x814d, 2);    pushw(-0x8 /* 0xf8 */);                   /* push 0xfff8 */
            ii(0x814f, 3);    callw(0x589d, -0x28b5);                   /* call 0x589d */
            ii(0x8152, 1);    popw(bx);                                 /* pop bx */
        l_0x8153:
            ii(0x8153, 3);    mov(ax, memw_a16[ds, 0xc26]);             /* mov ax, [0xc26] */
            ii(0x8156, 3);    mov(memw_a16[ss, bp - 0x2], ax);          /* mov [bp-0x2], ax */
            ii(0x8159, 1);    pushw(ds);                                /* push ds */
            ii(0x815a, 3);    pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x815d, 2);    pushw(0);                                 /* push 0x0 */
            ii(0x815f, 3);    callw_a16_far_ind(ss, bp - 0x4);          /* call far word [bp-0x4] */
            ii(0x8162, 3);    mov(ax, memw_a16[ss, bp - 0x6]);          /* mov ax, [bp-0x6] */
            ii(0x8165, 6);    mov(memw_a16[ds, 0x42], 0x9fa);           /* mov word [0x42], 0x9fa */
            ii(0x816b, 3);    mov(memw_a16[ds, 0x44], ax);              /* mov [0x44], ax */
            ii(0x816e, 1);    leavew();                                 /* leave */
            ii(0x816f, 1);    retw();                                   /* ret */
        }
    }
}
