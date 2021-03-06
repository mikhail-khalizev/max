using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_9a88-e479eafb")]
        public void Method_1009_9a88()
        {
            ii(0x1009_9a88, 5);  push(0x44);                           /* push 0x44 */
            ii(0x1009_9a8d, 5);  call(Definitions.sys_check_available_stack_size, 0xc_c2c0);/* call 0x10165d52 */
            ii(0x1009_9a92, 1);  push(ebx);                            /* push ebx */
            ii(0x1009_9a93, 1);  push(ecx);                            /* push ecx */
            ii(0x1009_9a94, 1);  push(edx);                            /* push edx */
            ii(0x1009_9a95, 1);  push(esi);                            /* push esi */
            ii(0x1009_9a96, 1);  push(edi);                            /* push edi */
            ii(0x1009_9a97, 1);  push(ebp);                            /* push ebp */
            ii(0x1009_9a98, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1009_9a9a, 6);  sub(esp, 0x20);                       /* sub esp, 0x20 */
            ii(0x1009_9aa0, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1009_9aa3, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x1009_9aa6, 5);  call(Definitions.my_ctor_0x101b_4184, -0x2_2fbb);/* call 0x10076af0 */
            ii(0x1009_9aab, 5);  mov(edx, 5);                          /* mov edx, 0x5 */
            ii(0x1009_9ab0, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_9ab3, 3);  mov(eax, memd[ds, eax + 7]);          /* mov eax, [eax+0x7] */
            ii(0x1009_9ab6, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1009_9ab9, 6);  imul(ebx, eax, 0x247);                /* imul ebx, eax, 0x247 */
            ii(0x1009_9abf, 5);  mov(eax, 0x101c_a468);                /* mov eax, 0x101ca468 */
            ii(0x1009_9ac4, 2);  add(eax, ebx);                        /* add eax, ebx */
            ii(0x1009_9ac6, 5);  call(0x100d_fd2c, 0x4_6261);          /* call 0x100dfd2c */
            ii(0x1009_9acb, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1009_9acd, 5);  call(0x100a_314c, 0x967a);            /* call 0x100a314c */
            ii(0x1009_9ad2, 4);  cmp(ax, memw[ds, edx + 8]);           /* cmp ax, [edx+0x8] */
            ii(0x1009_9ad6, 6);  if(jl(0x1009_9b7f, 0xa3)) goto l_0x1009_9b7f;/* jl 0x10099b7f */
            ii(0x1009_9adc, 3);  lea(ebx, memd[ss, ebp - 8]);          /* lea ebx, [ebp-0x8] */
            ii(0x1009_9adf, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1009_9ae1, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_9ae4, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x1009_9ae7, 5);  call(0x1009_c3c0, 0x28d4);            /* call 0x1009c3c0 */
            ii(0x1009_9aec, 5);  call(0x1009_6a12, -0x30df);           /* call 0x10096a12 */
            ii(0x1009_9af1, 2);  test(al, al);                         /* test al, al */
            ii(0x1009_9af3, 6);  if(jz(0x1009_9b7f, 0x86)) goto l_0x1009_9b7f;/* jz 0x10099b7f */
            ii(0x1009_9af9, 5);  mov(eax, 0x35);                       /* mov eax, 0x35 */
            ii(0x1009_9afe, 5);  call(Definitions.sys_new, 0xc_c2fd);  /* call 0x10165e00 */
            ii(0x1009_9b03, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1009_9b06, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1009_9b09, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1009_9b0c, 4);  cmp(memd[ss, ebp - 16], 0);           /* cmp dword [ebp-0x10], 0x0 */
            ii(0x1009_9b10, 2);  if(jz(0x1009_9b4a, 0x38)) goto l_0x1009_9b4a;/* jz 0x10099b4a */
            ii(0x1009_9b12, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_9b15, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x1009_9b18, 5);  call(0x1009_c41c, 0x28ff);            /* call 0x1009c41c */
            ii(0x1009_9b1d, 1);  push(eax);                            /* push eax */
            ii(0x1009_9b1e, 3);  lea(edx, memd[ss, ebp - 8]);          /* lea edx, [ebp-0x8] */
            ii(0x1009_9b21, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1009_9b24, 5);  call(0x1007_5e64, -0x2_3cc5);         /* call 0x10075e64 */
            ii(0x1009_9b29, 1);  push(eax);                            /* push eax */
            ii(0x1009_9b2a, 5);  mov(ecx, 5);                          /* mov ecx, 0x5 */
            ii(0x1009_9b2f, 5);  mov(ebx, 0xd00);                      /* mov ebx, 0xd00 */
            ii(0x1009_9b34, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1009_9b37, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1009_9b3a, 5);  call(0x1008_c999, -0xd1a6);           /* call 0x1008c999 */
            ii(0x1009_9b3f, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1009_9b42, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1009_9b45, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1009_9b48, 2);  jmp(0x1009_9b50, 6); goto l_0x1009_9b50;/* jmp 0x10099b50 */
        l_0x1009_9b4a:
            ii(0x1009_9b4a, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_9b4d, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
        l_0x1009_9b50:
            ii(0x1009_9b50, 3);  mov(edx, memd[ss, ebp - 28]);         /* mov edx, [ebp-0x1c] */
            ii(0x1009_9b53, 3);  lea(eax, memd[ss, ebp - 32]);         /* lea eax, [ebp-0x20] */
            ii(0x1009_9b56, 5);  call(0x1009_c7e0, 0x2c85);            /* call 0x1009c7e0 */
            ii(0x1009_9b5b, 3);  lea(eax, memd[ss, ebp - 32]);         /* lea eax, [ebp-0x20] */
            ii(0x1009_9b5e, 5);  call(0x1009_c73c, 0x2bd9);            /* call 0x1009c73c */
            ii(0x1009_9b63, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1009_9b65, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_9b68, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x1009_9b6b, 5);  call(0x1009_c3c0, 0x2850);            /* call 0x1009c3c0 */
            ii(0x1009_9b70, 5);  call(0x1009_350b, -0x666a);           /* call 0x1009350b */
            ii(0x1009_9b75, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1009_9b77, 3);  lea(eax, memd[ss, ebp - 32]);         /* lea eax, [ebp-0x20] */
            ii(0x1009_9b7a, 5);  call(0x1009_b9ec, 0x1e6d);            /* call 0x1009b9ec */
        l_0x1009_9b7f:
            ii(0x1009_9b7f, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1009_9b81, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1009_9b82, 1);  pop(edi);                             /* pop edi */
            ii(0x1009_9b83, 1);  pop(esi);                             /* pop esi */
            ii(0x1009_9b84, 1);  pop(edx);                             /* pop edx */
            ii(0x1009_9b85, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1009_9b86, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1009_9b87, 1);  ret();                                /* ret */
        }
    }
}
