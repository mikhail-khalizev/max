using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_aecb-7c8e7511")]
        public void Method_1013_aecb()
        {
            ii(0x1013_aecb, 5);  push(0x2c);                           /* push 0x2c */
            ii(0x1013_aed0, 5);  call(Definitions.sys_check_available_stack_size, 0x2_ae7d);/* call 0x10165d52 */
            ii(0x1013_aed5, 1);  push(ebx);                            /* push ebx */
            ii(0x1013_aed6, 1);  push(ecx);                            /* push ecx */
            ii(0x1013_aed7, 1);  push(esi);                            /* push esi */
            ii(0x1013_aed8, 1);  push(edi);                            /* push edi */
            ii(0x1013_aed9, 1);  push(ebp);                            /* push ebp */
            ii(0x1013_aeda, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1013_aedc, 6);  sub(esp, 0x14);                       /* sub esp, 0x14 */
            ii(0x1013_aee2, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_aee5, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1013_aee8, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_aeeb, 5);  call(0x1013_aaa8, -0x448);            /* call 0x1013aaa8 */
            ii(0x1013_aef0, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_aef3, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x1013_aef6, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1013_aef9, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1013_aefc, 3);  add(edx, 6);                          /* add edx, 0x6 */
            ii(0x1013_aeff, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_af02, 3);  add(eax, 6);                          /* add eax, 0x6 */
            ii(0x1013_af05, 5);  call(0x100c_d850, -0x6_d6ba);         /* call 0x100cd850 */
            ii(0x1013_af0a, 3);  sub(eax, 6);                          /* sub eax, 0x6 */
            ii(0x1013_af0d, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_af10, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x1013_af13, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1013_af16, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_af19, 7);  mov(memd[ds, eax + 2], 0x101b_6f04);  /* mov dword [eax+0x2], 0x101b6f04 */
            ii(0x1013_af20, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_af23, 7);  mov(memd[ds, eax + 18], 0x101b_6f00); /* mov dword [eax+0x12], 0x101b6f00 */
            ii(0x1013_af2a, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_af2d, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1013_af30, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1013_af33, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1013_af35, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1013_af36, 1);  pop(edi);                             /* pop edi */
            ii(0x1013_af37, 1);  pop(esi);                             /* pop esi */
            ii(0x1013_af38, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1013_af39, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1013_af3a, 1);  ret();                                /* ret */
        }
    }
}
