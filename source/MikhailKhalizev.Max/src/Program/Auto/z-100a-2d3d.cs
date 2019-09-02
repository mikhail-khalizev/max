using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_2d3d-d7a27182")]
        public void Method_100a_2d3d()
        {
            ii(0x100a_2d3d, 5); push(0x38);                             /* push 0x38 */
            ii(0x100a_2d42, 5); call(Definitions.sys_check_available_stack_size, 0xc_300b); /* call 0x10165d52 */
            ii(0x100a_2d47, 1); push(ebx);                              /* push ebx */
            ii(0x100a_2d48, 1); push(ecx);                              /* push ecx */
            ii(0x100a_2d49, 1); push(esi);                              /* push esi */
            ii(0x100a_2d4a, 1); push(edi);                              /* push edi */
            ii(0x100a_2d4b, 1); push(ebp);                              /* push ebp */
            ii(0x100a_2d4c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_2d4e, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x100a_2d54, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100a_2d57, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100a_2d5a, 3); lea(eax, memd[ss, ebp - 16]);           /* lea eax, [ebp-0x10] */
            ii(0x100a_2d5d, 5); call(Definitions.my_ctor_0x101b_4184, -0x2_c272); /* call 0x10076af0 */
            ii(0x100a_2d62, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_2d65, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x100a_2d68, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100a_2d6b, 3); mov(ebx, memd[ds, eax + 2]);            /* mov ebx, [eax+0x2] */
            ii(0x100a_2d6e, 3); lea(edx, memd[ss, ebp - 32]);           /* lea edx, [ebp-0x20] */
            ii(0x100a_2d71, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100a_2d74, 3); call_abs(memd[ds, ebx + 28]);           /* call dword [ebx+0x1c] */
            ii(0x100a_2d77, 3); mov(eax, memd[ss, ebp - 32]);           /* mov eax, [ebp-0x20] */
            ii(0x100a_2d7a, 4); mov(memw[ss, ebp - 16], ax);            /* mov [ebp-0x10], ax */
            ii(0x100a_2d7e, 3); mov(eax, memd[ss, ebp - 28]);           /* mov eax, [ebp-0x1c] */
            ii(0x100a_2d81, 4); mov(memw[ss, ebp - 14], ax);            /* mov [ebp-0xe], ax */
            ii(0x100a_2d85, 3); lea(edx, memd[ss, ebp - 16]);           /* lea edx, [ebp-0x10] */
            ii(0x100a_2d88, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_2d8b, 5); call(0x1007_5e64, -0x2_cf2c);           /* call 0x10075e64 */
            ii(0x100a_2d90, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_2d93, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_2d95, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_2d96, 1); pop(edi);                               /* pop edi */
            ii(0x100a_2d97, 1); pop(esi);                               /* pop esi */
            ii(0x100a_2d98, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_2d99, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_2d9a, 1); ret();                                  /* ret */
        }
    }
}
