using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_8d8c-7d3ab025")]
        public void /* sys */ Method_1017_8d8c()
        {
            ii(0x1017_8d8c, 1); push(ebx);                              /* push ebx */
            ii(0x1017_8d8d, 1); push(edx);                              /* push edx */
            ii(0x1017_8d8e, 3); sub(esp, 0x38);                         /* sub esp, 0x38 */
            ii(0x1017_8d91, 2); mov(ah, 0x2);                           /* mov ah, 0x2 */
            ii(0x1017_8d93, 2); mov(ebx, esp);                          /* mov ebx, esp */
            ii(0x1017_8d95, 4); lea(edx, memd[ss, esp + 0x1c]);         /* lea edx, [esp+0x1c] */
            ii(0x1017_8d99, 4); mov(memb[ss, esp + 0x1d], ah);          /* mov [esp+0x1d], ah */
            ii(0x1017_8d9d, 5); mov(eax, 0x16);                         /* mov eax, 0x16 */
            ii(0x1017_8da2, 5); call(/* sys */ 0x1016_c606, -0xc7a1);   /* call 0x1016c606 */
            ii(0x1017_8da7, 4); test(memb[ss, esp], 0x40);              /* test byte [esp], 0x40 */
            ii(0x1017_8dab, 2); if(jz(0x1017_8db4, 0x7)) goto l_0x1017_8db4; /* jz 0x10178db4 */
            ii(0x1017_8dad, 7); or(memb[ds, 0x101b_e1f2], 0x2);         /* or byte [0x101be1f2], 0x2 */
        l_0x1017_8db4:
            ii(0x1017_8db4, 4); test(memb[ss, esp], 0x20);              /* test byte [esp], 0x20 */
            ii(0x1017_8db8, 2); if(jz(0x1017_8dc1, 0x7)) goto l_0x1017_8dc1; /* jz 0x10178dc1 */
            ii(0x1017_8dba, 7); or(memb[ds, 0x101b_e1f2], 0x1);         /* or byte [0x101be1f2], 0x1 */
        l_0x1017_8dc1:
            ii(0x1017_8dc1, 4); test(memb[ss, esp], 0x10);              /* test byte [esp], 0x10 */
            ii(0x1017_8dc5, 2); if(jz(0x1017_8dce, 0x7)) goto l_0x1017_8dce; /* jz 0x10178dce */
            ii(0x1017_8dc7, 7); or(memb[ds, 0x101b_e1f2], 0x4);         /* or byte [0x101be1f2], 0x4 */
        l_0x1017_8dce:
            ii(0x1017_8dce, 3); add(esp, 0x38);                         /* add esp, 0x38 */
            ii(0x1017_8dd1, 1); pop(edx);                               /* pop edx */
            ii(0x1017_8dd2, 1); pop(ebx);                               /* pop ebx */
            ii(0x1017_8dd3, 1); ret();                                  /* ret */
        }
    }
}
