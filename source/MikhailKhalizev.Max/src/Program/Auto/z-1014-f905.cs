using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_f905-6387020d")]
        public void Method_1014_f905()
        {
            ii(0x1014_f905, 5); push(0x28);                             /* push 0x28 */
            ii(0x1014_f90a, 5); call(Definitions.sys_check_available_stack_size, 0x1_6443); /* call 0x10165d52 */
            ii(0x1014_f90f, 1); push(ebx);                              /* push ebx */
            ii(0x1014_f910, 1); push(ecx);                              /* push ecx */
            ii(0x1014_f911, 1); push(esi);                              /* push esi */
            ii(0x1014_f912, 1); push(edi);                              /* push edi */
            ii(0x1014_f913, 1); push(ebp);                              /* push ebp */
            ii(0x1014_f914, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_f916, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1014_f91c, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1014_f91f, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1014_f922, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_f925, 3); mov(memb[ds, eax], 0);                  /* mov byte [eax], 0x0 */
            ii(0x1014_f928, 7); mov(memd[ss, ebp - 0xc], 0);            /* mov dword [ebp-0xc], 0x0 */
            ii(0x1014_f92f, 5); mov(eax, StringDefinitions.M4);         /* mov eax, 0x101addcb */
            ii(0x1014_f934, 1); push(eax);                              /* push eax */
            ii(0x1014_f935, 5); mov(ecx, StringDefinitions.D);          /* mov ecx, 0x101addcd */
            ii(0x1014_f93a, 5); mov(ebx, StringDefinitions.C);          /* mov ebx, 0x101addcf */
            ii(0x1014_f93f, 4); movsx(edx, memw[ss, ebp - 0x4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x1014_f943, 5); mov(esi, 0x64);                         /* mov esi, 0x64 */
            ii(0x1014_f948, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1014_f94a, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1014_f94d, 2); idiv(esi);                              /* idiv esi */
            ii(0x1014_f94f, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1014_f952, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_f955, 5); call(0x1014_f869, -0xf1);               /* call 0x1014f869 */
            ii(0x1014_f95a, 4); movsx(edx, memw[ss, ebp - 0x4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x1014_f95e, 5); mov(ebx, 0x64);                         /* mov ebx, 0x64 */
            ii(0x1014_f963, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1014_f965, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1014_f968, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1014_f96a, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1014_f96d, 5); mov(eax, StringDefinitions.C2);         /* mov eax, 0x101addd1 */
            ii(0x1014_f972, 1); push(eax);                              /* push eax */
            ii(0x1014_f973, 5); mov(ecx, StringDefinitions.L5);         /* mov ecx, 0x101addd3 */
            ii(0x1014_f978, 5); mov(ebx, StringDefinitions.X);          /* mov ebx, 0x101addd5 */
            ii(0x1014_f97d, 4); movsx(edx, memw[ss, ebp - 0x4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x1014_f981, 5); mov(esi, 0xa);                          /* mov esi, 0xa */
            ii(0x1014_f986, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1014_f988, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1014_f98b, 2); idiv(esi);                              /* idiv esi */
            ii(0x1014_f98d, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1014_f990, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_f993, 5); call(0x1014_f869, -0x12f);              /* call 0x1014f869 */
            ii(0x1014_f998, 4); movsx(edx, memw[ss, ebp - 0x4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x1014_f99c, 5); mov(ebx, 0xa);                          /* mov ebx, 0xa */
            ii(0x1014_f9a1, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1014_f9a3, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1014_f9a6, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1014_f9a8, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1014_f9ab, 5); mov(eax, StringDefinitions.X2);         /* mov eax, 0x101addd7 */
            ii(0x1014_f9b0, 1); push(eax);                              /* push eax */
            ii(0x1014_f9b1, 5); mov(ecx, StringDefinitions.V);          /* mov ecx, 0x101addd9 */
            ii(0x1014_f9b6, 5); mov(ebx, StringDefinitions.I2);         /* mov ebx, 0x101adddb */
            ii(0x1014_f9bb, 4); movsx(edx, memw[ss, ebp - 0x4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x1014_f9bf, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_f9c2, 5); call(0x1014_f869, -0x15e);              /* call 0x1014f869 */
            ii(0x1014_f9c7, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_f9c9, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_f9ca, 1); pop(edi);                               /* pop edi */
            ii(0x1014_f9cb, 1); pop(esi);                               /* pop esi */
            ii(0x1014_f9cc, 1); pop(ecx);                               /* pop ecx */
            ii(0x1014_f9cd, 1); pop(ebx);                               /* pop ebx */
            ii(0x1014_f9ce, 1); ret();                                  /* ret */
        }
    }
}
