using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_99a7-7cd72a7e")]
        public void Method_1010_99a7()
        {
            ii(0x1010_99a7, 5);  push(0x2c);                           /* push 0x2c */
            ii(0x1010_99ac, 5);  call(Definitions.sys_check_available_stack_size, 0x5_c3a1);/* call 0x10165d52 */
            ii(0x1010_99b1, 1);  push(ebx);                            /* push ebx */
            ii(0x1010_99b2, 1);  push(ecx);                            /* push ecx */
            ii(0x1010_99b3, 1);  push(edx);                            /* push edx */
            ii(0x1010_99b4, 1);  push(esi);                            /* push esi */
            ii(0x1010_99b5, 1);  push(edi);                            /* push edi */
            ii(0x1010_99b6, 1);  push(ebp);                            /* push ebp */
            ii(0x1010_99b7, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1010_99b9, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x1010_99bf, 7);  cmp(memd[ds, 0x101c_4dd8], 0);        /* cmp dword [0x101c4dd8], 0x0 */
            ii(0x1010_99c6, 2);  if(jz(0x1010_99d2, 0xa)) goto l_0x1010_99d2;/* jz 0x101099d2 */
            ii(0x1010_99c8, 5);  mov(eax, memd[ds, 0x101c_4dd8]);      /* mov eax, [0x101c4dd8] */
            ii(0x1010_99cd, 5);  call(Definitions.sys_delete, 0x5_c592);/* call 0x10165f64 */
        l_0x1010_99d2:
            ii(0x1010_99d2, 10);  mov(memd[ds, 0x101c_4dd8], 0);       /* mov dword [0x101c4dd8], 0x0 */
            ii(0x1010_99dc, 7);  cmp(memd[ds, 0x101c_4ddc], 0);        /* cmp dword [0x101c4ddc], 0x0 */
            ii(0x1010_99e3, 2);  if(jz(0x1010_99f9, 0x14)) goto l_0x1010_99f9;/* jz 0x101099f9 */
            ii(0x1010_99e5, 5);  mov(edx, 0x101b_5c10);                /* mov edx, 0x101b5c10 */
            ii(0x1010_99ea, 5);  mov(eax, memd[ds, 0x101c_4ddc]);      /* mov eax, [0x101c4ddc] */
            ii(0x1010_99ef, 5);  call(Definitions.sys_call_dtor_arr, 0x5_c5c4);/* call 0x10165fb8 */
            ii(0x1010_99f4, 5);  call(Definitions.sys_delete_arr, 0x5_c5df);/* call 0x10165fd8 */
        l_0x1010_99f9:
            ii(0x1010_99f9, 10);  mov(memd[ds, 0x101c_4ddc], 0);       /* mov dword [0x101c4ddc], 0x0 */
            ii(0x1010_9a03, 7);  cmp(memd[ds, 0x101c_4de0], 0);        /* cmp dword [0x101c4de0], 0x0 */
            ii(0x1010_9a0a, 2);  if(jz(0x1010_9a35, 0x29)) goto l_0x1010_9a35;/* jz 0x10109a35 */
            ii(0x1010_9a0c, 5);  mov(eax, memd[ds, 0x101c_4de0]);      /* mov eax, [0x101c4de0] */
            ii(0x1010_9a11, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1010_9a14, 4);  cmp(memd[ss, ebp - 8], 0);            /* cmp dword [ebp-0x8], 0x0 */
            ii(0x1010_9a18, 2);  if(jz(0x1010_9a2e, 0x14)) goto l_0x1010_9a2e;/* jz 0x10109a2e */
            ii(0x1010_9a1a, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1010_9a1c, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_9a1f, 5);  call(Definitions.my_dtor_d2, -0x3_b4ec);/* call 0x100ce538 */
            ii(0x1010_9a24, 5);  call(Definitions.sys_delete, 0x5_c53b);/* call 0x10165f64 */
            ii(0x1010_9a29, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1010_9a2c, 2);  jmp(0x1010_9a35, 7); goto l_0x1010_9a35;/* jmp 0x10109a35 */
        l_0x1010_9a2e:
            ii(0x1010_9a2e, 7);  mov(memd[ss, ebp - 4], 0);            /* mov dword [ebp-0x4], 0x0 */
        l_0x1010_9a35:
            ii(0x1010_9a35, 10);  mov(memd[ds, 0x101c_4de0], 0);       /* mov dword [0x101c4de0], 0x0 */
            ii(0x1010_9a3f, 7);  cmp(memd[ds, 0x101c_4de4], 0);        /* cmp dword [0x101c4de4], 0x0 */
            ii(0x1010_9a46, 2);  if(jz(0x1010_9a71, 0x29)) goto l_0x1010_9a71;/* jz 0x10109a71 */
            ii(0x1010_9a48, 5);  mov(eax, memd[ds, 0x101c_4de4]);      /* mov eax, [0x101c4de4] */
            ii(0x1010_9a4d, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1010_9a50, 4);  cmp(memd[ss, ebp - 16], 0);           /* cmp dword [ebp-0x10], 0x0 */
            ii(0x1010_9a54, 2);  if(jz(0x1010_9a6a, 0x14)) goto l_0x1010_9a6a;/* jz 0x10109a6a */
            ii(0x1010_9a56, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1010_9a58, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1010_9a5b, 5);  call(Definitions.my_dtor_d2, -0x3_b528);/* call 0x100ce538 */
            ii(0x1010_9a60, 5);  call(Definitions.sys_delete, 0x5_c4ff);/* call 0x10165f64 */
            ii(0x1010_9a65, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1010_9a68, 2);  jmp(0x1010_9a71, 7); goto l_0x1010_9a71;/* jmp 0x10109a71 */
        l_0x1010_9a6a:
            ii(0x1010_9a6a, 7);  mov(memd[ss, ebp - 12], 0);           /* mov dword [ebp-0xc], 0x0 */
        l_0x1010_9a71:
            ii(0x1010_9a71, 10);  mov(memd[ds, 0x101c_4de4], 0);       /* mov dword [0x101c4de4], 0x0 */
            ii(0x1010_9a7b, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1010_9a7d, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1010_9a7e, 1);  pop(edi);                             /* pop edi */
            ii(0x1010_9a7f, 1);  pop(esi);                             /* pop esi */
            ii(0x1010_9a80, 1);  pop(edx);                             /* pop edx */
            ii(0x1010_9a81, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1010_9a82, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1010_9a83, 1);  ret();                                /* ret */
        }
    }
}
