using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_811c-d3bf03ac")]
        public void Method_1014_811c()
        {
            ii(0x1014_811c, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1014_8121, 5);  call(Definitions.sys_check_available_stack_size, 0x1_dc2c);/* call 0x10165d52 */
            ii(0x1014_8126, 1);  push(ebx);                            /* push ebx */
            ii(0x1014_8127, 1);  push(ecx);                            /* push ecx */
            ii(0x1014_8128, 1);  push(edx);                            /* push edx */
            ii(0x1014_8129, 1);  push(esi);                            /* push esi */
            ii(0x1014_812a, 1);  push(edi);                            /* push edi */
            ii(0x1014_812b, 1);  push(ebp);                            /* push ebp */
            ii(0x1014_812c, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1014_812e, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1014_8134, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1014_8137, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_813a, 5);  call(0x1013_aaa8, -0xd697);           /* call 0x1013aaa8 */
            ii(0x1014_813f, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1014_8142, 3);  lea(eax, memd[ss, ebp - 4]);          /* lea eax, [ebp-0x4] */
            ii(0x1014_8145, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1014_8148, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_814b, 7);  mov(memd[ds, eax + 2], 0x101b_5904);  /* mov dword [eax+0x2], 0x101b5904 */
            ii(0x1014_8152, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_8155, 6);  mov(memw[ds, eax + 6], 0);            /* mov word [eax+0x6], 0x0 */
            ii(0x1014_815b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_815e, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1014_8161, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1014_8164, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1014_8166, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1014_8167, 1);  pop(edi);                             /* pop edi */
            ii(0x1014_8168, 1);  pop(esi);                             /* pop esi */
            ii(0x1014_8169, 1);  pop(edx);                             /* pop edx */
            ii(0x1014_816a, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1014_816b, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1014_816c, 1);  ret();                                /* ret */
        }
    }
}
