using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_ae58-acd60cf8")]
        public void Method_1013_ae58()
        {
            ii(0x1013_ae58, 5);  push(0x2c);                           /* push 0x2c */
            ii(0x1013_ae5d, 5);  call(Definitions.sys_check_available_stack_size, 0x2_aef0);/* call 0x10165d52 */
            ii(0x1013_ae62, 1);  push(ecx);                            /* push ecx */
            ii(0x1013_ae63, 1);  push(esi);                            /* push esi */
            ii(0x1013_ae64, 1);  push(edi);                            /* push edi */
            ii(0x1013_ae65, 1);  push(ebp);                            /* push ebp */
            ii(0x1013_ae66, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1013_ae68, 6);  sub(esp, 0x18);                       /* sub esp, 0x18 */
            ii(0x1013_ae6e, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1013_ae71, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x1013_ae74, 3);  mov(memd[ss, ebp - 4], ebx);          /* mov [ebp-0x4], ebx */
            ii(0x1013_ae77, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1013_ae7a, 5);  call(0x1013_aaa8, -0x3d7);            /* call 0x1013aaa8 */
            ii(0x1013_ae7f, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1013_ae82, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x1013_ae85, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1013_ae88, 4);  movsx(ebx, memw[ss, ebp - 4]);        /* movsx ebx, word [ebp-0x4] */
            ii(0x1013_ae8c, 4);  movsx(edx, memw[ss, ebp - 8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x1013_ae90, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1013_ae93, 3);  add(eax, 6);                          /* add eax, 0x6 */
            ii(0x1013_ae96, 5);  call(0x100c_d7e8, -0x6_d6b3);         /* call 0x100cd7e8 */
            ii(0x1013_ae9b, 3);  sub(eax, 6);                          /* sub eax, 0x6 */
            ii(0x1013_ae9e, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1013_aea1, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x1013_aea4, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1013_aea7, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1013_aeaa, 7);  mov(memd[ds, eax + 2], 0x101b_6f04);  /* mov dword [eax+0x2], 0x101b6f04 */
            ii(0x1013_aeb1, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1013_aeb4, 7);  mov(memd[ds, eax + 18], 0x101b_6f00); /* mov dword [eax+0x12], 0x101b6f00 */
            ii(0x1013_aebb, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1013_aebe, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1013_aec1, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1013_aec4, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1013_aec6, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1013_aec7, 1);  pop(edi);                             /* pop edi */
            ii(0x1013_aec8, 1);  pop(esi);                             /* pop esi */
            ii(0x1013_aec9, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1013_aeca, 1);  ret();                                /* ret */
        }
    }
}
