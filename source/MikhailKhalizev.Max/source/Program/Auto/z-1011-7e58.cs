using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_7e58-8384eda0")]
        public void Method_1011_7e58()
        {
            ii(0x1011_7e58, 5);  push(0x3c);                           /* push 0x3c */
            ii(0x1011_7e5d, 5);  call(Definitions.sys_check_available_stack_size, 0x4_def0);/* call 0x10165d52 */
            ii(0x1011_7e62, 1);  push(ebx);                            /* push ebx */
            ii(0x1011_7e63, 1);  push(ecx);                            /* push ecx */
            ii(0x1011_7e64, 1);  push(edx);                            /* push edx */
            ii(0x1011_7e65, 1);  push(esi);                            /* push esi */
            ii(0x1011_7e66, 1);  push(edi);                            /* push edi */
            ii(0x1011_7e67, 1);  push(ebp);                            /* push ebp */
            ii(0x1011_7e68, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1011_7e6a, 6);  sub(esp, 0x20);                       /* sub esp, 0x20 */
            ii(0x1011_7e70, 5);  mov(eax, 0x101b_af94);                /* mov eax, 0x101baf94 */
            ii(0x1011_7e75, 5);  call(/* sys */ 0x1016_611f, 0x4_e2a5);/* call 0x1016611f */
            ii(0x1011_7e7a, 5);  mov(ecx, 0x1011_9dde);                /* mov ecx, 0x10119dde */
            ii(0x1011_7e7f, 5);  mov(ebx, 0x101c_52fe);                /* mov ebx, 0x101c52fe */
            ii(0x1011_7e84, 5);  mov(edx, StringDefinitions.Airpath);  /* mov edx, 0x101a7bcc */
            ii(0x1011_7e89, 5);  mov(eax, 0x101c_5300);                /* mov eax, 0x101c5300 */
            ii(0x1011_7e8e, 5);  call(0x1013_b77c, 0x2_38e9);          /* call 0x1013b77c */
            ii(0x1011_7e93, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x1011_7e96, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x1011_7e99, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1011_7e9c, 10);  mov(memd[ds, 0x101b_af9c], 1);       /* mov dword [0x101baf9c], 0x1 */
            ii(0x1011_7ea6, 5);  mov(ecx, 0x1011_b9e1);                /* mov ecx, 0x1011b9e1 */
            ii(0x1011_7eab, 5);  mov(ebx, 0x101c_5316);                /* mov ebx, 0x101c5316 */
            ii(0x1011_7eb0, 5);  mov(edx, StringDefinitions.Groundpath);/* mov edx, 0x101a7bd4 */
            ii(0x1011_7eb5, 5);  mov(eax, 0x101c_5318);                /* mov eax, 0x101c5318 */
            ii(0x1011_7eba, 5);  call(0x1013_b77c, 0x2_38bd);          /* call 0x1013b77c */
            ii(0x1011_7ebf, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1011_7ec2, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x1011_7ec5, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1011_7ec8, 10);  mov(memd[ds, 0x101b_af9c], 2);       /* mov dword [0x101baf9c], 0x2 */
            ii(0x1011_7ed2, 5);  mov(ecx, 0x1011_bd7d);                /* mov ecx, 0x1011bd7d */
            ii(0x1011_7ed7, 5);  mov(ebx, 0x101c_532e);                /* mov ebx, 0x101c532e */
            ii(0x1011_7edc, 5);  mov(edx, StringDefinitions.Builderpath);/* mov edx, 0x101a7bdf */
            ii(0x1011_7ee1, 5);  mov(eax, 0x101c_5330);                /* mov eax, 0x101c5330 */
            ii(0x1011_7ee6, 5);  call(0x1013_b77c, 0x2_3891);          /* call 0x1013b77c */
            ii(0x1011_7eeb, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1011_7eee, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1011_7ef1, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1011_7ef4, 10);  mov(memd[ds, 0x101b_af9c], 3);       /* mov dword [0x101baf9c], 0x3 */
            ii(0x1011_7efe, 5);  mov(ebx, 0xffff_ffff);                /* mov ebx, 0xffffffff */
            ii(0x1011_7f03, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1011_7f05, 5);  mov(eax, 0x101c_5348);                /* mov eax, 0x101c5348 */
            ii(0x1011_7f0a, 5);  call(0x1007_6aac, -0xa_1463);         /* call 0x10076aac */
            ii(0x1011_7f0f, 5);  mov(ebx, 0xffff_ffff);                /* mov ebx, 0xffffffff */
            ii(0x1011_7f14, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x1011_7f19, 5);  mov(eax, 0x101c_534c);                /* mov eax, 0x101c534c */
            ii(0x1011_7f1e, 5);  call(0x1007_6aac, -0xa_1477);         /* call 0x10076aac */
            ii(0x1011_7f23, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x1011_7f25, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x1011_7f2a, 5);  mov(eax, 0x101c_5350);                /* mov eax, 0x101c5350 */
            ii(0x1011_7f2f, 5);  call(0x1007_6aac, -0xa_1488);         /* call 0x10076aac */
            ii(0x1011_7f34, 5);  mov(ebx, 1);                          /* mov ebx, 0x1 */
            ii(0x1011_7f39, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x1011_7f3e, 5);  mov(eax, 0x101c_5354);                /* mov eax, 0x101c5354 */
            ii(0x1011_7f43, 5);  call(0x1007_6aac, -0xa_149c);         /* call 0x10076aac */
            ii(0x1011_7f48, 5);  mov(ebx, 1);                          /* mov ebx, 0x1 */
            ii(0x1011_7f4d, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1011_7f4f, 5);  mov(eax, 0x101c_5358);                /* mov eax, 0x101c5358 */
            ii(0x1011_7f54, 5);  call(0x1007_6aac, -0xa_14ad);         /* call 0x10076aac */
            ii(0x1011_7f59, 5);  mov(ebx, 1);                          /* mov ebx, 0x1 */
            ii(0x1011_7f5e, 5);  mov(edx, 0xffff_ffff);                /* mov edx, 0xffffffff */
            ii(0x1011_7f63, 5);  mov(eax, 0x101c_535c);                /* mov eax, 0x101c535c */
            ii(0x1011_7f68, 5);  call(0x1007_6aac, -0xa_14c1);         /* call 0x10076aac */
            ii(0x1011_7f6d, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x1011_7f6f, 5);  mov(edx, 0xffff_ffff);                /* mov edx, 0xffffffff */
            ii(0x1011_7f74, 5);  mov(eax, 0x101c_5360);                /* mov eax, 0x101c5360 */
            ii(0x1011_7f79, 5);  call(0x1007_6aac, -0xa_14d2);         /* call 0x10076aac */
            ii(0x1011_7f7e, 5);  mov(ebx, 0xffff_ffff);                /* mov ebx, 0xffffffff */
            ii(0x1011_7f83, 5);  mov(edx, 0xffff_ffff);                /* mov edx, 0xffffffff */
            ii(0x1011_7f88, 5);  mov(eax, 0x101c_5364);                /* mov eax, 0x101c5364 */
            ii(0x1011_7f8d, 5);  call(0x1007_6aac, -0xa_14e6);         /* call 0x10076aac */
            ii(0x1011_7f92, 5);  mov(eax, 0x101c_536c);                /* mov eax, 0x101c536c */
            ii(0x1011_7f97, 5);  call(0x1011_dbe9, 0x5c4d);            /* call 0x1011dbe9 */
            ii(0x1011_7f9c, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1011_7f9f, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1011_7fa2, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1011_7fa5, 10);  mov(memd[ds, 0x101b_af9c], 4);       /* mov dword [0x101baf9c], 0x4 */
            ii(0x1011_7faf, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1011_7fb1, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1011_7fb2, 1);  pop(edi);                             /* pop edi */
            ii(0x1011_7fb3, 1);  pop(esi);                             /* pop esi */
            ii(0x1011_7fb4, 1);  pop(edx);                             /* pop edx */
            ii(0x1011_7fb5, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1011_7fb6, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1011_7fb7, 1);  ret();                                /* ret */
        }
    }
}
