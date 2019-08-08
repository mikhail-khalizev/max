using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("abcdb763-c5e2-4097-94e3-d3a3c1699e74")]
        public void Method_0014_b31d()
        {
            ii(0x14_b31d, 3); mov(al, memb_a16[ss, bp + 0x16]);         /* mov al, [bp+0x16] */
            ii(0x14_b320, 2); cmp(al, 0xd);                             /* cmp al, 0xd */
            ii(0x14_b322, 2); if(jzw(0x14_b371, 0x4d)) goto l_0x14_b371; /* jz 0xb371 */
            ii(0x14_b324, 2); cmp(al, 0xc);                             /* cmp al, 0xc */
            ii(0x14_b326, 2); if(jzw(0x14_b371, 0x49)) goto l_0x14_b371; /* jz 0xb371 */
            ii(0x14_b328, 2); sub(al, 0x2);                             /* sub al, 0x2 */
            ii(0x14_b32a, 2); cmp(al, 0x3);                             /* cmp al, 0x3 */
            ii(0x14_b32c, 2); if(jbw(0x14_b331, 0x3)) goto l_0x14_b331; /* jb 0xb331 */
        l_0x14_b32e:
            ii(0x14_b32e, 3); if(jmpw_func(0x14_a81c, -0xb15)) return;  /* jmp 0xa81c */
        l_0x14_b331:
            ii(0x14_b331, 3); callw(0x14_ab18, -0x81c);                 /* call 0xab18 */
            ii(0x14_b334, 2); if(jbw(0x14_b32e, -0x8)) goto l_0x14_b32e; /* jb 0xb32e */
            ii(0x14_b336, 3); mov(cx, memw_a16[ss, bp + 0x14]);         /* mov cx, [bp+0x14] */
            ii(0x14_b339, 4); cmp(cx, memw_a16[ds, 0xe]);               /* cmp cx, [0xe] */
            ii(0x14_b33d, 2); if(jaw(0x14_b365, 0x26)) goto l_0x14_b365; /* ja 0xb365 */
            ii(0x14_b33f, 4); mov(di, memw_a16[ds, 0xa]);               /* mov di, [0xa] */
            ii(0x14_b343, 3); mov(memw_a16[ds, bx + 0x12], di);         /* mov [bx+0x12], di */
            ii(0x14_b346, 3); mov(si, memw_a16[ss, bp + 0x12]);         /* mov si, [bp+0x12] */
            ii(0x14_b349, 1); pushw(ds);                                /* push ds */
            ii(0x14_b34a, 3); mov(ds, memw_a16[ss, bp + 0x4]);          /* mov ds, [bp+0x4] */
            ii(0x14_b34d, 2); rep_a16(() => movsb_a16());               /* rep movsb */
            ii(0x14_b34f, 1); popw(ds);                                 /* pop ds */
            ii(0x14_b350, 3); callw(0x14_a893, -0xac0);                 /* call 0xa893 */
            ii(0x14_b353, 3); mov(cx, memw_a16[ss, bp + 0x14]);         /* mov cx, [bp+0x14] */
            ii(0x14_b356, 3); mov(es, memw_a16[ss, bp + 0x4]);          /* mov es, [bp+0x4] */
            ii(0x14_b359, 3); mov(di, memw_a16[ss, bp + 0x12]);         /* mov di, [bp+0x12] */
            ii(0x14_b35c, 4); mov(si, memw_a16[ds, 0xa]);               /* mov si, [0xa] */
            ii(0x14_b360, 2); rep_a16(() => movsb_a16());               /* rep movsb */
            ii(0x14_b362, 3); if(jmpw_func(0x14_b03d, -0x328)) return;  /* jmp 0xb03d */
        l_0x14_b365:
            ii(0x14_b365, 5); mov(memw_a16[ss, bp + 0x16], 0x8);        /* mov word [bp+0x16], 0x8 */
            ii(0x14_b36a, 4); or(memb_a16[ss, bp + 0x26], 0x1);         /* or byte [bp+0x26], 0x1 */
            ii(0x14_b36e, 3); if(jmpw_func(0x14_a838, -0xb39)) return;  /* jmp 0xa838 */
        l_0x14_b371:
            ii(0x14_b371, 2); jmpw(0x14_b365, -0xe); goto l_0x14_b365;  /* jmp 0xb365 */
        }
    }
}
