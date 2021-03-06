using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_956c-45c4cadc")]
        public void Method_1008_956c()
        {
            ii(0x1008_956c, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1008_9571, 5);  call(Definitions.sys_check_available_stack_size, 0xd_c7dc);/* call 0x10165d52 */
            ii(0x1008_9576, 1);  push(ebx);                            /* push ebx */
            ii(0x1008_9577, 1);  push(ecx);                            /* push ecx */
            ii(0x1008_9578, 1);  push(esi);                            /* push esi */
            ii(0x1008_9579, 1);  push(edi);                            /* push edi */
            ii(0x1008_957a, 1);  push(ebp);                            /* push ebp */
            ii(0x1008_957b, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1008_957d, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1008_9583, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1008_9586, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1008_9589, 7);  test(memd[ss, ebp - 4], 4);           /* test dword [ebp-0x4], 0x4 */
            ii(0x1008_9590, 2);  if(jz(0x1008_95a6, 0x14)) goto l_0x1008_95a6;/* jz 0x100895a6 */
            ii(0x1008_9592, 5);  mov(edx, 0x101b_3a68);                /* mov edx, 0x101b3a68 */
            ii(0x1008_9597, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_959a, 5);  call(Definitions.sys_call_dtor_arr, 0xd_ca19);/* call 0x10165fb8 */
            ii(0x1008_959f, 5);  call(Definitions.sys_delete_arr, 0xd_ca34);/* call 0x10165fd8 */
            ii(0x1008_95a4, 2);  jmp(0x1008_95ed, 0x47); goto l_0x1008_95ed;/* jmp 0x100895ed */
        l_0x1008_95a6:
            ii(0x1008_95a6, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1008_95a8, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_95ab, 3);  add(eax, 0x17);                       /* add eax, 0x17 */
            ii(0x1008_95ae, 5);  call(0x1007_5f2c, -0x1_3687);         /* call 0x10075f2c */
            ii(0x1008_95b3, 3);  sub(eax, 0x17);                       /* sub eax, 0x17 */
            ii(0x1008_95b6, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1008_95b9, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1008_95bb, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_95be, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x1008_95c1, 5);  call(0x1007_5f2c, -0x1_369a);         /* call 0x10075f2c */
            ii(0x1008_95c6, 3);  sub(eax, 0x13);                       /* sub eax, 0x13 */
            ii(0x1008_95c9, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1008_95cc, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x1008_95d1, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_95d4, 5);  call(0x100a_284c, 0x1_9273);          /* call 0x100a284c */
            ii(0x1008_95d9, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1008_95dc, 7);  test(memd[ss, ebp - 4], 2);           /* test dword [ebp-0x4], 0x2 */
            ii(0x1008_95e3, 2);  if(jz(0x1008_95ed, 8)) goto l_0x1008_95ed;/* jz 0x100895ed */
            ii(0x1008_95e5, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_95e8, 5);  call(Definitions.sys_delete, 0xd_c977);/* call 0x10165f64 */
        l_0x1008_95ed:
            ii(0x1008_95ed, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_95f0, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1008_95f3, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1008_95f6, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1008_95f8, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1008_95f9, 1);  pop(edi);                             /* pop edi */
            ii(0x1008_95fa, 1);  pop(esi);                             /* pop esi */
            ii(0x1008_95fb, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1008_95fc, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1008_95fd, 1);  ret();                                /* ret */
        }
    }
}
