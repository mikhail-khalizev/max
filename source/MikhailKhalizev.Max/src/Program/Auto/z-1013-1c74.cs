using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_1c74-1341bc89")]
        public void Method_1013_1c74()
        {
            ii(0x1013_1c74, 5); push(0x28);                             /* push 0x28 */
            ii(0x1013_1c79, 5); call(Definitions.sys_check_available_stack_size, 0x3_40d4); /* call 0x10165d52 */
            ii(0x1013_1c7e, 1); push(ebx);                              /* push ebx */
            ii(0x1013_1c7f, 1); push(ecx);                              /* push ecx */
            ii(0x1013_1c80, 1); push(edx);                              /* push edx */
            ii(0x1013_1c81, 1); push(esi);                              /* push esi */
            ii(0x1013_1c82, 1); push(edi);                              /* push edi */
            ii(0x1013_1c83, 1); push(ebp);                              /* push ebp */
            ii(0x1013_1c84, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_1c86, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1013_1c8c, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1013_1c8f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1013_1c92, 5); call(Definitions.my_ctor_0x101b_6edc, -0xb_ae53); /* call 0x10076e44 */
            ii(0x1013_1c97, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1013_1c9a, 3); lea(eax, memd[ss, ebp - 4]);            /* lea eax, [ebp-0x4] */
            ii(0x1013_1c9d, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1013_1ca0, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1013_1ca3, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1013_1ca6, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1013_1ca9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_1cab, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_1cac, 1); pop(edi);                               /* pop edi */
            ii(0x1013_1cad, 1); pop(esi);                               /* pop esi */
            ii(0x1013_1cae, 1); pop(edx);                               /* pop edx */
            ii(0x1013_1caf, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_1cb0, 1); pop(ebx);                               /* pop ebx */
            ii(0x1013_1cb1, 1); ret();                                  /* ret */
        }
    }
}
