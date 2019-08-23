using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_3f62-d93efdc8")]
        public void /* sys */ Method_1019_3f62()
        {
            ii(0x1019_3f62, 1); pop(edi);                               /* pop edi */
            ii(0x1019_3f63, 1); pop(esi);                               /* pop esi */
            ii(0x1019_3f64, 5); mov(eax, memd[ds, Definitions.video_bank_count_in_win]); /* mov eax, [0x10209c9c] */
            ii(0x1019_3f69, 3); add(memd[ss, ebp - 0x28], eax);         /* add [ebp-0x28], eax */
            ii(0x1019_3f6c, 6); sub(edi, memd[ds, Definitions.video_win_len]); /* sub edi, [0x10209ca0] */
            ii(0x1019_3f72, 7); cmp(memd[ds, 0x1020_9c90], 0);          /* cmp dword [0x10209c90], 0x0 */
            ii(0x1019_3f79, 2); if(jz(0x1019_3f8c, 0x11)) goto l_0x1019_3f8c; /* jz 0x10193f8c */
            ii(0x1019_3f7b, 2); mov(bh, 0);                             /* mov bh, 0x0 */
            ii(0x1019_3f7d, 6); mov(bl, memb[ds, 0x1020_9cb0]);         /* mov bl, [0x10209cb0] */
            ii(0x1019_3f83, 3); mov(edx, memd[ss, ebp - 0x28]);         /* mov edx, [ebp-0x28] */
            ii(0x1019_3f86, 6); call_abs(memd[ds, 0x1020_9c90]);        /* call dword [0x10209c90] */
        l_0x1019_3f8c:
            ii(0x1019_3f8c, 1); pop(edx);                               /* pop edx */
            ii(0x1019_3f8d, 1); pop(ebx);                               /* pop ebx */
            ii(0x1019_3f8e, 3); mov(ecx, memd[ss, ebp + 0x14]);         /* mov ecx, [ebp+0x14] */
            ii(0x1019_3f91, 5); mov(eax, 0);                            /* mov eax, 0x0 */
            ii(0x1019_3f96, 2); jmp(0x1019_3f9e, 0x6); goto l_0x1019_3f9e; /* jmp 0x10193f9e */
        l_0x1019_3f98:
            ii(0x1019_3f98, 3); mov(dx, memw[ds, ebx]);                 /* mov dx, [ebx] */
            ii(0x1019_3f9b, 3); add(ebx, 0x2);                          /* add ebx, 0x2 */
        l_0x1019_3f9e:
            ii(0x1019_3f9e, 3); add(dx, dx);                            /* add dx, dx */
            ii(0x1019_3fa1, 2); if(jz(0x1019_3f98, -0xb)) goto l_0x1019_3f98; /* jz 0x10193f98 */
            ii(0x1019_3fa3, 2); if(jb(0x1019_3fbf, 0x1a)) goto l_0x1019_3fbf; /* jb 0x10193fbf */
            ii(0x1019_3fa5, 3); add(esi, 0x10);                         /* add esi, 0x10 */
            ii(0x1019_3fa8, 3); add(edi, 0x10);                         /* add edi, 0x10 */
            ii(0x1019_3fab, 2); if(loop(0x1019_3f9e, -0xf)) goto l_0x1019_3f9e; /* loop 0x10193f9e */
            ii(0x1019_3fad, 5); if(jmp_func(0x1019_3da0, -0x212)) return; /* jmp 0x10193da0 */
        l_0x1019_3fb2:
            ii(0x1019_3fb2, 3); mov(dx, memw[ds, ebx]);                 /* mov dx, [ebx] */
            ii(0x1019_3fb5, 3); add(ebx, 0x2);                          /* add ebx, 0x2 */
        l_0x1019_3fb8:
            ii(0x1019_3fb8, 3); add(dx, dx);                            /* add dx, dx */
            ii(0x1019_3fbb, 2); if(ja(0x1019_3fce, 0x11)) goto l_0x1019_3fce; /* ja 0x10193fce */
            ii(0x1019_3fbd, 2); if(jz(0x1019_3fb2, -0xd)) goto l_0x1019_3fb2; /* jz 0x10193fb2 */
        l_0x1019_3fbf:
            ii(0x1019_3fbf, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x1019_3fc2, 2); if(loop(0x1019_3fb8, -0xc)) goto l_0x1019_3fb8; /* loop 0x10193fb8 */
            ii(0x1019_3fc4, 5); call(/* sys */ 0x1019_3fe5, 0x1c);      /* call 0x10193fe5 */
            ii(0x1019_3fc9, 5); if(jmp_func(0x1019_3da0, -0x22e)) return; /* jmp 0x10193da0 */
        l_0x1019_3fce:
            ii(0x1019_3fce, 5); call(/* sys */ 0x1019_3fe5, 0x12);      /* call 0x10193fe5 */
            ii(0x1019_3fd3, 3); add(esi, 0x10);                         /* add esi, 0x10 */
            ii(0x1019_3fd6, 3); add(edi, 0x10);                         /* add edi, 0x10 */
            ii(0x1019_3fd9, 5); mov(eax, 0);                            /* mov eax, 0x0 */
            ii(0x1019_3fde, 2); if(loop(0x1019_3f9e, -0x42)) goto l_0x1019_3f9e; /* loop 0x10193f9e */
            ii(0x1019_3fe0, 5); if(jmp_func(0x1019_3da0, -0x245)) return; /* jmp 0x10193da0 */
        }
    }
}
