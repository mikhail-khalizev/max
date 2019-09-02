using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_d3ee-5b3c34a4")]
        public void /* sys */ Method_1018_d3ee()
        {
            ii(0x1018_d3ee, 1); push(ecx);                              /* push ecx */
            ii(0x1018_d3ef, 1); push(edx);                              /* push edx */
            ii(0x1018_d3f0, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1018_d3f2, 5); call(/* sys */ 0x1018_d6ec, 0x2f5);     /* call 0x1018d6ec */
            ii(0x1018_d3f7, 4); cmp(memd[ds, edx + 0x14], 0);           /* cmp dword [edx+0x14], 0x0 */
            ii(0x1018_d3fb, 2); if(jnz(0x1018_d423, 0x26)) goto l_0x1018_d423; /* jnz 0x1018d423 */
            ii(0x1018_d3fd, 3); mov(ah, memb[ds, edx + 0xd]);           /* mov ah, [edx+0xd] */
            ii(0x1018_d400, 3); test(ah, 2);                            /* test ah, 0x2 */
            ii(0x1018_d403, 2); if(jz(0x1018_d40e, 9)) goto l_0x1018_d40e; /* jz 0x1018d40e */
            ii(0x1018_d405, 7); mov(memd[ds, edx + 0x14], 0x86);        /* mov dword [edx+0x14], 0x86 */
            ii(0x1018_d40c, 2); jmp(0x1018_d423, 0x15); goto l_0x1018_d423; /* jmp 0x1018d423 */
        l_0x1018_d40e:
            ii(0x1018_d40e, 3); test(ah, 4);                            /* test ah, 0x4 */
            ii(0x1018_d411, 2); if(jz(0x1018_d41c, 9)) goto l_0x1018_d41c; /* jz 0x1018d41c */
            ii(0x1018_d413, 7); mov(memd[ds, edx + 0x14], 1);           /* mov dword [edx+0x14], 0x1 */
            ii(0x1018_d41a, 2); jmp(0x1018_d423, 7); goto l_0x1018_d423; /* jmp 0x1018d423 */
        l_0x1018_d41c:
            ii(0x1018_d41c, 7); mov(memd[ds, edx + 0x14], 0x1000);      /* mov dword [edx+0x14], 0x1000 */
        l_0x1018_d423:
            ii(0x1018_d423, 3); mov(eax, memd[ds, edx + 0x14]);         /* mov eax, [edx+0x14] */
            ii(0x1018_d426, 5); call(Definitions.sys_malloc, -0x2_244d); /* call 0x1016afde */
            ii(0x1018_d42b, 3); mov(memd[ds, edx + 8], eax);            /* mov [edx+0x8], eax */
            ii(0x1018_d42e, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1018_d430, 2); if(jnz(0x1018_d452, 0x20)) goto l_0x1018_d452; /* jnz 0x1018d452 */
            ii(0x1018_d432, 3); mov(cl, memb[ds, edx + 0xd]);           /* mov cl, [edx+0xd] */
            ii(0x1018_d435, 7); mov(memd[ds, edx + 0x14], 1);           /* mov dword [edx+0x14], 0x1 */
            ii(0x1018_d43c, 3); and(cl, 0xf8);                          /* and cl, 0xf8 */
            ii(0x1018_d43f, 3); lea(eax, memd[ds, edx + 0x18]);         /* lea eax, [edx+0x18] */
            ii(0x1018_d442, 3); mov(memb[ds, edx + 0xd], cl);           /* mov [edx+0xd], cl */
            ii(0x1018_d445, 2); mov(ch, cl);                            /* mov ch, cl */
            ii(0x1018_d447, 3); mov(memd[ds, edx + 8], eax);            /* mov [edx+0x8], eax */
            ii(0x1018_d44a, 3); or(ch, 4);                              /* or ch, 0x4 */
            ii(0x1018_d44d, 3); mov(memb[ds, edx + 0xd], ch);           /* mov [edx+0xd], ch */
            ii(0x1018_d450, 2); jmp(0x1018_d456, 4); goto l_0x1018_d456; /* jmp 0x1018d456 */
        l_0x1018_d452:
            ii(0x1018_d452, 4); or(memb[ds, edx + 0xc], 8);             /* or byte [edx+0xc], 0x8 */
        l_0x1018_d456:
            ii(0x1018_d456, 3); mov(eax, memd[ds, edx + 8]);            /* mov eax, [edx+0x8] */
            ii(0x1018_d459, 7); mov(memd[ds, edx + 4], 0);              /* mov dword [edx+0x4], 0x0 */
            ii(0x1018_d460, 2); mov(memd[ds, edx], eax);                /* mov [edx], eax */
            ii(0x1018_d462, 1); pop(edx);                               /* pop edx */
            ii(0x1018_d463, 1); pop(ecx);                               /* pop ecx */
            ii(0x1018_d464, 1); ret();                                  /* ret */
        }
    }
}
