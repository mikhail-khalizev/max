using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_8113-4a01ab5c")]
        public void Method_1011_8113()
        {
            ii(0x1011_8113, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1011_8118, 5);  call(Definitions.sys_check_available_stack_size, 0x4_dc35);/* call 0x10165d52 */
            ii(0x1011_811d, 1);  push(esi);                            /* push esi */
            ii(0x1011_811e, 1);  push(edi);                            /* push edi */
            ii(0x1011_811f, 1);  push(ebp);                            /* push ebp */
            ii(0x1011_8120, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1011_8122, 6);  sub(esp, 0x18);                       /* sub esp, 0x18 */
            ii(0x1011_8128, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1011_812b, 3);  mov(memd[ss, ebp - 12], edx);         /* mov [ebp-0xc], edx */
            ii(0x1011_812e, 3);  mov(memd[ss, ebp - 8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x1011_8131, 3);  mov(memd[ss, ebp - 4], ecx);          /* mov [ebp-0x4], ecx */
            ii(0x1011_8134, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1011_8137, 5);  call(0x1014_4ef4, 0x2_cdb8);          /* call 0x10144ef4 */
            ii(0x1011_813c, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1011_813f, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x1011_8142, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1011_8145, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1011_8148, 7);  mov(memd[ds, eax + 2], 0x101b_69b4);  /* mov dword [eax+0x2], 0x101b69b4 */
            ii(0x1011_814f, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1011_8152, 3);  mov(edx, memd[ss, ebp - 16]);         /* mov edx, [ebp-0x10] */
            ii(0x1011_8155, 3);  mov(memd[ds, edx + 12], eax);         /* mov [edx+0xc], eax */
            ii(0x1011_8158, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_815b, 3);  mov(edx, memd[ss, ebp - 16]);         /* mov edx, [ebp-0x10] */
            ii(0x1011_815e, 3);  mov(memd[ds, edx + 16], eax);         /* mov [edx+0x10], eax */
            ii(0x1011_8161, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_8164, 3);  mov(edx, memd[ss, ebp - 16]);         /* mov edx, [ebp-0x10] */
            ii(0x1011_8167, 4);  mov(memw[ds, edx + 20], ax);          /* mov [edx+0x14], ax */
            ii(0x1011_816b, 3);  mov(eax, memd[ss, ebp + 16]);         /* mov eax, [ebp+0x10] */
            ii(0x1011_816e, 3);  mov(edx, memd[ss, ebp - 16]);         /* mov edx, [ebp-0x10] */
            ii(0x1011_8171, 4);  mov(memw[ds, edx + 8], ax);           /* mov [edx+0x8], ax */
            ii(0x1011_8175, 3);  mov(eax, memd[ss, ebp + 20]);         /* mov eax, [ebp+0x14] */
            ii(0x1011_8178, 3);  mov(edx, memd[ss, ebp - 16]);         /* mov edx, [ebp-0x10] */
            ii(0x1011_817b, 4);  mov(memw[ds, edx + 10], ax);          /* mov [edx+0xa], ax */
            ii(0x1011_817f, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1011_8182, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1011_8185, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1011_8188, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1011_818a, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1011_818b, 1);  pop(edi);                             /* pop edi */
            ii(0x1011_818c, 1);  pop(esi);                             /* pop esi */
            ii(0x1011_818d, 3);  ret(8);                               /* ret 0x8 */
        }
    }
}
