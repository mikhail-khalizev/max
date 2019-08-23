using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_9d3d-44e9e596")]
        public void my_ctor_c7()
        {
            ii(0x1009_9d3d, 5); push(0x30);                             /* push 0x30 */
            ii(0x1009_9d42, 5); call(Definitions.sys_check_available_stack_size, 0xc_c00b); /* call 0x10165d52 */
            ii(0x1009_9d47, 1); push(ebx);                              /* push ebx */
            ii(0x1009_9d48, 1); push(ecx);                              /* push ecx */
            ii(0x1009_9d49, 1); push(esi);                              /* push esi */
            ii(0x1009_9d4a, 1); push(edi);                              /* push edi */
            ii(0x1009_9d4b, 1); push(ebp);                              /* push ebp */
            ii(0x1009_9d4c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_9d4e, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x1009_9d54, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1009_9d57, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1009_9d5a, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_9d5d, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1009_9d60, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_9d63, 3); mov(edx, memd[ds, eax + 0x2]);          /* mov edx, [eax+0x2] */
            ii(0x1009_9d66, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_9d69, 3); call_abs(memd[ds, edx + 0x14]);         /* call dword [edx+0x14] */
            ii(0x1009_9d6c, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1009_9d6f, 3); mov(ebx, memd[ss, ebp - 0x4]);          /* mov ebx, [ebp-0x4] */
            ii(0x1009_9d72, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_9d75, 5); call(0x1008_ad90, -0xefea);             /* call 0x1008ad90 */
            ii(0x1009_9d7a, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1009_9d7d, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_9d80, 5); call(0x100a_26d1, 0x894c);              /* call 0x100a26d1 */
            ii(0x1009_9d85, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1009_9d88, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1009_9d8b, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1009_9d8e, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_9d91, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1009_9d94, 5); call(0x1009_c484, 0x26eb);              /* call 0x1009c484 */
            ii(0x1009_9d99, 3); sub(eax, 0x13);                         /* sub eax, 0x13 */
            ii(0x1009_9d9c, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1009_9d9f, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1009_9da2, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1009_9da5, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_9da8, 7); mov(memd[ds, eax + 0x2], 0x101b_43b0);  /* mov dword [eax+0x2], 0x101b43b0 */
            ii(0x1009_9daf, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1009_9db2, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_9db5, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1009_9db8, 5); call(0x1009_c44c, 0x268f);              /* call 0x1009c44c */
            ii(0x1009_9dbd, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_9dc0, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1009_9dc3, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1009_9dc6, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_9dc8, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_9dc9, 1); pop(edi);                               /* pop edi */
            ii(0x1009_9dca, 1); pop(esi);                               /* pop esi */
            ii(0x1009_9dcb, 1); pop(ecx);                               /* pop ecx */
            ii(0x1009_9dcc, 1); pop(ebx);                               /* pop ebx */
            ii(0x1009_9dcd, 1); ret();                                  /* ret */
        }
    }
}
