using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_39cc-a78bee2d")]
        public void Method_1013_39cc()
        {
            ii(0x1013_39cc, 5); push(0x44);                             /* push 0x44 */
            ii(0x1013_39d1, 5); call(Definitions.sys_check_available_stack_size, 0x3_237c); /* call 0x10165d52 */
            ii(0x1013_39d6, 1); push(ebx);                              /* push ebx */
            ii(0x1013_39d7, 1); push(ecx);                              /* push ecx */
            ii(0x1013_39d8, 1); push(edx);                              /* push edx */
            ii(0x1013_39d9, 1); push(esi);                              /* push esi */
            ii(0x1013_39da, 1); push(edi);                              /* push edi */
            ii(0x1013_39db, 1); push(ebp);                              /* push ebp */
            ii(0x1013_39dc, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_39de, 6); sub(esp, 0x28);                         /* sub esp, 0x28 */
            ii(0x1013_39e4, 5); mov(eax, 0x101b_b4e4);                  /* mov eax, 0x101bb4e4 */
            ii(0x1013_39e9, 5); call(/* sys */ 0x1016_611f, 0x3_2731);  /* call 0x1016611f */
            ii(0x1013_39ee, 5); mov(eax, 0x101c_61b4);                  /* mov eax, 0x101c61b4 */
            ii(0x1013_39f3, 5); call(0x100d_f25d, -0x5_479b);           /* call 0x100df25d */
            ii(0x1013_39f8, 3); mov(memd[ss, ebp - 40], eax);           /* mov [ebp-0x28], eax */
            ii(0x1013_39fb, 3); mov(eax, memd[ss, ebp - 40]);           /* mov eax, [ebp-0x28] */
            ii(0x1013_39fe, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
            ii(0x1013_3a01, 10); mov(memd[ds, 0x101b_b4ec], 1);         /* mov dword [0x101bb4ec], 0x1 */
            ii(0x1013_3a0b, 5); mov(eax, 0x101c_64b0);                  /* mov eax, 0x101c64b0 */
            ii(0x1013_3a10, 5); call(0x100d_f25d, -0x5_47b8);           /* call 0x100df25d */
            ii(0x1013_3a15, 3); mov(memd[ss, ebp - 36], eax);           /* mov [ebp-0x24], eax */
            ii(0x1013_3a18, 3); mov(eax, memd[ss, ebp - 36]);           /* mov eax, [ebp-0x24] */
            ii(0x1013_3a1b, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x1013_3a1e, 10); mov(memd[ds, 0x101b_b4ec], 2);         /* mov dword [0x101bb4ec], 0x2 */
            ii(0x1013_3a28, 5); mov(eax, 0x101c_67ac);                  /* mov eax, 0x101c67ac */
            ii(0x1013_3a2d, 5); call(0x100d_f25d, -0x5_47d5);           /* call 0x100df25d */
            ii(0x1013_3a32, 3); mov(memd[ss, ebp - 32], eax);           /* mov [ebp-0x20], eax */
            ii(0x1013_3a35, 3); mov(eax, memd[ss, ebp - 32]);           /* mov eax, [ebp-0x20] */
            ii(0x1013_3a38, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1013_3a3b, 10); mov(memd[ds, 0x101b_b4ec], 3);         /* mov dword [0x101bb4ec], 0x3 */
            ii(0x1013_3a45, 5); mov(eax, 0x101c_6aa8);                  /* mov eax, 0x101c6aa8 */
            ii(0x1013_3a4a, 5); call(0x100d_f25d, -0x5_47f2);           /* call 0x100df25d */
            ii(0x1013_3a4f, 3); mov(memd[ss, ebp - 28], eax);           /* mov [ebp-0x1c], eax */
            ii(0x1013_3a52, 3); mov(eax, memd[ss, ebp - 28]);           /* mov eax, [ebp-0x1c] */
            ii(0x1013_3a55, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1013_3a58, 10); mov(memd[ds, 0x101b_b4ec], 4);         /* mov dword [0x101bb4ec], 0x4 */
            ii(0x1013_3a62, 5); mov(eax, 0x101c_6da4);                  /* mov eax, 0x101c6da4 */
            ii(0x1013_3a67, 5); call(0x100d_f25d, -0x5_480f);           /* call 0x100df25d */
            ii(0x1013_3a6c, 3); mov(memd[ss, ebp - 24], eax);           /* mov [ebp-0x18], eax */
            ii(0x1013_3a6f, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x1013_3a72, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1013_3a75, 10); mov(memd[ds, 0x101b_b4ec], 5);         /* mov dword [0x101bb4ec], 0x5 */
            ii(0x1013_3a7f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_3a81, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_3a82, 1); pop(edi);                               /* pop edi */
            ii(0x1013_3a83, 1); pop(esi);                               /* pop esi */
            ii(0x1013_3a84, 1); pop(edx);                               /* pop edx */
            ii(0x1013_3a85, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_3a86, 1); pop(ebx);                               /* pop ebx */
            ii(0x1013_3a87, 1); ret();                                  /* ret */
        }
    }
}
