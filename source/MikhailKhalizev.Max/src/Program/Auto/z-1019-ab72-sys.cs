using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_ab72-7bd3714a")]
        public void /* sys */ Method_1019_ab72()
        {
            ii(0x1019_ab72, 1); push(ebx);                              /* push ebx */
            ii(0x1019_ab73, 1); push(ecx);                              /* push ecx */
            ii(0x1019_ab74, 1); push(edx);                              /* push edx */
            ii(0x1019_ab75, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1019_ab77, 3); test(bl, 0x3);                          /* test bl, 0x3 */
            ii(0x1019_ab7a, 2); if(jnz(0x1019_aba7, 0x2b)) goto l_0x1019_aba7; /* jnz 0x1019aba7 */
            ii(0x1019_ab7c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1019_ab7e, 5); mov(ecx, 0x64);                         /* mov ecx, 0x64 */
            ii(0x1019_ab83, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1019_ab86, 2); idiv(ecx);                              /* idiv ecx */
            ii(0x1019_ab88, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1019_ab8a, 2); if(jz(0x1019_ab95, 0x9)) goto l_0x1019_ab95; /* jz 0x1019ab95 */
        l_0x1019_ab8c:
            ii(0x1019_ab8c, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1019_ab91, 1); pop(edx);                               /* pop edx */
            ii(0x1019_ab92, 1); pop(ecx);                               /* pop ecx */
            ii(0x1019_ab93, 1); pop(ebx);                               /* pop ebx */
            ii(0x1019_ab94, 1); ret(); return;                          /* ret */
        l_0x1019_ab95:
            ii(0x1019_ab95, 5); mov(ecx, 0x190);                        /* mov ecx, 0x190 */
            ii(0x1019_ab9a, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x1019_ab9c, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1019_ab9e, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1019_aba1, 2); idiv(ecx);                              /* idiv ecx */
            ii(0x1019_aba3, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1019_aba5, 2); if(jz(0x1019_ab8c, -0x1b)) goto l_0x1019_ab8c; /* jz 0x1019ab8c */
        l_0x1019_aba7:
            ii(0x1019_aba7, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1019_aba9, 1); pop(edx);                               /* pop edx */
            ii(0x1019_abaa, 1); pop(ecx);                               /* pop ecx */
            ii(0x1019_abab, 1); pop(ebx);                               /* pop ebx */
            ii(0x1019_abac, 1); ret();                                  /* ret */
        }
    }
}
