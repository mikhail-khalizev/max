using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_4c19-ac93818")]
        public void /* sys */ Method_1019_4c19()
        {
            ii(0x1019_4c19, 7); cmp(memd[ds, 0x101c_1a54], 0);          /* cmp dword [0x101c1a54], 0x0 */
            ii(0x1019_4c20, 2); if(jz(0x1019_4c5a, 0x38)) goto l_0x1019_4c5a; /* jz 0x10194c5a */
            ii(0x1019_4c22, 1); nop();                                  /* nop */
            ii(0x1019_4c23, 1); nop();                                  /* nop */
            ii(0x1019_4c24, 1); nop();                                  /* nop */
            ii(0x1019_4c25, 1); nop();                                  /* nop */
            ii(0x1019_4c26, 9); mov(memw[ds, 0x101c_1a52], 0);          /* mov word [0x101c1a52], 0x0 */
            ii(0x1019_4c2f, 7); lss(esp, memd[ds, 0x101c_0a4a]);        /* lss esp, [0x101c0a4a] */
            ii(0x1019_4c36, 5); mov(eax, memd[ds, 0x101c_0a2c]);        /* mov eax, [0x101c0a2c] */
            ii(0x1019_4c3b, 6); mov(edx, memd[ds, 0x101c_0a30]);        /* mov edx, [0x101c0a30] */
            ii(0x1019_4c41, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1019_4c43, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1019_4c45, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1019_4c47, 3); xchg(memd[ss, ebp + 0x28], ecx);        /* xchg [ebp+0x28], ecx */
            ii(0x1019_4c4a, 3); xchg(memd[ss, ebp + 0x2c], eax);        /* xchg [ebp+0x2c], eax */
            ii(0x1019_4c4d, 1); pop(ds);                                /* pop ds */
            ii(0x1019_4c4e, 2); pop(gs);                                /* pop gs */
            ii(0x1019_4c50, 2); pop(fs);                                /* pop fs */
            ii(0x1019_4c52, 1); pop(es);                                /* pop es */
            ii(0x1019_4c53, 1); pop(edi);                               /* pop edi */
            ii(0x1019_4c54, 1); pop(esi);                               /* pop esi */
            ii(0x1019_4c55, 1); pop(ebp);                               /* pop ebp */
            ii(0x1019_4c56, 1); pop(ebx);                               /* pop ebx */
            ii(0x1019_4c57, 1); pop(ebx);                               /* pop ebx */
            ii(0x1019_4c58, 1); pop(edx);                               /* pop edx */
            ii(0x1019_4c59, 1); retf(); return;                         /* retf */
        l_0x1019_4c5a:
            ii(0x1019_4c5a, 1); ret();                                  /* ret */
        }
    }
}
