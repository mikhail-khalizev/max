using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_312d-16f7ad9d")]
        public void Method_1010_312d()
        {
            ii(0x1010_312d, 5); push(0x20);                             /* push 0x20 */
            ii(0x1010_3132, 5); call(Definitions.sys_check_available_stack_size, 0x6_2c1b); /* call 0x10165d52 */
            ii(0x1010_3137, 1); push(ebx);                              /* push ebx */
            ii(0x1010_3138, 1); push(ecx);                              /* push ecx */
            ii(0x1010_3139, 1); push(esi);                              /* push esi */
            ii(0x1010_313a, 1); push(edi);                              /* push edi */
            ii(0x1010_313b, 1); push(ebp);                              /* push ebp */
            ii(0x1010_313c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_313e, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x1010_3144, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1010_3147, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1010_314a, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1010_314d, 3); mov(edx, memd[ds, eax + 14]);           /* mov edx, [eax+0xe] */
            ii(0x1010_3150, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1010_3153, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1010_3156, 5); call(0x1013_c0fa, 0x3_8f9f);            /* call 0x1013c0fa */
            ii(0x1010_315b, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1010_315e, 3); mov(edx, memd[ds, eax + 16]);           /* mov edx, [eax+0x10] */
            ii(0x1010_3161, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1010_3164, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1010_3167, 5); call(0x1013_c0fa, 0x3_8f8e);            /* call 0x1013c0fa */
            ii(0x1010_316c, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1010_316f, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1010_3172, 3); add(eax, 6);                            /* add eax, 0x6 */
            ii(0x1010_3175, 5); call(0x1010_2d8f, -0x3eb);              /* call 0x10102d8f */
            ii(0x1010_317a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_317c, 1); pop(ebp);                               /* pop ebp */
            ii(0x1010_317d, 1); pop(edi);                               /* pop edi */
            ii(0x1010_317e, 1); pop(esi);                               /* pop esi */
            ii(0x1010_317f, 1); pop(ecx);                               /* pop ecx */
            ii(0x1010_3180, 1); pop(ebx);                               /* pop ebx */
            ii(0x1010_3181, 1); ret();                                  /* ret */
        }
    }
}
