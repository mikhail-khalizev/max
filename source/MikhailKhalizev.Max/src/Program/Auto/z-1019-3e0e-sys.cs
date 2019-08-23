using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_3e0e-54109b7b")]
        public void /* sys */ Method_1019_3e0e()
        {
            ii(0x1019_3e0e, 1); push(ebx);                              /* push ebx */
            ii(0x1019_3e0f, 1); push(ecx);                              /* push ecx */
            ii(0x1019_3e10, 1); push(edx);                              /* push edx */
            ii(0x1019_3e11, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1019_3e13, 3); shl(ecx, 0x2);                          /* shl ecx, 0x2 */
            ii(0x1019_3e16, 3); mov(ebx, memd[ss, ebp - 0x8]);          /* mov ebx, [ebp-0x8] */
            ii(0x1019_3e19, 2); sub(ebx, ecx);                          /* sub ebx, ecx */
            ii(0x1019_3e1b, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1019_3e1e, 2); sub(edx, ecx);                          /* sub edx, ecx */
            ii(0x1019_3e20, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1019_3e22, 2); rep(() => movsd());                     /* rep movsd */
            ii(0x1019_3e24, 2); add(esi, ebx);                          /* add esi, ebx */
            ii(0x1019_3e26, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1019_3e28, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1019_3e2a, 2); rep(() => movsd());                     /* rep movsd */
            ii(0x1019_3e2c, 2); add(esi, ebx);                          /* add esi, ebx */
            ii(0x1019_3e2e, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1019_3e30, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1019_3e32, 2); rep(() => movsd());                     /* rep movsd */
            ii(0x1019_3e34, 2); add(esi, ebx);                          /* add esi, ebx */
            ii(0x1019_3e36, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1019_3e38, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1019_3e3a, 2); rep(() => movsd());                     /* rep movsd */
            ii(0x1019_3e3c, 2); add(esi, ebx);                          /* add esi, ebx */
            ii(0x1019_3e3e, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1019_3e40, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1019_3e42, 2); rep(() => movsd());                     /* rep movsd */
            ii(0x1019_3e44, 2); add(esi, ebx);                          /* add esi, ebx */
            ii(0x1019_3e46, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1019_3e48, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1019_3e4a, 2); rep(() => movsd());                     /* rep movsd */
            ii(0x1019_3e4c, 2); add(esi, ebx);                          /* add esi, ebx */
            ii(0x1019_3e4e, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1019_3e50, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1019_3e52, 2); rep(() => movsd());                     /* rep movsd */
            ii(0x1019_3e54, 2); add(esi, ebx);                          /* add esi, ebx */
            ii(0x1019_3e56, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1019_3e58, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1019_3e5a, 2); rep(() => movsd());                     /* rep movsd */
            ii(0x1019_3e5c, 3); sub(esi, memd[ss, ebp - 0x10]);         /* sub esi, [ebp-0x10] */
            ii(0x1019_3e5f, 3); sub(edi, memd[ss, ebp - 0x14]);         /* sub edi, [ebp-0x14] */
            ii(0x1019_3e62, 1); pop(edx);                               /* pop edx */
            ii(0x1019_3e63, 1); pop(ecx);                               /* pop ecx */
            ii(0x1019_3e64, 1); pop(ebx);                               /* pop ebx */
            ii(0x1019_3e65, 1); ret();                                  /* ret */
        }
    }
}
