using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_32f7-b8721cd")]
        public void Method_100f_32f7()
        {
            ii(0x100f_32f7, 5); push(0x38);                             /* push 0x38 */
            ii(0x100f_32fc, 5); call(Definitions.sys_check_available_stack_size, 0x7_2a51); /* call 0x10165d52 */
            ii(0x100f_3301, 1); push(ebx);                              /* push ebx */
            ii(0x100f_3302, 1); push(ecx);                              /* push ecx */
            ii(0x100f_3303, 1); push(edx);                              /* push edx */
            ii(0x100f_3304, 1); push(esi);                              /* push esi */
            ii(0x100f_3305, 1); push(edi);                              /* push edi */
            ii(0x100f_3306, 1); push(ebp);                              /* push ebp */
            ii(0x100f_3307, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_3309, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100f_330f, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100f_3312, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100f_3316, 1); push(eax);                              /* push eax */
            ii(0x100f_3317, 5); mov(eax, StringDefinitions.I12);        /* mov eax, 0x101a2475 */
            ii(0x100f_331c, 1); push(eax);                              /* push eax */
            ii(0x100f_331d, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x100f_3320, 1); push(eax);                              /* push eax */
            ii(0x100f_3321, 5); call(Definitions.sys_sprintf, 0x7_2bdb); /* call 0x10165f01 */
            ii(0x100f_3326, 3); add(esp, 0xc);                          /* add esp, 0xc */
            ii(0x100f_3329, 5); call(0x1010_2a34, 0xf706);              /* call 0x10102a34 */
            ii(0x100f_332e, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x100f_3330, 5); mov(ebx, 0xa2);                         /* mov ebx, 0xa2 */
            ii(0x100f_3335, 3); lea(edx, memd[ss, ebp - 0x10]);         /* lea edx, [ebp-0x10] */
            ii(0x100f_3338, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x100f_333d, 5); call(0x100f_3176, -0x1cc);              /* call 0x100f3176 */
            ii(0x100f_3342, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_3344, 1); pop(ebp);                               /* pop ebp */
            ii(0x100f_3345, 1); pop(edi);                               /* pop edi */
            ii(0x100f_3346, 1); pop(esi);                               /* pop esi */
            ii(0x100f_3347, 1); pop(edx);                               /* pop edx */
            ii(0x100f_3348, 1); pop(ecx);                               /* pop ecx */
            ii(0x100f_3349, 1); pop(ebx);                               /* pop ebx */
            ii(0x100f_334a, 1); ret();                                  /* ret */
        }
    }
}
